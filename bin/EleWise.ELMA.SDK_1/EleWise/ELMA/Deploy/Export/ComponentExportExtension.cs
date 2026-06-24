// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.ComponentExportExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.Components;
using EleWise.ELMA.Deploy.Export.Helpers;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Helpers;
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

namespace EleWise.ELMA.Deploy.Export
{
  /// <summary>Расширение экспорта конфигурации для компонентов</summary>
  [Component(Order = 500)]
  internal class ComponentExportExtension : MetadataConfigurationExportExtension
  {
    /// <summary>Билдер кастомных правил экспорта страниц/портлетов</summary>
    private ExportRuleBuilder<ComponentMetadataItemHeader> customExportRuleBuilder;
    internal static ComponentExportExtension nVoFxmEg6pguHjGB20D9;

    /// <inheritdoc />
    public override Dictionary<Guid, object> GetNewSettingObj() => new Dictionary<Guid, object>()
    {
      {
        ComponentExportConsts.ExportExtensionUid,
        (object) new ComponentExportSetting()
      }
    };

    /// <inheritdoc />
    public override void AddExportObjects(ExportExtensionParams parameters)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.AddExportObjectsCustom(parameters.Parameters, parameters.PacketEntities, parameters.PacketMetadatas, parameters.ServiceData, parameters.Messages, parameters.Importants, parameters.FormExportData);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
            continue;
          case 2:
            this.AddCustomRules();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
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
    internal static string GetViewNamePrefix(ComponentMetadata componentMetadata) => (string) ComponentExportExtension.crNDrgEgxsaOQ4ZPhXSt(ComponentExportExtension.AYBD4tEg761EYyO0fYiE((object) componentMetadata));

    /// <summary>Префикс для кастомных представлений в компонентах</summary>
    /// <param name="metadataName">Имя метаданных</param>
    /// <returns>Префикс для кастомных представлений в компонентах</returns>
    internal static string GetViewNamePrefix(string metadataName) => (string) ComponentExportExtension.dXEPLIEgm10eKJBHjZjp(ComponentExportExtension.lmHntfEg0anGyjS0hW3Z(~541731958 ^ -542037971), (object) metadataName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70016163));

