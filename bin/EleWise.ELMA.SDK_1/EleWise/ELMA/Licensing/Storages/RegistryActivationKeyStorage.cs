// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.Storages.RegistryActivationKeyStorage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using Microsoft.Win32;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace EleWise.ELMA.Licensing.Storages
{
  public class RegistryActivationKeyStorage : IActivationKeyStorage
  {
    private RegistryKey _root;
    private RegistryKey _readKey;
    private RegistryKey _writeKey;
    internal static RegistryActivationKeyStorage gYaFy00TENmwInaaXZW;

    public RegistryActivationKeyStorage(RegistryKey root)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 4;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_25;
          case 1:
            goto label_2;
          case 2:
            try
            {
              this._readKey = (RegistryKey) RegistryActivationKeyStorage.vuBkME02pl7LNFFlEkk((object) this._root, RegistryActivationKeyStorage.Ll8ngy0OMhFM4aKwmJf(-97972138 ^ -97939794));
              int num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
                num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (this._readKey == null)
                    {
                      num2 = 5;
                      continue;
                    }
                    goto label_24;
                  case 2:
                  case 3:
                    goto label_24;
                  case 4:
                    RegistryActivationKeyStorage.NKEJDN0Pjc9fVJxDyW0((object) this._readKey);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 3 : 2;
                    continue;
                  case 5:
                    this._readKey = (RegistryKey) RegistryActivationKeyStorage.Be6hmT0ehIA0RJx8P1S((object) this._root, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323050186));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
                    continue;
                  default:
                    if (this._readKey == null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 2;
                      continue;
                    }
                    goto case 4;
                }
              }
            }
            catch (SecurityException ex)
            {
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
                num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    this._readKey = (RegistryKey) null;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_24;
                }
              }
            }
            catch (IOException ex)
            {
              int num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
                num4 = 1;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    this._readKey = (RegistryKey) null;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_24;
                }
              }
            }
            catch (UnauthorizedAccessException ex)
            {
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
                num5 = 1;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    this._readKey = (RegistryKey) null;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_24;
                }
              }
            }
          case 3:
label_24:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 1;
            continue;
          case 4:
            this._root = root;
            num1 = 5;
            continue;
          case 5:
            if (this._root == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 2;
            continue;
          case 6:
            goto label_53;
          default:
            goto label_35;
        }
      }
label_25:
      return;
label_53:
      return;
label_35:
      return;
label_2:
      try
      {
        this._writeKey = (RegistryKey) RegistryActivationKeyStorage.YEwTIN01nkIpsegjENA((object) this._root, RegistryActivationKeyStorage.Ll8ngy0OMhFM4aKwmJf(~538519529 ^ -538556690), true);
        int num6 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
          num6 = 0;
        string str;
        Guid guid;
        while (true)
        {
          switch (num6)
          {
            case 1:
              guid = RegistryActivationKeyStorage.cEdrOX0N3pNhFeIam6Z();
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 3 : 4;
              continue;
            case 2:
              RegistryActivationKeyStorage.xcjlbI0piDbE7NYL6tV((object) this._writeKey, (object) str);
              num6 = 5;
              continue;
            case 3:
              if (this._writeKey != null)
              {
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 1;
                continue;
              }
              goto label_47;
            case 4:
              str = guid.ToString();
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            case 5:
              goto label_51;
            default:
              RegistryActivationKeyStorage.NrtW2D03NhUjLrdW29c((object) this._writeKey, (object) str, RegistryActivationKeyStorage.Ll8ngy0OMhFM4aKwmJf(-951514650 ^ -951511446));
              num6 = 2;
              continue;
          }
        }
label_51:
        return;
label_47:;
      }
      catch (IOException ex)
      {
        int num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
          num7 = 0;
        while (true)
        {
          switch (num7)
          {
            case 1:
              goto label_45;
            default:
              this._writeKey = (RegistryKey) null;
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 0;
              continue;
          }
        }
label_45:;
      }
      catch (SecurityException ex)
      {
        int num8 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
          num8 = 0;
        while (true)
        {
          switch (num8)
          {
            case 1:
              goto label_41;
            default:
              this._writeKey = (RegistryKey) null;
              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
              continue;
          }
        }
label_41:;
      }
      catch (UnauthorizedAccessException ex)
      {
        int num9 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
          num9 = 0;
        while (true)
        {
          switch (num9)
          {
            case 1:
              goto label_39;
            default:
              this._writeKey = (RegistryKey) null;
              num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
              continue;
          }
        }
label_39:;
      }
    }

    public bool CanRead => this._readKey != null;

    public bool CanWrite => this._writeKey != null;

    public Dictionary<Guid, string> GetActivationKeys()
    {
      Dictionary<Guid, string> activationKeys = new Dictionary<Guid, string>();
      if (this._readKey == null)
        return activationKeys;
      foreach (string valueName in this._readKey.GetValueNames())
      {
        Guid result;
        if (!string.IsNullOrEmpty(valueName) && Guid.TryParse(valueName, out result))
        {
          object obj = this._readKey.GetValue(valueName);
          if (obj is string)
            activationKeys[result] = (string) obj;
        }
      }
      return activationKeys;
    }

    public void AddActivationKey(Guid uid, string key)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (this._writeKey != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            }
            goto label_22;
          case 2:
            goto label_24;
          default:
            goto label_2;
        }
      }
