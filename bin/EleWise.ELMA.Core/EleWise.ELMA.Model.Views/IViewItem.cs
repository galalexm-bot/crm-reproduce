using System;
using System.Collections.Generic;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views;

[DynamicPropertyContainer]
[ExtensionPoint]
public interface IViewItem : IReactive
{
	string Name { get; set; }

	Guid Uid { get; set; }

	[DynamicProperty(false)]
	bool Hide { get; set; }

	ViewItemHideMode HideMode { get; set; }

	FormViewItem FormViewItem { get; }

	System.Collections.Generic.ICollection<ComputedValue> DynamicProperties { get; set; }

	string TestId { get; set; }

	DefaultAction OnMouseEnter { get; set; }

	DefaultAction OnMouseLeave { get; set; }

	DefaultAction OnEnter { get; set; }

	DefaultAction OnEscape { get; set; }

	IViewItem Clone();
}
