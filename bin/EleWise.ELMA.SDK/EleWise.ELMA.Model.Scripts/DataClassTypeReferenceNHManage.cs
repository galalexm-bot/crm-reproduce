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
internal sealed class DataClassTypeReferenceNHManagerRegistrar : INHManagerRegistrar
{
	internal static DataClassTypeReferenceNHManagerRegistrar jDk0X2bIISAWTfV8tuPV;

	public void Register(NHManagerRegisterParams parameters)
	{
		//Discarded unreachable code: IL_00ae, IL_010a, IL_0142, IL_0151
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
			case 2:
				startInformation = (IStartInformation)HjWnwbbIqSLBGtGsbE85(99.0, XCw3LfbIRV8nNwjluwyo(FeJaRebIiHNJcxRtHB3W(-1751176224 ^ -1751281032)));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					((ContainerBuilder)mrJJ1IbIKrgkTPrQ923s(parameters)).RegisterNHManager(typeof(DataClassTypeReferenceManager)).As<DataClassTypeReferenceManager>().As<IDataClassTypeReferenceManager>()
						.SingleInstance();
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							parameters.Add<DataClassTypeReferenceNHMap>();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				finally
				{
					if (startInformation != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								UQG57TbIXsksAThK7Efm(startInformation);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			}
		}
	}

	public DataClassTypeReferenceNHManagerRegistrar()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object FeJaRebIiHNJcxRtHB3W(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object XCw3LfbIRV8nNwjluwyo(object P_0)
	{
		return SR.M((string)P_0);
	}

	internal static object HjWnwbbIqSLBGtGsbE85(double completePercent, object P_1)
	{
		return StartInformation.Operation(completePercent, (string)P_1);
	}

	internal static object mrJJ1IbIKrgkTPrQ923s(object P_0)
	{
		return ((NHManagerRegisterParams)P_0).Builder;
	}

	internal static void UQG57TbIXsksAThK7Efm(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool hZEUr3bIV60w3IlGLDh8()
	{
		return jDk0X2bIISAWTfV8tuPV == null;
	}

	internal static DataClassTypeReferenceNHManagerRegistrar Qwm7yAbISBr73eO4pdBI()
	{
		return jDk0X2bIISAWTfV8tuPV;
	}
}
