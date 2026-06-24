// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Impl.LicensedUnitBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Modules.Attributes;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace EleWise.ELMA.Modules.Impl
{
  public abstract class LicensedUnitBase : ILicensedUnitComponentInfo
  {
    protected static bool _hnLoaded;
    protected static uint _hnH;
    protected static uint _hnL;
    private static LicensedUnitBase WuoIfyN3CtpRVE9K6dw;

    protected void Check(
      Guid moduleUid,
      LicensedUnitBase.DecodeConcurrentActivationKeyAction decodeAction)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Check(moduleUid, decodeAction, out byte _, out ushort _, out ushort _);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected void Check(
      Guid moduleUid,
      LicensedUnitBase.DecodeConcurrentActivationKeyAction decodeAction,
      out byte licSubType,
      out ushort licCount,
      out ushort privilegeCount)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        LicenseStatus status;
        DateTime dateTime;
        DateTime? expirationDate;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              goto label_10;
            case 3:
              if (status != LicenseStatus.DateExpired)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
                continue;
              }
              goto label_10;
            case 4:
              goto label_16;
            case 5:
              DateTime date1 = dateTime.Date;
              dateTime = expirationDate.Value;
              DateTime date2 = dateTime.Date;
              if (LicensedUnitBase.XUMJtSNtCHdHT3rD6Vn(date1, date2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 1 : 2;
                continue;
              }
              goto label_7;
            case 6:
              if (status != LicenseStatus.Activated)
                goto case 9;
              else
                goto label_18;
            case 7:
              byte licType;
              if (decodeAction(out status, out licCount, out privilegeCount, out licType, out licSubType, out expirationDate))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 6 : 5;
                continue;
              }
              goto label_16;
            case 8:
              dateTime = LicensedUnitBase.q7jo73NDHrgcA0B2qFf();
              num2 = 5;
              continue;
            case 9:
              if (status != LicenseStatus.DateExpired)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
                continue;
              }
              goto case 3;
            default:
              if (expirationDate.HasValue)
              {
                num2 = 8;
                continue;
              }
              goto label_6;
          }
        }
label_18:
        num1 = 3;
      }
label_3:
      throw new LicenseActivationRequiredException(moduleUid);
label_10:
      throw new LicenseExpiredException(moduleUid);
label_7:
      return;
label_6:
      return;
label_16:
      throw new LicenseActivationRequiredException(moduleUid);
    }

    protected void Check(
      Guid moduleUid,
      LicensedUnitBase.DecodeActivationKeyAction decodeAction)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Check(moduleUid, decodeAction, out ushort _);
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

    protected void Check(
      Guid moduleUid,
      LicensedUnitBase.DecodeActivationKeyAction decodeAction,
      out ushort licCount)
    {
      int num = 5;
      DateTime now;
      LicenseStatus status;
      DateTime? expirationDate;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (status != LicenseStatus.DateExpired)
            {
              num = 2;
              continue;
            }
            goto label_2;
          case 2:
            if (!expirationDate.HasValue)
            {
              num = 8;
              continue;
            }
            goto case 10;
          case 3:
            goto label_14;
          case 4:
            goto label_8;
          case 5:
            byte licType;
            if (!decodeAction(out status, out licCount, out licType, out expirationDate))
            {
              num = 4;
              continue;
            }
            if (status == LicenseStatus.Activated)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 1;
              continue;
            }
            goto case 9;
          case 6:
            DateTime date1 = now.Date;
            now = expirationDate.Value;
            DateTime date2 = now.Date;
            if (!LicensedUnitBase.XUMJtSNtCHdHT3rD6Vn(date1, date2))
            {
              num = 3;
              continue;
            }
            goto label_2;
          case 7:
            goto label_17;
          case 8:
            goto label_11;
          case 9:
            if (status != LicenseStatus.DateExpired)
            {
              num = 7;
              continue;
            }
            goto case 1;
          case 10:
            now = DateTime.Now;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 5 : 6;
            continue;
          default:
            goto label_2;
        }
      }
label_14:
      return;
label_11:
      return;
label_2:
      throw new LicenseExpiredException(moduleUid);
label_8:
      throw new LicenseActivationRequiredException(moduleUid);
