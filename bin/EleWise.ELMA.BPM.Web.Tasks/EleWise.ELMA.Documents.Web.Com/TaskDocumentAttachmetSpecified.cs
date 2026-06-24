using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 20)]
internal class TaskDocumentAttachmetSpecifiedViewExtension : ITaskAttachmetSpecifiedViewExtension
{
	public string Name => "Attachments";

	public MvcHtmlString Attachments(HtmlHelper html, IEnumerable<IEntity<long>> attachments)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (IEntity<long> attachment in attachments)
		{
			stringBuilder.Append(((object)PartialExtensions.Partial(html, "DisplayTemplates/Entities/Attachment", (object)attachment)).ToString());
		}
		return MvcHtmlString.Create(stringBuilder.ToString());
	}
}
