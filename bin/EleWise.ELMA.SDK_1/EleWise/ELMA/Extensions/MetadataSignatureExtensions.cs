// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.MetadataSignatureExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Metadata;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Расширения для получения сигнатуры элементов</summary>
  public static class MetadataSignatureExtensions
  {
    internal static MetadataSignatureExtensions mZOGr5GacO8UGN80jNH1;

    /// <summary>Получить сигнатуру по классу</summary>
    /// <param name="metadata">Метаданные</param>
    /// <param name="properties">Свойства</param>
    /// <typeparam name="TSignature">Тип сигнатуры</typeparam>
    /// <typeparam name="TMetadata">Тип метаданных</typeparam>
    /// <returns>Сигнатура по классу</returns>
    public static TSignature GetClassMetadataSignature<TSignature, TMetadata>(
      this TMetadata metadata,
      IEnumerable<IPropertyMetadata> properties)
      where TSignature : ClassDependency
      where TMetadata : ClassMetadata
    {
      TSignature metadataSignature = InterfaceActivator.Create<TSignature>();
      if (metadata is EntityMetadata entityMetadata)
      {
        if (entityMetadata.Type == EntityMetadataType.Interface)
          metadataSignature.HeaderUid = entityMetadata.ImplementationUid;
        else if (entityMetadata.Type == EntityMetadataType.InterfaceExtension)
        {
          IMetadata metadata1 = MetadataServiceContext.Service.GetMetadata(entityMetadata.BaseClassUid);
          metadataSignature.HeaderUid = metadata1 != null ? metadata1.Uid : entityMetadata.Uid;
        }
        else
          metadataSignature.HeaderUid = entityMetadata.Uid;
      }
      else
        metadataSignature.HeaderUid = metadata.Uid;
      metadataSignature.ModuleUid = metadata.ModuleUid;
      metadataSignature.Name = metadata.Name;
      metadataSignature.DisplayName = metadata.DisplayName;
      foreach (IPropertyMetadata property in properties)
        metadataSignature.Properties.Add(property.CreatePropertySignature());
      return metadataSignature;
    }

    /// <summary>Получить сигнатуру датакласса</summary>
    /// <param name="metadata">Метаданные датакласса</param>
    /// <param name="simple">Простая сигнатура. Означает, что будет построена простая сигнатура. Без дополнительных свойств</param>
    /// <returns>Сигнатура датакласса</returns>
    public static DataClassDependency GetSignature(this DataClassMetadata metadata, bool simple = false) => metadata.GetSignature(!simple ? (IEnumerable<IPropertyMetadata>) metadata.Properties : (IEnumerable<IPropertyMetadata>) Enumerable.Empty<PropertyMetadata>());

    /// <summary>Получить сигнатуру датакласса</summary>
    /// <param name="metadata">Метаданные датакласса</param>
    /// <param name="properties">Свойства</param>
    /// <returns>Сигнатура датакласса</returns>
    public static DataClassDependency GetSignature(
      this DataClassMetadata metadata,
      IEnumerable<IPropertyMetadata> properties)
    {
      return metadata.GetClassMetadataSignature<DataClassDependency, DataClassMetadata>(properties);
    }

    /// <summary>Получить сигнатуру сущности</summary>
    /// <param name="metadata">Метаданные сущности</param>
    /// <param name="simple">Простая сигнатура. Означает, что будет построена простая сигнатура. Без дополнительных свойств</param>
    /// <returns>Сигнатура сущности</returns>
    public static EntityDependency GetSignature(this EntityMetadata metadata, bool simple = false)
    {
      int num1 = 7;
      IEnumerable<IPropertyMetadata> properties;
      while (true)
      {
        int num2 = num1;
        IEnumerable<IPropertyMetadata> propertiesAndTableParts;
        List<IPropertyMetadata> propertyMetadataList;
        IPropertyMetadata propertyMetadata1;
        IPropertyMetadata propertyMetadata2;
        Guid isGroupPropertyUid;
        Guid parentPropertyUid;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 4:
            case 14:
              goto label_9;
            case 2:
              if (propertyMetadata1 == null)
              {
                num2 = 18;
                continue;
              }
              goto case 22;
            case 3:
            case 24:
              properties = metadata.GetPropertiesAndTableParts();
              num2 = 4;
              continue;
            case 5:
              propertyMetadataList.Add(propertyMetadata2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 8 : 2;
              continue;
            case 6:
              if (!simple)
              {
                num2 = 3;
                continue;
              }
              goto default;
            case 7:
              properties = Enumerable.Empty<IPropertyMetadata>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 2 : 6;
              continue;
            case 8:
            case 13:
            case 19:
              parentPropertyUid = MetadataSignatureExtensions.lWTrv2GDbelpcmmO23Sn((object) metadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 20 : 20;
              continue;
            case 9:
            case 18:
              properties = (IEnumerable<IPropertyMetadata>) propertyMetadataList;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 14 : 9;
              continue;
            case 10:
              propertyMetadataList = new List<IPropertyMetadata>();
              num2 = 17;
              continue;
            case 11:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 12 : 5;
              continue;
            case 12:
              isGroupPropertyUid = MetadataSignatureExtensions.goaR8uGDosDJHgKtUhmW((object) metadata);
              num2 = 23;
              continue;
            case 15:
              if (MetadataSignatureExtensions.qoNgF4GDWxHweRJXPK21((object) metadata) == HierarchyType.GroupAndElements)
                goto case 11;
              else
                goto label_17;
            case 16:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 4 : 10;
              continue;
            case 17:
              propertiesAndTableParts = metadata.GetPropertiesAndTableParts();
              num2 = 15;
              continue;
            case 20:
              // ISSUE: reference to a compiler-generated method
              propertyMetadata1 = propertiesAndTableParts.FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (a => MetadataSignatureExtensions.\u003C\u003Ec__DisplayClass3_0.MjhNqD8WqHGXBaWDYaXA((object) a) == parentPropertyUid));
              num2 = 2;
              continue;
            case 21:
              if (propertyMetadata2 == null)
              {
                num2 = 13;
                continue;
              }
              goto case 5;
            case 22:
              propertyMetadataList.Add(propertyMetadata1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 3 : 9;
              continue;
            case 23:
              propertyMetadata2 = propertiesAndTableParts.FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (a => a.PropertyUid == isGroupPropertyUid));
              num2 = 21;
              continue;
            default:
              if (!MetadataSignatureExtensions.OTbBggGDBg4pEtiCOqY8((object) metadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
                continue;
              }
              goto case 16;
          }
        }
label_17:
        num1 = 19;
      }
label_9:
      return metadata.GetSignature(properties);
    }

    /// <summary>Получить сигнатуру сущности</summary>
    /// <param name="metadata">Метаданные сущности</param>
    /// <param name="properties">Свойства</param>
    /// <returns>Сигнатура сущности</returns>
    public static EntityDependency GetSignature(
      this EntityMetadata metadata,
      IEnumerable<IPropertyMetadata> properties)
    {
      return metadata.GetClassMetadataSignature<EntityDependency, EntityMetadata>(properties);
    }

    /// <summary>Получить сигнатуру функции</summary>
    /// <param name="metadata">Метаданные функции</param>
    /// <returns>Сигнатура функции</returns>
    public static FunctionDependency GetSignature(this FunctionMetadata metadata)
    {
      FunctionDependency signature = new FunctionDependency();
      signature.HeaderUid = metadata.Uid;
      MetadataSignatureExtensions.i5NXBgGDGC62PGq0aycJ((object) signature, MetadataSignatureExtensions.n33rXiGDhqNtg7UwT1Xx((object) metadata));
      MetadataSignatureExtensions.fiH35RGDfy4htl4100Iy((object) signature, MetadataSignatureExtensions.aLklGDGDE5yksJrsmWTH((object) metadata));
      MetadataSignatureExtensions.OwSC01GDCg80Tn5LUePD((object) signature, MetadataSignatureExtensions.AHEiIMGDQJYl5XsJ4O6i((object) metadata));
      signature.ParameterType = (TypeSignature) MetadataSignatureExtensions.b9MsMvGDvMGr5rmZ1wdu((object) metadata);
      MetadataSignatureExtensions.w1vBeyGD8gf3fWgA9p3c((object) signature, (object) metadata.ReturnType);
      return signature;
    }

    /// <summary>Получить сигнатуру перечисления</summary>
    /// <param name="metadata">Метаданные перечисления</param>
    /// <returns>Сигнатура перечисления</returns>
    public static EnumDependency GetSignature(this EnumMetadata metadata)
    {
      EnumDependency signature = new EnumDependency();
      MetadataSignatureExtensions.bv3uZlGDZHUSPrcgIemk((object) signature, metadata.Uid);
      MetadataSignatureExtensions.i5NXBgGDGC62PGq0aycJ((object) signature, MetadataSignatureExtensions.n33rXiGDhqNtg7UwT1Xx((object) metadata));
      MetadataSignatureExtensions.fiH35RGDfy4htl4100Iy((object) signature, MetadataSignatureExtensions.aLklGDGDE5yksJrsmWTH((object) metadata));
      MetadataSignatureExtensions.OwSC01GDCg80Tn5LUePD((object) signature, (object) metadata.DisplayName);
      return signature;
    }

    /// <summary>Сформировать зависимость от компонента</summary>
    /// <param name="componentMetadata">Метаданные компонента</param>
    /// <param name="component">Элемент представления "Пользовательский компонент"</param>
    /// <returns>Зависимость от компонента</returns>
    public static ComponentDependency GetDependency(
      this ComponentMetadata componentMetadata,
      ComponentViewItem component)
    {
      ComponentDependency dependency = new ComponentDependency();
      dependency.ViewItemUid = MetadataSignatureExtensions.Nbf3B8GDuaNJ1cFVP5k4((object) component);
      MetadataSignatureExtensions.bv3uZlGDZHUSPrcgIemk((object) dependency, MetadataSignatureExtensions.nd1NKpGDI6tAWHusdK7h((object) component));
      MetadataSignatureExtensions.i5NXBgGDGC62PGq0aycJ((object) dependency, MetadataSignatureExtensions.n33rXiGDhqNtg7UwT1Xx((object) componentMetadata));
      MetadataSignatureExtensions.fiH35RGDfy4htl4100Iy((object) dependency, MetadataSignatureExtensions.aLklGDGDE5yksJrsmWTH((object) componentMetadata));
      MetadataSignatureExtensions.OwSC01GDCg80Tn5LUePD((object) dependency, (object) componentMetadata.DisplayName);
      dependency.Async = component.LoadingType != 0;
      return dependency;
    }

    /// <summary>Получить сигнатуру компонента</summary>
    /// <param name="metadata">Метаданные компонента</param>
    /// <returns>Сигнатура компонента</returns>
    public static ComponentSignature GetSignature(this ComponentMetadata metadata)
    {
      int num1 = 9;
      ComponentSignature signature1;
      while (true)
      {
        int num2 = num1;
        List<PropertyMetadata>.Enumerator enumerator;
        List<PlaceholderViewItem> list1;
        List<ExtensionPointViewItem> list2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 12:
              goto label_4;
            case 2:
            case 14:
              if (!MetadataSignatureExtensions.Ha4rofGDD9B2s2RRrcj6(MetadataSignatureExtensions.n33rXiGDhqNtg7UwT1Xx((object) metadata), Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
                continue;
              }
              goto case 13;
            case 3:
label_57:
              object obj = MetadataSignatureExtensions.gXBwrjGDpFo8USaKmcJK((object) metadata.Content);
              // ISSUE: reference to a compiler-generated field
              Func<ViewItem, bool> func1 = MetadataSignatureExtensions.\u003C\u003Ec.\u003C\u003E9__8_0;
              Func<ViewItem, bool> itemCondition1;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                MetadataSignatureExtensions.\u003C\u003Ec.\u003C\u003E9__8_0 = itemCondition1 = (Func<ViewItem, bool>) (s => s is PlaceholderViewItem);
              }
              else
                goto label_43;
label_59:
              list1 = ((RootViewItem) obj).FindItems(itemCondition: itemCondition1).Cast<PlaceholderViewItem>().ToList<PlaceholderViewItem>();
              num2 = 11;
              continue;
label_43:
              itemCondition1 = func1;
              goto label_59;
            case 4:
              MetadataSignatureExtensions.uU2H3bGDw2EGDcIRRFUd((object) signature1, MetadataSignatureExtensions.XV0oOGGDtYsGeBkuJwQP((object) metadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 12 : 1;
              continue;
            case 5:
              try
              {
label_7:
                if (enumerator.MoveNext())
                  goto label_26;
                else
                  goto label_8;
label_6:
                InputComputedValue inputComputedValue1;
                TypeSettings settings;
                PropertyMetadata current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                    case 10:
                    case 21:
                      goto label_7;
                    case 2:
                    case 7:
                    case 9:
                    case 32:
                      inputComputedValue1.Name = (MetadataSignatureExtensions.NJXvrGGDq7d8buuTStVj((object) propertyMetadata) ? (string) MetadataSignatureExtensions.Di7R8kGDPiSavwra1y3J(516838154 ^ 516861594) : (string) MetadataSignatureExtensions.Di7R8kGDPiSavwra1y3J(1461825605 - 1531863589 ^ -70012026)) + (string) MetadataSignatureExtensions.aLklGDGDE5yksJrsmWTH((object) current);
                      num3 = 29;
                      continue;
                    case 3:
                      MetadataSignatureExtensions.PeDxSwGDOmAnWJEuYAwF((object) inputComputedValue1, MetadataSignatureExtensions.YHlvi5GDnxARJHRYDRiG((object) entitySettings));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 7;
                      continue;
                    case 4:
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 3 : 0;
                      continue;
                    case 5:
                    case 20:
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 23 : 33;
                      continue;
                    case 6:
                      ActionInputComputedValue inputComputedValue2 = new ActionInputComputedValue();
                      MetadataSignatureExtensions.pAGDy3GDXb9MypLP4gun((object) inputComputedValue2, (object) actionSettings.ParameterType);
                      inputComputedValue2.ReturnType = (TypeSignature) MetadataSignatureExtensions.kD6c8fGDTri4VbNa4x0M((object) actionSettings);
                      MetadataSignatureExtensions.yHjA0SGDkyPXc1Fx1L9k((object) inputComputedValue2, current.SubTypeUid);
                      inputComputedValue1 = (InputComputedValue) inputComputedValue2;
                      num3 = 2;
                      continue;
                    case 8:
                      inputComputedValue1.Required = current.Required;
                      num3 = 11;
                      continue;
                    case 11:
                      signature1.Inputs.Add(inputComputedValue1);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 18 : 21;
                      continue;
                    case 12:
                    case 24:
                      inputComputedValue1 = new InputComputedValue()
                      {
                        SubTypeUid = MetadataSignatureExtensions.adrkkCGDKkuTUhcNr9sU((object) current)
                      };
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
                      continue;
                    case 13:
                      if (!(settings is EntitySettings entitySettings))
                      {
                        num3 = 31;
                        continue;
                      }
                      goto case 4;
                    case 14:
                      inputComputedValue1.RelationType = MetadataSignatureExtensions.uKFQdmGD21lnHKV8q1GU((object) dataClassSettings);
                      num3 = 9;
                      continue;
                    case 15:
                      if (settings != null)
                      {
                        num3 = 22;
                        continue;
                      }
                      goto case 2;
                    case 16:
                    case 23:
                      num3 = 6;
                      continue;
                    case 17:
                      MetadataSignatureExtensions.yHjA0SGDkyPXc1Fx1L9k((object) inputComputedValue1, MetadataSignatureExtensions.rCODdqGDeVT8t9u3E2Ej((object) simpleTypeSettings));
                      num3 = 32;
                      continue;
                    case 18:
                      if (settings is ListOfSimpleTypeSettings simpleTypeSettings)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 3 : 5;
                        continue;
                      }
                      goto case 2;
                    case 19:
                      if (MetadataSignatureExtensions.NgkYqhGDRwAcFkoeEJax((object) propertyMetadata))
                      {
                        num3 = 12;
                        continue;
                      }
                      goto case 25;
                    case 22:
                      if (settings is ActionSettings actionSettings)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 14 : 23;
                        continue;
                      }
                      goto case 13;
                    case 25:
                      if (!MetadataSignatureExtensions.NJXvrGGDq7d8buuTStVj((object) propertyMetadata))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 10 : 10;
                        continue;
                      }
                      goto case 12;
                    case 26:
                      if (!(current is IViewModelPropertyMetadata propertyMetadata))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
                        continue;
                      }
                      goto case 19;
                    case 27:
                      goto label_26;
                    case 28:
                      MetadataSignatureExtensions.IWAJ3dGD306iGhDcv0du((object) inputComputedValue1, MetadataSignatureExtensions.BpEhpWGDNNQ3wCTJrKXl((object) current));
                      num3 = 8;
                      continue;
                    case 29:
                      inputComputedValue1.ComputedValueType = ComputedValueType.Input;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 35 : 3;
                      continue;
                    case 30:
                      goto label_57;
                    case 31:
                      if (!(settings is DataClassSettings dataClassSettings))
                      {
                        num3 = 18;
                        continue;
                      }
                      goto case 34;
                    case 33:
                      MetadataSignatureExtensions.PeDxSwGDOmAnWJEuYAwF((object) inputComputedValue1, RelationType.ManyToMany);
                      num3 = 17;
                      continue;
                    case 34:
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 14 : 12;
                      continue;
                    case 35:
                      MetadataSignatureExtensions.rhXja4GD1VO5aRPuOsem((object) inputComputedValue1, current.TypeUid);
                      num3 = 28;
                      continue;
                    default:
                      settings = current.Settings;
                      num3 = 15;
                      continue;
                  }
                }
