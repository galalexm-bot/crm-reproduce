// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Mappings.PropertyMapExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Mappings
{
  /// <summary>Расширение PropertyMap</summary>
  public static class PropertyMapExtensions
  {
    /// <summary>Заменить контекстные переменные</summary>
    /// <param name="propertyMap">Карта свойств</param>
    /// <param name="replaceContextVarMap">Карта заменяемых контекстных переменных</param>
    public static void ReplaceContextVars(
      this PropertyMap propertyMap,
      Dictionary<Guid, Guid> replaceContextVarMap)
    {
      Guid guid;
      if (replaceContextVarMap.TryGetValue(propertyMap.RightClassUid, out guid))
        propertyMap.RightClassUid = guid;
      if (replaceContextVarMap.TryGetValue(propertyMap.LeftClassUid, out guid))
        propertyMap.LeftClassUid = guid;
      foreach (PropertyMapItem propertyMapItem in propertyMap.Items)
      {
        Guid leftPropertyUid = propertyMapItem.LeftPropertyUid;
        if (replaceContextVarMap.TryGetValue(leftPropertyUid, out guid))
          propertyMapItem.LeftPropertyUid = guid;
        Guid rightPropertyUid = propertyMapItem.RightPropertyUid;
        if (replaceContextVarMap.TryGetValue(rightPropertyUid, out guid))
          propertyMapItem.RightPropertyUid = guid;
      }
    }
  }
}
