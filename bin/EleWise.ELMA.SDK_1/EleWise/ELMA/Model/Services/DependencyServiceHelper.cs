// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.DependencyServiceHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>
  /// Помощник для сервиса <see cref="T:EleWise.ELMA.Model.Services.DependencyService" />
  /// </summary>
  public static class DependencyServiceHelper
  {
    private static IEnumerable<ITypeDescriptor> descriptors;
    internal static DependencyServiceHelper gcTskcbClJXvDoem6Cep;

    private static IEnumerable<ITypeDescriptor> Descriptors => DependencyServiceHelper.descriptors ?? (DependencyServiceHelper.descriptors = Locator.GetServiceNotNull<IEnumerable<ITypeDescriptor>>());

    /// <summary>Анализ сигнатуры типа</summary>
    /// <param name="signature">Сигнатура</param>
    /// <param name="dataClassDependencies">Зависимости от структур обмена данными</param>
    /// <param name="entityDependencies">Зависимости от сущностей</param>
    /// <param name="enumDependencies">Зависимости от перечислений</param>
    /// <param name="currentModuleUid">Текущий модуль</param>
    /// <param name="options">Настройки для анализа зависимостей</param>
    /// <exception cref="T:EleWise.ELMA.Exceptions.MetadataLoadException">Ошибка загрузки метаданных возникает, если не найдены метаданные</exception>
    internal static void AnalyseTypeSignature(
      TypeSignature signature,
      IDictionary<Guid, DataClassDependency> dataClassDependencies,
      IDictionary<Guid, EntityDependency> entityDependencies,
      IDictionary<Guid, EnumDependency> enumDependencies,
      Guid currentModuleUid,
      DependencyServiceOptions options)
    {
      if (DependencyServiceHelper.IsDataClass(signature.TypeUid, signature.SubTypeUid))
      {
        if (!(MetadataServiceContext.Service.GetMetadata(signature.SubTypeUid) is DataClassMetadata metadata))
          throw new MetadataLoadException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647818308), (object) signature.SubTypeUid));
        if (DependencyServiceHelper.SkipDependency((IMetadata) metadata, currentModuleUid, options))
          return;
        DependencyServiceHelper.AddClassDependency<DataClassDependency, DataClassMetadata>(dataClassDependencies, metadata.Uid, metadata, (Func<DataClassMetadata, DataClassDependency>) (m => m.GetSignature(true)));
      }
      else
      {
        if (DependencyServiceHelper.IsEntity(signature.TypeUid))
        {
          if (!(MetadataServiceContext.Service.GetMetadata(signature.SubTypeUid) is EntityMetadata metadata))
            throw new MetadataLoadException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217617179), (object) signature.SubTypeUid));
          DependencyServiceHelper.AddClassDependency<EntityDependency, EntityMetadata>(entityDependencies, signature.SubTypeUid, metadata, (Func<EntityMetadata, EntityDependency>) (m => m.GetSignature(true)));
        }
        if (!DependencyServiceHelper.IsEnum(signature.TypeUid))
          return;
        if (!(MetadataServiceContext.Service.GetMetadata(signature.SubTypeUid) is EnumMetadata metadata1))
          throw new MetadataLoadException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397377284), (object) signature.SubTypeUid));
        DependencyServiceHelper.AddEnumDependency(enumDependencies, metadata1);
      }
    }

    /// <summary>Является ли тип структурой обмена данными</summary>
    /// <param name="typeUid">Тип</param>
    /// <param name="subTypeUid">Подтип</param>
    /// <returns><c>true</c>, если тип является структурой обмена данными</returns>
    internal static bool IsDataClass(Guid typeUid, Guid subTypeUid) => DependencyServiceHelper.tfYDwXbC5UG5cY7BOi6R(typeUid, DataClassDescriptor.UID);

    /// <summary>Является ли тип действием</summary>
    /// <param name="typeUid">Тип</param>
    /// <returns><c>true</c>, если тип является действием</returns>
    internal static bool IsAction(Guid typeUid) => DependencyServiceHelper.tfYDwXbC5UG5cY7BOi6R(typeUid, ActionDescriptor.UID);

    /// <summary>Является ли тип действием</summary>
    /// <param name="typeUid">Тип</param>
    /// <returns><c>true</c>, если тип является сущностью</returns>
    internal static bool IsEntity(Guid typeUid)
    {
      int num1 = 2;
      Guid typeUid1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            typeUid1 = typeUid;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      IEnumerable<ITypeDescriptor> descriptors = DependencyServiceHelper.Descriptors;
      // ISSUE: reference to a compiler-generated field
      Func<ITypeDescriptor, bool> func = DependencyServiceHelper.\u003C\u003Ec.\u003C\u003E9__6_0;
      Func<ITypeDescriptor, bool> predicate;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        DependencyServiceHelper.\u003C\u003Ec.\u003C\u003E9__6_0 = predicate = (Func<ITypeDescriptor, bool>) (a =>
        {
          int num2 = 1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                if (!(a is EntityDescriptor))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
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
          // ISSUE: reference to a compiler-generated method
          return !DependencyServiceHelper.\u003C\u003Ec.MPvQRbCnLcgcBOdZq2Wc((object) a);
label_5:
          return false;
        });
      }
      else
        goto label_5;
