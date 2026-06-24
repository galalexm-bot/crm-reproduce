// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.IRootMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using System;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>
  /// Интерфейс корневого объекта метаданных (класс, перечисление...)
  /// </summary>
  public interface IRootMetadata : IMetadata, IXsiType
  {
    /// <summary>Загрузить метаданные из скомпилированного типа</summary>
    /// <param name="type">Тип</param>
    /// <param name="inherit">True, если нужно выбирать свойства, включая родительские классы</param>
    void LoadFromType(Type type, bool inherit = true);

    /// <summary>Требуют ли изменения в метаданных перезапуска сервера</summary>
    /// <param name="metadata">Измененные метаданные</param>
    /// <returns>True, если требуют</returns>
    bool IsRestartNeeded(IRootMetadata metadata);

    /// <summary>Применить изменения, не требующие перезапуска сервера</summary>
    /// <param name="inherit">С учетом наследования</param>
    void ApplyRestartUnrequiredChanges(bool inherit);
  }
}