label_24:
      return;
label_2:
      try
      {
        RegistryActivationKeyStorage.NrtW2D03NhUjLrdW29c((object) this._writeKey, (object) uid.ToString(), (object) key);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
          num2 = 0;
        switch (num2)
        {
          case 0:
            return;
          default:
            return;
        }
      }
      catch (IOException ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_12;
            default:
              ((ILogger) RegistryActivationKeyStorage.USdgu10aCNtkRGCWIfu()).Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642894222), (Exception) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 0;
              continue;
          }
        }
label_12:
        return;
      }
      catch (SecurityException ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_10;
            default:
              ((ILogger) RegistryActivationKeyStorage.USdgu10aCNtkRGCWIfu()).Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234340314), (Exception) ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 1;
              continue;
          }
        }
label_10:
        return;
      }
      catch (UnauthorizedAccessException ex)
      {
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
          num5 = 0;
        while (true)
        {
          switch (num5)
          {
            case 1:
              goto label_6;
            default:
              RegistryActivationKeyStorage.QHmHXG0DeCmnC8AHldq(RegistryActivationKeyStorage.USdgu10aCNtkRGCWIfu(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70004458), (object) ex);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
              continue;
          }
        }
label_6:
        return;
      }
label_22:;
    }

    public void RemoveActivationKey(Guid uid)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (this._writeKey != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            }
            goto label_27;
          case 2:
            goto label_29;
          default:
            goto label_4;
        }
      }
label_29:
      return;
label_27:
      return;
label_4:
      try
      {
        if (RegistryActivationKeyStorage.XPhBdP0tHGoR6hxICwT((object) this._writeKey, (object) uid.ToString()) == null)
          return;
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_21;
            default:
              this._writeKey.DeleteValue(uid.ToString());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 1;
              continue;
          }
        }
label_21:;
      }
      catch (IOException ex)
      {
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_17;
            case 1:
              Logger.Log.Error(RegistryActivationKeyStorage.Ll8ngy0OMhFM4aKwmJf(901793403 ^ 901831155), (Exception) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
              continue;
            default:
              goto label_15;
          }
        }
label_17:
        return;
label_15:;
      }
      catch (SecurityException ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_11;
            default:
              ((ILogger) RegistryActivationKeyStorage.USdgu10aCNtkRGCWIfu()).Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178243252), (Exception) ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
              continue;
          }
        }
label_11:;
      }
      catch (UnauthorizedAccessException ex)
      {
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
          num5 = 0;
        while (true)
        {
          switch (num5)
          {
            case 1:
              goto label_9;
            default:
              RegistryActivationKeyStorage.QHmHXG0DeCmnC8AHldq(RegistryActivationKeyStorage.USdgu10aCNtkRGCWIfu(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218936002), (object) ex);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
              continue;
          }
        }
label_9:;
      }
    }

    internal static object Ll8ngy0OMhFM4aKwmJf(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object vuBkME02pl7LNFFlEkk([In] object obj0, [In] object obj1) => (object) ((RegistryKey) obj0).OpenSubKey((string) obj1);

    internal static object Be6hmT0ehIA0RJx8P1S([In] object obj0, [In] object obj1) => (object) ((RegistryKey) obj0).CreateSubKey((string) obj1);

    internal static object NKEJDN0Pjc9fVJxDyW0([In] object obj0) => (object) ((RegistryKey) obj0).GetValueNames();

    internal static object YEwTIN01nkIpsegjENA([In] object obj0, [In] object obj1, [In] bool obj2) => (object) ((RegistryKey) obj0).OpenSubKey((string) obj1, obj2);

    internal static Guid cEdrOX0N3pNhFeIam6Z() => Guid.NewGuid();

    internal static void NrtW2D03NhUjLrdW29c([In] object obj0, [In] object obj1, [In] object obj2) => ((RegistryKey) obj0).SetValue((string) obj1, obj2);

    internal static void xcjlbI0piDbE7NYL6tV([In] object obj0, [In] object obj1) => ((RegistryKey) obj0).DeleteValue((string) obj1);

    internal static bool ET2qhE0k9EeATqAEuB8() => RegistryActivationKeyStorage.gYaFy00TENmwInaaXZW == null;

    internal static RegistryActivationKeyStorage GQNf8w0n1XXatQphSsx() => RegistryActivationKeyStorage.gYaFy00TENmwInaaXZW;

    internal static object USdgu10aCNtkRGCWIfu() => (object) Logger.Log;

    internal static void QHmHXG0DeCmnC8AHldq([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object XPhBdP0tHGoR6hxICwT([In] object obj0, [In] object obj1) => ((RegistryKey) obj0).GetValue((string) obj1);
  }
}
