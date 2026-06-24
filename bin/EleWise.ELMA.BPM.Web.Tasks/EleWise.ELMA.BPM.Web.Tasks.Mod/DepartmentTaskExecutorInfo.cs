using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class DepartmentTaskExecutorInfo
{
	public IUser Executor { get; set; }

	public int CountCurrent { get; set; }

	public int CountExpired { get; set; }
}
