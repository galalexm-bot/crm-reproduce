// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.MetadataLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.ExpressionUtil;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events.Audit;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Caching;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Загрузчик метаданных</summary>
  public class MetadataLoader
  {
    private static readonly System.Reflection.PropertyInfo dictionaryIndexer;
    private static readonly IDictionary<string, MemoryCache> MetadataCaches;
    private static readonly System.Reflection.MethodInfo getCacheValueMethod;
    private static readonly System.Reflection.MethodInfo getCacheValueCondMethod;
    private static readonly System.Reflection.MethodInfo paramToStringMethod;
    private static readonly System.Reflection.MethodInfo typeParamToStringMethod;
    private static readonly System.Reflection.MethodInfo genericCollectionToStringMethod;
    private static readonly System.Reflection.MethodInfo identifiedParamToStringMethod;
    private static readonly System.Reflection.MethodInfo stringJoinMethod;
    private static IDictionary<Type, IRootMetadata> loadedMetadataInherit;
    private static IDictionary<Type, IRootMetadata> loadedMetadataNotInherit;
    private static IDictionary<Guid, List<KeyValuePair<PropertyMetadata, ClassMetadata>>> propertiesByParents;
    private static Func<Guid, bool, bool, List<ClassMetadata>> getChildClassesCached;
    private static Func<Guid, List<EnumMetadata>> getChildEnumsCached;
    private static Func<Guid, bool, List<ClassMetadata>> getBaseClassesCached;
    private static MetadataLoader GbOXxjb0WCmVE4JvNPuN;

    /// <summary>
    /// Загрузить (восстановить) метаданные из типа <paramref name="runtimeType" />
    /// </summary>
    /// <param name="runtimeType">Тип, у которого требуется получить метаданные</param>
    /// <param name="inherit">True, если нужно выбирать свойства, включая родительские классы</param>
    /// <param name="loadImplementation">Загружать ли метаданные реализации, если указанный тип - интерфейс</param>
    /// <returns>Метаданные</returns>
    public static IMetadata LoadMetadata(Type runtimeType, bool inherit = true, bool loadImplementation = true)
    {
      int num1 = 39;
      IRootMetadata rootMetadata;
      while (true)
      {
        int num2 = num1;
        Type type1;
        while (true)
        {
          IDictionary<Type, IRootMetadata> dictionary1;
          MetadataTypeAttribute metadataTypeAttribute;
          bool flag;
          int num3;
          Type type2;
          IDictionary<Type, IRootMetadata> dictionary2;
          switch (num2)
          {
            case 1:
            case 29:
              if (!type1.IsEnum)
              {
                num2 = 40;
                continue;
              }
              goto case 10;
            case 2:
            case 27:
              dictionary1[type1] = rootMetadata;
              num2 = 26;
              continue;
            case 3:
              type1 = type1.GetNonNullableType();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 12 : 12;
              continue;
            case 4:
            case 13:
            case 25:
            case 41:
              if (rootMetadata == null)
              {
                num2 = 27;
                continue;
              }
              goto case 43;
            case 5:
              rootMetadata = MetadataLoader.nUUTUSb0ZP5lQlcoifjE(MetadataLoader.sg0DmXb08NO3ovJJlTLh((object) metadataTypeAttribute)) as IRootMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 1 : 4;
              continue;
            case 6:
              // ISSUE: type reference
              metadataTypeAttribute = ((IEnumerable<object>) type1.GetReflectionCustomAttributes(MetadataLoader.hFy5DQb0vXGxVrJJmu17(__typeref (MetadataTypeAttribute)), false)).FirstOrDefault<object>() as MetadataTypeAttribute;
              num2 = 44;
              continue;
            case 7:
              num3 = MetadataLoader.y6iuUeb0CvSZCdPaX0hU((object) ComponentManager.Current) == ComponentManager.LifetimeStage.Initialized ? 1 : 0;
              goto label_61;
            case 8:
              if (type1.IsValueType)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 9:
              if (!MetadataLoader.AFL3RPb0fDyljXlhlbV9(type1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 23 : 0;
                continue;
              }
              goto case 3;
            case 10:
              rootMetadata = (IRootMetadata) new EnumMetadata();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 13 : 1;
              continue;
            case 11:
              MetadataLoader.loadedMetadataInherit[type1] = rootMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 13 : 37;
              continue;
            case 12:
            case 23:
              if (loadImplementation)
              {
                num2 = 32;
                continue;
              }
              goto case 17;
            case 14:
              dictionary2 = MetadataLoader.loadedMetadataNotInherit;
              break;
            case 15:
              if (!ComponentManager.Initialized)
              {
                num2 = 18;
                continue;
              }
              goto case 7;
            case 16:
            case 31:
            case 33:
              if (type1.IsClass)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 11 : 34;
                continue;
              }
              goto case 46;
            case 17:
              type2 = type1;
              goto label_59;
            case 18:
              num3 = 0;
              goto label_61;
            case 19:
              rootMetadata = (IRootMetadata) new ClassMetadata();
              num2 = 25;
              continue;
            case 20:
              inherit = false;
              num2 = 36;
              continue;
            case 21:
            case 34:
              if (TypeOf<IDataClass>.Raw.IsAssignableFrom(type1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 4 : 20;
                continue;
              }
              goto case 19;
            case 22:
            case 26:
              goto label_42;
            case 24:
              if (type1.IsSealed)
              {
                num2 = 42;
                continue;
              }
              goto case 16;
            case 28:
              rootMetadata = (IRootMetadata) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 11 : 30;
              continue;
            case 30:
              if (dictionary1.TryGetValue(type1, out rootMetadata))
              {
                num2 = 22;
                continue;
              }
              goto case 6;
            case 32:
              type2 = MetadataLoader.kJBLVjb0Q7nkxs6GlxXN(type1);
              goto label_59;
            case 35:
              type1 = MetadataLoader.jCuu0eb0E4immWvfQVWF(runtimeType);
              num2 = 9;
              continue;
            case 36:
              rootMetadata = (IRootMetadata) new DataClassMetadata();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 6 : 11;
              continue;
            case 37:
              goto label_33;
            case 38:
              if (inherit)
              {
                dictionary2 = MetadataLoader.loadedMetadataInherit;
                break;
              }
              goto label_8;
            case 39:
              MetadataLoader.iZQhrMb0G2Ei0gNqaGCL((object) runtimeType, MetadataLoader.rfy1yjb0hRjTYPwEUpjk(44884861 ^ 44964771));
              num2 = 38;
              continue;
            case 40:
              if (!type1.IsClass)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 21 : 31;
                continue;
              }
              goto case 24;
            case 42:
              if (type1.IsAbstract)
                goto case 10;
              else
                goto label_13;
            case 43:
              rootMetadata.LoadFromType(type1, inherit);
              num2 = 47;
              continue;
            case 44:
              if (metadataTypeAttribute == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 0;
                continue;
              }
              goto case 5;
            case 45:
              rootMetadata.ApplyRestartUnrequiredChanges(inherit);
              num2 = 2;
              continue;
            case 46:
              if (!type1.IsInterface)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 8;
                continue;
              }
              goto case 21;
            case 47:
              if (flag)
              {
                num2 = 45;
                continue;
              }
              goto case 2;
            default:
              if (!type1.IsPrimitive)
              {
                num2 = 21;
                continue;
              }
              goto case 4;
          }
          dictionary1 = dictionary2;
          num2 = 35;
          continue;
label_59:
          type1 = type2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 12 : 15;
          continue;
label_61:
          flag = num3 != 0;
          num2 = 28;
        }
label_8:
        num1 = 14;
        continue;
label_13:
        num1 = 33;
        continue;
label_33:
        MetadataLoader.loadedMetadataNotInherit[type1] = rootMetadata;
        num1 = 41;
      }
label_42:
      return (IMetadata) rootMetadata;
    }

    /// <summary>
    /// Загрузить метаданные по уникальному идентификатору. Должен быть доступен сервис IMetadataRuntimeService
    /// </summary>
    /// <param name="uid">Уникальный идентификатор объекта метаданных</param>
    /// <param name="inherit">True, если нужно выбирать свойства, включая родительские классы</param>
    /// <param name="loadImplementation">Загружать ли метаданные реализации, если указанный тип - интерфейс</param>
    /// <returns>Метаданные</returns>
    public static IMetadata LoadMetadata(Guid uid, bool inherit = true, bool loadImplementation = true)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (!MetadataLoader.K50hkLb0uR8qJN072NCK(uid, Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return (IMetadata) null;
label_5:
      return MetadataLoader.LoadMetadata(MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(uid, loadImplementation), inherit, loadImplementation);
    }

    /// <summary>
    /// Загрузить метаданные по уникальному идентификатору. Должен быть доступен сервис IMetadataRuntimeService
    /// </summary>
    /// <param name="uid">Уникальный идентификатор объекта метаданных</param>
    /// <param name="inherit">True, если нужно выбирать свойства, включая родительские классы</param>
    /// <param name="loadImplementation">Загружать ли метаданные реализации, если указанный тип - интерфейс</param>
    /// <returns>Метаданные или null, если не были найдены</returns>
    public static IMetadata LoadMetadataOrNull(Guid uid, bool inherit = true, bool loadImplementation = true)
    {
      int num = 3;
      Type typeByUidOrNull;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            typeByUidOrNull = MetadataServiceContext.MetadataRuntimeService.GetTypeByUidOrNull(uid, loadImplementation);
            num = 4;
            continue;
          case 3:
            if (!MetadataLoader.K50hkLb0uR8qJN072NCK(uid, Guid.Empty))
            {
              num = 2;
              continue;
            }
            goto label_8;
          case 4:
            if (MetadataLoader.ArTwsfb0IMD1ih1Vg8NW(typeByUidOrNull, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 5;
              continue;
            }
            goto label_2;
          case 5:
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (IMetadata) null;
label_3:
      return MetadataLoader.LoadMetadata(typeByUidOrNull, inherit, loadImplementation);
label_8:
      return (IMetadata) null;
    }

    /// <summary>
    /// Загрузить список свойств указанного класса, а также всех его наследников
    /// </summary>
    /// <param name="metadata">Метаданные класса</param>
    /// <returns>Список свойств</returns>
    public static List<KeyValuePair<PropertyMetadata, ClassMetadata>> GetChildProperties(
      ClassMetadata metadata)
    {
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124624304));
      List<KeyValuePair<PropertyMetadata, ClassMetadata>> keyValuePairList;
      if (metadata.Uid == Guid.Empty || !MetadataLoader.propertiesByParents.TryGetValue(metadata.Uid, out keyValuePairList))
      {
        keyValuePairList = new List<KeyValuePair<PropertyMetadata, ClassMetadata>>();
        MetadataLoader.GetChildProperties((object) metadata, keyValuePairList);
        MetadataLoader.propertiesByParents[metadata.Uid] = keyValuePairList;
      }
      return metadata.Properties.Select<PropertyMetadata, KeyValuePair<PropertyMetadata, ClassMetadata>>((Func<PropertyMetadata, KeyValuePair<PropertyMetadata, ClassMetadata>>) (pm => new KeyValuePair<PropertyMetadata, ClassMetadata>(pm, metadata))).OrderBy<KeyValuePair<PropertyMetadata, ClassMetadata>, int>((Func<KeyValuePair<PropertyMetadata, ClassMetadata>, int>) (p => p.Key.Order)).Concat<KeyValuePair<PropertyMetadata, ClassMetadata>>((IEnumerable<KeyValuePair<PropertyMetadata, ClassMetadata>>) keyValuePairList).ToList<KeyValuePair<PropertyMetadata, ClassMetadata>>();
    }

    /// <summary>Получить рекурсивно все свойства базовых классов</summary>
    /// <param name="metadata"></param>
    /// <returns></returns>
    public static List<PropertyMetadata> GetBaseProperties(ClassMetadata metadata)
    {
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669389525));
      // ISSUE: reference to a compiler-generated method
      Func<Guid, ClassMetadata> func = (Func<Guid, ClassMetadata>) (uid => (ClassMetadata) ((IMetadataService) MetadataLoader.\u003C\u003Ec.QEf6MbC46BXEwoRAqHGb()).GetMetadata(uid));
      return MetadataLoader.GetBaseProperties(metadata, func);
    }

    /// <summary>Получить рекурсивно все свойства базовых классов</summary>
    /// <param name="metadata"></param>
    /// <param name="func"></param>
    /// <returns></returns>
    public static List<PropertyMetadata> GetBaseProperties(
      ClassMetadata metadata,
      Func<Guid, ClassMetadata> func)
    {
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309653886));
      List<PropertyMetadata> properties = new List<PropertyMetadata>();
      MetadataLoader.GetBaseProperties((object) metadata, properties, (List<KeyValuePair<PropertyMetadata, ClassMetadata>>) null, func);
      return properties;
    }

    /// <summary>Получить рекурсивно все свойства базовых классов</summary>
    /// <param name="metadata"></param>
    /// <returns></returns>
    public static List<KeyValuePair<PropertyMetadata, ClassMetadata>> GetBasePropertiesAndMetadata(
      ClassMetadata metadata)
    {
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521251458));
      // ISSUE: reference to a compiler-generated method
      Func<Guid, ClassMetadata> func = (Func<Guid, ClassMetadata>) (uid => (ClassMetadata) ((IMetadataService) MetadataLoader.\u003C\u003Ec.QEf6MbC46BXEwoRAqHGb()).GetMetadata(uid));
      return MetadataLoader.GetBasePropertiesAndMetadata(metadata, func);
    }

    /// <summary>Получить рекурсивно все свойства базовых классов</summary>
    /// <param name="metadata"></param>
    /// <param name="func"></param>
    /// <returns></returns>
    public static List<KeyValuePair<PropertyMetadata, ClassMetadata>> GetBasePropertiesAndMetadata(
      ClassMetadata metadata,
      Func<Guid, ClassMetadata> func)
    {
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97953432));
      List<KeyValuePair<PropertyMetadata, ClassMetadata>> propertiesAndMetadata = new List<KeyValuePair<PropertyMetadata, ClassMetadata>>();
      MetadataLoader.GetBaseProperties((object) metadata, (List<PropertyMetadata>) null, propertiesAndMetadata, func);
      return propertiesAndMetadata;
    }

    /// <summary>Получить рекурсивно все свойства базовых классов</summary>
    /// <param name="metadata"></param>
    /// <returns></returns>
    public static List<IPropertyMetadata> GetBasePropertiesAndTableParts(
      ClassMetadata metadata,
      bool includeExtensions = false)
    {
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858869089));
      return MetadataLoader.GetPropertiesAndTableParts((object) metadata, true, includeExtensions);
    }

    /// <summary>
    /// Получить рекурсивно все свойства данного класса и его базовых классов
    /// </summary>
    /// <param name="metadata"></param>
    /// <returns></returns>
    public static List<IPropertyMetadata> GetPropertiesAndTableParts(
      ClassMetadata metadata,
      bool includeExtensions = false)
    {
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1786900618));
      return MetadataLoader.GetPropertiesAndTableParts((object) metadata, false, includeExtensions);
    }

    /// <summary>
    /// Получить рекурсивно все базовые классы (а также расширения, если includeExtensions=true)
    /// </summary>
    /// <param name="metadata"></param>
    /// <returns></returns>
    public static List<ClassMetadata> GetBaseClassMetadataList(
      ClassMetadata metadata,
      bool includeExtensions)
    {
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867217237));
      return MetadataLoader.GetClassMetadataList((object) metadata, true, false, includeExtensions);
    }

    /// <summary>
    /// Получить рекурсивно все базовые классы (а также расширения, если includeExtensions=true)
    /// </summary>
    /// <param name="metadata"></param>
    /// <returns></returns>
    public static List<ClassMetadata> GetBaseClassMetadataList(
      ClassMetadata metadata,
      bool includeExtensions = false,
      bool loadImplementation = true)
    {
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112684632));
      return MetadataLoader.GetClassMetadataList((object) metadata, true, false, includeExtensions, loadImplementation);
    }

    /// <summary>Получить все расширения для указаннго класса</summary>
    /// <param name="metadata">Метаданные</param>
    /// <param name="includeBaseClasses">Включать в результат базовые классы</param>
    /// <returns>Список метаданных</returns>
    public static List<ClassMetadata> GetClassExtensionsMetadataList(
      ClassMetadata metadata,
      bool includeBaseClasses)
    {
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3314396));
      return MetadataLoader.GetClassMetadataList((object) metadata, includeBaseClasses, true, true);
    }

    /// <summary>
    /// Получить список действий для сущности, включая действия из расширений
    /// </summary>
    /// <param name="metadata">Метаданные сущности</param>
    /// <param name="inherit">Включает действия из базового класса</param>
    /// <param name="onlyBase">Только действия из базового класса (учитывается, если inherit = true)</param>
    /// <returns>Список действий</returns>
    public static List<EnumValueMetadata> GetEntityActions(
      EntityMetadata metadata,
      bool inherit,
      bool onlyBase)
    {
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304623219));
      return MetadataLoader.GetEntityActions(metadata, inherit, onlyBase, true);
    }

    /// <summary>Получить список действий для сущности</summary>
    /// <param name="metadata">Метаданные сущности</param>
    /// <param name="inherit">Включает действия из базового класса</param>
    /// <param name="onlyBase">Только действия из базового класса (учитывается, если inherit = true)</param>
    /// <param name="loadextensions">Включать действия из расширений</param>
    /// <returns>Список действий</returns>
    public static List<EnumValueMetadata> GetEntityActions(
      EntityMetadata metadata,
      bool inherit = true,
      bool onlyBase = false,
      bool loadextensions = true)
    {
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654279271));
      List<EnumValueMetadata> items = new List<EnumValueMetadata>();
      MetadataLoader.GetEntityActions(items, (object) metadata, inherit, onlyBase, loadextensions);
      return items;
    }

    /// <summary>Получить все базовые классы</summary>
    /// <param name="metadata"></param>
    /// <returns></returns>
    public static List<ClassMetadata> GetBaseClasses(
      ClassMetadata metadata,
      bool loadImplementation = true)
    {
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323102988));
      return MetadataServiceContext.MetadataRuntimeServiceOrNull != null ? new List<ClassMetadata>((IEnumerable<ClassMetadata>) MetadataLoader.getBaseClassesCached(metadata.Uid, loadImplementation)) : MetadataLoader.GetBaseClassesList((object) metadata, loadImplementation);
    }

    /// <summary>Получить все дочерние классы</summary>
    /// <param name="metadata"></param>
    public static List<ClassMetadata> GetChildClasses(
      ClassMetadata metadata,
      bool loadImplementation = true)
    {
      return MetadataLoader.GetChildClasses(metadata, loadImplementation, false);
    }

    /// <summary>Получить все дочерние классы</summary>
    /// <param name="metadata">Метаданные базового класса</param>
    /// <param name="loadImplementation">Загружать реализации</param>
    /// <param name="includeRoot">Включить базовый тип в результат</param>
    public static List<ClassMetadata> GetChildClasses(
      ClassMetadata metadata,
      bool loadImplementation,
      bool includeRoot)
    {
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541746505));
      return MetadataServiceContext.MetadataRuntimeServiceOrNull != null ? new List<ClassMetadata>((IEnumerable<ClassMetadata>) MetadataLoader.getChildClassesCached(metadata.Uid, loadImplementation, includeRoot)) : MetadataLoader.GetChildClassesList((object) metadata, loadImplementation, includeRoot);
    }

    /// <summary>Получить все дочерние классы</summary>
    /// <param name="mdUid">Уникальный идентификатор метаданных базового типа</param>
    /// <param name="loadImplementation">Загружать реализации</param>
    /// <param name="includeRoot">Включить базовый тип в результат</param>
    public static List<ClassMetadata> GetChildClasses(
      Guid mdUid,
      bool loadImplementation = true,
      bool includeRoot = false)
    {
      return MetadataLoader.GetChildClasses((ClassMetadata) MetadataLoader.LoadMetadata(mdUid, false, loadImplementation), loadImplementation, includeRoot);
    }

    /// <summary>Получить все дочерние перечисления</summary>
    /// <param name="metadata"></param>
    /// <returns></returns>
    public static List<EnumMetadata> GetChildEnums(EnumMetadata metadata)
    {
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293703130));
      return MetadataServiceContext.MetadataRuntimeServiceOrNull != null ? new List<EnumMetadata>((IEnumerable<EnumMetadata>) MetadataLoader.getChildEnumsCached(metadata.Uid)) : MetadataLoader.GetChildEnumsList((object) metadata);
    }

    /// <summary>Базовый ли это класс</summary>
    /// <param name="uid">Идентификатор метаданных базового класса</param>
    /// <param name="metadata">Метаданные основного класса</param>
    /// <returns></returns>
    public static bool IsBaseClass(Guid uid, ClassMetadata metadata, bool loadImplementation = true)
    {
      int num = 1;
      Guid uid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            uid1 = uid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 2 : 0;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      return MetadataLoader.GetBaseClasses(metadata, loadImplementation).Any<ClassMetadata>((Func<ClassMetadata, bool>) (m => MetadataLoader.\u003C\u003Ec__DisplayClass20_0.v77qrmC4M8mcjMC23du4(m.Uid, uid1)));
    }

    /// <summary>
    /// Проверка принадлежности Uid-а типа объекта заданному типу сущности или наследнику от неё.
    /// </summary>
    /// <typeparam name="T">Тип сущности, на принадлежность которому проверяется objectTypeUid.</typeparam>
    /// <param name="objectTypeUid">Уникальный идентификатор проверяемого типа объекта.</param>
    /// <returns></returns>
    public static bool IsBaseOrChildClass<T>(Guid objectTypeUid) => MetadataLoader.IsBaseOrChildClass(typeof (T), objectTypeUid);

    /// <summary>
    /// Проверка принадлежности Uid-а типа объекта заданному типу сущности или наследнику от неё.
    /// </summary>
    /// <param name="basetypeUid">Уникальный идентификатор типа сущности, на принадлежность которому проверяется objectTypeUid.</param>
    /// <param name="objectTypeUid">Уникальный идентификатор проверяемого типа объекта.</param>
    /// <returns></returns>
    public static bool IsBaseOrChildClass(Guid basetypeUid, Guid objectTypeUid) => MetadataLoader.IsBaseOrChildClass(MetadataLoader.LoadMetadata(basetypeUid) as ClassMetadata, objectTypeUid);

    /// <summary>
    /// Проверка принадлежности Uid-а типа объекта заданному типу сущности или наследнику от неё.
    /// </summary>
    /// <param name="basetype">Тип сущности, на принадлежность которому проверяется objectTypeUid.</param>
    /// <param name="objectTypeUid">Уникальный идентификатор проверяемого типа объекта.</param>
    /// <returns></returns>
    public static bool IsBaseOrChildClass(Type basetype, Guid objectTypeUid) => MetadataLoader.IsBaseOrChildClass(MetadataLoader.LoadMetadata(basetype) as ClassMetadata, objectTypeUid);

    /// <summary>
    /// Проверка принадлежности Uid-а типа объекта заданному типу сущности или наследнику от неё.
    /// </summary>
    /// <param name="baseMetadata">Метаданные типа сущности, на принадлежность которому проверяется objectTypeUid.</param>
    /// <param name="objectTypeUid">Уникальный идентификатор проверяемого типа объекта.</param>
    /// <returns></returns>
    public static bool IsBaseOrChildClass(ClassMetadata baseMetadata, Guid objectTypeUid)
    {
      int num = 1;
      Guid objectTypeUid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
            continue;
          case 2:
            if (MetadataLoader.K50hkLb0uR8qJN072NCK(objectTypeUid1, MetadataLoader.jdpuMXb0V0gvw39Mg8Tj((object) baseMetadata)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 3 : 5;
              continue;
            }
            goto label_4;
          case 3:
            goto label_4;
          case 4:
            if (baseMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 2 : 1;
              continue;
            }
            goto label_6;
          case 5:
            goto label_5;
          default:
            objectTypeUid1 = objectTypeUid;
            num = 4;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      return MetadataLoader.GetChildClasses(baseMetadata).Any<ClassMetadata>((Func<ClassMetadata, bool>) (m => MetadataLoader.\u003C\u003Ec__DisplayClass24_0.yOrAm7C4rYL7ypL5huCC((object) m) == objectTypeUid1));
label_5:
      return true;
label_6:
      return false;
    }

    /// <summary>
    /// Проверка принадлежности Uid-а типа объекта заданному типу сущности или наследнику от неё.
    /// </summary>
    /// <param name="baseMetadata">Метаданные типа сущности, на принадлежность которому проверяется objectTypeUid.</param>
    /// <param name="metadata">Метаданные проверяемого типа объекта.</param>
    /// <returns></returns>
    public static bool IsBaseOrChildClass(ClassMetadata baseMetadata, ClassMetadata metadata) => MetadataLoader.dQhHgLb0SNRkd5yaWEUC((object) baseMetadata, MetadataLoader.jdpuMXb0V0gvw39Mg8Tj((object) metadata));

    /// <summary>
    /// Загрузить тип фильтра по уникальному идентификатору объекта методанных
    /// </summary>
    /// <param name="uid">Уникальный идентификатор объекта метаданных</param>
    /// <returns>Тип фильтра</returns>
    public static Type GetFilterType(Guid uid)
    {
      int num1 = 7;
      Type filterType1;
      Type filterType2;
      while (true)
      {
        int num2 = num1;
        Type type;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
            case 8:
              if (filterType1 == (Type) null)
              {
                num2 = 4;
                continue;
              }
              goto label_6;
            case 3:
              filterType1 = MetadataLoader.UkWceKb0XLk2DT2LOSIr((object) type.Assembly, MetadataLoader.A6Nlv7b0KhjbmBXjfDg7((object) type.FullName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921219329)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
            case 4:
              if (!MetadataLoader.ArTwsfb0IMD1ih1Vg8NW(type, (Type) null))
              {
                num2 = 5;
                continue;
              }
              goto case 3;
            case 5:
              goto label_6;
            case 6:
              if (!MetadataLoader.ArTwsfb0IMD1ih1Vg8NW(filterType2, (Type) null))
              {
                ReferenceOnEntityType referenceOnEntityType = new ReferenceOnEntityType();
                MetadataLoader.Spj3M4b0RDDawGQZlcdm((object) referenceOnEntityType, uid);
                type = MetadataLoader.DDwdDAb0qOouhF3AyNmF((object) referenceOnEntityType);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
                continue;
              }
              num2 = 9;
              continue;
            case 7:
              filterType2 = MetadataLoader.VGGB4jb0iOeDO9QkE9id(uid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 6 : 3;
              continue;
            case 9:
              goto label_11;
            default:
              type = type.BaseType;
              num2 = 8;
              continue;
          }
        }
label_5:
        filterType1 = (Type) null;
        num1 = 2;
      }
label_6:
      return filterType1;
label_11:
      return filterType2;
    }

    /// <summary>Получить метаданные сущности по фильтру</summary>
    /// <param name="filterType">Тип фильтра</param>
    /// <returns></returns>
    public static ClassMetadata GetEntityMetadataByFilter(
      Type filterType,
      bool inherit = true,
      bool loadImplementation = true)
    {
      int num = 2;
      FilterForAttribute filterForAttribute;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            if (MetadataLoader.DC4jwZb0TPgFT0F789Kd(filterType, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
              continue;
            }
            // ISSUE: type reference
            filterForAttribute = (FilterForAttribute) ((IEnumerable<object>) MetadataLoader.X1xPCib0k25Nt2UEKy9j(filterType, MetadataLoader.hFy5DQb0vXGxVrJJmu17(__typeref (FilterForAttribute)), true)).FirstOrDefault<object>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
            continue;
          case 3:
            goto label_2;
          default:
            if (filterForAttribute == null)
            {
              num = 3;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      return (ClassMetadata) null;
label_3:
      return (ClassMetadata) MetadataLoader.LoadMetadata(MetadataLoader.W2X9olb0n4FZWalKI0fu((object) filterForAttribute), inherit, loadImplementation);
label_8:
      return (ClassMetadata) null;
    }

    /// <summary>
    /// Получить изображение нужного размера с учетом родителей
    /// </summary>
    /// <param name="metadata"></param>
    /// <param name="size"></param>
    /// <returns></returns>
    public static MetadataImage ParentImage(ClassMetadata metadata, int size)
    {
      int num = 4;
      MetadataImage image;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            if (MetadataLoader.McwB1Ob02j8RHnalpkN3(MetadataLoader.QhfTXcb0OXKZ6imHbWIZ((object) metadata), Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
              continue;
            }
            goto label_11;
          case 3:
            if (image == null)
            {
              num = 2;
              continue;
            }
            goto case 5;
          case 4:
            image = metadata.GetImage(size, true);
            num = 3;
            continue;
          case 5:
            if (image.Data != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
              continue;
            }
            goto case 2;
          default:
            goto label_10;
        }
      }
label_7:
      return image;
label_10:
      return MetadataLoader.ParentImage((ClassMetadata) ((IMetadataService) MetadataLoader.HdLAFlb0e8vQFDZZSPX2()).GetMetadata(MetadataLoader.QhfTXcb0OXKZ6imHbWIZ((object) metadata)), size);
label_11:
      return (MetadataImage) null;
    }

    /// <summary>Получить невидимые на форме свойства</summary>
    /// <param name="metadata"></param>
    /// <param name="viewType"></param>
    /// <returns></returns>
    public static List<PropertyMetadata> GetNotVisibleProperties(
      ClassMetadata metadata,
      ViewType viewType)
    {
      List<PropertyMetadata> visibleProperties = new List<PropertyMetadata>();
      foreach (PropertyMetadata property in metadata.Properties)
      {
        ViewAttribute forView = property.ViewSettings != null ? property.ViewSettings.GetForView(viewType) : (ViewAttribute) null;
        if (forView != null && !forView.Visible)
          visibleProperties.Add(property);
      }
      return visibleProperties;
    }

    /// <summary>
    /// Получить идентификаторы всех объектов метаданных, которые зависят от метаданных <paramref name="metadata" />
    /// </summary>
    /// <param name="metadata"></param>
    /// <returns></returns>
    public static List<Guid> GetDependentMetadataUids(IRootMetadata metadata)
    {
      HashSet<Guid> guidSet = new HashSet<Guid>();
      MetadataLoader.GetDependentMetadataUidsRecursive((object) metadata, (ISet<Guid>) guidSet);
      return guidSet.ToList<Guid>();
    }

    /// <summary>
    /// Получение метаданных интерфейса сущности, которой принадлежит свойство
    /// </summary>
    /// <param name="metadata">Метаданные реализации</param>
    /// <param name="propertyName">Наименование свойства</param>
    /// <returns>Метаданные интерфейса, которому принадлежит свойство</returns>
    public static ClassMetadata GetRealMetadataForProperty(
      ClassMetadata metadata,
      string propertyName)
    {
      int num = 4;
      ClassMetadata metadataForProperty;
      string propertyName1;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            if (!metadataForProperty.Properties.Any<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => MetadataLoader.\u003C\u003Ec__DisplayClass31_0.N2BBvMC4UT5nCJogikXY(MetadataLoader.\u003C\u003Ec__DisplayClass31_0.YOHy91C4LDS9OiJCP2Yp((object) p), (object) propertyName1))))
            {
              if (MetadataLoader.McwB1Ob02j8RHnalpkN3(MetadataLoader.QhfTXcb0OXKZ6imHbWIZ((object) metadataForProperty), Guid.Empty))
              {
                num = 5;
                continue;
              }
              goto label_10;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
              continue;
            }
          case 2:
            metadataForProperty = (ClassMetadata) MetadataLoader.LoadMetadata(MetadataLoader.jdpuMXb0V0gvw39Mg8Tj((object) metadata), false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 0;
            continue;
          case 3:
            propertyName1 = propertyName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 2;
            continue;
          case 4:
            num = 3;
            continue;
          case 5:
            goto label_9;
          default:
            goto label_2;
        }
      }
