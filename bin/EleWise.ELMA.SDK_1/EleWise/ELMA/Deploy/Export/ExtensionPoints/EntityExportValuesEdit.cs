// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.ExtensionPoints.EntityExportValuesEdit
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Export.ExtensionPoints
{
  [Component]
  public abstract class EntityExportValuesEdit : IEntityExportValuesEdit
  {
    private static EntityExportValuesEdit AsKmJJEU4dA3751wtWhW;

    public abstract Guid TypeUid { get; }

    public abstract void EditValues(Dictionary<string, object> values);

    protected EntityExportValuesEdit()
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

    internal static bool YpLKAYEU6HeVFPk0h3GD() => EntityExportValuesEdit.AsKmJJEU4dA3751wtWhW == null;

    internal static EntityExportValuesEdit CFLi2UEUHZcQw3RQHybW() => EntityExportValuesEdit.AsKmJJEU4dA3751wtWhW;
  }
}
