using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class LeadCommentHistoryPartProvider : CommentHistoryPartProviderBase
{
	protected override bool CheckEntity(HtmlHelper html, IEntity entity)
	{
		return entity is ILead;
	}

	protected override bool CheckEventActionObject(HtmlHelper html, ICommentedHistoryModel eventData)
	{
		return eventData is ILeadHistoryBaseModel;
	}
}
