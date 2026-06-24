using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Workflow.Models;

[InterfaceExtension(typeof(IUserSettingsModel))]
public interface IWorkflowTasksUserSettingsModel : IUserSettingsModel, IAutoImplement
{
	WorkflowTasksSettingsModel Tasks { get; set; }
}
