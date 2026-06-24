using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Security.Models;

[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("eb3117da-3066-45ec-8219-863b988174d6")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[DisplayName(typeof(__Resources_IUserCryptoProfile), "DisplayName")]
[Uid("9906e130-eb5a-4221-b80e-db0e9e11dd5c")]
[MetadataType(typeof(EntityMetadata))]
[DisplayFormat(null)]
[Entity("UserCryptoProfile")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>e327a04e-00d1-41eb-944e-d4a889a8118d</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[ShowInDesigner(false)]
public interface IUserCryptoProfile : IEntity<long>, IEntity, IIdentified
{
	[GuidSettings(FieldName = "Uid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[SystemProperty]
	[EntityProperty]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IUserCryptoProfile), "P_Uid_DisplayName")]
	[Uid("ddb9ba60-7e41-415f-b4f1-95e6d49f1ba6")]
	[NotNull]
	Guid Uid { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IUserCryptoProfile), "P_AuthCryptoProviderGuid_DisplayName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[GuidSettings(FieldName = "AuthCryptoProviderGuid")]
	[Order(1)]
	[Uid("b50a39be-0bd6-4a49-b2f7-d32fb11b74a4")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[CanBeNull]
	Guid? AuthCryptoProviderGuid { get; set; }

	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[Order(2)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IUserCryptoProfile), "P_User_DisplayName")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("618eb431-2d0c-4fe0-a349-a411ceac5d75")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "User")]
	[EntityProperty]
	IUser User { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[CanBeNull]
	[Uid("c697c153-67df-4d9d-9dc7-ce58d2efc3d1")]
	[Order(3)]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[DisplayName(typeof(__Resources_IUserCryptoProfile), "P_AuthDigitalSignatureTypeGuid_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[GuidSettings(FieldName = "AuthDigitalSignatureTypeGuid")]
	Guid? AuthDigitalSignatureTypeGuid { get; set; }
}
