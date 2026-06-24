using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Types;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("53f2d16c-4d27-4891-a3ea-9f8fe7f68a00")]
[DisplayName(typeof(__Resources_IMarketingActivity), "DisplayName")]
[BaseClass("fffdf82c-19fe-4e06-b29e-c7a34b33c4d1")]
[DisplayFormat(null)]
[Image(typeof(IMarketingActivity), "target", 16, ImageFormatType.IconPack, false)]
[FormView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<FormView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>00000000-0000-0000-0000-000000000000</Uid>\r\n  <ViewType>Display</ViewType>\r\n  <CanUseCommonView>true</CanUseCommonView>\r\n  <CanUseCommonRazorView>true</CanUseCommonRazorView>\r\n  <CanUseTabView>true</CanUseTabView>\r\n  <CanUseTabRazorView>true</CanUseTabRazorView>\r\n  <ViewInCommon>true</ViewInCommon>\r\n</FormView>")]
[FormView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<FormView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>00000000-0000-0000-0000-000000000000</Uid>\r\n  <ViewType>Create</ViewType>\r\n  <CanUseCommonView>true</CanUseCommonView>\r\n  <CanUseCommonRazorView>true</CanUseCommonRazorView>\r\n  <ViewInCommon>true</ViewInCommon>\r\n</FormView>")]
[FormView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<FormView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>00000000-0000-0000-0000-000000000000</Uid>\r\n  <ViewType>Edit</ViewType>\r\n  <CanUseCommonView>true</CanUseCommonView>\r\n  <CanUseCommonRazorView>true</CanUseCommonRazorView>\r\n  <ViewInCommon>true</ViewInCommon>\r\n</FormView>")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>1b27f782-9bcc-4f1d-8695-d2680bcf5594</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("MarketingActivity")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[SaveHistory]
[Filterable]
[ImplementationUid("973b4ad4-4832-4bd1-ac26-22b1b8461dd0")]
[FilterType(typeof(IMarketingActivityFilter))]
[ActionsType(typeof(MarketingActivityActions))]
public interface IMarketingActivity : IMarketingBase, IEntity<long>, IEntity, IIdentified, ISoftDeletable, IInheritable
{
	[Uid("16f92123-ae94-471f-9394-beff817f2321")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "c29d5357-56dc-4e65-9c89-91faed78abca")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "MarketingGroup")]
	[DisplayName(typeof(__Resources_IMarketingActivity), "P_MarketingGroup_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IMarketingGroup MarketingGroup { get; set; }

	[Uid("b5d3a328-4ace-476d-bb6f-2c69b18c84fc")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "b021633c-e2bc-4666-8e86-9bb7fa85d54d")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ActivityType")]
	[DisplayName(typeof(__Resources_IMarketingActivity), "P_ActivityType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IMarketingActivityType ActivityType { get; set; }

	[Uid("d3c21f0c-a865-4998-b2ed-dfdd62dd75fc")]
	[Order(2)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "2c2ae8eb-9f42-4d3e-b990-157357c1a535")]
	[MarketingEffectSettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "e261eb61-aeae-41a4-917e-3626b92afad2", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IMarketingActivity), "P_MarketingEffects_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	ISet<IMarketingEffect> MarketingEffects { get; set; }

	[Uid("db8d8786-50ae-4777-b882-25b357e76f96")]
	[Order(3)]
	[NotNull]
	[Required(true)]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "StartDate")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IMarketingActivity), "P_StartDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	DateTime StartDate { get; set; }

	[Uid("0fb0d9a7-7485-4bdd-8f21-dd4ba66b1930")]
	[Order(4)]
	[NotNull]
	[Required(true)]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "EndDate")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IMarketingActivity), "P_EndDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	DateTime EndDate { get; set; }
}