label_8:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 6 : 30;
                goto label_6;
label_26:
                current = enumerator.Current;
                num3 = 26;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
                {
                  num3 = 25;
                  goto label_6;
                }
                else
                  goto label_6;
              }
              finally
              {
                enumerator.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 6:
              enumerator = ((ClassMetadata) MetadataSignatureExtensions.f3hC2rGDit14b1eyeA2f(MetadataSignatureExtensions.nxvEoWGDSw3cwObtcueW((object) metadata))).Properties.GetEnumerator();
              num2 = 5;
              continue;
            case 7:
              List<ImplementationSignature> extensionPoints = signature1.ExtensionPoints;
              List<ExtensionPointViewItem> source1 = list2;
              // ISSUE: reference to a compiler-generated field
              Func<ExtensionPointViewItem, ImplementationSignature> func2 = MetadataSignatureExtensions.\u003C\u003Ec.\u003C\u003E9__8_4;
              Func<ExtensionPointViewItem, ImplementationSignature> selector1;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                MetadataSignatureExtensions.\u003C\u003Ec.\u003C\u003E9__8_4 = selector1 = (Func<ExtensionPointViewItem, ImplementationSignature>) (s => new ImplementationSignature()
                {
                  PointId = (string) MetadataSignatureExtensions.\u003C\u003Ec.wRDYjc8Wt3xxq8xsg9sw((object) s),
                  TypeUid = s.TypeUid
                });
              }
              else
                goto label_73;
