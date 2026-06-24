// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.ExtensionPoints.IStartExportRulesIgnore
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Deploy.Export.ExtensionPoints
{
  /// <summary>
  /// Расширение для игнорирование сущностей при проверке наличия правил экспорта при старте системы
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IStartExportRulesIgnore
  {
    /// <summary>
    /// Метод, проверяющий, нужно ли игнорировать сущность при проверке правила
    /// </summary>
    /// <param name="entityMetadata"></param>
    /// <returns>true - нужно игнорировать, false - не нужно игнорировать</returns>
    bool IgnoreThisEntity(EntityMetadata entityMetadata);
  }
}
