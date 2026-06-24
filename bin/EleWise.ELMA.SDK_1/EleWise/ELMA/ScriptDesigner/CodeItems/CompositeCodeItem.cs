// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.CodeItems.CompositeCodeItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace EleWise.ELMA.ScriptDesigner.CodeItems
{
  /// <summary>Составной элемент кода</summary>
  [Serializable]
  public abstract class CompositeCodeItem : CodeItem, ICompositeCodeItem, ICodeItem
  {
    private static CompositeCodeItem SvvbBsiKg0BwZulTEoH;

    public CompositeCodeItem()
    {
      CompositeCodeItem.JmM9pDikyWG8P1DNiIn();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Items = new List<CodeItem>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Элементы представления</summary>
    [XmlArrayItem("CompositeCodeItem", typeof (CompositeCodeItem))]
    [XmlArrayItem("CodeItem")]
    [NotNull]
    public List<CodeItem> Items { get; set; }

    public IEnumerable<ICodeItem> GetAllItems() => CompositeCodeItem.GetAllItems((object) this);

    private static IEnumerable<ICodeItem> GetAllItems(object viewItem) => !(viewItem is ICompositeCodeItem compositeCodeItem) ? (IEnumerable<ICodeItem>) new CodeItem[0] : compositeCodeItem.Items.SelectMany<CodeItem, ICodeItem>((Func<CodeItem, IEnumerable<ICodeItem>>) (i => ((IEnumerable<ICodeItem>) new CodeItem[1]
    {
      i
    }).Union<ICodeItem>(CompositeCodeItem.GetAllItems((object) i))));

    public abstract bool IsValidChild(ICodeItem codeItem);

    internal static void JmM9pDikyWG8P1DNiIn() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool xAR8yfiX2KpyWACnAPV() => CompositeCodeItem.SvvbBsiKg0BwZulTEoH == null;

    internal static CompositeCodeItem E7iFCmiTjO1VltvKK79() => CompositeCodeItem.SvvbBsiKg0BwZulTEoH;
  }
}
