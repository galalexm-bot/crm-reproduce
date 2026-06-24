using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Comparers;

public sealed class NHComparer<TEntity, TSource> : IComparer, IComparer<TSource>, IComparerInternal
{
	private static readonly IDictionary<Type, ConcurrentDictionary<string, IComparer>> Comparers;

	private IComparer comparerInternal;

	internal static object XcRWXPoUC0BV0FdoEqY2;

	public NHComparer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	int IComparer.Compare(object x, object y)
	{
		return comparerInternal.Compare(x, y);
	}

	int IComparer<TSource>.Compare(TSource x, TSource y)
	{
		return comparerInternal.Compare(x, y);
	}

	void IComparerInternal.SetRole(string role)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				_003C_003Ec__DisplayClass5_.role = role;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 2;
				break;
			case 0:
				return;
			case 1:
				comparerInternal = Comparers.GetOrAdd(typeof(TEntity), (Type t) => new ConcurrentDictionary<string, IComparer>()).GetOrAdd(_003C_003Ec__DisplayClass5_.role, _003C_003Ec__DisplayClass5_._003CEleWise_002EELMA_002EModel_002ETypes_002EComparers_002EIComparerInternal_002ESetRole_003Eb__1);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static NHComparer()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				Comparers = PublishCacheContext.CreateCache(delegate(IDictionary<Type, ConcurrentDictionary<string, IComparer>> c, Type t, Guid g)
				{
					c.Remove(t);
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool R83RkYoUvY02B2DJt9rK()
	{
		return XcRWXPoUC0BV0FdoEqY2 == null;
	}

	internal static object nAl2eFoU8GDaDId1jB3w()
	{
		return XcRWXPoUC0BV0FdoEqY2;
	}
}
