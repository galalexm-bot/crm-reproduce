using System;
using EleWise.ELMA.KPI.Common.Code;
using EleWise.ELMA.KPI.Common.Interfaces;
using EleWise.ELMA.KPI.Common.Scales;

namespace EleWise.ELMA.Workflow.Models;

public static class ProcessMetricExtensions
{
	private static ProcessMetricExtensions ve6MuIOdR4YG2lXWGnmR;

	public static ScaleStatus GetScaleStatus(this ProcessMetric processMetric, object metricValue)
	{
		//Discarded unreachable code: IL_00a9, IL_00b8, IL_00ea, IL_011d, IL_012c, IL_0197, IL_01a6
		int num = 7;
		int num2 = num;
		ScaleStatus result = default(ScaleStatus);
		IIndicatorScale indicatorScale = default(IIndicatorScale);
		Type type = default(Type);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 7:
				if (metricValue == null)
				{
					num2 = 6;
					continue;
				}
				obj = metricValue.GetType();
				break;
			default:
				result = null;
				num2 = 4;
				continue;
			case 10:
			case 14:
				result = indicatorScale.GetStatus(processMetric, jroeVYOdpjkrHYWfeUyZ(metricValue));
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
				{
					num2 = 5;
				}
				continue;
			case 2:
			case 5:
			case 9:
			case 11:
				return result;
			case 1:
				result = indicatorScale.GetStatus(processMetric, TimeSpanToDouble.Convert((TimeSpan)metricValue));
				num2 = 11;
				continue;
			case 6:
				obj = null;
				break;
			case 3:
				if (SgCMCyOdTLi53kKqtmJD(type, null))
				{
					num2 = 12;
					continue;
				}
				goto case 8;
			case 12:
				indicatorScale = (IIndicatorScale)tYlB6xOdQk8peCfmDXrR(processMetric);
				num2 = 13;
				continue;
			case 13:
				if (!(metricValue is TimeSpan))
				{
					num2 = 10;
					continue;
				}
				goto case 1;
			case 4:
				if (!aDphkxOd3EA2oUnjX9mo(processMetric))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
					{
						num2 = 9;
					}
					continue;
				}
				goto case 3;
			case 8:
				result = ScaleStatus.Unavailable;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
				{
					num2 = 2;
				}
				continue;
			}
			type = (Type)obj;
			num2 = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
			{
				num2 = 0;
			}
		}
	}

	internal static bool aDphkxOd3EA2oUnjX9mo(object P_0)
	{
		return ((IScaleUser)P_0).CanUseScale();
	}

	internal static bool SgCMCyOdTLi53kKqtmJD(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object tYlB6xOdQk8peCfmDXrR(object P_0)
	{
		return ((IScaleUser)P_0).GetScale();
	}

	internal static double jroeVYOdpjkrHYWfeUyZ(object P_0)
	{
		return Convert.ToDouble(P_0);
	}

	internal static bool XDj9qhOd6Tk8RedKfGeK()
	{
		return ve6MuIOdR4YG2lXWGnmR == null;
	}

	internal static ProcessMetricExtensions zJCnI3OdqVXdLnMFt8Se()
	{
		return ve6MuIOdR4YG2lXWGnmR;
	}
}
