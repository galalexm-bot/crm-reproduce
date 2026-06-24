// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.FilePreviewServiceProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Configuration.Provider;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>
  /// Базовый класс провайдера сервиса генерации предпросмотра
  /// </summary>
  public abstract class FilePreviewServiceProvider : ProviderBase, IFilePreviewServiceProvider
  {
    private static FilePreviewServiceProvider OKKtWqG2DbWbNxwVugeE;

    /// <summary>Uid провайдера</summary>
    public abstract Guid ProviderUid { get; }

    /// <summary>Добавить файл в очередь</summary>
    /// <param name="fileId">Идентификатор файла</param>
    /// <param name="priority">Приоритет</param>
    public abstract void AddFileToQueue(string fileId, long priority);

    /// <summary>Удалить файл из очереди</summary>
    /// <param name="fileId">Идентификатор файла</param>
    public abstract void DeleteFileFromQueue(string fileId);

    /// <summary>Получить статус формирования предпросмотра для файла</summary>
    /// <param name="fileId">Идентификатор файла</param>
    /// <returns>Статус формирования</returns>
    public abstract PreviewWorkStatus GetFilePreviewWorkStatus(string fileId);

    /// <inheritdoc />
    public abstract bool GeneratePreview(
      string fileId,
      string fileEncryptPassword,
      string password);

    /// <inheritdoc />
    public abstract bool CheckPassword(string fileId, string password);

    /// <inheritdoc />
    public abstract bool CheckPassword(string fileId, string fileEncryptPassword, string password);

    /// <summary>Получить генератор предпросмотра для файла</summary>
    /// <param name="file">Бинарный файл</param>
    /// <returns>Генератор</returns>
    public virtual IFilePreviewCreator GetFilePreviewCreator(BinaryFile file)
    {
      int num1 = 5;
      // ISSUE: variable of a compiler-generated type
      FilePreviewServiceProvider.\u003C\u003Ec__DisplayClass8_0 cDisplayClass80;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            if (cDisplayClass80.file != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 3 : 3;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_3;
          case 4:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass80.file = file;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 1;
            continue;
          case 5:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass80 = new FilePreviewServiceProvider.\u003C\u003Ec__DisplayClass8_0();
            num1 = 4;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      IFilePreviewCreator filePreviewCreator;
      return filePreviewCreator;
label_3:
      return (IFilePreviewCreator) null;
label_7:
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FilePreviewServiceProvider.\u003C\u003Ec__DisplayClass8_1 cDisplayClass81 = new FilePreviewServiceProvider.\u003C\u003Ec__DisplayClass8_1();
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass81.CS\u0024\u003C\u003E8__locals1 = cDisplayClass80;
              num2 = 6;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              if (FilePreviewServiceProvider.hLJfLdG24FqJ4ox5cOj4((object) cDisplayClass81.ext))
              {
                num2 = 5;
                continue;
              }
              break;
            case 3:
            case 4:
              goto label_2;
            case 5:
              filePreviewCreator = (IFilePreviewCreator) null;
              num2 = 4;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass81.ext = cDisplayClass81.CS\u0024\u003C\u003E8__locals1.file.Extension;
              num2 = 2;
              continue;
          }
          // ISSUE: reference to a compiler-generated method
          filePreviewCreator = ((ComponentManager) FilePreviewServiceProvider.hETf2kG26ebrKCDD4bIY()).GetExtensionPoints<IFilePreviewCreator>().FirstOrDefault<IFilePreviewCreator>(new Func<IFilePreviewCreator, bool>(cDisplayClass81.\u003CGetFilePreviewCreator\u003Eb__0));
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 3;
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              filePreviewCreator = (IFilePreviewCreator) null;
              num3 = 2;
              continue;
            case 2:
              goto label_2;
            default:
              FilePreviewServiceProvider.x2eHAMG2AiFueNHrZXTq(FilePreviewServiceProvider.buWwydG2HAy1ype6VuWC(), (object) ex.Message, (object) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
              continue;
          }
        }
      }
    }

    protected FilePreviewServiceProvider()
    {
      FilePreviewServiceProvider.RmjxkXG278Y8Jl9VbVG9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool hLJfLdG24FqJ4ox5cOj4([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object hETf2kG26ebrKCDD4bIY() => (object) ComponentManager.Current;

    internal static object buWwydG2HAy1ype6VuWC() => (object) Logger.Log;

    internal static void x2eHAMG2AiFueNHrZXTq([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static bool SUUja9G2tZ67YEVnCEct() => FilePreviewServiceProvider.OKKtWqG2DbWbNxwVugeE == null;

    internal static FilePreviewServiceProvider vYYFsgG2wA9Ca6U85VXK() => FilePreviewServiceProvider.OKKtWqG2DbWbNxwVugeE;

    internal static void RmjxkXG278Y8Jl9VbVG9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
