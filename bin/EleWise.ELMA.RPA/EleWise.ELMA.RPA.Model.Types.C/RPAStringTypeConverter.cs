using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.RPA.Model.Types.Converters;

[Component]
internal class RPAStringTypeConverter : IRPATypeConverter
{
	public string RPATypeDescriptor => "string";

	public Guid ElmaTypeDescriptor => StringDescriptor.UID;
}
