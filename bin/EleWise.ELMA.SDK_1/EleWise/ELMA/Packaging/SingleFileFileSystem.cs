// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Packaging.SingleFileFileSystem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Packaging
{
  /// <summary>
  /// Специальная реализация файловой системы, состоящей из единственного файла.
  /// Предназначена исключительно для решения https://jira4.elewise.com/browse/ELMA-31831
  /// </summary>
  internal class SingleFileFileSystem : IFileSystem, IDisposable
  {
    private readonly string fileName;
    private byte[] buffer;
    internal static SingleFileFileSystem ddGhiNBnWqS0RMT9NHhm;

    /// <summary>Ctor</summary>
    /// <param name="fileName">Путь к файлу</param>
    public SingleFileFileSystem(string fileName)
    {
      SingleFileFileSystem.znCVvOBnhQVAnsomRgOm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.fileName = fileName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Логгер (не реализовано)</summary>
    public ILogger Logger
    {
      get => throw new NotImplementedException();
      set => throw new NotImplementedException();
    }

    /// <summary>Корневая папка ФС (не реализовано)</summary>
    public string Root => throw new NotImplementedException();

    /// <summary>Добавить файл (не реализовано)</summary>
    /// <param name="path">Путь к файлу</param>
    /// <param name="stream">Поток с данными</param>
    /// <exception cref="T:System.NotImplementedException">Не реализовано</exception>
    public void AddFile(string path, Stream stream) => throw new NotImplementedException();

    /// <summary>Добавить файл</summary>
    /// <param name="path">Путь к файлу</param>
    /// <param name="writeToStream">Делегат для сохранения содержимого файла</param>
    /// <exception cref="T:System.InvalidOperationException">Передан путь, отличающийся от единственного файла в ФС</exception>
    public void AddFile(string path, Action<Stream> writeToStream)
    {
      if (path != this.fileName)
        throw new InvalidOperationException(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993500047), (object) this.fileName, (object) path));
      MemoryStream memoryStream = new MemoryStream();
      writeToStream((Stream) memoryStream);
      this.buffer = memoryStream.ToArray();
    }

    /// <summary>Добавить файлы (не реализовано)</summary>
    /// <param name="files">Добавляемые файлы</param>
    /// <param name="rootDir">Путь к каталогу, куда добавить файлы</param>
    /// <exception cref="T:System.NotImplementedException">Не реализовано</exception>
    public void AddFiles(IEnumerable<IPackageFile> files, string rootDir) => throw new NotImplementedException();

    /// <summary>Создать файл (не реализовано)</summary>
    /// <param name="path">Путь к файлу</param>
    /// <returns>Поток для содержимого файла</returns>
    /// <exception cref="T:System.NotImplementedException">Не реализовано</exception>
    public Stream CreateFile(string path) => throw new NotImplementedException();

    /// <summary>Удалить каталог (не реализовано)</summary>
    /// <param name="path">Путь</param>
    /// <param name="recursive">Флаг рекурсивного удаления</param>
    /// <exception cref="T:System.NotImplementedException">Не реализовано</exception>
    public void DeleteDirectory(string path, bool recursive) => throw new NotImplementedException();

    /// <summary>Удалить файл (не реализовано)</summary>
    /// <param name="path">Путь</param>
    /// <exception cref="T:System.NotImplementedException">Не реализовано</exception>
    public void DeleteFile(string path) => throw new NotImplementedException();

    /// <summary>Удалить файлы (не реализовано)</summary>
    /// <param name="files">Файлы</param>
    /// <param name="rootDir">Путь к папке</param>
    /// <exception cref="T:System.NotImplementedException">Не реализовано</exception>
    public void DeleteFiles(IEnumerable<IPackageFile> files, string rootDir) => throw new NotImplementedException();

    /// <summary>Проверить существование каталога (не реализовано)</summary>
    /// <param name="path">Путь к каталогу</param>
    /// <returns>true - каталог существует, false - нет</returns>
    /// <exception cref="T:System.NotImplementedException">Не реализовано</exception>
    public bool DirectoryExists(string path) => throw new NotImplementedException();

    /// <summary>Уничтожить объект ФС</summary>
    public void Dispose()
    {
      switch (1)
      {
        case 1:
          try
          {
            if (this.buffer == null)
              break;
            int num1 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
              num1 = 1;
            MemoryStream memoryStream;
            while (true)
            {
              switch (num1)
              {
                case 0:
                  goto label_13;
                case 1:
                  memoryStream = new MemoryStream(this.buffer, false);
                  num1 = 2;
                  continue;
                case 2:
                  goto label_5;
                default:
                  goto label_12;
              }
            }
label_13:
            break;
label_12:
            break;
label_5:
            try
            {
              FileStream fileStream = (FileStream) SingleFileFileSystem.aXBHg6BnGfx0kvTCw4EB((object) this.fileName);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  try
                  {
                    SingleFileFileSystem.FVcAWhBnEUMXTxvYlhw7((object) memoryStream, (object) fileStream);
                    int num3 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0)
                      num3 = 0;
                    switch (num3)
                    {
                      case 0:
                        return;
                      default:
                        return;
                    }
                  }
                  finally
                  {
                    if (fileStream != null)
                    {
                      int num4 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
                        num4 = 1;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            SingleFileFileSystem.sIOVjWBnfjpL5QxjBC7r((object) fileStream);
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_20;
                        }
                      }
                    }
label_20:;
                  }
              }
            }
            finally
            {
              int num5;
              if (memoryStream == null)
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
              else
                goto label_26;
label_23:
              switch (num5)
              {
                case 2:
                  break;
                default:
              }
label_26:
              memoryStream.Dispose();
              num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
              {
                num5 = 0;
                goto label_23;
              }
              else
                goto label_23;
            }
          }
          finally
          {
            this.buffer = (byte[]) null;
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
              num = 0;
            switch (num)
            {
              default:
            }
          }
      }
    }

    /// <summary>Проверить существование файла (не реализовано)</summary>
    /// <param name="path">Путь к файлу</param>
    /// <returns>true - файл существует, false - нет</returns>
    public bool FileExists(string path)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.buffer != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
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
      return SingleFileFileSystem.lXhbt8BnQjgv7v8BevlJ((object) path);
