using System.Collections.Generic;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal;

internal interface IModuleMapperService : IMapperService
{
	IEnumerable<IInternalMapperConfiguration> ModuleMappers { get; set; }
}
