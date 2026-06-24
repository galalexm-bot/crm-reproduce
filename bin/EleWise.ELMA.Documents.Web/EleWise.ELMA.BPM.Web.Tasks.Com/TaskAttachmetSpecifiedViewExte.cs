using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 10)]
internal class TaskAttachmetSpecifiedViewExtension : ITaskAttachmetSpecifiedViewExtension
{
	public string Name => "DocAttachments";

	public MvcHtmlString Attachments(HtmlHelper html, IEnumerable<IEntity<long>> attachments)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (IEntity<long> attachment in attachments)
		{
			stringBuilder.Append(((object)PartialExtensions.Partial(html, "DisplayTemplates/Entities/DocumentAttachment", (object)attachment)).ToString());
		}
		return MvcHtmlString.Create(stringBuilder.ToString());
	}
}
