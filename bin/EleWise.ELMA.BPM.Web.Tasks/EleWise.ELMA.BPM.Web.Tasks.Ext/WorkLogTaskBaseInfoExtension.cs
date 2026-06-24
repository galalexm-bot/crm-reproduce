using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component(EnableInterceptiors = false, Order = 10)]
public class WorkLogTaskBaseInfoExtension : IEntityInfoExtension
{
	public Guid Uid => new Guid("D01229A6-8DD0-4831-9E43-31B4C11282A9");

	public Guid EntityUid => InterfaceActivator.UID<ITaskBase>();

	public MvcHtmlString EntityInfo(HtmlHelper htmlHelper, IEntity entity, string url, string defaultTitle = "")
	{
		return htmlHelper.StatusLink(entity as ITaskBase, showInfo: true, url, showAuthor: false, completeAlwaysThrough: false, defaultTitle, false);
	}
}
