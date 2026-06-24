// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.TestImportMessagesType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Deploy.Import
{
  /// <summary>Тип сообщения в результате проверки файла импорта</summary>
  [Serializable]
  public enum TestImportMessagesType
  {
    InfoCommon = 0,
    Warning = 1,
    Error = 2,
    InfoMetadata = 3,
    InfoLose = 4,
    InfoReboote = 5,
    UserAction = 6,
    SystemImportStatus = 30, // 0x0000001E
    Finish = 100, // 0x00000064
  }
}
