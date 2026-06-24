// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.AOP.AbstractAsyncInterceptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Castle.DynamicProxy;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.AOP
{
  /// <summary>Базовый абстрактный класс перехватчика метода</summary>
  public abstract class AbstractAsyncInterceptor : IAsyncInterceptor, IInterceptor
  {
    private readonly MethodInfo executeInterceptAsyncInfo;
    private static readonly ConcurrentDictionary<Type, MethodInfo> ExecuteInterceptAsyncConstructedMethodCache;
    private readonly MethodInfo executeInterceptForValueTaskAsyncInfo;
    private static readonly ConcurrentDictionary<Type, MethodInfo> ExecuteInterceptForValueTaskAsyncConstructedMethodCache;
    internal static AbstractAsyncInterceptor EywYtWWPkX5g3mnGGCRC;

    /// <summary>Выполнить перехват метода синхронно</summary>
    /// <param name="invocation">Информация о вызове метода</param>
    public abstract void Intercept(IInvocation invocation);

    /// <inheritdoc />
    public abstract Task InterceptAsync(
      IInvocationAsync invocation,
      CancellationToken cancellationToken);

    /// <inheritdoc />
    [DebuggerHidden]
    void IInterceptor.Intercept(IInvocation invocation)
    {
      int num = 3;
      while (true)
      {
        object obj1;
        Type genericArgument;
        MethodInfo methodInfo;
        object obj2;
        MethodInfo orAdd;
        switch (num)
        {
          case 0:
            goto label_14;
          case 1:
            AbstractAsyncInterceptor.jLejWXWPpE7uFAysjx6g((object) invocation, (object) this.InterceptAsync((IInvocationAsync) new AbstractAsyncInterceptor.InvocationAsync(invocation), (CancellationToken) obj1));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 10 : 0;
            continue;
          case 2:
            AbstractAsyncInterceptor.yj6MwIWP18usNMOGVBFX((object) this, (object) invocation);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 12 : 7;
            continue;
          case 3:
            if (!AbstractAsyncInterceptor.keBxbIWPPyatlLQdfAS1(AbstractAsyncInterceptor.Md2NKGWPekbV6LhaloYC(AbstractAsyncInterceptor.hKYSlvWP2O7Rf8pk7Cor((object) invocation))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 2;
              continue;
            }
            object source = AbstractAsyncInterceptor.Csy7xEWPNQNmHGbW1unc((object) invocation);
            if (source == null)
            {
              num = 6;
              continue;
            }
            // ISSUE: reference to a compiler-generated field
            Func<object, bool> func = AbstractAsyncInterceptor.\u003C\u003Ec.\u003C\u003E9__7_0;
            Func<object, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              AbstractAsyncInterceptor.\u003C\u003Ec.\u003C\u003E9__7_0 = predicate = (Func<object, bool>) (argument => argument is CancellationToken);
            }
            else
              goto label_33;
label_25:
            obj2 = ((IEnumerable<object>) source).FirstOrDefault<object>(predicate);
            break;
label_33:
            predicate = func;
            goto label_25;
          case 4:
            if (!(AbstractAsyncInterceptor.Md2NKGWPekbV6LhaloYC((object) invocation.Method) == TypeOf<Task>.Raw))
            {
              num = 15;
              continue;
            }
            goto case 1;
          case 5:
            goto label_8;
          case 6:
            obj2 = (object) null;
            break;
          case 7:
            obj2 = (object) AbstractAsyncInterceptor.E0ipIIWP3SAsdZWGk4wC();
            goto label_30;
          case 8:
            orAdd = AbstractAsyncInterceptor.ExecuteInterceptForValueTaskAsyncConstructedMethodCache.GetOrAdd(genericArgument, (Func<Type, MethodInfo>) (type => (MethodInfo) AbstractAsyncInterceptor.MxmervWPHiKLdxtGvSMf((object) this.executeInterceptForValueTaskAsyncInfo, (object) new Type[1]
            {
              type
            })));
            goto label_32;
          case 9:
            if (AbstractAsyncInterceptor.S5B6OnWPtGXPJZAcuknS(AbstractAsyncInterceptor.Md2NKGWPekbV6LhaloYC(AbstractAsyncInterceptor.hKYSlvWP2O7Rf8pk7Cor((object) invocation)).GetGenericTypeDefinition(), AbstractAsyncInterceptor.ClGAKcWPDgF83o8UHrC2((object) TypeOf.Task1)))
            {
              num = 11;
              continue;
            }
            goto case 8;
          case 10:
            goto label_27;
          case 11:
            orAdd = AbstractAsyncInterceptor.ExecuteInterceptAsyncConstructedMethodCache.GetOrAdd(genericArgument, (Func<Type, MethodInfo>) (type => (MethodInfo) AbstractAsyncInterceptor.MxmervWPHiKLdxtGvSMf((object) this.executeInterceptAsyncInfo, (object) new Type[1]
            {
              type
            })));
            goto label_32;
          case 12:
            goto label_17;
          case 13:
            AbstractAsyncInterceptor.jLejWXWPpE7uFAysjx6g((object) invocation, (object) new ValueTask((Task) AbstractAsyncInterceptor.D7fwKxWPaxEg6jachiyn((object) this, (object) new AbstractAsyncInterceptor.InvocationAsync(invocation), (CancellationToken) obj1)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 5 : 2;
            continue;
          case 14:
            AbstractAsyncInterceptor.jLejWXWPpE7uFAysjx6g((object) invocation, AbstractAsyncInterceptor.VqLJ4jWPwtMcbIwIekPT((object) methodInfo, (object) this, (object) new object[2]
            {
              (object) invocation,
              obj1
            }));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          case 15:
            if (((MethodInfo) AbstractAsyncInterceptor.hKYSlvWP2O7Rf8pk7Cor((object) invocation)).ReturnType == TypeOf<ValueTask>.Raw)
            {
              num = 13;
              continue;
            }
            genericArgument = ((MethodInfo) AbstractAsyncInterceptor.hKYSlvWP2O7Rf8pk7Cor((object) invocation)).ReturnType.GetGenericArguments()[0];
            num = 9;
            continue;
          default:
            goto label_23;
        }
        if (obj2 == null)
        {
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 7 : 2;
          continue;
        }
label_30:
        obj1 = obj2;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 4 : 4;
        continue;
label_32:
        methodInfo = orAdd;
        num = 14;
      }
label_14:
      return;
label_8:
      return;
label_27:
      return;
label_17:
      return;
label_23:;
    }

    /// <summary>
    /// Выполнить асинхронное действие с ожиданием его завершения
    /// </summary>
    /// <typeparam name="TResult">Тип возвращаемого результата</typeparam>
    /// <param name="invocation">Информация о вызове метода</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Результат выполнения</returns>
    private async Task<TResult> ExecuteInterceptAsync<TResult>(
      IInvocation invocation,
      CancellationToken cancellationToken)
    {
      int num1 = 3;
      int num2;
      TResult result;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_39;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 2 : 0;
            continue;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 1;
            continue;
          case 5:
label_2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 3 : 4;
            continue;
          default:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 6 : 15;
              else
                goto label_21;
label_8:
              TaskAwaiter taskAwaiter1;
              TaskAwaiter<TResult> taskAwaiter2;
              TaskAwaiter awaiter1;
              TaskAwaiter<TResult> awaiter2;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                  case 15:
                    awaiter1 = taskAwaiter1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 7;
                    continue;
                  case 2:
                    if (!awaiter1.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 19 : 0;
                      continue;
                    }
                    goto case 11;
                  case 3:
                    goto label_36;
                  case 4:
                    goto label_21;
                  case 5:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
                    continue;
                  case 6:
                    taskAwaiter2 = new TaskAwaiter<TResult>();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 18 : 0;
                    continue;
                  case 7:
                    taskAwaiter1 = new TaskAwaiter();
                    num3 = 20;
                    continue;
                  case 8:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<TResult>, AbstractAsyncInterceptor.\u003CExecuteInterceptAsync\u003Ed__8<TResult>>(ref awaiter2, this);
                    num3 = 3;
                    continue;
                  case 9:
                    awaiter2 = ((Task<TResult>) invocation.ReturnValue).GetAwaiter();
                    num3 = 16;
                    continue;
                  case 10:
                    awaiter1 = this.InterceptAsync((IInvocationAsync) new AbstractAsyncInterceptor.InvocationAsync(invocation), cancellationToken).GetAwaiter();
                    num3 = 2;
                    continue;
                  case 11:
                    awaiter1.GetResult();
                    num3 = 9;
                    continue;
                  case 12:
                    goto label_25;
                  case 13:
                    result = awaiter2.GetResult();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 10 : 17;
                    continue;
                  case 14:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AbstractAsyncInterceptor.\u003CExecuteInterceptAsync\u003Ed__8<TResult>>(ref awaiter1, this);
                    num3 = 21;
                    continue;
                  case 16:
                    if (!awaiter2.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 5 : 5;
                      continue;
                    }
                    goto case 13;
                  case 17:
                    goto label_2;
                  case 18:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 13;
                    continue;
                  case 19:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = 22;
                    continue;
                  case 20:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 11;
                    continue;
                  case 21:
                    goto label_32;
                  case 22:
                    taskAwaiter1 = awaiter1;
                    num3 = 14;
                    continue;
                  default:
                    taskAwaiter2 = awaiter2;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 7 : 8;
                    continue;
                }
              }
label_36:
              return;
label_32:
              return;
label_21:
              if (num2 != 1)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 6 : 10;
                goto label_8;
              }
label_25:
              awaiter2 = taskAwaiter2;
              num3 = 6;
              goto label_8;
            }
            catch (Exception ex)
            {
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
                num4 = 0;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 2 : 0;
                    continue;
                  case 2:
                    goto label_30;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
                    continue;
                }
              }
