using System;
using System.Collections.Generic;
using System.Linq;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers;

internal abstract class AbstractMessagesMaker : IGlimpseMessagesMaker
{
	internal static AbstractMessagesMaker PCOsI7ERqIYhUjS1upgG;

	public virtual Type[] SupportedEventTypes => new Type[0];

	public virtual bool IsAvailable(DiagnosticsEvent @event)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass2_.eventType = @event.GetType();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return ((IEnumerable<Type>)BxOq4HERTpHLXEMt9qjd(this)).Any(_003C_003Ec__DisplayClass2_._003CIsAvailable_003Eb__0);
			}
		}
	}

	public abstract object[] MakeMessages(DiagnosticsEvent @event);

	protected AbstractMessagesMaker()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object BxOq4HERTpHLXEMt9qjd(object P_0)
	{
		return ((AbstractMessagesMaker)P_0).SupportedEventTypes;
	}

	internal static bool R0CsK1ERKpsmLcsbG6cY()
	{
		return PCOsI7ERqIYhUjS1upgG == null;
	}

	internal static AbstractMessagesMaker Me4VSsERXj6Yleso8dga()
	{
		return PCOsI7ERqIYhUjS1upgG;
	}
}
