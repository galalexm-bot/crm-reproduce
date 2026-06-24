using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Messaging;

public abstract class BaseMessageChannel : IMessageChannel, IManageableMessageChannel
{
	internal static BaseMessageChannel P2SpyAhmt84sad0ZB7pO;

	public abstract Guid Uid { get; }

	public abstract string Name { get; }

	public abstract string DisplayName { get; }

	public virtual bool Default => false;

	public virtual bool Enabled => true;

	public abstract void Send(IMessage message);

	protected BaseMessageChannel()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		hcXm11hm6NoPEo7EMfsw();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void hcXm11hm6NoPEo7EMfsw()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool otxESZhmwkGwmryZKnO4()
	{
		return P2SpyAhmt84sad0ZB7pO == null;
	}

	internal static BaseMessageChannel RRfImmhm4m006vuoYM6a()
	{
		return P2SpyAhmt84sad0ZB7pO;
	}
}
