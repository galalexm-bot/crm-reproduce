// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.DynamicEntityManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Remoting;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>Менеджер динамических сущностей</summary>
  [Component]
  public class DynamicEntityManager : EternalRefObject, IConfigurationService
  {
    private static Dictionary<Guid, TypedDynamicEntityManager> managers;
    internal static DynamicEntityManager NXySJhhQlhFHgkCUK9rI;

    public static TypedDynamicEntityManager Typed(Guid typeUid) => (TypedDynamicEntityManager) DynamicEntityManager.Md8h0ZhQ5DtgrsZDREwq((object) Locator.GetServiceNotNull<DynamicEntityManager>(), typeUid);

    public virtual TypedDynamicEntityManager GetTypedManager(Guid typeUid)
    {
      int num1 = 2;
      bool lockTaken;
      Dictionary<Guid, TypedDynamicEntityManager> managers;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              managers = DynamicEntityManager.managers;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_6;
            default:
              goto label_5;
          }
        }
label_3:
        lockTaken = false;
        num1 = 3;
      }
label_5:
      TypedDynamicEntityManager typedManager;
      return typedManager;
label_6:
      try
      {
        Monitor.Enter((object) managers, ref lockTaken);
        int num3 = 3;
        TypedDynamicEntityManager dynamicEntityManager;
        while (true)
        {
          switch (num3)
          {
            case 1:
              DynamicEntityManager.managers[typeUid] = dynamicEntityManager;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 2 : 2;
              continue;
            case 2:
              typedManager = dynamicEntityManager;
              num3 = 4;
              continue;
            case 3:
              if (!DynamicEntityManager.managers.TryGetValue(typeUid, out dynamicEntityManager))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 4:
              goto label_5;
            default:
              dynamicEntityManager = new TypedDynamicEntityManager(typeUid);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 1 : 0;
              continue;
          }
        }
      }
      finally
      {
        int num4;
        if (!lockTaken)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
        else
          goto label_16;
label_15:
        switch (num4)
        {
          case 1:
            break;
          default:
        }
label_16:
        DynamicEntityManager.CfBCs7hQjgBvH6d2MTaB((object) managers);
        num4 = 2;
        goto label_15;
      }
    }

    public DynamicEntityManager()
    {
      DynamicEntityManager.MLwWGjhQY5aVRKx5hOLj();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static DynamicEntityManager()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DynamicEntityManager.MLwWGjhQY5aVRKx5hOLj();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            DynamicEntityManager.managers = new Dictionary<Guid, TypedDynamicEntityManager>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static object Md8h0ZhQ5DtgrsZDREwq([In] object obj0, Guid typeUid) => (object) ((DynamicEntityManager) obj0).GetTypedManager(typeUid);

    internal static bool E4HNewhQrObSFvpcTnjV() => DynamicEntityManager.NXySJhhQlhFHgkCUK9rI == null;

    internal static DynamicEntityManager YqpOJmhQgtDeuHIFeRY9() => DynamicEntityManager.NXySJhhQlhFHgkCUK9rI;

    internal static void CfBCs7hQjgBvH6d2MTaB([In] object obj0) => Monitor.Exit(obj0);

    internal static void MLwWGjhQY5aVRKx5hOLj() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
