// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.IPermissionsDelegate
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using System;

namespace EleWise.ELMA.Security
{
  /// <summary>
  /// Для каждого типа, экемпляры которого соотносятся с привилегиями реализуется такой интерфейс.
  /// В реализации интерфейса закладывается логика проверки привилегии.
  /// </summary>
  /// <example>
  /// Тип: Document
  /// Привилегия: Edit
  /// </example>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-813.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface IPermissionsDelegate
  {
    /// <summary>Проверить тип на соответсвие</summary>
    /// <param name="type">Тип</param>
    /// <param name="permission">Привилегия</param>
    /// <returns><c>true</c>, если тип соответствует указанной привилегии</returns>
    bool CanCheckPermissions(Type type, Permission permission);

    /// <summary>Проверить наличие привилегии</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="permission">Привилегия</param>
    /// <param name="target">Целевой объект</param>
    /// <param name="skipAdmin">Пропустить проверку Административной привилегии</param>
    /// <returns><c>true</c>, если привилегия существует</returns>
    bool HasPermission(IUser user, Permission permission, object target, bool skipAdmin = false);
  }
}
