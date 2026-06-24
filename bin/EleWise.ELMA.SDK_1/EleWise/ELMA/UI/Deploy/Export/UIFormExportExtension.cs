// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Deploy.Export.UIFormExportExtension
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Deploy.Export
{
  /// <summary>
  /// Расширение экспорта конфигурации для страниц и портлетов
  /// </summary>
  [Component(Order = 350)]
  public class UIFormExportExtension : IConfigExportExtension
  {
    private ExportRuleBuilder<IFormMetadataItemHeader> customExportRuleBuilder;
    internal static UIFormExportExtension LyTiYLdSvFRR9g7eh35;

    public Dictionary<Guid, object> GetNewSettingObj() => new Dictionary<Guid, object>()
    {
      {
        UIFormExportConsts.ExportExtensionUid,
        (object) new UIFormExportSetting()
      }
    };

    public void AddExportObjects(ExportExtensionParams parameters)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.AddExportObjectsCustom(parameters.Parameters, parameters.ServiceData, parameters.PacketEntities, parameters.FormExportData);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
            continue;
          case 2:
            this.AddCustomRules();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Префикс для кастомных представлений в компонентах</summary>
    /// <param name="componentMetadata">Метаданные компонента</param>
    /// <returns>Префикс для кастомных представлений в компонентах</returns>
    public static string GetViewNamePrefix(FormMetadata formMetadata) => (string) UIFormExportExtension.OIrGV2dKJG8JDfW5lpg(UIFormExportExtension.MGqbQOdqLIV0BAcJ4RL((object) formMetadata));

    /// <summary>Префикс для кастомных представлений в компонентах</summary>
    /// <param name="metadataName">Имя метаданных</param>
    /// <returns>Префикс для кастомных представлений в компонентах</returns>
    internal static string GetViewNamePrefix(string metadataName) => (string) UIFormExportExtension.by9tCddTsGT6PGXRQfd(UIFormExportExtension.pNodA9dXlViMuc22WIc(-882126494 ^ -882148174), (object) metadataName, UIFormExportExtension.pNodA9dXlViMuc22WIc(333888594 ^ 1075625116 ^ 1408918686));

    private void AddCustomRules()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.customExportRuleBuilder = new ExportRuleBuilder<IFormMetadataItemHeader>(new ExportRuleList());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          case 2:
            UIFormExportExtension.wJPdHUdPcAHESeASiVI((object) this.customExportRuleBuilder.Rule().ForPropertyName(InterfaceActivator.TypeOf<ScriptModule>(), (string) UIFormExportExtension.pNodA9dXlViMuc22WIc(1051802738 - -1831968059 ^ -1411222447)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 10 : 10;
            continue;
          case 3:
            ExportRuleBuilderSelectType<IFormMetadataItemHeader> builderSelectType1 = this.customExportRuleBuilder.Rule();
            // ISSUE: type reference
            ParameterExpression parameterExpression1 = Expression.Parameter(UIFormExportExtension.PxAnPOd2wEPXjexA26t(__typeref (IFormMetadataItemHeader)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824348567));
            // ISSUE: method reference
            Expression<Func<IFormMetadataItemHeader, object>> f1 = Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression) UIFormExportExtension.chpNNRdnwbIsr6j4JhC((object) parameterExpression1, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IFormMetadataItemHeader.get_Emulation))), parameterExpression1);
            UIFormExportExtension.wJPdHUdPcAHESeASiVI((object) builderSelectType1.ForPropertyName(f1));
            num = 6;
            continue;
          case 4:
            ExportRuleBuilderSelectType<IFormMetadataItemHeader> builderSelectType2 = this.customExportRuleBuilder.Rule();
            // ISSUE: type reference
            ParameterExpression parameterExpression2 = Expression.Parameter(UIFormExportExtension.PxAnPOd2wEPXjexA26t(__typeref (IFormMetadataItemHeader)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108613692));
            // ISSUE: method reference
            // ISSUE: type reference
            Expression<Func<IFormMetadataItemHeader, object>> f2 = Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression) UIFormExportExtension.q5igE1d1VcRnfQtDBUZ(UIFormExportExtension.chpNNRdnwbIsr6j4JhC((object) parameterExpression2, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IFormMetadataItemHeader.get_IsDeleted))), UIFormExportExtension.PxAnPOd2wEPXjexA26t(__typeref (object))), parameterExpression2);
            UIFormExportExtension.At2j6GdNWNAhVLULa6V((object) builderSelectType2.ForPropertyName(f2));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 8 : 0;
            continue;
          case 5:
            ExportRuleBuilderSelectType<IFormMetadataItemHeader> builderSelectType3 = this.customExportRuleBuilder.Rule();
            // ISSUE: type reference
            ParameterExpression parameterExpression3 = Expression.Parameter(UIFormExportExtension.PxAnPOd2wEPXjexA26t(__typeref (IFormMetadataItemHeader)), (string) UIFormExportExtension.pNodA9dXlViMuc22WIc(92412609 - 1050237057 ^ -957845580));
            // ISSUE: method reference
            Expression<Func<IFormMetadataItemHeader, object>> f3 = Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression) UIFormExportExtension.chpNNRdnwbIsr6j4JhC((object) parameterExpression3, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IFormMetadataItemHeader.get_Group))), parameterExpression3);
            builderSelectType3.ForPropertyName(f3).ExportDeep();
            num = 7;
            continue;
          case 6:
            ParameterExpression parameterExpression4;
            // ISSUE: method reference
            // ISSUE: type reference
            this.customExportRuleBuilder.Rule().ForPropertyName(Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression) UIFormExportExtension.q5igE1d1VcRnfQtDBUZ(UIFormExportExtension.chpNNRdnwbIsr6j4JhC((object) parameterExpression4, (object) (MethodInfo) UIFormExportExtension.nF25WfdehBsDjw7FPLL(__methodref (IFormMetadataItemHeader.get_HardDelete))), UIFormExportExtension.PxAnPOd2wEPXjexA26t(__typeref (object))), parameterExpression4)).Ignore();
            num = 4;
            continue;
          case 7:
            ExportRuleBuilderSelectType<IFormMetadataItemHeader> builderSelectType4 = this.customExportRuleBuilder.Rule();
            // ISSUE: type reference
            ParameterExpression parameterExpression5 = Expression.Parameter(UIFormExportExtension.PxAnPOd2wEPXjexA26t(__typeref (IFormMetadataItemHeader)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867226527));
            // ISSUE: method reference
            Expression<Func<IFormMetadataItemHeader, object>> f4 = Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression) UIFormExportExtension.chpNNRdnwbIsr6j4JhC((object) parameterExpression5, (object) (MethodInfo) UIFormExportExtension.nF25WfdehBsDjw7FPLL(__methodref (IFormMetadataItemHeader.get_Published))), parameterExpression5);
            UIFormExportExtension.wJPdHUdPcAHESeASiVI((object) builderSelectType4.ForPropertyName(f4));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 3;
            continue;
          case 8:
            ParameterExpression parameterExpression6;
            // ISSUE: method reference
            this.customExportRuleBuilder.Rule().ForPropertyName(Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression) Expression.Convert((Expression) UIFormExportExtension.chpNNRdnwbIsr6j4JhC((object) parameterExpression6, (object) (MethodInfo) UIFormExportExtension.nF25WfdehBsDjw7FPLL(__methodref (IFormMetadataItemHeader.get_IsDirtyItem))), typeof (object)), parameterExpression6)).Ignore();
            num = 9;
            continue;
          case 9:
            ExportRuleBuilderSelectType<IFormMetadataItemHeader> builderSelectType5 = this.customExportRuleBuilder.Rule();
            // ISSUE: type reference
            ParameterExpression parameterExpression7 = (ParameterExpression) UIFormExportExtension.n6qrvLdkQXtui78xcvg(UIFormExportExtension.PxAnPOd2wEPXjexA26t(__typeref (IFormMetadataItem)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477118418));
            // ISSUE: method reference
            Expression<Func<IFormMetadataItem, object>> f5 = Expression.Lambda<Func<IFormMetadataItem, object>>((Expression) UIFormExportExtension.chpNNRdnwbIsr6j4JhC((object) parameterExpression7, (object) (MethodInfo) UIFormExportExtension.nF25WfdehBsDjw7FPLL(__methodref (IFormMetadataItem.get_ScriptModule))), parameterExpression7);
            UIFormExportExtension.BTEtfpdOoPPf0Ku5fC2((object) builderSelectType5.ForPropertyName<IFormMetadataItem>(f5));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 2 : 2;
            continue;
          case 10:
            goto label_2;
          default:
            ExportRuleBuilderSelectType<IFormMetadataItemHeader> builderSelectType6 = this.customExportRuleBuilder.Rule();
            ParameterExpression parameterExpression8 = (ParameterExpression) UIFormExportExtension.n6qrvLdkQXtui78xcvg(typeof (IFormMetadataItemHeader), UIFormExportExtension.pNodA9dXlViMuc22WIc(333888594 ^ 1075625116 ^ 1408937274));
            // ISSUE: method reference
            Expression<Func<IFormMetadataItemHeader, object>> f6 = Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression) UIFormExportExtension.chpNNRdnwbIsr6j4JhC((object) parameterExpression8, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IFormMetadataItemHeader.get_Draft))), parameterExpression8);
            UIFormExportExtension.BTEtfpdOoPPf0Ku5fC2((object) builderSelectType6.ForPropertyName(f6));
            num = 5;
            continue;
        }
      }
