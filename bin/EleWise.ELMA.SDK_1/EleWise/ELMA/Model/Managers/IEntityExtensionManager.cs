// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.IEntityExtensionManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events.Audit;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>Менеджер сущности-расширения</summary>
  public interface IEntityExtensionManager
  {
    /// <summary>Предобработка действия в основном менеджере</summary>
    /// <param name="e">Параметры события</param>
    void Preprocess(AuditableCancelEventArgs e);

    /// <summary>Постобработка действия в основном менеджере</summary>
    /// <param name="e">Параметры события</param>
    void Postprocess(AuditableEventArgs e);
  }
}
