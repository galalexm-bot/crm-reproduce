// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.BackgroundOperationExecutorBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.BackgroundOperations;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Components
{
  /// <summary>Базовый исполнитель фоновой операции</summary>
  [Component]
  public abstract class BackgroundOperationExecutorBase : IBackgroundOperationExecutor
  {
    private static BackgroundOperationExecutorBase cWwf2BfGYKxutA7RT9sF;

    /// <summary>Может ли компонент выполнить фоновую операцию?</summary>
    /// <param name="executionInfo">Данные для выполнения операции.</param>
    /// <returns>true - может, false - не сможет.</returns>
    public abstract bool CanExecute(IBackgroundOperation executionInfo);

    /// <summary>
    /// Получить описание фоновой операции (какая операция выполняется).
    /// </summary>
    /// <param name="executionInfo">Данные об операции.</param>
    /// <returns>Описание фоновой операции (какая операция выполняется).</returns>
    public abstract string GetDescription(IBackgroundOperation executionInfo);

    /// <summary>
    /// Запустить системную задачу, выполняющую фоновую операцию.
    /// </summary>
    /// <param name="executionInfo">Данные об операции.</param>
    /// <param name="token">Токен отмены.</param>
    /// <returns>Системная задача.</returns>
    public Task<object> RunTask(IBackgroundOperation executionInfo, CancellationToken token)
    {
      try
      {
        using (CallContextSessionOwner.Create())
          return this.RunTaskImpl(executionInfo, token);
      }
      catch (Exception ex)
      {
        return Task.Factory.StartNew<object>((Func<object>) (() =>
        {
          throw ex;
        }));
      }
    }

    /// <summary>
    /// Реализация запуска фоновой операции для классов-наследников.
    /// </summary>
    /// <param name="executionInfo">Данные об операции.</param>
    /// <param name="token">Токен отмены.</param>
    /// <returns>Системная задача.</returns>
    protected abstract Task<object> RunTaskImpl(
      IBackgroundOperation executionInfo,
      CancellationToken token);

    /// <summary>
    /// Привести данные об операции к указанному типу операции.
    /// </summary>
    /// <typeparam name="T">Тип операции.</typeparam>
    /// <param name="executionInfo">Данные об операции.</param>
    /// <returns>Данные об операции, приведённые к указанному типу, либо исключение, если приведение выполнить нельзя.</returns>
    /// <exception cref="T:System.ArgumentNullException">Переданный параметр 'executionInfo' не является объектом указанного типа.</exception>
    protected T CastTo<T>(IBackgroundOperation executionInfo) where T : class, IBackgroundOperation => executionInfo is T obj ? obj : throw new ArgumentNullException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -69833282), (object) typeof (T).FullName));

    protected BackgroundOperationExecutorBase()
    {
      BackgroundOperationExecutorBase.KFlqwCfGsTNi7NwNRVus();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void KFlqwCfGsTNi7NwNRVus() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool cpRiEgfGLyliIYjCiN4o() => BackgroundOperationExecutorBase.cWwf2BfGYKxutA7RT9sF == null;

    internal static BackgroundOperationExecutorBase UrnIFNfGUfQ476keQsVs() => BackgroundOperationExecutorBase.cWwf2BfGYKxutA7RT9sF;
  }
}
