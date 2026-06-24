// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.TemplateFileManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>
  /// Менеджер шаблонов файлов (реализация на основе IFileManager)
  /// </summary>
  [Service]
  public class TemplateFileManager : ITemplateFileManager
  {
    internal static TemplateFileManager Gu5cnUWMNR7ZOILAUxJq;

    protected IFileManager FileManager => Locator.GetServiceNotNull<IFileManager>();

    /// <summary>Сохранить файл шаблона</summary>
    /// <param name="binaryFile">Файл</param>
    /// <returns>Идентификатор в строковом представлении</returns>
    public virtual string SaveTemplate(BinaryFile binaryFile) => (string) TemplateFileManager.AcUKcAWMall1xoKTtZw5((object) this.FileManager, (object) binaryFile);

    /// <summary>Загрузить файл шаблона</summary>
    /// <param name="id">Идентификатор файла</param>
    /// <returns>Загруженный файл</returns>
    public virtual BinaryFile LoadTemplate(string id) => this.FileManager.LoadFile(id);

    /// <summary>Создать файл из шаблона (скопировать шаблон как файл)</summary>
    /// <param name="id">Идентификатор файла шаблона</param>
    /// <returns></returns>
    public virtual BinaryFile CreateFromTemplate(string id)
    {
      int num = 2;
      BinaryFile binaryFile;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (binaryFile == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            binaryFile = (BinaryFile) TemplateFileManager.hjX17JWMDfaOstQi573W((object) this, (object) id);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      throw new ObjectNotFoundException((string) TemplateFileManager.LuKaIfWMtgcLV2YOq8cA((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1787005366)), id);
label_4:
      return (BinaryFile) TemplateFileManager.IOXaM0WM6kSTGPVcpUDo((object) ((BinaryFileBuilder) TemplateFileManager.djBI0aWMwwFmWAPE6AQ7((object) binaryFile)).Content(binaryFile.GetContent(GetContentOptions.NonSeekable), true, (string) TemplateFileManager.F7pYhEWM49gnBCKsxlTe((object) binaryFile)));
    }

    /// <inheritdoc />
    public string GetTemplateFileServerPath(string id) => (string) TemplateFileManager.juVOfcWM76nOvZpoLaQk(TemplateFileManager.SICIT7WMA2rVP4Poaqcv((object) (this.LoadTemplate(id) ?? throw new ObjectNotFoundException((string) TemplateFileManager.LuKaIfWMtgcLV2YOq8cA(TemplateFileManager.NiZ4UcWMHN87IOiT9DdS(95909607 + 343705423 ^ 439471668)), id))));

    public TemplateFileManager()
    {
      TemplateFileManager.p2aLgVWMxiFNU2ilL5xH();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object AcUKcAWMall1xoKTtZw5([In] object obj0, [In] object obj1) => (object) ((IFileManager) obj0).SaveFile((BinaryFile) obj1);

    internal static bool qTxQynWM3ktsMaLXvrXT() => TemplateFileManager.Gu5cnUWMNR7ZOILAUxJq == null;

    internal static TemplateFileManager owx9b1WMpMgHudCK6k1E() => TemplateFileManager.Gu5cnUWMNR7ZOILAUxJq;

    internal static object hjX17JWMDfaOstQi573W([In] object obj0, [In] object obj1) => (object) ((TemplateFileManager) obj0).LoadTemplate((string) obj1);

    internal static object LuKaIfWMtgcLV2YOq8cA([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object djBI0aWMwwFmWAPE6AQ7([In] object obj0) => (object) BinaryFile.CreateFrom((BinaryFile) obj0);

    internal static object F7pYhEWM49gnBCKsxlTe([In] object obj0) => (object) ((BinaryFile) obj0).Extension;

    internal static object IOXaM0WM6kSTGPVcpUDo([In] object obj0) => (object) ((BinaryFileBuilder) obj0).Build();

    internal static object NiZ4UcWMHN87IOiT9DdS(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object SICIT7WMA2rVP4Poaqcv([In] object obj0) => (object) ((BinaryFile) obj0).ContentLocation;

    internal static object juVOfcWM76nOvZpoLaQk([In] object obj0) => (object) ((Uri) obj0).LocalPath;

    internal static void p2aLgVWMxiFNU2ilL5xH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
