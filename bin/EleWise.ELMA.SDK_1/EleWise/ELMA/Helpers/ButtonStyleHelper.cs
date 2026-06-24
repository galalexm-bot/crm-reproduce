// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.ButtonStyleHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Views;
using SG9KiyIbtdgGDf12qr;
using System.Drawing;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Helpers
{
  public static class ButtonStyleHelper
  {
    internal static ButtonStyleHelper x7WkZahLK0FDWlN7Um7V;

    /// <summary>Получить цвет кнопки</summary>
    /// <param name="style">Стиль кнопки</param>
    /// <returns>Цвет кнопки</returns>
    public static Color GetButtonColor(ButtonStyle style)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            switch (style)
            {
              case ButtonStyle.Blue:
                goto label_2;
              case ButtonStyle.Green:
                goto label_3;
              case ButtonStyle.Yellow:
                goto label_4;
              case ButtonStyle.Red:
                goto label_5;
              case ButtonStyle.MetroGray:
                goto label_6;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 0;
                continue;
            }
          default:
            goto label_2;
        }
      }
label_2:
      return ButtonStyleHelper.rV5uSxhLkPbVKjGLaBHQ(78, 128, 193);
label_3:
      return ButtonStyleHelper.rV5uSxhLkPbVKjGLaBHQ(60, 170, 108);
label_4:
      return ButtonStyleHelper.rV5uSxhLkPbVKjGLaBHQ(250, 231, 164);
label_5:
      return ButtonStyleHelper.rV5uSxhLkPbVKjGLaBHQ(231, 76, 60);
label_6:
      return ButtonStyleHelper.rV5uSxhLkPbVKjGLaBHQ(136, 136, 136);
label_7:
      return ButtonStyleHelper.rV5uSxhLkPbVKjGLaBHQ(224, 224, 224);
    }

    /// <summary>Получить цвет границ кнопки</summary>
    /// <param name="style">Стиль кнопки</param>
    /// <returns>Цвет границ кнопки</returns>
    public static Color GetBorderColor(ButtonStyle style)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            switch (style)
            {
              case ButtonStyle.Blue:
                goto label_4;
              case ButtonStyle.Green:
                goto label_5;
              case ButtonStyle.Yellow:
                goto label_6;
              case ButtonStyle.Red:
                goto label_7;
              case ButtonStyle.MetroGray:
                goto label_8;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
                continue;
            }
          case 2:
            goto label_4;
          default:
            goto label_9;
        }
      }
label_4:
      return ButtonStyleHelper.rV5uSxhLkPbVKjGLaBHQ(79, 128, 191);
label_5:
      return ButtonStyleHelper.rV5uSxhLkPbVKjGLaBHQ(49, 159, 97);
label_6:
      return ButtonStyleHelper.rV5uSxhLkPbVKjGLaBHQ(235, 209, 121);
label_7:
      return ButtonStyleHelper.rV5uSxhLkPbVKjGLaBHQ(219, 64, 48);
label_8:
      return Color.FromArgb(119, 119, 119);
label_9:
      return Color.FromArgb(208, 208, 208);
    }

    /// <summary>Получить цвет текста кнопки</summary>
    /// <param name="style">Стиль кнопки</param>
    /// <returns>Цвет текста кнопки</returns>
    public static Color GetTextColor(ButtonStyle style)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            switch (style)
            {
              case ButtonStyle.Red:
              case ButtonStyle.MetroGray:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
                continue;
              default:
                goto label_5;
            }
          case 2:
            switch (style)
            {
              case ButtonStyle.Blue:
              case ButtonStyle.Green:
                goto label_4;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 1;
                continue;
            }
          default:
            goto label_4;
        }
      }
label_4:
      return ButtonStyleHelper.FUcYNWhLnsfwVGTNY2QI();
