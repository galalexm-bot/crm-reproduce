using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.Models.Enums;

namespace EleWise.ELMA.Workflow.Models;

[EntityMetadataType(EntityMetadataType.Interface)]
[ShowInCatalogList(false)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[Filterable]
[Description("SR.M('Общая информация по пользовательскому расширению, одинаковая для всех версий:\\nНаименование расширения,  Родительская папка и т.п.')")]
[FilterType(typeof(ICustomActivityHeaderFilter))]
[ImplementationUid("35203ede-3d76-4999-a7f0-c17ab42717a3")]
[DisplayName("SR.M('Заголовок пользовательского расширения')")]
[Uid("9b83a85f-81ce-4f66-9f74-683799a4f362")]
[DisplayFormat(null)]
[ShowInTypeTree(false)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>2509d61d-e601-4627-9d9a-53adf23f33ad</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("CustomActivityHeader")]
[MetadataType(typeof(EntityMetadata))]
public interface ICustomActivityHeader : IEntity<long>, IEntity, IIdentified
{
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[DisplayName("SR.M('Уникальный идентификатор')")]
	[Uid("f94adda2-f766-4e31-9651-ecd44b55a484")]
	[EntityProperty]
	[SystemProperty]
	[NotNull]
	[GuidSettings(FieldName = "Uid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	Guid Uid { get; set; }

	[StringSettings(MaxValueString = "2000", FieldName = "Name")]
	[StringRangeLength(0, "2000")]
	[Order(1)]
	[Uid("23a28039-1297-4836-a78f-e9c8ce3bce29")]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Filterable]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[RequiredField]
	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName("SR.M('Название')")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	string Name { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[Uid("499f475f-659c-44dc-b870-7651b02d8093")]
	[Order(2)]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Folder")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "7077af3a-c095-4a73-87de-3ba205024c07")]
	[DisplayName("SR.M('Родительская папка')")]
	ICustomActivityFolder Folder { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Published")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName("SR.M('Опубликованная версия')")]
	[EntityProperty]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "c83a80c7-9eef-40ff-b3f5-b46a06094869")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Description("SR.M('Действующая версия пользовательского расширения')")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(3)]
	[Uid("be95a10e-16e5-4b14-93c9-c79558d99d33")]
	ICustomActivity Published { get; set; }

	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "c83a80c7-9eef-40ff-b3f5-b46a06094869")]
	[Order(4)]
	[Uid("0b0dba94-8599-47e7-bd98-a70a4c3a6f16")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Draft")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName("SR.M('Текущая версия')")]
	[Description("SR.M('Текущая версия (черновик)')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	ICustomActivity Draft { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "255", FieldName = "ColorFirst")]
	[Uid("9dec7e5c-8fe3-4b79-9d09-5853a41ecc94")]
	[Order(5)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[StringRangeLength(0, "255")]
	[DisplayName("SR.M('Основной цвет')")]
	string ColorFirst { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName("SR.M('Дополнительный цвет')")]
	[Order(6)]
	[Uid("6dc7cea5-d21a-4670-92b8-b2c3b09e7a18")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringRangeLength(0, "255")]
	[StringSettings(MaxValueString = "255", FieldName = "ColorSecond")]
	string ColorSecond { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName("SR.M('Удалено или нет')")]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[RequiredField]
	[CanBeNull]
	[Order(7)]
	[Uid("b39962ab-b93f-4c57-994c-9faf3b68a46c")]
	[BoolSettings(FieldName = "Deleted")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[Required(true)]
	bool? Deleted { get; set; }

	[Required(true)]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[CanBeNull]
	[Uid("4c4263a9-fd7e-407d-b42b-6634446e6173")]
	[Order(8)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[RequiredField]
	[BoolSettings(FieldName = "ReadOnly")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName("SR.M('Только для чтения')")]
	bool? ReadOnly { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[NotNull]
	[Order(9)]
	[Uid("e783cd12-1a3b-488a-b6cf-a178c1d2fa74")]
	[DisplayName("SR.M('Есть неопубликованные изменения')")]
	[BoolSettings(DefaultValueStr = "True", FieldName = "IsDirtyCustomActivity")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	bool IsDirtyCustomActivity { get; set; }

	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[CanBeNull]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Order(10)]
	[Uid("977318a7-2d8d-446b-a037-830fff7fcbab")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName("SR.M('Основной цвет из набора')")]
	[EnumSettings(FieldName = "ColorFirstPreset")]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "596e78dd-c440-498c-b578-c6af5f4d4c47")]
	WebDiagrammerElementColor? ColorFirstPreset { get; set; }

	[DisplayName("SR.M('Дополнительный цвет из набора')")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "596e78dd-c440-498c-b578-c6af5f4d4c47")]
	[EnumSettings(FieldName = "ColorSecondPreset")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[CanBeNull]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("f1815d88-054a-46e1-b297-9b8df92bdefd")]
	[Order(11)]
	WebDiagrammerElementColor? ColorSecondPreset { get; set; }
}
