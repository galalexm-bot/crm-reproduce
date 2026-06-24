// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Messaging.IManageableMessageChannel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Messaging
{
  /// <summary>Интерфейс управляемого канала отправки сообщений</summary>
  public interface IManageableMessageChannel
  {
    /// <summary>Включен</summary>
    bool Enabled { get; }
  }
}
