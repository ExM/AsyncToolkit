using System;

namespace System.Asynchrony
{
	
	public class Task : ITask
	{
		private Action _action;
		
		public Task(Action action)
		{
			_action = action;
		}

		public void Run()
		{
			_action();
		}

		public void Run(object arg)
		{
			_action();
		}

		public static Task Create(Action action)
		{
			return new Task(action);
		}
		
		public static Task<T1> Create<T1>(
			Action<T1> action,
			T1 arg1)
		{
			return new Task<T1>(action,
				arg1);
		}
		
		public static Task<T1, T2> Create<T1, T2>(
			Action<T1, T2> action,
			T1 arg1, T2 arg2)
		{
			return new Task<T1, T2>(action,
				arg1, arg2);
		}
		
		public static Task<T1, T2, T3> Create<T1, T2, T3>(
			Action<T1, T2, T3> action,
			T1 arg1, T2 arg2, T3 arg3)
		{
			return new Task<T1, T2, T3>(action,
				arg1, arg2, arg3);
		}
		
		public static Task<T1, T2, T3, T4> Create<T1, T2, T3, T4>(
			Action<T1, T2, T3, T4> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			return new Task<T1, T2, T3, T4>(action,
				arg1, arg2, arg3, arg4);
		}
		
		public static Task<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(
			Action<T1, T2, T3, T4, T5> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
			return new Task<T1, T2, T3, T4, T5>(action,
				arg1, arg2, arg3, arg4, arg5);
		}
		
		public static Task<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(
			Action<T1, T2, T3, T4, T5, T6> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
			return new Task<T1, T2, T3, T4, T5, T6>(action,
				arg1, arg2, arg3, arg4, arg5, arg6);
		}
		
