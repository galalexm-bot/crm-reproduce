// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.CodeGeneration.ComponentMetadataGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.CodeGeneration
{
  /// <summary>Генератор метаданных компонента</summary>
  internal class ComponentMetadataGenerator : CodeGenerator
  {
    internal static ComponentMetadataGenerator aE4VSTBVF0sGiHCKJ5ew;

    /// <summary>Метаданные компонента</summary>
    protected ComponentMetadata Metadata
    {
      get => this.\u003CMetadata\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CMetadata\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
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

    /// <inheritdoc />
    protected override void InitInternal(IMetadata metadata)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            ComponentMetadataGenerator.cj6pTkBVhmNqvxSwPEw9(metadata is ComponentMetadata, ComponentMetadataGenerator.zx12h1BVojUZ4Hc6aLDC(-630932142 - 1120244082 ^ -1751243328));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          case 3:
            ComponentMetadataGenerator.Ep9IXqBVbkMWIZmP1l0X((object) metadata, ComponentMetadataGenerator.zx12h1BVojUZ4Hc6aLDC(--1418440330 ^ 1418454964));
            num = 2;
            continue;
          default:
            this.Metadata = (ComponentMetadata) metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    protected override GeneratedFileInfo GenerateMainFileInternal()
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            Contract.NotNull((object) this.Metadata, (string) ComponentMetadataGenerator.zx12h1BVojUZ4Hc6aLDC(~289714581 ^ -289671000));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 1;
            continue;
          default:
            goto label_14;
        }
      }
label_3:
      GeneratedFileInfo mainFileHelper;
      try
      {
        ISyntaxNode[] array1 = this.GetNamespaces().Concat<ISyntaxNode>(this.GenerateMainFile()).ToArray<ISyntaxNode>();
        int num2 = 2;
        ISyntaxTrivia[] array2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_14;
            case 2:
              array2 = this.WriteLocalizationResources().ToArray<ISyntaxTrivia>();
              num2 = 3;
              continue;
            case 3:
              if (((IEnumerable<ISyntaxTrivia>) array2).Any<ISyntaxTrivia>())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 4:
              mainFileHelper = this.GenerateMainFileHelper((string) ComponentMetadataGenerator.zx12h1BVojUZ4Hc6aLDC(~210725948 ^ -210664039), ((string) ComponentMetadataGenerator.CchBsVBVG1JKSgaJJe3b((object) this.Metadata)).NamespaceDeclaration(array1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 1;
              continue;
            default:
              ((IEnumerable<ISyntaxNode>) array1).Last<ISyntaxNode>().TextCommentsTrailing((IEnumerable<ISyntaxTrivia>) array2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 4;
              continue;
          }
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            throw new CodeGenerationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939446772), ComponentMetadataGenerator.O3RB5UBVE05QL6tNrP0y((object) this.Metadata)), ex);
        }
      }
