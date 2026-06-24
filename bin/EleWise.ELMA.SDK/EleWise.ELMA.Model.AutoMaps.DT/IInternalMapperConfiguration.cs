using System;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal;

internal interface IInternalMapperConfiguration
{
	Type SourceType { get; }

	string TypeRef { get; }

	object CreateSourceInstance(DataClass dataClass);

	DataClass CreateDestinationInstance();

	void BeforeMap(object source, DataClass destination, IInternalMapperService mapperService);

	void Map(object source, DataClass destination, IInternalMapperService mapperService);

	void Map(ClassMetadata metadata, object source, DataClass destination, IInternalMapperService mapperService);

	void BeforeMapReverse(DataClass source, object destination, IInternalMapperService mapperService);

	void MapReverse(DataClass source, object destination, IInternalMapperService mapperService);

	void MapReverse(ClassMetadata metadata, DataClass source, object destination, IInternalMapperService mapperService);
}
