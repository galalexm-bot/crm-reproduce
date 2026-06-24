// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.TableCellAlignmentAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Указывает выравнивание в ячейке таблицы, в которой отображается значение свойства
  /// </summary>
  [AttributeUsage(AttributeTargets.Property)]
  public class TableCellAlignmentAttribute : Attribute
  {
    private LineAlignment value;
    private static TableCellAlignmentAttribute k9BOx1oZVrTrl653qKmA;

    /// <summary>Ctor</summary>
    /// <param name="value">Ширина колонки в пикселях</param>
    public TableCellAlignmentAttribute(LineAlignment value)
    {
      TableCellAlignmentAttribute.DSgGEXoZRBqKUwimJgMR();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.value = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Ширина колонки в пикселях</summary>
    public LineAlignment Value => this.value;

    internal static void DSgGEXoZRBqKUwimJgMR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool MNIl9toZSnF8EsC1NSEb() => TableCellAlignmentAttribute.k9BOx1oZVrTrl653qKmA == null;

    internal static TableCellAlignmentAttribute S3gvXfoZiswBFAFGwxoG() => TableCellAlignmentAttribute.k9BOx1oZVrTrl653qKmA;
  }
}
