// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.DTO.Managers.TemplateFileDTOManager
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
using EleWise.ELMA.Services.Impl;
using EleWise.ELMA.Templates;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files.DTO.Managers
{
  /// <summary>Менеджер файлов (для работы через Remoting)</summary>
  public class TemplateFileDTOManager : DTOManager, ITemplateFileDTOManager, IConfigurationService
  {
    internal static TemplateFileDTOManager DJpISkGOBOgf1eWdrRGA;

    protected ITemplateFileManager FileTemplateManager => Locator.GetServiceNotNull<ITemplateFileManager>();

    /// <summary>Сохранить файл шаблона</summary>
    /// <param name="binaryFile">Файл</param>
    /// <returns>Идентификатор в строковом представлении</returns>
    public virtual string SaveTemplate(BinaryFileDTO binaryFile)
    {
      int num = 2;
      BinaryFile binaryFile1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (binaryFile != null)
            {
              binaryFile1 = Mapper.Map<BinaryFileDTO, BinaryFile>(binaryFile);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      throw new ArgumentNullException((string) TemplateFileDTOManager.in1IYnGObYvLgWN32Sng(1199946765 ^ 1199838645));
label_4:
      return this.FileTemplateManager.SaveTemplate(binaryFile1);
    }

    /// <summary>Загрузить файл шаблона</summary>
    /// <param name="id">Идентификатор файла</param>
    /// <returns>Загруженный файл</returns>
    public virtual BinaryFileDTO LoadTemplate(string id)
    {
      int num1 = 2;
      BinaryFile source;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              if (id != null)
              {
                source = (BinaryFile) TemplateFileDTOManager.hhhIELGOhH7kcObDyhPq((object) this.FileTemplateManager, (object) id);
                num2 = 3;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 0;
              continue;
            case 3:
              goto label_7;
            case 4:
              goto label_10;
            default:
              goto label_9;
          }
        }
label_7:
        if (source != null)
          num1 = 4;
        else
          goto label_9;
      }
label_3:
      throw new ArgumentNullException((string) TemplateFileDTOManager.in1IYnGObYvLgWN32Sng(712480695 ^ 712418509));
label_9:
      return (BinaryFileDTO) null;
label_10:
      return Mapper.Map<BinaryFile, BinaryFileDTO>(source);
    }

    /// <summary>Создать файл из шаблона (скопировать шаблон как файл)</summary>
    /// <param name="id">Идентификатор файла шаблона</param>
    /// <returns></returns>
    public virtual BinaryFileDTO CreateFromTemplate(string id)
    {
      int num = 3;
      BinaryFile source;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (source != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 4;
              continue;
            }
            goto label_8;
          case 2:
            source = (BinaryFile) TemplateFileDTOManager.ME2r1fGOGBPTy5GkUew6((object) this.FileTemplateManager, (object) id);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
            continue;
          case 3:
            if (id != null)
            {
              num = 2;
              continue;
            }
            goto label_2;
          case 4:
            goto label_9;
          case 5:
            goto label_2;
          default:
            goto label_8;
        }
      }
label_2:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146579367));
label_8:
      return (BinaryFileDTO) null;