    private void AddCustomRules()
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ExportRuleBuilderSelectType<ComponentMetadataItemHeader> builderSelectType1 = this.customExportRuleBuilder.Rule();
              ParameterExpression parameterExpression1 = (ParameterExpression) ComponentExportExtension.FGfB3vEgy2g1yWAlelWU(typeof (ComponentMetadataItemHeader), ComponentExportExtension.lmHntfEg0anGyjS0hW3Z(1470440286 ^ 1470467754));
              // ISSUE: method reference
              Expression<Func<ComponentMetadataItemHeader, object>> f1 = Expression.Lambda<Func<ComponentMetadataItemHeader, object>>((Expression) ComponentExportExtension.vpfjK2EgMDZ1JWk69Pvl((object) parameterExpression1, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ComponentMetadataItemHeader.get_Draft))), parameterExpression1);
              ComponentExportExtension.Gl90IVEgJgbEKY3bdnJn((object) builderSelectType1.ForPropertyName(f1));
              num2 = 9;
              continue;
            case 2:
              this.customExportRuleBuilder = new ExportRuleBuilder<ComponentMetadataItemHeader>(new ExportRuleList());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
              continue;
            case 3:
              ExportRuleBuilderSelectType<ComponentMetadataItemHeader> builderSelectType2 = this.customExportRuleBuilder.Rule();
              ParameterExpression parameterExpression2 = (ParameterExpression) ComponentExportExtension.FGfB3vEgy2g1yWAlelWU(typeof (MetadataItemGroupUI), ComponentExportExtension.lmHntfEg0anGyjS0hW3Z(-1886646897 ^ -1886609285));
              // ISSUE: method reference
              Expression<Func<MetadataItemGroupUI, object>> f2 = Expression.Lambda<Func<MetadataItemGroupUI, object>>((Expression) ComponentExportExtension.vpfjK2EgMDZ1JWk69Pvl((object) parameterExpression2, (object) (MethodInfo) ComponentExportExtension.rC3ug9Eg931J26fJGakJ(__methodref (MetadataItemGroupUI.get_Groups))), parameterExpression2);
              builderSelectType2.ForPropertyName<MetadataItemGroupUI>(f2).Ignore();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 8 : 7;
              continue;
            case 4:
              ExportRuleBuilderSelectType<ComponentMetadataItemHeader> builderSelectType3 = this.customExportRuleBuilder.Rule();
              // ISSUE: type reference
              ParameterExpression parameterExpression3 = (ParameterExpression) ComponentExportExtension.FGfB3vEgy2g1yWAlelWU(ComponentExportExtension.Q4T9HHEglVpr2HVGxF5K(__typeref (ComponentMetadataItem)), ComponentExportExtension.lmHntfEg0anGyjS0hW3Z(--1360331293 ^ 1360375785));
              // ISSUE: method reference
              Expression<Func<ComponentMetadataItem, object>> f3 = Expression.Lambda<Func<ComponentMetadataItem, object>>((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ComponentMetadataItem.get_TestScriptModule))), parameterExpression3);
              builderSelectType3.ForPropertyName<ComponentMetadataItem>(f3).ExportDeep();
              num2 = 13;
              continue;
            case 5:
              ExportRuleBuilderSelectType<ComponentMetadataItemHeader> builderSelectType4 = this.customExportRuleBuilder.Rule();
              // ISSUE: type reference
              ParameterExpression parameterExpression4 = (ParameterExpression) ComponentExportExtension.FGfB3vEgy2g1yWAlelWU(ComponentExportExtension.Q4T9HHEglVpr2HVGxF5K(__typeref (ComponentMetadataItemHeader)), ComponentExportExtension.lmHntfEg0anGyjS0hW3Z(1242972401 >> 4 ^ 77711867));
              // ISSUE: method reference
              Expression<Func<ComponentMetadataItemHeader, object>> f4 = Expression.Lambda<Func<ComponentMetadataItemHeader, object>>((Expression) ComponentExportExtension.vpfjK2EgMDZ1JWk69Pvl((object) parameterExpression4, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ComponentMetadataItemHeader.get_Group))), parameterExpression4);
              ComponentExportExtension.Gl90IVEgJgbEKY3bdnJn((object) builderSelectType4.ForPropertyName(f4));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
              continue;
            case 6:
              ExportRuleBuilderSelectType<ComponentMetadataItemHeader> builderSelectType5 = this.customExportRuleBuilder.Rule();
              // ISSUE: type reference
              ParameterExpression parameterExpression5 = (ParameterExpression) ComponentExportExtension.FGfB3vEgy2g1yWAlelWU(ComponentExportExtension.Q4T9HHEglVpr2HVGxF5K(__typeref (MetadataItemGroupUI)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642897740));
              // ISSUE: method reference
              Expression<Func<MetadataItemGroupUI, object>> f5 = Expression.Lambda<Func<MetadataItemGroupUI, object>>((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (MetadataItemGroupUI.get_Parent))), parameterExpression5);
              ComponentExportExtension.Gl90IVEgJgbEKY3bdnJn((object) builderSelectType5.ForPropertyName<MetadataItemGroupUI>(f5));
              num2 = 3;
              continue;
            case 7:
              ExportRuleBuilderSelectType<ComponentMetadataItemHeader> builderSelectType6 = this.customExportRuleBuilder.Rule();
              // ISSUE: type reference
              ParameterExpression parameterExpression6 = (ParameterExpression) ComponentExportExtension.FGfB3vEgy2g1yWAlelWU(ComponentExportExtension.Q4T9HHEglVpr2HVGxF5K(__typeref (ComponentMetadataItem)), ComponentExportExtension.lmHntfEg0anGyjS0hW3Z(-1876063057 ^ -1876090533));
              // ISSUE: method reference
              Expression<Func<ComponentMetadataItem, object>> f6 = Expression.Lambda<Func<ComponentMetadataItem, object>>((Expression) Expression.Property((Expression) parameterExpression6, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ComponentMetadataItem.get_ClientScriptModule))), parameterExpression6);
              ComponentExportExtension.Gl90IVEgJgbEKY3bdnJn((object) builderSelectType6.ForPropertyName<ComponentMetadataItem>(f6));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 4;
              continue;
            case 8:
              goto label_3;
            case 9:
              ExportRuleBuilderSelectType<ComponentMetadataItemHeader> builderSelectType7 = this.customExportRuleBuilder.Rule();
              ParameterExpression parameterExpression7 = (ParameterExpression) ComponentExportExtension.FGfB3vEgy2g1yWAlelWU(typeof (ComponentMetadataItemHeader), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218452902));
              // ISSUE: method reference
              Expression<Func<ComponentMetadataItemHeader, object>> f7 = Expression.Lambda<Func<ComponentMetadataItemHeader, object>>((Expression) ComponentExportExtension.vpfjK2EgMDZ1JWk69Pvl((object) parameterExpression7, (object) (MethodInfo) ComponentExportExtension.rC3ug9Eg931J26fJGakJ(__methodref (ComponentMetadataItemHeader.get_Published))), parameterExpression7);
              ComponentExportExtension.YnUVnbEgdE8lol3ILCh0((object) builderSelectType7.ForPropertyName(f7));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 12 : 11;
              continue;
            case 10:
              goto label_5;
            case 11:
              ComponentExportExtension.YnUVnbEgdE8lol3ILCh0((object) this.customExportRuleBuilder.Rule().ForPropertyName(InterfaceActivator.TypeOf<ScriptModule>(), (string) ComponentExportExtension.lmHntfEg0anGyjS0hW3Z(~-306453669 ^ 306553994)));
              num2 = 10;
              continue;
            case 12:
              ExportRuleBuilderSelectType<ComponentMetadataItemHeader> builderSelectType8 = this.customExportRuleBuilder.Rule();
              // ISSUE: type reference
              ParameterExpression parameterExpression8 = (ParameterExpression) ComponentExportExtension.FGfB3vEgy2g1yWAlelWU(ComponentExportExtension.Q4T9HHEglVpr2HVGxF5K(__typeref (ComponentMetadataItemHeader)), ComponentExportExtension.lmHntfEg0anGyjS0hW3Z(92412609 - 1050237057 ^ -957845580));
              // ISSUE: method reference
              // ISSUE: type reference
              Expression<Func<ComponentMetadataItemHeader, object>> f8 = Expression.Lambda<Func<ComponentMetadataItemHeader, object>>((Expression) ComponentExportExtension.hPdmgEEgrUqnZ16WaJ1C(ComponentExportExtension.vpfjK2EgMDZ1JWk69Pvl((object) parameterExpression8, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ComponentMetadataItemHeader.get_IsDeleted))), ComponentExportExtension.Q4T9HHEglVpr2HVGxF5K(__typeref (object))), parameterExpression8);
              ComponentExportExtension.YnUVnbEgdE8lol3ILCh0((object) builderSelectType8.ForPropertyName(f8));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 4 : 5;
              continue;
            case 13:
              ExportRuleBuilderSelectType<ComponentMetadataItemHeader> builderSelectType9 = this.customExportRuleBuilder.Rule();
              // ISSUE: type reference
              ParameterExpression parameterExpression9 = Expression.Parameter(ComponentExportExtension.Q4T9HHEglVpr2HVGxF5K(__typeref (ComponentMetadataItem)), (string) ComponentExportExtension.lmHntfEg0anGyjS0hW3Z(1925118608 << 2 ^ -889501772));
              // ISSUE: method reference
              // ISSUE: type reference
              Expression<Func<ComponentMetadataItem, object>> f9 = Expression.Lambda<Func<ComponentMetadataItem, object>>((Expression) Expression.Convert((Expression) ComponentExportExtension.vpfjK2EgMDZ1JWk69Pvl((object) parameterExpression9, (object) (MethodInfo) ComponentExportExtension.rC3ug9Eg931J26fJGakJ(__methodref (ComponentMetadataItem.get_VersionNumber))), ComponentExportExtension.Q4T9HHEglVpr2HVGxF5K(__typeref (object))), parameterExpression9);
              ComponentExportExtension.YnUVnbEgdE8lol3ILCh0((object) builderSelectType9.ForPropertyName<ComponentMetadataItem>(f9));
              num2 = 11;
              continue;
            default:
              ExportRuleBuilderSelectType<ComponentMetadataItemHeader> builderSelectType10 = this.customExportRuleBuilder.Rule();
              // ISSUE: type reference
              ParameterExpression parameterExpression10 = (ParameterExpression) ComponentExportExtension.FGfB3vEgy2g1yWAlelWU(ComponentExportExtension.Q4T9HHEglVpr2HVGxF5K(__typeref (ComponentMetadataItem)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901835663));
              // ISSUE: method reference
              Expression<Func<ComponentMetadataItem, object>> f10 = Expression.Lambda<Func<ComponentMetadataItem, object>>((Expression) ComponentExportExtension.vpfjK2EgMDZ1JWk69Pvl((object) parameterExpression10, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ComponentMetadataItem.get_ScriptModule))), parameterExpression10);
              ComponentExportExtension.Gl90IVEgJgbEKY3bdnJn((object) builderSelectType10.ForPropertyName<ComponentMetadataItem>(f10));
              num2 = 7;
              continue;
          }
        }
