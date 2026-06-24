using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Type;

namespace EleWise.ELMA.Extensions.QueryCastExtensions;

[Component(Type = ComponentType.Server)]
internal class CastRightOperandFromBigint2String : IQueryCastExtension
{
	private ITransformationProvider transformationProvider;

	internal static CastRightOperandFromBigint2String BAXvb3G04QaGx3uvf4wp;

	public Type LeftOperandType => zflRhkG0AJ5MgQfYvRwH(typeof(string).TypeHandle);

	public Type RightOperandType => typeof(long);

	public CastRightOperandFromBigint2String(ITransformationProvider transformationProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sg2IDNG07GPjZfB3WZ7T();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
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
			this.transformationProvider = transformationProvider;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
			{
				num = 1;
			}
		}
	}

	public SqlString CastLeftOperand(SqlString sqlString)
	{
		return sqlString;
	}

	public IProjection CastRightOperand(string propertyName)
	{
		return Projections.Cast((IType)(object)NHibernateUtil.String, (IProjection)(object)Projections.Property(propertyName));
	}

	internal static Type zflRhkG0AJ5MgQfYvRwH(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void sg2IDNG07GPjZfB3WZ7T()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool P82amlG06JRXBvIkdkDS()
	{
		return BAXvb3G04QaGx3uvf4wp == null;
	}

	internal static CastRightOperandFromBigint2String uEuevnG0HY8joxiBfj7i()
	{
		return BAXvb3G04QaGx3uvf4wp;
	}
}
