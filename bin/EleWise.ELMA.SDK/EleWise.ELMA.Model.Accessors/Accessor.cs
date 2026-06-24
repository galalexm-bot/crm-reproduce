using System;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.Properties;

namespace EleWise.ELMA.Model.Accessors;

[Serializable]
[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class Accessor<T, TVal, TData> : AccessorBase<T, TVal, TData>, IGetter, ISetter where T : class where TData : class
{
	internal static object E5H91ihmpiKf3I0InmZg;

	public override bool HasGetter => true;

	public override bool HasSetter => true;

	Type ReturnType => base.PropertyType;

	MethodInfo Method => null;

	MethodInfo Method => null;

	protected Accessor(string propertyName, int dataIndex)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(propertyName, dataIndex);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public abstract TVal Get(T target);

	public abstract void Set(T target, TVal value);

	object IGetter.GetForInsert(object owner, IDictionary mergeMap, ISessionImplementor session)
	{
		return Get((T)owner);
	}

	object IGetter.Get(object target)
	{
		return Get((T)target);
	}

	void ISetter.Set(object target, object value)
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
				Set((T)target, (value is TVal) ? ((TVal)value) : default(TVal));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool qqQflAhmaOVMxnXoiQM1()
	{
		return E5H91ihmpiKf3I0InmZg == null;
	}

	internal static object JpRFOFhmDF4RAXGyFybf()
	{
		return E5H91ihmpiKf3I0InmZg;
	}
}
