// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Entities.EntityScriptModule`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Scripts.Entities
{
  /// <summary>Базовый класс модуля сценариев сущности</summary>
  /// <typeparam name="TEntity">Тип сущности</typeparam>
  public abstract class EntityScriptModule<TEntity> : NHManager, IManager where TEntity : IEntity
  {
    private static object oiIuTCbP1jHWYQsO3MLp;

    [Obsolete]
    protected ScriptBase.LoggerClass get_Logger() => ScriptBase.LoggerClass.Instance;

    protected EntityScriptModule()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool INCIRPbPN6jySq0N0nES() => EntityScriptModule<TEntity>.oiIuTCbP1jHWYQsO3MLp == null;

    internal static object y360v1bP3WPw9v1ap2cg() => EntityScriptModule<TEntity>.oiIuTCbP1jHWYQsO3MLp;

    protected static class Logger
    {
      public static ILogger Log => ScriptLogger.Log;
    }
  }
}
