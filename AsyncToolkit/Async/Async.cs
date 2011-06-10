using System;
using System.Threading;

namespace System.Asynchrony
{
	public static partial class Async
	{
		public static void Invoke(Action action)
		{
			ThreadPool.QueueUserWorkItem(new Task(action).Run);
		}

		public static void Sleep(SleepSticker ss, int timeout, Action<bool> action)
		{
			RegisteredWaitHandle handle = null;
			handle = ThreadPool.RegisterWaitForSingleObject(ss.Wait, (object state, bool timedOut) =>
			{
				handle.Unregister(ss.Wait);
				action(timedOut);
			}, null, timeout, true);
		}

		public static SleepSticker Sleep(int timeout, Action<bool> action)
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
