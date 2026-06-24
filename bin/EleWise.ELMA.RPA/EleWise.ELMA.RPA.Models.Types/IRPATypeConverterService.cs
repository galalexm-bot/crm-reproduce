using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.RPA.Model.Types.Converters;

namespace EleWise.ELMA.RPA.Models.Types.Converters;

public interface IRPATypeConverterService
{
	IEnumerable<ITypeDescriptor> ElmaTypeDescriptors { get; set; }

	IEnumerable<IRPATypeConverter> RPATypeConverters { get; set; }

	ITypeDescriptor GetElmaTypeDescriptor(IRPATypeConverter converter);

	IRPATypeConverter GetRPATypeConverter(Guid typeUid);
}
