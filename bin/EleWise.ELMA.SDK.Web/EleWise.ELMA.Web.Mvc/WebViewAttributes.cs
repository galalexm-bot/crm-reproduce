using System;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc;

public class WebViewAttributes : ViewAttributes
{
	public HtmlAttributes Html { get; set; }

	public RouteValueDictionary AdditionalViewData { get; set; }

	public bool RenderContainer { get; set; }

	public string ContainerTagName { get; set; }

	public Action<TagBuilder> ContainerBuilderAction { get; set; }

	[XmlIgnore]
	public Guid? ViewItemUid { get; set; }

	public ViewItemTransformation ViewItemTransformation { get; set; }

	[XmlIgnore]
	public bool NeedPostfix { get; set; }

	public string Target { get; set; }

	public WebViewAttributes()
	{
		Html = new HtmlAttributes();
	}

	public void Container(string tagName = null, Action<TagBuilder> builderAction = null)
	{
		RenderContainer = true;
		ContainerTagName = tagName;
		ContainerBuilderAction = builderAction;
	}

	public void CopyFrom(ViewAttributes a)
	{
		if (a == null)
		{
			return;
		}
		foreach (PropertyInfo item in from p in a.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy)
			where p.CanRead && p.CanWrite
			select p)
		{
			item.SetValue(this, item.GetValue(a, null), null);
		}
	}
}
