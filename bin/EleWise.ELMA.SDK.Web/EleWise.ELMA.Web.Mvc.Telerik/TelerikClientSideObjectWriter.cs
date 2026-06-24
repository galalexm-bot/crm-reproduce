using System.IO;
using System.Web.Script.Serialization;
using EleWise.ELMA.Serialization;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.Web.Mvc.Telerik;

internal class TelerikClientSideObjectWriter : ClientSideObjectWriter
{
	public TelerikClientSideObjectWriter(string id, string type, TextWriter textWriter)
		: base(id, type, textWriter)
	{
	}

	protected override JavaScriptSerializer CreateJsonSerializer()
	{
		return new JsonSerializer();
	}
}
