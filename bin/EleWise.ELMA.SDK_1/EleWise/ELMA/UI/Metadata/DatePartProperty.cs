// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Metadata.DatePartProperty
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Metadata
{
  /// <summary>Класс для свойств - дат с разделением на тип</summary>
  [Serializable]
  public class DatePartProperty : UserDefinedListPropertyBase
  {
    internal static DatePartProperty C9mPD9BhZnjWLUtXLRqD;

    /// <summary>Часть даты для выбора</summary>
    public List<int> DatePartTypes { get; set; }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.UI.Metadata.DatePartProperty.DatePartTypes" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeAggregationProperties() => DatePartProperty.R5FVPMBhVYdMiQKJilx5((object) this.DatePartTypes) != 0;

    public DatePartProperty()
    {
      DatePartProperty.viZ7TmBhS4WA6ZTkgr7J();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static int R5FVPMBhVYdMiQKJilx5([In] object obj0) => ((List<int>) obj0).Count;

    internal static bool QxSfO9BhuVYtECi71cpW() => DatePartProperty.C9mPD9BhZnjWLUtXLRqD == null;

    internal static DatePartProperty oHZo83BhIbBlwmQiqnDQ() => DatePartProperty.C9mPD9BhZnjWLUtXLRqD;

    internal static void viZ7TmBhS4WA6ZTkgr7J() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
