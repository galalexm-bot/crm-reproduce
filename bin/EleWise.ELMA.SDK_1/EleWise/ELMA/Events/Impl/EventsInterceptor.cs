// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Impl.EventsInterceptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Castle.DynamicProxy;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.AOP;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Events.Impl
{
  /// <summary>Перехватчик событий</summary>
  internal class EventsInterceptor : AbstractAsyncInterceptor
  {
    private readonly IEnumerable<IEventBus> eventBuses;
    private readonly IEnumerable<IEventBusAsync> eventBusesAsync;
    [ThreadStatic]
    private static Stack<string> notifying;
    private static readonly AsyncLocal<Stack<string>> notifyingAsyncLocal;
    internal static EventsInterceptor kKT63oGYMTXqZUCH6bMI;

    /// <summary>Ctor</summary>
    /// <param name="eventBuses">Шины событий</param>
    /// <param name="eventBusesAsync">Асинхронные шины событий</param>
    public EventsInterceptor(
      IEnumerable<IEventBus> eventBuses,
      IEnumerable<IEventBusAsync> eventBusesAsync)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.eventBuses = eventBuses;
      this.eventBusesAsync = eventBusesAsync;
    }

    /// <inheritdoc />
    public override void Intercept(IInvocation invocation)
    {
      int num1 = 4;
      string str1;
      string str2;
      IInvocation invocation1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_45;
            case 1:
              goto label_37;
            case 2:
              if (EventsInterceptor.notifying == null)
              {
                num2 = 11;
                continue;
              }
              goto case 9;
            case 3:
              goto label_43;
            case 4:
              num2 = 3;
              continue;
            case 5:
              goto label_6;
            case 6:
              ((ILogger) EventsInterceptor.RmU7waGYgYoo2yVV5vHm()).Error(EventsInterceptor.gmLrwUGY5KCdZhqkpgnE(-53329496 >> 4 ^ -3590038));
              num2 = 10;
              continue;
            case 7:
              if (!EventSettings.Enabled)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
                continue;
              }
              str2 = (string) EventsInterceptor.fQJwRQGYldsEheDA4og6((object) EventsInterceptor.zaVfk5GYduwpRDGMVYhc((object) invocation1.Method));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 8 : 1;
              continue;
            case 8:
              goto label_3;
            case 9:
              if (EventsInterceptor.I8TqyuGYrNggSyh9BbAF((object) EventsInterceptor.notifying) <= 1000)
              {
                EventsInterceptor.notifying.Push(str2);
                num2 = 5;
                continue;
              }
              num2 = 6;
              continue;
            case 10:
              goto label_35;
            case 11:
              EventsInterceptor.notifying = new Stack<string>();
              num2 = 9;
              continue;
            default:
              goto label_26;
          }
        }
label_3:
        str1 = (string) EventsInterceptor.fQJwRQGYldsEheDA4og6((object) invocation1.Method);
        num1 = 2;
        continue;
label_43:
        invocation1 = invocation;
        num1 = 7;
      }
label_45:
      return;
label_37:
      return;
label_35:
      return;
label_26:
      return;
