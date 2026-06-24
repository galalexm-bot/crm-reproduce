using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.RPA.Model.Types.Converters;

namespace EleWise.ELMA.RPA.Models.Types.Converters;

[Component]
internal class RPABooleanTypeConverter : IRPATypeConverter
{
	public Guid ElmaTypeDescriptor => BoolDescriptor.UID;

	public string RPATypeDescriptor => "bool";
}
