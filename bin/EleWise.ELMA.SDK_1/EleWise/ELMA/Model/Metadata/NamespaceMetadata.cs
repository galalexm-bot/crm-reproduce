// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.NamespaceMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Modules.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Метаданные пространства имен</summary>
  [XmlRoot("Namespace")]
  [Serializable]
  public class NamespaceMetadata : 
    NamedMetadata,
    ICodeItemMetadata,
    IMetadata,
    IXsiType,
    IRootMetadata
  {
    internal static NamespaceMetadata u5k14qb7qAfpC1ZacfRT;

    /// <summary>Пространство имен</summary>
    public virtual string Namespace
    {
      get => this.\u003CNamespace\u003Ek__BackingField;
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
              this.\u003CNamespace\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
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

    /// <summary>Отображаемое пространство имен</summary>
    [DefaultValue("")]
    public virtual string NamespaceForDisplay
    {
      get => this.\u003CNamespaceForDisplay\u003Ek__BackingField;
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
              this.\u003CNamespaceForDisplay\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
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

    /// <summary>Полное имя типа</summary>
    public string FullTypeName
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!NamespaceMetadata.DblDCdb7k3anYylMbJqK(NamespaceMetadata.nerT5Ab7TESx51eXU7Iw((object) this)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        string str = (string) NamespaceMetadata.nerT5Ab7TESx51eXU7Iw((object) this) + (string) NamespaceMetadata.YnTXYEb7nfNdIIqnIpWp(-1217523399 ^ -1217524739);
        goto label_6;
label_5:
        str = string.Empty;
label_6:
        object obj = NamespaceMetadata.sPy9sDb7OA5yRKH3Tck2((object) this);
        return (string) NamespaceMetadata.pP79Ykb72bOINCFfX52v((object) str, obj);
      }
    }

    /// <summary>
    /// Разрешить создавать новые модели через дизайнер в данном пространстве имен
    /// </summary>
    [DefaultValue(false)]
    public bool AllowCreateModels
    {
      get => this.\u003CAllowCreateModels\u003Ek__BackingField;
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
              this.\u003CAllowCreateModels\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
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

    /// <summary>Загрузить метаданные из скомпилированного типа</summary>
    /// <param name="type">Тип</param>
    /// <param name="inherit">True, если нужно выбирать свойства, включая родительские классы</param>
    public void LoadFromType(Type type, bool inherit = true)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        AssemblyModuleAttribute attribute1;
        UidAttribute attribute2;
        INamespaceInfo instance;
        while (true)
        {
          switch (num2)
          {
            case 1:
              instance = (INamespaceInfo) Activator.CreateInstance(type);
              num2 = 6;
              continue;
            case 2:
              this.Uid = attribute2 == null ? Guid.Empty : attribute2.Uid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 5 : 0;
              continue;
            case 3:
              attribute2 = AttributeHelper<UidAttribute>.GetAttribute(type, false);
              num2 = 2;
              continue;
            case 4:
              goto label_13;
            case 5:
              attribute1 = AttributeHelper<AssemblyModuleAttribute>.GetAttribute(type.Assembly);
              num2 = 7;
              continue;
            case 6:
              NamespaceMetadata.BLUtf0b7plSkjp2dVmXm((object) this, instance == null ? (object) string.Empty : (object) instance.DisplayName);
              num2 = 10;
              continue;
            case 7:
              NamespaceMetadata.jrX66mb7epHm1Q8nQQF7((object) this, attribute1 == null ? Guid.Empty : attribute1.Uid);
              num2 = 9;
              continue;
            case 8:
              NamespaceMetadata.PqG87Lb73ucmc9O7JtRF((object) this, (object) type.Namespace);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 1;
              continue;
            case 9:
              NamespaceMetadata.LgWwE4b7PDMa60Rq1CHY((object) this, !type.IsPublic && !type.IsNestedPublic);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            case 10:
              goto label_7;
            default:
              NamespaceMetadata.wYIAqLb7NRq3LQjEIejM((object) this, NamespaceMetadata.b80EYZb71S9pgCqqIj6w((object) type));
              num2 = 8;
              continue;
          }
        }
label_7:
        this.AllowCreateModels = AttributeHelper<AllowCreateModelsAttribute>.GetAttribute(type, false) != null;
        num1 = 4;
      }
label_13:;
    }

    /// <summary>Требуют ли изменения в метаданных перезапуска сервера</summary>
    /// <param name="metadata">Измененные метаданные</param>
    /// <returns>True, если требуют</returns>
    public virtual bool IsRestartNeeded(IRootMetadata metadata) => true;

    /// <summary>Применить изменения, не требующие перезапуска сервера</summary>
    public virtual void ApplyRestartUnrequiredChanges(bool inherit)
    {
    }

    /// <summary>Построить дерево пространств имен</summary>
    /// <param name="namespaces">Список метаданных пространств имен</param>
    /// <returns>Корневой узел дерева</returns>
    public static NamespaceMetadata.TreeNode BuildNamespaceTree(List<NamespaceMetadata> namespaces)
    {
      NamespaceMetadata.TreeNode root = new NamespaceMetadata.TreeNode();
      Dictionary<string, NamespaceMetadata.TreeNode> nodesByNamespace = new Dictionary<string, NamespaceMetadata.TreeNode>();
      // ISSUE: reference to a compiler-generated method
      foreach (NamespaceMetadata metadata in namespaces.Where<NamespaceMetadata>((Func<NamespaceMetadata, bool>) (n => NamespaceMetadata.\u003C\u003Ec.xx00jFC4VpIrl0RDNGOE((object) n))))
      {
        if (metadata.Namespace != null)
          NamespaceMetadata.AddNode((object) metadata, (object) root, namespaces, nodesByNamespace);
      }
      return root;
    }

    private static NamespaceMetadata.TreeNode AddNode(
      object metadata,
      object root,
      List<NamespaceMetadata> namespaces,
      Dictionary<string, NamespaceMetadata.TreeNode> nodesByNamespace)
    {
      NamespaceMetadata.TreeNode treeNode1;
      if (nodesByNamespace.TryGetValue(((NamespaceMetadata) metadata).Namespace, out treeNode1))
        return treeNode1;
      int length = ((NamespaceMetadata) metadata).Namespace.LastIndexOf('.');
      NamespaceMetadata.TreeNode treeNode2 = (NamespaceMetadata.TreeNode) null;
      if (length >= 0)
      {
        string prevNsName = ((NamespaceMetadata) metadata).Namespace.Substring(0, length);
        // ISSUE: reference to a compiler-generated method
        NamespaceMetadata metadata1 = namespaces.FirstOrDefault<NamespaceMetadata>((Func<NamespaceMetadata, bool>) (ns => NamespaceMetadata.\u003C\u003Ec__DisplayClass20_0.ntH8EoC4KxgDiFI494Gb((object) ns.Namespace, (object) prevNsName)));
        treeNode2 = metadata1 != null ? NamespaceMetadata.AddNode((object) metadata1, root, namespaces, nodesByNamespace) : (NamespaceMetadata.TreeNode) null;
      }
      if (string.IsNullOrEmpty(((NamedMetadata) metadata).DisplayName))
      {
        nodesByNamespace.Add(((NamespaceMetadata) metadata).Namespace, treeNode2);
        if (treeNode2 != null && !treeNode2.AllowCreateModels && ((NamespaceMetadata) metadata).AllowCreateModels)
        {
          treeNode2.AllowCreateModels = true;
          treeNode2.Namespace = ((NamespaceMetadata) metadata).Namespace;
        }
        return treeNode2;
      }
      string str = length >= 0 ? ((NamespaceMetadata) metadata).Namespace.Substring(length + 1) : ((NamespaceMetadata) metadata).Namespace;
      NamespaceMetadata.TreeNode treeNode3 = new NamespaceMetadata.TreeNode()
      {
        Name = str,
        DisplayName = ((NamedMetadata) metadata).DisplayName,
        Namespace = ((NamespaceMetadata) metadata).Namespace
      };
      treeNode3.AllowCreateModels = ((NamespaceMetadata) metadata).AllowCreateModels;
      (treeNode2 != null ? treeNode2.Nodes : ((NamespaceMetadata.TreeNode) root).Nodes).Add(treeNode3);
      nodesByNamespace.Add(((NamespaceMetadata) metadata).Namespace, treeNode3);
      return treeNode3;
    }

    public NamespaceMetadata()
    {
      NamespaceMetadata.Ht91TSb7aRPBWmjrbgrt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool y4h0uib7Kgwvpa5ycFlc() => NamespaceMetadata.u5k14qb7qAfpC1ZacfRT == null;

    internal static NamespaceMetadata bCkH28b7Xo8jGi2S2fq7() => NamespaceMetadata.u5k14qb7qAfpC1ZacfRT;

    internal static object nerT5Ab7TESx51eXU7Iw([In] object obj0) => (object) ((NamespaceMetadata) obj0).Namespace;

    internal static bool DblDCdb7k3anYylMbJqK([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object YnTXYEb7nfNdIIqnIpWp(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object sPy9sDb7OA5yRKH3Tck2([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object pP79Ykb72bOINCFfX52v([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void jrX66mb7epHm1Q8nQQF7([In] object obj0, Guid value) => ((AbstractMetadata) obj0).ModuleUid = value;

    internal static void LgWwE4b7PDMa60Rq1CHY([In] object obj0, bool value) => ((AbstractMetadata) obj0).Internal = value;

    internal static object b80EYZb71S9pgCqqIj6w([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static void wYIAqLb7NRq3LQjEIejM([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static void PqG87Lb73ucmc9O7JtRF([In] object obj0, [In] object obj1) => ((NamespaceMetadata) obj0).Namespace = (string) obj1;

    internal static void BLUtf0b7plSkjp2dVmXm([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).DisplayName = (string) obj1;

    internal static void Ht91TSb7aRPBWmjrbgrt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    /// <summary>Информация о типе метаданных</summary>
    [Component]
    private class Info : IMetadataTypeInfo
    {
      private static object zhanh8C4ovGDYPKHJPCt;

      public string Name => EleWise.ELMA.SR.T((string) NamespaceMetadata.Info.WRafD0C4Gk59esM7Px1J(1581325282 << 3 ^ -234000008));

      public string Description => string.Empty;

      public Type MetadataType => NamespaceMetadata.Info.nCBgOfC4Ets54E5PcoRS(__typeref (NamespaceMetadata));

      public Type GeneratorType => NamespaceMetadata.Info.nCBgOfC4Ets54E5PcoRS(__typeref (NamespaceGenerator));

      public Info()
      {
        NamespaceMetadata.Info.Bk0XxaC4fBHSIahLs0qZ();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object WRafD0C4Gk59esM7Px1J(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool La5lcQC4bavLaokBtrLT() => NamespaceMetadata.Info.zhanh8C4ovGDYPKHJPCt == null;

      internal static NamespaceMetadata.Info PHZV4uC4h4ySstoy8Jrx() => (NamespaceMetadata.Info) NamespaceMetadata.Info.zhanh8C4ovGDYPKHJPCt;

      internal static Type nCBgOfC4Ets54E5PcoRS([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static void Bk0XxaC4fBHSIahLs0qZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    /// <summary>Узел дерева метаданных пространств имен</summary>
    public class TreeNode
    {
      internal static NamespaceMetadata.TreeNode vqaL00C4QEid1dytq0jI;

      /// <summary>Ctor</summary>
      public TreeNode()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.Nodes = new List<NamespaceMetadata.TreeNode>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      /// <summary>Имя</summary>
      public string Name
      {
        get => this.\u003CName\u003Ek__BackingField;
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
                this.\u003CName\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
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

      /// <summary>Отображаемое имя</summary>
      public string DisplayName
      {
        get => this.\u003CDisplayName\u003Ek__BackingField;
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
                this.\u003CDisplayName\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
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

      /// <summary>Пространство имен</summary>
      public string Namespace
      {
        get => this.\u003CNamespace\u003Ek__BackingField;
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
                this.\u003CNamespace\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
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

      /// <summary>Можно ли создавать модели в данном пространстве имен</summary>
      public bool AllowCreateModels
      {
        get => this.\u003CAllowCreateModels\u003Ek__BackingField;
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
                this.\u003CAllowCreateModels\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
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

      /// <summary>Подчиненные узлы</summary>
      public List<NamespaceMetadata.TreeNode> Nodes { get; set; }

      internal static bool kUFFdwC4Cn7DnDEdd689() => NamespaceMetadata.TreeNode.vqaL00C4QEid1dytq0jI == null;

      internal static NamespaceMetadata.TreeNode E1UujlC4vTP6Kf7KNelo() => NamespaceMetadata.TreeNode.vqaL00C4QEid1dytq0jI;
    }
  }
}
