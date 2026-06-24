using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Modules.Impl;

internal abstract class ApplicationUnit : IApplicationUnit
{
	internal static ApplicationUnit XH5B0rNQkrCQlp0LSNe;

	public abstract string Id { get; }

	public abstract Guid Uid { get; }

	public abstract string Title { get; }

	public abstract string Description { get; }

	public abstract string Version { get; }

	public abstract string Author { get; }

	public IApplicationUnit Owner
	{
		[CompilerGenerated]
		get
		{
			return _003COwner_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003COwner_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override string ToString()
	{
		return (string)QMy4QnN8FhOtnWDQLtt(this);
	}

	protected ApplicationUnit()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		H2FNRCNZuU8Iu54eeVU();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool gQKsE4NCi4oiq6MJYtP()
	{
		return XH5B0rNQkrCQlp0LSNe == null;
	}

	internal static ApplicationUnit svxuQANvn1ZJWyiMD2V()
	{
		return XH5B0rNQkrCQlp0LSNe;
	}

	internal static object QMy4QnN8FhOtnWDQLtt(object P_0)
	{
		return ((ApplicationUnit)P_0).Id;
	}

	internal static void H2FNRCNZuU8Iu54eeVU()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
