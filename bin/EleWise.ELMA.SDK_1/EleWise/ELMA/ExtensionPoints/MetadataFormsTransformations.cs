// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.MetadataFormsTransformations
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ExtensionPoints
{
  [Component]
  public class MetadataFormsTransformations : IMetadataFormsTransformations
  {
    internal static MetadataFormsTransformations qToCiNGlBiOCNWPDTx4q;

    public void Transformate(EntityMetadata metadata)
    {
      int num1 = 2;
      EntityMetadata metadata1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            metadata1 = metadata;
            num1 = 3;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
            continue;
          case 3:
            ((ComponentManager) MetadataFormsTransformations.xhCwbhGlb6Hou6h6qZTN()).GetExtensionPoints<IEntityMetadataFormTransformation>().ForEach<IEntityMetadataFormTransformation>((Action<IEntityMetadataFormTransformation>) (q =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    q.GetTransformations(metadata1.FormTransformations);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    public MetadataFormsTransformations()
    {
      MetadataFormsTransformations.uG4wCKGlhaW6M0iVIy0c();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object xhCwbhGlb6Hou6h6qZTN() => (object) ComponentManager.Current;

    internal static bool TJAIDLGlWxyDEJ9RnMBJ() => MetadataFormsTransformations.qToCiNGlBiOCNWPDTx4q == null;

    internal static MetadataFormsTransformations P6EQjfGlodRR5PimbDst() => MetadataFormsTransformations.qToCiNGlBiOCNWPDTx4q;

    internal static void uG4wCKGlhaW6M0iVIy0c() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
