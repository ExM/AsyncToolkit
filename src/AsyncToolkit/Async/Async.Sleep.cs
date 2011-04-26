using System;
using System.Threading;

namespace System.Asynchrony
{
	
	public static partial class Async
	{
		
		public static SleepSticker Sleep<T1>(int timeout,
			Action<bool, T1> action,
			T1 arg1)
		{
			ManualResetEvent wait = new ManualResetEvent(false);
			RegisteredWaitHandle handle = null;
			handle = ThreadPool.RegisterWaitForSingleObject(wait, (object state, bool timedOut) =>
			{
				handle.Unregister(wait);
				action(timedOut, arg1);
			}, null, timeout, true);
			return new SleepSticker(wait);
		}
		
		public static SleepSticker Sleep<T1, T2>(int timeout,
			Action<bool, T1, T2> action,
			T1 arg1, T2 arg2)
		{
			ManualResetEvent wait = new ManualResetEvent(false);
			RegisteredWaitHandle handle = null;
			handle = ThreadPool.RegisterWaitForSingleObject(wait, (object state, bool timedOut) =>
			{
				handle.Unregister(wait);
				action(timedOut, arg1, arg2);
			}, null, timeout, true);
			return new SleepSticker(wait);
		}
		
		public static SleepSticker Sleep<T1, T2, T3>(int timeout,
			Action<bool, T1, T2, T3> action,
			T1 arg1, T2 arg2, T3 arg3)
		{
			ManualResetEvent wait = new ManualResetEvent(false);
			RegisteredWaitHandle handle = null;
			handle = ThreadPool.RegisterWaitForSingleObject(wait, (object state, bool timedOut) =>
			{
				handle.Unregister(wait);
				action(timedOut, arg1, arg2, arg3);
			}, null, timeout, true);
			return new SleepSticker(wait);
		}
		
		public static SleepSticker Sleep<T1, T2, T3, T4>(int timeout,
			Action<bool, T1, T2, T3, T4> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			ManualResetEvent wait = new ManualResetEvent(false);
			RegisteredWaitHandle handle = null;
			handle = ThreadPool.RegisterWaitForSingleObject(wait, (object state, bool timedOut) =>
			{
				handle.Unregister(wait);
				action(timedOut, arg1, arg2, arg3, arg4);
			}, null, timeout, true);
			return new SleepSticker(wait);
		}
		
		public static SleepSticker Sleep<T1, T2, T3, T4, T5>(int timeout,
			Action<bool, T1, T2, T3, T4, T5> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
			ManualResetEvent wait = new ManualResetEvent(false);
			RegisteredWaitHandle handle = null;
			handle = ThreadPool.RegisterWaitForSingleObject(wait, (object state, bool timedOut) =>
			{
				handle.Unregister(wait);
				action(timedOut, arg1, arg2, arg3, arg4, arg5);
			}, null, timeout, true);
			return new SleepSticker(wait);
		}
		
		public static SleepSticker Sleep<T1, T2, T3, T4, T5, T6>(int timeout,
			Action<bool, T1, T2, T3, T4, T5, T6> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
			ManualResetEvent wait = new ManualResetEvent(false);
			RegisteredWaitHandle handle = null;
			handle = ThreadPool.RegisterWaitForSingleObject(wait, (object state, bool timedOut) =>
			{
				handle.Unregister(wait);
				action(timedOut, arg1, arg2, arg3, arg4, arg5, arg6);
			}, null, timeout, true);
			return new SleepSticker(wait);
		}
		
