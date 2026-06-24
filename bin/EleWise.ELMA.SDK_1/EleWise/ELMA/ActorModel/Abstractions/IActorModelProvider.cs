// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Abstractions.IActorModelProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Abstractions
{
  /// <summary>Интерфейс среды Actor Model.</summary>
  public interface IActorModelProvider
  {
    /// <summary>Возвращает уникальный ключ Актора.</summary>
    /// <returns>Ключ Актора.</returns>
    object GetPrimaryKey();

    /// <summary>
    /// Регистрирует напоминание для получения регулярных уведомлений.
    /// </summary>
    /// <param name="reminderName">Название напоминания.</param>
    /// <param name="dueTime">Интервал времени для первого запуска.</param>
    /// <param name="period">Частота запуска.</param>
    /// <returns>Задача.</returns>
    Task RegisterOrUpdateReminder(string reminderName, TimeSpan dueTime, TimeSpan period);

    /// <summary>Удаляет регистрацию напоминания.</summary>
    /// <param name="reminderName">Название напоминания.</param>
    /// <returns>Задача.</returns>
    Task UnregisterReminder(string reminderName);

    /// <summary>
    /// Регистрирует таймер для периодического вызова указанного callback-метода.
    /// </summary>
    /// <param name="asyncCallback">Callback-метод для вызова в момент срабатывания таймера.</param>
    /// <param name="state">Объект-состояние, который будет передан в callback-метод.</param>
    /// <param name="dueTime">Время первого срабатывания таймера.</param>
    /// <param name="period">Интервал времени для последующих срабатываний таймера.</param>
    /// <returns>Дескриптор таймера.</returns>
    IDisposable RegisterTimer(
      Func<object, Task> asyncCallback,
      object state,
      TimeSpan dueTime,
      TimeSpan period);

    /// <summary>Выполнить внешнюю задачу (вне рамок потока Orleans)</summary>
    /// <param name="action">Действие</param>
    Task RunExternalTask(Func<Task> action);

    /// <summary>Выполнить внешнюю задачу (вне рамок потока Orleans)</summary>
    /// <typeparam name="TResult">Тип возвращаемого результата</typeparam>
    /// <param name="action">Действие</param>
    /// <returns>Результат выполнения</returns>
    Task<TResult> RunExternalTask<TResult>(Func<Task<TResult>> action);

    /// <summary>Установить таймаут деактивации Актора</summary>
    /// <param name="timeSpan">Интервал времени, после истечения которого произойдет деактивация Актора</param>
    void DelayDeactivation(TimeSpan timeSpan);

    /// <summary>Декативировать Актор</summary>
    void DeactivateOnIdle();
  }
}
