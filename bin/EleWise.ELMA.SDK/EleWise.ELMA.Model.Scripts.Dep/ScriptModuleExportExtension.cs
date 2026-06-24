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
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts.Deploy.Export;

[Component(Order = 950)]
public class ScriptModuleExportExtension : IConfigExportExtension
{
	private ExportRuleBuilder<IGlobalScriptModuleHeader> customExportRuleBuilder;

	internal static ScriptModuleExportExtension Uc0lBkbXlD3YqrYKcJME;

	public Dictionary<Guid, object> GetNewSettingObj()
	{
		return new Dictionary<Guid, object> { 
		{
			ScriptModuleExportConsts.ExportExtensionUid,
			new ScriptModuleExportSetting()
		} };
	}

	public void AddExportObjects(ExportExtensionParams parameters)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				AddCustomRules();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num2 = 0;
				}
				break;
			default:
				AddExportObjectsCustom(parameters.Parameters, parameters.ServiceData, parameters.PacketEntities);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private void AddCustomRules()
	{
		int num = 7;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 7:
					break;
				case 1:
				{
					ExportRuleBuilderSelectType<IGlobalScriptModuleHeader> exportRuleBuilderSelectType5 = customExportRuleBuilder.Rule();
					ParameterExpression parameterExpression = Expression.Parameter(nAQyawbX5PCQU569S0XO(typeof(IGlobalScriptModuleHeader).TypeHandle), (string)jTs710bXj3JbmKFQtTUm(0x3A6135BE ^ 0x3A61984A));
					exportRuleBuilderSelectType5.ForPropertyName(Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>((Expression)mcTssobXz3lcfxBjgpJg(Expression.Property(parameterExpression, (MethodInfo)zTqmuxbXLqhcVU1AC8om((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), nAQyawbX5PCQU569S0XO(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression })).Ignore();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				case 3:
					yTqjRZbXciZ7UQdPkViP(customExportRuleBuilder.Rule().ForPropertyName(InterfaceActivator.TypeOf<ScriptModule>(), (string)jTs710bXj3JbmKFQtTUm(-1822890472 ^ -1822929948)));
					num2 = 2;
					continue;
				default:
				{
					ExportRuleBuilderSelectType<IGlobalScriptModuleHeader> exportRuleBuilderSelectType2 = customExportRuleBuilder.Rule();
					ParameterExpression parameterExpression = (ParameterExpression)NoAW31bXYjTjvE45a9XU(nAQyawbX5PCQU569S0XO(typeof(IGlobalScriptModule).TypeHandle), jTs710bXj3JbmKFQtTUm(0x4D1C1EE4 ^ 0x4D1CB310));
					U2xanrbXsbZINGVV6WRI(exportRuleBuilderSelectType2.ForPropertyName(Expression.Lambda<Func<IGlobalScriptModule, object>>((Expression)xmBVa9bXUj4ETNGZY01F(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
					num2 = 3;
					continue;
				}
				case 4:
				{
					ExportRuleBuilderSelectType<IGlobalScriptModuleHeader> exportRuleBuilderSelectType4 = customExportRuleBuilder.Rule();
					ParameterExpression parameterExpression = (ParameterExpression)NoAW31bXYjTjvE45a9XU(typeof(IGlobalScriptModuleHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488837569));
					yTqjRZbXciZ7UQdPkViP(exportRuleBuilderSelectType4.ForPropertyName(Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>((Expression)mcTssobXz3lcfxBjgpJg(Expression.Property(parameterExpression, (MethodInfo)zTqmuxbXLqhcVU1AC8om((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), nAQyawbX5PCQU569S0XO(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression })));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 5:
				{
					ExportRuleBuilderSelectType<IGlobalScriptModuleHeader> exportRuleBuilderSelectType3 = customExportRuleBuilder.Rule();
					ParameterExpression parameterExpression = (ParameterExpression)NoAW31bXYjTjvE45a9XU(nAQyawbX5PCQU569S0XO(typeof(IGlobalScriptModuleHeader).TypeHandle), jTs710bXj3JbmKFQtTUm(-1633514411 ^ -1633541727));
					yTqjRZbXciZ7UQdPkViP(exportRuleBuilderSelectType3.ForPropertyName(Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>(Expression.Property(parameterExpression, (MethodInfo)zTqmuxbXLqhcVU1AC8om((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 1;
					}
					continue;
				}
				case 6:
				{
					ExportRuleBuilderSelectType<IGlobalScriptModuleHeader> exportRuleBuilderSelectType = customExportRuleBuilder.Rule();
					ParameterExpression parameterExpression = (ParameterExpression)NoAW31bXYjTjvE45a9XU(nAQyawbX5PCQU569S0XO(typeof(IGlobalScriptModuleHeader).TypeHandle), jTs710bXj3JbmKFQtTUm(-97972138 ^ -97927774));
					U2xanrbXsbZINGVV6WRI(exportRuleBuilderSelectType.ForPropertyName(Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>((Expression)xmBVa9bXUj4ETNGZY01F(parameterExpression, (MethodInfo)zTqmuxbXLqhcVU1AC8om((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 5;
					}
					continue;
				}
				}
				break;
			}
			customExportRuleBuilder = new ExportRuleBuilder<IGlobalScriptModuleHeader>(new ExportRuleList());
			num = 6;
		}
	}

	private List<IEntity> GetEntities(IGlobalScriptModuleHeader header)
	{
		ExportHelperBuilder<IGlobalScriptModuleHeader> exportHelperBuilder = ExportHelperBuilder.Create(header);
		exportHelperBuilder.ExportRuleList = customExportRuleBuilder.ExportRules;
		return exportHelperBuilder.EntityExportList();
	}

	private void AddExportObjectsCustom(Dictionary<Guid, object> parameters, Dictionary<string, object> serviceData, List<PacketEntity> packetEntities)
	{
		if (parameters[ScriptModuleExportConsts.ExportExtensionUid] is ScriptModuleExportSetting scriptModuleExportSetting && scriptModuleExportSetting.ExportScriptModules)
		{
			AddScriptModules(packetEntities, scriptModuleExportSetting.ScriptModuleUids, serviceData);
		}
	}

	private void AddScriptModules(List<PacketEntity> packetEntities, List<Guid> uids, Dictionary<string, object> serviceData)
	{
		GlobalScriptModuleHeaderManager serviceNotNull = Locator.GetServiceNotNull<GlobalScriptModuleHeaderManager>();
		foreach (Guid uid in uids)
		{
			IGlobalScriptModuleHeader globalScriptModuleHeader = serviceNotNull.Load(uid);
			PacketEntity packetEntity = new PacketEntity(globalScriptModuleHeader);
			packetEntity.ExportRules = customExportRuleBuilder.ExportRules;
			foreach (IEntity entity in GetEntities(globalScriptModuleHeader))
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
		}
	}

	public ScriptModuleExportExtension()
	{
		//Discarded unreachable code: IL_003f, IL_0044
		meqWaqbTF7DkuV82udaN();
		customExportRuleBuilder = new ExportRuleBuilder<IGlobalScriptModuleHeader>(new ExportRuleList());
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool JVD0rqbXrEWU2kqemfWu()
	{
		return Uc0lBkbXlD3YqrYKcJME == null;
	}

	internal static ScriptModuleExportExtension jjo3w5bXgrtxx9rZGivZ()
	{
		return Uc0lBkbXlD3YqrYKcJME;
	}

	internal static Type nAQyawbX5PCQU569S0XO(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object jTs710bXj3JbmKFQtTUm(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object NoAW31bXYjTjvE45a9XU(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object zTqmuxbXLqhcVU1AC8om(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object xmBVa9bXUj4ETNGZY01F(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static void U2xanrbXsbZINGVV6WRI(object P_0)
	{
		((ExportRuleBuilderSelectAction<IGlobalScriptModuleHeader>)P_0).ExportDeep();
	}

	internal static void yTqjRZbXciZ7UQdPkViP(object P_0)
	{
		((ExportRuleBuilderSelectAction<IGlobalScriptModuleHeader>)P_0).Ignore();
	}

	internal static object mcTssobXz3lcfxBjgpJg(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static void meqWaqbTF7DkuV82udaN()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
