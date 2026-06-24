// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Convertors.ToBinaryFileConvertor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Types.Convertors
{
  /// <summary>
  /// Базовый класс преобразования из какого-либо типа в тип "Строка"
  /// </summary>
  public class ToBinaryFileConvertor : TypeConvertor
  {
    internal static ToBinaryFileConvertor ecfpRWo5dRs2gu8ZlmoT;

    /// <summary>Тип "BinaryFile"</summary>
    public override List<Guid> SourceTypeUids => new List<Guid>()
    {
      BinaryFileDescriptor.UID
    };

    /// <summary>Тип "Строка"</summary>
    public override List<Guid> TargetTypeUids => new List<Guid>()
    {
      BinaryFileDescriptor.UID
    };

    public override object DoConvert(object obj) => obj;

    public ToBinaryFileConvertor()
    {
      ToBinaryFileConvertor.xtcj7Qo5gEcbEhjRubL0();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void xtcj7Qo5gEcbEhjRubL0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool nV4JQ2o5lcsNPEbA43hC() => ToBinaryFileConvertor.ecfpRWo5dRs2gu8ZlmoT == null;

    internal static ToBinaryFileConvertor FIFMCso5r05yHHVIfRfy() => ToBinaryFileConvertor.ecfpRWo5dRs2gu8ZlmoT;
  }
}
