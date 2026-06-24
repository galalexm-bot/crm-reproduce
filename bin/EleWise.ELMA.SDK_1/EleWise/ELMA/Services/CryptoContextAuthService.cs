// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.CryptoContextAuthService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services
{
  [Service(Type = ComponentType.WebServer, InjectProperties = true, Scope = ServiceScope.Shell, EnableInterceptors = false)]
  public class CryptoContextAuthService : ICryptoContextAuthService
  {
    internal static CryptoContextAuthService qDEAlQBHqKOGFFXss0XZ;

    protected ICryptoContextAuthServiceImpl GetImpl(IEntity entity)
    {
      int num = 3;
      ICryptoContextAuthServiceImpl impl;
      IEntity entity1;
      while (true)
      {
        switch (num)
        {
          case 1:
            impl = ((ComponentManager) CryptoContextAuthService.gAmdgqBHT5JqrNQb2VwY()).GetExtensionPoints<ICryptoContextAuthServiceImpl>().FirstOrDefault<ICryptoContextAuthServiceImpl>((Func<ICryptoContextAuthServiceImpl, bool>) (p => p.CheckType(entity1)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          case 2:
            entity1 = entity;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 0;
            continue;
          case 3:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 2 : 1;
            continue;
          case 4:
            goto label_4;
          case 5:
            goto label_5;
          default:
            if (impl != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 4 : 5;
              continue;
            }
            goto label_4;
        }
      }
label_4:
      throw new Exception(EleWise.ELMA.SR.T((string) CryptoContextAuthService.spTj7MBHkNMVxw1NYsve(-97972138 ^ -98023382), (object) entity1.GetType()));
label_5:
      return impl;
    }

    public bool SignInForEntity(IEntity entity, string password)
    {
      int num = 2;
      ICryptoContextAuthServiceImpl impl;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (impl == null)
            {
              num = 3;
              continue;
            }
            goto label_2;
          case 2:
            impl = this.GetImpl(entity);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return CryptoContextAuthService.kj5riaBHnJNTEwpg5HNi((object) impl, (object) entity, (object) password);
label_3:
      return false;
    }

    public bool IsSignForEntity(IEntity entity)
    {
      int num = 3;
      ICryptoContextAuthServiceImpl impl;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (impl == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 3:
            impl = this.GetImpl(entity);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 2 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return CryptoContextAuthService.J0nLBHBHOKbKQI6aGTtJ((object) impl, (object) entity);
label_6:
      return false;
    }

    public void SignOutForEntity(IEntity entity)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        ICryptoContextAuthServiceImpl impl;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              goto label_3;
            case 3:
              if (impl != null)
                break;
              goto label_5;
            case 4:
              goto label_7;
          }
          CryptoContextAuthService.f45WMgBH2IW2xaVEyMY3((object) impl, (object) entity);
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 1;
        }
label_5:
        num1 = 2;
        continue;
label_7:
        impl = this.GetImpl(entity);
        num1 = 3;
      }
label_6:
      return;
label_3:;
    }

    public IEntity DecryptFromContext(IEntity entity)
    {
      int num = 3;
      ICryptoContextAuthServiceImpl impl;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (impl == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
              continue;
            }
            goto label_3;
          case 3:
            impl = this.GetImpl(entity);
            num = 2;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (IEntity) CryptoContextAuthService.crG5X0BHe22dsPJyn7qe((object) impl, (object) entity);
label_4:
      return (IEntity) null;
    }

    public string GetPasswordFromContext(IEntity entity)
    {
      int num = 2;
      ICryptoContextAuthServiceImpl impl;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (impl == null)
            {
              num = 3;
              continue;
            }
            goto label_3;
          case 2:
            impl = this.GetImpl(entity);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_4;
          default:
            goto label_3;
        }
      }
label_3:
      return (string) CryptoContextAuthService.iPQ9vqBHPed7PmgZRXnU((object) impl, (object) entity);
label_4:
      return (string) null;
    }

    public CryptoContextAuthService()
    {
      CryptoContextAuthService.BhhtR0BH1VXBK6QbDoB4();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object gAmdgqBHT5JqrNQb2VwY() => (object) ComponentManager.Current;

    internal static object spTj7MBHkNMVxw1NYsve(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool e8tebLBHKcI0DBpIbQdm() => CryptoContextAuthService.qDEAlQBHqKOGFFXss0XZ == null;

    internal static CryptoContextAuthService PIFMrTBHXEA8MuQRoeTh() => CryptoContextAuthService.qDEAlQBHqKOGFFXss0XZ;

    internal static bool kj5riaBHnJNTEwpg5HNi([In] object obj0, [In] object obj1, [In] object obj2) => ((ICryptoContextAuthServiceImpl) obj0).SignInForEntity((IEntity) obj1, (string) obj2);

    internal static bool J0nLBHBHOKbKQI6aGTtJ([In] object obj0, [In] object obj1) => ((ICryptoContextAuthServiceImpl) obj0).IsSignForEntity((IEntity) obj1);

    internal static void f45WMgBH2IW2xaVEyMY3([In] object obj0, [In] object obj1) => ((ICryptoContextAuthServiceImpl) obj0).SignOutForEntity((IEntity) obj1);

    internal static object crG5X0BHe22dsPJyn7qe([In] object obj0, [In] object obj1) => (object) ((ICryptoContextAuthServiceImpl) obj0).DecryptFromContext((IEntity) obj1);

    internal static object iPQ9vqBHPed7PmgZRXnU([In] object obj0, [In] object obj1) => (object) ((ICryptoContextAuthServiceImpl) obj0).GetPasswordFromContext((IEntity) obj1);

    internal static void BhhtR0BH1VXBK6QbDoB4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
