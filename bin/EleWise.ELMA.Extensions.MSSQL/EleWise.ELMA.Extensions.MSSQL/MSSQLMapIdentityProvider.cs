using System;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Id;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;

namespace EleWise.ELMA.Extensions.MSSQL;

internal class MSSQLMapIdentityProvider : MapIdentityProvider
{
	private static MSSQLMapIdentityProvider TNNRdNMBQP4cvIP3W3q;

	public override void SetGenerator(IIdMapper mapping, string tableName, string idColumnName)
	{
		//Discarded unreachable code: IL_00ba, IL_00c9
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass0_.tableName = tableName;
				num2 = 5;
				break;
			default:
				mapping.Generator((IGeneratorDef)J2vjjpMDaAE8RBMc8lF(), (Action<IGeneratorMapper>)_003C_003Ec__DisplayClass0_._003CSetGenerator_003Eb__0);
				num2 = 4;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_e4ca8eb6304c45b5b9866ec7523159cd == 0)
				{
					num2 = 3;
				}
				break;
			case 5:
				if (!aenf6LMqRMA4tASjgTH(new MSSQLTransformationProvider(((IMainDatabaseProvider)UaM87aM5vKbbTsrHGlT(Locator.GetServiceNotNull<IRuntimeApplication>())).ConnectionString)))
				{
					num2 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_da020ace8b12415a904b6d9c77d7515c == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 6:
				return;
			case 4:
				return;
			case 1:
				mapping.Generator(IdentityHiLoFromTableGenerator.GeneratorDef, (Action<IGeneratorMapper>)_003C_003Ec__DisplayClass0_._003CSetGenerator_003Eb__1);
				num2 = 6;
				break;
			case 3:
				_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
				num2 = 2;
				break;
			}
		}
	}

	public MSSQLMapIdentityProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.BPCyhsoin5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_dd87e5ded93948d0bf26853dd7df12f5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object UaM87aM5vKbbTsrHGlT(object P_0)
	{
		return ((IRuntimeApplication)P_0).MainProvider;
	}

	internal static bool aenf6LMqRMA4tASjgTH(object P_0)
	{
		return ((MSSQLTransformationProvider)P_0).IsSequenceSupport;
	}

	internal static object J2vjjpMDaAE8RBMc8lF()
	{
		return ElmaSequenceHiLoGenerator.GeneratorDef;
	}

	internal static bool z8XMMXMpVce6ikc0H98()
	{
		return TNNRdNMBQP4cvIP3W3q == null;
	}

	internal static MSSQLMapIdentityProvider CMM28oMXiYnCpkEc5V6()
	{
		return TNNRdNMBQP4cvIP3W3q;
	}
}
