// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.DataClassGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Генератор кода объекта конструктора интерфейсов</summary>
  internal class DataClassGenerator : ClassGenerator
  {
    internal static DataClassGenerator Nwoqo6he1S2hahxA1gbu;

    private static DataClassDescriptor DataClassDescriptor => Locator.GetServiceNotNull<DataClassDescriptor>();

    /// <summary>Генерировать синтаксическое дерево</summary>
    /// <returns>Сгенерированное синтаксическое дерево</returns>
    public IEnumerable<ISyntaxNode> Generate() => this.ignoreNamespaces.WithIgnoreNamespaces<IEnumerable<ISyntaxNode>>(new Func<IEnumerable<ISyntaxNode>>(((ClassGenerator) this).GenerateMainFile));

    /// <summary>Добавить игнорируемое пространство имен</summary>
    /// <param name="ignoreNamespace">Игнорируемое пространство имен</param>
    internal void AddIgnoreNamespace(string ignoreNamespace)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.ignoreNamespaces.Add(ignoreNamespace);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    protected override Accessibility GetMainClassAccessibility()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!DataClassGenerator.AL8aeLhepA4SaNG72HM8((object) this.metadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
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
      return Accessibility.Internal;
label_3:
      return Accessibility.Public;
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetBaseInterfaces() => (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
    {
      typeof (IDataClass).CreateTypeSyntax()
    };

    /// <inheritdoc />
    protected override ISyntaxNode GetBaseClass() => (ISyntaxNode) DataClassGenerator.NGRne3heDhLtVNcchPh2(DataClassGenerator.g9SkvSheaHPGNm3Naj39(__typeref (DataClass)));

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetMembers() => base.GetMembers().If<ISyntaxNode>(this.generationParams.Mode == GenerationMode.Publish, (Func<IEnumerable<ISyntaxNode>, IEnumerable<ISyntaxNode>>) (_ => _.Concat<ISyntaxNode>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813551087).FieldDeclaration(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -575931690).CreateTypeSyntax(), Accessibility.Private, DeclarationModifiers.Static | DeclarationModifiers.ReadOnly, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475946613).CreateTypeSyntax().MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917272318).GenericName(this.metadata.TypeName.CreateTypeSyntax())).InvocationExpression()))));

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetCtors(List<ISyntaxNode> ctorStatements) => (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
    {
      SyntaxGeneratorExtensions.ConstructorDeclaration(this.CtorParameters(), this.CtorAccessibility(), baseConstructorArguments: (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        this.generationParams.Mode == GenerationMode.Publish ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901977157).IdentifierName() : SyntaxGeneratorExtensions.Null
      }, statements: (IEnumerable<ISyntaxNode>) ctorStatements)
    };

    /// <inheritdoc />
    protected override void WritePropertyAttributes(
      ISyntaxNode property,
      PropertyMetadata propertyMetadata,
      string resourcePrefix = null)
    {
      int num = 5;
      int index;
      PropertyMetadataAdditionalAttribute[] additionalAttributes;
      string fullName;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
          case 6:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 8 : 6;
            continue;
          case 2:
            fullName = TypeOf<ObsoleteAttribute>.FullName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 3 : 3;
            continue;
          case 3:
            additionalAttributes = propertyMetadata.AdditionalAttributes;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 9 : 8;
            continue;
          case 4:
            if (propertyMetadata.AdditionalAttributes.Length == 0)
            {
              num = 10;
              continue;
            }
            goto case 2;
          case 5:
            if (propertyMetadata.AdditionalAttributes != null)
            {
              num = 4;
              continue;
            }
            goto case 10;
          case 7:
            property.AddAttributes(TypeOf<EditorBrowsableAttribute>.Raw.CreateAttribute((object) EditorBrowsableState.Never));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 2 : 6;
            continue;
          case 8:
          case 12:
            if (index >= additionalAttributes.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 11;
              continue;
            }
            goto case 13;
          case 9:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 12 : 3;
            continue;
          case 10:
          case 11:
            base.WritePropertyAttributes(property, propertyMetadata, resourcePrefix);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
            continue;
          case 13:
            if (!(additionalAttributes[index].AddtibuteName == fullName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 1;
              continue;
            }
            goto case 7;
          default:
            goto label_2;
        }
      }
label_4:
      return;
