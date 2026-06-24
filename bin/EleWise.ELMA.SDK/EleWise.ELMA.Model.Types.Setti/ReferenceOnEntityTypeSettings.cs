using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Settings;

[Serializable]
public class ReferenceOnEntityTypeSettings : SimpleTypeSettings
{
	[OptionalField]
	private Guid _baseClass;

	private static ReferenceOnEntityTypeSettings J2i7VQbFICpSsG79QI0l;

	[XmlIgnore]
	public Guid BaseClass
	{
		get
		{
			return _baseClass;
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
				case 0:
					return;
				case 1:
					_baseClass = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue("")]
	[JsonSerializationIgnore]
	[XmlElement("BaseClass")]
	public string BaseClassStr
	{
		get
		{
			//Discarded unreachable code: IL_0060, IL_006f
			int num = 1;
			int num2 = num;
			Guid baseClass = default(Guid);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (BaseClass != Guid.Empty)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 3:
					return baseClass.ToString();
				case 2:
					return "";
				default:
					baseClass = BaseClass;
					num2 = 3;
					break;
				}
			}
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
				case 0:
					return;
				case 1:
					BaseClass = ((!uBX2r8bFRgOJp7dnhv15(value)) ? new Guid(value) : Guid.Empty);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ReferenceOnEntityTypeSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ILMfpubFiGuWWvmcgpuL();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected ReferenceOnEntityTypeSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		ILMfpubFiGuWWvmcgpuL();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void ILMfpubFiGuWWvmcgpuL()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool jK3l1fbFVbVNwi6FrK6u()
	{
		return J2i7VQbFICpSsG79QI0l == null;
	}

	internal static ReferenceOnEntityTypeSettings hPW5u9bFSPkwrmL3M9m4()
	{
		return J2i7VQbFICpSsG79QI0l;
	}

	internal static bool uBX2r8bFRgOJp7dnhv15(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}
}
