// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ProductPackage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace EleWise.ELMA.Deploy
{
  [XmlRoot]
  public class ProductPackage
  {
    private static ProductPackage cNDTLiEP8n6js3lSw8MZ;

    [XmlElement]
    public string HashId
    {
      get => this.\u003CHashId\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CHashId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    [XmlArray]
    public List<ProductInfo> Products { get; set; }

    public ProductPackage()
    {
      ProductPackage.uegc1UEPIkUuruPc1Ur6();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool v26ObjEPZ6VU7CuXF9ZE() => ProductPackage.cNDTLiEP8n6js3lSw8MZ == null;

    internal static ProductPackage VfcGDYEPumolkwOmKMHn() => ProductPackage.cNDTLiEP8n6js3lSw8MZ;

    internal static void uegc1UEPIkUuruPc1Ur6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
