// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.EnumerableExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Reflection;

namespace EleWise.ELMA.Extensions
{
  public static class EnumerableExtensions
  {
    private static readonly Lazy<PropertyInfo> NameValueCollectionComparerProperty;
    private static readonly ConcurrentDictionary<Type, Type> ElementTypeCache;
    private static EnumerableExtensions DOpVQvGH5ymEQHYndfjn;

    public static IEnumerable<T> If<T>(
      this IEnumerable<T> instance,
      bool condition,
      System.Func<IEnumerable<T>, IEnumerable<T>> action)
    {
      return !condition ? instance : action(instance);
    }

    public static IEnumerable<T> If<T>(
      this IEnumerable<T> instance,
      bool condition,
      System.Func<IEnumerable<T>, IEnumerable<T>> thenAction,
      System.Func<IEnumerable<T>, IEnumerable<T>> elseAction)
    {
      return !condition ? elseAction(instance) : thenAction(instance);
    }

    public static void Each<T>(this IEnumerable<T> instance, Action<T, int> action)
    {
      int num = 0;
      foreach (T obj in instance)
        action(obj, num++);
    }

    /// <summary>Executes the provided delegate for each item.</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="instance">The instance.</param>
    /// <param name="action">The action to be applied.</param>
    public static void Each<T>(this IEnumerable<T> instance, Action<T> action)
    {
      if (instance == null || action == null)
        return;
      foreach (T obj in instance)
        action(obj);
    }

    public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> source) => source ?? Enumerable.Empty<T>();

    public static IEnumerable<T> CastOrNull<T>(this IEnumerable source) => source == null ? (IEnumerable<T>) null : source.Cast<T>();

    public static ICollection<T> CastToCollectionOrNull<T>(this IEnumerable source) => source == null ? (ICollection<T>) null : (ICollection<T>) source.Cast<T>().ToList<T>();

    public static IList<T> CastToListOrNull<T>(this IEnumerable source) => source == null ? (IList<T>) null : (IList<T>) source.Cast<T>().ToList<T>();

    public static T[] CastToArrayOrNull<T>(this IEnumerable source) => source == null ? (T[]) null : source.Cast<T>().ToArray<T>();

    public static IEnumerable<T> AsGenericEnumerable<T>(this IEnumerable source)
    {
      if (source == null)
        return (IEnumerable<T>) null;
      Type type1 = typeof (T);
      if (source.GetType().FindGenericType(typeof (IEnumerable<T>)) != (Type) null)
        return (IEnumerable<T>) source;
      IEnumerator enumerator = source.GetEnumerator();
      Type type2;
      try
      {
        type2 = typeof (EnumerableExtensions.GenericEnumerable<>).MakeGenericType(typeof (T));
      }
      catch
      {
        while (enumerator.MoveNext())
        {
          if (enumerator.Current != null)
          {
            type1 = enumerator.Current.GetType();
            try
            {
              enumerator.Reset();
              break;
            }
            catch
            {
              break;
            }
          }
        }
        type2 = typeof (EnumerableExtensions.GenericEnumerable<>).MakeGenericType(type1);
      }
      object[] objArray = new object[1]{ (object) source };
      return (IEnumerable<T>) Activator.CreateInstance(type2, objArray);
    }

    internal static int IndexOf(this IEnumerable source, object item)
    {
      int num1 = 3;
      int num2;
      IEnumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            enumerator = (IEnumerator) EnumerableExtensions.gobH7qGHLkXUvBxdw2AF((object) source);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 0;
            continue;
          case 3:
            num2 = 0;
            num1 = 2;
            continue;
          default:
            goto label_20;
        }
      }
label_2:
      int num3;
      try
      {
label_6:
        if (EnumerableExtensions.t4UOAXGHcY33euNl8RRX((object) enumerator))
          goto label_9;
        else
          goto label_7;
label_3:
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_6;
            case 2:
              goto label_4;
            case 3:
            case 4:
              ++num2;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 0;
              continue;
            case 5:
              goto label_21;
            case 6:
              goto label_9;
            default:
              goto label_20;
          }
        }
