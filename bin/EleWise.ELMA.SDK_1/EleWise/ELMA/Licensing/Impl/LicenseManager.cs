// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.Impl.LicenseManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing.Storages;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using Microsoft.Win32;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace EleWise.ELMA.Licensing.Impl
{
  internal class LicenseManager : ILicenseManager
  {
    /// <summary>Ключ версии Community Edition</summary>
    private Guid ceUid;
    private readonly List<IActivationKeyStorage> _storages;
    private static LicenseManager sK2gpJ7sIIbXvDZrPcW;

    public void ApplyAllActivationKeys()
    {
      int num1 = 2;
      IModuleManager moduleManager1;
      ILicensedUnit licensedUnit;
      Dictionary<Guid, string>.Enumerator enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (moduleManager1 != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 5 : 6;
              continue;
            }
            goto label_58;
          case 2:
            moduleManager1 = (IModuleManager) LicenseManager.sUquw7xBKQl5bG7C2hM(LicenseManager.GYlD3kxFsbFPaMUdH9H());
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
            continue;
          case 3:
            enumerator1 = this.GetActivationKeys().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
            continue;
          case 4:
            if (licensedUnit != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 3 : 0;
              continue;
            }
            goto label_54;
          case 5:
            goto label_60;
          case 6:
            licensedUnit = LicenseManager.vy8mIgxW2G9BBrfXwRJ((object) moduleManager1) as ILicensedUnit;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 4 : 4;
            continue;
          case 7:
            goto label_2;
          default:
            goto label_8;
        }
      }
label_60:
      return;
label_2:
      return;
label_54:
      return;
label_8:
      try
      {
label_11:
        if (enumerator1.MoveNext())
          goto label_15;
        else
          goto label_12;
label_10:
        KeyValuePair<Guid, string> current1;
        List<IActivationKeyStorage>.Enumerator enumerator2;
        int num2;
        while (true)
        {
          ModuleManager moduleManager2;
          IEnumerator<ModuleManager.StoreComponentConfigurationInfo> enumerator3;
          switch (num2)
          {
            case 1:
              LicenseManager.HOACPJxoEeommuEZBwq((object) licensedUnit, (object) current1.Value);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 8;
              continue;
            case 2:
              goto label_15;
            case 3:
              goto label_11;
            case 4:
              goto label_17;
            case 5:
              if (moduleManager2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 6 : 6;
                continue;
              }
              goto case 9;
            case 7:
              goto label_49;
            case 8:
              moduleManager2 = moduleManager1 as ModuleManager;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 5;
              continue;
            case 9:
              IEnumerable<ModuleManager.StoreComponentConfigurationInfo> installedComponentInfos = moduleManager2.GetInstalledComponentInfos();
              this.GetActivationKeys().Select<KeyValuePair<Guid, string>, string>((Func<KeyValuePair<Guid, string>, string>) (p => p.Value)).ToList<string>();
              enumerator3 = installedComponentInfos.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 10 : 7;
              continue;
            case 10:
              try
              {
label_38:
                if (LicenseManager.IF0SLoxhTL68yY2Xrq8((object) enumerator3))
                  goto label_40;
                else
                  goto label_39;
label_37:
                ModuleManager.StoreComponentConfigurationInfo current2;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      ((ILicensedUnit) LicenseManager.QBblr2xbjVGrH2lNhXJ((object) current2)).ApplyActivationKey(current1.Value);
                      num3 = 4;
                      continue;
                    case 2:
                      goto label_35;
                    case 3:
                      if (current2.LicensedUnit == null)
                      {
                        num3 = 5;
                        continue;
                      }
                      goto case 1;
                    case 4:
                    case 5:
                      goto label_38;
                    default:
                      goto label_40;
                  }
                }
label_39:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 2 : 0;
                goto label_37;
label_40:
                current2 = enumerator3.Current;
                num3 = 3;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
                {
                  num3 = 1;
                  goto label_37;
                }
                else
                  goto label_37;
              }
              finally
              {
                if (enumerator3 != null)
                {
                  int num4 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
                    num4 = 0;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        LicenseManager.HUb4Y7xG6OYhP7kZrHH((object) enumerator3);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_51;
                    }
                  }
                }
label_51:;
              }
          }
label_35:
          enumerator2 = this._storages.GetEnumerator();
          num2 = 4;
        }
label_49:
        return;
label_17:
        try
        {
label_21:
          if (enumerator2.MoveNext())
            goto label_19;
          else
            goto label_22;
label_18:
          IActivationKeyStorage current3;
          int num5;
          switch (num5)
          {
            case 1:
              try
              {
                LicenseManager.HdwJbhxE85w0bWoRBxw((object) current3, current1.Key, (object) current1.Value);
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                    goto label_21;
                }
              }
              catch (Exception ex)
              {
                int num7 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
                  num7 = 1;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      LicenseManager.iDQaxLxC9Ni6L1esHyh(LicenseManager.ErPGRNxf5eu0boxBCK6(), LicenseManager.jIm3vOxQ1Nph7dkSsDe(1461825605 - 1531863589 ^ -70003342), (object) ex);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_21;
                  }
                }
              }
            case 2:
              break;
            case 3:
              goto label_11;
            default:
              goto label_21;
          }
