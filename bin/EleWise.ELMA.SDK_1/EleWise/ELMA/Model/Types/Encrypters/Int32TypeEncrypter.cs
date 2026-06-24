// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Encrypters.Int32TypeEncrypter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Encrypters
{
  [Component]
  public class Int32TypeEncrypter : BaseTypeEncrypter
  {
    private static Int32TypeEncrypter G177WkoLVHTslEvMa6mH;

    public override bool CheckType(object obj, IMetadata propertyMetadata)
    {
      int num = 1;
      PropertyMetadata propertyMetadata1;
      while (true)
      {
        switch (num)
        {
          case 1:
            propertyMetadata1 = propertyMetadata as PropertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            if (propertyMetadata1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 2 : 2;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      return propertyMetadata1.TypeUid == Int32Descriptor.UID;
label_3:
      return false;
    }

    protected override string ObjectToString(object obj, IMetadata propertyMetadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            if (Int32TypeEncrypter.Q4gGBQoLRq4mh1U9Cbfk((object) (PropertyMetadata) propertyMetadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 1;
              continue;
            }
            goto label_8;
          case 3:
            goto label_6;
          default:
            goto label_7;
        }
      }
label_6:
      return string.Empty;
label_7:
      return base.ObjectToString((object) Int32TypeEncrypter.EXKCVUoLqqde80h8w7NL(obj), propertyMetadata);
label_8:
      return base.ObjectToString(obj, propertyMetadata);
    }

    protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!Int32TypeEncrypter.ibSCQvoLKxHOMn0W0Zd6((object) obj))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            if (Int32TypeEncrypter.Q4gGBQoLRq4mh1U9Cbfk((object) (PropertyMetadata) propertyMetadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 1 : 1;
              continue;
            }
            goto label_7;
          case 3:
            goto label_6;
          default:
            goto label_7;
        }
      }
label_6:
      return (object) null;
label_7:
      return (object) Int32TypeEncrypter.O4tJKvoLXKCfwx3AlwqT((object) obj);
    }

    public Int32TypeEncrypter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool a9jMVBoLS9crwgCuSe2P() => Int32TypeEncrypter.G177WkoLVHTslEvMa6mH == null;

    internal static Int32TypeEncrypter ncqGDcoLiA2Eirjd8srQ() => Int32TypeEncrypter.G177WkoLVHTslEvMa6mH;

    internal static bool Q4gGBQoLRq4mh1U9Cbfk([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static int EXKCVUoLqqde80h8w7NL([In] object obj0) => Convert.ToInt32(obj0);

    internal static bool ibSCQvoLKxHOMn0W0Zd6([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static int O4tJKvoLXKCfwx3AlwqT([In] object obj0) => Convert.ToInt32((string) obj0);
  }
}