		public static SleepSticker Sleep<T1, T2, T3, T4, T5, T6, T7>(int timeout,
			Action<bool, T1, T2, T3, T4, T5, T6, T7> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
			ManualResetEvent wait = new ManualResetEvent(false);
			RegisteredWaitHandle handle = null;
			handle = ThreadPool.RegisterWaitForSingleObject(wait, (object state, bool timedOut) =>
			{
				handle.Unregister(wait);
				action(timedOut, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
			}, null, timeout, true);
			return new SleepSticker(wait);
		}
		
		public static SleepSticker Sleep<T1, T2, T3, T4, T5, T6, T7, T8>(int timeout,
			Action<bool, T1, T2, T3, T4, T5, T6, T7, T8> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
			ManualResetEvent wait = new ManualResetEvent(false);
			RegisteredWaitHandle handle = null;
			handle = ThreadPool.RegisterWaitForSingleObject(wait, (object state, bool timedOut) =>
			{
				handle.Unregister(wait);
				action(timedOut, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			}, null, timeout, true);
			return new SleepSticker(wait);
		}
		
		public static SleepSticker Sleep<T1, T2, T3, T4, T5, T6, T7, T8, T9>(int timeout,
			Action<bool, T1, T2, T3, T4, T5, T6, T7, T8, T9> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
			ManualResetEvent wait = new ManualResetEvent(false);
			RegisteredWaitHandle handle = null;
			handle = ThreadPool.RegisterWaitForSingleObject(wait, (object state, bool timedOut) =>
			{
				handle.Unregister(wait);
				action(timedOut, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
			}, null, timeout, true);
			return new SleepSticker(wait);
		}
		
		public static SleepSticker Sleep<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int timeout,
			Action<bool, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
			ManualResetEvent wait = new ManualResetEvent(false);
			RegisteredWaitHandle handle = null;
			handle = ThreadPool.RegisterWaitForSingleObject(wait, (object state, bool timedOut) =>
			{
				handle.Unregister(wait);
				action(timedOut, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
			}, null, timeout, true);
			return new SleepSticker(wait);
		}
		
		public static SleepSticker Sleep<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int timeout,
			Action<bool, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
			ManualResetEvent wait = new ManualResetEvent(false);
			RegisteredWaitHandle handle = null;
			handle = ThreadPool.RegisterWaitForSingleObject(wait, (object state, bool timedOut) =>
			{
				handle.Unregister(wait);
				action(timedOut, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
			}, null, timeout, true);
			return new SleepSticker(wait);
		}
		
		public static SleepSticker Sleep<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int timeout,
			Action<bool, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
			ManualResetEvent wait = new ManualResetEvent(false);
			RegisteredWaitHandle handle = null;
			handle = ThreadPool.RegisterWaitForSingleObject(wait, (object state, bool timedOut) =>
			{
				handle.Unregister(wait);
				action(timedOut, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
			}, null, timeout, true);
			return new SleepSticker(wait);
		}
		
		public static SleepSticker Sleep<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int timeout,
			Action<bool, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
			ManualResetEvent wait = new ManualResetEvent(false);
			RegisteredWaitHandle handle = null;
			handle = ThreadPool.RegisterWaitForSingleObject(wait, (object state, bool timedOut) =>
			{
				handle.Unregister(wait);
				action(timedOut, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
			}, null, timeout, true);
			return new SleepSticker(wait);
		}
		
		public static SleepSticker Sleep<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int timeout,
			Action<bool, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
			ManualResetEvent wait = new ManualResetEvent(false);
			RegisteredWaitHandle handle = null;
			handle = ThreadPool.RegisterWaitForSingleObject(wait, (object state, bool timedOut) =>
			{
				handle.Unregister(wait);
				action(timedOut, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
			}, null, timeout, true);
			return new SleepSticker(wait);
		}
		
		public static SleepSticker Sleep<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int timeout,
			Action<bool, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
		{
			ManualResetEvent wait = new ManualResetEvent(false);
			RegisteredWaitHandle handle = null;
			handle = ThreadPool.RegisterWaitForSingleObject(wait, (object state, bool timedOut) =>
			{
				handle.Unregister(wait);
				action(timedOut, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
			}, null, timeout, true);
			return new SleepSticker(wait);
		}
	}
}
