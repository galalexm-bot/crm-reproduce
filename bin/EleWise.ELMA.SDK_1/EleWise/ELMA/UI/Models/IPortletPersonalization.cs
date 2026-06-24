// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.IPortletPersonalization
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.UI.Models
{
  public interface IPortletPersonalization
  {
    /// <summary>Иднетификатор типа портлета</summary>
    Guid PortletUid { get; set; }

    /// <summary>Идентификатор экземпляра портлета</summary>
    Guid InstanceId { get; set; }

    /// <summary>Оформление</summary>
    string Name { get; set; }

    /// <summary>Ширина</summary>
    double? Width { get; set; }

    /// <summary>Высота</summary>
    double? Height { get; set; }

    /// <summary>Разрешить свертывание</summary>
    bool DenyMinimize { get; set; }

    /// <summary>URL-адрес названия</summary>
    string NameUrl { get; set; }

    /// <summary>URL-адрес изображения</summary>
    string ImageUrl { get; set; }

    /// <summary>Включить асинхронную загрузку</summary>
    bool EnableAsyncLoading { get; set; }

    /// <summary>Показать кнопку ручного обновления</summary>
    bool ShowAsyncUpdateButton { get; set; }
  }
}
