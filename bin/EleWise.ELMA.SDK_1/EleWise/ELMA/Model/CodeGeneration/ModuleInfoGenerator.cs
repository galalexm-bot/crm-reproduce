// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.ModuleInfoGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.CodeGeneration.CSharp.Nodes;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>
  /// Генератор кода аттрибутов сборки на основе метаданных модуля
  /// </summary>
  public class ModuleInfoGenerator : CodeGenerator
  {
    /// <summary>Метаданные модуля</summary>
    protected ModuleInfoMetadata metadata;
    private static ModuleInfoGenerator c27J1Ph3cgNaryHFkSoQ;

    /// <inheritdoc />
    protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal() => (IEnumerable<GeneratedFileInfo>) new ModuleInfoGenerator.\u003CGenerateAdditionalFilesInternal\u003Ed__0(-2);

    /// <inheritdoc />
    protected override GeneratedFileInfo GenerateMainFileInternal()
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            ModuleInfoGenerator.OLScL5hpWY68CnT9g9Rf((object) this.metadata, ModuleInfoGenerator.h7ruXLhpB8NV6er1JT0e(-951514650 ^ -951500584));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      GeneratedFileInfo mainFileHelper;
      return mainFileHelper;
label_4:
      try
      {
        mainFileHelper = this.GenerateMainFileHelper(this.AssemblyAttributes());
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            throw new CodeGenerationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345364806), (object) this.metadata.Name), ex);
        }
      }
    }

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
            ModuleInfoGenerator.A45QqOhpbVBTCTgZjFgm(metadata is ModuleInfoMetadata, ModuleInfoGenerator.h7ruXLhpB8NV6er1JT0e(654297945 ^ 654090469));
            num = 3;
            continue;
          case 2:
            ModuleInfoGenerator.i34qNBhpougsbgfnG74Q((object) metadata, ModuleInfoGenerator.h7ruXLhpB8NV6er1JT0e(1597012150 ^ 1596993928));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 0;
            continue;
          case 3:
            this.metadata = (ModuleInfoMetadata) metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <summary>Сгенерировать код с атрибутами сборки</summary>
    protected virtual IEnumerable<ISyntaxNode> AssemblyAttributes() => (IEnumerable<ISyntaxNode>) new ModuleInfoGenerator.\u003CAssemblyAttributes\u003Ed__4(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>Записать атрибут сборки</summary>
    /// <typeparam name="T">Тип атрибута</typeparam>
    /// <param name="ctorParameters">Параметры конструктора</param>
    protected ISyntaxNode AssemblyAttribute<T>(params object[] ctorParameters)
    {
      ISyntaxNode attribute = TypeOf<T>.Raw.CreateAttribute(ctorParameters);
      attribute.Unpack<AttributeSyntax>().AssemblySpecifier = true;
      return attribute;
    }

    public ModuleInfoGenerator()
    {
      ModuleInfoGenerator.OdbjoAhphTcFDJXN8Ovb();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object h7ruXLhpB8NV6er1JT0e(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void OLScL5hpWY68CnT9g9Rf([In] object obj0, [In] object obj1) => Contract.NotNull(obj0, (string) obj1);

    internal static bool g2Gcr7h3zbL2kud42snd() => ModuleInfoGenerator.c27J1Ph3cgNaryHFkSoQ == null;

    internal static ModuleInfoGenerator jddxQJhpFBVQbyyARxpL() => ModuleInfoGenerator.c27J1Ph3cgNaryHFkSoQ;

    internal static void i34qNBhpougsbgfnG74Q([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void A45QqOhpbVBTCTgZjFgm(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static void OdbjoAhphTcFDJXN8Ovb() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