label_6:
      try
      {
        // ISSUE: object of a compiler-generated type is created
        IEnumerable<\u003C\u003Ef__AnonymousType11<string, object>> source1 = ((IEnumerable<ParameterInfo>) EventsInterceptor.l7i4e2GYY682ljafaIA9(EventsInterceptor.sJ20MjGYjBlkJQePFqUG((object) invocation1))).Select((parameter, index) => new \u003C\u003Ef__AnonymousType11<string, object>(parameter.Name, invocation1.Arguments[index]));
        // ISSUE: reference to a compiler-generated field
        Func<\u003C\u003Ef__AnonymousType11<string, object>, string> func1 = EventsInterceptor.\u003C\u003Ec.\u003C\u003E9__3_1;
        Func<\u003C\u003Ef__AnonymousType11<string, object>, string> keySelector;
        if (func1 == null)
        {
          // ISSUE: reference to a compiler-generated field
          EventsInterceptor.\u003C\u003Ec.\u003C\u003E9__3_1 = keySelector = kv => kv.Name;
        }
        else
          goto label_50;
label_8:
        // ISSUE: reference to a compiler-generated field
        Func<\u003C\u003Ef__AnonymousType11<string, object>, object> func2 = EventsInterceptor.\u003C\u003Ec.\u003C\u003E9__3_2;
        Func<\u003C\u003Ef__AnonymousType11<string, object>, object> elementSelector;
        if (func2 == null)
        {
          // ISSUE: reference to a compiler-generated field
          EventsInterceptor.\u003C\u003Ec.\u003C\u003E9__3_2 = elementSelector = kv => kv.Value;
        }
        else
          goto label_49;
label_10:
        Dictionary<string, object> dictionary = source1.ToDictionary(keySelector, elementSelector);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
          num3 = 1;
        List<object> results;
        IEnumerator<IEventBus> enumerator;
        while (true)
        {
          switch (num3)
          {
            case 1:
              results = new List<object>();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_31;
            case 3:
              try
              {
label_17:
                if (EventsInterceptor.PDdl7uGYL8HS9l19y9GS((object) enumerator))
                  goto label_21;
                else
                  goto label_18;
label_15:
                IEnumerable source2;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_21;
                    case 2:
                      goto label_17;
                    case 3:
                      goto label_30;
                    case 4:
                      if (source2 != null)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_17;
                    default:
                      results.AddRange(source2.Cast<object>());
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 2 : 2;
                      continue;
                  }
                }
label_18:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 3 : 0;
                goto label_15;
label_21:
                source2 = enumerator.Current.Notify(str2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138154820) + str1, (IDictionary<string, object>) dictionary);
                num4 = 4;
                goto label_15;
              }
              finally
              {
                if (enumerator != null)
                {
                  int num5 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
                    num5 = 0;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        goto label_28;
                      default:
                        EventsInterceptor.VVs4A4GYU88ILOk1u6MI((object) enumerator);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_28:;
              }
            case 4:
label_30:
              EventsInterceptor.eLWlGQGYc87jPT47j62L((object) invocation1, this.Adjust((IEnumerable) results, EventsInterceptor.kAskIKGYsCmNrBFAa35i(EventsInterceptor.sJ20MjGYjBlkJQePFqUG((object) invocation1))));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 2 : 1;
              continue;
            default:
              enumerator = this.eventBuses.GetEnumerator();
              num3 = 3;
              continue;
          }
        }
label_31:
        return;
label_49:
        elementSelector = func2;
        goto label_10;
label_50:
        keySelector = func1;
        goto label_8;
      }
      finally
      {
        EventsInterceptor.notifying.Pop();
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
          num6 = 0;
        switch (num6)
        {
          default:
        }
      }
    }

    /// <inheritdoc />
    public override Task InterceptAsync(
      IInvocationAsync invocation,
      CancellationToken cancellationToken)
    {
      int num1 = 5;
      // ISSUE: variable of a compiler-generated type
      EventsInterceptor.\u003CInterceptAsync\u003Ed__4 stateMachine;
      while (true)
      {
        int num2 = num1;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_8;
            case 3:
              goto label_7;
            case 4:
              // ISSUE: reference to a compiler-generated field
              stateMachine.invocation = invocation;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 7 : 3;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = 4;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 0;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated field
              stateMachine.cancellationToken = cancellationToken;
              num2 = 3;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        tBuilder.Start<EventsInterceptor.\u003CInterceptAsync\u003Ed__4>(ref stateMachine);
        num1 = 2;
        continue;
label_7:
        // ISSUE: reference to a compiler-generated field
        stateMachine.\u003C\u003Et__builder = EventsInterceptor.cyh8mZGYzLZGo1SSiQon();
        num1 = 6;
      }
label_8:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    private object Adjust(IEnumerable results, Type returnType)
    {
      int num = 9;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!EventsInterceptor.zdBUedGLBBv542sUhEFQ(results.GetType(), returnType))
            {
              num = 4;
              continue;
            }
            goto label_12;
          case 2:
            if (results == null)
            {
              num = 7;
              continue;
            }
            goto case 1;
          case 3:
          case 5:
          case 7:
          case 8:
            goto label_12;
          case 4:
            goto label_13;
          case 6:
            if (EventsInterceptor.zdBUedGLBBv542sUhEFQ(returnType, TypeOf<Task>.Raw))
            {
              num = 3;
              continue;
            }
            break;
          case 9:
            // ISSUE: type reference
            if (EventsInterceptor.zdBUedGLBBv542sUhEFQ(returnType, EventsInterceptor.sc32O8GLFc0rC8etH7am(__typeref (void))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 8 : 3;
              continue;
            }
            goto case 6;
        }
        if (!EventsInterceptor.zdBUedGLBBv542sUhEFQ(returnType, TypeOf<ValueTask>.Raw))
          num = 2;
        else
          break;
      }