label_4:
        num3 = num2;
        num4 = 5;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
        {
          num4 = 3;
          goto label_3;
        }
        else
          goto label_3;
label_7:
        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
        goto label_3;
label_9:
        if (!EnumerableExtensions.YWbDJDGHs8WC2ZI1yPxP(EnumerableExtensions.qeKJRbGHUd21D12fwVNT((object) enumerator), item))
        {
          num4 = 3;
          goto label_3;
        }
        else
          goto label_4;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        int num5 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
          num5 = 1;
        while (true)
        {
          switch (num5)
          {
            case 1:
              if (disposable != null)
              {
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
                continue;
              }
              goto label_17;
            case 2:
              goto label_17;
            default:
              disposable.Dispose();
              num5 = 2;
              continue;
          }
        }
label_17:;
      }
label_21:
      return num3;
label_20:
      return -1;
    }

    /// <exception cref="T:System.ArgumentOutOfRangeException"><c>index</c> is out of range.</exception>
    internal static object ElementAt(this IEnumerable source, int index)
    {
      int num1 = 5;
      IList list;
      IEnumerator enumerator;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 3:
              if (list == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            case 4:
              list = source as IList;
              num2 = 3;
              continue;
            case 5:
              if (index >= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 4 : 4;
                continue;
              }
              goto label_5;
            case 6:
              goto label_26;
            case 7:
              goto label_5;
            case 8:
              goto label_9;
            case 9:
              goto label_3;
            default:
              enumerator = (IEnumerator) EnumerableExtensions.gobH7qGHLkXUvBxdw2AF((object) source);
              num2 = 8;
              continue;
          }
        }
label_7:
        if (EnumerableExtensions.ckGIGBGAF6HNQrwBn9bQ((object) list) <= 0)
          num1 = 2;
        else
          goto label_26;
      }
label_3:
      return (object) null;
label_5:
      throw new ArgumentOutOfRangeException((string) EnumerableExtensions.EtTTXDGHzimby5nflDyM(~-306453669 ^ 306565584));
label_9:
      object obj1;
      try
      {
label_14:
        if (EnumerableExtensions.t4UOAXGHcY33euNl8RRX((object) enumerator))
          goto label_12;
        else
          goto label_15;
label_10:
        object obj2;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              if (index == 0)
              {
                num3 = 4;
                continue;
              }
              goto case 5;
            case 2:
              goto label_3;
            case 3:
              goto label_12;
            case 4:
              obj1 = obj2;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
              continue;
            case 5:
              --index;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 3 : 6;
              continue;
            case 6:
              goto label_14;
            default:
              goto label_4;
          }
        }
label_12:
        obj2 = EnumerableExtensions.qeKJRbGHUd21D12fwVNT((object) enumerator);
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
        {
          num3 = 1;
          goto label_10;
        }
        else
          goto label_10;
label_15:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 2;
        goto label_10;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        int num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
          num4 = 1;
        while (true)
        {
          switch (num4)
          {
            case 1:
              if (disposable != null)
              {
                num4 = 2;
                continue;
              }
              goto label_25;
            case 2:
              disposable.Dispose();
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
              continue;
            default:
              goto label_25;
          }
        }
label_25:;
      }
label_4:
      return obj1;