label_2:;
    }

    /// <inheritdoc />
    protected override void WriteTypeAttributes(ISyntaxNode type)
    {
      int num1 = 5;
      List<DataClassDependency>.Enumerator enumerator;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_26;
            case 1:
              goto label_14;
            case 2:
              goto label_8;
            case 3:
              goto label_7;
            case 4:
              if (DataClassGenerator.ep5TvthetF3V6QKvAcmD((object) this.generationParams) != GenerationMode.Publish)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 2;
                continue;
              }
              base.WriteTypeAttributes(type);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 6 : 4;
              continue;
            case 5:
              if (this.metadata is DataClassMetadata metadata)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 2 : 4;
                continue;
              }
              goto label_22;
            case 6:
              enumerator = metadata.IncludeList.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
              continue;
            case 7:
              goto label_4;
            default:
              goto label_16;
          }
        }
label_8:
        this.WriteIncludeComments(type, metadata);
        num1 = 3;
      }
label_26:
      return;
label_7:
      return;
label_4:
      return;
label_16:
      return;
label_22:
      return;
label_14:
      try
      {
label_19:
        if (enumerator.MoveNext())
          goto label_18;
        else
          goto label_20;
label_15:
        DataClassDependency current;
        DataClassMetadata dataClassMetadata;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_10;
            case 1:
              // ISSUE: type reference
              type.AddAttributes(DataClassGenerator.g9SkvSheaHPGNm3Naj39(__typeref (IncludeAttribute)).CreateAttribute(DataClassGenerator.WTnNZeheAKem2rXxJd3Z((object) DataClassGenerator.oUuY17heHJMvpilW7ami((object) dataClassMetadata).ToString())));
              num3 = 3;
              continue;
            case 2:
              goto label_18;
            case 3:
              goto label_19;
            case 4:
              dataClassMetadata = (DataClassMetadata) DataClassGenerator.dAL8Avhe6o7NHihv5vlq(DataClassGenerator.zF1tKhhewlB3OcmbWlEt(), DataClassGenerator.YoLVukhe48q8EsuHc10N((object) current));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
              continue;
            default:
              goto label_3;
          }
        }
label_10:
        return;
label_3:
        return;
label_18:
        current = enumerator.Current;
        num3 = 4;
        goto label_15;
label_20:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
        goto label_15;
      }
      finally
      {
        enumerator.Dispose();
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
    }

    /// <inheritdoc />
    protected override GeneratedFileInfo GenerateMainFileInternal()
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            Contract.NotNull((object) this.metadata, (string) DataClassGenerator.b2a5fche7d2YLB7bGku8(1514961705 ^ 1514942999));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            goto label_4;
        }
      }
label_3:
      GeneratedFileInfo mainFileHelper;
      return mainFileHelper;
