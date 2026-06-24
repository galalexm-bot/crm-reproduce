// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.CustomFilterGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Генератор кода уникального фильтра</summary>
  public class CustomFilterGenerator : EntityGenerator, IAutoClassGenerator
  {
    private Type interfaceType;
    private Type[] extensionTypes;
    internal static CustomFilterGenerator j0rGRNh2UcJm1XVilB58;

    /// <inheritdoc />
    public string GenerateCode(Type interfaceType, params Type[] extensionTypes)
    {
      int num = 1;
      EntityMetadata entityMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            CustomFilterGenerator.pScrCHheFKkFJ7W4ZwX9((object) interfaceType, CustomFilterGenerator.XEDpMkh2zj9gWo97O76Y(-606654180 ^ -606835348));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
            continue;
          case 2:
            Type[] typeArray = extensionTypes;
            this.extensionTypes = typeArray == null ? new Type[0] : typeArray;
            num = 4;
            continue;
          case 3:
            goto label_2;
          case 4:
            entityMetadata = new EntityMetadata();
            num = 6;
            continue;
          case 5:
            ((ICodeGenerator) this).Metadata = (IMetadata) entityMetadata.CreateInterfaceImplementationMetadata();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 3 : 0;
            continue;
          case 6:
            entityMetadata.LoadFromType(interfaceType, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 5 : 5;
            continue;
          default:
            this.interfaceType = interfaceType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:
      return (string) CustomFilterGenerator.c6EksXheBnlSINrV0Uuv((object) interfaceType.Namespace.NamespaceDeclaration(this.GetNamespaces().Concat<ISyntaxNode>(this.GenerateMainFile())));
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GenerateMainFile() => this.WriteFilterClass();

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> FilterForAttribute() => Enumerable.Empty<ISyntaxNode>();

    /// <inheritdoc />
    protected override string GetInterfaceTypeName() => this.interfaceType.FullName;

    /// <inheritdoc />
    protected override void FilterCommentSummary(ISyntaxNode filterType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            filterType.XmlComments(EleWise.ELMA.SR.T((string) CustomFilterGenerator.XEDpMkh2zj9gWo97O76Y(589593376 ^ -1977315327 ^ -1459374161), CustomFilterGenerator.HIRdwYheoWxTT85OYfxU(CustomFilterGenerator.aosgcOheWyPxyPH7sg2K((object) this.metadata))).SummaryComment());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public CustomFilterGenerator()
    {
      CustomFilterGenerator.PyhJVVhebCtm2XMqIAdv();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object XEDpMkh2zj9gWo97O76Y(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void pScrCHheFKkFJ7W4ZwX9([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object c6EksXheBnlSINrV0Uuv([In] object obj0) => (object) ((ISyntaxNode) obj0).GenerateCSCodeString();

    internal static bool WZcUuGh2sGwXFm5RaEn0() => CustomFilterGenerator.j0rGRNh2UcJm1XVilB58 == null;

    internal static CustomFilterGenerator oKraOlh2cSZDhRXnalxf() => CustomFilterGenerator.j0rGRNh2UcJm1XVilB58;

    internal static object aosgcOheWyPxyPH7sg2K([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static object HIRdwYheoWxTT85OYfxU([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void PyhJVVhebCtm2XMqIAdv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
