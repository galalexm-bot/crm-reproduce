using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Functions;

namespace EleWise.ELMA.Tasks.Notifications;

[Component]
public class WorkLogItemGeneratorFunctionContainer : ITemplateGeneratorFunctionsContainer
{
	public static FormatedValue WorkTimeToFormatString(FunctionEvaluationContext context)
	{
		string value = "";
		if (context != null && context.Parameters != null && context.Parameters.Count > 0)
		{
			FormatedValue formatedValue = context.Parameters[0];
			if (formatedValue != null && formatedValue.Value != null && formatedValue.Value is WorkTime?)
			{
				value = ((WorkTime?)formatedValue.Value).Value.ToShortFormat();
			}
		}
		return new FormatedValue(value);
	}

	public static FormatedValue LoadEntityByWorkLogItem(FunctionEvaluationContext context)
	{
		IEntity value = null;
		if (context != null && context.Parameters != null && context.Parameters.Count > 0)
		{
			FormatedValue formatedValue = context.Parameters[0];
			if (formatedValue != null && formatedValue.Value != null && formatedValue.Value is IWorkLogItem)
			{
				IWorkLogItem workLogItem = (IWorkLogItem)formatedValue.Value;
				value = WorkLogExtensionHelper.LoadObject(workLogItem.ObjectId, workLogItem.ObjectUID);
			}
		}
		return new FormatedValue(value);
	}

	public static FormatedValue GetEntityDisplayNameByWorkLogItem(FunctionEvaluationContext context)
	{
		string value = "";
		if (context != null && context.Parameters != null && context.Parameters.Count > 0)
		{
			FormatedValue formatedValue = context.Parameters[0];
			if (formatedValue != null && formatedValue.Value != null && formatedValue.Value is IWorkLogItem && MetadataLoader.LoadMetadata(((IWorkLogItem)formatedValue.Value).ObjectUID) is ClassMetadata classMetadata)
			{
				value = classMetadata.DisplayName;
			}
		}
		return new FormatedValue(value);
	}

	[Obsolete("Используйте LoadEntityByWorkLogItem")]
	public static FormatedValue GetObject(FunctionEvaluationContext context)
	{
		return LoadEntityByWorkLogItem(context);
	}

	[Obsolete("Используйте GetEntityDisplayNameByWorkLogItem")]
	public static FormatedValue ObjectDisplayName(FunctionEvaluationContext context)
	{
		return GetEntityDisplayNameByWorkLogItem(context);
	}
}
