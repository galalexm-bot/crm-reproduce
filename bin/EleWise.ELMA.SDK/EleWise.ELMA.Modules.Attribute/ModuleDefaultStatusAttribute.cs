using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Modules.Attributes;

[AttributeUsage(AttributeTargets.Assembly)]
public class ModuleDefaultStatusAttribute : Attribute
{
	private ModuleStatus status;

	internal static ModuleDefaultStatusAttribute kq0n9epUCtJ7091myJv;

	public ModuleStatus Status => status;

	public ModuleDefaultStatusAttribute(ModuleStatus status)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		hC1UBKpzK5KV9HDeiiY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
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
			this.status = status;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
			{
				num = 1;
			}
		}
	}

	internal static void hC1UBKpzK5KV9HDeiiY()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool hAfsTDpslISUFPu3gni()
	{
		return kq0n9epUCtJ7091myJv == null;
	}

	internal static ModuleDefaultStatusAttribute xV4cu9pco4sYUI62X8Q()
	{
		return kq0n9epUCtJ7091myJv;
	}
}
