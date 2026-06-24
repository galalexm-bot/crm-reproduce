using System;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Web.Mvc;

public class ElmaJsonResult : JsonResult
{
	public override void ExecuteResult(ControllerContext context)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if ((int)((JsonResult)this).get_JsonRequestBehavior() == 1 && string.Equals(context.get_HttpContext().Request.HttpMethod, "GET", StringComparison.OrdinalIgnoreCase))
		{
			throw new InvalidOperationException(SR.T("Использование запроса GET не разрешено в данном методе"));
		}
		HttpResponseBase response = context.get_HttpContext().Response;
		response.ContentType = (string.IsNullOrEmpty(((JsonResult)this).get_ContentType()) ? "application/json" : ((JsonResult)this).get_ContentType());
		if (((JsonResult)this).get_ContentEncoding() != null)
		{
			response.ContentEncoding = ((JsonResult)this).get_ContentEncoding();
		}
		if (((JsonResult)this).get_Data() != null)
		{
			JsonSerializer jsonSerializer = new JsonSerializer();
			if (((JsonResult)this).get_MaxJsonLength().HasValue)
			{
				jsonSerializer.MaxJsonLength = ((JsonResult)this).get_MaxJsonLength().Value;
			}
			if (((JsonResult)this).get_RecursionLimit().HasValue)
			{
				jsonSerializer.RecursionLimit = ((JsonResult)this).get_RecursionLimit().Value;
			}
			response.Write(jsonSerializer.Serialize(((JsonResult)this).get_Data()));
		}
	}
}
