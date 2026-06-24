using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 1000)]
public class Int32RangeWrapperDescriptor : ITypeWrapperDescriptor
{
	private static Int32RangeWrapperDescriptor mXHo4xbE62OGpy5OMviZ;

	public Type OriginalType => typeof(Int32Range);

	public Type WrapperType => typeof(Int32RangeWrapper);

	public Type[] GenericArgumentsTypes => null;

	public object CreateWrapper(object obj)
	{
		return new Int32RangeWrapper((Int32Range)obj);
	}

	public object GetObject(object wrapper)
	{
		//Discarded unreachable code: IL_00a7
		int num = 2;
		int num2 = num;
		Int32Range int32Range = default(Int32Range);
		Int32RangeWrapper int32RangeWrapper = default(Int32RangeWrapper);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return int32Range;
			case 5:
				int32Range = default(Int32Range);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				int32RangeWrapper = wrapper as Int32RangeWrapper;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return int32Range;
			case 6:
				int32Range = default(Int32Range);
				num2 = 4;
				break;
			case 1:
				if (int32RangeWrapper == null)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 5;
			case 3:
				int32Range.From = (tS5PPPbE77WG7GLCAvEJ(int32RangeWrapper) ? new int?(T1Jm3ZbExpY7UlJI5pvk(int32RangeWrapper)) : null);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 4;
				}
				break;
			case 7:
				int32Range.To = (lkEAnnbE08FnrbkJKuOL(int32RangeWrapper) ? new int?(PSPYHxbEmFlvCp8y36Hb(int32RangeWrapper)) : null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool TestType(Type type)
	{
		return false;
	}

	public Int32RangeWrapperDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		aVcBUibEyxxWsvdoFySX();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool edS3CEbEHuC6hkewW06V()
	{
		return mXHo4xbE62OGpy5OMviZ == null;
	}

	internal static Int32RangeWrapperDescriptor SG85lAbEAY9CjINtQh6t()
	{
		return mXHo4xbE62OGpy5OMviZ;
	}

	internal static bool tS5PPPbE77WG7GLCAvEJ(object P_0)
	{
		return ((Int32RangeWrapper)P_0).HasFromValue;
	}

	internal static int T1Jm3ZbExpY7UlJI5pvk(object P_0)
	{
		return ((Int32RangeWrapper)P_0).From;
	}

	internal static bool lkEAnnbE08FnrbkJKuOL(object P_0)
	{
		return ((Int32RangeWrapper)P_0).HasToValue;
	}

	internal static int PSPYHxbEmFlvCp8y36Hb(object P_0)
	{
		return ((Int32RangeWrapper)P_0).To;
	}

	internal static void aVcBUibEyxxWsvdoFySX()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
