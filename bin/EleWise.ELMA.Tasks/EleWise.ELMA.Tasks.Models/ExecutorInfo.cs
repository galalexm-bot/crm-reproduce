using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Tasks.Models;

public class ExecutorInfo
{
	public IUser Executor { get; set; }

	public int Count { get; set; }
}
