// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.EntityCreateSystemComponentCreator
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
  /// Создание системного компонента для отображения формы создания сущности
  /// </summary>
  [Component]
  internal sealed class EntityCreateSystemComponentCreator : AbstractEntitySystemComponentCreator
  {
    private static EntityCreateSystemComponentCreator lWIE0Nfb1lIUV9bODx0j;

    /// <inheritdoc />
    protected override Guid ComponentUid => EntitySystemComponentConstants.CreateUid;

    /// <inheritdoc />
    protected override string ComponentMetadataName => (string) EntityCreateSystemComponentCreator.UZQOxIfbpufJUOgeLeBo(-1852837372 ^ -1853166112);

    /// <inheritdoc />
    protected override string ComponentDisplayName => (string) EntityCreateSystemComponentCreator.zOTKw7fbakkPfE3Adfye(EntityCreateSystemComponentCreator.UZQOxIfbpufJUOgeLeBo(572119659 - -337058038 ^ 909497211));

    /// <inheritdoc />
    protected override ViewType ViewType => ViewType.Create;

    public EntityCreateSystemComponentCreator()
    {
      EntityCreateSystemComponentCreator.zbh9Y3fbDrxURMHput1M();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object UZQOxIfbpufJUOgeLeBo(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool pitHUPfbNbRlarfc1ZY0() => EntityCreateSystemComponentCreator.lWIE0Nfb1lIUV9bODx0j == null;

    internal static EntityCreateSystemComponentCreator p13fXFfb3fF5jKaUNKlW() => EntityCreateSystemComponentCreator.lWIE0Nfb1lIUV9bODx0j;

    internal static object zOTKw7fbakkPfE3Adfye([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void zbh9Y3fbDrxURMHput1M() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