label_72:
              IEnumerable<ImplementationSignature> collection1 = source1.Select<ExtensionPointViewItem, ImplementationSignature>(selector1);
              extensionPoints.AddRange(collection1);
              num2 = 4;
              continue;
label_73:
              selector1 = func2;
              goto label_72;
            case 8:
              ComponentSignature componentSignature = new ComponentSignature();
              MetadataSignatureExtensions.bv3uZlGDZHUSPrcgIemk((object) componentSignature, metadata.Uid);
              MetadataSignatureExtensions.i5NXBgGDGC62PGq0aycJ((object) componentSignature, MetadataSignatureExtensions.n33rXiGDhqNtg7UwT1Xx((object) metadata));
              MetadataSignatureExtensions.fiH35RGDfy4htl4100Iy((object) componentSignature, MetadataSignatureExtensions.aLklGDGDE5yksJrsmWTH((object) metadata));
              MetadataSignatureExtensions.OwSC01GDCg80Tn5LUePD((object) componentSignature, MetadataSignatureExtensions.AHEiIMGDQJYl5XsJ4O6i((object) metadata));
              signature1 = componentSignature;
              num2 = 6;
              continue;
            case 9:
              goto label_49;
            case 10:
              goto label_60;
            case 11:
              if (MetadataSignatureExtensions.EqBK79GDad6enJjPwjXO((object) list1) <= 0)
              {
                num2 = 14;
                continue;
              }
              goto label_60;
            case 13:
              List<ImplementationSignature> implementations1 = signature1.Implementations;
              List<Implementation> implementations2 = metadata.Implementations;
              // ISSUE: reference to a compiler-generated field
              Func<Implementation, ImplementationSignature> func3 = MetadataSignatureExtensions.\u003C\u003Ec.\u003C\u003E9__8_2;
              Func<Implementation, ImplementationSignature> selector2;
              if (func3 == null)
              {
                // ISSUE: reference to a compiler-generated field
                MetadataSignatureExtensions.\u003C\u003Ec.\u003C\u003E9__8_2 = selector2 = (Func<Implementation, ImplementationSignature>) (s =>
                {
                  ImplementationSignature signature2 = new ImplementationSignature();
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  MetadataSignatureExtensions.\u003C\u003Ec.KvCR3U8WaYM8yKUEOlZu((object) signature2, MetadataSignatureExtensions.\u003C\u003Ec.nlk3Yq8Wpty88Ls4K0wm((object) s));
                  // ISSUE: reference to a compiler-generated method
                  signature2.TypeUid = MetadataSignatureExtensions.\u003C\u003Ec.pwGtD68WDxFhg2vFHux6((object) s);
                  return signature2;
                });
              }
              else
                goto label_50;
label_66:
              IEnumerable<ImplementationSignature> collection2 = implementations2.Select<Implementation, ImplementationSignature>(selector2);
              implementations1.AddRange(collection2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
label_50:
              selector2 = func3;
              goto label_66;
            default:
              FormViewItem view = ((ComponentContentMetadata) MetadataSignatureExtensions.nxvEoWGDSw3cwObtcueW((object) metadata)).View;
              // ISSUE: reference to a compiler-generated field
              Func<ViewItem, bool> func4 = MetadataSignatureExtensions.\u003C\u003Ec.\u003C\u003E9__8_3;
              Func<ViewItem, bool> itemCondition2;
              if (func4 == null)
              {
                // ISSUE: reference to a compiler-generated field
                MetadataSignatureExtensions.\u003C\u003Ec.\u003C\u003E9__8_3 = itemCondition2 = (Func<ViewItem, bool>) (s => s is ExtensionPointViewItem);
              }
              else
                goto label_64;
label_69:
              list2 = view.FindItems(itemCondition: itemCondition2).Cast<ExtensionPointViewItem>().ToList<ExtensionPointViewItem>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 7 : 5;
              continue;
label_64:
              itemCondition2 = func4;
              goto label_69;
          }
        }
label_49:
        MetadataSignatureExtensions.sR1n50GDVVNg33deU2sk((object) metadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178224130));
        num1 = 8;
        continue;
label_60:
        List<InputComputedValue> inputs = signature1.Inputs;
        List<PlaceholderViewItem> source2 = list1;
        // ISSUE: reference to a compiler-generated field
        Func<PlaceholderViewItem, InputComputedValue> func5 = MetadataSignatureExtensions.\u003C\u003Ec.\u003C\u003E9__8_1;
        Func<PlaceholderViewItem, InputComputedValue> selector3;
        if (func5 == null)
        {
          // ISSUE: reference to a compiler-generated field
          MetadataSignatureExtensions.\u003C\u003Ec.\u003C\u003E9__8_1 = selector3 = (Func<PlaceholderViewItem, InputComputedValue>) (s =>
          {
            InputComputedValue signature3 = new InputComputedValue();
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            MetadataSignatureExtensions.\u003C\u003Ec.bFQPir8WNDuFAu4KSLDW((object) signature3, MetadataSignatureExtensions.\u003C\u003Ec.Y7Lg8N8W1MNNgpZSSKAN((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312494029), MetadataSignatureExtensions.\u003C\u003Ec.s3vZf78WP4mosKpYsuj3((object) s)));
            // ISSUE: reference to a compiler-generated method
            MetadataSignatureExtensions.\u003C\u003Ec.qgGJje8W3BTRV5EHoSfK((object) signature3, SlotViewItem.TypeUid);
            signature3.SubTypeUid = s.Uid;
            return signature3;
          });
        }
        else
          goto label_74;
label_62:
        IEnumerable<InputComputedValue> collection3 = source2.Select<PlaceholderViewItem, InputComputedValue>(selector3);
        inputs.AddRange(collection3);
        num1 = 2;
        continue;
label_74:
        selector3 = func5;
        goto label_62;
      }
