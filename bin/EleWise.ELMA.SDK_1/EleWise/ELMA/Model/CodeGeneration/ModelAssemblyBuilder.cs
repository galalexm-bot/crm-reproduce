// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.ModelAssemblyBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Projects;
using EleWise.ELMA.Services;
using Iesi.Collections;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CSharp.RuntimeBinder;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.ServiceModel;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using System.Xml;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Генератор сборок по метаданным</summary>
  public class ModelAssemblyBuilder : AssemblyBuilder
  {
    private IEnumerable<IModelReferenceProvider> modelReferenceProviders;
    private IMetadataGeneratorService metadataGeneratorService;
    private string assemblyInfo;
    private string rootNamespace;
    private static ModelAssemblyBuilder uNjFtGhNd8WBp9nFPBdZ;

    /// <summary>Поставщик ссылок для построителя сборок моделей</summary>
    private IEnumerable<IModelReferenceProvider> ModelReferenceProviders
    {
      get
      {
        IEnumerable<IModelReferenceProvider> referenceProviders = this.modelReferenceProviders;
        if (referenceProviders != null)
          return referenceProviders;
        return !ComponentManager.Initialized ? Enumerable.Empty<IModelReferenceProvider>() : (this.modelReferenceProviders = ComponentManager.Current.GetExtensionPoints<IModelReferenceProvider>());
      }
      set => this.modelReferenceProviders = value;
    }

    /// <summary>Поставщик генераторов кода для метаданных</summary>
    internal IMetadataGeneratorService MetadataGeneratorService
    {
      get
      {
        int num = 1;
        IMetadataGeneratorService generatorService;
        while (true)
        {
          switch (num)
          {
            case 1:
              generatorService = this.metadataGeneratorService;
              if (generatorService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return generatorService;
label_5:
        return Locator.GetServiceNotNull<IMetadataGeneratorService>();
      }
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
              this.metadataGeneratorService = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
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

    /// <summary>Создать генератор</summary>
    public ModelAssemblyBuilder()
    {
      ModelAssemblyBuilder.XQqS71hNg15cyyXg5HpM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Создать генератор</summary>
    /// <param name="assemblyName">Имя сборки</param>
    /// <param name="rootNamespace">Корневое пространство имен</param>
    public ModelAssemblyBuilder(string assemblyName, string rootNamespace = null)
    {
      ModelAssemblyBuilder.XQqS71hNg15cyyXg5HpM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.AssemblyName = assemblyName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            Contract.ArgumentNotNullOrEmpty(assemblyName, (string) ModelAssemblyBuilder.yADEBbhN5hqo09FBLkjR(712480695 ^ 712307211));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 0;
            continue;
          default:
            this.rootNamespace = ModelAssemblyBuilder.xcWtAshNjVCyRJUROuYB((object) rootNamespace) ? assemblyName : rootNamespace;
            num = 2;
            continue;
        }
      }
label_2:;
    }

    public override void AddDefaultReferences()
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        Assembly[] assemblyArray;
        Assembly assembly;
        string str;
        int index;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 2:
            case 4:
            case 12:
              ++index;
              num2 = 15;
              continue;
            case 3:
              if (ModelAssemblyBuilder.xcWtAshNjVCyRJUROuYB(ModelAssemblyBuilder.hwWnpQhNUEt93wKIVPSs((object) assembly)))
              {
                num2 = 2;
                continue;
              }
              goto case 11;
            case 5:
              str = (string) ModelAssemblyBuilder.FoTld3hNLIGPgT4VFxMQ((object) assembly);
              num2 = 3;
              continue;
            case 6:
              this.AddReferences((IEnumerable<IReferenceProviderBase>) this.ModelReferenceProviders);
              num2 = 18;
              continue;
            case 7:
              goto label_15;
            case 8:
            case 15:
              if (index < assemblyArray.Length)
                goto case 14;
              else
                goto label_20;
            case 9:
              this.AddReference(assembly);
              num2 = 4;
              continue;
            case 10:
              this.AddDefaultReferencesFromElmaConfig((string) ModelAssemblyBuilder.yADEBbhN5hqo09FBLkjR(2045296739 + 1688595713 ^ -561092802));
              num2 = 20;
              continue;
            case 11:
              if (!ModelAssemblyBuilder.I4ECllhNsDFagZiC5tPX((object) assembly))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 1;
                continue;
              }
              goto default;
            case 13:
              if (ModelAssemblyBuilder.YQpVYMhNcK4bcSrqrPqm((object) str, ModelAssemblyBuilder.yADEBbhN5hqo09FBLkjR(~-306453669 ^ 306452106)))
              {
                num2 = 9;
                continue;
              }
              goto case 1;
            case 14:
              assembly = assemblyArray[index];
              num2 = 17;
              continue;
            case 16:
              index = 0;
              num2 = 8;
              continue;
            case 17:
              if (assembly.IsDynamic)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 12 : 11;
                continue;
              }
              goto case 5;
            case 18:
              this.AddDefaultReferencesFromConfig(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112717108));
              num2 = 10;
              continue;
            case 19:
              goto label_16;
            case 20:
              goto label_3;
            default:
              if (ModelAssemblyBuilder.YQpVYMhNcK4bcSrqrPqm((object) str, ModelAssemblyBuilder.yADEBbhN5hqo09FBLkjR(-1350312861 << 3 ^ 2082400636)))
              {
                num2 = 13;
                continue;
              }
              goto case 1;
          }
        }
