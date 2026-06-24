// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Design.Components.IProgressDialog
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Design.Components
{
  /// <summary>Интерфейс диалога с прогресс-баром</summary>
  public interface IProgressDialog : IDisposable
  {
    /// <summary>Получить или установить текст сообщения</summary>
    string Message { get; set; }

    /// <summary>Прервать</summary>
    void Terminate();
  }
}
