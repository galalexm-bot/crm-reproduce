// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApi.PublicApiPermissionsNode`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi
{
  public class PublicApiPermissionsNode<T> : IPublicApiNode, IPublicApiPermissionsNode where T : IPermissionProvider
  {
    internal static object ojunaNhAnw69JWdmElFq;

    public PublicApiPermissionsNode(string parentPath)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ParentPath = parentPath;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
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

    string IPublicApiNode.Path => throw new NotImplementedException();

    Type IPublicApiPermissionsNode.Type => TypeOf<T>.Raw;

    public IEnumerable<ISyntaxNode> Generate(
      IDictionary<string, IEnumerable<IPublicApiNode>> tree)
    {
      return !PublicApiCodeGenerator.Current.AddIfNotExists(this.ParentPath + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70206745)) ? Enumerable.Empty<ISyntaxNode>() : tree[this.ParentPath].OfType<IPublicApiPermissionsNode>().SelectMany<IPublicApiPermissionsNode, (Type, string, Permission, ObsoleteAttribute)>((Func<IPublicApiPermissionsNode, IEnumerable<(Type, string, Permission, ObsoleteAttribute)>>) (n => ((IEnumerable<FieldInfo>) n.Type.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.GetField)).Select<FieldInfo, (Type, string, Permission, ObsoleteAttribute)>((Func<FieldInfo, (Type, string, Permission, ObsoleteAttribute)>) (f => (n.Type, f.Name, f.GetValue((object) null) as Permission, AttributeHelper<ObsoleteAttribute>.GetAttribute((MemberInfo) f, false)))))).Where<(Type, string, Permission, ObsoleteAttribute)>((Func<(Type, string, Permission, ObsoleteAttribute), bool>) (d => d.Permission != (Permission) null)).Select<(Type, string, Permission, ObsoleteAttribute), ISyntaxNode>((Func<(Type, string, Permission, ObsoleteAttribute), ISyntaxNode>) (d => d.Name.PropertyDeclaration(TypeOf<Permission>.Raw.CreateTypeSyntax(), Accessibility.Public, getAccessorStatements: (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        d.Type.CreateTypeSyntax().MemberAccessExpression(d.Name).ReturnStatement()
      }).If(d.ObsoleteAttribute != null, (Func<ISyntaxNode, ISyntaxNode>) (p => p.AddAttributes(TypeOf<ObsoleteAttribute>.Raw.CreateAttribute((object) d.ObsoleteAttribute.Message, (object) d.ObsoleteAttribute.IsError), TypeOf<BrowsableAttribute>.Raw.CreateAttribute((object) false)))).XmlComments(EleWise.ELMA.SR.T(d.Permission.Name).SummaryComment())));
    }

    internal static bool GvL0GkhAORETU4YvIHdV() => PublicApiPermissionsNode<T>.ojunaNhAnw69JWdmElFq == null;

    internal static object fMwmO4hA2uvLe5KLDs5l() => PublicApiPermissionsNode<T>.ojunaNhAnw69JWdmElFq;
  }
}
