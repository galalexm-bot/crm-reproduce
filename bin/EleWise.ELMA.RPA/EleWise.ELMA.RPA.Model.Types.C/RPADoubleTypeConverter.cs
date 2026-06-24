using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.RPA.Model.Types.Converters;

[Component]
internal class RPADoubleTypeConverter : IRPATypeConverter
{
	public Guid ElmaTypeDescriptor => DoubleDescriptor.UID;

	public string RPATypeDescriptor => "double";
}
