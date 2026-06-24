// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.CodeGeneration.ComponentClientScriptModuleCodeGenerator
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
  internal sealed class ComponentClientScriptModuleCodeGenerator : ScriptModuleCodeGenerator
  {
    private ComponentMetadata componentMetadata;
    internal static ComponentClientScriptModuleCodeGenerator X2LMrpBIoLdfPTiyCHx5;

    /// <inheritdoc />
    protected override void InitInternal(IMetadata metadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ComponentClientScriptModuleCodeGenerator.UjRCOdBIE8SuOEVW50vE((object) metadata, ComponentClientScriptModuleCodeGenerator.GdiMggBIG9xiUsitIDVg(654297945 ^ 654279271));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.componentMetadata = (ComponentMetadata) metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 2 : 0;
            continue;
          default:
            ComponentClientScriptModuleCodeGenerator.MPWSohBIfmjoTQUtlppY(metadata is ComponentMetadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883416080));
            num = 3;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetNamespaces() => (IEnumerable<ISyntaxNode>) new ISyntaxNode[12]
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218899220).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951580792).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475794849).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411131525).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398594480).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082466858).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561012204).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583676132).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876124495).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289776074).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173554393).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889521524).NamespaceImportDeclaration()
    };

    /// <inheritdoc />
    protected override string GetNamespace() => (string) ComponentClientScriptModuleCodeGenerator.WaOyTVBIQ0cLaSk9Fjur((object) this.componentMetadata);

    /// <inheritdoc />
    protected override string GetClassName() => (string) ComponentClientScriptModuleCodeGenerator.PN1sCIBICUhZ8lYBhJvy((object) this.componentMetadata);

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
            type.XmlComments(SR.T((string) ComponentClientScriptModuleCodeGenerator.GdiMggBIG9xiUsitIDVg(654297945 ^ 654236401), (object) this.componentMetadata.DisplayName).SummaryComment());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
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
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886577555).ClassDeclaration(modifiers: DeclarationModifiers.Partial)
    };

    public ComponentClientScriptModuleCodeGenerator()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object GdiMggBIG9xiUsitIDVg(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void UjRCOdBIE8SuOEVW50vE([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void MPWSohBIfmjoTQUtlppY(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static bool ekClYABIbmunfaFTKbIq() => ComponentClientScriptModuleCodeGenerator.X2LMrpBIoLdfPTiyCHx5 == null;

    internal static ComponentClientScriptModuleCodeGenerator kjhQeXBIhP9ITOrBRcs5() => ComponentClientScriptModuleCodeGenerator.X2LMrpBIoLdfPTiyCHx5;

    internal static object WaOyTVBIQ0cLaSk9Fjur([In] object obj0) => (object) ((ComponentMetadata) obj0).Namespace;

    internal static object PN1sCIBICUhZ8lYBhJvy([In] object obj0) => (object) ((NamedMetadata) obj0).Name;
  }
}
