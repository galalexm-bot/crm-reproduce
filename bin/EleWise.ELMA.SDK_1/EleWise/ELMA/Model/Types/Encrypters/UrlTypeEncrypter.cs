// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Encrypters.UrlTypeEncrypter
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
  public class UrlTypeEncrypter : BaseTypeEncrypter
  {
    internal static UrlTypeEncrypter DpSaJ3oLYas3WG1qEvvH;

    public override bool CheckType(object obj, IMetadata propertyMetadata)
    {
      int num = 2;
      PropertyMetadata propertyMetadata1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (propertyMetadata1 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 3 : 3;
              continue;
            }
            goto label_2;
          case 2:
            propertyMetadata1 = propertyMetadata as PropertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return UrlTypeEncrypter.py8BSKoLssp2EArs4DmN((object) propertyMetadata1) == UrlDescriptor.UID;
label_3:
      return false;
    }

    protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
    {
      object objectFromString;
      switch (1)
      {
        case 1:
          try
          {
            int num;
            if (UrlTypeEncrypter.qxLmLwoLcq8Yq0OKQuaA((object) obj))
              num = 3;
            else
              goto label_6;
label_4:
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_6;
                case 3:
                  objectFromString = (object) null;
                  num = 2;
                  continue;
                default:
                  goto label_1;
              }
            }
label_6:
            objectFromString = (object) new Uri(obj, UriKind.RelativeOrAbsolute);
            num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
            {
              num = 0;
              goto label_4;
            }
            else
              goto label_4;
          }
          catch (Exception ex)
          {
            int num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  objectFromString = (object) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_1;
              }
            }
          }
      }
label_1:
      return objectFromString;
    }

    public UrlTypeEncrypter()
    {
      UrlTypeEncrypter.ahecMwoLzdIbo5Rcahvu();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid py8BSKoLssp2EArs4DmN([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static bool cpQSQSoLLOwCiOHwADcK() => UrlTypeEncrypter.DpSaJ3oLYas3WG1qEvvH == null;

    internal static UrlTypeEncrypter O8TwXroLU78DTysSeaPt() => UrlTypeEncrypter.DpSaJ3oLYas3WG1qEvvH;

    internal static bool qxLmLwoLcq8Yq0OKQuaA([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void ahecMwoLzdIbo5Rcahvu() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