label_2:
      return metadataForProperty;
label_9:
      return MetadataLoader.GetRealMetadataForProperty((ClassMetadata) MetadataLoader.LoadMetadata(MetadataLoader.QhfTXcb0OXKZ6imHbWIZ((object) metadataForProperty), false), propertyName1);
label_10:
      return (ClassMetadata) null;
    }

    /// <summary>
    /// Получение метаданных интерфейса сущности, которой принадлежит свойство
    /// </summary>
    /// <param name="metadata">Метаданные реализации</param>
    /// <param name="propertyuid">Uid свойства</param>
    /// <returns>Метаданные интерфейса, которому принадлежит свойство</returns>
    public static ClassMetadata GetRealMetadataForProperty(ClassMetadata metadata, Guid propertyuid)
    {
      int num1 = 5;
      ClassMetadata metadataForProperty;
      Guid propertyuid1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!metadataForProperty.Properties.Any<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => MetadataLoader.\u003C\u003Ec__DisplayClass32_0.cykWxUC6B3E3CFufq6H5(MetadataLoader.\u003C\u003Ec__DisplayClass32_0.t7Z7OwC6FY5S0eq9kcCu((object) p), propertyuid1))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_12;
            case 3:
              goto label_11;
            case 4:
              goto label_10;
            case 5:
              num2 = 4;
              continue;
            case 6:
              metadataForProperty = (ClassMetadata) MetadataLoader.LoadMetadata(MetadataLoader.jdpuMXb0V0gvw39Mg8Tj((object) metadata), false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 0;
              continue;
            case 7:
              goto label_4;
            default:
              if (!(MetadataLoader.QhfTXcb0OXKZ6imHbWIZ((object) metadataForProperty) != Guid.Empty))
              {
                num2 = 2;
                continue;
              }
              goto label_11;
          }
        }
