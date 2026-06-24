// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.ServiceScope
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>Тип жизненного цикла в контейнере</summary>
  public enum ServiceScope
  {
    /// <summary>
    /// Один объект на контейнер (контейнер пересоздается при включении-отключении расширений)
    /// </summary>
    Shell,
    /// <summary>Один объект на приложение</summary>
    Application,
    /// <summary>Один экземпляр на каждое использование</summary>
    Transient,
    /// <summary>
    /// Один экземпляр на единицу работы (в Web будет один экземпляр на HTTP запрос)
    /// </summary>
    UnitOfWork,
  }
}
