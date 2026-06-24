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
internal class CastLeftOperandFromBigint2String : IQueryCastExtension
{
	private ITransformationProvider transformationProvider;

	internal static CastLeftOperandFromBigint2String cIVdxjG05s5gYAD6kPdF;

	public Type LeftOperandType => typeof(long);

	public Type RightOperandType => Epji1SG0LEoWsVQcKjGx(typeof(string).TypeHandle);

	public CastLeftOperandFromBigint2String(ITransformationProvider transformationProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.transformationProvider = transformationProvider;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public SqlString CastLeftOperand(SqlString sqlString)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = (string)GdL2i7G0sWiu1Ole9lU3(hJ5eixG0URMNsNMtLBSh(transformationProvider), DbType.AnsiString);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return new SqlString((string)hu94WMG0zbLYo1gOeX2B(WdW4O8G0csAcXTrPpohf(0x2A7797B7 ^ 0x2A739B75), sqlString, text));
			}
		}
	}

	public IProjection CastRightOperand(string propertyName)
	{
		return (IProjection)By7qC8GmFKZfRBehIqmW(propertyName);
	}

	internal static Type Epji1SG0LEoWsVQcKjGx(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool oEvidEG0jZ4vnQI9QslZ()
	{
		return cIVdxjG05s5gYAD6kPdF == null;
	}

	internal static CastLeftOperandFromBigint2String AqSxT1G0YsI1OwD9itIf()
	{
		return cIVdxjG05s5gYAD6kPdF;
	}

	internal static object hJ5eixG0URMNsNMtLBSh(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object GdL2i7G0sWiu1Ole9lU3(object P_0, DbType type)
	{
		return ((Dialect)P_0).GetTypeName(type);
	}

	internal static object WdW4O8G0csAcXTrPpohf(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object hu94WMG0zbLYo1gOeX2B(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object By7qC8GmFKZfRBehIqmW(object P_0)
	{
		return Projections.Property((string)P_0);
	}
}
