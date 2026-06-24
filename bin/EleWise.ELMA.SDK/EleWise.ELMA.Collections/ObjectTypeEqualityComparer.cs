using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Collections;

public class ObjectTypeEqualityComparer<T> : IEqualityComparer, IEqualityComparer<T>
{
	internal static object c1vYI8m1I3f2IoDNDOe;

	bool IEqualityComparer.Equals(object x, object y)
	{
		//Discarded unreachable code: IL_0059, IL_0068
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (y != null)
					{
						num2 = 2;
						continue;
					}
					goto case 1;
				case 1:
					return false;
				case 2:
					return x.GetType() == y.GetType();
				case 3:
					return true;
				case 4:
					if (x == y)
					{
						break;
					}
					if (x != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				}
				break;
			}
			num = 3;
		}
	}

	int IEqualityComparer.GetHashCode([NotNull] object obj)
	{
		//Discarded unreachable code: IL_004d, IL_005c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (obj != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335017593));
			default:
				return obj.GetHashCode();
			}
		}
	}

	public bool Equals(T x, T y)
	{
		return ((IEqualityComparer)this).Equals((object)x, (object)y);
	}

	public int GetHashCode(T obj)
	{
		return ((IEqualityComparer)this).GetHashCode((object)obj);
	}

	public ObjectTypeEqualityComparer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool g0nG2cmNalBLTsEUlky()
	{
		return c1vYI8m1I3f2IoDNDOe == null;
	}

	internal static object MDn9Jqm3aFmaontPmpT()
	{
		return c1vYI8m1I3f2IoDNDOe;
	}
}
