using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Mappings;

public interface IPropertyMapService
{
	void Map(object objLeft, object objRight, PropertyMap map);

	void MapProperty(object objRight, PropertyMetadata rightPropMd, object leftValue, PropertyMetadata leftPropMetadata);

	void MapTablePart(object objLeft, object objRight, TablePartMetadata leftTp, TablePartMetadata rightTp, PropertyMap map);
}
