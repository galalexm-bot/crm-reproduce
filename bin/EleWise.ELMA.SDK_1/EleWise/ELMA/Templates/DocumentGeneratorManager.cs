// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.DocumentGeneratorManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Templates.TemplateGenerator;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Templates
{
  /// <summary>Сервис генерации документов</summary>
  /// <example>
  /// <para>
  /// <seealso href="http://www.elma-bpm.ru/kb/article-393.html">Двойная генерация по шаблону</seealso>
  /// </para>
  /// <code>
  /// //Пример кода взят из статьи в базе знаний, посвящённой двойной генерации документа
  /// <![CDATA[
  /// var version = InterfaceActivator.Create<DocumentVersion>();
  /// version.Document = context.Dokument;
  /// var versionFile = Locator.GetServiceNotNull<IDocumentFileManager>().GetFileByDocumentId(context.Dokument.Id);
  /// var file = Locator.GetServiceNotNull<ITemplateFileManager>().CreateFromTemplate(versionFile.Id);
  /// 
  /// //Вариант 1:
  /// // Создаем генератор
  /// var generator = Locator.GetServiceNotNull<DocumentGeneratorManager>().Create(file);
  /// // Генерируем документ
  /// generator.Generate(context);
  /// 
  /// //Вариант 2:
  /// //Сразу генерируем документ
  /// Locator.GetServiceNotNull<DocumentGeneratorManager>().Generate(file, context);
  /// 
  /// // Сохраняем файл сгенерированного документа
  /// Locator.GetServiceNotNull<IFileManager>().SaveFile(file);
  /// // Записываем результат в переменную
  /// version.File=file;
  /// version.Name = "версия из генерации";
  /// //устанавливаем статус версии Текущая
  /// version.Status = DocumentVersionStatus.Current;
  /// version.File.Name="имя файла2.rtf";
  /// context.Dokument.Versions.Add(version);
  /// context.Dokument.Save();
  /// ]]>
  /// </code>
  /// </example>
  [Service]
  [PublicApiMember("DocumentGeneratorServicesApi", "SR.M('Сервис генерации документов')", "SR.M('\r\n    /// <para>\r\n    /// <seealso href=\"http://www.elma-bpm.ru/kb/article-393.html\">Двойная генерация по шаблону</seealso>    \r\n    /// </para>\r\n    /// <code>\r\n    /// //Пример кода взят из статьи в базе знаний, посвящённой двойной генерации документа\r\n    /// <![CDATA[\r\n    /// var version = InterfaceActivator.Create<DocumentVersion>();\r\n    /// version.Document = context.Dokument;\r\n    /// var versionFile = Locator.GetServiceNotNull<IDocumentFileManager>().GetFileByDocumentId(context.Dokument.Id); \r\n    /// var file = Locator.GetServiceNotNull<ITemplateFileManager>().CreateFromTemplate(versionFile.Id); \r\n    /// // Создаем генератор \r\n    /// var generator = PublicAPI.Services.DocumentGenerator.Create(file);\r\n    /// // Генерируем документ \r\n    /// generator.Generate(context); \r\n    /// // Сохраняем файл сгенерированного документа \r\n    /// Locator.GetServiceNotNull<IFileManager>().SaveFile(file); \r\n    /// // Записываем результат в переменную \r\n    /// version.File=file;\r\n    /// version.Name = \"версия из генерации\";\r\n    /// //устанавливаем статус версии Текущая\r\n    /// version.Status = DocumentVersionStatus.Current;\r\n    /// version.File.Name=\"имя файла2.rtf\";\r\n    /// context.Dokument.Versions.Add(version);\r\n    /// context.Dokument.Save();\r\n    /// ]]>\r\n    /// </code>')")]
  [DeveloperApi(DeveloperApiType.Service)]
  public class DocumentGeneratorManager
  {
    internal static DocumentGeneratorManager yfw6ukBPxqn5jH1Sqgl5;

    /// <summary>Создать генератор документов</summary>
    /// <param name="templateFileName">Полное имя файла шаблона</param>
    /// <param name="provider">Провайдер генерации (по умолчанию используется ElmaGeneratorProvider)</param>
    public virtual DocumentGeneratorBase Create(
      string templateFileName,
      IGeneratorProvider provider = null)
    {
      int num1 = 4;
      IDocumentGeneratorProvider generatorProvider;
      string ext;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (generatorProvider != null)
            {
              num1 = 2;
              continue;
            }
            goto label_10;
          case 2:
            goto label_11;
          case 3:
            if (!DocumentGeneratorManager.E7IvFSBPyurThUBAYJZo((object) templateFileName))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 4:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 3 : 1;
            continue;
          case 5:
            goto label_2;
          case 6:
            goto label_10;
          case 7:
            generatorProvider = ((ComponentManager) DocumentGeneratorManager.DTBwLCBPdgky5kQ6111f()).GetExtensionPoints<IDocumentGeneratorProvider>().FirstOrDefault<IDocumentGeneratorProvider>((Func<IDocumentGeneratorProvider, bool>) (p =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (DocumentGeneratorManager.\u003C\u003Ec__DisplayClass0_0.xdRN23Qq4NukUNrFH9vr((object) p) != null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_5;
                  default:
                    goto label_4;
                }
              }
label_4:
              return ((IEnumerable<string>) p.SupportedExtensions).Select<string, string>((Func<string, string>) (e => e.ToUpper())).Contains<string>(ext);
label_5:
              return false;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 1;
            continue;
          default:
            ext = (string) DocumentGeneratorManager.NeM9ANBP96VBmLYOfA95(DocumentGeneratorManager.YyirXYBPJ66lCkSTTMaU((object) templateFileName));
            num1 = 7;
            continue;
        }
      }
label_2:
      throw new ArgumentNullException((string) DocumentGeneratorManager.TrFpUVBPMDMdtP3DOXBx(-1204263869 ^ -1341583247 ^ 137382802));
label_10:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) DocumentGeneratorManager.TrFpUVBPMDMdtP3DOXBx(-2138160520 ^ -2138079812), (object) ext));
label_11:
      return generatorProvider.Create(templateFileName, provider ?? (IGeneratorProvider) new ElmaGeneratorProvider());
    }

    /// <summary>Создать генератор документов</summary>
    /// <param name="templateFileStream">Полное имя файла шаблона</param>
    /// <param name="fileName">Имя файла с расширением</param>
    /// <param name="provider">Провайдер генерации (по умолчанию используется ElmaGeneratorProvider)</param>
    public virtual DocumentGeneratorBase Create(
      Stream templateFileStream,
      string fileName,
      IGeneratorProvider provider = null)
    {
      int num1 = 6;
      IDocumentGeneratorProviderExtension providerExtension1;
      string ext;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (providerExtension1 == null)
            {
              num1 = 2;
              continue;
            }
            goto label_10;
          case 2:
            goto label_9;
          case 3:
            providerExtension1 = ((ComponentManager) DocumentGeneratorManager.DTBwLCBPdgky5kQ6111f()).GetExtensionPoints<IDocumentGeneratorProviderExtension>().FirstOrDefault<IDocumentGeneratorProviderExtension>((Func<IDocumentGeneratorProviderExtension, bool>) (p =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (DocumentGeneratorManager.\u003C\u003Ec__DisplayClass1_0.xqEpvmQqdXRvXYAAHy2d((object) p) == null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
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
              // ISSUE: reference to a compiler-generated method
              return ((IEnumerable<string>) DocumentGeneratorManager.\u003C\u003Ec__DisplayClass1_0.xqEpvmQqdXRvXYAAHy2d((object) p)).Select<string, string>((Func<string, string>) (e => e.ToUpper())).Contains<string>(ext);
label_5:
              return false;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 1;
            continue;
          case 4:
            ext = (string) DocumentGeneratorManager.NeM9ANBP96VBmLYOfA95(DocumentGeneratorManager.YyirXYBPJ66lCkSTTMaU((object) fileName));
            num1 = 3;
            continue;
          case 5:
            Contract.ArgumentNotNull((object) templateFileStream, (string) DocumentGeneratorManager.TrFpUVBPMDMdtP3DOXBx(-1822890472 ^ -1822841264));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
            continue;
          case 6:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 5 : 2;
            continue;
          default:
            DocumentGeneratorManager.t6a1UxBPlJP5WuADRHsd((object) fileName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178235174));
            num1 = 4;
            continue;
        }
      }
label_9:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) DocumentGeneratorManager.TrFpUVBPMDMdtP3DOXBx(1581325282 << 3 ^ -234233644), (object) ext));
label_10:
      IDocumentGeneratorProviderExtension providerExtension2 = providerExtension1;
      Stream templateFileStream1 = templateFileStream;
      IGeneratorProvider generatorProvider = provider;
      IGeneratorProvider provider1 = generatorProvider == null ? (IGeneratorProvider) new ElmaGeneratorProvider() : generatorProvider;
      return providerExtension2.Create(templateFileStream1, provider1);
    }

    /// <summary>Сгенерировать документ</summary>
    /// <param name="file">Файл</param>
    [PublicApiNodeId("DocumentGeneratorServicesApi")]
    public virtual void Generate(BinaryFile file, object dataSource)
    {
      int num1 = 2;
      string templateLocally;
      DocumentGeneratorBase documentGeneratorBase;
      while (true)
      {
        switch (num1)
        {
          case 1:
            documentGeneratorBase = this.Create(templateLocally);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 5;
            continue;
          case 2:
            templateLocally = this.GetTemplateLocally(file);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_4;
          case 4:
            if (documentGeneratorBase.LastExceptions == null)
            {
              num1 = 7;
              continue;
            }
            goto case 6;
          case 5:
            DocumentGeneratorManager.GqpFvnBPrCnKQH4MMLNE((object) documentGeneratorBase, dataSource);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 4 : 2;
            continue;
          case 6:
            documentGeneratorBase.LastExceptions.Each<Exception>((Action<Exception>) (ex =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ((ILogger) DocumentGeneratorManager.\u003C\u003Ec.VxMntZQqxq6t3iFe2afx()).Error(DocumentGeneratorManager.\u003C\u003Ec.qF6shiQq0sXAVYfejj4F((object) ex), ex);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
            continue;
          default:
            this.UpdateBinaryFile(file, templateLocally);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 3;
            continue;
        }
      }
label_4:;
    }

    /// <summary>Сгенерировать документ</summary>
    /// <param name="file">Файл</param>
    /// <param name="dataSource">Объект данных</param>
    /// <param name="provider">Провайдер генерации</param>
    [PublicApiNodeId("DocumentGeneratorServicesApi")]
    public virtual void Generate(BinaryFile file, object dataSource, IGeneratorProvider provider)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        string templateLocally;
        DocumentGeneratorBase documentGeneratorBase;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (documentGeneratorBase.LastExceptions == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 5;
                continue;
              }
              goto case 6;
            case 2:
              documentGeneratorBase = this.Create(templateLocally, provider);
              num2 = 7;
              continue;
            case 3:
              goto label_4;
            case 4:
              goto label_10;
            case 6:
              ICollection<Exception> lastExceptions = documentGeneratorBase.LastExceptions;
              // ISSUE: reference to a compiler-generated field
              Action<Exception> action1 = DocumentGeneratorManager.\u003C\u003Ec.\u003C\u003E9__3_0;
              Action<Exception> action2;
              if (action1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                DocumentGeneratorManager.\u003C\u003Ec.\u003C\u003E9__3_0 = action2 = (Action<Exception>) (ex =>
                {
                  int num3 = 1;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 0:
                        goto label_2;
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        DocumentGeneratorManager.\u003C\u003Ec.HV0Q65QqmXYmPRD2diNR((object) Logger.Log, DocumentGeneratorManager.\u003C\u003Ec.qF6shiQq0sXAVYfejj4F((object) ex), (object) ex);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_2:
                  return;
label_4:;
                });
              }
              else
                goto label_13;
label_12:
              lastExceptions.Each<Exception>(action2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
label_13:
              action2 = action1;
              goto label_12;
            case 7:
              DocumentGeneratorManager.GqpFvnBPrCnKQH4MMLNE((object) documentGeneratorBase, dataSource);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 1;
              continue;
            default:
              this.UpdateBinaryFile(file, templateLocally);
              num2 = 4;
              continue;
          }
        }
label_4:
        templateLocally = this.GetTemplateLocally(file);
        num1 = 2;
      }
