using System;
using EleWise.ELMA.DataClasses;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal;

internal interface IInternalMapperService
{
	IInternalMapperConfiguration GetMapper(Type declaredSourceType, Guid metadataUid);

	IInternalMapperConfiguration GetMapper(Guid metadataUid);

	IInternalMapperConfiguration GetMapper(DataClass dataClass, Type declaredSourceType);
}
