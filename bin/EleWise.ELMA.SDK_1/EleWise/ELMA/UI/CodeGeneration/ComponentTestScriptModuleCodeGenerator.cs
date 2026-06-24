// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.CodeGeneration.ComponentTestScriptModuleCodeGenerator
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
  /// Генерация кода для тестового модуля сценариев компонентов
  /// </summary>
  internal sealed class ComponentTestScriptModuleCodeGenerator : ScriptModuleCodeGenerator
  {
    private ComponentMetadata componentMetadata;
    internal static ComponentTestScriptModuleCodeGenerator c7EpN9BIeyD5eeKIT77Z;

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
            ComponentTestScriptModuleCodeGenerator.MOr6AZBIp1JnnV8blank(metadata is ComponentMetadata, ComponentTestScriptModuleCodeGenerator.aYIonjBINBqjJo9n568i(-787452571 ^ -787389627));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
            continue;
          case 3:
            ComponentTestScriptModuleCodeGenerator.VQqwbqBI3c7DbIwoIiyg((object) metadata, ComponentTestScriptModuleCodeGenerator.aYIonjBINBqjJo9n568i(654297945 ^ 654279271));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 2;
            continue;
          default:
            this.componentMetadata = (ComponentMetadata) metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetNamespaces() => (IEnumerable<ISyntaxNode>) new ISyntaxNode[13]
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105133636).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825454440).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647975276).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675440791).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426159563).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767655735).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889526992).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138891248).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106587174).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921132641).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088365760).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542660271).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272563139).NamespaceImportDeclaration()
    };

    /// <inheritdoc />
    protected override string GetNamespace() => this.componentMetadata.Namespace;

    /// <inheritdoc />
    protected override string GetClassName() => (string) ComponentTestScriptModuleCodeGenerator.psqJm7BIa13AQoNoKA51((object) this.componentMetadata);

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
            type.XmlComments(SR.T((string) ComponentTestScriptModuleCodeGenerator.aYIonjBINBqjJo9n568i(694673736 ^ -23604109 ^ -672061483)).SummaryComment(), ((string) ComponentTestScriptModuleCodeGenerator.aYIonjBINBqjJo9n568i(1251470110 >> 2 ^ 312797243)).ExampleComment());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
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
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112642428).ClassDeclaration(modifiers: DeclarationModifiers.Partial)
    };

    public ComponentTestScriptModuleCodeGenerator()
    {
      ComponentTestScriptModuleCodeGenerator.pXLcjfBIDShPEbQObDmO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object aYIonjBINBqjJo9n568i(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void VQqwbqBI3c7DbIwoIiyg([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void MOr6AZBIp1JnnV8blank(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static bool ghRQBeBIPWXYI6loWpZ4() => ComponentTestScriptModuleCodeGenerator.c7EpN9BIeyD5eeKIT77Z == null;

    internal static ComponentTestScriptModuleCodeGenerator cOFTxwBI1IcSxlx9w80y() => ComponentTestScriptModuleCodeGenerator.c7EpN9BIeyD5eeKIT77Z;

    internal static object psqJm7BIa13AQoNoKA51([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static void pXLcjfBIDShPEbQObDmO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
