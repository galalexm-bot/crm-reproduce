// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApi.PublicApiEntityFilterHelperNode
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.API;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi
{
  public class PublicApiEntityFilterHelperNode : IPublicApiNode
  {
    private bool isDelta;
    private readonly ISyntaxNode[] notImplStatements;
    private readonly Dictionary<Guid, string> _objectTypes;
    private static PublicApiEntityFilterHelperNode w0I4EihHR8nxvbeLwURn;

    /// <summary>Метаданные</summary>
    internal EntityMetadata EntityMetadata { get; }

    public PublicApiEntityFilterHelperNode([NotNull] EntityMetadata entityMetadata)
    {
      PublicApiEntityFilterHelperNode.h4aOT9hHXSUdH3DT4uBq();
      ISyntaxNode[] syntaxNodeArray;
      if (!PublicApiEntityFilterHelperNode.Qj8nibhHT94YudPeiXcC())
        syntaxNodeArray = (ISyntaxNode[]) null;
      else
        syntaxNodeArray = new ISyntaxNode[1]
        {
          (ISyntaxNode) PublicApiEntityFilterHelperNode.jJU7IXhHkCUGBGUgj9by()
        };
      this.notImplStatements = syntaxNodeArray;
      this._objectTypes = new Dictionary<Guid, string>()
      {
        {
          new Guid((string) PublicApiEntityFilterHelperNode.ddhRLChHnTebe2B1ojB0(694673736 ^ -23604109 ^ -671923677)),
          (string) PublicApiEntityFilterHelperNode.MIpegbhHOk23RWDvMWWw((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461468471))
        },
        {
          new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538595470)),
          (string) PublicApiEntityFilterHelperNode.MIpegbhHOk23RWDvMWWw(PublicApiEntityFilterHelperNode.ddhRLChHnTebe2B1ojB0(1917998801 >> 2 ^ 479599110))
        },
        {
          new Guid((string) PublicApiEntityFilterHelperNode.ddhRLChHnTebe2B1ojB0(-105199646 ^ -105271214)),
          (string) PublicApiEntityFilterHelperNode.MIpegbhHOk23RWDvMWWw(PublicApiEntityFilterHelperNode.ddhRLChHnTebe2B1ojB0(272623989 ^ 272408201))
        },
        {
          new Guid((string) PublicApiEntityFilterHelperNode.ddhRLChHnTebe2B1ojB0(-53329496 >> 4 ^ -3253248)),
          EleWise.ELMA.SR.T((string) PublicApiEntityFilterHelperNode.ddhRLChHnTebe2B1ojB0(825385222 ^ 825301344))
        }
      };
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
        num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (PublicApiEntityFilterHelperNode.oJ47DThH2BKB7gkxDqmH((object) entityMetadata) == EntityMetadataType.Interface)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 2;
              continue;
            }
            break;
          case 2:
            entityMetadata = (EntityMetadata) ((PublicApiCodeGenerator) PublicApiEntityFilterHelperNode.b3wmh0hHegOOPeaegRoC()).GetMetadata(PublicApiEntityFilterHelperNode.KBuBOYhHPEieZ92T7dCw((object) entityMetadata));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
            continue;
          case 3:
            if (PublicApiEntityFilterHelperNode.oJ47DThH2BKB7gkxDqmH((object) entityMetadata) == EntityMetadataType.InterfaceExtension)
            {
              num = 5;
              continue;
            }
            goto case 1;
          case 4:
            goto label_6;
          case 5:
            entityMetadata = (EntityMetadata) ((PublicApiCodeGenerator) PublicApiEntityFilterHelperNode.b3wmh0hHegOOPeaegRoC()).GetMetadata(entityMetadata.BaseClassUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 0;
            continue;
        }
        this.EntityMetadata = entityMetadata;
        num = 4;
      }
