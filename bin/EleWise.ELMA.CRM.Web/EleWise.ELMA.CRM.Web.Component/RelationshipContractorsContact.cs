using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class RelationshipContractorsContactsPropertyAdjustment : IPropertyViewItemAdjustment, IPropertyViewItemAdjustmentRuntime2
{
	public void Adjust(PropertyViewItem propertyViewItem, object model, ViewType viewType)
	{
		Guid guid = InterfaceActivator.PropertyUid((IRelationship m) => m.ContractorsContacts);
		if (!(propertyViewItem.PropertyUid != guid) && model is IRelationship relationship && (relationship.Contractor == null || relationship.ContractorsContacts == null || !((IEnumerable<IContact>)relationship.ContractorsContacts).Any()))
		{
			FormViewItem formViewItem = propertyViewItem.FormViewItem;
			EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(relationship.GetType()) as EntityMetadata;
			if (formViewItem != null && entityMetadata != null && !(formViewItem.Uid != entityMetadata.DefaultForms.GetForm(ViewType.Display).Uid) && (formViewItem.HideEmptySettings != HideEmptyEnum.HideEmpty || !propertyViewItem.Attributes.ShowEmpty))
			{
				propertyViewItem.Hide = true;
			}
		}
	}
}
