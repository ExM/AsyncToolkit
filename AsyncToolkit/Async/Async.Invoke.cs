using System;
using System.Threading;

namespace System.Asynchrony
{
	
	public static partial class Async
	{
		
		public static void Invoke<T1>(
			Action<T1> action,
			T1 arg1)
		{
			if(action != null)
				ThreadPool.QueueUserWorkItem(new Task<T1>(
					action, arg1).Run);
		}
		
		public static void Invoke<T1, T2>(
			Action<T1, T2> action,
			T1 arg1, T2 arg2)
		{
			if(action != null)
				ThreadPool.QueueUserWorkItem(new Task<T1, T2>(
					action, arg1, arg2).Run);
		}
		
		public static void Invoke<T1, T2, T3>(
			Action<T1, T2, T3> action,
			T1 arg1, T2 arg2, T3 arg3)
		{
			if(action != null)
				ThreadPool.QueueUserWorkItem(new Task<T1, T2, T3>(
					action, arg1, arg2, arg3).Run);
		}
		
		public static void Invoke<T1, T2, T3, T4>(
			Action<T1, T2, T3, T4> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			if(action != null)
				ThreadPool.QueueUserWorkItem(new Task<T1, T2, T3, T4>(
					action, arg1, arg2, arg3, arg4).Run);
		}
		
		public static void Invoke<T1, T2, T3, T4, T5>(
			Action<T1, T2, T3, T4, T5> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
			if(action != null)
				ThreadPool.QueueUserWorkItem(new Task<T1, T2, T3, T4, T5>(
					action, arg1, arg2, arg3, arg4, arg5).Run);
		}
		
		public static void Invoke<T1, T2, T3, T4, T5, T6>(
			Action<T1, T2, T3, T4, T5, T6> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
			if(action != null)
				ThreadPool.QueueUserWorkItem(new Task<T1, T2, T3, T4, T5, T6>(
					action, arg1, arg2, arg3, arg4, arg5, arg6).Run);
		}
		
		public static void Invoke<T1, T2, T3, T4, T5, T6, T7>(
			Action<T1, T2, T3, T4, T5, T6, T7> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
			if(action != null)
				ThreadPool.QueueUserWorkItem(new Task<T1, T2, T3, T4, T5, T6, T7>(
					action, arg1, arg2, arg3, arg4, arg5, arg6, arg7).Run);
		}
		
		public static void Invoke<T1, T2, T3, T4, T5, T6, T7, T8>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
			if(action != null)
				ThreadPool.QueueUserWorkItem(new Task<T1, T2, T3, T4, T5, T6, T7, T8>(
					action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8).Run);
		}
		
		public static void Invoke<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
			if(action != null)
				ThreadPool.QueueUserWorkItem(new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
					action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9).Run);
		}
		
		public static void Invoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
			if(action != null)
				ThreadPool.QueueUserWorkItem(new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
					action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10).Run);
		}
		
		public static void Invoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
			if(action != null)
				ThreadPool.QueueUserWorkItem(new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
					action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11).Run);
		}
		
		public static void Invoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
			if(action != null)
				ThreadPool.QueueUserWorkItem(new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
					action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12).Run);
		}
		
		public static void Invoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
			if(action != null)
				ThreadPool.QueueUserWorkItem(new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
					action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13).Run);
		}
		
		public static void Invoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
			if(action != null)
				ThreadPool.QueueUserWorkItem(new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
					action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14).Run);
		}
		
		public static void Invoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
		{
			if(action != null)
				ThreadPool.QueueUserWorkItem(new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
					action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15).Run);
		}
		
		public static void Invoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
		{
			if(action != null)
				ThreadPool.QueueUserWorkItem(new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
					action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16).Run);
		}
	}
}