label_7:
      // ISSUE: reference to a compiler-generated method
      return descriptors.Where<ITypeDescriptor>(predicate).FirstOrDefault<ITypeDescriptor>((Func<ITypeDescriptor, bool>) (a => DependencyServiceHelper.\u003C\u003Ec__DisplayClass6_0.pAnNMVCOFvtkWQCSf6hk((object) a) == typeUid1)) != null;
label_5:
      predicate = func;
      goto label_7;
    }

    /// <summary>Является ли тип перечислением</summary>
    /// <param name="typeUid">Тип</param>
    /// <returns><c>true</c>, если тип является перечислением</returns>
    internal static bool IsEnum(Guid typeUid) => DependencyServiceHelper.tfYDwXbC5UG5cY7BOi6R(typeUid, EnumDescriptor.UID);

    /// <summary>Обработать метаданные</summary>
    /// <param name="currentModuleUid">Текущий модуль</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="options">Настройки для анализа зависимостей</param>
    /// <param name="enumDependencies">Зависимости от перечислений</param>
    /// <param name="entityDependencies">Зависимости от сущностей</param>
    /// <param name="dataClassDependencies">Зависимости от Структур обмена данными</param>
    /// <param name="propertyMetadata">Свойство</param>
    public static void ProcessMetadata(
      Guid currentModuleUid,
      IMetadata metadata,
      DependencyServiceOptions options,
      Dictionary<Guid, EnumDependency> enumDependencies,
      Dictionary<Guid, EntityDependency> entityDependencies,
      Dictionary<Guid, DataClassDependency> dataClassDependencies,
      IPropertyMetadata propertyMetadata = null)
    {
      switch (metadata)
      {
        case EnumMetadata metadata1:
          DependencyServiceHelper.AddEnumDependency((IDictionary<Guid, EnumDependency>) enumDependencies, metadata1);
          break;
        case EntityMetadata metadata2:
          Dictionary<Guid, EntityDependency> classDependencies = entityDependencies;
          IPropertyMetadata property = propertyMetadata;
          DependencyServiceHelper.AddClassDependency<EntityDependency, EntityMetadata>((IDictionary<Guid, EntityDependency>) classDependencies, metadata2, (Func<EntityMetadata, EntityDependency>) (m => m.GetSignature(true)), property);
          break;
        case DataClassMetadata dataClassMetadata:
          if (DependencyServiceHelper.SkipDependency((IMetadata) dataClassMetadata, currentModuleUid, options))
            break;
          DependencyServiceHelper.AddClassDependency<DataClassDependency, DataClassMetadata>((IDictionary<Guid, DataClassDependency>) dataClassDependencies, dataClassMetadata, (Func<DataClassMetadata, DataClassDependency>) (m => m.GetSignature(true)), propertyMetadata);
          break;
      }
    }

    /// <summary>Добавить зависимость от класса</summary>
    /// <param name="classDependencies">Зависимости от классов</param>
    /// <param name="metadataUid">Уникальный идентификатор метаданных</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="createDependency">Функция создания зависимости</param>
    /// <param name="property">Свойство</param>
    /// <typeparam name="T">Тип зависимости</typeparam>
    /// <typeparam name="TMetadata">Тип метаданных</typeparam>
    internal static void AddClassDependency<T, TMetadata>(
      IDictionary<Guid, T> classDependencies,
      Guid metadataUid,
      TMetadata metadata,
      Func<TMetadata, T> createDependency,
      IPropertyMetadata property = null)
      where T : ClassDependency
      where TMetadata : ClassMetadata
    {
      if ((object) metadata == null || classDependencies == null)
        return;
      if (!classDependencies.ContainsKey(metadataUid))
        classDependencies[metadataUid] = createDependency(metadata);
      if (property == null)
        return;
      List<PropertySignature> properties = classDependencies[metadataUid].Properties;
      if (properties.FirstOrDefault<PropertySignature>((Func<PropertySignature, bool>) (p => p.Uid == property.Uid)) != null)
        return;
      properties.Add(property.CreatePropertySignature());
    }

    /// <summary>Добавить зависимость от класса</summary>
    /// <param name="classDependencies">Зависимости от классов</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="createDependency">Функция создания зависимости</param>
    /// <param name="property">Свойство</param>
    /// <typeparam name="T">Тип зависимости</typeparam>
    /// <typeparam name="TMetadata">Тип метаданных</typeparam>
    internal static void AddClassDependency<T, TMetadata>(
      IDictionary<Guid, T> classDependencies,
      TMetadata metadata,
      Func<TMetadata, T> createDependency,
      IPropertyMetadata property = null)
      where T : ClassDependency
      where TMetadata : ClassMetadata
    {
      Guid uid = metadata.Uid;
      if (metadata is EntityMetadata entityMetadata && entityMetadata.Type == EntityMetadataType.InterfaceExtension)
      {
        IMetadata metadata1 = MetadataServiceContext.Service.GetMetadata(entityMetadata.BaseClassUid);
        if (metadata1 != null)
          uid = metadata1.Uid;
      }
      DependencyServiceHelper.AddClassDependency<T, TMetadata>(classDependencies, uid, metadata, createDependency, property);
    }

    /// <summary>Добавить зависимость от функции</summary>
    /// <param name="functionDependencies">Зависимости от функций</param>
    /// <param name="metadata">Метаданные функции</param>
    internal static void AddFunctionDependency(
      IDictionary<Guid, FunctionDependency> functionDependencies,
      FunctionMetadata metadata)
    {
      if (metadata == null || functionDependencies == null || functionDependencies.ContainsKey(metadata.Uid))
        return;
      functionDependencies[metadata.Uid] = metadata.GetSignature();
    }

    /// <summary>Добавить зависимость от перечисления</summary>
    /// <param name="enumDependencies">Зависимости от перечислений</param>
    /// <param name="metadata">Метаданные перечисления</param>
    internal static void AddEnumDependency(
      IDictionary<Guid, EnumDependency> enumDependencies,
      EnumMetadata metadata)
    {
      if (metadata == null || enumDependencies == null || enumDependencies.ContainsKey(metadata.Uid))
        return;
      enumDependencies[metadata.Uid] = metadata.GetSignature();
    }

    /// <summary>Пропустить зависимость</summary>
    /// <param name="md">Метаданные</param>
    /// <param name="currentModuleUid">Текущий модуль</param>
    /// <param name="options">Настройки для анализа зависимостей</param>
    /// <returns><c>true</c>, если необходимо пропустить зависимость</returns>
    internal static bool SkipDependency(
      IMetadata md,
      Guid currentModuleUid,
      DependencyServiceOptions options)
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
              goto label_17;
            case 2:
              goto label_10;
            case 3:
              goto label_13;
            case 4:
            case 6:
              if (DependencyServiceHelper.tfYDwXbC5UG5cY7BOi6R(currentModuleUid, Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 3 : 2;
                continue;
              }
              if (DependencyServiceHelper.tfYDwXbC5UG5cY7BOi6R(DependencyServiceHelper.Vhk4jDbCUCAb3sT8ijlB((object) md), currentModuleUid))
              {
                if (options == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 1;
                  continue;
                }
                goto label_16;
              }
              else
              {
                num2 = 2;
                continue;
              }
            case 5:
              goto label_16;
            case 7:
              if (!(md is DataClassMetadata dataClassMetadata))
              {
                num2 = 6;
                continue;
              }
              goto label_8;
            case 8:
              goto label_8;
            default:
              goto label_5;
          }
        }
