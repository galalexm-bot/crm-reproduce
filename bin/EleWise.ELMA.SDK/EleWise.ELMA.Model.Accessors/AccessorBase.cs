using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Accessors;

[Serializable]
[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class AccessorBase<T, TVal, TData> : IAccessor where T : class where TData : class
{
	private static readonly MethodInfo GetDataMethod;

	private readonly int dataIndex;

	private PropertyInfo property;

	private Type dataType;

	private IList<CustomAttributeData> customAttributesData;

	private static object Oe3XX6hmZSnf0mR7WDKX;

	public Type PropertyType { get; }

	public string PropertyName { get; }

	public abstract bool HasGetter { get; }

	public abstract bool HasSetter { get; }

	protected AccessorBase(string propertyName, int dataIndex)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				PropertyName = propertyName;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num = 3;
				}
				break;
			case 2:
				return;
			case 1:
				PropertyType = typeof(TVal);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				this.dataIndex = dataIndex;
				num = 2;
				break;
			}
		}
	}

	public Expression GetExpression(Expression instance)
	{
		return Expression.Property(Expression.Convert(Expression.Call(GetDataMethod, GetLimitedSelf(instance), Expression.Constant(dataIndex)), typeof(TData)), PropertyName);
	}

	public Expression SetExpression(Expression instance, Expression value)
	{
		return Expression.Assign(Expression.Property(Expression.Convert(Expression.Call(GetDataMethod, GetLimitedSelf(instance), Expression.Constant(dataIndex)), typeof(TData)), PropertyName), value);
	}

	private static Expression GetLimitedSelf(Expression instance)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return Expression.Convert(instance, typeof(T));
			case 1:
				return instance;
			case 2:
				if (AreEquivalent(instance.Type, typeof(T)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	private static bool AreEquivalent(Type t1, Type t2)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return t1.IsEquivalentTo(t2);
			case 1:
				if (t1 == t2)
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static AccessorBase()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				GetDataMethod = typeof(Accessors).GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70238029), BindingFlags.Static | BindingFlags.NonPublic);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static bool zC12njhmukILJKFf2LZd()
	{
		return Oe3XX6hmZSnf0mR7WDKX == null;
	}

	internal static object AIi2Q4hmIUliuJ5wtPEQ()
	{
		return Oe3XX6hmZSnf0mR7WDKX;
	}
}
