// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.Links.LinksDictionary
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import.Links
{
  public class LinksDictionary : List<ILinksDictionaryItem>
  {
    private static LinksDictionary kCdspFEJHJinB3spr2vJ;

    public bool AddLink(LinksDictionaryItem item)
    {
      int num = 8;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (LinksDictionary.Hq78E1EJxgp8KLGLR4Zy((object) item) != Guid.Empty)
            {
              num = 3;
              continue;
            }
            goto label_5;
          case 2:
            if (LinksDictionary.DrHPt7EJmYAlZH66HJ3i(LinksDictionary.xPHVKgEJMFx2mP6TSgvq((object) item), Guid.Empty))
            {
              num = 5;
              continue;
            }
            goto label_5;
          case 3:
            if (!LinksDictionary.DrHPt7EJmYAlZH66HJ3i(LinksDictionary.Hkt9JSEJ09SbYkVdHDcZ((object) item), Guid.Empty))
            {
              num = 6;
              continue;
            }
            break;
          case 4:
            goto label_4;
          case 5:
            this.Add((ILinksDictionaryItem) item);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 4 : 1;
            continue;
          case 6:
          case 7:
            goto label_5;
          case 8:
            if (item == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 6 : 7;
              continue;
            }
            goto case 1;
        }
        if (LinksDictionary.aty2soEJyG1qR1H33PGY((object) item) != Guid.Empty)
          num = 2;
        else
          goto label_5;
      }
label_4:
      return true;
label_5:
      return false;
    }

    public LinksDictionary()
    {
      LinksDictionary.HoTK0DEJJnM2YRWq9uM4();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid Hq78E1EJxgp8KLGLR4Zy([In] object obj0) => ((LinksDictionaryItem) obj0).EntityUid;

    internal static Guid Hkt9JSEJ09SbYkVdHDcZ([In] object obj0) => ((LinksDictionaryItem) obj0).EntityTypeUid;

    internal static bool DrHPt7EJmYAlZH66HJ3i([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static Guid aty2soEJyG1qR1H33PGY([In] object obj0) => ((LinksDictionaryItem) obj0).LinkUid;

    internal static Guid xPHVKgEJMFx2mP6TSgvq([In] object obj0) => ((LinksDictionaryItem) obj0).LinkPropertyUid;

    internal static bool o6yvHFEJA1aCA5NIUFVQ() => LinksDictionary.kCdspFEJHJinB3spr2vJ == null;

    internal static LinksDictionary Mo6vSlEJ7aapy28iqTFF() => LinksDictionary.kCdspFEJHJinB3spr2vJ;

    internal static void HoTK0DEJJnM2YRWq9uM4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
