// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IInstanceExpressionPermissionHolder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Хранилище информации о привилгии на объект предосталенной пользователю правилами из <see cref="T:EleWise.ELMA.Security.Services.IInstanceExpressionPermission" />
  /// TODO achmed написать когда следует реализовывать данный интерфейс
  /// </summary>
  public interface IInstanceExpressionPermissionHolder
  {
    /// <summary>Обладатель привилегии</summary>
    IUser User { get; set; }

    /// <summary>
    /// Роль пользователя или выражение, по которому дана привилегия (используется при синхронизации списка)
    /// в момент изменения сущности
    /// </summary>
    string TypeRole { get; set; }

    /// <summary>Объект на который предоставлена привилегия</summary>
    object Target { get; set; }

    /// <summary>
    /// Определяет, нужно ли давать доступ начальнику обладателя привилегии
    /// </summary>
    bool AllowChief { get; set; }
  }
}
