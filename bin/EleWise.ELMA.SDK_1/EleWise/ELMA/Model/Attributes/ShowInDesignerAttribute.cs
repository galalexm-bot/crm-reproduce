// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.ShowInDesignerAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут, указывающий нужно ли отображать элемент в дизайнере ELMA
  /// </summary>
  public class ShowInDesignerAttribute : Attribute
  {
    private bool visible;
    private static ShowInDesignerAttribute ndsls9oZQ3FsRCn79ZuJ;

    /// <summary>Ctor</summary>
    /// <param name="visible">Нужно ли отображать элемент в дизайнере ELMA</param>
    public ShowInDesignerAttribute(bool visible)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.visible = visible;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Нужно ли отображать элемент в дизайнере ELMA</summary>
    public bool Visible
    {
      get => this.visible;
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
              this.visible = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
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

    internal static bool K5mYkUoZC4rkFg9wooxe() => ShowInDesignerAttribute.ndsls9oZQ3FsRCn79ZuJ == null;

    internal static ShowInDesignerAttribute dY6ExWoZvxU5gKV41Sg3() => ShowInDesignerAttribute.ndsls9oZQ3FsRCn79ZuJ;
  }
}
