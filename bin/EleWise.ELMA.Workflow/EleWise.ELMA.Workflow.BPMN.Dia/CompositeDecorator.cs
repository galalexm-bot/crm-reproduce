using System;
using j3AmrhgkCleVTGdEwA;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

[Serializable]
public class CompositeDecorator : BaseDecorator
{
	internal BaseDecorator[] decorators;

	private static CompositeDecorator EfNptlOwcRsvbkH5dLo8;

	public CompositeDecorator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		VsNsnKOwdVk4nlFXWM57();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public CompositeDecorator(BaseDecorator[] decorators, DecoratorPosition position = DecoratorPosition.Center)
	{
		//Discarded unreachable code: IL_002b, IL_0030, IL_011a, IL_0129
		VsNsnKOwdVk4nlFXWM57();
		base._002Ector(position);
		int num = 8;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
		{
			num = 6;
		}
		BaseDecorator[] array = default(BaseDecorator[]);
		BaseDecorator baseDecorator = default(BaseDecorator);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 12:
				array = decorators;
				num = 9;
				break;
			case 8:
				this.decorators = decorators;
				num = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
				{
					num = 3;
				}
				break;
			case 10:
				return;
			case 7:
				awGWBNOwHFd6JNlVEhT3(this, P6Pvr1Own2X6agmyFKVi(baseDecorator));
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
				{
					num = 2;
				}
				break;
			default:
				if (J0DCdSOwukvIDyeoqP7S(baseDecorator) > J0DCdSOwukvIDyeoqP7S(this))
				{
					num = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
					{
						num = 11;
					}
					break;
				}
				goto case 1;
			case 6:
				baseDecorator = array[num2];
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
				{
					num = 0;
				}
				break;
			case 3:
				if (decorators == null)
				{
					return;
				}
				num = 12;
				break;
			case 4:
			case 5:
				if (num2 >= array.Length)
				{
					num = 10;
					break;
				}
				goto case 6;
			case 1:
				if (baseDecorator.Height > P6Pvr1Own2X6agmyFKVi(this))
				{
					num = 7;
					break;
				}
				goto case 2;
			case 2:
				num2++;
				num = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
				{
					num = 0;
				}
				break;
			case 11:
				CD7kOaOwDuEDHXcbaFIG(this, J0DCdSOwukvIDyeoqP7S(baseDecorator));
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
				{
					num = 1;
				}
				break;
			case 9:
				num2 = 0;
				num = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
				{
					num = 4;
				}
				break;
			}
		}
	}

	protected override void CreatePaths(NRectangleF bounds)
	{
		//Discarded unreachable code: IL_0150, IL_015f, IL_016f
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num2 = num;
		BaseDecorator[] array = default(BaseDecorator[]);
		int num3 = default(int);
		BaseDecorator baseDecorator = default(BaseDecorator);
		NRectangleF bounds2 = default(NRectangleF);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 11:
				array = decorators;
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
				{
					num2 = 0;
				}
				break;
			case 12:
				return;
			case 10:
				num3++;
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
				{
					num2 = 5;
				}
				break;
			case 6:
				m9m9U2OwLwlLlM1DPrxA(baseDecorator, bounds2);
				num2 = 9;
				break;
			case 9:
				paths.AddRange(baseDecorator.paths);
				num2 = 10;
				break;
			case 2:
				paths.Clear();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
				{
					num2 = 1;
				}
				break;
			case 8:
				((NRectangleF)(ref bounds2))._002Ector(((NRectangleF)(ref bounds)).get_Center().X - J0DCdSOwukvIDyeoqP7S(baseDecorator) / 2f, ((NRectangleF)(ref bounds)).get_Center().Y - P6Pvr1Own2X6agmyFKVi(baseDecorator) / 2f, J0DCdSOwukvIDyeoqP7S(baseDecorator), P6Pvr1Own2X6agmyFKVi(baseDecorator));
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
				{
					num2 = 4;
				}
				break;
			case 5:
			case 7:
				if (num3 >= array.Length)
				{
					num2 = 12;
					break;
				}
				goto default;
			case 1:
				if (decorators == null)
				{
					return;
				}
				num2 = 11;
				break;
			default:
				baseDecorator = array[num3];
				num2 = 8;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
				{
					num2 = 5;
				}
				break;
			case 3:
				num3 = 0;
				num2 = 7;
				break;
			}
		}
	}

	internal static void VsNsnKOwdVk4nlFXWM57()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool aae0iyOwPLRPHbwi5JIk()
	{
		return EfNptlOwcRsvbkH5dLo8 == null;
	}

	internal static CompositeDecorator U7X7Y2OwXpOiwtAJyMJI()
	{
		return EfNptlOwcRsvbkH5dLo8;
	}

	internal static float J0DCdSOwukvIDyeoqP7S(object P_0)
	{
		return ((BaseDecorator)P_0).Width;
	}

	internal static void CD7kOaOwDuEDHXcbaFIG(object P_0, float value)
	{
		((BaseDecorator)P_0).Width = value;
	}

	internal static float P6Pvr1Own2X6agmyFKVi(object P_0)
	{
		return ((BaseDecorator)P_0).Height;
	}

	internal static void awGWBNOwHFd6JNlVEhT3(object P_0, float value)
	{
		((BaseDecorator)P_0).Height = value;
	}

	internal static void m9m9U2OwLwlLlM1DPrxA(object P_0, NRectangleF bounds)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((BaseDecorator)P_0).RecreatePaths(bounds);
	}
}