label_2:;
    }

    private List<IEntity> GetEntities(IFormMetadataItemHeader header)
    {
      ExportHelperBuilder<IFormMetadataItemHeader> exportHelperBuilder = ExportHelperBuilder.Create<IFormMetadataItemHeader>(header);
      exportHelperBuilder.ExportRuleList = this.customExportRuleBuilder.ExportRules;
      return exportHelperBuilder.EntityExportList();
    }

    private void AddExportObjectsCustom(
      Dictionary<Guid, object> parameters,
      Dictionary<string, object> serviceData,
      List<PacketEntity> packetEntities,
      List<FormExportData> formExportData)
    {
      if (!(parameters[UIFormExportConsts.ExportExtensionUid] is UIFormExportSetting parameter) || !parameter.ExportForms)
        return;
      this.AddForms(packetEntities, parameter.FormHeaderUids, serviceData, formExportData);
    }

    private void AddForms(
      List<PacketEntity> packetEntities,
      List<Guid> uids,
      Dictionary<string, object> serviceData,
      List<FormExportData> formExportData)
    {
      FormMetadataItemHeaderManager serviceNotNull = Locator.GetServiceNotNull<FormMetadataItemHeaderManager>();
      foreach (Guid uid in uids)
      {
        IFormMetadataItemHeader header = serviceNotNull.Load(uid);
        PacketEntity packetEntity = new PacketEntity((IEntity) header);
        packetEntity.ExportRules = this.customExportRuleBuilder.ExportRules;
        foreach (IEntity entity in this.GetEntities(header))
        {
          packetEntity.SubEntities.Add(entity);
          if (entity is IFormMetadataItem formMetadataItem)
          {
            FormMetadata metadata = formMetadataItem.Metadata as FormMetadata;
            // ISSUE: reference to a compiler-generated method
            formExportData.Add(new FormExportData()
            {
              EntityName = metadata.DisplayName,
              FormViewItems = (ICollection<FormViewItem>) metadata.PartUids.Select<Guid, FormPartMetadata>(new Func<Guid, FormPartMetadata>(metadata.GetPart)).Select<FormPartMetadata, FormViewItem>((Func<FormPartMetadata, FormViewItem>) (p => (FormViewItem) UIFormExportExtension.\u003C\u003Ec.tmqxBif5drhH67eMMXUL((object) p))).ToList<FormViewItem>(),
              ViewNamePrefix = UIFormExportExtension.GetViewNamePrefix(metadata)
            });
          }
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
        ExportFormDependencyHelper.AddFormDependenciesInfo(uid, header.DisplayName, serviceData);
        packetEntities.Add(packetEntity);
      }
    }

    public UIFormExportExtension()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.customExportRuleBuilder = new ExportRuleBuilder<IFormMetadataItemHeader>(new ExportRuleList());
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool iO7r8Kdi79eM4UIgiNw() => UIFormExportExtension.LyTiYLdSvFRR9g7eh35 == null;

    internal static UIFormExportExtension eJt4AIdRhyOOwCe7RKE() => UIFormExportExtension.LyTiYLdSvFRR9g7eh35;

    internal static object MGqbQOdqLIV0BAcJ4RL([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object OIrGV2dKJG8JDfW5lpg([In] object obj0) => (object) UIFormExportExtension.GetViewNamePrefix((string) obj0);

    internal static object pNodA9dXlViMuc22WIc(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object by9tCddTsGT6PGXRQfd([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object n6qrvLdkQXtui78xcvg([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object chpNNRdnwbIsr6j4JhC([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static void BTEtfpdOoPPf0Ku5fC2([In] object obj0) => ((ExportRuleBuilderSelectAction<IFormMetadataItemHeader>) obj0).ExportDeep();

    internal static Type PxAnPOd2wEPXjexA26t([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object nF25WfdehBsDjw7FPLL([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static void wJPdHUdPcAHESeASiVI([In] object obj0) => ((ExportRuleBuilderSelectAction<IFormMetadataItemHeader>) obj0).Ignore();

    internal static object q5igE1d1VcRnfQtDBUZ([In] object obj0, [In] Type obj1) => (object) Expression.Convert((Expression) obj0, obj1);

    internal static void At2j6GdNWNAhVLULa6V([In] object obj0) => ((ExportRuleBuilderSelectAction<IFormMetadataItemHeader>) obj0).Export();
  }
}