label_9:
      return Mapper.Map<BinaryFile, BinaryFileDTO>(source);
    }

    public virtual BinaryFileDTO LoadSystemTemplate(string name)
    {
      int num = 7;
      string str1;
      byte[] numArray;
      string str2;
      string str3;
      string str4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            goto label_3;
          case 3:
            str2 = (string) TemplateFileDTOManager.cqUVg5GOQFJvF9PjbSZh((object) str1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
            continue;
          case 4:
            str3 = (string) TemplateFileDTOManager.W7HRU3GOvVNxMh8vew6E((object) str1);
            num = 5;
            continue;
          case 5:
            str4 = (string) TemplateFileDTOManager.yrvh5mGO8LcZOnC6xmsT((object) Locator.GetServiceNotNull<MimeMappingService>(), (object) str3);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
            continue;
          case 6:
            if (!TemplateFileDTOManager.X9ndOQGOfhTpKOpZOF0l((object) str1))
            {
              num = 3;
              continue;
            }
            goto label_3;
          case 7:
            str1 = (string) TemplateFileDTOManager.Exbb1wGOEWItQfkyiieM((object) TemplateLoader.Instance, (object) name);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 6 : 6;
            continue;
          default:
            numArray = (byte[]) TemplateFileDTOManager.CQsyOUGOCiR3UhKTkQLN((object) str1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 4;
            continue;
        }
      }
label_3:
      return (BinaryFileDTO) null;
label_7:
      BinaryFileDTO binaryFileDto = new BinaryFileDTO();
      binaryFileDto.Name = str2;
      TemplateFileDTOManager.vWRglYGOZ9OihSwl5G0S((object) binaryFileDto, (object) numArray);
      TemplateFileDTOManager.cu6MquGOud2IRwQeaDkW((object) binaryFileDto, (object) str4);
      TemplateFileDTOManager.DutiIdGOIOU17g0sEb1u((object) binaryFileDto, DateTime.Now);
      return binaryFileDto;
    }

    /// <inheritdoc />
    public virtual string GetTemplateFileServerPath(string id) => (string) TemplateFileDTOManager.aZFkD1GOVj6YScqagTKt((object) this.FileTemplateManager, (object) id);

    public TemplateFileDTOManager()
    {
      TemplateFileDTOManager.vouQHcGOSFMZtq8071IF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object in1IYnGObYvLgWN32Sng(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool HZ9QsVGOWqQnc4R5iaCu() => TemplateFileDTOManager.DJpISkGOBOgf1eWdrRGA == null;

    internal static TemplateFileDTOManager ybaM8dGOoWUmgwkemUnQ() => TemplateFileDTOManager.DJpISkGOBOgf1eWdrRGA;

    internal static object hhhIELGOhH7kcObDyhPq([In] object obj0, [In] object obj1) => (object) ((ITemplateFileManager) obj0).LoadTemplate((string) obj1);

    internal static object ME2r1fGOGBPTy5GkUew6([In] object obj0, [In] object obj1) => (object) ((ITemplateFileManager) obj0).CreateFromTemplate((string) obj1);

    internal static object Exbb1wGOEWItQfkyiieM([In] object obj0, [In] object obj1) => (object) ((TemplateLoader) obj0).LoadTemplate((string) obj1);

    internal static bool X9ndOQGOfhTpKOpZOF0l([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object cqUVg5GOQFJvF9PjbSZh([In] object obj0) => (object) Path.GetFileName((string) obj0);

    internal static object CQsyOUGOCiR3UhKTkQLN([In] object obj0) => (object) File.ReadAllBytes((string) obj0);

    internal static object W7HRU3GOvVNxMh8vew6E([In] object obj0) => (object) Path.GetExtension((string) obj0);

    internal static object yrvh5mGO8LcZOnC6xmsT([In] object obj0, [In] object obj1) => (object) ((MimeMappingService) obj0).GetTypeByExtension((string) obj1);

    internal static void vWRglYGOZ9OihSwl5G0S([In] object obj0, [In] object obj1) => ((BinaryFileDTO) obj0).Content = (byte[]) obj1;

    internal static void cu6MquGOud2IRwQeaDkW([In] object obj0, [In] object obj1) => ((BinaryFileDTO) obj0).ContentType = (string) obj1;

    internal static void DutiIdGOIOU17g0sEb1u([In] object obj0, DateTime value) => ((BinaryFileDTO) obj0).CreateDate = value;

    internal static object aZFkD1GOVj6YScqagTKt([In] object obj0, [In] object obj1) => (object) ((ITemplateFileManager) obj0).GetTemplateFileServerPath((string) obj1);

    internal static void vouQHcGOSFMZtq8071IF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
