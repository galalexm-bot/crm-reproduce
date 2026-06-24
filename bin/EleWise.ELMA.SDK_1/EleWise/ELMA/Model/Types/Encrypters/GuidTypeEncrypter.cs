// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Encrypters.GuidTypeEncrypter
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
  public class GuidTypeEncrypter : BaseTypeEncrypter
  {
    private static GuidTypeEncrypter jUiq95oYLgHenxmV3BnP;

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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            goto label_6;
          default:
            if (propertyMetadata1 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 3 : 3;
              continue;
            }
            goto label_5;
        }
      }
label_5:
      return GuidTypeEncrypter.pQsyAIoYzjX1rXyG9gtq(GuidTypeEncrypter.xenl8poYcR5nqQU0DLu7((object) propertyMetadata1), GuidDescriptor.UID);
label_6:
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
            if (obj == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            if (GuidTypeEncrypter.NLvYhkoLF6RYrIoms7fS((object) (PropertyMetadata) propertyMetadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_2;
        }
      }
label_2:
      return string.Empty;
label_3:
      return base.ObjectToString((object) (Guid) obj, propertyMetadata);
label_4:
      return base.ObjectToString(obj, propertyMetadata);
    }

    protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (!GuidTypeEncrypter.c9D8YOoLBiZT8vD6DbXR((object) obj))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 3:
            if (((PropertyMetadata) propertyMetadata).Nullable)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 2;
              continue;
            }
            break;
          case 4:
            goto label_8;
          case 5:
            goto label_2;
        }
        if (!GuidTypeEncrypter.c9D8YOoLBiZT8vD6DbXR((object) obj))
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
        else
          break;
      }
label_2:
      return (object) Guid.Empty;
label_3:
      return (object) new Guid(obj);
label_8:
      return (object) null;
    }

    public GuidTypeEncrypter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid xenl8poYcR5nqQU0DLu7([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static bool pQsyAIoYzjX1rXyG9gtq([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool zVDgeHoYUNQpF962XcyK() => GuidTypeEncrypter.jUiq95oYLgHenxmV3BnP == null;

    internal static GuidTypeEncrypter u9EWUKoYsAmvCFfWeUH9() => GuidTypeEncrypter.jUiq95oYLgHenxmV3BnP;

    internal static bool NLvYhkoLF6RYrIoms7fS([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static bool c9D8YOoLBiZT8vD6DbXR([In] object obj0) => string.IsNullOrEmpty((string) obj0);
  }
}
