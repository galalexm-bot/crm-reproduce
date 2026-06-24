// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.CodeGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Базовый класс генератора кода на основе метаданных</summary>
  public abstract class CodeGenerator : ICodeGenerator
  {
    /// <summary>Параметры генерации</summary>
    protected GenerationParams generationParams;
    /// <summary>Имя поля уникального идентификатора</summary>
    internal const string CONST_UID_FIELD = "_UID";
    protected const string CONST_UID_S = "UID_S";
    protected const string CONST_UID = "UID";
    protected readonly List<string> ignoreNamespaces;
    private IMetadata metadata;
    private static CodeGenerator mPg6afhDgDF0Cm5lkRV0;

    IMetadata ICodeGenerator.Metadata
    {
      get => this.metadata;
      set
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              CodeGenerator.rcWiOqhDL9kSGmJ2PSNF((object) this, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
              continue;
            case 2:
              CodeGenerator.kqOELshDYssuwPNau1pP((object) this, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 0;
              continue;
            case 3:
              this.metadata = value;
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
    }

    GenerationParams ICodeGenerator.GenerationParams
    {
      get => this.generationParams;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.generationParams = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    GeneratedFileInfo ICodeGenerator.GenerateMainFile() => this.ignoreNamespaces.WithIgnoreNamespaces<GeneratedFileInfo>((Func<GeneratedFileInfo>) (() => (GeneratedFileInfo) CodeGenerator.NCR66khtq2BX1pqaJScY((object) this)));

    GeneratedFileInfo[] ICodeGenerator.Generate() => this.ignoreNamespaces.WithIgnoreNamespaces<GeneratedFileInfo[]>((Func<GeneratedFileInfo[]>) (() =>
    {
      int num = 3;
      GeneratedFileInfo mainFileInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            List<GeneratedFileInfo> generatedFileInfoList = new List<GeneratedFileInfo>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 3:
            num = 2;
            continue;
          default:
            mainFileInfo = (GeneratedFileInfo) CodeGenerator.NCR66khtq2BX1pqaJScY((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
            continue;
        }
      }
label_2:
      return Enumerable.Empty<GeneratedFileInfo>().If<GeneratedFileInfo>(mainFileInfo != null, (Func<IEnumerable<GeneratedFileInfo>, IEnumerable<GeneratedFileInfo>>) (g => g.Concat<GeneratedFileInfo>(mainFileInfo))).Concat<GeneratedFileInfo>(this.GenerateAdditionalFilesInternal()).ToArray<GeneratedFileInfo>();
    }));

    GeneratedFileInfo[] ICodeGenerator.GenerateAdditionalFiles() => this.ignoreNamespaces.WithIgnoreNamespaces<GeneratedFileInfo[]>((Func<GeneratedFileInfo[]>) (() => this.GenerateAdditionalFilesInternal().ToArray<GeneratedFileInfo>()));

    /// <summary>Внутренняя инициализация</summary>
    /// <param name="metadata">Метаданные</param>
    protected abstract void InitInternal(IMetadata metadata);

    /// <summary>Сгенерировать основной файл</summary>
    /// <returns>Информация о сгенерированном файле</returns>
    protected abstract GeneratedFileInfo GenerateMainFileInternal();

    /// <summary>
    /// Сформировать <see cref="T:EleWise.ELMA.Model.CodeGeneration.GeneratedFileInfo" />
    /// </summary>
    /// <param name="declarations">Деклация кода</param>
    protected GeneratedFileInfo GenerateMainFileHelper(params ISyntaxNode[] declarations) => this.GenerateMainFileHelper(((IEnumerable<ISyntaxNode>) declarations).AsEnumerable<ISyntaxNode>());

    /// <summary>
    /// Сформировать <see cref="T:EleWise.ELMA.Model.CodeGeneration.GeneratedFileInfo" />
    /// </summary>
    /// <param name="declarations">Деклация кода</param>
    /// <param name="withPragmaWarningDisable">Добавить #pragma warning disable</param>
    protected GeneratedFileInfo GenerateMainFileHelper(
      IEnumerable<ISyntaxNode> declarations,
      bool withPragmaWarningDisable = false)
    {
      return this.GenerateMainFileHelper(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488809851), declarations, withPragmaWarningDisable);
    }

    /// <summary>
    /// Сформировать <see cref="T:EleWise.ELMA.Model.CodeGeneration.GeneratedFileInfo" />
    /// </summary>
    /// <param name="extension">Расширения файла</param>
    /// <param name="declarations">Деклация кода</param>
    protected GeneratedFileInfo GenerateMainFileHelper(
      string extension,
      params ISyntaxNode[] declarations)
    {
      return this.GenerateMainFileHelper(extension, ((IEnumerable<ISyntaxNode>) declarations).AsEnumerable<ISyntaxNode>());
    }

    /// <summary>
    /// Сформировать <see cref="T:EleWise.ELMA.Model.CodeGeneration.GeneratedFileInfo" />
    /// </summary>
    /// <param name="extension">Расширения файла</param>
    /// <param name="declarations">Деклация кода</param>
    /// <param name="withPragmaWarningDisable">Добавить #pragma warning disable</param>
    protected GeneratedFileInfo GenerateMainFileHelper(
      string extension,
      IEnumerable<ISyntaxNode> declarations,
      bool withPragmaWarningDisable = false)
    {
      GeneratedFileInfo mainFileHelper = new GeneratedFileInfo();
      mainFileHelper.Type = GeneratedFileType.CS;
      GeneratedFileInfo generatedFileInfo = mainFileHelper;
      IEnumerable<ISyntaxNode> declarations1;
      if (!withPragmaWarningDisable)
        declarations1 = declarations;
      else
        declarations1 = declarations.WithPragmaWarningDisableDirective(108.CreateSyntaxNode(), 114.CreateSyntaxNode(), 162.CreateSyntaxNode(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837887663).IdentifierName());
      byte[] csCode = declarations1.GenerateCSCode();
      generatedFileInfo.Data = csCode;
      mainFileHelper.Extension = extension;
      return mainFileHelper;
    }

    /// <summary>Сгенерировать дополнительные файлы</summary>
    protected abstract IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal();

    /// <summary>
    /// Инициализировать пространства имен, которые можно игнорировать при ссылке на тип
    /// </summary>
    protected virtual void InitIgnoreNamespaces(IMetadata metadata)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        ICodeItemMetadata codeItemMetadata;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_4;
            case 1:
              goto label_10;
            case 2:
              this.ignoreNamespaces.Insert(0, codeItemMetadata.Namespace);
              num2 = 4;
              continue;
            case 3:
              if (codeItemMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 5 : 2;
                continue;
              }
              goto label_3;
            case 4:
              goto label_13;
            case 5:
              if (CodeGenerator.s5wJh3hDzPuYCwswKfmF(CodeGenerator.KxLLsYhDcGprwbtfXGKX((object) codeItemMetadata)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 6:
              this.ignoreNamespaces.Add((string) CodeGenerator.XnaKDUhDsNLG9ZLQH9No(~-122002947 ^ 121933916));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 1;
              continue;
            case 7:
              CodeGenerator.KMMSWEhDU5tGjX727tAH((object) this.ignoreNamespaces);
              num2 = 6;
              continue;
            default:
              goto label_14;
          }
        }
label_10:
        codeItemMetadata = metadata as ICodeItemMetadata;
        num1 = 3;
      }
label_4:
      return;
label_13:
      return;
label_14:
      return;
label_3:;
    }

    /// <summary>Записать документируемые комментарии</summary>
    /// <param name="node">SyntaxNode</param>
    /// <param name="metadata">Метаданные объекта, содержащего комментарии</param>
    /// <param name="resourcePrefix">Префикс для имени ресурса</param>
    protected void XmlComments(
      ISyntaxNode node,
      NamedDocumentedMetadata metadata,
      string resourcePrefix = null)
    {
      int num = 2;
      List<ISyntaxTrivia> documentationComments;
      string comment;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!CodeGenerator.s5wJh3hDzPuYCwswKfmF(CodeGenerator.siA45HhtFHFVnqmSaOgG((object) metadata)))
            {
              num = 5;
              continue;
            }
            goto case 3;
          case 2:
            documentationComments = new List<ISyntaxTrivia>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 1 : 1;
            continue;
          case 3:
            if (!CodeGenerator.s5wJh3hDzPuYCwswKfmF(CodeGenerator.g3cTIhhtBUu5kriycyEO((object) metadata)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
              continue;
            }
            goto case 7;
          case 4:
            goto label_12;
          case 5:
          case 6:
            comment = (string) CodeGenerator.B46JXBhtboiGUjy2ruan(CodeGenerator.B46JXBhtboiGUjy2ruan(CodeGenerator.siA45HhtFHFVnqmSaOgG((object) metadata), CodeGenerator.XnaKDUhDsNLG9ZLQH9No(647913418 ^ 647835380), CodeGenerator.Hioph5htWHWeMTEb6ZCo(CodeGenerator.g3cTIhhtBUu5kriycyEO((object) metadata))), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459381633), (object) EleWise.ELMA.SR.T((string) CodeGenerator.rAMD0phtoDNbJ1wPBUYX((object) metadata)));
            num = 12;
            continue;
          case 7:
            if (CodeGenerator.s5wJh3hDzPuYCwswKfmF(CodeGenerator.rAMD0phtoDNbJ1wPBUYX((object) metadata)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 2 : 10;
              continue;
            }
            goto case 11;
          case 8:
          case 9:
          case 10:
            node.XmlComments((IEnumerable<ISyntaxTrivia>) documentationComments);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 4;
            continue;
          case 11:
            documentationComments.Add(((string) CodeGenerator.Hioph5htWHWeMTEb6ZCo(CodeGenerator.rAMD0phtoDNbJ1wPBUYX((object) metadata))).RemarksComment());
            num = 9;
            continue;
          case 12:
            documentationComments.Add(comment.SplittedComment());
            num = 8;
            continue;
          default:
            documentationComments.Add(((string) CodeGenerator.Hioph5htWHWeMTEb6ZCo((object) metadata.DisplayName)).SummaryComment());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 7 : 7;
            continue;
        }
      }
