// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.ViewModelContextGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Генератор для класса контекста модели отображения</summary>
  public sealed class ViewModelContextGenerator : ClassGenerator
  {
    private readonly Guid? parentMetadataUid;
    internal static ViewModelContextGenerator Qepm81hO6k3eF9Pb7gF1;

    private string ClassName => (string) ViewModelContextGenerator.K5VaKFhOxb530xJCG5yy((object) this.metadata.Name, ViewModelContextGenerator.IBlgY9hO7jGSXhwNCkIa(874012245 ^ 874179169));

    private DataClassMetadata ViewModelMetadata => (DataClassMetadata) ViewModelContextGenerator.RU14SBhO0QFcZUnQp7uh((object) (EntityMetadata) this.metadata);

    /// <summary>Ctor</summary>
    /// <param name="parentMetadataUid">Уникальный идентификатор родительских метаданных</param>
    public ViewModelContextGenerator(Guid? parentMetadataUid)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.parentMetadataUid = parentMetadataUid;
    }

    /// <summary>Сгенерировать класс ViewModelContext</summary>
    /// <returns>Класс ViewModelContext</returns>
    public ISyntaxNode Generate()
    {
      int num = 1;
      ISyntaxNode syntaxNode;
      while (true)
      {
        switch (num)
        {
          case 1:
            syntaxNode = this.ClassName.ClassDeclaration(Accessibility.Internal, DeclarationModifiers.Sealed, (ISyntaxNode) ViewModelContextGenerator.p2xRmlhOmMaOyPTKM5GJ((object) this), members: this.GetMembers());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
            continue;
          case 2:
            ViewModelContextGenerator.WmuX6BhOM5yCB8mq5Sar((object) this, (object) syntaxNode);
            num = 3;
            continue;
          case 3:
            goto label_5;
          default:
            ViewModelContextGenerator.r3BErihOyWGZXlR0Lpi6((object) this, (object) syntaxNode);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 2 : 2;
            continue;
        }
      }
label_5:
      return syntaxNode;
    }

    /// <inheritdoc />
    protected override ISyntaxNode GetBaseClass() => (ISyntaxNode) ViewModelContextGenerator.mReRAZhO9c6snBnAIZSE(ViewModelContextGenerator.E5QtqNhOJKJV7Qu6tQ8K(__typeref (DataClass)));

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetCtors(List<ISyntaxNode> ctorStatements) => (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
    {
      SyntaxGeneratorExtensions.ConstructorDeclaration(this.CtorParameters(), this.CtorAccessibility(), baseConstructorArguments: (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        this.generationParams.Mode == GenerationMode.Publish ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901977157).IdentifierName() : SyntaxGeneratorExtensions.Null
      }, statements: (IEnumerable<ISyntaxNode>) ctorStatements)
    };

    /// <inheritdoc />
    protected override void WriteTypeAttributes(ISyntaxNode type)
    {
      int num = 4;
      Guid? parentMetadataUid;
      Guid guid;
      while (true)
      {
        switch (num)
        {
          case 1:
            ISyntaxNode syntaxNode1 = type;
            ISyntaxNode[] syntaxNodeArray1 = new ISyntaxNode[1];
            Type attributeType1 = typeof (EntityMetadataUidAttribute);
            object[] objArray1 = new object[1];
            guid = this.metadata.Uid;
            objArray1[0] = (object) guid.ToString();
            syntaxNodeArray1[0] = attributeType1.CreateAttribute(objArray1);
            syntaxNode1.AddAttributes(syntaxNodeArray1);
            num = 2;
            continue;
          case 2:
            parentMetadataUid = this.parentMetadataUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
            continue;
          case 3:
            // ISSUE: type reference
            // ISSUE: type reference
            type.AddAttributes(ViewModelContextGenerator.E5QtqNhOJKJV7Qu6tQ8K(__typeref (MetadataTypeAttribute)).CreateAttribute((object) ViewModelContextGenerator.E5QtqNhOJKJV7Qu6tQ8K(__typeref (DataClassMetadata))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 0;
            continue;
          case 4:
            ISyntaxNode syntaxNode2 = type;
            ISyntaxNode[] syntaxNodeArray2 = new ISyntaxNode[1];
            // ISSUE: type reference
            Type attributeType2 = ViewModelContextGenerator.E5QtqNhOJKJV7Qu6tQ8K(__typeref (UidAttribute));
            object[] objArray2 = new object[1];
            guid = ViewModelContextGenerator.wb80SLhOdtWh0B6Pn6WQ((object) this.ViewModelMetadata);
            objArray2[0] = (object) guid.ToString();
            syntaxNodeArray2[0] = attributeType2.CreateAttribute(objArray2);
            syntaxNode2.AddAttributes(syntaxNodeArray2);
            num = 3;
            continue;
          case 5:
            parentMetadataUid = this.parentMetadataUid;
            num = 7;
            continue;
          case 6:
            goto label_2;
          case 7:
            if (ViewModelContextGenerator.D82xbLhOl4w99HT91mTs(parentMetadataUid.Value, Guid.Empty))
            {
              num = 8;
              continue;
            }
            goto label_13;
          case 8:
            ISyntaxNode syntaxNode3 = type;
            ISyntaxNode[] syntaxNodeArray3 = new ISyntaxNode[1];
            // ISSUE: type reference
            Type attributeType3 = ViewModelContextGenerator.E5QtqNhOJKJV7Qu6tQ8K(__typeref (IncludeAttribute));
            object[] objArray3 = new object[1];
            parentMetadataUid = this.parentMetadataUid;
            guid = parentMetadataUid.Value;
            objArray3[0] = (object) guid.ToString();
            syntaxNodeArray3[0] = attributeType3.CreateAttribute(objArray3);
            syntaxNode3.AddAttributes(syntaxNodeArray3);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 6 : 5;
            continue;
          default:
            if (parentMetadataUid.HasValue)
            {
              num = 5;
              continue;
            }
            goto label_14;
        }
      }
label_2:
      return;
label_13:
      return;
label_14:;
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetMembers() => (IEnumerable<ISyntaxNode>) new ViewModelContextGenerator.\u003CGetMembers\u003Ed__11(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> WriteProperty(
      PropertyMetadata propertyMetadata,
      List<ISyntaxNode> ctorStatements,
      bool writeAttributes = true,
      Action<ISyntaxNode> propertyAction = null)
    {
      Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993452635));
      if (propertyMetadata.TypeUid == ActionDescriptor.UID)
        return Enumerable.Empty<ISyntaxNode>();
      if (propertyMetadata is IViewModelPropertyMetadata propertyMetadata1 && propertyMetadata1.ClientOnly)
        return Enumerable.Empty<ISyntaxNode>();
      ITypeGenerationInfo propertyTypeDescriptor = (ITypeGenerationInfo) this.GetPropertyTypeDescriptor(propertyMetadata);
      ISyntaxNode propertyTypeReference = this.GetPropertyTypeReference(propertyMetadata, propertyTypeDescriptor);
      IEnumerable<ISyntaxNode> getAccessorStatements = (IEnumerable<ISyntaxNode>) null;
      IEnumerable<ISyntaxNode> setAccessorStatements = (IEnumerable<ISyntaxNode>) null;
      if (this.generationParams.Mode == GenerationMode.Publish)
      {
        getAccessorStatements = (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123685856).InvocationExpression(CodeGenerator.CreateGuid(this.ViewModelMetadata.Uid), CodeGenerator.CreateGuid(propertyMetadata.Uid)).CastExpression(propertyTypeReference).ReturnStatement()
        };
        setAccessorStatements = (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488697409).InvocationExpression(CodeGenerator.CreateGuid(this.ViewModelMetadata.Uid), CodeGenerator.CreateGuid(propertyMetadata.Uid), SyntaxGeneratorExtensions.Value)
        };
      }
      ISyntaxNode property = propertyMetadata.Name.PropertyDeclaration(propertyTypeReference, Accessibility.Public, getAccessorStatements: getAccessorStatements, setAccessorStatements: setAccessorStatements, setterAccessibility: propertyMetadata.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397218452) ? Accessibility.Private : Accessibility.NotApplicable);
      if (writeAttributes)
        this.WritePropertyComments(property, propertyMetadata);
      return (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        property
      };
    }

    /// <inheritdoc />
    protected override ISyntaxNode GetPropertyTypeReference(
      PropertyMetadata propertyMetadata,
      ITypeGenerationInfo typeDescriptor)
    {
      int num = 1;
      DataClassMetadata dataClassMetadata1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DataClassMetadata dataClassMetadata2 = new DataClassMetadata();
            ViewModelContextGenerator.AQC5i9hOr44WEuPFXNtq((object) dataClassMetadata2, ViewModelContextGenerator.wb80SLhOdtWh0B6Pn6WQ((object) this.metadata));
            ViewModelContextGenerator.R2EHXehOg9lTQwwQUtYi((object) dataClassMetadata2, this.metadata.BaseClassUid);
            dataClassMetadata2.isInterfaceType = new bool?(ViewModelContextGenerator.T1w05qhO5UbVIfwY7a48((object) this.metadata));
            dataClassMetadata1 = dataClassMetadata2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (ISyntaxNode) ViewModelContextGenerator.zdMy2QhOjWrOI2TQort6((object) typeDescriptor, (object) dataClassMetadata1, (object) propertyMetadata, false);
    }

    internal static object IBlgY9hO7jGSXhwNCkIa(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object K5VaKFhOxb530xJCG5yy([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool keiC8rhOHJyOY62MBXHT() => ViewModelContextGenerator.Qepm81hO6k3eF9Pb7gF1 == null;

    internal static ViewModelContextGenerator SnvuTjhOA5Qq3jKncSpS() => ViewModelContextGenerator.Qepm81hO6k3eF9Pb7gF1;

    internal static object RU14SBhO0QFcZUnQp7uh([In] object obj0) => (object) ((EntityMetadata) obj0).ViewModelMetadata;

    internal static object p2xRmlhOmMaOyPTKM5GJ([In] object obj0) => (object) ((ClassGenerator) obj0).GetBaseClass();

    internal static void r3BErihOyWGZXlR0Lpi6([In] object obj0, [In] object obj1) => ((ClassGenerator) obj0).WriteComments((ISyntaxNode) obj1);

    internal static void WmuX6BhOM5yCB8mq5Sar([In] object obj0, [In] object obj1) => ((ClassGenerator) obj0).WriteTypeAttributes((ISyntaxNode) obj1);

    internal static Type E5QtqNhOJKJV7Qu6tQ8K([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object mReRAZhO9c6snBnAIZSE(Type type) => (object) type.CreateTypeSyntax();

    internal static Guid wb80SLhOdtWh0B6Pn6WQ([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool D82xbLhOl4w99HT91mTs([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static void AQC5i9hOr44WEuPFXNtq([In] object obj0, Guid value) => ((AbstractMetadata) obj0).Uid = value;

    internal static void R2EHXehOg9lTQwwQUtYi([In] object obj0, Guid value) => ((ClassMetadata) obj0).BaseClassUid = value;

    internal static bool T1w05qhO5UbVIfwY7a48([In] object obj0) => ((ClassMetadata) obj0).IsInterfaceType;

    internal static object zdMy2QhOjWrOI2TQort6(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      bool forFilter)
    {
      return (object) ((ITypeGenerationInfo) obj0).GetPropertyTypeReference((ClassMetadata) obj1, (PropertyMetadata) obj2, forFilter);
    }
  }
}
