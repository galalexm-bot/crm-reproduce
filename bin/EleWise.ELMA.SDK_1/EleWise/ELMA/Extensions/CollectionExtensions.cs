// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.CollectionExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>
  ///  расширения для коллекций (последовательностей, списков и т.д.)
  /// </summary>
  public static class CollectionExtensions
  {
    internal static CollectionExtensions BMfMIpGHd07uarNrc28o;

    /// <summary>
    /// Топологическая сортировка
    /// Код взят отсюда http://stackoverflow.com/questions/1982592/topological-sorting-using-linq
    /// ВНИМАНИЕ: Для упорядочивания comparer должен возвращать -1 и 0, значения &gt;0 не учитываются.
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <param name="comparer"></param>
    /// <returns></returns>
    public static IEnumerable<TSource> PartialOrderBy<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      IComparer<TKey> comparer)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<TSource>) new CollectionExtensions.\u003CPartialOrderBy\u003Ed__0<TSource, TKey>(-2)
      {
        \u003C\u003E3__source = source,
        \u003C\u003E3__keySelector = keySelector,
        \u003C\u003E3__comparer = comparer
      };
    }

    /// <summary>Содержит ли коллекция элемент по типу</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="source"></param>
    /// <returns></returns>
    public static bool Contains<T>(this IEnumerable source) => source.Cast<object>().ToList<object>().Any<object>((Func<object, bool>) (a => a is T));

    /// <summary>
    /// Топологическая сортировка
    /// Код взят отсюда http://stackoverflow.com/questions/1982592/topological-sorting-using-linq
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <returns></returns>
    public static IEnumerable<TSource> PartialOrderBy<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector)
      where TKey : IComparable
    {
      return source.PartialOrderBy<TSource, TKey>(keySelector, (IComparer<TKey>) CollectionExtensions.ComparableComparer<TKey>.Instance);
    }

    /// <summary>
    /// Сортировка по родителю: сначала дочерние записи, потом родительские (между разными ветками порядок не выстраивается)
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <param name="source"></param>
    /// <param name="parentSelector"></param>
    /// <returns></returns>
    public static IEnumerable<TSource> OrderByParentDesc<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, TSource> parentSelector)
    {
      return source.OrderByParentDesc<TSource>(parentSelector, (IEqualityComparer<TSource>) EqualityComparer<TSource>.Default);
    }

    /// <summary>
    /// Сортировка по родителю: сначала дочерние записи, потом родительские (между разными ветками порядок не выстраивается)
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <param name="source"></param>
    /// <param name="parentSelector"></param>
    /// <param name="comparer"></param>
    /// <returns></returns>
    public static IEnumerable<TSource> OrderByParentDesc<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, TSource> parentSelector,
      IEqualityComparer<TSource> comparer)
    {
      return source.OrderByParentDesc<TSource>(parentSelector, (Func<TSource, bool>) (i => comparer.Equals(parentSelector(i), default (TSource))), comparer);
    }

    /// <summary>
    /// Сортировка по родителю: сначала дочерние записи, потом родительские (между разными ветками порядок не выстраивается)
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <param name="source"></param>
    /// <param name="parentSelector"></param>
    /// <param name="rootSelector"></param>
    /// <returns></returns>
    public static IEnumerable<TSource> OrderByParentDesc<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, TSource> parentSelector,
      Func<TSource, bool> rootSelector)
    {
      return source.OrderByParentDesc<TSource>(parentSelector, rootSelector, (IEqualityComparer<TSource>) EqualityComparer<TSource>.Default);
    }

    /// <summary>
    /// Сортировка по родителю: сначала дочерние записи, потом родительские (между разными ветками порядок не выстраивается)
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <param name="source"></param>
    /// <param name="parentSelector"></param>
    /// <param name="rootSelector"></param>
    /// <param name="comparer"></param>
    /// <returns></returns>
    public static IEnumerable<TSource> OrderByParentDesc<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, TSource> parentSelector,
      Func<TSource, bool> rootSelector,
      IEqualityComparer<TSource> comparer)
    {
      Stack<TSource> sourceStack = new Stack<TSource>();
      List<TSource> list = source.ToList<TSource>();
      Func<TSource, bool> predicate = rootSelector;
      while (true)
      {
        List<TSource> items = list.Where<TSource>(predicate).ToList<TSource>();
        if (items.Count != 0)
        {
          foreach (TSource source1 in items)
          {
            sourceStack.Push(source1);
            list.Remove(source1);
          }
          predicate = (Func<TSource, bool>) (i => items.Contains<TSource>(parentSelector(i), comparer));
        }
        else
          break;
      }
      return (IEnumerable<TSource>) sourceStack;
    }

    /// <summary>Создать копию списка и добавить элемент</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="source"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static List<T> ImmutableAdd<T>(this List<T> source, T value) => new List<T>((IEnumerable<T>) source)
    {
      value
    };

    /// <summary>Создать копию списка и добавить элементы</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="source"></param>
    /// <param name="values"></param>
    /// <returns></returns>
    public static List<T> ImmutableAdd<T>(this List<T> source, IEnumerable<T> values)
    {
      List<T> objList = new List<T>((IEnumerable<T>) source);
      objList.AddRange(values);
      return objList;
    }

    /// <summary>Создать список из одного элемента</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="first"></param>
    /// <returns></returns>
    public static List<T> CreateOneElementList<T>(T first) => new List<T>()
    {
      first
    };

    /// <summary>
    /// Сравнить последовательности по составу, без учета порядка.
    /// 
    /// Например,  для
    /// 
    /// [1,2,3] [3,1,2] будет true
    /// 
    /// </summary>
    /// <typeparam name="T">Тип элемента</typeparam>
    /// <param name="source">Последовательность элементов</param>
    /// <param name="sequence">Последовательность элементов</param>
    /// <returns>true, если последовательности совпадают по составу, иначе false</returns>
    public static bool SetEqual<T>(this IEnumerable<T> source, IEnumerable<T> sequence) => source.ToHashSet<T>().SetEquals(sequence);

    /// <summary>
    /// Сравнить последовательности по составу, без учета порядка.
    /// 
    /// Например,  для
    /// 
    /// [1,2,3] [3,1,2] будет true
    /// 
    /// </summary>
    /// <typeparam name="T">Тип элемента</typeparam>
    /// <param name="source">Последовательность элементов</param>
    /// <param name="sequence">Последовательность элементов</param>
    /// <param name="comparer"><see cref="T:System.Collections.Generic.IEqualityComparer`1" /> для сравнения элементов</param>
    /// <returns>true, если последовательности совпадают по составу, иначе false</returns>
    public static bool SetEqual<T>(
      this IEnumerable<T> source,
      IEnumerable<T> sequence,
      IEqualityComparer<T> comparer)
    {
      return source.ToHashSet<T>(comparer).SetEquals(sequence);
    }

    /// <summary>
    ///  Выполнить действие для всех элементов последовательности
    /// </summary>
    /// <param name="enumeration"></param>
    /// <param name="action"></param>
    /// <typeparam name="T"></typeparam>
    public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
    {
      if (enumeration == null || action == null)
        return;
      foreach (T obj in enumeration)
        action(obj);
    }

    public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T, int> action)
    {
      if (enumeration == null || action == null)
        return;
      enumeration.Select<T, int>((Func<T, int, int>) ((item, i) =>
      {
        action(item, i);
        return 0;
      })).FirstOrDefault<int>((Func<int, bool>) (i => i > 0));
    }

    /// <summary>Добавить в коллекцию элементы последовательности</summary>
    /// <param name="collection">Последовательность</param>
    /// <param name="source"></param>
    /// <typeparam name="T"></typeparam>
    public static void AddSequense<T>(this ICollection<T> collection, IEnumerable<T> source)
    {
      foreach (T obj in source)
        collection.Add(obj);
    }

    /// <summary>
    /// Очищает текущую коллекцию и заполняет её элементами другой коллекции
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="collection">Текущая коллекция</param>
    /// <param name="source">Элементы, которые будут добавлены</param>
    public static void AssignAll<T>(this ICollection<T> collection, IEnumerable<T> source)
    {
      collection.Clear();
      collection.AddRange<T>(source);
    }

    /// <summary>
    /// Получить элементы последовательности с указанного элемента до указанного
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="source"></param>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <returns></returns>
    public static IEnumerable<T> TakeFromTo<T>(this IEnumerable<T> source, int from, int to)
    {
      Contract.CheckArgument(from >= 1, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1318053726));
      Contract.CheckArgument(to >= from, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643523215));
      return source.Skip<T>(from - 1).Take<T>(to - from + 1);
    }

    /// <summary>
    /// Получить элементы последовательности с указанного элемента до указанного
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="source"></param>
    /// <param name="skip"></param>
    /// <param name="length"></param>
    /// <returns></returns>
    public static IEnumerable<T> Take<T>(this IEnumerable<T> source, int skip, int length)
    {
      Contract.CheckArgument(skip >= 0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398924292));
      Contract.CheckArgument(length >= 0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106256526));
      return source.Skip<T>(skip).Take<T>(length);
    }

    /// <summary>
    ///  Агрегировать последовательность функцией двух аргументов
    /// </summary>
    /// <param name="source"></param>
    /// <param name="seed"></param>
    /// <param name="func"></param>
    /// <typeparam name="RT"></typeparam>
    /// <typeparam name="ST"></typeparam>
    /// <returns></returns>
    public static IEnumerable<RT> AggregateSequense<RT, ST>(
      this IEnumerable<ST> source,
      RT seed,
      Func<RT, ST, RT> func)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<RT>) new CollectionExtensions.\u003CAggregateSequense\u003Ed__19<RT, ST>(-2)
      {
        \u003C\u003E3__source = source,
        \u003C\u003E3__seed = seed,
        \u003C\u003E3__func = func
      };
    }

    /// <summary>
    /// Создать словарь с типами, опрелделенными вырадениями в аргуметах
    /// С помощью этого метода пожно создавать словари с анонимными методами
    /// </summary>
    /// <typeparam name="TK"></typeparam>
    /// <typeparam name="TV"></typeparam>
    /// <param name="ketSample"></param>
    /// <param name="valueSample"></param>
    /// <returns></returns>
    public static Dictionary<TK, TV> CreateDictionary<TK, TV>(TK ketSample, TV valueSample) => new Dictionary<TK, TV>();

    /// <summary>
    /// Синхронизировать содержимое коллекции из последовательности: лишние удалить, недостаюшие добавить.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="target"></param>
    /// <param name="source"></param>
    /// <param name="compare"></param>
    public static void SyncFrom<T>(
      this ICollection<T> target,
      IEnumerable<T> source,
      Func<T, T, bool> compare,
      Func<T, bool> skipRemove = null,
      Action<T> onRemove = null)
    {
      List<T> list1 = target.ToList<T>();
      List<T> list2 = source.ToList<T>();
      foreach (T obj in list2)
      {
        T v = obj;
        if (!target.Any<T>((Func<T, bool>) (t => compare(t, v))))
          target.Add(v);
      }
      foreach (T obj in list1)
      {
        T v = obj;
        if (!list2.Any<T>((Func<T, bool>) (t => compare(t, v))) && (skipRemove == null || !skipRemove(v)))
        {
          target.Remove(v);
          if (onRemove != null)
            onRemove(v);
        }
      }
    }

    /// <summary>
    /// Синхронизировать содержимое коллекции из последовательности: лишние удалить, недостаюшие добавить.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="target"></param>
    /// <param name="source"></param>
    public static void SyncFrom<T>(this ICollection<T> target, IEnumerable<T> source) => target.SyncFrom<T>(source, (Func<T, T, bool>) ((v1, v2) => object.Equals((object) v1, (object) v2)));

    /// <summary>
    /// Добавить элемент в коллекцию если он не был добавлен ранее
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="collection"></param>
    /// <param name="item"></param>
    public static void AddIfNotContains<T>(this ICollection<T> collection, T item)
    {
      if (collection.Contains(item))
        return;
      collection.Add(item);
    }

    /// <summary>
    /// Добавить элемент в справочник, если он не был добалвен ранее по ключу
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="dictionary"></param>
    /// <param name="item"></param>
    public static void AddIfNotContainsKey<TKey, TValue>(
      this IDictionary<TKey, TValue> dictionary,
      KeyValuePair<TKey, TValue> item)
    {
      if (dictionary.ContainsKey(item.Key))
        return;
      dictionary.Add(item);
    }

    /// <summary>
    /// Добавить элемент в справочник, если он не был добалвен ранее по ключу
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="dictionary"></param>
    /// <param name="key"></param>
    /// <param name="value"></param>
    public static void AddIfNotContainsKey<TKey, TValue>(
      this IDictionary<TKey, TValue> dictionary,
      TKey key,
      TValue value)
    {
      if (dictionary.ContainsKey(key))
        return;
      dictionary.Add(key, value);
    }

    /// <summary>
    /// Добавить элемент в справочник, если он не был добалвен ранее по ключу
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="dictionary"></param>
    /// <param name="key"></param>
    /// <param name="value"></param>
    public static TValue AddIfNotContainsKey<TKey, TValue>(
      this IDictionary<TKey, TValue> dictionary,
      TKey key,
      Func<TKey, TValue> value)
    {
      TValue obj;
      if (!dictionary.TryGetValue(key, out obj))
      {
        obj = value(key);
        dictionary.Add(key, obj);
      }
      return obj;
    }

    /// <summary>
    /// Получить значение из словаря, если нет, то вернуть значение по умолчанию
    /// </summary>
    /// <typeparam name="TKey">Тип ключа</typeparam>
    /// <typeparam name="TValue">Тип значения</typeparam>
    /// <param name="dictionary">Словарь</param>
    /// <param name="key">Ключ</param>
    /// <param name="defaultValue">Значение по умолчанию</param>
    /// <returns>Значение</returns>
    public static TValue GetValueOrDefault<TKey, TValue>(
      this IDictionary<TKey, TValue> dictionary,
      TKey key,
      TValue defaultValue)
    {
      TValue obj;
      return !dictionary.TryGetValue(key, out obj) ? defaultValue : obj;
    }

    /// <summary>развернить объект в список (развертка)</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="first"></param>
    /// <param name="next"></param>
    /// <param name="whileCondirion"></param>
    /// <returns></returns>
    public static IEnumerable<T> GenerateSequense<T>(
      this T first,
      Func<T, T> next,
      Func<T, bool> whileCondirion)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<T>) new CollectionExtensions.\u003CGenerateSequense\u003Ed__28<T>(-2)
      {
        \u003C\u003E3__first = first,
        \u003C\u003E3__next = next,
        \u003C\u003E3__whileCondirion = whileCondirion
      };
    }

    /// <summary>
    ///  Объединяет две последовательности, используя указанную функцию селектора.
    /// http://blogs.msdn.com/ericlippert/archive/2009/05/07/zip-me-up.aspx
    /// </summary>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TSecond"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="first"></param>
    /// <param name="second"></param>
    /// <param name="resultSelector"></param>
    /// <returns></returns>
    public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(
      this IEnumerable<TFirst> first,
      IEnumerable<TSecond> second,
      Func<TFirst, TSecond, TResult> resultSelector)
    {
      if (first == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306190452));
      if (second == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1322827500));
      if (resultSelector == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173878959));
      return CollectionExtensions.ZipIterator<TFirst, TSecond, TResult>(first, second, resultSelector);
    }

    private static IEnumerable<TResult> ZipIterator<TFirst, TSecond, TResult>(
      IEnumerable<TFirst> first,
      IEnumerable<TSecond> second,
      Func<TFirst, TSecond, TResult> resultSelector)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<TResult>) new CollectionExtensions.\u003CZipIterator\u003Ed__30<TFirst, TSecond, TResult>(-2)
      {
        \u003C\u003E3__first = first,
        \u003C\u003E3__second = second,
        \u003C\u003E3__resultSelector = resultSelector
      };
    }

    /// <summary>Обход дерева в глубину</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="head"></param>
    /// <param name="childrenFunc"></param>
    /// <returns></returns>
    public static IEnumerable<T> AsDepthFirstEnumerable<T>(
      this T head,
      Func<T, IEnumerable<T>> childrenFunc)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<T>) new CollectionExtensions.\u003CAsDepthFirstEnumerable\u003Ed__31<T>(-2)
      {
        \u003C\u003E3__head = head,
        \u003C\u003E3__childrenFunc = childrenFunc
      };
    }

    /// <summary>Обход дерева в ширину</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="head"></param>
    /// <param name="childrenFunc"></param>
    /// <returns></returns>
    public static IEnumerable<T> AsBreadthFirstEnumerable<T>(
      this T head,
      Func<T, IEnumerable<T>> childrenFunc)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<T>) new CollectionExtensions.\u003CAsBreadthFirstEnumerable\u003Ed__32<T>(-2)
      {
        \u003C\u003E3__head = head,
        \u003C\u003E3__childrenFunc = childrenFunc
      };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="source"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static bool IsSubsetOf<T>(this IEnumerable<T> source, IEnumerable<T> target) => !source.Except<T>(target).Any<T>();

    /// <summary>Сравнить два буфера</summary>
    /// <param name="b1">Первый буфер</param>
    /// <param name="b2">Второй буфер</param>
    /// <returns><c>true</c> если буферы эквивалентны</returns>
    public static bool ByteArrayCompare(byte[] b1, byte[] b2) => CollectionExtensions.t2h92DGHgqKBvq02gGJS((object) b1, (object) b2);

    /// <summary>Развернуть объект в список</summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <param name="first">Первое значение</param>
    /// <param name="next">Функция вычисления следующего значения</param>
    /// <param name="whileCondition">Условие</param>
    /// <returns></returns>
    public static IEnumerable<T> Unfold<T>(T first, Func<T, T> next, Func<T, bool> whileCondition) => (IEnumerable<T>) new CollectionExtensions.\u003CUnfold\u003Ed__35<T>(-2)
    {
      \u003C\u003E3__first = first,
      \u003C\u003E3__next = next,
      \u003C\u003E3__whileCondition = whileCondition
    };

    /// <summary>
    /// Сгенерировать из последовательности строку вида [элемент1, элемнет2, ...]
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="source"></param>
    /// <returns></returns>
    public static string AsText<T>(this IEnumerable<T> source) where T : class => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812020052) + string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539366989), source.Select<T, string>((Func<T, string>) (s => (object) s != null ? s.ToString() : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822606248))).ToArray<string>()) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397228592);

    /// <summary>
    /// Break a list of items into chunks of a specific size
    /// http://stackoverflow.com/questions/419019/split-list-into-sublists-with-linq/6362642#6362642
    /// </summary>
    public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> source, int chunksize) => (IEnumerable<IEnumerable<T>>) new CollectionExtensions.\u003CChunk\u003Ed__37<T>(-2)
    {
      \u003C\u003E3__source = source,
      \u003C\u003E3__chunksize = chunksize
    };

    public static IEnumerable<T> Distinct<T>(
      this IEnumerable<T> items,
      Func<T, T, bool> equals,
      Func<T, int> hashCode)
    {
      return items.Distinct<T>((IEqualityComparer<T>) new CollectionExtensions.DelegateComparer<T>(equals, hashCode));
    }

    public static IEnumerable<T> Distinct<T>(this IEnumerable<T> items, Func<T, T, bool> equals) => items.Distinct<T>((IEqualityComparer<T>) new CollectionExtensions.DelegateComparer<T>(equals, (Func<T, int>) null));

    /// <summary>
    /// Возвращает различающиеся элементы последовательности, где "различимость" определяется при помощи проекции.
    /// </summary>
    /// <typeparam name="TSource">Тип элементов <paramref name="source" />.</typeparam>
    /// <typeparam name="TKey">Тип результирующего элемента проекции <paramref name="selector" />.</typeparam>
    /// <param name="source">Последовательность, из которой требуется удалить дубликаты элементов.</param>
    /// <param name="selector">Проекция для определения "отличимости".</param>
    /// <returns><see cref="T:System.Collections.Generic.IEnumerable`1" />, содержащая различающиеся элементы из исходной последовательности.</returns>
    public static IEnumerable<TSource> Distinct<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> selector)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<TSource>) new CollectionExtensions.\u003CDistinct\u003Ed__41<TSource, TKey>(-2)
      {
        \u003C\u003E3__source = source,
        \u003C\u003E3__selector = selector
      };
    }

    public static string ToCommaSeparatedString<T>(this IEnumerable<T> collection) => collection.ToSeparatedString<T>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606641172));

    public static string ToSeparatedString<T>(this IEnumerable<T> collection, string separator) => string.Join(separator, collection.Select<T, string>((Func<T, string>) (el => el.ToString())).ToArray<string>());

    /// <summary>
    /// Перевести коллекцию в строку значений с разделителем ',' (запятая) и
    /// ограничителем значений '"' (двойная кавычка)
    /// </summary>
    /// <typeparam name="T">Тип коллекции</typeparam>
    /// <param name="collection">Коллекция</param>
    /// <returns>Строка значений коллекции</returns>
    public static string ToCommaSeparatedQuotedString<T>(this IEnumerable<T> collection) => collection.ToSeparatedQuotedString<T>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61179679));

    /// <summary>
    /// Перевести коллекцию в строку значений с указанными разделителем и ограничителем значений
    /// </summary>
    /// <remarks>
    /// Символ ограничителя значений экранируется с помощью метода <see cref="M:EleWise.ELMA.Extensions.StringExtensions.Escape(System.String,System.Char)" />,
    /// если встречается в строковом представлении значения.
    /// </remarks>
    /// <typeparam name="T">Тип элемента коллекции</typeparam>
    /// <param name="collection">Коллекция</param>
    /// <param name="separator">Разделитель</param>
    /// <param name="quoteChar">Ограничитель значений</param>
    /// <returns>Строка значений коллекции</returns>
    public static string ToSeparatedQuotedString<T>(
      this IEnumerable<T> collection,
      string separator,
      char quoteChar = '"')
    {
      return string.Join(separator, collection.Select<T, string>((Func<T, string>) (el => (object) el != null ? el.ToString().Escape(quoteChar).Quote(quoteChar) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951510784))));
    }

    /// <summary>Добавить коллекцию в коллекцию</summary>
    /// <remarks>Перенесено из NuGet в неизменном виде</remarks>
    /// <typeparam name="T">Тип элемента коллекции</typeparam>
    /// <param name="collection">Исходная коллекция</param>
    /// <param name="items">Коллекция с добавляемыми элементами</param>
    public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> items)
    {
      foreach (T obj in items)
        collection.Add(obj);
    }

    /// <summary>Добавить коллекцию в коллекцию</summary>
    /// <remarks>
    /// Используется в конфигурационных скриптах: в старницах и портлетах, которые были обновлены
    /// с первого на второй рантайм
    /// </remarks>
    /// <typeparam name="T">Тип элемента коллекции</typeparam>
    /// <param name="collection">Исходная коллекция</param>
    /// <param name="items">Коллекция с добавляемыми элементами</param>
    public static void AddAll<T>(this ICollection<T> collection, IEnumerable<T> items) => collection.AddRange<T>(items);

    /// <summary>
    /// Удалить из коллекции элементы, удовлетворяющие условию.
    /// </summary>
    /// <remarks>Перенесено из NuGet в неизменном виде</remarks>
    /// <typeparam name="T">Тип элемента коллекции</typeparam>
    /// <param name="collection">Исходная коллекция</param>
    /// <param name="match">Функция проверки условия</param>
    /// <returns>Число удалённых элементов</returns>
    public static int RemoveAll<T>(this ICollection<T> collection, Func<T, bool> match)
    {
      IList<T> list = (IList<T>) collection.Where<T>(match).ToList<T>();
      foreach (T obj in (IEnumerable<T>) list)
        collection.Remove(obj);
      return list.Count;
    }

    /// <summary>Есть ли в коллекции элементы</summary>
    /// <typeparam name="T">Тип элемента коллекции</typeparam>
    /// <param name="collection">Исходная коллекция</param>
    /// <returns><c>true</c>, если коллекция не <c>null</c> и в ней есть хотя бы один элемент</returns>
    public static bool HasItems<T>(this ICollection<T> collection) => collection != null && collection.Count > 0;

    /// <summary>Есть ли в коллекции элементы, удовлетворяющие условию</summary>
    /// <typeparam name="T">Тип элемента коллекции</typeparam>
    /// <param name="collection">Исходная коллекция</param>
    /// <param name="predicate">Функция проверки условия</param>
    /// <returns><c>true</c>, если коллекция не <c>null</c> и в ней есть хотя бы один элемент удовлетворяющий условию</returns>
    public static bool HasItems<T>(this ICollection<T> collection, Func<T, bool> predicate) => collection != null && collection.Any<T>(predicate);

    internal static bool t2h92DGHgqKBvq02gGJS([In] object obj0, [In] object obj1) => ByteArrayExtensions.ByteArrayCompare((byte[]) obj0, (byte[]) obj1);

    internal static bool SXaJLPGHlBKwF7xDi4xX() => CollectionExtensions.BMfMIpGHd07uarNrc28o == null;

    internal static CollectionExtensions Kd3JA7GHrwFCS4ESHRdt() => CollectionExtensions.BMfMIpGHd07uarNrc28o;

    private class ComparableComparer<T> : IComparer<T> where T : IComparable
    {
      public static readonly CollectionExtensions.ComparableComparer<T> Instance;
      private static object yVVDST8Gl1pFotkivd7F;

      public int Compare(T x, T y) => x.CompareTo((object) y);

      public ComparableComparer()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
          num = 0;
        switch (num)
        {
        }
      }

      static ComparableComparer()
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              CollectionExtensions.ComparableComparer<T>.Instance = new CollectionExtensions.ComparableComparer<T>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            case 2:
              TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }

      internal static bool l38BUB8GrviLTEeXU4ls() => CollectionExtensions.ComparableComparer<T>.yVVDST8Gl1pFotkivd7F == null;

      internal static object msOfYt8Gg7xBQP1lt1dk() => CollectionExtensions.ComparableComparer<T>.yVVDST8Gl1pFotkivd7F;
    }

    public class DelegateComparer<T> : IEqualityComparer<T>
    {
      private readonly Func<T, T, bool> _equals;
      private readonly Func<T, int> _hashCode;

      public DelegateComparer(Func<T, T, bool> equals, Func<T, int> hashCode)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this._equals = equals;
        this._hashCode = hashCode;
      }

      public bool Equals(T x, T y) => this._equals(x, y);

      public int GetHashCode(T obj) => this._hashCode != null ? this._hashCode(obj) : obj.GetHashCode();
    }
  }
}
