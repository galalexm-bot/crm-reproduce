// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.MetadataGeneratorService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <inheritdoc />
  [Service]
  internal sealed class MetadataGeneratorService : IMetadataGeneratorService
  {
    private readonly IEnumerable<IMetadataTypeInfo> metadataTypeInfos;
    private static MetadataGeneratorService TxTEyWhkKTAxGOMW5phU;

    /// <summary>Ctor</summary>
    /// <param name="metadataTypeInfos">Информация о типе метаданных</param>
    public MetadataGeneratorService(IEnumerable<IMetadataTypeInfo> metadataTypeInfos)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.metadataTypeInfos = metadataTypeInfos;
    }

    /// <inheritdoc />
    public ICodeGenerator GetCodeGenerator(IMetadata metadata)
    {
      int num = 1;
      IMetadataTypeInfo metadataTypeInfo;
      IMetadata metadata1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
            continue;
          case 2:
            if (metadataTypeInfo != null)
            {
              num = 4;
              continue;
            }
            goto label_2;
          case 3:
            goto label_2;
          case 4:
            goto label_3;
          case 5:
            // ISSUE: reference to a compiler-generated method
            metadataTypeInfo = this.metadataTypeInfos.FirstOrDefault<IMetadataTypeInfo>((Func<IMetadataTypeInfo, bool>) (m => MetadataGeneratorService.\u003C\u003Ec__DisplayClass2_0.QJj6axvGnEA1DeOMApdf((object) m) == metadata1.GetType()));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 2 : 2;
            continue;
          default:
            metadata1 = metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 5 : 4;
            continue;
        }
      }
label_2:
      throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439564228), (object) metadata1.GetType()));
label_3:
      return (ICodeGenerator) Activator.CreateInstance(MetadataGeneratorService.D2RF5yhkkybMjYimGC5Z((object) metadataTypeInfo));
    }

    internal static Type D2RF5yhkkybMjYimGC5Z([In] object obj0) => ((IMetadataTypeInfo) obj0).GeneratorType;

    internal static bool iRI7xhhkXhjuHNGvmvSX() => MetadataGeneratorService.TxTEyWhkKTAxGOMW5phU == null;

    internal static MetadataGeneratorService CUspcQhkTiY9yKNTmPBZ() => MetadataGeneratorService.TxTEyWhkKTAxGOMW5phU;
  }
}
