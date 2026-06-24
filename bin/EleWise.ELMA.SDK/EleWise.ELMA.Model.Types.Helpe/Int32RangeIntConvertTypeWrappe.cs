using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class Int32RangeIntConvertTypeWrapper : IConvertTypeWrapper
{
	internal static Int32RangeIntConvertTypeWrapper rO71RbbEMCk5iOknVGhK;

	public Type OriginalType => typeof(Int32Range);

	public Type ConvertType => NAIJyAbEdLpgdgjGWQsb(typeof(int).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		//Discarded unreachable code: IL_0036
		int num = 1;
		int? from = default(int?);
		Int32Range int32Range = default(Int32Range);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 2:
					num3 = 0;
					break;
				default:
					from = int32Range.From;
					num2 = 3;
					continue;
				case 1:
					int32Range = (Int32Range)obj;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					if (!from.HasValue)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto end_IL_0012;
				case 4:
					num3 = from.Value;
					break;
				}
				return num3;
				continue;
				end_IL_0012:
				break;
			}
			from = int32Range.From;
			num = 4;
		}
	}

	public Int32RangeIntConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type NAIJyAbEdLpgdgjGWQsb(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool wsi1bBbEJOYunh5IxgAL()
	{
		return rO71RbbEMCk5iOknVGhK == null;
	}

	internal static Int32RangeIntConvertTypeWrapper p2weNybE9YDnPuNIPPVZ()
	{
		return rO71RbbEMCk5iOknVGhK;
	}
}
