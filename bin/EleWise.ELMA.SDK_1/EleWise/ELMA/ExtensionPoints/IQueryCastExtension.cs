// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IQueryCastExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using System;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>
  /// Расширение, предоставляющее возможность выполнить cast в запросе EQL
  /// </summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface IQueryCastExtension
  {
    /// <summary>Тип левого операнда</summary>
    Type LeftOperandType { get; }

    /// <summary>Кастить тип правого операнда</summary>
    Type RightOperandType { get; }

    /// <summary>Каст левого операнда</summary>
    /// <param name="sqlString"></param>
    /// <returns></returns>
    SqlString CastLeftOperand(SqlString sqlString);

    /// <summary>Каст правого операнда</summary>
    /// <param name="propertyName">Название свойства</param>
    /// <returns></returns>
    IProjection CastRightOperand(string propertyName);
  }
}
