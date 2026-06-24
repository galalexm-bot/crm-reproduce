// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Actions.Impl.EntityManagerActionsCollectModule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using Autofac.Core;
using EleWise.ELMA.Model.Managers;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Actions.Impl
{
  internal class EntityManagerActionsCollectModule : Module
  {
    private EntityManagerActionsStorage _actionsStorage;
    private static EntityManagerActionsCollectModule o2gC6KfwzrrlbPrJVPOj;

    protected override void AttachToComponentRegistration(
      IComponentRegistry componentRegistry,
      IComponentRegistration registration)
    {
      int num1 = 1;
      IEnumerator<Service> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_22;
          case 1:
            if (registration == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            IEnumerable<Service> services = registration.Services;
            // ISSUE: reference to a compiler-generated field
            Func<Service, bool> func = EntityManagerActionsCollectModule.\u003C\u003Ec.\u003C\u003E9__1_0;
            Func<Service, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              EntityManagerActionsCollectModule.\u003C\u003Ec.\u003C\u003E9__1_0 = predicate = (Func<Service, bool>) (s =>
              {
                int num2 = 1;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      if (!(s is TypedService))
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_2;
                    case 2:
                      goto label_2;
                    default:
                      goto label_3;
                  }
                }
label_2:
                // ISSUE: reference to a compiler-generated method
                return typeof (IEntityManager).IsAssignableFrom(EntityManagerActionsCollectModule.\u003C\u003Ec.v2Jvf3ZfxcjidUApNqB6((object) (TypedService) s));
label_3:
                return false;
              });
            }
            else
              goto label_2;
label_24:
            enumerator = services.Where<Service>(predicate).GetEnumerator();
            num1 = 3;
            continue;
label_2:
            predicate = func;
            goto label_24;
          case 3:
            goto label_3;
          case 4:
            goto label_16;
          default:
            goto label_11;
        }
      }
label_22:
      return;
label_16:
      return;
label_11:
      return;
label_3:
      try
      {
label_9:
        if (EntityManagerActionsCollectModule.Aq3TDXf4b36crmFBuKi2((object) enumerator))
          goto label_7;
        else
          goto label_10;
label_4:
        TypedService current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_5;
            case 2:
              goto label_9;
            case 3:
              goto label_7;
            default:
              EntityManagerActionsCollectModule.BiOcG8f4oh5W7Aeos47D((object) this._actionsStorage, EntityManagerActionsCollectModule.XrBOSZf4WIyJpPIvSnrB((object) current));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 2 : 2;
              continue;
          }
        }
label_5:
        return;
label_7:
        current = (TypedService) enumerator.Current;
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
        {
          num3 = 0;
          goto label_4;
        }
        else
          goto label_4;
label_10:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 0;
        goto label_4;
      }
      finally
      {
        if (enumerator != null)
        {
          int num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                EntityManagerActionsCollectModule.MQCjuEf4h9pIMvxNLsu6((object) enumerator);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
                continue;
              default:
                goto label_18;
            }
          }
        }
label_18:;
      }
    }

    protected override void Load(ContainerBuilder builder)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._actionsStorage = new EntityManagerActionsStorage();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          case 2:
            EntityManagerActionsCollectModule.NfWgvif4Gi8pXGwXdcJD((object) this, (object) builder);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            builder.RegisterInstance<EntityManagerActionsStorage>(this._actionsStorage).As<IEntityManagerTypesStorage>().As<EntityManagerActionsStorage>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 1 : 3;
            continue;
        }
      }
label_2:;
    }

    public EntityManagerActionsCollectModule()
    {
      EntityManagerActionsCollectModule.nUHS06f4E8eI0pwipvDK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type XrBOSZf4WIyJpPIvSnrB([In] object obj0) => ((TypedService) obj0).ServiceType;

    internal static void BiOcG8f4oh5W7Aeos47D([In] object obj0, Type managerType) => ((EntityManagerActionsStorage) obj0).AddManagerType(managerType);

    internal static bool Aq3TDXf4b36crmFBuKi2([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void MQCjuEf4h9pIMvxNLsu6([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool XlGyEEf4F5GGFo147TeR() => EntityManagerActionsCollectModule.o2gC6KfwzrrlbPrJVPOj == null;

    internal static EntityManagerActionsCollectModule PFEyZ6f4BE2sJsxDejxu() => EntityManagerActionsCollectModule.o2gC6KfwzrrlbPrJVPOj;

    internal static void NfWgvif4Gi8pXGwXdcJD([In] object obj0, [In] object obj1) => __nonvirtual (((Module) obj0).Load((ContainerBuilder) obj1));

    internal static void nUHS06f4E8eI0pwipvDK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
