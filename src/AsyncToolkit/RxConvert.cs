
namespace System.Asynchrony
{
	public static class RxConvert<Tout>
	{
		public static void Convert<T1>(T1 arg1, Func<T1, Tout> converter, Action<Tout> completed, Action<Exception> excepted)
		{
			Tout result;
			try
			{
				result = converter(arg1);
			}
			catch (Exception err)
			{
				excepted(err);
				return;
			}
			completed(result);
		}

		public static void Convert<T1, T2>(T1 arg1, T2 arg2, Func<T1, T2, Tout> converter, Action<Tout> completed, Action<Exception> excepted)
		{
			Tout result;
			try
			{
				result = converter(arg1, arg2);
			}
			catch (Exception err)
			{
				excepted(err);
				return;
			}
			completed(result);
		}
	}
}
