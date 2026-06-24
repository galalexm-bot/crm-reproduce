using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_SaleCategoriesViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(ISale))]
public class SaleCategoriesViewItem : PropertyViewItem
{
	[Component(Order = 50)]
	private class ToolboxItem : CRMViewItemToolboxItem<SaleCategoriesViewItem>
	{
	}

	public SaleCategoriesViewItem()
	{
		base.Attributes.Name = SR.T("Категории");
		base.Attributes.ReadOnly = true;
	}
}