label_19:
          current3 = enumerator2.Current;
          num5 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
          {
            num5 = 1;
            goto label_18;
          }
          else
            goto label_18;
label_22:
          num5 = 3;
          goto label_18;
        }
        finally
        {
          enumerator2.Dispose();
          int num8 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
            num8 = 0;
          switch (num8)
          {
            default:
          }
        }
label_12:
        num2 = 7;
        goto label_10;
label_15:
        current1 = enumerator1.Current;
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
        {
          num2 = 1;
          goto label_10;
        }
        else
          goto label_10;
      }
      finally
      {
        enumerator1.Dispose();
        int num9 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
          num9 = 0;
        switch (num9)
        {
          default:
        }
      }
label_58:;
    }

    public string GetRegistrationKey()
    {
      int num = 1;
      ILicensedUnit unit;
      while (true)
      {
        object obj;
        switch (num)
        {
          case 1:
            if (!LicenseManager.PwD7utxvSNhiZg0SNmf())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
              continue;
            }
            obj = LicenseManager.WClOgRx8woilMtmPk6w(LicenseManager.sUquw7xBKQl5bG7C2hM((object) ComponentManager.Current));
            break;
          case 2:
            goto label_2;
          case 3:
            goto label_3;
          case 4:
            if (unit == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 3;
              continue;
            }
            goto label_2;
          default:
            obj = (object) null;
            break;
        }
        unit = (ILicensedUnit) obj;
        num = 4;
      }
label_2:
      return this.GetRegistrationKey(unit);
label_3:
      return string.Empty;
    }

    public string GetRegistrationKey(ILicensedUnit unit)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            LicenseManager.YZELWPxZ15yP5pSwiwK((object) unit, LicenseManager.jIm3vOxQ1Nph7dkSsDe(-1852837372 ^ -1852872268));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (string) LicenseManager.Y0Atb8xuor24lMwISE3((object) unit);
    }

    public void CompleteLicensingInitialize()
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        ILicensedUnit licensedUnit1;
        while (true)
        {
          ILicensedUnit licensedUnit2;
          switch (num2)
          {
            case 1:
              if (LicenseManager.sUquw7xBKQl5bG7C2hM(LicenseManager.GYlD3kxFsbFPaMUdH9H()) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
                continue;
              }
              licensedUnit2 = LicenseManager.vy8mIgxW2G9BBrfXwRJ(LicenseManager.sUquw7xBKQl5bG7C2hM((object) ComponentManager.Current)) as ILicensedUnit;
              break;
            case 2:
              goto label_8;
            case 3:
              goto label_3;
            case 4:
              if (licensedUnit1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 2 : 2;
                continue;
              }
              goto label_12;
            case 5:
              ((ModuleManager) LicenseManager.sUquw7xBKQl5bG7C2hM(LicenseManager.GYlD3kxFsbFPaMUdH9H())).UpdateModuleStatuses();
              num2 = 4;
              continue;
            case 6:
              LicenseManager.rNEqJpxI4xEvdq01QTm((object) licensedUnit1);
              num2 = 5;
              continue;
            case 7:
              goto label_12;
            default:
              licensedUnit2 = (ILicensedUnit) null;
              break;
          }
          licensedUnit1 = licensedUnit2;
          num2 = 6;
        }
label_12:
        LicenseManager.QXfZpCxVUbicqIPPoep((object) licensedUnit1);
        num1 = 3;
      }
label_8:
      return;
label_3:;
    }

    public Guid AddActivationKey(string key) => this.AddActivationKey(key, out IEnumerable<IStoreComponentInfo> _);

    public Guid AddActivationKey(
      string key,
      out IEnumerable<IStoreComponentInfo> newActivatedComponents)
    {
      int num1 = 2;
      Guid uid;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          List<IStoreComponentInfo>.Enumerator enumerator1;
          Dictionary<string, LicenseStatus> dictionary;
          IEnumerator<ModuleManager.StoreComponentConfigurationInfo> enumerator2;
          ModuleManager moduleManager;
          List<IActivationKeyStorage>.Enumerator enumerator3;
          List<IStoreComponentInfo> storeComponentInfoList1;
          List<IStoreComponentInfo> storeComponentInfoList2;
          List<IStoreComponentInfo> storeComponentInfoList3;
          switch (num2)
          {
            case 1:
              storeComponentInfoList2 = new List<IStoreComponentInfo>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
              continue;
            case 2:
              uid = Guid.NewGuid();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 1;
              continue;
            case 3:
            case 26:
label_69:
              enumerator1 = storeComponentInfoList2.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 24 : 24;
              continue;
            case 4:
              enumerator1 = storeComponentInfoList1.GetEnumerator();
              num2 = 12;
              continue;
            case 5:
              if (!(LicenseManager.vy8mIgxW2G9BBrfXwRJ(LicenseManager.sUquw7xBKQl5bG7C2hM(LicenseManager.GYlD3kxFsbFPaMUdH9H())) is ILicensedUnit))
              {
                num2 = 10;
                continue;
              }
              goto case 22;
            case 6:
label_94:
              if (LicenseManager.sUquw7xBKQl5bG7C2hM(LicenseManager.GYlD3kxFsbFPaMUdH9H()) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 2 : 5;
                continue;
              }
              goto case 10;
            case 7:
              try
              {
label_23:
                if (LicenseManager.IF0SLoxhTL68yY2Xrq8((object) enumerator2))
                  goto label_25;
                else
                  goto label_24;
label_20:
                ModuleManager.StoreComponentConfigurationInfo current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_43;
                    case 2:
                      LicenseManager.HOACPJxoEeommuEZBwq(LicenseManager.QBblr2xbjVGrH2lNhXJ((object) current), (object) key);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
                      continue;
                    case 3:
                      if (LicenseManager.QBblr2xbjVGrH2lNhXJ((object) current) != null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 2;
                        continue;
                      }
                      goto label_23;
                    case 4:
                      goto label_25;
                    default:
                      goto label_23;
                  }
                }
label_24:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 0;
                goto label_20;
label_25:
                current = enumerator2.Current;
                num3 = 3;
                goto label_20;
              }
              finally
              {
                if (enumerator2 != null)
                {
                  int num4 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
                    num4 = 1;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        LicenseManager.HUb4Y7xG6OYhP7kZrHH((object) enumerator2);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_32;
                    }
                  }
                }
