using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.ViewItems;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class RelationshipContactInfoFormViewItemTransformate : IFormViewItemTransformate
{
	public FormViewItem Transformate(FormViewItem formViewItem, object model)
	{
		if (!(model is RelationshipModel relationshipModel) || formViewItem.Uid != relationshipModel.FormViewItem(ViewType.Display).Uid || relationshipModel.Entity.Contractor != null || relationshipModel.Entity.Contact != null || relationshipModel.Entity.Lead != null)
		{
			return formViewItem;
		}
		return formViewItem.Transformate(delegate(FormViewItemTransformationBuilder<IRelationship> t)
		{
			formViewItem.GetAllItems().OfType<RelationshipContactInfoViewItem>().Each(delegate(RelationshipContactInfoViewItem p)
			{
				t.ForItem<RelationshipContactInfoViewItem>(p.Uid).Hide();
			});
		}).Transformate(delegate(FormViewItemTransformationBuilder<IRelationship> t)
		{
			(from p in formViewItem.GetAllItems().OfType<RelationshipContactInfoTabViewItem>()
				where p.Items.All((ViewItem s) => s.GetType() == typeof(RelationshipContactInfoViewItem))
				select p).Each(delegate(RelationshipContactInfoTabViewItem p)
			{
				t.ForItem<RelationshipContactInfoTabViewItem>(p.Uid).Hide();
			});
		});
	}
}