label_4:
      return signature1;
    }

    /// <summary>Получить публичную сигнатуру модуля</summary>
    /// <param name="metadata">Метаданные модуля</param>
    /// <returns>Сигнатура модуля</returns>
    public static ModuleSignature GetSignature(this ModuleInfoMetadata metadata)
    {
      int num1 = 2;
      ModuleSignature signature1;
      List<ComponentMetadata>.Enumerator enumerator1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              signature1 = new ModuleSignature();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 5;
              continue;
            case 2:
              MetadataSignatureExtensions.sR1n50GDVVNg33deU2sk((object) metadata, MetadataSignatureExtensions.Di7R8kGDPiSavwra1y3J(1654249598 >> 2 ^ 413548321));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
              continue;
            case 3:
              goto label_5;
            case 4:
              // ISSUE: reference to a compiler-generated method
              signature1.Functions.AddRange(metadata.Functions.Where<FunctionMetadata>((Func<FunctionMetadata, bool>) (d => !d.Internal)).Select<FunctionMetadata, FunctionDependency>((Func<FunctionMetadata, FunctionDependency>) (d => (FunctionDependency) MetadataSignatureExtensions.\u003C\u003Ec.nKjJpx8W4KXEF7QtYNoQ((object) d))));
              num2 = 6;
              continue;
            case 5:
              goto label_55;
            case 6:
              enumerator1 = metadata.Components.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
              continue;
            case 7:
              List<ComponentSignature> components1 = signature1.Components;
              List<ComponentMetadata> components2 = metadata.Components;
              // ISSUE: reference to a compiler-generated field
              Func<ComponentMetadata, bool> func1 = MetadataSignatureExtensions.\u003C\u003Ec.\u003C\u003E9__9_2;
              Func<ComponentMetadata, bool> predicate1;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                MetadataSignatureExtensions.\u003C\u003Ec.\u003C\u003E9__9_2 = predicate1 = (Func<ComponentMetadata, bool>) (d => !MetadataSignatureExtensions.\u003C\u003Ec.MZ4hEp8WwI8uVV9DqsGK((object) d));
              }
              else
                goto label_67;
label_60:
              IEnumerable<ComponentMetadata> source = components2.Where<ComponentMetadata>(predicate1);
              // ISSUE: reference to a compiler-generated field
              Func<ComponentMetadata, ComponentSignature> func2 = MetadataSignatureExtensions.\u003C\u003Ec.\u003C\u003E9__9_3;
              Func<ComponentMetadata, ComponentSignature> selector;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                MetadataSignatureExtensions.\u003C\u003Ec.\u003C\u003E9__9_3 = selector = (Func<ComponentMetadata, ComponentSignature>) (d => d.GetSignature());
              }
              else
                goto label_66;
label_62:
              IEnumerable<ComponentSignature> collection1 = source.Select<ComponentMetadata, ComponentSignature>(selector);
              components1.AddRange(collection1);
              num2 = 4;
              continue;
label_66:
              selector = func2;
              goto label_62;
label_67:
              predicate1 = func1;
              goto label_60;
            default:
              goto label_6;
          }
        }
label_55:
        List<DataClassDependency> dataClasses1 = signature1.DataClasses;
        List<DataClassMetadata> dataClasses2 = metadata.DataClasses;
        // ISSUE: reference to a compiler-generated field
        Func<DataClassMetadata, bool> func3 = MetadataSignatureExtensions.\u003C\u003Ec.\u003C\u003E9__9_0;
        Func<DataClassMetadata, bool> predicate2;
        if (func3 == null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          MetadataSignatureExtensions.\u003C\u003Ec.\u003C\u003E9__9_0 = predicate2 = (Func<DataClassMetadata, bool>) (d => !MetadataSignatureExtensions.\u003C\u003Ec.MZ4hEp8WwI8uVV9DqsGK((object) d));
        }
        else
          goto label_65;
label_57:
        IEnumerable<DataClassDependency> collection2 = dataClasses2.Where<DataClassMetadata>(predicate2).Select<DataClassMetadata, DataClassDependency>((Func<DataClassMetadata, DataClassDependency>) (d => d.GetSignature()));
        dataClasses1.AddRange(collection2);
        num1 = 7;
        continue;
label_65:
        predicate2 = func3;
        goto label_57;
      }
label_5:
      return signature1;
label_6:
      try
      {
label_45:
        if (enumerator1.MoveNext())
          goto label_47;
        else
          goto label_46;
label_8:
        ComponentMetadata current;
        List<Implementation>.Enumerator enumerator2;
        int num3;
        while (true)
        {
          List<ExtensionPointViewItem>.Enumerator enumerator3;
          List<ExtensionPointViewItem> list;
          switch (num3)
          {
            case 1:
              if (MetadataSignatureExtensions.Ao7w2FGD4bpdAQYfgOgk(current.CustomTypeImplementation.TypeUid, Guid.Empty))
              {
                num3 = 5;
                continue;
              }
              break;
            case 2:
              goto label_47;
            case 3:
              if (MetadataSignatureExtensions.XV0oOGGDtYsGeBkuJwQP((object) current) != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 1;
                continue;
              }
              break;
            case 4:
              goto label_5;
            case 5:
              signature1.CustomTypes.Add(current.CustomTypeImplementation);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
              continue;
            case 6:
label_40:
              if (MetadataSignatureExtensions.gYwFjdGD6bhaU80umd4y((object) current.Implementations) != 0)
              {
                num3 = 9;
                continue;
              }
              goto label_45;
            case 7:
              enumerator3 = list.GetEnumerator();
              num3 = 8;
              continue;
            case 8:
              try
              {
label_15:
                if (enumerator3.MoveNext())
                  goto label_13;
                else
                  goto label_16;
label_10:
                int num4;
                ExtensionPointViewItem extensionPoint;
                while (true)
                {
                  switch (num4)
                  {
                    case 2:
                      goto label_13;
                    case 3:
                      extensionPoint = enumerator3.Current;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 5 : 1;
                      continue;
                    case 4:
                      List<ImplementationSignature> extensionPoints = signature1.ExtensionPoints;
                      List<ExtensionPointViewItem> source = list;
                      // ISSUE: reference to a compiler-generated field
                      Func<ExtensionPointViewItem, ImplementationSignature> func = MetadataSignatureExtensions.\u003C\u003Ec.\u003C\u003E9__9_8;
                      Func<ExtensionPointViewItem, ImplementationSignature> selector;
                      if (func == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        MetadataSignatureExtensions.\u003C\u003Ec.\u003C\u003E9__9_8 = selector = (Func<ExtensionPointViewItem, ImplementationSignature>) (s =>
                        {
                          ImplementationSignature signature2 = new ImplementationSignature();
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          MetadataSignatureExtensions.\u003C\u003Ec.KvCR3U8WaYM8yKUEOlZu((object) signature2, MetadataSignatureExtensions.\u003C\u003Ec.wRDYjc8Wt3xxq8xsg9sw((object) s));
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          MetadataSignatureExtensions.\u003C\u003Ec.fP5TUR8WHG4P81H99Nhb((object) signature2, MetadataSignatureExtensions.\u003C\u003Ec.Q9bxIB8W6OMswTpLkSt6((object) s));
                          return signature2;
                        });
                      }
                      else
                        goto label_64;
label_19:
                      IEnumerable<ImplementationSignature> collection = source.Select<ExtensionPointViewItem, ImplementationSignature>(selector);
                      extensionPoints.AddRange(collection);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
                      continue;
label_64:
                      selector = func;
                      goto label_19;
                    case 5:
                      if (signature1.ExtensionPoints.Any<ImplementationSignature>((Func<ImplementationSignature, bool>) (i =>
                      {
                        int num5 = 1;
                        while (true)
                        {
                          switch (num5)
                          {
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              if (MetadataSignatureExtensions.\u003C\u003Ec__DisplayClass9_0.R9am6b8WM3JKBTdTm5lb(MetadataSignatureExtensions.\u003C\u003Ec__DisplayClass9_0.ab3SWM8WmjhcOKRBym9H((object) i), MetadataSignatureExtensions.\u003C\u003Ec__DisplayClass9_0.v2TRh08WykcuPviXT2R2((object) extensionPoint)))
                              {
                                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
                                continue;
                              }
                              goto label_5;
                            default:
                              goto label_4;
                          }
                        }
label_4:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        return MetadataSignatureExtensions.\u003C\u003Ec__DisplayClass9_0.lxVZpN8WdSe4fTCvieQI(MetadataSignatureExtensions.\u003C\u003Ec__DisplayClass9_0.xQFdaw8WJSLY4cdwPHNP((object) i), MetadataSignatureExtensions.\u003C\u003Ec__DisplayClass9_0.NqTtum8W9NmsQTpAb2AM((object) extensionPoint));
label_5:
                        return false;
                      })))
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
                        continue;
                      }
                      goto case 4;
                    case 6:
                      goto label_40;
                    default:
                      goto label_15;
                  }
                }
label_13:
                num4 = 3;
                goto label_10;
label_16:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 6 : 3;
                goto label_10;
              }
              finally
              {
                enumerator3.Dispose();
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                }
              }
            case 9:
              enumerator2 = current.Implementations.GetEnumerator();
              num3 = 10;
              continue;
            case 10:
              goto label_27;
            case 11:
              goto label_45;
          }
          list = ((RootViewItem) MetadataSignatureExtensions.gXBwrjGDpFo8USaKmcJK(MetadataSignatureExtensions.nxvEoWGDSw3cwObtcueW((object) current))).FindItems(itemCondition: (Func<ViewItem, bool>) (s => s is ExtensionPointViewItem)).Cast<ExtensionPointViewItem>().ToList<ExtensionPointViewItem>();
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 5 : 7;
        }
