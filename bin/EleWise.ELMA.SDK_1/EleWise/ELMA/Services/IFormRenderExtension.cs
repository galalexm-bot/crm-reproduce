// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IFormRenderExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using System;

namespace EleWise.ELMA.Services
{
  /// <summary>Расширение для рендероа форм новым рантаймом</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IFormRenderExtension
  {
    /// <summary>Проверить реализации</summary>
    /// <param name="entity">Сущность</param>
    /// <returns><c>True</c>, если реализация подходит</returns>
    bool Check(IEntity<long> entity);

    /// <summary>
    /// Можно ли отрендерить форму с помощью конструктора интерфейсов
    /// </summary>
    /// <param name="entity">Сущность</param>
    /// <param name="formUid">Уникальный идентификатор формы</param>
    /// <returns><c>True</c>, если форму можно отрендерить с помощью конструктора интерфейсов</returns>
    bool CanRenderRuntimeVersion2(IEntity<long> entity, Guid formUid);
  }
}
