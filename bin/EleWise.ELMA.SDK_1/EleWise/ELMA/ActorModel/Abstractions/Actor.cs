// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Abstractions.Actor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Abstractions
{
  /// <summary>Базовый класс Актора.</summary>
  public abstract class Actor : IActor
  {
    /// <summary>Время жизник Grain-а по умолчанию</summary>
    private static readonly TimeSpan DefaultCollectionAge;
    private IActorModelProvider actorModelProvider;
    private static Actor OxNtFvfD0BCVLU5cEVqZ;

    /// <summary>Время жизни Актора</summary>
    /// <remarks>
    /// Используется в методе <see cref="M:EleWise.ELMA.ActorModel.Abstractions.Actor.OnActivateAsync" /> на этапе инициализации Актора.
    /// Для управления временим жизни в Runtime необходимо использовать метод <see cref="M:EleWise.ELMA.ActorModel.Abstractions.Actor.DelayDeactivation(System.TimeSpan)" />
    /// </remarks>
    public virtual TimeSpan LifeTime { get; }

    /// <summary>Инициализирует Актор в среде Actor Model.</summary>
    /// <param name="actorModelProvider">Интерфейс среды Акторов</param>
    public void Initialize(IActorModelProvider actorModelProvider)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.actorModelProvider == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_4;
          case 3:
            goto label_2;
          default:
            this.actorModelProvider = actorModelProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 2 : 2;
            continue;
        }
      }
label_4:
      return;
label_2:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) Actor.mvmN3JfDMGDcmknRuJxh(1654249598 >> 2 ^ 413344213)));
    }

    /// <summary>Вызывается в конце процесса активации Актора.</summary>
    /// <returns>Задача.</returns>
    public virtual Task OnActivateAsync() => (Task) Actor.rnsqX4fDJmhtK0p2FPCh();

    /// <summary>Вызывается в начале процесса деактивации Актора.</summary>
    /// <returns>Задача.</returns>
    public virtual Task OnDeactivateAsync() => (Task) Actor.rnsqX4fDJmhtK0p2FPCh();

    /// <summary>Принимает напоминание.</summary>
    /// <param name="reminderName">Название напоминания.</param>
    /// <returns>Задача.</returns>
    public virtual Task ReceiveReminder(string reminderName) => (Task) Actor.rnsqX4fDJmhtK0p2FPCh();

    /// <summary>Возвращает уникальный ключ Актора.</summary>
    /// <typeparam name="TKey">Тип ключа.</typeparam>
    /// <returns>Ключ.</returns>
    protected TKey GetPrimaryKey<TKey>() => (TKey) this.actorModelProvider.GetPrimaryKey();

    /// <summary>
    /// Регистрирует напоминание для получения регулярных уведомлений.
    /// </summary>
    /// <param name="reminderName">Название напоминания.</param>
    /// <param name="dueTime">Интервал времени для первого запуска.</param>
    /// <param name="period">Частота запуска.</param>
    /// <returns>Задача.</returns>
    protected Task RegisterOrUpdateReminder(string reminderName, TimeSpan dueTime, TimeSpan period) => (Task) Actor.XcjamwfD9wGiLKt4x8iq((object) this.actorModelProvider, (object) reminderName, dueTime, period);

    /// <summary>Удаляет регистрацию напоминания.</summary>
    /// <param name="reminderName">Название напоминания.</param>
    /// <returns>Задача.</returns>
    protected Task UnregisterReminder(string reminderName) => this.actorModelProvider.UnregisterReminder(reminderName);

    /// <summary>
    /// Регистрирует таймер для периодического вызова указанного callback-метода.
    /// </summary>
    /// <param name="asyncCallback">Callback-метод для вызова в момент срабатывания таймера.</param>
    /// <param name="state">Объект-состояние, который будет передан в callback-метод.</param>
    /// <param name="dueTime">Время первого срабатывания таймера.</param>
    /// <param name="period">Интервал времени для последующих срабатываний таймера.</param>
    /// <returns>Дескриптор таймера.</returns>
    protected IDisposable RegisterTimer(
      Func<object, Task> asyncCallback,
      object state,
      TimeSpan dueTime,
      TimeSpan period)
    {
      return this.actorModelProvider.RegisterTimer(asyncCallback, state, dueTime, period);
    }

    /// <summary>Выполнить внешнюю задачу (вне рамок потока Orleans)</summary>
    /// <param name="action">Действие</param>
    protected Task RunExternalTask(Func<Task> action) => this.actorModelProvider.RunExternalTask(action);

    /// <summary>Выполнить внешнюю задачу (вне рамок потока Orleans)</summary>
    /// <typeparam name="TResult">Тип возвращаемого результата</typeparam>
    /// <param name="action">Действие</param>
    /// <returns>Результат выполнения</returns>
    protected Task<TResult> RunExternalTask<TResult>(Func<Task<TResult>> action) => this.actorModelProvider.RunExternalTask<TResult>(action);

    /// <summary>Установить таймаут для деактивации Актора</summary>
    /// <param name="timeSpan">Интервал времени, после истечения которого произойдет деактивация Актора</param>
    protected void DelayDeactivation(TimeSpan timeSpan)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.actorModelProvider.DelayDeactivation(timeSpan);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Деактивировать Актор</summary>
    protected void DeactivateOnIdle()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            Actor.xSZex3fDdBce6kGmsG5R((object) this.actorModelProvider);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected Actor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.LifeTime = Actor.DefaultCollectionAge;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static Actor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            Actor.DefaultCollectionAge = Actor.uppAOKfDl8vRcZ5F9DgK(10.0);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object mvmN3JfDMGDcmknRuJxh(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool ivKPx8fDmrwlauQVDtiI() => Actor.OxNtFvfD0BCVLU5cEVqZ == null;

    internal static Actor SuQfXIfDyhsVQgGr9GS1() => Actor.OxNtFvfD0BCVLU5cEVqZ;

    internal static object rnsqX4fDJmhtK0p2FPCh() => (object) Task.CompletedTask;

    internal static object XcjamwfD9wGiLKt4x8iq(
      [In] object obj0,
      [In] object obj1,
      TimeSpan dueTime,
      TimeSpan period)
    {
      return (object) ((IActorModelProvider) obj0).RegisterOrUpdateReminder((string) obj1, dueTime, period);
    }

    internal static void xSZex3fDdBce6kGmsG5R([In] object obj0) => ((IActorModelProvider) obj0).DeactivateOnIdle();

    internal static TimeSpan uppAOKfDl8vRcZ5F9DgK([In] double obj0) => TimeSpan.FromMinutes(obj0);
  }
}
