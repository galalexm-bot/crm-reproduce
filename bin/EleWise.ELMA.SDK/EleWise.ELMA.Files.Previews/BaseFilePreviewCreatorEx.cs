using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files.Previews;

public abstract class BaseFilePreviewCreatorEx : BaseFilePreviewCreator, IFilePreviewCreatorEx, IFilePreviewCreator
{
	private static BaseFilePreviewCreatorEx s29K1GG2i4OR4h9UiLbK;

	public virtual string ExternalCreatorFileName => string.Empty;

	public virtual bool RequiredExternalCreator => true;

	public virtual string GetExternalCreatorFileName(BinaryFile file)
	{
		return ExternalCreatorFileName;
	}

	public override void Create(string path, BinaryFile file)
	{
	}

	public virtual Process CreateWithExternalCreator(string filePreviewDir, BinaryFile file)
	{
		return (Process)vuN0fMG2Km821coCy38Y(this, filePreviewDir, file, null);
	}

	protected virtual Process CreateWithExternalCreator(string filePreviewDir, BinaryFile file, string password)
	{
		//Discarded unreachable code: IL_00ae, IL_00bd, IL_0173, IL_0182, IL_0192, IL_01a1
		int num = 7;
		int num2 = num;
		Process process = default(Process);
		string mainFileName = default(string);
		PackageService service = default(PackageService);
		IElmaComponent elmaComponent = default(IElmaComponent);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (x6sSqQG2nlEBPdgWxldo(QPyE12G2kVnMhUXfTAYt(this, file)))
				{
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 13;
			case 5:
				if (!z4hX3aG2amW9dREqrHyd(process))
				{
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 8;
			case 8:
				return process;
			case 14:
				return null;
			case 1:
				return null;
			case 4:
				mainFileName = GetMainFileName(filePreviewDir, file);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 2;
				}
				continue;
			case 6:
				if (service == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 3;
					}
				}
				else
				{
					service.CheckInitialized();
					num2 = 9;
				}
				continue;
			case 13:
				if (!x6sSqQG2nlEBPdgWxldo(mainFileName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 11;
			case 3:
				return null;
			case 7:
				service = Locator.GetService<PackageService>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 6;
				}
				continue;
			case 9:
				elmaComponent = (IElmaComponent)JPvUpKG2T3xvBtnJEylk(service, vGKQ2jG2XNiVKnJbbojC(0x307E9FD1 ^ 0x307D7C4D));
				num2 = 10;
				continue;
			case 10:
				if (elmaComponent != null)
				{
					num2 = 4;
					continue;
				}
				goto case 1;
			case 11:
			case 12:
				return null;
			}
			if (x6sSqQG2nlEBPdgWxldo(FsdmwEG2O4XwhKLZLvxr(file)))
			{
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 4;
				}
				continue;
			}
			Process process2 = new Process();
			kcaAPiG2ebRZibrLQtco(JYLLofG22jn6BE43u4fc(process2), Path.Combine(elmaComponent.ComponentRoot, (string)QPyE12G2kVnMhUXfTAYt(this, file)));
			AqtR86G23xOx7ved8OnW(JYLLofG22jn6BE43u4fc(process2), (password != null) ? string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x5116E1C3), mainFileName, FsdmwEG2O4XwhKLZLvxr(file), Convert.ToBase64String((byte[])pEGsA6G2NuoftLsZsU0T(jp4ocHG21lqAGMsgdtIv(), password))) : ja55gVG2PhaGu6nPSu6g(vGKQ2jG2XNiVKnJbbojC(-97972138 ^ -97848430), mainFileName, FsdmwEG2O4XwhKLZLvxr(file)));
			jL4L8vG2pafGqo2x5bGt(JYLLofG22jn6BE43u4fc(process2), false);
			process = process2;
			num2 = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
			{
				num2 = 5;
			}
		}
	}

	protected BaseFilePreviewCreatorEx()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object vuN0fMG2Km821coCy38Y(object P_0, object P_1, object P_2, object P_3)
	{
		return ((BaseFilePreviewCreatorEx)P_0).CreateWithExternalCreator((string)P_1, (BinaryFile)P_2, (string)P_3);
	}

	internal static bool c1NtNEG2R7HDchLtTHdX()
	{
		return s29K1GG2i4OR4h9UiLbK == null;
	}

	internal static BaseFilePreviewCreatorEx ktSug3G2qxDpmB6vGvG8()
	{
		return s29K1GG2i4OR4h9UiLbK;
	}

	internal static object vGKQ2jG2XNiVKnJbbojC(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object JPvUpKG2T3xvBtnJEylk(object P_0, object P_1)
	{
		return ((PackageService)P_0).GetComponent((string)P_1);
	}

	internal static object QPyE12G2kVnMhUXfTAYt(object P_0, object P_1)
	{
		return ((BaseFilePreviewCreatorEx)P_0).GetExternalCreatorFileName((BinaryFile)P_1);
	}

	internal static bool x6sSqQG2nlEBPdgWxldo(object P_0)
	{
		return ((string)P_0).IsNullOrEmpty();
	}

	internal static object FsdmwEG2O4XwhKLZLvxr(object P_0)
	{
		return ((BinaryFile)P_0).ContentFilePath;
	}

	internal static object JYLLofG22jn6BE43u4fc(object P_0)
	{
		return ((Process)P_0).StartInfo;
	}

	internal static void kcaAPiG2ebRZibrLQtco(object P_0, object P_1)
	{
		((ProcessStartInfo)P_0).FileName = (string)P_1;
	}

	internal static object ja55gVG2PhaGu6nPSu6g(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object jp4ocHG21lqAGMsgdtIv()
	{
		return Encoding.UTF8;
	}

	internal static object pEGsA6G2NuoftLsZsU0T(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	internal static void AqtR86G23xOx7ved8OnW(object P_0, object P_1)
	{
		((ProcessStartInfo)P_0).Arguments = (string)P_1;
	}

	internal static void jL4L8vG2pafGqo2x5bGt(object P_0, bool P_1)
	{
		((ProcessStartInfo)P_0).UseShellExecute = P_1;
	}

	internal static bool z4hX3aG2amW9dREqrHyd(object P_0)
	{
		return ((Process)P_0).Start();
	}
}
