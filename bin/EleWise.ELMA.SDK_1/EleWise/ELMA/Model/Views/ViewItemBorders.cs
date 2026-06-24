// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ViewItemBorders
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
  /// <summary>Границы элемента</summary>
  public class ViewItemBorders
  {
    private static ViewItemBorders kRWVbQokw4QhWAgr6MQ5;

    /// <summary>Ширина границ</summary>
    [DefaultValue(null)]
    public int? Width { get; set; }

    /// <summary>Обозначение цвета границ</summary>
    [DefaultValue(null)]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
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

    /// <summary>Верхняя</summary>
    [DefaultValue(null)]
    public ViewItemBorder Top
    {
      get => this.\u003CTop\u003Ek__BackingField;
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
              this.\u003CTop\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
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

    /// <summary>Правая</summary>
    [DefaultValue(null)]
    public ViewItemBorder Right
    {
      get => this.\u003CRight\u003Ek__BackingField;
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
              this.\u003CRight\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
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

    /// <summary>Нижняя</summary>
    [DefaultValue(null)]
    public ViewItemBorder Bottom
    {
      get => this.\u003CBottom\u003Ek__BackingField;
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
              this.\u003CBottom\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
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

    /// <summary>Левая</summary>
    [DefaultValue(null)]
    public ViewItemBorder Left
    {
      get => this.\u003CLeft\u003Ek__BackingField;
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
              this.\u003CLeft\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
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

    /// <summary>Получить общую горизонтальную толщину</summary>
    /// <returns></returns>
    public int GetHorizontalWidth() => this.GetLeftWidth() + this.GetRightWidth();

    /// <summary>Получить общую вертикальную толщину</summary>
    /// <returns></returns>
    public int GetVerticalWidth() => this.GetTopWidth() + this.GetBottomWidth();

    /// <summary>Получить ширину левой границы</summary>
    /// <returns></returns>
    public int GetLeftWidth()
    {
      int num1 = 5;
      int? width;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!width.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_5;
            case 3:
              goto label_6;
            case 4:
            case 9:
              width = this.Width;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 1;
              continue;
            case 5:
              if (this.Left == null)
              {
                num2 = 4;
                continue;
              }
              goto label_6;
            case 6:
              goto label_14;
            case 7:
              if (width.HasValue)
              {
                num2 = 6;
                continue;
              }
              goto case 4;
            case 8:
              goto label_13;
            default:
              goto label_3;
          }
        }
label_4:
        width = this.Width;
        num1 = 8;
        continue;
label_6:
        width = this.Left.Width;
        num1 = 7;
        continue;
label_14:
        width = this.Left.Width;
        num1 = 2;
      }
label_3:
      return 0;
label_5:
      return width.Value;
label_13:
      return width.Value;
    }

    /// <summary>Получить ширину правой границы</summary>
    /// <returns></returns>
    public int GetRightWidth()
    {
      int num = 4;
      int? width;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_13;
          case 2:
          case 3:
            width = this.Width;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 8 : 0;
            continue;
          case 4:
            if (this.Right == null)
            {
              num = 3;
              continue;
            }
            goto case 5;
          case 5:
            width = this.Right.Width;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 4 : 6;
            continue;
          case 6:
            if (!width.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 0;
              continue;
            }
            width = this.Right.Width;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 7 : 4;
            continue;
          case 7:
            goto label_2;
          case 8:
            if (!width.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
              continue;
            }
            width = this.Width;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 1;
            continue;
          default:
            goto label_11;
        }
      }
label_2:
      return width.Value;
label_11:
      return 0;
label_13:
      return width.Value;
    }

    /// <summary>Получить ширину верхней границы</summary>
    /// <returns></returns>
    public int GetTopWidth()
    {
      int num1 = 4;
      int? width;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 3:
              width = this.Width;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
              continue;
            case 2:
              width = this.Top.Width;
              num2 = 9;
              continue;
            case 4:
              if (this.Top == null)
              {
                num2 = 3;
                continue;
              }
              goto case 6;
            case 5:
              goto label_9;
            case 6:
              width = this.Top.Width;
              num2 = 7;
              continue;
            case 7:
              if (width.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 2 : 1;
                continue;
              }
              goto case 1;
            case 8:
              goto label_12;
            case 9:
              goto label_15;
            default:
              if (!width.HasValue)
              {
                num2 = 5;
                continue;
              }
              goto label_10;
          }
        }
label_10:
        width = this.Width;
        num1 = 8;
      }
label_9:
      return 0;
label_12:
      return width.Value;