label_10:
        propertyuid1 = propertyuid;
        num1 = 6;
      }
label_4:
      return metadataForProperty;
label_11:
      return (ClassMetadata) MetadataLoader.VSSKEBb0P1atop7fMNCV((object) (ClassMetadata) MetadataLoader.LoadMetadata(metadataForProperty.BaseClassUid, false), propertyuid1);
label_12:
      return (ClassMetadata) null;
    }

    /// <summary>Сравниваем два TypeUid у метаданных</summary>
    /// <param name="leftTypeUid">Первый TypeUid</param>
    /// <param name="rightTypeUid">Второй TypeUid</param>
    /// <returns></returns>
    public static bool CompareTypeUids(Guid leftTypeUid, Guid rightTypeUid)
    {
      int num = 6;
      List<Guid> list;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!list.Contains(rightTypeUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 3 : 9;
              continue;
            }
            goto label_2;
          case 2:
          case 9:
            if (!MetadataLoader.K50hkLb0uR8qJN072NCK(rightTypeUid, EntityDescriptor.UID))
            {
              num = 7;
              continue;
            }
            goto case 3;
          case 3:
            if (!list.Contains(leftTypeUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 10 : 2;
              continue;
            }
            goto label_5;
          case 4:
            goto label_2;
          case 5:
            IEnumerable<IEntityType> extensionPoints = ((ComponentManager) MetadataLoader.tZ8JPXb01RBnUu5F7IOE()).GetExtensionPoints<IEntityType>();
            // ISSUE: reference to a compiler-generated field
            Func<IEntityType, IEnumerable<Guid>> func = MetadataLoader.\u003C\u003Ec.\u003C\u003E9__33_0;
            Func<IEntityType, IEnumerable<Guid>> selector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              MetadataLoader.\u003C\u003Ec.\u003C\u003E9__33_0 = selector = (Func<IEntityType, IEnumerable<Guid>>) (e => (IEnumerable<Guid>) e.Types);
            }
            else
              goto label_20;
label_19:
            list = extensionPoints.SelectMany<IEntityType, Guid>(selector).ToList<Guid>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 7 : 12;
            continue;
label_20:
            selector = func;
            goto label_19;
          case 6:
            if (!MetadataLoader.K50hkLb0uR8qJN072NCK(leftTypeUid, rightTypeUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 5;
              continue;
            }
            goto label_16;
          case 7:
          case 10:
            goto label_6;
          case 8:
            if (!MetadataLoader.K50hkLb0uR8qJN072NCK(leftTypeUid, EntityDescriptor.UID))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 2 : 2;
              continue;
            }
            goto case 1;
          case 11:
            goto label_16;
          case 12:
            list.Add(EntityDescriptor.UID);
            num = 8;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return true;
label_5:
      return true;
label_6:
      return false;
label_16:
      return true;
    }

    /// <summary>Создать безусловно кеширующую функцию</summary>
    /// <typeparam name="TResult">Тип возвращаемого функцией значения</typeparam>
    /// <param name="extractValueExpr">Выражение функции</param>
    /// <returns>Кеширующую функцию</returns>
    public static Func<TResult> UseCachingForFunc<TResult>(
      Expression<Func<TResult>> extractValueExpr)
    {
      return (Func<TResult>) MetadataLoader.CompileLambda((object) MetadataLoader.GetDecoratedLambda((object) extractValueExpr, z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408825398)));
    }

    /// <summary>
    /// Создать безусловно кеширующую функцию и вернуть метод очистки кеша от её значений
    /// </summary>
    /// <typeparam name="TResult">Тип возвращаемого функцией значения</typeparam>
    /// <param name="extractValueExpr">Выражение функции</param>
    /// <param name="clearAction">Метод очистки кеша</param>
    /// <returns>Кеширующую функцию</returns>
    public static Func<TResult> UseCachingForFunc<TResult>(
      Expression<Func<TResult>> extractValueExpr,
      out System.Action clearAction)
    {
      clearAction = MetadataLoader.ClearFunc((object) extractValueExpr.ToString());
      return (Func<TResult>) MetadataLoader.CompileLambda((object) MetadataLoader.GetDecoratedLambda((object) extractValueExpr, extractValueExpr.ToString()));
    }

    /// <summary>Создать безусловно кеширующую функцию</summary>
    /// <typeparam name="T1">Тип первого параметра функции</typeparam>
    /// <typeparam name="TResult">Тип возвращаемого функцией значения</typeparam>
    /// <param name="extractValueExpr">Выражение функции</param>
    /// <returns>Кеширующую функцию</returns>
    public static Func<T1, TResult> UseCachingForFunc<T1, TResult>(
      Expression<Func<T1, TResult>> extractValueExpr)
    {
      return (Func<T1, TResult>) MetadataLoader.CompileLambda((object) MetadataLoader.GetDecoratedLambda((object) extractValueExpr, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1011990535)));
    }

    /// <summary>
    /// Создать условно кеширующую функцию. Условием (кешировать или нет полученное значение) управляет выражение функции.
    /// </summary>
    /// <typeparam name="T1">Тип первого параметра функции</typeparam>
    /// <typeparam name="TResult">Тип возвращаемого функцией значения, которое упаковано в кортеже вместе с флагом кеширования</typeparam>
    /// <param name="extractValueExpr">Выражение функции</param>
    /// <returns>Кеширующую функцию</returns>
    public static Func<T1, TResult> UseConditionalCachingForFunc<T1, TResult>(
      Expression<Func<T1, Tuple<TResult, bool>>> extractValueExpr)
    {
      return (Func<T1, TResult>) MetadataLoader.CompileLambda((object) MetadataLoader.GetDecoratedLambda((object) extractValueExpr, z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293870620), true));
    }

    /// <summary>
    /// Создать безусловно кеширующую функцию и вернуть метод очистки кеша от её значений
    /// </summary>
    /// <typeparam name="T1">Тип первого параметра функции</typeparam>
    /// <typeparam name="TResult">Тип возвращаемого функцией значения</typeparam>
    /// <param name="extractValueExpr">Выражение функции</param>
    /// <param name="clearAction">Метод очистки кеша</param>
    /// <returns>Кеширующую функцию</returns>
    public static Func<T1, TResult> UseCachingForFunc<T1, TResult>(
      Expression<Func<T1, TResult>> extractValueExpr,
      out System.Action clearAction)
    {
      clearAction = MetadataLoader.ClearFunc((object) extractValueExpr.ToString());
      return (Func<T1, TResult>) MetadataLoader.CompileLambda((object) MetadataLoader.GetDecoratedLambda((object) extractValueExpr, extractValueExpr.ToString()));
    }

    /// <summary>Создать безусловно кеширующую функцию</summary>
    /// <typeparam name="T1">Тип первого параметра функции</typeparam>
    /// <typeparam name="T2">Тип второго параметра функции</typeparam>
    /// <typeparam name="TResult">Тип возвращаемого функцией значения</typeparam>
    /// <param name="extractValueExpr">Выражение функции</param>
    /// <returns>Кеширующую функцию</returns>
    public static Func<T1, T2, TResult> UseCachingForFunc<T1, T2, TResult>(
      Expression<Func<T1, T2, TResult>> extractValueExpr)
    {
      return (Func<T1, T2, TResult>) MetadataLoader.CompileLambda((object) MetadataLoader.GetDecoratedLambda((object) extractValueExpr, z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1756974534)));
    }

    /// <summary>
    /// Создать безусловно кеширующую функцию и вернуть метод очистки кеша от её значений
    /// </summary>
    /// <typeparam name="T1">Тип первого параметра функции</typeparam>
    /// <typeparam name="T2">Тип второго параметра функции</typeparam>
    /// <typeparam name="TResult">Тип возвращаемого функцией значения</typeparam>
    /// <param name="extractValueExpr">Выражение функции</param>
    /// <param name="clearAction">Метод очистки кеша</param>
    /// <returns>Кеширующую функцию</returns>
    public static Func<T1, T2, TResult> UseCachingForFunc<T1, T2, TResult>(
      Expression<Func<T1, T2, TResult>> extractValueExpr,
      out System.Action clearAction)
    {
      clearAction = MetadataLoader.ClearFunc((object) extractValueExpr.ToString());
      return (Func<T1, T2, TResult>) MetadataLoader.CompileLambda((object) MetadataLoader.GetDecoratedLambda((object) extractValueExpr, extractValueExpr.ToString()));
    }

    /// <summary>Создать безусловно кеширующую функцию</summary>
    /// <typeparam name="T1">Тип первого параметра функции</typeparam>
    /// <typeparam name="T2">Тип второго параметра функции</typeparam>
    /// <typeparam name="T3">Тип третьего параметра функции</typeparam>
    /// <typeparam name="TResult">Тип возвращаемого функцией значения</typeparam>
    /// <param name="extractValueExpr">Выражение функции</param>
    /// <returns>Кеширующую функцию</returns>
    public static Func<T1, T2, T3, TResult> UseCachingForFunc<T1, T2, T3, TResult>(
      Expression<Func<T1, T2, T3, TResult>> extractValueExpr)
    {
      return (Func<T1, T2, T3, TResult>) MetadataLoader.CompileLambda((object) MetadataLoader.GetDecoratedLambda((object) extractValueExpr, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 154004013)));
    }

    /// <summary>
    /// Создать безусловно кеширующую функцию и вернуть метод очистки кеша от её значений
    /// </summary>
    /// <typeparam name="T1">Тип первого параметра функции</typeparam>
    /// <typeparam name="T2">Тип второго параметра функции</typeparam>
    /// <typeparam name="T3">Тип третьего параметра функции</typeparam>
    /// <typeparam name="TResult">Тип возвращаемого функцией значения</typeparam>
    /// <param name="extractValueExpr">Выражение функции</param>
    /// <param name="clearAction">Метод очистки кеша</param>
    /// <returns>Кеширующую функцию</returns>
    public static Func<T1, T2, T3, TResult> UseCachingForFunc<T1, T2, T3, TResult>(
      Expression<Func<T1, T2, T3, TResult>> extractValueExpr,
      out System.Action clearAction)
    {
      clearAction = MetadataLoader.ClearFunc((object) extractValueExpr.ToString());
      return (Func<T1, T2, T3, TResult>) MetadataLoader.CompileLambda((object) MetadataLoader.GetDecoratedLambda((object) extractValueExpr, extractValueExpr.ToString()));
    }

    private static Delegate CompileLambda(object exp) => ((LambdaExpression) exp).CompileFast();

    private static System.Action ClearFunc(object region)
    {
      string region1 = (string) region;
      return (System.Action) (() =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: reference to a compiler-generated method
              MetadataLoader.\u003C\u003Ec__DisplayClass46_0.mioy4hC6hjW61eQGPmNU((object) MetadataLoader.MetadataCaches[region1]);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      });
    }

    private static T GetCacheValue<T>(object key, object region, Func<T> func)
    {
      MemoryCache metadataCach = MetadataLoader.MetadataCaches[(string) region];
      object cacheValue = metadataCach.Get((string) key, (string) null);
      if (cacheValue is MemoryCacheService.NullValue)
        cacheValue = (object) default (T);
      else if (cacheValue == null)
      {
        cacheValue = (object) func();
        metadataCach.Set((string) key, cacheValue ?? (object) MemoryCacheService.NullValue.Null, ObjectCache.InfiniteAbsoluteExpiration, (string) null);
      }
      return (T) cacheValue;
    }

    private static T GetCacheValueCond<T>(object key, object region, Func<Tuple<T, bool>> func)
    {
      MemoryCache metadataCach = MetadataLoader.MetadataCaches[(string) region];
      object cacheValueCond = metadataCach.Get((string) key, (string) null);
      if (cacheValueCond is MemoryCacheService.NullValue)
        cacheValueCond = (object) default (T);
      else if (cacheValueCond == null)
      {
        Tuple<T, bool> tuple = func();
        cacheValueCond = (object) tuple.Item1;
        if (tuple.Item2)
          metadataCach.Set((string) key, cacheValueCond ?? (object) MemoryCacheService.NullValue.Null, ObjectCache.InfiniteAbsoluteExpiration, (string) null);
      }
      return (T) cacheValueCond;
    }

    private static LambdaExpression GetDecoratedLambda(
      object extractValueExpr,
      string region = "MetadataCache",
      bool useConditionalCaching = false)
    {
      int num = 6;
      Type type1;
      BlockExpression body;
      while (true)
      {
        ParameterExpression parameterExpression;
        Type type2;
        switch (num)
        {
          case 1:
            goto label_10;
          case 2:
            parameterExpression = (ParameterExpression) MetadataLoader.G61G0Ib03ExuEEY1ePT4(TypeOf<string>.Raw, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541809623));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
            continue;
          case 3:
            type2 = MetadataLoader.yCb190b0N45F1kIgDbIx(extractValueExpr).GetGenericArguments()[0];
            break;
          case 4:
            type2 = MetadataLoader.yCb190b0N45F1kIgDbIx(extractValueExpr);
            break;
          case 5:
            if (useConditionalCaching)
            {
              num = 3;
              continue;
            }
            goto case 4;
          case 6:
            // ISSUE: reference to a compiler-generated method
            MetadataLoader.MetadataCaches.AddOrUpdate<string, MemoryCache>(region, (Func<string, MemoryCache>) (r => new MemoryCache((string) MetadataLoader.\u003C\u003Ec.tNnVQZC4HvQ8ji59B3gX(572119659 - -337058038 ^ 909249433))), (Func<string, MemoryCache, MemoryCache>) ((r, c) => c));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 5 : 5;
            continue;
          default:
            body = Expression.Block(type1, (IEnumerable<ParameterExpression>) new ParameterExpression[1]
            {
              parameterExpression
            }, (Expression) MetadataLoader.bhShTTb0pEibt3Lu1hjI((object) parameterExpression, extractValueExpr), (Expression) MetadataLoader.prtaygb0w5YMZJe5R35W((object) null, MetadataLoader.AytSBfb0aHhMK2t77p26((object) (useConditionalCaching ? MetadataLoader.getCacheValueCondMethod : MetadataLoader.getCacheValueMethod), (object) new Type[1]
            {
              type1
            }), (object) parameterExpression, MetadataLoader.uCxWjjb0DB2XAry83aoA((object) region), MetadataLoader.ohqCGEb0td9C1DKlhRT9((object) Expression.Invoke((Expression) extractValueExpr, (IEnumerable<Expression>) ((LambdaExpression) extractValueExpr).Parameters), (object) Array.Empty<ParameterExpression>())));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 1 : 1;
            continue;
        }
        type1 = type2;
        num = 2;
      }
