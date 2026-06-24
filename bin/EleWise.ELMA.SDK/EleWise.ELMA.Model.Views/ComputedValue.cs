using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[XmlInclude(typeof(InputComputedValue))]
public class ComputedValue : IComputedValue, ILocalizable
{
	private readonly IDictionary<string, PropertyInfo> localizableProperties;

	internal static ComputedValue zqXDZjoqPcWYMr0joL8d;

	[DefaultValue("")]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
				case 1:
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
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

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public object Value
	{
		[CompilerGenerated]
		get
		{
			return _003CValue_003Ek__BackingField;
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
				case 1:
					_003CValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
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

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue("")]
	public string MethodName
	{
		[CompilerGenerated]
		get
		{
			return _003CMethodName_003Ek__BackingField;
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
				case 1:
					_003CMethodName_003Ek__BackingField = value;
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

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue("")]
	public string CalculateScript
	{
		[CompilerGenerated]
		get
		{
			return _003CCalculateScript_003Ek__BackingField;
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
				case 1:
					_003CCalculateScript_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
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

	[DefaultValue(ComputedValueType.Input)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public ComputedValueType ComputedValueType
	{
		[CompilerGenerated]
		get
		{
			return _003CComputedValueType_003Ek__BackingField;
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
				case 1:
					_003CComputedValueType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
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

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue(ComputedValueType.Input)]
	public Guid PropertyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CPropertyUid_003Ek__BackingField;
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
				case 1:
					_003CPropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
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

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public List<Guid> PropertyParents { get; set; }

	IDictionary<string, PropertyInfo> ILocalizable.LocalizableProperties => localizableProperties;

	public ComputedValue()
	{
		//Discarded unreachable code: IL_003a
		sqlUlEoq3RB6tOH3TVG0();
		localizableProperties = new Dictionary<string, PropertyInfo>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
		{
			num = 5;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
			{
				CalculateScript = string.Empty;
				int num2 = 2;
				num = num2;
				break;
			}
			case 2:
				ComputedValueType = ComputedValueType.Input;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num = 1;
				}
				break;
			case 4:
				MethodName = string.Empty;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num = 0;
				}
				break;
			case 1:
				PropertyParents = new List<Guid>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 5:
				Name = string.Empty;
				num = 4;
				break;
			}
		}
	}

	IEnumerable<string> ILocalizable.GetStrings(ILocalizable parent)
	{
		string localizableString = GetLocalizableString(parent);
		if (localizableString == null)
		{
			return Enumerable.Empty<string>();
		}
		return new string[1] { localizableString };
	}

	void ILocalizable.Localize(ILocalizable parent)
	{
		int num = 3;
		int num2 = num;
		string localizableString = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				localizableString = GetLocalizableString(parent);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				return;
			case 0:
				return;
			case 2:
				if (localizableString != null)
				{
					Value = tuQR5Poqp71BIajfZXZw(localizableString);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	private string GetLocalizableString(ILocalizable parent)
	{
		//Discarded unreachable code: IL_0089, IL_0098, IL_00f7, IL_0138, IL_0147
		int num = 4;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (WNeQKeoqasMsJY1wp1pb(text))
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 8;
					}
					break;
				}
				return text;
			case 8:
				return null;
			case 6:
				return null;
			default:
				text = Value as string;
				num2 = 5;
				break;
			case 2:
				if (ComputedValueType == ComputedValueType.Input)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 4:
				if (string.IsNullOrWhiteSpace(Name))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 2;
			case 3:
			case 7:
				return null;
			case 1:
				if (parent.LocalizableProperties.ContainsKey(Name))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializePropertyParents()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (PropertyParents != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return PropertyParents.Count > 0;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializePropertyUid()
	{
		return t9rFtmoqD4PgOEBO3vI9(PropertyUid, Guid.Empty);
	}

	internal static void sqlUlEoq3RB6tOH3TVG0()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool RmRnjJoq1xdEXtWYAshs()
	{
		return zqXDZjoqPcWYMr0joL8d == null;
	}

	internal static ComputedValue R1yEmOoqNb7QhL0AB2Te()
	{
		return zqXDZjoqPcWYMr0joL8d;
	}

	internal static object tuQR5Poqp71BIajfZXZw(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool WNeQKeoqasMsJY1wp1pb(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static bool t9rFtmoqD4PgOEBO3vI9(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}
}
