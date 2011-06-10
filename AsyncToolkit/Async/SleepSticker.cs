using System.Threading;

namespace System.Asynchrony
{
	public class SleepSticker
	{
		internal readonly ManualResetEvent Wait;

		public SleepSticker(ManualResetEvent wait)
		{
			Wait = wait;
		}

		public void Abort()
		{
			Wait.Set();
		}
	}
}