label_26:
      return EnumerableExtensions.nllEOJGAB88MgdOwnaon((object) list, index);
    }

    public static IEnumerable<TSource> SelectRecursive<TSource>(
      this IEnumerable<TSource> source,
      System.Func<TSource, IEnumerable<TSource>> recursiveSelector)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<TSource>) new EnumerableExtensions.\u003CSelectRecursive\u003Ed__13<TSource>(-2)
      {
        \u003C\u003E3__source = source,
        \u003C\u003E3__recursiveSelector = recursiveSelector
      };
    }

    /// <exception cref="T:System.ArgumentNullException"><c>first</c> is null.</exception>
    /// <exception cref="T:System.ArgumentNullException"><c>second</c> is null.</exception>
    /// <exception cref="T:System.ArgumentNullException"><c>resultSelector</c> is null.</exception>
    public static IEnumerable<TResult> Consolidate<TFirst, TSecond, TResult>(
      this IEnumerable<TFirst> first,
      IEnumerable<TSecond> second,
      Func<TFirst, TSecond, TResult> resultSelector)
    {
      if (first == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113601747));
      if (second == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -28993091));
      if (resultSelector == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137720028));
      return EnumerableExtensions.ZipIterator<TFirst, TSecond, TResult>(first, second, resultSelector);
    }

    private static IEnumerable<TResult> ZipIterator<TFirst, TSecond, TResult>(
      IEnumerable<TFirst> first,
      IEnumerable<TSecond> second,
      Func<TFirst, TSecond, TResult> resultSelector)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<TResult>) new EnumerableExtensions.\u003CZipIterator\u003Ed__15<TFirst, TSecond, TResult>(-2)
      {
        \u003C\u003E3__first = first,
        \u003C\u003E3__second = second,
        \u003C\u003E3__resultSelector = resultSelector
      };
    }

    public static ReadOnlyCollection<T> ToReadOnlyCollection<T>(this IEnumerable<T> sequence)
    {
      if (sequence == null)
        return EnumerableExtensions.DefaultReadOnlyCollection<T>.Empty;
      return sequence is ReadOnlyCollection<T> readOnlyCollection ? readOnlyCollection : new ReadOnlyCollection<T>((IList<T>) sequence.ToArray<T>());
    }

    public static ConcurrentDictionary<TKey, TSource> ToConcurrentDictionary<TSource, TKey>(
      this IEnumerable<TSource> source,
      System.Func<TSource, TKey> keySelector)
    {
      return source.ToConcurrentDictionary<TSource, TKey, TSource>(keySelector, (System.Func<TSource, TSource>) (x => x), (IEqualityComparer<TKey>) null);
    }

    public static ConcurrentDictionary<TKey, TSource> ToConcurrentDictionary<TSource, TKey>(
      this IEnumerable<TSource> source,
      System.Func<TSource, TKey> keySelector,
      IEqualityComparer<TKey> comparer)
    {
      return source.ToConcurrentDictionary<TSource, TKey, TSource>(keySelector, (System.Func<TSource, TSource>) (x => x), comparer);
    }

    public static ConcurrentDictionary<TKey, TElement> ToConcurrentDictionary<TSource, TKey, TElement>(
      this IEnumerable<TSource> source,
      System.Func<TSource, TKey> keySelector,
      System.Func<TSource, TElement> elementSelector)
    {
      return source.ToConcurrentDictionary<TSource, TKey, TElement>(keySelector, elementSelector, (IEqualityComparer<TKey>) null);
    }

    public static ConcurrentDictionary<TKey, TElement> ToConcurrentDictionary<TSource, TKey, TElement>(
      this IEnumerable<TSource> source,
      System.Func<TSource, TKey> keySelector,
      System.Func<TSource, TElement> elementSelector,
      IEqualityComparer<TKey> comparer)
    {
      if (source == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088306818));
      if (keySelector == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675507671));
      if (elementSelector == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 154081637));
      ConcurrentDictionary<TKey, TElement> concurrentDictionary = new ConcurrentDictionary<TKey, TElement>(comparer ?? (IEqualityComparer<TKey>) System.Collections.Generic.EqualityComparer<TKey>.Default);
      foreach (TSource source1 in source)
        concurrentDictionary.TryAdd(keySelector(source1), elementSelector(source1));
      return concurrentDictionary;
    }

    public static NameValueCollection ToNameValueCollection<TSource>(
      this IEnumerable<TSource> source,
      System.Func<TSource, string> nameSelector,
      System.Func<TSource, string> valueSelector,
      IEqualityComparer equalityComparer = null)
    {
      if (source == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70005333));
      if (nameSelector == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1853098230));
      if (valueSelector == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293425614));
      NameValueCollection nameValueCollection = new NameValueCollection(equalityComparer);
      foreach (TSource source1 in source)
        nameValueCollection.Add(nameSelector(source1), valueSelector(source1));
      return nameValueCollection;
    }

    public static IEqualityComparer EqualityComparer(this NameValueCollection nameValueCollection) => (IEqualityComparer) EnumerableExtensions.n7swVHGAWwEBP9Oni5Mt((object) EnumerableExtensions.NameValueCollectionComparerProperty.Value, (object) nameValueCollection, (object) null);

    /// <summary>
    /// Читает все данные из reader и преобразовывает их через func
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="reader"></param>
    /// <param name="func"></param>
    /// <remarks>
    /// reader закрывается внутри метода.<br />
    /// </remarks>
    /// <returns></returns>
    public static IEnumerable<T> AsEnumerable<T>(this IDataReader reader, System.Func<IDataReader, T> func) => (IEnumerable<T>) new EnumerableExtensions.\u003CAsEnumerable\u003Ed__25<T>(-2)
    {
      \u003C\u003E3__reader = reader,
      \u003C\u003E3__func = func
    };

    public static Type GetElementType(Type collectionType)
    {
      ConcurrentDictionary<Type, Type> elementTypeCache = EnumerableExtensions.ElementTypeCache;
      Type key = collectionType;
      // ISSUE: reference to a compiler-generated field
      System.Func<Type, Type> func = EnumerableExtensions.\u003C\u003Ec.\u003C\u003E9__27_0;
      System.Func<Type, Type> valueFactory;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        EnumerableExtensions.\u003C\u003Ec.\u003C\u003E9__27_0 = valueFactory = (System.Func<Type, Type>) (ct =>
        {
          int num = 4;
          Type type1;
          while (true)
          {
            Type type2;
            switch (num)
            {
              case 1:
                // ISSUE: type reference
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (EnumerableExtensions.\u003C\u003Ec.kmhclw8feqYDvCnmIJwY(ct.GetGenericTypeDefinition(), EnumerableExtensions.\u003C\u003Ec.HrLDxb8f2wdgntvu6yJF(__typeref (IEnumerable<>))))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 1;
                  continue;
                }
                goto default;
              case 2:
                type2 = ct;
                break;
              case 4:
                if (!ct.IsGenericType)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 3;
                  continue;
                }
                goto case 1;
              case 5:
                goto label_2;
              case 6:
                // ISSUE: reference to a compiler-generated method
                if (!EnumerableExtensions.\u003C\u003Ec.oFXcZU8fPwr7LN0Ds3CZ(type1, (Type) null))
                {
                  num = 5;
                  continue;
                }
                goto label_3;
              default:
                type2 = ct.GetInterface(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317943680));
                break;
            }
            type1 = type2;
            num = 6;
          }
