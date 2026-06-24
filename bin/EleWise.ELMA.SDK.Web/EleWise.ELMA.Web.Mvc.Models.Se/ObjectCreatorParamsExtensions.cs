using System.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Models.Selectors;

public static class ObjectCreatorParamsExtensions
{
	public static ObjectCreatorParams FromDictionary(IDictionary<string, object> dict)
	{
		if (dict != null && dict.Count > 0)
		{
			ObjectCreatorParams objectCreatorParams = new ObjectCreatorParams();
			{
				foreach (KeyValuePair<string, object> item2 in dict)
				{
					ObjectCreatorParam item = new ObjectCreatorParam
					{
						Key = item2.Key,
						Value = item2.Value.ToString()
					};
					objectCreatorParams.Params.Add(item);
				}
				return objectCreatorParams;
			}
		}
		return null;
	}
}
