// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IPermissionProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>Интерфейс расширения списка привилегий</summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-813.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [DeveloperApi(DeveloperApiType.Service)]
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  public interface IPermissionProvider
  {
    /// <summary>Получить список привилегий</summary>
    /// <returns></returns>
    IEnumerable<Permission> GetPermissions();

    /// <summary>
    /// Получить информацию о назначении привилегий ролям по умолчанию
    /// </summary>
    /// <returns></returns>
    IEnumerable<PermissionStereotype> GetPermissionStereotypes();

    /// <summary>Локализованные имена привилегий</summary>
    [Obsolete("Используйте SR.M в названиях пермишенов")]
    List<string> LocalizedItemsNames { get; }

    /// <summary>Локализованные описания привилегий</summary>
    [Obsolete("Используйте SR.M в описания пермишенов")]
    List<string> LocalizedItemsDescriptions { get; }

    /// <summary>Локализованные имена категорий</summary>
    [Obsolete("Используйте SR.M в описании категорий")]
    List<string> LocalizedItemsCategories { get; }
  }
}
