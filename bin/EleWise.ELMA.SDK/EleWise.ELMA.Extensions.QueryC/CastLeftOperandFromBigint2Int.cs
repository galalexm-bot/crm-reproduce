using System;
using System.Data;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions.QueryCastExtensions;

[Component(Type = ComponentType.Server)]
internal class CastLeftOperandFromBigint2Int : IQueryCastExtension
{
	private ITransformationProvider transformationProvider;

	internal static CastLeftOperandFromBigint2Int l5p9DVG0SKgvSUFOAgKP;

	public Type LeftOperandType => x81ui1G0qWjrr0RpwJt2(typeof(long).TypeHandle);

	public Type RightOperandType => x81ui1G0qWjrr0RpwJt2(typeof(int).TypeHandle);

	public CastLeftOperandFromBigint2Int(ITransformationProvider transformationProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
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
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
			{
				num = 1;
			}
		}
	}

	public SqlString CastLeftOperand(SqlString sqlString)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = (string)KUx9ALG0X4ir4QyQiUHu(LPZWICG0KIR0XQXD7MAx(transformationProvider), DbType.Int32);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return new SqlString((string)z5TvcVG0khcei3KAlAvP(IlCpXDG0Ty267uItyuiS(-1146510045 ^ -1146246687), sqlString, text));
			}
		}
	}

	public IProjection CastRightOperand(string propertyName)
	{
		return (IProjection)(object)Projections.Property(propertyName);
	}

	internal static Type x81ui1G0qWjrr0RpwJt2(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool pCvPTpG0ihCEehlDbrDu()
	{
		return l5p9DVG0SKgvSUFOAgKP == null;
	}

	internal static CastLeftOperandFromBigint2Int dJFS0pG0Rw05Rd02qE7i()
	{
		return l5p9DVG0SKgvSUFOAgKP;
	}

	internal static object LPZWICG0KIR0XQXD7MAx(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object KUx9ALG0X4ir4QyQiUHu(object P_0, DbType type)
	{
		return ((Dialect)P_0).GetTypeName(type);
	}

	internal static object IlCpXDG0Ty267uItyuiS(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object z5TvcVG0khcei3KAlAvP(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}
}
