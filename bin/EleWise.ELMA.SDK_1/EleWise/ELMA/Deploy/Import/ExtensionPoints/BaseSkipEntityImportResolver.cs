// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.BaseSkipEntityImportResolver
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate.Util;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  public abstract class BaseSkipEntityImportResolver : ISkipEntityImportResolver
  {
    private static BaseSkipEntityImportResolver lZbXWgElMUkYL6j40RyK;

    public abstract bool IsSupported(Guid typeGuid);

    public abstract bool IsSkip(
      Dictionary<string, object> propValues,
      Dictionary<string, string> serviceData);

    /// <summary>Получить Id из свойств</summary>
    /// <param name="propValues"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    protected virtual Guid GetId(Dictionary<string, object> propValues, string key)
    {
      Guid result = Guid.Empty;
      if (propValues.ContainsKey(key) && propValues[key] != null && (!(propValues[key] is IDictionary propValue) || propValue.Values.Count <= 0 || !Guid.TryParse(propValue.Values.First().ToString(), out result)))
        Guid.TryParse(propValues[key].ToString(), out result);
      return result;
    }

    protected BaseSkipEntityImportResolver()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool FTWC1BElJf2LxfXHlAuC() => BaseSkipEntityImportResolver.lZbXWgElMUkYL6j40RyK == null;

    internal static BaseSkipEntityImportResolver cqC8d6El9xJRcUbCyIe4() => BaseSkipEntityImportResolver.lZbXWgElMUkYL6j40RyK;
  }
}
