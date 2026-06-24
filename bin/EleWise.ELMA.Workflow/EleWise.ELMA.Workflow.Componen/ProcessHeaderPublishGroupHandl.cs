using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints.Publication;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Publication;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components.Publication;

[Component(Type = ComponentType.Server, Order = 300)]
internal class ProcessHeaderPublishGroupHandler : IPublishGroupHandler
{
	private readonly ProcessHeaderManager processHeaderManager;

	internal static ProcessHeaderPublishGroupHandler tnq7ZKOB1fY1EhuyAL1d;

	public ProcessHeaderPublishGroupHandler(ProcessHeaderManager processHeaderManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		i7v4gVOBwtpiKaICifTB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
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
			this.processHeaderManager = processHeaderManager;
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
			{
				num = 1;
			}
		}
	}

	public PublishDataResult Publish(ReferenceOnEntity[] data, string comment)
	{
		//Discarded unreachable code: IL_008a, IL_0151, IL_01fd, IL_02cc, IL_0332
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		long id = default(long);
		IEnumerable<ReferenceOnEntity> source = default(IEnumerable<ReferenceOnEntity>);
		PublishDataResult result = default(PublishDataResult);
		long[] array2 = default(long[]);
		int num4 = default(int);
		long[] array = default(long[]);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass2_.processHeaderTypeUid = InterfaceActivator.UID<IProcessHeader>();
				num2 = 2;
				break;
			case 7:
			{
				PublishDataResult publishDataResult2 = new PublishDataResult();
				Y9OEKGOB4e5VoLfcF0Iu(publishDataResult2, true);
				publishDataResult2.NeedRestart = false;
				return publishDataResult2;
			}
			default:
				num2 = 6;
				break;
			case 6:
				try
				{
					List<IProcessHeader> list = new List<IProcessHeader>();
					int num3 = 5;
					while (true)
					{
						switch (num3)
						{
						case 7:
							list.Add(processHeaderManager.Load(id));
							num3 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
							{
								num3 = 2;
							}
							break;
						case 1:
						{
							PublishDataResult publishDataResult = new PublishDataResult(source.ToList());
							Y9OEKGOB4e5VoLfcF0Iu(publishDataResult, true);
							result = publishDataResult;
							num3 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
							{
								num3 = 4;
							}
							break;
						}
						case 9:
							id = array2[num4];
							num3 = 7;
							break;
						case 8:
							num4 = 0;
							num3 = 6;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
							{
								num3 = 6;
							}
							break;
						default:
							if (num4 >= array2.Length)
							{
								num3 = 3;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
								{
									num3 = 1;
								}
								break;
							}
							goto case 9;
						case 2:
							num4++;
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 != 0)
							{
								num3 = 0;
							}
							break;
						case 3:
							processHeaderManager.Publish((IEnumerable<IProcessHeader>)vRiTanOBzPjtCyxUSpQs(list), comment, generateDocumentation: false);
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
							{
								num3 = 1;
							}
							break;
						case 5:
							array2 = array;
							num3 = 8;
							break;
						case 4:
							return result;
						}
					}
				}
				catch (Exception ex)
				{
					int num5 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							fysj4WOcZLp5kMGlRn1j(Logger.Log, gEKGhlOcOQnaOBan9KCV(iriUsgOcKAPekTFrmjtD(-1600060848 ^ -1600074122)), ex);
							num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
							{
								num5 = 1;
							}
							break;
						case 1:
						{
							List<string> list2 = new List<string>();
							object obj = DlrIIwOcvQLcRqg2fdbc(ex);
							object obj2 = iriUsgOcKAPekTFrmjtD(-1303601216 ^ -1303513298);
							object obj3 = tZBE0DOcYEKvwsByXr6Q(ex);
							list2.Add((string)nK4G4gOc8wDycIIsSjJi(obj, obj2, (obj3 != null) ? DlrIIwOcvQLcRqg2fdbc(obj3) : null));
							result = new PublishDataResult(null, list2)
							{
								IsSuccess = false
							};
							num5 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
							{
								num5 = 0;
							}
							break;
						}
						case 2:
							return result;
						}
					}
				}
			case 8:
				return result;
			case 4:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				source = data.Where(_003C_003Ec__DisplayClass2_._003CPublish_003Eb__0);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				if (array.Length != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 7;
			case 1:
				array = source.Select((ReferenceOnEntity x) => _003C_003Ec.PTemJHvYvPvxeMkR1HYo(x)).ToArray();
				num2 = 5;
				break;
			}
		}
	}

	internal static void i7v4gVOBwtpiKaICifTB()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool iqVPDLOBhCvxb7AZK190()
	{
		return tnq7ZKOB1fY1EhuyAL1d == null;
	}

	internal static ProcessHeaderPublishGroupHandler I8QPUMOBECOyWU98a2G5()
	{
		return tnq7ZKOB1fY1EhuyAL1d;
	}

	internal static void Y9OEKGOB4e5VoLfcF0Iu(object P_0, bool P_1)
	{
		((PublishDataResult)P_0).IsSuccess = P_1;
	}

	internal static object vRiTanOBzPjtCyxUSpQs(object P_0)
	{
		return ((List<IProcessHeader>)P_0).ToArray();
	}

	internal static object iriUsgOcKAPekTFrmjtD(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object gEKGhlOcOQnaOBan9KCV(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void fysj4WOcZLp5kMGlRn1j(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object DlrIIwOcvQLcRqg2fdbc(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object tZBE0DOcYEKvwsByXr6Q(object P_0)
	{
		return ((Exception)P_0).InnerException;
	}

	internal static object nK4G4gOc8wDycIIsSjJi(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}
}
