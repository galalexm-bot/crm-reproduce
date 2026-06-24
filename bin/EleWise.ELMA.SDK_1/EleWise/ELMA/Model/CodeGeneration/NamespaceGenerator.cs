// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.NamespaceGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

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
  public class NamespaceGenerator : CodeGenerator
  {
    /// <summary>Метаданные пространства имен</summary>
    protected NamespaceMetadata metadata;
    private static NamespaceGenerator r5H7v6hD8EllFVntgeWw;

    /// <summary>Внутренняя инициализация</summary>
    /// <param name="metadata">Метаданные пространства имен</param>
    protected override void InitInternal(IMetadata metadata)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.metadata = (NamespaceMetadata) metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
            continue;
          case 2:
            NamespaceGenerator.ktERUIhDSbgU4IGSvkrS(metadata is NamespaceMetadata, NamespaceGenerator.L3lQkYhDIw46FnTWhWM7(712480695 ^ 712304533));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 0;
            continue;
          case 3:
            NamespaceGenerator.MT1FAdhDVtEJyKrFJpeS((object) metadata, NamespaceGenerator.L3lQkYhDIw46FnTWhWM7(92412609 - 1050237057 ^ -957838466));
            num = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <summary>Сгенерировать основной файл</summary>
    /// <returns>Информация о сгенерированном файле</returns>
    protected override GeneratedFileInfo GenerateMainFileInternal()
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            NamespaceGenerator.SigO1xhDisx1U6VKSQYs((object) this.metadata, NamespaceGenerator.L3lQkYhDIw46FnTWhWM7(-1487388570 ^ -1487402664));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_11;
          default:
            goto label_2;
        }
      }
label_2:
      GeneratedFileInfo mainFileHelper;
      try
      {
        mainFileHelper = this.GenerateMainFileHelper((IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
        {
          ((string) NamespaceGenerator.YpVhtbhDRXftn8mYEsCl((object) this.metadata)).NamespaceDeclaration(this.GetNamespaces().Concat<ISyntaxNode>(this.GenerateMainFile()))
        }, true);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            throw new CodeGenerationException(EleWise.ELMA.SR.T((string) NamespaceGenerator.L3lQkYhDIw46FnTWhWM7(1012087039 ^ 1011897217), NamespaceGenerator.vkX4wwhDqbsAIEDMUNrY((object) this.metadata)), ex);
        }
      }
label_11:
      return mainFileHelper;
    }

    /// <exclude />
    protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal() => (IEnumerable<GeneratedFileInfo>) new NamespaceGenerator.\u003CGenerateAdditionalFilesInternal\u003Ed__2(-2);

    /// <summary>Записать используемые пространства имен</summary>
    protected virtual IEnumerable<ISyntaxNode> GetNamespaces() => (IEnumerable<ISyntaxNode>) new NamespaceGenerator.\u003CGetNamespaces\u003Ed__4(-2);

    /// <summary>Сгенерировать основной файл</summary>
    protected virtual IEnumerable<ISyntaxNode> GenerateMainFile() => (IEnumerable<ISyntaxNode>) new NamespaceGenerator.\u003CGenerateMainFile\u003Ed__5(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>Записать комментарии к классу</summary>
    /// <param name="type">Объявление класса</param>
    protected virtual void WriteComments(ISyntaxNode type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            NamespaceGenerator.SigO1xhDisx1U6VKSQYs((object) this.metadata, NamespaceGenerator.L3lQkYhDIw46FnTWhWM7(44884861 ^ 44870211));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            type.XmlComments(EleWise.ELMA.SR.T((string) NamespaceGenerator.L3lQkYhDIw46FnTWhWM7(-420743386 ^ -420968634), NamespaceGenerator.YpVhtbhDRXftn8mYEsCl((object) this.metadata)).SummaryComment());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Записать атрибуты класса</summary>
    /// <param name="declaration">Объявление класса</param>
    protected virtual void WriteTypeAttributes(ISyntaxNode declaration)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              if (!NamespaceGenerator.VJbiH8hDKMiRbPhPntTd((object) this.metadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 1;
                continue;
              }
              break;
            case 3:
              goto label_7;
            case 4:
              goto label_8;
            case 5:
              goto label_3;
          }
          declaration.AddAttributes(TypeOf<AllowCreateModelsAttribute>.Raw.CreateAttribute());
          num2 = 5;
        }
label_7:
        this.WriteBasicAttributes(declaration);
        num1 = 2;
        continue;
label_8:
        NamespaceGenerator.SigO1xhDisx1U6VKSQYs((object) this.metadata, NamespaceGenerator.L3lQkYhDIw46FnTWhWM7(-1380439818 << 3 ^ 1841368718));
        num1 = 3;
      }
label_6:
      return;
label_3:;
    }

    /// <summary>Записать члены класса</summary>
    protected virtual IEnumerable<ISyntaxNode> Members() => (IEnumerable<ISyntaxNode>) new NamespaceGenerator.\u003CMembers\u003Ed__8(-2)
    {
      \u003C\u003E4__this = this
    };

    public NamespaceGenerator()
    {
      NamespaceGenerator.HgbitShDXB5vixiDDSH8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object L3lQkYhDIw46FnTWhWM7(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void MT1FAdhDVtEJyKrFJpeS([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void ktERUIhDSbgU4IGSvkrS(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static bool MFfJQfhDZVD2SGh3JfOy() => NamespaceGenerator.r5H7v6hD8EllFVntgeWw == null;

    internal static NamespaceGenerator qM3cSkhDuK7Kpwqrwv26() => NamespaceGenerator.r5H7v6hD8EllFVntgeWw;

    internal static void SigO1xhDisx1U6VKSQYs([In] object obj0, [In] object obj1) => Contract.NotNull(obj0, (string) obj1);

    internal static object YpVhtbhDRXftn8mYEsCl([In] object obj0) => (object) ((NamespaceMetadata) obj0).Namespace;

    internal static object vkX4wwhDqbsAIEDMUNrY([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static bool VJbiH8hDKMiRbPhPntTd([In] object obj0) => ((NamespaceMetadata) obj0).AllowCreateModels;

    internal static void HgbitShDXB5vixiDDSH8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
