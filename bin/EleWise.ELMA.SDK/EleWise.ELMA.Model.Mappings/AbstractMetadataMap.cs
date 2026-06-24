using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode.Impl.CustomizersImpl;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Mappings;

public abstract class AbstractMetadataMap<T> : AbstractEntityMap<T, long> where T : AbstractMetadata
{
	internal static object eNoI5Zhby6gb9bN4MC0K;

	public AbstractMetadataMap(string tableName)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(tableName);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
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
			ParameterExpression parameterExpression = Expression.Parameter(typeof(T), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106467044));
			((PropertyContainerCustomizer<T>)(object)this).Property<Guid>(Expression.Lambda<Func<T, Guid>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
			{
				num = 1;
			}
		}
	}

	internal static bool SUHc3dhbMPRx6tbwE0tN()
	{
		return eNoI5Zhby6gb9bN4MC0K == null;
	}

	internal static object CMmyMvhbJY2J9ueMoJA6()
	{
		return eNoI5Zhby6gb9bN4MC0K;
	}
}
