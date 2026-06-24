using System.Collections.Generic;
using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Messaging;

public abstract class GroupingMessageChannel : BaseMessageChannel, IGroupingMessageChannel, IMessageChannel
{
	internal static GroupingMessageChannel QmAEFHhmHStG2voxbWOU;

	public override bool Default => true;

	public abstract void Send(IMessage message, IEnumerable<IUser> recipients);

	protected GroupingMessageChannel()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool tItuMqhmAPDfY2GTmxI2()
	{
		return QmAEFHhmHStG2voxbWOU == null;
	}

	internal static GroupingMessageChannel yBMbH9hm7oNYjo8Z7pmQ()
	{
		return QmAEFHhmHStG2voxbWOU;
	}
}
