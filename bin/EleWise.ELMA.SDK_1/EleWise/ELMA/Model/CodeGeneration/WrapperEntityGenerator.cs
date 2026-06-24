// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.WrapperEntityGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>
  /// Обертка генератора кода сущности
  /// <remarks>Инициализирует настоящий генератор после установки метаданных</remarks>
  /// </summary>
  internal class WrapperEntityGenerator : ICodeGenerator
  {
    private ICodeGenerator generator;
    private EntityMetadata metadata;
    private GenerationParams generationParams;
    internal static WrapperEntityGenerator RjGmMch2QC5wGh47iu42;

    /// <inheritdoc />
    public IMetadata Metadata
    {
      get
      {
        int num = 2;
        IMetadata metadata;
        while (true)
        {
          switch (num)
          {
            case 1:
              metadata = (IMetadata) this.metadata;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
              continue;
            case 2:
              if (this.generator == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
                continue;
              }
              goto label_5;
            case 3:
              goto label_5;
            default:
              goto label_2;
          }
        }
label_2:
        return metadata;
label_5:
        return this.generator.Metadata;
      }
      set
      {
        int num1 = 7;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                if (this.metadata != null)
                {
                  num2 = 2;
                  continue;
                }
                goto case 5;
              case 2:
                if (WrapperEntityGenerator.FA0NTSh287FGcYIfs4x7((object) this.metadata) == EntityMetadataType.Entity)
                {
                  num2 = 5;
                  continue;
                }
                goto label_17;
              case 3:
                this.metadata = entityMetadata;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 13 : 1;
                continue;
              case 4:
                if (this.generator != null)
                {
                  num2 = 14;
                  continue;
                }
                goto case 12;
              case 5:
                if (WrapperEntityGenerator.FA0NTSh287FGcYIfs4x7((object) entityMetadata) == EntityMetadataType.Entity)
                {
                  num2 = 4;
                  continue;
                }
                goto case 11;
              case 6:
                if (entityMetadata.Type == EntityMetadataType.Entity)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 1;
                  continue;
                }
                goto case 5;
              case 7:
                if (value is EntityMetadata entityMetadata)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 3 : 6;
                  continue;
                }
                goto label_3;
              case 8:
              case 14:
                goto label_5;
              case 9:
                if (WrapperEntityGenerator.FA0NTSh287FGcYIfs4x7((object) this.metadata) == EntityMetadataType.Entity)
                {
                  num2 = 10;
                  continue;
                }
                goto case 4;
              case 10:
                goto label_17;
              case 11:
                if (this.metadata != null)
                {
                  num2 = 9;
                  continue;
                }
                goto case 4;
              case 12:
                this.generator = WrapperEntityGenerator.FA0NTSh287FGcYIfs4x7((object) entityMetadata) != EntityMetadataType.Entity ? (ICodeGenerator) new EntityDynamicGenerator() : (ICodeGenerator) new EntityGenerator();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
                continue;
              case 13:
                goto label_25;
              default:
                WrapperEntityGenerator.oXt8YUh2IeGxPZJBBef5((object) this.generator, (object) this.generationParams);
                num2 = 8;
                continue;
            }
          }
label_5:
          WrapperEntityGenerator.GmrET9h2VAwXIV0wM8tN((object) this.generator, (object) entityMetadata);
          num1 = 3;
        }
label_25:
        return;
label_3:
        throw new Exception((string) WrapperEntityGenerator.USqdphh2ZSKBEUMERrSU(~538519529 ^ -538604722));
label_17:
        throw new Exception((string) WrapperEntityGenerator.hTxfr9h2uRLOSdWTxx76(WrapperEntityGenerator.USqdphh2ZSKBEUMERrSU(-688192331 - 435440695 ^ -1123685706)));
      }
    }

    /// <inheritdoc />
    public GenerationParams GenerationParams
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.generator != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return (GenerationParams) WrapperEntityGenerator.tjnxaMh2SPIX9ugn0RlC((object) this.generator);
label_3:
        return this.generationParams;
      }
      set
      {
        int num1 = 3;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
              case 2:
                this.generationParams = value;
                num2 = 4;
                continue;
              case 3:
                if (this.generator != null)
                  break;
                goto label_4;
              case 4:
                goto label_7;
            }
            WrapperEntityGenerator.oXt8YUh2IeGxPZJBBef5((object) this.generator, (object) value);
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
          }
label_4:
          num1 = 2;
        }
label_7:;
      }
    }

    /// <inheritdoc />
    public GeneratedFileInfo[] Generate()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.generator != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      throw new Exception((string) WrapperEntityGenerator.hTxfr9h2uRLOSdWTxx76((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837879825)));
label_3:
      return this.generator.Generate();
    }

    /// <inheritdoc />
    public GeneratedFileInfo[] GenerateAdditionalFiles()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.generator == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638619771)));
label_3:
      return (GeneratedFileInfo[]) WrapperEntityGenerator.g4hymrh2iF6pLvJZshsF((object) this.generator);
    }

    /// <inheritdoc />
    public GeneratedFileInfo GenerateMainFile()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.generator == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      throw new Exception((string) WrapperEntityGenerator.hTxfr9h2uRLOSdWTxx76(WrapperEntityGenerator.USqdphh2ZSKBEUMERrSU(-1146510045 ^ -1146423625)));
label_5:
      return (GeneratedFileInfo) WrapperEntityGenerator.nI02tGh2RjASQua48Xkr((object) this.generator);
    }

    public WrapperEntityGenerator()
    {
      WrapperEntityGenerator.EsGLgxh2qvGkwjWdTv5R();
      this.generationParams = new GenerationParams();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool IHJYxEh2CXh4nL7lxDAj() => WrapperEntityGenerator.RjGmMch2QC5wGh47iu42 == null;

    internal static WrapperEntityGenerator SOJ18Kh2vxpsqDlIXw6h() => WrapperEntityGenerator.RjGmMch2QC5wGh47iu42;

    internal static EntityMetadataType FA0NTSh287FGcYIfs4x7([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static object USqdphh2ZSKBEUMERrSU(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object hTxfr9h2uRLOSdWTxx76([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void oXt8YUh2IeGxPZJBBef5([In] object obj0, [In] object obj1) => ((ICodeGenerator) obj0).GenerationParams = (GenerationParams) obj1;

    internal static void GmrET9h2VAwXIV0wM8tN([In] object obj0, [In] object obj1) => ((ICodeGenerator) obj0).Metadata = (IMetadata) obj1;

    internal static object tjnxaMh2SPIX9ugn0RlC([In] object obj0) => (object) ((ICodeGenerator) obj0).GenerationParams;

    internal static object g4hymrh2iF6pLvJZshsF([In] object obj0) => (object) ((ICodeGenerator) obj0).GenerateAdditionalFiles();

    internal static object nI02tGh2RjASQua48Xkr([In] object obj0) => (object) ((ICodeGenerator) obj0).GenerateMainFile();

    internal static void EsGLgxh2qvGkwjWdTv5R() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
