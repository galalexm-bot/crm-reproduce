// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IOmniSharpService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.UI.Models;
using System.Threading.Tasks;

namespace EleWise.ELMA.Services
{
  /// <summary>Сервис по работе с сервером OmniSharp</summary>
  public interface IOmniSharpService
  {
    /// <summary>Запустить сервер</summary>
    /// <param name="needRestart">Нужно ли перезапустить сервер</param>
    void Start(bool needRestart);

    /// <summary>Остановить сервер</summary>
    void Stop();

    /// <summary>Инициализировать рабочее пространство на сервере</summary>
    /// <param name="request">Запрос</param>
    /// <returns>Информация об инициализированом рабочем пространстве</returns>
    Task<OmniSharpItem> InitWorkspace(InitWorkspaceRequest request);

    /// <summary>Получить результат запроса к серверу</summary>
    /// <param name="request">Запрос</param>
    /// <returns>Результат выполнения запроса к серверу</returns>
    Task<string> GetResult(OmniSharpRequest request);

    /// <summary>Добавить ссылки на сборки</summary>
    /// <param name="request">Запрос</param>
    Task AddReferences(AddReferencesRequest request);

    /// <summary>Удалить ссылки на сборки</summary>
    /// <param name="request">Запрос</param>
    Task RemoveReferences(RemoveReferencesRequest request);
  }
}
