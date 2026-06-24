// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Common.Models.PasswordInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Common.Models
{
  /// <summary>Информация о пароле</summary>
  [XmlRoot("Password")]
  [Component]
  [Serializable]
  public class PasswordInfo : IXsiType, ICloneable
  {
    [NonSerialized]
    private static IEnumerable<IPasswordResolver> resolvers;
    [NonSerialized]
    private IPasswordResolver passwordResolver;
    private Guid passwordType;
    internal static PasswordInfo N3caOsfS8CcaKsxgatuw;

    [XmlIgnore]
    private IEnumerable<IPasswordResolver> Resolvers => PasswordInfo.resolvers ?? (PasswordInfo.resolvers = Locator.GetServiceNotNull<IEnumerable<IPasswordResolver>>());

    /// <summary>Функция сравнения</summary>
    /// <param name="other">Контейнер хэша</param>
    /// <returns></returns>
    protected bool Equals(PasswordInfo other)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (other == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
              continue;
            }
            if (this == other)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 1 : 2;
              continue;
            }
            goto label_8;
          case 2:
            goto label_7;
          default:
            goto label_4;
        }
      }
label_4:
      return false;
label_7:
      return true;
label_8:
      return PasswordInfo.nROdsYfSIvMgQ2j58dMZ((object) other.Hash, (object) this.Hash);
    }

    /// <summary>Инициализация алгоритма вычисления пароля</summary>
    /// <param name="passwordType">Тип пароля</param>
    internal void InitPasswordResolver(Guid? passwordType)
    {
      if (this.passwordResolver != null)
        return;
      if (passwordType.HasValue)
        this.passwordType = passwordType.Value;
      if (this.passwordResolver != null)
        return;
      this.passwordResolver = this.Resolvers.FirstOrDefault<IPasswordResolver>((Func<IPasswordResolver, bool>) (r => PasswordInfo.W4UWy4fSk9TQv0xngBdb(PasswordInfo.Cd698cfST7coYy8gpOsy((object) r), this.passwordType)));
    }

    /// <summary>Ctor</summary>
    /// <param name="password">Пароль</param>
    /// <param name="passwordType">Тип пароля</param>
    internal PasswordInfo(string password, Guid passwordType)
    {
      PasswordInfo.UB9gQwfSVWRij1t8iZ3U();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Hash = (string) PasswordInfo.eYli0MfSiQRmyj8WpKLi((object) this.passwordResolver, (object) password, (object) this.Salt);
            num = 2;
            continue;
          case 2:
            goto label_5;
          case 3:
            if (this.passwordResolver == null)
            {
              num = 4;
              continue;
            }
            break;
          case 4:
            goto label_2;
          case 5:
            this.InitPasswordResolver(new Guid?(passwordType));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 3 : 0;
            continue;
        }
        this.Salt = (string) PasswordInfo.GLXX8AfSSSpXJ9aD5lgh((object) this.passwordResolver);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 1;
      }
label_5:
      return;
label_2:;
    }

    /// <summary>Ctor</summary>
    /// <param name="hash">Хэш (зашифрованный пароль)</param>
    /// <param name="salt">Соль</param>
    /// <param name="passwordType">Тип пароля</param>
    internal PasswordInfo(string hash, string salt, Guid passwordType)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.InitPasswordResolver(new Guid?(passwordType));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          case 2:
            this.passwordType = passwordType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 1;
            continue;
          case 3:
            this.Salt = salt;
            num = 2;
            continue;
          case 4:
            this.Hash = hash;
            num = 3;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    /// <summary>Проверка пароля</summary>
    /// <param name="password">Пароль</param>
    /// <returns></returns>
    internal bool Check(string password)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (this.passwordResolver != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return false;
label_5:
      return PasswordInfo.KjvJpefSRNmSKIe7IlOr((object) this.passwordResolver, (object) this.Hash, (object) this.Salt, (object) password);
    }

    /// <summary>Получить пароль, если не хэш</summary>
    /// <returns></returns>
    internal string GetPassword()
    {
      int num = 1;
      IPasswordResolver passwordResolver;
      while (true)
      {
        switch (num)
        {
          case 1:
            passwordResolver = this.passwordResolver;
            if (passwordResolver == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) null;
label_5:
      return (string) PasswordInfo.CRDku4fSqgUAB9jRIAve((object) passwordResolver, (object) this.Hash, (object) this.Salt);
    }

    /// <summary>Ctor</summary>
    public PasswordInfo()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Клонирование</summary>
    /// <returns></returns>
    public object Clone() => (object) new PasswordInfo(this.Hash, this.Salt, this.passwordType);

    /// <summary>Хэш</summary>
    public string Hash
    {
      get => this.\u003CHash\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CHash\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Соль</summary>
    public string Salt
    {
      get => this.\u003CSalt\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CSalt\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Есть ли пароль внутри</summary>
    /// <returns></returns>
    public bool IsEmpty() => string.IsNullOrEmpty(this.Hash);

    /// <summary>Функция сравнения</summary>
    /// <param name="obj">Объект для сравнения</param>
    /// <returns></returns>
    public override bool Equals(object obj)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this == obj)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
              continue;
            }
            // ISSUE: type reference
            if (PasswordInfo.NVRsiXfSX5ils1yY4rg2(obj.GetType(), PasswordInfo.GgxF3wfSKSYBmIIDqtP4(__typeref (PasswordInfo))))
            {
              num = 3;
              continue;
            }
            goto label_6;
          case 2:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          case 3:
            goto label_5;
          case 4:
            goto label_2;
          default:
            goto label_9;
        }
      }
label_2:
      return false;
label_5:
      return false;
label_6:
      return this.Equals((PasswordInfo) obj);
label_9:
      return true;
    }

    /// <summary>Считаем код хэша</summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
      int num1 = 1;
      string hash;
      while (true)
      {
        switch (num1)
        {
          case 1:
            hash = this.Hash;
            if (hash == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_5;
        }
      }
label_5:
      string str = string.Empty;
label_6:
      int num2 = str.GetHashCode() * 397;
      string salt = this.Salt;
      int hashCode = (salt == null ? (object) string.Empty : (object) salt).GetHashCode();
      return num2 ^ hashCode;
label_2:
      str = hash;
      goto label_6;
    }

    internal static bool nROdsYfSIvMgQ2j58dMZ([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool BMNBdtfSZsuCFGD3s36l() => PasswordInfo.N3caOsfS8CcaKsxgatuw == null;

    internal static PasswordInfo IuA8a3fSueQUxC5ylx3t() => PasswordInfo.N3caOsfS8CcaKsxgatuw;

    internal static void UB9gQwfSVWRij1t8iZ3U() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object GLXX8AfSSSpXJ9aD5lgh([In] object obj0) => (object) ((IPasswordResolver) obj0).GenerateSalt();

    internal static object eYli0MfSiQRmyj8WpKLi([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IPasswordResolver) obj0).Encrypt((string) obj1, (string) obj2);

    internal static bool KjvJpefSRNmSKIe7IlOr([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((IPasswordResolver) obj0).Check((string) obj1, (string) obj2, (string) obj3);

    internal static object CRDku4fSqgUAB9jRIAve([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IPasswordResolver) obj0).Decrypt((string) obj1, (string) obj2);

    internal static Type GgxF3wfSKSYBmIIDqtP4([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool NVRsiXfSX5ils1yY4rg2([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static Guid Cd698cfST7coYy8gpOsy([In] object obj0) => ((IPasswordResolver) obj0).Uid;

    internal static bool W4UWy4fSk9TQv0xngBdb([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;
  }
}