label_32:;
              }
            case 8:
label_63:
              newActivatedComponents = (IEnumerable<IStoreComponentInfo>) storeComponentInfoList2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 19 : 12;
              continue;
            case 9:
              enumerator1 = storeComponentInfoList1.GetEnumerator();
              num2 = 25;
              continue;
            case 10:
            case 11:
              moduleManager = LicenseManager.sUquw7xBKQl5bG7C2hM(LicenseManager.GYlD3kxFsbFPaMUdH9H()) as ModuleManager;
              num2 = 17;
              continue;
            case 12:
              try
              {
label_76:
                if (enumerator1.MoveNext())
                  goto label_74;
                else
                  goto label_77;
label_71:
                LicenseStatus licenseStatus;
                IStoreComponentInfo current;
                ILicenseInfo licenseInfo;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_74;
                    case 2:
                      goto label_69;
                    case 4:
                      if (licenseInfo != null)
                      {
                        num5 = 7;
                        continue;
                      }
                      goto label_76;
                    case 5:
                      if (LicenseManager.EkX8LUxKQNtQEuChFTp((object) licenseInfo) != LicenseStatus.Activated)
                      {
                        num5 = 8;
                        continue;
                      }
                      goto case 10;
                    case 6:
                      storeComponentInfoList2.Add(current);
                      num5 = 3;
                      continue;
                    case 7:
                      if (!dictionary.TryGetValue(current.Id, out licenseStatus))
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
                        continue;
                      }
                      goto case 9;
                    case 9:
                      if (LicenseManager.EkX8LUxKQNtQEuChFTp((object) licenseInfo) != LicenseStatus.NeedRestart)
                      {
                        num5 = 5;
                        continue;
                      }
                      goto case 10;
                    case 10:
                      if (licenseStatus != LicenseStatus.DateExpired)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 11 : 10;
                        continue;
                      }
                      goto case 6;
                    case 11:
                      if (licenseStatus == LicenseStatus.NotActivated)
                      {
                        num5 = 6;
                        continue;
                      }
                      goto label_76;
                    case 12:
                      licenseInfo = (ILicenseInfo) LicenseManager.nGqkLYxq32QCKQuKnEn(LicenseManager.nu232ExRAPcQv67yJNh((object) current));
                      num5 = 4;
                      continue;
                    default:
                      goto label_76;
                  }
                }
label_74:
                current = enumerator1.Current;
                num5 = 6;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
                {
                  num5 = 12;
                  goto label_71;
                }
                else
                  goto label_71;
