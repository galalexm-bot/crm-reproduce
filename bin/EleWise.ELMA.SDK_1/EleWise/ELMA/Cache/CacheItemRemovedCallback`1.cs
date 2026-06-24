// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.CacheItemRemovedCallback`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Cache
{
  /// <summary>
  /// Определение метода обратного вызова для уведомления приложений при удалении кэшированного элемента из <see cref="T:EleWise.ELMA.Cache.ICacheService" />.
  /// </summary>
  /// <param name="key">Ключ, удаляемый из кэша.</param>
  /// <param name="value">Элемент <see cref="T:System.Object" />, связанный с ключом, удаляемым из кэша.</param>
  /// <param name="reason">Причина удаления элемента из кэша, указанная перечислением <see cref="T:EleWise.ELMA.Cache.CacheItemRemovedReason" />.</param>
  public delegate void CacheItemRemovedCallback<in T>(
    string key,
    T value,
    CacheItemRemovedReason reason);
}
