// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Threading.IThreadPoolContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Threading
{
  /// <summary>
  /// Интерфейс объекта, содрежащего пул потоков для выполнения операций с данным объектом
  /// </summary>
  public interface IThreadPoolContainer
  {
    /// <summary>Получить пул потоков для исполнения данной работы</summary>
    IThreadPool Pool { get; }
  }
}
