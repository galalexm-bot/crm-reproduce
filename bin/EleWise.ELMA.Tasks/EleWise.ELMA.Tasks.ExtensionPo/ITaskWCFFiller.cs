using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.API.Models;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints.API;

[ExtensionPoint(ComponentType.All)]
public interface ITaskWCFFiller
{
	void FillTaskWCF(ITask task, TaskWCF taskWCF);
}
