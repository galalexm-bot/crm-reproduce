using System;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Runtime.Db;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Extensions.MSSQL;

internal class CoreDbStructure : DbStructureExtension
{
	private static CoreDbStructure RjDXWt8Tqm5h8cBp051;

	public override Guid ProviderUid => MSSQLProvider.UID;

	public override Type Parent => gYoJs68V4NvREYVXbdy(typeof(EleWise.ELMA.Model.Db.CoreDbStructure).TypeHandle);

	internal void Alter_G_GenIdFix()
	{
		//Discarded unreachable code: IL_0039
		int num = 1;
		int num2 = num;
		MSSQLTransformationProvider mSSQLTransformationProvider = default(MSSQLTransformationProvider);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				if (mSSQLTransformationProvider != null)
				{
					num2 = 4;
					break;
				}
				return;
			case 4:
				if (vOsY3V8UGK5ZBpJDaMX(mSSQLTransformationProvider))
				{
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_d2ea3571782f460a8fcf4212c4b89aef != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 5;
			case 3:
				return;
			case 5:
				OrYcaW8GxTV5LeC71Yy(mSSQLTransformationProvider);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_3f5427a24f2948678f15f0286379c485 == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				mSSQLTransformationProvider = base.Transformation as MSSQLTransformationProvider;
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ec5f92fd6ddb449a9afc09c18f0a77db != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public CoreDbStructure()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		wIxZOf8FOBfOuLkRf2A();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_74c50b4541604f879acc41487ba8662e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type gYoJs68V4NvREYVXbdy(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool vOsY3V8UGK5ZBpJDaMX(object P_0)
	{
		return ((MSSQLTransformationProvider)P_0).IsSequenceSupport;
	}

	internal static void OrYcaW8GxTV5LeC71Yy(object P_0)
	{
		((MSSQLTransformationProvider)P_0).G_GenId_Real();
	}

	internal static bool SV4SWt8gPOj51hyCNfS()
	{
		return RjDXWt8Tqm5h8cBp051 == null;
	}

	internal static CoreDbStructure KhhEVh8Rlym3YC3vpbk()
	{
		return RjDXWt8Tqm5h8cBp051;
	}

	internal static void wIxZOf8FOBfOuLkRf2A()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.BPCyhsoin5();
	}
}