label_10:
      // ISSUE: reference to a compiler-generated method
      return Expression.Lambda(MetadataLoader.bi4K2bb0Hh2VJUfy7JFS((object) ((IEnumerable<ParameterInfo>) MetadataLoader.rhiAb4b06960eoE0OlRM((object) MetadataLoader.rKCeARb04HIwr40TfUy9(extractValueExpr).GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501469137)))).Select<ParameterInfo, Type>((Func<ParameterInfo, Type>) (p => MetadataLoader.\u003C\u003Ec.kEx50mC4ADAnV3DlOlwA((object) p))).Concat<Type>(type1).ToArray<Type>()), (Expression) body, (IEnumerable<ParameterExpression>) ((LambdaExpression) extractValueExpr).Parameters);
    }

    private static Expression GenerateKey(object keyVar, object extractValueExpr)
    {
      int num1 = 3;
      List<Expression> initializers;
      IEnumerator<ParameterExpression> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            enumerator = ((LambdaExpression) extractValueExpr).Parameters.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 1 : 1;
            continue;
          case 3:
            initializers = new List<Expression>()
            {
              (Expression) MetadataLoader.uCxWjjb0DB2XAry83aoA((object) MetadataLoader.ParamToString<string>(extractValueExpr.ToString()))
            };
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 2 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (Expression) MetadataLoader.zL5GDxb0y1WmEN9HNhvn(keyVar, (object) Expression.Call(MetadataLoader.stringJoinMethod, (Expression) Expression.Constant(MetadataLoader.rfy1yjb0hRjTYPwEUpjk(272623989 ^ 272612777)), (Expression) Expression.NewArrayInit(TypeOf<string>.Raw, (IEnumerable<Expression>) initializers)));
label_3:
      try
      {
label_13:
        if (enumerator.MoveNext())
          goto label_8;
        else
          goto label_14;
label_4:
        System.Reflection.MethodInfo methodInfo;
        ParameterExpression current;
        Type type;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_13;
            case 3:
            case 4:
              goto label_6;
            case 5:
              methodInfo = (System.Reflection.MethodInfo) MetadataLoader.AytSBfb0aHhMK2t77p26((object) MetadataLoader.genericCollectionToStringMethod, (object) new Type[1]
              {
                type.GetGenericArguments()[0]
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 5 : 7;
              continue;
            case 6:
              type = MetadataLoader.rKCeARb04HIwr40TfUy9((object) current);
              num2 = 9;
              continue;
            case 7:
            case 11:
            case 12:
            case 20:
              initializers.Add((Expression) MetadataLoader.f2THF8b00n8akfDjewAt((object) methodInfo, (object) current));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 2;
              continue;
            case 8:
            case 18:
              methodInfo = MetadataLoader.paramToStringMethod.MakeGenericMethod(type);
              num2 = 12;
              continue;
            case 9:
              if (MetadataLoader.WdEKh6b0AFpbUHT8FoDa(type))
              {
                num2 = 18;
                continue;
              }
              goto case 17;
            case 10:
              if (!(type == typeof (Type)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 6 : 13;
                continue;
              }
              goto case 19;
            case 14:
              methodInfo = MetadataLoader.identifiedParamToStringMethod;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 11 : 6;
              continue;
            case 15:
            case 16:
              if (!MetadataLoader.Mn79ENb07IKF2WIafijG(type))
              {
                num2 = 3;
                continue;
              }
              goto case 14;
            case 17:
              if (type.IsEnum)
              {
                num2 = 8;
                continue;
              }
              goto case 10;
            case 19:
              methodInfo = MetadataLoader.typeParamToStringMethod;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 8 : 20;
              continue;
            case 21:
              goto label_2;
            default:
              if (!type.IsEnumerableOfSimpleType())
              {
                num2 = 16;
                continue;
              }
              goto case 5;
          }
        }
label_6:
        throw new ArgumentException((string) MetadataLoader.dpEQnWb0xkhki0BaPV1d(MetadataLoader.rfy1yjb0hRjTYPwEUpjk(-35995181 ^ -36161339)));
label_8:
        current = enumerator.Current;
        num2 = 6;
        goto label_4;
label_14:
        num2 = 21;
        goto label_4;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_30;
              default:
                MetadataLoader.R17if8b0mw9b9Cym0ZVt((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
                continue;
            }
          }
        }
label_30:;
      }
    }

    private static string ParamToString<T>(T val) => (object) val != null ? val.ToString().Escape('\'').Quote('\'') : z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132908505);

    private static string TypeParamToString(Type type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!MetadataLoader.ArTwsfb0IMD1ih1Vg8NW(type, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_2;
        }
      }
