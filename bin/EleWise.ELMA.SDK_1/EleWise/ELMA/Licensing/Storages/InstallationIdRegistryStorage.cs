// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.Storages.InstallationIdRegistryStorage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using Microsoft.Win32;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace EleWise.ELMA.Licensing.Storages
{
  public class InstallationIdRegistryStorage : IInstallationIdStorage
  {
    private RegistryKey _root;
    private RegistryKey _readKey;
    private RegistryKey _writeKey;
    internal static InstallationIdRegistryStorage rarKBUxL5fjKpppf7Pj;

    public InstallationIdRegistryStorage(RegistryKey root)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 5;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_27;
          case 2:
            goto label_25;
          case 3:
            goto label_55;
          case 4:
            num1 = 7;
            continue;
          case 5:
            this._root = root;
            num1 = 6;
            continue;
          case 6:
            if (this._root != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 4;
              continue;
            }
            goto label_53;
          case 7:
            try
            {
              this._readKey = (RegistryKey) InstallationIdRegistryStorage.rUoqgQxzGclTHPL27GV((object) this._root, InstallationIdRegistryStorage.g78M5QxckCuywbLadVO(-441065788 ^ -2092910478 ^ 1727396018));
              int num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
                num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (this._readKey == null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 2 : 5;
                      continue;
                    }
                    break;
                  case 2:
                    if (this._readKey != null)
                    {
                      num2 = 4;
                      continue;
                    }
                    goto case 6;
                  case 3:
                  case 4:
                  case 5:
                    goto label_58;
                  case 6:
                    this._readKey = (RegistryKey) InstallationIdRegistryStorage.la6gqA0Fsr7ZUK8VEpu((object) this._root, InstallationIdRegistryStorage.g78M5QxckCuywbLadVO(-675505729 ^ -675543109));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
                    continue;
                }
                InstallationIdRegistryStorage.ItQneu0B1bMTsDA1E4R((object) this._readKey);
                num2 = 3;
              }
            }
            catch (SecurityException ex)
            {
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_58;
                  default:
                    this._readKey = (RegistryKey) null;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 0;
                    continue;
                }
              }
            }
            catch (IOException ex)
            {
              int num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
                num4 = 1;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    this._readKey = (RegistryKey) null;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_58;
                }
              }
            }
            catch (UnauthorizedAccessException ex)
            {
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
                num5 = 1;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    this._readKey = (RegistryKey) null;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_58;
                }
              }
            }
        }
label_58:
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 1;
      }
label_25:
      return;
label_55:
      return;
label_27:
      try
      {
        this._writeKey = (RegistryKey) InstallationIdRegistryStorage.A2bBu50WurUfNTjCrdH((object) this._root, InstallationIdRegistryStorage.g78M5QxckCuywbLadVO(-16752921 ^ -16727837), true);
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
          num6 = 3;
        string str;
        Guid guid;
        while (true)
        {
          switch (num6)
          {
            case 1:
              str = guid.ToString();
              num6 = 2;
              continue;
            case 2:
              InstallationIdRegistryStorage.vyJj0u0occTZVNKGuN2((object) this._writeKey, (object) str, InstallationIdRegistryStorage.g78M5QxckCuywbLadVO(1819636893 << 3 ^ 1672199012));
              num6 = 4;
              continue;
            case 3:
              if (this._writeKey != null)
              {
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
                continue;
              }
              goto label_47;
            case 4:
              InstallationIdRegistryStorage.IZtkQR0blxKejh7LSvP((object) this._writeKey, (object) str);
              num6 = 5;
              continue;
            case 5:
              goto label_49;
            default:
              guid = Guid.NewGuid();
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
              continue;
          }
        }
label_49:
        return;
label_47:
        return;
      }
      catch (IOException ex)
      {
        int num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
          num7 = 0;
        while (true)
        {
          switch (num7)
          {
            case 1:
              goto label_43;
            default:
              this._writeKey = (RegistryKey) null;
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
              continue;
          }
        }
label_43:
        return;
      }
      catch (SecurityException ex)
      {
        int num8 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
          num8 = 1;
        while (true)
        {
          switch (num8)
          {
            case 0:
              goto label_41;
            case 1:
              this._writeKey = (RegistryKey) null;
              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
              continue;
            default:
              goto label_37;
          }
        }
label_41:
        return;
label_37:
        return;
      }
      catch (UnauthorizedAccessException ex)
      {
        int num9 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
          num9 = 1;
        while (true)
        {
          switch (num9)
          {
            case 0:
              goto label_30;
            case 1:
              this._writeKey = (RegistryKey) null;
              num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
              continue;
            default:
              goto label_24;
          }
        }
label_30:
        return;
label_24:
        return;
      }
label_53:;
    }

    public string Read()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this._readKey != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return (string) null;
label_5:
      return (string) this._readKey.GetValue((string) InstallationIdRegistryStorage.g78M5QxckCuywbLadVO(-1217523399 ^ -1217491189));
    }

    public bool Write(string value)
    {
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_6;
          case 2:
            if (this._writeKey != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          case 3:
            InstallationIdRegistryStorage.ifDCNX0hZLBtVBAkDnl((object) value, InstallationIdRegistryStorage.g78M5QxckCuywbLadVO(-1146510045 ^ -1146491819));
            num1 = 2;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return false;
label_6:
      bool flag;
      try
      {
        InstallationIdRegistryStorage.vyJj0u0occTZVNKGuN2((object) this._writeKey, InstallationIdRegistryStorage.g78M5QxckCuywbLadVO(1012087039 ^ 1012115149), (object) value);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            default:
              flag = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 1;
              continue;
          }
        }
      }
      catch (IOException ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_2;
        }
      }
      catch (SecurityException ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
          num4 = 0;
        switch (num4)
        {
          default:
            goto label_2;
        }
      }
      catch (UnauthorizedAccessException ex)
      {
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
          num5 = 0;
        switch (num5)
        {
          default:
            goto label_2;
        }
      }
label_3:
      return flag;
    }

    internal static object g78M5QxckCuywbLadVO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object rUoqgQxzGclTHPL27GV([In] object obj0, [In] object obj1) => (object) ((RegistryKey) obj0).OpenSubKey((string) obj1);

    internal static object la6gqA0Fsr7ZUK8VEpu([In] object obj0, [In] object obj1) => (object) ((RegistryKey) obj0).CreateSubKey((string) obj1);

    internal static object ItQneu0B1bMTsDA1E4R([In] object obj0) => (object) ((RegistryKey) obj0).GetValueNames();

    internal static object A2bBu50WurUfNTjCrdH([In] object obj0, [In] object obj1, [In] bool obj2) => (object) ((RegistryKey) obj0).OpenSubKey((string) obj1, obj2);

    internal static void vyJj0u0occTZVNKGuN2([In] object obj0, [In] object obj1, [In] object obj2) => ((RegistryKey) obj0).SetValue((string) obj1, obj2);

    internal static void IZtkQR0blxKejh7LSvP([In] object obj0, [In] object obj1) => ((RegistryKey) obj0).DeleteValue((string) obj1);

    internal static bool cbcbuIxU0sUxFKOwA6g() => InstallationIdRegistryStorage.rarKBUxL5fjKpppf7Pj == null;

    internal static InstallationIdRegistryStorage YKZETuxsQ2IJRsRh242() => InstallationIdRegistryStorage.rarKBUxL5fjKpppf7Pj;

    internal static void ifDCNX0hZLBtVBAkDnl([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);
  }
}