label_5:
      return true;
    }

    /// <summary>Получить дату создания (не реализовано)</summary>
    /// <param name="path">Путь</param>
    /// <returns>Дата создания</returns>
    /// <exception cref="T:System.NotImplementedException">Не реализовано</exception>
    public DateTimeOffset GetCreated(string path) => throw new NotImplementedException();

    /// <summary>Получить подкаталоги (не реализовано)</summary>
    /// <param name="path">Путь к каталогу</param>
    /// <returns>Подкаталоги</returns>
    /// <exception cref="T:System.NotImplementedException">Не реализовано</exception>
    public IEnumerable<string> GetDirectories(string path) => throw new NotImplementedException();

    /// <summary>Получить файлы (не реализовано)</summary>
    /// <param name="path">Корневой путь</param>
    /// <param name="filter">Фильтр (маска)</param>
    /// <param name="recursive">Флаг рекурсивного поиска</param>
    /// <returns>Найденные пути к файлам</returns>
    /// <exception cref="T:System.NotImplementedException">Не реализовано</exception>
    public IEnumerable<string> GetFiles(string path, string filter, bool recursive) => throw new NotImplementedException();

    /// <summary>Получить полный путь (не реализовано)</summary>
    /// <param name="path">Относительный путь</param>
    /// <returns>Полный путь к указанному ресурсу</returns>
    /// <exception cref="T:System.NotImplementedException">Не реализовано</exception>
    public string GetFullPath(string path) => throw new NotImplementedException();

    /// <summary>Получить дату последнего доступа (не реализовано)</summary>
    /// <param name="path">Путь</param>
    /// <returns>Дата последнего доступа</returns>
    /// <exception cref="T:System.NotImplementedException"></exception>
    public DateTimeOffset GetLastAccessed(string path) => throw new NotImplementedException();

    /// <summary>Получить дату модификации (не реализовано)</summary>
    /// <param name="path">Путь</param>
    /// <returns>Дата модификации</returns>
    /// <exception cref="T:System.NotImplementedException">Не реализовано</exception>
    public DateTimeOffset GetLastModified(string path) => throw new NotImplementedException();

    /// <summary>Сделать файл записываемым (не реализовано)</summary>
    /// <param name="path">Путь к файлу</param>
    /// <exception cref="T:System.NotImplementedException">Не реализовано</exception>
    public void MakeFileWritable(string path) => throw new NotImplementedException();

    /// <summary>Переместить файл (не реализовано)</summary>
    /// <param name="source">Искодный путь</param>
    /// <param name="destination">Конечный путь</param>
    /// <exception cref="T:System.NotImplementedException">Не реализовано</exception>
    public void MoveFile(string source, string destination) => throw new NotImplementedException();

    /// <summary>Открыть файл</summary>
    /// <param name="path">Путь к файлу</param>
    /// <returns>Поток с содержимым файла</returns>
    public Stream OpenFile(string path)
    {
      int num1 = 1;
      MemoryStream destination;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (this.buffer != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 3:
            destination = new MemoryStream();
            num1 = 4;
            continue;
          case 4:
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (Stream) new MemoryStream(this.buffer, false);
label_5:
      try
      {
        FileStream fileStream = (FileStream) SingleFileFileSystem.hseZ2iBnCaWfe6yJQUHs((object) path);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
label_18:
              this.buffer = (byte[]) SingleFileFileSystem.EdaE2tBnvehjnsXwx567((object) destination);
              num2 = 2;
              continue;
            case 2:
              goto label_4;
            default:
              try
              {
                fileStream.CopyTo((Stream) destination);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_18;
                }
              }
              finally
              {
                int num4;
                if (fileStream == null)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 0;
                else
                  goto label_15;
label_14:
                switch (num4)
                {
                  case 1:
                  case 2:
                }
label_15:
                fileStream.Dispose();
                num4 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
                {
                  num4 = 2;
                  goto label_14;
                }
                else
                  goto label_14;
              }
          }
        }
      }
      finally
      {
        int num5;
        if (destination == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 1 : 1;
        else
          goto label_22;
label_21:
        switch (num5)
        {
          case 1:
          case 2:
        }
label_22:
        SingleFileFileSystem.sIOVjWBnfjpL5QxjBC7r((object) destination);
        num5 = 2;
        goto label_21;
      }
    }

    internal static void znCVvOBnhQVAnsomRgOm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool aGOY3tBnohroUJOrS4Eh() => SingleFileFileSystem.ddGhiNBnWqS0RMT9NHhm == null;

    internal static SingleFileFileSystem NuNomxBnbDGbUl4LGxhM() => SingleFileFileSystem.ddGhiNBnWqS0RMT9NHhm;

    internal static object aXBHg6BnGfx0kvTCw4EB([In] object obj0) => (object) File.OpenWrite((string) obj0);

    internal static void FVcAWhBnEUMXTxvYlhw7([In] object obj0, [In] object obj1) => ((Stream) obj0).CopyTo((Stream) obj1);

    internal static void sIOVjWBnfjpL5QxjBC7r([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool lXhbt8BnQjgv7v8BevlJ([In] object obj0) => File.Exists((string) obj0);

    internal static object hseZ2iBnCaWfe6yJQUHs([In] object obj0) => (object) File.OpenRead((string) obj0);

    internal static object EdaE2tBnvehjnsXwx567([In] object obj0) => (object) ((MemoryStream) obj0).ToArray();
  }
}
