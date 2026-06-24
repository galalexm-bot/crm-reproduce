// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.ITrigger
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Scheduling
{
  /// <summary>
  /// Триггер - вычисляет в какое время должна выполнится работа
  /// </summary>
  public interface ITrigger
  {
    /// <summary>Название триггера</summary>
    string Name { get; }

    /// <summary>Уникальный идентификатор триггера</summary>
    Guid Id { get; }

    /// <summary>Получить следующую дату выполнения</summary>
    /// <param name="dateTime">Время последнего запуска</param>
    /// <param name="now">Текущее время</param>
    /// <returns></returns>
    DateTime? GetNextTimeAfter(DateTime? dateTime, DateTime now);

    /// <summary>
    /// Интервал, в котором производится проверка времени триггера от текущей даты при длительном простое
    /// </summary>
    /// <remarks>
    /// Обычно можно возвращать тут среднее значение интервала самого триггера
    /// </remarks>
    TimeSpan OvertimeToRun { get; }
  }
}
