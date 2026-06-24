using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings.Events;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Settings;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public class GlobalSettingsBase : IStoreValuesObject
{
	private IGlobalSettingsEventHandler _globalSettingsEventHandler;

	private readonly IDictionary<string, string> _settingsData;

	private static GlobalSettingsBase tbSZr2Wh0FSqb5NohpfF;

	[HiddenInput(DisplayValue = false)]
	public IGlobalSettingsEventHandler GlobalSettingsEventHandler
	{
		get
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (_globalSettingsEventHandler == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 1:
					_globalSettingsEventHandler = Locator.GetService<IGlobalSettingsEventHandler>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			return _globalSettingsEventHandler;
		}
	}

	[HiddenInput(DisplayValue = false)]
	public virtual IDictionary<string, string> SettingsData => _settingsData;

	protected virtual IDictionary<string, string> GetStorageValue(PropertyInfo property)
	{
		object value = property.GetValue(this, null);
		TypeConverter converter = TypeDescriptor.GetConverter(property.PropertyType);
		string value2 = ((converter != null && converter.CanConvertTo(typeof(string))) ? converter.ConvertToInvariantString(value) : ClassSerializationHelper.SerializeObjectByJson(value));
		return new Dictionary<string, string> { { property.Name, value2 } };
	}

	protected virtual bool SkipProperty(PropertyInfo property)
	{
		//Discarded unreachable code: IL_0122
		int num = 7;
		int num2 = num;
		IgnoreDataMemberAttribute attribute2 = default(IgnoreDataMemberAttribute);
		HiddenInputAttribute attribute = default(HiddenInputAttribute);
		while (true)
		{
			switch (num2)
			{
			default:
				return true;
			case 1:
				attribute2 = AttributeHelper<IgnoreDataMemberAttribute>.GetAttribute(property, inherited: true);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 4;
				}
				break;
			case 5:
				if (TfPm9fWh9gxrLS8oxEV9(attribute))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 2;
					}
					break;
				}
				return true;
			case 4:
				if (attribute == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 5;
			case 7:
				if (zRwBZEWhMAFeXpXQsm3w(property))
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto default;
			case 2:
			case 3:
				return attribute2 != null;
			case 6:
				if (ASsLgVWhJbeVqbQ8wZFh(property))
				{
					attribute = AttributeHelper<HiddenInputAttribute>.GetAttribute(property, inherited: true);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	protected virtual void SetStorageValue(PropertyInfo property, IDictionary<string, string> values)
	{
		if (values.ContainsKey(property.Name))
		{
			object obj = null;
			string text = values[property.Name];
			try
			{
				TypeConverter converter = TypeDescriptor.GetConverter(property.PropertyType);
				obj = ((converter != null && converter.CanConvertFrom(typeof(string))) ? converter.ConvertFromInvariantString(text) : ClassSerializationHelper.DeserializeObjectByJson(property.PropertyType, text));
				GlobalSettingsEventHandler.ChangeSetting(new EditGlobalSettingsEventArgs(property, this, text));
			}
			catch (Exception exception)
			{
				Logger.Log.Error(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29301569), property.Name, property.DeclaringType.FullName), exception);
			}
			if (obj != null)
			{
				property.SetValue(this, obj, null);
			}
		}
	}

	public virtual IDictionary<string, string> GetStorageValues()
	{
		Dictionary<string, string> dictionary = (from property in GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
			where !uSQkpgWhlle7gTAoMGAE(this, property)
			where ((Array)_003C_003Ec.tVOrfgQNGptvjo25vB48(property)).Length == 0
			select property).SelectMany(GetStorageValue).ToDictionary((KeyValuePair<string, string> k) => k.Key, (KeyValuePair<string, string> v) => v.Value);
		foreach (KeyValuePair<string, string> item in dictionary)
		{
			SettingsData[item.Key] = item.Value;
		}
		return dictionary;
	}

	public virtual void SetStorageValues(IDictionary<string, string> values)
	{
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals0.values = values;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		if (CS_0024_003C_003E8__locals0.values == null)
		{
			return;
		}
		(from property in GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
			where CS_0024_003C_003E8__locals0.values.Keys.Contains((string)_003C_003Ec__DisplayClass7_0.ywSmSSQNCiWbIho3vsOa(property))
			where !CS_0024_003C_003E8__locals0._003C_003E4__this.SkipProperty(property)
			where ((Array)_003C_003Ec.tVOrfgQNGptvjo25vB48(property)).Length == 0
			select property).ForEach(delegate(PropertyInfo property)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					CS_0024_003C_003E8__locals0._003C_003E4__this.SetStorageValue(property, CS_0024_003C_003E8__locals0.values);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		});
		SettingsData.Clear();
		foreach (KeyValuePair<string, string> value in CS_0024_003C_003E8__locals0.values)
		{
			SettingsData[value.Key] = value.Value;
		}
	}

	public GlobalSettingsBase()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		i5Dg9CWhd6UCSXnEKNOl();
		_settingsData = new Dictionary<string, string>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool TDdjujWhmqqkXm57QfNa()
	{
		return tbSZr2Wh0FSqb5NohpfF == null;
	}

	internal static GlobalSettingsBase WrmuZeWhyPSc9potfXId()
	{
		return tbSZr2Wh0FSqb5NohpfF;
	}

	internal static bool zRwBZEWhMAFeXpXQsm3w(object P_0)
	{
		return ((PropertyInfo)P_0).CanRead;
	}

	internal static bool ASsLgVWhJbeVqbQ8wZFh(object P_0)
	{
		return ((PropertyInfo)P_0).CanWrite;
	}

	internal static bool TfPm9fWh9gxrLS8oxEV9(object P_0)
	{
		return ((HiddenInputAttribute)P_0).get_DisplayValue();
	}

	internal static void i5Dg9CWhd6UCSXnEKNOl()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool uSQkpgWhlle7gTAoMGAE(object P_0, object P_1)
	{
		return ((GlobalSettingsBase)P_0).SkipProperty((PropertyInfo)P_1);
	}
}