label_2:
      string val = (string) null;
      goto label_6;
label_5:
      val = type.AssemblyQualifiedName;
label_6:
      return MetadataLoader.ParamToString<string>(val);
    }

    private static string GenericCollectionToString<T>(IEnumerable<T> collection) => z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712466773) + collection.ToSeparatedQuotedString<T>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813616417), '\'') + z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44832149);

    private static string IdentifiedParamToString(object param)
    {
      int num1 = 6;
      Type type;
      object val;
      while (true)
      {
        int num2 = num1;
        ArgumentException argumentException1;
        IEntity entity;
        ArgumentException argumentException2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!MetadataLoader.u0WkyMb0d0yo3hdSviuJ((object) entity))
              {
                num2 = 11;
                continue;
              }
              goto label_3;
            case 2:
              if (entity != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 0;
                continue;
              }
              goto label_5;
            case 3:
              goto label_3;
            case 4:
              argumentException2 = new ArgumentException((string) MetadataLoader.dpEQnWb0xkhki0BaPV1d(MetadataLoader.rfy1yjb0hRjTYPwEUpjk(2045296739 + 1688595713 ^ -561228792)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            case 5:
              val = MetadataLoader.Sx1apub0MXZrb7lAKYIu(param);
              num2 = 8;
              continue;
            case 6:
              type = param.GetType();
              num2 = 5;
              continue;
            case 7:
              ((ILogger) MetadataLoader.e0AdMkb0JVa2kHDnmA4l()).Log(EleWise.ELMA.Logging.LogLevel.Error, (Exception) argumentException1, (string) MetadataLoader.VMvTNXb09F0FLuxIjmrj((object) argumentException1));
              num2 = 10;
              continue;
            case 8:
              if (!MetadataLoader.WdEKh6b0AFpbUHT8FoDa(val.GetType()))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 4 : 4;
                continue;
              }
              goto case 9;
            case 9:
              entity = param as IEntity;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 2;
              continue;
            case 10:
            case 11:
              goto label_5;
            default:
              ((ILogger) MetadataLoader.e0AdMkb0JVa2kHDnmA4l()).Log(EleWise.ELMA.Logging.LogLevel.Error, (Exception) argumentException2, (string) MetadataLoader.VMvTNXb09F0FLuxIjmrj((object) argumentException2));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 9 : 9;
              continue;
          }
        }
label_3:
        argumentException1 = new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281962864), (object) type.FullName));
        num1 = 7;
      }
label_5:
      return (string) MetadataLoader.qZy6CAb0lHa17quDCLyX(type) + (string) MetadataLoader.rfy1yjb0hRjTYPwEUpjk(~-397266137 ^ 397188506) + MetadataLoader.ParamToString<object>(val);
    }

    internal static void AddMetadataToCache(Type runtimeType, IRootMetadata metadata, bool inherit = true)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          IDictionary<Type, IRootMetadata> dictionary;
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              if (!inherit)
                goto default;
              else
                goto label_5;
            case 3:
              MetadataLoader.iZQhrMb0G2Ei0gNqaGCL((object) runtimeType, MetadataLoader.rfy1yjb0hRjTYPwEUpjk(-1598106783 - -968262081 ^ -629690884));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 2 : 0;
              continue;
            case 4:
              dictionary = MetadataLoader.loadedMetadataInherit;
              break;
            default:
              dictionary = MetadataLoader.loadedMetadataNotInherit;
              break;
          }
          Type type = runtimeType.GetTypeWithoutProxy();
          if (MetadataLoader.AFL3RPb0fDyljXlhlbV9(type))
            type = type.GetNonNullableType();
          Type key = type;
          IRootMetadata rootMetadata = metadata;
          dictionary[key] = rootMetadata;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
        }
label_5:
        num1 = 4;
      }
