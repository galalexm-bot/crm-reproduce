using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Models;

[FilterFor(typeof(IProcessesWorkflowInstance))]
public interface IProcessesWorkflowInstanceFilter : IWorkflowInstanceFilter, IEntityFilter
{
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство ImprovedProcessHeader</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство ImprovedProcessHeader", true)]
	[CustomFilterProperty]
	[Uid("c709c056-3c9c-4bef-bc08-81a26c64f2af")]
	[DisplayName(typeof(__Resources_IProcessesWorkflowInstance), "FP_ImprovedProcessHeaderId_DisplayName")]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(FieldName = "ImprovedProcessHeaderId")]
	[CanBeNull]
	long? ImprovedProcessHeaderId { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[CustomFilterProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ImprovedProcessHeader")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "da55965d-02a3-4dfd-8b71-d0c45d82c6a5")]
	[Order(1)]
	[DisplayName(typeof(__Resources_IProcessesWorkflowInstance), "FP_ImprovedProcessHeader_DisplayName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[Uid("03356cd9-3d79-489f-a68a-76ec34655af9")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	IProcessHeader ImprovedProcessHeader { get; set; }
}
