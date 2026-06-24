using System;
using System.Collections.Generic;
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
using EleWise.ELMA.Model.Scripts.Deploy.Export;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts.Deploy.Import;

public class ScriptModuleImportSaveActions : EntityImportSaveActions
{
	public static readonly Guid UID;

	internal static ScriptModuleImportSaveActions WOM9iWbXnrL1jVXA22tF;

	public override bool IsSupported(Guid typeGuid)
	{
		return biiUGSbXeZbZECT4I8Xb(typeGuid, UID);
	}

	public override bool CanBeSaved(Dictionary<string, object> propValues, ImportEntityCanBeSavedData data)
	{
		if (propValues == null)
		{
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A6C7A9))));
			return false;
		}
		Locator.GetServiceNotNull<GlobalScriptModuleHeaderManager>();
		if (string.IsNullOrWhiteSpace(propValues.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488886261)) ? propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576138140)].ToString() : null))
		{
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195585241))));
			return false;
		}
		Guid result = Guid.Empty;
		if (propValues.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576141258)) && propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63ABCB7A)] != null)
		{
			Guid.TryParse(propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521243694)].ToString(), out result);
		}
		if (result == Guid.Empty)
		{
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951469270))));
			return false;
		}
		return true;
	}

	public override List<TestImportMessages> ExecPreSaveActions(IEntity entity, ImportEntityPreSaveData data)
	{
		if (!(entity is IGlobalScriptModuleHeader))
		{
			Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C9657EC));
			return new List<TestImportMessages>
			{
				new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE3B879)))
			};
		}
		return new List<TestImportMessages>();
	}

	public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
	{
		//Discarded unreachable code: IL_00c9, IL_00f9, IL_0108, IL_0118, IL_0127, IL_015a, IL_0169, IL_0211, IL_03b1, IL_03c0, IL_0406
		int num = 1;
		XmlReader reader = default(XmlReader);
		Guid result2 = default(Guid);
		string title = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 16:
					JymLSnbXPg8sCqOSDPr9(reader);
					num2 = 13;
					continue;
				case 5:
					reader = data.Reader;
					num2 = 22;
					continue;
				case 3:
				case 10:
				case 25:
					ONLecUbXAIwIfVnpXuo1(reader);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 26;
					}
					continue;
				case 22:
					result2 = Guid.Empty;
					num2 = 12;
					continue;
				case 20:
					JymLSnbXPg8sCqOSDPr9(reader);
					num2 = 19;
					continue;
				case 28:
				{
					object obj = hwJ3mxbX3lbOBPIMNS82(reader);
					ParameterExpression parameterExpression = (ParameterExpression)f2Ls8wbXDhi59bOCMoXJ(typeof(IGlobalScriptModuleHeader), pgCS4ZbXaBWoVy8sEIRq(0x48A7E34A ^ 0x48A599E4));
					if ((string)obj == LinqUtils.NameOf(Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>((Expression)M8I5arbX6NqLnLPKJpw1(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), j2AstjbXpyA4eCjdtU8j(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression })))
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 3;
				}
				case 26:
					wtgmErbX7m3np1G3mtO3(reader);
					num2 = 29;
					continue;
				case 0:
					return;
				case 31:
					Guid.TryParse((string)EB6F0bbX4KpSuErNOktU(reader), out result2);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 27;
					}
					continue;
				case 15:
					JymLSnbXPg8sCqOSDPr9(reader);
					num2 = 10;
					continue;
				case 27:
					JymLSnbXPg8sCqOSDPr9(reader);
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 17;
					}
					continue;
				case 18:
				case 29:
					if (FCC479bXxke4lkkmA9Wt(reader) == XmlNodeType.EndElement)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 11;
				case 6:
				case 8:
				case 9:
				case 21:
					if (PeI5ILbXNv5KydoaxNkT(reader))
					{
						num2 = 28;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num2 = 23;
						}
						continue;
					}
					goto case 3;
				case 14:
					if (LMkKuBbXHYuoq3jF1V7J(reader))
					{
						num2 = 3;
						continue;
					}
					break;
				case 17:
					return;
				case 24:
					title = (string)EB6F0bbX4KpSuErNOktU(reader);
					num2 = 15;
					continue;
				case 11:
					if (!PeI5ILbXNv5KydoaxNkT(reader))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 23;
				case 13:
					rqJMGEbX1QC6DZ0OMFJi(reader);
					num2 = 20;
					continue;
				case 32:
					if (reader.IsEmptyElement)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 4;
				case 7:
					((BPMAppFakeManifest)uhxsZtbXmslnQUxHlVmt(data.ConfigImportSettings)).GetOrCreateChapterByUid(ScriptModuleExportConsts.ExportExtensionUid, "").GetOrCreateItemByUid(result2, title);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 17;
					}
					continue;
				case 2:
					if (!sR5IjWbX0gx0AjubcsUM(result2, default(Guid)))
					{
						return;
					}
					num2 = 7;
					continue;
				case 1:
					if (data.ConfigImportSettings == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 12:
					title = "";
					num2 = 16;
					continue;
				case 23:
				{
					object obj2 = hwJ3mxbX3lbOBPIMNS82(reader);
					ParameterExpression parameterExpression = (ParameterExpression)f2Ls8wbXDhi59bOCMoXJ(j2AstjbXpyA4eCjdtU8j(typeof(IGlobalScriptModuleHeader).TypeHandle), pgCS4ZbXaBWoVy8sEIRq(-740338220 ^ -740479110));
					if (!((string)obj2 == LinqUtils.NameOf(Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>((Expression)XKMhCebXw23Jora9rTim(parameterExpression, (MethodInfo)opeILsbXtl7sy4Fo6A4Z((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }))))
					{
						goto end_IL_0012;
					}
					goto case 32;
				}
				case 19:
					reader.MoveToElement();
					num2 = 18;
					continue;
				case 4:
					rqJMGEbX1QC6DZ0OMFJi(reader);
					num2 = 24;
					continue;
				case 30:
					break;
				}
				rqJMGEbX1QC6DZ0OMFJi(reader);
				num2 = 31;
				continue;
				end_IL_0012:
				break;
			}
			num = 21;
		}
	}

	public ScriptModuleImportSaveActions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		yRaIGLbXyWAD2ZlFRM0Y();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ScriptModuleImportSaveActions()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				UID = new Guid((string)pgCS4ZbXaBWoVy8sEIRq(0x1A33FE36 ^ 0x1A313D84));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				yRaIGLbXyWAD2ZlFRM0Y();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool biiUGSbXeZbZECT4I8Xb(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool x3rhl2bXOONY3RqO7YOv()
	{
		return WOM9iWbXnrL1jVXA22tF == null;
	}

	internal static ScriptModuleImportSaveActions ki1VDkbX2uxeXh8H7gcN()
	{
		return WOM9iWbXnrL1jVXA22tF;
	}

	internal static bool JymLSnbXPg8sCqOSDPr9(object P_0)
	{
		return ((XmlReader)P_0).Read();
	}

	internal static bool rqJMGEbX1QC6DZ0OMFJi(object P_0)
	{
		return ((XmlReader)P_0).MoveToElement();
	}

	internal static bool PeI5ILbXNv5KydoaxNkT(object P_0)
	{
		return ((XmlReader)P_0).IsStartElement();
	}

	internal static object hwJ3mxbX3lbOBPIMNS82(object P_0)
	{
		return ((XmlReader)P_0).Name;
	}

	internal static Type j2AstjbXpyA4eCjdtU8j(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object pgCS4ZbXaBWoVy8sEIRq(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object f2Ls8wbXDhi59bOCMoXJ(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object opeILsbXtl7sy4Fo6A4Z(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object XKMhCebXw23Jora9rTim(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object EB6F0bbX4KpSuErNOktU(object P_0)
	{
		return ((XmlReader)P_0).ReadString();
	}

	internal static object M8I5arbX6NqLnLPKJpw1(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static bool LMkKuBbXHYuoq3jF1V7J(object P_0)
	{
		return ((XmlReader)P_0).IsEmptyElement;
	}

	internal static void ONLecUbXAIwIfVnpXuo1(object P_0)
	{
		((XmlReader)P_0).Skip();
	}

	internal static XmlNodeType wtgmErbX7m3np1G3mtO3(object P_0)
	{
		return ((XmlReader)P_0).MoveToContent();
	}

	internal static XmlNodeType FCC479bXxke4lkkmA9Wt(object P_0)
	{
		return ((XmlReader)P_0).NodeType;
	}

	internal static bool sR5IjWbX0gx0AjubcsUM(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object uhxsZtbXmslnQUxHlVmt(object P_0)
	{
		return ((IConfigImportSettings)P_0).FakeManifest;
	}

	internal static void yRaIGLbXyWAD2ZlFRM0Y()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
