using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Criterion;
using NHibernate.SqlCommand;

namespace EleWise.ELMA.Extensions.QueryCastExtensions;

[Component(Type = ComponentType.Server)]
internal class DefaultNoCast : IQueryCastExtension
{
	private static DefaultNoCast O5Vq4UG09YpguDcpeeWi;

	public Type LeftOperandType => null;

	public Type RightOperandType => null;

	public SqlString CastLeftOperand(SqlString sqlString)
	{
		return sqlString;
	}

	public IProjection CastRightOperand(string propertyName)
	{
		return (IProjection)drCnd6G0rKZGrC1XQl1S(propertyName);
	}

	public DefaultNoCast()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		hZavLNG0gOMT7649pOum();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object drCnd6G0rKZGrC1XQl1S(object P_0)
	{
		return Projections.Property((string)P_0);
	}

	internal static void hZavLNG0gOMT7649pOum()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool L3KsUgG0dY1IhwDf0mBb()
	{
		return O5Vq4UG09YpguDcpeeWi == null;
	}

	internal static DefaultNoCast RKiIVRG0lAAknQuKgtw3()
	{
		return O5Vq4UG09YpguDcpeeWi;
	}
}
