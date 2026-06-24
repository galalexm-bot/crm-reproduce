// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IQueryInFunction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using NHibernate.Criterion;

namespace EleWise.ELMA.ExtensionPoints
{
  [ExtensionPoint(ComponentType.All)]
  public interface IQueryInFunction
  {
    /// <summary>Имя функции</summary>
    string FunctionName { get; }

    /// <summary>Получить сriterion</summary>
    /// <param name="alias"></param>
    /// <param name="metadata"></param>
    /// <param name="propName"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    ICriterion GetCriterion(
      string alias,
      EntityMetadata metadata,
      string propName,
      object[] parameters);
  }
}
