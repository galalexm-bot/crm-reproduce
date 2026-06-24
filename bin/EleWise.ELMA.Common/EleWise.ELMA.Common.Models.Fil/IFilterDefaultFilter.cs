using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Common.Models.Filters;

[FilterFor(typeof(IFilterDefault))]
public interface IFilterDefaultFilter : IEntityFilter
{
	ReferenceOnEntityType ObjectsType { get; set; }

	IUser CreationAuthor { get; set; }

	Guid? Code { get; set; }

	[CustomFilterProperty]
	[Uid("e53a4b02-d08d-45d8-a370-a2db71a4350f")]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "NoAuthor")]
	[DisplayName(typeof(__Resources_IFilterDefault), "FP_NoAuthor_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	bool NoAuthor { get; set; }
}
