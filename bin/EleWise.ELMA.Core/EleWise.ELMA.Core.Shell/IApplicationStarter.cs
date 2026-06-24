using System.Threading.Tasks;

namespace EleWise.ELMA.Core.Shell;

public interface IApplicationStarter
{
	System.Threading.Tasks.Task Start();

	System.Threading.Tasks.Task Update();

	System.Threading.Tasks.Task Restart();
}
