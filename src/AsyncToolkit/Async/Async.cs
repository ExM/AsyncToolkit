using System;
using System.Threading;

namespace System.Asynchrony
{
	public static partial class Async
	{
		public static void AsyncInvoke(Action action)
		{
			ThreadPool.QueueUserWorkItem(new Task(action).Run);
		}

		public static SleepSticker AsyncSleep(int timeout, Action<bool> action)
		{
			ManualResetEvent wait = new ManualResetEvent(false);
			RegisteredWaitHandle handle = null;
			handle = ThreadPool.RegisterWaitForSingleObject(wait, (object state, bool timedOut) =>
			{
				handle.Unregister(wait);
				action(timedOut);
			}, null, timeout, true);
			return new SleepSticker(wait);
		}
	}
}
