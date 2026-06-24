using System.IO;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.Web.Mvc.Telerik;

public static class ElmaTelerikInitializer
{
	private static bool initialized;

	private static readonly object syncObj = new object();

	public static void Init()
	{
		if (initialized)
		{
			return;
		}
		lock (syncObj)
		{
			if (!initialized)
			{
				ClientSideObjectWriterFactory.CreateFunc = (string id, string type, TextWriter textWriter) => (IClientSideObjectWriter)(object)new TelerikClientSideObjectWriter(id, type, textWriter);
				initialized = true;
			}
		}
	}
}
