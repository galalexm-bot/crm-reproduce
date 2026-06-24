using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.ViewItems;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class AttachmentsGridViewItemRenderer : ViewItemRendererBase<AttachmentsGridViewItem>, ICountViewItemRenderer
{
	public long? Count(object model, ICountViewItem viewItem)
	{
		ICRMAttachmentFilter iCRMAttachmentFilter = InterfaceActivator.Create<ICRMAttachmentFilter>();
		iCRMAttachmentFilter.Contractor = model as IContractor;
		iCRMAttachmentFilter.Contact = model as IContact;
		iCRMAttachmentFilter.Lead = model as ILead;
		iCRMAttachmentFilter.Sale = model as ISale;
		return EntityManager<ICRMAttachment>.Instance.Count(iCRMAttachmentFilter);
	}
}
