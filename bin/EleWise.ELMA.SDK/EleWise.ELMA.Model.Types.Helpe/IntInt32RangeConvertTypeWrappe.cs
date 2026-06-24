using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class IntInt32RangeConvertTypeWrapper : IConvertTypeWrapper
{
	internal static IntInt32RangeConvertTypeWrapper mJVYetbEYA1173CquflP;

	public Type OriginalType => MsymIvbEsEMXijpMn6ob(typeof(int).TypeHandle);

	public Type ConvertType => MsymIvbEsEMXijpMn6ob(typeof(Int32Range).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 1;
		int num2 = num;
		Int32Range int32Range = default(Int32Range);
		int value = default(int);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return int32Range;
			default:
				int32Range = default(Int32Range);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				int32Range.To = value;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				value = IZph4jbEcbxeCDtXIfdd(obj);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				int32Range.From = value;
				num2 = 3;
				break;
			}
		}
	}

	public IntInt32RangeConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vKNdcXbEzqsf9oqRYxEQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type MsymIvbEsEMXijpMn6ob(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static int IZph4jbEcbxeCDtXIfdd(object P_0)
	{
		return Convert.ToInt32(P_0);
	}

	internal static bool LhFn2abELC1HON6BE97I()
	{
		return mJVYetbEYA1173CquflP == null;
	}

	internal static IntInt32RangeConvertTypeWrapper MTFAV0bEUW3mIh3UYuKp()
	{
		return mJVYetbEYA1173CquflP;
	}

	internal static void vKNdcXbEzqsf9oqRYxEQ()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
