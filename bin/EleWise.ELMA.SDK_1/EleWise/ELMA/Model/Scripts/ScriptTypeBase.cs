// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.ScriptTypeBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Базовая реализация для типа сценариев</summary>
  public abstract class ScriptTypeBase : IScriptType
  {
    private static ScriptTypeBase DwjmXdbize0r4m5rO0XV;

    /// <summary>Уникальный идентификатор типа сценария</summary>
    public abstract Guid Uid { get; }

    /// <summary>Отображаемое имя</summary>
    public abstract string Name { get; }

    /// <summary>
    /// Перечисляются полные имена сборок ELMA которые нужно добавить референсы
    /// </summary>
    public virtual string ListReferenceAdd => (string) null;

    /// <summary>Сгенерировать определение метода</summary>
    /// <param name="name">Имя метода</param>
    /// <param name="generationParams">Дополнительные параметры генерации</param>
    /// <returns>Определение метода</returns>
    public abstract ScriptMethodDeclaration GenerateMethod(
      string name,
      IDictionary<string, object> generationParams = null);

    /// <summary>
    /// Получить значение параметра. Если параметр не найден, возвращается null.
    /// </summary>
    /// <param name="generationParams"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    protected object GetParameterValue(IDictionary<string, object> generationParams, string name)
    {
      if (generationParams == null)
        return (object) null;
      object parameterValue;
      generationParams.TryGetValue(name, out parameterValue);
      return parameterValue;
    }

    protected ScriptTypeBase()
    {
      ScriptTypeBase.b7ABaebRW1tCmaHfi1uZ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void b7ABaebRW1tCmaHfi1uZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool JOQTfIbRF8C627oRfVTk() => ScriptTypeBase.DwjmXdbize0r4m5rO0XV == null;

    internal static ScriptTypeBase byxjUQbRBOXyxNtf5YX1() => ScriptTypeBase.DwjmXdbize0r4m5rO0XV;
  }
}
