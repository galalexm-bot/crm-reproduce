using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Deploy.Managers;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Packaging;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Export;

[Component(Order = 500)]
internal class TranslateExportExtension : IConfigExportExtension
{
	private readonly IDeployManager deployManager;

	private readonly PackageService packageService;

	private readonly string version;

	private readonly List<string> pathsSavingPO;

	private readonly string basePathSave;

	internal static TranslateExportExtension t4iC5dE5quoRGSgnhpsx;

	public TranslateExportExtension(IDeployManager deployManager, PackageService packageService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oVIY5AE5TNSvHyajOOIN();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
		{
			num = 4;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				pathsSavingPO = new List<string>
				{
					string.Format((string)VvgcP5E5nnKc3F5Hnt0h(-1921202237 ^ -1921500397), U5oIw6E5OWn16rnXF5vG()),
					string.Format((string)VvgcP5E5nnKc3F5Hnt0h(-561074844 ^ -561360494), U5oIw6E5OWn16rnXF5vG())
				};
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num = 3;
				}
				break;
			case 3:
				basePathSave = (string)wc8MbfE52k8OFp4cMold(packageService);
				num = 2;
				break;
			case 2:
				return;
			case 4:
				this.deployManager = deployManager;
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num = 5;
				}
				break;
			case 5:
				this.packageService = packageService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num = 0;
				}
				break;
			default:
				version = VersionInfo.GetVersion(VXgMiuE5ki3HoDlUE8vO(this)).ToString();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void AddExportObjects(ExportExtensionParams parameters)
	{
		//Discarded unreachable code: IL_0039
		int num = 2;
		int num2 = num;
		IEnumerable<PackageDescription> translates = default(IEnumerable<PackageDescription>);
		TranslateExportSettings translateSettings = default(TranslateExportSettings);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			case 4:
				translates = FindTranslates();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			default:
				AddPackageDescriptions(parameters, translates, translateSettings);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (translateSettings == null)
				{
					return;
				}
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				translateSettings = GetTranslateSettings(parameters);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void AddPackageDescriptions(ExportExtensionParams parameters, IEnumerable<PackageDescription> translates, TranslateExportSettings settings)
	{
		using List<CultureInfo>.Enumerator enumerator = settings.Translates.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
			CS_0024_003C_003E8__locals0.item = enumerator.Current;
			PackageDescription packageDescription = translates.FirstOrDefault((PackageDescription p) => _003C_003Ec__DisplayClass8_0.zlTZ8L8xKVA1hTEkgGvP(_003C_003Ec__DisplayClass8_0.i6PaWs8xqR34BlCXLDpl(p), CS_0024_003C_003E8__locals0.item.ToString()));
			if (packageDescription == null)
			{
				parameters.PackageDescriptions.Add(CreatePackage(CS_0024_003C_003E8__locals0.item));
			}
			else
			{
				parameters.PackageDescriptions.Add(packageDescription);
			}
		}
	}

	private TranslateExportSettings GetTranslateSettings(ExportExtensionParams parameters)
	{
		//Discarded unreachable code: IL_0039, IL_00a4
		int num = 2;
		int num2 = num;
		TranslateExportSettings translateExportSettings = default(TranslateExportSettings);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (translateExportSettings.ExportTranslate)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto default;
			default:
				return null;
			case 5:
				return translateExportSettings;
			case 2:
				translateExportSettings = parameters.Parameters[TranslateExportConst.ExportExtensionUid] as TranslateExportSettings;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (translateExportSettings == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	private IEnumerable<PackageDescription> FindTranslates()
	{
		PackageFilter filter = new PackageFilter
		{
			Level = PackageLevel.All,
			Status = PackageStatus.Any
		};
		return deployManager.FindPackages(filter);
	}

	public Dictionary<Guid, object> GetNewSettingObj()
	{
		return new Dictionary<Guid, object> { 
		{
			TranslateExportConst.ExportExtensionUid,
			new TranslateExportSettings()
		} };
	}

	private PackageDescription CreatePackage(CultureInfo info)
	{
		int num = 2;
		int num2 = num;
		PackageDescription packageDescription = default(PackageDescription);
		while (true)
		{
			switch (num2)
			{
			case 1:
				SaveManifestMetadata(packageDescription, info);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return packageDescription;
			case 2:
				packageDescription = CreatePackageDescription(info);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 1;
				}
				break;
			default:
				BuildPackage(packageDescription, info);
				num2 = 3;
				break;
			}
		}
	}

	private PackageDescription CreatePackageDescription(CultureInfo info)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		PackageDescription obj = new PackageDescription
		{
			Id = (string)HPFANAE5PLWFevX9sukw(VvgcP5E5nnKc3F5Hnt0h(0x12A5FAC7 ^ 0x12A5B8C5), VvgcP5E5nnKc3F5Hnt0h(-2106517564 ^ -2106201386), HcEWX3E5ecY2OG0XrRiV(info))
		};
		UjaQcoE51J6eY69knYyK(obj, info.NativeName);
		obj.Authors = new List<string> { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x426461F7) };
		obj.InstalledVersion = new SemanticVersion(version);
		obj.Description = (string)Hbr3tnE5NAjOZA8yKj0b(VvgcP5E5nnKc3F5Hnt0h(0x4785BC0D ^ 0x47814133), info.DisplayName);
		IhgHcgE53vtwnNIPUBox(obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C9068D6));
		FnviIZE5pYTEcdXyeOwE(obj, (object)new SemanticVersion(version));
		MGGwY4E5aRysVCtVrGPD(obj, ElmaPackageType.Translates);
		return obj;
	}

	private ManifestMetadata CreateManifestMetadata(PackageDescription packageDescription, CultureInfo info)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0063: Expected O, but got Unknown
		ManifestMetadata val = new ManifestMetadata();
		V935fkE5tIGvtmIIvrtQ((object)val, bkTHHpE5DBXhm2HLQRYu(packageDescription));
		val.set_Authors(string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858880269), packageDescription.Authors));
		Yf4YXuE5wBRkWbtnZnIQ((object)val, version);
		HP9AaSE56QwmGYHd7Hc7((object)val, H6ndXFE54C9CEawxriTF(packageDescription));
		uKuRLvE5HtIyKnEByBhC((object)val, HcEWX3E5ecY2OG0XrRiV(info));
		IueUVwE57AJvvw1Dfkii((object)val, WX7XaYE5AhGtcdCqGNjQ(packageDescription));
		return val;
	}

	private void SaveManifestMetadata(PackageDescription packageDescription, CultureInfo info)
	{
		//Discarded unreachable code: IL_007a, IL_00b2, IL_00ea, IL_00f9
		int num = 2;
		int num2 = num;
		Manifest val = default(Manifest);
		FileStream fileStream = default(FileStream);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				val = (Manifest)Y6YqXwE5xKSLGy8epxe6(CreateManifestMetadata(packageDescription, info));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 3:
				try
				{
					val.Save((Stream)fileStream);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					if (fileStream != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								Gq7SriE5yFXes5wvLeoB(fileStream);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 1:
				fileStream = (FileStream)swREo3E5mehiGhjF4CLj(FDWee6E50JeldIDlw6y0(VvgcP5E5nnKc3F5Hnt0h(0xA592A41 ^ 0xA5DD793), new object[4]
				{
					basePathSave,
					VvgcP5E5nnKc3F5Hnt0h(0x34185E55 ^ 0x341CA347),
					HcEWX3E5ecY2OG0XrRiV(info),
					version
				}));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	private void BuildPackage(PackageDescription packageDescription, CultureInfo info)
	{
		int num = 4;
		int num2 = num;
		PackageBuilder val = default(PackageBuilder);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				CopyFiles(val, info, (string)HPFANAE5PLWFevX9sukw(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70010987), SR.Dir, HcEWX3E5ecY2OG0XrRiV(info)), (string)HPFANAE5PLWFevX9sukw(VvgcP5E5nnKc3F5Hnt0h(-1487388570 ^ -1487392514), SR.Dir, info.Name));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				val = CreatePackageBuilder(packageDescription, info);
				num2 = 3;
				break;
			case 3:
				SetDependencePackage(val);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				SavePackage(val, info);
				num2 = 2;
				break;
			}
		}
	}

	private void CopyFiles(PackageBuilder builder, CultureInfo info, string path, string fullFolder)
	{
		//Discarded unreachable code: IL_0069, IL_00d5, IL_00e4, IL_00ef, IL_01f4, IL_0207, IL_025d, IL_029c
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		int num = 16;
		int num3 = default(int);
		string[] array = default(string[]);
		string path2 = default(string);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
		string text = default(string);
		string fileName = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
				case 5:
					if (num3 >= array.Length)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 17:
					CopyFiles(builder, info, path2, fullFolder);
					num2 = 2;
					continue;
				case 2:
					num3++;
					num2 = 11;
					continue;
				case 7:
				case 10:
					path2 = array[num3];
					num2 = 17;
					continue;
				case 9:
					try
					{
						while (true)
						{
							int num4;
							if (!enumerator.MoveNext())
							{
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
								{
									num4 = 1;
								}
								goto IL_00f3;
							}
							goto IL_01a5;
							IL_01a5:
							current = enumerator.Current;
							num4 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
							{
								num4 = 0;
							}
							goto IL_00f3;
							IL_00f3:
							while (true)
							{
								switch (num4)
								{
								case 3:
									break;
								case 2:
								{
									Collection<IPackageFile> files = builder.get_Files();
									PhysicalPackageFile val = new PhysicalPackageFile();
									QaY69rE59nDYxA741Vcl(val, text);
									dK1x8yE5lYjsEKIVgoo1(val, FDWee6E50JeldIDlw6y0(VvgcP5E5nnKc3F5Hnt0h(0x4EDCBA32 ^ 0x4ED84430), new object[4]
									{
										current,
										HcEWX3E5ecY2OG0XrRiV(info),
										jKULa5E5dTRBmgVIcVvu(path, fullFolder, ""),
										fileName
									}));
									files.Add((IPackageFile)(object)val);
									num4 = 3;
									continue;
								}
								default:
									goto IL_01a5;
								case 1:
									goto end_IL_010d;
								}
								break;
							}
							continue;
							end_IL_010d:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 14;
				case 4:
					break;
				case 14:
					num3++;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 3;
					}
					continue;
				case 16:
					array = (string[])V7Mn5RE5M10VLEavxqPH(path);
					num2 = 15;
					continue;
				case 13:
					num3 = 0;
					num2 = 5;
					continue;
				case 0:
					return;
				case 6:
					array = (string[])ubthiuE5J3dKpb1Lrg7t(path);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 5;
					}
					continue;
				case 1:
				case 11:
					if (num3 < array.Length)
					{
						num2 = 7;
						continue;
					}
					goto case 6;
				case 15:
					num3 = 0;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 1;
					}
					continue;
				case 12:
					fileName = Path.GetFileName(text);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					enumerator = pathsSavingPO.GetEnumerator();
					num2 = 9;
					continue;
				}
				break;
			}
			text = array[num3];
			num = 12;
		}
	}

	private PackageBuilder CreatePackageBuilder(PackageDescription packageDescription, CultureInfo info)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		int num = 7;
		PackageBuilder val = default(PackageBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					Vv9isqE5g50by0rd9v1c(val, ijFcQdE5rRRWGxxGOoMM(info));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					val.get_Tags().AddRange((IEnumerable<string>)jbVGwVE5YFWct5yGRCtX(packageDescription.Tags, new char[1] { ' ' }));
					num = 3;
					break;
				case 7:
					val = new PackageBuilder();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 6;
					}
					continue;
				case 6:
					val.set_Id((string)bkTHHpE5DBXhm2HLQRYu(packageDescription));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 2;
					}
					continue;
				case 3:
					return val;
				default:
					wH2fyBE55qsVhcAjrFxV(val, H6ndXFE54C9CEawxriTF(packageDescription));
					num2 = 5;
					continue;
				case 8:
					val.set_Version(packageDescription.InstalledVersion);
					num = 4;
					break;
				case 5:
					e5xgpHE5jrO7BRe4X3Qg(val, info.Name);
					num2 = 8;
					continue;
				case 4:
					val.get_Authors().Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A77C443));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	private void SetDependencePackage(PackageBuilder builder)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		int num = 4;
		int num2 = num;
		List<PackageDependency> list = default(List<PackageDependency>);
		PackageDependencySet item = default(PackageDependencySet);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 4:
				list = new List<PackageDependency>();
				num2 = 3;
				break;
			case 3:
				list.Add(new PackageDependency((string)VvgcP5E5nnKc3F5Hnt0h(-957824448 ^ -957596574)));
				num2 = 2;
				break;
			case 2:
				item = new PackageDependencySet((FrameworkName)null, (IEnumerable<PackageDependency>)list);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				break;
			default:
				builder.get_DependencySets().Add(item);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void SavePackage(PackageBuilder builder, CultureInfo info)
	{
		//Discarded unreachable code: IL_004b, IL_0083, IL_00a2, IL_00ce, IL_00dd
		int num = 1;
		int num2 = num;
		FileStream fileStream = default(FileStream);
		while (true)
		{
			switch (num2)
			{
			case 1:
				fileStream = File.Create((string)FDWee6E50JeldIDlw6y0(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61E8F2EA), new object[4]
				{
					basePathSave,
					VvgcP5E5nnKc3F5Hnt0h(-1411196499 ^ -1410980673),
					info.Name,
					version
				}));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				nq38BdE5L4Jtq1mCDLFE(builder, fileStream);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
				return;
			}
			finally
			{
				int num4;
				if (fileStream == null)
				{
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num4 = 0;
					}
					goto IL_0087;
				}
				goto IL_00ac;
				IL_00ac:
				Gq7SriE5yFXes5wvLeoB(fileStream);
				num4 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num4 = 1;
				}
				goto IL_0087;
				IL_0087:
				switch (num4)
				{
				default:
					goto end_IL_0062;
				case 0:
					goto end_IL_0062;
				case 2:
					break;
				case 1:
					goto end_IL_0062;
				}
				goto IL_00ac;
				end_IL_0062:;
			}
		}
	}

	internal static void oVIY5AE5TNSvHyajOOIN()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type VXgMiuE5ki3HoDlUE8vO(object P_0)
	{
		return P_0.GetType();
	}

	internal static object VvgcP5E5nnKc3F5Hnt0h(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object U5oIw6E5OWn16rnXF5vG()
	{
		return SR.ResourcesDirectory;
	}

	internal static object wc8MbfE52k8OFp4cMold(object P_0)
	{
		return ((PackageService)P_0).LocalRepositoryPath;
	}

	internal static bool lScZZhE5K6fDn0aDseiY()
	{
		return t4iC5dE5quoRGSgnhpsx == null;
	}

	internal static TranslateExportExtension YOvK9BE5XTIbi25Bo8n8()
	{
		return t4iC5dE5quoRGSgnhpsx;
	}

	internal static object HcEWX3E5ecY2OG0XrRiV(object P_0)
	{
		return ((CultureInfo)P_0).Name;
	}

	internal static object HPFANAE5PLWFevX9sukw(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void UjaQcoE51J6eY69knYyK(object P_0, object P_1)
	{
		((PackageDescription)P_0).Title = (string)P_1;
	}

	internal static object Hbr3tnE5NAjOZA8yKj0b(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void IhgHcgE53vtwnNIPUBox(object P_0, object P_1)
	{
		((PackageDescription)P_0).Tags = (string)P_1;
	}

	internal static void FnviIZE5pYTEcdXyeOwE(object P_0, object P_1)
	{
		((PackageDescription)P_0).LastVersion = (SemanticVersion)P_1;
	}

	internal static void MGGwY4E5aRysVCtVrGPD(object P_0, ElmaPackageType value)
	{
		((PackageDescription)P_0).Type = value;
	}

	internal static object bkTHHpE5DBXhm2HLQRYu(object P_0)
	{
		return ((PackageDescription)P_0).Id;
	}

	internal static void V935fkE5tIGvtmIIvrtQ(object P_0, object P_1)
	{
		((ManifestMetadata)P_0).set_Id((string)P_1);
	}

	internal static void Yf4YXuE5wBRkWbtnZnIQ(object P_0, object P_1)
	{
		((ManifestMetadata)P_0).set_Version((string)P_1);
	}

	internal static object H6ndXFE54C9CEawxriTF(object P_0)
	{
		return ((PackageDescription)P_0).Description;
	}

	internal static void HP9AaSE56QwmGYHd7Hc7(object P_0, object P_1)
	{
		((ManifestMetadata)P_0).set_Description((string)P_1);
	}

	internal static void uKuRLvE5HtIyKnEByBhC(object P_0, object P_1)
	{
		((ManifestMetadata)P_0).set_Language((string)P_1);
	}

	internal static object WX7XaYE5AhGtcdCqGNjQ(object P_0)
	{
		return ((PackageDescription)P_0).Tags;
	}

	internal static void IueUVwE57AJvvw1Dfkii(object P_0, object P_1)
	{
		((ManifestMetadata)P_0).set_Tags((string)P_1);
	}

	internal static object Y6YqXwE5xKSLGy8epxe6(object P_0)
	{
		return Manifest.Create((IPackageMetadata)P_0);
	}

	internal static object FDWee6E50JeldIDlw6y0(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object swREo3E5mehiGhjF4CLj(object P_0)
	{
		return File.Create((string)P_0);
	}

	internal static void Gq7SriE5yFXes5wvLeoB(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object V7Mn5RE5M10VLEavxqPH(object P_0)
	{
		return Directory.GetDirectories((string)P_0);
	}

	internal static object ubthiuE5J3dKpb1Lrg7t(object P_0)
	{
		return Directory.GetFiles((string)P_0);
	}

	internal static void QaY69rE59nDYxA741Vcl(object P_0, object P_1)
	{
		((PhysicalPackageFile)P_0).set_SourcePath((string)P_1);
	}

	internal static object jKULa5E5dTRBmgVIcVvu(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static void dK1x8yE5lYjsEKIVgoo1(object P_0, object P_1)
	{
		((PhysicalPackageFile)P_0).set_TargetPath((string)P_1);
	}

	internal static object ijFcQdE5rRRWGxxGOoMM(object P_0)
	{
		return ((CultureInfo)P_0).NativeName;
	}

	internal static void Vv9isqE5g50by0rd9v1c(object P_0, object P_1)
	{
		((PackageBuilder)P_0).set_Title((string)P_1);
	}

	internal static void wH2fyBE55qsVhcAjrFxV(object P_0, object P_1)
	{
		((PackageBuilder)P_0).set_Description((string)P_1);
	}

	internal static void e5xgpHE5jrO7BRe4X3Qg(object P_0, object P_1)
	{
		((PackageBuilder)P_0).set_Language((string)P_1);
	}

	internal static object jbVGwVE5YFWct5yGRCtX(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static void nq38BdE5L4Jtq1mCDLFE(object P_0, object P_1)
	{
		((PackageBuilder)P_0).Save((Stream)P_1);
	}
}
