// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.BinaryFileSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Настройки типа "Файл"</summary>
  [Serializable]
  public class BinaryFileSettings : SimpleTypeSettings
  {
    internal static BinaryFileSettings OoUi69bFqM6FluBNXcrc;

    /// <summary>Ctor</summary>
    public BinaryFileSettings()
    {
      BinaryFileSettings.S4UpHdbFTDPUtAnhc0x9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected BinaryFileSettings(SerializationInfo info, StreamingContext context)
    {
      BinaryFileSettings.S4UpHdbFTDPUtAnhc0x9();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Загружать целиком папку и запаковывать в Zip архив</summary>
    public bool FolderZip
    {
      get => this.\u003CFolderZip\u003Ek__BackingField;
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
              this.\u003CFolderZip\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
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

    /// <summary>Допустимые расширения файла (пример: .txt,.png)</summary>
    public string FileExtensions
    {
      get => this.\u003CFileExtensions\u003Ek__BackingField;
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
              this.\u003CFileExtensions\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
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

    internal static void S4UpHdbFTDPUtAnhc0x9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool jTgZwybFKLrntar9oYgI() => BinaryFileSettings.OoUi69bFqM6FluBNXcrc == null;

    internal static BinaryFileSettings Oh9sYgbFXlVLHv3Gh2jU() => BinaryFileSettings.OoUi69bFqM6FluBNXcrc;
  }
}
