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
internal class CastRightOperandFromBigint2Int : IQueryCastExtension
{
	private ITransformationProvider transformationProvider;

	internal static CastRightOperandFromBigint2Int QL1OL7G03Tx7kxmtGQVI;

	public Type LeftOperandType => SmBlUDG0DCn5HtMuuvfD(typeof(int).TypeHandle);

	public Type RightOperandType => SmBlUDG0DCn5HtMuuvfD(typeof(long).TypeHandle);

	public CastRightOperandFromBigint2Int(ITransformationProvider transformationProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		CTZWcHG0tU42Kv7pWdrQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
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
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
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
		return Projections.Cast((IType)(object)NHibernateUtil.Int32, (IProjection)FwLyYMG0wXaGPaUFxnAU(propertyName));
	}

	internal static Type SmBlUDG0DCn5HtMuuvfD(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void CTZWcHG0tU42Kv7pWdrQ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool ryt5JdG0pYQaxDX2r7nc()
	{
		return QL1OL7G03Tx7kxmtGQVI == null;
	}

	internal static CastRightOperandFromBigint2Int NPH38wG0aiHMk2ukTTkE()
	{
		return QL1OL7G03Tx7kxmtGQVI;
	}

	internal static object FwLyYMG0wXaGPaUFxnAU(object P_0)
	{
		return Projections.Property((string)P_0);
	}
}
