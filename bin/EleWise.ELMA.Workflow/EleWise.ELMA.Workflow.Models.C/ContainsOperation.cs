using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Workflow.Models.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models.ConditionTable.Operations;

[Component]
internal sealed class ContainsOperation : IOperation
{
	public static readonly Guid UID;

	internal static ContainsOperation w19CFgOTNJZSK67hvv9g;

	public Guid Uid => UID;

	public string Name => (string)hqNBEEOT1jtrDHfygMcO(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965291699 ^ -1965152867));

	public string Description => SR.T((string)eWbsfNOThnVAmcHEVNg9(-29981480 ^ -30104004));

	public string OperationString => string.Empty;

	public bool CanShow => true;

	public TypeOperationEnum OperationType => TypeOperationEnum.Contains;

	public bool CanExecute(ITypeDescriptor descriptor, object left, object right)
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!(left is string))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return right is string;
			default:
				return false;
			}
		}
	}

	public bool Execute(ITypeDescriptor descriptor, object left, object right)
	{
		//Discarded unreachable code: IL_005b, IL_00c8, IL_0205, IL_0214
		int num = 1;
		IRuntimeTypeDescriptor runtimeTypeDescriptor = default(IRuntimeTypeDescriptor);
		bool result = default(bool);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					runtimeTypeDescriptor = descriptor as IRuntimeTypeDescriptor;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return result;
				case 4:
					throw new Exception((string)LSl9kVOTEomnfGoCxHJK(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-865213812 ^ -865091148), new object[2]
					{
						descriptor.GetType().Name,
						eWbsfNOThnVAmcHEVNg9(-135674354 ^ -135535186)
					}));
				case 5:
					num2 = 3;
					continue;
				case 3:
					try
					{
						string text = left as string;
						int num3 = 4;
						while (true)
						{
							switch (num3)
							{
							default:
								return result;
							case 0:
								return result;
							case 1:
								throw new Exception((string)LSl9kVOTEomnfGoCxHJK(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x438A0E43 ^ 0x43882D93), new object[3]
								{
									text2,
									eqJW0jOTwt4R6aZNZJfN(runtimeTypeDescriptor).Name,
									eWbsfNOThnVAmcHEVNg9(-1108877388 ^ -1109001340)
								}));
							case 3:
								if (text == null)
								{
									num3 = 2;
								}
								else if (text2 != null)
								{
									result = zh7kcTOT4fDZfkGeUmwa(text, text2);
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
									{
										num3 = 0;
									}
								}
								else
								{
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
									{
										num3 = 1;
									}
								}
								break;
							case 2:
								throw new Exception((string)LSl9kVOTEomnfGoCxHJK(eWbsfNOThnVAmcHEVNg9(0x56A753C9 ^ 0x56A57019), new object[3]
								{
									text,
									eqJW0jOTwt4R6aZNZJfN(runtimeTypeDescriptor).Name,
									SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1843E01F ^ 0x1841C42F)
								}));
							case 4:
								text2 = right as string;
								num3 = 3;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
								{
									num3 = 3;
								}
								break;
							}
						}
					}
					catch (Exception ex)
					{
						throw ex;
					}
				default:
					if (runtimeTypeDescriptor != null)
					{
						break;
					}
					goto case 4;
				}
				break;
			}
			num = 5;
		}
	}

	public ContainsOperation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		wl4ahEOTznJUJjwbIDAC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ContainsOperation()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				UID = new Guid((string)eWbsfNOThnVAmcHEVNg9(-1574607501 ^ -1574485709));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object hqNBEEOT1jtrDHfygMcO(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool QPUuCROTxeGjQlnNmkQv()
	{
		return w19CFgOTNJZSK67hvv9g == null;
	}

	internal static ContainsOperation goo1otOTS9ECN3BaG2jb()
	{
		return w19CFgOTNJZSK67hvv9g;
	}

	internal static object eWbsfNOThnVAmcHEVNg9(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object LSl9kVOTEomnfGoCxHJK(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static Type eqJW0jOTwt4R6aZNZJfN(object P_0)
	{
		return ((IRuntimeTypeDescriptor)P_0).RuntimeType;
	}

	internal static bool zh7kcTOT4fDZfkGeUmwa(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static void wl4ahEOTznJUJjwbIDAC()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
