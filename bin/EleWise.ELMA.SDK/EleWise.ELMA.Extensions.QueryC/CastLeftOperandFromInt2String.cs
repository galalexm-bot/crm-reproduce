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
internal class CastLeftOperandFromInt2String : IQueryCastExtension
{
	private ITransformationProvider transformationProvider;

	private static CastLeftOperandFromInt2String b71JY3G0nEJNBIGuYyDg;

	public Type LeftOperandType => c8LEAIG0eFCOmdRRF2LL(typeof(int).TypeHandle);

	public Type RightOperandType => c8LEAIG0eFCOmdRRF2LL(typeof(string).TypeHandle);

	public CastLeftOperandFromInt2String(ITransformationProvider transformationProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
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
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
			{
				num = 1;
			}
		}
	}

	public SqlString CastLeftOperand(SqlString sqlString)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		string typeName = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return new SqlString((string)II6DdmG01cGQEHLygBjJ(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16494043), sqlString, typeName));
			case 1:
				typeName = ((Dialect)wgEV8aG0PjAtMNb7tKWq(transformationProvider)).GetTypeName(DbType.AnsiString);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IProjection CastRightOperand(string propertyName)
	{
		return (IProjection)BlX0ViG0N5QYrhepk7lZ(propertyName);
	}

	internal static Type c8LEAIG0eFCOmdRRF2LL(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool VshMlhG0OdpeW5EdvRnb()
	{
		return b71JY3G0nEJNBIGuYyDg == null;
	}

	internal static CastLeftOperandFromInt2String S7TIoOG027LfdyRJTafR()
	{
		return b71JY3G0nEJNBIGuYyDg;
	}

	internal static object wgEV8aG0PjAtMNb7tKWq(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object II6DdmG01cGQEHLygBjJ(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object BlX0ViG0N5QYrhepk7lZ(object P_0)
	{
		return Projections.Property((string)P_0);
	}
}