label_77:
                num5 = 2;
                goto label_71;
              }
              finally
              {
                enumerator1.Dispose();
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                }
              }
            case 13:
              if (((PackageService) LicenseManager.EmMjTAxSivZZ8JQCJuw(LicenseManager.GYlD3kxFsbFPaMUdH9H())).Initialized)
              {
                IEnumerable<IStoreComponentInfo> storeComponentsInfo = ((PackageService) LicenseManager.EmMjTAxSivZZ8JQCJuw((object) ComponentManager.Current)).GetStoreComponentsInfo(false);
                // ISSUE: reference to a compiler-generated field
                Func<IStoreComponentInfo, bool> func = LicenseManager.\u003C\u003Ec.\u003C\u003E9__5_0;
                Func<IStoreComponentInfo, bool> predicate;
                if (func == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  LicenseManager.\u003C\u003Ec.\u003C\u003E9__5_0 = predicate = (Func<IStoreComponentInfo, bool>) (i =>
                  {
                    int num7 = 1;
                    while (true)
                    {
                      switch (num7)
                      {
                        case 1:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          if (LicenseManager.\u003C\u003Ec.EREOElfgXOU9PMRingLw(LicenseManager.\u003C\u003Ec.s1fDH1fgK9Mim2TNtwEe((object) i)))
                          {
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
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
                    // ISSUE: reference to a compiler-generated method
                    return LicenseManager.\u003C\u003Ec.E6lv1wfgTFnL8rGQ46bd((object) i) != null;
label_5:
                    return false;
                  });
                }
                else
                  goto label_103;
label_100:
                storeComponentInfoList3 = storeComponentsInfo.Where<IStoreComponentInfo>(predicate).ToList<IStoreComponentInfo>();
                break;
label_103:
                predicate = func;
                goto label_100;
              }
              else
                goto label_61;
            case 14:
              IEnumerable<ModuleManager.StoreComponentConfigurationInfo> installedComponentInfos = moduleManager.GetInstalledComponentInfos();
              this.GetActivationKeys().Select<KeyValuePair<Guid, string>, string>((Func<KeyValuePair<Guid, string>, string>) (p => p.Value)).ToList<string>();
              enumerator2 = installedComponentInfos.GetEnumerator();
              num2 = 7;
              continue;
            case 15:
              try
              {
label_36:
                if (enumerator3.MoveNext())
                  goto label_38;
                else
                  goto label_37;
label_35:
                int num8;
                switch (num8)
                {
                  case 1:
                    goto label_94;
                  case 2:
                    goto label_36;
                  default:
                    goto label_38;
                }
label_37:
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 1;
                goto label_35;
label_38:
                LicenseManager.HdwJbhxE85w0bWoRBxw((object) enumerator3.Current, uid, (object) key);
                num8 = 2;
                goto label_35;
              }
              finally
              {
                enumerator3.Dispose();
                int num9 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
                  num9 = 0;
                switch (num9)
                {
                  default:
                }
              }
            case 16:
            case 18:
label_43:
              if (storeComponentInfoList1 == null)
              {
                num2 = 26;
                continue;
              }
              goto case 4;
            case 17:
              if (moduleManager == null)
              {
                num2 = 18;
                continue;
              }
              goto case 14;
            case 19:
              goto label_18;
            case 20:
              storeComponentInfoList3 = (List<IStoreComponentInfo>) null;
              break;
            case 21:
              if (storeComponentInfoList1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 8 : 9;
                continue;
              }
              goto case 23;
            case 22:
              LicenseManager.HOACPJxoEeommuEZBwq((object) (ILicensedUnit) LicenseManager.vy8mIgxW2G9BBrfXwRJ(LicenseManager.sUquw7xBKQl5bG7C2hM(LicenseManager.GYlD3kxFsbFPaMUdH9H())), (object) key);
              num2 = 11;
              continue;
            case 23:
label_67:
              enumerator3 = this._storages.GetEnumerator();
              num2 = 15;
              continue;
            case 24:
              try
              {
label_51:
                if (enumerator1.MoveNext())
                  goto label_50;
                else
                  goto label_52;
label_49:
                IStoreComponentInfo current;
                int num10;
                while (true)
                {
                  switch (num10)
                  {
                    case 1:
                      goto label_50;
                    case 2:
                      LicenseManager.Douf6RxXJCBvwCbAXCe(LicenseManager.sUquw7xBKQl5bG7C2hM(LicenseManager.GYlD3kxFsbFPaMUdH9H()), (object) current, StoreComponentStatus.Allowed);
                      num10 = 3;
                      continue;
                    case 3:
                      goto label_51;
                    default:
                      goto label_63;
                  }
                }
label_50:
                current = enumerator1.Current;
                num10 = 2;
                goto label_49;
label_52:
                num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
                goto label_49;
              }
              finally
              {
                enumerator1.Dispose();
                int num11 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
                  num11 = 0;
                switch (num11)
                {
                  default:
                }
              }
            case 25:
              try
              {
label_11:
                if (enumerator1.MoveNext())
                  goto label_6;
                else
                  goto label_12;
label_4:
                IStoreComponentInfo current;
                int num12;
                while (true)
                {
                  ILicenseInfo licenseInfo;
                  switch (num12)
                  {
                    case 1:
                      goto label_67;
                    case 2:
                      goto label_6;
                    case 3:
                    case 5:
                      goto label_11;
                    case 4:
                      if (licenseInfo == null)
                      {
                        num12 = 5;
                        continue;
                      }
                      break;
                    case 6:
                      licenseInfo = current.LicensedUnit.GetLicenseInfo();
                      num12 = 4;
                      continue;
                  }
                  dictionary[(string) LicenseManager.IwtDhsxiO1SBB6i3q4u((object) current)] = licenseInfo.Status;
                  num12 = 3;
                }
label_6:
                current = enumerator1.Current;
                num12 = 6;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
                {
                  num12 = 1;
                  goto label_4;
                }
                else
                  goto label_4;
label_12:
                num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 1;
                goto label_4;
              }
              finally
              {
                enumerator1.Dispose();
                int num13 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
                  num13 = 0;
                switch (num13)
                {
                  default:
                }
              }
            default:
              dictionary = new Dictionary<string, LicenseStatus>();
              num2 = 13;
              continue;
          }
          storeComponentInfoList1 = storeComponentInfoList3;
          num2 = 21;
        }
label_61:
        num1 = 20;
      }
