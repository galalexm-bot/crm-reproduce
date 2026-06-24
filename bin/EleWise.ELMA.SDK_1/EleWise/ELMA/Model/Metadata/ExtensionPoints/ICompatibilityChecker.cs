// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ExtensionPoints.ICompatibilityChecker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata.ExtensionPoints
{
  /// <summary>Компонент проверки совместимости</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface ICompatibilityChecker
  {
    /// <summary>
    /// Проверить, подходит ли объект для проверки совместимости
    /// </summary>
    /// <param name="obj">Объект для проверки</param>
    /// <returns><c>true</c>, если объект подходит</returns>
    bool Check(object obj);

    /// <summary>Проверить совместимость</summary>
    /// <param name="new">Проверяемая версия</param>
    /// <param name="old">Версия с которой производится проверка</param>
    /// <returns>Список сообщений о проверке. Если совместимо, то список пуст</returns>
    ICollection<string> CheckCompatibility(object old, object @new);
  }
}
