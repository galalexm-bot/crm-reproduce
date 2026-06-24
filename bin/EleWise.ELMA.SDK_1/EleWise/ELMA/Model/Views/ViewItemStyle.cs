// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ViewItemStyle
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Стил элемента</summary>
  public class ViewItemStyle
  {
    private static ViewItemStyle IfysolonhLh2tGBrfuPH;

    /// <summary>Выполнить слияние стилей</summary>
    /// <param name="styles"></param>
    /// <returns></returns>
    public static ViewItemStyle Merge(params ViewItemStyle[] styles)
    {
      int num = 12;
      ViewItemStyle viewItemStyle;
      int index;
      ViewItemStyle[] viewItemStyleArray;
      ViewItemStyle style;
      while (true)
      {
        switch (num)
        {
          case 1:
            viewItemStyle.Apply(style);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 5;
            continue;
          case 2:
            viewItemStyleArray = styles;
            num = 3;
            continue;
          case 3:
            index = 0;
            num = 10;
            continue;
          case 4:
            goto label_2;
          case 5:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
            continue;
          case 6:
            style = viewItemStyleArray[index];
            num = 13;
            continue;
          case 7:
            goto label_4;
          case 8:
            goto label_5;
          case 9:
            if (styles.Length != 1)
            {
              viewItemStyle = new ViewItemStyle();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 2 : 2;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 2 : 4;
            continue;
          case 11:
            if (styles.Length != 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 9 : 8;
              continue;
            }
            goto label_5;
          case 12:
            if (styles != null)
            {
              num = 11;
              continue;
            }
            goto label_5;
          case 13:
            if (style != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 1;
              continue;
            }
            goto case 5;
          default:
            if (index >= viewItemStyleArray.Length)
            {
              num = 7;
              continue;
            }
            goto case 6;
        }
      }
label_2:
      return styles[0];
label_4:
      return viewItemStyle;
label_5:
      return (ViewItemStyle) null;
    }

    /// <summary>Цвет фона</summary>
    [DefaultValue(null)]
    public ViewItemColor BackgroundColor
    {
      get => this.\u003CBackgroundColor\u003Ek__BackingField;
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
              this.\u003CBackgroundColor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
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

    /// <summary>Цвет шрифта</summary>
    public ViewItemColor Color
    {
      get => this.\u003CColor\u003Ek__BackingField;
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
              this.\u003CColor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
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

    /// <summary>Отступы</summary>
    [DefaultValue(null)]
    public ViewItemPaddings Padding
    {
      get => this.\u003CPadding\u003Ek__BackingField;
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
              this.\u003CPadding\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
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

    /// <summary>Границы</summary>
    [DefaultValue(null)]
    public ViewItemBorders Borders
    {
      get => this.\u003CBorders\u003Ek__BackingField;
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
              this.\u003CBorders\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
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

    /// <summary>Закругления углов</summary>
    [DefaultValue(null)]
    public ViewItemCornerRadius CornerRadius
    {
      get => this.\u003CCornerRadius\u003Ek__BackingField;
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
              this.\u003CCornerRadius\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
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

    /// <summary>Шрифт</summary>
    [DefaultValue(null)]
    public ViewItemFont Font
    {
      get => this.\u003CFont\u003Ek__BackingField;
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
              this.\u003CFont\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
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

    /// <summary>Высота линии текста</summary>
    public int? LineHeight { get; set; }

    /// <summary>Применить указанный стиль</summary>
    /// <param name="style"></param>
    public void Apply(ViewItemStyle style)
    {
      int num1 = 23;
      while (true)
      {
        int num2 = num1;
        int? lineHeight;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.Padding = new ViewItemPaddings();
              num2 = 26;
              continue;
            case 2:
              if (this.Borders == null)
              {
                num2 = 9;
                continue;
              }
              goto case 20;
            case 3:
              ViewItemStyle.PqMT9jonReIYThxSOJFv((object) this.Font, ViewItemStyle.faYTW4onik0DbhVJ8yMh((object) style));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 15;
              continue;
            case 4:
              goto label_34;
            case 5:
              if (ViewItemStyle.faYTW4onik0DbhVJ8yMh((object) style) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
                continue;
              }
              goto label_17;
            case 6:
            case 17:
              goto label_37;
            case 7:
              this.CornerRadius = new ViewItemCornerRadius();
              num2 = 6;
              continue;
            case 8:
              this.Color = (ViewItemColor) ViewItemStyle.SQdwtronvLekRU521rEW(ViewItemStyle.KSCHteon81ggW2395tQX((object) style));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 11 : 1;
              continue;
            case 9:
              this.Borders = new ViewItemBorders();
              num2 = 20;
              continue;
            case 10:
            case 14:
              if (style.Color == null)
              {
                num2 = 21;
                continue;
              }
              goto case 8;
            case 11:
            case 21:
              if (ViewItemStyle.xWSmQronZBQnXbwIu0fj((object) style) != null)
              {
                num2 = 27;
                continue;
              }
              goto case 16;
            case 12:
              if (ViewItemStyle.TK8v6EonSvXnQapOX8KK((object) style) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 25 : 22;
                continue;
              }
              goto case 5;
            case 13:
              this.BackgroundColor = (ViewItemColor) ViewItemStyle.SQdwtronvLekRU521rEW(ViewItemStyle.mwdedeonCM0DvwPe4l2x((object) style));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 10 : 6;
              continue;
            case 15:
              goto label_17;
            case 16:
              if (ViewItemStyle.o34BaConIfiC6BCOcfUL((object) style) != null)
              {
                num2 = 2;
                continue;
              }
              goto case 12;
            case 18:
              goto label_24;
            case 19:
              this.LineHeight = style.LineHeight;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 18 : 7;
              continue;
            case 20:
              ViewItemStyle.SAYhH3onVSo6FXn9cxUu((object) this.Borders, ViewItemStyle.o34BaConIfiC6BCOcfUL((object) style));
              num2 = 12;
              continue;
            case 22:
              if (ViewItemStyle.mwdedeonCM0DvwPe4l2x((object) style) == null)
              {
                num2 = 14;
                continue;
              }
              goto case 13;
            case 23:
              ViewItemStyle.QWTGFtonQIjsCZgkLhgv((object) style, ViewItemStyle.pZXAvConfTKx7TZ1hI7U(-87337865 ^ -87487893));
              num2 = 22;
              continue;
            case 24:
              if (lineHeight.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 13 : 19;
                continue;
              }
              goto label_23;
            case 25:
              if (this.CornerRadius != null)
              {
                num2 = 17;
                continue;
              }
              goto case 7;
            case 26:
              ViewItemStyle.wVlcZBonuDgjOjOqbNwm((object) this.Padding, ViewItemStyle.xWSmQronZBQnXbwIu0fj((object) style));
              num2 = 16;
              continue;
            case 27:
              if (this.Padding == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 1;
                continue;
              }
              goto case 26;
            default:
              if (this.Font == null)
              {
                num2 = 4;
                continue;
              }
              goto case 3;
          }
        }
label_17:
        lineHeight = style.LineHeight;
        num1 = 24;
        continue;
label_34:
        this.Font = new ViewItemFont();
        num1 = 3;
        continue;
label_37:
        this.CornerRadius.Apply((ViewItemCornerRadius) ViewItemStyle.TK8v6EonSvXnQapOX8KK((object) style));
        num1 = 5;
      }
label_24:
      return;
label_23:;
    }

    /// <summary>
    /// Получить общую горизонтальную ширину отступа для содержимого (границы + отступы)
    /// </summary>
    /// <returns></returns>
    public int GetHorizontalContentPadding()
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_5;
          case 2:
            if (this.Borders != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      int num2 = 0;
      goto label_6;
label_5:
      num2 = ViewItemStyle.RvItTyonqQfJGUyM1ID6((object) this.Borders);
label_6:
      int num3 = this.Padding == null ? 0 : ViewItemStyle.RNob94onKPLP82Nty6Y0((object) this.Padding);
      return num2 + num3;
    }

    /// <summary>
    /// Получить общую вертикальную ширину отступа для содержимого (границы + отступы)
    /// </summary>
    /// <returns></returns>
    public int GetVerticalContentPadding()
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (this.Borders == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_2;
        }
      }
label_2:
      int num2 = 0;
      goto label_6;
label_5:
      num2 = ViewItemStyle.rv6973onXxwCvV5VUweq((object) this.Borders);
label_6:
      int num3 = this.Padding == null ? 0 : ViewItemStyle.ghyRNWonT8ho11Xk2YU0((object) this.Padding);
      return num2 + num3;
    }

    /// <summary>
    /// Получить ширину отступа слева для содержимого (границы + отступы)
    /// </summary>
    /// <returns></returns>
    public int GetLeftContentPadding()
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_5;
          case 2:
            if (this.Borders != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      int num2 = 0;
      goto label_6;
label_5:
      num2 = ViewItemStyle.KPTWDionklcbT6SwhnuW((object) this.Borders);
label_6:
      int num3;
      if (this.Padding != null)
      {
        int? left = this.Padding.Left;
        if (left.HasValue)
        {
          left = this.Padding.Left;
          num3 = left.Value;
          goto label_10;
        }
      }
      num3 = 0;
label_10:
      return num2 + num3;
    }

    /// <summary>
    /// Получить ширину отступа справа для содержимого (границы + отступы)
    /// </summary>
    /// <returns></returns>
    public int GetRightContentPadding()
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_5;
          case 2:
            if (this.Borders != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      int num2 = 0;
      goto label_6;
label_5:
      num2 = ViewItemStyle.oGMSl7onnWpSs7fSjlVD((object) this.Borders);
label_6:
      int num3;
      if (this.Padding != null)
      {
        int? right = this.Padding.Right;
        if (right.HasValue)
        {
          right = this.Padding.Right;
          num3 = right.Value;
          goto label_10;
        }
      }
      num3 = 0;
label_10:
      return num2 + num3;
    }

    /// <summary>
    /// Получить ширину отступа сверху для содержимого (границы + отступы)
    /// </summary>
    /// <returns></returns>
    public int GetTopContentPadding()
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (this.Borders == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      int num2 = 0;
      goto label_6;
label_5:
      num2 = this.Borders.GetTopWidth();
label_6:
      int num3;
      if (this.Padding != null)
      {
        int? top = this.Padding.Top;
        if (top.HasValue)
        {
          top = this.Padding.Top;
          num3 = top.Value;
          goto label_10;
        }
      }
      num3 = 0;
label_10:
      return num2 + num3;
    }

    /// <summary>
    /// Получить ширину отступа снизу для содержимого (границы + отступы)
    /// </summary>
    /// <returns></returns>
    public int GetBottomContentPadding()
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (this.Borders == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      int num2 = 0;
      goto label_6;
label_5:
      num2 = this.Borders.GetRightWidth();
label_6:
      int num3;
      if (this.Padding != null)
      {
        int? bottom = this.Padding.Bottom;
        if (bottom.HasValue)
        {
          bottom = this.Padding.Bottom;
          num3 = bottom.Value;
          goto label_10;
        }
      }
      num3 = 0;
label_10:
      return num2 + num3;
    }

    /// <summary>Сбросить все параметры</summary>
    public virtual void Reset()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.Padding = (ViewItemPaddings) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          case 3:
            this.BackgroundColor = (ViewItemColor) null;
            num = 2;
            continue;
          case 4:
            this.Font = (ViewItemFont) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 1;
            continue;
          default:
            this.Borders = (ViewItemBorders) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 3 : 4;
            continue;
        }
      }
label_2:;
    }

    public ViewItemStyle()
    {
      ViewItemStyle.W5fw3VonOlYbXSmtAoal();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool eFrYDponGAT8VHD2o8sB() => ViewItemStyle.IfysolonhLh2tGBrfuPH == null;

    internal static ViewItemStyle k11xWqonE7IRgdy4W4uR() => ViewItemStyle.IfysolonhLh2tGBrfuPH;

    internal static object pZXAvConfTKx7TZ1hI7U(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void QWTGFtonQIjsCZgkLhgv([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object mwdedeonCM0DvwPe4l2x([In] object obj0) => (object) ((ViewItemStyle) obj0).BackgroundColor;

    internal static object SQdwtronvLekRU521rEW([In] object obj0) => (object) ((ViewItemColor) obj0).Clone();

    internal static object KSCHteon81ggW2395tQX([In] object obj0) => (object) ((ViewItemStyle) obj0).Color;

    internal static object xWSmQronZBQnXbwIu0fj([In] object obj0) => (object) ((ViewItemStyle) obj0).Padding;

    internal static void wVlcZBonuDgjOjOqbNwm([In] object obj0, [In] object obj1) => ((ViewItemPaddings) obj0).Apply((ViewItemPaddings) obj1);

    internal static object o34BaConIfiC6BCOcfUL([In] object obj0) => (object) ((ViewItemStyle) obj0).Borders;

    internal static void SAYhH3onVSo6FXn9cxUu([In] object obj0, [In] object obj1) => ((ViewItemBorders) obj0).Apply((ViewItemBorders) obj1);

    internal static object TK8v6EonSvXnQapOX8KK([In] object obj0) => (object) ((ViewItemStyle) obj0).CornerRadius;

    internal static object faYTW4onik0DbhVJ8yMh([In] object obj0) => (object) ((ViewItemStyle) obj0).Font;

    internal static void PqMT9jonReIYThxSOJFv([In] object obj0, [In] object obj1) => ((ViewItemFont) obj0).Apply((ViewItemFont) obj1);

    internal static int RvItTyonqQfJGUyM1ID6([In] object obj0) => ((ViewItemBorders) obj0).GetHorizontalWidth();

    internal static int RNob94onKPLP82Nty6Y0([In] object obj0) => ((ViewItemPaddings) obj0).Horizontal;

    internal static int rv6973onXxwCvV5VUweq([In] object obj0) => ((ViewItemBorders) obj0).GetVerticalWidth();

    internal static int ghyRNWonT8ho11Xk2YU0([In] object obj0) => ((ViewItemPaddings) obj0).Vertical;

    internal static int KPTWDionklcbT6SwhnuW([In] object obj0) => ((ViewItemBorders) obj0).GetLeftWidth();

    internal static int oGMSl7onnWpSs7fSjlVD([In] object obj0) => ((ViewItemBorders) obj0).GetRightWidth();

    internal static void W5fw3VonOlYbXSmtAoal() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
