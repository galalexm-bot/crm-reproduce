// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Messaging.BaseMessageChannel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Messaging
{
  /// <summary>Базовый класс канала рассылки сообщений</summary>
  public abstract class BaseMessageChannel : IMessageChannel, IManageableMessageChannel
  {
    internal static BaseMessageChannel P2SpyAhmt84sad0ZB7pO;

    /// <inheritdoc />
    public abstract Guid Uid { get; }

    /// <inheritdoc />
    public abstract string Name { get; }

    /// <inheritdoc />
    public abstract string DisplayName { get; }

    /// <inheritdoc />
    public virtual bool Default => false;

    /// <inheritdoc />
    public abstract void Send(IMessage message);

    /// <inheritdoc />
    public virtual bool Enabled => true;

    protected BaseMessageChannel()
    {
      BaseMessageChannel.hcXm11hm6NoPEo7EMfsw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void hcXm11hm6NoPEo7EMfsw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool otxESZhmwkGwmryZKnO4() => BaseMessageChannel.P2SpyAhmt84sad0ZB7pO == null;

    internal static BaseMessageChannel RRfImmhm4m006vuoYM6a() => BaseMessageChannel.P2SpyAhmt84sad0ZB7pO;
  }
}
