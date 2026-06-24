// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.DefaultNotificationFlow
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Notifications.Impl
{
  [Component(Order = 2147483647)]
  public class DefaultNotificationFlow : INotificationFlow
  {
    /// <summary>Уникальный идентификатор канала</summary>
    public static readonly Guid UID;
    private static DefaultNotificationFlow IB6X78DGAuaDPNSLeW9;

    public Guid Uid => DefaultNotificationFlow.UID;

    public string Name => EleWise.ELMA.SR.T((string) DefaultNotificationFlow.zEJ4auDQQ9kXOGVMXjl(-2092274397 << 4 ^ 883316466));

    public IEnumerable<INotificationFlowObject> FlowObjects => ComponentManager.Current.GetExtensionPoints<INotificationFlowObject>().Where<INotificationFlowObject>((Func<INotificationFlowObject, bool>) (nfo => DefaultNotificationFlow.YJRsCcDv3dURotPMBdq((object) nfo, this.Uid)));

    public DefaultNotificationFlow()
    {
      DefaultNotificationFlow.KHtqehDC5RtGYid072y();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static DefaultNotificationFlow()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DefaultNotificationFlow.UID = new Guid((string) DefaultNotificationFlow.zEJ4auDQQ9kXOGVMXjl(-1088304168 ^ -1088336126));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
            continue;
          case 2:
            DefaultNotificationFlow.KHtqehDC5RtGYid072y();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object zEJ4auDQQ9kXOGVMXjl(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool vc6fD6DERouQa4itBEL() => DefaultNotificationFlow.IB6X78DGAuaDPNSLeW9 == null;

    internal static DefaultNotificationFlow gnmVWqDfbhJ94RDLF9X() => DefaultNotificationFlow.IB6X78DGAuaDPNSLeW9;

    internal static void KHtqehDC5RtGYid072y() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool YJRsCcDv3dURotPMBdq([In] object obj0, Guid flowUid) => ((INotificationFlowObject) obj0).Can(flowUid);
  }
}
