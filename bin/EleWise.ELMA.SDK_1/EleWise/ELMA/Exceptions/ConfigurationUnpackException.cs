// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.ConfigurationUnpackException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Exceptions
{
  /// <summary>Ошибка распаковки файла импорта</summary>
  [Serializable]
  public class ConfigurationUnpackException : Exception
  {
    /// <summary>Список предупреждений, возникших при распаковке</summary>
    public string[] Warnings { get; }

    /// <summary>Список ошибок, возникших при распаковке</summary>
    public string[] Errors { get; }

    /// <summary>Ctor</summary>
    /// <param name="message">Сообщение об ошибке</param>
    /// <param name="innerException">Ошибка во время выполнения распаковки</param>
    /// <param name="warnings">Список предупреждений</param>
    /// <param name="errors">Список ошибок</param>
    public ConfigurationUnpackException(
      string message,
      Exception innerException,
      IEnumerable<string> warnings,
      IEnumerable<string> errors)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(message, innerException);
      this.Warnings = (warnings != null ? warnings.ToArray<string>() : (string[]) null) ?? Array.Empty<string>();
      this.Errors = (errors != null ? errors.ToArray<string>() : (string[]) null) ?? Array.Empty<string>();
    }
  }
}
