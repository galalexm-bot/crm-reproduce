using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;
using href.Utils;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files.Previews;

public abstract class BaseFilePreviewCreator : IFilePreviewCreator, IMultiFilePreviewCreator
{
	private IFilePreviewService filePreviewService;

	internal static BaseFilePreviewCreator jo47JkGPuud1oaBpqmI1;

	private IFilePreviewService FilePreviewService
	{
		get
		{
			int num = 2;
			int num2 = num;
			IFilePreviewService filePreviewService = default(IFilePreviewService);
			IFilePreviewService obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					filePreviewService = (this.filePreviewService = Locator.GetServiceNotNull<IFilePreviewService>());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = this.filePreviewService;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					obj = filePreviewService;
					break;
				}
				break;
			}
			return obj;
		}
	}

	public abstract Guid Uid { get; }

	public abstract string DisplayName { get; }

	public IRuntimeApplication RuntimeApplication
	{
		[CompilerGenerated]
		get
		{
			return _003CRuntimeApplication_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CRuntimeApplication_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public IFolderPreviewService FolderPreviewService
	{
		[CompilerGenerated]
		get
		{
			return _003CFolderPreviewService_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CFolderPreviewService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual string PreviewDir => (string)LFajXVGPSYwNcR8ltppd(FolderPreviewService);

	public abstract List<string> Extensions { get; }

	public abstract void Create(string path, BinaryFile file);

	public virtual string GetRelativeMainFileName(BinaryFile file)
	{
		return (string)dnBpfRGPiGshsBZsAV78(0x31326106 ^ 0x31318BD8);
	}

	public virtual string GetTextFileName(string filePreviewDir, BinaryFile file)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!Directory.Exists(filePreviewDir))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return Path.Combine(filePreviewDir, (string)teivqtGPRb4DfAJ5X2NR(this, file));
			default:
				return null;
			}
		}
	}

	public virtual string GetTextFileName(BinaryFile file)
	{
		//Discarded unreachable code: IL_0041, IL_0050, IL_00cb, IL_010a
		int num = 1;
		int num2 = num;
		string text = default(string);
		Guid uid = default(Guid);
		string input = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 7:
				return (string)wtHtUfGPn6RR4buX2Isy(this, text, file);
			case 3:
				return null;
			default:
				if (e6gEEFGPXbo0uBLSeJsw(n6RPC6GPKHgW4ugI1lun(file), Guid.Empty))
				{
					num2 = 4;
					continue;
				}
				goto case 5;
			case 4:
				uid = file.Uid;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 2;
				}
				continue;
			case 6:
				text = (string)tFQjMJGPklsAOtl0tUQc(FolderPreviewService, Guid.Parse(input));
				num2 = 7;
				continue;
			case 1:
				if (!wZrSUJGPqFVSmn3Z2Lj8(PreviewDir))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 3;
			case 5:
				obj = NHBDpHGPTdAv5Y8KgKJB(file);
				break;
			case 2:
				obj = uid.ToString();
				break;
			}
			input = (string)obj;
			num2 = 6;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
			{
				num2 = 5;
			}
		}
	}

	public virtual string GetMainFileName(string filePreviewDir, BinaryFile file)
	{
		return (string)wtHtUfGPn6RR4buX2Isy(this, filePreviewDir, file);
	}

	public virtual string GetMainFileName(BinaryFile file)
	{
		return (string)W7d4AaGPOBf31K9gVjqM(this, file);
	}

	public virtual bool IsAvaliable(BinaryFile file)
	{
		//Discarded unreachable code: IL_007e, IL_008d
		int num = 3;
		int num2 = num;
		PreviewSettingsModule service = default(PreviewSettingsModule);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return B8BWjkGP2ymAymAotdGt(service, this);
			default:
				return true;
			case 2:
				if (service == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 3:
				service = Locator.GetService<PreviewSettingsModule>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual bool HasPreview(BinaryFile file)
	{
		return HasPreview(file, 5L);
	}

	public virtual bool HasPreview(BinaryFile file, long priority)
	{
		//Discarded unreachable code: IL_00ae, IL_00bd, IL_00f2, IL_0160, IL_016f
		int num = 8;
		int num2 = num;
		string mainFileName = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				if (!File.Exists(mainFileName))
				{
					num2 = 3;
					break;
				}
				if (!nKqDpGGPNokGhqCxg8S2(mainFileName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 1;
					}
					break;
				}
				return true;
			case 8:
				mainFileName = GetMainFileName(file);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 4;
				}
				break;
			case 10:
				return false;
			case 3:
			case 5:
				if (OdWmllGPeEflTeKjZfgT(file))
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 9;
			case 2:
			case 6:
				return true;
			case 4:
				lrPRU0GP1pYwR809PeF7(FilePreviewService, file, priority);
				num2 = 10;
				break;
			case 7:
				if (wZrSUJGPqFVSmn3Z2Lj8(mainFileName))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto default;
			case 1:
				return false;
			case 9:
				if (BryM3VGPPxfJvjlSj95F(FilePreviewService, file, null))
				{
					num2 = 4;
					break;
				}
				goto case 2;
			}
		}
	}

	public virtual string GetPreviewText(BinaryFile file)
	{
		//Discarded unreachable code: IL_00c3, IL_011e, IL_012d, IL_0143, IL_014e, IL_015d, IL_0168, IL_0263, IL_0276, IL_033f, IL_034e, IL_0397
		int num = 11;
		int num2 = num;
		Guid uid = default(Guid);
		string text2 = default(string);
		string text = default(string);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string text3 = default(string);
		string input = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 1:
				uid = file.Uid;
				num2 = 15;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				if (!BryM3VGPPxfJvjlSj95F(FilePreviewService, file, null))
				{
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 14;
					}
					break;
				}
				goto case 13;
			case 20:
				if (vjdmXTGP3druX7HLeoOl(text2))
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 2;
			case 17:
				if (!nKqDpGGPNokGhqCxg8S2(text2))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 5;
					}
				}
				else
				{
					text = "";
					num2 = 20;
				}
				break;
			case 19:
				obj = NHBDpHGPTdAv5Y8KgKJB(file);
				goto IL_0424;
			case 4:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
							{
								num3 = 4;
							}
							goto IL_016c;
						}
						goto IL_021f;
						IL_021f:
						text3 = (string)UFn9fmGPaVoRwutf8lf0(enumerator.Current);
						num3 = 2;
						goto IL_016c;
						IL_016c:
						while (true)
						{
							switch (num3)
							{
							case 3:
								text = (string)bFDdWFGPDS3HxeSJGeGd(text, dnBpfRGPiGshsBZsAV78(0x1ECE530A ^ 0x1ECE1A28), text3);
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
								{
									num3 = 5;
								}
								continue;
							case 2:
								text3 = text3.GetClearBodyFromHtml();
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
								{
									num3 = 0;
								}
								continue;
							case 5:
								break;
							default:
								text3 = text3.SanitizeHtml();
								num3 = 3;
								continue;
							case 1:
								goto IL_021f;
							case 4:
								return text;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 2:
				if (new List<string>
				{
					(string)dnBpfRGPiGshsBZsAV78(-195614443 ^ -195763815),
					(string)dnBpfRGPiGshsBZsAV78(-3333094 ^ -3216256)
				}.Contains(Path.GetExtension(text2)))
				{
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 16;
					}
					break;
				}
				goto case 8;
			case 18:
				if (e6gEEFGPXbo0uBLSeJsw(n6RPC6GPKHgW4ugI1lun(file), Guid.Empty))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 19;
			case 8:
			case 9:
				text = File.ReadAllText(text2);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 6;
				}
				break;
			case 11:
				text2 = (string)W7d4AaGPOBf31K9gVjqM(this, file);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 10;
				}
				break;
			default:
				throw new PreviewTextFileDoNotExistException();
			case 10:
				if (wZrSUJGPqFVSmn3Z2Lj8(text2))
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 17;
			case 13:
				lrPRU0GP1pYwR809PeF7(FilePreviewService, file, 0L);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
			case 6:
				if (file.Encrypt)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 16;
					}
					break;
				}
				goto case 3;
			case 7:
				return text;
			case 15:
				obj = uid.ToString();
				goto IL_0424;
			case 12:
				{
					enumerator = ((IEnumerable<string>)GcOWxPGPp33Nq2LEGqtj(tFQjMJGPklsAOtl0tUQc(FolderPreviewService, Guid.Parse(input)), dnBpfRGPiGshsBZsAV78(0x18A6761F ^ 0x18A606B5), SearchOption.AllDirectories)).Where(delegate(string s)
					{
						int num5 = 2;
						int num6 = num5;
						while (true)
						{
							switch (num6)
							{
							case 2:
								if (!s.EndsWith((string)_003C_003Ec.vFu55jvz4QQnZ5iiQ712(-2106517564 ^ -2106400952)))
								{
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
									{
										num6 = 1;
									}
									break;
								}
								goto IL_0074;
							default:
								return _003C_003Ec.IvFatEvz61ysiOPFZutd(s, _003C_003Ec.vFu55jvz4QQnZ5iiQ712(-643786247 ^ -643608221));
							case 1:
								{
									if (!_003C_003Ec.IvFatEvz61ysiOPFZutd(s, _003C_003Ec.vFu55jvz4QQnZ5iiQ712(-1979251663 ^ -1979524003)))
									{
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
										{
											num6 = 0;
										}
										break;
									}
									goto IL_0074;
								}
								IL_0074:
								return true;
							}
						}
					}).ToList().GetEnumerator();
					num2 = 4;
					break;
				}
				IL_0424:
				input = (string)obj;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 12;
				}
				break;
			}
		}
	}

	protected virtual Encoding GetFileEncoding(string filename)
	{
		return (Encoding)uTYWiyGPwXeEY72MTyuL(uwAH8SGPtp8GbkFDifp1(filename));
	}

	public virtual bool EnableGenerateHtml()
	{
		return true;
	}

	public IEnumerable<string> GetPreviewFilesList(BinaryFile file)
	{
		string textFileName = GetTextFileName(file);
		if (string.IsNullOrEmpty(textFileName) || !File.Exists(textFileName))
		{
			if (!file.Encrypt && FilePreviewService.CheckPassword(file, null))
			{
				FilePreviewService.AddPreviewWork(file, 0L);
			}
			throw new PreviewTextFileDoNotExistException();
		}
		if (!string.IsNullOrWhiteSpace(textFileName) && new List<string>
		{
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289896730),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108095356)
		}.Contains(Path.GetExtension(textFileName)))
		{
			string input = ((file.Uid != Guid.Empty) ? file.Uid.ToString() : file.Id);
			return Directory.GetFiles(FolderPreviewService.GetPreviewDirectory(Guid.Parse(input)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675485419), SearchOption.AllDirectories).Where(delegate(string s)
			{
				//Discarded unreachable code: IL_004e, IL_005d, IL_006d, IL_007c
				int num = 4;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						return _003C_003Ec.IvFatEvz61ysiOPFZutd(s, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD698CA));
					default:
						return true;
					case 1:
						if (_003C_003Ec.IvFatEvz61ysiOPFZutd(s, _003C_003Ec.vFu55jvz4QQnZ5iiQ712(0x63ABA4E8 ^ 0x63AE7C84)))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 2;
					case 4:
						if (_003C_003Ec.IvFatEvz61ysiOPFZutd(s, _003C_003Ec.vFu55jvz4QQnZ5iiQ712(-812025778 ^ -811945790)))
						{
							num2 = 3;
							break;
						}
						goto case 1;
					}
				}
			}).ToList();
		}
		return new List<string> { textFileName };
	}

	public long GetTextPreviewFilesSize(BinaryFile file)
	{
		//Discarded unreachable code: IL_005d, IL_0067, IL_014b, IL_017b, IL_018a, IL_0196, IL_01a5
		int num = 2;
		int num2 = num;
		long num4 = default(long);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current = default(string);
		FileInfo fileInfo = default(FileInfo);
		while (true)
		{
			switch (num2)
			{
			case 2:
			{
				IEnumerable<string> previewFilesList = GetPreviewFilesList(file);
				num4 = 0L;
				enumerator = previewFilesList.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 1;
				}
				break;
			}
			default:
				return num4;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!MI4lGEGP42Sl2CqEoibr(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
							{
								num3 = 0;
							}
							goto IL_006b;
						}
						goto IL_0102;
						IL_0102:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num3 = 5;
						}
						goto IL_006b;
						IL_006b:
						while (true)
						{
							switch (num3)
							{
							default:
								return num4;
							case 0:
								return num4;
							case 2:
								fileInfo = new FileInfo(current);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
								{
									num3 = 0;
								}
								continue;
							case 5:
								if (nKqDpGGPNokGhqCxg8S2(current))
								{
									num3 = 2;
									continue;
								}
								break;
							case 4:
								break;
							case 1:
								num4 += fileInfo.Length;
								num3 = 4;
								continue;
							case 3:
								goto IL_0102;
							}
							break;
						}
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num5 = 1;
						}
						goto IL_014f;
					}
					goto IL_0165;
					IL_0165:
					UgaivGGP653HEsafxNS2(enumerator);
					num5 = 2;
					goto IL_014f;
					IL_014f:
					switch (num5)
					{
					case 1:
						goto end_IL_012a;
					case 2:
						goto end_IL_012a;
					}
					goto IL_0165;
					end_IL_012a:;
				}
			}
		}
	}

	protected BaseFilePreviewCreator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		itn6LSGPHRDiNLNkhiQ4();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool vEZ4omGPITsm3KaJrw35()
	{
		return jo47JkGPuud1oaBpqmI1 == null;
	}

	internal static BaseFilePreviewCreator gutnrGGPVhHBOmEdl0uK()
	{
		return jo47JkGPuud1oaBpqmI1;
	}

	internal static object LFajXVGPSYwNcR8ltppd(object P_0)
	{
		return ((IFolderPreviewService)P_0).PreviewsPath;
	}

	internal static object dnBpfRGPiGshsBZsAV78(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object teivqtGPRb4DfAJ5X2NR(object P_0, object P_1)
	{
		return ((BaseFilePreviewCreator)P_0).GetRelativeMainFileName((BinaryFile)P_1);
	}

	internal static bool wZrSUJGPqFVSmn3Z2Lj8(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static Guid n6RPC6GPKHgW4ugI1lun(object P_0)
	{
		return ((BinaryFile)P_0).Uid;
	}

	internal static bool e6gEEFGPXbo0uBLSeJsw(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object NHBDpHGPTdAv5Y8KgKJB(object P_0)
	{
		return ((BinaryFile)P_0).Id;
	}

	internal static object tFQjMJGPklsAOtl0tUQc(object P_0, Guid id)
	{
		return ((IFolderPreviewService)P_0).GetPreviewDirectory(id);
	}

	internal static object wtHtUfGPn6RR4buX2Isy(object P_0, object P_1, object P_2)
	{
		return ((BaseFilePreviewCreator)P_0).GetTextFileName((string)P_1, (BinaryFile)P_2);
	}

	internal static object W7d4AaGPOBf31K9gVjqM(object P_0, object P_1)
	{
		return ((BaseFilePreviewCreator)P_0).GetTextFileName((BinaryFile)P_1);
	}

	internal static bool B8BWjkGP2ymAymAotdGt(object P_0, object P_1)
	{
		return ((PreviewSettingsModule)P_0).IsEnabledPreview((IFilePreviewCreator)P_1);
	}

	internal static bool OdWmllGPeEflTeKjZfgT(object P_0)
	{
		return ((BinaryFile)P_0).Encrypt;
	}

	internal static bool BryM3VGPPxfJvjlSj95F(object P_0, object P_1, object P_2)
	{
		return ((IFilePreviewService)P_0).CheckPassword((BinaryFile)P_1, (string)P_2);
	}

	internal static void lrPRU0GP1pYwR809PeF7(object P_0, object P_1, long priority)
	{
		((IFilePreviewService)P_0).AddPreviewWork((BinaryFile)P_1, priority);
	}

	internal static bool nKqDpGGPNokGhqCxg8S2(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static bool vjdmXTGP3druX7HLeoOl(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object GcOWxPGPp33Nq2LEGqtj(object P_0, object P_1, SearchOption P_2)
	{
		return Directory.GetFiles((string)P_0, (string)P_1, P_2);
	}

	internal static object UFn9fmGPaVoRwutf8lf0(object P_0)
	{
		return File.ReadAllText((string)P_0);
	}

	internal static object bFDdWFGPDS3HxeSJGeGd(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object uwAH8SGPtp8GbkFDifp1(object P_0)
	{
		return File.ReadAllBytes((string)P_0);
	}

	internal static object uTYWiyGPwXeEY72MTyuL(object P_0)
	{
		return EncodingTools.DetectInputCodepage((byte[])P_0);
	}

	internal static bool MI4lGEGP42Sl2CqEoibr(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void UgaivGGP653HEsafxNS2(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void itn6LSGPHRDiNLNkhiQ4()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
