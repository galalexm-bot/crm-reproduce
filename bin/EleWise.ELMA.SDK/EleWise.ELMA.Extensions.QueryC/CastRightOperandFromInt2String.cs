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
internal class CastRightOperandFromInt2String : IQueryCastExtension
{
	private ITransformationProvider transformationProvider;

	internal static CastRightOperandFromInt2String J8UjnAG0x723T3R4Fwlj;

	public Type LeftOperandType => uq2wnCG0yyFGfide6uxJ(typeof(string).TypeHandle);

	public Type RightOperandType => uq2wnCG0yyFGfide6uxJ(typeof(int).TypeHandle);

	public CastRightOperandFromInt2String(ITransformationProvider transformationProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qQaPrHG0MJnr2FhjoYmK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
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
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
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
		return Projections.Cast((IType)(object)NHibernateUtil.String, (IProjection)odqMLpG0JFOmFJlW3nLH(propertyName));
	}

	internal static Type uq2wnCG0yyFGfide6uxJ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void qQaPrHG0MJnr2FhjoYmK()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool ICvFkjG00rBAKXreC7W3()
	{
		return J8UjnAG0x723T3R4Fwlj == null;
	}

	internal static CastRightOperandFromInt2String jbl1ImG0mUGmIUKEEepv()
	{
		return J8UjnAG0x723T3R4Fwlj;
	}

	internal static object odqMLpG0JFOmFJlW3nLH(object P_0)
	{
		return Projections.Property((string)P_0);
	}
}
