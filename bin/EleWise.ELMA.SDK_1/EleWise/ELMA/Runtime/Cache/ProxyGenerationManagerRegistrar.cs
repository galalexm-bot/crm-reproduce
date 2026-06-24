// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Cache.ProxyGenerationManagerRegistrar
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Properties;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Cache
{
  /// <summary>
  /// Компонент для вызова регистрации менеджеров напрямую из <see cref="T:EleWise.ELMA.Model.Managers.ModelRegistrarImpl" />
  /// </summary>
  /// <remarks>
  /// Используется утилитой построения кэшей для прокси системных менеджеров сущностей
  /// </remarks>
  [Component(Type = ComponentType.Test, InjectProerties = true)]
  internal sealed class ProxyGenerationManagerRegistrar : INHManagerRegistrar
  {
    private static ProxyGenerationManagerRegistrar EfxrrWW2c2XpdvUMvIbQ;

    /// <summary>
    /// Текущий <see cref="T:EleWise.ELMA.Runtime.IRuntimeApplication" />
    /// </summary>
    public IRuntimeApplication RuntimeApplication
    {
      get => this.\u003CRuntimeApplication\u003Ek__BackingField;
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
              this.\u003CRuntimeApplication\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
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

    /// <inheritdoc />
    public void Register(NHManagerRegisterParams parameters)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          string str;
          switch (num2)
          {
            case 1:
              IRuntimeApplication runtimeApplication = this.RuntimeApplication;
              if (runtimeApplication == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
                continue;
              }
              object obj1 = ProxyGenerationManagerRegistrar.pycfI1WeBXSGvfVsLA2f((object) runtimeApplication);
              if (obj1 != null)
              {
                object obj2 = ProxyGenerationManagerRegistrar.sZXHx9WeW4QAkusopwpC(obj1);
                if (obj2 == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 6 : 3;
                  continue;
                }
                str = ProxyGenerationManagerRegistrar.cbnArPWeou5Ka7JWMqCx(obj2).FullName;
                break;
              }
              goto label_10;
            case 2:
label_3:
              ((ModelRegistrarImpl) ProxyGenerationManagerRegistrar.L244MZWeQALKBsTcL5vT((object) (ILicensedModuleAssembly) ProxyGenerationManagerRegistrar.vIKBDZWef9GtZvUN2Mlt(ProxyGenerationManagerRegistrar.ICFs2lWeGEmFXyUZPpYY(ProxyGenerationManagerRegistrar.ENHTCYWehNJRL0UyTEtP()), ProxyGenerationManagerRegistrar.t831BaWeEitnfm6VdHDx()))).RegisterEntityManagers(parameters, (IList<Assembly>) null);
              num2 = 5;
              continue;
            case 3:
              goto label_9;
            case 4:
              str = (string) null;
              break;
            case 5:
              goto label_5;
            case 6:
              str = (string) null;
              break;
            default:
              str = (string) null;
              break;
          }
          object obj3 = ProxyGenerationManagerRegistrar.NOnwmoWebUrxByw8juZx(95909607 + 343705423 ^ 439482040);
          if (!(str == (string) obj3))
            num2 = 3;
          else
            goto label_3;
        }
label_10:
        num1 = 4;
      }
label_9:
      return;
label_5:;
    }

    public ProxyGenerationManagerRegistrar()
    {
      ProxyGenerationManagerRegistrar.myf6RnWeC6QteXQHlq9l();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool rVB8kYW2zsGqtigXFUDY() => ProxyGenerationManagerRegistrar.EfxrrWW2c2XpdvUMvIbQ == null;

    internal static ProxyGenerationManagerRegistrar BeB4H8WeF5W2p59VE8h4() => ProxyGenerationManagerRegistrar.EfxrrWW2c2XpdvUMvIbQ;

    internal static object pycfI1WeBXSGvfVsLA2f([In] object obj0) => (object) ((IRuntimeApplication) obj0).TransformationProvider;

    internal static object sZXHx9WeW4QAkusopwpC([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static Type cbnArPWeou5Ka7JWMqCx([In] object obj0) => obj0.GetType();

    internal static object NOnwmoWebUrxByw8juZx(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object ENHTCYWehNJRL0UyTEtP() => (object) ComponentManager.Current;

    internal static object ICFs2lWeGEmFXyUZPpYY([In] object obj0) => (object) ((ComponentManager) obj0).ModuleManager;

    internal static Guid t831BaWeEitnfm6VdHDx() => __AssemblyInfo.UID;

    internal static object vIKBDZWef9GtZvUN2Mlt([In] object obj0, Guid uid) => (object) ((IModuleManager) obj0).FindUnitByUid(uid);

    internal static object L244MZWeQALKBsTcL5vT([In] object obj0) => (object) ((ILicensedModuleAssembly) obj0).LicenseUnit;

    internal static void myf6RnWeC6QteXQHlq9l() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
