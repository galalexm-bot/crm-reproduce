// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApi.PublicApiNodeEntityProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi
{
  [Component(Order = 1000)]
  public class PublicApiNodeEntityProvider : IPublicApiNodeProvider
  {
    private static readonly IList<string> ObsoleteNodes;
    private static object managerTypesInitLock;
    private static ConcurrentDictionary<Type, Type> managerTypes;
    private static PublicApiNodeEntityProvider xnqZ2khHLrQoCeKTgikc;

    public IEnumerable<IPublicApiNode> CreatePublicApiNodes() => (IEnumerable<IPublicApiNode>) new PublicApiNodeEntityProvider.\u003CCreatePublicApiNodes\u003Ed__0(-2);

    public static IEnumerable<IPublicApiNode> BuildObjectsTree(string parentPath, string groupName)
    {
      MetadataTreeHelper.GroupNode groupByName = MetadataTreeHelper.GetGroupByName(MetadataTreeHelper.BuildTree(PublicApiNodeEntityProvider.GetEntityObjectsToTree(), false, generateForPublicApi: true), groupName);
      return PublicApiNodeEntityProvider.BuildObjectsTree(parentPath, groupByName);
    }

    public static IEnumerable<IPublicApiNode> BuildObjectsTree(
      string parentPath,
      MetadataTreeHelper.GroupNode groupNode)
    {
      return groupNode == null ? Enumerable.Empty<IPublicApiNode>() : PublicApiNodeEntityProvider.BuildObjectsTree((object) parentPath, (object) groupNode, PublicApiNodeEntityProvider.GetEntityObjects(), false);
    }

    private static IEnumerable<IPublicApiNode> BuildObjectsTree(
      object parentPath,
      object groupTreeNode,
      IEnumerable<EntityMetadata> metadataList,
      bool hidden)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<IPublicApiNode>) new PublicApiNodeEntityProvider.\u003CBuildObjectsTree\u003Ed__5(-2)
      {
        \u003C\u003E3__parentPath = (string) parentPath,
        \u003C\u003E3__groupTreeNode = (MetadataTreeHelper.GroupNode) groupTreeNode,
        \u003C\u003E3__metadataList = metadataList,
        \u003C\u003E3__hidden = hidden
      };
    }

    private static IEnumerable<IPublicApiNode> UserObject(object parentPath, object metadata) => (IEnumerable<IPublicApiNode>) new PublicApiNodeEntityProvider.\u003CUserObject\u003Ed__6(-2)
    {
      \u003C\u003E3__parentPath = (string) parentPath,
      \u003C\u003E3__metadata = (EntityMetadata) metadata
    };

    private static ISyntaxNode ManagerReferenceCode(object type) => ((ISyntaxNode) PublicApiNodeEntityProvider.qmxMpMhAFEkCaC9c0RyA((object) PublicApiNodeEntityProvider.D8HeBkhHcr94BhJcaSDD((object) EleWise.ELMA.SDK.TypeOf.Locator).CreateTypeSyntax(), (object) ((string) PublicApiNodeEntityProvider.D8JDWlhHzqintGZnpKwv(-35995181 ^ -36063455)).GenericName((ISyntaxNode) type))).InvocationExpression();

    public static IEnumerable<IPublicApiNode> TableParts(
      string parentPath,
      EntityMetadata parentMetadata)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<IPublicApiNode>) new PublicApiNodeEntityProvider.\u003CTableParts\u003Ed__8(-2)
      {
        \u003C\u003E3__parentPath = parentPath,
        \u003C\u003E3__parentMetadata = parentMetadata
      };
    }

    public static IEnumerable<IPublicApiNode> TableParts(string parentPath, Type type) => (IEnumerable<IPublicApiNode>) new PublicApiNodeEntityProvider.\u003CTableParts\u003Ed__9(-2)
    {
      \u003C\u003E3__parentPath = parentPath,
      \u003C\u003E3__type = type
    };

    private static IEnumerable<IPublicApiNode> TablePart(object parentPath, object metadata) => (IEnumerable<IPublicApiNode>) new PublicApiNodeEntityProvider.\u003CTablePart\u003Ed__10(-2)
    {
      \u003C\u003E3__parentPath = (string) parentPath,
      \u003C\u003E3__metadata = (EntityMetadata) metadata
    };

    /// <summary>Получить выражение вызова сервиса\менеджера</summary>
    /// <param name="type">Вызываемый тип</param>
    /// <returns>Выражение</returns>
    public static ISyntaxNode GetManagerReferenceCode(ISyntaxNode type) => ((ISyntaxNode) PublicApiNodeEntityProvider.qmxMpMhAFEkCaC9c0RyA((object) EleWise.ELMA.SDK.TypeOf.Locator.Raw.CreateTypeSyntax(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283600937).GenericName(type))).InvocationExpression();

    /// <summary>Получить вызываемые методы</summary>
    /// <param name="type">Тип</param>
    /// <returns>Массив методов</returns>
    public static MethodInfo[] InvokeMethods(Type type)
    {
      MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod);
      // ISSUE: reference to a compiler-generated field
      Func<MethodInfo, bool> func1 = PublicApiNodeEntityProvider.\u003C\u003Ec.\u003C\u003E9__12_0;
      Func<MethodInfo, bool> predicate1;
      if (func1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        PublicApiNodeEntityProvider.\u003C\u003Ec.\u003C\u003E9__12_0 = predicate1 = (Func<MethodInfo, bool>) (m => AttributeHelper<PublicApiMemberAttribute>.GetAttribute((MemberInfo) m, false) != null);
      }
      else
        goto label_1;
