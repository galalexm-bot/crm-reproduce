// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.EntityDisplaySystemComponentCreator
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
  /// Создание системного компонента для отображения формы просмотра сущности
  /// </summary>
  [Component]
  internal sealed class EntityDisplaySystemComponentCreator : AbstractEntitySystemComponentCreator
  {
    internal static EntityDisplaySystemComponentCreator xdPve5fb6QfdHJsEHXrC;

    /// <inheritdoc />
    protected override Guid ComponentUid => EntitySystemComponentConstants.DisplayUid;

    /// <inheritdoc />
    protected override string ComponentMetadataName => (string) EntityDisplaySystemComponentCreator.MY2Bgqfb78O9iwt0L31K(-1638402543 ^ -1638738193);

    /// <inheritdoc />
    protected override string ComponentDisplayName => EleWise.ELMA.SR.T((string) EntityDisplaySystemComponentCreator.MY2Bgqfb78O9iwt0L31K(1470440286 ^ 1470104168));

    /// <inheritdoc />
    protected override ViewType ViewType => ViewType.Display;

    public EntityDisplaySystemComponentCreator()
    {
      EntityDisplaySystemComponentCreator.u818w9fbxo7Bic8yJnHb();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object MY2Bgqfb78O9iwt0L31K(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool a6de20fbHRvvfFqtCbc2() => EntityDisplaySystemComponentCreator.xdPve5fb6QfdHJsEHXrC == null;

    internal static EntityDisplaySystemComponentCreator XF2x2vfbAIG43dRJG7mg() => EntityDisplaySystemComponentCreator.xdPve5fb6QfdHJsEHXrC;

    internal static void u818w9fbxo7Bic8yJnHb() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