label_18:
      return uid;
    }

    public void RemoveActivationKey(Guid keyUid)
    {
      int num1 = 2;
      List<IActivationKeyStorage>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_14;
          case 1:
            goto label_3;
          case 2:
            enumerator = this._storages.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
            continue;
          default:
            goto label_10;
        }
      }
label_14:
      return;
label_10:
      return;
label_3:
      try
      {
label_8:
        if (enumerator.MoveNext())
          goto label_6;
        else
          goto label_9;
label_4:
        int num2;
        switch (num2)
        {
          case 1:
            break;
          case 2:
            return;
          default:
            goto label_8;
        }
label_6:
        LicenseManager.OWXBksxTyfTwBKrn13t((object) enumerator.Current, keyUid);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0)
        {
          num2 = 0;
          goto label_4;
        }
        else
          goto label_4;
label_9:
        num2 = 2;
        goto label_4;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    public Dictionary<Guid, string> GetActivationKeys()
    {
      Dictionary<Guid, string> activationKeys1 = new Dictionary<Guid, string>();
      foreach (IActivationKeyStorage storage in this._storages)
      {
        Dictionary<Guid, string> activationKeys2 = storage.GetActivationKeys();
        if (activationKeys2 != null)
        {
          foreach (KeyValuePair<Guid, string> keyValuePair in activationKeys2)
            activationKeys1[keyValuePair.Key] = keyValuePair.Value;
        }
      }
      return activationKeys1;
    }

    /// <summary>Можно ли добавлять ключ активации</summary>
    /// <returns></returns>
    public bool CanAddActivationKey() => false;

    public string GetActivationToken()
    {
      int num1 = 14;
      List<Tuple<byte[], ActivationToken>> tupleList;
      MemoryStream memoryStream;
      while (true)
      {
        byte[] activationToken1;
        IEnumerator<ModuleManager.StoreComponentConfigurationInfo> enumerator;
        byte[] byteArray;
        ModuleManager moduleManager1;
        IModuleManager moduleManager2;
        ActivationToken activationToken2;
        ActivationToken activationToken3;
        object obj;
        switch (num1)
        {
          case 1:
            activationToken1 = RSALicense.GetActivationToken(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951479718), VersionInfo.GetVersion<EleWise.ELMA.SR>().ToString(), (IEnumerable<StoreComponentSignatureInfo>) new List<StoreComponentSignatureInfo>());
            num1 = 18;
            continue;
          case 2:
            goto label_22;
          case 3:
            if (moduleManager1 != null)
            {
              num1 = 6;
              continue;
            }
            goto case 4;
          case 4:
label_80:
            byteArray = this.ceUid.ToByteArray();
            num1 = 8;
            continue;
          case 5:
            try
            {
label_11:
              if (LicenseManager.IF0SLoxhTL68yY2Xrq8((object) enumerator))
                goto label_10;
              else
                goto label_12;
label_6:
              ActivationToken activationToken4;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_10;
                  case 2:
                    tupleList.Add(new Tuple<byte[], ActivationToken>((byte[]) null, activationToken4));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 4 : 4;
                    continue;
                  case 3:
                    if (activationToken4 != null)
                    {
                      num2 = 2;
                      continue;
                    }
                    goto label_11;
                  case 4:
                    goto label_11;
                  default:
                    goto label_80;
                }
              }
label_10:
              activationToken4 = (ActivationToken) LicenseManager.J412SpxkiQngeR7Dpuo((object) enumerator.Current);
              num2 = 3;
              goto label_6;
label_12:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
              goto label_6;
            }
            finally
            {
              if (enumerator != null)
              {
                int num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      enumerator.Dispose();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_18;
                  }
                }
              }
label_18:;
            }
          case 6:
            IEnumerable<ModuleManager.StoreComponentConfigurationInfo> installedComponentInfos = moduleManager1.GetInstalledComponentInfos();
            this.GetActivationKeys().Select<KeyValuePair<Guid, string>, string>((Func<KeyValuePair<Guid, string>, string>) (p => p.Value)).ToList<string>();
            enumerator = installedComponentInfos.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 5 : 4;
            continue;
          case 7:
            if (moduleManager2 != null)
            {
              num1 = 15;
              continue;
            }
            goto label_82;
          case 8:
            tupleList.Add(new Tuple<byte[], ActivationToken>(byteArray, (ActivationToken) null));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 10 : 2;
            continue;
          case 9:
            activationToken3 = new ActivationToken();
            activationToken3.Token = activationToken1;
            goto label_89;
          case 10:
            memoryStream = (MemoryStream) LicenseManager.MbWq3LxnlZ5JAGm0I74();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 2;
            continue;
          case 11:
            goto label_4;
          case 12:
            moduleManager1 = moduleManager2 as ModuleManager;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 3 : 0;
            continue;
          case 13:
            obj = (object) null;
            break;
          case 14:
            if (!LicenseManager.PwD7utxvSNhiZg0SNmf())
            {
              num1 = 13;
              continue;
            }
            obj = LicenseManager.sUquw7xBKQl5bG7C2hM(LicenseManager.GYlD3kxFsbFPaMUdH9H());
            break;
          case 15:
            tupleList = new List<Tuple<byte[], ActivationToken>>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 1;
            continue;
          case 16:
            goto label_82;
          case 17:
            activationToken3 = (ActivationToken) null;
            goto label_89;
          case 18:
            if (activationToken1 != null)
            {
              num1 = 9;
              continue;
            }
            goto case 17;
          default:
            tupleList.Add(new Tuple<byte[], ActivationToken>((byte[]) null, activationToken2));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 2 : 12;
            continue;
        }
        moduleManager2 = (IModuleManager) obj;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 7 : 5;
        continue;