label_6:;
    }

    private static void GetBaseClass(
      object metadata,
      List<ClassMetadata> res,
      bool loadImplementation = true)
    {
      if (!(((ClassMetadata) metadata).BaseClassUid != Guid.Empty))
        return;
      ClassMetadata metadata1 = (ClassMetadata) MetadataServiceContext.Service.GetMetadata(((ClassMetadata) metadata).BaseClassUid, loadImplementation);
      if (metadata1 == null)
        return;
      res.Add(metadata1);
      if (!(metadata1.BaseClassUid != Guid.Empty))
        return;
      MetadataLoader.GetBaseClass((object) metadata1, res, loadImplementation);
    }

    private static void GetChildClasses(
      object metadata,
      List<ClassMetadata> res,
      bool loadImplementation = true)
    {
      ClassMetadata metadata1 = (ClassMetadata) metadata;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      List<ClassMetadata> list = MetadataServiceContext.Service.GetMetadataList().OfType<ClassMetadata>().Where<ClassMetadata>((Func<ClassMetadata, bool>) (m => MetadataLoader.\u003C\u003Ec__DisplayClass70_0.IH07itC68golkUVjpvFT(MetadataLoader.\u003C\u003Ec__DisplayClass70_0.bscMwJC6CvUdHdZy1oBk((object) m), MetadataLoader.\u003C\u003Ec__DisplayClass70_0.eY0iSPC6vPajvM3RVipE((object) metadata1)))).ToList<ClassMetadata>();
      res.AddRange((IEnumerable<ClassMetadata>) list);
      foreach (object metadata2 in list)
        MetadataLoader.GetChildClasses(metadata2, res, loadImplementation);
    }

    private static void GetChildEnums(object metadata, List<EnumMetadata> res)
    {
      EnumMetadata metadata1 = (EnumMetadata) metadata;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      List<EnumMetadata> list = MetadataServiceContext.Service.GetMetadataList().OfType<EnumMetadata>().Where<EnumMetadata>((Func<EnumMetadata, bool>) (m => MetadataLoader.\u003C\u003Ec__DisplayClass71_0.B46Vb4C6iON2shgLObiu(MetadataLoader.\u003C\u003Ec__DisplayClass71_0.ksILixC6VWuR005Q3HIs((object) m), MetadataLoader.\u003C\u003Ec__DisplayClass71_0.NQHOJLC6SXi85xen1OiY((object) metadata1)))).ToList<EnumMetadata>();
      res.AddRange((IEnumerable<EnumMetadata>) list);
      foreach (object metadata2 in list)
        MetadataLoader.GetChildEnums(metadata2, res);
    }

    private static void GetChildProperties(
      object metadata,
      List<KeyValuePair<PropertyMetadata, ClassMetadata>> properties)
    {
      ClassMetadata metadata1 = (ClassMetadata) metadata;
      List<KeyValuePair<PropertyMetadata, ClassMetadata>> properties1 = properties;
      if (!(metadata1.Uid != Guid.Empty))
        return;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      foreach (ClassMetadata classMetadata in MetadataServiceContext.Service.GetMetadataList().OfType<ClassMetadata>().Where<ClassMetadata>((Func<ClassMetadata, bool>) (m => MetadataLoader.\u003C\u003Ec__DisplayClass72_0.bPqmjHC6nfMDxojtO20l(MetadataLoader.\u003C\u003Ec__DisplayClass72_0.vrhhgHC6T5GBNl7sHBGq((object) m), MetadataLoader.\u003C\u003Ec__DisplayClass72_0.GZTmEDC6kUlG2QMy88A4((object) metadata1)))))
      {
        ClassMetadata child = (ClassMetadata) MetadataLoader.LoadMetadata(classMetadata.Uid, false, false);
        properties1.AddRange((IEnumerable<KeyValuePair<PropertyMetadata, ClassMetadata>>) child.Properties.Where<PropertyMetadata>((Func<PropertyMetadata, bool>) (pm =>
        {
          int num = 1;
          PropertyMetadata pm1;
          while (true)
          {
            switch (num)
            {
              case 1:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_4;
              default:
                pm1 = pm;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 2 : 1;
                continue;
            }
          }
label_4:
          return !properties1.Any<KeyValuePair<PropertyMetadata, ClassMetadata>>((Func<KeyValuePair<PropertyMetadata, ClassMetadata>, bool>) (p =>
          {
            if (p.Key.Uid == Guid.Empty && p.Key.Name == pm1.Name)
              return true;
            return p.Key.Uid != Guid.Empty && p.Key.Uid == pm1.Uid;
          }));
        })).Select<PropertyMetadata, KeyValuePair<PropertyMetadata, ClassMetadata>>((Func<PropertyMetadata, KeyValuePair<PropertyMetadata, ClassMetadata>>) (pm => new KeyValuePair<PropertyMetadata, ClassMetadata>(pm, child))).OrderBy<KeyValuePair<PropertyMetadata, ClassMetadata>, int>((Func<KeyValuePair<PropertyMetadata, ClassMetadata>, int>) (p => p.Key.Order)));
        MetadataLoader.GetChildProperties((object) child, properties1);
      }
    }

    private static void GetBaseProperties(
      object metadata,
      List<PropertyMetadata> properties,
      List<KeyValuePair<PropertyMetadata, ClassMetadata>> propertiesAndMetadata,
      Func<Guid, ClassMetadata> func)
    {
      if (func == null || !(((ClassMetadata) metadata).BaseClassUid != Guid.Empty))
        return;
      ClassMetadata baseClass = func(((ClassMetadata) metadata).BaseClassUid);
      if (baseClass == null)
        return;
      MetadataLoader.GetBaseProperties((object) baseClass, properties, propertiesAndMetadata, func);
      if (properties != null)
        properties.AddRange(baseClass.Properties.Where<PropertyMetadata>((Func<PropertyMetadata, bool>) (bp =>
        {
          int num = 2;
          PropertyMetadata bp1;
          while (true)
          {
            switch (num)
            {
              case 1:
                bp1 = bp;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
                continue;
              case 2:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 1 : 1;
                continue;
              default:
                goto label_4;
            }
          }
label_4:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          return properties.All<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => MetadataLoader.\u003C\u003Ec__DisplayClass73_2.IiRYVjC6ylugkDacb44y(p.Uid, MetadataLoader.\u003C\u003Ec__DisplayClass73_2.QSntJ9C6m0ks97nyRd1Z((object) bp1))));
        })));
      if (propertiesAndMetadata == null)
        return;
      propertiesAndMetadata.AddRange(baseClass.Properties.Where<PropertyMetadata>((Func<PropertyMetadata, bool>) (bp =>
      {
        int num = 2;
        PropertyMetadata bp2;
        while (true)
        {
          switch (num)
          {
            case 1:
              bp2 = bp;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
            case 2:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 1;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return propertiesAndMetadata.All<KeyValuePair<PropertyMetadata, ClassMetadata>>((Func<KeyValuePair<PropertyMetadata, ClassMetadata>, bool>) (pc => pc.Key.Uid != bp2.Uid));
      })).Select<PropertyMetadata, KeyValuePair<PropertyMetadata, ClassMetadata>>((Func<PropertyMetadata, KeyValuePair<PropertyMetadata, ClassMetadata>>) (p => new KeyValuePair<PropertyMetadata, ClassMetadata>(p, baseClass))));
    }

    private static List<IPropertyMetadata> GetPropertiesAndTableParts(
      object metadata,
      bool onlyBase,
      bool includeExtensions)
    {
      Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876048495));
      List<ClassMetadata> classMetadataList = MetadataLoader.GetClassMetadataList(metadata, true, !onlyBase, includeExtensions);
      List<IPropertyMetadata> propertiesAndTableParts = new List<IPropertyMetadata>();
      foreach (ClassMetadata classMetadata in classMetadataList)
      {
        if (classMetadata is EntityMetadata entityMetadata)
          propertiesAndTableParts.AddRange(entityMetadata.GetPropertiesAndTableParts());
        else
          propertiesAndTableParts.AddRange(classMetadata.Properties.Cast<IPropertyMetadata>());
      }
      return propertiesAndTableParts;
    }

    private static List<ClassMetadata> GetClassMetadataList(
      object rootMetadata,
      bool includeBase,
      bool includeRootMetadata,
      bool includeExtensions,
      bool loadImplementation = true)
    {
      Contract.ArgumentNotNull(rootMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309740244));
      // ISSUE: reference to a compiler-generated method
      Func<Guid, bool, ClassMetadata> func = (Func<Guid, bool, ClassMetadata>) ((uid, loadImpl) => (ClassMetadata) ((IMetadataService) MetadataLoader.\u003C\u003Ec.QEf6MbC46BXEwoRAqHGb()).GetMetadata(uid, loadImpl));
      Func<Guid, List<ClassMetadata>> getExtensionsFunc = (Func<Guid, List<ClassMetadata>>) (uid => MetadataServiceContext.Service.GetMetadataList().OfType<ClassMetadata>().Where<ClassMetadata>((Func<ClassMetadata, bool>) (m =>
      {
        int num = 2;
        EntityMetadata entityMetadata;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (entityMetadata == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 2:
              entityMetadata = m as EntityMetadata;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
              continue;
            case 3:
              goto label_7;
            case 4:
              // ISSUE: reference to a compiler-generated method
              if (MetadataLoader.\u003C\u003Ec__DisplayClass75_0.uqofucC6jjoueGk4rl4l((object) entityMetadata) == EntityMetadataType.InterfaceExtension)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 3 : 0;
                continue;
              }
              goto label_8;
            default:
              goto label_8;
          }
        }
label_7:
        // ISSUE: reference to a compiler-generated method
        return MetadataLoader.\u003C\u003Ec__DisplayClass75_0.Bi7fYqC6Ys57LhVxkQJZ(entityMetadata.BaseClassUid, uid);
label_8:
        return false;
      })).ToList<ClassMetadata>());
      List<ClassMetadata> result = new List<ClassMetadata>();
      if (includeRootMetadata)
        MetadataLoader.GetClassMetadataListNonRecursive(rootMetadata, result, includeExtensions, getExtensionsFunc);
      if (includeBase)
        MetadataLoader.GetBaseClassMetadataList(rootMetadata, result, func, includeExtensions, getExtensionsFunc, loadImplementation);
      return result;
    }

    private static void GetBaseClassMetadataList(
      object metadata,
      List<ClassMetadata> result,
      Func<Guid, bool, ClassMetadata> func,
      bool includeExtensions,
      Func<Guid, List<ClassMetadata>> getExtensionsFunc,
      bool loadImplementation = true)
    {
      ClassMetadata metadata1 = (ClassMetadata) metadata;
      if (func == null || !(metadata1.BaseClassUid != Guid.Empty))
        return;
      ClassMetadata metadata2 = func(metadata1.BaseClassUid, loadImplementation);
      if (metadata2 == null)
        return;
      MetadataLoader.GetClassMetadataListNonRecursive((object) metadata2, result, includeExtensions, (Func<Guid, List<ClassMetadata>>) (uid => getExtensionsFunc == null ? new List<ClassMetadata>() : getExtensionsFunc(uid).Where<ClassMetadata>((Func<ClassMetadata, bool>) (m =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (m == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
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
        return m.Uid != MetadataLoader.\u003C\u003Ec__DisplayClass76_0.l9QPl8C6zOkZRDmf1Ch6((object) metadata1);
label_5:
        return false;
      })).ToList<ClassMetadata>()));
      MetadataLoader.GetBaseClassMetadataList((object) metadata2, result, func, includeExtensions, getExtensionsFunc, loadImplementation);
    }

    private static void GetClassMetadataListNonRecursive(
      object metadata,
      List<ClassMetadata> result,
      bool includeExtensions,
      Func<Guid, List<ClassMetadata>> getExtensionsFunc)
    {
      if (metadata == null)
        return;
      List<ClassMetadata> collection1 = new List<ClassMetadata>();
      collection1.Add((ClassMetadata) metadata);
      if (includeExtensions && getExtensionsFunc != null)
      {
        List<ClassMetadata> collection2 = getExtensionsFunc(((AbstractMetadata) metadata).Uid);
        if (collection2 != null)
          collection1.AddRange((IEnumerable<ClassMetadata>) collection2);
      }
      result.InsertRange(0, (IEnumerable<ClassMetadata>) collection1);
    }

    public static Guid GetMetadataUid(EntityMetadata metadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (MetadataLoader.a7b5yFb0rSOkTOMr9GGX((object) metadata) == EntityMetadataType.InterfaceExtension)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return MetadataLoader.QhfTXcb0OXKZ6imHbWIZ((object) metadata);
label_5:
      return metadata.Uid;
    }

    private static void GetEntityActions(
      List<EnumValueMetadata> items,
      object metadata,
      bool inherit,
      bool onlyBase,
      bool includeExtensions)
    {
      Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837680827));
      switch (((EntityMetadata) metadata).Type)
      {
        case EntityMetadataType.InterfaceExtension:
          if (includeExtensions && ((ClassMetadata) metadata).BaseClassUid != Guid.Empty)
          {
            metadata = (object) (EntityMetadata) MetadataServiceContext.Service.GetMetadata(((ClassMetadata) metadata).BaseClassUid, false);
            break;
          }
          break;
        case EntityMetadataType.InterfaceImplementation:
          metadata = (object) (EntityMetadata) MetadataServiceContext.Service.GetMetadata(((EntityMetadata) metadata).ImplementationUid, false);
          break;
      }
      foreach (EntityMetadata classMetadata in MetadataLoader.GetClassMetadataList(metadata, inherit, !onlyBase || !inherit, includeExtensions, false))
      {
        if (classMetadata.Actions != null)
          items.AddRange((IEnumerable<EnumValueMetadata>) classMetadata.Actions.Values);
      }
      if (!inherit)
        return;
      items.AddRange((IEnumerable<EnumValueMetadata>) EntityAuditActionProvider.DefaultActions.Values);
    }

    private static void GetDependentMetadataUidsRecursive(
      object metadata,
      ISet<Guid> result,
      IDictionary<Guid, List<EntityMetadata>> entityMetadataByBaseClassUid = null)
    {
      if (metadata == null || !result.Add(((IMetadata) metadata).Uid))
        return;
      if (metadata is ICompositeMetadata compositeMetadata)
        MetadataLoader.AddCompositeMetadataUids((object) compositeMetadata, result);
      if (!(metadata is EntityMetadata entityMetadata))
        return;
      if (entityMetadataByBaseClassUid == null)
        entityMetadataByBaseClassUid = (IDictionary<Guid, List<EntityMetadata>>) MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>().Where<EntityMetadata>((Func<EntityMetadata, bool>) (m => m.Type != EntityMetadataType.InterfaceExtension)).GroupBy<EntityMetadata, Guid>((Func<EntityMetadata, Guid>) (m => m.BaseClassUid)).ToDictionary<IGrouping<Guid, EntityMetadata>, Guid, List<EntityMetadata>>((Func<IGrouping<Guid, EntityMetadata>, Guid>) (g => g.Key), (Func<IGrouping<Guid, EntityMetadata>, List<EntityMetadata>>) (g => g.ToList<EntityMetadata>()));
      if (entityMetadata.Type == EntityMetadataType.InterfaceExtension)
      {
        result.Add(entityMetadata.BaseClassUid);
        MetadataLoader.GetDependentMetadataUidsRecursive((object) (MetadataServiceContext.Service.GetMetadata(entityMetadata.BaseClassUid) as EntityMetadata), result, entityMetadataByBaseClassUid);
      }
      else
      {
        List<EntityMetadata> entityMetadataList;
        if (entityMetadataByBaseClassUid.TryGetValue(entityMetadata.Uid, out entityMetadataList))
        {
          foreach (object metadata1 in entityMetadataList)
            MetadataLoader.GetDependentMetadataUidsRecursive(metadata1, result, entityMetadataByBaseClassUid);
        }
        if (entityMetadata.Type != EntityMetadataType.Interface)
          return;
        MetadataLoader.GetDependentMetadataUidsRecursive((object) (MetadataServiceContext.Service.GetMetadata(entityMetadata.ImplementationUid) as EntityMetadata), result, entityMetadataByBaseClassUid);
      }
    }

    private static void AddCompositeMetadataUids(object compositeMetadata, ISet<Guid> uids)
    {
      if (compositeMetadata == null)
        return;
      IEnumerable<IMetadata> compositeParts = ((ICompositeMetadata) compositeMetadata).GetCompositeParts();
      if (compositeParts == null)
        return;
      foreach (IMetadata metadata in compositeParts)
      {
        uids.Add(metadata.Uid);
        if (metadata is ICompositeMetadata compositeMetadata1)
          MetadataLoader.AddCompositeMetadataUids((object) compositeMetadata1, uids);
      }
    }

    private static List<ClassMetadata> EnumerateChildClasses(
      Guid metadataUid,
      bool loadImplementation,
      bool includeRoot)
    {
      return MetadataLoader.LoadMetadataOrNull(metadataUid, false, loadImplementation) is ClassMetadata metadata ? MetadataLoader.GetChildClassesList((object) metadata, loadImplementation, includeRoot) : new List<ClassMetadata>();
    }

    private static List<EnumMetadata> EnumerateChildEnums(Guid metadataUid) => MetadataLoader.LoadMetadataOrNull(metadataUid, false, false) is EnumMetadata metadata ? MetadataLoader.GetChildEnumsList((object) metadata) : new List<EnumMetadata>();

    private static List<ClassMetadata> EnumerateBaseClasses(
      Guid metadataUid,
      bool loadImplementation)
    {
      return MetadataLoader.LoadMetadataOrNull(metadataUid, false, loadImplementation) is ClassMetadata metadata ? MetadataLoader.GetBaseClassesList((object) metadata, loadImplementation) : new List<ClassMetadata>();
    }

    private static List<ClassMetadata> GetChildClassesList(
      object metadata,
      bool loadImplementation,
      bool includeRoot)
    {
      List<ClassMetadata> res = new List<ClassMetadata>();
      MetadataLoader.GetChildClasses(metadata, res, loadImplementation);
      if (includeRoot)
        res.Add((ClassMetadata) metadata);
      return res;
    }

    private static List<EnumMetadata> GetChildEnumsList(object metadata)
    {
      List<EnumMetadata> res = new List<EnumMetadata>();
      MetadataLoader.GetChildEnums(metadata, res);
      return res;
    }

    private static List<ClassMetadata> GetBaseClassesList(object metadata, bool loadImplementation = true)
    {
      List<ClassMetadata> res = new List<ClassMetadata>();
      MetadataLoader.GetBaseClass(metadata, res, loadImplementation);
      return res;
    }

    public MetadataLoader()
    {
      MetadataLoader.G07GOwb0gqiqe4SA4PQt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static MetadataLoader()
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        ParameterExpression parameterExpression1;
        ParameterExpression parameterExpression2;
        ParameterExpression parameterExpression3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: type reference
              parameterExpression1 = (ParameterExpression) MetadataLoader.sxvXecb05ZbUxG0q7H0f(MetadataLoader.hFy5DQb0vXGxVrJJmu17(__typeref (Guid)), MetadataLoader.rfy1yjb0hRjTYPwEUpjk(-1839087379 - 334718690 ^ 2121243101));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 21 : 3;
              continue;
            case 2:
              MetadataLoader.getCacheValueMethod = TypeOf<MetadataLoader>.Raw.GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583648680), BindingFlags.Static | BindingFlags.NonPublic);
              num2 = 5;
              continue;
            case 3:
              MetadataLoader.loadedMetadataNotInherit = PublishCacheContext.CreateCache<Type, IRootMetadata>((Action<IDictionary<Type, IRootMetadata>, Type, Guid>) ((c, t, _) => c.Remove(t)));
              num2 = 4;
              continue;
            case 4:
              MetadataLoader.propertiesByParents = PublishCacheContext.CreateCache<Guid, List<KeyValuePair<PropertyMetadata, ClassMetadata>>>((Action<IDictionary<Guid, List<KeyValuePair<PropertyMetadata, ClassMetadata>>>, Type, Guid>) ((c, _, __) => c.Clear()));
              num2 = 18;
              continue;
            case 5:
              MetadataLoader.getCacheValueCondMethod = TypeOf<MetadataLoader>.Raw.GetMethod((string) MetadataLoader.rfy1yjb0hRjTYPwEUpjk(95909607 + 343705423 ^ 439420156), BindingFlags.Static | BindingFlags.NonPublic);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 10 : 2;
              continue;
            case 6:
              MetadataLoader.typeParamToStringMethod = TypeOf<MetadataLoader>.Raw.GetMethod((string) MetadataLoader.rfy1yjb0hRjTYPwEUpjk(1199946765 ^ 1200047875), BindingFlags.Static | BindingFlags.NonPublic);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 6 : 17;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated method
              MetadataLoader.dictionaryIndexer = ((IEnumerable<System.Reflection.PropertyInfo>) TypeOf<IDictionary<string, MemoryCache>>.Raw.GetProperties()).Where<System.Reflection.PropertyInfo>((Func<System.Reflection.PropertyInfo, bool>) (p => MetadataLoader.\u003C\u003Ec.yBoI4vC47IUeOIuvFB2N(p.PropertyType, TypeOf<MemoryCache>.Raw))).First<System.Reflection.PropertyInfo>((Func<System.Reflection.PropertyInfo, bool>) (p =>
              {
                int num3 = 1;
                ParameterInfo[] parameterInfoArray;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      parameterInfoArray = (ParameterInfo[]) MetadataLoader.\u003C\u003Ec.NTeLODC4x4DuEYv4Pg8p((object) p);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_5;
                    default:
                      if (parameterInfoArray.Length == 1)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 2 : 2;
                        continue;
                      }
                      goto label_6;
                  }
                }
