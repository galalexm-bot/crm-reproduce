// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.DTO.Managers.FileDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Files.DTO.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files.DTO.Managers
{
  /// <summary>Менеджер файлов (для работы через Remoting)</summary>
  public class FileDTOManager : DTOManager, IBinaryDTOManager, IConfigurationService
  {
    private static FileDTOManager XlexkfGnr94TuZnMubmq;

    protected IFileManager FileManager => Locator.GetServiceNotNull<IFileManager>();

    /// <summary>Сохранить файл</summary>
    /// <param name="binaryFile">Файл</param>
    /// <returns>Идентификатор в строковом представлении</returns>
    public virtual string SaveFile(BinaryFileDTO binaryFile)
    {
      int num = 3;
      BinaryFile binaryFile1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            binaryFile1 = Mapper.Map<BinaryFileDTO, BinaryFile>(binaryFile);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 1 : 1;
            continue;
          case 3:
            if (binaryFile != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 2 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      throw new ArgumentNullException((string) FileDTOManager.qOblUGGnjoNm4K6tSYGO(236071375 ^ 236159095));
label_4:
      return (string) FileDTOManager.frA9wTGnYP6lIqAGlAhN((object) this.FileManager, (object) binaryFile1);
    }

    /// <summary>Загрузить файл</summary>
    /// <param name="id">Идентификатор файла</param>
    /// <returns>Загруженный файл</returns>
    public virtual BinaryFileDTO LoadFile(string id)
    {
      int num = 1;
      BinaryFile source;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (id != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_8;
          case 3:
            goto label_4;
          case 4:
            if (source == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 2 : 1;
              continue;
            }
            goto label_9;
          default:
            source = (BinaryFile) FileDTOManager.mvQ5iTGnLRLsHYMEJOsP((object) this.FileManager, (object) id);
            num = 4;
            continue;
        }
      }
label_4:
      throw new ArgumentNullException((string) FileDTOManager.qOblUGGnjoNm4K6tSYGO(-1876063057 ^ -1876115499));
label_8:
      return (BinaryFileDTO) null;
label_9:
      return Mapper.Map<BinaryFile, BinaryFileDTO>(source);
    }

    /// <summary>Копировать файл</summary>
    /// <param name="sourceBinaryFile"></param>
    /// <returns></returns>
    public virtual BinaryFileDTO CopyFile(BinaryFileDTO sourceBinaryFile)
    {
      int num = 4;
      BinaryFile source;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            goto label_3;
          case 3:
            source = (BinaryFile) FileDTOManager.PbRPIkGnzHDi3fvrQuSr(FileDTOManager.rQYDeJGncdVXiSGeaDlP(FileDTOManager.nDcJyCGnUfqsLc6jKRAs((object) Mapper.Map<BinaryFileDTO, BinaryFile>(sourceBinaryFile)), FileDTOManager.LlrsW3Gns7vb5Nea7c0g((object) sourceBinaryFile)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
            continue;
          case 4:
            if (sourceBinaryFile != null)
            {
              num = 3;
              continue;
            }
            goto label_3;
          default:
            FileDTOManager.frA9wTGnYP6lIqAGlAhN((object) this.FileManager, (object) source);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
            continue;
        }
      }
label_2:
      return Mapper.Map<BinaryFile, BinaryFileDTO>(source);
label_3:
      throw new ArgumentNullException((string) FileDTOManager.qOblUGGnjoNm4K6tSYGO(-398663332 ^ -398636296));
    }

    public FileDTOManager()
    {
      FileDTOManager.zVLAehGOFBpy4R4lI2ch();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object qOblUGGnjoNm4K6tSYGO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object frA9wTGnYP6lIqAGlAhN([In] object obj0, [In] object obj1) => (object) ((IFileManager) obj0).SaveFile((BinaryFile) obj1);

    internal static bool LoDxOiGngEClHaoKvaMN() => FileDTOManager.XlexkfGnr94TuZnMubmq == null;

    internal static FileDTOManager fLR52XGn5jVHaFOlydlw() => FileDTOManager.XlexkfGnr94TuZnMubmq;

    internal static object mvQ5iTGnLRLsHYMEJOsP([In] object obj0, [In] object obj1) => (object) ((IFileManager) obj0).LoadFile((string) obj1);

    internal static object nDcJyCGnUfqsLc6jKRAs([In] object obj0) => (object) BinaryFile.CreateFrom((BinaryFile) obj0);

    internal static object LlrsW3Gns7vb5Nea7c0g([In] object obj0) => (object) ((BinaryFileDTO) obj0).Content;

    internal static object rQYDeJGncdVXiSGeaDlP([In] object obj0, [In] object obj1) => (object) ((BinaryFileBuilder) obj0).Content((byte[]) obj1);

    internal static object PbRPIkGnzHDi3fvrQuSr([In] object obj0) => (object) ((BinaryFileBuilder) obj0).Build();

    internal static void zVLAehGOFBpy4R4lI2ch() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
