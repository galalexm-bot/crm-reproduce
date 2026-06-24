// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.Impl.ConcurrentLicenseInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Licensing.Impl
{
  public class ConcurrentLicenseInfo : 
    WorkplaceLicenseInfo,
    IConcurrentLicenseInfo,
    IWorkplaceLicenseInfo,
    ILicenseInfo
  {
    private static ConcurrentLicenseInfo TJmRbK727B57KPHYg2i;

    public ConcurrentLicenseInfo(object owner)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(owner);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Является ли текущая лицензия конкурентной</summary>
    public bool IsConcurrent
    {
      get => this.\u003CIsConcurrent\u003Ek__BackingField;
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
              this.\u003CIsConcurrent\u003Ek__BackingField = value;
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

    /// <summary>Количество активированных привилегированных лицензий</summary>
    public uint? PrivilegeCount { get; set; }

    /// <summary>Количество используемых привилегированных лицензий</summary>
    public uint UsedPrivilegeCount
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!(this.Owner is IConcurrentLicenseInfoOwner))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return 0;
label_5:
        return ConcurrentLicenseInfo.baQjTo71sJntx6oslEK((object) (IConcurrentLicenseInfoOwner) this.Owner);
      }
    }

    internal static bool W29s1c7eNJ7dMmKlqZx() => ConcurrentLicenseInfo.TJmRbK727B57KPHYg2i == null;

    internal static ConcurrentLicenseInfo nv90sb7PGdKw3TYGiGs() => ConcurrentLicenseInfo.TJmRbK727B57KPHYg2i;

    internal static uint baQjTo71sJntx6oslEK([In] object obj0) => ((IConcurrentLicenseInfoOwner) obj0).UsedPrivilegeCount;
  }
}
