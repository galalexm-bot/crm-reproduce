using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.RPA.Model.Types.Converters;

[Component]
internal class RPAIntTypeConverter : IRPATypeConverter
{
	public Guid ElmaTypeDescriptor => Int64Descriptor.UID;

	public string RPATypeDescriptor => "int";
}
