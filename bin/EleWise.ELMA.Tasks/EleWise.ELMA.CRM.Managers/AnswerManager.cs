using System;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class AnswerManager : EntityManager<IAnswer, long>
{
	public override ExportRuleList ExportRules()
	{
		Locator.GetServiceNotNull<IMetadataRuntimeService>();
		Type parentType = InterfaceActivator.TypeOf<IAnswer>();
		return new ExportRuleList
		{
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Attachments",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "CreationAuthor",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "CreationDate",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Question",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "ShowAll",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Text",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Uid",
				ExportRuleType = ExportRuleType.Export
			}
		};
	}
}