label_5:
                // ISSUE: reference to a compiler-generated method
                return MetadataLoader.\u003C\u003Ec.yBoI4vC47IUeOIuvFB2N(parameterInfoArray[0].ParameterType, TypeOf<string>.Raw);
label_6:
                return false;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 4 : 9;
              continue;
            case 8:
              MetadataLoader.G07GOwb0gqiqe4SA4PQt();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 2 : 7;
              continue;
            case 9:
              MetadataLoader.MetadataCaches = PublishCacheContext.CreateCache<string, MemoryCache>((Func<IDictionary<string, MemoryCache>, IDictionary<string, MemoryCache>>) (cache => (cache != null ? (IDictionary<string, MemoryCache>) cache.ToConcurrentDictionary<KeyValuePair<string, MemoryCache>, string, MemoryCache>((Func<KeyValuePair<string, MemoryCache>, string>) (p => p.Key), (Func<KeyValuePair<string, MemoryCache>, MemoryCache>) (p => new MemoryCache(p.Value.Name))) : (IDictionary<string, MemoryCache>) null) ?? (IDictionary<string, MemoryCache>) new ConcurrentDictionary<string, MemoryCache>()), onComplete: (Action<IDictionary<string, MemoryCache>>) (cache => cache.ForEach<KeyValuePair<string, MemoryCache>>((Action<KeyValuePair<string, MemoryCache>>) (c => c.Value.Clear()))));
              num2 = 2;
              continue;
            case 10:
              MetadataLoader.paramToStringMethod = TypeOf<MetadataLoader>.Raw.GetMethod((string) MetadataLoader.rfy1yjb0hRjTYPwEUpjk(1597012150 ^ 1597145670), BindingFlags.Static | BindingFlags.NonPublic);
              num2 = 6;
              continue;
            case 11:
              // ISSUE: type reference
              parameterExpression3 = (ParameterExpression) MetadataLoader.sxvXecb05ZbUxG0q7H0f(MetadataLoader.hFy5DQb0vXGxVrJJmu17(__typeref (bool)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889646616));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 6 : 14;
              continue;
            case 12:
              MetadataLoader.identifiedParamToStringMethod = TypeOf<MetadataLoader>.Raw.GetMethod((string) MetadataLoader.rfy1yjb0hRjTYPwEUpjk(-1255365154 ^ 596875508 ^ -1765947840), BindingFlags.Static | BindingFlags.NonPublic);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
              continue;
            case 13:
              // ISSUE: method reference
              MetadataLoader.getChildClassesCached = MetadataLoader.UseCachingForFunc<Guid, bool, bool, List<ClassMetadata>>(Expression.Lambda<Func<Guid, bool, bool, List<ClassMetadata>>>((Expression) MetadataLoader.ItTTupb0Y6tdLUKNT6Bq((object) null, (object) (System.Reflection.MethodInfo) MetadataLoader.IqunObb0jwUUfS3wS4Ps(__methodref (MetadataLoader.EnumerateChildClasses)), (object) new Expression[3]
              {
                (Expression) parameterExpression2,
                (Expression) parameterExpression3,
                (Expression) parameterExpression1
              }), parameterExpression2, parameterExpression3, parameterExpression1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 0;
              continue;
            case 14:
              // ISSUE: method reference
              MetadataLoader.getBaseClassesCached = MetadataLoader.UseCachingForFunc<Guid, bool, List<ClassMetadata>>(Expression.Lambda<Func<Guid, bool, List<ClassMetadata>>>((Expression) MetadataLoader.ItTTupb0Y6tdLUKNT6Bq((object) null, (object) (System.Reflection.MethodInfo) MetadataLoader.IqunObb0jwUUfS3wS4Ps(__methodref (MetadataLoader.EnumerateBaseClasses)), (object) new Expression[2]
              {
                (Expression) parameterExpression1,
                (Expression) parameterExpression3
              }), parameterExpression1, parameterExpression3));
              num2 = 15;
              continue;
            case 15:
              goto label_3;
            case 16:
              // ISSUE: type reference
              parameterExpression3 = (ParameterExpression) MetadataLoader.sxvXecb05ZbUxG0q7H0f(MetadataLoader.hFy5DQb0vXGxVrJJmu17(__typeref (bool)), MetadataLoader.rfy1yjb0hRjTYPwEUpjk(372753449 ^ 372588417));
              num2 = 19;
              continue;
            case 17:
              MetadataLoader.genericCollectionToStringMethod = TypeOf<MetadataLoader>.Raw.GetMethod((string) MetadataLoader.rfy1yjb0hRjTYPwEUpjk(-1334993905 ^ -1334876357), BindingFlags.Static | BindingFlags.NonPublic);
              num2 = 12;
              continue;
            case 18:
              // ISSUE: type reference
              parameterExpression2 = (ParameterExpression) MetadataLoader.sxvXecb05ZbUxG0q7H0f(MetadataLoader.hFy5DQb0vXGxVrJJmu17(__typeref (Guid)), MetadataLoader.rfy1yjb0hRjTYPwEUpjk(-1487388570 ^ -1487305808));
              num2 = 16;
              continue;
            case 19:
              parameterExpression1 = (ParameterExpression) MetadataLoader.sxvXecb05ZbUxG0q7H0f(typeof (bool), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113977151));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 1 : 13;
              continue;
            case 20:
              // ISSUE: type reference
              parameterExpression1 = Expression.Parameter(MetadataLoader.hFy5DQb0vXGxVrJJmu17(__typeref (Guid)), (string) MetadataLoader.rfy1yjb0hRjTYPwEUpjk(1113862659 ^ 1113977301));
              num2 = 11;
              continue;
            case 21:
              goto label_5;
            case 22:
              MetadataLoader.loadedMetadataInherit = PublishCacheContext.CreateCache<Type, IRootMetadata>((Action<IDictionary<Type, IRootMetadata>, Type, Guid>) ((c, _, __) => c.Clear()));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 3 : 2;
              continue;
            default:
              MetadataLoader.stringJoinMethod = TypeOf<string>.Raw.GetMethod((string) MetadataLoader.rfy1yjb0hRjTYPwEUpjk(222162814 ^ 222237922), new Type[2]
              {
                TypeOf<string>.Raw,
                TypeOf<IEnumerable<string>>.Raw
              });
              num2 = 22;
              continue;
          }
        }
