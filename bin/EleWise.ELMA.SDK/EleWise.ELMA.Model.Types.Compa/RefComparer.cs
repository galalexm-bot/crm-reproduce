using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Comparers;

public class RefComparer<TSource> : IComparer<TSource>
{
	private readonly PropertyInfo propertyInfo;

	private readonly ListSortDirection order;

	private readonly int orderInt;

	private static object ofjesioUt8qqv1PtDkiV;

	public RefComparer(Type source, string propertyName, ListSortDirection order)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 2:
				propertyInfo = source.GetReflectionProperty(propertyName);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num = 0;
				}
				break;
			default:
				this.order = order;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				orderInt = ((this.order != ListSortDirection.Descending) ? 1 : (-1));
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num = 3;
				}
				break;
			}
		}
	}

	protected virtual int Compare(object keyX, object keyY)
	{
		//Discarded unreachable code: IL_0095, IL_00a4
		int num = 4;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return num3;
			default:
				throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420916560), keyX.GetType().FullName));
			case 2:
				num3 = ((IComparable)keyX).CompareTo(keyY);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return 1;
			case 4:
				if (keyX != null)
				{
					if (keyX is IComparable)
					{
						num2 = 2;
						break;
					}
					goto default;
				}
				num2 = 3;
				break;
			case 1:
				if (num3 == 0)
				{
					return 1;
				}
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	public virtual int Compare(TSource x, TSource y)
	{
		if (object.Equals(x, y))
		{
			return 0;
		}
		object value = propertyInfo.GetValue(x, null);
		object value2 = propertyInfo.GetValue(y, null);
		return orderInt * Compare(value, value2);
	}

	internal static bool FHBPEjoUwRuIRkfvIS3Q()
	{
		return ofjesioUt8qqv1PtDkiV == null;
	}

	internal static object k41sDFoU4DrY7Jros7Yg()
	{
		return ofjesioUt8qqv1PtDkiV;
	}
}
