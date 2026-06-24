using System;
using System.Drawing;
using System.IO;

namespace EleWise.TemplateGenerator.Formats;

public class GeneratorFormatProvider : IGeneratorFormatProvider
{
	private GenerationContext context;

	private int? diffBtTemplateDtAndRuntimeDt;

	protected GenerationContext Context => context;

	public GeneratorFormatProvider(GenerationContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		this.context = context;
	}

	public virtual string FormatValue(FormatedValue value)
	{
		TransformDateTime(value);
		string s = ((value != null && value.Value != null) ? value.Value.ToString() : string.Empty);
		return AdaptNewLines(s);
	}

	protected void TransformDateTime(FormatedValue value)
	{
		if (value == null || value.Value == null)
		{
			return;
		}
		DateTime? dateTime = value.Value as DateTime?;
		if (!dateTime.HasValue || !Context.ExtendedProperties.ContainsKey("TemplateTimeZoneOffset"))
		{
			return;
		}
		object obj = Context.ExtendedProperties["TemplateTimeZoneOffset"];
		if (obj != null)
		{
			if (!diffBtTemplateDtAndRuntimeDt.HasValue)
			{
				TimeZoneInfo.ClearCachedData();
				int num = Convert.ToInt32(DateTimeOffset.Now.Offset.TotalMinutes);
				diffBtTemplateDtAndRuntimeDt = (int)obj - num;
			}
			value.Value = dateTime.Value.AddMinutes(diffBtTemplateDtAndRuntimeDt.Value);
		}
	}

	public virtual Image GetImage(FormatedValue value)
	{
		if (value == null)
		{
			return null;
		}
		object obj = ((value.Value is FormatedValue) ? ((FormatedValue)value.Value).Value : value.Value);
		if (obj == null)
		{
			return null;
		}
		if (obj is Image)
		{
			return (Image)obj;
		}
		string text = obj.ToString();
		if (File.Exists(text))
		{
			return Image.FromFile(text);
		}
		return null;
	}

	protected virtual string AdaptNewLines(string s)
	{
		return s?.Replace("\r\n", "\r").Replace("\r", "\n").Replace("\n", "\r\n");
	}
}