label_2:
          return (Type) null;
label_3:
          return type1.GetGenericArguments()[0];
        });
      }
      else
        goto label_1;
label_3:
      return elementTypeCache.GetOrAdd(key, valueFactory);
label_1:
      valueFactory = func;
      goto label_3;
    }

    public static IEnumerable<TSource> Concat<TSource>(
      this TSource first,
      IEnumerable<TSource> second)
    {
      return Enumerable.Repeat<TSource>(first, 1).Concat<TSource>(second);
    }

    public static IEnumerable<TSource> Concat<TSource>(
      this IEnumerable<TSource> first,
      TSource second)
    {
      return first.Concat<TSource>(Enumerable.Repeat<TSource>(second, 1));
    }

    /// <summary>
    /// Присоединить элемент к последовательности если он не пуст
    /// </summary>
    /// <param name="first">Последовательность элементов</param>
    /// <param name="second">Отдельный элемент который надо присоединить</param>
    /// <typeparam name="TSource">Тип элемента</typeparam>
    /// <returns>
    /// Если <paramref name="second" /> не <c>null</c> то возвращаем новый набор элементов вместе с <paramref name="second" /><br />
    /// Иначе возвращаем <paramref name="first" />
    /// </returns>
    public static IEnumerable<TSource> ConcatIfNotNull<TSource>(
      this IEnumerable<TSource> first,
      TSource second)
    {
      return (object) second != null ? first.Concat<TSource>(second) : first;
    }

    public static TimeSpan Sum<TSource>(
      this IEnumerable<TSource> source,
      System.Func<TSource, TimeSpan> selector)
    {
      return source != null ? new TimeSpan(source.Sum<TSource>((System.Func<TSource, long>) (s => selector(s).Ticks))) : TimeSpan.Zero;
    }

    /// <summary>Преобразование в IEnumerable</summary>
    /// <typeparam name="T">Тип обьектов в IEnumerable</typeparam>
    /// <param name="item">Объект</param>
    /// <returns>Сформированный IEnumerable</returns>
    public static IEnumerable<T> ToEnumerable<T>(this T item) => (IEnumerable<T>) new EnumerableExtensions.\u003CToEnumerable\u003Ed__32<T>(-2)
    {
      \u003C\u003E3__item = item
    };

    /// <summary>Сортировка по зависимостям</summary>
    /// <param name="elements">Элементы</param>
    /// <param name="hasDependency">Функция, определяющая есть ли зависимость</param>
    /// <typeparam name="T"></typeparam>
    /// <returns>Новый список</returns>
    public static IEnumerable<T> OrderByDependencies<T>(
      this IEnumerable<T> elements,
      Func<T, T, bool> hasDependency)
    {
      EnumerableExtensions.Linkage<T>[] array = elements.Select<T, EnumerableExtensions.Linkage<T>>((System.Func<T, EnumerableExtensions.Linkage<T>>) (d => new EnumerableExtensions.Linkage<T>()
      {
        Element = d
      })).ToArray<EnumerableExtensions.Linkage<T>>();
      List<T> list = new List<T>();
      foreach (EnumerableExtensions.Linkage<T> linkage in array)
        EnumerableExtensions.Add<T>(linkage, (ICollection<T>) list, (IEnumerable<EnumerableExtensions.Linkage<T>>) array, hasDependency);
      return (IEnumerable<T>) list;
    }

    private static void Add<T>(
      EnumerableExtensions.Linkage<T> item,
      ICollection<T> list,
      IEnumerable<EnumerableExtensions.Linkage<T>> population,
      Func<T, T, bool> hasDependency)
    {
      if (item.Used)
        return;
      item.Used = true;
      foreach (EnumerableExtensions.Linkage<T> linkage in population.Where<EnumerableExtensions.Linkage<T>>((System.Func<EnumerableExtensions.Linkage<T>, bool>) (dep => hasDependency(item.Element, dep.Element))))
        EnumerableExtensions.Add<T>(linkage, list, population, hasDependency);
      list.Add(item.Element);
    }

    /// <summary>Проверяет, содержит ли множество объект</summary>
    /// <typeparam name="T">Тип</typeparam>
    /// <param name="instance">Объект</param>
    /// <param name="expected">Множество, в котором выполняется поиск</param>
    /// <returns></returns>
    public static bool In<T>(this T instance, params T[] expected) => ((IEnumerable<T>) expected).Contains<T>(instance);

    static EnumerableExtensions()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EnumerableExtensions.ElementTypeCache = new ConcurrentDictionary<Type, Type>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: type reference
            // ISSUE: reference to a compiler-generated method
            // ISSUE: explicit non-virtual call
            EnumerableExtensions.NameValueCollectionComparerProperty = new Lazy<PropertyInfo>((Func<PropertyInfo>) (() => __nonvirtual (EnumerableExtensions.\u003C\u003Ec.HrLDxb8f2wdgntvu6yJF(__typeref (NameObjectCollectionBase)).GetProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335343519), BindingFlags.Instance | BindingFlags.NonPublic))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 1;
            continue;
          case 3:
            EnumerableExtensions.VWJ5dSGAoxG1iDwJqFkB();
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

    internal static object gobH7qGHLkXUvBxdw2AF([System.Runtime.InteropServices.In] object obj0) => (object) ((IEnumerable) obj0).GetEnumerator();

    internal static object qeKJRbGHUd21D12fwVNT([System.Runtime.InteropServices.In] object obj0) => ((IEnumerator) obj0).Current;

    internal static bool YWbDJDGHs8WC2ZI1yPxP([System.Runtime.InteropServices.In] object obj0, [System.Runtime.InteropServices.In] object obj1) => object.Equals(obj0, obj1);

    internal static bool t4UOAXGHcY33euNl8RRX([System.Runtime.InteropServices.In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static bool CX095MGHjeVJGhEMxmx3() => EnumerableExtensions.DOpVQvGH5ymEQHYndfjn == null;

    internal static EnumerableExtensions wYTyPNGHYXEMKjHF71uQ() => EnumerableExtensions.DOpVQvGH5ymEQHYndfjn;

    internal static object EtTTXDGHzimby5nflDyM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static int ckGIGBGAF6HNQrwBn9bQ([System.Runtime.InteropServices.In] object obj0) => ((ICollection) obj0).Count;

    internal static object nllEOJGAB88MgdOwnaon([System.Runtime.InteropServices.In] object obj0, [System.Runtime.InteropServices.In] int obj1) => ((IList) obj0)[obj1];

    internal static object n7swVHGAWwEBP9Oni5Mt([System.Runtime.InteropServices.In] object obj0, [System.Runtime.InteropServices.In] object obj1, [System.Runtime.InteropServices.In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static void VWJ5dSGAoxG1iDwJqFkB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    public class GenericEnumerable<T> : IEnumerable<T>, IEnumerable
    {
      private readonly IEnumerable source;
      internal static object N39mjQ8EzGIZsTfXYdUN;

      /// <summary>
      /// Initializes a new instance of the <see cref="T:EleWise.ELMA.Extensions.EnumerableExtensions.GenericEnumerable`1" /> class.
      /// </summary>
      /// <param name="source">The source.</param>
      public GenericEnumerable(IEnumerable source)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.source = source;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      IEnumerator IEnumerable.GetEnumerator() => this.source.GetEnumerator();

      IEnumerator<T> IEnumerable<T>.GetEnumerator() => (IEnumerator<T>) new EnumerableExtensions.GenericEnumerable<T>.\u003CSystem\u002DCollections\u002DGeneric\u002DIEnumerable\u003CT\u003E\u002DGetEnumerator\u003Ed__3(0)
      {
        \u003C\u003E4__this = this
      };

      internal static bool zQVTXx8fFKagaoygrfPN() => EnumerableExtensions.GenericEnumerable<T>.N39mjQ8EzGIZsTfXYdUN == null;

      internal static object w6ByTG8fBJupAsoAAOyL() => EnumerableExtensions.GenericEnumerable<T>.N39mjQ8EzGIZsTfXYdUN;
    }

    private static class DefaultReadOnlyCollection<T>
    {
      private static ReadOnlyCollection<T> defaultCollection;

      internal static ReadOnlyCollection<T> Empty
      {
        get
        {
          if (EnumerableExtensions.DefaultReadOnlyCollection<T>.defaultCollection == null)
            EnumerableExtensions.DefaultReadOnlyCollection<T>.defaultCollection = new ReadOnlyCollection<T>((IList<T>) new T[0]);
          return EnumerableExtensions.DefaultReadOnlyCollection<T>.defaultCollection;
        }
      }
    }

    private class Linkage<T>
    {
      internal static object yjCwVv8fhKo72EJRXmey;

      public T Element { get; set; }

      public bool Used
      {
        get => this.\u003CUsed\u003Ek__BackingField;
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
                this.\u003CUsed\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
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

      public Linkage()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool MaFuij8fGr2d5FdDmi8X() => EnumerableExtensions.Linkage<T>.yjCwVv8fhKo72EJRXmey == null;

      internal static object umrSWU8fERJNRa9jclCl() => EnumerableExtensions.Linkage<T>.yjCwVv8fhKo72EJRXmey;
    }
  }
}
