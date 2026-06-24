// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.BaseFilePreviewCreatorEx
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>
  /// Расширение базового класса генератора файлов предпросмотра
  /// </summary>
  public abstract class BaseFilePreviewCreatorEx : 
    BaseFilePreviewCreator,
    IFilePreviewCreatorEx,
    IFilePreviewCreator
  {
    private static BaseFilePreviewCreatorEx s29K1GG2i4OR4h9UiLbK;

    /// <summary>
    /// Полное наименование исполняемого файла внешнего генератора предпросмотра
    /// </summary>
    public virtual string ExternalCreatorFileName => string.Empty;

    /// <summary>
    /// Полное наименование исполняемого файла внешнего генератора предпросмотра
    /// </summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public virtual string GetExternalCreatorFileName(BinaryFile file) => this.ExternalCreatorFileName;

    /// <summary>Требуется внешний генератор файла предпросмотра</summary>
    /// <returns><с>true</с>, если требуется внешний генератор файла предпросмотра</returns>
    public virtual bool RequiredExternalCreator => true;

    /// <summary>Создать превью</summary>
    /// <param name="path"></param>
    /// <param name="file"></param>
    public override void Create(string path, BinaryFile file)
    {
    }

    /// <summary>
    /// Создать файл предпросмотра используя внешний генератор
    /// </summary>
    /// <param name="filePreviewDir">Путь до директории предпросмотра</param>
    /// <param name="file">Файл</param>
    /// <returns>Процесс внешнего генератора</returns>
    public virtual Process CreateWithExternalCreator(string filePreviewDir, BinaryFile file) => (Process) BaseFilePreviewCreatorEx.vuN0fMG2Km821coCy38Y((object) this, (object) filePreviewDir, (object) file, (object) null);

    /// <summary>
    /// Создать файл предпросмотра используя внешний генератор
    /// </summary>
    /// <param name="filePreviewDir">Путь до директории предпросмотра</param>
    /// <param name="file">Файл</param>
    /// <param name="password">Пароль для расшифровки файла</param>
    /// <returns>Процесс внешнего генератора</returns>
    protected virtual Process CreateWithExternalCreator(
      string filePreviewDir,
      BinaryFile file,
      string password)
    {
      int num = 7;
      Process withExternalCreator;
      string mainFileName;
      PackageService service;
      IElmaComponent elmaComponent;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            if (BaseFilePreviewCreatorEx.x6sSqQG2nlEBPdgWxldo(BaseFilePreviewCreatorEx.QPyE12G2kVnMhUXfTAYt((object) this, (object) file)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 11 : 3;
              continue;
            }
            goto case 13;
          case 3:
            goto label_14;
          case 4:
            mainFileName = this.GetMainFileName(filePreviewDir, file);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 1 : 2;
            continue;
          case 5:
            if (!BaseFilePreviewCreatorEx.z4hX3aG2amW9dREqrHyd((object) withExternalCreator))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 14 : 1;
              continue;
            }
            goto label_6;
          case 6:
            if (service == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 3;
              continue;
            }
            service.CheckInitialized();
            num = 9;
            continue;
          case 7:
            service = Locator.GetService<PackageService>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 6;
            continue;
          case 8:
            goto label_6;
          case 9:
            elmaComponent = (IElmaComponent) BaseFilePreviewCreatorEx.JPvUpKG2T3xvBtnJEylk((object) service, BaseFilePreviewCreatorEx.vGKQ2jG2XNiVKnJbbojC(813604817 ^ 813530189));
            num = 10;
            continue;
          case 10:
            if (elmaComponent != null)
            {
              num = 4;
              continue;
            }
            goto label_8;
          case 11:
          case 12:
            goto label_22;
          case 13:
            if (!BaseFilePreviewCreatorEx.x6sSqQG2nlEBPdgWxldo((object) mainFileName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
              continue;
            }
            goto label_22;
          case 14:
            goto label_7;
          default:
            if (BaseFilePreviewCreatorEx.x6sSqQG2nlEBPdgWxldo(BaseFilePreviewCreatorEx.FsdmwEG2O4XwhKLZLvxr((object) file)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 12 : 4;
              continue;
            }
            Process process = new Process();
            BaseFilePreviewCreatorEx.kcaAPiG2ebRZibrLQtco(BaseFilePreviewCreatorEx.JYLLofG22jn6BE43u4fc((object) process), (object) Path.Combine(elmaComponent.ComponentRoot, (string) BaseFilePreviewCreatorEx.QPyE12G2kVnMhUXfTAYt((object) this, (object) file)));
            BaseFilePreviewCreatorEx.AqtR86G23xOx7ved8OnW(BaseFilePreviewCreatorEx.JYLLofG22jn6BE43u4fc((object) process), password != null ? (object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360454083), (object) mainFileName, BaseFilePreviewCreatorEx.FsdmwEG2O4XwhKLZLvxr((object) file), (object) Convert.ToBase64String((byte[]) BaseFilePreviewCreatorEx.pEGsA6G2NuoftLsZsU0T(BaseFilePreviewCreatorEx.jp4ocHG21lqAGMsgdtIv(), (object) password))) : BaseFilePreviewCreatorEx.ja55gVG2PhaGu6nPSu6g(BaseFilePreviewCreatorEx.vGKQ2jG2XNiVKnJbbojC(-97972138 ^ -97848430), (object) mainFileName, BaseFilePreviewCreatorEx.FsdmwEG2O4XwhKLZLvxr((object) file)));
            BaseFilePreviewCreatorEx.jL4L8vG2pafGqo2x5bGt(BaseFilePreviewCreatorEx.JYLLofG22jn6BE43u4fc((object) process), false);
            withExternalCreator = process;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 3 : 5;
            continue;
        }
      }
label_6:
      return withExternalCreator;
label_7:
      return (Process) null;
label_8:
      return (Process) null;
label_14:
      return (Process) null;
label_22:
      return (Process) null;
    }

    protected BaseFilePreviewCreatorEx()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object vuN0fMG2Km821coCy38Y(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((BaseFilePreviewCreatorEx) obj0).CreateWithExternalCreator((string) obj1, (BinaryFile) obj2, (string) obj3);
    }

    internal static bool c1NtNEG2R7HDchLtTHdX() => BaseFilePreviewCreatorEx.s29K1GG2i4OR4h9UiLbK == null;

    internal static BaseFilePreviewCreatorEx ktSug3G2qxDpmB6vGvG8() => BaseFilePreviewCreatorEx.s29K1GG2i4OR4h9UiLbK;

    internal static object vGKQ2jG2XNiVKnJbbojC(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object JPvUpKG2T3xvBtnJEylk([In] object obj0, [In] object obj1) => (object) ((PackageService) obj0).GetComponent((string) obj1);

    internal static object QPyE12G2kVnMhUXfTAYt([In] object obj0, [In] object obj1) => (object) ((BaseFilePreviewCreatorEx) obj0).GetExternalCreatorFileName((BinaryFile) obj1);

    internal static bool x6sSqQG2nlEBPdgWxldo([In] object obj0) => ((string) obj0).IsNullOrEmpty();

    internal static object FsdmwEG2O4XwhKLZLvxr([In] object obj0) => (object) ((BinaryFile) obj0).ContentFilePath;

    internal static object JYLLofG22jn6BE43u4fc([In] object obj0) => (object) ((Process) obj0).StartInfo;

    internal static void kcaAPiG2ebRZibrLQtco([In] object obj0, [In] object obj1) => ((ProcessStartInfo) obj0).FileName = (string) obj1;

    internal static object ja55gVG2PhaGu6nPSu6g([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object jp4ocHG21lqAGMsgdtIv() => (object) Encoding.UTF8;

    internal static object pEGsA6G2NuoftLsZsU0T([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetBytes((string) obj1);

    internal static void AqtR86G23xOx7ved8OnW([In] object obj0, [In] object obj1) => ((ProcessStartInfo) obj0).Arguments = (string) obj1;

    internal static void jL4L8vG2pafGqo2x5bGt([In] object obj0, [In] bool obj1) => ((ProcessStartInfo) obj0).UseShellExecute = obj1;

    internal static bool z4hX3aG2amW9dREqrHyd([In] object obj0) => ((Process) obj0).Start();
  }
}
