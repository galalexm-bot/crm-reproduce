using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Calendar.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("2919287f-1f84-42d0-b937-7da6025b95e4")]
[DisplayName(typeof(__Resources_ISchedule), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("d9214c4c-3ff3-4366-b11e-d003d4dd89ea")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>1dc2631b-5033-4410-85d0-11246ef0f2e8</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("Schedule")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[CopyAction(CopyAction.ByRef)]
[Filterable]
[ImplementationUid("75deb6c7-ff20-4ba9-b06b-acc3e6cbf331")]
[FilterType(typeof(IScheduleFilter))]
public interface ISchedule : IEntity<long>, IEntity, IIdentified
{
	[Uid("7c149624-e049-4916-9af3-4c81d47f5ace")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_ISchedule), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("d9214c4c-3ff3-4366-b11e-d003d4dd89ea")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	[RequiredField]
	[DisplayName(typeof(__Resources_ISchedule), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[FastSearch(true)]
	[Filterable]
	[EntityProperty]
	string Name { get; set; }

	[Uid("76dade8a-fef4-4192-920c-9e6a7866f02a")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(FieldName = "CreationAuthor")]
	[DisplayName(typeof(__Resources_ISchedule), "P_CreationAuthor_DisplayName")]
	[PropertyHandler("b05ac6bd-eb8b-474a-a796-b53831a9967e")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IUser CreationAuthor { get; set; }

	[Uid("fc369d3c-3bf1-48c3-b9f7-0317ff91fcec")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(FieldName = "Owner")]
	[DisplayName(typeof(__Resources_ISchedule), "P_Owner_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IUser Owner { get; set; }

	[Uid("75d82d09-cb4b-4546-b546-a9c7c153beef")]
	[Order(6)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfbe6673-0388-46da-a188-f35ce8a6088d")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "e7b705e3-1a74-442b-871e-c80432c3e605", CascadeMode = CascadeMode.All)]
	[DisplayName(typeof(__Resources_ISchedule), "P_Permissions_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ISet<ISchedulePermission> Permissions { get; set; }

	[Uid("85eae218-f351-4011-825f-c53c9e1ab0c2")]
	[Order(2)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MultiLine = true, FieldName = "Description")]
	[DisplayName(typeof(__Resources_ISchedule), "P_Description_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	string Description { get; set; }

	[Uid("e68f395f-2cd2-4623-a40c-44e72d6874bc")]
	[Order(4)]
	[NotNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "CreationDate")]
	[DisplayName(typeof(__Resources_ISchedule), "P_CreationDate_DisplayName")]
	[PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	DateTime CreationDate { get; set; }
}