label_27:
        try
        {
label_31:
          if (enumerator2.MoveNext())
            goto label_29;
          else
            goto label_32;
label_28:
          int num7;
          Implementation implementation;
          while (true)
          {
            switch (num7)
            {
              case 1:
                goto label_31;
              case 2:
                goto label_29;
              case 3:
                List<ImplementationSignature> implementations = signature1.Implementations;
                ImplementationSignature implementationSignature = new ImplementationSignature();
                MetadataSignatureExtensions.bXCWWKGDA0dHMxVXAfOP((object) implementationSignature, MetadataSignatureExtensions.LVr7hrGDH4GYmylyChvi((object) implementation));
                MetadataSignatureExtensions.SgaC93GDxMXPpeXBRO1g((object) implementationSignature, MetadataSignatureExtensions.hbVPjlGD7ooJke6vmSsZ((object) implementation));
                implementations.Add(implementationSignature);
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
                continue;
              case 4:
                if (!signature1.Implementations.Any<ImplementationSignature>((Func<ImplementationSignature, bool>) (i =>
                {
                  int num8 = 1;
                  while (true)
                  {
                    switch (num8)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        if (MetadataSignatureExtensions.\u003C\u003Ec__DisplayClass9_1.mSOVpP8WY52TBD3EoHvu(MetadataSignatureExtensions.\u003C\u003Ec__DisplayClass9_1.uyTNl08Wjsfvj0eXWHwR((object) i), implementation.TypeUid))
                        {
                          num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
                          continue;
                        }
                        goto label_5;
                      default:
                        goto label_4;
                    }
                  }
label_4:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  return MetadataSignatureExtensions.\u003C\u003Ec__DisplayClass9_1.F6CHFc8WsL2vX67nxI7c(MetadataSignatureExtensions.\u003C\u003Ec__DisplayClass9_1.znd0gX8WLDgDFdW2RMbR((object) i), MetadataSignatureExtensions.\u003C\u003Ec__DisplayClass9_1.BUjDOP8WUILejMf7wBge((object) implementation));
label_5:
                  return false;
                })))
                {
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 3 : 1;
                  continue;
                }
                goto label_31;
              case 5:
                implementation = enumerator2.Current;
                num7 = 4;
                continue;
              default:
                goto label_45;
            }
          }
label_29:
          num7 = 5;
          goto label_28;
label_32:
          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
          goto label_28;
        }
        finally
        {
          enumerator2.Dispose();
          int num9 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
            num9 = 0;
          switch (num9)
          {
            default:
          }
        }
label_46:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 4 : 4;
        goto label_8;
label_47:
        current = enumerator1.Current;
        num3 = 3;
        goto label_8;
      }
      finally
      {
        enumerator1.Dispose();
        int num10 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
          num10 = 0;
        switch (num10)
        {
          default:
        }
      }
    }

    /// <summary>Создать сигнатуру свойства</summary>
    /// <param name="property">Метаданные свойства</param>
    /// <returns>Сигнатура свойства</returns>
    public static PropertySignature CreatePropertySignature(this IPropertyMetadata property)
    {
      int num1 = 13;
      PropertySignature propertySignature1;
      while (true)
      {
        int num2 = num1;
        TypeSignature typeSignature1;
        TypeSettings typeSettings;
        while (true)
        {
          switch (num2)
          {
            case 1:
              propertySignature1.Type.RelationType = RelationType.ManyToMany;
              num2 = 14;
              continue;
            case 2:
              if (typeSettings != null)
              {
                num2 = 5;
                continue;
              }
              goto label_18;
            case 3:
              if (typeSettings is DataClassSettings dataClassSettings)
              {
                num2 = 19;
                continue;
              }
              goto case 20;
            case 4:
            case 10:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 1;
              continue;
            case 5:
              if (!(typeSettings is EntitySettings entitySettings))
                goto case 3;
              else
                goto label_6;
            case 6:
              MetadataSignatureExtensions.hQ7cLlGD5ncfUG70KI3F(MetadataSignatureExtensions.SJpELpGDghJa3l5TthLt((object) propertySignature1), entitySettings.RelationType);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 12 : 22;
              continue;
            case 7:
            case 17:
              num2 = 6;
              continue;
            case 8:
              MetadataSignatureExtensions.VNUaJwGDlPIbOgV5A20m((object) propertySignature1, (object) typeSignature1);
              num2 = 21;
              continue;
            case 9:
              MetadataSignatureExtensions.hQ7cLlGD5ncfUG70KI3F((object) propertySignature1.Type, dataClassSettings.RelationType);
              num2 = 18;
              continue;
            case 11:
              if (property is PropertyMetadata propertyMetadata)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
                continue;
              }
              goto case 8;
            case 12:
              goto label_8;
            case 13:
              goto label_13;
            case 14:
              goto label_3;
            case 15:
            case 19:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 9 : 7;
              continue;
            case 16:
            case 18:
            case 22:
            case 23:
              goto label_18;
            case 20:
              if (!(typeSettings is ListOfSimpleTypeSettings simpleTypeSettings))
              {
                num2 = 23;
                continue;
              }
              goto case 4;
            case 21:
              typeSettings = (TypeSettings) MetadataSignatureExtensions.GbC3M4GDrYK0qQyrSZA4((object) property);
              num2 = 2;
              continue;
            default:
              typeSignature1.Nullable = propertyMetadata.Nullable;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 8 : 7;
              continue;
          }
        }
label_3:
        MetadataSignatureExtensions.InFYoSGDdyt7b8E6mmUh(MetadataSignatureExtensions.SJpELpGDghJa3l5TthLt((object) propertySignature1), MetadataSignatureExtensions.rCODdqGDeVT8t9u3E2Ej((object) simpleTypeSettings));
        num1 = 16;
        continue;
label_6:
        num1 = 7;
        continue;
label_8:
        TypeSignature typeSignature2 = new TypeSignature();
        MetadataSignatureExtensions.YwSoeOGDJpYKjASlk1AX((object) typeSignature2, MetadataSignatureExtensions.LG3MQSGDMmfv5VFIelb6((object) property));
        MetadataSignatureExtensions.InFYoSGDdyt7b8E6mmUh((object) typeSignature2, MetadataSignatureExtensions.v4a6pDGD9D5RokctG295((object) property));
        typeSignature1 = typeSignature2;
        num1 = 11;
        continue;
label_13:
        PropertySignature propertySignature2 = new PropertySignature();
        MetadataSignatureExtensions.MNs7hOGD04JPKojylJyE((object) propertySignature2, (object) property.Name);
        MetadataSignatureExtensions.hnwdaEGDy5F4IpNcrLhS((object) propertySignature2, MetadataSignatureExtensions.P2m1k5GDmv3mRDtEMxZx((object) property));
        propertySignature1 = propertySignature2;
        num1 = 12;
      }
