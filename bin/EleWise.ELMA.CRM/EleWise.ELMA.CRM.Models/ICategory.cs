using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("815fe8a8-fa62-47d8-b096-3e1aa8a52763")]
[DisplayName(typeof(__Resources_ICategory), "DisplayName")]
[Description(typeof(__Resources_ICategory), "Description")]
[DisplayFormat(null)]
[TitleProperty("342b2ef2-7cdd-47f8-a720-784c581e9d95")]
[InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>7cd0e609-e33b-49be-bc9d-4bd64d7b75f7</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("Category")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("b7340bfd-e88e-4a42-9b55-dff7088caa5a")]
[FilterType(typeof(ICategoryFilter))]
public interface ICategory : IEntity<long>, IEntity, IIdentified, ISoftDeletable
{
	[Uid("eac17ca9-8841-4fe0-add3-42436422ad78")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_ICategory), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("342b2ef2-7cdd-47f8-a720-784c581e9d95")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	[RequiredField]
	[DisplayName(typeof(__Resources_ICategory), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[Filterable]
	[EntityProperty]
	string Name { get; set; }

	[Uid("5fab5397-e108-4f35-923a-f638a20f1373")]
	[Order(2)]
	[NotNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "9d06806e-a170-472a-b3b0-07f316333629")]
	[EnumSettings(DefaultValueStr = "a75285ae-7eaa-4155-bcd4-1eaf9ad91abb", FieldName = "CategoryType")]
	[DisplayName(typeof(__Resources_ICategory), "P_CategoryType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	CategoryType CategoryType { get; set; }

	[Uid("65a54d9a-53ec-494d-a2b6-dbc41d7d6d36")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "a8fd8204-80a0-4f2a-954e-69fd9bfc419b")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "f546fd8c-2c26-45e4-8055-6e3a200355c1", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_ICategory), "P_LeadPermissions_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	ISet<ILeadPermission> LeadPermissions { get; set; }

	[Uid("59746be8-96b3-426a-a9ad-0341ba91e88e")]
	[Order(4)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "2cdaf91f-6b08-4db0-9a46-73834c251bf5")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "2088e09d-f918-473f-b03c-bcc9a03c0f1d", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_ICategory), "P_ContractorPermissions_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	ISet<IContractorPermission> ContractorPermissions { get; set; }

	[Uid("8638d7d8-4484-49f8-b080-11363f326b2f")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "7af9ad76-a111-466b-8b57-3b76b5504182")]
	[EntitySettings(RelationType = RelationType.ManyToManyInverse, KeyColumnUidStr = "0acd389d-5cd7-4784-a246-cc31c37948a8", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_ICategory), "P_Leads_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	ISet<ILead> Leads { get; set; }

	[Uid("91a86914-521c-4482-957b-3c43929b9c52")]
	[Order(6)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "38096146-0c73-4809-94f5-e18b2d525531")]
	[EntitySettings(RelationType = RelationType.ManyToManyInverse, KeyColumnUidStr = "fd34e08d-90de-4ba9-961d-28330701014e", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_ICategory), "P_Contractors_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	ISet<IContractor> Contractors { get; set; }

	[Uid("4b3a77d0-940d-43c0-bd3a-141ec3ecf8cc")]
	[Order(7)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "ee3bc0c5-2221-46b3-b4b2-4ea939fc6885")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ContainerContractorPermissio")]
	[DisplayName(typeof(__Resources_ICategory), "P_ContainerContractorPermission_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IContContractorPermission ContainerContractorPermission { get; set; }

	[Uid("b7bb07e6-89d4-429f-8d40-c7f6f2158a98")]
	[Order(8)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "fb2ce9cf-f4c6-4e57-b865-ad0bd5bcf538")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ContainerLeadPermission")]
	[DisplayName(typeof(__Resources_ICategory), "P_ContainerLeadPermission_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IContLeadPermission ContainerLeadPermission { get; set; }

	[Uid("6eaea16c-f8b4-4917-99de-f7f65dc3a911")]
	[Order(9)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsDeleted")]
	[DisplayName(typeof(__Resources_ICategory), "P_IsDeleted_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	new bool IsDeleted { get; set; }

	[Uid("84348894-4749-45fd-bcc3-b6b781008d3d")]
	[Order(10)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "HardDelete")]
	[DisplayName(typeof(__Resources_ICategory), "P_HardDelete_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	new bool HardDelete { get; set; }
}
