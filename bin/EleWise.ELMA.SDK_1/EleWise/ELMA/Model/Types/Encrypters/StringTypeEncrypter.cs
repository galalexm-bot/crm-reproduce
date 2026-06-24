// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Encrypters.StringTypeEncrypter
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
  public class StringTypeEncrypter : BaseTypeEncrypter
  {
    internal static StringTypeEncrypter HJsGodoLAHY7p4ZjFMJ4;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            propertyMetadata1 = propertyMetadata as PropertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            if (!StringTypeEncrypter.VJ22yKoLmyoNX9FT8Nyi(StringTypeEncrypter.omc0LqoL0d8DGiTxvtt2((object) propertyMetadata1), StringDescriptor.UID))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 3;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      return StringTypeEncrypter.omc0LqoL0d8DGiTxvtt2((object) propertyMetadata1) == TextDescriptor.UID;
label_3:
      return true;
label_4:
      return false;
    }

    protected override object GetObjectFromString(string obj, IMetadata propertyMetadata) => (object) obj;

    public override object EncryptStub(object obj, IMetadata propertyMetadata) => StringTypeEncrypter.Eo8774oLyfmIM3RD9RMn((object) this, obj, (object) propertyMetadata);

    public StringTypeEncrypter()
    {
      StringTypeEncrypter.WDyRB9oLMI94vcNoJt5w();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid omc0LqoL0d8DGiTxvtt2([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static bool VJ22yKoLmyoNX9FT8Nyi([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool yIMIpgoL793BXKF9DjRC() => StringTypeEncrypter.HJsGodoLAHY7p4ZjFMJ4 == null;

    internal static StringTypeEncrypter pDAcpGoLxYpZ0qQGdiA8() => StringTypeEncrypter.HJsGodoLAHY7p4ZjFMJ4;

    internal static object Eo8774oLyfmIM3RD9RMn([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((BaseTypeEncrypter) obj0).GetMaskedVal(obj1, (IMetadata) obj2);

    internal static void WDyRB9oLMI94vcNoJt5w() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
