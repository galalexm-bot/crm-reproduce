// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.BaseFilePreviewCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;
using href.Utils;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Базовый создатель превьюшек</summary>
  public abstract class BaseFilePreviewCreator : IFilePreviewCreator, IMultiFilePreviewCreator
  {
    private IFilePreviewService filePreviewService;
    internal static BaseFilePreviewCreator jo47JkGPuud1oaBpqmI1;

    private IFilePreviewService FilePreviewService
    {
      get
      {
        int num = 2;
        IFilePreviewService serviceNotNull;
        IFilePreviewService filePreviewService;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.filePreviewService = serviceNotNull = Locator.GetServiceNotNull<IFilePreviewService>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            case 2:
              filePreviewService = this.filePreviewService;
              if (filePreviewService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return filePreviewService;
label_6:
        return serviceNotNull;
      }
    }

    /// <summary>Уникальный идентификатор</summary>
    public abstract Guid Uid { get; }

    /// <summary>Отображаемое имя</summary>
    public abstract string DisplayName { get; }

    /// <summary>Запущенное приложение</summary>
    public IRuntimeApplication RuntimeApplication
    {
      get => this.\u003CRuntimeApplication\u003Ek__BackingField;
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
              this.\u003CRuntimeApplication\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
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

    /// <summary>Работа с папкой предпросмотра файлов</summary>
    public IFolderPreviewService FolderPreviewService
    {
      get => this.\u003CFolderPreviewService\u003Ek__BackingField;
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
              this.\u003CFolderPreviewService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
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

    /// <summary>Папка с превьюшками</summary>
    public virtual string PreviewDir => (string) BaseFilePreviewCreator.LFajXVGPSYwNcR8ltppd((object) this.FolderPreviewService);

    /// <summary>Расширения файлов</summary>
    public abstract List<string> Extensions { get; }

    /// <summary>Создать превью</summary>
    /// <param name="path"></param>
    /// <param name="file"></param>
    public abstract void Create(string path, BinaryFile file);

    /// <summary>ОТносительный путь до главного файла (папка Preview)</summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public virtual string GetRelativeMainFileName(BinaryFile file) => (string) BaseFilePreviewCreator.dnBpfRGPiGshsBZsAV78(825385222 ^ 825330648);

    /// <summary>Имя текстового файла</summary>
    /// <param name="filePreviewDir"></param>
    /// <param name="file"></param>
    /// <returns></returns>
    public virtual string GetTextFileName(string filePreviewDir, BinaryFile file)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!Directory.Exists(filePreviewDir))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) null;
label_5:
      return Path.Combine(filePreviewDir, (string) BaseFilePreviewCreator.teivqtGPRb4DfAJ5X2NR((object) this, (object) file));
    }

    /// <summary>Имя текстового файла</summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public virtual string GetTextFileName(BinaryFile file)
    {
      int num = 1;
      string str;
      while (true)
      {
        Guid uid;
        string input;
        object obj;
        switch (num)
        {
          case 1:
            if (!BaseFilePreviewCreator.wZrSUJGPqFVSmn3Z2Lj8((object) this.PreviewDir))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            obj = (object) uid.ToString();
            break;
          case 3:
            goto label_3;
          case 4:
            uid = file.Uid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 2 : 2;
            continue;
          case 5:
            obj = BaseFilePreviewCreator.NHBDpHGPTdAv5Y8KgKJB((object) file);
            break;
          case 6:
            str = (string) BaseFilePreviewCreator.tFQjMJGPklsAOtl0tUQc((object) this.FolderPreviewService, Guid.Parse(input));
            num = 7;
            continue;
          case 7:
            goto label_2;
          default:
            if (BaseFilePreviewCreator.e6gEEFGPXbo0uBLSeJsw(BaseFilePreviewCreator.n6RPC6GPKHgW4ugI1lun((object) file), Guid.Empty))
            {
              num = 4;
              continue;
            }
            goto case 5;
        }
        input = (string) obj;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 6 : 5;
      }
label_2:
      return (string) BaseFilePreviewCreator.wtHtUfGPn6RR4buX2Isy((object) this, (object) str, (object) file);
label_3:
      return (string) null;
    }

    /// <summary>Имя главного файла</summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public virtual string GetMainFileName(string filePreviewDir, BinaryFile file) => (string) BaseFilePreviewCreator.wtHtUfGPn6RR4buX2Isy((object) this, (object) filePreviewDir, (object) file);

    /// <summary>Имя главного файла</summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public virtual string GetMainFileName(BinaryFile file) => (string) BaseFilePreviewCreator.W7d4AaGPOBf31K9gVjqM((object) this, (object) file);

    /// <summary>Доступен ли для использования</summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public virtual bool IsAvaliable(BinaryFile file)
    {
      int num = 3;
      PreviewSettingsModule service;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (service == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 3:
            service = Locator.GetService<PreviewSettingsModule>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 2 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_2:
      return BaseFilePreviewCreator.B8BWjkGP2ymAymAotdGt((object) service, (object) this);
label_3:
      return true;
    }

    /// <summary>Есть ли превью</summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public virtual bool HasPreview(BinaryFile file) => this.HasPreview(file, 5L);

    /// <summary>Имеется ли сгенерированая превью</summary>
    /// <param name="file"></param>
    /// <param name="priority"></param>
    /// <returns></returns>
    public virtual bool HasPreview(BinaryFile file, long priority)
    {
      int num = 8;
      while (true)
      {
        string mainFileName;
        switch (num)
        {
          case 1:
            goto label_14;
          case 2:
          case 6:
            goto label_10;
          case 3:
          case 5:
            if (BaseFilePreviewCreator.OdWmllGPeEflTeKjZfgT((object) file))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 6 : 3;
              continue;
            }
            goto case 9;
          case 4:
            BaseFilePreviewCreator.lrPRU0GP1pYwR809PeF7((object) this.FilePreviewService, (object) file, priority);
            num = 10;
            continue;
          case 7:
            if (BaseFilePreviewCreator.wZrSUJGPqFVSmn3Z2Lj8((object) mainFileName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 5;
              continue;
            }
            break;
          case 8:
            mainFileName = this.GetMainFileName(file);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 7 : 4;
            continue;
          case 9:
            if (BaseFilePreviewCreator.BryM3VGPPxfJvjlSj95F((object) this.FilePreviewService, (object) file, (object) null))
            {
              num = 4;
              continue;
            }
            goto label_10;
          case 10:
            goto label_5;
        }
        if (!File.Exists(mainFileName))
          num = 3;
        else if (!BaseFilePreviewCreator.nKqDpGGPNokGhqCxg8S2((object) mainFileName))
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 1;
        else
          goto label_15;
      }
label_5:
      return false;
label_10:
      return true;
label_14:
      return false;
label_15:
      return true;
    }

    /// <summary>Получить текст превью</summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public virtual string GetPreviewText(BinaryFile file)
    {
      int num1 = 11;
      string previewText;
      List<string>.Enumerator enumerator;
      while (true)
      {
        Guid uid;
        string path;
        string input;
        object obj;
        switch (num1)
        {
          case 1:
            uid = file.Uid;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 15 : 2;
            continue;
          case 2:
            if (new List<string>()
            {
              (string) BaseFilePreviewCreator.dnBpfRGPiGshsBZsAV78(-244066886 - -48452443 ^ -195763815),
              (string) BaseFilePreviewCreator.dnBpfRGPiGshsBZsAV78(-53329496 >> 4 ^ -3216256)
            }.Contains(Path.GetExtension(path)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 18 : 16;
              continue;
            }
            goto case 8;
          case 3:
            if (!BaseFilePreviewCreator.BryM3VGPPxfJvjlSj95F((object) this.FilePreviewService, (object) file, (object) null))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 12 : 14;
              continue;
            }
            goto case 13;
          case 4:
            goto label_10;
          case 5:
          case 6:
            if (file.Encrypt)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 7 : 16;
              continue;
            }
            goto case 3;
          case 7:
            goto label_35;
          case 8:
          case 9:
            previewText = File.ReadAllText(path);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 7 : 6;
            continue;
          case 10:
            if (BaseFilePreviewCreator.wZrSUJGPqFVSmn3Z2Lj8((object) path))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 6 : 0;
              continue;
            }
            goto case 17;
          case 11:
            path = (string) BaseFilePreviewCreator.W7d4AaGPOBf31K9gVjqM((object) this, (object) file);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 5 : 10;
            continue;
          case 12:
            enumerator = ((IEnumerable<string>) BaseFilePreviewCreator.GcOWxPGPp33Nq2LEGqtj(BaseFilePreviewCreator.tFQjMJGPklsAOtl0tUQc((object) this.FolderPreviewService, Guid.Parse(input)), BaseFilePreviewCreator.dnBpfRGPiGshsBZsAV78(1654249598 >> 2 ^ 413533877), SearchOption.AllDirectories)).Where<string>((Func<string, bool>) (s =>
            {
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (!BaseFilePreviewCreator.\u003C\u003Ec.IvFatEvz61ysiOPFZutd((object) s, BaseFilePreviewCreator.\u003C\u003Ec.vFu55jvz4QQnZ5iiQ712(322893104 - -1992822529 ^ -1979524003)))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_5;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    if (!s.EndsWith((string) BaseFilePreviewCreator.\u003C\u003Ec.vFu55jvz4QQnZ5iiQ712(-2106517564 ^ -2106400952)))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 1;
                      continue;
                    }
                    goto label_5;
                  default:
                    goto label_4;
                }
              }
label_4:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              return BaseFilePreviewCreator.\u003C\u003Ec.IvFatEvz61ysiOPFZutd((object) s, BaseFilePreviewCreator.\u003C\u003Ec.vFu55jvz4QQnZ5iiQ712(-643786247 ^ -643608221));
label_5:
              return true;
            })).ToList<string>().GetEnumerator();
            num1 = 4;
            continue;
          case 13:
            BaseFilePreviewCreator.lrPRU0GP1pYwR809PeF7((object) this.FilePreviewService, (object) file, 0L);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
            continue;
          case 15:
            obj = (object) uid.ToString();
            break;
          case 17:
            if (!BaseFilePreviewCreator.nKqDpGGPNokGhqCxg8S2((object) path))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 5;
              continue;
            }
            previewText = "";
            num1 = 20;
            continue;
          case 18:
            if (BaseFilePreviewCreator.e6gEEFGPXbo0uBLSeJsw(BaseFilePreviewCreator.n6RPC6GPKHgW4ugI1lun((object) file), Guid.Empty))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
              continue;
            }
            goto case 19;
          case 19:
            obj = BaseFilePreviewCreator.NHBDpHGPTdAv5Y8KgKJB((object) file);
            break;
          case 20:
            if (BaseFilePreviewCreator.vjdmXTGP3druX7HLeoOl((object) path))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 9 : 4;
              continue;
            }
            goto case 2;
          default:
            goto label_28;
        }
        input = (string) obj;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 3 : 12;
      }