		public static Task<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(
			Action<T1, T2, T3, T4, T5, T6, T7> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
			return new Task<T1, T2, T3, T4, T5, T6, T7>(action,
				arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		}
		
		public static Task<T1, T2, T3, T4, T5, T6, T7, T8> Create<T1, T2, T3, T4, T5, T6, T7, T8>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
			return new Task<T1, T2, T3, T4, T5, T6, T7, T8>(action,
				arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		}
		
		public static Task<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
			return new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9>(action,
				arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		}
		
		public static Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
			return new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(action,
				arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
		}
		
		public static Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
			return new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(action,
				arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
		}
		
		public static Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
			return new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(action,
				arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
		}
		
		public static Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
			return new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(action,
				arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
		}
		
		public static Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
			return new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(action,
				arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
		}
		
		public static Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
		{
			return new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(action,
				arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
		}
		
		public static Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
			Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
		{
			return new Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(action,
				arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
		}
	}
		
	public class Task<T1> : ITask
	{
		private Action<T1> _action;
		private T1 _arg1;

		public Task(Action<T1> action,
			T1 arg1)
		{
			_action = action;
			_arg1 = arg1;
		}

		public void Run()
		{
			_action(_arg1);
		}

		public void Run(object arg)
		{
			_action(_arg1);
		}
	}
		
	public class Task<T1, T2> : ITask
	{
		private Action<T1, T2> _action;
		private T1 _arg1;
		private T2 _arg2;

		public Task(Action<T1, T2> action,
			T1 arg1, T2 arg2)
		{
			_action = action;
			_arg1 = arg1;
			_arg2 = arg2;
		}

		public void Run()
		{
			_action(_arg1, _arg2);
		}

		public void Run(object arg)
		{
			_action(_arg1, _arg2);
		}
	}
		
	public class Task<T1, T2, T3> : ITask
	{
		private Action<T1, T2, T3> _action;
		private T1 _arg1;
		private T2 _arg2;
		private T3 _arg3;

		public Task(Action<T1, T2, T3> action,
			T1 arg1, T2 arg2, T3 arg3)
		{
			_action = action;
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
		}

		public void Run()
		{
			_action(_arg1, _arg2, _arg3);
		}

		public void Run(object arg)
		{
			_action(_arg1, _arg2, _arg3);
		}
	}
		
	public class Task<T1, T2, T3, T4> : ITask
	{
		private Action<T1, T2, T3, T4> _action;
		private T1 _arg1;
		private T2 _arg2;
		private T3 _arg3;
		private T4 _arg4;

		public Task(Action<T1, T2, T3, T4> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			_action = action;
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
		}

		public void Run()
		{
			_action(_arg1, _arg2, _arg3, _arg4);
		}

		public void Run(object arg)
		{
			_action(_arg1, _arg2, _arg3, _arg4);
		}
	}
		
	public class Task<T1, T2, T3, T4, T5> : ITask
	{
		private Action<T1, T2, T3, T4, T5> _action;
		private T1 _arg1;
		private T2 _arg2;
		private T3 _arg3;
		private T4 _arg4;
		private T5 _arg5;

		public Task(Action<T1, T2, T3, T4, T5> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
			_action = action;
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
		}

		public void Run()
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5);
		}

		public void Run(object arg)
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5);
		}
	}
		
	public class Task<T1, T2, T3, T4, T5, T6> : ITask
	{
		private Action<T1, T2, T3, T4, T5, T6> _action;
		private T1 _arg1;
		private T2 _arg2;
		private T3 _arg3;
		private T4 _arg4;
		private T5 _arg5;
		private T6 _arg6;

		public Task(Action<T1, T2, T3, T4, T5, T6> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
			_action = action;
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
		}

		public void Run()
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		public void Run(object arg)
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}
	}
		
	public class Task<T1, T2, T3, T4, T5, T6, T7> : ITask
	{
		private Action<T1, T2, T3, T4, T5, T6, T7> _action;
		private T1 _arg1;
		private T2 _arg2;
		private T3 _arg3;
		private T4 _arg4;
		private T5 _arg5;
		private T6 _arg6;
		private T7 _arg7;

		public Task(Action<T1, T2, T3, T4, T5, T6, T7> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
			_action = action;
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
			_arg7 = arg7;
		}

		public void Run()
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7);
		}

		public void Run(object arg)
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7);
		}
	}
		
	public class Task<T1, T2, T3, T4, T5, T6, T7, T8> : ITask
	{
		private Action<T1, T2, T3, T4, T5, T6, T7, T8> _action;
		private T1 _arg1;
		private T2 _arg2;
		private T3 _arg3;
		private T4 _arg4;
		private T5 _arg5;
		private T6 _arg6;
		private T7 _arg7;
		private T8 _arg8;

		public Task(Action<T1, T2, T3, T4, T5, T6, T7, T8> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
			_action = action;
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
			_arg7 = arg7;
			_arg8 = arg8;
		}

		public void Run()
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8);
		}

		public void Run(object arg)
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8);
		}
	}
		
	public class Task<T1, T2, T3, T4, T5, T6, T7, T8, T9> : ITask
	{
		private Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> _action;
		private T1 _arg1;
		private T2 _arg2;
		private T3 _arg3;
		private T4 _arg4;
		private T5 _arg5;
		private T6 _arg6;
		private T7 _arg7;
		private T8 _arg8;
		private T9 _arg9;

		public Task(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
			_action = action;
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
			_arg7 = arg7;
			_arg8 = arg8;
			_arg9 = arg9;
		}

		public void Run()
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9);
		}

		public void Run(object arg)
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9);
		}
	}
		
	public class Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : ITask
	{
		private Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _action;
		private T1 _arg1;
		private T2 _arg2;
		private T3 _arg3;
		private T4 _arg4;
		private T5 _arg5;
		private T6 _arg6;
		private T7 _arg7;
		private T8 _arg8;
		private T9 _arg9;
		private T10 _arg10;

		public Task(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
			_action = action;
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
			_arg7 = arg7;
			_arg8 = arg8;
			_arg9 = arg9;
			_arg10 = arg10;
		}

		public void Run()
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10);
		}

		public void Run(object arg)
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10);
		}
	}
		
	public class Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : ITask
	{
		private Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _action;
		private T1 _arg1;
		private T2 _arg2;
		private T3 _arg3;
		private T4 _arg4;
		private T5 _arg5;
		private T6 _arg6;
		private T7 _arg7;
		private T8 _arg8;
		private T9 _arg9;
		private T10 _arg10;
		private T11 _arg11;

		public Task(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
			_action = action;
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
			_arg7 = arg7;
			_arg8 = arg8;
			_arg9 = arg9;
			_arg10 = arg10;
			_arg11 = arg11;
		}

		public void Run()
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11);
		}

		public void Run(object arg)
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11);
		}
	}
		
	public class Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : ITask
	{
		private Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _action;
		private T1 _arg1;
		private T2 _arg2;
		private T3 _arg3;
		private T4 _arg4;
		private T5 _arg5;
		private T6 _arg6;
		private T7 _arg7;
		private T8 _arg8;
		private T9 _arg9;
		private T10 _arg10;
		private T11 _arg11;
		private T12 _arg12;

		public Task(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
			_action = action;
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
			_arg7 = arg7;
			_arg8 = arg8;
			_arg9 = arg9;
			_arg10 = arg10;
			_arg11 = arg11;
			_arg12 = arg12;
		}

		public void Run()
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11, _arg12);
		}

		public void Run(object arg)
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11, _arg12);
		}
	}
		
	public class Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : ITask
	{
		private Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _action;
		private T1 _arg1;
		private T2 _arg2;
		private T3 _arg3;
		private T4 _arg4;
		private T5 _arg5;
		private T6 _arg6;
		private T7 _arg7;
		private T8 _arg8;
		private T9 _arg9;
		private T10 _arg10;
		private T11 _arg11;
		private T12 _arg12;
		private T13 _arg13;

		public Task(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
			_action = action;
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
			_arg7 = arg7;
			_arg8 = arg8;
			_arg9 = arg9;
			_arg10 = arg10;
			_arg11 = arg11;
			_arg12 = arg12;
			_arg13 = arg13;
		}

		public void Run()
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11, _arg12, _arg13);
		}

		public void Run(object arg)
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11, _arg12, _arg13);
		}
	}
		
	public class Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : ITask
	{
		private Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _action;
		private T1 _arg1;
		private T2 _arg2;
		private T3 _arg3;
		private T4 _arg4;
		private T5 _arg5;
		private T6 _arg6;
		private T7 _arg7;
		private T8 _arg8;
		private T9 _arg9;
		private T10 _arg10;
		private T11 _arg11;
		private T12 _arg12;
		private T13 _arg13;
		private T14 _arg14;

		public Task(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
			_action = action;
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
			_arg7 = arg7;
			_arg8 = arg8;
			_arg9 = arg9;
			_arg10 = arg10;
			_arg11 = arg11;
			_arg12 = arg12;
			_arg13 = arg13;
			_arg14 = arg14;
		}

		public void Run()
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11, _arg12, _arg13, _arg14);
		}

		public void Run(object arg)
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11, _arg12, _arg13, _arg14);
		}
	}
		
	public class Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : ITask
	{
		private Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _action;
		private T1 _arg1;
		private T2 _arg2;
		private T3 _arg3;
		private T4 _arg4;
		private T5 _arg5;
		private T6 _arg6;
		private T7 _arg7;
		private T8 _arg8;
		private T9 _arg9;
		private T10 _arg10;
		private T11 _arg11;
		private T12 _arg12;
		private T13 _arg13;
		private T14 _arg14;
		private T15 _arg15;

		public Task(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
		{
			_action = action;
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
			_arg7 = arg7;
			_arg8 = arg8;
			_arg9 = arg9;
			_arg10 = arg10;
			_arg11 = arg11;
			_arg12 = arg12;
			_arg13 = arg13;
			_arg14 = arg14;
			_arg15 = arg15;
		}

		public void Run()
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11, _arg12, _arg13, _arg14, _arg15);
		}

		public void Run(object arg)
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11, _arg12, _arg13, _arg14, _arg15);
		}
	}
		
	public class Task<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : ITask
	{
		private Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> _action;
		private T1 _arg1;
		private T2 _arg2;
		private T3 _arg3;
		private T4 _arg4;
		private T5 _arg5;
		private T6 _arg6;
		private T7 _arg7;
		private T8 _arg8;
		private T9 _arg9;
		private T10 _arg10;
		private T11 _arg11;
		private T12 _arg12;
		private T13 _arg13;
		private T14 _arg14;
		private T15 _arg15;
		private T16 _arg16;

		public Task(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action,
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
		{
			_action = action;
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
			_arg4 = arg4;
			_arg5 = arg5;
			_arg6 = arg6;
			_arg7 = arg7;
			_arg8 = arg8;
			_arg9 = arg9;
			_arg10 = arg10;
			_arg11 = arg11;
			_arg12 = arg12;
			_arg13 = arg13;
			_arg14 = arg14;
			_arg15 = arg15;
			_arg16 = arg16;
		}

		public void Run()
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11, _arg12, _arg13, _arg14, _arg15, _arg16);
		}

		public void Run(object arg)
		{
			_action(_arg1, _arg2, _arg3, _arg4, _arg5, _arg6, _arg7, _arg8, _arg9, _arg10, _arg11, _arg12, _arg13, _arg14, _arg15, _arg16);
		}
	}
}
