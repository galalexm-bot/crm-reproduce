// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApi.PublicApiCustomBuilderMethodNode
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.API;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi
{
  public class PublicApiCustomBuilderMethodNode : IPublicApiNode
  {
    private readonly string methodName;
    private readonly string @namespace;
    private readonly string className;
    private readonly string summaryComment;
    private readonly List<(string Name, Type Type, string Description)> parameters;
    private string obsoleteMessage;
    private bool obsoleteError;
    private static PublicApiCustomBuilderMethodNode C1XgFQhHWwacXUYmiAn8;

    public PublicApiCustomBuilderMethodNode(
      string parentPath,
      string methodName,
      string @namespace,
      string className,
      string summaryComment)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.summaryComment = summaryComment;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
            continue;
          case 3:
            this.ParentPath = parentPath;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 3 : 4;
            continue;
          case 4:
            this.methodName = methodName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 6 : 1;
            continue;
          case 5:
            this.className = className;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 2;
            continue;
          case 6:
            this.@namespace = @namespace;
            num = 5;
            continue;
          default:
            this.parameters = new List<(string, Type, string)>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    public string ParentPath
    {
      get => this.\u003CParentPath\u003Ek__BackingField;
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
              this.\u003CParentPath\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
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

    public string Path => this.@namespace + z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87864935) + this.className;

    public string Namespace => (string) PublicApiCustomBuilderMethodNode.yqxlP9hHhxRUehZRTs84(-2099751081 ^ -2099568147) + this.@namespace;

    IEnumerable<ISyntaxNode> IPublicApiNode.Generate(
      IDictionary<string, IEnumerable<IPublicApiNode>> tree)
    {
      return (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        this.PublicApiNodeGenerate()
      };
    }

    public ISyntaxNode Generate(
      IDictionary<string, IEnumerable<IPublicApiNode>> tree)
    {
      if (!PublicApiCodeGenerator.Current.AddIfNotExists(this.Namespace + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921196793) + this.className))
        return (ISyntaxNode) null;
      PublicApiCustomBuilderNode[] builderNodes = tree[this.Path].OfType<PublicApiCustomBuilderNode>().ToArray<PublicApiCustomBuilderNode>();
      if (builderNodes.Length == 0)
        return (ISyntaxNode) null;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      Func<int, string> builderField = builderNodes.Length > 1 ? (Func<int, string>) (i => (string) PublicApiCustomBuilderMethodNode.\u003C\u003Ec.fVx9DhvPiRwDUgtpBkFp(PublicApiCustomBuilderMethodNode.\u003C\u003Ec.LndUt8vPSjmrHOdniwHK(--1867379187 ^ 1867034755), (object) i)) : (Func<int, string>) (i => (string) PublicApiCustomBuilderMethodNode.\u003C\u003Ec.LndUt8vPSjmrHOdniwHK(1669371371 ^ 1669715099));
      Func<Type, string, MethodInfo, ISyntaxNode> method = (Func<Type, string, MethodInfo, ISyntaxNode>) ((builderType, field, methodInfo) =>
      {
        int num1 = 8;
        List<ISyntaxNode> syntaxNodeList;
        while (true)
        {
          int num2 = num1;
          ISyntaxNode syntaxNode;
          while (true)
          {
            switch (num2)
            {
              case 1:
              case 3:
              case 5:
              case 11:
                goto label_17;
              case 2:
                syntaxNodeList.Add(syntaxNode);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
                continue;
              case 4:
                // ISSUE: reference to a compiler-generated method
                if (!PublicApiCustomBuilderMethodNode.\u003C\u003Ec.wAtpZQvPTjfb0OkeeekV())
                {
                  num2 = 13;
                  continue;
                }
                goto case 10;
              case 6:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                syntaxNodeList.Add((ISyntaxNode) PublicApiCustomBuilderMethodNode.\u003C\u003Ec.OeBd3ovP2XTIJTWYv4Sx(PublicApiCustomBuilderMethodNode.\u003C\u003Ec.Wi2Ub5vPRwI9TqB3pc6H()));
                num2 = 5;
                continue;
              case 7:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                syntaxNode = ((ISyntaxNode) PublicApiCustomBuilderMethodNode.\u003C\u003Ec.k69gsQvPXc9eAiyaIKdn(PublicApiCustomBuilderMethodNode.\u003C\u003Ec.dpS9M1vPqwa9es0XbNeO(PublicApiCustomBuilderMethodNode.\u003C\u003Ec.Wi2Ub5vPRwI9TqB3pc6H(), (object) field.IdentifierName()), PublicApiCustomBuilderMethodNode.\u003C\u003Ec.WAcoZBvPKLgqVTguYsyu((object) methodInfo))).InvocationExpression(((IEnumerable<ParameterInfo>) methodInfo.GetParameters()).Select<ParameterInfo, ISyntaxNode>((Func<ParameterInfo, ISyntaxNode>) (p => (ISyntaxNode) PublicApiCustomBuilderMethodNode.\u003C\u003Ec.z8UhOevP4cjVRsR76TLF(PublicApiCustomBuilderMethodNode.\u003C\u003Ec.XS3xvvvPtkR6jbKsG1Nx((object) p), PublicApiCustomBuilderMethodNode.\u003C\u003Ec.rDkG0PvPw1UOj1ZEZ83a((object) p)))));
                num2 = 4;
                continue;
              case 8:
                syntaxNodeList = new List<ISyntaxNode>();
                num2 = 7;
                continue;
              case 9:
              case 14:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                syntaxNodeList.Add((ISyntaxNode) PublicApiCustomBuilderMethodNode.\u003C\u003Ec.OeBd3ovP2XTIJTWYv4Sx(PublicApiCustomBuilderMethodNode.\u003C\u003Ec.t7fwPgvPPY0vXZgFFECW((object) syntaxNode, (object) ((PublicApiCodeGenerator) PublicApiCustomBuilderMethodNode.\u003C\u003Ec.KlN3W5vPeEc28583tJwc()).GetCodeTypeReference(methodInfo.ReturnType))));
                num2 = 3;
                continue;
              case 10:
                // ISSUE: reference to a compiler-generated method
                syntaxNodeList.Add((ISyntaxNode) PublicApiCustomBuilderMethodNode.\u003C\u003Ec.DJFWCXvPkkT4BVoVkfeH());
                num2 = 11;
                continue;
              case 12:
              case 15:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (!PublicApiCustomBuilderMethodNode.\u003C\u003Ec.x797uZvPOj8inFWfDHTL(PublicApiCustomBuilderMethodNode.\u003C\u003Ec.JbAf6xvPntfEQFHDlCfj((object) methodInfo), builderType))
                {
                  num2 = 14;
                  continue;
                }
                goto label_9;
              case 16:
                goto label_9;
              default:
                // ISSUE: reference to a compiler-generated method
                if (!(PublicApiCustomBuilderMethodNode.\u003C\u003Ec.JbAf6xvPntfEQFHDlCfj((object) methodInfo) == TypeOf.Void.Raw))
                {
                  num2 = 15;
                  continue;
                }
                goto case 2;
            }
          }
label_9:
          syntaxNodeList.Add(syntaxNode);
          num1 = 6;
        }
label_17:
        string name = methodInfo.Name;
        ParameterInfo[] parameters1 = methodInfo.GetParameters();
        // ISSUE: reference to a compiler-generated field
        Func<ParameterInfo, ISyntaxNode> func = PublicApiCustomBuilderMethodNode.\u003C\u003Ec.\u003C\u003E9__18_7;
        Func<ParameterInfo, ISyntaxNode> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          PublicApiCustomBuilderMethodNode.\u003C\u003Ec.\u003C\u003E9__18_7 = selector = (Func<ParameterInfo, ISyntaxNode>) (p =>
          {
            int num3 = 1;
            while (true)
            {
              switch (num3)
              {
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  if (!PublicApiCustomBuilderMethodNode.\u003C\u003Ec.ARwiOevP6PC79qwlvDaG((object) p, TypeOf<ParamArrayAttribute>.Raw))
                  {
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
                    continue;
                  }
                  goto label_5;
                default:
                  goto label_4;
              }
            }
label_4:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return p.Name.ParameterDeclaration((ISyntaxNode) PublicApiCustomBuilderMethodNode.\u003C\u003Ec.dBagV8vPAxpjdX6fK9e1(PublicApiCustomBuilderMethodNode.\u003C\u003Ec.o2sIj4vPHIevH4vg0sUr((object) p)));
label_5:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return (ISyntaxNode) PublicApiCustomBuilderMethodNode.\u003C\u003Ec.LM29w6vPxiitqoSZENa6((object) ((string) PublicApiCustomBuilderMethodNode.\u003C\u003Ec.DxW7CuvP7CwmRi5qtVpn((object) p)).ParameterDeclaration(PublicApiCodeGenerator.Current.GetCodeTypeReference(p.ParameterType)));
          });
        }
        else
          goto label_3;
label_19:
        IEnumerable<ISyntaxNode> parameters2 = ((IEnumerable<ParameterInfo>) parameters1).Select<ParameterInfo, ISyntaxNode>(selector);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        IEnumerable<string> typeParameters = !PublicApiCustomBuilderMethodNode.\u003C\u003Ec.uPM0TvvP1Okr2m87NWQE((object) methodInfo) ? (IEnumerable<string>) null : ((IEnumerable<Type>) PublicApiCustomBuilderMethodNode.\u003C\u003Ec.GUOfXUvPNU5Cd9KwAUNj((object) methodInfo)).Select<Type, string>((Func<Type, string>) (t => (string) PublicApiCustomBuilderMethodNode.\u003C\u003Ec.WAcoZBvPKLgqVTguYsyu((object) t)));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        object returnType = (string) PublicApiCustomBuilderMethodNode.\u003C\u003Ec.WAcoZBvPKLgqVTguYsyu((object) PublicApiCustomBuilderMethodNode.\u003C\u003Ec.JbAf6xvPntfEQFHDlCfj((object) methodInfo)) == builderType.Name ? PublicApiCustomBuilderMethodNode.\u003C\u003Ec.q3YtTOvPDKBa7f5pAO4V(PublicApiCustomBuilderMethodNode.\u003C\u003Ec.zdt2e0vPa101tJTCMDqw(PublicApiCustomBuilderMethodNode.\u003C\u003Ec.WAcoZBvPKLgqVTguYsyu((object) builderType), PublicApiCustomBuilderMethodNode.\u003C\u003Ec.LndUt8vPSjmrHOdniwHK(-1886646897 ^ -1886795567))) : (PublicApiCustomBuilderMethodNode.\u003C\u003Ec.OPkvD6vPpJVkPqjBrooJ(PublicApiCustomBuilderMethodNode.\u003C\u003Ec.JbAf6xvPntfEQFHDlCfj((object) methodInfo), PublicApiCustomBuilderMethodNode.\u003C\u003Ec.Td9YPnvP3CldY30k2na5((object) TypeOf.Void)) ? (object) ((PublicApiCodeGenerator) PublicApiCustomBuilderMethodNode.\u003C\u003Ec.KlN3W5vPeEc28583tJwc()).GetCodeTypeReference(PublicApiCustomBuilderMethodNode.\u003C\u003Ec.JbAf6xvPntfEQFHDlCfj((object) methodInfo)) : (object) null);
        List<ISyntaxNode> statements = syntaxNodeList;
        return name.MethodDeclaration(parameters2, typeParameters, (ISyntaxNode) returnType, Accessibility.Public, statements: (IEnumerable<ISyntaxNode>) statements).XmlComments(methodInfo.GetFullCommentsTrivia());
label_3:
        selector = func;
        goto label_19;
      });
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.className.ClassDeclaration(Accessibility.Public, members: ((IEnumerable<PublicApiCustomBuilderNode>) builderNodes).Select<PublicApiCustomBuilderNode, ISyntaxNode>((Func<PublicApiCustomBuilderNode, int, ISyntaxNode>) ((builderNode, i) => builderField(i).FieldDeclaration((ISyntaxNode) PublicApiCustomBuilderMethodNode.\u003C\u003Ec__DisplayClass18_0.HpaIvIveU3mbiK0uF0ve(builderNode.BuilderType), Accessibility.Private))).Concat<ISyntaxNode>(((IEnumerable<ConstructorInfo>) ((IEnumerable<PublicApiCustomBuilderNode>) builderNodes).First<PublicApiCustomBuilderNode>().BuilderType.GetConstructors(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public)).Select<ConstructorInfo, ISyntaxNode>((Func<ConstructorInfo, ISyntaxNode>) (ctor =>
      {
        int num = 2;
        IEnumerable<ISyntaxNode> statements;
        IEnumerable<(string, Type)> parameters;
        while (true)
        {
          IEnumerable<ISyntaxNode> syntaxNodes1;
          IEnumerable<ISyntaxNode> syntaxNodes2;
          // ISSUE: variable of a compiler-generated type
          PublicApiCustomBuilderMethodNode.\u003C\u003Ec__DisplayClass18_0 cDisplayClass180;
          switch (num)
          {
            case 1:
              cDisplayClass180 = this;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 5 : 1;
              continue;
            case 2:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 1;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated method
              if (PublicApiCustomBuilderMethodNode.\u003C\u003Ec__DisplayClass18_0.QhGPPTvesO3btGJwx0F9())
              {
                num = 7;
                continue;
              }
              goto default;
            case 4:
              goto label_13;
            case 5:
              ParameterInfo[] parameters3 = ctor.GetParameters();
              // ISSUE: reference to a compiler-generated field
              Func<ParameterInfo, (string, Type)> func = PublicApiCustomBuilderMethodNode.\u003C\u003Ec.\u003C\u003E9__18_9;
              Func<ParameterInfo, (string, Type)> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                PublicApiCustomBuilderMethodNode.\u003C\u003Ec.\u003C\u003E9__18_9 = selector = (Func<ParameterInfo, (string, Type)>) (p => (p.Name, p.ParameterType));
              }
              else
                goto label_14;
label_9:
              parameters = ((IEnumerable<ParameterInfo>) parameters3).Select<ParameterInfo, (string, Type)>(selector);
              num = 3;
              continue;
label_14:
              selector = func;
              goto label_9;
            case 6:
              syntaxNodes2 = syntaxNodes1;
              break;
            case 7:
              syntaxNodes1 = (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
              {
                SyntaxGeneratorExtensions.ThrowNotImplementedStatement()
              };
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 6 : 1;
              continue;
            default:
              syntaxNodes2 = ((IEnumerable<PublicApiCustomBuilderNode>) builderNodes).Aggregate<PublicApiCustomBuilderNode, List<(Type, ISyntaxNode)>>(new List<(Type, ISyntaxNode)>(), (Func<List<(Type, ISyntaxNode)>, PublicApiCustomBuilderNode, List<(Type, ISyntaxNode)>>) ((l, builderNode) =>
              {
                ISyntaxNode builderExpression = builderNode.CreateBuilderExpression(parameters, l.Select<(Type, ISyntaxNode), Type>((Func<(Type, ISyntaxNode), Type>) (i => i.BuilderType)), (Func<Type, ISyntaxNode>) (t =>
                {
                  int num = 1;
                  Type t2;
                  while (true)
                  {
                    switch (num)
                    {
                      case 1:
                        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
                        continue;
                      case 2:
                        goto label_3;
                      default:
                        t2 = t;
                        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 2 : 1;
                        continue;
                    }
                  }
label_3:
                  // ISSUE: reference to a compiler-generated field
                  return cDisplayClass180.builderField(l.FindIndex((Predicate<(Type, ISyntaxNode)>) (i => i.BuilderType == t2))).IdentifierName();
                }));
                // ISSUE: reference to a compiler-generated field
                l.Add((builderNode.BuilderType, SyntaxGeneratorExtensions.This.MemberAccessExpression(cDisplayClass180.builderField(l.Count).IdentifierName()).AssignmentStatement(builderExpression)));
                return l;
              })).Select<(Type, ISyntaxNode), ISyntaxNode>((Func<(Type, ISyntaxNode), ISyntaxNode>) (i => i.SyntaxNode));
              break;
          }
          statements = syntaxNodes2;
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 3 : 4;
        }
label_13:
        return SyntaxGeneratorExtensions.ConstructorDeclaration(parameters.Select<(string, Type), ISyntaxNode>((Func<(string, Type), ISyntaxNode>) (p => p.Name.ParameterDeclaration(PublicApiCodeGenerator.Current.GetCodeTypeReference(p.Type)))), Accessibility.Public, statements: statements).XmlComments(ctor.GetFullCommentsTrivia());
      }))).Concat<ISyntaxNode>(((IEnumerable<PublicApiCustomBuilderNode>) builderNodes).SelectMany<PublicApiCustomBuilderNode, ISyntaxNode>((Func<PublicApiCustomBuilderNode, int, IEnumerable<ISyntaxNode>>) ((builderNode, i) => ((IEnumerable<MethodInfo>) builderNode.BuilderType.GetMethods(BindingFlags.Instance | BindingFlags.Public)).Where<MethodInfo>((Func<MethodInfo, bool>) (methodInfo => PublicApiCustomBuilderMethodNode.\u003C\u003Ec.OPkvD6vPpJVkPqjBrooJ(PublicApiCustomBuilderMethodNode.\u003C\u003Ec.ci5dmivP088Xf2URInaS((object) methodInfo), TypeOf<object>.Raw))).Select<MethodInfo, ISyntaxNode>((Func<MethodInfo, ISyntaxNode>) (methodInfo => method(builderNode.BuilderType, builderField(i), methodInfo))))))).MakeClassHide();
    }

    public PublicApiCustomBuilderMethodNode Obsolete(string obsoleteMessage, bool obsoleteError = false)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.obsoleteMessage = obsoleteMessage;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.obsoleteError = obsoleteError;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 2;
            continue;
        }
      }
