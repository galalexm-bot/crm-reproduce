// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.CodeGeneration.PortletComponentPersonalizationGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.CodeGeneration
{
  /// <summary>Генератор настроек портлета</summary>
  internal sealed class PortletComponentPersonalizationGenerator : PortletPersonalizationGenerator
  {
    private static PortletComponentPersonalizationGenerator TEsu7eBu9Y4JfvQLgeGA;

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GenerateMainFile()
    {
      ISyntaxNode type = this.ignoreNamespaces.WithIgnoreNamespaces<ISyntaxNode>((Func<ISyntaxNode>) (() => ((string) PortletComponentPersonalizationGenerator.a9fBeyBu53AfsgD7YbOv(-2107978722 ^ -2108020940)).ClassDeclaration(Accessibility.Internal, baseType: (ISyntaxNode) PortletComponentPersonalizationGenerator.QwPyrOBujDa95aMUXIrM((object) this), interfaceTypes: this.GetBaseInterfaces(), members: this.GetMembers())));
      this.WriteComments(type);
      this.WriteTypeAttributes(type);
      return (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        type
      };
    }

    /// <inheritdoc />
    protected override void WriteTypeAttributes(ISyntaxNode type)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            base.WriteTypeAttributes(type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            if (PortletComponentPersonalizationGenerator.HtZZqQBurDHU0YxH1iJK((object) this.generationParams) != GenerationMode.Publish)
            {
              num = 2;
              continue;
            }
            goto case 1;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_2:
      return;
label_7:;
    }

    /// <inheritdoc />
    protected override void WritePropertyAttributes(
      ISyntaxNode property,
      PropertyMetadata propertyMetadata,
      string resourcePrefix = null)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_6;
          case 1:
            if (PortletComponentPersonalizationGenerator.HtZZqQBurDHU0YxH1iJK((object) this.generationParams) != GenerationMode.Publish)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_2;
          case 3:
            base.WritePropertyAttributes(property, propertyMetadata, resourcePrefix);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 2 : 1;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_2:
      return;
label_7:;
    }

    public PortletComponentPersonalizationGenerator()
    {
      PortletComponentPersonalizationGenerator.Aveel4BugjjyDLcjfIIJ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static GenerationMode HtZZqQBurDHU0YxH1iJK([In] object obj0) => ((GenerationParams) obj0).Mode;

    internal static bool DAWDVkBudj8FYy0huddY() => PortletComponentPersonalizationGenerator.TEsu7eBu9Y4JfvQLgeGA == null;

    internal static PortletComponentPersonalizationGenerator cwX86VBultJHJRHEXJGh() => PortletComponentPersonalizationGenerator.TEsu7eBu9Y4JfvQLgeGA;

    internal static void Aveel4BugjjyDLcjfIIJ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object a9fBeyBu53AfsgD7YbOv(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object QwPyrOBujDa95aMUXIrM([In] object obj0) => (object) ((ClassGenerator) obj0).GetBaseClass();
  }
}