label_3:
      IEnumerable<MethodInfo> source = ((IEnumerable<MethodInfo>) methods).Where<MethodInfo>(predicate1);
      // ISSUE: reference to a compiler-generated field
      Func<MethodInfo, bool> func2 = PublicApiNodeEntityProvider.\u003C\u003Ec.\u003C\u003E9__12_1;
      Func<MethodInfo, bool> predicate2;
      if (func2 == null)
      {
        // ISSUE: reference to a compiler-generated field
        PublicApiNodeEntityProvider.\u003C\u003Ec.\u003C\u003E9__12_1 = predicate2 = (Func<MethodInfo, bool>) (m => AttributeHelper<PublicApiNodeIdAttribute>.GetAttribute((MemberInfo) m, false) == null);
      }
      else
        goto label_4;
label_6:
      return source.Where<MethodInfo>(predicate2).ToArray<MethodInfo>();
label_4:
      predicate2 = func2;
      goto label_6;
label_1:
      predicate1 = func1;
      goto label_3;
    }

    /// <summary>Получить вызываемые методы</summary>
    /// <param name="parentPath">Родителький узел дерева</param>
    /// <param name="managerType">Тип менеджера</param>
    /// <param name="typeArguments">Аргументы типа менеджера (при необходимости)</param>
    /// <returns>Узлы дерева</returns>
    public static IEnumerable<IPublicApiNode> InvokeMethods(
      string parentPath,
      Type managerType,
      params TypeArgument[] typeArguments)
    {
      return PublicApiNodeEntityProvider.InvokeMethods(parentPath, managerType, (Func<MethodInfo, bool>) (m => true), typeArguments);
    }

    /// <summary>Получить вызываемые методы</summary>
    /// <param name="parentPath">Родителький узел дерева</param>
    /// <param name="managerType">Тип менеджера</param>
    /// <param name="exceptFunc">Фильтрация методов менеждера</param>
    /// <param name="typeArguments">Аргументы типа менеджера (при необходимости)</param>
    /// <returns>Узлы дерева</returns>
    public static IEnumerable<IPublicApiNode> InvokeMethods(
      string parentPath,
      Type managerType,
      Func<MethodInfo, bool> exceptFunc,
      params TypeArgument[] typeArguments)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<IPublicApiNode>) new PublicApiNodeEntityProvider.\u003CInvokeMethods\u003Ed__14(-2)
      {
        \u003C\u003E3__parentPath = parentPath,
        \u003C\u003E3__managerType = managerType,
        \u003C\u003E3__exceptFunc = exceptFunc,
        \u003C\u003E3__typeArguments = typeArguments
      };
    }

    /// <summary>Получить список метадаты сущностей</summary>
    /// <returns>Список метадаты</returns>
    private static IEnumerable<EntityMetadata> GetEntityObjects() => (IEnumerable<EntityMetadata>) PublicApiCodeGenerator.Current.GetAllMetadata().OfType<EntityMetadata>().Where<EntityMetadata>((Func<EntityMetadata, bool>) (m =>
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            if (!PublicApiNodeEntityProvider.\u003C\u003Ec.vwMM8rvpR6XXp89FX1MS(PublicApiNodeEntityProvider.\u003C\u003Ec.YlVCsZvpi2JpTVFJarnJ(), (object) m))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      return !PublicApiNodeEntityProvider.\u003C\u003Ec.g43TgxvpksGQqj5MpYc4((object) PublicApiCodeGenerator.Current, (object) m);
label_5:
      return false;
    })).ToArray<EntityMetadata>();

    /// <summary>
    /// Получить список метадаты сущностей для построения дерева
    /// </summary>
    /// <returns>Список метадаты сущностей для построения дерева</returns>
    public static IEnumerable<ICodeItemMetadata> GetEntityObjectsToTree() => (IEnumerable<ICodeItemMetadata>) ((IEnumerable<ICodeItemMetadata>) PublicApiNodeEntityProvider.GetEntityObjects().OrderBy<EntityMetadata, string>((Func<EntityMetadata, string>) (m => m.DisplayName))).ToArray<ICodeItemMetadata>();

    /// <summary>Молучить тип менеджера для типа сущности</summary>
    /// <param name="entityType">Тип сущности</param>
    /// <returns>Тип менеджера</returns>
    public static Type GetManagerType(Type entityType)
    {
      int num1 = 1;
      Type managerType;
      while (true)
      {
        int num2 = num1;
        DefaultManagerAttribute managerAttribute;
        bool lockTaken;
        object managerTypesInitLock;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (PublicApiNodeEntityProvider.managerTypes == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 2:
              try
              {
                Monitor.Enter(managerTypesInitLock, ref lockTaken);
                int num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
                  num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      if (PublicApiNodeEntityProvider.managerTypes == null)
                      {
                        num3 = 2;
                        continue;
                      }
                      goto label_35;
                    case 2:
                      IEnumerable<Type> extensionPointTypes = ((ComponentManager) PublicApiNodeEntityProvider.OV0KajhABNRCZBWBPwLI()).GetExtensionPointTypes(typeof (IEntityManager));
                      // ISSUE: reference to a compiler-generated field
                      Func<Type, \u003C\u003Ef__AnonymousType4<Type, Type>> func1 = PublicApiNodeEntityProvider.\u003C\u003Ec.\u003C\u003E9__19_0;
                      Func<Type, \u003C\u003Ef__AnonymousType4<Type, Type>> selector;
                      if (func1 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: object of a compiler-generated type is created
                        PublicApiNodeEntityProvider.\u003C\u003Ec.\u003C\u003E9__19_0 = selector = type => new \u003C\u003Ef__AnonymousType4<Type, Type>(type, type.GetInterface(EleWise.ELMA.SDK.TypeOf.IEntityManager1.Raw.FullName));
                      }
                      else
                        goto label_40;
label_20:
                      IEnumerable<IGrouping<Type, \u003C\u003Ef__AnonymousType4<Type, Type>>> source = extensionPointTypes.Select(selector).Where(t => t.entityManager != (Type) null).GroupBy(t => t.entityManager.GetGenericArguments()[0]);
                      // ISSUE: reference to a compiler-generated field
                      Func<IGrouping<Type, \u003C\u003Ef__AnonymousType4<Type, Type>>, Type> func2 = PublicApiNodeEntityProvider.\u003C\u003Ec.\u003C\u003E9__19_3;
                      Func<IGrouping<Type, \u003C\u003Ef__AnonymousType4<Type, Type>>, Type> keySelector;
                      if (func2 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        PublicApiNodeEntityProvider.\u003C\u003Ec.\u003C\u003E9__19_3 = keySelector = t => t.Key;
                      }
                      else
                        goto label_39;
label_22:
                      // ISSUE: reference to a compiler-generated field
                      Func<IGrouping<Type, \u003C\u003Ef__AnonymousType4<Type, Type>>, Type> func3 = PublicApiNodeEntityProvider.\u003C\u003Ec.\u003C\u003E9__19_4;
                      Func<IGrouping<Type, \u003C\u003Ef__AnonymousType4<Type, Type>>, Type> elementSelector;
                      if (func3 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        PublicApiNodeEntityProvider.\u003C\u003Ec.\u003C\u003E9__19_4 = elementSelector = t => t.Select(tt => tt.type).Where<Type>((Func<Type, bool>) (tt => AttributeHelper<ObsoleteAttribute>.GetAttribute(tt, false) == null)).LastOrDefault<Type>();
                      }
                      else
                        goto label_38;
label_24:
                      PublicApiNodeEntityProvider.managerTypes = new ConcurrentDictionary<Type, Type>((IEnumerable<KeyValuePair<Type, Type>>) source.ToDictionary<IGrouping<Type, \u003C\u003Ef__AnonymousType4<Type, Type>>, Type, Type>(keySelector, elementSelector));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                      continue;
label_38:
                      elementSelector = func3;
                      goto label_24;
label_39:
                      keySelector = func2;
                      goto label_22;
label_40:
                      selector = func1;
                      goto label_20;
                    default:
                      goto label_35;
                  }
                }
              }
              finally
              {
                if (lockTaken)
                {
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
                    num4 = 0;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_30;
                      default:
                        Monitor.Exit(managerTypesInitLock);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_30:;
              }
            case 3:
label_35:
              if (!PublicApiNodeEntityProvider.managerTypes.TryGetValue(entityType, out managerType))
              {
                num2 = 13;
                continue;
              }
              goto label_8;
            case 4:
              if (managerAttribute == null)
              {
                num2 = 5;
                continue;
              }
              goto case 7;
            case 5:
              if (!entityType.IsInterface)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 5 : 7;
                continue;
              }
              goto case 10;
            case 6:
              lockTaken = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 1 : 2;
              continue;
            case 7:
            case 9:
              if (managerAttribute != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 5 : 12;
                continue;
              }
              goto case 11;
            case 8:
              goto label_8;
            case 10:
              managerAttribute = ((IEnumerable<Type>) entityType.GetInterfaces()).Select<Type, DefaultManagerAttribute>((Func<Type, DefaultManagerAttribute>) (intf => AttributeHelper<DefaultManagerAttribute>.GetAttribute(intf, false))).FirstOrDefault<DefaultManagerAttribute>((Func<DefaultManagerAttribute, bool>) (attr => attr != null));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 6 : 9;
              continue;
            case 11:
              PublicApiNodeEntityProvider.managerTypes[entityType] = managerType;
              num2 = 8;
              continue;
            case 12:
              goto label_9;
            case 13:
              goto label_5;
            default:
              managerTypesInitLock = PublicApiNodeEntityProvider.managerTypesInitLock;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 5 : 6;
              continue;
          }
        }
