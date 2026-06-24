using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Convertors;

public class ToGuidConvertor : TypeConvertor
{
	internal static ToGuidConvertor mPjbEBojhWC1nvgYgvg2;

	public override List<Guid> SourceTypeUids => new List<Guid>
	{
		GuidDescriptor.UID,
		HtmlStringDescriptor.UID,
		TextDescriptor.UID,
		StringDescriptor.UID
	};

	public override List<Guid> TargetTypeUids => new List<Guid> { GuidDescriptor.UID };

	public override object DoConvert(object obj)
	{
		//Discarded unreachable code: IL_0071, IL_0090, IL_00dd, IL_00f4, IL_0103
		int num = 2;
		int num2 = num;
		Guid? guid = default(Guid?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (obj != null)
				{
					num2 = 3;
					break;
				}
				goto default;
			default:
				return guid;
			case 3:
				try
				{
					int num3;
					if (!Guid.TryParse(obj.ToString(), out var result))
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num3 = 0;
						}
						goto IL_0075;
					}
					goto IL_009a;
					IL_009a:
					guid = result;
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num3 = 0;
					}
					goto IL_0075;
					IL_0075:
					switch (num3)
					{
					default:
						goto end_IL_0045;
					case 0:
						goto end_IL_0045;
					case 2:
						break;
					case 1:
						goto end_IL_0045;
					}
					goto IL_009a;
					end_IL_0045:;
				}
				catch (Exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto default;
			case 2:
				guid = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public ToGuidConvertor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		EXJTCXojfJV0TibwrjIS();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool hq58DFojGeqTYrkNmutD()
	{
		return mPjbEBojhWC1nvgYgvg2 == null;
	}

	internal static ToGuidConvertor dqE3jZojE1LqW4VxFgFN()
	{
		return mPjbEBojhWC1nvgYgvg2;
	}

	internal static void EXJTCXojfJV0TibwrjIS()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