label_5:
        ComponentExportExtension.YnUVnbEgdE8lol3ILCh0((object) this.customExportRuleBuilder.Rule().ForPropertyName(InterfaceActivator.TypeOf<ScriptModule>(), (string) ComponentExportExtension.lmHntfEg0anGyjS0hW3Z(1461625753 ^ 1461587557)));
        num1 = 6;
      }
label_3:;
    }

    /// <summary>
    /// Получить список сущностей для экспортируемого компонента
    /// </summary>
    /// <param name="header">Заголовок</param>
    private List<IEntity> GetEntities(ComponentMetadataItemHeader header)
    {
      ExportHelperBuilder<ComponentMetadataItemHeader> exportHelperBuilder = ExportHelperBuilder.Create<ComponentMetadataItemHeader>(header);
      exportHelperBuilder.ExportRuleList = this.customExportRuleBuilder.ExportRules;
      return exportHelperBuilder.EntityExportList();
    }

    private void AddExportObjectsCustom(
      Dictionary<Guid, object> parameters,
      List<PacketEntity> packetEntities,
      List<PacketMetadata> packetMetadatas,
      Dictionary<string, object> serviceData,
      List<DeployLogMessage> messages,
      ISet<Guid> importants,
      List<FormExportData> formExportData)
    {
      if (!(parameters[ComponentExportConsts.ExportExtensionUid] is ComponentExportSetting parameter) || parameter.ComponentsIds.Count == 0)
        return;
      List<Guid> componentsIds = parameter.ComponentsIds;
      ComponentMetadataItemHeaderManager instance = ComponentMetadataItemHeaderManager.Instance;
      List<ComponentMetadata> components = new List<ComponentMetadata>();
      foreach (Guid uid in componentsIds)
      {
        ComponentMetadataItemHeader header = instance.LoadOrNull(uid);
        if (header != null)
        {
          if (this.IsUIForm(header))
          {
            PacketEntity packetEntity = new PacketEntity((IEntity) header);
            packetEntity.ExportRules = this.customExportRuleBuilder.ExportRules;
            foreach (IEntity entity in this.GetEntities(header))
            {
              packetEntity.SubEntities.Add(entity);
              if (entity is ComponentMetadataItem componentMetadataItem)
              {
                ComponentMetadata metadata = (ComponentMetadata) componentMetadataItem.Metadata;
                formExportData.Add(new FormExportData()
                {
                  EntityName = metadata.DisplayName,
                  FormViewItems = (ICollection<FormViewItem>) new FormViewItem[1]
                  {
                    metadata.Content.View
                  },
                  ViewNamePrefix = ComponentExportExtension.GetViewNamePrefix(metadata)
                });
              }
            }
            packetEntities.Add(packetEntity);
          }
          else
          {
            ComponentMetadata componentMetadata = ClassSerializationHelper.CloneObjectByXml<ComponentMetadata>((ComponentMetadata) header.Published.Metadata);
            componentMetadata.Uid = header.Uid;
            components.Add(componentMetadata);
            PacketMetadata packetMetadata = new PacketMetadata((IMetadata) componentMetadata);
            if (header.Group != null)
            {
              serviceData.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218654174) + (object) header.Uid, (object) header.Group.Uid);
              foreach (IEntity key in this.AddInfoMetadataGroup(header.Group, serviceData))
              {
                if (!packetMetadata.SubEntitiesBefore.ContainsKey(key))
                  packetMetadata.SubEntitiesBefore.Add(key, new Guid?());
              }
            }
            importants.Add(ComponentExportExtension.ImportantData.Uid);
            packetMetadata.SubUserMetadataInfo[componentMetadata.Uid] = new SubUserMetadataInfo((IMetadata) componentMetadata);
            AddExportObjectsHelper.AddScriptModule(packetMetadata, serviceData, (IMetadata) componentMetadata, header.Published.ScriptModule, header.Draft.ScriptModule, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633518907), this.ScriptModuleManager, this.ExternalAssemblyManager);
            AddExportObjectsHelper.AddScriptModule(packetMetadata, serviceData, (IMetadata) componentMetadata, header.Published.ClientScriptModule, header.Draft.ClientScriptModule, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106465774), this.ScriptModuleManager, this.ExternalAssemblyManager);
            packetMetadatas.Add(packetMetadata);
            formExportData.Add(new FormExportData()
            {
              EntityName = componentMetadata.DisplayName,
              FormViewItems = (ICollection<FormViewItem>) new FormViewItem[1]
              {
                componentMetadata.Content.View
              },
              ViewNamePrefix = ComponentExportExtension.GetViewNamePrefix(componentMetadata)
            });
          }
        }
      }
      // ISSUE: reference to a compiler-generated method
      ICollection<ValidationError> source = this.TestComponents((ICollection<ComponentMetadata>) components, packetMetadatas.SelectMany<PacketMetadata, IMetadata>((Func<PacketMetadata, IEnumerable<IMetadata>>) (p => p.SubUserMetadataInfo.Values.Select<SubUserMetadataInfo, IMetadata>((Func<SubUserMetadataInfo, IMetadata>) (i => (IMetadata) ComponentExportExtension.\u003C\u003Ec.o358Oe875b1AtxnWd2VU((object) i))).Append<IMetadata>(p.MetaData))).OfType<EntityMetadata>());
      if (source.Count > 0)
      {
        messages.AddRange(source.SelectMany<ValidationError, ValidationError>((Func<ValidationError, IEnumerable<ValidationError>>) (e => ComponentExportExtension.GetErrors((object) e))).Select<ValidationError, DeployLogMessage>((Func<ValidationError, DeployLogMessage>) (e => new DeployLogMessage(DeployLogMessageType.Error, e.Message))));
        throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082085082)));
      }
    }

    private bool IsUIForm(ComponentMetadataItemHeader header)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!ComponentExportExtension.GKWAOfEg5Ghki9CSkNCS(ComponentExportExtension.GOS42mEggXWBFL2JUKJm((object) header), PageComponentMetadata.TypeUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return ComponentExportExtension.GKWAOfEg5Ghki9CSkNCS(ComponentExportExtension.GOS42mEggXWBFL2JUKJm((object) header), PortletComponentMetadata.TypeUid);
label_3:
      return true;
    }

    private static IEnumerable<ValidationError> GetErrors(object error) => ((IEnumerable<ValidationError>) ((ValidationError) error).InnerErrors).EmptyIfNull<ValidationError>().SelectMany<ValidationError, ValidationError>(new Func<ValidationError, IEnumerable<ValidationError>>(ComponentExportExtension.GetErrors)).Prepend<ValidationError>((ValidationError) error);

    private ICollection<ValidationError> TestComponents(
      ICollection<ComponentMetadata> components,
      IEnumerable<EntityMetadata> entities)
    {
      using (MetadataServiceContext.Extend((IEnumerable<IMetadata>) components))
      {
        HashSet<Guid> componentsSet = components.Select<ComponentMetadata, Guid>((Func<ComponentMetadata, Guid>) (c => c.Uid)).ToHashSet<Guid>();
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return (ICollection<ValidationError>) entities.Where<EntityMetadata>((Func<EntityMetadata, bool>) (m => m.ViewModelMetadata != null)).Select<EntityMetadata, ValidationError>((Func<EntityMetadata, ValidationError>) (m =>
        {
          int num = 2;
          EntityMetadata m1;
          // ISSUE: variable of a compiler-generated type
          ComponentExportExtension.\u003C\u003Ec__DisplayClass10_0 cDisplayClass100;
          while (true)
          {
            switch (num)
            {
              case 1:
                cDisplayClass100 = this;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 3 : 2;
                continue;
              case 2:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 1;
                continue;
              case 3:
                m1 = m;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
                continue;
              default:
                goto label_5;
            }
          }
label_5:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          return GenerateError(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132780711), ComponentExportExtension.\u003C\u003Ec__DisplayClass10_0.QB8c8F87sH8ywyLfJJ2F((object) m1)), ComponentExportExtension.\u003C\u003Ec__DisplayClass10_0.eH1kg887cigNcskKff0n((object) m1), Guid.Empty, m1.Forms.Select<FormViewItem, ValidationError>((Func<FormViewItem, ValidationError>) (f => (ValidationError) ComponentExportExtension.\u003C\u003Ec__DisplayClass10_1.ghAnUV8xC6in9SRZ7bJo((object) EleWise.ELMA.SR.T((string) ComponentExportExtension.\u003C\u003Ec__DisplayClass10_1.I2UWeF8xGmnfCQPlu5Cl(-675505729 ^ -675639021), (object) f.DisplayName), ComponentExportExtension.\u003C\u003Ec__DisplayClass10_1.LSg6yN8xEqhPhYCV7yRk((object) m1), ComponentExportExtension.\u003C\u003Ec__DisplayClass10_1.YJWRid8xf6QyG2SN4Cbf((object) f), (object) CheckComponentHelper.CheckComponentViewItems(f, ((AbstractMetadata) ComponentExportExtension.\u003C\u003Ec__DisplayClass10_1.Xi7jGE8xQo2oWEawB0S8((object) m1)).Uid, m1, new Func<Guid, bool>(cDisplayClass100.componentsSet.Contains)).ToArray<ValidationError>()))).Where<ValidationError>((Func<ValidationError, bool>) (e => e != null)).ToArray<ValidationError>());
        })).Where<ValidationError>((Func<ValidationError, bool>) (e => e != null)).Concat<ValidationError>(components.Select<ComponentMetadata, ValidationError>((Func<ComponentMetadata, ValidationError>) (m => (ValidationError) ComponentExportExtension.\u003C\u003Ec__DisplayClass10_0.bFNNhf8xBTH58aiCNoNd((object) EleWise.ELMA.SR.T((string) ComponentExportExtension.\u003C\u003Ec__DisplayClass10_0.QsWCX587z8vv2yJMNtBP(-477139494 ^ -477534772), (object) m.DisplayName), ComponentExportExtension.\u003C\u003Ec__DisplayClass10_0.eH1kg887cigNcskKff0n((object) m), Guid.Empty, (object) CheckComponentHelper.CheckComponentViewItems(((ComponentContentMetadata) ComponentExportExtension.\u003C\u003Ec__DisplayClass10_0.oICfWV8xFGmt8hDVEn3Q((object) m)).View, ComponentExportExtension.\u003C\u003Ec__DisplayClass10_0.eH1kg887cigNcskKff0n((object) m), new Func<Guid, bool>(componentsSet.Contains)).ToArray<ValidationError>()))).Where<ValidationError>((Func<ValidationError, bool>) (e => e != null))).ToArray<ValidationError>();
      }

      static ValidationError GenerateError(
        string errorMessage,
        Guid ownerUid,
        Guid formUid,
        ValidationError[] errors)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (errors.Length == 0)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            default:
              goto label_5;
          }
        }
