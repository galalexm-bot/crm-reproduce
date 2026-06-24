using System;
using System.Collections.Generic;
using EleWise.ELMA.Deploy.Export.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Export.Models;

public sealed class BaseExportCheckingResult : IExportCheckingResult
{
	private List<ExportCheckingMessage> messages;

	internal static BaseExportCheckingResult PTQgEQELOFQedUFs9AxD;

	public IReadOnlyCollection<ExportCheckingMessage> Messages => messages;

	public void AddMessage(ExportCheckingMessageType type, string text)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				ryIesOEL1vlt4T4hNu2n(text, x3B1cNELP73DnbX1NR0K(-1767720453 ^ -1767674949));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			List<ExportCheckingMessage> list = messages;
			ExportCheckingMessage exportCheckingMessage = new ExportCheckingMessage();
			tWdUSEELNS2spCkVTeRb(exportCheckingMessage, type);
			exportCheckingMessage.Text = text;
			list.Add(exportCheckingMessage);
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
			{
				num2 = 1;
			}
		}
	}

	public void AddMessage(ExportCheckingMessageType type, string text, Guid uid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				ryIesOEL1vlt4T4hNu2n(text, x3B1cNELP73DnbX1NR0K(0xE1229CF ^ 0xE13FB8F));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			List<ExportCheckingMessage> list = messages;
			ExportCheckingMessage exportCheckingMessage = new ExportCheckingMessage();
			tWdUSEELNS2spCkVTeRb(exportCheckingMessage, type);
			exportCheckingMessage.Text = text;
			lxeNM9EL3TmxoMpeS618(exportCheckingMessage, uid);
			list.Add(exportCheckingMessage);
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
			{
				num2 = 2;
			}
		}
	}

	public void AddMessage(ExportCheckingMessage message)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				cAjbSLELpj4pW1Wm81ii(message, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -868024270));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				messages.Add(message);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public void AddMessages(IEnumerable<ExportCheckingMessage> messages)
	{
		Contract.ArgumentNotNull(messages, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECAF876));
		this.messages.AddRange(messages);
	}

	public BaseExportCheckingResult()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		m9LlXTELalZ5L6BuXcpZ();
		messages = new List<ExportCheckingMessage>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object x3B1cNELP73DnbX1NR0K(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void ryIesOEL1vlt4T4hNu2n(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static void tWdUSEELNS2spCkVTeRb(object P_0, ExportCheckingMessageType value)
	{
		((ExportCheckingMessage)P_0).Type = value;
	}

	internal static bool q8rMA8EL2FIXvANsXmSw()
	{
		return PTQgEQELOFQedUFs9AxD == null;
	}

	internal static BaseExportCheckingResult isdfjjELegt2UFUyIQW0()
	{
		return PTQgEQELOFQedUFs9AxD;
	}

	internal static void lxeNM9EL3TmxoMpeS618(object P_0, Guid value)
	{
		((ExportCheckingMessage)P_0).Uid = value;
	}

	internal static void cAjbSLELpj4pW1Wm81ii(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void m9LlXTELalZ5L6BuXcpZ()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
