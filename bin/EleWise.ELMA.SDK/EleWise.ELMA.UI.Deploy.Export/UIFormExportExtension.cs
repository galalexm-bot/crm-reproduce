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
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Deploy.Export;

[Component(Order = 350)]
public class UIFormExportExtension : IConfigExportExtension
{
	private ExportRuleBuilder<IFormMetadataItemHeader> customExportRuleBuilder;

	internal static UIFormExportExtension LyTiYLdSvFRR9g7eh35;

	public Dictionary<Guid, object> GetNewSettingObj()
	{
		return new Dictionary<Guid, object> { 
		{
			UIFormExportConsts.ExportExtensionUid,
			new UIFormExportSetting()
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
			case 2:
				AddCustomRules();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				AddExportObjectsCustom(parameters.Parameters, parameters.ServiceData, parameters.PacketEntities, parameters.FormExportData);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static string GetViewNamePrefix(FormMetadata formMetadata)
	{
		return (string)OIrGV2dKJG8JDfW5lpg(MGqbQOdqLIV0BAcJ4RL(formMetadata));
	}

	internal static string GetViewNamePrefix(string metadataName)
	{
		return (string)by9tCddTsGT6PGXRQfd(pNodA9dXlViMuc22WIc(-882126494 ^ -882148174), metadataName, pNodA9dXlViMuc22WIc(0x53FA00CE ^ 0x53FA649E));
	}

	private void AddCustomRules()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 9:
			{
				ExportRuleBuilderSelectType<IFormMetadataItemHeader> exportRuleBuilderSelectType2 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = (ParameterExpression)n6qrvLdkQXtui78xcvg(PxAnPOd2wEPXjexA26t(typeof(IFormMetadataItem).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477118418));
				BTEtfpdOoPPf0Ku5fC2(exportRuleBuilderSelectType2.ForPropertyName(Expression.Lambda<Func<IFormMetadataItem, object>>((Expression)chpNNRdnwbIsr6j4JhC(parameterExpression, (MethodInfo)nF25WfdehBsDjw7FPLL((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 2;
				}
				break;
			}
			case 1:
				customExportRuleBuilder = new ExportRuleBuilder<IFormMetadataItemHeader>(new ExportRuleList());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				wJPdHUdPcAHESeASiVI(customExportRuleBuilder.Rule().ForPropertyName(InterfaceActivator.TypeOf<ScriptModule>(), (string)pNodA9dXlViMuc22WIc(-1411196499 ^ -1411222447)));
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 10;
				}
				break;
			default:
			{
				ExportRuleBuilderSelectType<IFormMetadataItemHeader> exportRuleBuilderSelectType8 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = (ParameterExpression)n6qrvLdkQXtui78xcvg(typeof(IFormMetadataItemHeader), pNodA9dXlViMuc22WIc(0x53FA00CE ^ 0x53FAAD3A));
				BTEtfpdOoPPf0Ku5fC2(exportRuleBuilderSelectType8.ForPropertyName(Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression)chpNNRdnwbIsr6j4JhC(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				num2 = 5;
				break;
			}
			case 10:
				return;
			case 5:
			{
				ExportRuleBuilderSelectType<IFormMetadataItemHeader> exportRuleBuilderSelectType7 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = Expression.Parameter(PxAnPOd2wEPXjexA26t(typeof(IFormMetadataItemHeader).TypeHandle), (string)pNodA9dXlViMuc22WIc(-957824448 ^ -957845580));
				exportRuleBuilderSelectType7.ForPropertyName(Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression)chpNNRdnwbIsr6j4JhC(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).ExportDeep();
				num2 = 7;
				break;
			}
			case 7:
			{
				ExportRuleBuilderSelectType<IFormMetadataItemHeader> exportRuleBuilderSelectType6 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = Expression.Parameter(PxAnPOd2wEPXjexA26t(typeof(IFormMetadataItemHeader).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867226527));
				wJPdHUdPcAHESeASiVI(exportRuleBuilderSelectType6.ForPropertyName(Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression)chpNNRdnwbIsr6j4JhC(parameterExpression, (MethodInfo)nF25WfdehBsDjw7FPLL((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 3;
				}
				break;
			}
			case 6:
			{
				ExportRuleBuilderSelectType<IFormMetadataItemHeader> exportRuleBuilderSelectType5 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), (string)pNodA9dXlViMuc22WIc(-740338220 ^ -740296672));
				exportRuleBuilderSelectType5.ForPropertyName(Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression)q5igE1d1VcRnfQtDBUZ(chpNNRdnwbIsr6j4JhC(parameterExpression, (MethodInfo)nF25WfdehBsDjw7FPLL((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), PxAnPOd2wEPXjexA26t(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression })).Ignore();
				num2 = 4;
				break;
			}
			case 8:
			{
				ExportRuleBuilderSelectType<IFormMetadataItemHeader> exportRuleBuilderSelectType4 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), (string)pNodA9dXlViMuc22WIc(0x1C9495B4 ^ 0x1C943840));
				exportRuleBuilderSelectType4.ForPropertyName(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Convert((Expression)chpNNRdnwbIsr6j4JhC(parameterExpression, (MethodInfo)nF25WfdehBsDjw7FPLL((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })).Ignore();
				num2 = 9;
				break;
			}
			case 3:
			{
				ExportRuleBuilderSelectType<IFormMetadataItemHeader> exportRuleBuilderSelectType3 = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = Expression.Parameter(PxAnPOd2wEPXjexA26t(typeof(IFormMetadataItemHeader).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824348567));
				wJPdHUdPcAHESeASiVI(exportRuleBuilderSelectType3.ForPropertyName(Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression)chpNNRdnwbIsr6j4JhC(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				num2 = 6;
				break;
			}
			case 4:
			{
				ExportRuleBuilderSelectType<IFormMetadataItemHeader> exportRuleBuilderSelectType = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = Expression.Parameter(PxAnPOd2wEPXjexA26t(typeof(IFormMetadataItemHeader).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108613692));
				At2j6GdNWNAhVLULa6V(exportRuleBuilderSelectType.ForPropertyName(Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression)q5igE1d1VcRnfQtDBUZ(chpNNRdnwbIsr6j4JhC(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), PxAnPOd2wEPXjexA26t(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression })));
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	private List<IEntity> GetEntities(IFormMetadataItemHeader header)
	{
		ExportHelperBuilder<IFormMetadataItemHeader> exportHelperBuilder = ExportHelperBuilder.Create(header);
		exportHelperBuilder.ExportRuleList = customExportRuleBuilder.ExportRules;
		return exportHelperBuilder.EntityExportList();
	}

	private void AddExportObjectsCustom(Dictionary<Guid, object> parameters, Dictionary<string, object> serviceData, List<PacketEntity> packetEntities, List<FormExportData> formExportData)
	{
		if (parameters[UIFormExportConsts.ExportExtensionUid] is UIFormExportSetting uIFormExportSetting && uIFormExportSetting.ExportForms)
		{
			AddForms(packetEntities, uIFormExportSetting.FormHeaderUids, serviceData, formExportData);
		}
	}

	private void AddForms(List<PacketEntity> packetEntities, List<Guid> uids, Dictionary<string, object> serviceData, List<FormExportData> formExportData)
	{
		FormMetadataItemHeaderManager serviceNotNull = Locator.GetServiceNotNull<FormMetadataItemHeaderManager>();
		foreach (Guid uid in uids)
		{
			IFormMetadataItemHeader formMetadataItemHeader = serviceNotNull.Load(uid);
			PacketEntity packetEntity = new PacketEntity(formMetadataItemHeader);
			packetEntity.ExportRules = customExportRuleBuilder.ExportRules;
			foreach (IEntity entity in GetEntities(formMetadataItemHeader))
			{
				packetEntity.SubEntities.Add(entity);
				if (entity is IFormMetadataItem formMetadataItem)
				{
					FormMetadata formMetadata = formMetadataItem.Metadata as FormMetadata;
					formExportData.Add(new FormExportData
					{
						EntityName = formMetadata.DisplayName,
						FormViewItems = (from p in formMetadata.PartUids.Select(formMetadata.GetPart)
							select (FormViewItem)_003C_003Ec.tmqxBif5drhH67eMMXUL(p)).ToList(),
						ViewNamePrefix = GetViewNamePrefix(formMetadata)
					});
				}
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
			ExportFormDependencyHelper.AddFormDependenciesInfo(uid, formMetadataItemHeader.DisplayName, serviceData);
			packetEntities.Add(packetEntity);
		}
	}

	public UIFormExportExtension()
	{
		//Discarded unreachable code: IL_003f, IL_0044
		SingletonReader.JJCZtPuTvSt();
		customExportRuleBuilder = new ExportRuleBuilder<IFormMetadataItemHeader>(new ExportRuleList());
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool iO7r8Kdi79eM4UIgiNw()
	{
		return LyTiYLdSvFRR9g7eh35 == null;
	}

	internal static UIFormExportExtension eJt4AIdRhyOOwCe7RKE()
	{
		return LyTiYLdSvFRR9g7eh35;
	}

	internal static object MGqbQOdqLIV0BAcJ4RL(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object OIrGV2dKJG8JDfW5lpg(object P_0)
	{
		return GetViewNamePrefix((string)P_0);
	}

	internal static object pNodA9dXlViMuc22WIc(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object by9tCddTsGT6PGXRQfd(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object n6qrvLdkQXtui78xcvg(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object chpNNRdnwbIsr6j4JhC(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static void BTEtfpdOoPPf0Ku5fC2(object P_0)
	{
		((ExportRuleBuilderSelectAction<IFormMetadataItemHeader>)P_0).ExportDeep();
	}

	internal static Type PxAnPOd2wEPXjexA26t(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object nF25WfdehBsDjw7FPLL(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static void wJPdHUdPcAHESeASiVI(object P_0)
	{
		((ExportRuleBuilderSelectAction<IFormMetadataItemHeader>)P_0).Ignore();
	}

	internal static object q5igE1d1VcRnfQtDBUZ(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static void At2j6GdNWNAhVLULa6V(object P_0)
	{
		((ExportRuleBuilderSelectAction<IFormMetadataItemHeader>)P_0).Export();
	}
}
