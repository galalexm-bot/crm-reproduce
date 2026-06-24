// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.CodeGeneration.FormMetadataGenerator`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.UI.CodeGeneration
{
  public abstract class FormMetadataGenerator<T> : CodeGenerator where T : FormMetadata
  {
    private T _metadata;
    internal static object NGEC1hBV3XnIOoWiHKgv;

    protected override void InitInternal(IMetadata metadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672211926));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            this._metadata = (T) metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 2;
            continue;
          default:
            Contract.CheckArgument(metadata is FormMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921130791));
            num = 3;
            continue;
        }
      }
label_2:;
    }

    protected override GeneratedFileInfo GenerateMainFileInternal()
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            Contract.NotNull((object) this.Metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727385716));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 0;
            continue;
          default:
            goto label_9;
        }
      }
label_2:
      GeneratedFileInfo mainFileHelper;
      try
      {
        mainFileHelper = this.GenerateMainFileHelper((!string.IsNullOrEmpty(this.generationParams.Prefix) ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541734579) + this.generationParams.Prefix : "") + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541799737), this.Metadata.Namespace.NamespaceDeclaration(this.GetNamespaces().Concat<ISyntaxNode>(this.GenerateMainFile())));
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            throw new CodeGenerationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787383323), (object) this.Metadata.Name), ex);
        }
      }
label_9:
      return mainFileHelper;
    }

    protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal() => (IEnumerable<GeneratedFileInfo>) new FormMetadataGenerator<T>.\u003CGenerateAdditionalFilesInternal\u003Ed__2(-2);

    protected T Metadata => this._metadata;

    protected virtual IEnumerable<ISyntaxNode> GetNamespaces() => (IEnumerable<ISyntaxNode>) new FormMetadataGenerator<T>.\u003CGetNamespaces\u003Ed__5(-2);

    protected virtual IEnumerable<ISyntaxNode> GenerateMainFile() => (IEnumerable<ISyntaxNode>) new FormMetadataGenerator<T>.\u003CGenerateMainFile\u003Ed__6(-2)
    {
      \u003C\u003E4__this = this
    };

    protected virtual ISyntaxNode CreateContainerTypeDeclaration()
    {
      int num = 1;
      ISyntaxNode syntaxNode;
      while (true)
      {
        switch (num)
        {
          case 1:
            syntaxNode = this.Metadata.Name.ClassDeclaration(Accessibility.Public, members: this.GenerateMainFileContent());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            syntaxNode.AddAttributes(typeof (MetadataTypeAttribute).CreateAttribute((object) this.Metadata.GetType()));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      return syntaxNode;
    }

    protected abstract IEnumerable<ISyntaxNode> GenerateMainFileContent();

    protected FormMetadataGenerator()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool xa0DqABVpQnbVCM35JiD() => FormMetadataGenerator<T>.NGEC1hBV3XnIOoWiHKgv == null;

    internal static object CTUgDDBVaI9G3l4dIuZX() => FormMetadataGenerator<T>.NGEC1hBV3XnIOoWiHKgv;
  }
}