label_30:
              return;
            }
        }
      }
label_39:;
    }

    /// <summary>
    /// Выполнить асинхронное действие с ожиданием его завершения
    /// </summary>
    /// <typeparam name="TResult">Тип возвращаемого результата</typeparam>
    /// <param name="invocation">Информация о вызове метода</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Результат выполнения</returns>
    private async ValueTask<TResult> ExecuteInterceptForValueTaskAsync<TResult>(
      IInvocation invocation,
      CancellationToken cancellationToken)
    {
      int num1 = 1;
      TResult result;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 3;
            continue;
          case 3:
            goto label_42;
          case 4:
label_5:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 0;
            continue;
          case 5:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = 7;
              else
                goto label_26;
label_9:
              TaskAwaiter taskAwaiter;
              TaskAwaiter awaiter1;
              while (true)
              {
                ValueTaskAwaiter<TResult> valueTaskAwaiter;
                int num4;
                ValueTaskAwaiter<TResult> awaiter2;
                ValueTask<TResult> returnValue;
                switch (num3)
                {
                  case 1:
                  case 12:
                    awaiter1.GetResult();
                    num3 = 20;
                    continue;
                  case 2:
                    goto label_39;
                  case 3:
                    goto label_26;
                  case 4:
                    valueTaskAwaiter = new ValueTaskAwaiter<TResult>();
                    num3 = 9;
                    continue;
                  case 5:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 12;
                    continue;
                  case 6:
                    goto label_5;
                  case 7:
                    if (num2 != 1)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 16 : 7;
                      continue;
                    }
                    goto case 18;
                  case 8:
                    if (awaiter2.IsCompleted)
                    {
                      num3 = 15;
                      continue;
                    }
                    goto case 14;
                  case 9:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 22;
                    continue;
                  case 10:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 7 : 11;
                    continue;
                  case 11:
                    taskAwaiter = awaiter1;
                    num4 = 24;
                    break;
                  case 13:
                    awaiter2 = returnValue.GetAwaiter();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 8 : 6;
                    continue;
                  case 14:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
                    continue;
                  case 15:
                  case 22:
                    result = awaiter2.GetResult();
                    num3 = 6;
                    continue;
                  case 16:
                    awaiter1 = this.InterceptAsync((IInvocationAsync) new AbstractAsyncInterceptor.InvocationAsync(invocation), cancellationToken).GetAwaiter();
                    num3 = 23;
                    continue;
                  case 17:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter<TResult>, AbstractAsyncInterceptor.\u003CExecuteInterceptForValueTaskAsync\u003Ed__9<TResult>>(ref awaiter2, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 19 : 3;
                    continue;
                  case 18:
                    awaiter2 = valueTaskAwaiter;
                    num4 = 4;
                    break;
                  case 19:
                    goto label_35;
                  case 20:
                    returnValue = (ValueTask<TResult>) invocation.ReturnValue;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 13;
                    continue;
                  case 21:
                    taskAwaiter = new TaskAwaiter();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 5;
                    continue;
                  case 23:
                    if (awaiter1.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 0;
                      continue;
                    }
                    goto case 10;
                  case 24:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, AbstractAsyncInterceptor.\u003CExecuteInterceptForValueTaskAsync\u003Ed__9<TResult>>(ref awaiter1, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 2 : 2;
                    continue;
                  default:
                    valueTaskAwaiter = awaiter2;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 2 : 17;
                    continue;
                }
                num3 = num4;
              }
label_39:
              return;
label_35:
              return;
label_26:
              awaiter1 = taskAwaiter;
              num3 = 21;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
              {
                num3 = 11;
                goto label_9;
              }
              else
                goto label_9;
            }
            catch (Exception ex)
            {
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
                num5 = 0;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    goto label_31;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num5 = 2;
                    continue;
                }
              }
