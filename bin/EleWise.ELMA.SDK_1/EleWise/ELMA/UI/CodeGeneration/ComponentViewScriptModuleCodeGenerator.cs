// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.CodeGeneration.ComponentViewScriptModuleCodeGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.CodeGeneration
{
  /// <summary>
  /// Генерация кода для клиентского модуля сценариев компонентов
  /// </summary>
  internal sealed class ComponentViewScriptModuleCodeGenerator : ScriptModuleCodeGenerator
  {
    private ComponentMetadata componentMetadata;
    internal static ComponentViewScriptModuleCodeGenerator bttae2Bup6MEbQcWoHwj;

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
            ComponentViewScriptModuleCodeGenerator.qe0OElBu45WbIVj0KPvu(metadata is ComponentMetadata, ComponentViewScriptModuleCodeGenerator.F2LyP9ButCkJBmX8Jdrm(-1290212282 ^ -644262414 ^ 1786820500));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
            continue;
          case 3:
            ComponentViewScriptModuleCodeGenerator.fkcJybBuw22BgAHdhIqb((object) metadata, ComponentViewScriptModuleCodeGenerator.F2LyP9ButCkJBmX8Jdrm(-35995181 ^ -36009747));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 2;
            continue;
          default:
            this.componentMetadata = (ComponentMetadata) metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetNamespaces() => (IEnumerable<ISyntaxNode>) new ISyntaxNode[14]
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306516730).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852900246).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867759382).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29322315).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121225467).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70072319).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541795141).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420808618).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787389747).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70106680).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345481766).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195675831).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35925685).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675444365).NamespaceImportDeclaration()
    };

    /// <inheritdoc />
    protected override string GetNamespace() => (string) ComponentViewScriptModuleCodeGenerator.M8RlsLBu6uspZMCbFJ0X((object) this.componentMetadata);

    /// <inheritdoc />
    protected override string GetClassName() => (string) ComponentViewScriptModuleCodeGenerator.PdCLnlBuHHhWZIgmyfHj((object) this.componentMetadata);

    /// <inheritdoc />
    protected override void WriteComments(ISyntaxNode type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            type.XmlComments(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521204416), ComponentViewScriptModuleCodeGenerator.QZpSLCBuAmDDeUKkypRd((object) this.componentMetadata)).SummaryComment());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
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
    protected override IEnumerable<ISyntaxNode> GetMembers() => (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740408172).ClassDeclaration(modifiers: DeclarationModifiers.Partial, members: (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        this.OverrideMethodRender()
      })
    };

    private ISyntaxNode OverrideMethodRender() => ((string) ComponentViewScriptModuleCodeGenerator.F2LyP9ButCkJBmX8Jdrm(-2099751081 ^ -2099689981)).MethodDeclaration(returnType: z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281903652).CreateTypeSyntax(), accessibility: Accessibility.Public, modifiers: DeclarationModifiers.Override, statements: (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
    {
      (ISyntaxNode) ComponentViewScriptModuleCodeGenerator.yguXmuBu7cw20xoHgUJt((object) ((object) null).CreateSyntaxNode())
    });

    public ComponentViewScriptModuleCodeGenerator()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object F2LyP9ButCkJBmX8Jdrm(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void fkcJybBuw22BgAHdhIqb([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void qe0OElBu45WbIVj0KPvu(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static bool BpZZpZBuaIhFKSy8NmfJ() => ComponentViewScriptModuleCodeGenerator.bttae2Bup6MEbQcWoHwj == null;

    internal static ComponentViewScriptModuleCodeGenerator k0WMZHBuDPk8ZeWwEIAh() => ComponentViewScriptModuleCodeGenerator.bttae2Bup6MEbQcWoHwj;

    internal static object M8RlsLBu6uspZMCbFJ0X([In] object obj0) => (object) ((ComponentMetadata) obj0).Namespace;

    internal static object PdCLnlBuHHhWZIgmyfHj([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object QZpSLCBuAmDDeUKkypRd([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static object yguXmuBu7cw20xoHgUJt([In] object obj0) => (object) ((ISyntaxNode) obj0).ReturnStatement();
  }
}
