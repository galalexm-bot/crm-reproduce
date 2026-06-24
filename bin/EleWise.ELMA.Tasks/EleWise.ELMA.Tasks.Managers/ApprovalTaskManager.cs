using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Managers;

public class ApprovalTaskManager : TaskBaseManager<IApprovalTask>
{
	[NotNull]
	public new static ApprovalTaskManager Instance => Locator.GetServiceNotNull<ApprovalTaskManager>();

	public override ExportRuleList ExportRules()
	{
		Type parentType = InterfaceActivator.TypeOf<IApprovalTask>();
		return new ExportRuleList
		{
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "ApprovalStatus",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "ParentStatus",
				ExportRuleType = ExportRuleType.Export
			}
		};
	}
}
