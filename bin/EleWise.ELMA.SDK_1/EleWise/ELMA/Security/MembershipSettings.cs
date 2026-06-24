// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.MembershipSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Security
{
  /// <summary>Настройки для сервиса управления учетными записями</summary>
  [Obsolete("Класс будет удален")]
  public class MembershipSettings
  {
    internal static MembershipSettings GBgF7JB56Of6BlfkpfWP;

    /// <summary>
    /// Конструктор, задает значения по умолчанию:
    ///    <see cref="P:EleWise.ELMA.Security.MembershipSettings.EnablePasswordRetrieval" /> = <c>false</c>
    ///    <see cref="P:EleWise.ELMA.Security.MembershipSettings.EnablePasswordReset" /> = <c>true</c>
    ///    <see cref="P:EleWise.ELMA.Security.MembershipSettings.RequiresUniqueEmail" /> = <c>true</c>
    ///    <see cref="P:EleWise.ELMA.Security.MembershipSettings.MaxInvalidPasswordAttempts" /> = <c>5</c>
    ///    <see cref="P:EleWise.ELMA.Security.MembershipSettings.PasswordAttemptWindow" /> = <c>10</c>
    ///    <see cref="P:EleWise.ELMA.Security.MembershipSettings.MinRequiredPasswordLength" /> = <c>3</c>
    ///    <see cref="P:EleWise.ELMA.Security.MembershipSettings.MinRequiredNonAlphanumericCharacters" /> = <c>1</c>
    ///    <see cref="P:EleWise.ELMA.Security.MembershipSettings.PasswordStrengthRegularExpression" /> = <c>""</c>
    /// </summary>
    public MembershipSettings()
    {
      MembershipSettings.CW2MecB57ImORo30krwA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 5;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
        num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.PasswordAttemptWindow = 10;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 2 : 6;
            continue;
          case 2:
            this.RequiresUniqueEmail = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
            continue;
          case 3:
            this.PasswordStrengthRegularExpression = "";
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 7 : 8;
            continue;
          case 4:
            this.EnablePasswordReset = true;
            num = 2;
            continue;
          case 5:
            this.EnablePasswordRetrieval = false;
            num = 4;
            continue;
          case 6:
            this.MinRequiredPasswordLength = 3;
            num = 7;
            continue;
          case 7:
            this.MinRequiredNonAlphanumericCharacters = 1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 3 : 3;
            continue;
          case 8:
            goto label_3;
          default:
            this.MaxInvalidPasswordAttempts = 5;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Разрешить получение своего пароля</summary>
    public bool EnablePasswordRetrieval
    {
      get => this.\u003CEnablePasswordRetrieval\u003Ek__BackingField;
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
              this.\u003CEnablePasswordRetrieval\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
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

    /// <summary>Разрешить изменение пароля</summary>
    public bool EnablePasswordReset
    {
      get => this.\u003CEnablePasswordReset\u003Ek__BackingField;
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
              this.\u003CEnablePasswordReset\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
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

    /// <summary>
    /// Максимальное количество попыток неправильного ввода пароля
    /// </summary>
    public int MaxInvalidPasswordAttempts
    {
      get => this.\u003CMaxInvalidPasswordAttempts\u003Ek__BackingField;
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
              this.\u003CMaxInvalidPasswordAttempts\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
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

    /// <summary>
    /// Интервал в минутах.
    /// Если в течение этого интервала было совершено максимальное количество неправильных попыток авторизации,
    /// учетная запись блокируется.
    /// </summary>
    public int PasswordAttemptWindow
    {
      get => this.\u003CPasswordAttemptWindow\u003Ek__BackingField;
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
              this.\u003CPasswordAttemptWindow\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
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

    /// <summary>Требовать уникального значения почтового адреса</summary>
    public bool RequiresUniqueEmail
    {
      get => this.\u003CRequiresUniqueEmail\u003Ek__BackingField;
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
              this.\u003CRequiresUniqueEmail\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
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

    /// <summary>Минимальная длинна пароля</summary>
    public int MinRequiredPasswordLength
    {
      get => this.\u003CMinRequiredPasswordLength\u003Ek__BackingField;
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
              this.\u003CMinRequiredPasswordLength\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
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

    /// <summary>
    /// Минимальное количество не буквенно-числовых символов в пароле
    /// </summary>
    public int MinRequiredNonAlphanumericCharacters
    {
      get => this.\u003CMinRequiredNonAlphanumericCharacters\u003Ek__BackingField;
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
              this.\u003CMinRequiredNonAlphanumericCharacters\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
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

    /// <summary>Регулярное выражение для проверки стойкости пароля</summary>
    public string PasswordStrengthRegularExpression
    {
      get => this.\u003CPasswordStrengthRegularExpression\u003Ek__BackingField;
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
              this.\u003CPasswordStrengthRegularExpression\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
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

    internal static void CW2MecB57ImORo30krwA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool BIs6AKB5Hcs0gyDIvQxT() => MembershipSettings.GBgF7JB56Of6BlfkpfWP == null;

    internal static MembershipSettings PbkopLB5AtUnPDPMFiym() => MembershipSettings.GBgF7JB56Of6BlfkpfWP;
  }
}
