// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.ExcelFilePreviewCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Aspose.Cells;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Создаем превью для Excel-файлов</summary>
  [Component(Order = 100)]
  public class ExcelFilePreviewCreator : BasePasswordFilePreviewCreatorEx
  {
    /// <summary>UID создателя превью</summary>
    public static Guid UID;
    private static ExcelFilePreviewCreator QytB6rG1Oo5nc8pqmIlF;

    /// <inheritdoc />
    public override Guid Uid => ExcelFilePreviewCreator.UID;

    /// <inheritdoc />
    public override string DisplayName => EleWise.ELMA.SR.T((string) ExcelFilePreviewCreator.SsHG3dG1PW5RSyA5li0e(-477139494 ^ -477329744));

    /// <inheritdoc />
    public override List<string> Extensions => new List<string>()
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583696310),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173566603),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309810144),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882361656)
    };

    /// <inheritdoc />
    public override string ExternalCreatorFileName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289888804);

    /// <inheritdoc />
    public override bool CheckPassword(BinaryFile file, string password)
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!FileFormatUtil.DetectFileFormat((string) ExcelFilePreviewCreator.DoML5XG1NKxS9e66OSLL((object) file)).IsEncrypted)
            {
              num1 = 6;
              continue;
            }
            if (password != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 1 : 3;
              continue;
            }
            goto label_12;
          case 2:
            if (!ExcelFilePreviewCreator.VnMANgG11nh9EyrTfFXx((object) file.ContentFilePath))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
              continue;
            }
            goto label_15;
          case 3:
            num1 = 5;
            continue;
          case 4:
            goto label_12;
          case 5:
            goto label_2;
          case 6:
            goto label_20;
          case 7:
            goto label_14;
          default:
            goto label_15;
        }
      }
label_2:
      bool flag;
      try
      {
        string contentFilePath = file.ContentFilePath;
        LoadOptions loadOptions = new LoadOptions();
        ExcelFilePreviewCreator.DAJrxpG13s1AfmkFlBVa((object) loadOptions, (object) password);
        Workbook workbook = new Workbook(contentFilePath, loadOptions);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_14;
            default:
              flag = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 1;
              continue;
          }
        }
      }
      catch (CellsException ex)
      {
        if (ExcelFilePreviewCreator.KyvqRQG1pMOocovLkDXy((object) ex) == Aspose.Cells.ExceptionType.IncorrectPassword)
        {
          int num3 = 2;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_14;
              case 2:
                flag = false;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
                continue;
              default:
                goto label_11;
            }
          }
        }
label_11:
        throw;
      }
label_12:
      return false;
label_14:
      return flag;
label_15:
      return password == null;
label_20:
      return password == null;
    }

    public ExcelFilePreviewCreator()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ExcelFilePreviewCreator()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ExcelFilePreviewCreator.a8fPOJG1aTn7DdWSllDC();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ExcelFilePreviewCreator.UID = new Guid((string) ExcelFilePreviewCreator.SsHG3dG1PW5RSyA5li0e(-1317790512 ^ -1317539620));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object SsHG3dG1PW5RSyA5li0e(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool bWfsykG12MUIc2DtB9NF() => ExcelFilePreviewCreator.QytB6rG1Oo5nc8pqmIlF == null;

    internal static ExcelFilePreviewCreator mp3txaG1evtCuSvbmxS3() => ExcelFilePreviewCreator.QytB6rG1Oo5nc8pqmIlF;

    internal static bool VnMANgG11nh9EyrTfFXx([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object DoML5XG1NKxS9e66OSLL([In] object obj0) => (object) ((BinaryFile) obj0).ContentFilePath;

    internal static void DAJrxpG13s1AfmkFlBVa([In] object obj0, [In] object obj1) => ((LoadOptions) obj0).Password = (string) obj1;

    internal static Aspose.Cells.ExceptionType KyvqRQG1pMOocovLkDXy([In] object obj0) => ((CellsException) obj0).Code;

    internal static void a8fPOJG1aTn7DdWSllDC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
