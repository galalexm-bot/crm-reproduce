// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IIgnoreUidUI
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>
  /// Расширение, позволяющее не назначать уникальные индексы для таблиц сущностей
  /// </summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface IIgnoreUidUI
  {
    /// <summary>
    /// Возвращает результат проверки на игнорирование навешивания уникального индекса на колонку Uid
    /// </summary>
    /// <param name="md"></param>
    /// <returns></returns>
    bool NeedIgnoreUid(EntityMetadata md);
  }
}
