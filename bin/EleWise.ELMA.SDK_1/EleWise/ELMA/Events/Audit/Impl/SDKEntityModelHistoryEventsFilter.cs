// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.Impl.SDKEntityModelHistoryEventsFilter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Events.Audit.Impl
{
  [Component]
  internal class SDKEntityModelHistoryEventsFilter : EntityModelHistoryEventsFilterBase
  {
    private static SDKEntityModelHistoryEventsFilter ik3qVkGc5QKW8dItV5nl;

    protected override Type[] ExcludeTypes => new Type[7]
    {
      SDKEntityModelHistoryEventsFilter.hiVxwXGcLyG9Rb8f08sJ(__typeref (ISchedulerJobRunInfo)),
      SDKEntityModelHistoryEventsFilter.hiVxwXGcLyG9Rb8f08sJ(__typeref (ISchedulerTaskJob)),
      SDKEntityModelHistoryEventsFilter.hiVxwXGcLyG9Rb8f08sJ(__typeref (ISchedulerTask)),
      SDKEntityModelHistoryEventsFilter.hiVxwXGcLyG9Rb8f08sJ(__typeref (IInstanceExpressionPermissionHolder)),
      SDKEntityModelHistoryEventsFilter.hiVxwXGcLyG9Rb8f08sJ(__typeref (IInstanceSettingsPermissionHolder)),
      SDKEntityModelHistoryEventsFilter.hiVxwXGcLyG9Rb8f08sJ(__typeref (ICreateFilePreviewQueueItem)),
      typeof (IIndexQueue)
    };

    public SDKEntityModelHistoryEventsFilter()
    {
      SDKEntityModelHistoryEventsFilter.KSYVIkGcUFQF0Oqia2B0();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type hiVxwXGcLyG9Rb8f08sJ([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool dufvXdGcjYtKaiAumeyC() => SDKEntityModelHistoryEventsFilter.ik3qVkGc5QKW8dItV5nl == null;

    internal static SDKEntityModelHistoryEventsFilter NGMO6pGcYjeb4t4tqJ4A() => SDKEntityModelHistoryEventsFilter.ik3qVkGc5QKW8dItV5nl;

    internal static void KSYVIkGcUFQF0Oqia2B0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
