using System;
using System.Collections.Generic;
using System.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model;

public sealed class ComponentUsage
{
	internal static ComponentUsage Mqk2A4W5ov1tyn5F4sb9;

	public List<Guid> ViewItems { get; set; }

	public List<string> Inputs { get; set; }

	public ComponentUsage()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		hg8gsMW5G1l3imW7sMuk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
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
			case 2:
				Inputs = new List<string>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				ViewItems = new List<Guid>();
				num = 2;
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeViewItems()
	{
		return lcZPEgW5ED0yGi2BTIof(ViewItems) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeInputs()
	{
		return O7ip1lW5fs8t6HYPm790(Inputs) != 0;
	}

	internal static void hg8gsMW5G1l3imW7sMuk()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool vqKu8cW5btfutvnm1uNR()
	{
		return Mqk2A4W5ov1tyn5F4sb9 == null;
	}

	internal static ComponentUsage hcBgX2W5hjX7X7kZb2SN()
	{
		return Mqk2A4W5ov1tyn5F4sb9;
	}

	internal static int lcZPEgW5ED0yGi2BTIof(object P_0)
	{
		return ((List<Guid>)P_0).Count;
	}

	internal static int O7ip1lW5fs8t6HYPm790(object P_0)
	{
		return ((List<string>)P_0).Count;
	}
}