label_14:
      return mainFileHelper;
    }

    /// <inheritdoc />
    protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal() => (IEnumerable<GeneratedFileInfo>) new GeneratedFileInfo[2]
    {
      this.GenerateMainFileHelper(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479560462), this.GenerateViewModel()),
      this.GenerateMainFileHelper(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822822148), this.GenerateServerController())
    };

    /// <summary>Получить пространства имён</summary>
    /// <returns>Пространства имён</returns>
    protected virtual IEnumerable<ISyntaxNode> GetNamespaces() => (IEnumerable<ISyntaxNode>) new ComponentMetadataGenerator.\u003CGetNamespaces\u003Ed__10(-2);

    /// <summary>Сгенерировать основной файл</summary>
    /// <returns></returns>
    protected virtual IEnumerable<ISyntaxNode> GenerateMainFile() => (IEnumerable<ISyntaxNode>) new ComponentMetadataGenerator.\u003CGenerateMainFile\u003Ed__11(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>Сгенерировать наполнение основного файла</summary>
    /// <returns></returns>
    protected virtual IEnumerable<ISyntaxNode> GenerateMainFileContent() => this.GenerateFileContent(new ComponentContextGenerator()).Concat<ISyntaxNode>(this.GenerateDataClasses(new DataClassGenerator()));

    /// <summary>Сгенерировать код контекста компонента</summary>
    /// <param name="generator">Генератор</param>
    /// <returns>Код</returns>
    protected IEnumerable<ISyntaxNode> GenerateFileContent(ComponentContextGenerator generator)
    {
      Contract.NotNull((object) this.Metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123676484));
      Contract.NotNull((object) this.Metadata.Content, z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654236741));
      Contract.NotNull((object) this.Metadata.Content.Context, z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439544164));
      ComponentContextMetadata context = this.Metadata.Content.Context;
      EntityMetadata entityMetadata1 = new EntityMetadata();
      entityMetadata1.Properties = context.Properties;
      entityMetadata1.Namespace = this.Metadata.Namespace;
      entityMetadata1.Name = context.Name;
      entityMetadata1.DisplayName = context.DisplayName;
      entityMetadata1.Uid = context.Uid;
      entityMetadata1.Type = EntityMetadataType.Entity;
      EntityMetadata entityMetadata2 = entityMetadata1;
      ((ICodeGenerator) generator).Metadata = (IMetadata) entityMetadata2;
      ((ICodeGenerator) generator).GenerationParams.Mode = this.generationParams.Mode;
      return generator.Generate();
    }

    /// <summary>Сгенерировать код локальных датаклассов компонента</summary>
    /// <param name="dataClassGenerator">Генератор</param>
    /// <returns>Код</returns>
    protected IEnumerable<ISyntaxNode> GenerateDataClasses(DataClassGenerator dataClassGenerator)
    {
      Contract.NotNull((object) this.Metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629808160));
      List<ISyntaxNode> dataClasses = new List<ISyntaxNode>();
      foreach (DataClassMetadata dataClass in this.Metadata.DataClasses)
      {
        ((ICodeGenerator) dataClassGenerator).Metadata = (IMetadata) dataClass;
        ((ICodeGenerator) dataClassGenerator).GenerationParams.Mode = this.generationParams.Mode;
        dataClassGenerator.AddIgnoreNamespace(this.Metadata.Namespace);
        dataClasses.AddRange(dataClassGenerator.Generate());
      }
      return (IEnumerable<ISyntaxNode>) dataClasses;
    }

    /// <summary>Сгенерировать класс ViewModel</summary>
    /// <returns>Сгенерированный класс ViewModel</returns>
    protected virtual ISyntaxNode GenerateViewModel()
    {
      ComponentViewModelGenerator viewModelGenerator = new ComponentViewModelGenerator();
      ComponentMetadataGenerator.jBiqWdBVfHtwVunfNie2((object) viewModelGenerator, (object) this.Metadata);
      return (ISyntaxNode) ComponentMetadataGenerator.JO0w3tBVQJ3QVYKXpLWE((object) viewModelGenerator);
    }

    /// <summary>Записать ресурсы локализации</summary>
    protected virtual IEnumerable<ISyntaxTrivia> WriteLocalizationResources()
    {
      List<ISyntaxTrivia> list = this.Resources().ToList<ISyntaxTrivia>();
      if (!list.Any<ISyntaxTrivia>())
        return Enumerable.Empty<ISyntaxTrivia>();
      list.Insert(0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372691889).TextComment());
      return (IEnumerable<ISyntaxTrivia>) list;
    }

    /// <summary>Записать ресурсы класса</summary>
    protected virtual IEnumerable<ISyntaxTrivia> Resources() => (IEnumerable<ISyntaxTrivia>) new ComponentMetadataGenerator.\u003CResources\u003Ed__17(-2)
    {
      \u003C\u003E4__this = this
    };

    private ISyntaxNode GenerateServerController()
    {
      ComponentServerControllerGenerator controllerGenerator = new ComponentServerControllerGenerator();
      ComponentMetadataGenerator.jBiqWdBVfHtwVunfNie2((object) controllerGenerator, (object) this.Metadata);
      return (ISyntaxNode) ComponentMetadataGenerator.dNHP5jBVC8TTGmHMTGbR((object) controllerGenerator);
    }

    private ISyntaxNode CreateContainerTypeDeclaration()
    {
      int num = 1;
      ISyntaxNode declaration;
      while (true)
      {
        switch (num)
        {
          case 1:
            declaration = ((string) ComponentMetadataGenerator.O3RB5UBVE05QL6tNrP0y((object) this.Metadata)).ClassDeclaration(Accessibility.Internal, DeclarationModifiers.Partial, members: this.GenerateMainFileContent());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          case 3:
            this.WriteBasicAttributes(declaration);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 1 : 2;
            continue;
          default:
            if (ComponentMetadataGenerator.u6FAXbBVvBURsHWJE2uy((object) this.generationParams) == GenerationMode.Publish)
            {
              num = 3;
              continue;
            }
            goto label_6;
        }
      }
label_6:
      return declaration;
    }

    public ComponentMetadataGenerator()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool VyEWlZBVBqmplPtge1g1() => ComponentMetadataGenerator.aE4VSTBVF0sGiHCKJ5ew == null;

    internal static ComponentMetadataGenerator WEPydxBVW1U4NCBoM2F7() => ComponentMetadataGenerator.aE4VSTBVF0sGiHCKJ5ew;

    internal static object zx12h1BVojUZ4Hc6aLDC(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void Ep9IXqBVbkMWIZmP1l0X([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void cj6pTkBVhmNqvxSwPEw9(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static object CchBsVBVG1JKSgaJJe3b([In] object obj0) => (object) ((ComponentMetadata) obj0).Namespace;

    internal static object O3RB5UBVE05QL6tNrP0y([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static void jBiqWdBVfHtwVunfNie2([In] object obj0, [In] object obj1) => ((ICodeGenerator) obj0).Metadata = (IMetadata) obj1;

    internal static object JO0w3tBVQJ3QVYKXpLWE([In] object obj0) => (object) ((ComponentViewModelGenerator) obj0).Generate();

    internal static object dNHP5jBVC8TTGmHMTGbR([In] object obj0) => (object) ((ComponentServerControllerGenerator) obj0).Generate();

    internal static GenerationMode u6FAXbBVvBURsHWJE2uy([In] object obj0) => ((GenerationParams) obj0).Mode;

    internal static object Vo7CYhBV8lm5T4cXQFfg([In] object obj0) => (object) ((string) obj0).TextComment();
  }
}
