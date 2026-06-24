// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.CallContextType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Тип блока обработки</summary>
  public enum CallContextType
  {
    /// <summary>Веб-запрос</summary>
    [DisplayName("Web Request")] WebRequest,
    /// <summary>Фоновый поток</summary>
    [DisplayName("Background thread")] Background,
    /// <summary>
    /// Фоновая задача.
    /// В данную группу попадают задачи обернутые в EleWise.ELMA.Threading.BackgroundTask
    /// </summary>
    [DisplayName("Background task")] BackgroundTask,
    /// <summary>Дочерняя сессия диагностики</summary>
    [DisplayName("User diagnostics subsession")] SubContext,
  }
}
