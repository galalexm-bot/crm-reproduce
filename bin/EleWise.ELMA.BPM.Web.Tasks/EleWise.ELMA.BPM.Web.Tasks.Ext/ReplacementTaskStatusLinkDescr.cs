using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component(Order = 10)]
public class ReplacementTaskStatusLinkDescription : ITaskStatusLinkDescription
{
	public bool CheckType(ITaskBase task)
	{
		return task.TypeUid == InterfaceActivator.UID<IReplacementTask>();
	}

	public MvcHtmlString Description(HtmlHelper htmlHelper, ITaskBase task)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		bool? obj = (bool?)htmlHelper.get_ViewData().get_Item("Portlet");
		TagBuilder val = new TagBuilder("span");
		string innerHtml = ((obj == true) ? SR.T("Переназначение активных задач ({0})", ((HtmlString)(object)PartialExtensions.Partial(htmlHelper, "DisplayTemplates/Entities/User", (object)task.CreationAuthor)).ToHtmlString()) : SR.T("Переназначение активных задач"));
		val.set_InnerHtml(innerHtml);
		val.get_Attributes().Add("style", "color: Grey");
		return MvcHtmlString.Create(val.ToString((TagRenderMode)0));
	}
}
