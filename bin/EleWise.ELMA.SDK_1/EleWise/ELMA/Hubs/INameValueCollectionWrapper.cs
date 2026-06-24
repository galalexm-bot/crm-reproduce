// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Hubs.INameValueCollectionWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections;
using System.Collections.Generic;

namespace EleWise.ELMA.Hubs
{
  /// <summary>Интерфейс коллекции "имя-значение"</summary>
  public interface INameValueCollectionWrapper : 
    IEnumerable<KeyValuePair<string, string>>,
    IEnumerable
  {
    /// <summary>
    /// Получить значение по ключу через оператор индексирования
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    string this[string key] { get; }

    /// <summary>Получить значения по ключу</summary>
    /// <param name="key"></param>
    /// <returns></returns>
    IEnumerable<string> GetValues(string key);

    /// <summary>Получить значение по ключу</summary>
    /// <param name="key"></param>
    /// <returns></returns>
    string Get(string key);
  }
}
