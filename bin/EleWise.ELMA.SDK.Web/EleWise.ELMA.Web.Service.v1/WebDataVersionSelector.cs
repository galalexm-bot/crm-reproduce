using System;
using System.ServiceModel.Web;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Models.API;

namespace EleWise.ELMA.Web.Service.v1;

public static class WebDataVersionSelector
{
	public static EleWise.ELMA.Common.Models.WebData UpdateVersion(this EleWise.ELMA.Common.Models.WebData data)
	{
		if (data == null)
		{
			return null;
		}
		if (WebOperationContext.Current != null)
		{
			string text = WebOperationContext.Current.IncomingRequest.Headers.Get("WebData-Version");
			if (!string.IsNullOrWhiteSpace(text) && string.Equals(text, "2.0", StringComparison.InvariantCultureIgnoreCase) && !(data is EleWise.ELMA.Common.Models.API.WebData))
			{
				return EleWise.ELMA.Common.Models.API.WebData.Create(data);
			}
		}
		return data;
	}
}
