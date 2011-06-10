using System.Collections.Generic;
using System.Text;
using System.Asynchrony;

namespace System.IO
{
	public static class StreamExtensions
	{
		public static void AsyncWrite(this Stream dest, string text, Action completed, Action<Exception> excepted)
		{
			AsyncWrite(dest, text, Encoding.UTF8, completed, excepted);
		}

		public static void AsyncWrite(this Stream dest, string text, Encoding encode, Action completed, Action<Exception> excepted)
		{
			byte[] buff = encode.GetBytes(text);
			AsyncWrite(dest, buff, completed, excepted);
		}

		public static void AsyncWrite(this Stream dest, byte[] buff, Action completed, Action<Exception> excepted)
		{
			dest.BeginWrite(buff, 0, buff.Length, (ar) =>
			{
				try
				{
					dest.EndWrite(ar);
				}
				catch (Exception err)
				{
					excepted(err);
					return;
				}
				completed();
			}, null);
		}

		public static void AsyncRead(this Stream source, Action<string> completed, Action<Exception> excepted)
		{
			new CopyStreamContext(
				source,
				1024,
				(buff) => RExt.Convert(buff, Encoding.UTF8.GetString, completed, excepted),
				excepted);
		}

		public static void AsyncRead(this Stream source, Encoding encode, Action<string> completed, Action<Exception> excepted)
		{
			new CopyStreamContext(
				source,
				1024,
				(buff) => RExt.Convert(buff, encode.GetString, completed, excepted),
				excepted);
		}

		public static void AsyncRead(this Stream source, int partLenght, Action<string> completed, Action<Exception> excepted)
		{
			new CopyStreamContext(
				source,
				partLenght,
				(buff) => RExt.Convert(buff, Encoding.UTF8.GetString, completed, excepted),
				excepted);
		}

		public static void AsyncRead(this Stream source, Action<byte[]> completed, Action<Exception> excepted)
		{
			new CopyStreamContext(source, 0x1000, completed, excepted);
		}

		private class CopyStreamContext
		{
			private readonly int _partLenght;
			private long _totalBytes = 0;
			private List<byte[]> _buffers = new List<byte[]>();
			private byte[] _buffer;
			private Stream _src;
			private Action<byte[]> _completed;
			private Action<Exception> _excepted;

			public CopyStreamContext(Stream source, int partLenght, Action<byte[]> completed, Action<Exception> excepted)
			{
				_partLenght = partLenght;
				_buffer = new byte[_partLenght];

				_src = source;
				_completed = completed;
				_excepted = excepted;

				_src.BeginRead(_buffer, 0, _partLenght, OnRead, null);
			}

			private void OnRead(IAsyncResult readResult)
			{
				byte[] localCopy;

				try
				{
					int read = _src.EndRead(readResult);
					if (read > 0)
					{
						localCopy = new byte[read];
						Array.Copy(_buffer, localCopy, read);
						_totalBytes += read;
						_buffers.Add(localCopy);
						_src.BeginRead(_buffer, 0, _partLenght, OnRead, null);
						return;
					}

					int N = _buffers.Count;

					if (N == 1)
					{
						localCopy = _buffers[0];
					}
					else
					{
						localCopy = new byte[_totalBytes];
						int offset = 0;

						for (int i = 0; i < N; i++)
						{
							byte[] cur = _buffers[i];
							Array.Copy(cur, 0, localCopy, offset, cur.Length);
							offset += cur.Length;
						}
					}
				}
				catch (Exception exc)
				{
					_excepted(exc);
					return;
				}

				_completed(localCopy);
			}
		}
	}
}
