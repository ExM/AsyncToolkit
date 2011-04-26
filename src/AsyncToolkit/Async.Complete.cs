
namespace System.Asynchrony
{
	public static partial class Async
	{
		public static Action<Exception, Ti> Complete<Ti>(Action<Ti> action, Action<Exception> excepted)
		{
			return (err, arg) =>
			{
				if (err != null)
				{
					excepted(err);
					return;
				}

				try
				{
					action(arg);
				}
				catch (SystemException ex)
				{
					excepted(ex);
				}
			};
		}
	}
}
