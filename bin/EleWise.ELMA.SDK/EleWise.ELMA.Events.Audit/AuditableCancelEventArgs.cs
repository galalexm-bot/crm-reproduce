using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Events.Audit;

public class AuditableCancelEventArgs : AuditableEventArgs
{
	internal static AuditableCancelEventArgs sBFRhyGL6HKbFHU17blK;

	public bool Cancel
	{
		[CompilerGenerated]
		get
		{
			return _003CCancel_003Ek__BackingField;
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
					_003CCancel_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
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

	public AuditableCancelEventArgs()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool dC2FnRGLHnEQgflkGmXl()
	{
		return sBFRhyGL6HKbFHU17blK == null;
	}

	internal static AuditableCancelEventArgs wkvenNGLAsfPHX7f4LcO()
	{
		return sBFRhyGL6HKbFHU17blK;
	}
}
