// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.Publication.IPublishGroupHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Publication;

namespace EleWise.ELMA.ExtensionPoints.Publication
{
  /// <summary>
  /// Интерфейс для сервисов, выполняющих публикацию группы объектов
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface IPublishGroupHandler
  {
    /// <summary>Опубликовать объекты</summary>
    /// <param name="data">Данные для публикации</param>
    /// <param name="comment">Комментарий</param>
    /// <returns>Результат публикации</returns>
    PublishDataResult Publish(ReferenceOnEntity[] data, string comment);
  }
}
