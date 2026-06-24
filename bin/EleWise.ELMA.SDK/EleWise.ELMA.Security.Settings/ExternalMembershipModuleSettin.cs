using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Settings;

public abstract class ExternalMembershipModuleSettings : IExternalMembershipModuleSettings, IStoreValuesObject
{
	private bool deletable;

	internal static ExternalMembershipModuleSettings XeKeg3BY6sSqEdrccF87;

	public abstract Guid ModuleUid { get; }

	public Guid InstanceUid
	{
		[CompilerGenerated]
		get
		{
			return _003CInstanceUid_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CInstanceUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(ExternalMembershipSettings_SR), "Name")]
	public abstract string Name { get; }

	public virtual bool Deletable
	{
		get
		{
			return deletable;
		}
		set
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
					deletable = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public virtual IDictionary<string, string> GetStorageValue(PropertyInfo property)
	{
		object value = property.GetValue(this, null);
		TypeConverter converter = TypeDescriptor.GetConverter(property.PropertyType);
		string value2 = ((converter != null && converter.CanConvertTo(typeof(string))) ? converter.ConvertToInvariantString(value) : ClassSerializationHelper.SerializeObjectByJson(value));
		return new Dictionary<string, string> { { property.Name, value2 } };
	}

	public virtual void SetStorageValue(PropertyInfo property, IDictionary<string, string> values)
	{
		if (values.ContainsKey(property.Name))
		{
			object obj = null;
			string text = values[property.Name];
			try
			{
				TypeConverter converter = TypeDescriptor.GetConverter(property.PropertyType);
				obj = ((converter != null && converter.CanConvertFrom(typeof(string))) ? converter.ConvertFromInvariantString(text) : ClassSerializationHelper.DeserializeObjectByJson(property.PropertyType, text));
			}
			catch (Exception exception)
			{
				Logger.Log.Error(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE002A9), property.Name, property.DeclaringType.FullName), exception);
			}
			if (obj != null)
			{
				property.SetValue(this, obj, null);
			}
		}
	}

	protected virtual bool SkipProperty(PropertyInfo property)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (KIpIHqBY76AeytdK8heo(property))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 0;
					}
					break;
				}
				return true;
			default:
				return !qVNEHXBYx1mmgjKeQgkr(property);
			}
		}
	}

	private static bool SkipPropertyByAttribute(object property)
	{
		return AttributeHelper<XmlIgnoreAttribute>.GetAttribute((MemberInfo)property, inherited: true) != null;
	}

	IDictionary<string, string> IStoreValuesObject.GetStorageValues()
	{
		return (from property in GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
			where !_003C_003Ec.Y5lsg3QPZc3JaDlyZoXu(property)
			where !hxP3ooBY0o4CiwEVoeMI(this, property)
			where ((Array)_003C_003Ec.IejenZQPuCrRbjHys3TX(property)).Length == 0
			select property).SelectMany(GetStorageValue).ToDictionary((KeyValuePair<string, string> k) => k.Key, (KeyValuePair<string, string> v) => v.Value);
	}

	void IStoreValuesObject.SetStorageValues(IDictionary<string, string> values)
	{
		_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass17_0();
		CS_0024_003C_003E8__locals0.values = values;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		if (CS_0024_003C_003E8__locals0.values == null)
		{
			return;
		}
		(from property in GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
			where CS_0024_003C_003E8__locals0.values.Keys.Contains((string)_003C_003Ec__DisplayClass17_0.SmhStEQPRQeWCvSCNXgZ(property))
			where !_003C_003Ec.Y5lsg3QPZc3JaDlyZoXu(property)
			where !_003C_003Ec__DisplayClass17_0.wg4CS5QPqygFujiv0fj0(CS_0024_003C_003E8__locals0._003C_003E4__this, property)
			where ((Array)_003C_003Ec.IejenZQPuCrRbjHys3TX(property)).Length == 0
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
				case 0:
					return;
				case 1:
					CS_0024_003C_003E8__locals0._003C_003E4__this.SetStorageValue(property, CS_0024_003C_003E8__locals0.values);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
	}

	protected ExternalMembershipModuleSettings()
	{
		//Discarded unreachable code: IL_0036, IL_003b
		SingletonReader.JJCZtPuTvSt();
		deletable = true;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool uREA4EBYHx9SQGhNk6WL()
	{
		return XeKeg3BY6sSqEdrccF87 == null;
	}

	internal static ExternalMembershipModuleSettings vfW6fnBYAW5j1RuhB6QH()
	{
		return XeKeg3BY6sSqEdrccF87;
	}

	internal static bool KIpIHqBY76AeytdK8heo(object P_0)
	{
		return ((PropertyInfo)P_0).CanRead;
	}

	internal static bool qVNEHXBYx1mmgjKeQgkr(object P_0)
	{
		return ((PropertyInfo)P_0).CanWrite;
	}

	internal static bool hxP3ooBY0o4CiwEVoeMI(object P_0, object P_1)
	{
		return ((ExternalMembershipModuleSettings)P_0).SkipProperty((PropertyInfo)P_1);
	}
}
