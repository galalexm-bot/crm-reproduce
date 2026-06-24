// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Exceptions.MappingServiceNotAvailableException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.FullTextSearch.Exceptions
{
  /// <summary>
  /// Исключение, сигнализирующее о невозможности полнотекстового поиска из-за недоступности сервиса управления картой соответствий.
  /// </summary>
  [Serializable]
  internal sealed class MappingServiceNotAvailableException : Exception
  {
    /// <summary>Ctor.</summary>
    /// <param name="errors">Список ошибок, из-за которых сервис управления картой соответствий недоступен.</param>
    public MappingServiceNotAvailableException(IEnumerable<string> errors)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Message = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647905390), errors);
    }

    /// <inheritdoc />
    public override string Message { get; }
  }
}
