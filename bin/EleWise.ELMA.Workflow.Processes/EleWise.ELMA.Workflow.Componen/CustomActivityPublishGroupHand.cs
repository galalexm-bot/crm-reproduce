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

[Component(Type = ComponentType.Server, Order = 200)]
internal class CustomActivityPublishGroupHandler : IPublishGroupHandler
{
	private readonly CustomActivityManager customActivityManager;

	internal static CustomActivityPublishGroupHandler G4rEXXdGqNIdJMqkAVO;

	public CustomActivityPublishGroupHandler(CustomActivityManager customActivityManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bbeafe91b1c448baa8c5cf2ab0baaadd == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.customActivityManager = customActivityManager;
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_de54abced8a94396b6a2752618533f57 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public PublishDataResult Publish(ReferenceOnEntity[] data, string comment)
	{
		//Discarded unreachable code: IL_013a, IL_01ff, IL_02b8, IL_02c7
		int num = 4;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_2 = default(_003C_003Ec__DisplayClass2_0);
		long[] array = default(long[]);
		ICustomActivity customActivity = default(ICustomActivity);
		_003C_003Ec__DisplayClass2_1 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_1);
		int num4 = default(int);
		List<ReferenceOnEntity> list = default(List<ReferenceOnEntity>);
		IEnumerable<ReferenceOnEntity> source = default(IEnumerable<ReferenceOnEntity>);
		PublishDataResult result = default(PublishDataResult);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
				{
					PublishDataResult publishDataResult2 = new PublishDataResult();
					UmZRI1dOpS8WX0whFKk(publishDataResult2, true);
					KUV6Ohd6vCdnNvf2UaW(publishDataResult2, false);
					return publishDataResult2;
				}
				case 4:
					_003C_003Ec__DisplayClass2_2 = new _003C_003Ec__DisplayClass2_0();
					num2 = 3;
					continue;
				case 2:
					try
					{
						long[] array2 = array;
						int num3 = 7;
						while (true)
						{
							switch (num3)
							{
							case 10:
								customActivity = customActivityManager.Load(_003C_003Ec__DisplayClass2_.customActivityId);
								num3 = 1;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ff730ec99c9d438e9ab033b91102c6e4 != 0)
								{
									num3 = 1;
								}
								break;
							case 4:
							case 9:
								if (num4 >= array2.Length)
								{
									num3 = 8;
									break;
								}
								goto case 3;
							case 2:
								list.Add(source.First(_003C_003Ec__DisplayClass2_._003CPublish_003Eb__2));
								num3 = 5;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_368897dda30d41e8b26c6b065203d16b == 0)
								{
									num3 = 2;
								}
								break;
							case 1:
							{
								LljZK3dRwReyvF9Yq3l(customActivityManager, customActivity);
								int num5 = 2;
								num3 = num5;
								break;
							}
							case 5:
								num4++;
								num3 = 4;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d352efd9477f4d458f3173b66f7e626f == 0)
								{
									num3 = 9;
								}
								break;
							case 6:
								_003C_003Ec__DisplayClass2_.customActivityId = array2[num4];
								num3 = 10;
								break;
							case 7:
								num4 = 0;
								num3 = 4;
								break;
							case 8:
								result = new PublishDataResult(list)
								{
									IsSuccess = true
								};
								num3 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c5274b5f82c74d1e8e92ea099532df1e == 0)
								{
									num3 = 0;
								}
								break;
							case 3:
								_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_1();
								num3 = 6;
								break;
							default:
								return result;
							case 0:
								return result;
							}
						}
					}
					catch (Exception ex)
					{
						int num6 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_58d62f4202494b18a0cc2631d85b3ead != 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								uk6s4ddBiL9ZQ6Opa2W(Logger.Log, xcqPhod0RGyQpEGjRub(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-7731921 ^ -7699201)), ex);
								num6 = 2;
								break;
							case 2:
							{
								List<ReferenceOnEntity> publishData = list;
								List<string> list2 = new List<string>();
								object obj = BHHbIPdWS9NeNyfYCfh(ex);
								string text = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x624F2FBE ^ 0x624F5836);
								Exception innerException = ex.InnerException;
								list2.Add((string)QvcFCmdHyaVsRUe6SVH(obj, text, (innerException != null) ? BHHbIPdWS9NeNyfYCfh(innerException) : null));
								PublishDataResult publishDataResult = new PublishDataResult(publishData, list2);
								UmZRI1dOpS8WX0whFKk(publishDataResult, false);
								result = publishDataResult;
								num6 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9da417d3072c4857ad8a08ca0cf38980 == 0)
								{
									num6 = 1;
								}
								break;
							}
							case 1:
								return result;
							}
						}
					}
				case 3:
					_003C_003Ec__DisplayClass2_2.customActivityTypeUid = InterfaceActivator.UID<ICustomActivity>();
					num2 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e496a9998cf542ff98d1a5e001d6c664 == 0)
					{
						num2 = 7;
					}
					continue;
				case 5:
					if (array.Length != 0)
					{
						list = new List<ReferenceOnEntity>();
						num2 = 2;
						continue;
					}
					num2 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_766d50e1f7cc46f1bc746fe53086708c == 0)
					{
						num2 = 6;
					}
					continue;
				case 7:
					source = data.Where(_003C_003Ec__DisplayClass2_2._003CPublish_003Eb__0);
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_405af183be2449cfa4440c68827d6de9 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					return result;
				case 1:
					array = source.Select((ReferenceOnEntity x) => _003C_003Ec.gasVkZWX6bMRu4D66LC(x)).ToArray();
					num = 5;
					break;
				}
				break;
			}
		}
	}

	internal static bool piQacndn3sHvPJBavRQ()
	{
		return G4rEXXdGqNIdJMqkAVO == null;
	}

	internal static CustomActivityPublishGroupHandler DaH47WdyNGU2ZkZchWh()
	{
		return G4rEXXdGqNIdJMqkAVO;
	}

	internal static void UmZRI1dOpS8WX0whFKk(object P_0, bool P_1)
	{
		((PublishDataResult)P_0).IsSuccess = P_1;
	}

	internal static void KUV6Ohd6vCdnNvf2UaW(object P_0, bool P_1)
	{
		((PublishDataResult)P_0).NeedRestart = P_1;
	}

	internal static void LljZK3dRwReyvF9Yq3l(object P_0, object P_1)
	{
		((CustomActivityManager)P_0).Publish((ICustomActivity)P_1);
	}

	internal static object xcqPhod0RGyQpEGjRub(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void uk6s4ddBiL9ZQ6Opa2W(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object BHHbIPdWS9NeNyfYCfh(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object QvcFCmdHyaVsRUe6SVH(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}
}
