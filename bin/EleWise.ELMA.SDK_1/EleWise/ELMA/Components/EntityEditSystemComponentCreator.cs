// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.EntityEditSystemComponentCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Components
{
  /// <summary>
  /// Создание системного компонента для отображения формы редактирования сущности
  /// </summary>
  [Component]
  internal sealed class EntityEditSystemComponentCreator : AbstractEntitySystemComponentCreator
  {
    private static EntityEditSystemComponentCreator D1Snl4fb0lhsumPXbJ7D;

    /// <inheritdoc />
    protected override Guid ComponentUid => EntitySystemComponentConstants.EditUid;

    /// <inheritdoc />
    protected override string ComponentMetadataName => (string) EntityEditSystemComponentCreator.t0jHEhfbMOknFWqbCk2R(-1824388195 ^ -1824052707);

    /// <inheritdoc />
    protected override string ComponentDisplayName => (string) EntityEditSystemComponentCreator.cOQ6j2fbJsNk381JGP8p(EntityEditSystemComponentCreator.t0jHEhfbMOknFWqbCk2R(1505778440 - 1981636111 ^ -475538101));

    /// <inheritdoc />
    protected override ViewType ViewType => ViewType.Edit;

    public EntityEditSystemComponentCreator()
    {
      EntityEditSystemComponentCreator.wVZwrLfb9BlKQ5uZK0hc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object t0jHEhfbMOknFWqbCk2R(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool qAMq31fbmIPqX6hYOVHy() => EntityEditSystemComponentCreator.D1Snl4fb0lhsumPXbJ7D == null;

    internal static EntityEditSystemComponentCreator GVeb9ffbyFqaUXTWnXnU() => EntityEditSystemComponentCreator.D1Snl4fb0lhsumPXbJ7D;

    internal static object cOQ6j2fbJsNk381JGP8p([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void wVZwrLfb9BlKQ5uZK0hc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
