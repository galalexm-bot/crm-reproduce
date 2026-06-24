// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IFormViewItemExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using System;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Точка расширения для получения форм сущности</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IFormViewItemExtension
  {
    /// <summary>Проверка реализации</summary>
    /// <param name="entity">Сущность</param>
    bool Check(object entity);

    /// <summary>Получить представление формы</summary>
    /// <param name="formUid">Уникальный идентификатор формы</param>
    /// <param name="entity">Сущность</param>
    /// <param name="checkExists">Если форма не найдена - если True, будет выдано исключение, если False - вернется null.</param>
    FormViewItem GetFormViewItem(Guid formUid, object entity, bool checkExists);
  }
}
