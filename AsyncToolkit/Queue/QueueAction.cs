using System;
using System.Threading;

namespace System.Asynchrony
{
	public partial class QueueAction
	{
		private QueueTask<ITask> _source;

		public QueueAction()
		{
			_source = new QueueTask<ITask>(OnAction);
		}

		private static void OnAction(ITask item)
		{
			item.Run();
		}

		public void Clear()
		{
			_source.Clear();
		}
	}
}
