using EleWise.ELMA.Model.Mappings;

namespace EleWise.ELMA.RPA.Models.Mappings;

internal interface IRPAPropertyMapService
{
	void MapFromRPA(object objLeft, object objRight, PropertyMap map, string rpaOutContext);

	string MapToRPA(object objLeft, object objRight, PropertyMap map);
}
