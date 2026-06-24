using System;
using System.Collections.Generic;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.BPMApps.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Deploy;
using EleWise.ELMA.Workflow.DTO.Managers;
using EleWise.ELMA.Workflow.DTO.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMApps;

[Component(Order = 400)]
public class WorkflowBAConverter : IBPMAppItemsConverter
{
	private static readonly Guid _exportProcessesUid;

	private static WorkflowBAConverter NdOFooZDbwfavwSiVFyO;

	public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
	{
		//Discarded unreachable code: IL_0157, IL_01f6, IL_0205, IL_0292, IL_02a5, IL_02b4, IL_02d5, IL_032c, IL_033b, IL_040b, IL_041a, IL_0478, IL_0487, IL_0498, IL_04a6, IL_050d, IL_051c, IL_05c3, IL_05d6, IL_064e, IL_065d, IL_069e
		int num = 1;
		List<Guid>.Enumerator enumerator = default(List<Guid>.Enumerator);
		WorkflowExportSetting workflowExportSetting = default(WorkflowExportSetting);
		object value = default(object);
		List<long>.Enumerator enumerator2 = default(List<long>.Enumerator);
		HashSet<Guid> hashSet = default(HashSet<Guid>);
		ProcessHeaderDTO value3 = default(ProcessHeaderDTO);
		Dictionary<long, ProcessHeaderDTO> dictionary2 = default(Dictionary<long, ProcessHeaderDTO>);
		long current2 = default(long);
		WorkflowBAChapter workflowBAChapter = default(WorkflowBAChapter);
		ProcessGroupDTO group = default(ProcessGroupDTO);
		Dictionary<Guid, ProcessHeaderDTO> dictionary = default(Dictionary<Guid, ProcessHeaderDTO>);
		ProcessHeaderDTO value2 = default(ProcessHeaderDTO);
		Guid current = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					enumerator = workflowExportSetting.ProcessesUids.GetEnumerator();
					num2 = 29;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
					{
						num2 = 12;
					}
					continue;
				default:
					QQdC7vZDBJEMbC0R1Zt0(settings, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1361036319 ^ -1360901721));
					num2 = 16;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
					{
						num2 = 16;
					}
					continue;
				case 5:
					return;
				case 28:
					return;
				case 10:
					workflowExportSetting = value as WorkflowExportSetting;
					num2 = 25;
					continue;
				case 8:
					return;
				case 12:
					return;
				case 19:
					return;
				case 18:
					if (workflowExportSetting.ProcessesIds != null)
					{
						num2 = 21;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 9;
				case 22:
					try
					{
						while (true)
						{
							IL_01ae:
							int num5;
							if (!enumerator2.MoveNext())
							{
								num5 = 5;
								goto IL_0165;
							}
							goto IL_018b;
							IL_0165:
							while (true)
							{
								switch (num5)
								{
								case 6:
									break;
								case 3:
								case 4:
									goto IL_01ae;
								default:
									if (!hashSet.Add(value3.Uid))
									{
										num5 = 4;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
										{
											num5 = 3;
										}
										continue;
									}
									goto case 2;
								case 1:
									if (dictionary2.TryGetValue(current2, out value3))
									{
										num5 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
										{
											num5 = 0;
										}
										continue;
									}
									goto IL_01ae;
								case 2:
								{
									List<ProcessBAItem> processes = workflowBAChapter.Processes;
									ProcessBAItem processBAItem = new ProcessBAItem();
									PRYRnEZDu6TlpEBYN3Ct(processBAItem, NWmnfuZDdChQpCfj6r7Q(value3));
									processes.Add(processBAItem);
									int num6 = 3;
									num5 = num6;
									continue;
								}
								case 5:
									goto end_IL_01ae;
								}
								break;
							}
							goto IL_018b;
							IL_018b:
							current2 = enumerator2.Current;
							num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
							{
								num5 = 1;
							}
							goto IL_0165;
							continue;
							end_IL_01ae:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num7 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					goto case 32;
				case 2:
					hashSet = new HashSet<Guid>();
					num2 = 15;
					continue;
				case 3:
				case 11:
				case 23:
				case 24:
					if (workflowBAChapter.Processes == null)
					{
						num2 = 12;
						continue;
					}
					goto case 31;
				case 31:
					if (T9x80gZDDRFk497KANvO(workflowBAChapter.Processes) <= 0)
					{
						num2 = 19;
						continue;
					}
					goto case 13;
				case 32:
					if (workflowExportSetting.ProcessesUids == null)
					{
						num2 = 3;
						continue;
					}
					goto case 4;
				case 9:
					if (workflowExportSetting.ProcessesUids == null)
					{
						num2 = 20;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
						{
							num2 = 24;
						}
						continue;
					}
					goto case 14;
				case 26:
					enumerator2 = workflowExportSetting.ProcessesIds.GetEnumerator();
					num2 = 22;
					continue;
				case 7:
					workflowBAChapter.Processes = new List<ProcessBAItem>();
					num2 = 27;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
					{
						num2 = 17;
					}
					continue;
				case 17:
				{
					WorkflowBAChapter workflowBAChapter2 = new WorkflowBAChapter();
					Aci4UaZDXXDXOq4Zjf6x(workflowBAChapter2, WorkflowExportConsts.ExportExtensionUid);
					workflowBAChapter = workflowBAChapter2;
					num2 = 7;
					continue;
				}
				case 6:
					FillDictionaryById(group, dictionary2, dictionary);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b != 0)
					{
						num2 = 2;
					}
					continue;
				case 27:
					if (!Ga57NTZDcfZI5rfERIO5(workflowExportSetting))
					{
						num = 23;
						break;
					}
					goto case 18;
				case 14:
				case 21:
					group = Locator.GetServiceNotNull<IProcessGroupDTOManager>().LoadRootGroup(0L);
					num2 = 30;
					continue;
				case 15:
					if (workflowExportSetting.ProcessesIds != null)
					{
						num2 = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
						{
							num2 = 26;
						}
						continue;
					}
					goto case 32;
				case 25:
					if (workflowExportSetting != null)
					{
						nmIOVmZDPhGiom21f7lW(bpmAppManifest, _exportProcessesUid, Ga57NTZDcfZI5rfERIO5(workflowExportSetting));
						num2 = 17;
					}
					else
					{
						num2 = 5;
					}
					continue;
				case 29:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 6;
								goto IL_04aa;
							}
							goto IL_0584;
							IL_04aa:
							while (true)
							{
								switch (num3)
								{
								case 1:
									workflowBAChapter.Processes.Add(new ProcessBAItem
									{
										Uid = NWmnfuZDdChQpCfj6r7Q(value2)
									});
									num3 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
									{
										num3 = 5;
									}
									continue;
								case 3:
									if (dictionary.TryGetValue(current, out value2))
									{
										num3 = 2;
										continue;
									}
									break;
								case 2:
									if (!hashSet.Add(NWmnfuZDdChQpCfj6r7Q(value2)))
									{
										num3 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 1;
								case 4:
									goto IL_0584;
								case 6:
									goto end_IL_056e;
								}
								break;
							}
							continue;
							IL_0584:
							current = enumerator.Current;
							num3 = 3;
							goto IL_04aa;
							continue;
							end_IL_056e:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 3;
				case 30:
					dictionary2 = new Dictionary<long, ProcessHeaderDTO>();
					num2 = 20;
					continue;
				case 13:
					Uxuc9WZDnInFhEW7JDu2(bpmAppManifest, workflowBAChapter);
					num2 = 8;
					continue;
				case 20:
					dictionary = new Dictionary<Guid, ProcessHeaderDTO>();
					num = 6;
					break;
				case 1:
					QQdC7vZDBJEMbC0R1Zt0(bpmAppManifest, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1212129906 ^ 0x483D600C));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					if (!settings.CustomSettings.TryGetValue(WorkflowExportConsts.ExportExtensionUid, out value))
					{
						return;
					}
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
		}
	}

	public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
	{
		//Discarded unreachable code: IL_0219, IL_0228, IL_0239, IL_0243, IL_0298, IL_035a, IL_036d
		int num = 1;
		int num2 = num;
		WorkflowExportSetting workflowExportSetting = default(WorkflowExportSetting);
		List<ProcessBAItem>.Enumerator enumerator = default(List<ProcessBAItem>.Enumerator);
		WorkflowBAChapter workflowBAChapter = default(WorkflowBAChapter);
		ProcessGroupDTO group = default(ProcessGroupDTO);
		Dictionary<Guid, ProcessHeaderDTO> dictionary = default(Dictionary<Guid, ProcessHeaderDTO>);
		ProcessBAItem current = default(ProcessBAItem);
		ProcessHeaderDTO value = default(ProcessHeaderDTO);
		while (true)
		{
			switch (num2)
			{
			case 15:
				workflowExportSetting = new WorkflowExportSetting();
				num2 = 16;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
				{
					num2 = 6;
				}
				break;
			case 16:
				workflowExportSetting.ExportProcesses = h1FqLhZDLFw2ncofDuLc(bpmAppManifest, _exportProcessesUid, Ga57NTZDcfZI5rfERIO5(workflowExportSetting));
				num2 = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
				{
					num2 = 9;
				}
				break;
			case 5:
				return;
			case 10:
				workflowExportSetting.ProcessesUids = new List<Guid>();
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
				{
					num2 = 13;
				}
				break;
			case 14:
				enumerator = workflowBAChapter.Processes.GetEnumerator();
				num2 = 12;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
				{
					num2 = 8;
				}
				break;
			case 1:
				QQdC7vZDBJEMbC0R1Zt0(bpmAppManifest, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1134D2C0 ^ 0x113610BE));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
				{
					num2 = 0;
				}
				break;
			case 13:
				group = Locator.GetServiceNotNull<IProcessGroupDTOManager>().LoadRootGroup(0L);
				num2 = 4;
				break;
			case 9:
				workflowBAChapter = TMuuAjZDf5SQGWaSELFZ(bpmAppManifest, WorkflowExportConsts.ExportExtensionUid) as WorkflowBAChapter;
				num2 = 8;
				break;
			case 8:
				if (workflowBAChapter != null)
				{
					num2 = 3;
					break;
				}
				goto case 6;
			default:
				Contract.ArgumentNotNull(settings, (string)Cm1Zk4ZDHf618pq8ZBMa(-1574607501 ^ -1574496459));
				num2 = 12;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
				{
					num2 = 15;
				}
				break;
			case 2:
				FillDictionaryByUid(group, dictionary);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
				{
					num2 = 14;
				}
				break;
			case 3:
				if (workflowBAChapter.Processes == null)
				{
					num2 = 6;
					break;
				}
				goto case 7;
			case 7:
				workflowExportSetting.ProcessesIds = new List<long>();
				num2 = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
				{
					num2 = 1;
				}
				break;
			case 12:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
							{
								num3 = 4;
							}
							goto IL_0247;
						}
						goto IL_02a2;
						IL_02a2:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
						{
							num3 = 0;
						}
						goto IL_0247;
						IL_0247:
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 3:
								break;
							case 5:
								goto IL_02a2;
							case 1:
								if (!dictionary.TryGetValue(lW5IDtZD93WO6T5lOPbJ(current), out value))
								{
									num3 = 2;
									continue;
								}
								goto case 6;
							case 6:
								workflowExportSetting.ProcessesIds.Add(value.Id);
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
								{
									num3 = 0;
								}
								continue;
							default:
								workflowExportSetting.ProcessesUids.Add(NWmnfuZDdChQpCfj6r7Q(value));
								num3 = 3;
								continue;
							case 4:
								goto end_IL_026d;
							}
							break;
						}
						continue;
						end_IL_026d:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 6;
			case 6:
			case 11:
				settings.CustomSettings[WorkflowExportConsts.ExportExtensionUid] = workflowExportSetting;
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
				{
					num2 = 3;
				}
				break;
			case 4:
				dictionary = new Dictionary<Guid, ProcessHeaderDTO>();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private void FillDictionaryById(ProcessGroupDTO group, Dictionary<long, ProcessHeaderDTO> headers, Dictionary<Guid, ProcessHeaderDTO> headersUids)
	{
		foreach (ProcessHeaderDTO process in group.Processes)
		{
			headers[process.Id] = process;
			headersUids[process.Uid] = process;
		}
		foreach (ProcessGroupDTO subGroup in group.SubGroups)
		{
			FillDictionaryById(subGroup, headers, headersUids);
		}
	}

	private void FillDictionaryByUid(ProcessGroupDTO group, Dictionary<Guid, ProcessHeaderDTO> headers)
	{
		foreach (ProcessHeaderDTO process in group.Processes)
		{
			headers[process.Uid] = process;
		}
		foreach (ProcessGroupDTO subGroup in group.SubGroups)
		{
			FillDictionaryByUid(subGroup, headers);
		}
	}

	public WorkflowBAConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowBAConverter()
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
				_exportProcessesUid = new Guid((string)Cm1Zk4ZDHf618pq8ZBMa(-539998957 ^ -539850867));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				UOatWLZDWSdEPvJaKC5I();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void QQdC7vZDBJEMbC0R1Zt0(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool Ga57NTZDcfZI5rfERIO5(object P_0)
	{
		return ((WorkflowExportSetting)P_0).ExportProcesses;
	}

	internal static void nmIOVmZDPhGiom21f7lW(object P_0, Guid P_1, bool P_2)
	{
		((BPMAppManifest)P_0).SetFlag(P_1, P_2);
	}

	internal static void Aci4UaZDXXDXOq4Zjf6x(object P_0, Guid P_1)
	{
		((BPMAppManifestChapter)P_0).Uid = P_1;
	}

	internal static Guid NWmnfuZDdChQpCfj6r7Q(object P_0)
	{
		return ((ProcessHeaderDTO)P_0).Uid;
	}

	internal static void PRYRnEZDu6TlpEBYN3Ct(object P_0, Guid P_1)
	{
		((BPMAppManifestItem)P_0).Uid = P_1;
	}

	internal static int T9x80gZDDRFk497KANvO(object P_0)
	{
		return ((List<ProcessBAItem>)P_0).Count;
	}

	internal static void Uxuc9WZDnInFhEW7JDu2(object P_0, object P_1)
	{
		((BPMAppManifest)P_0).SetChapter((BPMAppManifestChapter)P_1);
	}

	internal static bool fktrOjZD5it9WlSbpqgL()
	{
		return NdOFooZDbwfavwSiVFyO == null;
	}

	internal static WorkflowBAConverter sCCeTxZDgySALHrg8lJA()
	{
		return NdOFooZDbwfavwSiVFyO;
	}

	internal static object Cm1Zk4ZDHf618pq8ZBMa(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool h1FqLhZDLFw2ncofDuLc(object P_0, Guid P_1, bool P_2)
	{
		return ((BPMAppManifest)P_0).GetFlag(P_1, P_2);
	}

	internal static object TMuuAjZDf5SQGWaSELFZ(object P_0, Guid P_1)
	{
		return ((BPMAppManifest)P_0).GetChapter(P_1);
	}

	internal static Guid lW5IDtZD93WO6T5lOPbJ(object P_0)
	{
		return ((BPMAppManifestItem)P_0).Uid;
	}

	internal static void UOatWLZDWSdEPvJaKC5I()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
