// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.NHCastExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using NHibernate;
using NHibernate.Proxy;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Extensions
{
  public static class NHCastExtensions
  {
    private static NHCastExtensions TZ9GApGAZwZyyvCjYIcS;

    public static T CastAs<T>(this object source) => (T) source.CastAs(typeof (T));

    public static object CastAs(this object source, Type neededType)
    {
      int num = 4;
      Type c;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (neededType.IsAssignableFrom(c))
            {
              num = 5;
              continue;
            }
            goto label_2;
          case 2:
            if (NHCastExtensions.p5ya8BGAiB7OweH6qQgg(c, neededType))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 0;
              continue;
            }
            goto label_3;
          case 3:
            c = NHCastExtensions.BpmPNfGASs7blFdjo7xw(source);
            num = 2;
            continue;
          case 4:
            if (NHCastExtensions.afjCGbGAVbibEf3KDsiV(source))
            {
              num = 3;
              continue;
            }
            goto label_4;
          case 5:
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      throw new ApplicationException(string.Format((string) NHCastExtensions.XdoYPJGARP0moUjbrmnM(272623989 ^ 272362511), NHCastExtensions.hU1bcTGAq8pZfZxBa8cY((object) c), NHCastExtensions.hU1bcTGAq8pZfZxBa8cY((object) neededType)));
label_3:
      return NHCastExtensions.MABoo2GAXnwiB5YbQe5j(NHCastExtensions.CltCXWGAKxtiEwO2B3My((object) (INHibernateProxy) source));
label_4:
      return source;
    }

    public static T CastAsRealType<T>(this T source) => (T) ((object) source).CastAsRealType();

    public static object CastAsRealType(this object source)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!NHCastExtensions.afjCGbGAVbibEf3KDsiV(source))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return source;
label_3:
      return NHCastExtensions.MABoo2GAXnwiB5YbQe5j(NHCastExtensions.CltCXWGAKxtiEwO2B3My((object) (INHibernateProxy) source));
    }

    public static Type GetTypeWithoutProxy(this Type type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!NHCastExtensions.zp4INMGATfPwfZMXVe3u(type))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return type;
label_5:
      return type.BaseType;
    }

    /// <summary>Привести к реальному типу</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="source">Исходный тип</param>
    /// <param name="token">Токен, который можно использовать для отмены работы</param>
    /// <returns></returns>
    public static async Task<T> CastAsRealTypeAsync<T>(this T source, CancellationToken token)
    {
      int num1 = 4;
      while (true)
      {
        T result;
        int num2;
        switch (num1)
        {
          case 1:
            goto label_24;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 1;
            continue;
          case 3:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 1;
              else
                goto label_15;
label_6:
              TaskAwaiter<object> taskAwaiter;
              TaskAwaiter<object> awaiter;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    awaiter = ((object) (T) source).CastAsRealTypeAsync(token).GetAwaiter();
                    num3 = 9;
                    continue;
                  case 2:
                    taskAwaiter = new TaskAwaiter<object>();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
                    continue;
                  case 3:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = 4;
                    continue;
                  case 4:
                    taskAwaiter = awaiter;
                    num3 = 10;
                    continue;
                  case 5:
                    goto label_21;
                  case 6:
                    goto label_15;
                  case 7:
                  case 8:
                    result = (T) awaiter.GetResult();
                    num3 = 11;
                    continue;
                  case 9:
                    if (awaiter.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 7 : 5;
                      continue;
                    }
                    goto case 3;
                  case 10:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, NHCastExtensions.\u003CCastAsRealTypeAsync\u003Ed__5<T>>(ref awaiter, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 3 : 5;
                    continue;
                  case 11:
                    goto label_25;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 8;
                    continue;
                }
              }
label_21:
              return;
label_15:
              awaiter = taskAwaiter;
              num3 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
              {
                num3 = 0;
                goto label_6;
              }
              else
                goto label_6;
            }
            catch (Exception ex)
            {
              int num4 = 2;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_18;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 1;
                    continue;
                }
              }
label_18:
              return;
            }
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = 3;
            continue;
        }
