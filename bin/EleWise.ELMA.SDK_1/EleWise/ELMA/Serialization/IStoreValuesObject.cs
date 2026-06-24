// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.IStoreValuesObject
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;

namespace EleWise.ELMA.Serialization
{
  /// <summary>Объект, хранящий строковые данные (ключ-значение)</summary>
  public interface IStoreValuesObject
  {
    /// <summary>Получить настройки из объекта</summary>
    /// <returns>Словарь с настройками</returns>
    IDictionary<string, string> GetStorageValues();

    /// <summary>Установить настройки в объект</summary>
    /// <param name="values">Словарь с настройками</param>
    void SetStorageValues(IDictionary<string, string> values);
  }
}
