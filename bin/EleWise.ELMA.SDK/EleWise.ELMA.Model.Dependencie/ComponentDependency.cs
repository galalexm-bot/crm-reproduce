using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Dependencies;

[Serializable]
public sealed class ComponentDependency : Dependency
{
	internal static ComponentDependency s3MBNOhRhKgu7FcOMVI2;

	[DefaultValue(null)]
	public Guid ViewItemUid
	{
		[CompilerGenerated]
		get
		{
			return _003CViewItemUid_003Ek__BackingField;
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
					_003CViewItemUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
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

	public List<InputComputedValue> Inputs { get; }

	[DefaultValue(false)]
	public bool Async
	{
		[CompilerGenerated]
		get
		{
			return _003CAsync_003Ek__BackingField;
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
					_003CAsync_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ComponentDependency()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		RrPWTwhRfmY7aUBLWFnL();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Inputs = new List<InputComputedValue>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
			{
				num = 1;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeInputs()
	{
		return xFe3gQhRQkq03YYC1Ywm(Inputs) != 0;
	}

	internal static void RrPWTwhRfmY7aUBLWFnL()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool z09kjJhRGWffB0wOkFd1()
	{
		return s3MBNOhRhKgu7FcOMVI2 == null;
	}

	internal static ComponentDependency Ql6BvahRE1cAI1pFNpQC()
	{
		return s3MBNOhRhKgu7FcOMVI2;
	}

	internal static int xFe3gQhRQkq03YYC1Ywm(object P_0)
	{
		return ((List<InputComputedValue>)P_0).Count;
	}
}
