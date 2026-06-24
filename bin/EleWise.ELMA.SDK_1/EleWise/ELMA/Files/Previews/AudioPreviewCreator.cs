// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.AudioPreviewCreator
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
  /// <summary>Отображение аудио файлов</summary>
  [Component]
  public class AudioPreviewCreator : BaseFilePreviewCreatorEx
  {
    private readonly Guid uid;
    internal static AudioPreviewCreator bYMFJTG2L8t8yArY6kjp;

    public override Guid Uid => this.uid;

    public override string DisplayName => (string) AudioPreviewCreator.r695hsG2zDLGBE5JtRcV(AudioPreviewCreator.fcvbLUG2c0YANoZWqIJK(-420743386 ^ -420998230));

    public override List<string> Extensions => new List<string>()
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138966230),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317537778),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475981805),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138200434)
    };

    public override bool EnableGenerateHtml() => false;

    public override string GetPreviewText(BinaryFile file) => (string) null;

    public override string PreviewDir => (string) null;

    public override string GetMainFileName(BinaryFile file) => file.ContentFilePath;

    public override string GetRelativeMainFileName(BinaryFile file) => (string) null;

    public override string GetTextFileName(string filePreviewDir, BinaryFile file) => (string) null;

    public override string GetTextFileName(BinaryFile file) => (string) null;

    public override bool RequiredExternalCreator => false;

    public AudioPreviewCreator()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.uid = new Guid((string) AudioPreviewCreator.fcvbLUG2c0YANoZWqIJK(-1886646897 ^ -1886394227));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object fcvbLUG2c0YANoZWqIJK(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object r695hsG2zDLGBE5JtRcV([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool jDTk2nG2UWlaGIdjXJdI() => AudioPreviewCreator.bYMFJTG2L8t8yArY6kjp == null;

    internal static AudioPreviewCreator xwd6KlG2sUB06qhJ8Bme() => AudioPreviewCreator.bYMFJTG2L8t8yArY6kjp;
  }
}