label_31:
              return;
            }
          default:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 3 : 5;
            continue;
        }
      }
label_42:;
    }

    protected AbstractAsyncInterceptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.executeInterceptAsyncInfo = typeof (AbstractAsyncInterceptor).GetMethod((string) AbstractAsyncInterceptor.l56tFQWP4aniNl0oUnJr(864270449 << 6 ^ -521400208), BindingFlags.Instance | BindingFlags.NonPublic);
      this.executeInterceptForValueTaskAsyncInfo = typeof (AbstractAsyncInterceptor).GetMethod((string) AbstractAsyncInterceptor.l56tFQWP4aniNl0oUnJr(-1350312861 << 3 ^ 2082271046), BindingFlags.Instance | BindingFlags.NonPublic);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static AbstractAsyncInterceptor()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            AbstractAsyncInterceptor.ExecuteInterceptForValueTaskAsyncConstructedMethodCache = new ConcurrentDictionary<Type, MethodInfo>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
            continue;
          case 2:
            AbstractAsyncInterceptor.ExecuteInterceptAsyncConstructedMethodCache = new ConcurrentDictionary<Type, MethodInfo>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 1;
            continue;
          case 3:
            AbstractAsyncInterceptor.gNLIFLWP6a8xcUXAdWbK();
            num = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    internal static object hKYSlvWP2O7Rf8pk7Cor([In] object obj0) => (object) ((IInvocation) obj0).Method;

    internal static Type Md2NKGWPekbV6LhaloYC([In] object obj0) => ((MethodInfo) obj0).ReturnType;

    internal static bool keBxbIWPPyatlLQdfAS1(Type type) => type.IsAsync();

    internal static void yj6MwIWP18usNMOGVBFX([In] object obj0, [In] object obj1) => ((AbstractAsyncInterceptor) obj0).Intercept((IInvocation) obj1);

    internal static object Csy7xEWPNQNmHGbW1unc([In] object obj0) => (object) ((IInvocation) obj0).Arguments;

    internal static CancellationToken E0ipIIWP3SAsdZWGk4wC() => CancellationToken.None;

    internal static void jLejWXWPpE7uFAysjx6g([In] object obj0, [In] object obj1) => ((IInvocation) obj0).ReturnValue = obj1;

    internal static object D7fwKxWPaxEg6jachiyn(
      [In] object obj0,
      [In] object obj1,
      CancellationToken cancellationToken)
    {
      return (object) ((AbstractAsyncInterceptor) obj0).InterceptAsync((IInvocationAsync) obj1, cancellationToken);
    }

    internal static Type ClGAKcWPDgF83o8UHrC2([In] object obj0) => ((RipeType) obj0).Raw;

    internal static bool S5B6OnWPtGXPJZAcuknS([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object VqLJ4jWPwtMcbIwIekPT([In] object obj0, [In] object obj1, [In] object obj2) => ((MethodBase) obj0).Invoke(obj1, (object[]) obj2);

    internal static bool HaIY0KWPnDja4XIT4PtS() => AbstractAsyncInterceptor.EywYtWWPkX5g3mnGGCRC == null;

    internal static AbstractAsyncInterceptor TNDmSiWPO5i5xP3aCIQQ() => AbstractAsyncInterceptor.EywYtWWPkX5g3mnGGCRC;

    internal static object l56tFQWP4aniNl0oUnJr(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void gNLIFLWP6a8xcUXAdWbK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object MxmervWPHiKLdxtGvSMf([In] object obj0, [In] object obj1) => (object) ((MethodInfo) obj0).MakeGenericMethod((Type[]) obj1);

    /// <summary>Информация о вызове асинхронного метода</summary>
    private sealed class InvocationAsync : IInvocationAsync, IInvocation
    {
      private static readonly ConcurrentDictionary<Type, MethodInfo> AsyncConstructedMethodCache;
      private readonly object baseInvocation;
      private readonly object invocationAsyncInfo;
      private static object r6qT6YQAgYusMPAbZHxM;

      /// <summary>Ctor</summary>
      /// <param name="baseInvocation">Базовая синхронная релизация информации о вызове метода</param>
      public InvocationAsync(IInvocation baseInvocation)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: type reference
        // ISSUE: explicit non-virtual call
        this.invocationAsyncInfo = (object) __nonvirtual (AbstractAsyncInterceptor.InvocationAsync.dEAH01QAY0ciI0cGWXXs(__typeref (AbstractAsyncInterceptor.InvocationAsync)).GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889285330), BindingFlags.Instance | BindingFlags.NonPublic));
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.baseInvocation = (object) baseInvocation;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
              continue;
          }
        }