label_12:
      return (object) results;
label_13:
      // ISSUE: type reference
      // ISSUE: type reference
      return EventsInterceptor.utpmPeGLhTf0PlVVhHUI(EventsInterceptor.pSBekEGLbvu1PBPFjI7x(EventsInterceptor.sc32O8GLFc0rC8etH7am(__typeref (Enumerable)), EventsInterceptor.gmLrwUGY5KCdZhqkpgnE(-1217523399 ^ -1217786369), (object) (EventsInterceptor.kPZyaOGLooxnuwF0Pnrv(returnType, EventsInterceptor.QQ0iKGGLWx7EJ9ofYEiw((object) TypeOf.Task1)) || EventsInterceptor.kPZyaOGLooxnuwF0Pnrv(returnType, EventsInterceptor.QQ0iKGGLWx7EJ9ofYEiw((object) TypeOf.ValueTask1)) ? returnType.GetGenericArguments()[0].GetGenericArguments() : returnType.GetGenericArguments()), (object) new Type[1]
      {
        typeof (IEnumerable)
      }, EventsInterceptor.sc32O8GLFc0rC8etH7am(__typeref (IEnumerable<>))), (object) null, (object) (object[]) new IEnumerable[1]
      {
        results
      });
    }

    static EventsInterceptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            EventsInterceptor.miOONlGLG7nUdiobF93s();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            EventsInterceptor.notifyingAsyncLocal = new AsyncLocal<Stack<string>>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static Type zaVfk5GYduwpRDGMVYhc([In] object obj0) => ((MemberInfo) obj0).DeclaringType;

    internal static object fQJwRQGYldsEheDA4og6([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static int I8TqyuGYrNggSyh9BbAF([In] object obj0) => ((Stack<string>) obj0).Count;

    internal static object RmU7waGYgYoo2yVV5vHm() => (object) Logger.Log;

    internal static object gmLrwUGY5KCdZhqkpgnE(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object sJ20MjGYjBlkJQePFqUG([In] object obj0) => (object) ((IInvocation) obj0).Method;

    internal static object l7i4e2GYY682ljafaIA9([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();

    internal static bool PDdl7uGYL8HS9l19y9GS([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void VVs4A4GYU88ILOk1u6MI([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static Type kAskIKGYsCmNrBFAa35i([In] object obj0) => ((MethodInfo) obj0).ReturnType;

    internal static void eLWlGQGYc87jPT47j62L([In] object obj0, [In] object obj1) => ((IInvocation) obj0).ReturnValue = obj1;

    internal static bool U05IaKGYJea5rVo9M9Dg() => EventsInterceptor.kKT63oGYMTXqZUCH6bMI == null;

    internal static EventsInterceptor xrWvpTGY9T54NC5cpMZ4() => EventsInterceptor.kKT63oGYMTXqZUCH6bMI;

    internal static AsyncTaskMethodBuilder cyh8mZGYzLZGo1SSiQon() => AsyncTaskMethodBuilder.Create();

    internal static Type sc32O8GLFc0rC8etH7am([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool zdBUedGLBBv542sUhEFQ([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static Type QQ0iKGGLWx7EJ9ofYEiw([In] object obj0) => ((RipeType) obj0).Raw;

    internal static bool kPZyaOGLooxnuwF0Pnrv(Type type, Type genericType) => type.IsAssignableToGenericType(genericType);

    internal static object pSBekEGLbvu1PBPFjI7x(
      Type t,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      Type returnType)
    {
      return (object) t.GetGenericMethod((string) obj1, (Type[]) obj2, (Type[]) obj3, returnType);
    }

    internal static object utpmPeGLhTf0PlVVhHUI([In] object obj0, [In] object obj1, [In] object obj2) => ((MethodBase) obj0).Invoke(obj1, (object[]) obj2);

    internal static void miOONlGLG7nUdiobF93s() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
