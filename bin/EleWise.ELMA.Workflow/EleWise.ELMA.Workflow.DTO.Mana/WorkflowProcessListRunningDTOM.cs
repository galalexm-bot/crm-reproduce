using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public class WorkflowProcessListRunningDTOManager : DTOManager, IWorkflowProcessListRunningDTOManager, IConfigurationService
{
	internal static WorkflowProcessListRunningDTOManager oR5q01NyYuEBRCotylO;

	public WorkflowProcessListRunningManager workflowListProcessesRunningEntityManager
	{
		[CompilerGenerated]
		get
		{
			return _003CworkflowListProcessesRunningEntityManager_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CworkflowListProcessesRunningEntityManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public virtual List<WorkflowProcessListRunningDTO> Load(EntityMetadata metadata, bool objectUser)
	{
		AddParentRoutes(metadata, objectUser);
		return Load(objectUser ? metadata.ImplementationUid : metadata.Uid);
	}

	public virtual List<WorkflowProcessListRunningDTO> Load(Guid typeId)
	{
		List<WorkflowProcessListRunningDTO> list = new List<WorkflowProcessListRunningDTO>();
		IWorkflowProcessListRunningFilter workflowProcessListRunningFilter = InterfaceActivator.Create<IWorkflowProcessListRunningFilter>();
		workflowProcessListRunningFilter.TypeObject = typeId;
		workflowProcessListRunningFilter.DisableSecurity = true;
		foreach (IWorkflowProcessListRunning item in workflowListProcessesRunningEntityManager.Find(workflowProcessListRunningFilter, FetchOptions.All))
		{
			if (item.ProcessHeader == null)
			{
				item.Delete();
				continue;
			}
			list.Add(new WorkflowProcessListRunningDTO
			{
				RootMetadata = (item.RootMetadata ?? item.TypeObject),
				processHeaderDTO = Mapper.Map<IProcessHeader, ProcessHeaderDTO>(item.ProcessHeader, new ProcessHeaderDTO()),
				IsParent = (item.IsParent ?? false)
			});
		}
		return list;
	}

	public virtual void Save(List<WorkflowProcessListRunningDTO> data, EntityMetadata metadata, bool objectUser)
	{
		SaveRoute(data, objectUser ? metadata.ImplementationUid : metadata.Uid, objectUser);
		AddParentRoutes(metadata, objectUser);
	}

	public virtual void Save(List<WorkflowProcessListRunningDTO> data, Guid typeId)
	{
		SaveRoute(data, typeId, objectUser: true);
	}

	private void SaveRoute(List<WorkflowProcessListRunningDTO> data, Guid typeId, bool objectUser)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals0.typeId = typeId;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.objectUser = objectUser;
		IWorkflowProcessListRunningFilter workflowProcessListRunningFilter = InterfaceActivator.Create<IWorkflowProcessListRunningFilter>();
		workflowProcessListRunningFilter.TypeObject = CS_0024_003C_003E8__locals0.typeId;
		workflowProcessListRunningFilter.IsParent = false;
		workflowProcessListRunningFilter.DisableSecurity = true;
		CS_0024_003C_003E8__locals0.old = workflowListProcessesRunningEntityManager.Find(workflowProcessListRunningFilter, FetchOptions.All);
		using (IEnumerator<IWorkflowProcessListRunning> enumerator = CS_0024_003C_003E8__locals0.old.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass8_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass8_1();
				CS_0024_003C_003E8__locals1.p = enumerator.Current;
				if (!data.Any(delegate(WorkflowProcessListRunningDTO r)
				{
					//Discarded unreachable code: IL_0066, IL_0075
					int num5 = 3;
					int num6 = num5;
					while (true)
					{
						switch (num6)
						{
						case 2:
							if (_003C_003Ec__DisplayClass8_1.vjL1qCZrqkFyuGEEeRNv(r))
							{
								num6 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
								{
									num6 = 0;
								}
								continue;
							}
							goto case 1;
						case 3:
							if (r != null)
							{
								num6 = 2;
								continue;
							}
							break;
						case 1:
							return _003C_003Ec__DisplayClass8_1.qimX88ZrC4x9ra3EHSKF(_003C_003Ec__DisplayClass8_1.aPSQhHZrTLvKdRTuSine(_003C_003Ec__DisplayClass8_1.MDRtMfZr3HJVDR1wmdTh(r)), _003C_003Ec__DisplayClass8_1.a55DDjZrpFx9BmRF7FnS(_003C_003Ec__DisplayClass8_1.MmO1gIZrQYNgwjLlhlRY(CS_0024_003C_003E8__locals1.p)));
						}
						break;
					}
					return false;
				}))
				{
					DeleteChildRoutes(CS_0024_003C_003E8__locals1.p, CS_0024_003C_003E8__locals0.objectUser);
					workflowListProcessesRunningEntityManager.Delete(CS_0024_003C_003E8__locals1.p);
				}
			}
		}
		data.Where(delegate(WorkflowProcessListRunningDTO p)
		{
			//Discarded unreachable code: IL_006c
			int num3 = 1;
			_003C_003Ec__DisplayClass8_2 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_2);
			while (true)
			{
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					default:
						_003C_003Ec__DisplayClass8_.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
						num4 = 3;
						continue;
					case 1:
						_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_2();
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
						{
							num4 = 0;
						}
						continue;
					case 3:
						_003C_003Ec__DisplayClass8_.p = p;
						num4 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
						{
							num4 = 1;
						}
						continue;
					case 4:
						return !CS_0024_003C_003E8__locals0.old.Any(_003C_003Ec__DisplayClass8_._003CSaveRoute_003Eb__3);
					case 5:
						return false;
					case 2:
						if (!_003C_003Ec__DisplayClass8_0.PSdHaWZrHpkIVikYhHFU(_003C_003Ec__DisplayClass8_0.MVS591ZrnTruG2e2DJSI(_003C_003Ec__DisplayClass8_.p), CS_0024_003C_003E8__locals0.typeId))
						{
							break;
						}
						goto case 4;
					}
					break;
				}
				num3 = 5;
			}
		}).ToList().ForEach(delegate(WorkflowProcessListRunningDTO a)
		{
			int num = 6;
			int num2 = num;
			IProcessHeader processHeader = default(IProcessHeader);
			IWorkflowProcessListRunning workflowProcessListRunning = default(IWorkflowProcessListRunning);
			while (true)
			{
				switch (num2)
				{
				case 6:
					processHeader = Mapper.Map<ProcessHeaderDTO, IProcessHeader>((ProcessHeaderDTO)_003C_003Ec__DisplayClass8_0.hRiBTEZrLQb4SbL23Ho7(a));
					num2 = 5;
					break;
				default:
					workflowProcessListRunning.IsParent = false;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b != 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					workflowProcessListRunning = CS_0024_003C_003E8__locals0._003C_003E4__this.workflowListProcessesRunningEntityManager.Create();
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					return;
				case 7:
					workflowProcessListRunning.RootMetadata = CS_0024_003C_003E8__locals0.typeId;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num2 = 0;
					}
					break;
				case 8:
					_003C_003Ec__DisplayClass8_0.Cp3M8kZrfFVyQf3cfi4b(workflowProcessListRunning, processHeader);
					num2 = 9;
					break;
				case 4:
					CS_0024_003C_003E8__locals0._003C_003E4__this.AddChildRoutes(workflowProcessListRunning, CS_0024_003C_003E8__locals0.objectUser);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					workflowProcessListRunning.RootMetadata = a.RootMetadata;
					num2 = 2;
					break;
				case 2:
					_003C_003Ec__DisplayClass8_0.UkKPS6ZrW3UTS8YJJPXi(workflowProcessListRunning);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
					{
						num2 = 4;
					}
					break;
				case 9:
					_003C_003Ec__DisplayClass8_0.dcdXEQZr9AdfRY8uDm5t(workflowProcessListRunning, CS_0024_003C_003E8__locals0.typeId);
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
					{
						num2 = 7;
					}
					break;
				}
			}
		});
	}

	private void DeleteChildRoutes(IWorkflowProcessListRunning route, bool objectUser)
	{
		//Discarded unreachable code: IL_0037, IL_0085, IL_0094, IL_009f, IL_011b, IL_015b, IL_016a, IL_0176, IL_02d7, IL_030f, IL_031e, IL_032d
		int num = 2;
		int num2 = num;
		IEnumerator<EntityMetadata> enumerator = default(IEnumerator<EntityMetadata>);
		IEnumerator<IWorkflowProcessListRunning> enumerator2 = default(IEnumerator<IWorkflowProcessListRunning>);
		IWorkflowProcessListRunningFilter workflowProcessListRunningFilter = default(IWorkflowProcessListRunningFilter);
		EntityMetadata current = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 2:
				if (!xOkygaN5ilaLXx818yd(Q7KPUGNbCDhRAB9DwVu(Locator.GetServiceNotNull<IMetadataRuntimeService>(), route.TypeObject, true), null))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				return;
			case 3:
				return;
			case 1:
				enumerator = MetadataLoader.GetChildClasses((EntityMetadata)MetadataLoader.LoadMetadata(AdGS6uNgFlh4CGrjjZU(route))).OfType<EntityMetadata>().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					IL_0257:
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 3;
						goto IL_0049;
					}
					goto IL_019b;
					IL_0049:
					while (true)
					{
						switch (num3)
						{
						case 3:
							return;
						case 6:
							try
							{
								while (true)
								{
									int num4;
									if (!enumerator2.MoveNext())
									{
										num4 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
										{
											num4 = 0;
										}
										goto IL_00a3;
									}
									goto IL_00b9;
									IL_00b9:
									H4CwmANXOGpotXUbUhs(enumerator2.Current);
									num4 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
									{
										num4 = 1;
									}
									goto IL_00a3;
									IL_00a3:
									switch (num4)
									{
									case 2:
										goto IL_00b9;
									case 1:
										continue;
									case 0:
										break;
									}
									break;
								}
							}
							finally
							{
								int num5;
								if (enumerator2 == null)
								{
									num5 = 2;
									goto IL_011f;
								}
								goto IL_0135;
								IL_011f:
								switch (num5)
								{
								default:
									goto end_IL_010a;
								case 1:
									break;
								case 2:
									goto end_IL_010a;
								case 0:
									goto end_IL_010a;
								}
								goto IL_0135;
								IL_0135:
								YyG3SBNdWCFCZvGb4OV(enumerator2);
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
								{
									num5 = 0;
								}
								goto IL_011f;
								end_IL_010a:;
							}
							goto IL_0257;
						default:
						{
							workflowProcessListRunningFilter.IsParent = true;
							int num6 = 2;
							num3 = num6;
							continue;
						}
						case 9:
							break;
						case 1:
							enumerator2 = workflowListProcessesRunningEntityManager.Find(workflowProcessListRunningFilter, FetchOptions.All).GetEnumerator();
							num3 = 6;
							continue;
						case 2:
							workflowProcessListRunningFilter.ProcessHeader = route.ProcessHeader;
							num3 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
							{
								num3 = 4;
							}
							continue;
						case 7:
							DpVH1TNPNAKyGwUGj15(workflowProcessListRunningFilter, false);
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
							{
								num3 = 1;
							}
							continue;
						case 4:
							workflowProcessListRunningFilter.RootMetadata = route.TypeObject;
							num3 = 7;
							continue;
						case 8:
							workflowProcessListRunningFilter = InterfaceActivator.Create<IWorkflowProcessListRunningFilter>();
							num3 = 5;
							continue;
						case 10:
							goto IL_0257;
						case 5:
							workflowProcessListRunningFilter.TypeObject = (objectUser ? vxYhhXNcyjcAXnLvYMU(current) : nVQeyQNBGSgReQ6N8tq(current));
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						break;
					}
					goto IL_019b;
					IL_019b:
					current = enumerator.Current;
					num3 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
					{
						num3 = 2;
					}
					goto IL_0049;
				}
			}
			finally
			{
				if (enumerator != null)
				{
					int num7 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
					{
						num7 = 0;
					}
					while (true)
					{
						switch (num7)
						{
						default:
							enumerator.Dispose();
							num7 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
							{
								num7 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
			}
		}
	}

	private void AddParentRoutes(EntityMetadata metadata, bool objectUser)
	{
		//Discarded unreachable code: IL_00b0, IL_00bf, IL_00ca, IL_0163, IL_019b, IL_0218, IL_0227, IL_0287, IL_03a6, IL_03b5, IL_04c5, IL_04d8, IL_04e7
		int num = 24;
		ICollection<IWorkflowProcessListRunning> collection = default(ICollection<IWorkflowProcessListRunning>);
		IWorkflowProcessListRunningFilter workflowProcessListRunningFilter3 = default(IWorkflowProcessListRunningFilter);
		IEnumerator<IWorkflowProcessListRunning> enumerator2 = default(IEnumerator<IWorkflowProcessListRunning>);
		IEnumerable<ClassMetadata> source = default(IEnumerable<ClassMetadata>);
		IWorkflowProcessListRunningFilter workflowProcessListRunningFilter2 = default(IWorkflowProcessListRunningFilter);
		IWorkflowProcessListRunningFilter workflowProcessListRunningFilter = default(IWorkflowProcessListRunningFilter);
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_2 = default(_003C_003Ec__DisplayClass10_0);
		_003C_003Ec__DisplayClass10_1 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_1);
		List<IWorkflowProcessListRunning>.Enumerator enumerator = default(List<IWorkflowProcessListRunning>.Enumerator);
		IWorkflowProcessListRunning current = default(IWorkflowProcessListRunning);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 25:
					collection = workflowListProcessesRunningEntityManager.Find(workflowProcessListRunningFilter3, FetchOptions.All);
					num2 = 10;
					continue;
				case 22:
					try
					{
						while (true)
						{
							int num6;
							if (!s7YWJHNHP3xYTxxcFQd(enumerator2))
							{
								num6 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
								{
									num6 = 0;
								}
								goto IL_00ce;
							}
							goto IL_00e4;
							IL_00e4:
							IWorkflowProcessListRunning current2 = enumerator2.Current;
							current2.RootMetadata = current2.TypeObject;
							current2.IsParent = false;
							current2.Save();
							num6 = 2;
							goto IL_00ce;
							IL_00ce:
							switch (num6)
							{
							case 1:
								goto IL_00e4;
							case 2:
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							int num7 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
							{
								num7 = 0;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									YyG3SBNdWCFCZvGb4OV(enumerator2);
									num7 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
									{
										num7 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 3;
				case 18:
					if (!source.Any())
					{
						num2 = 21;
						continue;
					}
					goto case 11;
				case 15:
					workflowProcessListRunningFilter2 = InterfaceActivator.Create<IWorkflowProcessListRunningFilter>();
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
					{
						num2 = 12;
					}
					continue;
				case 26:
					DpVH1TNPNAKyGwUGj15(workflowProcessListRunningFilter2, false);
					num2 = 8;
					continue;
				case 10:
					workflowProcessListRunningFilter = InterfaceActivator.Create<IWorkflowProcessListRunningFilter>();
					num2 = 20;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
					{
						num2 = 13;
					}
					continue;
				case 21:
					return;
				case 7:
					source = MetadataLoader.GetBaseClasses(_003C_003Ec__DisplayClass10_2.metadata).Where(_003C_003Ec__DisplayClass10_2._003CAddParentRoutes_003Eb__0);
					num2 = 18;
					continue;
				case 12:
					HWkwiVNDqpwCBrMFloQ(workflowProcessListRunningFilter2, QCjtvWNuRDUDunc59Y6(0x65B7F624 ^ 0x65B6A082));
					num = 26;
					break;
				case 23:
					_003C_003Ec__DisplayClass10_2.metadata = metadata;
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
					{
						num2 = 2;
					}
					continue;
				case 14:
					return;
				case 8:
					enumerator2 = workflowListProcessesRunningEntityManager.Find(workflowProcessListRunningFilter2, (FetchOptions)aBjqJ5Nn4JMUEdfNkkT()).GetEnumerator();
					num2 = 22;
					continue;
				case 20:
					if (h9Es6RNLPOMTh7FVwgX(collection) <= 0)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 17;
				default:
					DpVH1TNPNAKyGwUGj15(workflowProcessListRunningFilter, false);
					num = 27;
					break;
				case 3:
					if (_003C_003Ec__DisplayClass10_2.metadata == null)
					{
						return;
					}
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
					{
						num2 = 7;
					}
					continue;
				case 27:
					_003C_003Ec__DisplayClass10_.oldnew = workflowListProcessesRunningEntityManager.Find(workflowProcessListRunningFilter, FetchOptions.All);
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
					{
						num2 = 19;
					}
					continue;
				case 24:
					_003C_003Ec__DisplayClass10_2 = new _003C_003Ec__DisplayClass10_0();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
					{
						num2 = 23;
					}
					continue;
				case 9:
					workflowProcessListRunningFilter3.DisableSecurity = false;
					num2 = 25;
					continue;
				case 16:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
								{
									num3 = 2;
								}
								goto IL_03c4;
							}
							goto IL_0404;
							IL_0404:
							current = enumerator.Current;
							int num4 = 3;
							num3 = num4;
							goto IL_03c4;
							IL_03c4:
							while (true)
							{
								switch (num3)
								{
								case 2:
									return;
								case 1:
									goto IL_0404;
								case 3:
								{
									IWorkflowProcessListRunning workflowProcessListRunning = workflowListProcessesRunningEntityManager.Create();
									workflowProcessListRunning.ProcessHeader = current.ProcessHeader;
									tw2tayN9gq7R9kyHoYW(workflowProcessListRunning, objectUser ? nVQeyQNBGSgReQ6N8tq(_003C_003Ec__DisplayClass10_2.metadata) : vxYhhXNcyjcAXnLvYMU(_003C_003Ec__DisplayClass10_2.metadata));
									workflowProcessListRunning.RootMetadata = current.RootMetadata;
									workflowProcessListRunning.IsParent = true;
									QXB9q5NWRpZe2bPBbli(workflowProcessListRunning);
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								}
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
				case 13:
					workflowProcessListRunningFilter3.IsParent = false;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
					{
						num2 = 9;
					}
					continue;
				case 11:
					_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_1();
					num2 = 4;
					continue;
				case 1:
				case 6:
					workflowProcessListRunningFilter.IsParent = true;
					num2 = 5;
					continue;
				case 4:
					workflowProcessListRunningFilter3 = InterfaceActivator.Create<IWorkflowProcessListRunningFilter>();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					HWkwiVNDqpwCBrMFloQ(workflowProcessListRunningFilter3, string.Format((string)QCjtvWNuRDUDunc59Y6(-1638225214 ^ -1638138872), string.Join((string)QCjtvWNuRDUDunc59Y6(-1386448964 ^ -1386463434), source.Select((ClassMetadata c) => (string)_003C_003Ec.imcDs5Ze8GRpFHsKd5jN(_003C_003Ec.u7kDqPZevqYTRW0aDAZN(--1436248540 ^ 0x5599BCBC), _003C_003Ec.PZuGTFZeYe2KZULYnjkD(c), _003C_003Ec.u7kDqPZevqYTRW0aDAZN(0x17F0C5A2 ^ 0x17F24EE4))))));
					num2 = 13;
					continue;
				case 17:
					HWkwiVNDqpwCBrMFloQ(workflowProcessListRunningFilter, YHBkpJNf6nWg87EvLIo(QCjtvWNuRDUDunc59Y6(-1303601216 ^ -1303525068), string.Join((string)QCjtvWNuRDUDunc59Y6(0x6A69C5CD ^ 0x6A698D47), collection.Select((IWorkflowProcessListRunning c) => (string)_003C_003Ec.imcDs5Ze8GRpFHsKd5jN(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-935313063 ^ -935160775), _003C_003Ec.YMautaZeskXKhpb6lHqu(c), _003C_003Ec.u7kDqPZevqYTRW0aDAZN(-1386448964 ^ -1386283782))))));
					num2 = 6;
					continue;
				case 5:
					workflowProcessListRunningFilter.TypeObject = (objectUser ? _003C_003Ec__DisplayClass10_2.metadata.ImplementationUid : vxYhhXNcyjcAXnLvYMU(_003C_003Ec__DisplayClass10_2.metadata));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
					{
						num2 = 0;
					}
					continue;
				case 19:
					enumerator = collection.Where(_003C_003Ec__DisplayClass10_._003CAddParentRoutes_003Eb__3).ToList().GetEnumerator();
					num2 = 16;
					continue;
				}
				break;
			}
		}
	}

	private void AddChildRoutes(IWorkflowProcessListRunning route, bool objectUser)
	{
		//Discarded unreachable code: IL_009f, IL_00ae, IL_00b9, IL_01ad, IL_01cc, IL_01db, IL_01f8, IL_0207, IL_0218
		int num = 1;
		IEnumerator<EntityMetadata> enumerator = default(IEnumerator<EntityMetadata>);
		EntityMetadata current = default(EntityMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 1:
					if (Q7KPUGNbCDhRAB9DwVu(Locator.GetServiceNotNull<IMetadataRuntimeService>(), AdGS6uNgFlh4CGrjjZU(route), true) == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					try
					{
						while (true)
						{
							int num3;
							if (!s7YWJHNHP3xYTxxcFQd(enumerator))
							{
								num3 = 3;
								goto IL_00bd;
							}
							goto IL_00ed;
							IL_00bd:
							while (true)
							{
								switch (num3)
								{
								case 2:
									break;
								default:
									goto IL_00ed;
								case 1:
								{
									IWorkflowProcessListRunning workflowProcessListRunning = workflowListProcessesRunningEntityManager.Create();
									workflowProcessListRunning.ProcessHeader = route.ProcessHeader;
									tw2tayN9gq7R9kyHoYW(workflowProcessListRunning, objectUser ? vxYhhXNcyjcAXnLvYMU(current) : nVQeyQNBGSgReQ6N8tq(current));
									workflowProcessListRunning.RootMetadata = AdGS6uNgFlh4CGrjjZU(route);
									workflowProcessListRunning.IsParent = true;
									workflowProcessListRunning.Save();
									num3 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								case 3:
									return;
								}
								break;
							}
							continue;
							IL_00ed:
							current = enumerator.Current;
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
							{
								num3 = 1;
							}
							goto IL_00bd;
						}
					}
					finally
					{
						int num4;
						if (enumerator == null)
						{
							num4 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
							{
								num4 = 0;
							}
							goto IL_01b1;
						}
						goto IL_01e6;
						IL_01e6:
						enumerator.Dispose();
						num4 = 2;
						goto IL_01b1;
						IL_01b1:
						switch (num4)
						{
						case 1:
							goto end_IL_018c;
						case 2:
							goto end_IL_018c;
						}
						goto IL_01e6;
						end_IL_018c:;
					}
				case 2:
					return;
				}
				break;
			}
			enumerator = MetadataLoader.GetChildClasses((EntityMetadata)aTYEp3Njw1xVhP916BE(route.TypeObject, true, true)).OfType<EntityMetadata>().GetEnumerator();
			num = 3;
		}
	}

	public WorkflowProcessListRunningDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool zjRkj9NmkMY6gPCcfky()
	{
		return oR5q01NyYuEBRCotylO == null;
	}

	internal static WorkflowProcessListRunningDTOManager TYOToUNtoGoApISn9gM()
	{
		return oR5q01NyYuEBRCotylO;
	}

	internal static Type Q7KPUGNbCDhRAB9DwVu(object P_0, Guid P_1, bool P_2)
	{
		return ((IMetadataRuntimeService)P_0).GetTypeByUidOrNull(P_1, P_2);
	}

	internal static bool xOkygaN5ilaLXx818yd(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid AdGS6uNgFlh4CGrjjZU(object P_0)
	{
		return ((IWorkflowProcessListRunning)P_0).TypeObject;
	}

	internal static Guid nVQeyQNBGSgReQ6N8tq(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static Guid vxYhhXNcyjcAXnLvYMU(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void DpVH1TNPNAKyGwUGj15(object P_0, bool P_1)
	{
		((IEntityFilter)P_0).DisableSecurity = P_1;
	}

	internal static void H4CwmANXOGpotXUbUhs(object P_0)
	{
		((IEntity)P_0).Delete();
	}

	internal static void YyG3SBNdWCFCZvGb4OV(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object QCjtvWNuRDUDunc59Y6(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void HWkwiVNDqpwCBrMFloQ(object P_0, object P_1)
	{
		((IEntityFilter)P_0).Query = (string)P_1;
	}

	internal static object aBjqJ5Nn4JMUEdfNkkT()
	{
		return FetchOptions.All;
	}

	internal static bool s7YWJHNHP3xYTxxcFQd(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static int h9Es6RNLPOMTh7FVwgX(object P_0)
	{
		return ((ICollection<IWorkflowProcessListRunning>)P_0).Count;
	}

	internal static object YHBkpJNf6nWg87EvLIo(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void tw2tayN9gq7R9kyHoYW(object P_0, Guid value)
	{
		((IWorkflowProcessListRunning)P_0).TypeObject = value;
	}

	internal static void QXB9q5NWRpZe2bPBbli(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object aTYEp3Njw1xVhP916BE(Guid P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}
}
