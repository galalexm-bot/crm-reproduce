// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.SchedulerJobBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Scheduling
{
  public abstract class SchedulerJobBase : ISchedulerJob, IHiddenSchedulerJob
  {
    internal static SchedulerJobBase oXXw3ABK9GSdrbYI83fx;

    public virtual Guid? OwnerUid => new Guid?();

    public abstract ITrigger Trigger { get; }

    public abstract ICollection<IJob> Jobs { get; }

    public virtual bool Hidden => false;

    protected SchedulerJobBase()
    {
      SchedulerJobBase.B39bJkBKrvM5vWW11NXa();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void B39bJkBKrvM5vWW11NXa() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool hhePJgBKd2kPlFc2TJBM() => SchedulerJobBase.oXXw3ABK9GSdrbYI83fx == null;

    internal static SchedulerJobBase uEx0lxBKlihPGHmtmrP3() => SchedulerJobBase.oXXw3ABK9GSdrbYI83fx;
  }
}
