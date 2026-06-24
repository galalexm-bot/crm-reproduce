using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.PublicationBehaviours;

public sealed class NotValueEqualsBehaviour : IPublicationBehaviourChecker
{
	private static NotValueEqualsBehaviour a9XSWObrXtnyWEWYowrV;

	public PublicationType Check(CheckType action, object oldValue, object newValue)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return PublicationType.Soft;
			case 1:
				if (!oldValue.Equals(newValue))
				{
					return PublicationType.Restart;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public NotValueEqualsBehaviour()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
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

	internal static bool Ekm94GbrTbUMhEoCXTVJ()
	{
		return a9XSWObrXtnyWEWYowrV == null;
	}

	internal static NotValueEqualsBehaviour NRLA0tbrkwcydflXnOHB()
	{
		return a9XSWObrXtnyWEWYowrV;
	}
}
