// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.IJob
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;
using System.Drawing;

namespace EleWise.ELMA.Scheduling
{
  /// <summary>Работа планировщика</summary>
  public interface IJob
  {
    /// <summary>Идентификатор работы</summary>
    Guid Id { get; }

    /// <summary>Название работы</summary>
    string Name { get; }

    /// <summary>Иконка работы (нужно для отображения в списках)</summary>
    Image Icon { get; }

    /// <summary>Выполнить работы и предоставить результат выполнения</summary>
    /// <param name="dateToRun"></param>
    /// <returns></returns>
    [NotNull]
    JobResult Do(DateTime dateToRun);
  }
}
