// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ExtensionPoints.IBPMAppChapterBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Models;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для компонента, формирующего элементы BPM App
  /// </summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface IBPMAppChapterBuilder
  {
    /// <summary>Получить список элементов дерева для отображения</summary>
    /// <param name="manifest">Манифест</param>
    IEnumerable<DeployTreeNode> GetChapterNodes(BPMAppFakeManifest manifest);

    /// <summary>Получить список элементов дерева для отображения</summary>
    /// <param name="manifest">Манифест</param>
    /// <param name="parameters">Параметры для формирования элементов</param>
    IEnumerable<DeployTreeNode> GetChapterNodes(
      BPMAppManifest manifest,
      IChapterParameters parameters);
  }
}
