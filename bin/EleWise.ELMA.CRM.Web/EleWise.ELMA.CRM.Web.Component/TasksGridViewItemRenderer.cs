using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.ViewItems;
using EleWise.ELMA.CRM.Web.Controllers;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class TasksGridViewItemRenderer : ViewItemRendererBase<TasksGridViewItem>, ICountViewItemRenderer
{
	public long? Count(object model, ICountViewItem viewItem)
	{
		ICRMTaskBaseFilter iCRMTaskBaseFilter = TaskController.CreateFilter();
		iCRMTaskBaseFilter.Contractor = model as IContractor;
		iCRMTaskBaseFilter.Contact = model as IContact;
		iCRMTaskBaseFilter.Lead = model as ILead;
		iCRMTaskBaseFilter.Sale = model as ISale;
		return TaskBaseManager.Instance.Count(iCRMTaskBaseFilter);
	}
}