label_2:
      return this;
    }

    public PublicApiCustomBuilderMethodNode Parameter<T>(string name, string description)
    {
      this.parameters.Add((name, TypeOf<T>.Raw, description));
      return this;
    }

    /// <summary>
    /// Базовая логика генерации узла для реализации <see cref="T:EleWise.ELMA.Model.CodeGeneration.PublicApi.IPublicApiNode">IPublicApiNode</see>
    /// </summary>
    /// <returns>Узел синтаксического дерева</returns>
    protected virtual ISyntaxNode PublicApiNodeGenerate()
    {
      int num = 2;
      ISyntaxNode type;
      IEnumerable<ISyntaxNode> syntaxNodes;
      while (true)
      {
        ISyntaxNode[] syntaxNodeArray;
        switch (num)
        {
          case 1:
            if (!PublicApiCustomBuilderMethodNode.qEdAhQhHfDuxSxJlg12T())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
              continue;
            }
            syntaxNodeArray = new ISyntaxNode[1]
            {
              (ISyntaxNode) PublicApiCustomBuilderMethodNode.ebo6y1hHCFo8x0cslGa2()
            };
            break;
          case 2:
            type = (ISyntaxNode) PublicApiCustomBuilderMethodNode.fyBy3ahHEOSyrDiWgTvf(PublicApiCustomBuilderMethodNode.OySEqdhHGcg3PIEsYDpC((object) this.Namespace, PublicApiCustomBuilderMethodNode.yqxlP9hHhxRUehZRTs84(-2112703338 ^ -2112704942), (object) this.className));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_8;
          default:
            syntaxNodeArray = new ISyntaxNode[1]
            {
              (ISyntaxNode) PublicApiCustomBuilderMethodNode.uWFXPUhHQxTvkBpSwGOE((object) type.ObjectCreationExpression(this.parameters.Select<(string, Type, string), ISyntaxNode>((Func<(string, Type, string), ISyntaxNode>) (p => p.Name.IdentifierName()))))
            };
            break;
        }
        syntaxNodes = (IEnumerable<ISyntaxNode>) syntaxNodeArray;
        num = 3;
      }
