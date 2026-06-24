using System.Collections.Generic;
using EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Mappers;

internal interface IInternalMapperConfigurator
{
	IEnumerable<IInternalMapperConfiguration> Init();
}
