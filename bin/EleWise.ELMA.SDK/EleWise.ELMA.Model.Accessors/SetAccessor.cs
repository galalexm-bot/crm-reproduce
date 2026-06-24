using System;
using System.ComponentModel;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Properties;

namespace EleWise.ELMA.Model.Accessors;

[Serializable]
[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class SetAccessor<T, TVal, TData> : AccessorBase<T, TVal, TData>, ISetter where T : class where TData : class
{
	internal static object aAHFh3hm1G6ymQD1rKar;

	public override bool HasGetter => false;

	public override bool HasSetter => true;

	MethodInfo Method => null;

	protected SetAccessor(string propertyName, int dataIndex)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(propertyName, dataIndex);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public abstract void Set(T target, TVal value);

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
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool uQb6WVhmNPXuJeRLv7NW()
	{
		return aAHFh3hm1G6ymQD1rKar == null;
	}

	internal static object UP4W4mhm308QY4FVvXIo()
	{
		return aAHFh3hm1G6ymQD1rKar;
	}
}
