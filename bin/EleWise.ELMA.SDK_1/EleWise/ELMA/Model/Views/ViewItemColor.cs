// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ViewItemColor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Ссылка на цвет элемента</summary>
  public class ViewItemColor
  {
    internal static ViewItemColor gobC0EokduXXUmGIWYbj;

    public ViewItemColor()
    {
      ViewItemColor.FnJlVrokgwBDsM8UJbZB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ViewItemColor(Color color)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Value = new Color?(color);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public static ViewItemColor FromHtml(string htmlColor) => new ViewItemColor(ViewItemColor.ckBGGiok5lmb1Pbmp83d((object) htmlColor));

    public ViewItemColor Clone()
    {
      ViewItemColor viewItemColor = new ViewItemColor();
      ViewItemColor.epSF51okjkXGnZbLqJOh((object) viewItemColor, (object) this.Name);
      return viewItemColor;
    }

    /// <summary>Обозначение цвета границы</summary>
    [DefaultValue(null)]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
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

    /// <summary>Цвет границы</summary>
    [XmlIgnore]
    public Color? Value
    {
      get
      {
        if (string.IsNullOrEmpty(this.Name))
          return new Color?();
        try
        {
          return new Color?(ColorTranslator.FromHtml(this.Name));
        }
        catch
        {
          return new Color?();
        }
      }
      set => this.Name = value.HasValue ? ColorTranslator.ToHtml(value.Value) : (string) null;
    }

    internal static void FnJlVrokgwBDsM8UJbZB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Wa0JDGoklaAPUOYT11Hb() => ViewItemColor.gobC0EokduXXUmGIWYbj == null;

    internal static ViewItemColor rIRk8EokrburyFIns74P() => ViewItemColor.gobC0EokduXXUmGIWYbj;

    internal static Color ckBGGiok5lmb1Pbmp83d([In] object obj0) => ColorTranslator.FromHtml((string) obj0);

    internal static void epSF51okjkXGnZbLqJOh([In] object obj0, [In] object obj1) => ((ViewItemColor) obj0).Name = (string) obj1;
  }
}
