using System;
using System.Collections.Generic;
using System.ComponentModel;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("85989007-2f69-412f-9c3f-33912aded4b4")]
[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Задача выдачи прав')")]
[EleWise.ELMA.Model.Attributes.Description("SR.M('Задача согласования выдачи прав доступа')")]
[BaseClass("0f338330-068c-4135-be4e-95797a209c4e")]
[DisplayFormat(null)]
[ShowInTypeTree(false)]
[ShowInDesigner(false)]
[CustomCode(typeof(IAccessRequestTask), "EleWise.ELMA.Tasks.Models.AccessRequestTask.CustomCodeTemplate.cs")]
[TableView("\ufeff<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>af16ef1d-e971-4f62-b294-db3641f53d88</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("AccessRequestTask")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("33a86d4a-b7b0-40c8-b9e7-5371d9b780b4")]
[ActionsType(typeof(AccessRequestTaskActions))]
public interface IAccessRequestTask : ITaskBase, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[Uid("ad5b9dc5-7c44-416d-83ab-97b7f5f39c33")]
	[Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
	[ListOfSimpleTypeSettings(SimpleTypeUidStr = "eb6e8ddc-fafe-4e0e-9018-1a7667012579", FieldName = "AccessRequestPermissionGuids")]
	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Уникальные идентификаторы запрашиваемого доступа')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"System.ComponentModel.EditorBrowsable\">\r\n    <Parameter>\r\n      <Value xsi:type=\"System.ComponentModel.EditorBrowsableState, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\">Never</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[EntityProperty]
	List<Guid> AccessRequestPermissionGuids { get; set; }

	[Uid("42e78fc2-d1c9-4af7-a6a4-0d8e91b6a91f")]
	[Order(1)]
	[Property("1f289b26-0607-4bc7-adc0-9ed814c80c90")]
	[ReferenceOnEntitySettings(FieldName = "EntityReference")]
	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Объект доступа')")]
	[EleWise.ELMA.Model.Attributes.Description("SR.M('Ссылка на объект, к которому требуется выдать права доступа')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	ReferenceOnEntity EntityReference { get; set; }

	[Uid("15f3a2f1-f1ef-4d98-bc75-f3ee8d2c0bbd")]
	[Order(2)]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "AccessRequestApproved")]
	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Доступ предоставлен')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	bool? AccessRequestApproved { get; set; }

	[Uid("32DFA5B3-702F-4654-B62D-2CB36CF6D28F")]
	[Order(2)]
	[EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Список запрашиваемых привилегий')")]
	IEnumerable<Permission> AccessRequestPermissions { get; }
}
