using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

[DynamicPropertyContainer]
public interface ISelectionItemViewItem
{
	[DynamicProperty(false)]
	bool EnableSelection { get; set; }

	Guid SelectablePropertyUid { get; set; }

	System.Collections.Generic.ICollection<Guid> SelectablePropertyParents { get; set; }

	[DynamicProperty(true)]
	[JsonIgnore]
	ActionWithParam<bool> OnSelect { get; set; }
}