label_3:;
      }

      /// <inheritdoc />
      public object[] Arguments => (object[]) AbstractAsyncInterceptor.InvocationAsync.kt5rXZQALMMUIRXbUmwI(this.baseInvocation);

      /// <inheritdoc />
      public Type[] GenericArguments => ((IInvocation) this.baseInvocation).GenericArguments;

      /// <inheritdoc />
      public object InvocationTarget => AbstractAsyncInterceptor.InvocationAsync.kUoXOOQAULvUPW2fxjxn(this.baseInvocation);

      /// <inheritdoc />
      public MethodInfo Method => (MethodInfo) AbstractAsyncInterceptor.InvocationAsync.Bo5M87QAsxosoMA9G11U(this.baseInvocation);

      /// <inheritdoc />
      public MethodInfo MethodInvocationTarget => (MethodInfo) AbstractAsyncInterceptor.InvocationAsync.dbEOC5QAcMgoOF7VlwCd(this.baseInvocation);

      /// <inheritdoc />
      public object Proxy => AbstractAsyncInterceptor.InvocationAsync.XawM7xQAz8gheSYncpRe(this.baseInvocation);

      /// <inheritdoc />
      public object ReturnValue
      {
        get => ((IInvocation) this.baseInvocation).ReturnValue;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                ((IInvocation) this.baseInvocation).ReturnValue = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <inheritdoc />
      public Type TargetType => AbstractAsyncInterceptor.InvocationAsync.BaETRSQ7FBRaOePn46o4(this.baseInvocation);

      /// <inheritdoc />
      public object GetArgumentValue(int index) => AbstractAsyncInterceptor.InvocationAsync.n1WjlfQ7BW9sfBJHHXDa(this.baseInvocation, index);

      /// <inheritdoc />
      public MethodInfo GetConcreteMethod() => ((IInvocation) this.baseInvocation).GetConcreteMethod();

      /// <inheritdoc />
      public MethodInfo GetConcreteMethodInvocationTarget() => (MethodInfo) AbstractAsyncInterceptor.InvocationAsync.DCj7YAQ7W4D4DCWN8Lik(this.baseInvocation);

      /// <inheritdoc />
      public void Proceed() => throw new NotImplementedException(EleWise.ELMA.SR.T((string) AbstractAsyncInterceptor.InvocationAsync.QAsAySQ7o5bf9puEDZMZ(-345420348 ^ -345230758), AbstractAsyncInterceptor.InvocationAsync.QAsAySQ7o5bf9puEDZMZ(712480695 ^ 712120207), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921431671)));

      /// <inheritdoc />
      IInvocationProceedInfo IInvocation.CaptureProceedInfo() => ((IInvocation) this.baseInvocation).CaptureProceedInfo();

      /// <inheritdoc />
      public void SetArgumentValue(int index, object value)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              AbstractAsyncInterceptor.InvocationAsync.tsghnMQ7b1oPKepLCLmr(this.baseInvocation, index, value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      /// <inheritdoc />
      public Task ProceedAsync()
      {
        int num1 = 2;
        IInvocationProceedInfo invocationProceedInfo;
        ValueTask returnValue;
        Type genericArgument;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                if (((MethodInfo) AbstractAsyncInterceptor.InvocationAsync.Bo5M87QAsxosoMA9G11U(this.baseInvocation)).ReturnType == TypeOf<Task>.Raw)
                {
                  num2 = 3;
                  continue;
                }
                if (!AbstractAsyncInterceptor.InvocationAsync.fTcNN9Q7EHlOpyVjBcQK(((IInvocation) this.baseInvocation).Method.ReturnType, TypeOf<ValueTask>.Raw))
                {
                  genericArgument = AbstractAsyncInterceptor.InvocationAsync.zc8I0lQ7fwrFD8MSKT2E(AbstractAsyncInterceptor.InvocationAsync.Bo5M87QAsxosoMA9G11U(this.baseInvocation)).GetGenericArguments()[0];
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
                  continue;
                }
                num2 = 7;
                continue;
              case 2:
                invocationProceedInfo = (IInvocationProceedInfo) AbstractAsyncInterceptor.InvocationAsync.k8TdDlQ7hMrBpEoVOWC8(this.baseInvocation);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 1;
                continue;
              case 3:
                AbstractAsyncInterceptor.InvocationAsync.QlZS8eQ7G221qLGpKN5K((object) invocationProceedInfo);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 6;
                continue;
              case 4:
                goto label_10;
              case 5:
                returnValue = (ValueTask) ((IInvocation) this.baseInvocation).ReturnValue;
                num2 = 4;
                continue;
              case 6:
                goto label_12;
              case 7:
                goto label_3;
              default:
                goto label_9;
            }
          }
