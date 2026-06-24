// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.FormScriptModuleType`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Templates;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.UI.Scripts
{
  /// <summary>Тип модуля сценариев для формы</summary>
  [Component]
  public abstract class FormScriptModuleType<TParams> : IScriptModuleType where TParams : FormScriptCodeGenerationParams
  {
    private static object wPNB1QYGvy4ccnTqYNO;

    /// <summary>Сгенерировать исходный код модуля сценариев</summary>
    /// <param name="p">Параметры генерации</param>
    /// <returns>Исходный код модуля сценариев</returns>
    public virtual string GenerateSourceCode(TParams p) => ResourceTemplateGenerator.GenerateTemplate<FormScriptModuleType<FormScriptCodeGenerationParams>>(this.TemplateFileName, (Func<string, string>) (s => this.ProcessTemplate(s, p)));

    /// <summary>
    /// Сгенерировать начальный исходный код для модуля сценариев
    /// </summary>
    /// <param name="parameters">Параметры</param>
    /// <returns>Исходный код</returns>
    public string GenerateSourceCode(object parameters) => this.GenerateSourceCode((TParams) parameters);

    public virtual ScriptCompileResult Compile(ScriptModule module) => throw new NotImplementedException();

    public abstract Guid Uid { get; }

    public abstract string Name { get; }

    protected abstract string TemplateFileName { get; }

    protected virtual string ProcessTemplate(string template, TParams p)
    {
      Contract.ArgumentNotNull((object) p, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1786868588));
      Contract.NotNull((object) p.Metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021424043));
      return template.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740319454), p.Metadata.Namespace).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837648533), p.Metadata.Name).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87844745), this.GetSummary(p));
    }

    protected abstract string GetSummary(TParams p);

    protected FormScriptModuleType()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool RK4KCJYEGOhX57L2tT1() => FormScriptModuleType<TParams>.wPNB1QYGvy4ccnTqYNO == null;

    internal static object j1ln5tYfAlvedcjAxdg() => FormScriptModuleType<TParams>.wPNB1QYGvy4ccnTqYNO;
  }
}