label_5:
      return ButtonStyleHelper.ikoSLPhLOrqxZBHXEpXb();
    }

    /// <summary>Получить CSS-класс для кнопки</summary>
    /// <param name="style">Стиль кнопки</param>
    /// <returns>Имя соответствующего CSS-класса</returns>
    public static string GetCssClass(ButtonStyle style)
    {
      int num1 = 7;
      string str;
      char ch;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (style != ButtonStyle.MetroGray)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
                continue;
              }
              goto label_8;
            case 2:
              ch = ButtonStyleHelper.ur2WihhLPsmMht0au6c8(ButtonStyleHelper.hIjWVehLekXY4Q4DCeGX((object) str, 0));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 3;
              continue;
            case 3:
              goto label_11;
            case 4:
            case 5:
              goto label_7;
            case 6:
              if (style == ButtonStyle.Default)
              {
                num2 = 5;
                continue;
              }
              goto case 1;
            case 7:
              goto label_12;
            default:
              if (style != ButtonStyle.Simple)
              {
                num2 = 2;
                continue;
              }
              goto label_9;
          }
        }
label_12:
        str = style.ToString();
        num1 = 6;
      }
label_7:
      return string.Empty;
label_8:
      return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811933704);
label_9:
      return (string) ButtonStyleHelper.Iqvrp5hL2bp9tctGwYEB(-1445902765 ^ -1980277732 ^ 539344269);
label_11:
      return (string) ButtonStyleHelper.kIDRUvhLN3Y8O21w3Qe4((object) ch.ToString(), ButtonStyleHelper.XMSjQehL1maoBuxycaau((object) str, 1));
    }

    /// <summary>Получить hex-представление цвета кнопки</summary>
    /// <param name="style">Стиль кнопки</param>
    /// <returns>Цвет кнопки в виде строки формата #xxxxxx</returns>
    public static string GetColorString(ButtonStyle style)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            switch (style)
            {
              case ButtonStyle.Blue:
                goto label_2;
              case ButtonStyle.Green:
                goto label_3;
              case ButtonStyle.Yellow:
                goto label_4;
              case ButtonStyle.Red:
                goto label_5;
              case ButtonStyle.MetroGray:
                goto label_6;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 1;
                continue;
            }
          default:
            goto label_2;
        }
      }
label_2:
      return (string) ButtonStyleHelper.Iqvrp5hL2bp9tctGwYEB(1581325282 << 3 ^ -234129214);
label_3:
      return z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669172863);
label_4:
      return z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210553803);
label_5:
      return z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917102722);
label_6:
      return (string) ButtonStyleHelper.Iqvrp5hL2bp9tctGwYEB(-16752921 ^ -16517379);
label_7:
      return (string) ButtonStyleHelper.Iqvrp5hL2bp9tctGwYEB(~-122002947 ^ 122041902);
    }

    internal static Color rV5uSxhLkPbVKjGLaBHQ([In] int obj0, [In] int obj1, [In] int obj2) => Color.FromArgb(obj0, obj1, obj2);

    internal static bool rZgWDNhLX8lcnACtTG5w() => ButtonStyleHelper.x7WkZahLK0FDWlN7Um7V == null;

    internal static ButtonStyleHelper RTS2r8hLTDmp3TDic1vk() => ButtonStyleHelper.x7WkZahLK0FDWlN7Um7V;

    internal static Color FUcYNWhLnsfwVGTNY2QI() => Color.White;

    internal static Color ikoSLPhLOrqxZBHXEpXb() => Color.Black;

    internal static object Iqvrp5hL2bp9tctGwYEB(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static char hIjWVehLekXY4Q4DCeGX([In] object obj0, [In] int obj1) => ((string) obj0)[obj1];

    internal static char ur2WihhLPsmMht0au6c8([In] char obj0) => char.ToLowerInvariant(obj0);

    internal static object XMSjQehL1maoBuxycaau([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static object kIDRUvhLN3Y8O21w3Qe4([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);
  }
}
