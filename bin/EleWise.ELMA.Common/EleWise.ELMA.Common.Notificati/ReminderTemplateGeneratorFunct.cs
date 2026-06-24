using System;
using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Functions;

namespace EleWise.ELMA.Common.Notifications;

[Component]
public class ReminderTemplateGeneratorFunctions : ITemplateGeneratorFunctionsContainer
{
	[Obsolete("Используйте GetReminderTimeSpan")]
	public static FormatedValue RemindTime(FunctionEvaluationContext context)
	{
		return GetReminderTimeSpan(context);
	}

	public static FormatedValue GetReminderTimeSpan(FunctionEvaluationContext context)
	{
		if (context.Parameters.Count < 1 || context.Parameters[0] == null)
		{
			return null;
		}
		if (!(context.Parameters[0].Value is IReminder reminder))
		{
			return null;
		}
		return new FormatedValue(reminder.GetRemindString());
	}
}
