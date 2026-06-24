// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.IWorkTreeElement
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>
  /// Внутренний интерфейс для доступа к общим временным полям контекста и вызова
  /// </summary>
  public interface IWorkTreeElement
  {
    /// <summary>Идентификатор (порядковый номер)</summary>
    long Id { get; }

    /// <summary>Название вызова</summary>
    string Name { get; set; }

    /// <summary>Длительность обработки</summary>
    TimeSpan TotalTime { get; }

    /// <summary>Ошибка</summary>
    Exception Exception { get; }

    /// <summary>
    /// Текущее дерево работы.
    /// Включает в себя полную информацию о текущих и завершенных вызовах и/или сессиях
    /// </summary>
    IEnumerable<IWorkTreeElement> WorkTree { get; }
  }
}
