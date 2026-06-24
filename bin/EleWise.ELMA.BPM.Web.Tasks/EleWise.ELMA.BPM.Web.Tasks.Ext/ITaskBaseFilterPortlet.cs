using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ITaskBaseFilterPortlet
{
	bool CheckGridId(string gridId);

	ITaskBaseFilter GetTaskBaseFilter();
}
