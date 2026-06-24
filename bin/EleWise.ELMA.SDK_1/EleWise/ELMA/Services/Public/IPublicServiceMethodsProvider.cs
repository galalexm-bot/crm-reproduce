// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Public.IPublicServiceMethodsProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using System.Collections.Generic;

namespace EleWise.ELMA.Services.Public
{
  /// <summary>
  /// Точка расширения, позволяющая предоставить публичные методы для публичных сервисов
  /// </summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-795.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  [ExtensionPoint(ComponentType.Server)]
  public interface IPublicServiceMethodsProvider
  {
    /// <summary>Получить список публичных методов</summary>
    /// <returns>Список публичных методов</returns>
    IEnumerable<IPublicServiceMethod> GetMethods();
  }
}
