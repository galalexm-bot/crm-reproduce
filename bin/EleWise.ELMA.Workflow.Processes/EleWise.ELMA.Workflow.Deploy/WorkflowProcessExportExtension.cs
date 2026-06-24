using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Deploy.Export;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Deploy;

[Component(Order = 350)]
public class WorkflowProcessExportExtension : IConfigExportExtension
{
	private ExportRuleBuilder<ICustomActivityHeader> customExportRuleBuilder;

	internal static WorkflowProcessExportExtension lyhyDU9Ik58iBJqtgV7;

	public Dictionary<Guid, object> GetNewSettingObj()
	{
		return new Dictionary<Guid, object> { 
		{
			CustomActivityExportConsts.ExportExtensionUid,
			new CustomActivityExportSetting()
		} };
	}

	private void AddCustomRules()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
			{
				ExportRuleBuilderSelectType<ICustomActivityHeader> exportRuleBuilderSelectType6 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = (ParameterExpression)olHJUuTCpMhylmX4ctm(typeof(ICustomActivityHeader), yYj89kT3P9gNvWHalqd(0x48FD6D2E ^ 0x48FD1F3C));
				AWTlfvThMCYmlrFcrIY(exportRuleBuilderSelectType6.ForPropertyName(Expression.Lambda<Func<ICustomActivityHeader, object>>((Expression)nQ0EByToZoRiGFAnqsZ(parameterExpression, (MethodInfo)RHul69TXTtpP0rq9oHM((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a154fb56e4e4b63873c2ec8d4e1cbe4 == 0)
				{
					num2 = 1;
				}
				break;
			}
			case 7:
				return;
			case 1:
				customExportRuleBuilder = new ExportRuleBuilder<ICustomActivityHeader>(new ExportRuleList());
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5e3789bc3f974f489e0b5a0c8243b85d == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
			{
				ExportRuleBuilderSelectType<ICustomActivityHeader> exportRuleBuilderSelectType2 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = Expression.Parameter(nb2JlPTEYX7LsXfjeRp(typeof(ICustomActivity).TypeHandle), (string)yYj89kT3P9gNvWHalqd(-1643416224 ^ -1643444366));
				jlYpuSTxVXgwOby1qZD(exportRuleBuilderSelectType2.ForPropertyName(Expression.Lambda<Func<ICustomActivity, object>>((Expression)nQ0EByToZoRiGFAnqsZ(parameterExpression, (MethodInfo)RHul69TXTtpP0rq9oHM((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				num2 = 6;
				break;
			}
			case 6:
			{
				ExportRuleBuilderSelectType<ICustomActivityHeader> exportRuleBuilderSelectType7 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = Expression.Parameter(nb2JlPTEYX7LsXfjeRp(typeof(ICustomActivity).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x60E50EF5 ^ 0x60E57CE7));
				AWTlfvThMCYmlrFcrIY(exportRuleBuilderSelectType7.ForPropertyName(Expression.Lambda<Func<ICustomActivity, object>>((Expression)z6k5wKTF7MRkhdrrT3I(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), nb2JlPTEYX7LsXfjeRp(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression })));
				num2 = 8;
				break;
			}
			default:
			{
				ExportRuleBuilderSelectType<ICustomActivityHeader> exportRuleBuilderSelectType5 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = (ParameterExpression)olHJUuTCpMhylmX4ctm(nb2JlPTEYX7LsXfjeRp(typeof(ICustomActivityHeader).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-92270799 ^ -92242653));
				exportRuleBuilderSelectType5.ForPropertyName(Expression.Lambda<Func<ICustomActivityHeader, object>>((Expression)nQ0EByToZoRiGFAnqsZ(parameterExpression, (MethodInfo)RHul69TXTtpP0rq9oHM((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).ExportDeep();
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 5:
				AWTlfvThMCYmlrFcrIY(customExportRuleBuilder.Rule().ForPropertyName(InterfaceActivator.TypeOf<ScriptModule>(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1803374629 ^ -1803356585)));
				num2 = 7;
				break;
			case 4:
			{
				ExportRuleBuilderSelectType<ICustomActivityHeader> exportRuleBuilderSelectType4 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = (ParameterExpression)olHJUuTCpMhylmX4ctm(nb2JlPTEYX7LsXfjeRp(typeof(ICustomActivity).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x21359E1C ^ 0x2135EC0E));
				AWTlfvThMCYmlrFcrIY(exportRuleBuilderSelectType4.ForPropertyName(Expression.Lambda<Func<ICustomActivity, object>>((Expression)z6k5wKTF7MRkhdrrT3I(nQ0EByToZoRiGFAnqsZ(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), nb2JlPTEYX7LsXfjeRp(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression })));
				num2 = 5;
				break;
			}
			case 2:
			{
				ExportRuleBuilderSelectType<ICustomActivityHeader> exportRuleBuilderSelectType3 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = (ParameterExpression)olHJUuTCpMhylmX4ctm(nb2JlPTEYX7LsXfjeRp(typeof(ICustomActivityHeader).TypeHandle), yYj89kT3P9gNvWHalqd(-182059571 ^ -182087713));
				AWTlfvThMCYmlrFcrIY(exportRuleBuilderSelectType3.ForPropertyName(Expression.Lambda<Func<ICustomActivityHeader, object>>((Expression)nQ0EByToZoRiGFAnqsZ(parameterExpression, (MethodInfo)RHul69TXTtpP0rq9oHM((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				num2 = 9;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5e3789bc3f974f489e0b5a0c8243b85d != 0)
				{
					num2 = 7;
				}
				break;
			}
			case 8:
			{
				ExportRuleBuilderSelectType<ICustomActivityHeader> exportRuleBuilderSelectType = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = (ParameterExpression)olHJUuTCpMhylmX4ctm(typeof(ICustomActivity), yYj89kT3P9gNvWHalqd(-1633140121 ^ -1633144715));
				AWTlfvThMCYmlrFcrIY(exportRuleBuilderSelectType.ForPropertyName(Expression.Lambda<Func<ICustomActivity, object>>((Expression)nQ0EByToZoRiGFAnqsZ(parameterExpression, (MethodInfo)RHul69TXTtpP0rq9oHM((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				num2 = 4;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4756c9eca18a4abd877173fe66f77852 == 0)
				{
					num2 = 4;
				}
				break;
			}
			}
		}
	}

	private List<IEntity> GetEntities(ICustomActivityHeader header)
	{
		ExportHelperBuilder<ICustomActivityHeader> exportHelperBuilder = ExportHelperBuilder.Create(header);
		exportHelperBuilder.ExportRuleList = customExportRuleBuilder.ExportRules;
		return exportHelperBuilder.EntityExportList();
	}

	public void AddExportObjects(ExportExtensionParams parameters)
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
				AddExportObjectsCustom(parameters.Parameters, parameters.ServiceData, parameters.PacketEntities);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_51bbd8978ad84af991914149de98c8c6 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				AddCustomRules();
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c5274b5f82c74d1e8e92ea099532df1e == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void AddExportObjectsCustom(Dictionary<Guid, object> parameters, Dictionary<string, object> serviceData, List<PacketEntity> packetEntities)
	{
		if (parameters[CustomActivityExportConsts.ExportExtensionUid] is CustomActivityExportSetting customActivityExportSetting && customActivityExportSetting.ExportCustomActivity)
		{
			ICollection<ICustomActivityHeader> headers = GetHeaders(customActivityExportSetting);
			AddCAs(packetEntities, headers, serviceData);
		}
	}

	private void AddCAs(List<PacketEntity> packetEntities, ICollection<ICustomActivityHeader> headers, Dictionary<string, object> serviceData)
	{
		foreach (ICustomActivityHeader header in headers)
		{
			PacketEntity packetEntity = new PacketEntity(header);
			packetEntity.ExportRules = customExportRuleBuilder.ExportRules;
			foreach (IEntity entity in GetEntities(header))
			{
				packetEntity.SubEntities.Add(entity);
				if (!(entity is IScriptModule scriptModule) || scriptModule.LocalReferences == null)
				{
					continue;
				}
				foreach (AssemblyReference localReference in scriptModule.LocalReferences)
				{
					IExternalAssembly externalAssembly = ExternalAssemblyManager.Instance.LoadOrNull(localReference.Uid);
					if (externalAssembly != null)
					{
						packetEntity.SubEntities.Insert(0, externalAssembly);
					}
				}
			}
			packetEntities.Add(packetEntity);
			if (header.Folder != null)
			{
				string key = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1535001335 ^ -1534996717), header.Uid.ToString().ToLower(), header.Folder.Uid.ToString().ToLower());
				if (!serviceData.ContainsKey(key))
				{
					serviceData.Add(key, header.Folder.Name);
				}
				AddGroupToServiceData(header.Folder, ref serviceData);
			}
		}
	}

	private void AddGroupToServiceData(ICustomActivityFolder group, ref Dictionary<string, object> serviceData)
	{
		//Discarded unreachable code: IL_00f7, IL_013e, IL_014d
		int num = 8;
		string key = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					key = (string)ukoTXfTs6XVREIG82BU(yYj89kT3P9gNvWHalqd(-275868378 ^ -275847260), WfTwLYTwVqaCln9MMmg(tWAd2YT8vZEJAs3aPgm(group).ToString()), tWAd2YT8vZEJAs3aPgm(swE8F7Tt6ioLLpDtSkX(group)).ToString().ToLower());
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3c90beae50bc45bbb9c4179594d556e4 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					if (serviceData.ContainsKey(key))
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_94abcc9c95ac4ce4baec9537ccf1485a == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 8:
					if (group != null)
					{
						num2 = 7;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3c90beae50bc45bbb9c4179594d556e4 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					return;
				case 5:
					return;
				case 3:
					break;
				case 7:
					if (group.Folder == null)
					{
						num2 = 5;
						continue;
					}
					goto case 6;
				case 1:
					return;
				default:
					AddGroupToServiceData(group.Folder, ref serviceData);
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f44d857a149741d8874c141a12a734dc == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			serviceData.Add(key, GhM2DGT28O6qs1nlIaF(swE8F7Tt6ioLLpDtSkX(group)));
			num = 4;
		}
	}

	private ICollection<ICustomActivityHeader> GetHeaders(CustomActivityExportSetting customActivityExportSetting)
	{
		List<ICustomActivityHeader> list = new List<ICustomActivityHeader>();
		HashSet<Guid> hashSet = new HashSet<Guid>();
		CustomActivityHeaderManager serviceNotNull = Locator.GetServiceNotNull<CustomActivityHeaderManager>();
		if (customActivityExportSetting.CustomActivityIds != null)
		{
			foreach (long customActivityId in customActivityExportSetting.CustomActivityIds)
			{
				ICustomActivityHeader customActivityHeader = serviceNotNull.Load(customActivityId);
				if (customActivityHeader != null)
				{
					list.Add(customActivityHeader);
					hashSet.Add(customActivityHeader.Uid);
				}
			}
		}
		if (customActivityExportSetting.CustomActivityUids != null)
		{
			foreach (Guid customActivityUid in customActivityExportSetting.CustomActivityUids)
			{
				if (!hashSet.Contains(customActivityUid))
				{
					ICustomActivityHeader customActivityHeader2 = serviceNotNull.Load(customActivityUid);
					if (customActivityHeader2 != null)
					{
						list.Add(customActivityHeader2);
						hashSet.Add(customActivityHeader2.Uid);
					}
				}
			}
			return list;
		}
		return list;
	}

	public WorkflowProcessExportExtension()
	{
		//Discarded unreachable code: IL_003f, IL_0044
		vwg2JhTqhU8iAVrQFXf();
		customExportRuleBuilder = new ExportRuleBuilder<ICustomActivityHeader>(new ExportRuleList());
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_71034f51e0444c3592d323fffec09e96 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type nb2JlPTEYX7LsXfjeRp(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object olHJUuTCpMhylmX4ctm(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object RHul69TXTtpP0rq9oHM(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object nQ0EByToZoRiGFAnqsZ(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object yYj89kT3P9gNvWHalqd(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void AWTlfvThMCYmlrFcrIY(object P_0)
	{
		((ExportRuleBuilderSelectAction<ICustomActivityHeader>)P_0).Ignore();
	}

	internal static void jlYpuSTxVXgwOby1qZD(object P_0)
	{
		((ExportRuleBuilderSelectAction<ICustomActivityHeader>)P_0).ExportDeep();
	}

	internal static object z6k5wKTF7MRkhdrrT3I(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static bool opKRfG9ZEJZ7B9em7jI()
	{
		return lyhyDU9Ik58iBJqtgV7 == null;
	}

	internal static WorkflowProcessExportExtension n5kXF79zsCLZvovlYUL()
	{
		return lyhyDU9Ik58iBJqtgV7;
	}

	internal static Guid tWAd2YT8vZEJAs3aPgm(object P_0)
	{
		return ((ICustomActivityFolder)P_0).Uid;
	}

	internal static object WfTwLYTwVqaCln9MMmg(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static object swE8F7Tt6ioLLpDtSkX(object P_0)
	{
		return ((ICustomActivityFolder)P_0).Folder;
	}

	internal static object ukoTXfTs6XVREIG82BU(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object GhM2DGT28O6qs1nlIaF(object P_0)
	{
		return ((ICustomActivityFolder)P_0).Name;
	}

	internal static void vwg2JhTqhU8iAVrQFXf()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
