using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Deploy.Import;

public class CustomActivityHeaderImportSaveActions : EntityImportSaveActions
{
	public static readonly Guid UID;

	private static readonly ILogger ImportLog;

	internal static CustomActivityHeaderImportSaveActions H7fN0DT0EG3qJs0D3dl;

	public override bool IsSupported(Guid typeGuid)
	{
		return oyQiCcTHMwD7pFym0Ca(typeGuid, UID);
	}

	public override bool CanBeSaved(Dictionary<string, object> propValues, ImportEntityCanBeSavedData data)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		if (propValues == null)
		{
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747C4140 ^ 0x747C3274))));
			return false;
		}
		CustomActivityHeaderManager serviceNotNull = Locator.GetServiceNotNull<CustomActivityHeaderManager>();
		string text = (propValues.ContainsKey(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xFA4957C ^ 0xFA4C300)) ? propValues[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-408604271 ^ -408590355)].ToString() : null);
		if (string.IsNullOrWhiteSpace(text))
		{
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138431307 ^ -138426619))));
			return false;
		}
		CS_0024_003C_003E8__locals0.uid = Guid.Empty;
		if (propValues.ContainsKey(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x27475F40 ^ 0x27470C92)) && propValues[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1941486619 ^ -1941499849)] != null)
		{
			Guid.TryParse(propValues[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1197637235 ^ -1197616545)].ToString(), out CS_0024_003C_003E8__locals0.uid);
		}
		if (CS_0024_003C_003E8__locals0.uid == Guid.Empty)
		{
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xFAE81C9 ^ 0xFAEF583))));
			return false;
		}
		bool? flag = null;
		if (propValues.ContainsKey(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xB84E87 ^ 0xB815ED)) && propValues[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48FEDADC ^ 0x48FE81B6)] != null)
		{
			bool result = false;
			if (bool.TryParse(propValues[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x242A8D1D ^ 0x242AD677)].ToString(), out result))
			{
				flag = result;
			}
		}
		if (flag == true)
		{
			ICustomActivityHeader customActivityHeader = serviceNotNull.LoadOrNull(CS_0024_003C_003E8__locals0.uid);
			if (customActivityHeader != null && customActivityHeader.Name != text)
			{
				data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-182059571 ^ -182089425))));
				return false;
			}
		}
		if (flag == true && (from e in serviceNotNull.LoadCustomActivityHeadersByName(text, ignoreCase: true)
			where _003C_003Ec__DisplayClass3_0.MvbvstR2eEc7NK2QYJ3(e) != CS_0024_003C_003E8__locals0.uid
			select e).Count() > 0)
		{
			Logger.Log.Error(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1275462473 ^ -1275491879));
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48FEDADC ^ 0x48FEACC6))));
			return false;
		}
		return true;
	}

	public override List<TestImportMessages> ExecPreSaveActions(IEntity entity, ImportEntityPreSaveData data)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0.caHeader = entity as ICustomActivityHeader;
		if (CS_0024_003C_003E8__locals0.caHeader == null)
		{
			Logger.Log.Error(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-588615921 ^ -588637867));
			return new List<TestImportMessages>
			{
				new TestImportMessages(TestImportMessagesType.Error, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-182059571 ^ -182088957)))
			};
		}
		CS_0024_003C_003E8__locals0.caHeader.IsDirtyCustomActivity = true;
		CustomActivityHeaderManager serviceNotNull = Locator.GetServiceNotNull<CustomActivityHeaderManager>();
		if (CS_0024_003C_003E8__locals0.caHeader.ReadOnly != true && (from e in serviceNotNull.LoadCustomActivityHeadersByName(CS_0024_003C_003E8__locals0.caHeader.Name, ignoreCase: true)
			where _003C_003Ec__DisplayClass4_0.nqf6PxRMxmh0SIP7w7q(_003C_003Ec__DisplayClass4_0.fVi5lpRKRms743deemt(e), CS_0024_003C_003E8__locals0.caHeader.Uid)
			select e).Any())
		{
			CS_0024_003C_003E8__locals0.caHeader.Name = serviceNotNull.GenerateNewName(CS_0024_003C_003E8__locals0.caHeader.Name, CS_0024_003C_003E8__locals0.caHeader.Uid, null, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3D87FABF ^ 0x3D878D37));
		}
		try
		{
			if (CS_0024_003C_003E8__locals0.caHeader.Folder == null)
			{
				_003C_003Ec__DisplayClass4_1 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass4_1();
				List<ICustomActivityFolder> list = new List<ICustomActivityFolder>();
				CS_0024_003C_003E8__locals2.subKey = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48FD6D2E ^ 0x48FD1AA0), CS_0024_003C_003E8__locals0.caHeader.Uid.ToString().ToLower());
				string text = data.ServiceData.Keys.FirstOrDefault((string s) => _003C_003Ec__DisplayClass4_1.qZx1R3RPy7rondxkh1U(s, CS_0024_003C_003E8__locals2.subKey));
				if (!string.IsNullOrWhiteSpace(text) && data.ServiceData.ContainsKey(text))
				{
					string[] array = text.Split('_');
					if (array.Count() == 3 && Guid.TryParse(array[2], out var result) && result != Guid.Empty)
					{
						ICustomActivityFolder customActivityFolder = Locator.GetServiceNotNull<CustomActivityFolderManager>().LoadOrNull(result);
						if (customActivityFolder != null && !customActivityFolder.IsNew())
						{
							CS_0024_003C_003E8__locals0.caHeader.Folder = customActivityFolder;
						}
						else
						{
							if (customActivityFolder == null)
							{
								customActivityFolder = InterfaceActivator.Create<ICustomActivityFolder>();
								customActivityFolder.Uid = result;
							}
							customActivityFolder.Name = data.ServiceData[text];
							customActivityFolder.Save();
							CS_0024_003C_003E8__locals0.caHeader.Folder = customActivityFolder;
							list.Add(customActivityFolder);
							CreateCustomActivityGroup(customActivityFolder, list, data.ServiceData);
						}
					}
				}
				if (list.Any())
				{
					using (IEnumerator<ICustomActivityFolder> enumerator = (from g in list
						where _003C_003Ec.YyKDp8RUClw5QEu0615(g) != null
						select (ICustomActivityFolder)_003C_003Ec.YyKDp8RUClw5QEu0615(g)).Distinct().GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							_003C_003Ec__DisplayClass4_2 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass4_2();
							CS_0024_003C_003E8__locals1.parentGroup = enumerator.Current;
							List<ICustomActivityFolder> list2 = list.Where(delegate(ICustomActivityFolder g)
							{
								//Discarded unreachable code: IL_002d, IL_003c
								int num = 2;
								int num2 = num;
								while (true)
								{
									switch (num2)
									{
									case 2:
										if (g.Folder == null)
										{
											num2 = 0;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 == 0)
											{
												num2 = 1;
											}
											break;
										}
										goto default;
									default:
										return _003C_003Ec__DisplayClass4_2.w0U8akRd04xTNh4H8PS(_003C_003Ec__DisplayClass4_2.IeIHIlRNrr287ghSafZ(g.Folder), _003C_003Ec__DisplayClass4_2.IeIHIlRNrr287ghSafZ(CS_0024_003C_003E8__locals1.parentGroup));
									case 1:
										return false;
									}
								}
							}).ToList();
							List<ICustomActivityFolder> list3 = new List<ICustomActivityFolder>();
							list3.AddRange(list2);
							if (CS_0024_003C_003E8__locals1.parentGroup.SubFolders != null)
							{
								list3.AddRange((IEnumerable<ICustomActivityFolder>)CS_0024_003C_003E8__locals1.parentGroup.SubFolders);
							}
							GenerateNewName(list2, list3);
						}
					}
					IEnumerable<ICustomActivityFolder> enumerable = Locator.GetServiceNotNull<CustomActivityFolderManager>().LoadRootFolders();
					List<ICustomActivityFolder> list4 = list.Where((ICustomActivityFolder g) => _003C_003Ec.YyKDp8RUClw5QEu0615(g) == null).ToList();
					List<ICustomActivityFolder> list5 = new List<ICustomActivityFolder>();
					list5.AddRange(list4);
					if (enumerable != null)
					{
						list5.AddRange(enumerable);
					}
					GenerateNewName(list4, list5);
				}
			}
		}
		catch (Exception exception)
		{
			ImportLog.Info(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xFAE81C9 ^ 0xFAEF639) + CS_0024_003C_003E8__locals0.caHeader.Uid, exception);
		}
		return new List<TestImportMessages>();
	}

	private void GenerateNewName(List<ICustomActivityFolder> newGroupsForThisParent, List<ICustomActivityFolder> allGroupsForThisParent)
	{
		foreach (ICustomActivityFolder item in newGroupsForThisParent)
		{
			_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
			CS_0024_003C_003E8__locals0.groupF = item;
			string name = CS_0024_003C_003E8__locals0.groupF.Name;
			IEnumerable<ICustomActivityFolder> enumerable = allGroupsForThisParent.Where(delegate(ICustomActivityFolder g)
			{
				int num4 = 1;
				int num5 = num4;
				while (true)
				{
					switch (num5)
					{
					case 1:
						if (!_003C_003Ec__DisplayClass5_0.M58XiuRyZhHtQPsDT29(_003C_003Ec__DisplayClass5_0.rChqKMRnxey4avZkAGY(g), _003C_003Ec__DisplayClass5_0.rChqKMRnxey4avZkAGY(CS_0024_003C_003E8__locals0.groupF)))
						{
							return false;
						}
						num5 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2f22e6eeec1e40a4b9dae10f79ea3ae0 == 0)
						{
							num5 = 0;
						}
						break;
					default:
						return string.Equals((string)_003C_003Ec__DisplayClass5_0.REOZhgRO1UBAZWdNs71(g), CS_0024_003C_003E8__locals0.groupF.Name, StringComparison.OrdinalIgnoreCase);
					}
				}
			});
			long num = 1L;
			while (enumerable != null && enumerable.Count() > 0 && num < long.MaxValue)
			{
				_003C_003Ec__DisplayClass5_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass5_1();
				CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
				CS_0024_003C_003E8__locals1.newName = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1643416224 ^ -1643442898), (name.Length + num.ToString().Length + 3 > 2000) ? name.Substring(1, 2000 - num.ToString().Length - 3) : name, num);
				enumerable = allGroupsForThisParent.Where(delegate(ICustomActivityFolder g)
				{
					//Discarded unreachable code: IL_002d, IL_003c
					int num2 = 2;
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							return _003C_003Ec__DisplayClass5_1.qOiuTVRede7HrJUGhog(_003C_003Ec__DisplayClass5_1.FmfJioRH0Sksn0m0ojj(g), CS_0024_003C_003E8__locals1.newName, StringComparison.OrdinalIgnoreCase);
						case 1:
							return false;
						case 2:
							if (!(_003C_003Ec__DisplayClass5_1.Lf0x5rRWxitp1nmigOM(g) != _003C_003Ec__DisplayClass5_1.Lf0x5rRWxitp1nmigOM(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.groupF)))
							{
								num3 = 1;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_77bc2455d9c3443ca1c76a1788888437 == 0)
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
					CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.groupF.Name = CS_0024_003C_003E8__locals1.newName;
				}
				num++;
			}
		}
	}

	private void CreateCustomActivityGroup(ICustomActivityFolder group, List<ICustomActivityFolder> newGroups, Dictionary<string, string> serviceData)
	{
		if (group.Folder != null)
		{
			return;
		}
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals0.subKey = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-444713948 ^ -444707776), group.Uid.ToString().ToLower());
		string text = serviceData.Keys.FirstOrDefault((string s) => s.StartsWith(CS_0024_003C_003E8__locals0.subKey));
		if (string.IsNullOrWhiteSpace(text) || !serviceData.ContainsKey(text))
		{
			return;
		}
		_003C_003Ec__DisplayClass6_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass6_1();
		string[] array = text.Split('_');
		if (array.Count() != 3 || !Guid.TryParse(array[2], out CS_0024_003C_003E8__locals1.parentGroupUid) || !(CS_0024_003C_003E8__locals1.parentGroupUid != Guid.Empty) || newGroups.FirstOrDefault((ICustomActivityFolder g) => g.Uid == CS_0024_003C_003E8__locals1.parentGroupUid) != null)
		{
			return;
		}
		ICustomActivityFolder customActivityFolder = Locator.GetServiceNotNull<CustomActivityFolderManager>().LoadOrNull(CS_0024_003C_003E8__locals1.parentGroupUid);
		if (customActivityFolder != null && !customActivityFolder.IsNew())
		{
			group.Folder = customActivityFolder;
			return;
		}
		if (customActivityFolder == null)
		{
			customActivityFolder = InterfaceActivator.Create<ICustomActivityFolder>();
			customActivityFolder.Uid = CS_0024_003C_003E8__locals1.parentGroupUid;
		}
		customActivityFolder.Name = serviceData[text];
		customActivityFolder.Save();
		group.Folder = customActivityFolder;
		newGroups.Add(customActivityFolder);
		CreateCustomActivityGroup(customActivityFolder, newGroups, serviceData);
	}

	public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
	{
		//Discarded unreachable code: IL_0137, IL_0146, IL_018e, IL_019e, IL_0314, IL_0323, IL_0333
		int num = 3;
		XmlReader xmlReader = default(XmlReader);
		Guid result2 = default(Guid);
		string title = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 21:
				{
					object obj2 = yGkyeqTLs6eMOYZGPkj(xmlReader);
					ParameterExpression parameterExpression = (ParameterExpression)m9jGIeT7TjAro67ZhiH(CDVDw0TJF8jm9sbgbgj(typeof(ICustomActivityHeader).TypeHandle), kQ7ws8Trce6Pogk7vA6(0x3C126B81 ^ 0x3C120629));
					if (aXOZoPT1jaBneUD3Um6(obj2, LinqUtils.NameOf(Expression.Lambda<Func<ICustomActivityHeader, object>>((Expression)LFCeUVTgVNNdfOSuMSO(parameterExpression, (MethodInfo)eyReOkT5IHXaaCqT0qM((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }))))
					{
						num2 = 14;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_908b32727d48459090dc901d67456a14 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 23;
				}
				case 8:
					xmlReader = (XmlReader)Dukq6PTieJAe1KgvwyK(data);
					num2 = 9;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_520732c4e13f4c5b8eebfda6fa186589 == 0)
					{
						num2 = 5;
					}
					continue;
				case 27:
					if (ocuhWuTfG8g8dOISYfP(xmlReader))
					{
						num2 = 21;
						continue;
					}
					goto case 23;
				case 11:
					xmlReader.MoveToContent();
					num2 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_51bbd8978ad84af991914149de98c8c6 == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					return;
				case 2:
					return;
				case 9:
					result2 = Guid.Empty;
					num2 = 26;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 == 0)
					{
						num2 = 28;
					}
					continue;
				case 14:
					if (JH1AFUTILycDMQQT7ed(xmlReader))
					{
						num2 = 3;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22be8589196e4573a0c71199212852ff != 0)
						{
							num2 = 23;
						}
						continue;
					}
					goto case 16;
				case 13:
					vc7nkDTlo9rqslB46iR(xmlReader);
					num2 = 7;
					continue;
				case 24:
					((BPMAppManifestFakeChapter)bxfewicop7Xyhu64ydY(lfBWPlcX0snvCPfOs2f(jI7n3cTe6S368sQZP7E(data)), CustomActivityExportConsts.ExportExtensionUid, "")).GetOrCreateItemByUid(result2, title);
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_427a79594804461da96485ca77914e7b != 0)
					{
						num2 = 1;
					}
					continue;
				case 23:
				case 30:
					if (ocuhWuTfG8g8dOISYfP(xmlReader))
					{
						num2 = 6;
						continue;
					}
					goto case 10;
				case 20:
					vc7nkDTlo9rqslB46iR(xmlReader);
					num2 = 26;
					continue;
				case 16:
					vc7nkDTlo9rqslB46iR(xmlReader);
					num2 = 12;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 == 0)
					{
						num2 = 7;
					}
					continue;
				case 6:
				{
					object obj = yGkyeqTLs6eMOYZGPkj(xmlReader);
					ParameterExpression parameterExpression = (ParameterExpression)m9jGIeT7TjAro67ZhiH(CDVDw0TJF8jm9sbgbgj(typeof(ICustomActivityHeader).TypeHandle), kQ7ws8Trce6Pogk7vA6(0x532DFB0A ^ 0x532D96A2));
					if (!aXOZoPT1jaBneUD3Um6(obj, LinqUtils.NameOf(Expression.Lambda<Func<ICustomActivityHeader, object>>((Expression)MLjYG5TzenfrCumwwGV(LFCeUVTgVNNdfOSuMSO(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), CDVDw0TJF8jm9sbgbgj(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }))))
					{
						num2 = 9;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_fc30864faaad488ba50da4607dce40b9 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 19;
				}
				case 19:
					if (!JH1AFUTILycDMQQT7ed(xmlReader))
					{
						num2 = 25;
						continue;
					}
					goto case 10;
				case 3:
					if (jI7n3cTe6S368sQZP7E(data) == null)
					{
						num2 = 2;
						continue;
					}
					goto case 8;
				case 15:
					Guid.TryParse((string)W3vX4RTZYS4pjsppw7F(xmlReader), out result2);
					num2 = 4;
					continue;
				default:
					xmlReader.Read();
					num2 = 22;
					continue;
				case 25:
					vc7nkDTlo9rqslB46iR(xmlReader);
					num2 = 15;
					continue;
				case 12:
					title = (string)W3vX4RTZYS4pjsppw7F(xmlReader);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8ed00be219534188ad23e215449e3f62 != 0)
					{
						num2 = 0;
					}
					continue;
				case 18:
					yDTl5tTuaCXmDEFRmyt(xmlReader);
					num2 = 20;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_427a79594804461da96485ca77914e7b == 0)
					{
						num2 = 7;
					}
					continue;
				case 29:
					if (!Qk0bqZcCX3HnRMFhGCQ(result2, default(Guid)))
					{
						return;
					}
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0b98e2160a714197bf0d3d74d55d90bc == 0)
					{
						num2 = 24;
					}
					continue;
				case 26:
					yDTl5tTuaCXmDEFRmyt(xmlReader);
					num2 = 13;
					continue;
				case 4:
					yDTl5tTuaCXmDEFRmyt(xmlReader);
					num2 = 17;
					continue;
				case 10:
				case 17:
				case 22:
					JYeJ1gcEeoRHLMPfbqW(xmlReader);
					num2 = 11;
					continue;
				case 28:
					title = "";
					num = 18;
					break;
				case 5:
				case 7:
					if (xmlReader.NodeType == XmlNodeType.EndElement)
					{
						num = 29;
						break;
					}
					goto case 27;
				}
				break;
			}
		}
	}

	public CustomActivityHeaderImportSaveActions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dilYBTc3WjPNDdN2olg();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_cc6425824e2145d58580462376bc9992 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static CustomActivityHeaderImportSaveActions()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				UID = new Guid((string)kQ7ws8Trce6Pogk7vA6(0x927D360 ^ 0x927ABA4));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b9495424a4ef4f809c30bcc362ac3faa != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			default:
				ImportLog = (ILogger)LYp79JchGD76mrxGrkx(kQ7ws8Trce6Pogk7vA6(-138431307 ^ -138424923));
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1b80284ddf044221848555b8c08e8f67 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				dilYBTc3WjPNDdN2olg();
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_140e6a1eacec422f932ef627eb6c4c16 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool oyQiCcTHMwD7pFym0Ca(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool p93lMdTBk80kyXPhqTr()
	{
		return H7fN0DT0EG3qJs0D3dl == null;
	}

	internal static CustomActivityHeaderImportSaveActions eIjHSYTWZjpOxF9Ukfm()
	{
		return H7fN0DT0EG3qJs0D3dl;
	}

	internal static object jI7n3cTe6S368sQZP7E(object P_0)
	{
		return ((ImportTestReadData)P_0).ConfigImportSettings;
	}

	internal static object Dukq6PTieJAe1KgvwyK(object P_0)
	{
		return ((ImportTestReadData)P_0).Reader;
	}

	internal static bool yDTl5tTuaCXmDEFRmyt(object P_0)
	{
		return ((XmlReader)P_0).Read();
	}

	internal static bool vc7nkDTlo9rqslB46iR(object P_0)
	{
		return ((XmlReader)P_0).MoveToElement();
	}

	internal static bool ocuhWuTfG8g8dOISYfP(object P_0)
	{
		return ((XmlReader)P_0).IsStartElement();
	}

	internal static object yGkyeqTLs6eMOYZGPkj(object P_0)
	{
		return ((XmlReader)P_0).Name;
	}

	internal static Type CDVDw0TJF8jm9sbgbgj(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object kQ7ws8Trce6Pogk7vA6(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object m9jGIeT7TjAro67ZhiH(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object eyReOkT5IHXaaCqT0qM(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object LFCeUVTgVNNdfOSuMSO(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static bool aXOZoPT1jaBneUD3Um6(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool JH1AFUTILycDMQQT7ed(object P_0)
	{
		return ((XmlReader)P_0).IsEmptyElement;
	}

	internal static object W3vX4RTZYS4pjsppw7F(object P_0)
	{
		return ((XmlReader)P_0).ReadString();
	}

	internal static object MLjYG5TzenfrCumwwGV(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static void JYeJ1gcEeoRHLMPfbqW(object P_0)
	{
		((XmlReader)P_0).Skip();
	}

	internal static bool Qk0bqZcCX3HnRMFhGCQ(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object lfBWPlcX0snvCPfOs2f(object P_0)
	{
		return ((IConfigImportSettings)P_0).FakeManifest;
	}

	internal static object bxfewicop7Xyhu64ydY(object P_0, Guid P_1, object P_2)
	{
		return ((BPMAppFakeManifest)P_0).GetOrCreateChapterByUid(P_1, (string)P_2);
	}

	internal static void dilYBTc3WjPNDdN2olg()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static object LYp79JchGD76mrxGrkx(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