label_12:;
    }

    /// <summary>Получить поле идентификатора</summary>
    /// <param name="guidType">Тип идентификатора</param>
    /// <returns>Поле идентификатора</returns>
    protected virtual ISyntaxNode GetUidField(ISyntaxNode guidType) => ((string) CodeGenerator.XnaKDUhDsNLG9ZLQH9No(~210725948 ^ -210517337)).FieldDeclaration(guidType, Accessibility.Private, DeclarationModifiers.Static, guidType.ObjectCreationExpression((ISyntaxNode) CodeGenerator.f9BLvuhthtXwsQfWqWhL((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105277806))));

    /// <summary>
    /// Записать константу и статическое свойство, определяющие уникальный идентификатор класса
    /// </summary>
    /// <param name="useNewKeyword">Использовать ли ключевое слово "new"</param>
    protected virtual IEnumerable<ISyntaxNode> UidStaticMembers(bool useNewKeyword = false) => (IEnumerable<ISyntaxNode>) new CodeGenerator.\u003CUidStaticMembers\u003Ed__24(-2)
    {
      \u003C\u003E4__this = this,
      \u003C\u003E3__useNewKeyword = useNewKeyword
    };

    /// <summary>
    /// Записать атрибуты класса, которые есть в интерфейсе IMetadata (Uid)
    /// </summary>
    /// <param name="declaration">Объявление класса</param>
    protected void WriteBasicAttributes(ISyntaxNode declaration)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.metadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
              continue;
            }
            ISyntaxNode syntaxNode = declaration;
            ISyntaxNode[] syntaxNodeArray = new ISyntaxNode[2];
            Type raw = TypeOf<MetadataTypeAttribute>.Raw;
            object[] objArray = new object[1];
            Type type = this.generationParams.MetadataType;
            if ((object) type == null)
              type = this.metadata.GetType();
            objArray[0] = (object) type;
            syntaxNodeArray[0] = raw.CreateAttribute(objArray);
            syntaxNodeArray[1] = TypeOf<UidAttribute>.Raw.CreateAttribute(CodeGenerator.jGIS4KhtE99gLIOpbwpc((object) CodeGenerator.euBsYahtG1nUKf0Z8cKM((object) this.metadata).ToString()));
            syntaxNode.AddAttributes(syntaxNodeArray);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 1;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:
      throw new NullReferenceException((string) CodeGenerator.XnaKDUhDsNLG9ZLQH9No(-1867198571 ^ -1867089087));
    }

    /// <summary>Получить выражение в виде SR.T("text")</summary>
    /// <param name="text">Локализуемый текст</param>
    /// <returns>Выражение</returns>
    protected string GetLocalizableText(string text)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (string.IsNullOrEmpty(text))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return string.Format((string) CodeGenerator.XnaKDUhDsNLG9ZLQH9No(~1767720452 ^ -1767782267), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113861895), (object) text);
