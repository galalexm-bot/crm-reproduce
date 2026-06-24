// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Encrypters.DropDownListTypeEncrypter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Encrypters
{
  [Component]
  public class DropDownListTypeEncrypter : BaseTypeEncrypter
  {
    internal static DropDownListTypeEncrypter UXHqESoY2UrhBasyJoRl;

    public override bool CheckType(object obj, IMetadata propertyMetadata)
    {
      int num = 2;
      PropertyMetadata propertyMetadata1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (propertyMetadata1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            propertyMetadata1 = propertyMetadata as PropertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return DropDownListTypeEncrypter.RoHEJIoYNpHcGkSvW0eS(DropDownListTypeEncrypter.F7S62ToY18dmmSohFO5n((object) propertyMetadata1), DropDownListDescriptor.UID);
label_4:
      return false;
    }

    protected override string ObjectToString(object obj, IMetadata propertyMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return string.Empty;
label_3:
      return ClassSerializationHelper.SerializeObjectByXml(obj);
    }

    protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (DropDownListTypeEncrypter.mRHHvdoY3Ism9GytFgXX((object) obj))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) null;
label_3:
      return (object) ClassSerializationHelper.DeserializeObjectByXml<DropDownItem>(obj);
    }

    public DropDownListTypeEncrypter()
    {
      DropDownListTypeEncrypter.Edpx1coYpxtWL2SCKI6r();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid F7S62ToY18dmmSohFO5n([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static bool RoHEJIoYNpHcGkSvW0eS([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool A0s2SQoYeLBc4tNlxJ6g() => DropDownListTypeEncrypter.UXHqESoY2UrhBasyJoRl == null;

    internal static DropDownListTypeEncrypter kmfCXwoYPa5rAIqPf7fd() => DropDownListTypeEncrypter.UXHqESoY2UrhBasyJoRl;

    internal static bool mRHHvdoY3Ism9GytFgXX([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void Edpx1coYpxtWL2SCKI6r() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