label_18:
      return propertySignature1;
    }

    /// <summary>Проверить совместимость типов по сигнатуре</summary>
    /// <param name="old">Сигнатура с которой производится сравнение</param>
    /// <param name="new">Сигнатура</param>
    /// <returns>Результат проверки совместимости</returns>
    public static CompatibilityResult Compatible(this TypeSignature old, TypeSignature @new)
    {
      int num1 = 14;
      List<string> errors;
      while (true)
      {
        int num2 = num1;
        string typeDisplayName;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
              errors = new List<string>();
              num2 = 11;
              continue;
            case 2:
              if (MetadataSignatureExtensions.Ao7w2FGD4bpdAQYfgOgk(MetadataSignatureExtensions.jjHeWFGDsaUJdhW9ZLAm((object) old), MetadataSignatureExtensions.jjHeWFGDsaUJdhW9ZLAm((object) @new)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 4;
                continue;
              }
              goto case 5;
            case 3:
              errors.Add(EleWise.ELMA.SR.T((string) MetadataSignatureExtensions.Di7R8kGDPiSavwra1y3J(-951514650 ^ -951388898), (object) str, (object) typeDisplayName));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
              continue;
            case 4:
            case 12:
              str = (string) MetadataSignatureExtensions.Fja1ZLGDz2cE1jjEAgQM((object) old);
              num2 = 10;
              continue;
            case 5:
              if (!MetadataSignatureExtensions.Ao7w2FGD4bpdAQYfgOgk(old.SubTypeUid, MetadataSignatureExtensions.g12TBxGDcyJVMjY2rMDn((object) @new)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 8 : 4;
                continue;
              }
              goto case 4;
            case 6:
              errors.Add((string) MetadataSignatureExtensions.pDb11lGDLTxF9MBoRlTb(MetadataSignatureExtensions.Di7R8kGDPiSavwra1y3J(712480695 ^ 712272683)));
              num2 = 2;
              continue;
            case 7:
              if (MetadataSignatureExtensions.HCVslLGDUvOQAGegXWVs((object) old) != MetadataSignatureExtensions.HCVslLGDUvOQAGegXWVs((object) @new))
              {
                num2 = 6;
                continue;
              }
              goto case 2;
            case 9:
              errors.Add((string) MetadataSignatureExtensions.pDb11lGDLTxF9MBoRlTb(MetadataSignatureExtensions.Di7R8kGDPiSavwra1y3J(1253244298 - 1829393894 ^ -575972424)));
              num2 = 7;
              continue;
            case 10:
              typeDisplayName = GetTypeDisplayName(@new);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 3 : 3;
              continue;
            case 11:
              if (old.Nullable != MetadataSignatureExtensions.lmqtqfGDYwhiIkGeOiD1((object) @new))
              {
                num2 = 9;
                continue;
              }
              goto case 7;
            case 13:
              MetadataSignatureExtensions.wjSeWhGDjwW3XdW6v5Rx((object) @new, MetadataSignatureExtensions.Di7R8kGDPiSavwra1y3J(901793403 ^ 901798977));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
              continue;
            case 14:
              goto label_10;
            default:
              goto label_18;
          }
        }
label_10:
        MetadataSignatureExtensions.wjSeWhGDjwW3XdW6v5Rx((object) old, MetadataSignatureExtensions.Di7R8kGDPiSavwra1y3J(-1822890472 ^ -1822825900));
        num1 = 13;
      }
label_18:
      return new CompatibilityResult(MetadataSignatureExtensions.jFwma5GtFx7UjmZyU6fc((object) errors) == 0, (IEnumerable<string>) errors);

      static string GetTypeDisplayName(TypeSignature type)
      {
        string typeDisplayName;
        switch (1)
        {
          case 1:
            try
            {
              int num;
              if (!(MetadataSignatureExtensions.heae7DGtQMEVtVKRK2PI(MetadataSignatureExtensions.WV1emyGtfQFGvdjyu0UP(), MetadataSignatureExtensions.jjHeWFGDsaUJdhW9ZLAm((object) type), MetadataSignatureExtensions.g12TBxGDcyJVMjY2rMDn((object) type)) is IPropertyTypeInfo propertyTypeInfo))
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 1 : 1;
              else
                goto label_5;
label_3:
              string str;
              switch (num)
              {
                case 1:
                  str = string.Empty;
                  goto label_6;
                default:
                  goto label_13;
              }
label_5:
              str = propertyTypeInfo.GetTypeDisplayName(MetadataSignatureExtensions.g12TBxGDcyJVMjY2rMDn((object) type));
label_6:
              typeDisplayName = str;
              num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
              {
                num = 0;
                goto label_3;
              }
              else
                goto label_3;
            }
            catch (Exception ex)
            {
              int num = 2;
              string str;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    goto label_13;
                  case 2:
                    str = (string) MetadataSignatureExtensions.Y4oYZLGtC5DnFFS1AsTF(MetadataSignatureExtensions.Di7R8kGDPiSavwra1y3J(1669371371 ^ 1669426107), (object) MetadataSignatureExtensions.jjHeWFGDsaUJdhW9ZLAm((object) type), (object) MetadataSignatureExtensions.g12TBxGDcyJVMjY2rMDn((object) type));
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 3 : 1;
                    continue;
                  case 3:
                    Logger.Log.Error((object) EleWise.ELMA.SR.T((string) MetadataSignatureExtensions.Di7R8kGDPiSavwra1y3J(-643786247 ^ -643603417), (object) str));
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
                    continue;
                  default:
                    typeDisplayName = str;
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
                    continue;
                }
              }
            }
        }
label_13:
        return typeDisplayName;
      }
    }

    /// <summary>Проверить совместимость DTO</summary>
    /// <param name="old">Зависимость DTO</param>
    /// <param name="new">Новая зависимость DTO</param>
    /// <returns>Результат проверки совместимости</returns>
    public static CompatibilityResult Compatible(
      this DataClassDependency old,
      DataClassDependency @new)
    {
      int num1 = 3;
      List<string> errors;
      List<PropertySignature>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            enumerator = old.Properties.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
            continue;
          case 3:
            errors = new List<string>();
            num1 = 2;
            continue;
          default:
            goto label_3;
        }
      }
label_2:
      return new CompatibilityResult(errors.Count == 0, (IEnumerable<string>) errors);