label_8:
        if (!DependencyServiceHelper.QQgqa4bCLExWppXR5IMt(DependencyServiceHelper.HtF1uVbCjvC4xjHjG9uW((object) dataClassMetadata), DependencyServiceHelper.sC9WhWbCYIss1Bn5boKk(1505778440 - 1981636111 ^ -476034867)))
          num1 = 4;
        else
          break;
      }
label_5:
      return true;
label_10:
      return false;
label_13:
      return false;
label_16:
      return DependencyServiceHelper.C73ZG5bCsUW1KGYEsTiG((object) options);
label_17:
      return true;
    }

    internal static bool tfYDwXbC5UG5cY7BOi6R([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool nnbePdbCrwM6SdYq99pL() => DependencyServiceHelper.gcTskcbClJXvDoem6Cep == null;

    internal static DependencyServiceHelper yr6ZHKbCgP053ufJqeuA() => DependencyServiceHelper.gcTskcbClJXvDoem6Cep;

    internal static object HtF1uVbCjvC4xjHjG9uW([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object sC9WhWbCYIss1Bn5boKk(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool QQgqa4bCLExWppXR5IMt([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static Guid Vhk4jDbCUCAb3sT8ijlB([In] object obj0) => ((IMetadata) obj0).ModuleUid;

    internal static bool C73ZG5bCsUW1KGYEsTiG([In] object obj0) => ((DependencyServiceOptions) obj0).SkipCurrentModule;
  }
}
