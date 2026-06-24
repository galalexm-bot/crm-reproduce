// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.IApplicationUnit
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Modules
{
  /// <summary>Часть приложения</summary>
  public interface IApplicationUnit
  {
    /// <summary>Строковый идентификатор</summary>
    string Id { get; }

    /// <summary>Уникальный идентификатор</summary>
    Guid Uid { get; }

    /// <summary>Отображаемое имя</summary>
    string Title { get; }

    /// <summary>Описание</summary>
    string Description { get; }

    /// <summary>Номер версии</summary>
    string Version { get; }

    /// <summary>Автор</summary>
    string Author { get; }

    /// <summary>Владелец данной части приложения</summary>
    IApplicationUnit Owner { get; }
  }
}
