using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Models;

[Filterable]
[EntityMetadataType(EntityMetadataType.Interface)]
[ShowInCatalogList(false)]
[DisplayName(typeof(__Resources_IImprovementProcessSettings), "DisplayName")]
[FilterType(typeof(IImprovementProcessSettingsFilter))]
[ImplementationUid("b6810770-91fe-4432-955e-398f2ab22180")]
[DisplayFormat(null)]
[MetadataType(typeof(EntityMetadata))]
[Uid("fa5e7eda-b2d8-4c33-bead-125a3902a552")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[Entity("ImprovementProcessSettings")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>0499a285-9686-4157-965f-f1874910a58f</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
public interface IImprovementProcessSettings : IEntity<long>, IEntity, IIdentified
{
	[GuidSettings(FieldName = "Uid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[DisplayName(typeof(__Resources_IImprovementProcessSettings), "P_Uid_DisplayName")]
	[EntityProperty]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[Uid("6248a556-d05f-4963-98d4-ba72a62fe1b5")]
	[NotNull]
	[SystemProperty]
	Guid Uid { get; set; }

	[Required(true)]
	[Order(1)]
	[Uid("52b013ef-48ae-4afb-a6e2-f68fc5a2b6e1")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "da55965d-02a3-4dfd-8b71-d0c45d82c6a5")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[RequiredField]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Header")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IImprovementProcessSettings), "P_Header_DisplayName")]
	IProcessHeader Header { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Description(typeof(__Resources_IImprovementProcessSettings), "P_ProcessHeaderContextVar_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IImprovementProcessSettings), "P_ProcessHeaderContextVar_DisplayName")]
	[NotNull]
	[Order(2)]
	[Uid("55a0f90f-877b-41e7-8218-dd2b9f136244")]
	[Required(true)]
	[GuidSettings(FieldName = "ProcessHeaderContextVar")]
	[RequiredField]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	Guid ProcessHeaderContextVar { get; set; }

	[NotNull]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[Description(typeof(__Resources_IImprovementProcessSettings), "P_WorkflowInstanceContextVar_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IImprovementProcessSettings), "P_WorkflowInstanceContextVar_DisplayName")]
	[Uid("694816fd-e4fe-4780-9c7c-f8b63eb706b0")]
	[RequiredField]
	[GuidSettings(FieldName = "WorkflowInstanceContextVar")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[Required(true)]
	[Order(3)]
	Guid WorkflowInstanceContextVar { get; set; }

	[RequiredField]
	[GuidSettings(FieldName = "TaskContextVar")]
	[Description(typeof(__Resources_IImprovementProcessSettings), "P_TaskContextVar_Description")]
	[DisplayName(typeof(__Resources_IImprovementProcessSettings), "P_TaskContextVar_DisplayName")]
	[Order(4)]
	[Uid("27bf34c8-170d-4d83-b5f3-158d25758a7b")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[NotNull]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[Required(true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	Guid TaskContextVar { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Description(typeof(__Resources_IImprovementProcessSettings), "P_DescriptionContextVar_Description")]
	[Required(true)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IImprovementProcessSettings), "P_DescriptionContextVar_DisplayName")]
	[NotNull]
	[Uid("abb57dd7-5fc3-4f0d-bd31-b173cbdc8640")]
	[Order(5)]
	[RequiredField]
	[GuidSettings(FieldName = "DescriptionContextVar")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	Guid DescriptionContextVar { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IImprovementProcessSettings), "P_Default_DisplayName")]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "Default")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Order(6)]
	[Uid("c28c0188-a64d-4cb0-bbf8-9538fff18a4a")]
	[EntityProperty]
	[Filterable]
	bool Default { get; set; }
}
