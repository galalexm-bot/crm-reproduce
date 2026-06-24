// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.PermissionType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Security
{
  /// <summary>Тип привилегии в отношении</summary>
  public enum PermissionType
  {
    /// <summary>
    /// Глобальная привилегия, например, "Доступ к модулю" или "Администрирование пользователей"
    /// </summary>
    Global = 1,
    /// <summary>
    /// Право на тип сущности, например, "Редактирование" для справочника "Города"
    /// </summary>
    EntityType = 2,
    /// <summary>
    /// Привилегия уровня экземпляра типа, например, "Редактирование документа id=124"
    /// </summary>
    Instance = 4,
  }
}
