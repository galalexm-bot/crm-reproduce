// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.IUser
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using System;

namespace EleWise.ELMA.Security
{
  /// <summary>Пользователь системы</summary>
  public interface IUser : IIdentified
  {
    /// <summary>Имя пользователя (учетная запись)</summary>
    string UserName { get; }

    /// <summary>Полное имя (Ф.И.О)</summary>
    string FullName { get; }

    /// <summary>Адрес электронной почты</summary>
    string EMail { get; }

    /// <summary>Локаль пользователя</summary>
    string Lang { get; set; }

    /// <summary>Системная ли локаль</summary>
    bool IsSystemLocal { get; set; }

    /// <summary>
    /// Провайдер авторизации. При нулевом значении - используется стандартная авторизация, при ненулевом - используется авторизация LDAP
    /// </summary>
    Guid AuthProviderGuid { get; }
  }
}
