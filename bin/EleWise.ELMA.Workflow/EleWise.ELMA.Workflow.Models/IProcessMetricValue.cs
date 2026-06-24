using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Workflow.Models;

[Filterable]
[EntityMetadataType(EntityMetadataType.Interface)]
[Entity("ProcessMetricValue")]
[FilterType(typeof(IProcessMetricValueFilter))]
[ImplementationUid("812015fd-60fb-483c-950b-192e73f048bf")]
[ShowInCatalogList(false)]
[DisplayName(typeof(__Resources_IProcessMetricValue), "DisplayName")]
[Uid("26c32d4b-43ee-44ee-9414-0c489ebdaddc")]
[MetadataType(typeof(EntityMetadata))]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>f874364b-b0a1-4864-9224-618562822b7b</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[DisplayFormat(null)]
public interface IProcessMetricValue : IEntity<long>, IEntity, IIdentified
{
	[NotNull]
	[Uid("8d20be01-1e3f-4d55-8788-9663afea7499")]
	[DisplayName(typeof(__Resources_IProcessMetricValue), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	Guid Uid { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IProcessMetricValue), "P_CreationDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
	[Order(1)]
	[Uid("39e1a19a-05f4-4993-9e6d-6d7fdf0116cf")]
	[NotNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	DateTime CreationDate { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IProcessMetricValue), "P_CreationAuthor_DisplayName")]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Order(2)]
	[Uid("2c949cbd-385a-420a-9582-899229fb5a83")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "CreationAuthor")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	IUser CreationAuthor { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "ChangeDate")]
	[CanBeNull]
	[Uid("90b4230c-50a3-4a61-9feb-76ff7e018309")]
	[Order(3)]
	[DisplayName(typeof(__Resources_IProcessMetricValue), "P_ChangeDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	DateTime? ChangeDate { get; set; }

	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ChangeAuthor")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IProcessMetricValue), "P_ChangeAuthor_DisplayName")]
	[EntityProperty]
	[Uid("28ea837a-0e4e-4620-8505-1f25f14b9d3d")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Order(4)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	IUser ChangeAuthor { get; set; }

	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[Order(8)]
	[Filterable]
	[Uid("51cd2773-9e68-4529-9913-28285ec3855e")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DateTimeSettings(RangeInFilter = false, FieldName = "PeriodStart")]
	[DisplayName(typeof(__Resources_IProcessMetricValue), "P_PeriodStart_DisplayName")]
	DateTime? PeriodStart { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("cdefa762-1e06-47bc-93f4-5a51e986df5e")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IProcessMetricValue), "P_PeriodEnd_DisplayName")]
	[CanBeNull]
	[Order(9)]
	[DateTimeSettings(RangeInFilter = false, FieldName = "PeriodEnd")]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	DateTime? PeriodEnd { get; set; }

	[CanBeNull]
	[Property("d3df6e6e-1ff1-46aa-ad60-d51ffa91ccc7")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("8c7fd4b7-8acc-4ee8-87b6-0c414b00de40")]
	[Order(6)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IProcessMetricValue), "P_Value_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DoubleSettings(PrecisionString = null, FieldName = "Value")]
	[EntityProperty]
	double? Value { get; set; }

	[Filterable]
	[EntityProperty]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Responsible")]
	[Uid("619e1706-97ba-40a8-89d8-b7d681302419")]
	[Order(7)]
	[DisplayName(typeof(__Resources_IProcessMetricValue), "P_Responsible_DisplayName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	IUser Responsible { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	[Order(5)]
	[NotNull]
	[GuidSettings(FieldName = "ProcessMetricUid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("e7086e1e-44e5-429c-8962-3161d40be87b")]
	[DisplayName(typeof(__Resources_IProcessMetricValue), "P_ProcessMetricUid_DisplayName")]
	Guid ProcessMetricUid { get; set; }
}
