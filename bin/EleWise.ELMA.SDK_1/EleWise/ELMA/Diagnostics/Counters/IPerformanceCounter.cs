// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Counters.IPerformanceCounter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;

namespace EleWise.ELMA.Diagnostics.Counters
{
  /// <summary>Счетчик производительности ELMA</summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface IPerformanceCounter
  {
    /// <summary>Имя счетчика</summary>
    string Name { get; }

    /// <summary>Описание счетчика</summary>
    string Description { get; }

    /// <summary>Получить данные для создания счетчика</summary>
    /// <returns></returns>
    IEnumerable<CounterCreationData> GetCreationData();

    /// <summary>Инициализировать</summary>
    /// <param name="category">Имя категории счетчиков</param>
    void Init(string category);
  }
}
