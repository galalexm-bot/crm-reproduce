// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Deploy.Export.ScriptModuleExportExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

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
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts.Deploy.Export
{
  /// <summary>
  /// Расширение экспорта конфигурации для глобальных модулей
  /// </summary>
  [Component(Order = 950)]
  public class ScriptModuleExportExtension : IConfigExportExtension
  {
    private ExportRuleBuilder<IGlobalScriptModuleHeader> customExportRuleBuilder;
    internal static ScriptModuleExportExtension Uc0lBkbXlD3YqrYKcJME;

    public Dictionary<Guid, object> GetNewSettingObj() => new Dictionary<Guid, object>()
    {
      {
        ScriptModuleExportConsts.ExportExtensionUid,
        (object) new ScriptModuleExportSetting()
      }
    };

    public void AddExportObjects(ExportExtensionParams parameters)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.AddCustomRules();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.AddExportObjectsCustom(parameters.Parameters, parameters.ServiceData, parameters.PacketEntities);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    private void AddCustomRules()
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ExportRuleBuilderSelectType<IGlobalScriptModuleHeader> builderSelectType1 = this.customExportRuleBuilder.Rule();
              // ISSUE: type reference
              ParameterExpression parameterExpression1 = Expression.Parameter(ScriptModuleExportExtension.nAQyawbX5PCQU569S0XO(__typeref (IGlobalScriptModuleHeader)), (string) ScriptModuleExportExtension.jTs710bXj3JbmKFQtTUm(979449278 ^ 979474506));
              // ISSUE: method reference
              // ISSUE: type reference
              Expression<Func<IGlobalScriptModuleHeader, object>> f1 = Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>((Expression) ScriptModuleExportExtension.mcTssobXz3lcfxBjgpJg((object) Expression.Property((Expression) parameterExpression1, (MethodInfo) ScriptModuleExportExtension.zTqmuxbXLqhcVU1AC8om(__methodref (IGlobalScriptModuleHeader.get_Deleted))), ScriptModuleExportExtension.nAQyawbX5PCQU569S0XO(__typeref (object))), parameterExpression1);
              builderSelectType1.ForPropertyName(f1).Ignore();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 4 : 4;
              continue;
            case 2:
              goto label_3;
            case 3:
              ScriptModuleExportExtension.yTqjRZbXciZ7UQdPkViP((object) this.customExportRuleBuilder.Rule().ForPropertyName(InterfaceActivator.TypeOf<ScriptModule>(), (string) ScriptModuleExportExtension.jTs710bXj3JbmKFQtTUm(-1822890472 ^ -1822929948)));
              num2 = 2;
              continue;
            case 4:
              ExportRuleBuilderSelectType<IGlobalScriptModuleHeader> builderSelectType2 = this.customExportRuleBuilder.Rule();
              ParameterExpression parameterExpression2 = (ParameterExpression) ScriptModuleExportExtension.NoAW31bXYjTjvE45a9XU(typeof (IGlobalScriptModuleHeader), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488837569));
              // ISSUE: method reference
              // ISSUE: type reference
              Expression<Func<IGlobalScriptModuleHeader, object>> f2 = Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>((Expression) ScriptModuleExportExtension.mcTssobXz3lcfxBjgpJg((object) Expression.Property((Expression) parameterExpression2, (MethodInfo) ScriptModuleExportExtension.zTqmuxbXLqhcVU1AC8om(__methodref (IGlobalScriptModuleHeader.get_HasChanges))), ScriptModuleExportExtension.nAQyawbX5PCQU569S0XO(__typeref (object))), parameterExpression2);
              ScriptModuleExportExtension.yTqjRZbXciZ7UQdPkViP((object) builderSelectType2.ForPropertyName(f2));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
              continue;
            case 5:
              ExportRuleBuilderSelectType<IGlobalScriptModuleHeader> builderSelectType3 = this.customExportRuleBuilder.Rule();
              // ISSUE: type reference
              ParameterExpression parameterExpression3 = (ParameterExpression) ScriptModuleExportExtension.NoAW31bXYjTjvE45a9XU(ScriptModuleExportExtension.nAQyawbX5PCQU569S0XO(__typeref (IGlobalScriptModuleHeader)), ScriptModuleExportExtension.jTs710bXj3JbmKFQtTUm(-342626196 - 1290888215 ^ -1633541727));
              // ISSUE: method reference
              Expression<Func<IGlobalScriptModuleHeader, object>> f3 = Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) ScriptModuleExportExtension.zTqmuxbXLqhcVU1AC8om(__methodref (IGlobalScriptModuleHeader.get_Published))), parameterExpression3);
              ScriptModuleExportExtension.yTqjRZbXciZ7UQdPkViP((object) builderSelectType3.ForPropertyName(f3));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
              continue;
            case 6:
              ExportRuleBuilderSelectType<IGlobalScriptModuleHeader> builderSelectType4 = this.customExportRuleBuilder.Rule();
              // ISSUE: type reference
              ParameterExpression parameterExpression4 = (ParameterExpression) ScriptModuleExportExtension.NoAW31bXYjTjvE45a9XU(ScriptModuleExportExtension.nAQyawbX5PCQU569S0XO(__typeref (IGlobalScriptModuleHeader)), ScriptModuleExportExtension.jTs710bXj3JbmKFQtTUm(-97972138 ^ -97927774));
              // ISSUE: method reference
              Expression<Func<IGlobalScriptModuleHeader, object>> f4 = Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>((Expression) ScriptModuleExportExtension.xmBVa9bXUj4ETNGZY01F((object) parameterExpression4, (object) (MethodInfo) ScriptModuleExportExtension.zTqmuxbXLqhcVU1AC8om(__methodref (IGlobalScriptModuleHeader.get_Draft))), parameterExpression4);
              ScriptModuleExportExtension.U2xanrbXsbZINGVV6WRI((object) builderSelectType4.ForPropertyName(f4));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 2 : 5;
              continue;
            case 7:
              goto label_4;
            default:
              ExportRuleBuilderSelectType<IGlobalScriptModuleHeader> builderSelectType5 = this.customExportRuleBuilder.Rule();
              // ISSUE: type reference
              ParameterExpression parameterExpression5 = (ParameterExpression) ScriptModuleExportExtension.NoAW31bXYjTjvE45a9XU(ScriptModuleExportExtension.nAQyawbX5PCQU569S0XO(__typeref (IGlobalScriptModule)), ScriptModuleExportExtension.jTs710bXj3JbmKFQtTUm(323422137 << 2 ^ 1293726480));
              // ISSUE: method reference
              Expression<Func<IGlobalScriptModule, object>> f5 = Expression.Lambda<Func<IGlobalScriptModule, object>>((Expression) ScriptModuleExportExtension.xmBVa9bXUj4ETNGZY01F((object) parameterExpression5, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IGlobalScriptModule.get_ScriptModule))), parameterExpression5);
              ScriptModuleExportExtension.U2xanrbXsbZINGVV6WRI((object) builderSelectType5.ForPropertyName<IGlobalScriptModule>(f5));
              num2 = 3;
              continue;
          }
        }
