using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[XmlRoot("Int16RangeValue")]
[Component]
public class Int16RangeWrapper : IXsiType
{
	internal static Int16RangeWrapper HenpcwbEWGWZLp83FaxK;

	[XmlElement("From")]
	public short From
	{
		[CompilerGenerated]
		get
		{
			return _003CFrom_003Ek__BackingField;
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
					_003CFrom_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
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

	[XmlElement("To")]
	public short To
	{
		[CompilerGenerated]
		get
		{
			return _003CTo_003Ek__BackingField;
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
					_003CTo_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
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

	[XmlElement("HasFromValue")]
	public bool HasFromValue
	{
		[CompilerGenerated]
		get
		{
			return _003CHasFromValue_003Ek__BackingField;
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
					_003CHasFromValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("HasToValue")]
	public bool HasToValue
	{
		[CompilerGenerated]
		get
		{
			return _003CHasToValue_003Ek__BackingField;
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
					_003CHasToValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Int16RangeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Fiu5ZcbEhCc5ODEa5Fws();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public Int16RangeWrapper(Int16Range source)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Fiu5ZcbEhCc5ODEa5Fws();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				HasToValue = source.To.HasValue;
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num = 4;
				}
				break;
			case 1:
				HasFromValue = source.From.HasValue;
				num = 2;
				break;
			case 4:
				return;
			default:
				From = (source.From.HasValue ? source.From.Value : suUJn3bEGShKhSIil4lE(0));
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num = 3;
				}
				break;
			case 3:
				To = (source.To.HasValue ? source.To.Value : suUJn3bEGShKhSIil4lE(0));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static void Fiu5ZcbEhCc5ODEa5Fws()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool EXc9uhbEoPrAIL11Ygrc()
	{
		return HenpcwbEWGWZLp83FaxK == null;
	}

	internal static Int16RangeWrapper r7VosWbEbCdex7pJqPcQ()
	{
		return HenpcwbEWGWZLp83FaxK;
	}

	internal static short suUJn3bEGShKhSIil4lE(int P_0)
	{
		return Convert.ToInt16(P_0);
	}
}