label_3:
          AbstractAsyncInterceptor.InvocationAsync.QlZS8eQ7G221qLGpKN5K((object) invocationProceedInfo);
          num1 = 5;
        }
label_9:
        return (Task) AbstractAsyncInterceptor.InvocationAsync.QCN1YHQ7Q3w8wc6rHtcU((object) AbstractAsyncInterceptor.InvocationAsync.AsyncConstructedMethodCache.GetOrAdd(genericArgument, (Func<Type, MethodInfo>) (type => ((MethodInfo) this.invocationAsyncInfo).MakeGenericMethod(type))), (object) this, (object) new object[2]
        {
          this.baseInvocation,
          (object) invocationProceedInfo
        });
label_10:
        return returnValue.AsTask();
label_12:
        return (Task) ((IInvocation) this.baseInvocation).ReturnValue;
      }

      /// <summary>
      /// Выполнить асинхронное действие с ожиданием его завершения
      /// </summary>
      /// <typeparam name="TResult">Тип возвращаемого результата</typeparam>
      /// <param name="invocation">Информация о вызове метода</param>
      /// <param name="invocationProceedInfo">Усеченная информация о вызове метода</param>
      /// <returns>Результат выполнения</returns>
      private async Task ExecuteInvocationAsync<TResult>(
        IInvocation invocation,
        IInvocationProceedInfo invocationProceedInfo)
      {
        int num1 = 4;
        int num2;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_53;
            case 2:
label_2:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003E1__state = -2;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
              continue;
            case 3:
              try
              {
                int num3;
                if (num2 != 0)
                  num3 = 15;
                else
                  goto label_41;
label_6:
                TaskAwaiter<TResult> taskAwaiter;
                TaskAwaiter<TResult> awaiter1;
                while (true)
                {
                  IInvocation invocation1;
                  ValueTaskAwaiter<TResult> valueTaskAwaiter;
                  int num4;
                  ValueTaskAwaiter<TResult> awaiter2;
                  TResult result;
                  object returnValue;
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num4 = 7;
                      break;
                    case 2:
                      awaiter2 = valueTask.GetAwaiter();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 8 : 8;
                      continue;
                    case 3:
                    case 27:
                      goto label_2;
                    case 4:
                      goto label_41;
                    case 5:
                    case 31:
                      result = awaiter2.GetResult();
                      num4 = 26;
                      break;
                    case 6:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num4 = 5;
                      break;
                    case 7:
                    case 21:
                      result = awaiter1.GetResult();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 20 : 30;
                      continue;
                    case 8:
                      if (awaiter2.IsCompleted)
                      {
                        num3 = 31;
                        continue;
                      }
                      goto case 29;
                    case 9:
                      if (returnValue != null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 32 : 36;
                        continue;
                      }
                      goto label_45;
                    case 11:
                      goto label_50;
                    case 12:
                      taskAwaiter = awaiter1;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 22 : 38;
                      continue;
                    case 13:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter<TResult>, AbstractAsyncInterceptor.InvocationAsync.\u003CExecuteInvocationAsync\u003Ed__28<TResult>>(ref awaiter2, this);
                      num3 = 18;
                      continue;
                    case 14:
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
                      continue;
                    case 15:
                      if (num2 != 1)
                      {
                        num3 = 25;
                        continue;
                      }
                      goto case 17;
                    case 16:
                      goto label_45;
                    case 17:
                      awaiter2 = valueTaskAwaiter;
                      num3 = 19;
                      continue;
                    case 18:
                      goto label_46;
                    case 19:
                      valueTaskAwaiter = new ValueTaskAwaiter<TResult>();
                      num3 = 6;
                      continue;
                    case 20:
                      if (awaiter1.IsCompleted)
                      {
                        num4 = 21;
                        break;
                      }
                      goto case 33;
                    case 22:
                      invocation1 = (IInvocation) null;
                      num3 = 3;
                      continue;
                    case 23:
                      invocation1 = (IInvocation) null;
                      num4 = 27;
                      break;
                    case 24:
                      if (returnValue is ValueTask<TResult> valueTask)
                      {
                        num3 = 14;
                        continue;
                      }
                      goto label_45;
                    case 25:
                      invocationProceedInfo.Invoke();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 34 : 0;
                      continue;
                    case 26:
                      invocation1.ReturnValue = (object) new ValueTask<TResult>(result);
                      num3 = 22;
                      continue;
                    case 28:
                      invocation1 = invocation;
                      awaiter1 = task.GetAwaiter();
                      num4 = 20;
                      break;
                    case 29:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 1;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 18 : 32;
                      continue;
                    case 30:
                      invocation1.ReturnValue = (object) Task.FromResult<TResult>(result);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 23 : 21;
                      continue;
                    case 32:
                      valueTaskAwaiter = awaiter2;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 13 : 13;
                      continue;
                    case 33:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 0;
                      num3 = 12;
                      continue;
                    case 34:
                      returnValue = invocation.ReturnValue;
                      num3 = 9;
                      continue;
                    case 35:
                      taskAwaiter = new TaskAwaiter<TResult>();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 0;
                      continue;
                    case 36:
                      if (!(returnValue is Task<TResult> task))
                      {
                        num3 = 24;
                        continue;
                      }
                      goto case 28;
                    case 37:
                      invocation1 = invocation;
                      num3 = 2;
                      continue;
                    case 38:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<TResult>, AbstractAsyncInterceptor.InvocationAsync.\u003CExecuteInvocationAsync\u003Ed__28<TResult>>(ref awaiter1, this);
                      num3 = 11;
                      continue;
                    default:
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 37 : 26;
                      continue;
                  }
                  num3 = num4;
                }
label_50:
                return;
label_46:
                return;
label_45:
                throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44746689), (object) invocation.ReturnValue.GetType().FullName, (object) TypeOf<Task<TResult>>.FullName, (object) TypeOf<ValueTask<TResult>>.FullName));
