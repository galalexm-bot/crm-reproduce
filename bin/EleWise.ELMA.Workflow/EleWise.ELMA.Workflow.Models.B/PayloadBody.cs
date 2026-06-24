using System;
using System.IO;
using System.Text;
using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models.BackgroundOperations.HttpRequest;

[Serializable]
public class PayloadBody
{
	private readonly byte[] payloadBody;

	internal static PayloadBody TmKS2wOMnt6JM10ly9Qg;

	public bool IsEmpty => payloadBody.Length == 0;

	public PayloadBody()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ot23FsOMfOLmegRLYajP();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				payloadBody = Array.Empty<byte>();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public PayloadBody(byte[] data)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
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
			payloadBody = data;
			num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
			{
				num = 1;
			}
		}
	}

	public PayloadBody(Stream stream)
	{
		//Discarded unreachable code: IL_002a, IL_007d, IL_00b2, IL_0115, IL_016e, IL_01a6, IL_01b5
		ot23FsOMfOLmegRLYajP();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
		{
			num = 1;
		}
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				break;
			case 0:
				return;
			case 2:
				try
				{
					int num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					default:
						try
						{
							stream.CopyTo(memoryStream);
							int num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
							{
								num3 = 1;
							}
							while (true)
							{
								switch (num3)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									payloadBody = (byte[])hEgNv6OMWJ1hEZBZX02b(memoryStream);
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
									{
										num3 = 0;
									}
									break;
								}
							}
						}
						finally
						{
							if (stream != null)
							{
								int num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
								{
									num4 = 1;
								}
								while (true)
								{
									switch (num4)
									{
									case 1:
										LfuTDsOMjG5HDLpTn0n0(stream);
										num4 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
										{
											num4 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								LfuTDsOMjG5HDLpTn0n0(memoryStream);
								num5 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
								{
									num5 = 1;
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
			memoryStream = (MemoryStream)wJeu6iOM9r5cRRPCJAEn();
			int num6 = 2;
			num = num6;
		}
	}

	public byte[] GetBytes()
	{
		int num = 1;
		int num2 = num;
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (payloadBody.Length == 0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
					{
						num2 = 0;
					}
					break;
				}
				array = new byte[payloadBody.Length];
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return array;
			case 2:
				TuvspmOMRkK2nVtVIW6e(payloadBody, array, payloadBody.Length);
				num2 = 3;
				break;
			default:
				return Array.Empty<byte>();
			}
		}
	}

	public Stream GetStream()
	{
		return (Stream)kaZQWMOM6jyfXMoUhvWW(payloadBody, false);
	}

	public string GetUtf8String()
	{
		return ((Encoding)Dnwv5OOMqklPUqJtJEyv()).GetString(payloadBody);
	}

	public string GetString(Encoding encoding = null)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
				return (string)DHoymTOMTOxn03PUEutx(encoding, payloadBody);
			case 1:
				obj = encoding;
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				obj = bleFhwOM3VInIjNbkrd0();
				break;
			}
			encoding = (Encoding)obj;
			num2 = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 != 0)
			{
				num2 = 2;
			}
		}
	}

	internal static void ot23FsOMfOLmegRLYajP()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool oueP40OMHdorfEmceaD9()
	{
		return TmKS2wOMnt6JM10ly9Qg == null;
	}

	internal static PayloadBody scIcDKOMLLgZiA1itniI()
	{
		return TmKS2wOMnt6JM10ly9Qg;
	}

	internal static object wJeu6iOM9r5cRRPCJAEn()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static object hEgNv6OMWJ1hEZBZX02b(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static void LfuTDsOMjG5HDLpTn0n0(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void TuvspmOMRkK2nVtVIW6e(object P_0, object P_1, int P_2)
	{
		Array.Copy((Array)P_0, (Array)P_1, P_2);
	}

	internal static object kaZQWMOM6jyfXMoUhvWW(object P_0, bool P_1)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, P_1);
	}

	internal static object Dnwv5OOMqklPUqJtJEyv()
	{
		return Encoding.UTF8;
	}

	internal static object bleFhwOM3VInIjNbkrd0()
	{
		return Encoding.ASCII;
	}

	internal static object DHoymTOMTOxn03PUEutx(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}
}
