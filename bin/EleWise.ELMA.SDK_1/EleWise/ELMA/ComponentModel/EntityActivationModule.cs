// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.EntityActivationModule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using Autofac.Core;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>Модуль перехвата активации сущностей</summary>
  internal class EntityActivationModule : Module
  {
    internal static EntityActivationModule MoiTa3fEx9ejHQUMK76g;

    protected override void AttachToComponentRegistration(
      IComponentRegistry componentRegistry,
      IComponentRegistration registration)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            registration.Activated += new EventHandler<ActivatedEventArgs<object>>(this.registration_Activated);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          case 2:
            registration.Activating += new EventHandler<ActivatingEventArgs<object>>(this.registration_Activating);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    private void handleRegistration(
      IEntity instance,
      Action<IEntityActivationHandler, IEntity> doForEach)
    {
      if (doForEach == null)
        return;
      foreach (IEntityActivationHandler activationHandler in ComponentManager.Current.GetExtensionPoints<IEntityActivationHandler>().Where<IEntityActivationHandler>((Func<IEntityActivationHandler, bool>) (h => h != null)))
        doForEach(activationHandler, instance);
    }

    private void registration_Activated(object sender, ActivatedEventArgs<object> e)
    {
      if (!(e.Instance is IEntity) || !ComponentManager.Initialized)
        return;
      this.handleRegistration((IEntity) e.Instance, (Action<IEntityActivationHandler, IEntity>) ((h, en) =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: reference to a compiler-generated method
              EntityActivationModule.\u003C\u003Ec.inU98P8rO8pUtAt0r5mw((object) h, (object) en);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
    }

    private void registration_Activating(object sender, ActivatingEventArgs<object> e)
    {
      if (!(e.Instance is IEntity) || !ComponentManager.Initialized)
        return;
      this.handleRegistration((IEntity) e.Instance, (Action<IEntityActivationHandler, IEntity>) ((h, en) =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: reference to a compiler-generated method
              EntityActivationModule.\u003C\u003Ec.uc64Tq8r2r1JLitc30yh((object) h, (object) en);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
    }

    public EntityActivationModule()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool UVnq7qfE0U8A8p3JELT3() => EntityActivationModule.MoiTa3fEx9ejHQUMK76g == null;

    internal static EntityActivationModule WkbIgEfEmrNyTrm6mQmS() => EntityActivationModule.MoiTa3fEx9ejHQUMK76g;
  }
}
