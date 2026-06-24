// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Providers.BLOBStoreProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Configuration.Provider;

namespace EleWise.ELMA.Runtime.Providers
{
  /// <summary>
  /// Базовай класс для провайдеров работы с объектами (BLOB)
  /// </summary>
  public abstract class BLOBStoreProvider : ProviderBase, IBLOBDataManager
  {
    private static BLOBStoreProvider OokFnLWGjyTgWDNs45mN;

    protected BLOBStoreProvider()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Установить значение</summary>
    /// <param name="uid">УИД компонента (например плагин)</param>
    /// <param name="key">Ключ</param>
    /// <param name="value">Значение (объект)</param>
    public abstract void SetBLOB<T>(Guid uid, string key, T value);

    /// <summary>Получить значение</summary>
    /// <param name="uid">УИД компонента (например плагин)</param>
    /// <param name="key">Ключ</param>
    /// <returns>Значение (объект)</returns>
    public abstract T GetBLOB<T>(Guid uid, string key);

    /// <summary>Очистить данные</summary>
    /// <param name="uid">УИД компонента (например плагин)</param>
    /// <param name="key">Ключ</param>
    public abstract void RemoveBLOB<T>(Guid uid, string key);

    internal static bool iLsnfMWGYDodnVgdCtbb() => BLOBStoreProvider.OokFnLWGjyTgWDNs45mN == null;

    internal static BLOBStoreProvider Hmb3eKWGLfhQ4Ah6F5Av() => BLOBStoreProvider.OokFnLWGjyTgWDNs45mN;
  }
}
