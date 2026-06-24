// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.StructuredFileFolder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Files
{
  /// <summary>Описание папки структурированного файла</summary>
  [Serializable]
  public sealed class StructuredFileFolder
  {
    internal static StructuredFileFolder FKmm1WGKGvK7ueDDveY9;

    /// <summary>Ctor</summary>
    public StructuredFileFolder()
    {
      StructuredFileFolder.OquG1uGKQh4kfJRPD73w();
      // ISSUE: reference to a compiler-generated field
      this.\u003CFolders\u003Ek__BackingField = new List<StructuredFileFolder>();
      // ISSUE: reference to a compiler-generated field
      this.\u003CFiles\u003Ek__BackingField = new List<StructuredFileFile>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Имя папки</summary>
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
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

    /// <summary>Вложенные папки</summary>
    public List<StructuredFileFolder> Folders { get; set; }

    /// <summary>Вложенные файлы</summary>
    public List<StructuredFileFile> Files { get; set; }

    internal static void OquG1uGKQh4kfJRPD73w() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool o4SMxlGKEcFKx4mgYIAt() => StructuredFileFolder.FKmm1WGKGvK7ueDDveY9 == null;

    internal static StructuredFileFolder k6YEXNGKfNU87WOeIAJ4() => StructuredFileFolder.FKmm1WGKGvK7ueDDveY9;
  }
}
