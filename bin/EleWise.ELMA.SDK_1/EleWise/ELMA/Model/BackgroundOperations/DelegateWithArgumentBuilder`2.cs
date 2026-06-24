// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.BackgroundOperations.DelegateWithArgumentBuilder`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.BackgroundOperations
{
  /// <summary>
  /// Класс-шаблон билдера делегата обратного вызова с дополнительным аргументом (помимо контекста процесса).
  /// </summary>
  /// <typeparam name="TContext">Тип контекста процесса, который передаётся в делегат.</typeparam>
  /// <typeparam name="T">Тип дополнительного аргумента, передаваемого в делегат.</typeparam>
  public class DelegateWithArgumentBuilder<TContext, T>
  {
    private ICallbackDelegate callbackDelegate;
    private static object nPC9LGWc4rMOUGYMwrw7;

    /// <summary>Ctor</summary>
    /// <param name="callbackDelegate">Объект делегата обратного вызова, над которым будет произведена конфигурация этим билдером.</param>
    public DelegateWithArgumentBuilder(ICallbackDelegate callbackDelegate)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.callbackDelegate = callbackDelegate;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>
    /// Не вызывать делегат и не обрабатывать результат.
    /// <para>
    /// Учтите, что если Вы выбираете данное поведение в качестве реакции на неудачное завершение операции, то при возникновении ошибки у Вас либо сработает
    /// эскалация по коннектору для ошибок в элементе, либо будет зарегистрирована ошибка и начнутся попытки повторного выполнения операции.
    /// </para>
    /// </summary>
    public void DoNotHandle()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.callbackDelegate.DelegateSignature = string.Empty;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
            continue;
          case 2:
            this.callbackDelegate.ArgumentNames = new string[0];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>
    /// Для обработки результата операции вызвать указанную функцию, которая к тому же может вернуть новую фоновую операцию.
    /// <para>
    /// НЕЛЬЗЯ передавать непубличный делегат и делегат, являющийся анонимной лямбдой!
    /// </para>
    /// </summary>
    /// <param name="func">Функция обработки результата фоновой операции.</param>
    /// <exception cref="T:System.ArgumentException">Делегат обратного вызова не может являться анонимной лямбдой.</exception>
    public void CallFunc(Func<TContext, T, IBackgroundOperation> func) => this.CallDelegate((Delegate) func);

    /// <summary>
    /// Для обработки результата операции вызвать указанный метод.
    /// <para>
    /// НЕЛЬЗЯ передавать непубличный делегат и делегат, являющийся анонимной лямбдой!
    /// </para>
    /// </summary>
    /// <param name="method">Метод обработки результата фоновой операции.</param>
    /// <exception cref="T:System.ArgumentException">Делегат обратного вызова не может являться анонимной лямбдой.</exception>
    public void CallMethod(Action<TContext, T> method) => this.CallDelegate((Delegate) method);

    private void CallDelegate(Delegate @delegate)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.callbackDelegate.DelegateSignature = DelegateHelper.DelegateToString(@delegate);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
              continue;
            case 2:
              DelegateHelper.ThrowIfNotPublic(@delegate);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 1;
              continue;
            case 3:
              goto label_7;
            case 4:
              goto label_3;
            default:
              this.callbackDelegate.ArgumentNames = DelegateHelper.GetDelegateArgumentNames(@delegate);
              num2 = 4;
              continue;
          }
        }
label_7:
        DelegateHelper.ThrowIfAnonymousLambda(@delegate);
        num1 = 2;
      }
label_3:;
    }

    internal static bool Vl5Vq4Wc6s8PtUK9TvdI() => DelegateWithArgumentBuilder<TContext, T>.nPC9LGWc4rMOUGYMwrw7 == null;

    internal static object aAQ2LpWcH7caUkmuMC13() => DelegateWithArgumentBuilder<TContext, T>.nPC9LGWc4rMOUGYMwrw7;
  }
}
