// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.ICacheKeyFormatter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Cache
{
  /// <summary>
  /// Точка расширения для дополнительного форматирования ключа кэша, формируемого при использовании атрибутов <see cref="T:EleWise.ELMA.Cache.Attributes.CacheAttribute" /> и <see cref="T:EleWise.ELMA.Cache.Attributes.ContextCacheAttribute" />
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface ICacheKeyFormatter
  {
    /// <summary>Форматировать ключ для представления значения в кэше</summary>
    /// <param name="cacheKey">Текущий сформированный ключ</param>
    /// <param name="invocation">Параметры исполнения метода</param>
    /// <returns>Отформатированный ключ</returns>
    string Format(string cacheKey, InvocationParameters invocation);
  }
}
