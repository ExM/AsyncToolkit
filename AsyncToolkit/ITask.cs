
namespace System.Asynchrony
{
	public interface ITask
	{
		void Run();
		void Run(object arg);
	}
}
