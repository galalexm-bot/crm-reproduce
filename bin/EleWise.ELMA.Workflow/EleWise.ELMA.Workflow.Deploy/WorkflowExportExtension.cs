using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Plugins;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.SubProcess;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Models.Regulation;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Deploy;

[Component(Order = 300)]
public class WorkflowExportExtension : IConfigExportExtension
{
	private ExportRuleBuilder<IProcessHeader> customExportRuleBuilder;

	internal static WorkflowExportExtension NO8AdW4L9e5dhyHH51k;

	public Dictionary<Guid, object> GetNewSettingObj()
	{
		return new Dictionary<Guid, object> { 
		{
			WorkflowExportConsts.ExportExtensionUid,
			new WorkflowExportSetting()
		} };
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
				AddExportObjectsCustom(parameters.Parameters, parameters.ServiceData, parameters.PacketEntities, parameters.FormExportData, parameters);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				AddCustomRules();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static string GetViewNamePrefix(ProcessContext context)
	{
		return (string)alMsdc4jGeSyZ7YUQfh(EMiyhN4Wlx1Z51JiQae(0x747FFBE0 ^ 0x747E9EC8), context.Name, EMiyhN4Wlx1Z51JiQae(-1001967776 ^ -1002026454));
	}

	private void AddExportObjectsCustom(Dictionary<Guid, object> parameters, Dictionary<string, object> serviceData, List<PacketEntity> packetEntities, List<FormExportData> formExportData, ExportExtensionParams exportParameters)
	{
		if (!(parameters[WorkflowExportConsts.ExportExtensionUid] is WorkflowExportSetting workflowExportSetting) || !workflowExportSetting.ExportProcesses)
		{
			return;
		}
		ProcessHeaderManager serviceNotNull = Locator.GetServiceNotNull<ProcessHeaderManager>();
		List<IProcessHeader> list = new List<IProcessHeader>();
		HashSet<Guid> hashSet = new HashSet<Guid>();
		foreach (long processesId in workflowExportSetting.ProcessesIds)
		{
			IProcessHeader processHeader = serviceNotNull.Load(processesId);
			list.Add(processHeader);
			hashSet.Add(processHeader.Uid);
		}
		foreach (Guid processesUid in workflowExportSetting.ProcessesUids)
		{
			if (!hashSet.Contains(processesUid))
			{
				IProcessHeader processHeader2 = serviceNotNull.Load(processesUid);
				list.Add(processHeader2);
				hashSet.Add(processHeader2.Uid);
			}
		}
		AddProcesses(packetEntities, list, serviceData, formExportData, exportParameters);
	}

	private void AddCustomRules()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				customExportRuleBuilder = new ExportRuleBuilder<IProcessHeader>(new ExportRuleList());
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
			{
				ExportRuleBuilderSelectType<IProcessHeader> exportRuleBuilderSelectType10 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = (ParameterExpression)nYKyPM4Rd1ETNOune8l(mUYaY343MiD5UuimxLh(typeof(IProcessHeader).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-17847711 ^ -17903823));
				kE1Kw34qEo15ZKCHXi5(exportRuleBuilderSelectType10.ForPropertyName(Expression.Lambda<Func<IProcessHeader, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
				{
					num2 = 9;
				}
				break;
			}
			case 5:
			{
				ExportRuleBuilderSelectType<IProcessHeader> exportRuleBuilderSelectType8 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = (ParameterExpression)nYKyPM4Rd1ETNOune8l(mUYaY343MiD5UuimxLh(typeof(IProcessHeader).TypeHandle), EMiyhN4Wlx1Z51JiQae(0xB7793C9 ^ 0xB76F699));
				exportRuleBuilderSelectType8.ForPropertyName(Expression.Lambda<Func<IProcessHeader, object>>((Expression)buT1AN4TYl7p44ffCVy(parameterExpression, (MethodInfo)b49XmR46XfFSAHXTaMM((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).Ignore();
				num2 = 3;
				break;
			}
			case 6:
			{
				ExportRuleBuilderSelectType<IProcessHeader> exportRuleBuilderSelectType7 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = (ParameterExpression)nYKyPM4Rd1ETNOune8l(typeof(IWorkflowProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1361036319 ^ -1360961871));
				kE1Kw34qEo15ZKCHXi5(exportRuleBuilderSelectType7.ForPropertyName(Expression.Lambda<Func<IWorkflowProcess, object>>(Expression.Property(parameterExpression, (MethodInfo)b49XmR46XfFSAHXTaMM((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				num2 = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
				{
					num2 = 10;
				}
				break;
			}
			case 8:
			{
				ExportRuleBuilderSelectType<IProcessHeader> exportRuleBuilderSelectType4 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = (ParameterExpression)nYKyPM4Rd1ETNOune8l(mUYaY343MiD5UuimxLh(typeof(IProcessHeader).TypeHandle), EMiyhN4Wlx1Z51JiQae(-432000546 ^ -431926130));
				kE1Kw34qEo15ZKCHXi5(exportRuleBuilderSelectType4.ForPropertyName(Expression.Lambda<Func<IProcessHeader, object>>((Expression)buT1AN4TYl7p44ffCVy(parameterExpression, (MethodInfo)b49XmR46XfFSAHXTaMM((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				num2 = 5;
				break;
			}
			case 11:
			{
				ExportRuleBuilderSelectType<IProcessHeader> exportRuleBuilderSelectType9 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = (ParameterExpression)nYKyPM4Rd1ETNOune8l(typeof(IWorkflowProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-682910880 ^ -682951120));
				exportRuleBuilderSelectType9.ForPropertyName(Expression.Lambda<Func<IWorkflowProcess, object>>((Expression)buT1AN4TYl7p44ffCVy(parameterExpression, (MethodInfo)b49XmR46XfFSAHXTaMM((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).ExportDeep();
				num2 = 12;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
				{
					num2 = 0;
				}
				break;
			}
			default:
				kE1Kw34qEo15ZKCHXi5(customExportRuleBuilder.Rule().ForPropertyName(InterfaceActivator.TypeOf<ScriptModule>(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965291699 ^ -1965202743)));
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
				{
					num2 = 14;
				}
				break;
			case 10:
				Lch7KR4QXfPruBRUvfg(customExportRuleBuilder.Rule().ForPropertyName(InterfaceActivator.TypeOf<IWorkflowProcess>(), (string)EMiyhN4Wlx1Z51JiQae(-45832783 ^ -45760279)));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
				{
					num2 = 0;
				}
				break;
			case 14:
				kE1Kw34qEo15ZKCHXi5(customExportRuleBuilder.Rule().ForPropertyName(InterfaceActivator.TypeOf<ScriptModule>(), (string)EMiyhN4Wlx1Z51JiQae(-1776305410 ^ -1776361620)));
				num2 = 4;
				break;
			case 4:
				return;
			case 12:
			{
				ExportRuleBuilderSelectType<IProcessHeader> exportRuleBuilderSelectType6 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = Expression.Parameter(mUYaY343MiD5UuimxLh(typeof(IWorkflowProcess).TypeHandle), (string)EMiyhN4Wlx1Z51JiQae(-801808857 ^ -801883273));
				Lch7KR4QXfPruBRUvfg(exportRuleBuilderSelectType6.ForPropertyName(Expression.Lambda<Func<IWorkflowProcess, object>>(Expression.Property(parameterExpression, (MethodInfo)b49XmR46XfFSAHXTaMM((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
				{
					num2 = 2;
				}
				break;
			}
			case 13:
			{
				ExportRuleBuilderSelectType<IProcessHeader> exportRuleBuilderSelectType5 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = (ParameterExpression)nYKyPM4Rd1ETNOune8l(mUYaY343MiD5UuimxLh(typeof(IProcessHeader).TypeHandle), EMiyhN4Wlx1Z51JiQae(-1895853023 ^ -1895894671));
				exportRuleBuilderSelectType5.ForPropertyName(Expression.Lambda<Func<IProcessHeader, object>>((Expression)buT1AN4TYl7p44ffCVy(parameterExpression, (MethodInfo)b49XmR46XfFSAHXTaMM((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).Ignore();
				num2 = 11;
				break;
			}
			case 1:
			{
				ExportRuleBuilderSelectType<IProcessHeader> exportRuleBuilderSelectType3 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = (ParameterExpression)nYKyPM4Rd1ETNOune8l(typeof(IProcessHeader), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-148495695 ^ -148420639));
				kE1Kw34qEo15ZKCHXi5(exportRuleBuilderSelectType3.ForPropertyName(Expression.Lambda<Func<IProcessHeader, object>>(Expression.Property(parameterExpression, (MethodInfo)b49XmR46XfFSAHXTaMM((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
				{
					num2 = 7;
				}
				break;
			}
			case 9:
			{
				ExportRuleBuilderSelectType<IProcessHeader> exportRuleBuilderSelectType2 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = (ParameterExpression)nYKyPM4Rd1ETNOune8l(mUYaY343MiD5UuimxLh(typeof(IProcessHeader).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75872B6 ^ 0x75917E6));
				kE1Kw34qEo15ZKCHXi5(exportRuleBuilderSelectType2.ForPropertyName(Expression.Lambda<Func<IProcessHeader, object>>((Expression)buT1AN4TYl7p44ffCVy(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				num2 = 13;
				break;
			}
			case 7:
			{
				ExportRuleBuilderSelectType<IProcessHeader> exportRuleBuilderSelectType = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = (ParameterExpression)nYKyPM4Rd1ETNOune8l(mUYaY343MiD5UuimxLh(typeof(IProcessHeader).TypeHandle), EMiyhN4Wlx1Z51JiQae(-14356676 ^ -14316948));
				Lch7KR4QXfPruBRUvfg(exportRuleBuilderSelectType.ForPropertyName(Expression.Lambda<Func<IProcessHeader, object>>((Expression)buT1AN4TYl7p44ffCVy(parameterExpression, (MethodInfo)b49XmR46XfFSAHXTaMM((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				num2 = 8;
				break;
			}
			}
		}
	}

	private List<IEntity> GetEntities(IProcessHeader header)
	{
		ExportHelperBuilder<IProcessHeader> exportHelperBuilder = ExportHelperBuilder.Create(header);
		exportHelperBuilder.ExportRuleList = customExportRuleBuilder.ExportRules;
		return exportHelperBuilder.EntityExportList();
	}

	private void AddProcesses(List<PacketEntity> packetEntities, List<IProcessHeader> headers, Dictionary<string, object> serviceData, List<FormExportData> formExportData, ExportExtensionParams parameters)
	{
		foreach (IProcessHeader header in headers)
		{
			List<IEntity> list = AddSubEntities(header, formExportData, serviceData);
			PacketEntity packetEntity = new PacketEntity(header);
			packetEntity.ExportRules = customExportRuleBuilder.ExportRules;
			packetEntity.SubEntities.AddRange(list);
			IEnumerable<IProcessHeader> enumerable = list.OfType<IProcessHeader>();
			Dictionary<Guid, IRegulationResourceType> dictionary = new Dictionary<Guid, IRegulationResourceType>();
			IEntityManager<IRegulationResourceType> instance = EntityManager<IRegulationResourceType>.Instance;
			foreach (IProcessHeader item in enumerable)
			{
				if (item.Current == null || item.Current.Regulation == null || item.Current.Regulation.Resources == null)
				{
					continue;
				}
				foreach (RegulationResource resource in item.Current.Regulation.Resources)
				{
					if (resource != null && !dictionary.ContainsKey(resource.ResourceType))
					{
						IRegulationResourceType regulationResourceType = instance.LoadOrNull(resource.ResourceType);
						if (regulationResourceType != null)
						{
							dictionary.Add(resource.ResourceType, regulationResourceType);
						}
					}
				}
			}
			if (dictionary.Any())
			{
				packetEntity.SubEntities.AddRange(dictionary.Values);
			}
			packetEntities.Add(packetEntity);
			foreach (IProcessHeader item2 in enumerable)
			{
				if (item2.Current != null && item2.Current.Diagram != null && item2.Current.Diagram.Elements != null)
				{
					foreach (InternalSubprocessElement item3 in item2.Current.Diagram.Elements.OfType<InternalSubprocessElement>())
					{
						long processHeaderId = item3.ProcessHeaderId;
						IProcessHeader processHeader = ProcessHeaderManager.Instance.LoadOrNull(processHeaderId);
						if (processHeader != null)
						{
							string key = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105863102 ^ -105787924), processHeader.Id);
							if (!serviceData.ContainsKey(key))
							{
								serviceData.Add(key, processHeader.Uid);
							}
							key = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2111219045 ^ -2111291579), processHeader.Uid);
							if (!serviceData.ContainsKey(key))
							{
								serviceData.Add(key, processHeader.Id);
							}
							key = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716570436), processHeader.Uid, item3.Uid);
							if (!serviceData.ContainsKey(key))
							{
								serviceData.Add(key, string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1756698829 ^ 0x68B47E9D), processHeader.Id, item2.Uid));
							}
						}
					}
				}
				if (item2.Current != null && item2.Current.Diagram != null && item2.Current.Diagram.Elements != null)
				{
					foreach (ExternalSubprocessElement item4 in item2.Current.Diagram.Elements.OfType<ExternalSubprocessElement>())
					{
						long processHeaderId2 = item4.ProcessHeaderId;
						IProcessHeader processHeader2 = ProcessHeaderManager.Instance.LoadOrNull(processHeaderId2);
						if (processHeader2 != null)
						{
							string key2 = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2111219045 ^ -2111291595), processHeader2.Id);
							if (!serviceData.ContainsKey(key2))
							{
								serviceData.Add(key2, processHeader2.Uid);
							}
							key2 = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1393899982 ^ -1393843220), processHeader2.Uid);
							if (!serviceData.ContainsKey(key2))
							{
								serviceData.Add(key2, processHeader2.Id);
							}
							key2 = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-135674354 ^ -135749602), processHeader2.Uid, item4.Uid);
							if (!serviceData.ContainsKey(key2))
							{
								serviceData.Add(key2, string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720382157), processHeader2.Id, item2.Uid));
							}
						}
					}
				}
				if (item2.Current == null || item2.Current.Diagram == null || item2.Current.Diagram.Elements == null)
				{
					continue;
				}
				foreach (DocumentGenerationElement item5 in item2.Current.Diagram.Elements.OfType<DocumentGenerationElement>())
				{
					if (item5 == null || item5.Templates == null)
					{
						continue;
					}
					foreach (DocumentGenerationTemplateInfo template in item5.Templates)
					{
						if (template.DocumentId.HasValue && template.DocumentId.HasValue)
						{
							IDocument document = DocumentManager.Instance.LoadOrNull(template.DocumentId.Value);
							if (document == null || !(document.Uid != Guid.Empty))
							{
								continue;
							}
							string key3;
							if (document.CurrentVersion != null && document.CurrentVersion.File != null)
							{
								IFileManager serviceNotNull = Locator.GetServiceNotNull<IFileManager>();
								BinaryFile binaryFile;
								try
								{
									binaryFile = serviceNotNull.LoadFile(document.CurrentVersion.File.Id);
								}
								catch (Exception)
								{
									binaryFile = null;
								}
								if (binaryFile != null && binaryFile.Uid != Guid.Empty)
								{
									key3 = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7381F16B ^ 0x73809709), binaryFile.Uid.ToString(), document.CurrentVersion.File.Id);
									if (!serviceData.ContainsKey(key3))
									{
										serviceData.Add(key3, 2);
									}
									key3 = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51EF0063 ^ 0x51EE66ED), document.Uid);
									if (!serviceData.ContainsKey(key3))
									{
										serviceData.Add(key3, binaryFile.Uid.ToString());
									}
								}
							}
							key3 = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712584311), template.DocumentId);
							if (!serviceData.ContainsKey(key3))
							{
								serviceData.Add(key3, document.Uid);
							}
						}
						else
						{
							if (string.IsNullOrWhiteSpace(template.TemplateFileId))
							{
								continue;
							}
							IFileManager serviceNotNull2 = Locator.GetServiceNotNull<IFileManager>();
							BinaryFile binaryFile2;
							try
							{
								binaryFile2 = serviceNotNull2.LoadFile(template.TemplateFileId);
							}
							catch (Exception)
							{
								binaryFile2 = null;
							}
							if (binaryFile2 != null && binaryFile2.Uid != Guid.Empty)
							{
								string key3 = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495241066), binaryFile2.Uid.ToString(), template.TemplateFileId);
								if (!serviceData.ContainsKey(key3))
								{
									serviceData.Add(key3, 2);
								}
							}
						}
					}
				}
			}
			foreach (IProcessHeader item6 in enumerable.Where((IProcessHeader ph) => _003C_003Ec.dEt8v4ZSKZ3dYXhT593p(ph) != null))
			{
				ExportFormDependencyHelper.AddFormDependenciesInfo(item6.Current.Uid, item6.Name, serviceData);
			}
			if (header.ParentGroup != null)
			{
				string key4 = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351281080), header.Uid.ToString().ToLower(), header.ParentGroup.Uid.ToString().ToLower());
				if (!serviceData.ContainsKey(key4))
				{
					serviceData.Add(key4, header.ParentGroup.Name);
				}
				AddGroupToServiceData(header.ParentGroup, ref serviceData);
			}
		}
	}

	private void AddGroupToServiceData(IProcessGroup group, ref Dictionary<string, object> serviceData)
	{
		//Discarded unreachable code: IL_007c, IL_00c6, IL_00d5
		int num = 4;
		string key = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
				case 7:
					AddGroupToServiceData((IProcessGroup)riw79t4pWLpZIoFEB0s(group), ref serviceData);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
					{
						num2 = 2;
					}
					continue;
				case 4:
					if (group == null)
					{
						num2 = 3;
						continue;
					}
					break;
				case 5:
					if (serviceData.ContainsKey(key))
					{
						num2 = 7;
						continue;
					}
					goto end_IL_0012;
				case 2:
					return;
				case 3:
					return;
				case 8:
					goto end_IL_0012;
				case 1:
					key = (string)Eu1soQ4kdFOJQIfvjf5(EMiyhN4Wlx1Z51JiQae(0x8D5763A ^ 0x8D41178), vj2GZx4MmRTMYti9gQv(QeXPO04CpcsP0bdFS9X(group).ToString()), vj2GZx4MmRTMYti9gQv(QeXPO04CpcsP0bdFS9X(group.Parent).ToString()));
					num2 = 5;
					continue;
				}
				if (riw79t4pWLpZIoFEB0s(group) == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			serviceData.Add(key, BQoKFh4UnicPy9xEjTn(group.Parent));
			num = 6;
		}
	}

	private List<IEntity> AddSubEntities(IProcessHeader header, List<FormExportData> formExportData, Dictionary<string, object> serviceData)
	{
		List<IEntity> list = new List<IEntity>();
		if (header.Parent == null || header.Status != WorkflowProcessStatus.Deleted)
		{
			foreach (IEntity entity in GetEntities(header))
			{
				_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
				if (!list.Contains(entity))
				{
					list.Add(entity);
				}
				CS_0024_003C_003E8__locals0.workflowProcess = entity as IWorkflowProcess;
				if (CS_0024_003C_003E8__locals0.workflowProcess == null)
				{
					continue;
				}
				formExportData.Add(new FormExportData
				{
					EntityName = CS_0024_003C_003E8__locals0.workflowProcess.Name,
					FormViewItemTransformations = CS_0024_003C_003E8__locals0.workflowProcess.Forms.Items.Select((WorkflowForm i) => new Pair<FormViewItemTransformation, FormViewItem>(((IFormViewItemTransformation)i).Transformation, i.CreateFormViewItem(CS_0024_003C_003E8__locals0.workflowProcess))).ToArray(),
					ViewNamePrefix = GetViewNamePrefix(CS_0024_003C_003E8__locals0.workflowProcess.Context),
					FormViews = CS_0024_003C_003E8__locals0.workflowProcess.Diagram.Elements.OfType<UserTaskElement>().Select(delegate(UserTaskElement e)
					{
						//Discarded unreachable code: IL_00bc
						int num = 3;
						FormView formView = default(FormView);
						while (true)
						{
							int num2 = num;
							while (true)
							{
								object obj;
								switch (num2)
								{
								case 3:
									if (_003C_003Ec.YoCobBZSO8jJIhF591Eg(e) == null)
									{
										num2 = 2;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
										{
											num2 = 2;
										}
										continue;
									}
									obj = _003C_003Ec.zc6eHEZSZHnNgXX9eDeu(_003C_003Ec.YoCobBZSO8jJIhF591Eg(e)) as FormView;
									goto IL_00ea;
								case 4:
									_003C_003Ec.bgGAYqZSl43DfU4BIXkS(formView, _003C_003Ec.x0p7bvZSJWtgywgqUmTU(_003C_003Ec.RGmnNPZSYXmTeMW7xlwQ(0x7AC609FE ^ 0x7AC4DC8E), new object[2]
									{
										_003C_003Ec.BLXDeSZS8eG3gewOaGun(e),
										_003C_003Ec.zUAasnZSst3l0hCpsAao(e)
									}));
									num2 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
									{
										num2 = 0;
									}
									continue;
								case 2:
									obj = new FormView();
									goto IL_00ea;
								case 5:
									break;
								case 1:
									return formView;
								default:
									{
										_003C_003Ec.aAj8byZSyHGedimw9K7S(formView, (_003C_003Ec.SV8acAZS0wQL7ink28jx(e) != null) ? ((UserTaskFormSettings)_003C_003Ec.SV8acAZS0wQL7ink28jx(e)).CustomViewName : null);
										num2 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
										{
											num2 = 1;
										}
										continue;
									}
									IL_00ea:
									formView = (FormView)obj;
									num2 = 5;
									continue;
								}
								break;
							}
							_003C_003Ec.eJh39BZSvhsUAhIvcJiH(formView, true);
							num = 4;
						}
					}).ToArray()
				});
				if (CS_0024_003C_003E8__locals0.workflowProcess.ScriptModule == null || CS_0024_003C_003E8__locals0.workflowProcess.ScriptModule.LocalReferences == null)
				{
					continue;
				}
				foreach (AssemblyReference localReference in CS_0024_003C_003E8__locals0.workflowProcess.ScriptModule.LocalReferences)
				{
					IExternalAssembly externalAssembly = ExternalAssemblyManager.Instance.LoadOrNull(localReference.Uid);
					if (externalAssembly != null)
					{
						list.Insert(0, externalAssembly);
					}
				}
			}
			{
				foreach (IProcessHeader item in (IEnumerable<IProcessHeader>)header.SubHeaders)
				{
					if (item.Status != WorkflowProcessStatus.Deleted)
					{
						list.AddRange(AddSubEntities(item, formExportData, serviceData));
						continue;
					}
					string key = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x361628FF ^ 0x36174F73), header.Uid, item.Uid);
					if (!serviceData.ContainsKey(key))
					{
						serviceData.Add(key, item.Uid);
					}
				}
				return list;
			}
		}
		return list;
	}

	public WorkflowExportExtension()
	{
		//Discarded unreachable code: IL_003f, IL_0044
		fIUkkC4VNt8Z2D9KyEh();
		customExportRuleBuilder = new ExportRuleBuilder<IProcessHeader>(new ExportRuleList());
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool rH6u024fMWvTxFdnhci()
	{
		return NO8AdW4L9e5dhyHH51k == null;
	}

	internal static WorkflowExportExtension mBGMlU498vTOB8e0JNW()
	{
		return NO8AdW4L9e5dhyHH51k;
	}

	internal static object EMiyhN4Wlx1Z51JiQae(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object alMsdc4jGeSyZ7YUQfh(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object nYKyPM4Rd1ETNOune8l(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object b49XmR46XfFSAHXTaMM(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static void kE1Kw34qEo15ZKCHXi5(object P_0)
	{
		((ExportRuleBuilderSelectAction<IProcessHeader>)P_0).Ignore();
	}

	internal static Type mUYaY343MiD5UuimxLh(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object buT1AN4TYl7p44ffCVy(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static void Lch7KR4QXfPruBRUvfg(object P_0)
	{
		((ExportRuleBuilderSelectAction<IProcessHeader>)P_0).ExportDeep();
	}

	internal static object riw79t4pWLpZIoFEB0s(object P_0)
	{
		return ((IProcessGroup)P_0).Parent;
	}

	internal static Guid QeXPO04CpcsP0bdFS9X(object P_0)
	{
		return ((IProcessGroup)P_0).Uid;
	}

	internal static object vj2GZx4MmRTMYti9gQv(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static object Eu1soQ4kdFOJQIfvjf5(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object BQoKFh4UnicPy9xEjTn(object P_0)
	{
		return ((IProcessGroup)P_0).Name;
	}

	internal static void fIUkkC4VNt8Z2D9KyEh()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
