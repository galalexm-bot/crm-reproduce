// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Nodes.SchemaNode
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Nodes
{
  /// <summary>Узел структуры источника данных</summary>
  [Serializable]
  public class SchemaNode
  {
    /// <summary>Узлы-потомки</summary>
    private List<SchemaNode> childs;
    private static SchemaNode tLyLdGWLAYaGgfDN82QL;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
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

    /// <summary>Тип</summary>
    public string Type
    {
      get => this.\u003CType\u003Ek__BackingField;
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
              this.\u003CType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
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

    /// <summary>Узел-родитель</summary>
    public SchemaNode Parent
    {
      get => this.\u003CParent\u003Ek__BackingField;
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
              this.\u003CParent\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
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

    public bool IsRoot => this.Parent == null;

    public IEnumerable<SchemaNode> Childs => (IEnumerable<SchemaNode>) this.childs;

    /// <summary>Добавить узел-потомок</summary>
    /// <param name="node"></param>
    public void AddChild(SchemaNode node)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            SchemaNode.sHkIA7WL0BU530hsvRkZ((object) node, (object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.childs.Add(node);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Добавить коллекцию узлов-потомков</summary>
    /// <param name="nodes"></param>
    public void AddChilds(IEnumerable<SchemaNode> nodes) => nodes.ForEach<SchemaNode>(new Action<SchemaNode>(this.AddChild));

    public SchemaNode()
    {
      SchemaNode.iUMJHsWLmTtHccFMi85o();
      this.childs = new List<SchemaNode>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Qqbh1mWL72OpuKjvgAlJ() => SchemaNode.tLyLdGWLAYaGgfDN82QL == null;

    internal static SchemaNode TM6hoQWLxmkm4sfNouJU() => SchemaNode.tLyLdGWLAYaGgfDN82QL;

    internal static void sHkIA7WL0BU530hsvRkZ([In] object obj0, [In] object obj1) => ((SchemaNode) obj0).Parent = (SchemaNode) obj1;

    internal static void iUMJHsWLmTtHccFMi85o() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
