using System.Threading;

namespace System.Asynchrony
{
	public class SleepSticker
	{
		private readonly ManualResetEvent _wait;

		public SleepSticker(ManualResetEvent wait)
		{
			_wait = wait;
		}

		public void Abort()
		{
			_wait.Set();
		}
	}
}
