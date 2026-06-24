using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Properties;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	private static Resources JdoObPhvSnLv6CpbCj5;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					resourceMan = new ResourceManager("EleWise.ELMA.Workflow.Properties.Resources", SMT3MrhTu6Rm6DkiQLb(typeof(Resources).TypeHandle).Assembly);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36c7cf283a024daf893e3b9d58dc5698 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					if (resourceMan == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4756c9eca18a4abd877173fe66f77852 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				}
				break;
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static string BlockUser_en_US => (string)ggxJMehNqhaJvZlL0NA(ResourceManager, BEZy88hcWbTi2SlDG45(-1941486619 ^ -1941476043), resourceCulture);

	internal static string BlockUser_ru_RU => (string)ggxJMehNqhaJvZlL0NA(g8NZdihdvipL80JB3FD(), BEZy88hcWbTi2SlDG45(-1952076060 ^ -1952088042), resourceCulture);

	internal static Bitmap folder => (Bitmap)KvAZnUhjKAkFu0gYkAE(ResourceManager, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-478552651 ^ -478547295), resourceCulture);

	internal static string ImproveProcess_en_US => ResourceManager.GetString((string)BEZy88hcWbTi2SlDG45(0x2A4998B0 ^ 0x2A49B794), resourceCulture);

	internal static string ImproveProcess_ru_RU => (string)ggxJMehNqhaJvZlL0NA(ResourceManager, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-275456087 ^ -275451655), resourceCulture);

	internal static Bitmap symb_task_receive => (Bitmap)((ResourceManager)g8NZdihdvipL80JB3FD()).GetObject((string)BEZy88hcWbTi2SlDG45(0x3D87FABF ^ 0x3D87D5C3), resourceCulture);

	internal static Bitmap symb_task_script => (Bitmap)KvAZnUhjKAkFu0gYkAE(g8NZdihdvipL80JB3FD(), BEZy88hcWbTi2SlDG45(-361150192 ^ -361142606), resourceCulture);

	internal static Bitmap symb_task_send => (Bitmap)ResourceManager.GetObject((string)BEZy88hcWbTi2SlDG45(-2038019883 ^ -2038012141), resourceCulture);

	internal Resources()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WxIhZuh9vfpggpn9hys();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f44d857a149741d8874c141a12a734dc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void WxIhZuh9vfpggpn9hys()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static bool YdT7tGhPVx85BFAejZo()
	{
		return JdoObPhvSnLv6CpbCj5 == null;
	}

	internal static Resources FgICNhh4q9VHZs4XOe8()
	{
		return JdoObPhvSnLv6CpbCj5;
	}

	internal static Type SMT3MrhTu6Rm6DkiQLb(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object BEZy88hcWbTi2SlDG45(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object ggxJMehNqhaJvZlL0NA(object P_0, object P_1, object P_2)
	{
		return ((ResourceManager)P_0).GetString((string)P_1, (CultureInfo)P_2);
	}

	internal static object g8NZdihdvipL80JB3FD()
	{
		return ResourceManager;
	}

	internal static object KvAZnUhjKAkFu0gYkAE(object P_0, object P_1, object P_2)
	{
		return ((ResourceManager)P_0).GetObject((string)P_1, (CultureInfo)P_2);
	}
}