label_15:
      return width.Value;
    }

    /// <summary>Получить ширину нижней границы</summary>
    /// <returns></returns>
    public int GetBottomWidth()
    {
      int num = 9;
      int? width;
      while (true)
      {
        switch (num)
        {
          case 1:
            width = this.Bottom.Width;
            num = 4;
            continue;
          case 2:
            width = this.Bottom.Width;
            num = 6;
            continue;
          case 3:
          case 8:
            width = this.Width;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 5;
            continue;
          case 4:
            if (width.HasValue)
            {
              num = 2;
              continue;
            }
            goto case 3;
          case 5:
            if (!width.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 7 : 7;
              continue;
            }
            width = this.Width;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
            continue;
          case 6:
            goto label_5;
          case 7:
            goto label_9;
          case 9:
            if (this.Bottom == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 8 : 3;
              continue;
            }
            goto case 1;
          default:
            goto label_11;
        }
      }
label_5:
      return width.Value;
label_9:
      return 0;
label_11:
      return width.Value;
    }

    /// <summary>Применить указанный стиль</summary>
    /// <param name="borders"></param>
    public void Apply(ViewItemBorders borders)
    {
      int num = 11;
      int? width;
      while (true)
      {
        switch (num)
        {
          case 1:
            ViewItemBorders.H0p3dLokMkeSRZ3jCOCF((object) this.Left, ViewItemBorders.t2eCliokJ8dTvhVxVcwP((object) borders));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 15 : 5;
            continue;
          case 2:
            if (this.Bottom != null)
            {
              num = 23;
              continue;
            }
            goto case 24;
          case 3:
          case 4:
            if (ViewItemBorders.t2eCliokJ8dTvhVxVcwP((object) borders) != null)
            {
              num = 26;
              continue;
            }
            goto label_29;
          case 5:
            if (this.Top != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 12 : 19;
              continue;
            }
            goto case 20;
          case 6:
            if (borders.Bottom == null)
            {
              num = 4;
              continue;
            }
            goto case 2;
          case 7:
            if (width.HasValue)
            {
              num = 9;
              continue;
            }
            goto default;
          case 8:
            if (this.Right == null)
            {
              num = 17;
              continue;
            }
            goto case 12;
          case 9:
            this.Width = borders.Width;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
            continue;
          case 10:
            width = borders.Width;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 3 : 7;
            continue;
          case 11:
            ViewItemBorders.NxvC6XokAov3Yl2pY3vK((object) borders, ViewItemBorders.l6wIZQokHv7GFnKwS5RD(-342626196 - 1290888215 ^ -1633627713));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 3 : 10;
            continue;
          case 12:
            this.Right.Apply((ViewItemBorder) ViewItemBorders.UqnJDlokmVYtto4jU1YQ((object) borders));
            num = 6;
            continue;
          case 13:
            this.Left = new ViewItemBorder();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 1;
            continue;
          case 14:
          case 21:
            if (ViewItemBorders.UqnJDlokmVYtto4jU1YQ((object) borders) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 8 : 0;
              continue;
            }
            goto case 6;
          case 15:
            goto label_35;
          case 16:
          case 18:
            if (ViewItemBorders.PNbF8Uok0HJw1QhDxt3i((object) borders) == null)
            {
              num = 14;
              continue;
            }
            goto case 5;
          case 17:
            this.Right = new ViewItemBorder();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 12 : 11;
            continue;
          case 19:
          case 27:
            this.Top.Apply((ViewItemBorder) ViewItemBorders.PNbF8Uok0HJw1QhDxt3i((object) borders));
            num = 21;
            continue;
          case 20:
            this.Top = new ViewItemBorder();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 5 : 27;
            continue;
          case 22:
            this.Color = (ViewItemColor) ViewItemBorders.pxhi13okxn8n3c3qjccu(ViewItemBorders.nCbjyQok7fA1C0HueUrO((object) borders));
            num = 18;
            continue;
          case 23:
          case 25:
            ViewItemBorders.H0p3dLokMkeSRZ3jCOCF((object) this.Bottom, ViewItemBorders.jAvEY8oky9AtvWfDAPRV((object) borders));
            num = 3;
            continue;
          case 24:
            this.Bottom = new ViewItemBorder();
            num = 25;
            continue;
          case 26:
            if (this.Left == null)
            {
              num = 13;
              continue;
            }
            goto case 1;
          default:
            if (ViewItemBorders.nCbjyQok7fA1C0HueUrO((object) borders) == null)
            {
              num = 16;
              continue;
            }
            goto case 22;
        }
      }
label_35:
      return;
label_29:;
    }

    public ViewItemBorders()
    {
      ViewItemBorders.MSdWAAok9ftx0kWfIAi4();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool PeYvTIok4k17DEFmtbZo() => ViewItemBorders.kRWVbQokw4QhWAgr6MQ5 == null;

    internal static ViewItemBorders XQL4pFok6UD2RRJheCAq() => ViewItemBorders.kRWVbQokw4QhWAgr6MQ5;

    internal static object l6wIZQokHv7GFnKwS5RD(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void NxvC6XokAov3Yl2pY3vK([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object nCbjyQok7fA1C0HueUrO([In] object obj0) => (object) ((ViewItemBorders) obj0).Color;

    internal static object pxhi13okxn8n3c3qjccu([In] object obj0) => (object) ((ViewItemColor) obj0).Clone();

    internal static object PNbF8Uok0HJw1QhDxt3i([In] object obj0) => (object) ((ViewItemBorders) obj0).Top;

    internal static object UqnJDlokmVYtto4jU1YQ([In] object obj0) => (object) ((ViewItemBorders) obj0).Right;

    internal static object jAvEY8oky9AtvWfDAPRV([In] object obj0) => (object) ((ViewItemBorders) obj0).Bottom;

    internal static void H0p3dLokMkeSRZ3jCOCF([In] object obj0, [In] object obj1) => ((ViewItemBorder) obj0).Apply((ViewItemBorder) obj1);

    internal static object t2eCliokJ8dTvhVxVcwP([In] object obj0) => (object) ((ViewItemBorders) obj0).Left;

    internal static void MSdWAAok9ftx0kWfIAi4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
