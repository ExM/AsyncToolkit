using System.Collections.Generic;
using System.Text;
using System.Asynchrony;

namespace System.IO
{
	public static class StreamExtensions
	{
		public static void AsyncWrite(this Stream dest, string text, Action<Exception> completed)
		{
			AsyncWrite(dest, text, Encoding.UTF8, completed);
		}

		public static void AsyncWrite(this Stream dest, string text, Encoding encode, Action<Exception> completed)
		{
			byte[] buff = encode.GetBytes(text);
			AsyncWrite(dest, buff, completed);
		}

		public static void AsyncWrite(this Stream dest, byte[] buff, Action<Exception> completed)
		{
			dest.BeginWrite(buff, 0, buff.Length, (ar) =>
			{
				try
				{
					dest.EndWrite(ar);
					completed(null);
				}
				catch (SystemException err)
				{
					completed(err);
				}
			}, null);
		}

		public static void AsyncRead(this Stream source, Action<Exception, string> completed)
		{
			AsyncRead(source, Encoding.UTF8, completed);
		}

		public static void AsyncRead(this Stream source, Encoding encode, Action<Exception, string> completed)
		{
			new CopyStreamContext(source, 0x1000, Async.Complete<byte[]>(
				(buff) => completed(null, encode.GetString(buff)), (ex) => completed(ex, null)));
		}

		public static void AsyncRead(this Stream source, Action<Exception, byte[]> completed)
		{
			new CopyStreamContext(source, 0x1000, completed);
		}

		private class CopyStreamContext
		{
			private readonly int _partLenght;
			private long _totalBytes = 0;
			private List<byte[]> _buffers = new List<byte[]>();
			private byte[] _buffer;
			private Stream _src = null;
			private Action<Exception, byte[]> _completed = null;

			public CopyStreamContext(Stream source, int partLenght, Action<Exception, byte[]> completed)
			{
				_partLenght = partLenght;
				_buffer = new byte[_partLenght];

				_src = source;
				_completed = completed;

				_src.BeginRead(_buffer, 0, _partLenght, OnRead, null);
			}

			private void OnRead(IAsyncResult readResult)
			{
				try
				{
					int read = _src.EndRead(readResult);
					if (read > 0)
					{
						byte[] copy = new byte[read];
						Array.Copy(_buffer, copy, read);
						_totalBytes += read;
						_buffers.Add(copy);
						_src.BeginRead(_buffer, 0, _partLenght, OnRead, null);
					}
					else
					{
						byte[] result = new byte[_totalBytes];
						int offset = 0;
						int N = _buffers.Count;
						for (int i = 0; i < N; i++)
						{
							byte[] cur = _buffers[i];
							Array.Copy(cur, 0, result, offset, cur.Length);
							offset += cur.Length;
						}

						_completed(null, result);
					}
				}
				catch (Exception exc)
				{
					_completed(exc, null);
				}
			}
		}
	}
}