label_10:
      try
      {
label_14:
        if (enumerator.MoveNext())
          goto label_17;
        else
          goto label_15;
label_11:
        string source;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_17;
            case 2:
              source = source.GetClearBodyFromHtml();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
              continue;
            case 3:
              previewText = (string) BaseFilePreviewCreator.bFDdWFGPDS3HxeSJGeGd((object) previewText, BaseFilePreviewCreator.dnBpfRGPiGshsBZsAV78(516838154 ^ 516823592), (object) source);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 2 : 5;
              continue;
            case 4:
              goto label_35;
            case 5:
              goto label_14;
            default:
              source = source.SanitizeHtml();
              num3 = 3;
              continue;
          }
        }
label_15:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 2 : 4;
        goto label_11;
label_17:
        source = (string) BaseFilePreviewCreator.UFn9fmGPaVoRwutf8lf0((object) enumerator.Current);
        num3 = 2;
        goto label_11;
      }
      finally
      {
        enumerator.Dispose();
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
label_28:
      throw new PreviewTextFileDoNotExistException();
label_35:
      return previewText;
    }

    /// <summary>Определить кодировку файла</summary>
    /// <param name="filename"></param>
    /// <returns></returns>
    protected virtual Encoding GetFileEncoding(string filename) => (Encoding) BaseFilePreviewCreator.uTYWiyGPwXeEY72MTyuL(BaseFilePreviewCreator.uwAH8SGPtp8GbkFDifp1((object) filename));

    /// <summary>Генериться превью в формате HTML</summary>
    /// <returns></returns>
    public virtual bool EnableGenerateHtml() => true;

    /// <inheritdoc />
    public IEnumerable<string> GetPreviewFilesList(BinaryFile file)
    {
      string textFileName = this.GetTextFileName(file);
      if (string.IsNullOrEmpty(textFileName) || !File.Exists(textFileName))
      {
        if (!file.Encrypt && this.FilePreviewService.CheckPassword(file, (string) null))
          this.FilePreviewService.AddPreviewWork(file, 0L);
        throw new PreviewTextFileDoNotExistException();
      }
      if (!string.IsNullOrWhiteSpace(textFileName))
      {
        if (new List<string>()
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289896730),
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108095356)
        }.Contains(Path.GetExtension(textFileName)))
          return (IEnumerable<string>) ((IEnumerable<string>) Directory.GetFiles(this.FolderPreviewService.GetPreviewDirectory(Guid.Parse(file.Uid != Guid.Empty ? file.Uid.ToString() : file.Id)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675485419), SearchOption.AllDirectories)).Where<string>((Func<string, bool>) (s =>
          {
            int num = 4;
            while (true)
            {
              switch (num)
              {
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  if (BaseFilePreviewCreator.\u003C\u003Ec.IvFatEvz61ysiOPFZutd((object) s, BaseFilePreviewCreator.\u003C\u003Ec.vFu55jvz4QQnZ5iiQ712(1819636893 << 3 ^ 1672379524)))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
                    continue;
                  }
                  goto label_2;
                case 2:
                  goto label_2;
                case 4:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  if (BaseFilePreviewCreator.\u003C\u003Ec.IvFatEvz61ysiOPFZutd((object) s, BaseFilePreviewCreator.\u003C\u003Ec.vFu55jvz4QQnZ5iiQ712(-812025778 ^ -811945790)))
                  {
                    num = 3;
                    continue;
                  }
                  goto case 1;
                default:
                  goto label_3;
              }
            }
label_2:
            // ISSUE: reference to a compiler-generated method
            return BaseFilePreviewCreator.\u003C\u003Ec.IvFatEvz61ysiOPFZutd((object) s, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574344906));
label_3:
            return true;
          })).ToList<string>();
      }
      return (IEnumerable<string>) new List<string>()
      {
        textFileName
      };
    }

    /// <inheritdoc />
    public long GetTextPreviewFilesSize(BinaryFile file)
    {
      int num1 = 2;
      long previewFilesSize;
      IEnumerator<string> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            IEnumerable<string> previewFilesList = this.GetPreviewFilesList(file);
            previewFilesSize = 0L;
            enumerator = previewFilesList.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return previewFilesSize;
label_4:
      try
      {
label_9:
        if (BaseFilePreviewCreator.MI4lGEGP42Sl2CqEoibr((object) enumerator))
          goto label_12;
        else
          goto label_10;
label_5:
        string current;
        FileInfo fileInfo;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              previewFilesSize += fileInfo.Length;
              num2 = 4;
              continue;
            case 2:
              fileInfo = new FileInfo(current);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 0;
              continue;
            case 3:
              goto label_12;
            case 4:
              goto label_9;
            case 5:
              if (BaseFilePreviewCreator.nKqDpGGPNokGhqCxg8S2((object) current))
              {
                num2 = 2;
                continue;
              }
              goto label_9;
            default:
              goto label_3;
          }
        }
