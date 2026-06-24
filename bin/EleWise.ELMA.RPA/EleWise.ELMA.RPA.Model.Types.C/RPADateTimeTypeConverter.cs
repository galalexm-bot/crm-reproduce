using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.RPA.Model.Types.Converters;

[Component]
internal class RPADateTimeTypeConverter : IRPATypeConverter
{
	public Guid ElmaTypeDescriptor => DateTimeDescriptor.UID;

	public string RPATypeDescriptor => "datetime";
}
