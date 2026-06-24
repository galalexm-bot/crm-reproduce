using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Documents.Models;

[FilterFor(typeof(IDocumentTaskBaseExtension))]
public interface IDocumentTaskBaseExtensionFilter : ITaskBaseFilter, IEntityFilter
{
	[CustomFilterProperty]
	[Uid("188f1bea-f4d3-4897-aa86-de467508411d")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "2b660715-d111-4cc6-acfd-965661719fba")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "InnerDocument")]
	[DisplayName(typeof(__Resources_IDocumentTaskBaseExtension), "FP_InnerDocument_DisplayName")]
	[Description(typeof(__Resources_IDocumentTaskBaseExtension), "FP_InnerDocument_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	IDocument InnerDocument { get; set; }

	[CustomFilterProperty]
	[Uid("6475d57b-fdd0-4dc7-ad22-be5df6de1cc2")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "2b660715-d111-4cc6-acfd-965661719fba")]
	[EntitySettings(RelationType = RelationType.ManyToMany, ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IDocumentTaskBaseExtension), "FP_InnerDocuments_DisplayName")]
	[Description(typeof(__Resources_IDocumentTaskBaseExtension), "FP_InnerDocuments_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	ISet<IDocument> InnerDocuments { get; set; }
}
