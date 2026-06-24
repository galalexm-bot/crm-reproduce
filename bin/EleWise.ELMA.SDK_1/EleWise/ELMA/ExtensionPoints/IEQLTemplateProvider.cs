// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IEQLTemplateProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Интерфейс провайдера EQL шаблонов</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IEQLTemplateProvider
  {
    /// <summary>Проверка типа</summary>
    /// <param name="typeUid">Уникальный идентификатор типа объекта</param>
    /// <param name="subTypeUid">Уникальный идентификатор подтипа объекта</param>
    /// <returns><c>True</c>, если реализация провайдера подходит</returns>
    bool Check(Guid typeUid, Guid subTypeUid);

    /// <summary>Получить информацию об объекте</summary>
    /// <param name="typeUid">Уникальный идентификатор типа</param>
    /// <param name="subTypeUid">Уникальный идентификатор подтипа</param>
    /// <param name="model">Модель в сериализованном виде</param>
    /// <returns>Объект</returns>
    object GetObjectInfo(Guid typeUid, Guid subTypeUid, string model);
  }
}
