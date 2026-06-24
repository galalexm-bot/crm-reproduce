using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Types.Settings;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Security.Models;

[ImplementationUid("843bc077-cf01-4bd1-aeb4-5ff9a84b62a3")]
[DisplayName("SR.M('Набор пользователей')")]
[Description("SR.M('Наборы пользователей/групп создаваемые пользователями самостоятельно')")]
[Uid("f4e0fcab-a604-4ff2-ad5d-2ea1987aa76e")]
[MetadataType(typeof(EntityMetadata))]
[FilterType(typeof(IPersonalGroupFilter))]
[DisplayFormat(null)]
[Filterable]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[TitleProperty("4fd1e379-fb9c-4e3f-ac7d-fb0c7e362858")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>51f66284-6bcb-4610-a5ad-f4ad478f06f5</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("PersonalGroup")]
public interface IPersonalGroup : IEntity<long>, IEntity, IIdentified
{
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[Uid("7a0f7fe2-dae4-4b12-b8c5-b06329a5d60c")]
	[SystemProperty]
	[DisplayName("SR.M('Уникальный идентификатор')")]
	[NotNull]
	[EntityProperty]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	Guid Uid { get; set; }

	[Filterable]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[RequiredField]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Owner")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName("SR.M('Пользователь')")]
	[Required(true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Order(1)]
	[Uid("0258083a-809b-4e44-8fd7-2db5dea34b85")]
	IUser Owner { get; set; }

	[Filterable]
	[EntityProperty]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "Name")]
	[RequiredField]
	[Uid("4fd1e379-fb9c-4e3f-ac7d-fb0c7e362858")]
	[Order(2)]
	[Required(true)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[StringRangeLength(0, "2000")]
	[DisplayName("SR.M('Название')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	string Name { get; set; }

	[DisplayName("SR.M('Пользователи')")]
	[Order(3)]
	[EntityUserSettings(RelationType = RelationType.ManyToMany, RelationTableName = "M_PersonalGroup_Users", ParentColumnName = "PersonalGroupId", ChildColumnName = "UserId", CascadeMode = CascadeMode.SaveUpdate)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Uid("f1d843d3-74bf-43bc-97ea-624971b87e3b")]
	[EntityProperty]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	ISet<IUser> Users { get; set; }

	[Order(4)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "72c9994a-cd4e-4746-ac50-5f454b450231")]
	[EntitySettings(RelationType = RelationType.ManyToMany, RelationTableName = "M_PersonalGroup_Groups", ParentColumnName = "PersonalGroupId", ChildColumnName = "GroupId", CascadeMode = CascadeMode.SaveUpdate)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[DisplayName("SR.M('Группы')")]
	[Uid("79480abf-af17-4a47-abfe-a709f3ad33c3")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	ISet<IUserGroup> Groups { get; set; }
}
