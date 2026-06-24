// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.CodeGeneration.ComponentServerScriptModuleCodeGenerator
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
  /// Генерация кода для серверного модуля сценариев компонентов
  /// </summary>
  internal sealed class ComponentServerScriptModuleCodeGenerator : ScriptModuleCodeGenerator
  {
    private ComponentMetadata componentMetadata;
    internal static ComponentServerScriptModuleCodeGenerator LgrM29BIRbyCu3cjhNCh;

    /// <inheritdoc />
    protected override void InitInternal(IMetadata metadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ComponentServerScriptModuleCodeGenerator.h4BXkoBITLkAMlFkZde2(metadata is ComponentMetadata, ComponentServerScriptModuleCodeGenerator.KlNQwYBIXVjSvkcdZdJG(825385222 ^ 825454374));
            num = 3;
            continue;
          case 2:
            Contract.ArgumentNotNull((object) metadata, (string) ComponentServerScriptModuleCodeGenerator.KlNQwYBIXVjSvkcdZdJG(-1146510045 ^ -1146491875));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
            continue;
          case 3:
            this.componentMetadata = (ComponentMetadata) metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetNamespaces() => (IEnumerable<ISyntaxNode>) new ISyntaxNode[9]
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852900262).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146574003).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70106890).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488812089).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195675341).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199877313).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146570903).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951581170).NamespaceImportDeclaration(),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222100738).NamespaceImportDeclaration()
    };

    /// <inheritdoc />
    protected override string GetNamespace() => (string) ComponentServerScriptModuleCodeGenerator.ha0IR0BIkYEfxYA5t8Wv((object) this.componentMetadata);

    /// <inheritdoc />
    protected override string GetClassName() => (string) ComponentServerScriptModuleCodeGenerator.BdFrm6BInNcQ7RuPPDmn((object) this.componentMetadata);

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
            type.XmlComments(SR.T((string) ComponentServerScriptModuleCodeGenerator.KlNQwYBIXVjSvkcdZdJG(1178210108 ^ 1178279572), ComponentServerScriptModuleCodeGenerator.o4HksdBIOM25ooMHc0dw((object) this.componentMetadata)).SummaryComment());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
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
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536865160).ClassDeclaration(modifiers: DeclarationModifiers.Partial)
    };

    public ComponentServerScriptModuleCodeGenerator()
    {
      ComponentServerScriptModuleCodeGenerator.Kdge4MBI2B8Ly70kROu2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object KlNQwYBIXVjSvkcdZdJG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void h4BXkoBITLkAMlFkZde2(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static bool WJKd8HBIqHdum4QdRt9N() => ComponentServerScriptModuleCodeGenerator.LgrM29BIRbyCu3cjhNCh == null;

    internal static ComponentServerScriptModuleCodeGenerator BtDC8BBIKsMVep7ixAP2() => ComponentServerScriptModuleCodeGenerator.LgrM29BIRbyCu3cjhNCh;

    internal static object ha0IR0BIkYEfxYA5t8Wv([In] object obj0) => (object) ((ComponentMetadata) obj0).Namespace;

    internal static object BdFrm6BInNcQ7RuPPDmn([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object o4HksdBIOM25ooMHc0dw([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static void Kdge4MBI2B8Ly70kROu2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