label_10:;
    }

    private string GetTemplateLocally(BinaryFile file)
    {
      int num = 2;
      string templateLocally;
      while (true)
      {
        switch (num)
        {
          case 1:
            DocumentGeneratorManager.MQg1GiBPji2dZkax6LZp((object) file, (object) templateLocally);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
            continue;
          case 2:
            templateLocally = (string) DocumentGeneratorManager.TSnYh5BP5Hu6ZhYUdUHV(DocumentGeneratorManager.f6rOElBPgQB8I9jJhwGE((object) file));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return templateLocally;
    }

    private void UpdateBinaryFile(BinaryFile file, string contentFilePath)
    {
      int num1 = 1;
      FileStream content;
      while (true)
      {
        switch (num1)
        {
          case 1:
            content = new FileStream(contentFilePath, FileMode.Open, FileAccess.Read);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_12;
          case 3:
label_2:
            DocumentGeneratorManager.gMrknGBPLf8ktdncTTLf((object) contentFilePath);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 2 : 1;
            continue;
          default:
            try
            {
              ((IBinaryFileStreams) DocumentGeneratorManager.Ps0BsCBPY2OmAJ1wIU8v()).PutContent(file, (Stream) content);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_2;
              }
            }
            finally
            {
              int num3;
              if (content == null)
                num3 = 2;
              else
                goto label_10;
label_9:
              switch (num3)
              {
                case 1:
                  break;
                default:
              }
label_10:
              content.Dispose();
              num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
              {
                num3 = 0;
                goto label_9;
              }
              else
                goto label_9;
            }
        }
      }
label_12:;
    }

    /// <summary>Сгенерировать файл по шаблону.</summary>
    /// <param name="templateFile">Шаблон.</param>
    /// <param name="dataSource">Объект данных.</param>
    /// <returns>Сгенерированный по шаблону файл.</returns>
    [PublicApiNodeId("DocumentGeneratorServicesApi")]
    public virtual BinaryFile GenerateToBinaryFile(BinaryFile templateFile, object dataSource)
    {
      int num1 = 2;
      string templateLocally;
      while (true)
      {
        int num2 = num1;
        DocumentGeneratorBase documentGeneratorBase;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              templateLocally = this.GetTemplateLocally(templateFile);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 1;
              continue;
            case 3:
              goto label_8;
            case 4:
              if (documentGeneratorBase.LastExceptions != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
                continue;
              }
              goto label_8;
            case 5:
              DocumentGeneratorManager.GqpFvnBPrCnKQH4MMLNE((object) documentGeneratorBase, dataSource);
              num2 = 4;
              continue;
            default:
              ICollection<Exception> lastExceptions = documentGeneratorBase.LastExceptions;
              // ISSUE: reference to a compiler-generated field
              Action<Exception> action1 = DocumentGeneratorManager.\u003C\u003Ec.\u003C\u003E9__6_0;
              Action<Exception> action2;
              if (action1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                DocumentGeneratorManager.\u003C\u003Ec.\u003C\u003E9__6_0 = action2 = (Action<Exception>) (ex =>
                {
                  int num3 = 1;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 0:
                        goto label_2;
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        DocumentGeneratorManager.\u003C\u003Ec.HV0Q65QqmXYmPRD2diNR(DocumentGeneratorManager.\u003C\u003Ec.VxMntZQqxq6t3iFe2afx(), DocumentGeneratorManager.\u003C\u003Ec.qF6shiQq0sXAVYfejj4F((object) ex), (object) ex);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_2:
                  return;
label_4:;
                });
              }
              else
                goto label_3;
label_12:
              lastExceptions.Each<Exception>(action2);
              num2 = 3;
              continue;
label_3:
              action2 = action1;
              goto label_12;
          }
        }
label_4:
        documentGeneratorBase = this.Create(templateLocally);
        num1 = 5;
      }
