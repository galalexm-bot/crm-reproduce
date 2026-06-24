using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.DTO.Models;
using EleWise.ELMA.Workflow.BPMN.Models;
using EleWise.ELMA.Workflow.BPMN.Validation;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.ExtensionPoints;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Scheduling;
using EleWise.ELMA.Workflow.Validation;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class BPMNProcessManager : BPMNProcessManager<IBPMNProcess>
{
	internal static BPMNProcessManager z4Yn9NOGNaStaeZJNZER;

	public BPMNProcessManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool EoQB32OGxVMQUVq8GILa()
	{
		return z4Yn9NOGNaStaeZJNZER == null;
	}

	internal static BPMNProcessManager EIw2bgOGSXUru1Zg92iZ()
	{
		return z4Yn9NOGNaStaeZJNZER;
	}
}
public abstract class BPMNProcessManager<TProcess> : WorkflowProcessManager<TProcess> where TProcess : class, IBPMNProcess
{
	internal static object bGC0a1OG1UjqyTbsiiJr;

	[PublicApiMember]
	public override void Save(TProcess obj)
	{
		Contract.ArgumentNotNull(obj, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37E927F1));
		Contract.CheckArgument(obj != null, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5BCD23A0 ^ 0x5BCF4496));
		base.Save(obj);
	}

	[Transaction]
	public override void Publish(TProcess process, long versionNumber, IWorkflowProcess parentProcess, string comment, bool isEmulation)
	{
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		if (process.ResponsibilityMatrix != null)
		{
			foreach (IResponsibilityMatrixItem item in (IEnumerable<IResponsibilityMatrixItem>)process.ResponsibilityMatrix)
			{
				item.BPMNProcess = process;
			}
		}
		_003C_003Ec__DisplayClass1_.startEvent = process.Diagram.GetStartElement() as StartEventElement;
		if (_003C_003Ec__DisplayClass1_.startEvent != null)
		{
			_003C_003Ec__DisplayClass1_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass1_;
			CS_0024_003C_003E8__locals0.header = process.Header;
			CS_0024_003C_003E8__locals0.settings = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.startEvent.EventSettings;
			ComponentManager.Current.GetExtensionPoints<IEventTrigger>().ForEach(delegate(IEventTrigger e)
			{
				int num = 1;
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
						e.OnProcessPublish(CS_0024_003C_003E8__locals0.header, CS_0024_003C_003E8__locals0.settings, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.startEvent.Trigger);
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			});
		}
		if (_003C_003Ec__DisplayClass1_.startEvent != null && _003C_003Ec__DisplayClass1_.startEvent.Trigger == EventTrigger.Timer && _003C_003Ec__DisplayClass1_.startEvent.TimerSettings != null && _003C_003Ec__DisplayClass1_.startEvent.TimerSettings.SchedulerTask != null)
		{
			ISchedulerTask schedulerTask = process.Header.StartProcessSchedulerTask;
			if (schedulerTask == null)
			{
				schedulerTask = InterfaceActivator.Create<ISchedulerTask>();
				process.Header.StartProcessSchedulerTask = schedulerTask;
			}
			schedulerTask.Name = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351477282), process.Header.Name);
			schedulerTask.Type = SchedulerTaskType.Periodic;
			schedulerTask.Settings = _003C_003Ec__DisplayClass1_.startEvent.TimerSettings.SchedulerTask.Settings;
			schedulerTask.Status = _003C_003Ec__DisplayClass1_.startEvent.TimerSettings.SchedulerTask.Status;
			schedulerTask.OwnerUid = WorkflowSchedulerTaskOwner.UID;
			IStartProcessSchedulerJob startProcessSchedulerJob = ((IEnumerable<ISchedulerTaskJob>)schedulerTask.Jobs).FirstOrDefault() as IStartProcessSchedulerJob;
			if (startProcessSchedulerJob == null)
			{
				((ICollection<ISchedulerTaskJob>)schedulerTask.Jobs).Clear();
				startProcessSchedulerJob = InterfaceActivator.Create<IStartProcessSchedulerJob>();
				schedulerTask.Jobs.Add((ISchedulerTaskJob)startProcessSchedulerJob);
			}
			startProcessSchedulerJob.Name = schedulerTask.Name;
			startProcessSchedulerJob.Task = schedulerTask;
			startProcessSchedulerJob.ProcessHeader = process.Header;
		}
		else if (process.Header.StartProcessSchedulerTask != null)
		{
			if (((IEnumerable<ISchedulerTaskJob>)process.Header.StartProcessSchedulerTask.Jobs).FirstOrDefault() is IStartProcessSchedulerJob startProcessSchedulerJob2)
			{
				base.Session.CreateQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-539998957 ^ -539876707) + InterfaceActivator.TypeOf<ISchedulerJobRunInfo>().Name + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077892328)).SetParameter<IStartProcessSchedulerJob>(0, startProcessSchedulerJob2).ExecuteUpdate(cleanUpCache: false);
				base.Session.CleanUpCache(typeof(ISchedulerJobRunInfo));
			}
			process.Header.StartProcessSchedulerTask.Delete();
			process.Header.StartProcessSchedulerTask = null;
		}
		base.Publish(process, versionNumber, parentProcess, comment, isEmulation);
	}

	public override ExportRuleList ExportRules()
	{
		int num = 1;
		int num2 = num;
		Type parentType = default(Type);
		while (true)
		{
			switch (num2)
			{
			default:
				return new ExportRuleList
				{
					new ExportRule
					{
						ParentType = parentType,
						PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-22348816 ^ -22307160),
						ExportRuleType = ExportRuleType.Export
					}
				};
			case 1:
				parentType = InterfaceActivator.TypeOf<IBPMNProcess>();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override ChangeProcessVersionValidationResult ValidateChangeVersion(IWorkflowProcess oldProcess, IWorkflowProcess newProcess, Guid[] initialActiveElementUids)
	{
		//Discarded unreachable code: IL_01f2, IL_0397, IL_03aa, IL_057d, IL_06e4, IL_071c, IL_084f, IL_085e, IL_0869, IL_08ce, IL_08dd, IL_08e8, IL_0957, IL_0977, IL_0a4e, IL_0a61, IL_0a70, IL_0b18, IL_0b2c, IL_0b3b, IL_0b46, IL_0c20, IL_0c50, IL_0c5f, IL_0c6b, IL_0dba, IL_0dcd, IL_0ded, IL_0dfc, IL_0e0c, IL_0e9f, IL_0eae, IL_0eb9, IL_0fea, IL_0ff9, IL_1079, IL_1098, IL_10a7, IL_10d4, IL_1107, IL_1111, IL_11a4, IL_120c, IL_1308, IL_131b, IL_14cb, IL_14da, IL_156b, IL_157a, IL_1765, IL_1891, IL_18c9
		int num = 41;
		Type instanceContextType = default(Type);
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		ChangeProcessVersionValidationResult changeProcessVersionValidationResult = default(ChangeProcessVersionValidationResult);
		List<Guid>.Enumerator enumerator3 = default(List<Guid>.Enumerator);
		IEnumerator<Guid> enumerator = default(IEnumerator<Guid>);
		IEnumerable<Guid> enumerable2 = default(IEnumerable<Guid>);
		IEnumerable<Guid> enumerable3 = default(IEnumerable<Guid>);
		BPMNProcessDTO bPMNProcessDTO = default(BPMNProcessDTO);
		BPMNProcessValidator bPMNProcessValidator2 = default(BPMNProcessValidator);
		_003C_003Ec__DisplayClass3_3 _003C_003Ec__DisplayClass3_3 = default(_003C_003Ec__DisplayClass3_3);
		string name2 = default(string);
		BPMNProcessValidator bPMNProcessValidator = default(BPMNProcessValidator);
		BPMNProcessDTO bPMNProcessDTO2 = default(BPMNProcessDTO);
		Type instanceContextType2 = default(Type);
		Dictionary<Guid, List<Element>>.Enumerator enumerator2 = default(Dictionary<Guid, List<Element>>.Enumerator);
		Dictionary<Guid, List<Element>> dictionary = default(Dictionary<Guid, List<Element>>);
		_003C_003Ec__DisplayClass3_2 _003C_003Ec__DisplayClass3_2 = default(_003C_003Ec__DisplayClass3_2);
		string name = default(string);
		IEnumerable<SwimlaneChangeInfo> source2 = default(IEnumerable<SwimlaneChangeInfo>);
		List<Element>.Enumerator enumerator5 = default(List<Element>.Enumerator);
		_003C_003Ec__DisplayClass3_9 _003C_003Ec__DisplayClass3_7 = default(_003C_003Ec__DisplayClass3_9);
		_003C_003Ec__DisplayClass3_10 _003C_003Ec__DisplayClass3_8 = default(_003C_003Ec__DisplayClass3_10);
		Dictionary<Element, BPMNProcessValidator.ExecutionGate> dictionary2 = default(Dictionary<Element, BPMNProcessValidator.ExecutionGate>);
		Element key = default(Element);
		BPMNProcessValidator.ExecutionGate value6 = default(BPMNProcessValidator.ExecutionGate);
		IEnumerator<Element> enumerator4 = default(IEnumerator<Element>);
		Element current = default(Element);
		IEnumerable<Guid> enumerable = default(IEnumerable<Guid>);
		_003C_003Ec__DisplayClass3_7 _003C_003Ec__DisplayClass3_6 = default(_003C_003Ec__DisplayClass3_7);
		Element element2 = default(Element);
		_003C_003Ec__DisplayClass3_8 _003C_003Ec__DisplayClass3_5 = default(_003C_003Ec__DisplayClass3_8);
		List<Element> value5 = default(List<Element>);
		Element element = default(Element);
		BPMNProcessValidator.ExecutionGate value4 = default(BPMNProcessValidator.ExecutionGate);
		IEnumerable<Guid> enumerable4 = default(IEnumerable<Guid>);
		_003C_003Ec__DisplayClass3_1 _003C_003Ec__DisplayClass3_4 = default(_003C_003Ec__DisplayClass3_1);
		int value3 = default(int);
		int? precision = default(int?);
		DoubleSettings doubleSettings2 = default(DoubleSettings);
		DoubleSettings doubleSettings = default(DoubleSettings);
		string displayName = default(string);
		int value2 = default(int);
		TypeSettings settings2 = default(TypeSettings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 29:
					instanceContextType = Locator.GetServiceNotNull<WorkflowInstanceContextService>().GetInstanceContextType(_003C_003Ec__DisplayClass3_.newProcess);
					num2 = 14;
					continue;
				case 6:
				case 9:
					return changeProcessVersionValidationResult;
				case 24:
				case 55:
					enumerator3 = _003C_003Ec__DisplayClass3_.activeElementUids.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
					{
						num2 = 0;
					}
					continue;
				case 47:
					enumerator = enumerable2.Intersect(enumerable3).GetEnumerator();
					num2 = 15;
					continue;
				case 8:
					bPMNProcessDTO = Mapper.Map<IBPMNProcess, BPMNProcessDTO>((IBPMNProcess)_003C_003Ec__DisplayClass3_.newProcess, new BPMNProcessDTO());
					num2 = 51;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
					{
						num2 = 9;
					}
					continue;
				case 3:
					bPMNProcessValidator2.Validate();
					num = 39;
					break;
				case 14:
					_003C_003Ec__DisplayClass3_.newContextMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(instanceContextType);
					num2 = 5;
					continue;
				default:
					try
					{
						while (true)
						{
							int num7;
							if (!enumerator3.MoveNext())
							{
								int num6 = 5;
								num7 = num6;
								goto IL_0200;
							}
							goto IL_0240;
							IL_0200:
							while (true)
							{
								switch (num7)
								{
								case 2:
									goto IL_0240;
								case 1:
									_003C_003Ec__DisplayClass3_3.uid = enumerator3.Current;
									num7 = 6;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
									{
										num7 = 6;
									}
									continue;
								case 6:
									if (IsActiveElementIsolated(_003C_003Ec__DisplayClass3_.newProcess.Diagram, _003C_003Ec__DisplayClass3_3.uid))
									{
										num7 = 3;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
										{
											num7 = 3;
										}
										continue;
									}
									break;
								case 3:
									name2 = _003C_003Ec__DisplayClass3_.newProcess.Diagram.Elements.FirstOrDefault(_003C_003Ec__DisplayClass3_3._003CValidateChangeVersion_003Eb__23).Name;
									num7 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
									{
										num7 = 4;
									}
									continue;
								case 4:
									changeProcessVersionValidationResult.Messages.Add(new ProcessValidationMessage
									{
										Type = ProcessValidationMessageType.Error,
										Object = null,
										Message = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1386448964 ^ -1386341014), name2)
									});
									num7 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
									{
										num7 = 0;
									}
									continue;
								case 5:
									goto end_IL_0226;
								}
								break;
							}
							continue;
							IL_0240:
							_003C_003Ec__DisplayClass3_3 = new _003C_003Ec__DisplayClass3_3();
							num7 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
							{
								num7 = 1;
							}
							goto IL_0200;
							continue;
							end_IL_0226:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
						int num8 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					goto case 27;
				case 53:
					enumerator3 = _003C_003Ec__DisplayClass3_.activeElementUids.GetEnumerator();
					num2 = 33;
					continue;
				case 51:
					bPMNProcessValidator = new BPMNProcessValidator(bPMNProcessDTO2);
					num2 = 54;
					continue;
				case 17:
					_003C_003Ec__DisplayClass3_.removedPropertiesUids = enumerable3.Except(enumerable2);
					num = 12;
					break;
				case 54:
					bPMNProcessValidator2 = new BPMNProcessValidator(bPMNProcessDTO);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
					{
						num2 = 10;
					}
					continue;
				case 44:
					Contract.ArgumentNotNull(_003C_003Ec__DisplayClass3_.newProcess, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1EA50FCC ^ 0x1EA5F312));
					num2 = 19;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
					{
						num2 = 3;
					}
					continue;
				case 36:
					_003C_003Ec__DisplayClass3_.oldContextMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(instanceContextType2);
					num2 = 19;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
					{
						num2 = 29;
					}
					continue;
				case 41:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 40;
					continue;
				case 46:
					changeProcessVersionValidationResult.Messages.Add(new ProcessValidationMessage
					{
						Type = ProcessValidationMessageType.Warning,
						Object = null,
						Message = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C1FFB55 ^ 0x3C1D920B))
					});
					num2 = 11;
					continue;
				case 16:
					Contract.ArgumentNotNull(_003C_003Ec__DisplayClass3_.oldProcess, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1514166050 ^ -1514287352));
					num2 = 44;
					continue;
				case 32:
					if (_003C_003Ec__DisplayClass3_.addedPropertiesUids.Count() > 0)
					{
						num2 = 23;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 49;
				case 35:
					if (initialActiveElementUids == null)
					{
						num2 = 9;
						continue;
					}
					goto case 4;
				case 31:
					_003C_003Ec__DisplayClass3_.oldProcess = oldProcess;
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
					{
						num2 = 16;
					}
					continue;
				case 48:
					enumerator2 = dictionary.GetEnumerator();
					num2 = 38;
					continue;
				case 37:
					try
					{
						while (true)
						{
							IL_0683:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 4;
								goto IL_0587;
							}
							goto IL_069d;
							IL_058b:
							int num4;
							while (true)
							{
								switch (num4)
								{
								case 2:
									break;
								default:
									_003C_003Ec__DisplayClass3_2.elementUid = enumerator.Current;
									num4 = 2;
									continue;
								case 3:
									changeProcessVersionValidationResult.Messages.Add(new ProcessValidationMessage
									{
										Type = ProcessValidationMessageType.Error,
										Object = _003C_003Ec__DisplayClass3_2.elementUid,
										Message = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108877388 ^ -1109019254), name, _003C_003Ec__DisplayClass3_2.elementUid)
									});
									num4 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
									{
										num4 = 1;
									}
									continue;
								case 1:
									goto IL_0683;
								case 5:
									goto IL_069d;
								case 4:
									goto end_IL_0683;
								}
								break;
							}
							name = _003C_003Ec__DisplayClass3_.oldProcess.Diagram.Elements.First(_003C_003Ec__DisplayClass3_2._003CValidateChangeVersion_003Eb__22).Name;
							num3 = 3;
							goto IL_0587;
							IL_069d:
							_003C_003Ec__DisplayClass3_2 = new _003C_003Ec__DisplayClass3_2();
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
							{
								num4 = 0;
							}
							goto IL_058b;
							IL_0587:
							num4 = num3;
							goto IL_058b;
							continue;
							end_IL_0683:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								case 1:
									enumerator.Dispose();
									num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
									{
										num5 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto case 13;
				case 22:
					_003C_003Ec__DisplayClass3_.newVersionSwimlanes = _003C_003Ec__DisplayClass3_.newProcess.Diagram.Elements.OfType<SwimlaneElement>();
					num2 = 25;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
					{
						num2 = 24;
					}
					continue;
				case 34:
					changeProcessVersionValidationResult.ChangedSwimlanes = source2.ToList();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
					{
						num2 = 1;
					}
					continue;
				case 28:
					return changeProcessVersionValidationResult;
				case 12:
					_003C_003Ec__DisplayClass3_.addedPropertiesUids = enumerable2.Except(enumerable3);
					num2 = 47;
					continue;
				case 40:
					_003C_003Ec__DisplayClass3_.newProcess = newProcess;
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
					{
						num2 = 3;
					}
					continue;
				case 50:
					if (_003C_003Ec__DisplayClass3_.removedPropertiesUids.Count() > 0)
					{
						num2 = 25;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
						{
							num2 = 46;
						}
						continue;
					}
					goto case 11;
				case 4:
					if (initialActiveElementUids.Length != 0)
					{
						_003C_003Ec__DisplayClass3_.activeElementUids = new List<Guid>(initialActiveElementUids);
						num2 = 52;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
						{
							num2 = 41;
						}
					}
					else
					{
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
						{
							num2 = 1;
						}
					}
					continue;
				case 19:
					Contract.CheckArgument(_003C_003Ec__DisplayClass3_.oldProcess is IBPMNProcess, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25832444));
					num = 20;
					break;
				case 38:
					try
					{
						while (true)
						{
							IL_0afd:
							int num16;
							if (!enumerator2.MoveNext())
							{
								num16 = 4;
								goto IL_086d;
							}
							goto IL_0ac4;
							IL_086d:
							while (true)
							{
								switch (num16)
								{
								case 4:
									return changeProcessVersionValidationResult;
								case 10:
									enumerator5 = _003C_003Ec__DisplayClass3_7.pair.Value.GetEnumerator();
									num16 = 6;
									continue;
								case 6:
									try
									{
										while (true)
										{
											IL_0985:
											int num17;
											if (!enumerator5.MoveNext())
											{
												num17 = 4;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
												{
													num17 = 0;
												}
												goto IL_08ec;
											}
											goto IL_0961;
											IL_0961:
											_003C_003Ec__DisplayClass3_8 = new _003C_003Ec__DisplayClass3_10();
											num17 = 9;
											goto IL_08ec;
											IL_08ec:
											while (true)
											{
												switch (num17)
												{
												case 2:
												case 5:
													dictionary2[key] = value6;
													num17 = 8;
													continue;
												case 6:
													if (bPMNProcessValidator2.ActivityGates.TryGetValue(key, out value6))
													{
														num17 = 2;
														continue;
													}
													goto case 3;
												case 1:
													break;
												default:
													goto IL_0985;
												case 9:
													_003C_003Ec__DisplayClass3_8.oldElement = enumerator5.Current;
													num17 = 7;
													continue;
												case 7:
													key = bPMNProcessDTO.Diagram.Elements.First(_003C_003Ec__DisplayClass3_8._003CValidateChangeVersion_003Eb__36);
													num17 = 6;
													continue;
												case 3:
													base.Logger.Error(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C64517B));
													num17 = 0;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
													{
														num17 = 0;
													}
													continue;
												case 4:
													goto end_IL_0985;
												}
												break;
											}
											goto IL_0961;
											continue;
											end_IL_0985:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator5).Dispose();
										int num18 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
										{
											num18 = 0;
										}
										switch (num18)
										{
										case 0:
											break;
										}
									}
									goto case 1;
								case 1:
									if (!dictionary2.Values.Any(_003C_003Ec__DisplayClass3_7._003CValidateChangeVersion_003Eb__33))
									{
										num16 = 2;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
										{
											num16 = 5;
										}
										continue;
									}
									goto case 9;
								case 3:
									dictionary2 = new Dictionary<Element, BPMNProcessValidator.ExecutionGate>();
									num16 = 10;
									continue;
								case 8:
									break;
								case 7:
									_003C_003Ec__DisplayClass3_7.pair = enumerator2.Current;
									num16 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
									{
										num16 = 3;
									}
									continue;
								default:
									goto IL_0afd;
								case 11:
									try
									{
										while (true)
										{
											int num19;
											if (!enumerator4.MoveNext())
											{
												num19 = 3;
												goto IL_0b4a;
											}
											goto IL_0bd7;
											IL_0b4a:
											while (true)
											{
												switch (num19)
												{
												case 2:
													break;
												default:
													changeProcessVersionValidationResult.Messages.Add(new ProcessValidationMessage
													{
														Type = ProcessValidationMessageType.Error,
														Object = current,
														Message = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-261315199 ^ -261175071), current.Name)
													});
													num19 = 2;
													continue;
												case 1:
													goto IL_0bd7;
												case 3:
													goto end_IL_0b64;
												}
												break;
											}
											continue;
											IL_0bd7:
											current = enumerator4.Current;
											num19 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
											{
												num19 = 0;
											}
											goto IL_0b4a;
											continue;
											end_IL_0b64:
											break;
										}
									}
									finally
									{
										int num20;
										if (enumerator4 == null)
										{
											num20 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
											{
												num20 = 0;
											}
											goto IL_0c24;
										}
										goto IL_0c3a;
										IL_0c3a:
										enumerator4.Dispose();
										num20 = 2;
										goto IL_0c24;
										IL_0c24:
										switch (num20)
										{
										default:
											goto end_IL_0bff;
										case 1:
											break;
										case 0:
											goto end_IL_0bff;
										case 2:
											goto end_IL_0bff;
										}
										goto IL_0c3a;
										end_IL_0bff:;
									}
									goto IL_0afd;
								case 12:
									changeProcessVersionValidationResult.Messages.Add(new ProcessValidationMessage
									{
										Type = ProcessValidationMessageType.Error,
										Object = null,
										Message = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-865213812 ^ -865104018))
									});
									num16 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
									{
										num16 = 0;
									}
									continue;
								case 9:
									enumerator4 = (from e in dictionary2.ToList().Where(_003C_003Ec__DisplayClass3_7._003CValidateChangeVersion_003Eb__37)
										select e.Key).GetEnumerator();
									num16 = 11;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
									{
										num16 = 9;
									}
									continue;
								case 2:
								case 5:
									if ((from v in dictionary2.Values
										group v by v.GateNum).Any((IGrouping<int, BPMNProcessValidator.ExecutionGate> group) => group.Count() > 1))
									{
										num16 = 12;
										continue;
									}
									goto IL_0afd;
								}
								break;
							}
							goto IL_0ac4;
							IL_0ac4:
							_003C_003Ec__DisplayClass3_7 = new _003C_003Ec__DisplayClass3_9();
							num16 = 7;
							goto IL_086d;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num21 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
						{
							num21 = 0;
						}
						switch (num21)
						{
						case 0:
							break;
						}
					}
				case 30:
					changeProcessVersionValidationResult = new ChangeProcessVersionValidationResult();
					num2 = 35;
					continue;
				case 13:
					_003C_003Ec__DisplayClass3_.activeElementUids = _003C_003Ec__DisplayClass3_.activeElementUids.Except(enumerable).ToList();
					num2 = 24;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
					{
						num2 = 21;
					}
					continue;
				case 20:
					Contract.CheckArgument(_003C_003Ec__DisplayClass3_.newProcess is IBPMNProcess, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x213F6477 ^ 0x213D0C51));
					num = 30;
					break;
				case 52:
					instanceContextType2 = Locator.GetServiceNotNull<WorkflowInstanceContextService>().GetInstanceContextType(_003C_003Ec__DisplayClass3_.oldProcess);
					num2 = 36;
					continue;
				case 18:
					try
					{
						while (true)
						{
							IL_104d:
							int num14;
							if (!enumerator.MoveNext())
							{
								num14 = 6;
								goto IL_0ebd;
							}
							goto IL_1004;
							IL_0ebd:
							while (true)
							{
								switch (num14)
								{
								case 2:
								{
									Element element3 = bPMNProcessDTO2.Diagram.Elements.First(_003C_003Ec__DisplayClass3_6._003CValidateChangeVersion_003Eb__30);
									element2 = bPMNProcessDTO.Diagram.Elements.First(_003C_003Ec__DisplayClass3_6._003CValidateChangeVersion_003Eb__31);
									if (element3.OutputConnectors.Count >= element2.OutputConnectors.Count)
									{
										num14 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
										{
											num14 = 7;
										}
										continue;
									}
									goto case 3;
								}
								default:
									if (_003C_003Ec__DisplayClass3_6.gwUid != Guid.Empty)
									{
										num14 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
										{
											num14 = 2;
										}
										continue;
									}
									goto IL_104d;
								case 3:
									changeProcessVersionValidationResult.Messages.Add(new ProcessValidationMessage
									{
										Type = ProcessValidationMessageType.Error,
										Object = null,
										Message = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x595C500A ^ 0x595E3B72), element2.Name)
									});
									num14 = 5;
									continue;
								case 1:
									break;
								case 4:
									_003C_003Ec__DisplayClass3_6.gwUid = enumerator.Current;
									num14 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
									{
										num14 = 0;
									}
									continue;
								case 5:
								case 7:
									goto IL_104d;
								case 6:
									goto end_IL_104d;
								}
								break;
							}
							goto IL_1004;
							IL_1004:
							_003C_003Ec__DisplayClass3_6 = new _003C_003Ec__DisplayClass3_7();
							num14 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
							{
								num14 = 4;
							}
							goto IL_0ebd;
							continue;
							end_IL_104d:
							break;
						}
					}
					finally
					{
						int num15;
						if (enumerator == null)
						{
							num15 = 2;
							goto IL_107d;
						}
						goto IL_10b2;
						IL_107d:
						switch (num15)
						{
						default:
							goto end_IL_1068;
						case 2:
							goto end_IL_1068;
						case 1:
							break;
						case 0:
							goto end_IL_1068;
						}
						goto IL_10b2;
						IL_10b2:
						enumerator.Dispose();
						num15 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
						{
							num15 = 0;
						}
						goto IL_107d;
						end_IL_1068:;
					}
					goto case 26;
				case 26:
					dictionary = new Dictionary<Guid, List<Element>>();
					num2 = 53;
					continue;
				case 7:
					_003C_003Ec__DisplayClass3_._003C_003E4__this = this;
					num2 = 31;
					continue;
				case 33:
					try
					{
						while (true)
						{
							IL_1256:
							int num12;
							if (!enumerator3.MoveNext())
							{
								num12 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
								{
									num12 = 0;
								}
								goto IL_1115;
							}
							goto IL_1235;
							IL_1235:
							_003C_003Ec__DisplayClass3_5 = new _003C_003Ec__DisplayClass3_8();
							num12 = 9;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
							{
								num12 = 8;
							}
							goto IL_1115;
							IL_1115:
							while (true)
							{
								switch (num12)
								{
								case 10:
									value5.Add(element);
									num12 = 5;
									continue;
								case 9:
									_003C_003Ec__DisplayClass3_5.uid = enumerator3.Current;
									num12 = 8;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
									{
										num12 = 2;
									}
									continue;
								case 4:
									value5 = new List<Element>();
									num12 = 6;
									continue;
								case 7:
									if (bPMNProcessValidator.ActivityGates.TryGetValue(element, out value4))
									{
										num12 = 3;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
										{
											num12 = 1;
										}
										continue;
									}
									goto case 2;
								case 8:
									element = bPMNProcessDTO2.Diagram.Elements.First(_003C_003Ec__DisplayClass3_5._003CValidateChangeVersion_003Eb__32);
									num12 = 7;
									continue;
								case 3:
								case 11:
									if (!dictionary.TryGetValue(value4.GatewayId, out value5))
									{
										num12 = 4;
										continue;
									}
									goto case 10;
								case 12:
									goto IL_1235;
								case 1:
								case 5:
									goto IL_1256;
								case 6:
									dictionary[value4.GatewayId] = value5;
									num12 = 10;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
									{
										num12 = 1;
									}
									continue;
								case 2:
									base.Logger.Error(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1212129906 ^ 0x483DCE26));
									num12 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
									{
										num12 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
						int num13 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
						{
							num13 = 0;
						}
						switch (num13)
						{
						case 0:
							break;
						}
					}
					goto case 48;
				case 27:
					_003C_003Ec__DisplayClass3_.oldVersionSwimlanes = _003C_003Ec__DisplayClass3_.oldProcess.Diagram.Elements.OfType<SwimlaneElement>();
					num2 = 20;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
					{
						num2 = 22;
					}
					continue;
				case 45:
					if (_003C_003Ec__DisplayClass3_.activeElementUids.IsSubsetOf(enumerable4))
					{
						num2 = 55;
						continue;
					}
					goto case 42;
				case 2:
					changeProcessVersionValidationResult.RemovedProperties = _003C_003Ec__DisplayClass3_.oldContextMetadata.Properties.Where(_003C_003Ec__DisplayClass3_._003CValidateChangeVersion_003Eb__2);
					num2 = 50;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
					{
						num2 = 13;
					}
					continue;
				case 1:
					bPMNProcessDTO2 = Mapper.Map<IBPMNProcess, BPMNProcessDTO>((IBPMNProcess)_003C_003Ec__DisplayClass3_.oldProcess, new BPMNProcessDTO());
					num2 = 8;
					continue;
				case 43:
					enumerator = enumerable.GetEnumerator();
					num = 37;
					break;
				case 11:
					changeProcessVersionValidationResult.AddedProperties = _003C_003Ec__DisplayClass3_.newContextMetadata.Properties.Where(_003C_003Ec__DisplayClass3_._003CValidateChangeVersion_003Eb__3);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
					{
						num2 = 32;
					}
					continue;
				case 42:
					enumerable = _003C_003Ec__DisplayClass3_.activeElementUids.Except(enumerable4);
					num2 = 43;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					bPMNProcessValidator.Validate();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
					{
						num2 = 3;
					}
					continue;
				case 23:
					changeProcessVersionValidationResult.Messages.Add(new ProcessValidationMessage
					{
						Type = ProcessValidationMessageType.Info,
						Object = null,
						Message = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A69C5CD ^ 0x6A6BAC0B))
					});
					num2 = 49;
					continue;
				case 15:
					try
					{
						while (true)
						{
							IL_173a:
							int num9;
							if (!enumerator.MoveNext())
							{
								num9 = 19;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
								{
									num9 = 6;
								}
								goto IL_14e9;
							}
							goto IL_1664;
							IL_1664:
							_003C_003Ec__DisplayClass3_4 = new _003C_003Ec__DisplayClass3_1();
							num9 = 13;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
							{
								num9 = 11;
							}
							goto IL_14e9;
							IL_14e9:
							while (true)
							{
								int num10;
								switch (num9)
								{
								case 21:
									value3 = precision.Value;
									num10 = 14;
									goto IL_14e5;
								case 10:
									precision = doubleSettings2.Precision;
									num9 = 22;
									continue;
								case 20:
									precision = doubleSettings.Precision;
									num10 = 15;
									goto IL_14e5;
								case 18:
									precision = doubleSettings2.Precision;
									num9 = 6;
									continue;
								case 14:
									changeProcessVersionValidationResult.Messages.Add(new ProcessValidationMessage
									{
										Type = ProcessValidationMessageType.Warning,
										Object = null,
										Message = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46CCB8F), displayName, value2, value3)
									});
									num9 = 12;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
									{
										num9 = 5;
									}
									continue;
								case 22:
									value2 = precision.Value;
									num9 = 7;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
									{
										num9 = 7;
									}
									continue;
								case 11:
									break;
								case 6:
									if (!precision.HasValue)
									{
										num9 = 9;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
										{
											num9 = 3;
										}
										continue;
									}
									goto case 8;
								case 3:
									settings2 = _003C_003Ec__DisplayClass3_.oldContextMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass3_4._003CValidateChangeVersion_003Eb__19).Settings;
									num9 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
									{
										num9 = 1;
									}
									continue;
								case 5:
									if (doubleSettings != null)
									{
										num9 = 16;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
										{
											num9 = 18;
										}
										continue;
									}
									goto IL_173a;
								case 16:
									displayName = _003C_003Ec__DisplayClass3_.newContextMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass3_4._003CValidateChangeVersion_003Eb__21).DisplayName;
									num9 = 10;
									continue;
								case 2:
								case 4:
								case 9:
								case 12:
									goto IL_173a;
								default:
									if (!precision.HasValue)
									{
										num9 = 4;
										continue;
									}
									goto case 20;
								case 1:
								{
									TypeSettings settings = _003C_003Ec__DisplayClass3_.newContextMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass3_4._003CValidateChangeVersion_003Eb__20).Settings;
									doubleSettings2 = settings2 as DoubleSettings;
									doubleSettings = settings as DoubleSettings;
									num9 = 17;
									continue;
								}
								case 17:
									if (doubleSettings2 == null)
									{
										num9 = 2;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
										{
											num9 = 2;
										}
										continue;
									}
									goto case 5;
								case 8:
									precision = doubleSettings.Precision;
									num9 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
									{
										num9 = 0;
									}
									continue;
								case 13:
									_003C_003Ec__DisplayClass3_4.uid = enumerator.Current;
									num9 = 3;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
									{
										num9 = 0;
									}
									continue;
								case 15:
								{
									int value = precision.Value;
									precision = doubleSettings2.Precision;
									if (value < precision.Value)
									{
										num9 = 16;
										continue;
									}
									goto IL_173a;
								}
								case 7:
									precision = doubleSettings.Precision;
									num9 = 21;
									continue;
								case 19:
									goto end_IL_173a;
									IL_14e5:
									num9 = num10;
									continue;
								}
								break;
							}
							goto IL_1664;
							continue;
							end_IL_173a:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num11 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 != 0)
							{
								num11 = 0;
							}
							while (true)
							{
								switch (num11)
								{
								default:
									enumerator.Dispose();
									num11 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
									{
										num11 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 2;
				case 5:
					enumerable3 = _003C_003Ec__DisplayClass3_.oldContextMetadata.Properties.Select((PropertyMetadata p) => p.Uid);
					num2 = 21;
					continue;
				case 21:
					enumerable2 = _003C_003Ec__DisplayClass3_.newContextMetadata.Properties.Select((PropertyMetadata p) => p.Uid);
					num2 = 17;
					continue;
				case 49:
					enumerable4 = _003C_003Ec__DisplayClass3_.newProcess.Diagram.Elements.Select((Element e) => e.Uid);
					num2 = 45;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
					{
						num2 = 40;
					}
					continue;
				case 25:
				{
					HashSet<Guid> source = new HashSet<Guid>(_003C_003Ec__DisplayClass3_.oldVersionSwimlanes.Select((SwimlaneElement sw) => sw.Uid).Concat(_003C_003Ec__DisplayClass3_.newVersionSwimlanes.Select((SwimlaneElement sw) => sw.Uid)));
					_003C_003Ec__DisplayClass3_.activeElementSwimlaneMap = (from item in _003C_003Ec__DisplayClass3_.activeElementUids.Select(_003C_003Ec__DisplayClass3_._003CValidateChangeVersion_003Eb__7).OfType<BPMNFlowElement>().Select(_003C_003Ec__DisplayClass3_._003CValidateChangeVersion_003Eb__8)
						group item by item.Swimlane.Uid).ToDictionary(group => group.Key, group => group.Select(i => i.ActiveElement.Uid).ToArray());
					source2 = source.Select(_003C_003Ec__DisplayClass3_._003CValidateChangeVersion_003Eb__12).Select(_003C_003Ec__DisplayClass3_._003CValidateChangeVersion_003Eb__13).Where(_003C_003Ec__DisplayClass3_._003CValidateChangeVersion_003Eb__14);
					num2 = 34;
					continue;
				}
				case 39:
				{
					Guid[] first = (from pair in bPMNProcessValidator.ActivityGates.Where(_003C_003Ec__DisplayClass3_._003CValidateChangeVersion_003Eb__15)
						select pair.Value.GatewayId).Distinct().ToArray();
					Guid[] second = (from pair in bPMNProcessValidator2.ActivityGates.Where(_003C_003Ec__DisplayClass3_._003CValidateChangeVersion_003Eb__17)
						select pair.Value.GatewayId).Distinct().ToArray();
					enumerator = first.Intersect(second).GetEnumerator();
					num2 = 18;
					continue;
				}
				}
				break;
			}
		}
	}

	private bool IsActiveElementIsolated(WorkflowDiagram newDiagram, Guid activeElementUid)
	{
		//Discarded unreachable code: IL_016e, IL_017d
		int num = 1;
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_2 = default(_003C_003Ec__DisplayClass4_0);
		List<Guid> list = default(List<Guid>);
		_003C_003Ec__DisplayClass4_1 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_1);
		Queue<Guid> queue = default(Queue<Guid>);
		IEnumerable<Guid> second = default(IEnumerable<Guid>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					if (newDiagram.Elements.FirstOrDefault(_003C_003Ec__DisplayClass4_2._003CIsActiveElementIsolated_003Eb__0) == null)
					{
						num2 = 13;
						continue;
					}
					list = new List<Guid>();
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
					{
						num2 = 11;
					}
					continue;
				case 10:
					list.Add(_003C_003Ec__DisplayClass4_.uid);
					num2 = 5;
					continue;
				default:
					_003C_003Ec__DisplayClass4_2.activeElementUid = activeElementUid;
					num2 = 6;
					continue;
				case 11:
					queue = new Queue<Guid>(new Guid[1] { _003C_003Ec__DisplayClass4_2.activeElementUid });
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
					{
						num2 = 8;
					}
					continue;
				case 6:
					Contract.ArgumentNotNull(newDiagram, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1001967776 ^ -1001926018));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
					{
						num2 = 7;
					}
					continue;
				case 2:
					break;
				case 4:
				case 8:
					if (!queue.Any())
					{
						num2 = 12;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 13:
					return false;
				case 9:
					_003C_003Ec__DisplayClass4_.uid = queue.Dequeue();
					num2 = 10;
					continue;
				case 3:
					return !list.Intersect(second).Any();
				case 1:
					_003C_003Ec__DisplayClass4_2 = new _003C_003Ec__DisplayClass4_0();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					newDiagram.Elements.FirstOrDefault(_003C_003Ec__DisplayClass4_._003CIsActiveElementIsolated_003Eb__3).OutputConnectors.Select((Connector c) => c.EndElement.Uid).Except(list).ForEach(queue.Enqueue);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
					{
						num2 = 4;
					}
					continue;
				case 12:
					second = from e in newDiagram.Elements
						where e is EndEventElement
						select e.Uid;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_1();
			num = 9;
		}
	}

	private bool IsSwimlaneNewOrAltered(SwimlaneChangeInfo info, IWorkflowProcess oldProcess, IWorkflowProcess newProcess)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return IsNewSwimlaneAltered(info, oldProcess, newProcess);
			case 1:
				return false;
			case 2:
				if (info.NewSwimlane != null)
				{
					if (info.OldSwimlane == null)
					{
						return true;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
					{
						num2 = 1;
					}
				}
				break;
			}
		}
	}

	private bool IsNewSwimlaneAltered(SwimlaneChangeInfo info, IWorkflowProcess oldProcess, IWorkflowProcess newProcess)
	{
		//Discarded unreachable code: IL_017e, IL_02aa, IL_02fc
		int num = 14;
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		EntityUserSettings entityUserSettings2 = default(EntityUserSettings);
		EntityUserSettings entityUserSettings = default(EntityUserSettings);
		List<Worker> workers = default(List<Worker>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj2;
				object obj;
				switch (num2)
				{
				case 1:
					return info.OldSwimlane.DepartmentId != info.NewSwimlane.DepartmentId;
				case 13:
					return true;
				default:
					if (info.OldSwimlane.WorkerDetectionType != info.NewSwimlane.WorkerDetectionType)
					{
						num = 10;
						break;
					}
					if (info.OldExecutorProperty != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 6;
				case 3:
					if (!(info.OldSwimlane.ExecuterProperty != info.NewSwimlane.ExecuterProperty))
					{
						num2 = 18;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
						{
							num2 = 14;
						}
						continue;
					}
					return true;
				case 17:
					return info.OldSwimlane.ExtendedSettings[SwimlaneElement.BusinessRoleType] != info.NewSwimlane.ExtendedSettings[SwimlaneElement.BusinessRoleType];
				case 4:
					if (info.NewExecutorProperty == null)
					{
						num2 = 11;
						continue;
					}
					obj2 = info.NewExecutorProperty.Settings as EntityUserSettings;
					goto IL_036c;
				case 2:
					_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
					num2 = 12;
					continue;
				case 16:
					_003C_003Ec__DisplayClass6_.newWorkers = entityUserSettings2.Workers;
					num2 = 9;
					continue;
				case 10:
					return true;
				case 8:
					if (entityUserSettings != null)
					{
						num2 = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
						{
							num2 = 19;
						}
						continue;
					}
					goto IL_031b;
				case 12:
					workers = entityUserSettings.Workers;
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
					{
						num2 = 16;
					}
					continue;
				case 7:
					if (!(info.OldSwimlane.ExecuterProperty != info.NewSwimlane.ExecuterProperty))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 10;
				case 19:
					if (entityUserSettings2 != null)
					{
						num2 = 2;
						continue;
					}
					goto IL_031b;
				case 18:
					return info.OldSwimlane.ScriptName != info.NewSwimlane.ScriptName;
				case 6:
					obj = null;
					goto IL_034c;
				case 14:
					if (info.OldSwimlane.SwimlaneType == info.NewSwimlane.SwimlaneType)
					{
						if (info.NewSwimlane.SwimlaneType != 0)
						{
							if (info.NewSwimlane.SwimlaneType == SwimlaneType.Dynamic)
							{
								num2 = 7;
								continue;
							}
							if (info.NewSwimlane.SwimlaneType != SwimlaneType.DynamicScript)
							{
								if (info.NewSwimlane.SwimlaneType != SwimlaneType.BusinessRole)
								{
									return false;
								}
								num2 = 17;
								continue;
							}
							num = 3;
							break;
						}
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
						{
							num2 = 1;
						}
						continue;
					}
					num2 = 13;
					continue;
				case 9:
					if (workers.Count != _003C_003Ec__DisplayClass6_.newWorkers.Count)
					{
						num2 = 15;
						continue;
					}
					return !workers.All(_003C_003Ec__DisplayClass6_._003CIsNewSwimlaneAltered_003Eb__0);
				case 11:
					obj2 = null;
					goto IL_036c;
				case 15:
					return true;
				case 5:
					{
						obj = info.OldExecutorProperty.Settings as EntityUserSettings;
						goto IL_034c;
					}
					IL_034c:
					entityUserSettings = (EntityUserSettings)obj;
					num = 4;
					break;
					IL_031b:
					return false;
					IL_036c:
					entityUserSettings2 = (EntityUserSettings)obj2;
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
					{
						num2 = 8;
					}
					continue;
				}
				break;
			}
		}
	}

	protected BPMNProcessManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool qdPA7UOGhLsctGq2mgMl()
	{
		return bGC0a1OG1UjqyTbsiiJr == null;
	}

	internal static object UnUsIMOGEYx0hTOhRy9m()
	{
		return bGC0a1OG1UjqyTbsiiJr;
	}
}
