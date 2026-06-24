using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace Microsoft.Web.Mvc.ExpressionUtil;

internal sealed class IndexExpressionFingerprint : ExpressionFingerprint
{
	private static IndexExpressionFingerprint lXORSHoZRiUVBwh3Fl4;

	public PropertyInfo Indexer
	{
		[CompilerGenerated]
		get
		{
			return _003CIndexer_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CIndexer_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
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

	public IndexExpressionFingerprint(ExpressionType nodeType, Type type, PropertyInfo indexer)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		lLcTGjoVAxnWVD3u4G6();
		base._002Ector(nodeType, type);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Indexer = indexer;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
			{
				num = 1;
			}
		}
	}

	public override bool Equals(object obj)
	{
		int num = 1;
		int num2 = num;
		IndexExpressionFingerprint indexExpressionFingerprint = default(IndexExpressionFingerprint);
		while (true)
		{
			switch (num2)
			{
			case 1:
				indexExpressionFingerprint = obj as IndexExpressionFingerprint;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return Equals(indexExpressionFingerprint);
			default:
				if (indexExpressionFingerprint != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0057;
			case 3:
				{
					if (object.Equals(Indexer, i76Y3AoS3NE10RSdw5a(indexExpressionFingerprint)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto IL_0057;
				}
				IL_0057:
				return false;
			}
		}
	}

	internal override void AddToHashCodeCombiner(HashCodeCombiner combiner)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				base.AddToHashCodeCombiner(combiner);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			case 1:
				combiner.AddObject(Indexer);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool X7eHcvou93yvMKnwSB9()
	{
		return lXORSHoZRiUVBwh3Fl4 == null;
	}

	internal static IndexExpressionFingerprint mqEI4koIC1I8Doslhv3()
	{
		return lXORSHoZRiUVBwh3Fl4;
	}

	internal static void lLcTGjoVAxnWVD3u4G6()
	{
		SingletonReader.PushGlobal();
	}

	internal static object i76Y3AoS3NE10RSdw5a(object P_0)
	{
		return ((IndexExpressionFingerprint)P_0).Indexer;
	}
}
