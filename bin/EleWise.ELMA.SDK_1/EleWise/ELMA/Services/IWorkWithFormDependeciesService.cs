// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IWorkWithFormDependeciesService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Services
{
  /// <summary>Сервис для ограничения работы с зависимостями форм.</summary>
  /// <remarks>
  /// Зависимости форм создаются при сохранении метаданных. При импорте метаданных данный функционал
  /// нужно отключить. Именно этим и занимается данный сервис. Так же его можно будет использовать
  /// и при публикации метаданных, чтобы там отключить работу с зависимостями форм
  /// </remarks>
  public interface IWorkWithFormDependeciesService
  {
    /// <summary>Активен ли сервис</summary>
    /// <returns></returns>
    bool IsActive();

    /// <summary>Запустить код</summary>
    /// <param name="action"></param>
    void Run(Action action);
  }
}
