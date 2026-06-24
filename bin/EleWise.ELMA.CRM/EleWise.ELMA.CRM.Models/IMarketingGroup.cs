using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("c29d5357-56dc-4e65-9c89-91faed78abca")]
[DisplayName(typeof(__Resources_IMarketingGroup), "DisplayName")]
[BaseClass("fffdf82c-19fe-4e06-b29e-c7a34b33c4d1")]
[DisplayFormat(null)]
[Image(typeof(IMarketingGroup), "targets", 16, ImageFormatType.IconPack, false)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>4bc4eacd-411e-4cc2-a042-261e303931f0</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("MarketingGroup")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[SaveHistory]
[Filterable]
[ImplementationUid("17d326f0-2cc2-44df-9253-281716ed283d")]
[FilterType(typeof(IMarketingGroupFilter))]
[ActionsType(typeof(MarketingGroupActions))]
public interface IMarketingGroup : IMarketingBase, IEntity<long>, IEntity, IIdentified, ISoftDeletable, IInheritable
{
	[Uid("093457d6-7d48-4487-87c4-e36034b14b84")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "597befab-cf4c-4ff1-857e-3c1d5239aa45")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "GroupType")]
	[DisplayName(typeof(__Resources_IMarketingGroup), "P_GroupType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IMarketingGroupType GroupType { get; set; }

	[Uid("8f39b76e-5fe8-444d-9b1f-5579e7ff39ce")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "53f2d16c-4d27-4891-a3ea-9f8fe7f68a00")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "16f92123-ae94-471f-9394-beff817f2321", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IMarketingGroup), "P_MarketingActivities_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	ISet<IMarketingActivity> MarketingActivities { get; set; }
}
