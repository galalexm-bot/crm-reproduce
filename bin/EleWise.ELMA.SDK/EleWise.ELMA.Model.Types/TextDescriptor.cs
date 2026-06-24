using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 200)]
public class TextDescriptor : StringDescriptor<TextSettings>
{
	public const string UID_S = "{317E3D72-9C47-4B68-926D-BA77A2579BC2}";

	public static readonly Guid UID;

	private IFullTextPropertyDescriptor propertyDescriptor;

	internal static TextDescriptor M4dOKcoJIYHA3AndqX1q;

	public override Guid Uid => UID;

	public override string Name => (string)CIFy75oJROY5pgPmNq25(kGSNLwoJiMHPhs6gTh1X(0x35C0467B ^ 0x35C22491));

	public override bool IsRuntimeType => false;

	public override IFullTextPropertyDescriptor FullTextPropertyDescriptor
	{
		get
		{
			int num = 1;
			int num2 = num;
			IFullTextPropertyDescriptor fullTextPropertyDescriptor = default(IFullTextPropertyDescriptor);
			IFullTextPropertyDescriptor fullTextPropertyDescriptor2;
			while (true)
			{
				switch (num2)
				{
				default:
					fullTextPropertyDescriptor = (propertyDescriptor = new TextPropertyDescriptor(this));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					fullTextPropertyDescriptor2 = propertyDescriptor;
					if (fullTextPropertyDescriptor2 != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					fullTextPropertyDescriptor2 = fullTextPropertyDescriptor;
					break;
				}
				break;
			}
			return fullTextPropertyDescriptor2;
		}
	}

	public TextDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		UUhabIoJqTe2WHaL6DW9();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static TextDescriptor()
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
				UUhabIoJqTe2WHaL6DW9();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				UID = new Guid((string)kGSNLwoJiMHPhs6gTh1X(--1418440330 ^ 0x5489371E));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static object kGSNLwoJiMHPhs6gTh1X(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object CIFy75oJROY5pgPmNq25(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool MUin9joJVrmpc8f5qiKG()
	{
		return M4dOKcoJIYHA3AndqX1q == null;
	}

	internal static TextDescriptor TW6i53oJS3Cgw0r0CgqC()
	{
		return M4dOKcoJIYHA3AndqX1q;
	}

	internal static void UUhabIoJqTe2WHaL6DW9()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