label_3:
        assemblyArray = (Assembly[]) ModelAssemblyBuilder.Emp3M2hNYXX68ZnG3y7J();
        num1 = 16;
        continue;
label_15:
        base.AddDefaultReferences();
        num1 = 6;
        continue;
label_20:
        num1 = 19;
      }
label_16:;
    }

    /// <summary>Добавить объект метаданных</summary>
    /// <param name="metadata">Метаданные</param>
    /// <param name="generationParams">Параметры генерации</param>
    public virtual void AddMetadata(IMetadata metadata, GenerationParams generationParams = null)
    {
      int num1 = 32;
      while (true)
      {
        int num2 = num1;
        ICodeGenerator codeGenerator1;
        ICodeItemMetadata codeItemMetadata;
        while (true)
        {
          int index;
          GeneratedFileInfo generatedFileInfo;
          string name;
          GeneratedFileInfo[] generatedFileInfoArray;
          GeneratedFileType generatedFileType;
          Type type1;
          ICodeGenerator codeGenerator2;
          Type type2;
          switch (num2)
          {
            case 1:
              ModelAssemblyBuilder.E5ISqth3ZRWYbxluEV9S((object) this, (object) ((Encoding) ModelAssemblyBuilder.A7ayfph3vAxrsCUpYUT8()).GetString((byte[]) ModelAssemblyBuilder.vqPpwMh38cT8vSEoA5nT((object) generatedFileInfo)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 24 : 18;
              continue;
            case 2:
              goto label_6;
            case 3:
              type2 = ModelAssemblyBuilder.ponAyrh3FeQYPiLHFgOf((object) generationParams);
              break;
            case 4:
              ModelAssemblyBuilder.s4VyjFh3EnpFSVrNjIIg(ModelAssemblyBuilder.tVjy3ih3or9cGELfdft4((object) codeGenerator1), ModelAssemblyBuilder.Co4MbVh3GcOFubJ1Irrb((object) codeItemMetadata));
              num2 = 20;
              continue;
            case 5:
              type2 = (Type) null;
              break;
            case 6:
              if (codeItemMetadata != null)
              {
                num2 = 17;
                continue;
              }
              goto case 12;
            case 7:
              ModelAssemblyBuilder.prVPIFh3h5cgi7k2OCKZ(ModelAssemblyBuilder.tVjy3ih3or9cGELfdft4((object) codeGenerator1), (object) ((string) ModelAssemblyBuilder.CriSHeh3bnDaeLuaxWOJ((object) codeItemMetadata) + (string) ModelAssemblyBuilder.yADEBbhN5hqo09FBLkjR(1669212571 ^ 1669260235)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 2 : 4;
              continue;
            case 8:
              generatedFileInfoArray = (GeneratedFileInfo[]) ModelAssemblyBuilder.WnoX8gh3QNgiPuYR0l2x((object) codeGenerator1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 29 : 27;
              continue;
            case 9:
              if (generatedFileType != GeneratedFileType.CS)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 25 : 5;
                continue;
              }
              goto case 1;
            case 10:
              this.AddEmbeddedResource(name, (byte[]) ModelAssemblyBuilder.vqPpwMh38cT8vSEoA5nT((object) generatedFileInfo));
              num2 = 22;
              continue;
            case 11:
            case 26:
              if (index < generatedFileInfoArray.Length)
              {
                num2 = 27;
                continue;
              }
              goto label_26;
            case 12:
            case 22:
            case 24:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 11 : 5;
              continue;
            case 13:
              if (generationParams != null)
              {
                num2 = 3;
                continue;
              }
              goto case 5;
            case 14:
              goto label_27;
            case 15:
              generatedFileType = ModelAssemblyBuilder.oiGD1Wh3CHqtl8rNb8WX((object) generatedFileInfo);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 9 : 7;
              continue;
            case 16:
              goto label_3;
            case 17:
              name = (string) ModelAssemblyBuilder.xdxrioh3uyZTsaDSfEHd(ModelAssemblyBuilder.tVjy3ih3or9cGELfdft4((object) codeGenerator1)) + (string) ModelAssemblyBuilder.yADEBbhN5hqo09FBLkjR(323422137 << 2 ^ 1293681696) + codeItemMetadata.Name + (string) ModelAssemblyBuilder.kYAxhqh3IX0SY4Iqin71((object) generatedFileInfo);
              num2 = 10;
              continue;
            case 18:
              ModelAssemblyBuilder.coo4Sjh3fHVKUcaHiwUR((object) codeGenerator1, (object) generationParams);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 2 : 8;
              continue;
            case 19:
            case 20:
              if (generationParams != null)
              {
                num2 = 18;
                continue;
              }
              goto case 8;
            case 21:
              codeGenerator2 = this.MetadataGeneratorService.GetCodeGenerator(metadata);
              goto label_41;
            case 23:
              if (ModelAssemblyBuilder.MJlBa0h3BINw9sDp1Umd(type1, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                continue;
              }
              goto case 21;
            case 25:
              if (generatedFileType != GeneratedFileType.EmbeddedResource)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 12 : 3;
                continue;
              }
              goto case 6;
            case 27:
            case 30:
              generatedFileInfo = generatedFileInfoArray[index];
              num2 = 15;
              continue;
            case 28:
              if (codeItemMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 19 : 13;
                continue;
              }
              goto case 7;
            case 29:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 26 : 18;
              continue;
            case 31:
              metadata = metadata.CastAsRealType<IMetadata>();
              num2 = 13;
              continue;
            case 32:
              ModelAssemblyBuilder.wStpW5hNzm5oLCULaVPh((object) metadata, ModelAssemblyBuilder.yADEBbhN5hqo09FBLkjR(-1088304168 ^ -1088322842));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 8 : 31;
              continue;
            default:
              codeGenerator2 = (ICodeGenerator) ModelAssemblyBuilder.Yhfjw2h3W48bXme6eYqV(type1);
              goto label_41;
          }
          type1 = type2;
          num2 = 23;
          continue;
label_41:
          codeGenerator1 = codeGenerator2;
          num2 = 16;
        }
label_3:
        codeGenerator1.Metadata = metadata;
        num1 = 2;
        continue;
label_6:
        codeItemMetadata = metadata as ICodeItemMetadata;
        num1 = 28;
      }
label_27:
      return;
label_26:;
    }

    /// <inheritdoc />
    public override MemoryStream BuildToStream(bool pdb = true, bool doc = true)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ModelAssemblyBuilder.eeZi1Wh3SPC5rHOjNEJu((object) this, ModelAssemblyBuilder.S7d3cOh3XS42kZhLUd1a());
              num2 = 14;
              continue;
            case 2:
              this.GenerateAssemblyInfo();
              num2 = 19;
              continue;
            case 3:
              goto label_23;
            case 4:
              ModelAssemblyBuilder.eeZi1Wh3SPC5rHOjNEJu((object) this, ModelAssemblyBuilder.wTUragh3VtGhdwHQMZwf());
              num2 = 3;
              continue;
            case 5:
            case 19:
              ModelAssemblyBuilder.E5ISqth3ZRWYbxluEV9S((object) this, (object) this.assemblyInfo);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 4 : 6;
              continue;
            case 6:
              goto label_11;
            case 7:
              ModelAssemblyBuilder.eeZi1Wh3SPC5rHOjNEJu((object) this, ModelAssemblyBuilder.av9yaZh3eCeLMBMr4RSu());
              num2 = 11;
              continue;
            case 8:
              this.AddReference(TypeOf<RuntimeBinderException>.Assembly);
              num2 = 18;
              continue;
            case 9:
              this.AddReference((Assembly) ModelAssemblyBuilder.ypjxiPh3OYJWd0buIWEH());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 8 : 17;
              continue;
            case 10:
              ModelAssemblyBuilder.eeZi1Wh3SPC5rHOjNEJu((object) this, ModelAssemblyBuilder.VF9rkEh3RJqFFKJqwI97());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 9 : 13;
              continue;
            case 11:
              ModelAssemblyBuilder.B6fk2fh316K1fGZtgY48((object) this, ModelAssemblyBuilder.hwWnpQhNUEt93wKIVPSs(ModelAssemblyBuilder.PLyqsJh3P6O7S89W4JOt(ModelAssemblyBuilder.yADEBbhN5hqo09FBLkjR(-1426456882 ^ 2009939514 ^ -583555614))));
              num2 = 20;
              continue;
            case 12:
              ModelAssemblyBuilder.eeZi1Wh3SPC5rHOjNEJu((object) this, (object) TypeOf<ISession>.Assembly);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
              continue;
            case 13:
              ModelAssemblyBuilder.eeZi1Wh3SPC5rHOjNEJu((object) this, ModelAssemblyBuilder.U4e9irh3qPSkj7S43bis());
              num2 = 16;
              continue;
            case 14:
              ModelAssemblyBuilder.eeZi1Wh3SPC5rHOjNEJu((object) this, ModelAssemblyBuilder.i8OJ1Xh3T7RWWYqukkyV());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 12 : 12;
              continue;
            case 15:
              ModelAssemblyBuilder.eeZi1Wh3SPC5rHOjNEJu((object) this, (object) TypeOf<System.Runtime.Serialization.DateTimeFormat>.Assembly);
              num2 = 9;
              continue;
            case 16:
              ModelAssemblyBuilder.eeZi1Wh3SPC5rHOjNEJu((object) this, ModelAssemblyBuilder.LrRPiwh3KE3H14anBF2i());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
              continue;
            case 17:
              goto label_19;
            case 18:
              this.AddReference((Assembly) ModelAssemblyBuilder.wp6bXoh3nG5soerEtRYM());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 15 : 14;
              continue;
            case 20:
              if (!ModelAssemblyBuilder.NmFd0Dh3NHT09PRanVhH((object) this.assemblyInfo))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 5 : 3;
                continue;
              }
              goto case 2;
            default:
              ModelAssemblyBuilder.eeZi1Wh3SPC5rHOjNEJu((object) this, ModelAssemblyBuilder.KMxxpkh3kHCISMQe0MPK());
              num2 = 8;
              continue;
          }
        }
label_19:
        this.AddReference((Assembly) ModelAssemblyBuilder.lMqmYuh32hlZ1waGEflj());
        num1 = 7;
        continue;
label_23:
        this.AddReference((Assembly) ModelAssemblyBuilder.pQuudth3ip77MRwW6GdH());
        num1 = 10;
      }
