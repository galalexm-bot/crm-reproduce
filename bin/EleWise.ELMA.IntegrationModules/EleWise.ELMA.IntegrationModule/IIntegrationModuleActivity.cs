using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.IntegrationModules.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("1d4e24cc-2954-4064-a5cb-ce87a10a53c8")]
[DisplayName("SR.M('Активити модуля интеграции')")]
[AllowCreateHeirs(true)]
[DisplayFormat(null)]
[TitleProperty("4b7b816c-17bf-4b22-8c59-d99101cf45ae")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>7a7a68db-56f3-4edf-b933-1fd2ec781e89</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("IntegrationModuleActivity")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("e9f40465-50c0-4b32-b535-ff8c42c31164")]
[FilterType(typeof(IIntegrationModuleActivityFilter))]
public interface IIntegrationModuleActivity : IEntity<long>, IEntity, IIdentified, IInheritable
{
	[Uid("1985ae56-deef-47bd-9c3d-3415c027de5d")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName("SR.M('Уникальный идентификатор')")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("ad036e1a-f19d-4c64-ad34-23cfb50e3c44")]
	[Order(2)]
	[Property("317e3d72-9c47-4b68-926d-ba77a2579bc2")]
	[TextSettings(FieldName = "ActivityErrorText")]
	[DisplayName("SR.M('Ошибка выполнения')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Output(true)]
	[EntityProperty]
	string ActivityErrorText { get; set; }

	[Uid("4b7b816c-17bf-4b22-8c59-d99101cf45ae")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	[RequiredField]
	[DisplayName("SR.M('Наименование')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[Output(true)]
	[Filterable]
	[EntityProperty]
	string Name { get; set; }

	[Uid("64AE5765-D9E2-44D9-969C-260BF52C6C7D")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Actyivitykey")]
	[DisplayName("SR.M('Ключ')")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[Input(true)]
	[Output(true)]
	[EntityProperty]
	Guid Actyivitykey { get; set; }
}
