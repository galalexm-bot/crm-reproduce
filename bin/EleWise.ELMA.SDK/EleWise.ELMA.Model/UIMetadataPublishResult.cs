using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model;

[Serializable]
public sealed class UIMetadataPublishResult
{
	internal static UIMetadataPublishResult hYpqgkW5QYUQbONOvltA;

	public List<ValidationError> Errors { get; }

	public Guid ItemUid
	{
		[CompilerGenerated]
		get
		{
			return _003CItemUid_003Ek__BackingField;
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
				case 1:
					_003CItemUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public UIMetadataPublishResult()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		DrBWgTW58l4DsOVZf7yA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
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
				Errors = new List<ValidationError>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void DrBWgTW58l4DsOVZf7yA()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool GZe1M3W5CglvS8wW1WG2()
	{
		return hYpqgkW5QYUQbONOvltA == null;
	}

	internal static UIMetadataPublishResult McEMQPW5v74A6r0DQgCT()
	{
		return hYpqgkW5QYUQbONOvltA;
	}
}
