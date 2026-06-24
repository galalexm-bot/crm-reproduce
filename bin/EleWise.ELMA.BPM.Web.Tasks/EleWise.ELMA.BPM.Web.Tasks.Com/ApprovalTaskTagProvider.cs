using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
public class ApprovalTaskTagProvider : BaseEntityTypeTagProvider
{
	public override bool CheckType(IEntity entity)
	{
		return entity is IApprovalTask;
	}

	protected override string GetTagText(IEntity entity)
	{
		return SR.T("Согласовать задачу");
	}
}
