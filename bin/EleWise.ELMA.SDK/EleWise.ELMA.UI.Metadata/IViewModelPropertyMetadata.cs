using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.UI.Metadata;

public interface IViewModelPropertyMetadata : IPropertyMetadata, INamedMetadata, IOrderedMetadata, IMetadata, IXsiType
{
	bool ClientOnly { get; set; }

	bool Input { get; set; }

	bool Output { get; set; }

	ComputedValue ComputedValue { get; set; }

	List<ComputedValue> ComputedValues { get; set; }
}
