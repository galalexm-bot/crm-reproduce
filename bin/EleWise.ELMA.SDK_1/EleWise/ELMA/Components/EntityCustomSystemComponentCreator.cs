// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.EntityCustomSystemComponentCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Components
{
  /// <summary>
  /// Создание системного компонента для отображения кастомной формы сущности
  /// </summary>
  [Component]
  internal sealed class EntityCustomSystemComponentCreator : AbstractEntitySystemComponentCreator
  {
    private static EntityCustomSystemComponentCreator mBrWvMfbtlsJOXtJpoGj;

    /// <inheritdoc />
    protected override Guid ComponentUid => EntitySystemComponentConstants.CustomUid;

    /// <inheritdoc />
    protected override string ComponentMetadataName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439803476);

    /// <inheritdoc />
    protected override string ComponentDisplayName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217711711);

    /// <inheritdoc />
    protected override ViewType ViewType => ViewType.Custom;

    public EntityCustomSystemComponentCreator()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool bdTpo0fbwgKT0G4WIKQ1() => EntityCustomSystemComponentCreator.mBrWvMfbtlsJOXtJpoGj == null;

    internal static EntityCustomSystemComponentCreator DsmtPgfb4dHOsDo9lTCY() => EntityCustomSystemComponentCreator.mBrWvMfbtlsJOXtJpoGj;
  }
}
