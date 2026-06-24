using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
[XmlRoot("Int64RangeValue")]
public class Int64RangeWrapper : IXsiType
{
	private static Int64RangeWrapper NNqx9TbGeOH9yJwlycIa;

	[XmlElement("From")]
	public long From
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
				case 0:
					return;
				case 1:
					_003CFrom_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("To")]
	public long To
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Int64RangeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		o8t1SJbGNiis7F5D6GK5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public Int64RangeWrapper(Int64Range source)
	{
		//Discarded unreachable code: IL_001e
		o8t1SJbGNiis7F5D6GK5();
		base._002Ector();
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				HasToValue = source.To.HasValue;
				num2 = 3;
				break;
			case 3:
				return;
			case 1:
				HasFromValue = source.From.HasValue;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				From = (source.From.HasValue ? source.From.Value : 0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				break;
			default:
				To = (source.To.HasValue ? source.To.Value : 0);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void o8t1SJbGNiis7F5D6GK5()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool u3yg0ubGPXteVvqC4yAD()
	{
		return NNqx9TbGeOH9yJwlycIa == null;
	}

	internal static Int64RangeWrapper lCnBW5bG15h4LCSHEPSI()
	{
		return NNqx9TbGeOH9yJwlycIa;
	}
}
