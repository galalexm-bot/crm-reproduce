// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Manager.IGlobalScriptModuleManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.Model.Scripts.Manager
{
  /// <summary>
  /// Интерфейс менеджера глобоальных модулей сценариев <see cref="T:EleWise.ELMA.Model.Scripts.IGlobalScriptModule" />
  /// </summary>
  internal interface IGlobalScriptModuleManager : 
    IEntityManager<IGlobalScriptModule, long>,
    IEntityManager<IGlobalScriptModule>,
    IEntityManager
  {
    /// <summary>Сформировать сборку глоабльного модуля сценариев</summary>
    /// <param name="globalScriptModule">Глобальный модуль сценариев</param>
    void GenerateGlobalScriptModuleAssembly(IGlobalScriptModule globalScriptModule);
  }
}
