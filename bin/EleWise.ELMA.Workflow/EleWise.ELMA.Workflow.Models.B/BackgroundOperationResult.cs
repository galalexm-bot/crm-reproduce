using System;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models.BackgroundOperations;

[Serializable]
public sealed class BackgroundOperationResult : IBackgroundOperationResult
{
	private byte[] _result;

	private bool _isError;

	private static BackgroundOperationResult XYetlEOC6XGk0K7WF5Nb;

	public byte[] SerializedResult => _result;

	public bool IsError => _isError;

	public BackgroundOperationResult(bool isError, object result)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		UvOJApOCTkAYGXhyWcVj();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				_isError = isError;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
				{
					num = 0;
				}
				break;
			default:
				_result = (byte[])jsQJWXOCQSv5Z4IScTiQ(result);
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
				{
					num = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void UvOJApOCTkAYGXhyWcVj()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object jsQJWXOCQSv5Z4IScTiQ(object P_0)
	{
		return ClassSerializationHelper.SerializeObject(P_0);
	}

	internal static bool VlHo4TOCqaoMAvvcZ83y()
	{
		return XYetlEOC6XGk0K7WF5Nb == null;
	}

	internal static BackgroundOperationResult MVf0glOC3y6teLbylurA()
	{
		return XYetlEOC6XGk0K7WF5Nb;
	}
}