label_5:
      return "";
    }

    /// <summary>Получить выражение в виде SR.T("text")</summary>
    /// <param name="text">Локализуемый текст</param>
    /// <returns>Выражение</returns>
    protected ISyntaxNode GetLocalizableExpression(string text, params object[] parameters)
    {
      int num1 = 1;
      string str;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!CodeGenerator.s5wJh3hDzPuYCwswKfmF((object) text))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 2:
              goto label_5;
            case 3:
              goto label_7;
            default:
              goto label_9;
          }
        }
label_5:
        str = text;
        if (str == null)
          num1 = 3;
        else
          goto label_8;
      }
label_7:
      str = "";
label_8:
      return str.CreateSyntaxNode();
label_9:
      object expression = CodeGenerator.c87lbOhtfjQiqNQMNXLB((object) TypeOf<EleWise.ELMA.SR>.Raw.CreateTypeSyntax(), CodeGenerator.XnaKDUhDsNLG9ZLQH9No(964881585 - -1459193222 ^ -1870724191));
      object first = CodeGenerator.jGIS4KhtE99gLIOpbwpc((object) text);
      object[] source = parameters;
      // ISSUE: reference to a compiler-generated field
      Func<object, ISyntaxNode> func = CodeGenerator.\u003C\u003Ec.\u003C\u003E9__27_0;
      Func<object, ISyntaxNode> selector;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        CodeGenerator.\u003C\u003Ec.\u003C\u003E9__27_0 = selector = (Func<object, ISyntaxNode>) (p => (ISyntaxNode) CodeGenerator.\u003C\u003Ec.IOOdFIvK0iib4QV8s3k4(p));
      }
      else
        goto label_10;
