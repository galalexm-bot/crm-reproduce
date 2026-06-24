using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("e0d3b204-e170-45a0-acf6-ff1197cc119b")]
[DisplayName(typeof(__Resources_IReplacementTask), "DisplayName")]
[BaseClass("0f338330-068c-4135-be4e-95797a209c4e")]
[AllowCreateHeirs(true)]
[DisplayFormat(null)]
[Image(typeof(IReplacementTask), "task_replacement", 16, ImageFormatType.IconPack, false)]
[FormView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<FormView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>de052e01-c0a5-4260-a738-40234bc0db2d</Uid>\r\n  <ViewType>Display</ViewType>\r\n  <CanUseCommonView>true</CanUseCommonView>\r\n  <CanUseCommonRazorView>true</CanUseCommonRazorView>\r\n  <CanUseTabView>true</CanUseTabView>\r\n  <CanUseTabRazorView>true</CanUseTabRazorView>\r\n  <ViewInCommon>true</ViewInCommon>\r\n</FormView>")]
[FormView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<FormView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>68ba4728-6c51-476c-b5c2-bdd7706e327e</Uid>\r\n  <ViewType>Create</ViewType>\r\n  <CanUseCommonView>true</CanUseCommonView>\r\n  <ViewInCommon>true</ViewInCommon>\r\n</FormView>")]
[FormView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<FormView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>6c0a90ce-0099-43b0-be76-09fc99daee29</Uid>\r\n  <ViewType>Edit</ViewType>\r\n  <CanUseCommonView>true</CanUseCommonView>\r\n  <ViewInCommon>true</ViewInCommon>\r\n</FormView>")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>919a5ede-64dc-440a-92e7-1f7a9d73a4e2</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("ReplacementTask")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("8d12df50-4b9d-4f7c-aa39-3f8d16d473fc")]
[FilterType(typeof(IReplacementTaskFilter))]
[ActionsType(typeof(ReplacementTaskActions))]
public interface IReplacementTask : ITaskBase, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[Uid("432c2277-b8d0-4534-8bd1-2e3a2361b394")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "c4fbe20f-1114-4198-a307-31b65cc84635")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, CopyAction = CopyAction.ByRef, FieldName = "Replacement")]
	[DisplayName(typeof(__Resources_IReplacementTask), "P_Replacement_DisplayName")]
	[Description(typeof(__Resources_IReplacementTask), "P_Replacement_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IReplacement Replacement { get; set; }

	[Uid("5852edf7-9c1b-443a-b2bb-7566ebf1d8d2")]
	[Order(2)]
	[Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
	[XmlSerializableObjectSettings(FieldName = "Assignments")]
	[DisplayName(typeof(__Resources_IReplacementTask), "P_Assignments_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	object Assignments { get; set; }

	[Uid("8b068997-52e9-4e72-a824-399a59610b64")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "BlockedUser")]
	[DisplayName(typeof(__Resources_IReplacementTask), "P_BlockedUser_DisplayName")]
	[Description(typeof(__Resources_IReplacementTask), "P_BlockedUser_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IUser BlockedUser { get; set; }
}
