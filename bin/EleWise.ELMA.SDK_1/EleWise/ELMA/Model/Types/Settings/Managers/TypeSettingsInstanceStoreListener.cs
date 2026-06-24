// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.Managers.TypeSettingsInstanceStoreListener
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Settings.Managers
{
  [Component]
  internal class TypeSettingsInstanceStoreListener : IUnitOfWorkEventListener
  {
    private static TypeSettingsInstanceStoreListener UZYyjpbWjEggAy0rFSH6;

    public void OnStartUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
    {
    }

    public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork) => TypeSettingsInstanceStoreListener.h82h31bWsJ3N7cMIHCMp(TypeSettingsInstanceStoreListener.BofdgMbWUJYpBcen7JWx());

    public void OnPostCommitUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnDisposeUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public TypeSettingsInstanceStoreListener()
    {
      TypeSettingsInstanceStoreListener.z0G6PobWcAxly63Pxo15();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object BofdgMbWUJYpBcen7JWx() => (object) TypeSettingsInstanceStoreManager.Instance;

    internal static void h82h31bWsJ3N7cMIHCMp([In] object obj0) => ((TypeSettingsInstanceStoreManager) obj0).SavePending();

    internal static void z0G6PobWcAxly63Pxo15() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool bcysWlbWYBEcOGEFlAWH() => TypeSettingsInstanceStoreListener.UZYyjpbWjEggAy0rFSH6 == null;

    internal static TypeSettingsInstanceStoreListener yHoQ4jbWLgA7n7jyxVpS() => TypeSettingsInstanceStoreListener.UZYyjpbWjEggAy0rFSH6;
  }
}
