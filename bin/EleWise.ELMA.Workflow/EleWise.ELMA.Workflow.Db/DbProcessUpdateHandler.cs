using System;
using EleWise.ELMA.Runtime.Db;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Db;

public class DbProcessUpdateHandler : DbUpdateHandler
{
	private static DbProcessUpdateHandler hvGSuhOZ5l1SJn1U5R2n;

	public override Guid ProviderUid => Guid.Empty;

	public override bool HasChanges => false;

	public override bool NeedRecreateConstraints => false;

	public override void OnForeignKeysDeleting(ForeginKeysDeletingEventArgs e)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				e.SkipNames.Add((string)wNJ3muOZPn8t1ZoTi8aY(0x6C7F14 ^ 0x6DFC20));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				lwGDscOZc70meYEJ7Wvt(this, e);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override void OnPrimaryKeysDeleting(PrimaryKeysDeletingEventArgs e)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				base.OnPrimaryKeysDeleting(e);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				e.SkipNames.Add((string)wNJ3muOZPn8t1ZoTi8aY(-935313063 ^ -935214563));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public override void OnIndexesDeleting(IndexesDeletingEventArgs e)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				GOAVIsOZXd0SJO7R6sgX(this, e);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				e.SkipNames.Add((string)wNJ3muOZPn8t1ZoTi8aY(-360662087 ^ -360630035));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public DbProcessUpdateHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sfSBOFOZdvbCV9U11IuN();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void lwGDscOZc70meYEJ7Wvt(object P_0, object P_1)
	{
		((DbUpdateHandler)P_0).OnForeignKeysDeleting((ForeginKeysDeletingEventArgs)P_1);
	}

	internal static object wNJ3muOZPn8t1ZoTi8aY(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool HAvHEFOZgsv4rIvr3RLQ()
	{
		return hvGSuhOZ5l1SJn1U5R2n == null;
	}

	internal static DbProcessUpdateHandler rqog3xOZBayXPB6Ay0AB()
	{
		return hvGSuhOZ5l1SJn1U5R2n;
	}

	internal static void GOAVIsOZXd0SJO7R6sgX(object P_0, object P_1)
	{
		((DbUpdateHandler)P_0).OnIndexesDeleting((IndexesDeletingEventArgs)P_1);
	}

	internal static void sfSBOFOZdvbCV9U11IuN()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
