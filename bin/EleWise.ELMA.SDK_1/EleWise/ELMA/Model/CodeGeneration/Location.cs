// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.Location
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>A program location in source code.</summary>
  [Serializable]
  public class Location
  {
    private static Location FAuZ7HhPfq3ueTbU2r1J;

    /// <summary>The path of the source document file.</summary>
    public string FilePath
    {
      get => this.\u003CFilePath\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CFilePath\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>The character position within the line.</summary>
    public int Character
    {
      get => this.\u003CCharacter\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CCharacter\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// The line number. The first line in a file is defined as line 0 (zero based line numbering).
    /// </summary>
    public int Line
    {
      get => this.\u003CLine\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CLine\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Get the text of the location.</summary>
    public override string ToString() => (string) Location.yCsB8ehP8I7GMsFpp0BR((object) new object[6]
    {
      (object) this.FilePath,
      (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606654806),
      (object) this.Line,
      Location.MIF0yyhPvHxyAAdJ2mMf(-1317790512 ^ -1317777888),
      (object) this.Character,
      Location.MIF0yyhPvHxyAAdJ2mMf(--1867379187 ^ 1867426913)
    });

    public Location()
    {
      Location.wOdTNAhPZfL5vrXJZdr2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool BcNXM6hPQ26gD2cuxbxI() => Location.FAuZ7HhPfq3ueTbU2r1J == null;

    internal static Location xE0psWhPCa71n16GXjCJ() => Location.FAuZ7HhPfq3ueTbU2r1J;

    internal static object MIF0yyhPvHxyAAdJ2mMf(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object yCsB8ehP8I7GMsFpp0BR([In] object obj0) => (object) string.Concat((object[]) obj0);

    internal static void wOdTNAhPZfL5vrXJZdr2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
