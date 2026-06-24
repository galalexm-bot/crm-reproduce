// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ViewItemPaddings
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
  /// <summary>Отступы внутри элемента</summary>
  public class ViewItemPaddings
  {
    private static ViewItemPaddings hXjayionFp9jjhRSG8SA;

    public ViewItemPaddings()
    {
      ViewItemPaddings.G7BhrvonoanVg0CFD1Q1();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ViewItemPaddings(int? top, int? right, int? bottom, int? left)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Top = top;
      this.Right = right;
      this.Bottom = bottom;
      this.Left = left;
    }

    public ViewItemPaddings(int? vertical, int? horizontal)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Top = vertical;
      this.Bottom = vertical;
      this.Left = horizontal;
      this.Right = horizontal;
    }

    public ViewItemPaddings(int? all)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Top = all;
      this.Bottom = all;
      this.Left = all;
      this.Right = all;
    }

    /// <summary>Сверху</summary>
    [DefaultValue(null)]
    public int? Top { get; set; }

    /// <summary>Справа</summary>
    [DefaultValue(null)]
    public int? Right { get; set; }

    /// <summary>Снизу</summary>
    [DefaultValue(null)]
    public int? Bottom { get; set; }

    /// <summary>Слева</summary>
    [DefaultValue(null)]
    public int? Left { get; set; }

    /// <summary>Получить сумму горизонтальных отступов</summary>
    public int Horizontal
    {
      get
      {
        int num1 = 1;
        int? left;
        while (true)
        {
          switch (num1)
          {
            case 1:
              left = this.Left;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              left = this.Left;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 2 : 4;
              continue;
            case 4:
              goto label_7;
            default:
              if (left.HasValue)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 3;
                continue;
              }
              goto label_3;
          }
        }
label_3:
        int num2 = 0;
        goto label_8;
label_7:
        num2 = left.Value;
label_8:
        int num3 = this.Right.HasValue ? this.Right.Value : 0;
        return num2 + num3;
      }
    }

    /// <summary>Получить сумму вертикальных отступов</summary>
    public int Vertical
    {
      get
      {
        int num1 = 1;
        int? top;
        while (true)
        {
          switch (num1)
          {
            case 1:
              top = this.Top;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            case 3:
              goto label_7;
            default:
              if (!top.HasValue)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 2 : 0;
                continue;
              }
              top = this.Top;
              num1 = 3;
              continue;
          }
        }
label_6:
        int num2 = 0;
        goto label_8;
label_7:
        num2 = top.Value;
label_8:
        int num3 = !this.Bottom.HasValue ? 0 : this.Bottom.Value;
        return num2 + num3;
      }
    }

    /// <summary>Применить указанные отступы</summary>
    /// <param name="paddings"></param>
    public void Apply(ViewItemPaddings paddings)
    {
      int num1 = 14;
      while (true)
      {
        int num2 = num1;
        int? nullable;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.Right = paddings.Right;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 8;
              continue;
            case 2:
              if (nullable.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 11 : 11;
                continue;
              }
              goto case 7;
            case 3:
              goto label_13;
            case 4:
              if (!nullable.HasValue)
              {
                num2 = 12;
                continue;
              }
              goto case 10;
            case 5:
              if (nullable.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
                continue;
              }
              goto case 8;
            case 6:
              nullable = paddings.Right;
              num2 = 5;
              continue;
            case 7:
              nullable = paddings.Left;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 4 : 4;
              continue;
            case 8:
              nullable = paddings.Bottom;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 2;
              continue;
            case 9:
              if (nullable.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
                continue;
              }
              goto case 6;
            case 10:
              this.Left = paddings.Left;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 3 : 2;
              continue;
            case 11:
              goto label_17;
            case 12:
              goto label_3;
            case 13:
              nullable = paddings.Top;
              num2 = 9;
              continue;
            case 14:
              ViewItemPaddings.YJGwbConbvCDaGji5i6e((object) paddings, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583622916));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 8 : 13;
              continue;
            default:
              this.Top = paddings.Top;
              num2 = 6;
              continue;
          }
        }
label_17:
        this.Bottom = paddings.Bottom;
        num1 = 7;
      }
label_13:
      return;
label_3:;
    }

    internal static void G7BhrvonoanVg0CFD1Q1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool bxkTdConB15owKU3R7Xm() => ViewItemPaddings.hXjayionFp9jjhRSG8SA == null;

    internal static ViewItemPaddings RWdoHyonWDdAZdfdoqri() => ViewItemPaddings.hXjayionFp9jjhRSG8SA;

    internal static void YJGwbConbvCDaGji5i6e([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);
  }
}
