using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.CRM.Web.Extensions;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class RelationshipWorkLogEntityLinkDescription : IWorkLogEntityInfoLinkDescription
{
	public bool CheckType(IEntity entity)
	{
		return entity is IRelationship;
	}

	public MvcHtmlString Description(HtmlHelper htmlHelper, IEntity entity)
	{
		return PartialExtensions.Partial(htmlHelper, "WorkLogItem/RelationshipInfo", (object)entity);
	}
}
