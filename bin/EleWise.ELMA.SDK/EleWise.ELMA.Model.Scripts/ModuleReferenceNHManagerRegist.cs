using System;
using Autofac;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts;

[Component]
internal sealed class ModuleReferenceNHManagerRegistrar : INHManagerRegistrar
{
	internal static ModuleReferenceNHManagerRegistrar VWHNXRbVwWOESmq4GEVg;

	public void Register(NHManagerRegisterParams parameters)
	{
		//Discarded unreachable code: IL_0064, IL_00c0, IL_00f0, IL_00ff, IL_010b, IL_011a
		int num = 2;
		int num2 = num;
		IStartInformation startInformation = default(IStartInformation);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				try
				{
					((ContainerBuilder)NPjnAebV7ySj0LsLsHtW(parameters)).RegisterNHManager(NZBjOWbVxjAbVRS3t4im(typeof(ModuleReferenceManager).TypeHandle)).As<ModuleReferenceManager, IModuleReferenceManager>().SingleInstance();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						}
						parameters.Add<ModuleReferenceNHMap>();
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num3 = 1;
						}
					}
				}
				finally
				{
					int num4;
					if (startInformation == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num4 = 1;
						}
						goto IL_00c4;
					}
					goto IL_00da;
					IL_00da:
					BOlJxCbV0xsUpBKPYe9F(startInformation);
					num4 = 2;
					goto IL_00c4;
					IL_00c4:
					switch (num4)
					{
					case 1:
						goto end_IL_009f;
					case 2:
						goto end_IL_009f;
					}
					goto IL_00da;
					end_IL_009f:;
				}
			case 2:
				startInformation = StartInformation.Operation(98.0, (string)qa456ybVAfRska3Cx15O(Uhu27GbVHIIrvPlaTiVC(-218496594 ^ -218580264)));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public ModuleReferenceNHManagerRegistrar()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object Uhu27GbVHIIrvPlaTiVC(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object qa456ybVAfRska3Cx15O(object P_0)
	{
		return SR.M((string)P_0);
	}

	internal static object NPjnAebV7ySj0LsLsHtW(object P_0)
	{
		return ((NHManagerRegisterParams)P_0).Builder;
	}

	internal static Type NZBjOWbVxjAbVRS3t4im(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void BOlJxCbV0xsUpBKPYe9F(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool Jl8YBQbV4M9m44h1qYyF()
	{
		return VWHNXRbVwWOESmq4GEVg == null;
	}

	internal static ModuleReferenceNHManagerRegistrar tkUJXCbV62cMdQQomvDH()
	{
		return VWHNXRbVwWOESmq4GEVg;
	}
}
