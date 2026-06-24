// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.IWebModuleUnit
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Modules
{
  /// <summary>Веб-часть модуля приложения.</summary>
  /// <remarks>
  /// Примеры модулей:
  /// - ЭДО
  /// - Задачи
  /// - Календарь и т.д.
  /// </remarks>
  public interface IWebModuleUnit
  {
    /// <summary>Уникальный идентификатор модуля</summary>
    string Uid { get; }

    /// <summary>Название модуля</summary>
    string Name { get; }

    /// <summary>Имя для отображения</summary>
    string DisplayName { get; }

    /// <summary>Описание модуля</summary>
    string Description { get; }

    /// <summary>Автор модуля</summary>
    string Author { get; }

    /// <summary>веб-сайт</summary>
    string WebSite { get; }
  }
}