label_10:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
        goto label_5;
label_12:
        current = enumerator.Current;
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
        {
          num2 = 5;
          goto label_5;
        }
        else
          goto label_5;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
        else
          goto label_17;
label_16:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_17:
        BaseFilePreviewCreator.UgaivGGP653HEsafxNS2((object) enumerator);
        num3 = 2;
        goto label_16;
      }
    }

    protected BaseFilePreviewCreator()
    {
      BaseFilePreviewCreator.itn6LSGPHRDiNLNkhiQ4();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool vEZ4omGPITsm3KaJrw35() => BaseFilePreviewCreator.jo47JkGPuud1oaBpqmI1 == null;

    internal static BaseFilePreviewCreator gutnrGGPVhHBOmEdl0uK() => BaseFilePreviewCreator.jo47JkGPuud1oaBpqmI1;

    internal static object LFajXVGPSYwNcR8ltppd([In] object obj0) => (object) ((IFolderPreviewService) obj0).PreviewsPath;

    internal static object dnBpfRGPiGshsBZsAV78(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object teivqtGPRb4DfAJ5X2NR([In] object obj0, [In] object obj1) => (object) ((BaseFilePreviewCreator) obj0).GetRelativeMainFileName((BinaryFile) obj1);

    internal static bool wZrSUJGPqFVSmn3Z2Lj8([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static Guid n6RPC6GPKHgW4ugI1lun([In] object obj0) => ((BinaryFile) obj0).Uid;

    internal static bool e6gEEFGPXbo0uBLSeJsw([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object NHBDpHGPTdAv5Y8KgKJB([In] object obj0) => (object) ((BinaryFile) obj0).Id;

    internal static object tFQjMJGPklsAOtl0tUQc([In] object obj0, Guid id) => (object) ((IFolderPreviewService) obj0).GetPreviewDirectory(id);

    internal static object wtHtUfGPn6RR4buX2Isy([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((BaseFilePreviewCreator) obj0).GetTextFileName((string) obj1, (BinaryFile) obj2);

    internal static object W7d4AaGPOBf31K9gVjqM([In] object obj0, [In] object obj1) => (object) ((BaseFilePreviewCreator) obj0).GetTextFileName((BinaryFile) obj1);

    internal static bool B8BWjkGP2ymAymAotdGt([In] object obj0, [In] object obj1) => ((PreviewSettingsModule) obj0).IsEnabledPreview((IFilePreviewCreator) obj1);

    internal static bool OdWmllGPeEflTeKjZfgT([In] object obj0) => ((BinaryFile) obj0).Encrypt;

    internal static bool BryM3VGPPxfJvjlSj95F([In] object obj0, [In] object obj1, [In] object obj2) => ((IFilePreviewService) obj0).CheckPassword((BinaryFile) obj1, (string) obj2);

    internal static void lrPRU0GP1pYwR809PeF7([In] object obj0, [In] object obj1, long priority) => ((IFilePreviewService) obj0).AddPreviewWork((BinaryFile) obj1, priority);

    internal static bool nKqDpGGPNokGhqCxg8S2([In] object obj0) => File.Exists((string) obj0);

    internal static bool vjdmXTGP3druX7HLeoOl([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object GcOWxPGPp33Nq2LEGqtj([In] object obj0, [In] object obj1, [In] SearchOption obj2) => (object) Directory.GetFiles((string) obj0, (string) obj1, obj2);

    internal static object UFn9fmGPaVoRwutf8lf0([In] object obj0) => (object) File.ReadAllText((string) obj0);

    internal static object bFDdWFGPDS3HxeSJGeGd([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object uwAH8SGPtp8GbkFDifp1([In] object obj0) => (object) File.ReadAllBytes((string) obj0);

    internal static object uTYWiyGPwXeEY72MTyuL([In] object obj0) => (object) EncodingTools.DetectInputCodepage((byte[]) obj0);

    internal static bool MI4lGEGP42Sl2CqEoibr([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void UgaivGGP653HEsafxNS2([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void itn6LSGPHRDiNLNkhiQ4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
