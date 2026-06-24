// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.DictionaryExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Расширения для справочников</summary>
  public static class DictionaryExtensions
  {
    /// <summary>
    /// Adds a key/value pair to the <paramref name="dictionary" />
    /// if the key does not already exist, or updates a key/value pair in <paramref name="dictionary" />
    /// by using the specified function if the key already exists.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">Original dictionary</param>
    /// <param name="key">The key to be added or whose value should be updated</param>
    /// <param name="addValue">The value to be added for an absent key</param>
    /// <param name="updateValueFactory">The function used to generate a new value for an existing key based on the key's existing value</param>
    /// <returns>The new value for the key. This will be either be addValue (if the key was absent) or the result of updateValueFactory (if the key was present).</returns>
    public static TValue AddOrUpdate<TKey, TValue>(
      this IDictionary<TKey, TValue> dictionary,
      TKey key,
      TValue addValue,
      Func<TKey, TValue, TValue> updateValueFactory)
    {
      switch (dictionary)
      {
        case ConcurrentDictionary<TKey, TValue> concurrentDictionary1:
          return concurrentDictionary1.AddOrUpdate(key, addValue, updateValueFactory);
        case PublishCacheContext.IConcurrentDictionary<TKey, TValue> concurrentDictionary2:
          return concurrentDictionary2.AddOrUpdate(key, addValue, updateValueFactory);
        default:
          TValue obj1;
          TValue obj2 = !dictionary.TryGetValue(key, out obj1) ? addValue : updateValueFactory(key, obj1);
          return dictionary[key] = obj2;
      }
    }

    /// <summary>
    /// Uses the specified functions to add a key/value pair to the <paramref name="dictionary" />
    /// if the key does not already exist, or to update a key/value pair in the <paramref name="dictionary" />
    /// if the key already exists.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">Original dictionary</param>
    /// <param name="key">The key to be added or whose value should be updated</param>
    /// <param name="addValueFactory">The function used to generate a value for an absent key</param>
    /// <param name="updateValueFactory">The function used to generate a new value for an existing key based on the key's existing value</param>
    /// <returns>The new value for the key. This will be either be the result of addValueFactory (if the key was absent) or the result of updateValueFactory (if the key was present).</returns>
    public static TValue AddOrUpdate<TKey, TValue>(
      this IDictionary<TKey, TValue> dictionary,
      TKey key,
      Func<TKey, TValue> addValueFactory,
      Func<TKey, TValue, TValue> updateValueFactory)
    {
      switch (dictionary)
      {
        case ConcurrentDictionary<TKey, TValue> concurrentDictionary1:
          return concurrentDictionary1.AddOrUpdate(key, addValueFactory, updateValueFactory);
        case PublishCacheContext.IConcurrentDictionary<TKey, TValue> concurrentDictionary2:
          return concurrentDictionary2.AddOrUpdate(key, addValueFactory, updateValueFactory);
        default:
          TValue obj1;
          TValue obj2 = !dictionary.TryGetValue(key, out obj1) ? addValueFactory(key) : updateValueFactory(key, obj1);
          return dictionary[key] = obj2;
      }
    }

    /// <summary>
    /// Uses the specified functions and argument to add a key/value pair to the <paramref name="dictionary" />
    /// if the key does not already exist, or to update a key/value pair in the <paramref name="dictionary" />
    /// if the key already exists.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <typeparam name="TArg">The type of an argument to pass into addValueFactory and updateValueFactory.</typeparam>
    /// <param name="dictionary">Original dictionary</param>
    /// <param name="key">The key to be added or whose value should be updated.</param>
    /// <param name="addValueFactory">The function used to generate a value for an absent key.</param>
    /// <param name="updateValueFactory">The function used to generate a new value for an existing key based on the key's existing value.</param>
    /// <param name="factoryArgument">An argument to pass into addValueFactory and updateValueFactory.</param>
    /// <returns>The new value for the key. This will be either be the result of addValueFactory (if the key was absent) or the result of updateValueFactory (if the key was present).</returns>
    public static TValue AddOrUpdate<TKey, TValue, TArg>(
      this IDictionary<TKey, TValue> dictionary,
      TKey key,
      Func<TKey, TArg, TValue> addValueFactory,
      Func<TKey, TValue, TArg, TValue> updateValueFactory,
      TArg factoryArgument)
    {
      switch (dictionary)
      {
        case ConcurrentDictionary<TKey, TValue> concurrentDictionary1:
          return concurrentDictionary1.AddOrUpdate<TArg>(key, addValueFactory, updateValueFactory, factoryArgument);
        case PublishCacheContext.IConcurrentDictionary<TKey, TValue> concurrentDictionary2:
          return concurrentDictionary2.AddOrUpdate<TArg>(key, addValueFactory, updateValueFactory, factoryArgument);
        default:
          TValue obj1;
          TValue obj2 = !dictionary.TryGetValue(key, out obj1) ? addValueFactory(key, factoryArgument) : updateValueFactory(key, obj1, factoryArgument);
          return dictionary[key] = obj2;
      }
    }

    /// <summary>
    /// Adds a key/value pair to the <paramref name="dictionary" />
    /// if the key does not already exist. Returns the new value, or the existing value
    /// if the key exists.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">Original dictionary</param>
    /// <param name="key">The key of the element to add.</param>
    /// <param name="newValue">The value to be added, if the key does not already exist.</param>
    /// <returns>The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value if the key was not in the dictionary.</returns>
    public static TValue GetOrAdd<TKey, TValue>(
      this IDictionary<TKey, TValue> dictionary,
      TKey key,
      TValue newValue)
    {
      if (dictionary is ConcurrentDictionary<TKey, TValue> concurrentDictionary1)
        return concurrentDictionary1.GetOrAdd(key, newValue);
      if (dictionary is PublishCacheContext.IConcurrentDictionary<TKey, TValue> concurrentDictionary2)
        return concurrentDictionary2.GetOrAdd(key, newValue);
      TValue orAdd;
      if (!dictionary.TryGetValue(key, out orAdd))
        dictionary[key] = orAdd = newValue;
      return orAdd;
    }

    /// <summary>
    /// Adds a key/value pair to the <paramref name="dictionary" />
    /// by using the specified function if the key does not already exist. Returns the
    /// new value, or the existing value if the key exists.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">Original dictionary</param>
    /// <param name="key">The key of the element to add.</param>
    /// <param name="valueFactory">The function used to generate a value for the key.</param>
    /// <returns>The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value if the key was not in the dictionary.</returns>
    public static TValue GetOrAdd<TKey, TValue>(
      this IDictionary<TKey, TValue> dictionary,
      TKey key,
      Func<TKey, TValue> valueFactory)
    {
      if (dictionary is ConcurrentDictionary<TKey, TValue> concurrentDictionary1)
        return concurrentDictionary1.GetOrAdd(key, valueFactory);
      if (dictionary is PublishCacheContext.IConcurrentDictionary<TKey, TValue> concurrentDictionary2)
        return concurrentDictionary2.GetOrAdd(key, valueFactory);
      TValue orAdd;
      if (!dictionary.TryGetValue(key, out orAdd))
        dictionary[key] = orAdd = valueFactory(key);
      return orAdd;
    }

    /// <summary>
    /// Adds a key/value pair to the <paramref name="dictionary" />
    /// by using the specified function and an argument if the key does not already exist,
    /// or returns the existing value if the key exists.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <typeparam name="TArg">The type of an argument to pass into valueFactory.</typeparam>
    /// <param name="dictionary">Original dictionary</param>
    /// <param name="key">The key of the element to add.</param>
    /// <param name="valueFactory">The function used to generate a value for the key.</param>
    /// <param name="factoryArgument">An argument value to pass into valueFactory.</param>
    /// <returns>The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value if the key was not in the dictionary.</returns>
    public static TValue GetOrAdd<TKey, TValue, TArg>(
      this IDictionary<TKey, TValue> dictionary,
      TKey key,
      Func<TKey, TArg, TValue> valueFactory,
      TArg factoryArgument)
    {
      if (dictionary is ConcurrentDictionary<TKey, TValue> concurrentDictionary1)
        return concurrentDictionary1.GetOrAdd<TArg>(key, valueFactory, factoryArgument);
      if (dictionary is PublishCacheContext.IConcurrentDictionary<TKey, TValue> concurrentDictionary2)
        return concurrentDictionary2.GetOrAdd<TArg>(key, valueFactory, factoryArgument);
      TValue orAdd;
      if (!dictionary.TryGetValue(key, out orAdd))
        dictionary[key] = orAdd = valueFactory(key, factoryArgument);
      return orAdd;
    }

    /// <summary>
    /// Updates the value associated with key to newValue if the existing value with key is equal to comparisonValue.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
    /// <param name="dictionary">Original dictionary</param>
    /// <param name="key">The key of the value that is compared with comparisonValue and possibly replaced.</param>
    /// <param name="newValue">The value that replaces the value of the element that has the specified key if the comparison results in equality.</param>
    /// <param name="comparisonValue">The value that is compared with the value of the element that has the specified key.</param>
    /// <returns>true if the value with key was equal to comparisonValue and was replaced with newValue; otherwise, false.</returns>
    public static bool TryUpdate<TKey, TValue>(
      this IDictionary<TKey, TValue> dictionary,
      TKey key,
      TValue newValue,
      TValue comparisonValue)
    {
      if (dictionary is ConcurrentDictionary<TKey, TValue> concurrentDictionary1)
        return concurrentDictionary1.TryUpdate(key, newValue, comparisonValue);
      if (dictionary is PublishCacheContext.IConcurrentDictionary<TKey, TValue> concurrentDictionary2)
        return concurrentDictionary2.TryUpdate(key, newValue, comparisonValue);
      TValue obj;
      if (!dictionary.TryGetValue(key, out obj) || (object) comparisonValue != (object) obj && ((object) comparisonValue == null || !comparisonValue.Equals((object) obj)))
        return false;
      dictionary[key] = newValue;
      return true;
    }
  }
}
