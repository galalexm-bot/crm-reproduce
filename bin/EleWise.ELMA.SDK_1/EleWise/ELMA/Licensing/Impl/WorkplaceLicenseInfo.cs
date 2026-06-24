// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.Impl.WorkplaceLicenseInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Licensing.Impl
{
  public class WorkplaceLicenseInfo : LicenseInfo, IWorkplaceLicenseInfo, ILicenseInfo
  {
    internal static WorkplaceLicenseInfo gYgWXV7jsgoSFPTQWYE;

    public WorkplaceLicenseInfo(object owner)
    {
      WorkplaceLicenseInfo.OWntKT7UOqBSAVPpGeP();
      // ISSUE: explicit constructor call
      base.\u002Ector(owner);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public uint? WorkplaceCount { get; set; }

    public uint UsedLicenseCount
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.Owner is IWorkplaceLicenseInfoOwner)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
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
        return 0;
label_5:
        return ((IWorkplaceLicenseInfoOwner) this.Owner).UsedLicenseCount;
      }
    }

    internal static void OWntKT7UOqBSAVPpGeP() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool tqWFDf7Yqe3X9KVrRng() => WorkplaceLicenseInfo.gYgWXV7jsgoSFPTQWYE == null;

    internal static WorkplaceLicenseInfo Kb5QeC7LZjZejTRI4UK() => WorkplaceLicenseInfo.gYgWXV7jsgoSFPTQWYE;
  }
}
