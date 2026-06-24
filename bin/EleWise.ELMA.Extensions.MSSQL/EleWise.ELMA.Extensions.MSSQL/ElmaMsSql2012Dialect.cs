using j3AmrhgkCleVTGdEwA;
using NHibernate.Dialect;

namespace EleWise.ELMA.Extensions.MSSQL;

internal class ElmaMsSql2012Dialect : MsSql2012Dialect
{
	internal static ElmaMsSql2012Dialect XQ6xFkhMUAZ3nFSEWu;

	public override string GetCreateSequenceString(string sequenceName)
	{
		return (string)dV8wULcI29GDc60lUP(this, sequenceName, 0, 1);
	}

	public ElmaMsSql2012Dialect()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.BPCyhsoin5();
		((MsSql2012Dialect)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ac9723878e2248bcb9bd99e393b431fd != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object dV8wULcI29GDc60lUP(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Dialect)P_0).GetCreateSequenceString((string)P_1, P_2, P_3);
	}

	internal static bool Xru4xkH45PProuEa9u()
	{
		return XQ6xFkhMUAZ3nFSEWu == null;
	}

	internal static ElmaMsSql2012Dialect nFMAIcsUlmLVKdpnPq()
	{
		return XQ6xFkhMUAZ3nFSEWu;
	}
}
