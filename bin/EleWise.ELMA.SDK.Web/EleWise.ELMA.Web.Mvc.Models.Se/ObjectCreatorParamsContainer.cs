using System.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Models.Selectors;

public class ObjectCreatorParamsContainer
{
	public List<ObjectCreatorParams> CreatorParams { get; set; }

	public ObjectCreatorParamsContainer()
	{
		CreatorParams = new List<ObjectCreatorParams>();
	}
}