label_8:
      string methodName = this.methodName;
      List<(string, Type, string)> parameters1 = this.parameters;
      // ISSUE: reference to a compiler-generated field
      Func<(string, Type, string), ISyntaxNode> func = PublicApiCustomBuilderMethodNode.\u003C\u003Ec.\u003C\u003E9__21_1;
      Func<(string, Type, string), ISyntaxNode> selector;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        PublicApiCustomBuilderMethodNode.\u003C\u003Ec.\u003C\u003E9__21_1 = selector = (Func<(string, Type, string), ISyntaxNode>) (p => p.Name.ParameterDeclaration(PublicApiCodeGenerator.Current.GetCodeTypeReference(p.Type)));
      }
      else
        goto label_11;
label_10:
      IEnumerable<ISyntaxNode> parameters2 = parameters1.Select<(string, Type, string), ISyntaxNode>(selector);
      ISyntaxNode returnType = type;
      IEnumerable<ISyntaxNode> statements = syntaxNodes;
      ISyntaxNode syntaxNode = methodName.MethodDeclaration(parameters2, returnType: returnType, accessibility: Accessibility.Public, modifiers: DeclarationModifiers.Virtual, statements: statements).If(this.obsoleteMessage != null, (Func<ISyntaxNode, ISyntaxNode>) (b => b.AddAttributes(SyntaxGeneratorExtensions.CreateAttribute<ObsoleteAttribute>((object) this.obsoleteMessage, (object) this.obsoleteError))));
      string summaryComment = this.summaryComment;
      IEnumerable<ISyntaxTrivia> documentationComments = summaryComment != null ? summaryComment.SummaryComment().Concat<ISyntaxTrivia>(this.parameters.Select<(string, Type, string), ISyntaxTrivia>((Func<(string, Type, string), ISyntaxTrivia>) (p =>
      {
        string str = p.Type.ParameterPath();
        return (z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979522814) + p.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123690208) + p.Description + (str != null ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317973032) : "") + str + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515133519)).SplittedComment();
      }))) : (IEnumerable<ISyntaxTrivia>) null;
      return syntaxNode.XmlComments(documentationComments);
label_11:
      selector = func;
      goto label_10;
    }

    internal static bool tAtaSehHoT4s0VBXseHC() => PublicApiCustomBuilderMethodNode.C1XgFQhHWwacXUYmiAn8 == null;

    internal static PublicApiCustomBuilderMethodNode XLWO18hHbX75ia3IEnG6() => PublicApiCustomBuilderMethodNode.C1XgFQhHWwacXUYmiAn8;

    internal static object yqxlP9hHhxRUehZRTs84(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object OySEqdhHGcg3PIEsYDpC([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object fyBy3ahHEOSyrDiWgTvf([In] object obj0) => (object) ((string) obj0).CreateTypeSyntax();

    internal static bool qEdAhQhHfDuxSxJlg12T() => PublicApiCodeGenerator.PublicApiNoImplementation;

    internal static object uWFXPUhHQxTvkBpSwGOE([In] object obj0) => (object) ((ISyntaxNode) obj0).ReturnStatement();

    internal static object ebo6y1hHCFo8x0cslGa2() => (object) SyntaxGeneratorExtensions.ThrowNotImplementedStatement();
  }
}
