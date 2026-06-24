using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Workflow.Processes.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IModuleSettingsProcessesPageProvider : IModuleSettingsPageProvider
{
}
