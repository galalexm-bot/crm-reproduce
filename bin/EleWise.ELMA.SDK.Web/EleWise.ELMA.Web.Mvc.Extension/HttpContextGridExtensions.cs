using System.Web;

namespace EleWise.ELMA.Web.Mvc.Extensions;

public static class HttpContextGridExtensions
{
	public static bool EditingFormEnabled(this HttpContextBase context, bool? enabled = null)
	{
		if (context == null)
		{
			return true;
		}
		if (enabled.HasValue)
		{
			context.UpdateItem("editingRowFormStarted", enabled);
		}
		return (bool)(context.Items["editingRowFormStarted"] ?? ((object)true));
	}
}
