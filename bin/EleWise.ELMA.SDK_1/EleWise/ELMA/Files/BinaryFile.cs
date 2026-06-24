// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.BinaryFile
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Files
{
  /// <summary>Файл.</summary>
  /// <remarks>
  /// Применяется в сценариях и при создании файлов сервером. Как правило, содержит несохранённый контент.
  /// </remarks>
  [Serializable]
  public class BinaryFile : ICloneable
  {
    private uint? contentCrc;
    private long? contentLength;
    private static IBinaryFileLegacyBehaviorProvider binaryFileLegacyBehaviorProvider;
    private string extension;
    [OptionalField]
    private string secondId;
    [OptionalField]
    private string salt;
    [OptionalField]
    private bool encrypt;
    private Guid uid;
    protected string name;
    private static BinaryFile bncyCBGkJYbSGNq53DEJ;

    private static IBinaryFileLegacyBehaviorProvider BinaryFileLegacyBehaviorProvider
    {
      get
      {
        int num = 1;
        IBinaryFileLegacyBehaviorProvider behaviorProvider;
        while (true)
        {
          switch (num)
          {
            case 1:
              behaviorProvider = BinaryFile.binaryFileLegacyBehaviorProvider;
              if (behaviorProvider == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return behaviorProvider;
label_5:
        return BinaryFile.binaryFileLegacyBehaviorProvider = Locator.GetServiceNotNull<IBinaryFileLegacyBehaviorProvider>();
      }
    }

    /// <summary>Ctor</summary>
    public BinaryFile()
    {
      BinaryFile.sggpSvGklnsbvuyKaQ47();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.uid = Guid.Empty;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Ctor</summary>
    /// <param name="contentFilePath">Путь к контенту на локальной файловой системе.</param>
    public BinaryFile(string contentFilePath)
    {
      BinaryFile.sggpSvGklnsbvuyKaQ47();
      // ISSUE: explicit constructor call
      this.\u002Ector(contentFilePath, false);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="contentFilePath">Путь к контенту на локальной файловой системе.</param>
    /// <param name="deleteAfterSave">Флаг удаления файла контента после сохранения (если нужно удалить временный файл).</param>
    public BinaryFile(string contentFilePath, bool deleteAfterSave)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
        num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.contentCrc = new uint?(BinaryFile.CrTHGIGk5QyhimKBHORY((object) contentFilePath));
            num = 4;
            continue;
          case 2:
            this.contentLength = new long?(BinaryFile.rcM9yaGkgm7i8F5xQEL3((object) new FileInfo(contentFilePath)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
            continue;
          case 3:
            this.ContentLocation = new Uri(contentFilePath);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
            continue;
          case 4:
            goto label_3;
          default:
            BinaryFile.NjLHN2GkrH87GEx6JOZg((object) this, deleteAfterSave);
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Идентификатор</summary>
    public string Id
    {
      get => this.\u003CId\u003Ek__BackingField;
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
              this.\u003CId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
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

    /// <summary>Если есть второй Id у файла (например Id из БД)</summary>
    public virtual string SecondId
    {
      get => this.secondId;
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
              this.secondId = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор</summary>
    public virtual Guid Uid
    {
      get => this.uid;
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
              this.uid = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
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

    /// <summary>Соль для шифрования</summary>
    public virtual string Salt
    {
      get => this.salt;
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
              this.salt = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
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

    /// <summary>Зашифрован</summary>
    public virtual bool Encrypt
    {
      get => this.encrypt;
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
              this.encrypt = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
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

    /// <summary>Имя файла</summary>
    public virtual string Name
    {
      get => this.name;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (BinaryFile.GmswjgGkjyNfDaLMPrQ9((object) this.name, (object) value))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 2:
              goto label_2;
            default:
              BinaryFile.FhMFQ1GkYyptP8QC45Fr((object) this, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 2;
              continue;
          }
        }
label_2:
        return;
label_6:;
      }
    }

    /// <summary>Mime-type файла</summary>
    public virtual string ContentType
    {
      get => this.\u003CContentType\u003Ek__BackingField;
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
              this.\u003CContentType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
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

    /// <summary>Локальный путь до файла</summary>
    [Obsolete("Свойство устарело. Для доступа к контенту используйте BinaryFile.GetContent(). Для установки контента рекомендуется создать новый файл через BinaryFile.CreateNew() или BinaryFile.CreateFrom().")]
    public virtual string ContentFilePath
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (BinaryFile.G06u02GkL6XcV2Ou8R2E((object) this.ContentLocation, (object) null))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return (string) null;
label_3:
        return (string) BinaryFile.ODsIBfGksmA2xE3KFR5l(BinaryFile.c3YU3DGkUUjAigFkmUxy((object) this));
      }
      set
      {
        int num = 7;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.SetContentFilePath(value);
              num = 3;
              continue;
            case 2:
              goto label_8;
            case 3:
            case 5:
              BinaryFile.NjLHN2GkrH87GEx6JOZg((object) this, false);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 2;
              continue;
            case 4:
            case 6:
              BinaryFile.odWmfFGkzSGPE3B1LvBh((object) this, (object) null);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 8 : 1;
              continue;
            case 7:
              if (BinaryFile.xCLl9CGkcMmjLxfeRIA1((object) value))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 6 : 4;
                continue;
              }
              goto case 1;
            case 8:
              this.contentCrc = new uint?(0U);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            default:
              this.contentLength = new long?(0L);
              num = 5;
              continue;
          }
        }
label_8:;
      }
    }

    /// <summary>Дата создания файла</summary>
    public virtual DateTime CreateDate
    {
      get => this.\u003CCreateDate\u003Ek__BackingField;
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
              this.\u003CCreateDate\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
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

    /// <summary>Удалить временный файл после сохраения в базу</summary>
    public virtual bool DeleteTempFileAfterSave
    {
      get => this.\u003CDeleteTempFileAfterSave\u003Ek__BackingField;
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
              this.\u003CDeleteTempFileAfterSave\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
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

    /// <summary>
    /// Местоположение контента (всегда указывает на источник).
    /// </summary>
    public virtual Uri ContentLocation
    {
      get => this.\u003CContentLocation\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CContentLocation\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
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

    /// <summary>
    /// Инициализировать свойство ContentFilePath (присваивается путь во временной папке). Учитывается расширение файла из свойства Name. Если Name пустое, то расширение .TMP
    /// </summary>
    [Obsolete("Свойство устарело. Для доступа к контенту используйте BinaryFile.GetContent(). Для установки контента рекомендуется создать новый файл через BinaryFile.CreateNew() или BinaryFile.CreateFrom().")]
    public virtual void InitializeContentFilePath()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            BinaryFile.odWmfFGkzSGPE3B1LvBh((object) this, (object) ((IBinaryFileLegacyBehaviorProvider) BinaryFile.I2X3b2GnFtBx7teSN05y()).InitializeContentLocation(this));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            BinaryFile.NjLHN2GkrH87GEx6JOZg((object) this, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>
    /// Сгенерировать значение для свойства ContentFilePath (путь во временной папке). Учитывается расширение файла из параметра <paramref name="originalFileName" />. Если оно пустое, то устанавливается расширение .TMP
    /// </summary>
    /// <param name="originalFileName">Оригинальное имя файла</param>
    public static string CreateContentFilePath(string originalFileName)
    {
      int num1 = 5;
      string str1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          string str2;
          switch (num2)
          {
            case 1:
              str1 = (string) BinaryFile.vpwiZkGnBYFpZEBm7fN7(-1290212282 ^ -644262414 ^ 1786829410);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 3 : 3;
              continue;
            case 2:
              if (!string.IsNullOrEmpty(str1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            case 4:
              str2 = (string) null;
              break;
            case 5:
              if (!BinaryFile.xCLl9CGkcMmjLxfeRIA1((object) originalFileName))
              {
                str2 = Path.GetExtension(originalFileName.ReplaceInvalidFileNameChars());
                break;
              }
              goto label_8;
            default:
              goto label_6;
          }
          str1 = str2;
          num2 = 2;
        }
label_8:
        num1 = 4;
      }
label_6:
      return (string) BinaryFile.CNuaarGnWXFCfZ6FDYml((object) str1);
    }

    /// <summary>
    /// Установить в BinaryFile контент из указанного местоположения.
    /// </summary>
    /// <param name="contentFilePath">Местоположение контента.</param>
    /// <param name="deleteTempFileAfterSave">Флаг, удалять ли исходный контент после сохранения BinaryFile.</param>
    [Obsolete("Метод устарел. Для передачи контента в BinaryFile используйте метод IBinaryFileStreams.PutContent().", true)]
    public virtual void SetContentFilePath(string contentFilePath, bool deleteTempFileAfterSave = false)
    {
      int num1 = 1;
      FileStream content;
      while (true)
      {
        switch (num1)
        {
          case 1:
            content = new FileStream(contentFilePath, FileMode.Open, FileAccess.Read);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_11;
          default:
            goto label_2;
        }
      }
label_11:
      return;
label_2:
      try
      {
        ((IBinaryFileStreams) BinaryFile.zeUfELGnoUuQF5WIFPEn()).PutContent(this, (Stream) content, PutContentOptions.Default);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            default:
              BinaryFile.NjLHN2GkrH87GEx6JOZg((object) this, deleteTempFileAfterSave);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
              continue;
          }
        }
label_10:;
      }
      finally
      {
        int num3;
        if (content == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
        else
          goto label_12;
label_9:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_12:
        BinaryFile.D0Al7qGnbr5TK0BwkvEr((object) content);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
        {
          num3 = 1;
          goto label_9;
        }
        else
          goto label_9;
      }
    }

    /// <summary>Создать BinaryFile из шаблона.</summary>
    /// <remarks>
    /// Атрибуты, которые будут скопированы с шаблона: ContentType, Name, Salt, Encrypt.
    /// Атрибуты, которым будут установлены новые значения: CreateDate, Uid.
    /// Атрибуты, которые не копируются: Id, ContentLocation, ContentFilePath, SecondId.
    /// </remarks>
    /// <param name="templateFile">BinaryFile-шаблон.</param>
    /// <returns>Построитель BinaryFile-ов.</returns>
    public static BinaryFileBuilder CreateFrom(BinaryFile templateFile) => new BinaryFileBuilder(templateFile);

    /// <summary>Создать новый BinaryFile.</summary>
    /// <returns>Построитель BinaryFile-ов.</returns>
    public static BinaryFileBuilder CreateNew() => new BinaryFileBuilder();

    /// <summary>
    /// Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />.
    /// </summary>
    /// <returns>
    /// true if the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />; otherwise, false.
    /// </returns>
    /// <param name="obj">The <see cref="T:System.Object" /> to compare with the current <see cref="T:System.Object" />. </param>
    /// <filterpriority>2</filterpriority>
    public override bool Equals(object obj)
    {
      int num = 10;
      Guid? nullable1;
      Guid? nullable2;
      while (true)
      {
        Guid? nullable3;
        BinaryFile binaryFile;
        Guid? nullable4;
        Guid? nullable5;
        switch (num)
        {
          case 1:
            if (nullable1.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
              continue;
            }
            goto label_14;
          case 2:
            goto label_15;
          case 3:
            goto label_9;
          case 4:
            if (!BinaryFile.KiveHhGnhLJpqekh3CnX((object) this))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 5 : 5;
              continue;
            }
            nullable4 = new Guid?(BinaryFile.GIJ1nBGnG91klSo60Rra((object) this));
            break;
          case 5:
            nullable3 = new Guid?();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 12;
            continue;
          case 6:
            if (nullable2.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 1 : 0;
              continue;
            }
            goto label_14;
          case 7:
            if (BinaryFile.fJZRdLGnfauBr0pYCy0r(BinaryFile.zGjIOuGnELXHtUQb4Zft((object) binaryFile), (object) this.Id))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 2 : 2;
              continue;
            }
            goto case 6;
          case 8:
            if (!BinaryFile.KiveHhGnhLJpqekh3CnX((object) binaryFile))
            {
              num = 11;
              continue;
            }
            nullable5 = new Guid?(binaryFile.Uid);
            goto label_26;
          case 9:
            if (binaryFile != null)
            {
              num = 4;
              continue;
            }
            goto label_9;
          case 10:
            binaryFile = obj as BinaryFile;
            num = 9;
            continue;
          case 11:
            nullable3 = new Guid?();
            num = 13;
            continue;
          case 12:
            nullable4 = nullable3;
            break;
          case 13:
            nullable5 = nullable3;
            goto label_26;
          default:
            goto label_13;
        }
        nullable2 = nullable4;
        num = 8;
        continue;
label_26:
        nullable1 = nullable5;
        num = 7;
      }
label_9:
      return false;
label_13:
      return BinaryFile.iii9svGnQcikZLMiDMg0(nullable2.Value, nullable1.Value);
label_14:
      return false;
label_15:
      return true;
    }

    /// <summary>Преобразовать объект в строковое представление.</summary>
    /// <returns>Строковое представление объекта.</returns>
    public override string ToString() => this.Name;

    /// <summary>Переименовать файл</summary>
    /// <param name="fileName">Имя файла</param>
    /// <returns>Был ли переименован файл</returns>
    /// <exception cref="T:System.ArgumentException">Файл по идентификатору не найден</exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">fileName не соответствует допустимому имени файла</exception>
    public virtual bool Rename(string fileName)
    {
      int num1 = 10;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              fileName = (string) BinaryFile.k0FhggGnueo9WagmjTu4(BinaryFile.H0bkdeGnZwofyKpYGFud(), (object) this.Id, (object) fileName);
              num2 = 2;
              continue;
            case 2:
              if (!BinaryFile.JcXLp0GnCm5mNpbiN84Z((object) fileName))
                goto case 12;
              else
                goto label_21;
            case 3:
              this.extension = (string) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_17;
            case 5:
              goto label_16;
            case 6:
              goto label_12;
            case 7:
              this.extension = (string) null;
              num2 = 6;
              continue;
            case 8:
              this.name = fileName;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 7 : 7;
              continue;
            case 9:
              goto label_25;
            case 10:
              if (BinaryFile.JcXLp0GnCm5mNpbiN84Z((object) fileName))
              {
                num2 = 9;
                continue;
              }
              fileName = (string) BinaryFile.QxjMipGnvZfrbs5OVwgO((object) fileName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 4 : 16;
              continue;
            case 11:
              this.extension = (string) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 2 : 5;
              continue;
            case 12:
              this.name = fileName;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 9 : 11;
              continue;
            case 13:
              this.name = fileName;
              num2 = 3;
              continue;
            case 14:
              goto label_3;
            case 15:
              if (this.Id == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 13 : 8;
                continue;
              }
              goto case 1;
            case 16:
              if (!BinaryFile.MttZKWGn83k3t6034CBU((object) fileName, (object) this.name, StringComparison.CurrentCulture))
              {
                if (this.name != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 11 : 15;
                  continue;
                }
                goto case 8;
              }
              else
              {
                num2 = 14;
                continue;
              }
            default:
              goto label_6;
          }
        }
label_21:
        num1 = 4;
      }
label_3:
      return true;
label_6:
      return true;
label_12:
      return true;
label_16:
      return true;
label_17:
      return false;
label_25:
      throw new ArgumentNullException((string) BinaryFile.vpwiZkGnBYFpZEBm7fN7(1669371371 ^ 1669393393));
    }

    /// <summary>
    /// Клонировать объект файла.
    /// Для копирования файла используйте <see cref="M:EleWise.ELMA.Runtime.Managers.IFileManager.CopyFile(EleWise.ELMA.Files.BinaryFile)" />
    /// </summary>
    /// <returns>Клон объекта</returns>
    public virtual BinaryFile Clone()
    {
      int num = 6;
      BinaryFileBuilder binaryFileBuilder;
      while (true)
      {
        Uri contentLocation;
        object obj;
        switch (num)
        {
          case 1:
            obj = BinaryFile.DDOw4hGnqx2FYEtdmU7T((object) binaryFileBuilder, (object) contentLocation, BinaryFile.DkyXCcGni7ef3UfQhu5m((object) this), BinaryFile.GOuybZGnRNUwPEimZC86((object) this));
            break;
          case 3:
            if (!BinaryFile.aK4Ym9GnVeDIou8IAoKs((object) contentLocation, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 2;
              continue;
            }
            goto case 4;
          case 4:
            if (!BinaryFile.f2rkkeGnSMZE3ASVDIJn((object) this))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 1;
              continue;
            }
            obj = (object) binaryFileBuilder.Content(this.GetContent(GetContentOptions.NonSeekable), true, (string) BinaryFile.D3UrGZGnKshCnTNBTvRR((object) this));
            break;
          case 5:
            binaryFileBuilder = (BinaryFileBuilder) BinaryFile.oBJnL1GnIeQqrajBEx8f((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 3 : 3;
            continue;
          case 6:
            contentLocation = this.ContentLocation;
            num = 5;
            continue;
          default:
            goto label_2;
        }
        binaryFileBuilder = (BinaryFileBuilder) obj;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
      }
label_2:
      object obj1 = BinaryFile.O9GfVUGnXGaquNEqqjMk((object) binaryFileBuilder);
      BinaryFile.Iui8ZRGnTNAaNLSQEUlO(obj1, (object) this.Id);
      BinaryFile.CURIBEGnntAe80lpHCEn(obj1, BinaryFile.NnOUQgGnkBLCQN9rIJ2W((object) this));
      return (BinaryFile) obj1;
    }

    /// <summary>Получить содержимое BinaryFile в виде потока.</summary>
    /// <param name="options">Характеристики потока чтения.</param>
    /// <returns>Поток.</returns>
    public virtual Stream GetContent(GetContentOptions options = null) => ((IBinaryFileStreams) BinaryFile.zeUfELGnoUuQF5WIFPEn()).GetContent(this, options);

    /// <summary>Расширение файла.</summary>
    public virtual string Extension
    {
      get
      {
        int num = 3;
        string extension1;
        string extension2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_9;
            case 3:
              if (BinaryFile.D1EJOAGnOyOHTah34uSD((object) this) == null)
              {
                num = 2;
                continue;
              }
              break;
            case 4:
              this.extension = extension1 = (string) BinaryFile.vm2xKNGneZTdvndSDEHu(BinaryFile.A4KBnjGn2CK8m6pbj9m6(BinaryFile.D1EJOAGnOyOHTah34uSD((object) this)));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 1;
              continue;
          }
          extension2 = this.extension;
          if (extension2 == null)
            num = 4;
          else
            break;
        }
        return extension2;
label_8:
        return extension1;
label_9:
        return string.Empty;
      }
    }

    /// <summary>Получить размер.</summary>
    /// <returns>Размер файла.</returns>
    public virtual long GetSize()
    {
      int num = 2;
      long? length;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!length.HasValue)
            {
              num = 3;
              continue;
            }
            goto label_2;
          case 2:
            length = ((IBinaryFileLegacyBehaviorProvider) BinaryFile.I2X3b2GnFtBx7teSN05y()).GetLength(this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
            continue;
          case 3:
            if (!this.contentLength.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 4 : 0;
              continue;
            }
            goto label_9;
          case 4:
            goto label_8;
          default:
            goto label_2;
        }
      }
label_2:
      return length.Value;
label_8:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) BinaryFile.vpwiZkGnBYFpZEBm7fN7(-1824388195 ^ -1824396701), (object) this.Id));
label_9:
      return this.contentLength.Value;
    }

    /// <summary>Установить размер контента.</summary>
    /// <param name="contentLength">Новый размер контента.</param>
    internal void SetSize(long contentLength)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.contentLength = new long?(contentLength);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Получить crc-32 файла.</summary>
    /// <returns>crc-32 файла.</returns>
    public virtual uint GetCrc()
    {
      int num = 2;
      uint? crc;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!crc.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            crc = ((IBinaryFileLegacyBehaviorProvider) BinaryFile.I2X3b2GnFtBx7teSN05y()).GetCrc(this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_2;
          case 4:
            goto label_8;
          default:
            if (!this.contentCrc.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 4 : 0;
              continue;
            }
            goto label_9;
        }
      }
label_2:
      return crc.Value;
label_8:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) BinaryFile.vpwiZkGnBYFpZEBm7fN7(-951514650 ^ -951391304), (object) this.Id));
label_9:
      return this.contentCrc.Value;
    }

    /// <summary>Установить crc-32 контента.</summary>
    /// <param name="contentCrc">Новый crc-32 контента.</param>
    internal void SetCrc(uint contentCrc)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.contentCrc = new uint?(contentCrc);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Загружены ли свойства объекта BinaryFile?</summary>
    /// <returns>true - загружены, false - нет.</returns>
    protected virtual bool IsLoaded() => true;

    /// <summary>
    /// Создаёт новый объект, который является копией текущего экземпляра.
    /// </summary>
    /// <returns>Новый объект, который является копией текущего экземпляра.</returns>
    object ICloneable.Clone() => BinaryFile.Uv2A0YGnPFv5DCXVRmCo((object) this);

    /// <summary>Преобразовать CRC-32 из строки в число.</summary>
    /// <param name="crcStringValue">Строковое представление CRC-32.</param>
    /// <returns>Числовое представление CRC-32.</returns>
    protected static uint ParseCrc(string crcStringValue)
    {
      int num = 2;
      uint result;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (uint.TryParse(crcStringValue, out result))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      throw new InvalidDataException((string) BinaryFile.jrx14SGn1ynnNJKX2ac1(BinaryFile.vpwiZkGnBYFpZEBm7fN7(1304605005 ^ 1304631273)));
label_5:
      return result;
    }

    /// <summary>Если файл не загружен, то подгружает его</summary>
    /// <param name="loadFile">Загружать ли тело файла</param>
    internal virtual void CheckLoaded(bool loadFile = false)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.CheckLoadedImpl(loadFile);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Реализация <see cref="M:EleWise.ELMA.Files.BinaryFile.CheckLoaded(System.Boolean)" /> для наследников <see cref="T:EleWise.ELMA.Files.BinaryFile" />, которым недоступны internal-члены класса.
    /// </summary>
    /// <param name="loadFile">Загружать ли тело файла?</param>
    protected virtual void CheckLoadedImpl(bool loadFile = false)
    {
    }

    internal static bool AIJknsGk9kkHXCMF8DeZ() => BinaryFile.bncyCBGkJYbSGNq53DEJ == null;

    internal static BinaryFile Gi5LyjGkdpAerrWEJMa0() => BinaryFile.bncyCBGkJYbSGNq53DEJ;

    internal static void sggpSvGklnsbvuyKaQ47() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void NjLHN2GkrH87GEx6JOZg([In] object obj0, bool value) => ((BinaryFile) obj0).DeleteTempFileAfterSave = value;

    internal static long rcM9yaGkgm7i8F5xQEL3([In] object obj0) => ((FileInfo) obj0).Length;

    internal static uint CrTHGIGk5QyhimKBHORY([In] object obj0) => Crc32.GetCrcValue((string) obj0);

    internal static bool GmswjgGkjyNfDaLMPrQ9([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static bool FhMFQ1GkYyptP8QC45Fr([In] object obj0, [In] object obj1) => ((BinaryFile) obj0).Rename((string) obj1);

    internal static bool G06u02GkL6XcV2Ou8R2E([In] object obj0, [In] object obj1) => (Uri) obj0 == (Uri) obj1;

    internal static object c3YU3DGkUUjAigFkmUxy([In] object obj0) => (object) ((BinaryFile) obj0).ContentLocation;

    internal static object ODsIBfGksmA2xE3KFR5l([In] object obj0) => (object) ((Uri) obj0).LocalPath;

    internal static bool xCLl9CGkcMmjLxfeRIA1([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void odWmfFGkzSGPE3B1LvBh([In] object obj0, [In] object obj1) => ((BinaryFile) obj0).ContentLocation = (Uri) obj1;

    internal static object I2X3b2GnFtBx7teSN05y() => (object) BinaryFile.BinaryFileLegacyBehaviorProvider;

    internal static object vpwiZkGnBYFpZEBm7fN7(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object CNuaarGnWXFCfZ6FDYml([In] object obj0) => (object) IOExtensions.GetTempFileName((string) obj0);

    internal static object zeUfELGnoUuQF5WIFPEn() => (object) DataAccessManager.BinaryFileStreams;

    internal static void D0Al7qGnbr5TK0BwkvEr([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool KiveHhGnhLJpqekh3CnX([In] object obj0) => ((BinaryFile) obj0).IsLoaded();

    internal static Guid GIJ1nBGnG91klSo60Rra([In] object obj0) => ((BinaryFile) obj0).Uid;

    internal static object zGjIOuGnELXHtUQb4Zft([In] object obj0) => (object) ((BinaryFile) obj0).Id;

    internal static bool fJZRdLGnfauBr0pYCy0r([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool iii9svGnQcikZLMiDMg0([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool JcXLp0GnCm5mNpbiN84Z([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object QxjMipGnvZfrbs5OVwgO([In] object obj0) => (object) ((string) obj0).ReplaceControlCharacters();

    internal static bool MttZKWGn83k3t6034CBU([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static object H0bkdeGnZwofyKpYGFud() => (object) DataAccessManager.FileManager;

    internal static object k0FhggGnueo9WagmjTu4([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IFileManager) obj0).RenameFile((string) obj1, (string) obj2);

    internal static object oBJnL1GnIeQqrajBEx8f([In] object obj0) => (object) BinaryFile.CreateFrom((BinaryFile) obj0);

    internal static bool aK4Ym9GnVeDIou8IAoKs([In] object obj0, [In] object obj1) => (Uri) obj0 != (Uri) obj1;

    internal static bool f2rkkeGnSMZE3ASVDIJn([In] object obj0) => ((BinaryFile) obj0).DeleteTempFileAfterSave;

    internal static long DkyXCcGni7ef3UfQhu5m([In] object obj0) => ((BinaryFile) obj0).GetSize();

    internal static uint GOuybZGnRNUwPEimZC86([In] object obj0) => ((BinaryFile) obj0).GetCrc();

    internal static object DDOw4hGnqx2FYEtdmU7T(
      [In] object obj0,
      [In] object obj1,
      long contentLength,
      uint contentCrc)
    {
      return (object) ((BinaryFileBuilder) obj0).Content((Uri) obj1, contentLength, contentCrc);
    }

    internal static object D3UrGZGnKshCnTNBTvRR([In] object obj0) => (object) ((BinaryFile) obj0).Extension;

    internal static object O9GfVUGnXGaquNEqqjMk([In] object obj0) => (object) ((BinaryFileBuilder) obj0).Build();

    internal static void Iui8ZRGnTNAaNLSQEUlO([In] object obj0, [In] object obj1) => ((BinaryFile) obj0).Id = (string) obj1;

    internal static object NnOUQgGnkBLCQN9rIJ2W([In] object obj0) => (object) ((BinaryFile) obj0).SecondId;

    internal static void CURIBEGnntAe80lpHCEn([In] object obj0, [In] object obj1) => ((BinaryFile) obj0).SecondId = (string) obj1;

    internal static object D1EJOAGnOyOHTah34uSD([In] object obj0) => (object) ((BinaryFile) obj0).Name;

    internal static object A4KBnjGn2CK8m6pbj9m6([In] object obj0) => (object) ((string) obj0).ReplaceInvalidFileNameChars();

    internal static object vm2xKNGneZTdvndSDEHu([In] object obj0) => (object) Path.GetExtension((string) obj0);

    internal static object Uv2A0YGnPFv5DCXVRmCo([In] object obj0) => (object) ((BinaryFile) obj0).Clone();

    internal static object jrx14SGn1ynnNJKX2ac1([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
  }
}
