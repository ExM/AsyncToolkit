using System;

namespace System.Asynchrony
{
	public partial class QueueAction
	{
		public void Add(Action action)
		{
			_source.Add(new Task(action));
		}
		
		public void Add<T1>(
			Action<T1> action,
			T1 arg1)
		{
			_source.Add(new Task<T1>(
				action, arg1));
		}
		
		public void Add<T1, T2>(
			Action<T1, T2> action,
			T1 arg1, T2 arg2)
		{
			_source.Add(new Task<T1, T2>(
				action, arg1, arg2));
		}
		
		public void Add<T1, T2, T3>(
			Action<T1, T2, T3> action,
			T1 arg1, T2 arg2, T3 arg3)
		{
			_source.Add(new Task<T1, T2, T3>(
				action, arg1, arg2, arg3));
		}
		
		public void Add<T1, T2, T3, T4>(
			Action<T1, T2, T3, T4> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			_source.Add(new Task<T1, T2, T3, T4>(
				action, arg1, arg2, arg3, arg4));
		}
		
		public void Add<T1, T2, T3, T4, T5>(
			Action<T1, T2, T3, T4, T5> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
			_source.Add(new Task<T1, T2, T3, T4, T5>(
				action, arg1, arg2, arg3, arg4, arg5));
		}
		
		public void Add<T1, T2, T3, T4, T5, T6>(
			Action<T1, T2, T3, T4, T5, T6> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
			_source.Add(new Task<T1, T2, T3, T4, T5, T6>(
				action, arg1, arg2, arg3, arg4, arg5, arg6));
		}
		
		public void Add<T1, T2, T3, T4, T5, T6, T7>(
			Action<T1, T2, T3, T4, T5, T6, T7> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
			_source.Add(new Task<T1, T2, T3, T4, T5, T6, T7>(
				action, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
		}
		
		public void Add<T1, T2, T3, T4, T5, T6, T7, T8>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
			_source.Add(new Task<T1, T2, T3, T4, T5, T6, T7, T8>(
				action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
		}
		
		public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
			_source.Add(new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
				action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
		}
		
		public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
			_source.Add(new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
				action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
		}
		
		public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
			_source.Add(new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
				action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
		}
		
		public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
			_source.Add(new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
				action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
		}
		
		public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
			_source.Add(new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
				action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
		}
		
		public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
			_source.Add(new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
				action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
		}
		
		public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
		{
			_source.Add(new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
				action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
		}
		
		public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
		{
			_source.Add(new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
				action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
		}
	}
}
