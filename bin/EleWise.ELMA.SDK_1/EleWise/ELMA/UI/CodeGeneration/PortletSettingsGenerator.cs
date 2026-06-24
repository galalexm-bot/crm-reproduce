// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.CodeGeneration.PortletSettingsGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.CodeGeneration
{
  public class PortletSettingsGenerator : FormContextGenerator
  {
    private static PortletSettingsGenerator WlI2KtBVxbhJd0O9hDqq;

    protected override ISyntaxNode GetBaseClass()
    {
      int num = 1;
      ISyntaxNode syntaxNode;
      while (true)
      {
        switch (num)
        {
          case 1:
            syntaxNode = (ISyntaxNode) PortletSettingsGenerator.fCDo6uBVyrJXRYGMETiF((object) (ITypeGenerationInfo) this.GetIdTypeDescriptor(), (object) this.metadata, (object) null, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      // ISSUE: type reference
      return PortletSettingsGenerator.nnBxAwBVM7UP51gpsgao(__typeref (PortletSettings<>)).CreateTypeSyntax(syntaxNode);
    }

    public PortletSettingsGenerator()
    {
      PortletSettingsGenerator.AcT1P3BVJ0LAH8JyTJBh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object fCDo6uBVyrJXRYGMETiF(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      bool forFilter)
    {
      return (object) ((ITypeGenerationInfo) obj0).GetPropertyTypeReference((ClassMetadata) obj1, (PropertyMetadata) obj2, forFilter);
    }

    internal static Type nnBxAwBVM7UP51gpsgao([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool T5SwtSBV0yUCdeqlUdIe() => PortletSettingsGenerator.WlI2KtBVxbhJd0O9hDqq == null;

    internal static PortletSettingsGenerator zWgH2jBVmiOiyhVLX2gL() => PortletSettingsGenerator.WlI2KtBVxbhJd0O9hDqq;

    internal static void AcT1P3BVJ0LAH8JyTJBh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
