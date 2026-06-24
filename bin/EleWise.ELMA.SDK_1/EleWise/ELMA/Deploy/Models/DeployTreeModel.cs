// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Models.DeployTreeModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Models
{
  /// <summary>Дерево объектов импорта</summary>
  public sealed class DeployTreeModel
  {
    /// <summary>Ctor</summary>
    /// <param name="id">Идентификатор дерева</param>
    /// <param name="children">Список узлов</param>
    public DeployTreeModel(string id, IEnumerable<DeployTreeNode> children)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Id = id;
      this.Children = children ?? throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360104313));
    }

    /// <summary>Идентификатор дерева</summary>
    public string Id { get; }

    /// <summary>Список узлов</summary>
    public IEnumerable<DeployTreeNode> Children { get; }
  }
}
