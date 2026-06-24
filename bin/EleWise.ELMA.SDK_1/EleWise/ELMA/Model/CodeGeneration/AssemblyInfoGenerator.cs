// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.AssemblyInfoGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.CodeGeneration.CSharp.Nodes;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>
  /// Генератор кода класса с информацией о пространстве имен
  /// </summary>
  public class AssemblyInfoGenerator : CodeGenerator
  {
    /// <summary>Метаданные сборки</summary>
    protected AssemblyInfoMetadata metadata;
    private static AssemblyInfoGenerator BDCqpihDFE45qwXosX32;

    /// <summary>Внутренняя инициализация</summary>
    /// <param name="metadata">Метаданные пространства имен</param>
    protected override void InitInternal(IMetadata metadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            AssemblyInfoGenerator.lSnWnlhDohhk2fboPP7P((object) metadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217505273));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
            continue;
          case 2:
            this.metadata = (AssemblyInfoMetadata) metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 3 : 3;
            continue;
          case 3:
            goto label_2;
          default:
            AssemblyInfoGenerator.Ammy9yhDhUQ9TtvDhNLG(metadata is AssemblyInfoMetadata, AssemblyInfoGenerator.tcApnuhDbKXJYSnJhxjx(1917998801 >> 2 ^ 479721992));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Сгенерировать основной файл</summary>
    /// <returns>Информация о сгенерированном файле</returns>
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
            AssemblyInfoGenerator.PG4NXQhDGA8aiq8MmItc((object) this.metadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672211926));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
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
        mainFileHelper = this.GenerateMainFileHelper(this.AssemblyAttributes().Concat<ISyntaxNode>(this.MemberDeclarations()), true);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
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
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            throw new CodeGenerationException(EleWise.ELMA.SR.T((string) AssemblyInfoGenerator.tcApnuhDbKXJYSnJhxjx(-35995181 ^ -36066643), AssemblyInfoGenerator.khZWrGhDEfimW8mclHqH((object) this.metadata)), ex);
        }
      }
    }

    protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal() => (IEnumerable<GeneratedFileInfo>) new AssemblyInfoGenerator.\u003CGenerateAdditionalFilesInternal\u003Ed__2(-2);

    /// <summary>Сгенерировать код с атрибутами сборки</summary>
    protected virtual IEnumerable<ISyntaxNode> AssemblyAttributes() => (IEnumerable<ISyntaxNode>) new AssemblyInfoGenerator.\u003CAssemblyAttributes\u003Ed__4(-2)
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

    /// <summary>Сгенерировать код</summary>
    protected virtual IEnumerable<ISyntaxNode> MemberDeclarations() => (IEnumerable<ISyntaxNode>) new AssemblyInfoGenerator.\u003CMemberDeclarations\u003Ed__6(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>
    /// Сгенерировать Stub-класс, который определяет, что сборке есть AssemblyInfoMetadata
    /// </summary>
    protected virtual ISyntaxNode GenerateStubClass()
    {
      int num = 5;
      ISyntaxNode type;
      AssemblyInfoGenerator assemblyInfoGenerator;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            type = ((string) AssemblyInfoGenerator.tcApnuhDbKXJYSnJhxjx(-1146510045 ^ -1146432221)).ClassDeclaration(Accessibility.Internal, members: this.UidStaticMembers());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            EleWise.ELMA.SR.RunWithFutureTranslate<ISyntaxNode>((Func<ISyntaxNode>) (() => type.AddAttributes(TypeOf<DescriptionAttribute>.Raw.CreateAttribute(AssemblyInfoGenerator.\u003C\u003Ec__DisplayClass7_0.qyIDvevqCtfXJclUkDEK(AssemblyInfoGenerator.\u003C\u003Ec__DisplayClass7_0.KwHR2rvqQ7myxivpHJDF((object) assemblyInfoGenerator.metadata))))), false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 0;
            continue;
          case 4:
            assemblyInfoGenerator = this;
            num = 2;
            continue;
          case 5:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 4 : 0;
            continue;
          case 6:
            if (!AssemblyInfoGenerator.LXow3JhDfdRS2PkPVe0w((object) this.metadata.Summary))
            {
              num = 3;
              continue;
            }
            goto label_8;
          default:
            this.WriteBasicAttributes(type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 6 : 1;
            continue;
        }
      }
label_8:
      return type;
    }

    /// <summary>Записать используемые пространства имен</summary>
    protected virtual IEnumerable<ISyntaxNode> GetNamespaces() => (IEnumerable<ISyntaxNode>) new AssemblyInfoGenerator.\u003CGetNamespaces\u003Ed__8(-2);

    /// <summary>Записать свойство в класс ресурсов</summary>
    /// <param name="propertyName">Имя свойства</param>
    /// <param name="propertyValue">Значение свойства</param>
    protected ISyntaxNode ResourceClassProperty(string propertyName, string propertyValue) => propertyName.PropertyDeclaration((ISyntaxNode) AssemblyInfoGenerator.hbEfOYhDQDIkn2lvEsyS(TypeOf<string>.Raw), Accessibility.Public, DeclarationModifiers.Static, (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
    {
      (ISyntaxNode) AssemblyInfoGenerator.hAPi6fhDC71cZdLpHVL5((object) this.GetLocalizableExpression(propertyValue))
    });

    public AssemblyInfoGenerator()
    {
      AssemblyInfoGenerator.qiGSm4hDvu3yF1mxEcZp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void lSnWnlhDohhk2fboPP7P([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object tcApnuhDbKXJYSnJhxjx(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void Ammy9yhDhUQ9TtvDhNLG(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static bool dGX1TohDBu6Cxf65p4ve() => AssemblyInfoGenerator.BDCqpihDFE45qwXosX32 == null;

    internal static AssemblyInfoGenerator AdhnHThDWq8Ymuwv9Txu() => AssemblyInfoGenerator.BDCqpihDFE45qwXosX32;

    internal static void PG4NXQhDGA8aiq8MmItc([In] object obj0, [In] object obj1) => Contract.NotNull(obj0, (string) obj1);

    internal static object khZWrGhDEfimW8mclHqH([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static bool LXow3JhDfdRS2PkPVe0w([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object hbEfOYhDQDIkn2lvEsyS(Type type) => (object) type.CreateTypeSyntax();

    internal static object hAPi6fhDC71cZdLpHVL5([In] object obj0) => (object) ((ISyntaxNode) obj0).ReturnStatement();

    internal static void qiGSm4hDvu3yF1mxEcZp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
