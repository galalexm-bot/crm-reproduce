// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.FindLinkedObjectsResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Результат поиска связанных объектов</summary>
  public sealed class FindLinkedObjectsResult
  {
    private static FindLinkedObjectsResult kaFXSsbNZsw93eXaeSYl;

    /// <summary>Добавленные объекты</summary>
    public ICollection<ILinkedObject> AddedObjects { get; set; }

    /// <summary>
    /// Связанные объекты, которые необходимо прогнать по проверкам
    /// </summary>
    public ICollection<ILinkedObject> LinkedObjects { get; set; }

    /// <summary>Ctor</summary>
    public FindLinkedObjectsResult()
    {
      FindLinkedObjectsResult.kXCAk1bNV4vJLsLGwliW();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.LinkedObjects = (ICollection<ILinkedObject>) new List<ILinkedObject>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 1;
            continue;
          default:
            this.AddedObjects = (ICollection<ILinkedObject>) new List<ILinkedObject>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 2 : 0;
            continue;
        }
      }
label_3:;
    }

    internal static void kXCAk1bNV4vJLsLGwliW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool DTe69MbNuy40dkDlBVKV() => FindLinkedObjectsResult.kaFXSsbNZsw93eXaeSYl == null;

    internal static FindLinkedObjectsResult dg06ipbNIiUrVavL6cTr() => FindLinkedObjectsResult.kaFXSsbNZsw93eXaeSYl;
  }
}