label_4:
        ValidationError error = new ValidationError();
        ComponentExportExtension.pFG6tOEgYe8MlW9Ps5I8((object) error, ownerUid);
        ComponentExportExtension.lRK71hEgLPkMBEllBX3x((object) error, !(formUid != Guid.Empty) ? Guid.Empty : ValidationElementType.ObjectFormViewItem);
        ComponentExportExtension.rVBMkEEgUmWy2BxXiL4M((object) error, formUid);
        ComponentExportExtension.uFwg5rEgs29ewiu0kLak((object) error, (object) errorMessage);
        ComponentExportExtension.eOcsiYEgcIdqNgltHLhl((object) error, (object) errors);
        return error;
label_5:
        return (ValidationError) null;
      }
    }

    public ComponentExportExtension()
    {
      ComponentExportExtension.oVeelcEgj3iLktx0ZgED();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool kYZPePEgHIdr8otvkGox() => ComponentExportExtension.nVoFxmEg6pguHjGB20D9 == null;

    internal static ComponentExportExtension Cg8yGJEgA196ROe6MSqH() => ComponentExportExtension.nVoFxmEg6pguHjGB20D9;

    internal static object AYBD4tEg761EYyO0fYiE([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object crNDrgEgxsaOQ4ZPhXSt([In] object obj0) => (object) ComponentExportExtension.GetViewNamePrefix((string) obj0);

    internal static object lmHntfEg0anGyjS0hW3Z(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object dXEPLIEgm10eKJBHjZjp([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object FGfB3vEgy2g1yWAlelWU([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object vpfjK2EgMDZ1JWk69Pvl([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static void Gl90IVEgJgbEKY3bdnJn([In] object obj0) => ((ExportRuleBuilderSelectAction<ComponentMetadataItemHeader>) obj0).ExportDeep();

    internal static object rC3ug9Eg931J26fJGakJ([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static void YnUVnbEgdE8lol3ILCh0([In] object obj0) => ((ExportRuleBuilderSelectAction<ComponentMetadataItemHeader>) obj0).Ignore();

    internal static Type Q4T9HHEglVpr2HVGxF5K([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object hPdmgEEgrUqnZ16WaJ1C([In] object obj0, [In] Type obj1) => (object) Expression.Convert((Expression) obj0, obj1);

    internal static Guid GOS42mEggXWBFL2JUKJm([In] object obj0) => ((ComponentMetadataItemHeader) obj0).MetadataTypeUid;

    internal static bool GKWAOfEg5Ghki9CSkNCS([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static void oVeelcEgj3iLktx0ZgED() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void pFG6tOEgYe8MlW9Ps5I8([In] object obj0, Guid value) => ((ValidationError) obj0).OwnerUid = value;

    internal static void lRK71hEgLPkMBEllBX3x([In] object obj0, Guid value) => ((ValidationError) obj0).ElementTypeUid = value;

    internal static void rVBMkEEgUmWy2BxXiL4M([In] object obj0, Guid value) => ((ValidationError) obj0).ElementUid = value;

    internal static void uFwg5rEgs29ewiu0kLak([In] object obj0, [In] object obj1) => ((ValidationError) obj0).Message = (string) obj1;

    internal static void eOcsiYEgcIdqNgltHLhl([In] object obj0, [In] object obj1) => ((ValidationError) obj0).InnerErrors = (ValidationError[]) obj1;

    [Component]
    private sealed class ImportantData : IImportantData
    {
      internal static object nsKHrc870HxFPBMP7R4r;

      public static Guid Uid { get; }

      Guid IImportantData.Uid => ComponentExportExtension.ImportantData.SdI59A87MQJlquUlNieB();

      public IEnumerable<Version> Versions { get; }

      public string Module => (string) null;

      public ImportantData()
      {
        ComponentExportExtension.ImportantData.z73wu787Jb8nHrIOE6ub();
        this.Versions = (IEnumerable<Version>) new Version[1]
        {
          new Version(4, 1, 0)
        };
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      static ImportantData()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              ComponentExportExtension.ImportantData.Uid = new Guid((string) ComponentExportExtension.ImportantData.OoDfUg879AfLCX1yEhhx(572119659 - -337058038 ^ 909571117));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 2 : 1;
              continue;
          }
        }
label_2:;
      }

      internal static Guid SdI59A87MQJlquUlNieB() => ComponentExportExtension.ImportantData.Uid;

      internal static void z73wu787Jb8nHrIOE6ub() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool nQMGqs87m2jiYP4JCvGi() => ComponentExportExtension.ImportantData.nsKHrc870HxFPBMP7R4r == null;

      internal static ComponentExportExtension.ImportantData tVSvHR87yjjNhDg8dI5x() => (ComponentExportExtension.ImportantData) ComponentExportExtension.ImportantData.nsKHrc870HxFPBMP7R4r;

      internal static object OoDfUg879AfLCX1yEhhx(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
    }
  }
}
