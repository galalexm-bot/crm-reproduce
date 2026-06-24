// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.EntityObjectFormProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>
  /// Провайдер форм для <see cref="T:EleWise.ELMA.Model.Entities.IEntity" />
  /// </summary>
  [Component(Order = 2147483647)]
  internal sealed class EntityObjectFormProvider : AbstractObjectFormProvider<IEntity>
  {
    internal static EntityObjectFormProvider efBBubGpKgyYtiXpgxXt;

    /// <inheritdoc />
    public EntityObjectFormProvider(
      IMetadataRuntimeService metadataRuntimeService,
      ViewModelDescriptor viewModelDescriptor)
    {
      EntityObjectFormProvider.soJq97GpkoQsZr0JjPCm();
      // ISSUE: explicit constructor call
      base.\u002Ector(metadataRuntimeService, viewModelDescriptor);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <inheritdoc />
    protected override FormViewItem Transform(
      ClassMetadata metadata,
      FormViewItem formViewItem,
      ViewType viewType = ViewType.Custom,
      ItemType itemType = ItemType.Default)
    {
      int num = 1;
      while (true)
      {
        FormViewItem formViewItem1;
        switch (num)
        {
          case 1:
            FormViewItem formViewItem2 = formViewItem;
            if (formViewItem2 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
              continue;
            }
            formViewItem1 = formViewItem2;
            break;
          case 2:
            goto label_2;
          default:
            formViewItem1 = new FormViewItemBuilder(EntityObjectFormProvider.timG60GpnKgThb1i7x9k((object) metadata), viewType).DefaultContainer().FormView;
            break;
        }
        formViewItem = formViewItem1;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 2 : 0;
      }
label_2:
      return base.Transform(metadata, formViewItem, viewType, itemType);
    }

    internal static void soJq97GpkoQsZr0JjPCm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool gPWLhoGpXmvmtP0mJ1T1() => EntityObjectFormProvider.efBBubGpKgyYtiXpgxXt == null;

    internal static EntityObjectFormProvider MQqNsgGpTiii3vcBqWYn() => EntityObjectFormProvider.efBBubGpKgyYtiXpgxXt;

    internal static Guid timG60GpnKgThb1i7x9k([In] object obj0) => ((AbstractMetadata) obj0).Uid;
  }
}
