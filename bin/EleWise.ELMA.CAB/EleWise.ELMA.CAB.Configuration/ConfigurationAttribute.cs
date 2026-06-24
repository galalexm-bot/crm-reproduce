using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using EleWise.ELMA.CAB.Properties;
using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB.Configuration;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
public sealed class ConfigurationAttribute : ParameterAttribute
{
	private class ConfigurationParameter : KnownTypeParameter
	{
		private static readonly Dictionary<string, ApplicationSettingsBase> cache = new Dictionary<string, ApplicationSettingsBase>();

		private readonly string settingsKey;

		public ConfigurationParameter(Type type, string settingsKey)
			: base(type)
		{
			this.settingsKey = settingsKey;
		}

		public override object GetValue(IBuilderContext context)
		{
			lock (cache)
			{
				string text = base.type.ToString();
				if (settingsKey != null)
				{
					text = text + "-" + settingsKey;
				}
				ApplicationSettingsBase applicationSettingsBase = cache[text];
				if (applicationSettingsBase == null)
				{
					applicationSettingsBase = (ApplicationSettingsBase)context.get_HeadOfChain().BuildUp(context, base.type, (object)null, (string)null);
					if (settingsKey != null)
					{
						applicationSettingsBase.SettingsKey = settingsKey;
					}
					cache.Add(text, applicationSettingsBase);
				}
				return applicationSettingsBase;
			}
		}
	}

	private readonly string settingsKey;

	public ConfigurationAttribute()
	{
	}

	public ConfigurationAttribute(string settingsKey)
	{
		this.settingsKey = settingsKey;
	}

	public override IParameter CreateParameter(Type memberType)
	{
		if (!typeof(ApplicationSettingsBase).IsAssignableFrom(memberType))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.ConfigurationAttributeOnValueWithIncompatibleType, new object[1] { memberType }));
		}
		return (IParameter)(object)new ConfigurationParameter(memberType, settingsKey);
	}
}