label_4:
        this.customExportRuleBuilder = new ExportRuleBuilder<IGlobalScriptModuleHeader>(new ExportRuleList());
        num1 = 6;
      }
label_3:;
    }

    private List<IEntity> GetEntities(IGlobalScriptModuleHeader header)
    {
      ExportHelperBuilder<IGlobalScriptModuleHeader> exportHelperBuilder = ExportHelperBuilder.Create<IGlobalScriptModuleHeader>(header);
      exportHelperBuilder.ExportRuleList = this.customExportRuleBuilder.ExportRules;
      return exportHelperBuilder.EntityExportList();
    }

    private void AddExportObjectsCustom(
      Dictionary<Guid, object> parameters,
      Dictionary<string, object> serviceData,
      List<PacketEntity> packetEntities)
    {
      if (!(parameters[ScriptModuleExportConsts.ExportExtensionUid] is ScriptModuleExportSetting parameter) || !parameter.ExportScriptModules)
        return;
      this.AddScriptModules(packetEntities, parameter.ScriptModuleUids, serviceData);
    }

    private void AddScriptModules(
      List<PacketEntity> packetEntities,
      List<Guid> uids,
      Dictionary<string, object> serviceData)
    {
      GlobalScriptModuleHeaderManager serviceNotNull = Locator.GetServiceNotNull<GlobalScriptModuleHeaderManager>();
      foreach (Guid uid in uids)
      {
        IGlobalScriptModuleHeader header = serviceNotNull.Load(uid);
        PacketEntity packetEntity = new PacketEntity((IEntity) header);
        packetEntity.ExportRules = this.customExportRuleBuilder.ExportRules;
        foreach (IEntity entity in this.GetEntities(header))
        {
          packetEntity.SubEntities.Add(entity);
          if (entity is IScriptModule scriptModule && scriptModule.LocalReferences != null)
          {
            foreach (AssemblyReference localReference in scriptModule.LocalReferences)
            {
              IExternalAssembly externalAssembly = ExternalAssemblyManager.Instance.LoadOrNull(localReference.Uid);
              if (externalAssembly != null)
                packetEntity.SubEntities.Insert(0, (IEntity) externalAssembly);
            }
          }
        }
        packetEntities.Add(packetEntity);
      }
    }

    public ScriptModuleExportExtension()
    {
      ScriptModuleExportExtension.meqWaqbTF7DkuV82udaN();
      this.customExportRuleBuilder = new ExportRuleBuilder<IGlobalScriptModuleHeader>(new ExportRuleList());
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool JVD0rqbXrEWU2kqemfWu() => ScriptModuleExportExtension.Uc0lBkbXlD3YqrYKcJME == null;

    internal static ScriptModuleExportExtension jjo3w5bXgrtxx9rZGivZ() => ScriptModuleExportExtension.Uc0lBkbXlD3YqrYKcJME;

    internal static Type nAQyawbX5PCQU569S0XO([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object jTs710bXj3JbmKFQtTUm(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object NoAW31bXYjTjvE45a9XU([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object zTqmuxbXLqhcVU1AC8om([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object xmBVa9bXUj4ETNGZY01F([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static void U2xanrbXsbZINGVV6WRI([In] object obj0) => ((ExportRuleBuilderSelectAction<IGlobalScriptModuleHeader>) obj0).ExportDeep();

    internal static void yTqjRZbXciZ7UQdPkViP([In] object obj0) => ((ExportRuleBuilderSelectAction<IGlobalScriptModuleHeader>) obj0).Ignore();

    internal static object mcTssobXz3lcfxBjgpJg([In] object obj0, [In] Type obj1) => (object) Expression.Convert((Expression) obj0, obj1);

    internal static void meqWaqbTF7DkuV82udaN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
