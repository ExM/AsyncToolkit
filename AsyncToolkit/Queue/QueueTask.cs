using System.Collections.Generic;
using System.Threading;

namespace System.Asynchrony
{
	public class QueueTask<T>
	{
		private object _sync = new object();
		private bool _threadExited = true;
		private Queue<T> _queue = new Queue<T>();
		private Action<T> _action;

		public QueueTask(Action<T> action)
		{
			if (action == null)
				throw new ArgumentNullException("action");
			_action = action;
		}

		public void Add(T task)
		{
			lock (_sync)
			{
				_queue.Enqueue(task);
				if (!_threadExited)
					return;
				_threadExited = false;
			}
			ThreadPool.QueueUserWorkItem(Work);
		}

		private void Work(object state)
		{
			while (true)
			{
				T task;
				lock (_sync)
				{
					if (_queue.Count == 0)
					{
						_threadExited = true;
						return;
					}
					task = _queue.Dequeue();
				}
				_action(task);
			}
		}

		public void Clear()
		{
			lock (_sync)
				_queue.Clear();
		}
	}
}