label_12:
      IEnumerable<ISyntaxNode> second = ((IEnumerable<object>) source).Select<object, ISyntaxNode>(selector);
      IEnumerable<ISyntaxNode> arguments = ((ISyntaxNode) first).Concat<ISyntaxNode>(second);
      return ((ISyntaxNode) expression).InvocationExpression(arguments);
label_10:
      selector = func;
      goto label_12;
    }

    /// <summary>Получить расширение для файла ресурса иконки</summary>
    /// <param name="image">Иконка</param>
    /// <param name="name">Имя иконки</param>
    /// <returns>Расширение для файла ресурса иконки</returns>
    protected string GetImageResourceExtension(MetadataImage image, string name = null)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            CodeGenerator.t2swWWhtQHtmwnLaOIZe((object) image, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479716392));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (string) CodeGenerator.pwqf3ihtuNe5mDqyyewd((object) new object[6]
      {
        !CodeGenerator.s5wJh3hDzPuYCwswKfmF(CodeGenerator.FbHb4DhtCqwBbnxBfqeJ((object) this.generationParams)) ? (object) ((string) CodeGenerator.XnaKDUhDsNLG9ZLQH9No(1319452732 ^ 1319459576) + (string) CodeGenerator.FbHb4DhtCqwBbnxBfqeJ((object) this.generationParams)) : (object) "",
        CodeGenerator.s5wJh3hDzPuYCwswKfmF((object) name) ? (object) "" : CodeGenerator.MTuIQChtv7RdlNbpQGSQ(CodeGenerator.XnaKDUhDsNLG9ZLQH9No(-1487388570 ^ -1487381854), (object) name),
        CodeGenerator.XnaKDUhDsNLG9ZLQH9No(-867826612 ^ -867863066),
        (object) CodeGenerator.KSxotnht8IK8cfXXvZUM((object) image),
        CodeGenerator.XnaKDUhDsNLG9ZLQH9No(-2099751081 ^ -2099753581),
        (object) CodeGenerator.GfKlUOhtZ2i6FrIxDehs((object) image)
      });
    }

    /// <summary>Получить имя для ресурсного файла иконки</summary>
    /// <param name="image">Иконка</param>
    /// <returns>Имя для ресурсного файла иконки</returns>
    protected string GetImageResourceName(MetadataImage image, string name = null)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            CodeGenerator.t2swWWhtQHtmwnLaOIZe((object) image, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222207714));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (string) CodeGenerator.g3beBEhtiLSQ0TWdorYc(CodeGenerator.caTt74htILxB9rg0wpr7((object) this.generationParams), CodeGenerator.XnaKDUhDsNLG9ZLQH9No(1470440286 ^ 1470445978), CodeGenerator.xCS6AIhtSxvfg9pKkr9q((object) Path.GetFileName((string) CodeGenerator.qkMVDghtVIGTlUa12qUB((object) this.generationParams))), (object) this.GetImageResourceExtension(image, name));
    }

    /// <summary>Получить метаданные по уникальному идентификатору</summary>
    /// <param name="uid">Уникальный идентификатор метаданных</param>
    /// <returns>Метаданные</returns>
    protected virtual IMetadata GetMetadata(Guid uid) => MetadataServiceContext.Service.GetMetadata(uid, false);

    /// <summary>
    /// Генерация самого быстрого создания Guid-а по заданному значению
    /// </summary>
    /// <param name="uid">Значение Guid</param>
    /// <returns>Сгенерированное выражение создания Guid</returns>
    protected static ISyntaxNode CreateGuid(Guid uid)
    {
      int num1 = 11;
      byte num2;
      byte num3;
      int num4;
      short num5;
      short num6;
      byte num7;
      byte num8;
      byte num9;
      byte num10;
      byte num11;
      byte num12;
      while (true)
      {
        int num13 = num1;
        byte[] byteArray;
        while (true)
        {
          switch (num13)
          {
            case 1:
              num3 = byteArray[8];
              num13 = 6;
              continue;
            case 2:
              goto label_5;
            case 3:
              num9 = byteArray[11];
              num13 = 12;
              continue;
            case 4:
              num12 = byteArray[15];
              num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 2;
              continue;
            case 5:
              num2 = byteArray[13];
              num13 = 7;
              continue;
            case 6:
              num7 = byteArray[9];
              num13 = 9;
              continue;
            case 7:
              num11 = byteArray[14];
              num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 4 : 3;
              continue;
            case 8:
              num5 = (short) (ushort) ((uint) byteArray[5] << 8 | (uint) byteArray[4]);
              num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
              continue;
            case 9:
              goto label_15;
            case 10:
              num4 = (int) byteArray[3] << 24 | (int) byteArray[2] << 16 | (int) byteArray[1] << 8 | (int) byteArray[0];
              num13 = 8;
              continue;
            case 11:
              goto label_12;
            case 12:
              num10 = byteArray[12];
              num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 5;
              continue;
            default:
              num6 = (short) (ushort) ((uint) byteArray[7] << 8 | (uint) byteArray[6]);
              num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 1;
              continue;
          }
        }
label_12:
        byteArray = uid.ToByteArray();
        num1 = 10;
        continue;
label_15:
        num8 = byteArray[10];
        num1 = 3;
      }
label_5:
      return ((ISyntaxNode) CodeGenerator.C6LPJlhtReeCRjJ94Ucw(TypeOf<Guid>.Raw)).ObjectCreationExpression((ISyntaxNode) CodeGenerator.jGIS4KhtE99gLIOpbwpc((object) num4), (ISyntaxNode) CodeGenerator.jGIS4KhtE99gLIOpbwpc((object) num5), (ISyntaxNode) CodeGenerator.jGIS4KhtE99gLIOpbwpc((object) num6), (ISyntaxNode) CodeGenerator.jGIS4KhtE99gLIOpbwpc((object) num3), num7.CreateSyntaxNode(), num8.CreateSyntaxNode(), num9.CreateSyntaxNode(), (ISyntaxNode) CodeGenerator.jGIS4KhtE99gLIOpbwpc((object) num10), (ISyntaxNode) CodeGenerator.jGIS4KhtE99gLIOpbwpc((object) num2), (ISyntaxNode) CodeGenerator.jGIS4KhtE99gLIOpbwpc((object) num11), (ISyntaxNode) CodeGenerator.jGIS4KhtE99gLIOpbwpc((object) num12));
    }

    private static void GetIntfMethodsRecursively(
      Type type,
      BindingFlags flags,
      HashSet<MethodInfo> methods)
    {
      MethodInfo[] methods1 = type.GetMethods(flags);
      methods.UnionWith((IEnumerable<MethodInfo>) methods1);
      foreach (Type type1 in type.GetInterfaces())
        CodeGenerator.GetIntfMethodsRecursively(type1, flags, methods);
    }

    protected CodeGenerator()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.generationParams = new GenerationParams();
      this.ignoreNamespaces = new List<string>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void kqOELshDYssuwPNau1pP([In] object obj0, [In] object obj1) => ((CodeGenerator) obj0).InitIgnoreNamespaces((IMetadata) obj1);

    internal static void rcWiOqhDL9kSGmJ2PSNF([In] object obj0, [In] object obj1) => ((CodeGenerator) obj0).InitInternal((IMetadata) obj1);

    internal static bool gIBR5whD5etgnVq9ZF86() => CodeGenerator.mPg6afhDgDF0Cm5lkRV0 == null;

    internal static CodeGenerator LOBEWkhDjHceTiPP5WRO() => CodeGenerator.mPg6afhDgDF0Cm5lkRV0;

    internal static void KMMSWEhDU5tGjX727tAH([In] object obj0) => ((List<string>) obj0).Clear();

    internal static object XnaKDUhDsNLG9ZLQH9No(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object KxLLsYhDcGprwbtfXGKX([In] object obj0) => (object) ((ICodeItemMetadata) obj0).Namespace;

    internal static bool s5wJh3hDzPuYCwswKfmF([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object siA45HhtFHFVnqmSaOgG([In] object obj0) => (object) ((NamedDocumentedMetadata) obj0).XmlComments;

    internal static object g3cTIhhtBUu5kriycyEO([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static object Hioph5htWHWeMTEb6ZCo([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object rAMD0phtoDNbJ1wPBUYX([In] object obj0) => (object) ((NamedMetadata) obj0).Description;

    internal static object B46JXBhtboiGUjy2ruan([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object f9BLvuhthtXwsQfWqWhL([In] object obj0) => (object) ((string) obj0).IdentifierName();

    internal static Guid euBsYahtG1nUKf0Z8cKM([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static object jGIS4KhtE99gLIOpbwpc([In] object obj0) => (object) obj0.CreateSyntaxNode();

    internal static object c87lbOhtfjQiqNQMNXLB([In] object obj0, [In] object obj1) => (object) ((ISyntaxNode) obj0).MemberAccessExpression((string) obj1);

    internal static void t2swWWhtQHtmwnLaOIZe([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object FbHb4DhtCqwBbnxBfqeJ([In] object obj0) => (object) ((GenerationParams) obj0).Prefix;

    internal static object MTuIQChtv7RdlNbpQGSQ([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static int KSxotnht8IK8cfXXvZUM([In] object obj0) => ((MetadataImage) obj0).Size;

    internal static ImageFormatType GfKlUOhtZ2i6FrIxDehs([In] object obj0) => ((MetadataImage) obj0).Format;

    internal static object pwqf3ihtuNe5mDqyyewd([In] object obj0) => (object) string.Concat((object[]) obj0);

    internal static object caTt74htILxB9rg0wpr7([In] object obj0) => (object) ((GenerationParams) obj0).Namespace;

    internal static object qkMVDghtVIGTlUa12qUB([In] object obj0) => (object) ((GenerationParams) obj0).FileName;

    internal static object xCS6AIhtSxvfg9pKkr9q([In] object obj0) => (object) Path.GetFileNameWithoutExtension((string) obj0);

    internal static object g3beBEhtiLSQ0TWdorYc(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }

    internal static object C6LPJlhtReeCRjJ94Ucw(Type type) => (object) type.CreateTypeSyntax();

    internal static object NCR66khtq2BX1pqaJScY([In] object obj0) => (object) ((CodeGenerator) obj0).GenerateMainFileInternal();
  }
}
