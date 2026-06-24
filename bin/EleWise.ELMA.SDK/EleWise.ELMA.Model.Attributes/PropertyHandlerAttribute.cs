using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class PropertyHandlerAttribute : Attribute
{
	private Guid handlerUid;

	private static PropertyHandlerAttribute ps6l5JoZH5QvbQ0pXghi;

	public Guid HandlerUid => handlerUid;

	public PropertyHandlerAttribute(string handlerUid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		c015f5oZxxdEoSbYkZp2();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.handlerUid = new Guid(handlerUid);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void c015f5oZxxdEoSbYkZp2()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool UKNF1CoZAXowKSIB8E7O()
	{
		return ps6l5JoZH5QvbQ0pXghi == null;
	}

	internal static PropertyHandlerAttribute Ivaq0ToZ7BGWFaeAC6Mb()
	{
		return ps6l5JoZH5QvbQ0pXghi;
	}
}
