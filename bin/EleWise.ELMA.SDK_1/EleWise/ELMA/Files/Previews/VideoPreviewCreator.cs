// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.VideoPreviewCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Отображение видео файлов</summary>
  [Component]
  public class VideoPreviewCreator : BaseFilePreviewCreatorEx
  {
    private readonly Guid uid;
    internal static VideoPreviewCreator lDZMjjGeFyGt3Yn5429M;

    public override Guid Uid => this.uid;

    public override string DisplayName => EleWise.ELMA.SR.T((string) VideoPreviewCreator.OY10GiGeoIVRC3LpCN5B(-1120607109 - 305487170 ^ -1426300309));

    public override List<string> Extensions => new List<string>()
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583588494),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234145150)
    };

    public override string ExternalCreatorFileName => (string) null;

    public override bool EnableGenerateHtml() => false;

    public override string GetPreviewText(BinaryFile file) => (string) null;

    public override string PreviewDir => (string) null;

    public override string GetMainFileName(BinaryFile file) => (string) VideoPreviewCreator.LhI8MuGebiUEOERqg2n4((object) file);

    public override string GetRelativeMainFileName(BinaryFile file) => (string) null;

    public override string GetTextFileName(string filePreviewDir, BinaryFile file) => (string) null;

    public override string GetTextFileName(BinaryFile file) => (string) null;

    public override bool RequiredExternalCreator => false;

    public VideoPreviewCreator()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.uid = new Guid((string) VideoPreviewCreator.OY10GiGeoIVRC3LpCN5B(323422137 << 2 ^ 1293941572));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object OY10GiGeoIVRC3LpCN5B(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool qOyKyJGeBIMctcTC6qdx() => VideoPreviewCreator.lDZMjjGeFyGt3Yn5429M == null;

    internal static VideoPreviewCreator infkcKGeWvdCMCGvhlyK() => VideoPreviewCreator.lDZMjjGeFyGt3Yn5429M;

    internal static object LhI8MuGebiUEOERqg2n4([In] object obj0) => (object) ((BinaryFile) obj0).ContentFilePath;
  }
}
