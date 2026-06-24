// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ExtensionPoints.IIgnoreIsUniqueMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для игнорирования метаданных без колонки Uid при импорте.
  /// </summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface IIgnoreIsUniqueMetadata
  {
    /// <summary>
    /// Получить список Uid'ов метаданных для исключения проверки метаданных на наличие поля Uid.
    /// </summary>
    /// <returns></returns>
    List<Guid> GetIgnoredUids();
  }
}
