// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.ILocalizable
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;
using System.Reflection;

namespace EleWise.ELMA.Globalization
{
  /// <summary>Локализуемый объект</summary>
  internal interface ILocalizable
  {
    /// <summary>Локализуемые свойства</summary>
    IDictionary<string, PropertyInfo> LocalizableProperties { get; }

    /// <summary>Получить ресурсы для локализации</summary>
    /// <param name="parent">Родительский локализуемый объект</param>
    /// <returns>Ресурсы для локализации</returns>
    IEnumerable<string> GetStrings(ILocalizable parent);

    /// <summary>Локализовать объект</summary>
    /// <param name="parent">Родительский локализуемый объект</param>
    void Localize(ILocalizable parent);
  }
}
