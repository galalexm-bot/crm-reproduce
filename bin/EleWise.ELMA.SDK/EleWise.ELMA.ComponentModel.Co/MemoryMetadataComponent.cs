using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using Autofac.Builder;
using EleWise.ELMA.Design;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ComponentModel.Components;

public abstract class MemoryMetadataComponent : AbstractMetadataEditorComponent, IMetadataEditorService, IMetadataService
{
	private static MemoryMetadataComponent AlCa4AfuY0yXemTnMl7k;

	public override void SaveMetadata(IEnumerable<IMetadata> metadataList)
	{
		foreach (IMetadata metadata in metadataList)
		{
			AddOrReplaceMetadata(ProjectName, metadata);
		}
		lastMetadataUpdate = DateTime.Now;
	}

	public override void RemoveMetadata(IMetadata metadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				lastMetadataUpdate = DateTime.Now;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				jVlO8QfucQZXWUhErCYH(this, lfns7kfusouuMx6QO9V4(this), metadata);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public override void BuildDocumentation()
	{
		//Discarded unreachable code: IL_00a4, IL_00b3, IL_00c3, IL_00d2, IL_0197
		int num = 19;
		string item = default(string);
		string text2 = default(string);
		List<string> list = default(List<string>);
		string text = default(string);
		string text5 = default(string);
		string text4 = default(string);
		string text3 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					item = (string)z4Uha2fIQOU3skbJDQfl(ImJAtpfICKVJNDylACE9(AOmBNafIfBX4Fiop43Fy()), obZqqDfuzS9LgRKkPCMN(-70007027 ^ -70005469));
					num2 = 4;
					continue;
				case 3:
					return;
				case 8:
				{
					Process process = new Process();
					rCQmYZfIvFASnaP3TW24(process.StartInfo, text2);
					((ProcessStartInfo)vuqyXLfI8NfG1BPlLbw7(process)).Arguments = (string)CPXIMOfIuCvyo094Ovbx(obZqqDfuzS9LgRKkPCMN(-309639236 ^ -309653858), FZ0XnOfIZi9Eo7xO4FVs(list));
					Eg36dEfIVJU91TT1gE6x(process.StartInfo, iDmJP2fIII9uRKghwhZN(AOmBNafIfBX4Fiop43Fy()));
					asf5tpfISyRtJpNTWeNG(vuqyXLfI8NfG1BPlLbw7(process), true);
					EWNorwfIihFvMZP6bk7t(vuqyXLfI8NfG1BPlLbw7(process), false);
					Nto1a1fIRTEraiPTZAq4(((ProcessStartInfo)vuqyXLfI8NfG1BPlLbw7(process)).EnvironmentVariables, obZqqDfuzS9LgRKkPCMN(0x4785BC0D ^ 0x478083D3), text);
					process.Start();
					process.WaitForExit();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				case 20:
					if (!OaBB4MfIEaAXqVUjCNEr(text5))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num2 = 15;
						}
						continue;
					}
					list = new List<string>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					list.Add(item);
					num = 16;
					break;
				case 15:
					throw new Exception(SR.T((string)obZqqDfuzS9LgRKkPCMN(-1334993905 ^ -1335319679), text5));
				case 9:
					throw new Exception((string)g2ta0ifIBo9c0YK90Ffo(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939714822)));
				case 11:
					text4 = (string)XuEXn9fIo3oaK7wHCVWP(QAMHK1fIWiImE3ClDy10());
					num2 = 21;
					continue;
				case 21:
					text = (string)fghQjXfIbPYjO4odO61I(text, obZqqDfuzS9LgRKkPCMN(-1876063057 ^ -1876381099), text4);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 1;
					}
					continue;
				case 16:
					list.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978142944));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 8;
					}
					continue;
				case 13:
					throw new Exception(SR.T((string)obZqqDfuzS9LgRKkPCMN(-561074844 ^ -561278230), text2));
				case 7:
					text5 = (string)z4Uha2fIQOU3skbJDQfl(AOmBNafIfBX4Fiop43Fy(), obZqqDfuzS9LgRKkPCMN(0x4785BC0D ^ 0x4785F18D));
					num2 = 20;
					continue;
				case 14:
					if (OaBB4MfIEaAXqVUjCNEr(text2))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 13;
				case 1:
					if (gUZpZAfIh7aKI5FxhKSu(text))
					{
						num2 = 6;
						continue;
					}
					goto case 17;
				case 5:
					if (!Directory.Exists(text3))
					{
						num = 12;
						break;
					}
					goto case 2;
				case 19:
					text = SR.GetSetting((string)obZqqDfuzS9LgRKkPCMN(0x1C9495B4 ^ 0x1C91ABE2));
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 18;
					}
					continue;
				default:
					list.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FAF49B));
					num = 10;
					break;
				case 17:
					throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD38D06A), text));
				case 6:
					text3 = Path.Combine(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD5FCD8), (string)obZqqDfuzS9LgRKkPCMN(-345420348 ^ -345214322));
					num = 5;
					break;
				case 12:
					w8MoyEfIGshK9XGPPVtS(text3);
					num2 = 2;
					continue;
				case 18:
					if (!wDytl3fIFAXBYmIWQRSY(text))
					{
						num2 = 11;
						continue;
					}
					goto case 9;
				case 2:
					text2 = Path.Combine(text4, (string)obZqqDfuzS9LgRKkPCMN(-70007027 ^ -69797777));
					num2 = 14;
					continue;
				}
				break;
			}
		}
	}

	public override MetadataItemDTO GetMetadataItemDTO(IMetadata metadata)
	{
		return null;
	}

	public override IEnumerable<MetadataItemDTO> GetMetadataItemDTOList()
	{
		return new MetadataItemDTO[0];
	}

	protected override void OnInit()
	{
		base.OnInit();
	}

	protected override void OnInitComplete()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				base.OnInitComplete();
				num2 = 2;
				break;
			case 2:
				SCFBorfIqrdnNE2h70f5(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			default:
				CurrentProjectName = (string)lfns7kfusouuMx6QO9V4(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected override void RegisterComponent(IRegistrationBuilder<AbstractMetadataEditorComponent, SimpleActivatorData, SingleRegistrationStyle> registrar)
	{
		base.RegisterComponent(registrar);
		registrar.As<IMetadataEditorService>();
	}

	protected virtual void AddReferences()
	{
	}

	protected abstract void LoadProject();

	protected MemoryMetadataComponent()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		XkxOjmfIKt8tm9XibpBR();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object lfns7kfusouuMx6QO9V4(object P_0)
	{
		return ((AbstractMetadataEditorComponent)P_0).ProjectName;
	}

	internal static void jVlO8QfucQZXWUhErCYH(object P_0, object P_1, object P_2)
	{
		((AbstractMetadataEditorComponent)P_0).RemoveMetadata((string)P_1, (IMetadata)P_2);
	}

	internal static bool CViRgdfuLWRdZ8APmiA1()
	{
		return AlCa4AfuY0yXemTnMl7k == null;
	}

	internal static MemoryMetadataComponent H8CBQRfuUdFgtFU9ZmOc()
	{
		return AlCa4AfuY0yXemTnMl7k;
	}

	internal static object obZqqDfuzS9LgRKkPCMN(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool wDytl3fIFAXBYmIWQRSY(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object g2ta0ifIBo9c0YK90Ffo(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object QAMHK1fIWiImE3ClDy10()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object XuEXn9fIo3oaK7wHCVWP(object P_0)
	{
		return ((AppDomain)P_0).BaseDirectory;
	}

	internal static object fghQjXfIbPYjO4odO61I(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static bool gUZpZAfIh7aKI5FxhKSu(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object w8MoyEfIGshK9XGPPVtS(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static bool OaBB4MfIEaAXqVUjCNEr(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object AOmBNafIfBX4Fiop43Fy()
	{
		return DesignEnvironment.LibsDir;
	}

	internal static object z4Uha2fIQOU3skbJDQfl(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object ImJAtpfICKVJNDylACE9(object P_0)
	{
		return Path.GetFileName((string)P_0);
	}

	internal static void rCQmYZfIvFASnaP3TW24(object P_0, object P_1)
	{
		((ProcessStartInfo)P_0).FileName = (string)P_1;
	}

	internal static object vuqyXLfI8NfG1BPlLbw7(object P_0)
	{
		return ((Process)P_0).StartInfo;
	}

	internal static object FZ0XnOfIZi9Eo7xO4FVs(object P_0)
	{
		return ((List<string>)P_0).ToArray();
	}

	internal static object CPXIMOfIuCvyo094Ovbx(object P_0, object P_1)
	{
		return string.Join((string)P_0, (string[])P_1);
	}

	internal static object iDmJP2fIII9uRKghwhZN(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static void Eg36dEfIVJU91TT1gE6x(object P_0, object P_1)
	{
		((ProcessStartInfo)P_0).WorkingDirectory = (string)P_1;
	}

	internal static void asf5tpfISyRtJpNTWeNG(object P_0, bool P_1)
	{
		((ProcessStartInfo)P_0).CreateNoWindow = P_1;
	}

	internal static void EWNorwfIihFvMZP6bk7t(object P_0, bool P_1)
	{
		((ProcessStartInfo)P_0).UseShellExecute = P_1;
	}

	internal static void Nto1a1fIRTEraiPTZAq4(object P_0, object P_1, object P_2)
	{
		((StringDictionary)P_0).Add((string)P_1, (string)P_2);
	}

	internal static void SCFBorfIqrdnNE2h70f5(object P_0)
	{
		((MemoryMetadataComponent)P_0).LoadProject();
	}

	internal static void XkxOjmfIKt8tm9XibpBR()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
