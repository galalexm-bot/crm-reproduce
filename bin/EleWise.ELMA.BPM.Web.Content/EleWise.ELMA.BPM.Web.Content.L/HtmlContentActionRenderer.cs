using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content;
using HtmlAgilityPack;

namespace EleWise.ELMA.BPM.Web.Content.LinkTypeProviders;

[Service(Scope = ServiceScope.Shell)]
public class HtmlContentActionRenderer
{
	private readonly ContentActionRegistry contentActionRegistry;

	public HtmlContentActionRenderer(ContentActionRegistry contentActionRegistry)
	{
		this.contentActionRegistry = contentActionRegistry;
	}

	public string PrepareMarkup(string data, HtmlHelper html)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		HtmlDocument val = new HtmlDocument();
		val.Load((TextReader)new StringReader(data));
		HtmlNodeCollection val2 = val.get_DocumentNode().SelectNodes("//a[@action-provider] | //input[@action-provider] | //button[@action-provider]");
		if (val2 == null)
		{
			return data;
		}
		foreach (HtmlNode item in (IEnumerable<HtmlNode>)val2)
		{
			string attributeValue = item.GetAttributeValue("action-provider", (string)null);
			if (attributeValue == null)
			{
				continue;
			}
			string text = item.GetAttributeValue("action-data", (string)null);
			if (text != null)
			{
				text = text.Replace("&quot;", "\"").Replace("&amp;", "&");
			}
			IContentAction contentAction = contentActionRegistry.Get(attributeValue, text);
			if (contentAction == null)
			{
				item.SetAttributeValue("href", "#invalid_action_data");
				continue;
			}
			string text2 = contentAction.GetHref(((ControllerContext)html.get_ViewContext()).get_RequestContext()).Replace("&", "&amp;").Replace("\"", "&quot;");
			if (item.get_Name() == "a")
			{
				if (contentAction.ActionType == ContentAction.ActionTypeDialog)
				{
					item.SetAttributeValue("href", "javascript:void(0);");
					item.SetAttributeValue("onclick", text2);
				}
				else
				{
					item.SetAttributeValue("href", text2);
				}
			}
			else if (item.get_Name() == "input" || item.get_Name() == "button")
			{
				if (contentAction.ActionType == ContentAction.ActionTypeDialog)
				{
					item.SetAttributeValue("onclick", text2.Replace("javascript:", ""));
				}
				else
				{
					item.SetAttributeValue("onclick", $"elma.openPleaseWait(true); location.href='{text2}'");
				}
			}
			contentAction.OnRender(html);
		}
		StringWriter stringWriter = new StringWriter(new StringBuilder(data.Length));
		val.Save((TextWriter)stringWriter);
		return stringWriter.ToString();
	}
}
