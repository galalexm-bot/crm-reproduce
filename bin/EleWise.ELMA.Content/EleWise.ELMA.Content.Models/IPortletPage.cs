using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Transformation;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Content.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("07592751-d5d9-40ea-952c-40b773fbbb0e")]
[DisplayName(typeof(__Resources_IPortletPage), "DisplayName")]
[BaseClass("5ce3c5d3-24b4-4d79-9be5-91bf0bb80a22")]
[AllowCreateHeirs(true)]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>4c5db2fa-ee3a-4bbc-884e-9ffd0c28992a</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("PortletPage")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("dc916059-c91e-4875-b6ff-c66f0c1d4a74")]
public interface IPortletPage : IPageBase, IPortalObject, IEntity<long>, IEntity, IIdentified, IInheritable, IPageTransformationContainer
{
	[Uid("153e295e-8942-4332-9f48-ca4a41ec31f5")]
	[NotNull]
	[Required(true)]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "PortletsLayoutId")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IPortletPage), "P_PortletsLayoutId_DisplayName")]
	[Description(typeof(__Resources_IPortletPage), "P_PortletsLayoutId_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	Guid PortletsLayoutId { get; set; }
}
