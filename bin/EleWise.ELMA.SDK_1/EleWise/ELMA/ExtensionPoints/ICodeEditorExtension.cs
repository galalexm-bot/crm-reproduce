// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.ICodeEditorExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.UI.Models;
using System.Threading.Tasks;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>
  /// Точка расширения генерации исходников для сервера автокомплита
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface ICodeEditorExtension
  {
    /// <summary>Проверка реализации</summary>
    /// <param name="request">Запрос на инициализацию рабочего пространства</param>
    /// <returns></returns>
    bool Check(InitWorkspaceRequest request);

    /// <summary>Инициализировать рабочее пространство на сервере</summary>
    /// <param name="request">Запрос</param>
    /// <returns>Информация об инициализированом рабочем пространстве</returns>
    Task<OmniSharpItem> InitWorkspace(InitWorkspaceRequest request);

    /// <summary>Сгенерировать исходники</summary>
    /// <param name="request">Запрос на инициализацию рабочего пространства</param>
    /// <returns></returns>
    IScriptData GenerateSource(InitWorkspaceRequest request);

    /// <summary>Получить позицию метода</summary>
    /// <param name="sourceCode">Исходный код</param>
    /// <param name="className">Имя класса</param>
    /// <param name="methodName">Имя метода</param>
    /// <returns>Поцизия метода</returns>
    int GetMethodPosition(string sourceCode, string className, string methodName);
  }
}