label_17:
      throw new LicenseActivationRequiredException(moduleUid);
    }

    protected virtual ushort GetDbLicenseCount() => 0;

    protected virtual string MainProviderType
    {
      get
      {
        int num = 2;
        IRuntimeApplication runtimeApplication1;
        while (true)
        {
          IRuntimeApplication runtimeApplication2;
          switch (num)
          {
            case 1:
              runtimeApplication2 = ((ComponentManager) LicensedUnitBase.orDWfdNwxu3Yguyniv1()).GetComponentsForRegister<IRuntimeApplication>().FirstOrDefault<IRuntimeApplication>();
              break;
            case 2:
              if (((ComponentManager) LicensedUnitBase.orDWfdNwxu3Yguyniv1()).Stage == ComponentManager.LifetimeStage.BeforeInit)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 1;
                continue;
              }
              goto case 5;
            case 3:
              goto label_12;
            case 4:
              goto label_11;
            case 5:
              runtimeApplication2 = Locator.GetServiceNotNull<IRuntimeApplication>();
              break;
            case 6:
              if (runtimeApplication1 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
                continue;
              }
              goto label_13;
            default:
              if (LicensedUnitBase.ATnyavN4yWoXbo1doZB(LicensedUnitBase.orDWfdNwxu3Yguyniv1()) != (ComponentType) 0)
              {
                num = 3;
                continue;
              }
              goto label_11;
          }
          runtimeApplication1 = runtimeApplication2;
          num = 6;
        }
label_11:
        return string.Empty;
label_12:
        throw new InvalidOperationException((string) LicensedUnitBase.L9kpquN6KmV92DQ2EXV(-138018305 ^ -137989381));
label_13:
        return (string) LicensedUnitBase.tLtYOINH7HrZybWrMGQ((object) (runtimeApplication1.MainProvider ?? throw new InvalidOperationException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487391910))).GetType());
      }
    }

    protected static void GHN(out uint hnH, out uint hnL)
    {
      int num1 = 14;
      object obj1;
      object obj2;
      byte[] numArray;
      byte[] hash;
      while (true)
      {
        switch (num1)
        {
          case 1:
            LicensedUnitBase._hnH = hnH;
            num1 = 4;
            continue;
          case 2:
            hnL = LicensedUnitBase._hnL;
            num1 = 6;
            continue;
          case 3:
            hash = new MD5CryptoServiceProvider().ComputeHash((byte[]) LicensedUnitBase.jEsnCONrt1CLBnF6sYj(LicensedUnitBase.TBE1EBNjchdxMEiMOgc(), (object) obj1.ToString()));
            num1 = 5;
            continue;
          case 4:
            LicensedUnitBase._hnL = hnL;
            num1 = 10;
            continue;
          case 5:
            hnH = LicensedUnitBase.iF6aEWN5ncwZL2hPQhk((object) hash, 0);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 0;
            continue;
          case 6:
            goto label_2;
          case 7:
            try
            {
              ManagementObjectCollection objectCollection = (ManagementObjectCollection) LicensedUnitBase.bbmRZdNARTtOqxRp8wR((object) new ManagementObjectSearcher((string) LicensedUnitBase.L9kpquN6KmV92DQ2EXV(-1822890472 ^ -1822911120)));
              int num2 = 6;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
                num2 = 1;
              ManagementObjectCollection.ManagementObjectEnumerator enumerator;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (LicensedUnitBase.g68FiUNxu1OvvG4m6Rx((object) enumerator))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_28;
                  case 2:
                    enumerator = objectCollection.GetEnumerator();
                    num2 = 5;
                    continue;
                  case 3:
                    obj1 = LicensedUnitBase.T18eavNmwfwgM15r3Cr(LicensedUnitBase.oFhTfPN0DeTmsCLPUXx((object) enumerator), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222141630));
                    num2 = 4;
                    continue;
                  case 4:
                    goto label_28;
                  case 5:
                    LicensedUnitBase.whkQ3qN7yXlE0XHiJXK((object) enumerator);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
                    continue;
                  case 6:
                    if (objectCollection != null)
                    {
                      num2 = 2;
                      continue;
                    }
                    goto label_28;
                  default:
                    obj2 = LicensedUnitBase.T18eavNmwfwgM15r3Cr(LicensedUnitBase.oFhTfPN0DeTmsCLPUXx((object) enumerator), LicensedUnitBase.L9kpquN6KmV92DQ2EXV(2008901894 << 3 ^ -1108657258));
                    num2 = 3;
                    continue;
                }
              }
            }
            catch (Exception ex)
            {
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  object obj3 = LicensedUnitBase.UxWtiFNy9FomjGd560K(LicensedUnitBase.L9kpquN6KmV92DQ2EXV(-1146510045 ^ -1146497297));
                  object obj4;
                  if (LicensedUnitBase.TiKLvjNJ70BChdlMgcR(LicensedUnitBase.vDqiUoNMmpa65C3YW5R((object) ex)))
                    obj4 = (object) string.Empty;
                  else
                    obj4 = LicensedUnitBase.O3Z24aNdiKGEvr3IF4n(LicensedUnitBase.XMvcDxN9Le0HRhNH4pu(), (object) EleWise.ELMA.SR.T((string) LicensedUnitBase.L9kpquN6KmV92DQ2EXV(-1146510045 ^ -1146498613), (object) ex.Message));
                  string str;
                  if (!(ex is COMException))
                    str = string.Empty;
                  else
                    str = Environment.NewLine + EleWise.ELMA.SR.T((string) LicensedUnitBase.L9kpquN6KmV92DQ2EXV(2008901894 << 3 ^ -1108656864), (object) string.Format((string) LicensedUnitBase.L9kpquN6KmV92DQ2EXV(1253244298 - 1829393894 ^ -576138608), (object) LicensedUnitBase.cwJ0KtNlhFIGW55beEY((object) (COMException) ex)));
                  throw new InvalidOperationException((string) obj3 + (string) obj4 + str, ex);
              }
            }
          case 8:
            obj1 = (object) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 3 : 7;
            continue;
          case 9:
            numArray = (byte[]) LicensedUnitBase.bQP8B3Ngt5TrdbdWcIH((object) new MD5CryptoServiceProvider(), (object) (byte[]) LicensedUnitBase.jEsnCONrt1CLBnF6sYj((object) Encoding.UTF8, (object) obj2.ToString()));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
            continue;
          case 10:
            LicensedUnitBase._hnLoaded = true;
            num1 = 16;
            continue;
          case 11:
