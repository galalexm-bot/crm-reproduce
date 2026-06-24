using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
[XmlRoot("DoubleRangeValue")]
public class DoubleRangeWrapper : IXsiType
{
	internal static DoubleRangeWrapper JH2RlTbhzHAQ8nQUEJ9M;

	[XmlElement("From")]
	public double From
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
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
	public double To
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
				case 0:
					return;
				case 1:
					_003CTo_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 0;
					}
					break;
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DoubleRangeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		LPD1OnbGWQD4vfSLpjbJ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public DoubleRangeWrapper(DoubleRange source)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		LPD1OnbGWQD4vfSLpjbJ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				HasToValue = source.To.HasValue;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num = 4;
				}
				break;
			case 1:
				HasFromValue = source.From.HasValue;
				num = 3;
				break;
			case 4:
				return;
			default:
				From = (source.From.HasValue ? source.From.Value : 0.0);
				num = 2;
				break;
			case 2:
				To = (source.To.HasValue ? source.To.Value : 0.0);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void LPD1OnbGWQD4vfSLpjbJ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool fgNWCebGFQB9GsnWcn3Y()
	{
		return JH2RlTbhzHAQ8nQUEJ9M == null;
	}

	internal static DoubleRangeWrapper eMC80CbGB5bjFjspjmqO()
	{
		return JH2RlTbhzHAQ8nQUEJ9M;
	}
}
