using System;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Models.ChangeProcessVersion;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

[Component]
public class WorkflowInstanceSelectableGridProvider : ISelectableGridProvider
{
	public const string UID_S = "DCDEF22E-4A4A-4FC6-AD41-C758863C2069";

	public static readonly Guid ProviderUid = new Guid("DCDEF22E-4A4A-4FC6-AD41-C758863C2069");

	public Guid Uid => ProviderUid;

	public bool ShowCheckBox(SelectableGridCheckBoxModel model)
	{
		if (model == null)
		{
			return false;
		}
		if (!(model.Property is IWorkflowInstance workflowInstance))
		{
			return false;
		}
		ChangeProcessVersionActionData changeData = new ChangeProcessVersionActionData
		{
			Reason = "",
			Instance = workflowInstance,
			NewProcess = workflowInstance.Process.Header.Published,
			User = AuthenticationService.GetCurrentUser<IUser>()
		};
		if (WorkflowInstanceManager.Instance.CanChangeVersion(changeData))
		{
			return true;
		}
		return false;
	}
}