label_6:;
    }

    public string ParentPath => (string) PublicApiEntityFilterHelperNode.gTAEaZhH1X3NsImWRHXf();

    string IPublicApiNode.Path => throw new NotImplementedException();

    public IEnumerable<ISyntaxNode> Generate(
      IDictionary<string, IEnumerable<IPublicApiNode>> tree)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<ISyntaxNode>) new PublicApiEntityFilterHelperNode.\u003CGenerate\u003Ed__11(-2)
      {
        \u003C\u003E4__this = this,
        \u003C\u003E3__tree = tree
      };
    }

    internal static bool CalculateType(
      PropertyMetadata prop,
      ref ISyntaxNode codeTypeReference,
      string @namespace,
      IDictionary<string, IEnumerable<IPublicApiNode>> tree = null,
      List<ISyntaxNode> additionalTypes = null,
      List<ISyntaxNode> members = null,
      List<ISyntaxNode> membersImpl = null,
      ISyntaxNode codeCast = null,
      ISyntaxNode returnType = null,
      ISyntaxNode returnTypeImpl = null,
      ISyntaxNode returnThis = null,
      ISyntaxNode[] addObsoleteAttributes = null,
      ISyntaxTrivia summaryComment = null,
      ISyntaxTrivia paramMethodSummary = null,
      ISyntaxTrivia paramComment = null)
    {
      ISyntaxNode[] syntaxNodeArray1;
      if (!PublicApiCodeGenerator.PublicApiNoImplementation)
        syntaxNodeArray1 = (ISyntaxNode[]) null;
      else
        syntaxNodeArray1 = new ISyntaxNode[1]
        {
          SyntaxGeneratorExtensions.ThrowNotImplementedStatement()
        };
      ISyntaxNode[] syntaxNodeArray2 = syntaxNodeArray1;
      string lowerFirstChar = prop.Name.ToLowerFirstChar();
      bool type = false;
      if (prop.Settings is EntitySettings settings8)
      {
        if (settings8.GenerateFilterInFilter)
        {
          ISyntaxNode syntaxNode1 = codeTypeReference.IsGeneric() ? codeTypeReference.GetGenericArguments().First<ISyntaxNode>() : codeTypeReference;
          string typeName = syntaxNode1.ToString() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87879583);
          codeTypeReference = typeName.CreateTypeSyntax();
          if (members != null)
          {
            string str = typeName.Substring(typeName.LastIndexOf('.') + 1) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61255023);
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            if (tree != null && !tree[PublicApiFilterHelpers.Path].OfType<PublicApiEntityFilterHelperNode>().Any<PublicApiEntityFilterHelperNode>((Func<PublicApiEntityFilterHelperNode, bool>) (n => PublicApiEntityFilterHelperNode.\u003C\u003Ec__DisplayClass12_0.W4MLGLvNbZMKuV9Bwsid(n.EntityMetadata.ImplementationUid, PublicApiEntityFilterHelperNode.\u003C\u003Ec__DisplayClass12_0.HvXyWlvNo9F3EVWSB7C5((object) prop)))) && PublicApiCodeGenerator.Current.AddIfNotExists(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309838036) + str))
            {
              EntityMetadata metadata = (EntityMetadata) PublicApiCodeGenerator.Current.GetMetadata(prop.SubTypeUid);
              ISyntaxNode propertyTypeReference = ((ITypeGenerationInfo) MetadataServiceContext.Service.GetIdTypeDescriptor(metadata.IdTypeUid)).GetPropertyTypeReference((ClassMetadata) metadata, (PropertyMetadata) null, false);
              additionalTypes.Add(str.ClassDeclaration(Accessibility.Public, baseType: z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921007765).CreateTypeSyntax(syntaxNode1, propertyTypeReference, codeTypeReference, str.CreateTypeSyntax())).MakeClassHide());
            }
            ISyntaxNode typeSyntax1 = str.CreateTypeSyntax(false);
            ISyntaxNode typeSyntax2 = TypeOf.Func2.Raw.CreateTypeSyntax(typeSyntax1, typeSyntax1);
            List<ISyntaxNode> syntaxNodeList = members;
            string name = prop.Name;
            ISyntaxNode[] parameters = new ISyntaxNode[1]
            {
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272404901).ParameterDeclaration(typeSyntax2)
            };
            ISyntaxNode returnType1 = returnType;
            ISyntaxNode[] statements = syntaxNodeArray2;
            if (statements == null)
              statements = new ISyntaxNode[3]
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921007825).LocalDeclarationStatement(typeSyntax1.ObjectCreationExpression()),
                codeCast.AssignmentStatement(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1011892271).IdentifierName().InvocationExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978521625).IdentifierName()).MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334976717))),
                returnThis.ReturnStatement()
              };
            ISyntaxNode syntaxNode2 = name.MethodDeclaration((IEnumerable<ISyntaxNode>) parameters, returnType: returnType1, accessibility: Accessibility.Public, statements: (IEnumerable<ISyntaxNode>) statements).XmlComments(summaryComment, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978553862), (object) EleWise.ELMA.SR.T(prop.DisplayName)).SplittedComment());
            syntaxNodeList.Add(syntaxNode2);
            membersImpl.Add(prop.Name.MethodDeclaration((IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
            {
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405632155).ParameterDeclaration(typeSyntax2)
            }, returnType: returnTypeImpl, accessibility: Accessibility.Public, modifiers: DeclarationModifiers.New, statements: (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
            {
              SyntaxGeneratorExtensions.Base.MemberAccessExpression(prop.Name).InvocationExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461574473).IdentifierName()).ReturnStatement()
            }).XmlComments(summaryComment, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87544449), (object) EleWise.ELMA.SR.T(prop.DisplayName)).SplittedComment()));
          }
        }
        else if (settings8.RelationType != RelationType.OneToOne)
        {
          type = true;
          codeTypeReference = codeTypeReference.GetGenericArguments().First<ISyntaxNode>().CreateArrayTypeSyntax();
        }
        else if (settings8.GenerateListInFilter)
        {
          type = true;
          codeTypeReference = codeTypeReference.CreateArrayTypeSyntax();
        }
      }
      else if ((prop.Settings is DateTimeSettings settings7 ? (settings7.RelativeInFilter ? 1 : 0) : 0) != 0 && prop is EntityPropertyMetadata)
        codeTypeReference = TypeOf<RelativeDateTime>.Raw.CreateTypeSyntax();
      else if ((prop.Settings is DateTimeSettings settings6 ? (settings6.RangeInFilter ? 1 : 0) : 0) != 0 && prop is EntityPropertyMetadata)
        codeTypeReference = TypeOf<DateTimeRange>.Raw.CreateTypeSyntax();
      else if ((prop.Settings is Int64Settings settings5 ? (settings5.RangeInFilter ? 1 : 0) : 0) != 0 && prop is EntityPropertyMetadata)
        codeTypeReference = TypeOf<Int64Range>.Raw.CreateTypeSyntax();
      else if ((prop.Settings is Int32Settings settings4 ? (settings4.RangeInFilter ? 1 : 0) : 0) != 0 && prop is EntityPropertyMetadata)
        codeTypeReference = TypeOf<Int32Range>.Raw.CreateTypeSyntax();
      else if ((prop.Settings is Int16Settings settings3 ? (settings3.RangeInFilter ? 1 : 0) : 0) != 0 && prop is EntityPropertyMetadata)
        codeTypeReference = TypeOf<Int16Range>.Raw.CreateTypeSyntax();
      else if ((prop.Settings is DoubleSettings settings2 ? (settings2.RangeInFilter ? 1 : 0) : 0) != 0)
        codeTypeReference = TypeOf<DoubleRange>.Raw.CreateTypeSyntax();
      else if ((prop.Settings is MoneySettings settings1 ? (settings1.RangeInFilter ? 1 : 0) : 0) != 0)
        codeTypeReference = TypeOf<MoneyRange>.Raw.CreateTypeSyntax();
      else if (prop.Settings is ListOfSimpleTypeSettings)
      {
        if (members != null)
        {
          ISyntaxNode elementType = codeTypeReference.GetGenericArguments().First<ISyntaxNode>();
          List<ISyntaxNode> syntaxNodeList = members;
          string name = prop.Name;
          ISyntaxNode[] parameters = new ISyntaxNode[1]
          {
            lowerFirstChar.ParameterDeclaration(elementType.CreateArrayTypeSyntax()).WithParamsModifier()
          };
          ISyntaxNode returnType2 = returnType;
          ISyntaxNode[] statements = syntaxNodeArray2;
          if (statements == null)
            statements = new ISyntaxNode[3]
            {
              codeCast.ValueEqualsExpression(SyntaxGeneratorExtensions.Null).IfStatement((IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
              {
                codeCast.AssignmentStatement(TypeOf.List.Raw.CreateTypeSyntax(elementType).ObjectCreationExpression())
              }),
              codeCast.MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106429878)).InvocationExpression(lowerFirstChar.IdentifierName()),
              returnThis.ReturnStatement()
            };
          ISyntaxNode syntaxNode = name.MethodDeclaration((IEnumerable<ISyntaxNode>) parameters, returnType: returnType2, accessibility: Accessibility.Public, statements: (IEnumerable<ISyntaxNode>) statements).AddAttributes(addObsoleteAttributes).XmlComments(summaryComment, paramMethodSummary, paramComment);
          syntaxNodeList.Add(syntaxNode);
          membersImpl.Add(prop.Name.MethodDeclaration((IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
          {
            lowerFirstChar.ParameterDeclaration(elementType.CreateArrayTypeSyntax()).WithParamsModifier()
          }, returnType: returnTypeImpl, accessibility: Accessibility.Public, modifiers: DeclarationModifiers.New, statements: (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
          {
            SyntaxGeneratorExtensions.Base.MemberAccessExpression(prop.Name).InvocationExpression(lowerFirstChar.IdentifierName()).ReturnStatement()
          }).AddAttributes(addObsoleteAttributes).XmlComments(summaryComment, paramMethodSummary, paramComment));
        }
      }
      else if (prop.Settings is AnyTypeSettings)
      {
        ISyntaxNode typeSyntax = ((AnyTypeSettings) prop.Settings).FullTypeName.CreateTypeSyntax();
        if (typeSyntax.GetGenericIdentifier() == z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767784359) || typeSyntax.GetGenericIdentifier() == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539321259))
        {
          ISyntaxNode elementType = typeSyntax.GetGenericArguments().First<ISyntaxNode>();
          string str = elementType.ToString();
          ref ISyntaxNode local = ref codeTypeReference;
          ISyntaxNode syntaxNode3;
          if (!(str == z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538598880)) && !str.ToString().Contains<char>('.'))
            syntaxNode3 = TypeOf.List.Raw.CreateTypeSyntax((@namespace + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138961604) + str).CreateTypeSyntax());
          else
            syntaxNode3 = typeSyntax;
          local = syntaxNode3;
          if (members != null)
          {
            List<ISyntaxNode> syntaxNodeList = members;
            string name = prop.Name;
            ISyntaxNode[] parameters = new ISyntaxNode[1]
            {
              lowerFirstChar.ParameterDeclaration(str == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740544542) || str.ToString().Contains<char>('.') ? elementType.CreateArrayTypeSyntax() : (@namespace + z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408899594) + str).CreateTypeSyntax().CreateArrayTypeSyntax()).WithParamsModifier()
            };
            ISyntaxNode returnType3 = returnType;
            ISyntaxNode[] statements = syntaxNodeArray2;
            if (statements == null)
              statements = new ISyntaxNode[3]
              {
                codeCast.ValueEqualsExpression(SyntaxGeneratorExtensions.Null).IfStatement((IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
                {
                  codeCast.AssignmentStatement(codeTypeReference.ObjectCreationExpression())
                }),
                codeCast.MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87544327)).InvocationExpression(lowerFirstChar.IdentifierName()),
                returnThis.ReturnStatement()
              };
            ISyntaxNode syntaxNode4 = name.MethodDeclaration((IEnumerable<ISyntaxNode>) parameters, returnType: returnType3, accessibility: Accessibility.Public, statements: (IEnumerable<ISyntaxNode>) statements).AddAttributes(addObsoleteAttributes).XmlComments(summaryComment, paramMethodSummary, paramComment);
            syntaxNodeList.Add(syntaxNode4);
            membersImpl.Add(prop.Name.MethodDeclaration((IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
            {
              lowerFirstChar.ParameterDeclaration(str == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1786954626) || str.ToString().Contains<char>('.') ? elementType.CreateArrayTypeSyntax() : (@namespace + z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521271676) + str).CreateTypeSyntax().CreateArrayTypeSyntax()).WithParamsModifier()
            }, returnType: returnTypeImpl, accessibility: Accessibility.Public, modifiers: DeclarationModifiers.New, statements: (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
            {
              SyntaxGeneratorExtensions.Base.MemberAccessExpression(prop.Name).InvocationExpression(lowerFirstChar.IdentifierName()).ReturnStatement()
            }).AddAttributes(addObsoleteAttributes).XmlComments(summaryComment, paramMethodSummary, paramComment));
          }
        }
      }
      return type;
    }

    /// <summary>Установить фалг дельта-сборки</summary>
    internal void SetIsDelta()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.isDelta = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void h4aOT9hHXSUdH3DT4uBq() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Qj8nibhHT94YudPeiXcC() => PublicApiCodeGenerator.PublicApiNoImplementation;

    internal static object jJU7IXhHkCUGBGUgj9by() => (object) SyntaxGeneratorExtensions.ThrowNotImplementedStatement();

    internal static object ddhRLChHnTebe2B1ojB0(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object MIpegbhHOk23RWDvMWWw([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static EntityMetadataType oJ47DThH2BKB7gkxDqmH([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static object b3wmh0hHegOOPeaegRoC() => (object) PublicApiCodeGenerator.Current;

    internal static Guid KBuBOYhHPEieZ92T7dCw([In] object obj0) => ((EntityMetadata) obj0).ImplementationUid;

    internal static bool NMLmjahHqm2gFYhvD9bG() => PublicApiEntityFilterHelperNode.w0I4EihHR8nxvbeLwURn == null;

    internal static PublicApiEntityFilterHelperNode Ah7Z9phHK89r8V4yDAvk() => PublicApiEntityFilterHelperNode.w0I4EihHR8nxvbeLwURn;

    internal static object gTAEaZhH1X3NsImWRHXf() => (object) PublicApiFilterHelpers.Path;
  }
}
