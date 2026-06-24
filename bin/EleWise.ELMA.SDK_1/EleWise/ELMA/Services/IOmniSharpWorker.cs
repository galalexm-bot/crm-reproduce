// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IOmniSharpWorker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;
using System.Threading.Tasks;

namespace EleWise.ELMA.Services
{
  /// <summary>Элемент для работы с сервером OmniSharp</summary>
  public interface IOmniSharpWorker
  {
    /// <summary>Запустить сервер</summary>
    /// <param name="needRestart">Нужно ли перезапустить сервер</param>
    void Start(bool needRestart);

    /// <summary>Остановить сервер</summary>
    void Stop();

    /// <summary>Получить результат запроса к серверу</summary>
    /// <param name="command">Имя метода, который необходимо выполнить (autocomplete, gotodefinition и т.д.)</param>
    /// <param name="postData">Данные</param>
    /// <param name="fileName">Имя файла</param>
    /// <returns>Результат выполнения запроса к серверу</returns>
    Task<string> GetResult(string command, string postData, string fileName);

    /// <summary>Инициализировать рабочее пространство на сервере</summary>
    /// <param name="fileName">Имя файла</param>
    /// <param name="projectPath">Путь до проекта</param>
    Task InitWorkspace(string fileName, string projectPath);

    /// <summary>Путь до библиотек для автокомплита</summary>
    string CompletionLibsPath { get; }

    /// <summary>Путь до клиентских библиотек автокомплита</summary>
    string ClientCompletionLibsPath { get; }

    /// <summary>Добавить ссылку на сборку</summary>
    /// <param name="assembliesPath">Пути до файлов, содержащих сборки, на которые добавляются ссылки</param>
    /// <param name="webReferencesPath">Пути до файлов с кодом веб-сервисов</param>
    /// <param name="projectPath">Путь до файла проекта</param>
    /// <param name="fileName">Имя файла с кодом</param>
    Task AddReferences(
      IEnumerable<string> assembliesPath,
      IEnumerable<string> webReferencesPath,
      string projectPath,
      string fileName);

    /// <summary>Удалить ссылки на сборки</summary>
    /// <param name="assembliesPath">Пути до файлов, содержащих сборки, на которые удаляются ссылки</param>
    /// <param name="webReferencesPath">Пути до файлов с кодом веб-сервисов</param>
    /// <param name="projectPath">Путь до файла проекта</param>
    /// <param name="fileName">Имя файла с кодом</param>
    Task RemoveReferences(
      IEnumerable<string> assembliesPath,
      IEnumerable<string> webReferencesPath,
      string projectPath,
      string fileName);
  }
}
