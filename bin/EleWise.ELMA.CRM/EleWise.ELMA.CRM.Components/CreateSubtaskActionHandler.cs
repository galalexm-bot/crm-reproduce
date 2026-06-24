using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Events;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.CRM.Components;

[Component]
public class CreateSubtaskActionHandler : ICreateSubtaskActionHandler, IEventHandler
{
	public void ProcessBeforeCreate(ITaskBase source, ITaskBase target, ICreateSubtaskActionModel subtaskModel)
	{
		if (source != null && subtaskModel is ICreateSubtaskWithCrmEntityActionModel && ((ICreateSubtaskWithCrmEntityActionModel)subtaskModel).CopyCrmEntity)
		{
			ICRMTaskBase iCRMTaskBase = source as ICRMTaskBase;
			ICRMTaskBase iCRMTaskBase2 = target as ICRMTaskBase;
			if (iCRMTaskBase != null && iCRMTaskBase2 != null)
			{
				iCRMTaskBase2.Contractor = iCRMTaskBase.Contractor;
				iCRMTaskBase2.Contact = iCRMTaskBase.Contact;
				iCRMTaskBase2.Lead = iCRMTaskBase.Lead;
				iCRMTaskBase2.Sale = iCRMTaskBase.Sale;
			}
		}
	}

	public void ProcessBeforeSave(ITaskBase source, ITaskBase target, ICreateSubtaskActionModel subtaskModel)
	{
	}

	public static bool IsDefaultValueCrmEntity(ITaskBase source)
	{
		if (source != null && source is ICRMTaskBase iCRMTaskBase && (iCRMTaskBase.Contractor != null || iCRMTaskBase.Contact != null || iCRMTaskBase.Lead != null || iCRMTaskBase.Sale != null))
		{
			return false;
		}
		return true;
	}
}
