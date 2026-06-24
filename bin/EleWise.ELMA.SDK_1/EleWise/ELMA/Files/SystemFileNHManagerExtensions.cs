// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.SystemFileNHManagerExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files
{
  /// <summary>
  /// Методы расширения к менеджеру <see cref="T:EleWise.ELMA.Files.SystemFileNHManager" />.
  /// </summary>
  public static class SystemFileNHManagerExtensions
  {
    private static SystemFileNHManagerExtensions g2OsJFGXov00rWaVUyfJ;

    /// <summary>
    /// Обязательно загрузить метаданные постоянно хранимого файла, либо кинуть исключение, что файл не найден.
    /// </summary>
    /// <param name="manager">Менеджер работы с системными файлами.</param>
    /// <param name="uid">Идентификатор файла.</param>
    /// <returns>Метаданные постоянно хранимого файла.</returns>
    public static SystemFile LoadFileRequired(this SystemFileNHManager manager, Guid uid)
    {
      int num = 3;
      SystemFile systemFile;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (systemFile != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
              continue;
            }
            goto label_5;
          case 3:
            systemFile = (SystemFile) SystemFileNHManagerExtensions.D0lw6YGXG7RaaooCSwhZ((object) manager, uid);
            num = 2;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      throw new FileNotFoundException(EleWise.ELMA.SR.T((string) SystemFileNHManagerExtensions.jElshJGXEauWaXZxrC70(-812025778 ^ -812067828), (object) uid));
label_6:
      return systemFile;
    }

    internal static object D0lw6YGXG7RaaooCSwhZ([In] object obj0, Guid uid) => (object) ((SystemFileNHManager) obj0).LoadFile(uid);

    internal static object jElshJGXEauWaXZxrC70(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool lcl7xlGXb7hHOvnNmjyK() => SystemFileNHManagerExtensions.g2OsJFGXov00rWaVUyfJ == null;

    internal static SystemFileNHManagerExtensions BN3NdoGXhgBI0I3ivU0l() => SystemFileNHManagerExtensions.g2OsJFGXov00rWaVUyfJ;
  }
}
