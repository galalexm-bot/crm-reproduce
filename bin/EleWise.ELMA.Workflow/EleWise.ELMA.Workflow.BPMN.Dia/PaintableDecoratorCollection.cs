using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

[Serializable]
public class PaintableDecoratorCollection : NDecoratorCollection, INPaintable, INNode
{
	private static PaintableDecoratorCollection wCgHnEO4FRxNxvFGHGyt;

	public override NAbilities Permissions
	{
		get
		{
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			int num = 1;
			int num2 = num;
			NAbilities result = default(NAbilities);
			while (true)
			{
				switch (num2)
				{
				case 2:
					((NAbilities)(ref result)).set_Export(true);
					num2 = 3;
					break;
				default:
					((NAbilities)(ref result)).set_Print(true);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
					{
						num2 = 2;
					}
					break;
				case 3:
					return result;
				case 1:
					result = VJtpexO4aUESqeERi6GT(this);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool CanPaint(NPaintContext context)
	{
		return tNQgcwO4rm4B2acJE83O(context, this);
	}

	public void Paint(NPaintContext context)
	{
		//Discarded unreachable code: IL_002f, IL_003e, IL_0049, IL_00f6, IL_0126, IL_015e, IL_016d
		int num = 1;
		int num2 = num;
		IEnumerator<INPaintable> enumerator = default(IEnumerator<INPaintable>);
		INPaintable current = default(INPaintable);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				enumerator = ((IEnumerable)zZGi47O4e45mliiPTpFn(this)).OfType<INPaintable>().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					IL_00cb:
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
						{
							num3 = 3;
						}
						goto IL_004d;
					}
					goto IL_006f;
					IL_006f:
					current = enumerator.Current;
					num3 = 4;
					goto IL_004d;
					IL_004d:
					while (true)
					{
						switch (num3)
						{
						case 3:
							return;
						case 2:
							break;
						case 4:
							if (!dDJeXYO4NORrNF9tlq50(current, context))
							{
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto case 5;
						case 5:
							current.Paint(context);
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
							{
								num3 = 0;
							}
							continue;
						default:
							goto IL_00cb;
						}
						break;
					}
					goto IL_006f;
				}
			}
			finally
			{
				if (enumerator != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							VeT8rAO4xOlRpvj5oU9c(enumerator);
							num4 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
							{
								num4 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public PaintableDecoratorCollection()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		gVcbcNO4S45kT7vBhAAy();
		((NDecoratorCollection)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static NAbilities VJtpexO4aUESqeERi6GT(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NDiagramElement)P_0).get_Permissions();
	}

	internal static bool fpbxQoO4igurf3LpDjqi()
	{
		return wCgHnEO4FRxNxvFGHGyt == null;
	}

	internal static PaintableDecoratorCollection dbUQ81O4IWLxiprDkv1K()
	{
		return wCgHnEO4FRxNxvFGHGyt;
	}

	internal static bool tNQgcwO4rm4B2acJE83O(object P_0, object P_1)
	{
		return ((NPaintContext)P_0).VerifyPermissions((INDiagramElement)P_1);
	}

	internal static object zZGi47O4e45mliiPTpFn(object P_0)
	{
		return ((NDiagramElementCollection)P_0).get_Nodes();
	}

	internal static bool dDJeXYO4NORrNF9tlq50(object P_0, object P_1)
	{
		return ((INPaintable)P_0).CanPaint((NPaintContext)P_1);
	}

	internal static void VeT8rAO4xOlRpvj5oU9c(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void gVcbcNO4S45kT7vBhAAy()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
