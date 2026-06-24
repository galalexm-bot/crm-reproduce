// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApi.PublicApiCustomMethodsNodeProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi
{
  [Component(Order = 2147483647)]
  internal class PublicApiCustomMethodsNodeProvider : IPublicApiNodeProvider
  {
    private readonly IEntityManagerTypesStorage entityManagerTypesStorage;
    internal static PublicApiCustomMethodsNodeProvider C7fAJjhHvrcBxXfFvE1k;

    public PublicApiCustomMethodsNodeProvider(
      IEntityManagerTypesStorage entityManagerTypesStorage)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.entityManagerTypesStorage = entityManagerTypesStorage;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public IEnumerable<IPublicApiNode> CreatePublicApiNodes() => (IEnumerable<IPublicApiNode>) this.entityManagerTypesStorage.GetManagerTypes().SelectMany<Type, MethodInfo>((Func<Type, IEnumerable<MethodInfo>>) (t => (IEnumerable<MethodInfo>) t.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod))).Select(method => new \u003C\u003Ef__AnonymousType2<MethodInfo, string>(method, AttributeHelper<PublicApiNodeIdAttribute>.GetAttribute((MemberInfo) method, false)?.PublicApiNodeId)).Where(data => data.PublicApiNodeId != null && data.PublicApiNodeId != z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 153802685) && AttributeHelper<PublicApiMemberAttribute>.GetAttribute((MemberInfo) data.method, false) != null).Select(data => new PublicApiMethodInvokeNode(PublicApiCodeGenerator.Current.GetPropertyClassNodePath(data.PublicApiNodeId).Single<string>(), data.method, this.ManagerReferenceCode(data.method), Array.Empty<TypeArgument>())).ToArray<PublicApiMethodInvokeNode>();

    private ISyntaxNode ManagerReferenceCode(MethodInfo method) => ((ISyntaxNode) PublicApiCustomMethodsNodeProvider.ohZ2XwhHiheX9YswC3l2((object) PublicApiCustomMethodsNodeProvider.wMgUhqhHuuPB63XE0Pnq((object) EleWise.ELMA.SDK.TypeOf.Locator).CreateTypeSyntax(), (object) ((string) PublicApiCustomMethodsNodeProvider.AdPjJ9hHI3C31Y6oSNGq(-1638402543 ^ -1638629149)).GenericName((ISyntaxNode) PublicApiCustomMethodsNodeProvider.O1ULM1hHSohOIkTr3QSL(PublicApiCustomMethodsNodeProvider.Ex9DKnhHVekDovts2Zs5((object) method))))).InvocationExpression();

    internal static bool txNMH8hH8hoxV1JHHhMy() => PublicApiCustomMethodsNodeProvider.C7fAJjhHvrcBxXfFvE1k == null;

    internal static PublicApiCustomMethodsNodeProvider zesDsshHZexGeBkakvDK() => PublicApiCustomMethodsNodeProvider.C7fAJjhHvrcBxXfFvE1k;

    internal static Type wMgUhqhHuuPB63XE0Pnq([In] object obj0) => ((RipeType) obj0).Raw;

    internal static object AdPjJ9hHI3C31Y6oSNGq(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type Ex9DKnhHVekDovts2Zs5([In] object obj0) => ((MemberInfo) obj0).DeclaringType;

    internal static object O1ULM1hHSohOIkTr3QSL(Type type) => (object) type.CreateTypeSyntax();

    internal static object ohZ2XwhHiheX9YswC3l2([In] object obj0, [In] object obj1) => (object) ((ISyntaxNode) obj0).MemberAccessExpression((ISyntaxNode) obj1);
  }
}
