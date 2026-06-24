// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Models.DeployTreeNode
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Models
{
  /// <summary>Узел дерева объектов экспорта-импорта</summary>
  public sealed class DeployTreeNode
  {
    private static DeployTreeNode CJITjJEwgHF8FM2dKJvp;

    /// <summary>Ctor</summary>
    /// <param name="id">Идентификатор узла</param>
    /// <param name="text">Текст узла</param>
    /// <param name="icon">Url иконки узла дерева</param>
    /// <param name="isDirtyItem">Есть неопубликованные изменения</param>
    /// <param name="isPublished">У объекта есть опубликованная версия</param>
    /// <param name="children">Вложенные узлы</param>
    public DeployTreeNode(
      string id,
      string text,
      string icon,
      bool isDirtyItem,
      bool isPublished,
      ICollection<DeployTreeNode> children)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Id = id;
      this.Text = text;
      this.Icon = icon;
      this.Children = children ?? (ICollection<DeployTreeNode>) new List<DeployTreeNode>();
      this.IsDirtyItem = isDirtyItem;
      this.IsPublished = isPublished;
    }

    /// <summary>Ctor</summary>
    /// <param name="id">Идентификатор узла</param>
    /// <param name="text">Текст узла</param>
    /// <param name="icon">Url иконки узла дерева</param>
    public DeployTreeNode(string id, string text, string icon)
    {
      DeployTreeNode.AxCbFBEwYVHg4atICyv4();
      // ISSUE: explicit constructor call
      this.\u002Ector(id, text, icon, false, true, (ICollection<DeployTreeNode>) null);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="id">Идентификатор узла</param>
    /// <param name="text">Текст узла</param>
    /// <param name="icon">Url иконки узла дерева</param>
    /// <param name="children">Вложенные узлы</param>
    public DeployTreeNode(
      string id,
      string text,
      string icon,
      ICollection<DeployTreeNode> children = null)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(id, text, icon, false, true, children);
    }

    /// <summary>Ctor</summary>
    /// <param name="id">Идентификатор узла</param>
    /// <param name="text">Текст узла</param>
    /// <param name="icon">Url иконки узла дерева</param>
    /// <param name="isDirtyItem">Есть неопубликованные изменения</param>
    /// <param name="isPublished">У объекта есть опубликованная версия</param>
    public DeployTreeNode(
      string id,
      string text,
      string icon,
      bool isDirtyItem,
      bool isPublished)
    {
      DeployTreeNode.AxCbFBEwYVHg4atICyv4();
      // ISSUE: explicit constructor call
      this.\u002Ector(id, text, icon, isDirtyItem, isPublished, (ICollection<DeployTreeNode>) null);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Идентификатор узла</summary>
    public string Id { get; }

    /// <summary>Текст узла</summary>
    public string Text
    {
      get => this.\u003CText\u003Ek__BackingField;
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
              this.\u003CText\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
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

    /// <summary>Url иконки узла дерева</summary>
    public string Icon { get; }

    /// <summary>Вложенные узлы</summary>
    public ICollection<DeployTreeNode> Children { get; }

    /// <summary>Количество дочерних элементов</summary>
    /// <remarks>Может отличаться от фактического в <see cref="P:EleWise.ELMA.Deploy.Models.DeployTreeNode.Children" /></remarks>
    public int Count
    {
      get => this.\u003CCount\u003Ek__BackingField;
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
              this.\u003CCount\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
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

    /// <summary>Есть неопубликованные изменения</summary>
    public bool IsDirtyItem
    {
      get => this.\u003CIsDirtyItem\u003Ek__BackingField;
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
              this.\u003CIsDirtyItem\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
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

    /// <summary>У объекта есть опубликованная версия</summary>
    public bool IsPublished
    {
      get => this.\u003CIsPublished\u003Ek__BackingField;
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
              this.\u003CIsPublished\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
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

    internal static void AxCbFBEwYVHg4atICyv4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool fqMLV5Ew5dN7nAtgMXx1() => DeployTreeNode.CJITjJEwgHF8FM2dKJvp == null;

    internal static DeployTreeNode L6cDsWEwjuvmky3xb8OI() => DeployTreeNode.CJITjJEwgHF8FM2dKJvp;
  }
}