label_41:
                awaiter1 = taskAwaiter;
                num3 = 35;
                goto label_6;
              }
              catch (Exception ex)
              {
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
                  num5 = 0;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.SetException(ex);
                      num5 = 2;
                      continue;
                    case 2:
                      goto label_35;
                    default:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = -2;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 1;
                      continue;
                  }
                }
label_35:
                return;
              }
            case 4:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              num2 = (^this).\u003C\u003E1__state;
              num1 = 3;
              continue;
            default:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003Et__builder.SetResult();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 1 : 0;
              continue;
          }
        }
label_53:;
      }

      static InvocationAsync()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              AbstractAsyncInterceptor.InvocationAsync.K1jeFAQ7C449ogy4JQcQ();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              AbstractAsyncInterceptor.InvocationAsync.AsyncConstructedMethodCache = new ConcurrentDictionary<Type, MethodInfo>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 2 : 1;
              continue;
          }
        }
label_2:;
      }

      internal static Type dEAH01QAY0ciI0cGWXXs([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static bool dFNWZ0QA5SvSkQYqRnsk() => AbstractAsyncInterceptor.InvocationAsync.r6qT6YQAgYusMPAbZHxM == null;

      internal static AbstractAsyncInterceptor.InvocationAsync BG3yvSQAjqiqWY2kjeps() => (AbstractAsyncInterceptor.InvocationAsync) AbstractAsyncInterceptor.InvocationAsync.r6qT6YQAgYusMPAbZHxM;

      internal static object kt5rXZQALMMUIRXbUmwI([In] object obj0) => (object) ((IInvocation) obj0).Arguments;

      internal static object kUoXOOQAULvUPW2fxjxn([In] object obj0) => ((IInvocation) obj0).InvocationTarget;

      internal static object Bo5M87QAsxosoMA9G11U([In] object obj0) => (object) ((IInvocation) obj0).Method;

      internal static object dbEOC5QAcMgoOF7VlwCd([In] object obj0) => (object) ((IInvocation) obj0).MethodInvocationTarget;

      internal static object XawM7xQAz8gheSYncpRe([In] object obj0) => ((IInvocation) obj0).Proxy;

      internal static Type BaETRSQ7FBRaOePn46o4([In] object obj0) => ((IInvocation) obj0).TargetType;

      internal static object n1WjlfQ7BW9sfBJHHXDa([In] object obj0, [In] int obj1) => ((IInvocation) obj0).GetArgumentValue(obj1);

      internal static object DCj7YAQ7W4D4DCWN8Lik([In] object obj0) => (object) ((IInvocation) obj0).GetConcreteMethodInvocationTarget();

      internal static object QAsAySQ7o5bf9puEDZMZ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static void tsghnMQ7b1oPKepLCLmr([In] object obj0, [In] int obj1, [In] object obj2) => ((IInvocation) obj0).SetArgumentValue(obj1, obj2);

      internal static object k8TdDlQ7hMrBpEoVOWC8([In] object obj0) => (object) ((IInvocation) obj0).CaptureProceedInfo();

      internal static void QlZS8eQ7G221qLGpKN5K([In] object obj0) => ((IInvocationProceedInfo) obj0).Invoke();

      internal static bool fTcNN9Q7EHlOpyVjBcQK([In] Type obj0, [In] Type obj1) => obj0 == obj1;

      internal static Type zc8I0lQ7fwrFD8MSKT2E([In] object obj0) => ((MethodInfo) obj0).ReturnType;

      internal static object QCN1YHQ7Q3w8wc6rHtcU([In] object obj0, [In] object obj1, [In] object obj2) => ((MethodBase) obj0).Invoke(obj1, (object[]) obj2);

      internal static void K1jeFAQ7C449ogy4JQcQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
