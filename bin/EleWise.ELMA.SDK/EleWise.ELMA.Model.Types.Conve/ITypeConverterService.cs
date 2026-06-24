using System;

namespace EleWise.ELMA.Model.Types.Convertors;

public interface ITypeConverterService
{
	bool CanConvert(Guid sourceTypeUid, Guid targetTypeUid);

	ITypeConvertor GetConverterToTargetType(Guid targetTypeUid);
}
