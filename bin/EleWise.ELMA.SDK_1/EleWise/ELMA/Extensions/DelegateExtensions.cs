// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.DelegateExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>
  ///  Класс, содержащий методы-расширения для работы с событиями и делегатами
  /// </summary>
  public static class DelegateExtensions
  {
    internal static DelegateExtensions CX3EZ3G7u9QaeIJOAmip;

    /// <summary>
    /// Выстреливает событие с переданными аргументами.
    /// Использовать только для статических классов.
    /// </summary>
    /// <param name="event">Событие</param>
    /// <param name="args">Агрументы</param>
    /// <remarks>
    /// Позволяет избежать ошибок в многопоточном приложении.
    /// Добавляет довольно много перегрузки к вызову.
    /// </remarks>
    public static void RaiseSafe(this Delegate @event, params object[] args)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            goto label_2;
          case 2:
            if ((object) @event == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 1;
              continue;
            }
            goto case 3;
          case 3:
            new Event(@event).Raise(args);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_4:
      return;
label_2:
      return;
label_7:;
    }

    /// <summary>
    /// Выстреливает событие с переданными аргументами.
    /// Использовать только для статических классов.
    /// </summary>
    /// <param name="event">Событие</param>
    /// <param name="sender">Источник</param>
    /// <param name="eventArgObject">Аргумент</param>
    /// <remarks>
    /// Позволяет избежать ошибок в многопоточном приложении.
    /// Добавляет довольно много перегрузки к вызову.
    /// </remarks>
    public static void RaiseSafe(this Delegate @event, object sender, EventArgs eventArgObject)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if ((object) @event != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            goto label_2;
          default:
            new Event(@event).Raise(sender, (object) eventArgObject);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 2;
            continue;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <summary>
    /// Выстреливает событие с переданными аргументами.
    /// Добавляет проверку на null
    /// </summary>
    /// <typeparam name="T">Тип события</typeparam>
    /// <param name="event">Событие</param>
    /// <param name="sender">Источник</param>
    /// <param name="args">Аргумент</param>
    public static void Raise<T>(this EventHandler<T> @event, object sender, T args) where T : EventArgs
    {
      if (@event == null)
        return;
      @event(sender, args);
    }

    /// <summary>
    /// Выстреливает событие с переданными аргументами.
    /// Добавляет проверку на null
    /// </summary>
    /// <param name="event">Событие</param>
    /// <param name="sender">Источник</param>
    /// <param name="args">Аргумент</param>
    public static void Raise(this EventHandler @event, object sender, EventArgs args)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            DelegateExtensions.QatD4XG7SoCWHgalok3O((object) @event, sender, (object) args);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            if (@event == null)
            {
              num = 2;
              continue;
            }
            goto case 1;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_2:
      return;
label_7:;
    }

    /// <summary>
    /// Привести дерегат к другому типу делегата
    /// http://code.logos.com/blog/2008/07/casting_delegates.html
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="source"></param>
    /// <returns></returns>
    public static T Cast<T>(Delegate source) where T : class => DelegateExtensions.Cast(source, typeof (T)) as T;

    /// <summary>
    /// Привести дерегат к другому типу делегата
    /// http://code.logos.com/blog/2008/07/casting_delegates.html
    /// </summary>
    /// <param name="source"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static Delegate Cast(Delegate source, Type type)
    {
      int num1 = 8;
      Delegate[] delegateArray1;
      Delegate[] delegateArray2;
      while (true)
      {
        int num2 = num1;
        int index;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 11:
              delegateArray2[index] = (Delegate) DelegateExtensions.M9qJAZG7KRNISvAyFZiw(type, DelegateExtensions.KnW5cuG7RiNrV6RbOYgM((object) delegateArray1[index]), (object) delegateArray1[index].Method);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 5 : 9;
              continue;
            case 2:
              goto label_11;
            case 3:
              if (delegateArray1.Length != 1)
              {
                delegateArray2 = new Delegate[delegateArray1.Length];
                num2 = 10;
                continue;
              }
              goto label_16;
            case 5:
              goto label_4;
            case 6:
              goto label_8;
            case 7:
              delegateArray1 = (Delegate[]) DelegateExtensions.Ug2DDJG7iTWoQybRjiJ1((object) source);
              num2 = 3;
              continue;
            case 8:
              goto label_13;
            case 9:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
              continue;
            case 10:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 4;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        if (index < delegateArray1.Length)
        {
          num1 = 11;
          continue;
        }
        goto label_11;
label_13:
        if ((object) source != null)
        {
          num1 = 7;
          continue;
        }
        goto label_8;
label_16:
        num1 = 5;
      }
label_4:
      return Delegate.CreateDelegate(type, DelegateExtensions.KnW5cuG7RiNrV6RbOYgM((object) delegateArray1[0]), (MethodInfo) DelegateExtensions.RNdHDUG7qAX9Yos9AEjw((object) delegateArray1[0]));
label_8:
      return (Delegate) null;
label_11:
      return (Delegate) DelegateExtensions.lOtoj9G7XkdVLRp5AsKC((object) delegateArray2);
    }

    internal static bool ijw4XoG7IJYib8Juso2f() => DelegateExtensions.CX3EZ3G7u9QaeIJOAmip == null;

    internal static DelegateExtensions PtvZiUG7Vd0V96xPO8dA() => DelegateExtensions.CX3EZ3G7u9QaeIJOAmip;

    internal static void QatD4XG7SoCWHgalok3O([In] object obj0, [In] object obj1, [In] object obj2) => ((EventHandler) obj0)(obj1, (EventArgs) obj2);

    internal static object Ug2DDJG7iTWoQybRjiJ1([In] object obj0) => (object) ((Delegate) obj0).GetInvocationList();

    internal static object KnW5cuG7RiNrV6RbOYgM([In] object obj0) => ((Delegate) obj0).Target;

    internal static object RNdHDUG7qAX9Yos9AEjw([In] object obj0) => (object) ((Delegate) obj0).Method;

    internal static object M9qJAZG7KRNISvAyFZiw([In] Type obj0, [In] object obj1, [In] object obj2) => (object) Delegate.CreateDelegate(obj0, obj1, (MethodInfo) obj2);

    internal static object lOtoj9G7XkdVLRp5AsKC([In] object obj0) => (object) Delegate.Combine((Delegate[]) obj0);
  }
}