label_4:
      try
      {
        ISyntaxNode syntaxNode = ((string) DataClassGenerator.DNdXeuhexEud7YZ6kXJT((object) this.metadata)).NamespaceDeclaration(this.GetNamespaces().Concat<ISyntaxNode>(this.GenerateMainFile()));
        int num2 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
          num2 = 2;
        ISyntaxTrivia[] array;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 4:
              mainFileHelper = this.GenerateMainFileHelper((string) DataClassGenerator.rk9Cf1heyS4Pkm2OxQrW(DataClassGenerator.OKPJ5Zhe0x40bT24Sqqv((object) this.generationParams.Prefix) ? (object) "" : (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70036252) + (string) DataClassGenerator.YINXVkhemhTG4G4c8VxQ((object) this.generationParams)), DataClassGenerator.b2a5fche7d2YLB7bGku8(1470998129 - 231418599 ^ 1239638724)), syntaxNode);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            case 2:
              array = this.WriteLocalizationResources().ToArray<ISyntaxTrivia>();
              num2 = 3;
              continue;
            case 3:
              if (array.Length == 0)
              {
                num2 = 4;
                continue;
              }
              goto case 5;
            case 5:
              syntaxNode.TextCommentsTrailing((IEnumerable<ISyntaxTrivia>) array);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
              continue;
            default:
              goto label_3;
          }
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            throw new CodeGenerationException(EleWise.ELMA.SR.T((string) DataClassGenerator.b2a5fche7d2YLB7bGku8(-2138160520 ^ -2138090248), (object) this.metadata.Name), ex);
        }
      }
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> WriteProperty(
      PropertyMetadata propertyMetadata,
      List<ISyntaxNode> ctorStatements,
      bool writeAttributes = true,
      Action<ISyntaxNode> propertyAction = null)
    {
      if (propertyMetadata.TypeUid == ActionDescriptor.UID)
        return Enumerable.Empty<ISyntaxNode>();
      ITypeGenerationInfo propertyTypeDescriptor = (ITypeGenerationInfo) this.GetPropertyTypeDescriptor(propertyMetadata);
      ISyntaxNode propertyTypeReference = this.GetPropertyTypeReference(propertyMetadata, propertyTypeDescriptor);
      IEnumerable<ISyntaxNode> getAccessorStatements = (IEnumerable<ISyntaxNode>) null;
      IEnumerable<ISyntaxNode> setAccessorStatements = (IEnumerable<ISyntaxNode>) null;
      if (this.generationParams.Mode == GenerationMode.Publish)
      {
        getAccessorStatements = (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521322344).GenericName(propertyTypeReference).InvocationExpression(CodeGenerator.CreateGuid(this.metadata.Uid), CodeGenerator.CreateGuid(propertyMetadata.Uid)).ReturnStatement()
        };
        setAccessorStatements = (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289750754).GenericName(propertyTypeReference).InvocationExpression(CodeGenerator.CreateGuid(this.metadata.Uid), CodeGenerator.CreateGuid(propertyMetadata.Uid), SyntaxGeneratorExtensions.Value)
        };
      }
      ISyntaxNode property = this.PropertyDeclaration(propertyMetadata, propertyTypeReference, getAccessorStatements, setAccessorStatements);
      this.WritePropertyComments(property, propertyMetadata);
      if (this.generationParams.Mode == GenerationMode.Publish)
        this.WritePropertyAttributes(property, propertyMetadata, (string) null);
      return (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        property
      };
    }

    /// <inheritdoc />
    protected override ISyntaxNode PropertyDeclaration(
      PropertyMetadata propertyMetadata,
      ISyntaxNode propertyType,
      IEnumerable<ISyntaxNode> getAccessorStatements = null,
      IEnumerable<ISyntaxNode> setAccessorStatements = null)
    {
      bool flag = false;
      if (propertyMetadata.TypeUid == ListOfSimpleTypeDescriptor.UID)
      {
        flag = true;
      }
      else
      {
        RelationType? relationType1 = this.GetRelationType(propertyMetadata);
        if (relationType1.HasValue)
        {
          RelationType? nullable = relationType1;
          RelationType relationType2 = RelationType.OneToOne;
          if (!(nullable.GetValueOrDefault() == relationType2 & nullable.HasValue))
            flag = true;
        }
      }
      return propertyMetadata.Name.PropertyDeclaration(propertyType, Accessibility.Public, DeclarationModifiers.Virtual, getAccessorStatements, setAccessorStatements, setterAccessibility: flag ? Accessibility.Private : Accessibility.NotApplicable);
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> UidStaticMembers(bool useNewKeyword = false) => Enumerable.Empty<ISyntaxNode>();

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxTrivia> WriteLocalizationResources()
    {
      List<ISyntaxTrivia> list = base.WriteLocalizationResources().ToList<ISyntaxTrivia>();
      foreach (PropertyMetadata property in this.metadata.Properties)
      {
        ISyntaxTrivia syntaxTrivia1 = this.GetLocalizableText(property.DisplayName).TextComment();
        if (syntaxTrivia1 != null)
          list.Add(syntaxTrivia1);
        ISyntaxTrivia syntaxTrivia2 = this.GetLocalizableText(property.Description).TextComment();
        if (syntaxTrivia2 != null)
          list.Add(syntaxTrivia2);
      }
      return (IEnumerable<ISyntaxTrivia>) list;
    }

    /// <summary>Записать комментарии для вложенных DTO</summary>
    /// <param name="type">Генерируемый тип</param>
    /// <param name="dataClassMetadata">Метаданные</param>
    protected internal void WriteIncludeComments(
      ISyntaxNode type,
      DataClassMetadata dataClassMetadata)
    {
      int num = 4;
      List<ISyntaxTrivia> comments;
      List<DataClassDependency> includeList;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DataClassGenerator.WriteIncludeComments((ICollection<ISyntaxTrivia>) comments, (IEnumerable<DataClassDependency>) includeList);
            num = 6;
            continue;
          case 2:
            if (includeList.Count > 0)
            {
              num = 5;
              continue;
            }
            goto case 1;
          case 3:
            includeList = dataClassMetadata.IncludeList;
            num = 2;
            continue;
          case 4:
            comments = new List<ISyntaxTrivia>();
            num = 3;
            continue;
          case 5:
            comments.Add((ISyntaxTrivia) DataClassGenerator.DUMRQdheM4WobOIhwnB3((object) EleWise.ELMA.SR.T((string) DataClassGenerator.b2a5fche7d2YLB7bGku8(1470998129 - 231418599 ^ 1239492456))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
            continue;
          case 6:
            if (DataClassGenerator.kUxyKLheJuvKlPETVdfY((object) comments) > 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 2 : 7;
              continue;
            }
            goto label_12;
          case 7:
            type.TextComments((IEnumerable<ISyntaxTrivia>) comments);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
            continue;
          default:
            goto label_13;
        }
      }
label_2:
      return;
label_13:
      return;
label_12:;
    }

    private static void WriteIncludeComments(
      ICollection<ISyntaxTrivia> comments,
      IEnumerable<DataClassDependency> includeList,
      string indent = null)
    {
      foreach (DataClassDependency include in includeList)
      {
        comments.Add(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979527830), (object) indent, (object) include.Name, (object) include.ModuleUid, (object) include.HeaderUid).TextComment());
        try
        {
          DataClassMetadata metadataByUid = DataClassGenerator.DataClassDescriptor.GetMetadataByUid(include.HeaderUid);
          if (metadataByUid != null)
            DataClassGenerator.WriteIncludeComments(comments, (IEnumerable<DataClassDependency>) metadataByUid.IncludeList, indent + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515136579));
        }
        catch (Exception ex)
        {
        }
      }
    }

    public DataClassGenerator()
    {
      DataClassGenerator.cgVqLqhe9Gs1GEDjs4xx();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool JRcd83heNqpq5AAxKdLh() => DataClassGenerator.Nwoqo6he1S2hahxA1gbu == null;

    internal static DataClassGenerator rmHpoUhe3UC21DjfEljs() => DataClassGenerator.Nwoqo6he1S2hahxA1gbu;

    internal static bool AL8aeLhepA4SaNG72HM8([In] object obj0) => ((AbstractMetadata) obj0).Internal;

    internal static Type g9SkvSheaHPGNm3Naj39([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object NGRne3heDhLtVNcchPh2(Type type) => (object) type.CreateTypeSyntax();

    internal static GenerationMode ep5TvthetF3V6QKvAcmD([In] object obj0) => ((GenerationParams) obj0).Mode;

    internal static object zF1tKhhewlB3OcmbWlEt() => (object) DataClassGenerator.DataClassDescriptor;

    internal static Guid YoLVukhe48q8EsuHc10N([In] object obj0) => ((Dependency) obj0).HeaderUid;

    internal static object dAL8Avhe6o7NHihv5vlq([In] object obj0, Guid typeUid) => (object) ((DataClassDescriptor) obj0).GetMetadataByUid(typeUid);

    internal static Guid oUuY17heHJMvpilW7ami([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object WTnNZeheAKem2rXxJd3Z([In] object obj0) => (object) obj0.CreateSyntaxNode();

    internal static object b2a5fche7d2YLB7bGku8(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object DNdXeuhexEud7YZ6kXJT([In] object obj0) => (object) ((ClassMetadata) obj0).Namespace;

    internal static bool OKPJ5Zhe0x40bT24Sqqv([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object YINXVkhemhTG4G4c8VxQ([In] object obj0) => (object) ((GenerationParams) obj0).Prefix;

    internal static object rk9Cf1heyS4Pkm2OxQrW([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object DUMRQdheM4WobOIhwnB3([In] object obj0) => (object) ((string) obj0).TextComment();

    internal static int kUxyKLheJuvKlPETVdfY([In] object obj0) => ((List<ISyntaxTrivia>) obj0).Count;

    internal static void cgVqLqhe9Gs1GEDjs4xx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
