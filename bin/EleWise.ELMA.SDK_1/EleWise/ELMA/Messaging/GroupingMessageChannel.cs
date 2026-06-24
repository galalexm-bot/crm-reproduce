// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Messaging.GroupingMessageChannel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Messaging
{
  /// <summary>
  /// Базовый класс канала поддерживающего рассылку нескольким получателям
  /// </summary>
  public abstract class GroupingMessageChannel : 
    BaseMessageChannel,
    IGroupingMessageChannel,
    IMessageChannel
  {
    internal static GroupingMessageChannel QmAEFHhmHStG2voxbWOU;

    /// <inheritdoc />
    public override bool Default => true;

    /// <inheritdoc />
    public abstract void Send(IMessage message, IEnumerable<IUser> recipients);

    protected GroupingMessageChannel()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool tItuMqhmAPDfY2GTmxI2() => GroupingMessageChannel.QmAEFHhmHStG2voxbWOU == null;

    internal static GroupingMessageChannel yBMbH9hm7oNYjo8Z7pmQ() => GroupingMessageChannel.QmAEFHhmHStG2voxbWOU;
  }
}
