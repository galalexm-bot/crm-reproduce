// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Actions.Impl.EntityManagerActionsStorage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Actions.Impl
{
  internal class EntityManagerActionsStorage : IEntityManagerTypesStorage
  {
    [NotNull]
    private readonly ISet<Type> entityManagerTypes;
    private static EntityManagerActionsStorage XSPpDtf4fvGQdSIuck7Z;

    internal void AddManagerType(Type managerType)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_5;
            case 1:
              this.entityManagerTypes.Add(managerType);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              if (typeof (IEntityManager).IsAssignableFrom(managerType))
                goto case 1;
              else
                goto label_7;
            default:
              goto label_8;
          }
        }
label_7:
        num1 = 2;
      }
label_5:
      return;
label_3:
      return;
label_8:;
    }

    public IEnumerable<Type> GetManagerTypes() => (IEnumerable<Type>) this.entityManagerTypes;

    public EntityManagerActionsStorage()
    {
      EntityManagerActionsStorage.jSEM0Mf4vDlG4nKIvOIn();
      this.entityManagerTypes = PublishCacheContext.CreateCache<Type>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool xrM6EFf4QcroM0dUonkj() => EntityManagerActionsStorage.XSPpDtf4fvGQdSIuck7Z == null;

    internal static EntityManagerActionsStorage bxsKORf4CROUUX2VqgtU() => EntityManagerActionsStorage.XSPpDtf4fvGQdSIuck7Z;

    internal static void jSEM0Mf4vDlG4nKIvOIn() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
