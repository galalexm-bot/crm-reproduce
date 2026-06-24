using System;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Extensions.MSSQL.NH;

internal sealed class MsSqlStreamNHType : StreamNHType
{
	internal sealed class MsSqlStreamNHTypeRegistrar : NHProviderDependentUserTypeRegistrar<MsSqlStreamNHType, StreamNHType>
	{
		private static MsSqlStreamNHTypeRegistrar g0lTZ799kX775q8MGq5;

		public override Guid ProviderUid { get; }

		public MsSqlStreamNHTypeRegistrar()
		{
			//Discarded unreachable code: IL_003a, IL_003f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.BPCyhsoin5();
			ProviderUid = MSSQLProvider.UID;
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_4d5fabaf870f450c93de24e9225e7993 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool frG50J9yy2mYIXJ9ow4()
		{
			return g0lTZ799kX775q8MGq5 == null;
		}

		internal static MsSqlStreamNHTypeRegistrar jwFmYR9nvmKs8RAFVnJ()
		{
			return g0lTZ799kX775q8MGq5;
		}
	}

	private static MsSqlStreamNHType j8sHJn8i4HCjXTWXrYr;

	public MsSqlStreamNHType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		TRd4aE8h9noAG0cbTUp();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b98765ef3c444c499e843eecd7ad6cc5 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void TRd4aE8h9noAG0cbTUp()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.BPCyhsoin5();
	}

	internal static bool udytij84ifoUf6q97Oq()
	{
		return j8sHJn8i4HCjXTWXrYr == null;
	}

	internal static MsSqlStreamNHType V3gyBC8e9COD50ysRK2()
	{
		return j8sHJn8i4HCjXTWXrYr;
	}
}
