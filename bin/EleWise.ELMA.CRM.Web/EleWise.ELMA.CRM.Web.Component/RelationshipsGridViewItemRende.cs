using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.ViewItems;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class RelationshipsGridViewItemRenderer : ViewItemRendererBase<RelationshipsGridViewItem>, ICountViewItemRenderer
{
	public long? Count(object model, ICountViewItem viewItem)
	{
		IRelationshipFilter relationshipFilter = InterfaceActivator.Create<IRelationshipFilter>();
		relationshipFilter.DisableSecurity = true;
		relationshipFilter.Contractor = model as IContractor;
		relationshipFilter.Contact = model as IContact;
		relationshipFilter.Lead = model as ILead;
		relationshipFilter.Sale = model as ISale;
		return RelationshipManager.Instance.Count(relationshipFilter);
	}
}
