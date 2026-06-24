// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Packaging.RequiredInstallStoreComponentsException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Packaging
{
  /// <summary>
  /// Исключение, которое вызывается при необходимости автоматической установки компонентов ELMA Store в систему
  /// </summary>
  [Serializable]
  public class RequiredInstallStoreComponentsException : Exception
  {
    private IEnumerable<IStoreComponentInfo> _componentsInfo;
    internal static RequiredInstallStoreComponentsException hsNVaOBnweMgbCUcKmJP;

    public RequiredInstallStoreComponentsException()
    {
      RequiredInstallStoreComponentsException.EaFrtmBnHdL4wOqPNUrf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public RequiredInstallStoreComponentsException(IEnumerable<IStoreComponentInfo> componentsInfo)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: explicit constructor call
      base.\u002Ector(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218463814), (object) string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867382257), componentsInfo.Select<IStoreComponentInfo, string>((Func<IStoreComponentInfo, string>) (c => string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312515895), RequiredInstallStoreComponentsException.\u003C\u003Ec.RddKKHQVqZHeMtbejUf8(RequiredInstallStoreComponentsException.\u003C\u003Ec.kNUx5BQVRVCZXtVaZTF0((object) c)), RequiredInstallStoreComponentsException.\u003C\u003Ec.El49gQQVT32Pp68uWOuD((object) c.Id, RequiredInstallStoreComponentsException.\u003C\u003Ec.IRKLTjQVK9WIAPYHmHOa(-1824388195 ^ -1824374081), RequiredInstallStoreComponentsException.\u003C\u003Ec.rsTBRmQVXxiamXLBv7GH((object) c))))))));
      this._componentsInfo = componentsInfo != null ? componentsInfo : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70090992));
    }

    /// <summary>Список компонентов для установки</summary>
    public IEnumerable<IStoreComponentInfo> ComponentsInfo => this._componentsInfo;

    internal static void EaFrtmBnHdL4wOqPNUrf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool mUh3mmBn4GlsjwCZMRgP() => RequiredInstallStoreComponentsException.hsNVaOBnweMgbCUcKmJP == null;

    internal static RequiredInstallStoreComponentsException kotQBJBn6YnjUTZ8MCcA() => RequiredInstallStoreComponentsException.hsNVaOBnweMgbCUcKmJP;
  }
}
