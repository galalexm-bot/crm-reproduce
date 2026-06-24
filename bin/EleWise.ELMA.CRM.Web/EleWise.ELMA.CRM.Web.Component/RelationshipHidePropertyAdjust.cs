using System;
using System.Linq.Expressions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Web.Components;

internal static class RelationshipHidePropertyAdjustment
{
	internal static void Hide(PropertyViewItem propertyViewItem, IRelationship relationship, ViewType viewType, Expression<Func<IRelationship, object>> expr)
	{
		Guid guid = InterfaceActivator.PropertyUid(expr);
		if (!(propertyViewItem.PropertyUid != guid) && relationship != null)
		{
			FormViewItem formViewItem = propertyViewItem.FormViewItem;
			EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(relationship.GetType()) as EntityMetadata;
			if (formViewItem != null && entityMetadata != null && !(formViewItem.Uid != entityMetadata.DefaultForms.GetForm(ViewType.Display).Uid) && expr.Compile()(relationship) == null && (formViewItem.HideEmptySettings != HideEmptyEnum.HideEmpty || !propertyViewItem.Attributes.ShowEmpty))
			{
				propertyViewItem.Hide = true;
			}
		}
	}
}
