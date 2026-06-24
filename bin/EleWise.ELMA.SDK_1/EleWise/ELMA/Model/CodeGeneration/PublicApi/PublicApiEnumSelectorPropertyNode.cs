// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApi.PublicApiEnumSelectorPropertyNode
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.API;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi
{
  public class PublicApiEnumSelectorPropertyNode : PublicApiPropertyClassNode
  {
    private static PublicApiEnumSelectorPropertyNode h2XXubhHwTHqFshfD2gb;

    public PublicApiEnumSelectorPropertyNode(
      string parent,
      [NotNull] EnumMetadata enumMetadata,
      bool register = true)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(parent, (string) PublicApiEnumSelectorPropertyNode.KeRoyPhH7J88aSfL5xbE(PublicApiEnumSelectorPropertyNode.lfnIGKhHHfYZNppjWvD3((object) enumMetadata), PublicApiEnumSelectorPropertyNode.NpebauhHA5tXTxnPXbLI(1581325282 << 3 ^ -234117688)), (string) PublicApiEnumSelectorPropertyNode.lfnIGKhHHfYZNppjWvD3((object) enumMetadata), enumMetadata.FullTypeName, false, register);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_6;
          case 1:
            if (enumMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 3 : 3;
              continue;
            }
            goto label_7;
          case 2:
            goto label_7;
          case 3:
            this.EnumMetadata = enumMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_6:
      return;
label_3:
      return;
label_7:
      throw new ArgumentNullException((string) PublicApiEnumSelectorPropertyNode.NpebauhHA5tXTxnPXbLI(1304605005 ^ 1304546233));
    }

    public override string Description => this.EnumMetadata.Description;

    /// <summary>Метаданные</summary>
    [NotNull]
    internal EnumMetadata EnumMetadata { get; }

    protected override ISyntaxNode PropertyResultClass(
      IDictionary<string, IEnumerable<IPublicApiNode>> tree)
    {
      return this.ClassName.ClassDeclaration(Accessibility.Public, members: this.Members()).XmlComments(EleWise.ELMA.SR.T(this.EnumMetadata.DisplayName).SummaryComment()).MakeClassHide();
    }

    protected virtual IEnumerable<ISyntaxNode> Members() => (IEnumerable<ISyntaxNode>) new PublicApiEnumSelectorPropertyNode.\u003CMembers\u003Ed__7(-2)
    {
      \u003C\u003E4__this = this
    };

    internal static object lfnIGKhHHfYZNppjWvD3([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object NpebauhHA5tXTxnPXbLI(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object KeRoyPhH7J88aSfL5xbE([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool cR0rUKhH4BIx0AKtKWTK() => PublicApiEnumSelectorPropertyNode.h2XXubhHwTHqFshfD2gb == null;

    internal static PublicApiEnumSelectorPropertyNode D33LsyhH6geKH73ZffyQ() => PublicApiEnumSelectorPropertyNode.h2XXubhHwTHqFshfD2gb;
  }
}
