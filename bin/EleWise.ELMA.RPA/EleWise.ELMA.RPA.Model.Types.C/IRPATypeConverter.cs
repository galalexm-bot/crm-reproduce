using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.RPA.Model.Types.Converters;

[ExtensionPoint(ComponentType.All)]
public interface IRPATypeConverter
{
	Guid ElmaTypeDescriptor { get; }

	string RPATypeDescriptor { get; }
}
