using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Export;

internal sealed class ModuleExportExtension
{
	[Component]
	private sealed class ImportantData : IImportantData
	{
		internal static object c6BTB287Hi8M2q1R52cK;

		public Guid Uid => ModuleExportConsts.ModulePacketImportantDataUid;

		public IEnumerable<Version> Versions { get; }

		public string Module => null;

		public ImportantData()
		{
			//Discarded unreachable code: IL_0046, IL_004b
			cmmWwS87xYX3dFLFnO4i();
			Versions = new Version[1]
			{
				new Version(4, 1, 6)
			};
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void cmmWwS87xYX3dFLFnO4i()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool klv1j887A2ovpJGXmUX5()
		{
			return c6BTB287Hi8M2q1R52cK == null;
		}

		internal static ImportantData OULCgP877Kvjv6xgt7w5()
		{
			return (ImportantData)c6BTB287Hi8M2q1R52cK;
		}
	}

	private static ModuleExportExtension Cg3PPvEg1CCmnCCmrtjp;

	public ModuleExportExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ljan8FEgpYswCuxbUVCl();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void ljan8FEgpYswCuxbUVCl()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool wYMEZeEgNZGV9bWDmsS7()
	{
		return Cg3PPvEg1CCmnCCmrtjp == null;
	}

	internal static ModuleExportExtension cP87UFEg3INdSAqLWorR()
	{
		return Cg3PPvEg1CCmnCCmrtjp;
	}
}
