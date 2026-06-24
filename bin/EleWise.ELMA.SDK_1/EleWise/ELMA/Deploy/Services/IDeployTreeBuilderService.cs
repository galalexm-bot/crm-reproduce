// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Services.IDeployTreeBuilderService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Models;

namespace EleWise.ELMA.Deploy.Services
{
  /// <summary>Сервис построения дерева объектов импорта</summary>
  public interface IDeployTreeBuilderService
  {
    /// <summary>Построить дерево по манифесту</summary>
    /// <param name="manifest">Манифест</param>
    /// <param name="id">Идентификатор</param>
    /// <param name="title">Заголовок</param>
    DeployTreeModel BuildTree(BPMAppFakeManifest manifest, string id, string title);

    /// <summary>Построить дерево по манифесту</summary>
    /// <param name="manifest">Манифест</param>
    /// <param name="id">Идентификатор экспорта</param>
    /// <param name="parameters">Параметры построения элементов</param>
    DeployTreeModel BuildTree(BPMAppManifest manifest, string id, IChapterParameters parameters);
  }
}
