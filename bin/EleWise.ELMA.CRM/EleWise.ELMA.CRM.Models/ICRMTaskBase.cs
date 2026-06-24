using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("50721ffa-8092-4cb2-ad5b-f432c68bab88")]
[DisplayName(typeof(__Resources_ICRMTaskBase), "DisplayName")]
[BaseClass("0f338330-068c-4135-be4e-95797a209c4e")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>3632c117-dc3c-4429-a157-5ccdad4d4bdb</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("CRMTaskBase")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.InterfaceExtension)]
[Filterable]
[FilterType(typeof(ICRMTaskBaseFilter))]
[ActionsType(typeof(CRMTaskBaseActions))]
public interface ICRMTaskBase : ITaskBase, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[Uid("cde3222a-8990-469f-b237-54be1d77fb1d")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "38096146-0c73-4809-94f5-e18b2d525531")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Contractor")]
	[DisplayName(typeof(__Resources_ICRMTaskBase), "P_Contractor_DisplayName")]
	[Description(typeof(__Resources_ICRMTaskBase), "P_Contractor_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IContractor Contractor { get; set; }

	[Uid("2aa80f4e-9d55-46a2-aeca-7963207e4ab6")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "a9b1bc6a-3286-4264-81aa-02f6df73c080")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Contact")]
	[DisplayName(typeof(__Resources_ICRMTaskBase), "P_Contact_DisplayName")]
	[Description(typeof(__Resources_ICRMTaskBase), "P_Contact_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IContact Contact { get; set; }

	[Uid("b86ef570-b30c-49ca-aff4-5750237bb550")]
	[Order(2)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "7af9ad76-a111-466b-8b57-3b76b5504182")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Lead")]
	[DisplayName(typeof(__Resources_ICRMTaskBase), "P_Lead_DisplayName")]
	[Description(typeof(__Resources_ICRMTaskBase), "P_Lead_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ILead Lead { get; set; }

	[Uid("9ac0a895-967b-4e07-b3f2-807f57b328da")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "d722eb1b-2583-48e6-ace0-e9417b027804")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Sale")]
	[DisplayName(typeof(__Resources_ICRMTaskBase), "P_Sale_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ISale Sale { get; set; }
}