label_8:
      return ((BinaryFileBuilder) DocumentGeneratorManager.Lj2t3OBPUxIljxLG4vGi((object) templateFile)).Content(templateLocally, true).Build();
    }

    public DocumentGeneratorManager()
    {
      DocumentGeneratorManager.UrISpVBPskqyLjoQ7UZH();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool E7IvFSBPyurThUBAYJZo([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object TrFpUVBPMDMdtP3DOXBx(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object YyirXYBPJ66lCkSTTMaU([In] object obj0) => (object) Path.GetExtension((string) obj0);

    internal static object NeM9ANBP96VBmLYOfA95([In] object obj0) => (object) ((string) obj0).ToUpper();

    internal static object DTBwLCBPdgky5kQ6111f() => (object) ComponentManager.Current;

    internal static bool XnFFlcBP0u6OS79wHvIh() => DocumentGeneratorManager.yfw6ukBPxqn5jH1Sqgl5 == null;

    internal static DocumentGeneratorManager WGOl9FBPmMvMUcldHEkA() => DocumentGeneratorManager.yfw6ukBPxqn5jH1Sqgl5;

    internal static void t6a1UxBPlJP5WuADRHsd([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static void GqpFvnBPrCnKQH4MMLNE([In] object obj0, [In] object obj1) => ((DocumentGeneratorBase) obj0).Generate(obj1);

    internal static object f6rOElBPgQB8I9jJhwGE([In] object obj0) => (object) ((BinaryFile) obj0).Extension;

    internal static object TSnYh5BP5Hu6ZhYUdUHV([In] object obj0) => (object) IOExtensions.GetTempFileName((string) obj0);

    internal static void MQg1GiBPji2dZkax6LZp([In] object obj0, [In] object obj1) => ((BinaryFile) obj0).SaveToLocalPath((string) obj1);

    internal static object Ps0BsCBPY2OmAJ1wIU8v() => (object) DataAccessManager.BinaryFileStreams;

    internal static void gMrknGBPLf8ktdncTTLf([In] object obj0) => File.Delete((string) obj0);

    internal static object Lj2t3OBPUxIljxLG4vGi([In] object obj0) => (object) BinaryFile.CreateFrom((BinaryFile) obj0);

    internal static void UrISpVBPskqyLjoQ7UZH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
