// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.IAuditableEventHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>
  /// Обработчик перехвата методов с атрибутом <see cref="T:EleWise.ELMA.Events.Audit.AuditableAttribute" />
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  public interface IAuditableEventHandler : IEventHandler
  {
    /// <summary>Предобработка</summary>
    /// <param name="e">Параметры события</param>
    void Preprocess(AuditableCancelEventArgs e);

    /// <summary>Постобработка</summary>
    /// <param name="e">Параметры события</param>
    void Postprocess(AuditableEventArgs e);
  }
}