label_3:
      try
      {
label_8:
        if (enumerator.MoveNext())
          goto label_17;
        else
          goto label_9;
label_6:
        // ISSUE: variable of a compiler-generated type
        MetadataSignatureExtensions.\u003C\u003Ec__DisplayClass12_0 cDisplayClass120;
        int num2;
        while (true)
        {
          int num3;
          CompatibilityResult compatibilityResult;
          // ISSUE: variable of a compiler-generated type
          MetadataSignatureExtensions.\u003C\u003Ec__DisplayClass12_1 cDisplayClass121;
          PropertySignature propertySignature;
          switch (num2)
          {
            case 1:
              if (propertySignature != null)
              {
                num2 = 17;
                continue;
              }
              goto case 14;
            case 2:
              // ISSUE: reference to a compiler-generated method
              propertySignature = @new.Properties.Find(new Predicate<PropertySignature>(cDisplayClass121.\u003CCompatible\u003Eb__0));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 1;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass120.currentProperty = enumerator.Current;
              num3 = 12;
              break;
            case 4:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass121.CS\u0024\u003C\u003E8__locals1 = cDisplayClass120;
              num2 = 10;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated method
              errors.AddRange(((IEnumerable<string>) MetadataSignatureExtensions.sPYwuIGtbLTMtwku5D0u((object) compatibilityResult)).Select<string, string>(new Func<string, string>(cDisplayClass121.\u003CCompatible\u003Eb__1)));
              num3 = 15;
              break;
            case 6:
            case 15:
              goto label_8;
            case 7:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass121.basePhrase = EleWise.ELMA.SR.T((string) MetadataSignatureExtensions.Di7R8kGDPiSavwra1y3J(1461625753 ^ 1461542615), MetadataSignatureExtensions.OxBKYqGtBg4EfV7Qxn6k((object) old), (object) cDisplayClass121.propertyName);
              num2 = 2;
              continue;
            case 8:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              compatibilityResult = (CompatibilityResult) MetadataSignatureExtensions.cK6WPjGtoD7Fjvi4lPqg(MetadataSignatureExtensions.SJpELpGDghJa3l5TthLt((object) cDisplayClass121.CS\u0024\u003C\u003E8__locals1.currentProperty), MetadataSignatureExtensions.SJpELpGDghJa3l5TthLt((object) propertySignature));
              num2 = 11;
              continue;
            case 9:
              goto label_17;
            case 10:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass121.propertyName = cDisplayClass121.CS\u0024\u003C\u003E8__locals1.currentProperty.Name;
              num2 = 7;
              continue;
            case 11:
              if (!compatibilityResult.IsValid)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 5 : 5;
                continue;
              }
              goto label_8;
            case 12:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass121 = new MetadataSignatureExtensions.\u003C\u003Ec__DisplayClass12_1();
              num2 = 4;
              continue;
            case 13:
              goto label_2;
            case 14:
              // ISSUE: reference to a compiler-generated field
              errors.Add(EleWise.ELMA.SR.T((string) MetadataSignatureExtensions.Di7R8kGDPiSavwra1y3J(-441065788 ^ -2092910478 ^ 1727437774), (object) cDisplayClass121.basePhrase));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 3 : 6;
              continue;
            case 16:
              // ISSUE: reference to a compiler-generated field
              errors.Add(EleWise.ELMA.SR.T((string) MetadataSignatureExtensions.Di7R8kGDPiSavwra1y3J(-87337865 ^ -87512597), (object) cDisplayClass121.basePhrase, MetadataSignatureExtensions.s2GC3JGtWdkBeZ9bWNPf((object) propertySignature)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 8;
              continue;
            default:
              // ISSUE: reference to a compiler-generated field
              if ((string) MetadataSignatureExtensions.s2GC3JGtWdkBeZ9bWNPf((object) propertySignature) != cDisplayClass121.propertyName)
              {
                num2 = 16;
                continue;
              }
              goto case 8;
          }
          num2 = num3;
        }
label_9:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 13 : 13;
        goto label_6;
label_17:
        // ISSUE: object of a compiler-generated type is created
        cDisplayClass120 = new MetadataSignatureExtensions.\u003C\u003Ec__DisplayClass12_0();
        num2 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
        {
          num2 = 3;
          goto label_6;
        }
        else
          goto label_6;
      }
      finally
      {
        enumerator.Dispose();
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
    }

    /// <summary>Проверить совместимость функций</summary>
    /// <param name="old">Зависимость</param>
    /// <param name="new">Новая зависимость</param>
    /// <returns>Результат проверки совместимости</returns>
    public static CompatibilityResult Compatible(
      this FunctionDependency old,
      FunctionDependency @new)
    {
      int num = 6;
      List<string> errors;
      while (true)
      {
        CompatibilityResult compatibilityResult1;
        CompatibilityResult compatibilityResult2;
        switch (num)
        {
          case 1:
            errors.Add(EleWise.ELMA.SR.T((string) MetadataSignatureExtensions.Di7R8kGDPiSavwra1y3J(-218496594 ^ -218554088), MetadataSignatureExtensions.OxBKYqGtBg4EfV7Qxn6k((object) @new)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 2 : 3;
            continue;
          case 2:
          case 7:
            compatibilityResult2 = (CompatibilityResult) MetadataSignatureExtensions.cK6WPjGtoD7Fjvi4lPqg(MetadataSignatureExtensions.vFYdjwGtEVcDCRAQG6DH((object) old), MetadataSignatureExtensions.vFYdjwGtEVcDCRAQG6DH((object) @new));
            num = 8;
            continue;
          case 3:
            errors.AddRange((IEnumerable<string>) MetadataSignatureExtensions.sPYwuIGtbLTMtwku5D0u((object) compatibilityResult1));
            num = 2;
            continue;
          case 4:
            compatibilityResult1 = (CompatibilityResult) MetadataSignatureExtensions.cK6WPjGtoD7Fjvi4lPqg(MetadataSignatureExtensions.V0V6MSGthRlWnXZVc13o((object) old), MetadataSignatureExtensions.V0V6MSGthRlWnXZVc13o((object) @new));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 7 : 9;
            continue;
          case 5:
            MetadataSignatureExtensions.wjSeWhGDjwW3XdW6v5Rx((object) @new, MetadataSignatureExtensions.Di7R8kGDPiSavwra1y3J(1033719030 - 2012070891 ^ -978349263));
            num = 13;
            continue;
          case 6:
            MetadataSignatureExtensions.wjSeWhGDjwW3XdW6v5Rx((object) old, MetadataSignatureExtensions.Di7R8kGDPiSavwra1y3J(1033719030 - 2012070891 ^ -978416313));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 5 : 2;
            continue;
          case 8:
            if (MetadataSignatureExtensions.xSuHjQGtG8C3G0RahZtv((object) compatibilityResult2))
            {
              num = 10;
              continue;
            }
            break;
          case 9:
            if (MetadataSignatureExtensions.xSuHjQGtG8C3G0RahZtv((object) compatibilityResult1))
            {
              num = 7;
              continue;
            }
            goto case 1;
          case 10:
          case 12:
            goto label_9;
          case 11:
            errors.AddRange((IEnumerable<string>) MetadataSignatureExtensions.sPYwuIGtbLTMtwku5D0u((object) compatibilityResult2));
            num = 12;
            continue;
          case 13:
            errors = new List<string>();
            num = 4;
            continue;
        }
        errors.Add(EleWise.ELMA.SR.T((string) MetadataSignatureExtensions.Di7R8kGDPiSavwra1y3J(-1598106783 - -968262081 ^ -629771142), MetadataSignatureExtensions.OxBKYqGtBg4EfV7Qxn6k((object) @new)));
        num = 11;
      }
label_9:
      return new CompatibilityResult(MetadataSignatureExtensions.jFwma5GtFx7UjmZyU6fc((object) errors) == 0, (IEnumerable<string>) errors);
    }

    internal static bool gH68ZLGazFMjNbcLx5tl() => MetadataSignatureExtensions.mZOGr5GacO8UGN80jNH1 == null;

    internal static MetadataSignatureExtensions k5LxwVGDF6bqtYwjMZjP() => MetadataSignatureExtensions.mZOGr5GacO8UGN80jNH1;

    internal static bool OTbBggGDBg4pEtiCOqY8([In] object obj0) => ((EntityMetadata) obj0).Hierarchical;

    internal static HierarchyType qoNgF4GDWxHweRJXPK21([In] object obj0) => ((EntityMetadata) obj0).HierarchyType;

    internal static Guid goaR8uGDosDJHgKtUhmW([In] object obj0) => ((EntityMetadata) obj0).IsGroupPropertyUid;

    internal static Guid lWTrv2GDbelpcmmO23Sn([In] object obj0) => ((EntityMetadata) obj0).ParentPropertyUid;

    internal static Guid n33rXiGDhqNtg7UwT1Xx([In] object obj0) => ((AbstractMetadata) obj0).ModuleUid;

    internal static void i5NXBgGDGC62PGq0aycJ([In] object obj0, Guid value) => ((Dependency) obj0).ModuleUid = value;

    internal static object aLklGDGDE5yksJrsmWTH([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static void fiH35RGDfy4htl4100Iy([In] object obj0, [In] object obj1) => ((Dependency) obj0).Name = (string) obj1;

    internal static object AHEiIMGDQJYl5XsJ4O6i([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static void OwSC01GDCg80Tn5LUePD([In] object obj0, [In] object obj1) => ((Dependency) obj0).DisplayName = (string) obj1;

    internal static object b9MsMvGDvMGr5rmZ1wdu([In] object obj0) => (object) ((FunctionMetadata) obj0).ParameterType;

    internal static void w1vBeyGD8gf3fWgA9p3c([In] object obj0, [In] object obj1) => ((FunctionDependency) obj0).ReturnType = (TypeSignature) obj1;

    internal static void bv3uZlGDZHUSPrcgIemk([In] object obj0, Guid value) => ((Dependency) obj0).HeaderUid = value;

    internal static Guid Nbf3B8GDuaNJ1cFVP5k4([In] object obj0) => ((ViewItem) obj0).Uid;

    internal static Guid nd1NKpGDI6tAWHusdK7h([In] object obj0) => ((ComponentViewItem) obj0).HeaderUid;

    internal static void sR1n50GDVVNg33deU2sk([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object nxvEoWGDSw3cwObtcueW([In] object obj0) => (object) ((ComponentMetadata) obj0).Content;

    internal static object f3hC2rGDit14b1eyeA2f([In] object obj0) => (object) ((ComponentContentMetadata) obj0).Context;

    internal static bool NgkYqhGDRwAcFkoeEJax([In] object obj0) => ((IViewModelPropertyMetadata) obj0).Input;

    internal static bool NJXvrGGDq7d8buuTStVj([In] object obj0) => ((IViewModelPropertyMetadata) obj0).Output;

    internal static Guid adrkkCGDKkuTUhcNr9sU([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static void pAGDy3GDXb9MypLP4gun([In] object obj0, [In] object obj1) => ((ActionInputComputedValue) obj0).ParameterType = (TypeSignature) obj1;

    internal static object kD6c8fGDTri4VbNa4x0M([In] object obj0) => (object) ((ActionSettings) obj0).ReturnType;

    internal static void yHjA0SGDkyPXc1Fx1L9k([In] object obj0, Guid value) => ((InputComputedValue) obj0).SubTypeUid = value;

    internal static RelationType YHlvi5GDnxARJHRYDRiG([In] object obj0) => ((EntitySettings) obj0).RelationType;

    internal static void PeDxSwGDOmAnWJEuYAwF([In] object obj0, RelationType value) => ((InputComputedValue) obj0).RelationType = value;

    internal static RelationType uKFQdmGD21lnHKV8q1GU([In] object obj0) => ((DataClassSettings) obj0).RelationType;

    internal static Guid rCODdqGDeVT8t9u3E2Ej([In] object obj0) => ((ListOfSimpleTypeSettings) obj0).SimpleTypeUid;

    internal static object Di7R8kGDPiSavwra1y3J(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void rhXja4GD1VO5aRPuOsem([In] object obj0, Guid value) => ((InputComputedValue) obj0).TypeUid = value;

    internal static bool BpEhpWGDNNQ3wCTJrKXl([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static void IWAJ3dGD306iGhDcv0du([In] object obj0, bool value) => ((InputComputedValue) obj0).Nullable = value;

    internal static object gXBwrjGDpFo8USaKmcJK([In] object obj0) => (object) ((ComponentContentMetadata) obj0).View;

    internal static int EqBK79GDad6enJjPwjXO([In] object obj0) => ((List<PlaceholderViewItem>) obj0).Count;

    internal static bool Ha4rofGDD9B2s2RRrcj6([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object XV0oOGGDtYsGeBkuJwQP([In] object obj0) => (object) ((ComponentMetadata) obj0).CustomTypeImplementation;

    internal static void uU2H3bGDw2EGDcIRRFUd([In] object obj0, [In] object obj1) => ((ComponentSignature) obj0).CustomType = (CustomTypeImplementationModel) obj1;

    internal static bool Ao7w2FGD4bpdAQYfgOgk([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static int gYwFjdGD6bhaU80umd4y([In] object obj0) => ((List<Implementation>) obj0).Count;

    internal static object LVr7hrGDH4GYmylyChvi([In] object obj0) => (object) ((Implementation) obj0).PointId;

    internal static void bXCWWKGDA0dHMxVXAfOP([In] object obj0, [In] object obj1) => ((ImplementationSignature) obj0).PointId = (string) obj1;

    internal static Guid hbVPjlGD7ooJke6vmSsZ([In] object obj0) => ((Implementation) obj0).TypeUid;

    internal static void SgaC93GDxMXPpeXBRO1g([In] object obj0, Guid value) => ((ImplementationSignature) obj0).TypeUid = value;

    internal static void MNs7hOGD04JPKojylJyE([In] object obj0, [In] object obj1) => ((PropertySignature) obj0).Name = (string) obj1;

    internal static Guid P2m1k5GDmv3mRDtEMxZx([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static void hnwdaEGDy5F4IpNcrLhS([In] object obj0, Guid value) => ((PropertySignature) obj0).Uid = value;

    internal static Guid LG3MQSGDMmfv5VFIelb6([In] object obj0) => ((IPropertyMetadata) obj0).TypeUid;

    internal static void YwSoeOGDJpYKjASlk1AX([In] object obj0, Guid value) => ((TypeSignature) obj0).TypeUid = value;

    internal static Guid v4a6pDGD9D5RokctG295([In] object obj0) => ((IPropertyMetadata) obj0).SubTypeUid;

    internal static void InFYoSGDdyt7b8E6mmUh([In] object obj0, Guid value) => ((TypeSignature) obj0).SubTypeUid = value;

    internal static void VNUaJwGDlPIbOgV5A20m([In] object obj0, [In] object obj1) => ((PropertySignature) obj0).Type = (TypeSignature) obj1;

    internal static object GbC3M4GDrYK0qQyrSZA4([In] object obj0) => (object) ((IPropertyMetadata) obj0).Settings;

    internal static object SJpELpGDghJa3l5TthLt([In] object obj0) => (object) ((PropertySignature) obj0).Type;

    internal static void hQ7cLlGD5ncfUG70KI3F([In] object obj0, RelationType value) => ((TypeSignature) obj0).RelationType = value;

    internal static void wjSeWhGDjwW3XdW6v5Rx([In] object obj0, [In] object obj1) => Contract.NotNull(obj0, (string) obj1);

    internal static bool lmqtqfGDYwhiIkGeOiD1([In] object obj0) => ((TypeSignature) obj0).Nullable;

    internal static object pDb11lGDLTxF9MBoRlTb([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static RelationType HCVslLGDUvOQAGegXWVs([In] object obj0) => ((TypeSignature) obj0).RelationType;

    internal static Guid jjHeWFGDsaUJdhW9ZLAm([In] object obj0) => ((TypeSignature) obj0).TypeUid;

    internal static Guid g12TBxGDcyJVMjY2rMDn([In] object obj0) => ((TypeSignature) obj0).SubTypeUid;

    internal static object Fja1ZLGDz2cE1jjEAgQM([In] object obj0)
    {
      return (object) GetTypeDisplayName((TypeSignature) obj0);

      static string GetTypeDisplayName(TypeSignature type)
      {
        string typeDisplayName;
        switch (1)
        {
          case 1:
            try
            {
              int num;
              if (!(MetadataSignatureExtensions.heae7DGtQMEVtVKRK2PI(MetadataSignatureExtensions.WV1emyGtfQFGvdjyu0UP(), MetadataSignatureExtensions.jjHeWFGDsaUJdhW9ZLAm((object) type), MetadataSignatureExtensions.g12TBxGDcyJVMjY2rMDn((object) type)) is IPropertyTypeInfo propertyTypeInfo))
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 1 : 1;
              else
                goto label_5;
label_3:
              string str;
              switch (num)
              {
                case 1:
                  str = string.Empty;
                  goto label_6;
                default:
                  goto label_13;
              }
label_5:
              str = propertyTypeInfo.GetTypeDisplayName(MetadataSignatureExtensions.g12TBxGDcyJVMjY2rMDn((object) type));
label_6:
              typeDisplayName = str;
              num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
              {
                num = 0;
                goto label_3;
              }
              else
                goto label_3;
            }
            catch (Exception ex)
            {
              int num = 2;
              string str;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    goto label_13;
                  case 2:
                    str = (string) MetadataSignatureExtensions.Y4oYZLGtC5DnFFS1AsTF(MetadataSignatureExtensions.Di7R8kGDPiSavwra1y3J(1669371371 ^ 1669426107), (object) MetadataSignatureExtensions.jjHeWFGDsaUJdhW9ZLAm((object) type), (object) MetadataSignatureExtensions.g12TBxGDcyJVMjY2rMDn((object) type));
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 3 : 1;
                    continue;
                  case 3:
                    Logger.Log.Error((object) EleWise.ELMA.SR.T((string) MetadataSignatureExtensions.Di7R8kGDPiSavwra1y3J(-643786247 ^ -643603417), (object) str));
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
                    continue;
                  default:
                    typeDisplayName = str;
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
                    continue;
                }
              }
            }
        }
label_13:
        return typeDisplayName;
      }
    }

    internal static int jFwma5GtFx7UjmZyU6fc([In] object obj0) => ((List<string>) obj0).Count;

    internal static object OxBKYqGtBg4EfV7Qxn6k([In] object obj0) => (object) ((Dependency) obj0).DisplayName;

    internal static object s2GC3JGtWdkBeZ9bWNPf([In] object obj0) => (object) ((PropertySignature) obj0).Name;

    internal static object cK6WPjGtoD7Fjvi4lPqg([In] object obj0, [In] object obj1) => (object) ((TypeSignature) obj0).Compatible((TypeSignature) obj1);

    internal static object sPYwuIGtbLTMtwku5D0u([In] object obj0) => (object) ((CompatibilityResult) obj0).Errors;

    internal static object V0V6MSGthRlWnXZVc13o([In] object obj0) => (object) ((FunctionDependency) obj0).ParameterType;

    internal static bool xSuHjQGtG8C3G0RahZtv([In] object obj0) => ((CompatibilityResult) obj0).IsValid;

    internal static object vFYdjwGtEVcDCRAQG6DH([In] object obj0) => (object) ((FunctionDependency) obj0).ReturnType;

    internal static object WV1emyGtfQFGvdjyu0UP() => (object) MetadataServiceContext.Service;

    internal static object heae7DGtQMEVtVKRK2PI([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static object Y4oYZLGtC5DnFFS1AsTF([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);
  }
}
