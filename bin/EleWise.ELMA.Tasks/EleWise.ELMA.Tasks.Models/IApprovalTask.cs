using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("eca12135-be30-4f85-b031-871ebc62bf34")]
[DisplayName(typeof(__Resources_IApprovalTask), "DisplayName")]
[BaseClass("0f338330-068c-4135-be4e-95797a209c4e")]
[DisplayFormat(null)]
[Image(typeof(IApprovalTask), "task_question", 16, ImageFormatType.IconPack, false)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>61128111-701f-447c-8062-eda7aa7e4434</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("ApprovalTask")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("7aae9590-6477-4927-8ba0-eba16b7d643b")]
[FilterType(typeof(IApprovalTaskFilter))]
[ActionsType(typeof(ApprovalTaskActions))]
public interface IApprovalTask : ITaskBase, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[Uid("05791977-240a-47f1-bf12-82d0162720e5")]
	[NotNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "b11d6d0a-f07b-40a3-bc49-2cc5a67fbc81")]
	[EnumSettings(FieldName = "ParentStatus")]
	[DisplayName(typeof(__Resources_IApprovalTask), "P_ParentStatus_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	TaskBaseStatus ParentStatus { get; set; }

	[Uid("10bac73f-9620-46e6-8a09-17bfb06804e1")]
	[Order(1)]
	[NotNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "9cde21b5-7990-4599-a080-87645e05913a")]
	[EnumSettings(FieldName = "ApprovalStatus")]
	[DisplayName(typeof(__Resources_IApprovalTask), "P_ApprovalStatus_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ApprovalStatus ApprovalStatus { get; set; }

	[Uid("f462dc1b-839e-4ee0-9b37-3086143acfe5")]
	[Order(2)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e70b68f9-15b1-4b31-8db4-9990152bb51d")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ApprovalComment")]
	[DisplayName(typeof(__Resources_IApprovalTask), "P_ApprovalComment_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IComment ApprovalComment { get; set; }
}
