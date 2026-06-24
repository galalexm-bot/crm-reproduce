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
public abstract class GetAccessor<T, TVal, TData> : AccessorBase<T, TVal, TData>, IGetter where T : class where TData : class
{
	private static object X1p1UqhmkBQP3iKJxj5K;

	public override bool HasGetter => true;

	public override bool HasSetter => false;

	Type ReturnType => base.PropertyType;

	MethodInfo Method => null;

	protected GetAccessor(string propertyName, int dataIndex)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(propertyName, dataIndex);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
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

	object IGetter.GetForInsert(object owner, IDictionary mergeMap, ISessionImplementor session)
	{
		return Get((T)owner);
	}

	object IGetter.Get(object target)
	{
		return Get((T)target);
	}

	internal static bool eVr5v9hmnBSw6HmlTFxh()
	{
		return X1p1UqhmkBQP3iKJxj5K == null;
	}

	internal static object sdASnhhmOflZXpYetunO()
	{
		return X1p1UqhmkBQP3iKJxj5K;
	}
}