label_28:
            hnL = 2345106789U;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 14 : 17;
            continue;
          case 12:
            hnH = 1234098765U;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 15 : 9;
            continue;
          case 13:
            hnH = LicensedUnitBase._hnH;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 2 : 1;
            continue;
          case 14:
            if (LicensedUnitBase._hnLoaded)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 13 : 10;
              continue;
            }
            obj2 = (object) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 6 : 8;
            continue;
          case 15:
            if (obj1 != null)
            {
              num1 = 3;
              continue;
            }
            goto case 1;
          case 16:
            goto label_18;
          case 17:
            if (obj2 != null)
            {
              num1 = 9;
              continue;
            }
            goto case 12;
          default:
            hnL = LicensedUnitBase.iF6aEWN5ncwZL2hPQhk((object) numArray, 0);
            num1 = 12;
            continue;
        }
      }
label_2:
      return;
label_18:;
    }

    string ILicensedUnitComponentInfo.GetComponentId() => (string) LicensedUnitBase.yFALilNYrhJ61i3BxUi((object) this);

    string ILicensedUnitComponentInfo.GetComponentVersion() => (string) LicensedUnitBase.rQxHsANLATW3vYMhHVk((object) this);

    protected virtual string GetComponentId()
    {
      int num = 1;
      ModuleAttribute attribute;
      while (true)
      {
        switch (num)
        {
          case 1:
            attribute = AttributeHelper<ModuleAttribute>.GetAttribute(this.GetType().Assembly);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_3;
          default:
            if (attribute != null)
            {
              num = 3;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return (string) null;
label_3:
      return (string) LicensedUnitBase.wTt8krNUDdTDP5AUrIZ((object) attribute);
    }

    protected virtual string GetComponentVersion()
    {
      int num = 1;
      Version version;
      while (true)
      {
        switch (num)
        {
          case 1:
            version = VersionInfo.GetVersion(LicensedUnitBase.WR5hV2NsmEM9dhgJYfP((object) this));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_3;
          default:
            if (LicensedUnitBase.qKUIU5NcMN4OIN1g5a3((object) version, (object) null))
            {
              num = 3;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return (string) null;
label_3:
      return version.ToString();
    }

    protected LicensedUnitBase()
    {
      LicensedUnitBase.MvZf4UNz5ct352fkwLZ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Ag1StaNpJsLpOYTpVE9() => LicensedUnitBase.WuoIfyN3CtpRVE9K6dw == null;

    internal static LicensedUnitBase WjPu5FNa4f0Jcd8yuwP() => LicensedUnitBase.WuoIfyN3CtpRVE9K6dw;

    internal static DateTime q7jo73NDHrgcA0B2qFf() => DateTime.Now;

    internal static bool XUMJtSNtCHdHT3rD6Vn([In] DateTime obj0, [In] DateTime obj1) => obj0 > obj1;

    internal static object orDWfdNwxu3Yguyniv1() => (object) ComponentManager.Current;

    internal static ComponentType ATnyavN4yWoXbo1doZB([In] object obj0) => ((ComponentManager) obj0).ComponentType;

    internal static object L9kpquN6KmV92DQ2EXV(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object tLtYOINH7HrZybWrMGQ([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object bbmRZdNARTtOqxRp8wR([In] object obj0) => (object) ((ManagementObjectSearcher) obj0).Get();

    internal static void whkQ3qN7yXlE0XHiJXK([In] object obj0) => ((ManagementObjectCollection.ManagementObjectEnumerator) obj0).Reset();

    internal static bool g68FiUNxu1OvvG4m6Rx([In] object obj0) => ((ManagementObjectCollection.ManagementObjectEnumerator) obj0).MoveNext();

    internal static object oFhTfPN0DeTmsCLPUXx([In] object obj0) => (object) ((ManagementObjectCollection.ManagementObjectEnumerator) obj0).Current;

    internal static object T18eavNmwfwgM15r3Cr([In] object obj0, [In] object obj1) => ((ManagementBaseObject) obj0).GetPropertyValue((string) obj1);

    internal static object UxWtiFNy9FomjGd560K([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object vDqiUoNMmpa65C3YW5R([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static bool TiKLvjNJ70BChdlMgcR([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object XMvcDxN9Le0HRhNH4pu() => (object) Environment.NewLine;

    internal static object O3Z24aNdiKGEvr3IF4n([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static int cwJ0KtNlhFIGW55beEY([In] object obj0) => ((ExternalException) obj0).ErrorCode;

    internal static object jEsnCONrt1CLBnF6sYj([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetBytes((string) obj1);

    internal static object bQP8B3Ngt5TrdbdWcIH([In] object obj0, [In] object obj1) => (object) ((HashAlgorithm) obj0).ComputeHash((byte[]) obj1);

    internal static uint iF6aEWN5ncwZL2hPQhk([In] object obj0, [In] int obj1) => BitConverter.ToUInt32((byte[]) obj0, obj1);

    internal static object TBE1EBNjchdxMEiMOgc() => (object) Encoding.UTF8;

    internal static object yFALilNYrhJ61i3BxUi([In] object obj0) => (object) ((LicensedUnitBase) obj0).GetComponentId();

    internal static object rQxHsANLATW3vYMhHVk([In] object obj0) => (object) ((LicensedUnitBase) obj0).GetComponentVersion();

    internal static object wTt8krNUDdTDP5AUrIZ([In] object obj0) => (object) ((ModuleAttribute) obj0).Id;

    internal static Type WR5hV2NsmEM9dhgJYfP([In] object obj0) => obj0.GetType();

    internal static bool qKUIU5NcMN4OIN1g5a3([In] object obj0, [In] object obj1) => (Version) obj0 != (Version) obj1;

    internal static void MvZf4UNz5ct352fkwLZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    protected delegate bool DecodeActivationKeyAction(
      out LicenseStatus status,
      out ushort licCount,
      out byte licType,
      out DateTime? expirationDate);

    protected delegate bool DecodeConcurrentActivationKeyAction(
      out LicenseStatus status,
      out ushort licCount,
      out ushort privilegeCount,
      out byte licType,
      out byte licSubType,
      out DateTime? expirationDate);

    public static class Providers
    {
      /// <summary>Провайдер Firebird</summary>
      [Obsolete("Провайдер Firebird больше не поддерживается", true)]
      public const string Firebird = "FirebirdProvider";
      /// <summary>Провайдер MSSQL</summary>
      public const string MSSQL = "MSSQLProvider";
      /// <summary>Провайдер Oracle</summary>
      public const string Oracle = "OracleProvider";
      /// <summary>Провайдер PostgreSQL</summary>
      public const string PostgreSQL = "PostgreSQLProvider";
      internal static LicensedUnitBase.Providers fcZGQSfMxjCIeBOYkwt4;

      public static string GetVersionName(string providerName) => LicensedUnitBase.Providers.GetVersionName(LicensedUnitBase.Providers.gBr9GpfMyUqQrYa7hjBL((object) providerName));

      public static string GetVersionName(ElmaEdition edition, string providerType)
      {
        int num = 3;
        string versionName;
        while (true)
        {
          string str;
          object obj;
          switch (num)
          {
            case 1:
            case 5:
              goto label_14;
            case 2:
              if (edition != ElmaEdition.Standart)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 8 : 3;
                continue;
              }
              goto case 7;
            case 3:
              versionName = LicensedUnitBase.Providers.GetVersionName(edition);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 2 : 1;
              continue;
            case 4:
              if (str == null)
              {
                num = 5;
                continue;
              }
              goto case 9;
            case 6:
              obj = LicensedUnitBase.Providers.XSmNJQfMMRJ6EekZZqwN(-1598106783 - -968262081 ^ -630181356);
              break;
            case 7:
              if (!LicensedUnitBase.Providers.IinN0afMJJTytAsKY1gZ((object) providerType, LicensedUnitBase.Providers.XSmNJQfMMRJ6EekZZqwN(277947046 - -1479185048 ^ 1757136786)))
              {
                num = 11;
                continue;
              }
              obj = LicensedUnitBase.Providers.XSmNJQfMMRJ6EekZZqwN(272623989 ^ 272272947);
              break;
            case 8:
              if (edition == ElmaEdition.Enterprise)
              {
                num = 7;
                continue;
              }
              goto label_14;
            case 9:
              versionName = (string) LicensedUnitBase.Providers.PiJrAkfM9AURjQoUVppx((object) versionName, LicensedUnitBase.Providers.XSmNJQfMMRJ6EekZZqwN(87862435 ^ 87870345), (object) str, LicensedUnitBase.Providers.XSmNJQfMMRJ6EekZZqwN(572119659 - -337058038 ^ 909176029));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 1;
              continue;
            case 10:
              if (LicensedUnitBase.Providers.IinN0afMJJTytAsKY1gZ((object) providerType, LicensedUnitBase.Providers.XSmNJQfMMRJ6EekZZqwN(-35995181 ^ -35998889)))
              {
                num = 12;
                continue;
              }
              goto default;
            case 11:
              if (LicensedUnitBase.Providers.IinN0afMJJTytAsKY1gZ((object) providerType, LicensedUnitBase.Providers.XSmNJQfMMRJ6EekZZqwN(-1204263869 ^ -1341583247 ^ 137749966)))
              {
                num = 6;
                continue;
              }
              goto case 10;
            case 12:
              obj = LicensedUnitBase.Providers.XSmNJQfMMRJ6EekZZqwN(1925118608 << 2 ^ -889287330);
              break;
            default:
              obj = (object) null;
              break;
          }
          str = (string) obj;
          num = 4;
        }
label_14:
        return versionName;
      }

      public static string GetVersionName(ElmaEdition edition)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_6;
            case 2:
              switch (edition)
              {
                case ElmaEdition.CE:
                  goto label_5;
                case ElmaEdition.Express:
                  goto label_2;
                case ElmaEdition.Standart:
                  goto label_3;
                case ElmaEdition.Enterprise:
                  goto label_4;
                default:
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
                  continue;
              }
            default:
              goto label_2;
          }
        }
label_2:
        return (string) LicensedUnitBase.Providers.kfEkWufMd3MnyCHTGd2s(LicensedUnitBase.Providers.XSmNJQfMMRJ6EekZZqwN(-70007027 ^ -69820311));
label_3:
        return (string) LicensedUnitBase.Providers.kfEkWufMd3MnyCHTGd2s((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939728908));
label_4:
        return (string) LicensedUnitBase.Providers.kfEkWufMd3MnyCHTGd2s(LicensedUnitBase.Providers.XSmNJQfMMRJ6EekZZqwN(44884861 ^ 44664049));
label_5:
        return (string) LicensedUnitBase.Providers.kfEkWufMd3MnyCHTGd2s(LicensedUnitBase.Providers.XSmNJQfMMRJ6EekZZqwN(-16752921 ^ -16434867));
label_6:
        return string.Empty;
      }

      public static ElmaEdition GetEdition(string providerName) => ElmaEdition.CE;

      internal static ElmaEdition gBr9GpfMyUqQrYa7hjBL([In] object obj0) => LicensedUnitBase.Providers.GetEdition((string) obj0);

      internal static bool oyS9bJfM0bCWkdcB1Kj0() => LicensedUnitBase.Providers.fcZGQSfMxjCIeBOYkwt4 == null;

      internal static LicensedUnitBase.Providers xVrfGWfMmB20lc0fdRP6() => LicensedUnitBase.Providers.fcZGQSfMxjCIeBOYkwt4;

      internal static object XSmNJQfMMRJ6EekZZqwN(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool IinN0afMJJTytAsKY1gZ([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

      internal static object PiJrAkfM9AURjQoUVppx(
        [In] object obj0,
        [In] object obj1,
        [In] object obj2,
        [In] object obj3)
      {
        return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
      }

      internal static object kfEkWufMd3MnyCHTGd2s([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
    }
  }
}
