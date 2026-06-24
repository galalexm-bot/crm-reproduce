using System;
using System.Collections;
using System.Linq;
using System.Web;
using EleWise.TemplateGenerator.Formats;

namespace EleWise.TemplateGenerator.Functions;

public static class DefaultFunctions
{
	public static FormatedValue Count(FunctionEvaluationContext context)
	{
		FormatedValue formatedValue = ((context.Parameters.Count > 0) ? context.Parameters[0] : null);
		if (formatedValue != null)
		{
			if (formatedValue.BlockInfo != null)
			{
				return new FormatedValue(formatedValue.BlockInfo.Count);
			}
			if (formatedValue.Value is IEnumerable)
			{
				return new FormatedValue(((IEnumerable)formatedValue.Value).Cast<object>().Count());
			}
		}
		return null;
	}

	public static FormatedValue Index(FunctionEvaluationContext context)
	{
		if (context.Parameters.Count > 0 && context.Parameters[0] != null && context.Parameters[0].BlockInfo != null)
		{
			return new FormatedValue(context.Parameters[0].BlockInfo.Index);
		}
		return null;
	}

	public static FormatedValue Image(FunctionEvaluationContext context)
	{
		if (context.Parameters.Count == 0)
		{
			return null;
		}
		DrawingFormat drawingFormat = new DrawingFormat();
		if (context.Parameters.Count > 1)
		{
			string text = ((context.Parameters[1] != null && context.Parameters[1].Value != null) ? context.Parameters[1].Value.ToString() : null);
			if (!string.IsNullOrEmpty(text))
			{
				drawingFormat.Parse(text);
			}
		}
		return new FormatedValue(context.Parameters[0].Value, drawingFormat);
	}

	public static FormatedValue HtmlString(FunctionEvaluationContext context)
	{
		HtmlString value = null;
		if (context != null && context.Parameters != null && context.Parameters.Count > 0)
		{
			FormatedValue formatedValue = context.Parameters[0];
			if (formatedValue != null && formatedValue.Value != null && formatedValue.Value is string)
			{
				value = new HtmlString((string)formatedValue.Value);
			}
		}
		return new FormatedValue(value);
	}

	public static FormatedValue StringCut(FunctionEvaluationContext context)
	{
		if (context.Parameters.Count < 2 || context.Parameters[0] == null || context.Parameters[1] == null)
		{
			return null;
		}
		string text = (string)context.Parameters[0].Value;
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		int num = Convert.ToInt32(context.Parameters[1].Value);
		return new FormatedValue((text.Length > num) ? $"{text.Substring(0, num - 2)}.." : text);
	}
}
