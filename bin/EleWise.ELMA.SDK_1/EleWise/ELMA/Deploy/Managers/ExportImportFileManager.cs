// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Managers.ExportImportFileManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Managers
{
  /// <summary>
  /// Менеджер для работы с ExportImportFileService через дизайнер
  /// </summary>
  public class ExportImportFileManager : DTOManager, IExportImportFileManager, IConfigurationService
  {
    internal static ExportImportFileManager r6AAMwEt11xrifuNsCI7;

    protected IExportImportFileService ExportImportFileService => Locator.GetServiceNotNull<IExportImportFileService>();

    /// <summary>
    /// Размер буфера для передачи данных между сервером и дизайнером
    /// </summary>
    /// <returns></returns>
    public virtual long GetBufferLength() => this.ExportImportFileService.GetBufferLength();

    /// <summary>Создание имени временной папки</summary>
    public virtual string CreateFolderName(string id) => (string) ExportImportFileManager.zqvWcKEtpl0UisC7gk7M((object) this.ExportImportFileService, (object) id);

    /// <summary>Создание имени экспорта-импорта во временной папке</summary>
    public virtual string CreateDeployFolderName(string id) => (string) ExportImportFileManager.b9eCmrEtaMttFUD2rguU((object) this.ExportImportFileService, (object) id);

    /// <summary>Создание имени файла-архива</summary>
    public virtual string CreateZipFileName(string id) => (string) ExportImportFileManager.AQKUM2EtDqucFEW7PEcF((object) this.ExportImportFileService, (object) id);

    /// <summary>Создание имени файла</summary>
    public virtual string CreateFileName(string id) => this.ExportImportFileService.CreateFileName(id, (string) null, (string) null);

    /// <summary>Создание имени файла</summary>
    public virtual string CreateFileName(string id, string name, string ext) => this.ExportImportFileService.CreateFileName(id, name, ext);

    /// <summary>Загрузка части файла с сервера</summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public virtual byte[] LoadFile(string id, long i) => (byte[]) ExportImportFileManager.iVXidXEtt64941Ebs1rK((object) this.ExportImportFileService, (object) id, i);

    /// <summary>Удаление файлов</summary>
    /// <param name="id"></param>
    public virtual void DeleteFiles(string id)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.ExportImportFileService.DeleteFiles(id);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Добавление части файла в файл на сервере</summary>
    /// <param name="id"></param>
    /// <param name="buf"></param>
    public virtual void AddToFile(string id, byte[] buf)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.ExportImportFileService.AddToFile(id, buf);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Добавление части файла в файл на сервере</summary>
    /// <param name="id"></param>
    /// <param name="buf"></param>
    public virtual void AddToNestedFile(string id, string nestedId, string path, byte[] buf)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ExportImportFileManager.k1ij3PEtwdtP3dvswM4O((object) this.ExportImportFileService, (object) id, (object) nestedId, (object) path, (object) buf);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Загрузка файла в CacheFilesService</summary>
    /// <param name="fileName"></param>
    /// <param name="fullFileName"></param>
    /// <param name="uid"></param>
    public virtual void LoadFileToCache(string fileName, string fullFileName, Guid uid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ExportImportFileManager.F4Ca20Et4RnPsKGxOBj9((object) this.ExportImportFileService, (object) fileName, (object) fullFileName, uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public ExportImportFileManager()
    {
      ExportImportFileManager.sqHhLhEt6gvrmDN1gCHf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool MwJ94GEtNBhHkjRPCyEj() => ExportImportFileManager.r6AAMwEt11xrifuNsCI7 == null;

    internal static ExportImportFileManager rttCf0Et3hReWsuILExk() => ExportImportFileManager.r6AAMwEt11xrifuNsCI7;

    internal static object zqvWcKEtpl0UisC7gk7M([In] object obj0, [In] object obj1) => (object) ((IExportImportFileService) obj0).CreateFolderName((string) obj1);

    internal static object b9eCmrEtaMttFUD2rguU([In] object obj0, [In] object obj1) => (object) ((IExportImportFileService) obj0).CreateDeployFolderName((string) obj1);

    internal static object AQKUM2EtDqucFEW7PEcF([In] object obj0, [In] object obj1) => (object) ((IExportImportFileService) obj0).CreateZipFileName((string) obj1);

    internal static object iVXidXEtt64941Ebs1rK([In] object obj0, [In] object obj1, long i) => (object) ((IExportImportFileService) obj0).LoadFile((string) obj1, i);

    internal static void k1ij3PEtwdtP3dvswM4O(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      ((IExportImportFileService) obj0).AddToNestedFile((string) obj1, (string) obj2, (string) obj3, (byte[]) obj4);
    }

    internal static void F4Ca20Et4RnPsKGxOBj9([In] object obj0, [In] object obj1, [In] object obj2, Guid uid) => ((IExportImportFileService) obj0).LoadFileToCache((string) obj1, (string) obj2, uid);

    internal static void sqHhLhEt6gvrmDN1gCHf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
