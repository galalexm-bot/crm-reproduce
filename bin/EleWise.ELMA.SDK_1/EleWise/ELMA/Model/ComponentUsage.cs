// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.ComponentUsage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model
{
  /// <summary>Использование компонента</summary>
  public sealed class ComponentUsage
  {
    internal static ComponentUsage Mqk2A4W5ov1tyn5F4sb9;

    /// <summary>Ctor</summary>
    public ComponentUsage()
    {
      ComponentUsage.hg8gsMW5G1l3imW7sMuk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ViewItems = new List<Guid>();
            num = 2;
            continue;
          case 2:
            this.Inputs = new List<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>Уникальные идентификаторы элементов представлений</summary>
    public List<Guid> ViewItems { get; set; }

    /// <summary>Заполненные инпуты</summary>
    public List<string> Inputs { get; set; }

    /// <summary>Нужно ли сериализовать</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeViewItems() => ComponentUsage.lcZPEgW5ED0yGi2BTIof((object) this.ViewItems) != 0;

    /// <summary>Нужно ли сериализовать</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeInputs() => ComponentUsage.O7ip1lW5fs8t6HYPm790((object) this.Inputs) != 0;

    internal static void hg8gsMW5G1l3imW7sMuk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool vqKu8cW5btfutvnm1uNR() => ComponentUsage.Mqk2A4W5ov1tyn5F4sb9 == null;

    internal static ComponentUsage hcBgX2W5hjX7X7kZb2SN() => ComponentUsage.Mqk2A4W5ov1tyn5F4sb9;

    internal static int lcZPEgW5ED0yGi2BTIof([In] object obj0) => ((List<Guid>) obj0).Count;

    internal static int O7ip1lW5fs8t6HYPm790([In] object obj0) => ((List<string>) obj0).Count;
  }
}
