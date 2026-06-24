// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Providers.SettingsStoreProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Configuration.Provider;

namespace EleWise.ELMA.Runtime.Providers
{
  /// <summary>Базовай класс для провайдеров работы с настройками</summary>
  public abstract class SettingsStoreProvider : ProviderBase, ISettingsManager
  {
    internal static SettingsStoreProvider sTVwwOWE80o472SovhTn;

    protected SettingsStoreProvider()
    {
      SettingsStoreProvider.bnWprEWEIIGVgbaFQVMb();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Установить значение</summary>
    /// <param name="uid">УИД компонента (например плагин)</param>
    /// <param name="key">Ключ</param>
    /// <param name="value">Значение</param>
    public abstract void SetString(Guid uid, string key, string value);

    /// <summary>Установить значения для компонента</summary>
    /// <param name="uid">УИД компонента (например плагин)</param>
    /// <param name="strings">Словарь значений</param>
    public abstract void SetStrings(Guid uid, IDictionary<string, string> strings);

    /// <summary>Получить значение</summary>
    /// <param name="uid">УИД компонента (например плагин)</param>
    /// <param name="key">Ключ</param>
    /// <returns>Значение</returns>
    public abstract string GetString(Guid uid, string key);

    /// <summary>Получить все значения для компонента</summary>
    /// <param name="uid">УИД компонента (например плагин)</param>
    /// <returns>Значения</returns>
    public abstract IDictionary<string, string> GetAllStrings(Guid uid);

    /// <summary>Удалить значение полностью</summary>
    /// <param name="uid">УИД компонента (например плагин)</param>
    /// <param name="key">Ключ</param>
    public abstract void RemoveString(Guid uid, string key);

    /// <summary>Удалить все значения полностью</summary>
    /// <param name="uid">УИД компонента (например плагин)</param>
    public abstract void RemoveAllStrings(Guid uid);

    internal static void bnWprEWEIIGVgbaFQVMb() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool zcrRQMWEZo0V6QYXYBI0() => SettingsStoreProvider.sTVwwOWE80o472SovhTn == null;

    internal static SettingsStoreProvider OdHl7CWEuQkXxRFq3UVc() => SettingsStoreProvider.sTVwwOWE80o472SovhTn;
  }
}
