// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ExtensionPoints.ICompatibilityChecker`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata.ExtensionPoints
{
  /// <summary>Компонент проверки совместимости</summary>
  public interface ICompatibilityChecker<T> : ICompatibilityChecker
  {
    /// <summary>Проверить совместимость</summary>
    /// <param name="new">Проверяемая версия</param>
    /// <param name="old">Версия с которой производится проверка</param>
    /// <returns>Список сообщений о проверке. Если совместимо, то список пуст</returns>
    ICollection<string> CheckCompatibility(T old, T @new);
  }
}