label_5:
        managerAttribute = AttributeHelper<DefaultManagerAttribute>.GetAttribute(entityType, true);
        num1 = 4;
        continue;
label_9:
        managerType = PublicApiNodeEntityProvider.hna0eGhAWOcfXWh2X1ha((object) managerAttribute, entityType);
        num1 = 11;
      }
label_8:
      return managerType;
    }

    /// <summary>Получить список типов менеджеров</summary>
    /// <returns>Список типов менеджеров</returns>
    public static IEnumerable<Type> GetManagerTypes() => (IEnumerable<Type>) Locator.GetServiceNotNull<IEntityManagerTypesStorage>().GetManagerTypes().ToArray<Type>();

    /// <summary>Инициализировать нод в дереве АПИ</summary>
    public static IEnumerable<IPublicApiNode> Members<T, TManager>(
      string parentPath,
      bool skipTableParts = false,
      bool skipTypeUid = false)
      where T : IEntity
      where TManager : IEntityManager<T>
    {
      return PublicApiNodeEntityProvider.Members((object) parentPath, TypeOf<T>.Raw, TypeOf<TManager>.Raw, skipTableParts, skipTypeUid);
    }

    private static IEnumerable<IPublicApiNode> Members(
      object parentPath,
      Type type,
      Type managerType,
      bool skipTableParts = false,
      bool skipTypeUid = false)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<IPublicApiNode>) new PublicApiNodeEntityProvider.\u003CMembers\u003Ed__22(-2)
      {
        \u003C\u003E3__parentPath = (string) parentPath,
        \u003C\u003E3__type = type,
        \u003C\u003E3__managerType = managerType,
        \u003C\u003E3__skipTableParts = skipTableParts,
        \u003C\u003E3__skipTypeUid = skipTypeUid
      };
    }

    public PublicApiNodeEntityProvider()
    {
      PublicApiNodeEntityProvider.hFoU3xhAoYvAEsF4xcvy();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static PublicApiNodeEntityProvider()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PublicApiNodeEntityProvider.hFoU3xhAoYvAEsF4xcvy();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
            continue;
          case 2:
            PublicApiNodeEntityProvider.managerTypesInitLock = new object();
            num = 3;
            continue;
          case 3:
            goto label_2;
          default:
            PublicApiNodeEntityProvider.ObsoleteNodes = (IList<string>) new string[9]
            {
              (string) PublicApiNodeEntityProvider.D8JDWlhHzqintGZnpKwv(323422137 << 2 ^ 1293903246),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727405518),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293903228),
              (string) PublicApiNodeEntityProvider.D8JDWlhHzqintGZnpKwv(1149433385 + 173655049 ^ 1323286942),
              (string) PublicApiNodeEntityProvider.D8JDWlhHzqintGZnpKwv(1232639661 >> 3 ^ 153905439),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978553574),
              (string) PublicApiNodeEntityProvider.D8JDWlhHzqintGZnpKwv(~541731958 ^ -541675625),
              (string) PublicApiNodeEntityProvider.D8JDWlhHzqintGZnpKwv(-1886646897 ^ -1886424637),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824426007)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static Type D8HeBkhHcr94BhJcaSDD([In] object obj0) => ((RipeType) obj0).Raw;

    internal static object D8JDWlhHzqintGZnpKwv(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object qmxMpMhAFEkCaC9c0RyA([In] object obj0, [In] object obj1) => (object) ((ISyntaxNode) obj0).MemberAccessExpression((ISyntaxNode) obj1);

    internal static bool McewQahHUWDv6xvKAjbG() => PublicApiNodeEntityProvider.xnqZ2khHLrQoCeKTgikc == null;

    internal static PublicApiNodeEntityProvider i6qPY0hHsL6F7gcpj6YY() => PublicApiNodeEntityProvider.xnqZ2khHLrQoCeKTgikc;

    internal static object OV0KajhABNRCZBWBPwLI() => (object) ComponentManager.Current;

    internal static Type hna0eGhAWOcfXWh2X1ha([In] object obj0, Type objectType) => ((DefaultManagerAttribute) obj0).GetManagerType(objectType);

    internal static void hFoU3xhAoYvAEsF4xcvy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class TypesAndMetadataBindingModel
    {
      internal static object JH0SPDvpfCqoKUatK30y;

      public Type ManagerType
      {
        get => this.\u003CManagerType\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CManagerType\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      public Type EntityType
      {
        get => this.\u003CEntityType\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CEntityType\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      public TypesAndMetadataBindingModel()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool OENBUTvpQpyohdPMJGiF() => PublicApiNodeEntityProvider.TypesAndMetadataBindingModel.JH0SPDvpfCqoKUatK30y == null;

      internal static PublicApiNodeEntityProvider.TypesAndMetadataBindingModel KKdjs9vpCKkyDqulQWjI() => (PublicApiNodeEntityProvider.TypesAndMetadataBindingModel) PublicApiNodeEntityProvider.TypesAndMetadataBindingModel.JH0SPDvpfCqoKUatK30y;
    }
  }
}