label_11:
      return base.BuildToStream(pdb, doc);
    }

    /// <summary>Сегенерировать файл AssemblyInfo</summary>
    /// <param name="conversions">Преобразования с текстом шаблона</param>
    /// <returns>Текст файла AssemblyInfo.cs</returns>
    public virtual void GenerateAssemblyInfo(Func<string, string> conversions = null) => this.assemblyInfo = ModelProject.GenerateAssemblyInfoFile(conversions);

    /// <summary>
    /// Получить все зависимые сборки для всех сборок, находящихся в указанной папке
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public static string[] GetAllReferencedAssembliesFromPath(string path)
    {
      int num1 = 3;
      AppDomainSetup appDomainSetup;
      Assembly assembly;
      AppDomain appDomain;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_14;
          case 2:
            assembly = (Assembly) ModelAssemblyBuilder.GiyxV1h33fO0VQe939GH();
            num1 = 4;
            continue;
          case 3:
            appDomainSetup = new AppDomainSetup();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 2;
            continue;
          case 4:
            ModelAssemblyBuilder.BgI0Moh3aWGRmKCOLsxG((object) appDomainSetup, ModelAssemblyBuilder.EM15Xfh3p7GN9xPAqYfF(ModelAssemblyBuilder.hwWnpQhNUEt93wKIVPSs((object) assembly)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 5 : 1;
            continue;
          case 5:
            appDomain = (AppDomain) ModelAssemblyBuilder.rDPbDxh3tfOq6IVgCMX3(ModelAssemblyBuilder.l80J4Dh3DBrI4BMykV6o(ModelAssemblyBuilder.yADEBbhN5hqo09FBLkjR(-1710575414 ^ -1710631662), (object) Guid.NewGuid().ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323092540))), (object) null, (object) appDomainSetup);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      string[] referencedAssemblies;
      try
      {
        referencedAssemblies = ((ModelAssemblyBuilder.ReferencedAssembliesResolver) appDomain.CreateInstanceAndUnwrap(assembly.FullName, (string) ModelAssemblyBuilder.iFvAwXh3wh0oCbEOsOiD())).GetReferencedAssemblies(path);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        ModelAssemblyBuilder.bG9WKwh34DGnhu5dUVkC((object) appDomain);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_14:
      return referencedAssemblies;
    }

    internal static bool ES0iD8hNlOLVVI7VYXXr() => ModelAssemblyBuilder.uNjFtGhNd8WBp9nFPBdZ == null;

    internal static ModelAssemblyBuilder vSdd1nhNrsy5kXn4VIFl() => ModelAssemblyBuilder.uNjFtGhNd8WBp9nFPBdZ;

    internal static void XQqS71hNg15cyyXg5HpM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object yADEBbhN5hqo09FBLkjR(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool xcWtAshNjVCyRJUROuYB([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object Emp3M2hNYXX68ZnG3y7J() => (object) ComponentManager.GetAssemblies();

    internal static object FoTld3hNLIGPgT4VFxMQ([In] object obj0) => (object) ComponentManager.GetAssemblyShortName((Assembly) obj0);

    internal static object hwWnpQhNUEt93wKIVPSs([In] object obj0) => (object) ((Assembly) obj0).Location;

    internal static bool I4ECllhNsDFagZiC5tPX([In] object obj0) => ComponentManager.IsModelAssembly((Assembly) obj0);

    internal static bool YQpVYMhNcK4bcSrqrPqm([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static void wStpW5hNzm5oLCULaVPh([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static Type ponAyrh3FeQYPiLHFgOf([In] object obj0) => ((GenerationParams) obj0).GeneratorType;

    internal static bool MJlBa0h3BINw9sDp1Umd([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object Yhfjw2h3W48bXme6eYqV([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static object tVjy3ih3or9cGELfdft4([In] object obj0) => (object) ((ICodeGenerator) obj0).GenerationParams;

    internal static object CriSHeh3bnDaeLuaxWOJ([In] object obj0) => (object) ((ICodeItemMetadata) obj0).Name;

    internal static void prVPIFh3h5cgi7k2OCKZ([In] object obj0, [In] object obj1) => ((GenerationParams) obj0).FileName = (string) obj1;

    internal static object Co4MbVh3GcOFubJ1Irrb([In] object obj0) => (object) ((ICodeItemMetadata) obj0).Namespace;

    internal static void s4VyjFh3EnpFSVrNjIIg([In] object obj0, [In] object obj1) => ((GenerationParams) obj0).Namespace = (string) obj1;

    internal static void coo4Sjh3fHVKUcaHiwUR([In] object obj0, [In] object obj1) => ((ICodeGenerator) obj0).GenerationParams = (GenerationParams) obj1;

    internal static object WnoX8gh3QNgiPuYR0l2x([In] object obj0) => (object) ((ICodeGenerator) obj0).Generate();

    internal static GeneratedFileType oiGD1Wh3CHqtl8rNb8WX([In] object obj0) => ((GeneratedFileInfo) obj0).Type;

    internal static object A7ayfph3vAxrsCUpYUT8() => (object) Encoding.UTF8;

    internal static object vqPpwMh38cT8vSEoA5nT([In] object obj0) => (object) ((GeneratedFileInfo) obj0).Data;

    internal static void E5ISqth3ZRWYbxluEV9S([In] object obj0, [In] object obj1) => ((AssemblyBuilder) obj0).AddSourceCode((string) obj1);

    internal static object xdxrioh3uyZTsaDSfEHd([In] object obj0) => (object) ((GenerationParams) obj0).Namespace;

    internal static object kYAxhqh3IX0SY4Iqin71([In] object obj0) => (object) ((GeneratedFileInfo) obj0).Extension;

    internal static object wTUragh3VtGhdwHQMZwf() => (object) TypeOf<Uri>.Assembly;

    internal static void eeZi1Wh3SPC5rHOjNEJu([In] object obj0, [In] object obj1) => ((AssemblyBuilder) obj0).AddReference((Assembly) obj1);

    internal static object pQuudth3ip77MRwW6GdH() => (object) TypeOf<IQueryable>.Assembly;

    internal static object VF9rkEh3RJqFFKJqwI97() => (object) TypeOf<RequiredAttribute>.Assembly;

    internal static object U4e9irh3qPSkj7S43bis() => (object) TypeOf<System.Configuration.Configuration>.Assembly;

    internal static object LrRPiwh3KE3H14anBF2i() => (object) TypeOf<HttpContext>.Assembly;

    internal static object S7d3cOh3XS42kZhLUd1a() => (object) TypeOf<MvcHtmlString>.Assembly;

    internal static object i8OJ1Xh3T7RWWYqukkyV() => (object) TypeOf<IEntity>.Assembly;

    internal static object KMxxpkh3kHCISMQe0MPK() => (object) TypeOf<ISet>.Assembly;

    internal static object wp6bXoh3nG5soerEtRYM() => (object) TypeOf<Color>.Assembly;

    internal static object ypjxiPh3OYJWd0buIWEH() => (object) TypeOf<AuditLevel>.Assembly;

    internal static object lMqmYuh32hlZ1waGEflj() => (object) TypeOf<WebService>.Assembly;

    internal static object av9yaZh3eCeLMBMr4RSu() => (object) TypeOf<Formatting>.Assembly;

    internal static object PLyqsJh3P6O7S89W4JOt([In] object obj0) => (object) Assembly.Load((string) obj0);

    internal static void B6fk2fh316K1fGZtgY48([In] object obj0, [In] object obj1) => ((AssemblyBuilder) obj0).AddReference((string) obj1);

    internal static bool NmFd0Dh3NHT09PRanVhH([In] object obj0) => ((string) obj0).IsNullOrWhiteSpace();

    internal static object GiyxV1h33fO0VQe939GH() => (object) TypeOf<ModelAssemblyBuilder>.Assembly;

    internal static object EM15Xfh3p7GN9xPAqYfF([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static void BgI0Moh3aWGRmKCOLsxG([In] object obj0, [In] object obj1) => ((AppDomainSetup) obj0).ApplicationBase = (string) obj1;

    internal static object l80J4Dh3DBrI4BMykV6o([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object rDPbDxh3tfOq6IVgCMX3([In] object obj0, [In] object obj1, [In] object obj2) => (object) AppDomain.CreateDomain((string) obj0, (Evidence) obj1, (AppDomainSetup) obj2);

    internal static object iFvAwXh3wh0oCbEOsOiD() => (object) TypeOf<ModelAssemblyBuilder.ReferencedAssembliesResolver>.FullName;

    internal static void bG9WKwh34DGnhu5dUVkC([In] object obj0) => AppDomain.Unload((AppDomain) obj0);

    private class ReferencedAssembliesResolver : MarshalByRefObject
    {
      private object path;
      private static Dictionary<string, Assembly> loadedAsms;
      internal static object XA0G7YvVRsm2rqoi5Y9b;

      public string[] GetReferencedAssemblies(string path)
      {
        int num1 = 1;
        IEnumerator<string> enumerator;
        List<string> stringList1;
        List<string> stringList2;
        while (true)
        {
          switch (num1)
          {
            case 1:
              this.path = (object) path;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
              continue;
            case 2:
              if (!ModelAssemblyBuilder.ReferencedAssembliesResolver.CIJBAFvVT3lL7fGZafvB((object) path))
              {
                num1 = 3;
                continue;
              }
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              IEnumerable<string> strings = ((IEnumerable<string>) ModelAssemblyBuilder.ReferencedAssembliesResolver.RufOXMvVncubluKhfAm1((object) path, ModelAssemblyBuilder.ReferencedAssembliesResolver.KR1ruqvVknvgxoJyJHUP(1461625753 ^ 1461708639))).Where<string>((Func<string, bool>) (fn => !ModelAssemblyBuilder.ReferencedAssembliesResolver.\u003C\u003Ec.pZD2LHZX5XE07MxkXnHb(ModelAssemblyBuilder.ReferencedAssembliesResolver.\u003C\u003Ec.Cytcl4ZXrx4EmnHDuiVj(ModelAssemblyBuilder.ReferencedAssembliesResolver.\u003C\u003Ec.BefWa7ZXl9skB4pGsOse((object) fn)), ModelAssemblyBuilder.ReferencedAssembliesResolver.\u003C\u003Ec.vTZ9HSZXgGh4GReMEAKL(1051802738 - -1831968059 ^ -1411198077))));
              stringList1 = new List<string>();
              stringList2 = new List<string>();
              enumerator = strings.GetEnumerator();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 4 : 1;
              continue;
            case 3:
              goto label_54;
            case 4:
              goto label_3;
            case 5:
              goto label_50;
            default:
              ((AppDomain) ModelAssemblyBuilder.ReferencedAssembliesResolver.pb8pZUvVXyjFDpqq9SdZ()).ReflectionOnlyAssemblyResolve += new ResolveEventHandler(this.CurrentDomain_ReflectionOnlyAssemblyResolve);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 2 : 0;
              continue;
          }
        }
label_3:
        try
        {
label_42:
          if (ModelAssemblyBuilder.ReferencedAssembliesResolver.KbOD97vVwpJq5N0ZpUeL((object) enumerator))
            goto label_5;
          else
            goto label_43;
label_4:
          string current;
          int num2;
          switch (num2)
          {
            case 1:
              break;
            case 2:
              goto label_42;
            case 3:
              try
              {
                int num3 = 15;
                Assembly target;
                System.Reflection.AssemblyName assemblyName;
                System.Reflection.AssemblyName[] referencedAssemblies;
                int index;
                System.Reflection.AssemblyName asmName;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      try
                      {
                        if (ModelAssemblyBuilder.ReferencedAssembliesResolver.dqrPA3vVegOF7Ti7e5B6(ModelAssemblyBuilder.ReferencedAssembliesResolver.uLWRDxvVp8KRxNhR7VUc(ModelAssemblyBuilder.ReferencedAssembliesResolver.pMctoNvV3JQEkJSIaKG1((object) assemblyName)), (object) null))
                        {
                          int num4 = 1;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
                            num4 = 1;
                          while (true)
                          {
                            switch (num4)
                            {
                              case 1:
                                if (!ModelAssemblyBuilder.ReferencedAssembliesResolver.wlydTZvVtEaDGoUd9XNY(ModelAssemblyBuilder.ReferencedAssembliesResolver.hAIHh7vVD3Nmvp6tVAOc((object) path, ModelAssemblyBuilder.ReferencedAssembliesResolver.aD9ax4vVau2Z4iXxsVg5(ModelAssemblyBuilder.ReferencedAssembliesResolver.EMT99ivV1k2u420DrSKA((object) assemblyName), ModelAssemblyBuilder.ReferencedAssembliesResolver.KR1ruqvVknvgxoJyJHUP(372753449 ^ 372670611)))))
                                {
                                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
                                  continue;
                                }
                                goto label_31;
                              case 2:
                                goto label_31;
                              default:
                                stringList1.Add((string) ModelAssemblyBuilder.ReferencedAssembliesResolver.aD9ax4vVau2Z4iXxsVg5(ModelAssemblyBuilder.ReferencedAssembliesResolver.EMT99ivV1k2u420DrSKA((object) assemblyName), ModelAssemblyBuilder.ReferencedAssembliesResolver.KR1ruqvVknvgxoJyJHUP(1232639661 >> 3 ^ 154031727)));
                                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 2;
                                continue;
                            }
                          }
                        }
                        else
                          goto case 6;
                      }
                      catch
                      {
                        int num5 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
                          num5 = 0;
                        switch (num5)
                        {
                          default:
                            goto label_31;
                        }
                      }
                    case 2:
                    case 14:
                      if (index >= referencedAssemblies.Length)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
                        continue;
                      }
                      goto case 5;
                    case 3:
                      if (ModelAssemblyBuilder.ReferencedAssembliesResolver.dqrPA3vVegOF7Ti7e5B6((object) target, (object) null))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 17 : 6;
                        continue;
                      }
                      goto label_42;
                    case 4:
                      if (!ModelAssemblyBuilder.ReferencedAssembliesResolver.Fux5bIvVN4xYlZAM10p8(ModelAssemblyBuilder.ReferencedAssembliesResolver.EMT99ivV1k2u420DrSKA((object) assemblyName), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811908394), StringComparison.CurrentCultureIgnoreCase))
                      {
                        num3 = 9;
                        continue;
                      }
                      goto case 6;
                    case 5:
                      assemblyName = referencedAssemblies[index];
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 4 : 7;
                      continue;
                    case 6:
                    case 16:
label_31:
                      ++index;
                      num3 = 14;
                      continue;
                    case 7:
                      if (stringList2.Contains((string) ModelAssemblyBuilder.ReferencedAssembliesResolver.EMT99ivV1k2u420DrSKA((object) assemblyName)))
                      {
                        num3 = 16;
                        continue;
                      }
                      goto case 4;
                    case 8:
                      referencedAssemblies = target.GetReferencedAssemblies();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 19 : 19;
                      continue;
                    case 9:
                      stringList2.Add((string) ModelAssemblyBuilder.ReferencedAssembliesResolver.EMT99ivV1k2u420DrSKA((object) assemblyName));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
                      continue;
                    case 10:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (!CustomAttributeData.GetCustomAttributes(target).Any<CustomAttributeData>((Func<CustomAttributeData, bool>) (c => ModelAssemblyBuilder.ReferencedAssembliesResolver.\u003C\u003Ec.doYUV9ZXU4cZ1WMEo7rX((object) ModelAssemblyBuilder.ReferencedAssembliesResolver.\u003C\u003Ec.qp8s7jZXYTYW6WHVvwMJ(ModelAssemblyBuilder.ReferencedAssembliesResolver.\u003C\u003Ec.ePCIRnZXjgPj4bArk4qd((object) c)).FullName, ModelAssemblyBuilder.ReferencedAssembliesResolver.\u003C\u003Ec.nqhtYeZXLBMaXY01iBn0()))))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 13 : 11;
                        continue;
                      }
                      goto case 8;
                    case 11:
                      if (ModelAssemblyBuilder.ReferencedAssembliesResolver.xFPP3TvV2GMWNvde9Zxy((object) target, (object) null))
                      {
                        num3 = 18;
                        continue;
                      }
                      goto case 3;
                    case 12:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      target = ((IEnumerable<Assembly>) AppDomain.CurrentDomain.ReflectionOnlyGetAssemblies()).FirstOrDefault<Assembly>((Func<Assembly, bool>) (a => (string) ModelAssemblyBuilder.ReferencedAssembliesResolver.\u003C\u003Ec__DisplayClass1_0.mZcDjuZXm5JLnkaNYALi((object) a) == (string) ModelAssemblyBuilder.ReferencedAssembliesResolver.\u003C\u003Ec__DisplayClass1_0.hU3vI8ZXyOgrovwyKZiG((object) asmName)));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 11 : 3;
                      continue;
                    case 15:
                      asmName = (System.Reflection.AssemblyName) ModelAssemblyBuilder.ReferencedAssembliesResolver.PWkRTRvVOf58uf7fXuOV((object) current);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 12 : 2;
                      continue;
                    case 17:
                      ModelAssemblyBuilder.ReferencedAssembliesResolver.loadedAsms[(string) ModelAssemblyBuilder.ReferencedAssembliesResolver.dZTUJWvVPykjhAP6BfW3((object) target)] = target;
                      num3 = 10;
                      continue;
                    case 18:
                      target = Assembly.ReflectionOnlyLoadFrom(current);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 3 : 0;
                      continue;
                    case 19:
                      index = 0;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 1 : 2;
                      continue;
                    default:
                      goto label_42;
                  }
                }
              }
              catch
              {
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                    goto label_42;
                }
              }
            default:
              goto label_50;
          }
label_5:
          current = enumerator.Current;
          num2 = 3;
          goto label_4;
label_43:
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
          goto label_4;
        }
        finally
        {
          int num7;
          if (enumerator == null)
            num7 = 2;
          else
            goto label_47;
label_46:
          switch (num7)
          {
            case 1:
            case 2:
          }
label_47:
          ModelAssemblyBuilder.ReferencedAssembliesResolver.yLNNCbvV42C4rNOgbwK8((object) enumerator);
          num7 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
          {
            num7 = 0;
            goto label_46;
          }
          else
            goto label_46;
        }
label_50:
        return (string[]) ModelAssemblyBuilder.ReferencedAssembliesResolver.FA2OBRvV6ilABlDrvIvC((object) stringList1);
label_54:
        return new string[0];
      }

      private Assembly CurrentDomain_ReflectionOnlyAssemblyResolve(
        object sender,
        ResolveEventArgs args)
      {
        int num = 8;
        string str;
        Assembly assembly;
        System.Reflection.AssemblyName assemblyName;
        ResolveEventArgs args1;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_13;
            case 2:
              if (!ModelAssemblyBuilder.ReferencedAssembliesResolver.wlydTZvVtEaDGoUd9XNY((object) str))
              {
                num = 11;
                continue;
              }
              goto case 15;
            case 3:
            case 11:
              assembly = Assembly.ReflectionOnlyLoad((string) ModelAssemblyBuilder.ReferencedAssembliesResolver.YOQqEQvVHxptwIwZmf9c((object) args1));
              num = 16;
              continue;
            case 4:
              goto label_12;
            case 5:
              ModelAssemblyBuilder.ReferencedAssembliesResolver.loadedAsms[args1.Name] = assembly;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 1;
              continue;
            case 6:
              goto label_10;
            case 7:
              args1 = args;
              num = 10;
              continue;
            case 8:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 7 : 1;
              continue;
            case 9:
              str = (string) ModelAssemblyBuilder.ReferencedAssembliesResolver.hAIHh7vVD3Nmvp6tVAOc(this.path, ModelAssemblyBuilder.ReferencedAssembliesResolver.aD9ax4vVau2Z4iXxsVg5(ModelAssemblyBuilder.ReferencedAssembliesResolver.EMT99ivV1k2u420DrSKA((object) assemblyName), ModelAssemblyBuilder.ReferencedAssembliesResolver.KR1ruqvVknvgxoJyJHUP(-1146510045 ^ -1146560103)));
              num = 2;
              continue;
            case 10:
              if (!ModelAssemblyBuilder.ReferencedAssembliesResolver.loadedAsms.TryGetValue((string) ModelAssemblyBuilder.ReferencedAssembliesResolver.YOQqEQvVHxptwIwZmf9c((object) args1), out assembly))
              {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                assembly = ((IEnumerable<Assembly>) ModelAssemblyBuilder.ReferencedAssembliesResolver.tsWQQQvVAF4y8ebsi9mI((object) AppDomain.CurrentDomain)).FirstOrDefault<Assembly>((Func<Assembly, bool>) (a => ModelAssemblyBuilder.ReferencedAssembliesResolver.\u003C\u003Ec__DisplayClass2_0.jtRgXrZTBhqj5Dl48V0I(ModelAssemblyBuilder.ReferencedAssembliesResolver.\u003C\u003Ec__DisplayClass2_0.rN5QNkZTFXtApOQJCPCZ((object) a), (object) args1.Name)));
                num = 14;
                continue;
              }
              num = 6;
              continue;
            case 12:
              if (ModelAssemblyBuilder.ReferencedAssembliesResolver.eBaQNgvV74BiBYN882uo(this.path))
              {
                num = 3;
                continue;
              }
              goto case 9;
            case 13:
              goto label_6;
            case 14:
              if (!ModelAssemblyBuilder.ReferencedAssembliesResolver.dqrPA3vVegOF7Ti7e5B6((object) assembly, (object) null))
              {
                assemblyName = new System.Reflection.AssemblyName((string) ModelAssemblyBuilder.ReferencedAssembliesResolver.YOQqEQvVHxptwIwZmf9c((object) args1));
                num = 12;
                continue;
              }
              num = 5;
              continue;
            case 15:
              assembly = (Assembly) ModelAssemblyBuilder.ReferencedAssembliesResolver.AqmsZ3vVxBZIoLaCtsRE((object) str);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
              continue;
            case 16:
              ModelAssemblyBuilder.ReferencedAssembliesResolver.loadedAsms[(string) ModelAssemblyBuilder.ReferencedAssembliesResolver.YOQqEQvVHxptwIwZmf9c((object) args1)] = assembly;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 4 : 1;
              continue;
            default:
              ModelAssemblyBuilder.ReferencedAssembliesResolver.loadedAsms[(string) ModelAssemblyBuilder.ReferencedAssembliesResolver.YOQqEQvVHxptwIwZmf9c((object) args1)] = assembly;
              num = 13;
              continue;
          }
        }
label_6:
        return assembly;
label_10:
        return assembly;
label_12:
        return assembly;
label_13:
        return assembly;
      }

      public ReferencedAssembliesResolver()
      {
        ModelAssemblyBuilder.ReferencedAssembliesResolver.AcXdrmvV0WL2m5O36sca();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      static ReferencedAssembliesResolver()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              ModelAssemblyBuilder.ReferencedAssembliesResolver.loadedAsms = new Dictionary<string, Assembly>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 2;
              continue;
          }
        }
label_2:;
      }

      internal static object pb8pZUvVXyjFDpqq9SdZ() => (object) AppDomain.CurrentDomain;

      internal static bool CIJBAFvVT3lL7fGZafvB([In] object obj0) => Directory.Exists((string) obj0);

      internal static object KR1ruqvVknvgxoJyJHUP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object RufOXMvVncubluKhfAm1([In] object obj0, [In] object obj1) => (object) Directory.GetFiles((string) obj0, (string) obj1);

      internal static object PWkRTRvVOf58uf7fXuOV([In] object obj0) => (object) System.Reflection.AssemblyName.GetAssemblyName((string) obj0);

      internal static bool xFPP3TvV2GMWNvde9Zxy([In] object obj0, [In] object obj1) => (Assembly) obj0 == (Assembly) obj1;

      internal static bool dqrPA3vVegOF7Ti7e5B6([In] object obj0, [In] object obj1) => (Assembly) obj0 != (Assembly) obj1;

      internal static object dZTUJWvVPykjhAP6BfW3([In] object obj0) => (object) ((Assembly) obj0).FullName;

      internal static object EMT99ivV1k2u420DrSKA([In] object obj0) => (object) ((System.Reflection.AssemblyName) obj0).Name;

      internal static bool Fux5bIvVN4xYlZAM10p8([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

      internal static object pMctoNvV3JQEkJSIaKG1([In] object obj0) => (object) ((System.Reflection.AssemblyName) obj0).FullName;

      internal static object uLWRDxvVp8KRxNhR7VUc([In] object obj0) => (object) Assembly.ReflectionOnlyLoad((string) obj0);

      internal static object aD9ax4vVau2Z4iXxsVg5([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

      internal static object hAIHh7vVD3Nmvp6tVAOc([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

      internal static bool wlydTZvVtEaDGoUd9XNY([In] object obj0) => File.Exists((string) obj0);

      internal static bool KbOD97vVwpJq5N0ZpUeL([In] object obj0) => ((IEnumerator) obj0).MoveNext();

      internal static void yLNNCbvV42C4rNOgbwK8([In] object obj0) => ((IDisposable) obj0).Dispose();

      internal static object FA2OBRvV6ilABlDrvIvC([In] object obj0) => (object) ((List<string>) obj0).ToArray();

      internal static bool fBAFsMvVqTF8Nl4TLwZm() => ModelAssemblyBuilder.ReferencedAssembliesResolver.XA0G7YvVRsm2rqoi5Y9b == null;

      internal static ModelAssemblyBuilder.ReferencedAssembliesResolver kVeEcYvVKLv4vNhKZXIS() => (ModelAssemblyBuilder.ReferencedAssembliesResolver) ModelAssemblyBuilder.ReferencedAssembliesResolver.XA0G7YvVRsm2rqoi5Y9b;

      internal static object YOQqEQvVHxptwIwZmf9c([In] object obj0) => (object) ((ResolveEventArgs) obj0).Name;

      internal static object tsWQQQvVAF4y8ebsi9mI([In] object obj0) => (object) ((AppDomain) obj0).ReflectionOnlyGetAssemblies();

      internal static bool eBaQNgvV74BiBYN882uo([In] object obj0) => string.IsNullOrEmpty((string) obj0);

      internal static object AqmsZ3vVxBZIoLaCtsRE([In] object obj0) => (object) Assembly.ReflectionOnlyLoadFrom((string) obj0);

      internal static void AcXdrmvV0WL2m5O36sca() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
