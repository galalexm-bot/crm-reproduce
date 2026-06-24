using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Types.Settings;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Security.Models;

[FilterFor(typeof(IAbsence))]
public interface IAbsenceFilter : IEntityFilter
{
	DateTimeRange StartDate { get; set; }

	DateTimeRange EndDate { get; set; }

	string Description { get; set; }

	AbsenceStatus? Status { get; set; }

	ISet<IGroundsForAbsence> Grounds { get; set; }

	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство Users</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство Users", true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "User")]
	[CustomFilterProperty]
	[Uid("20d8dc15-ba6a-4429-a489-efcacda74478")]
	[DisplayName(typeof(__Resources_IAbsence), "FP_User_DisplayName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	IUser User { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[Order(1)]
	[EntityUserSettings(RelationType = RelationType.ManyToMany, ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IAbsence), "FP_Users_DisplayName")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("df69a44a-8476-4ab8-8049-4757cde0facc")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[CustomFilterProperty]
	ISet<IUser> Users { get; set; }
}
