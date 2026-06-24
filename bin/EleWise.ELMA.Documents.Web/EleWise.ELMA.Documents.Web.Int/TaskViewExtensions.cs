using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Documents.Web.Integration.Tasks;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class TaskViewExtensions : IExtensionZone
{
	private static readonly List<string> zones = new List<string> { "EleWise.ELMA.BPM.Web.Tasks.ViewForm-BeforeTabView" };

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zones.Contains(zoneId);
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (!zones.Contains(zoneId) || !(html.get_ViewData().get_Model() is TaskViewModel taskViewModel) || taskViewModel.Entity == null)
		{
			return;
		}
		foreach (IDocumentAttachment item in ((IEnumerable<IDocumentAttachment>)((IAttachmentsTaskBase)taskViewModel.Entity).DocumentAttachments).Where((IDocumentAttachment a) => a.Document != null))
		{
			html.get_ViewContext().get_Writer().Write(html.LastObjectHandler(new LastObjectInfoModel
			{
				ObjectId = item.Document.Id,
				ObjectType = InterfaceActivator.UID<IDocument>()
			}));
		}
	}
}
