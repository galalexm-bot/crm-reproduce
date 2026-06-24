using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts;

[Service]
internal sealed class MetadataUpdateService : IMetadataUpdateService
{
	private readonly IEnumerable<IMetadataUpdateDataHandler> metadataUpdateDataHandlers;

	private readonly IEnumerable<IMetadataUpdateHandler> metadataUpdateHandlers;

	private readonly IFeatureFlagService featureFlagService;

	internal static MetadataUpdateService y5xxxIbVT9afGGcbpG4g;

	public MetadataUpdateService(IEnumerable<IMetadataUpdateDataHandler> metadataUpdateDataHandlers, IEnumerable<IMetadataUpdateHandler> metadataUpdateHandlers, IFeatureFlagService featureFlagService)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.metadataUpdateDataHandlers = metadataUpdateDataHandlers;
		this.metadataUpdateHandlers = metadataUpdateHandlers;
		this.featureFlagService = featureFlagService;
	}

	public IMetadataUpdateResult Update(IMetadata metadata)
	{
		return Update(metadata, Guid.Empty);
	}

	public IMetadataUpdateResult Update(IMetadata metadata, Guid formUid)
	{
		//Discarded unreachable code: IL_01b4, IL_01be, IL_0235, IL_0244, IL_02a0, IL_02e8, IL_02fb, IL_0332, IL_0341, IL_034c, IL_037c, IL_038b, IL_0396, IL_042e, IL_0441, IL_0450, IL_0539, IL_054c
		int num = 6;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		List<IMetadataUpdateHandler> list2 = default(List<IMetadataUpdateHandler>);
		List<Guid> list = default(List<Guid>);
		MetadataUpdateResult metadataUpdateResult = default(MetadataUpdateResult);
		List<IMetadataUpdateDataHandler>.Enumerator enumerator3 = default(List<IMetadataUpdateDataHandler>.Enumerator);
		IMetadataUpdateDataHandler current3 = default(IMetadataUpdateDataHandler);
		List<IMetadataUpdateHandler>.Enumerator enumerator = default(List<IMetadataUpdateHandler>.Enumerator);
		IMetadataUpdateHandler current = default(IMetadataUpdateHandler);
		List<Guid>.Enumerator enumerator2 = default(List<Guid>.Enumerator);
		Guid current2 = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					throw new Exception(SR.T((string)NiN6DobV2mUTCNQVPCrL(-1767720453 ^ -1767898305), _003C_003Ec__DisplayClass5_.metadata.GetType()));
				case 5:
					break;
				case 2:
					throw new MetadataException((string)rk5mPSbVePrsnhnQtUCZ(NiN6DobV2mUTCNQVPCrL(0x4A1640F ^ 0x4A3DE8D)));
				case 6:
					_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
					num2 = 5;
					continue;
				case 8:
					if (cCwNL8bVOiZBmXH3Bm1M(featureFlagService, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548B0080), false))
					{
						list2 = metadataUpdateHandlers.Where(_003C_003Ec__DisplayClass5_._003CUpdate_003Eb__0).ToList();
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num2 = 9;
						}
					}
					else
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
						{
							num2 = 2;
						}
					}
					continue;
				case 9:
					if (hBcpLYbVPjgpxkP5g5ST(list2) != 0)
					{
						List<IMetadataUpdateDataHandler> list3 = metadataUpdateDataHandlers.Where(_003C_003Ec__DisplayClass5_._003CUpdate_003Eb__1).ToList();
						list = new List<Guid>();
						metadataUpdateResult = new MetadataUpdateResult(ClassSerializationHelper.CloneObjectByXml(_003C_003Ec__DisplayClass5_.metadata), new List<ScriptModule>(), new List<IEntity>());
						enumerator3 = list3.GetEnumerator();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 4;
					}
					continue;
				case 3:
					return metadataUpdateResult;
				default:
					try
					{
						while (true)
						{
							int num7;
							if (!enumerator3.MoveNext())
							{
								num7 = 6;
								goto IL_01c2;
							}
							goto IL_0288;
							IL_01c2:
							while (true)
							{
								switch (num7)
								{
								case 3:
									list.AddRange(current3.GetFormUids(metadataUpdateResult));
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
									{
										num7 = 0;
									}
									continue;
								case 5:
									if (!InSpGUbV1YVEMd2jOvto(formUid, Guid.Empty))
									{
										num7 = 2;
										continue;
									}
									goto case 3;
								case 4:
									metadataUpdateResult.ScriptModules.AddRange(current3.GetScriptModules(metadataUpdateResult));
									num7 = 5;
									continue;
								case 8:
									goto IL_0288;
								case 1:
								case 2:
									list.Add(formUid);
									num7 = 7;
									continue;
								case 6:
									goto end_IL_01f0;
								}
								break;
							}
							continue;
							IL_0288:
							current3 = enumerator3.Current;
							num7 = 4;
							goto IL_01c2;
							continue;
							end_IL_01f0:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					goto case 7;
				case 7:
					enumerator = list2.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					try
					{
						while (true)
						{
							IL_04e7:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
								{
									num3 = 2;
								}
								goto IL_0350;
							}
							goto IL_045b;
							IL_045b:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
							{
								num3 = 0;
							}
							goto IL_0350;
							IL_0350:
							while (true)
							{
								switch (num3)
								{
								case 2:
									return metadataUpdateResult;
								case 3:
									try
									{
										while (true)
										{
											IL_03ec:
											int num4;
											if (!enumerator2.MoveNext())
											{
												num4 = 2;
												goto IL_039a;
											}
											goto IL_03b4;
											IL_039a:
											while (true)
											{
												switch (num4)
												{
												case 3:
													current.UpdateForm(metadataUpdateResult, current2);
													num4 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
													{
														num4 = 1;
													}
													continue;
												case 1:
													goto IL_03ec;
												case 2:
													goto end_IL_03ec;
												}
												break;
											}
											goto IL_03b4;
											IL_03b4:
											current2 = enumerator2.Current;
											num4 = 3;
											goto IL_039a;
											continue;
											end_IL_03ec:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator2).Dispose();
										int num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
										{
											num5 = 0;
										}
										switch (num5)
										{
										case 0:
											break;
										}
									}
									goto case 1;
								case 5:
									break;
								default:
									sBoeWqbVN6vXhNJlHCYu(current, metadataUpdateResult);
									num3 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
									{
										num3 = 4;
									}
									continue;
								case 4:
									enumerator2 = list.GetEnumerator();
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
									{
										num3 = 3;
									}
									continue;
								case 1:
									oamxUYbV3n8AlyBLHRPk(current, metadataUpdateResult);
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
									{
										num3 = 6;
									}
									continue;
								case 6:
									goto IL_04e7;
								}
								break;
							}
							goto IL_045b;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
				}
				break;
			}
			_003C_003Ec__DisplayClass5_.metadata = metadata;
			num = 8;
		}
	}

	internal static bool GcDa4gbVkneMdqNAkUIo()
	{
		return y5xxxIbVT9afGGcbpG4g == null;
	}

	internal static MetadataUpdateService YEsGUibVnMYg6eJxsgqL()
	{
		return y5xxxIbVT9afGGcbpG4g;
	}

	internal static bool cCwNL8bVOiZBmXH3Bm1M(object P_0, object P_1, bool defaultEnabled)
	{
		return ((IFeatureFlagService)P_0).Enabled((string)P_1, defaultEnabled);
	}

	internal static object NiN6DobV2mUTCNQVPCrL(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object rk5mPSbVePrsnhnQtUCZ(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static int hBcpLYbVPjgpxkP5g5ST(object P_0)
	{
		return ((List<IMetadataUpdateHandler>)P_0).Count;
	}

	internal static bool InSpGUbV1YVEMd2jOvto(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static void sBoeWqbVN6vXhNJlHCYu(object P_0, object P_1)
	{
		((IMetadataUpdateHandler)P_0).UpdateMetadata((IMetadataUpdateResult)P_1);
	}

	internal static void oamxUYbV3n8AlyBLHRPk(object P_0, object P_1)
	{
		((IMetadataUpdateHandler)P_0).UpdateScriptModules((IMetadataUpdateResult)P_1);
	}
}