label_89:
        activationToken2 = activationToken3;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
      }
label_4:
      string activationToken5;
      return activationToken5;
label_22:
      try
      {
        LicenseManager.trMAUsxOZKiga6pwlsn((object) memoryStream, byte.MaxValue);
        int num4 = 6;
        List<Tuple<byte[], ActivationToken>>.Enumerator enumerator;
        byte num5;
        SHA1 shA1;
        while (true)
        {
          switch (num4)
          {
            case 1:
              try
              {
                memoryStream.Seek(0L, SeekOrigin.Begin);
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
                  num6 = 0;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_25;
                    default:
                      num5 = (byte) LicenseManager.g27XNDxNMBNSL1FPiHc((object) shA1, (object) memoryStream)[0];
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
              finally
              {
                int num7;
                if (shA1 == null)
                  num7 = 2;
                else
                  goto label_62;
label_61:
                switch (num7)
                {
                  case 1:
                  case 2:
                }
label_62:
                LicenseManager.HUb4Y7xG6OYhP7kZrHH((object) shA1);
                num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
                {
                  num7 = 1;
                  goto label_61;
                }
                else
                  goto label_61;
              }
            case 2:
              try
              {
label_36:
                if (enumerator.MoveNext())
                  goto label_41;
                else
                  goto label_37;
label_28:
                byte[] numArray1;
                ActivationToken activationToken6;
                int num8;
                while (true)
                {
                  int num9;
                  ActivationToken activationToken7;
                  byte[] buffer;
                  byte[] numArray2;
                  byte[] numArray3;
                  switch (num8)
                  {
                    case 1:
                    case 15:
                      if (numArray2 == null)
                      {
                        num8 = 12;
                        continue;
                      }
                      goto case 19;
                    case 2:
                      goto label_66;
                    case 3:
                      LicenseManager.qEClV3xPXiMQElSDT49((object) memoryStream, LicenseManager.PTGmJrx2ajRlLyFedNH((object) activationToken7), 0, activationToken7.Token.Length);
                      num8 = 4;
                      continue;
                    case 4:
                    case 5:
                    case 11:
                    case 12:
                      goto label_36;
                    case 6:
                      numArray3 = activationToken7.Token;
                      goto label_49;
                    case 7:
                      LicenseManager.trMAUsxOZKiga6pwlsn((object) memoryStream, (byte) numArray2.Length);
                      num8 = 14;
                      continue;
                    case 8:
                      activationToken7 = activationToken6;
                      num9 = 18;
                      break;
                    case 9:
label_31:
                      memoryStream.WriteByte(byte.MaxValue);
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 10 : 8;
                      continue;
                    case 10:
                      buffer = (byte[]) LicenseManager.f4JkSrxecLtcIQ9subs(LicenseManager.PTGmJrx2ajRlLyFedNH((object) activationToken7).Length);
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
                      continue;
                    case 13:
                      numArray2 = numArray1;
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 8 : 6;
                      continue;
                    case 14:
                      LicenseManager.qEClV3xPXiMQElSDT49((object) memoryStream, (object) numArray2, 0, numArray2.Length);
                      num8 = 5;
                      continue;
                    case 16:
                      numArray3 = (byte[]) null;
                      goto label_49;
                    case 17:
                      goto label_41;
                    case 18:
                      if (activationToken7 != null)
                      {
                        num8 = 6;
                        continue;
                      }
                      goto case 16;
                    case 19:
                      if (numArray2.Length >= (int) byte.MaxValue)
                      {
                        num9 = 11;
                        break;
                      }
                      goto case 7;
                    default:
                      memoryStream.Write(buffer, 0, 4);
                      num8 = 3;
                      continue;
                  }
                  num8 = num9;
                  continue;
label_49:
                  if (numArray3 == null)
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
                  else
                    goto label_31;
                }
label_37:
                num8 = 2;
                goto label_28;
label_41:
                enumerator.Current.Deconstruct<byte[], ActivationToken>(out numArray1, out activationToken6);
                num8 = 10;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
                {
                  num8 = 13;
                  goto label_28;
                }
                else
                  goto label_28;
              }
              finally
              {
                enumerator.Dispose();
                int num10 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
                  num10 = 0;
                switch (num10)
                {
                  default:
                }
              }
            case 3:
label_25:
              activationToken5 = MemoryHelper.ActionWithMemoryBuffer<byte, (MemoryStream, byte), string>((int) LicenseManager.pogS9Jx31JnInfIYjlq((object) memoryStream) + 1, (memoryStream, num5), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (MemoryStream, byte), string>(this.GetActivationTokenAction));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 4 : 0;
              continue;
            case 4:
              goto label_4;
            case 5:
label_66:
              shA1 = (SHA1) LicenseManager.N8W2rux1RbeQwfKMM25();
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 1;
              continue;
            case 6:
              LicenseManager.trMAUsxOZKiga6pwlsn((object) memoryStream, (byte) 0);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
              continue;
            default:
              enumerator = tupleList.GetEnumerator();
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 2 : 1;
              continue;
          }
        }
      }
      finally
      {
        int num11;
        if (memoryStream == null)
          num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
        else
          goto label_70;
label_69:
        switch (num11)
        {
          case 2:
            break;
          default:
        }
label_70:
        LicenseManager.HUb4Y7xG6OYhP7kZrHH((object) memoryStream);
        num11 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        {
          num11 = 0;
          goto label_69;
        }
        else
          goto label_69;
      }
label_82:
      return string.Empty;
    }

    private string GetActivationTokenAction(
      byte[] buffer,
      int offset,
      int length,
      (MemoryStream, byte) param)
    {
      (MemoryStream memoryStream, byte num) = param;
      buffer[offset] = num;
      memoryStream.Seek(0L, SeekOrigin.Begin);
      memoryStream.Read(buffer, offset + 1, (int) memoryStream.Length);
      return Convert.ToBase64String(buffer, offset, length);
    }

    internal LicenseManager(IEnumerable<IActivationKeyStorage> storages)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.ceUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70003264));
      this._storages = new List<IActivationKeyStorage>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this._storages.Add((IActivationKeyStorage) new RegistryActivationKeyStorage(Registry.LocalMachine));
      this._storages.Add((IActivationKeyStorage) new RegistryActivationKeyStorage(Registry.CurrentUser));
      if (storages == null)
        return;
      this._storages.AddRange(storages);
    }

    private static ActivationToken GetStoreComponentToken(object info)
    {
      int num1 = 13;
      byte[] activationToken;
      IActivationTokenContainer licensedUnit;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              licensedUnit = ((ModuleManager.StoreComponentConfigurationInfo) info).LicensedUnit as IActivationTokenContainer;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 3 : 5;
              continue;
            case 2:
              goto label_20;
            case 3:
            case 4:
            case 8:
              goto label_4;
            case 5:
              if (licensedUnit != null)
              {
                num2 = 7;
                continue;
              }
              goto label_11;
            case 6:
              if (((ModuleManager.StoreComponentConfigurationInfo) info).Signatures.Any<StoreComponentSignatureInfo>())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 7:
              goto label_10;
            case 9:
              if (((ModuleManager.StoreComponentConfigurationInfo) info).Signatures == null)
              {
                num2 = 3;
                continue;
              }
              goto case 6;
            case 10:
              if (activationToken != null)
              {
                num2 = 2;
                continue;
              }
              goto label_19;
            case 11:
              goto label_19;
            case 12:
              if (LicenseManager.oKyVDdxpJhKM8iHamVL(info) == null)
              {
                num2 = 4;
                continue;
              }
              goto case 9;
            case 13:
              goto label_3;
            default:
              if (LicenseManager.DHciRixaykIvh3IWfHY(LicenseManager.oKyVDdxpJhKM8iHamVL(info)) == ElmaStoreComponentActivationType.Paid)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
                continue;
              }
              activationToken = RSALicense.GetActivationToken((string) LicenseManager.BgJrkaxtkbgJOLjMlPG(LicenseManager.oKyVDdxpJhKM8iHamVL(info)), ((ElmaStoreComponentManifest) LicenseManager.oKyVDdxpJhKM8iHamVL(info)).Version, ((ModuleManager.StoreComponentConfigurationInfo) info).Signatures);
              num2 = 10;
              continue;
          }
        }