label_5:
        // ISSUE: method reference
        MetadataLoader.getChildEnumsCached = MetadataLoader.UseCachingForFunc<Guid, List<EnumMetadata>>(Expression.Lambda<Func<Guid, List<EnumMetadata>>>((Expression) MetadataLoader.ItTTupb0Y6tdLUKNT6Bq((object) null, (object) (System.Reflection.MethodInfo) MethodBase.GetMethodFromHandle(__methodref (MetadataLoader.EnumerateChildEnums)), (object) new Expression[1]
        {
          (Expression) parameterExpression1
        }), parameterExpression1));
        num1 = 20;
      }
label_3:;
    }

    internal static object rfy1yjb0hRjTYPwEUpjk(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void iZQhrMb0G2Ei0gNqaGCL([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static Type jCuu0eb0E4immWvfQVWF(Type type) => type.GetTypeWithoutProxy();

    internal static bool AFL3RPb0fDyljXlhlbV9(Type type) => EleWise.ELMA.Extensions.TypeExtensions.IsNullableType(type);

    internal static Type kJBLVjb0Q7nkxs6GlxXN(Type t) => InterfaceActivator.TypeOf(t);

    internal static ComponentManager.LifetimeStage y6iuUeb0CvSZCdPaX0hU([In] object obj0) => ((ComponentManager) obj0).Stage;

    internal static Type hFy5DQb0vXGxVrJJmu17([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static Type sg0DmXb08NO3ovJJlTLh([In] object obj0) => ((MetadataTypeAttribute) obj0).MetadataType;

    internal static object nUUTUSb0ZP5lQlcoifjE([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static bool gbcEbgb0oiT7uxKx8wjf() => MetadataLoader.GbOXxjb0WCmVE4JvNPuN == null;

    internal static MetadataLoader X8ly9ob0bgL7BObd21ds() => MetadataLoader.GbOXxjb0WCmVE4JvNPuN;

    internal static bool K50hkLb0uR8qJN072NCK([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool ArTwsfb0IMD1ih1Vg8NW([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static Guid jdpuMXb0V0gvw39Mg8Tj([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool dQhHgLb0SNRkd5yaWEUC([In] object obj0, Guid objectTypeUid) => MetadataLoader.IsBaseOrChildClass((ClassMetadata) obj0, objectTypeUid);

    internal static Type VGGB4jb0iOeDO9QkE9id(Guid uid) => UniqueFilterHelper.GetUniqueFilterType(uid);

    internal static void Spj3M4b0RDDawGQZlcdm([In] object obj0, Guid value) => ((ReferenceOnEntityType) obj0).TypeUid = value;

    internal static Type DDwdDAb0qOouhF3AyNmF([In] object obj0) => ((ReferenceOnEntityType) obj0).EntityType;

    internal static object A6Nlv7b0KhjbmBXjfDg7([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static Type UkWceKb0XLk2DT2LOSIr([In] object obj0, [In] object obj1) => ((Assembly) obj0).GetReflectionType((string) obj1);

    internal static bool DC4jwZb0TPgFT0F789Kd([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object X1xPCib0k25Nt2UEKy9j(Type type, Type attributeType, bool inherit) => (object) type.GetReflectionCustomAttributes(attributeType, inherit);

    internal static Type W2X9olb0n4FZWalKI0fu([In] object obj0) => ((FilterForAttribute) obj0).EntityType;

    internal static Guid QhfTXcb0OXKZ6imHbWIZ([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static bool McwB1Ob02j8RHnalpkN3([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object HdLAFlb0e8vQFDZZSPX2() => (object) MetadataServiceContext.Service;

    internal static object VSSKEBb0P1atop7fMNCV([In] object obj0, Guid propertyuid) => (object) MetadataLoader.GetRealMetadataForProperty((ClassMetadata) obj0, propertyuid);

    internal static object tZ8JPXb01RBnUu5F7IOE() => (object) ComponentManager.Current;

    internal static Type yCb190b0N45F1kIgDbIx([In] object obj0) => ((LambdaExpression) obj0).ReturnType;

    internal static object G61G0Ib03ExuEEY1ePT4([In] Type obj0, [In] object obj1) => (object) Expression.Variable(obj0, (string) obj1);

    internal static object bhShTTb0pEibt3Lu1hjI([In] object obj0, [In] object obj1) => (object) MetadataLoader.GenerateKey(obj0, obj1);

    internal static object AytSBfb0aHhMK2t77p26([In] object obj0, [In] object obj1) => (object) ((System.Reflection.MethodInfo) obj0).MakeGenericMethod((Type[]) obj1);

    internal static object uCxWjjb0DB2XAry83aoA([In] object obj0) => (object) Expression.Constant(obj0);

    internal static object ohqCGEb0td9C1DKlhRT9([In] object obj0, [In] object obj1) => (object) Expression.Lambda((Expression) obj0, (ParameterExpression[]) obj1);

    internal static object prtaygb0w5YMZJe5R35W(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      return (object) Expression.Call((Expression) obj0, (System.Reflection.MethodInfo) obj1, (Expression) obj2, (Expression) obj3, (Expression) obj4);
    }

    internal static Type rKCeARb04HIwr40TfUy9([In] object obj0) => ((Expression) obj0).Type;

    internal static object rhiAb4b06960eoE0OlRM([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();

    internal static Type bi4K2bb0Hh2VJUfy7JFS([In] object obj0) => Expression.GetFuncType((Type[]) obj0);

    internal static bool WdEKh6b0AFpbUHT8FoDa(Type type) => type.IsSimpleType();

    internal static bool Mn79ENb07IKF2WIafijG(Type type) => type.IsIdentifiedType();

    internal static object dpEQnWb0xkhki0BaPV1d([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object f2THF8b00n8akfDjewAt([In] object obj0, [In] object obj1) => (object) Expression.Call((System.Reflection.MethodInfo) obj0, (Expression) obj1);

    internal static void R17if8b0mw9b9Cym0ZVt([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object zL5GDxb0y1WmEN9HNhvn([In] object obj0, [In] object obj1) => (object) Expression.Assign((Expression) obj0, (Expression) obj1);

    internal static object Sx1apub0MXZrb7lAKYIu([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static object e0AdMkb0JVa2kHDnmA4l() => (object) Logger.Log;

    internal static object VMvTNXb09F0FLuxIjmrj([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static bool u0WkyMb0d0yo3hdSviuJ([In] object obj0) => ((IEntity) obj0).IsNew();

    internal static object qZy6CAb0lHa17quDCLyX(Type type) => (object) MetadataLoader.TypeParamToString(type);

    internal static EntityMetadataType a7b5yFb0rSOkTOMr9GGX([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static void G07GOwb0gqiqe4SA4PQt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object sxvXecb05ZbUxG0q7H0f([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object IqunObb0jwUUfS3wS4Ps([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object ItTTupb0Y6tdLUKNT6Bq([In] object obj0, [In] object obj1, [In] object obj2) => (object) Expression.Call((Expression) obj0, (System.Reflection.MethodInfo) obj1, (Expression[]) obj2);
  }
}
