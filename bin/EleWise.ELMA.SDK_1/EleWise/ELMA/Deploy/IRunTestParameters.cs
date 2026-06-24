// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.IRunTestParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Threading;

namespace EleWise.ELMA.Deploy
{
  /// <summary>Параметры запуска проверки конфигурации</summary>
  public interface IRunTestParameters
  {
    /// <summary>Ключ активации</summary>
    string ActivationKey { get; }

    /// <summary>Токен отмены</summary>
    CancellationToken CancellationToken { get; }
  }
}
