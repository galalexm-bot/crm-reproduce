using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace Orchard.Mvc.ViewEngines;

public class LayoutViewContext
{
	private static readonly object _key = typeof(LayoutViewContext);

	public string BodyContent { get; set; }

	public IDictionary<string, TextWriter> Contents { get; set; }

	private LayoutViewContext()
	{
		Contents = new Dictionary<string, TextWriter>();
	}

	public static LayoutViewContext From(ControllerContext context)
	{
		return From(context.get_HttpContext());
	}

	public static LayoutViewContext From(HttpContextBase context)
	{
		if (!context.Items.Contains(_key))
		{
			context.Items.Add(_key, new LayoutViewContext());
		}
		return (LayoutViewContext)context.Items[_key];
	}

	public TextWriter GetNamedContent(string name)
	{
		if (!Contents.ContainsKey(name))
		{
			Contents.Add(name, new StringWriter());
		}
		return Contents[name];
	}
}