label_3:
        LicenseManager.YZELWPxZ15yP5pSwiwK(info, LicenseManager.jIm3vOxQ1Nph7dkSsDe(1574260816 ^ 1574249750));
        num1 = 12;
      }
label_4:
      return (ActivationToken) null;
label_10:
      return (ActivationToken) LicenseManager.T0GyjlxD6foWRJh3oGP((object) licensedUnit);
label_11:
      return (ActivationToken) null;
label_19:
      return (ActivationToken) null;
label_20:
      ActivationToken storeComponentToken = new ActivationToken();
      LicenseManager.FWoCrAxw0LTPHaLgXsZ((object) storeComponentToken, (object) activationToken);
      return storeComponentToken;
    }

    internal static object GYlD3kxFsbFPaMUdH9H() => (object) ComponentManager.Current;

    internal static object sUquw7xBKQl5bG7C2hM([In] object obj0) => (object) ((ComponentManager) obj0).ModuleManager;

    internal static object vy8mIgxW2G9BBrfXwRJ([In] object obj0) => (object) ((IModuleManager) obj0).MainApplication;

    internal static void HOACPJxoEeommuEZBwq([In] object obj0, [In] object obj1) => ((ILicensedUnit) obj0).ApplyActivationKey((string) obj1);

    internal static object QBblr2xbjVGrH2lNhXJ([In] object obj0) => (object) ((ModuleManager.StoreComponentConfigurationInfo) obj0).LicensedUnit;

    internal static bool IF0SLoxhTL68yY2Xrq8([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void HUb4Y7xG6OYhP7kZrHH([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void HdwJbhxE85w0bWoRBxw([In] object obj0, Guid uid, [In] object obj2) => ((IActivationKeyStorage) obj0).AddActivationKey(uid, (string) obj2);

    internal static object ErPGRNxf5eu0boxBCK6() => (object) Logger.Log;

    internal static object jIm3vOxQ1Nph7dkSsDe(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void iDQaxLxC9Ni6L1esHyh([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static bool giG4Wv7cZn3BZMj7QEg() => LicenseManager.sK2gpJ7sIIbXvDZrPcW == null;

    internal static LicenseManager Y4a3WM7zLV6vQ8oKtUf() => LicenseManager.sK2gpJ7sIIbXvDZrPcW;

    internal static bool PwD7utxvSNhiZg0SNmf() => ComponentManager.Initialized;

    internal static object WClOgRx8woilMtmPk6w([In] object obj0) => (object) ((IModuleManager) obj0).MainLicensedUnit;

    internal static void YZELWPxZ15yP5pSwiwK([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object Y0Atb8xuor24lMwISE3([In] object obj0) => (object) ((ILicensedUnit) obj0).GetRegistrationKey();

    internal static void rNEqJpxI4xEvdq01QTm([In] object obj0) => ((ILicensedUnit) obj0).UpdateLicenseInfo();

    internal static void QXfZpCxVUbicqIPPoep([In] object obj0) => ((ILicensedUnit) obj0).CompleteLicensingInitialize();

    internal static object EmMjTAxSivZZ8JQCJuw([In] object obj0) => (object) ((ComponentManager) obj0).PackageService;

    internal static object IwtDhsxiO1SBB6i3q4u([In] object obj0) => (object) ((IStoreComponentInfo) obj0).Id;

    internal static object nu232ExRAPcQv67yJNh([In] object obj0) => (object) ((IStoreComponentInfo) obj0).LicensedUnit;

    internal static object nGqkLYxq32QCKQuKnEn([In] object obj0) => (object) ((ILicensedUnit) obj0).GetLicenseInfo();

    internal static LicenseStatus EkX8LUxKQNtQEuChFTp([In] object obj0) => ((ILicenseInfo) obj0).Status;

    internal static void Douf6RxXJCBvwCbAXCe([In] object obj0, [In] object obj1, StoreComponentStatus status) => ((IModuleManager) obj0).SaveStoreComponentInfo((IStoreComponentInfo) obj1, status);

    internal static void OWXBksxTyfTwBKrn13t([In] object obj0, Guid uid) => ((IActivationKeyStorage) obj0).RemoveActivationKey(uid);

    internal static object J412SpxkiQngeR7Dpuo([In] object obj0) => (object) LicenseManager.GetStoreComponentToken(obj0);

    internal static object MbWq3LxnlZ5JAGm0I74() => (object) MemoryHelper.GetMemoryStream();

    internal static void trMAUsxOZKiga6pwlsn([In] object obj0, [In] byte obj1) => ((Stream) obj0).WriteByte(obj1);

    internal static object PTGmJrx2ajRlLyFedNH([In] object obj0) => (object) ((ActivationToken) obj0).Token;

    internal static object f4JkSrxecLtcIQ9subs([In] int obj0) => (object) BitConverter.GetBytes(obj0);

    internal static void qEClV3xPXiMQElSDT49([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3) => ((Stream) obj0).Write((byte[]) obj1, obj2, obj3);

    internal static object N8W2rux1RbeQwfKMM25() => (object) SHA1.Create();

    internal static object g27XNDxNMBNSL1FPiHc([In] object obj0, [In] object obj1) => (object) ((HashAlgorithm) obj0).ComputeHash((Stream) obj1);

    internal static long pogS9Jx31JnInfIYjlq([In] object obj0) => ((Stream) obj0).Length;

    internal static object oKyVDdxpJhKM8iHamVL([In] object obj0) => (object) ((ModuleManager.StoreComponentConfigurationInfo) obj0).Manifest;

    internal static ElmaStoreComponentActivationType DHciRixaykIvh3IWfHY([In] object obj0) => ((ElmaStoreComponentManifest) obj0).ActivationType;

    internal static object T0GyjlxD6foWRJh3oGP([In] object obj0) => (object) ((IActivationTokenContainer) obj0).GetActivationToken();

    internal static object BgJrkaxtkbgJOLjMlPG([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Id;

    internal static void FWoCrAxw0LTPHaLgXsZ([In] object obj0, [In] object obj1) => ((ActivationToken) obj0).Token = (byte[]) obj1;
  }
}