label_25:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = 2;
      }
label_24:;
    }

    /// <summary>Привести к реальному типу</summary>
    /// <param name="source">Исходный тип</param>
    /// <param name="token">Токен, который можно использовать для отмены работы</param>
    /// <returns></returns>
    public static async Task<object> CastAsRealTypeAsync(
      this object source,
      CancellationToken token)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        object result;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_32;
            case 1:
              goto label_4;
            case 2:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003Et__builder.SetResult(result);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_6;
            case 4:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              num3 = (^this).\u003C\u003E1__state;
              num2 = 3;
              continue;
            default:
              goto label_29;
          }
        }
label_4:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = 2;
        continue;
label_6:
        try
        {
          int num4;
          if (num3 != 0)
            num4 = 4;
          else
            goto label_22;
label_9:
          TaskAwaiter<object> taskAwaiter;
          TaskAwaiter<object> awaiter;
          while (true)
          {
            int num5;
            switch (num4)
            {
              case 1:
              case 13:
                goto label_4;
              case 2:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003E1__state = num3 = -1;
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
                continue;
              case 3:
                if (!awaiter.IsCompleted)
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 11 : 2;
                  continue;
                }
                goto default;
              case 4:
                if (source.IsProxy())
                {
                  num5 = 12;
                  break;
                }
                goto case 7;
              case 5:
                goto label_22;
              case 6:
                taskAwaiter = awaiter;
                num4 = 8;
                continue;
              case 7:
                result = source;
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 1;
                continue;
              case 8:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, NHCastExtensions.\u003CCastAsRealTypeAsync\u003Ed__6>(ref awaiter, this);
                num5 = 10;
                break;
              case 9:
                taskAwaiter = new TaskAwaiter<object>();
                num4 = 2;
                continue;
              case 10:
                goto label_26;
              case 11:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003E1__state = num3 = 0;
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 5 : 6;
                continue;
              case 12:
                // ISSUE: reference to a compiler-generated method
                awaiter = ((ILazyInitializer) NHCastExtensions.\u003CCastAsRealTypeAsync\u003Ed__6.QmQLj58fl2S5MWHPapI4((object) (INHibernateProxy) source)).GetImplementationAsync(token).GetAwaiter();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 3 : 3;
                continue;
              default:
                result = awaiter.GetResult();
                num5 = 13;
                break;
            }
            num4 = num5;
          }
label_26:
          return;
label_22:
          awaiter = taskAwaiter;
          num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
          {
            num4 = 9;
            goto label_9;
          }
          else
            goto label_9;
        }
        catch (Exception ex)
        {
          int num6 = 2;
          while (true)
          {
            switch (num6)
            {
              case 0:
                goto label_25;
              case 1:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003Et__builder.SetException(ex);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
                continue;
              case 2:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003E1__state = -2;
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
                continue;
              default:
                goto label_13;
            }
          }
label_25:
          return;
label_13:
          return;
        }
      }
label_32:
      return;
label_29:;
    }

    internal static bool afjCGbGAVbibEf3KDsiV([In] object obj0) => obj0.IsProxy();

    internal static Type BpmPNfGASs7blFdjo7xw([In] object obj0) => NHibernateUtil.GetClass(obj0);

    internal static bool p5ya8BGAiB7OweH6qQgg([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object XdoYPJGARP0moUjbrmnM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object hU1bcTGAq8pZfZxBa8cY([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object CltCXWGAKxtiEwO2B3My([In] object obj0) => (object) ((INHibernateProxy) obj0).HibernateLazyInitializer;

    internal static object MABoo2GAXnwiB5YbQe5j([In] object obj0) => ((ILazyInitializer) obj0).GetImplementation();

    internal static bool a7wkAiGAuPMNwIcnWjkI() => NHCastExtensions.TZ9GApGAZwZyyvCjYIcS == null;

    internal static NHCastExtensions XIoF1lGAI77rV9WXV8Dk() => NHCastExtensions.TZ9GApGAZwZyyvCjYIcS;

    internal static bool zp4INMGATfPwfZMXVe3u(Type type) => type.IsProxy();
  }
}
