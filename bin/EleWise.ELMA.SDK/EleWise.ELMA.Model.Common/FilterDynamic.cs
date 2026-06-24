using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Model.Accessors;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Common;

[DebuggerTypeProxy(typeof(DynamicDebugView))]
public class FilterDynamic : Filter, IValueContainerObjectInternal, IDynamicMetaObjectProvider
{
	internal static FilterDynamic esWYKihqTInoUpHPOcHj;

	protected internal static ICreator<T, TData> ResolveCreator<T, TData, TClassData>(Func<T, TData> creator) where TData : class where TClassData : TData
	{
		return Creator<T>.ResolveCreator<TData, TClassData>(creator);
	}

	DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter)
	{
		return new MetaDynamic(parameter, this, (string name) => (IAccessor)vpkHJ4hq2B9FoDX9ybV4(GetType(), name, false));
	}

	IEnumerable<object> IValueContainerObjectInternal.GetData()
	{
		return GetData_034F();
	}

	protected internal virtual IEnumerable<object> GetData_034F()
	{
		return Enumerable.Empty<object>();
	}

	protected static IEnumerable<object> GetAccessors_034F()
	{
		return Enumerable.Empty<object>();
	}

	public FilterDynamic()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		L6g1KOhqOwmoW6VWh5hn();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool UM4BSwhqkKnFPkmApvl9()
	{
		return esWYKihqTInoUpHPOcHj == null;
	}

	internal static FilterDynamic NDjRPGhqn3FVZLCInfTZ()
	{
		return esWYKihqTInoUpHPOcHj;
	}

	internal static void L6g1KOhqOwmoW6VWh5hn()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object vpkHJ4hq2B9FoDX9ybV4(Type type, object P_1, bool declaredOnly)
	{
		return type.GetAccessor((string)P_1, declaredOnly);
	}
}
