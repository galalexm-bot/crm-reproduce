using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Db;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions.MSSQL;

[Component(Order = 1)]
internal class EntityUpdateDbHandler : DbUpdateHandler
{
	internal static EntityUpdateDbHandler IiCtg7BA8FsxLUHcrh;

	public override Guid ProviderUid => MSSQLProvider.UID;

	public override bool NeedRecreateConstraints => false;

	public override bool HasChanges => false;

	public override void OnProceduresDeleting(ProceduresDeletingEventArgs e)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				e.SkipNames.Add((string)DXq83C5XYotL5RXO3V(--1906803267 ^ 0x71A78243));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_536a197f18c04d92abf9ab236ddc733a == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				e.SkipNames.Add(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ACAC88E ^ 0x1ACAC89C));
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_adccb0765c0e42dbaf186220f45b757c == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public EntityUpdateDbHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		pNmp8YqRL71205QZko();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_adccb0765c0e42dbaf186220f45b757c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object DXq83C5XYotL5RXO3V(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool aOGPjrpoUtIlXkwo44()
	{
		return IiCtg7BA8FsxLUHcrh == null;
	}

	internal static EntityUpdateDbHandler xjVJyTXRunwNUov9lP()
	{
		return IiCtg7BA8FsxLUHcrh;
	}

	internal static void pNmp8YqRL71205QZko()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.BPCyhsoin5();
	}
}
