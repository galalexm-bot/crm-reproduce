// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.TableColumnWidthAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Указывает ширину колонки таблицы, в которой отображается свойство
  /// </summary>
  [AttributeUsage(AttributeTargets.Property)]
  public class TableColumnWidthAttribute : Attribute
  {
    private int value;
    private static TableColumnWidthAttribute lgCaT8oZqoXfv41RCRqD;

    /// <summary>Ctor</summary>
    /// <param name="value">Ширина колонки в пикселях</param>
    public TableColumnWidthAttribute(int value)
    {
      TableColumnWidthAttribute.lvyJIwoZTfv2A9YuNOSg();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.value = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ширина колонки в пикселях</summary>
    public int Value => this.value;

    internal static void lvyJIwoZTfv2A9YuNOSg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool iWIcJYoZKCFscLvtQ5Qw() => TableColumnWidthAttribute.lgCaT8oZqoXfv41RCRqD == null;

    internal static TableColumnWidthAttribute jANHXuoZXJ8oGfpg0XxJ() => TableColumnWidthAttribute.lgCaT8oZqoXfv41RCRqD;
  }
}
