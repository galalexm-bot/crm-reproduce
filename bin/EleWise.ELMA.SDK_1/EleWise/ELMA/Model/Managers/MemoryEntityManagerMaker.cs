// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.MemoryEntityManagerMaker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Managers
{
  public class MemoryEntityManagerMaker : IManagerMaker
  {
    internal static MemoryEntityManagerMaker iWrsTHhGA7865EpEUW8B;

    public Type MakeManager(Type objectType)
    {
      int num = 2;
      Type entityIdType;
      while (true)
      {
        switch (num)
        {
          case 1:
            entityIdType = ModelHelper.GetEntityIdType(objectType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
            continue;
          case 2:
            if (!MemoryEntityManagerMaker.PQC3IvhG040AP8JxI4C7(objectType, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 1;
              continue;
            }
            goto label_5;
          case 3:
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: type reference
      return MemoryEntityManagerMaker.UpxAQphGyDRmReNBWKp1(__typeref (MemoryEntityManager<,>)).MakeGenericType(objectType, entityIdType);
label_5:
      throw new ArgumentNullException((string) MemoryEntityManagerMaker.t29LathGmWWsAQA9loAW(-1921202237 ^ -1921081647));
    }

    public MemoryEntityManagerMaker()
    {
      MemoryEntityManagerMaker.rwF0S8hGM7BiTIiEKVdk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool PQC3IvhG040AP8JxI4C7([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object t29LathGmWWsAQA9loAW(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type UpxAQphGyDRmReNBWKp1([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool KjtnCShG7jiOqRgmmXD0() => MemoryEntityManagerMaker.iWrsTHhGA7865EpEUW8B == null;

    internal static MemoryEntityManagerMaker YUCucqhGxX0ViUlpeuLm() => MemoryEntityManagerMaker.iWrsTHhGA7865EpEUW8B;

    internal static void rwF0S8hGM7BiTIiEKVdk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
