using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Import.Links;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.SubProcess;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Deploy.Import;

public class ProcessHeaderImportSaveActions : EntityImportSaveActions
{
	public static readonly List<Guid> UIDs;

	private static readonly ILogger ImportLog;

	internal static ProcessHeaderImportSaveActions pMbcvfzbvsQKuZ8AxQL;

	public override bool IsSupported(Guid typeGuid)
	{
		return UIDs.Contains(typeGuid);
	}

	public override List<TestImportMessages> ExecPreSaveActions(IEntity entity, ImportEntityPreSaveData data)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals0.processHeader = entity as IProcessHeader;
		if (CS_0024_003C_003E8__locals0.processHeader == null)
		{
			ImportLog.Error(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-14356676 ^ -14317336));
			return new List<TestImportMessages>
			{
				new TestImportMessages(TestImportMessagesType.Error, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351277342)))
			};
		}
		List<TestImportMessages> result = new List<TestImportMessages>();
		CS_0024_003C_003E8__locals0.processHeader.IsDirtyProcess = true;
		ProcessHeaderManager serviceNotNull = Locator.GetServiceNotNull<ProcessHeaderManager>();
		if ((from e in serviceNotNull.LoadReportHeadersByName(CS_0024_003C_003E8__locals0.processHeader.Name, ignoreCase: true)
			where _003C_003Ec__DisplayClass3_0.fXu16kZSRqmYoRJVkofp(_003C_003Ec__DisplayClass3_0.pj6W3dZSjBcRjEqWO8J6(e), _003C_003Ec__DisplayClass3_0.pj6W3dZSjBcRjEqWO8J6(CS_0024_003C_003E8__locals0.processHeader))
			select e).Any())
		{
			string name = CS_0024_003C_003E8__locals0.processHeader.Name;
			CS_0024_003C_003E8__locals0.processHeader.Name = serviceNotNull.GenerateNewName(CS_0024_003C_003E8__locals0.processHeader.Name, CS_0024_003C_003E8__locals0.processHeader.Uid, null, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-10408775 ^ -10468265));
			ImportLog.Info(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56F860D7 ^ 0x56F90823), name, CS_0024_003C_003E8__locals0.processHeader.Name));
		}
		if ((from e in serviceNotNull.LoadReportHeadersByName(CS_0024_003C_003E8__locals0.processHeader.Name, ignoreCase: true)
			where _003C_003Ec__DisplayClass3_0.YriLlfZS6TXUErnwTyps(_003C_003Ec__DisplayClass3_0.pj6W3dZSjBcRjEqWO8J6(e), CS_0024_003C_003E8__locals0.processHeader.Uid)
			select e).Any())
		{
			IEnumerable<IProcessHeader> enumerable = serviceNotNull.LoadSubProcesses(CS_0024_003C_003E8__locals0.processHeader);
			if (enumerable != null)
			{
				foreach (IProcessHeader item in enumerable)
				{
					string key = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638225214 ^ -1638153336), CS_0024_003C_003E8__locals0.processHeader.Uid, item.Uid);
					if (!data.ServiceData.ContainsKey(key))
					{
						data.ServiceData.Add(key, item.Uid.ToString());
					}
				}
			}
		}
		try
		{
			if (CS_0024_003C_003E8__locals0.processHeader.ParentGroup == null)
			{
				_003C_003Ec__DisplayClass3_1 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass3_1();
				List<IProcessGroup> list = new List<IProcessGroup>();
				CS_0024_003C_003E8__locals2.subKey = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-768800937 ^ -768839971), CS_0024_003C_003E8__locals0.processHeader.Uid.ToString().ToLower());
				string text = data.ServiceData.Keys.FirstOrDefault((string s) => _003C_003Ec__DisplayClass3_1.LnMwcfZSQf7CTFGXHXEP(s, CS_0024_003C_003E8__locals2.subKey));
				if (!string.IsNullOrWhiteSpace(text) && data.ServiceData.ContainsKey(text))
				{
					string[] array = text.Split('_');
					if (array.Count() == 3 && Guid.TryParse(array[2], out var result2) && result2 != Guid.Empty)
					{
						IProcessGroup processGroup = Locator.GetServiceNotNull<ProcessGroupManager>().LoadOrNull(result2);
						if (processGroup != null && !processGroup.IsNew())
						{
							CS_0024_003C_003E8__locals0.processHeader.ParentGroup = processGroup;
						}
						else
						{
							if (processGroup == null)
							{
								processGroup = InterfaceActivator.Create<IProcessGroup>();
								processGroup.Uid = result2;
							}
							processGroup.Name = data.ServiceData[text];
							processGroup.Save();
							CS_0024_003C_003E8__locals0.processHeader.ParentGroup = processGroup;
							list.Add(processGroup);
							CreateProcessGroup(processGroup, list, data.ServiceData);
						}
					}
				}
				if (list.Any())
				{
					using (IEnumerator<IProcessGroup> enumerator2 = (from g in list
						where g.Parent != null
						select (IProcessGroup)_003C_003Ec.dEMg51ZSoMxbPWqdIDnp(g)).Distinct().GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							_003C_003Ec__DisplayClass3_2 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass3_2();
							CS_0024_003C_003E8__locals1.parentGroup = enumerator2.Current;
							List<IProcessGroup> list2 = list.Where(delegate(IProcessGroup g)
							{
								int num3 = 1;
								int num4 = num3;
								while (true)
								{
									switch (num4)
									{
									default:
										return _003C_003Ec__DisplayClass3_2.x570dyZSVtckOKQLGpmW(_003C_003Ec__DisplayClass3_2.H4Ux38ZSUcMoOqLlH5yu(_003C_003Ec__DisplayClass3_2.XDyvY4ZSkwFSE7Tn1pIs(g)), _003C_003Ec__DisplayClass3_2.H4Ux38ZSUcMoOqLlH5yu(CS_0024_003C_003E8__locals1.parentGroup));
									case 1:
										if (g.Parent == null)
										{
											return false;
										}
										num4 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
										{
											num4 = 0;
										}
										break;
									}
								}
							}).ToList();
							List<IProcessGroup> list3 = new List<IProcessGroup>();
							list3.AddRange(list2);
							if (CS_0024_003C_003E8__locals1.parentGroup.SubGroups != null)
							{
								list3.AddRange((IEnumerable<IProcessGroup>)CS_0024_003C_003E8__locals1.parentGroup.SubGroups);
							}
							GenerateNewName(list2, list3);
						}
					}
					IEnumerable<IProcessGroup> enumerable2 = Locator.GetServiceNotNull<ProcessGroupManager>().LoadRootGroups();
					List<IProcessGroup> list4 = list.Where(delegate(IProcessGroup g)
					{
						int num = 1;
						int num2 = num;
						while (true)
						{
							switch (num2)
							{
							case 1:
								if (_003C_003Ec.dEMg51ZSoMxbPWqdIDnp(g) == null)
								{
									return false;
								}
								num2 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
								{
									num2 = 0;
								}
								break;
							default:
								return _003C_003Ec.dEMg51ZSoMxbPWqdIDnp(g) == null;
							}
						}
					}).ToList();
					List<IProcessGroup> list5 = new List<IProcessGroup>();
					list5.AddRange(list4);
					if (enumerable2 != null)
					{
						list5.AddRange(enumerable2);
					}
					GenerateNewName(list4, list5);
					return result;
				}
				return result;
			}
			return result;
		}
		catch (Exception exception)
		{
			ImportLog.Info(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1647793954 ^ -1647722226) + CS_0024_003C_003E8__locals0.processHeader.Uid, exception);
			return result;
		}
	}

	private void GenerateNewName(List<IProcessGroup> newGroupsForThisParent, List<IProcessGroup> allGroupsForThisParent)
	{
		foreach (IProcessGroup item in newGroupsForThisParent)
		{
			_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
			string name = item.Name;
			CS_0024_003C_003E8__locals0.grp = item;
			IEnumerable<IProcessGroup> enumerable = allGroupsForThisParent.Where(delegate(IProcessGroup g)
			{
				//Discarded unreachable code: IL_0062, IL_0071
				int num4 = 2;
				int num5 = num4;
				while (true)
				{
					switch (num5)
					{
					case 2:
						if (!(_003C_003Ec__DisplayClass4_0.LZ1aQMZSrutVkiQH5U4l(g) != _003C_003Ec__DisplayClass4_0.LZ1aQMZSrutVkiQH5U4l(CS_0024_003C_003E8__locals0.grp)))
						{
							num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
							{
								num5 = 1;
							}
							break;
						}
						goto default;
					default:
						return string.Equals((string)_003C_003Ec__DisplayClass4_0.MbUBYlZSejYqieeihx3h(g), (string)_003C_003Ec__DisplayClass4_0.MbUBYlZSejYqieeihx3h(CS_0024_003C_003E8__locals0.grp), StringComparison.OrdinalIgnoreCase);
					case 1:
						return false;
					}
				}
			});
			long num = 1L;
			while (enumerable != null && enumerable.Count() > 0 && num < long.MaxValue)
			{
				_003C_003Ec__DisplayClass4_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass4_1();
				CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
				CS_0024_003C_003E8__locals1.newName = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2F44D93A ^ 0x2F45FD2C), (name.Length + num.ToString().Length + 3 > 2000) ? name.Substring(1, 2000 - num.ToString().Length - 3) : name, num);
				enumerable = allGroupsForThisParent.Where(delegate(IProcessGroup g)
				{
					//Discarded unreachable code: IL_007c, IL_008b
					int num2 = 2;
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							return _003C_003Ec__DisplayClass4_1.hls1REZSEZ4hCBpPYXPP(_003C_003Ec__DisplayClass4_1.IEvxTjZSh3eJgq79wmWr(g), CS_0024_003C_003E8__locals1.newName, StringComparison.OrdinalIgnoreCase);
						case 1:
							return false;
						case 2:
							if (!(_003C_003Ec__DisplayClass4_1.c4nDMZZS1s5OcoALDN2Y(g) != CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.grp.Uid))
							{
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
								{
									num3 = 1;
								}
								break;
							}
							goto default;
						}
					}
				});
				if (enumerable == null || enumerable.Count() <= 0 || num >= long.MaxValue)
				{
					item.Name = CS_0024_003C_003E8__locals1.newName;
				}
				num++;
			}
		}
	}

	private void CreateProcessGroup(IProcessGroup group, List<IProcessGroup> newGroups, Dictionary<string, string> serviceData)
	{
		if (group.Parent != null)
		{
			return;
		}
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0.subKey = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105863102 ^ -105790872), group.Uid.ToString().ToLower());
		string text = serviceData.Keys.FirstOrDefault((string s) => _003C_003Ec__DisplayClass5_0.aonwifZ1K9hHHxQhYKWv(s, CS_0024_003C_003E8__locals0.subKey));
		if (string.IsNullOrWhiteSpace(text) || !serviceData.ContainsKey(text))
		{
			return;
		}
		_003C_003Ec__DisplayClass5_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass5_1();
		string[] array = text.Split('_');
		if (array.Count() != 3 || !Guid.TryParse(array[2], out CS_0024_003C_003E8__locals1.parentGroupUid) || !(CS_0024_003C_003E8__locals1.parentGroupUid != Guid.Empty) || newGroups.FirstOrDefault((IProcessGroup g) => _003C_003Ec__DisplayClass5_1.HKCEZbZ1sIVEG2iFsNO3(_003C_003Ec__DisplayClass5_1.dKriAVZ18ZjRdKHy9bWl(g), CS_0024_003C_003E8__locals1.parentGroupUid)) != null)
		{
			return;
		}
		IProcessGroup processGroup = Locator.GetServiceNotNull<ProcessGroupManager>().LoadOrNull(CS_0024_003C_003E8__locals1.parentGroupUid);
		if (processGroup != null && !processGroup.IsNew())
		{
			group.Parent = processGroup;
			return;
		}
		if (processGroup == null)
		{
			processGroup = InterfaceActivator.Create<IProcessGroup>();
			processGroup.Uid = CS_0024_003C_003E8__locals1.parentGroupUid;
		}
		processGroup.Name = serviceData[text];
		processGroup.Save();
		group.Parent = processGroup;
		newGroups.Add(processGroup);
		CreateProcessGroup(processGroup, newGroups, serviceData);
	}

	public override void ExecPostSaveActions(IEntity entity, Type type, Dictionary<string, object> values, Dictionary<string, string> serviceData, LinksDictionary links)
	{
		if (!(entity is IProcessHeader processHeader))
		{
			return;
		}
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		ProcessHeaderManager serviceNotNull = Locator.GetServiceNotNull<ProcessHeaderManager>();
		_003C_003Ec__DisplayClass6_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass6_1();
		CS_0024_003C_003E8__locals1.keyString = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF79B9C) + processHeader.Uid;
		foreach (KeyValuePair<string, string> item in serviceData.Where((KeyValuePair<string, string> p) => p.Key.StartsWith(CS_0024_003C_003E8__locals1.keyString)).ToList())
		{
			string[] array = item.Key.Split('_');
			if (array.Count() != 3 || !Guid.TryParse(array[1], out var _) || !Guid.TryParse(array[2], out var result2) || string.IsNullOrWhiteSpace(item.Value))
			{
				continue;
			}
			string[] array2 = item.Value.Split('_');
			if (array2 == null || array2.Count() != 2 || !long.TryParse(array2[0], out var result3) || !Guid.TryParse(array2[1], out var result4))
			{
				continue;
			}
			IProcessHeader processHeader2 = serviceNotNull.LoadOrNull(result4);
			if (processHeader2 == null)
			{
				continue;
			}
			IWorkflowProcess current2 = processHeader2.Current;
			if (current2 == null || current2.Diagram == null || current2.Diagram.Elements == null)
			{
				continue;
			}
			foreach (InternalSubprocessElement item2 in current2.Diagram.Elements.OfType<InternalSubprocessElement>())
			{
				if (GetCorrectInvertProcHeadId(current2, serviceData, item2.Uid, result3) && result2 == item2.Uid)
				{
					item2.ProcessHeaderId = processHeader.Id;
				}
			}
			foreach (ExternalSubprocessElement item3 in current2.Diagram.Elements.OfType<ExternalSubprocessElement>())
			{
				if (GetCorrectInvertProcHeadId(current2, serviceData, item3.Uid, result3) && result2 == item3.Uid)
				{
					item3.ProcessHeaderId = processHeader.Id;
				}
			}
			current2.Diagram = ClassSerializationHelper.CloneObjectByXml(current2.Diagram);
			current2.Save();
		}
		CS_0024_003C_003E8__locals0.keyForOldSubHeaders = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-772614310 ^ -772555270) + processHeader.Uid;
		foreach (KeyValuePair<string, string> item4 in serviceData.Where((KeyValuePair<string, string> p) => p.Key.StartsWith(CS_0024_003C_003E8__locals0.keyForOldSubHeaders)).ToList())
		{
			string[] array3 = item4.Key.Split('_');
			if (array3.Count() == 3 && Guid.TryParse(array3[1], out var result5) && !string.IsNullOrWhiteSpace(item4.Value) && Guid.TryParse(item4.Value, out var result6))
			{
				IProcessHeader processHeader3 = serviceNotNull.LoadOrNull(result6);
				IProcessHeader processHeader4 = serviceNotNull.LoadOrNull(result5);
				if (processHeader3 != null)
				{
					processHeader4.SubHeaders.Add(processHeader3);
				}
			}
		}
	}

	private bool GetCorrectInvertProcHeadId(IWorkflowProcess parentProcess, Dictionary<string, string> serviceData, Guid elementUid, long subProcessHeaderId)
	{
		if (parentProcess != null)
		{
			string key = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51EF0063 ^ 0x51EE6AB1) + elementUid;
			if (serviceData.ContainsKey(key))
			{
				string[] array = serviceData[key].Split('_');
				if (array != null && array.Count() == 2 && Guid.TryParse(array[0], out var result) && long.TryParse(array[1], out var result2) && result == parentProcess.Uid && result2 == subProcessHeaderId)
				{
					return true;
				}
			}
		}
		return false;
	}

	public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
	{
		//Discarded unreachable code: IL_01e2, IL_0212, IL_0221, IL_0230, IL_0261, IL_036f, IL_037e, IL_038d, IL_03b6, IL_056d, IL_05dc, IL_05eb, IL_061d
		int num = 23;
		XmlReader xmlReader = default(XmlReader);
		Guid result2 = default(Guid);
		Guid result3 = default(Guid);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 28:
					if (NNyo6NznYM7HT4f22K0(xmlReader))
					{
						num2 = 5;
						continue;
					}
					goto case 32;
				case 38:
					if (!NNyo6NznYM7HT4f22K0(xmlReader))
					{
						num2 = 7;
						continue;
					}
					goto case 6;
				case 37:
				{
					object obj2 = MP6EgUzL5gCC7BYRQiR(xmlReader);
					ParameterExpression parameterExpression = (ParameterExpression)s7rQjdzffCNSN7FiOnj(typeof(IProcessHeader), Qq4OuQzXvN0ZvRLaQXq(--1212129906 ^ 0x483EBE5C));
					if (!I7NCXXzDksWjlajDRHi(obj2, LinqUtils.NameOf(Expression.Lambda<Func<IProcessHeader, object>>((Expression)LijOiKzuKx2WBBU3tpM(parameterExpression, (MethodInfo)eS32yXzdLOpJPbw7HOT((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }))))
					{
						num2 = 34;
						continue;
					}
					goto case 30;
				}
				default:
					if (!KLXUaUzTP5bShGvYKcs(result2, default(Guid)))
					{
						num2 = 41;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 2;
				case 1:
				case 3:
				case 20:
				case 31:
				case 34:
				case 42:
					rpBgCszRn8tQ1s7ekur(xmlReader);
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
					{
						num2 = 6;
					}
					continue;
				case 4:
					CWBlc5zcWgV1RA5vthH(xmlReader);
					num2 = 31;
					continue;
				case 6:
				case 21:
					if (!jQKckuzjqJpDuPlNkxi(xmlReader))
					{
						num2 = 42;
						continue;
					}
					goto case 37;
				case 11:
					result3 = Guid.Empty;
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
					{
						num2 = 12;
					}
					continue;
				case 24:
					ARvi04zPP6pG80ltQuL(xmlReader);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
					{
						num2 = 15;
					}
					continue;
				case 7:
					xmlReader.MoveToElement();
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num2 = 33;
					}
					continue;
				case 44:
					CWBlc5zcWgV1RA5vthH(xmlReader);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
				case 9:
				case 27:
					if (xmlReader.IsStartElement())
					{
						num2 = 14;
						continue;
					}
					goto case 6;
				case 22:
					xmlReader = (XmlReader)tso0GMzBnKD7ElmdieG(data);
					num = 11;
					break;
				case 8:
				{
					string name = xmlReader.Name;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(IProcessHeader), (string)Qq4OuQzXvN0ZvRLaQXq(0x13F63440 ^ 0x13F7286E));
					if (!I7NCXXzDksWjlajDRHi(name, LinqUtils.NameOf(Expression.Lambda<Func<IProcessHeader, object>>((Expression)LijOiKzuKx2WBBU3tpM(parameterExpression, (MethodInfo)eS32yXzdLOpJPbw7HOT((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }))))
					{
						num2 = 27;
						continue;
					}
					goto case 28;
				}
				case 10:
					CWBlc5zcWgV1RA5vthH(xmlReader);
					num2 = 29;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
					{
						num2 = 35;
					}
					continue;
				case 41:
					return;
				case 36:
					return;
				case 39:
					Guid.TryParse((string)EOEWxnzHYhF2Q2ce8gG(xmlReader), out result2);
					num2 = 19;
					continue;
				case 33:
					Guid.TryParse((string)EOEWxnzHYhF2Q2ce8gG(xmlReader), out result3);
					num2 = 44;
					continue;
				case 32:
					ARvi04zPP6pG80ltQuL(xmlReader);
					num2 = 43;
					continue;
				case 29:
					if (xmlReader.IsStartElement())
					{
						num2 = 8;
						continue;
					}
					goto case 5;
				case 19:
					CWBlc5zcWgV1RA5vthH(xmlReader);
					num2 = 3;
					continue;
				case 43:
					text = (string)EOEWxnzHYhF2Q2ce8gG(xmlReader);
					num2 = 4;
					continue;
				case 23:
					if (data.ConfigImportSettings != null)
					{
						num = 22;
						break;
					}
					return;
				case 18:
					CWBlc5zcWgV1RA5vthH(xmlReader);
					num2 = 24;
					continue;
				case 14:
				{
					object obj = MP6EgUzL5gCC7BYRQiR(xmlReader);
					ParameterExpression parameterExpression = (ParameterExpression)s7rQjdzffCNSN7FiOnj(typeof(IProcessHeader), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657647093));
					if (!((string)obj == LinqUtils.NameOf(Expression.Lambda<Func<IProcessHeader, object>>((Expression)gsEPjtzW0hQd3vpbJQ7(LijOiKzuKx2WBBU3tpM(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), UGhna0z9DryoshmR9BU(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }))))
					{
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 38;
				}
				case 25:
					text = "";
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
					{
						num2 = 10;
					}
					continue;
				case 30:
					if (NNyo6NznYM7HT4f22K0(xmlReader))
					{
						num2 = 20;
						continue;
					}
					goto case 16;
				case 17:
					if (!mCvtYXz3iU3yoUlvkiC(result3, default(Guid)))
					{
						num2 = 36;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
						{
							num2 = 32;
						}
						continue;
					}
					goto default;
				case 16:
					xmlReader.MoveToElement();
					num2 = 39;
					continue;
				case 40:
					return;
				case 12:
					result2 = Guid.Empty;
					num2 = 25;
					continue;
				case 13:
					EV4U4qz61nksk9hWBVN(xmlReader);
					num2 = 22;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num2 = 26;
					}
					continue;
				case 2:
					bRJCXhzMN0masBRXAGR(OcLLYczChv6ojOGD8lD(xu6FSgzplWFf4osY4Re(hAfh4ezQafFOI8yd0KK(data)), WorkflowExportConsts.ExportExtensionUid, ""), result3, text);
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
					{
						num2 = 40;
					}
					continue;
				case 35:
					ARvi04zPP6pG80ltQuL(xmlReader);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
					{
						num2 = 18;
					}
					continue;
				case 15:
				case 26:
					if (tOrZc6zqZIH6MaH8d7T(xmlReader) == XmlNodeType.EndElement)
					{
						num2 = 17;
						continue;
					}
					goto case 29;
				}
				break;
			}
		}
	}

	public ProcessHeaderImportSaveActions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ProcessHeaderImportSaveActions()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				ImportLog = (ILogger)wIfNPyzUk4yZDxisIuZ(Qq4OuQzXvN0ZvRLaQXq(-1965291699 ^ -1965200383));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				UIDs = new List<Guid>
				{
					new Guid((string)Qq4OuQzXvN0ZvRLaQXq(0x4FD00585 ^ 0x4FD16E85))
				};
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				mGhCu7zkCcdDyQrfDep();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool SBwLxtz5Huei3P8XnOF()
	{
		return pMbcvfzbvsQKuZ8AxQL == null;
	}

	internal static ProcessHeaderImportSaveActions z9UiB5zgGt8RCm9SknB()
	{
		return pMbcvfzbvsQKuZ8AxQL;
	}

	internal static object tso0GMzBnKD7ElmdieG(object P_0)
	{
		return ((ImportTestReadData)P_0).Reader;
	}

	internal static bool CWBlc5zcWgV1RA5vthH(object P_0)
	{
		return ((XmlReader)P_0).Read();
	}

	internal static bool ARvi04zPP6pG80ltQuL(object P_0)
	{
		return ((XmlReader)P_0).MoveToElement();
	}

	internal static object Qq4OuQzXvN0ZvRLaQXq(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object eS32yXzdLOpJPbw7HOT(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object LijOiKzuKx2WBBU3tpM(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static bool I7NCXXzDksWjlajDRHi(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool NNyo6NznYM7HT4f22K0(object P_0)
	{
		return ((XmlReader)P_0).IsEmptyElement;
	}

	internal static object EOEWxnzHYhF2Q2ce8gG(object P_0)
	{
		return ((XmlReader)P_0).ReadString();
	}

	internal static object MP6EgUzL5gCC7BYRQiR(object P_0)
	{
		return ((XmlReader)P_0).Name;
	}

	internal static object s7rQjdzffCNSN7FiOnj(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static Type UGhna0z9DryoshmR9BU(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object gsEPjtzW0hQd3vpbJQ7(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static bool jQKckuzjqJpDuPlNkxi(object P_0)
	{
		return ((XmlReader)P_0).IsStartElement();
	}

	internal static void rpBgCszRn8tQ1s7ekur(object P_0)
	{
		((XmlReader)P_0).Skip();
	}

	internal static XmlNodeType EV4U4qz61nksk9hWBVN(object P_0)
	{
		return ((XmlReader)P_0).MoveToContent();
	}

	internal static XmlNodeType tOrZc6zqZIH6MaH8d7T(object P_0)
	{
		return ((XmlReader)P_0).NodeType;
	}

	internal static bool mCvtYXz3iU3yoUlvkiC(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool KLXUaUzTP5bShGvYKcs(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object hAfh4ezQafFOI8yd0KK(object P_0)
	{
		return ((ImportTestReadData)P_0).ConfigImportSettings;
	}

	internal static object xu6FSgzplWFf4osY4Re(object P_0)
	{
		return ((IConfigImportSettings)P_0).FakeManifest;
	}

	internal static object OcLLYczChv6ojOGD8lD(object P_0, Guid P_1, object P_2)
	{
		return ((BPMAppFakeManifest)P_0).GetOrCreateChapterByUid(P_1, (string)P_2);
	}

	internal static object bRJCXhzMN0masBRXAGR(object P_0, Guid P_1, object P_2)
	{
		return ((BPMAppManifestFakeChapter)P_0).GetOrCreateItemByUid(P_1, (string)P_2);
	}

	internal static void mGhCu7zkCcdDyQrfDep()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object wIfNPyzUk4yZDxisIuZ(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
