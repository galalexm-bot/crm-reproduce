// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Mappings.ReplaceUidsAtPropertyMapService.ReplaceUidAtPropertyMapServiceStub
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Mappings.ReplaceUidsAtPropertyMapService
{
  /// <summary>
  /// Заглушка для точки расширения по замене UID-ов в сервисе маппинга
  /// </summary>
  internal sealed class ReplaceUidAtPropertyMapServiceStub : IReplaceUidAtPropertyMapServiceExtension
  {
    private static ReplaceUidAtPropertyMapServiceStub topV5Ahh0OHlLv4avOPk;

    /// <inheritdoc />
    public void Init(object objLeft, object objRight)
    {
    }

    /// <inheritdoc />
    public bool GetUidReplace(Guid uid, out Guid? newUid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            newUid = new Guid?();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return false;
    }

    /// <inheritdoc />
    public void EndWork()
    {
    }

    public ReplaceUidAtPropertyMapServiceStub()
    {
      ReplaceUidAtPropertyMapServiceStub.V8WyIPhhM3XBD0bYfuce();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool CRJx5thhmkwwB4KZ9PiA() => ReplaceUidAtPropertyMapServiceStub.topV5Ahh0OHlLv4avOPk == null;

    internal static ReplaceUidAtPropertyMapServiceStub CfH2T0hhyL7hRBwiYMOD() => ReplaceUidAtPropertyMapServiceStub.topV5Ahh0OHlLv4avOPk;

    internal static void V8WyIPhhM3XBD0bYfuce() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
