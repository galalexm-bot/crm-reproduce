using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Services;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files.Previews;

[Service]
public class FilePreviewService : IFilePreviewService
{
	private sealed class FilePreviewEventHandler : IFilePreviewEventHandler, IEventHandler
	{
		private readonly object fileId;

		private readonly TaskCompletionSource<bool> taskCompletionSource;

		internal static object rcYSkqvzHsPLUjFUJtND;

		public Task Wait => taskCompletionSource.Task;

		public FilePreviewEventHandler(string fileId)
		{
			//Discarded unreachable code: IL_003c, IL_0041
			SingletonReader.JJCZtPuTvSt();
			taskCompletionSource = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					this.fileId = fileId;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public Task Complete(string fileId, Exception exception = null)
		{
			//Discarded unreachable code: IL_0041, IL_0050, IL_0086, IL_0095, IL_00a4
			int num = 6;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return Task.CompletedTask;
					case 4:
						if (exception != null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 2;
					case 2:
						taskCompletionSource.SetResult(result: true);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num2 = 0;
						}
						continue;
					case 6:
						if (!km8fkpvzx32sRLC8D3HL(this.fileId, fileId, StringComparison.InvariantCultureIgnoreCase))
						{
							num2 = 5;
							continue;
						}
						goto case 4;
					case 1:
					case 3:
						break;
					}
					break;
				}
				taskCompletionSource.SetException(exception);
				num = 7;
			}
		}

		internal static bool BWMcnZvzAu1EVf408syF()
		{
			return rcYSkqvzHsPLUjFUJtND == null;
		}

		internal static FilePreviewEventHandler j0f9unvz7EpyF7DVJlAn()
		{
			return (FilePreviewEventHandler)rcYSkqvzHsPLUjFUJtND;
		}

		internal static bool km8fkpvzx32sRLC8D3HL(object P_0, object P_1, StringComparison P_2)
		{
			return ((string)P_0).Equals((string)P_1, P_2);
		}
	}

	private readonly ILazy<IEventHandlerSubscribeService> eventHandlerSubscribeService;

	internal static FilePreviewService OmsEAWGPAmnaGfupbY8D;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string PreviewDir => (string)QCkbsrGP0w0BgFiiPS5A(FolderPreviewService);

	public IFilePreviewServiceProvider FilePreviewServiceProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CFilePreviewServiceProvider_003Ek__BackingField;
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
					_003CFilePreviewServiceProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public FilePreviewService(ILazy<IEventHandlerSubscribeService> eventHandlerSubscribeService)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.eventHandlerSubscribeService = eventHandlerSubscribeService;
	}

	public string GetPreviewText(BinaryFile file)
	{
		int num = 2;
		int num2 = num;
		IFilePreviewCreator previewCreator = default(IFilePreviewCreator);
		while (true)
		{
			switch (num2)
			{
			default:
				return "";
			case 1:
				if (previewCreator != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 3:
				if (WmRikEGPm5PP9XdU4PjX(previewCreator, file))
				{
					return (string)jtWg5wGPyCPx0SKZKQQ4(previewCreator, file);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				previewCreator = GetPreviewCreator(file);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual void AddPreviewWork(BinaryFile file, long priority)
	{
		//Discarded unreachable code: IL_0085
		int num = 3;
		int num2 = num;
		string text2 = default(string);
		Guid guid = default(Guid);
		while (true)
		{
			string text;
			switch (num2)
			{
			default:
				mibgxiGP9YmGkNoNfFDS(FilePreviewServiceProvider, text2, priority);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				text = file.Id;
				break;
			case 3:
				if (Qbm57fGPJwKHI5E1FkDp(fMC50iGPM2Q9HrF2XCwB(file), Guid.Empty))
				{
					guid = fMC50iGPM2Q9HrF2XCwB(file);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 2;
				}
				continue;
			case 4:
				return;
			case 1:
				text = guid.ToString();
				break;
			}
			text2 = text;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
			{
				num2 = 0;
			}
		}
	}

	public PreviewWorkStatus GetPreviewWorkStatus(BinaryFile file)
	{
		//Discarded unreachable code: IL_00f0
		int num = 3;
		Guid guid = default(Guid);
		PreviewWorkStatus previewWorkStatus = default(PreviewWorkStatus);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 3:
					if (Qbm57fGPJwKHI5E1FkDp(fMC50iGPM2Q9HrF2XCwB(file), Guid.Empty))
					{
						guid = fMC50iGPM2Q9HrF2XCwB(file);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto end_IL_0012;
				case 5:
					if (!HasPreview(file))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					return PreviewWorkStatus.Completed;
				case 6:
					if (previewWorkStatus == PreviewWorkStatus.None)
					{
						num2 = 5;
						continue;
					}
					return previewWorkStatus;
				case 4:
					previewWorkStatus = my57aMGPlNTfP6Xcjdh0(FilePreviewServiceProvider, text);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					return PreviewWorkStatus.None;
				case 2:
					obj = GnYjZgGPdHk6a8FQ4BJ2(file);
					break;
				default:
					obj = guid.ToString();
					break;
				}
				text = (string)obj;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 4;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	public void ClearPreview(BinaryFile file)
	{
		//Discarded unreachable code: IL_0045, IL_0104, IL_0132, IL_0141
		int num = 3;
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_;
		string text2 = default(string);
		Guid guid = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				string text;
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 4:
					_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
					_003C_003Ec__DisplayClass16_.filePreviewDir = (string)bBEBZuGPjFvb5VJKFToy(FolderPreviewService, iJungfGP5ZHubUWWyCZ8(text2));
					Lugm43GPYJOmE7mqQBuV((Action)delegate
					{
						//Discarded unreachable code: IL_0072, IL_0081
						int num3 = 2;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 1:
								return;
							case 3:
								return;
							case 2:
								if (!Directory.Exists(_003C_003Ec__DisplayClass16_.filePreviewDir))
								{
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
									{
										num4 = 1;
									}
									continue;
								}
								break;
							}
							_003C_003Ec__DisplayClass16_0.TORyTHvzMYpXfbcJ2Mav(_003C_003Ec__DisplayClass16_.filePreviewDir, true);
							num4 = 3;
						}
					});
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 8;
					}
					continue;
				case 8:
					return;
				case 3:
					if (!djcAnVGPrHZDkPviXBUy(PreviewDir))
					{
						num2 = 2;
						continue;
					}
					return;
				case 7:
					if (DB0jVtGPg6wZpXBYYSPb(text2))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 6:
					text = file.Id;
					break;
				case 5:
					return;
				case 2:
					if (fMC50iGPM2Q9HrF2XCwB(file) != Guid.Empty)
					{
						guid = fMC50iGPM2Q9HrF2XCwB(file);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto end_IL_0012;
				case 1:
					text = guid.ToString();
					break;
				}
				text2 = text;
				num2 = 7;
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	public IFilePreviewCreator GetPreviewCreator(BinaryFile file)
	{
		return FilePreviewServiceProvider.GetFilePreviewCreator(file);
	}

	public void GeneratePreview(BinaryFile file)
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
				GeneratePreview(file, null, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private string UnionPasswords(string fileEncryptPassword, string password)
	{
		return (string)cmCQjvGPLfD5ZfYwXqe9(fileEncryptPassword, password);
	}

	public void GeneratePreview(BinaryFile file, string fileEncryptPassword, string password)
	{
		//Discarded unreachable code: IL_00fc, IL_010b, IL_01ea, IL_01f9, IL_022d, IL_02b6, IL_02f6, IL_0305, IL_0311, IL_035f, IL_036e, IL_0390, IL_039f, IL_0461, IL_0470, IL_047b, IL_0508, IL_0538, IL_0547, IL_0553, IL_0562, IL_059c, IL_05ab, IL_05b6, IL_0642, IL_0661, IL_0670, IL_068d, IL_069c, IL_07a0, IL_07bf, IL_07ce, IL_07fb, IL_080a, IL_083b, IL_089a, IL_08ca, IL_08d9, IL_0906, IL_093e, IL_094d, IL_09d8
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		int num = 25;
		Guid guid = default(Guid);
		string text3 = default(string);
		MemoryStream memoryStream = default(MemoryStream);
		string text2 = default(string);
		string text = default(string);
		string encryptFileName = default(string);
		IFilePreviewCreator previewCreator = default(IFilePreviewCreator);
		TaskAwaiter taskAwaiter = default(TaskAwaiter);
		FilePreviewEventHandler filePreviewEventHandler = default(FilePreviewEventHandler);
		IDisposable disposable = default(IDisposable);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		FileStream fileStream = default(FileStream);
		int folderOffset = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 11:
					return;
				case 24:
					if (!Qbm57fGPJwKHI5E1FkDp(file.Uid, Guid.Empty))
					{
						num2 = 19;
						continue;
					}
					guid = fMC50iGPM2Q9HrF2XCwB(file);
					num2 = 26;
					continue;
				case 15:
					return;
				case 25:
					if (djcAnVGPrHZDkPviXBUy(PreviewDir))
					{
						return;
					}
					num2 = 24;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 21;
					}
					continue;
				case 21:
					return;
				case 3:
					if (!djcAnVGPrHZDkPviXBUy(text3))
					{
						num2 = 20;
						continue;
					}
					goto default;
				case 12:
					memoryStream = new MemoryStream();
					num2 = 8;
					continue;
				case 22:
					text2 = (string)bBEBZuGPjFvb5VJKFToy(FolderPreviewService, iJungfGP5ZHubUWWyCZ8(text));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 4;
					}
					continue;
				case 17:
					if (!file.Encrypt)
					{
						num2 = 28;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 30;
				case 5:
					if (!FilePreviewServiceProvider.GeneratePreview(text, fileEncryptPassword, password))
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 12;
				case 6:
					if (djcAnVGPrHZDkPviXBUy(encryptFileName))
					{
						return;
					}
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 14;
					}
					continue;
				case 30:
					encryptFileName = GetEncryptFileName(previewCreator, file);
					num2 = 6;
					continue;
				case 1:
					try
					{
						TL1irMG1ueSnQ873k5Le(this, file, 0L);
						int num15 = 2;
						while (true)
						{
							switch (num15)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								taskAwaiter.GetResult();
								num15 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
								{
									num15 = 0;
								}
								break;
							case 2:
								taskAwaiter = Phy6OaG1V0BASVOZM5OL(MI6UmwG1IfZRPe7T9Vdp(filePreviewEventHandler));
								num15 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
								{
									num15 = 1;
								}
								break;
							}
						}
					}
					finally
					{
						int num16;
						if (disposable == null)
						{
							num16 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
							{
								num16 = 1;
							}
							goto IL_02ba;
						}
						goto IL_02d0;
						IL_02d0:
						rO1VWFG1Gjl52MSQSK3B(disposable);
						num16 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num16 = 2;
						}
						goto IL_02ba;
						IL_02ba:
						switch (num16)
						{
						case 1:
							goto end_IL_0295;
						case 2:
							goto end_IL_0295;
						}
						goto IL_02d0;
						end_IL_0295:;
					}
				case 2:
					zo99LPGPsdXhlZrZWPXn(text2);
					num2 = 23;
					continue;
				case 28:
					if (vgsgdqGPcbrdRSDpuISF(FilePreviewServiceProvider, text, null))
					{
						text3 = (string)E4ai5wG1F5uOoPssIWpI(previewCreator, file);
						num2 = 3;
						continue;
					}
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 30;
					}
					continue;
				case 4:
					previewCreator = GetPreviewCreator(file);
					num2 = 27;
					continue;
				case 8:
					try
					{
						ZipOutputStream val = new ZipOutputStream((Stream)memoryStream);
						((DeflaterOutputStream)val).set_IsStreamOwner(false);
						ZipOutputStream val2 = val;
						int num3 = 6;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 5:
								enumerator = Directory.EnumerateDirectories(text2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088317048), SearchOption.AllDirectories).GetEnumerator();
								num4 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
								{
									num4 = 3;
								}
								continue;
							case 1:
								fileStream = (FileStream)f9fRsMG1C5nkgMkx7f72(GetEncryptFileName(GetPreviewCreator(file), file));
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
								{
									num4 = 0;
								}
								continue;
							case 4:
								try
								{
									while (true)
									{
										int num10;
										if (!EVWRIeG1Qt5rsMjtGuqF(enumerator))
										{
											num10 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
											{
												num10 = 0;
											}
											goto IL_047f;
										}
										goto IL_04bb;
										IL_04bb:
										BOA0GNG1fIMhhxMwdSjj(enumerator.Current, true);
										num10 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
										{
											num10 = 2;
										}
										goto IL_047f;
										IL_047f:
										switch (num10)
										{
										case 2:
											break;
										default:
											goto IL_04bb;
										case 1:
											goto end_IL_0495;
										}
										continue;
										end_IL_0495:
										break;
									}
								}
								finally
								{
									int num11;
									if (enumerator == null)
									{
										num11 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
										{
											num11 = 0;
										}
										goto IL_050c;
									}
									goto IL_0522;
									IL_0522:
									rO1VWFG1Gjl52MSQSK3B(enumerator);
									num11 = 2;
									goto IL_050c;
									IL_050c:
									switch (num11)
									{
									default:
										goto end_IL_04e7;
									case 1:
										break;
									case 0:
										goto end_IL_04e7;
									case 2:
										goto end_IL_04e7;
									}
									goto IL_0522;
									end_IL_04e7:;
								}
								goto case 1;
							case 3:
								enumerator = Directory.EnumerateFiles(text2, (string)BKhpi1G1oUidIk0DJDr6(0x4DC2B14D ^ 0x4DC2E31D), SearchOption.AllDirectories).GetEnumerator();
								num4 = 2;
								continue;
							case 2:
								try
								{
									while (true)
									{
										int num8;
										if (!enumerator.MoveNext())
										{
											num8 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
											{
												num8 = 1;
											}
											goto IL_05ba;
										}
										goto IL_05f6;
										IL_05f6:
										eSenYCG1ELhJZ0ATJ0xs(enumerator.Current);
										num8 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
										{
											num8 = 0;
										}
										goto IL_05ba;
										IL_05ba:
										switch (num8)
										{
										case 2:
											break;
										default:
											goto IL_05f6;
										case 1:
											goto end_IL_05d0;
										}
										continue;
										end_IL_05d0:
										break;
									}
								}
								finally
								{
									int num9;
									if (enumerator == null)
									{
										num9 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
										{
											num9 = 1;
										}
										goto IL_0646;
									}
									goto IL_067b;
									IL_067b:
									rO1VWFG1Gjl52MSQSK3B(enumerator);
									num9 = 2;
									goto IL_0646;
									IL_0646:
									switch (num9)
									{
									case 1:
										goto end_IL_0621;
									case 2:
										goto end_IL_0621;
									}
									goto IL_067b;
									end_IL_0621:;
								}
								goto case 5;
							case 6:
								try
								{
									gexp38G1WsksbV4vpGRl(val2, (f6homMG1B9EdwKJ8qthw(file) && password != null) ? UnionPasswords(fileEncryptPassword, password) : (password ?? fileEncryptPassword));
									int num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
									{
										num5 = 0;
									}
									while (true)
									{
										switch (num5)
										{
										default:
										{
											Ar0eXoG1hBMyXRENNSwm(text2, val2, folderOffset);
											int num6 = 2;
											num5 = num6;
											continue;
										}
										case 1:
											folderOffset = text2.Length + ((!oZoRjOG1bJVlFGTO5q0X(text2, BKhpi1G1oUidIk0DJDr6(0x6A81B9B4 ^ 0x6A81A6C2))) ? 1 : 0);
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
											{
												num5 = 0;
											}
											continue;
										case 2:
											break;
										}
										break;
									}
								}
								finally
								{
									int num7;
									if (val2 == null)
									{
										num7 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
										{
											num7 = 1;
										}
										goto IL_07a4;
									}
									goto IL_07d9;
									IL_07d9:
									rO1VWFG1Gjl52MSQSK3B(val2);
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
									{
										num7 = 2;
									}
									goto IL_07a4;
									IL_07a4:
									switch (num7)
									{
									case 1:
										goto end_IL_077f;
									case 2:
										goto end_IL_077f;
									}
									goto IL_07d9;
									end_IL_077f:;
								}
								goto case 3;
							}
							try
							{
								zKMMAKG1vjabkxjPAFLV(memoryStream, 0L, SeekOrigin.Begin);
								int num12 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
								{
									num12 = 0;
								}
								while (true)
								{
									switch (num12)
									{
									case 1:
										return;
									}
									SgWoHeG180vC2bXyNnHu(memoryStream, fileStream);
									num12 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
									{
										num12 = 1;
									}
								}
							}
							finally
							{
								int num13;
								if (fileStream == null)
								{
									num13 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
									{
										num13 = 1;
									}
									goto IL_089e;
								}
								goto IL_08b4;
								IL_08b4:
								rO1VWFG1Gjl52MSQSK3B(fileStream);
								num13 = 2;
								goto IL_089e;
								IL_089e:
								switch (num13)
								{
								case 1:
									goto end_IL_0879;
								case 2:
									goto end_IL_0879;
								}
								goto IL_08b4;
								end_IL_0879:;
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							int num14 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
							{
								num14 = 0;
							}
							while (true)
							{
								switch (num14)
								{
								default:
									rO1VWFG1Gjl52MSQSK3B(memoryStream);
									num14 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
									{
										num14 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				case 29:
					disposable = (IDisposable)OXOXKnG1Zt80usxi0Q1p(eventHandlerSubscribeService.Value, filePreviewEventHandler);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					break;
				case 27:
					if (previewCreator != null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num2 = 16;
						}
						continue;
					}
					return;
				case 19:
					obj = GnYjZgGPdHk6a8FQ4BJ2(file);
					goto IL_0aa0;
				case 14:
					if (ShiZKlGPz5VXeomuk8e4(encryptFileName))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
					continue;
				case 20:
					if (ShiZKlGPz5VXeomuk8e4(text3))
					{
						num2 = 10;
						continue;
					}
					goto default;
				case 18:
					return;
				case 16:
					if (!vROGZ8GPUKf24TbpsiEg(text2))
					{
						num2 = 2;
						continue;
					}
					goto case 17;
				case 7:
				case 13:
					throw new Exception(SR.T((string)BKhpi1G1oUidIk0DJDr6(0x5A4C7B29 ^ 0x5A4F91DF), text));
				case 10:
					return;
				default:
					if (!f6homMG1B9EdwKJ8qthw(file))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 5;
				case 26:
					{
						obj = guid.ToString();
						goto IL_0aa0;
					}
					IL_0aa0:
					text = (string)obj;
					num2 = 22;
					continue;
				}
				break;
			}
			if (password != null)
			{
				num = 5;
				continue;
			}
			filePreviewEventHandler = new FilePreviewEventHandler(text);
			num = 29;
		}
	}

	public bool TryExtractFile(BinaryFile file, string path, Stream outputStream, string fileEncryptPassword, string password)
	{
		//Discarded unreachable code: IL_00a8, IL_0102, IL_018a, IL_01b5, IL_0250, IL_0288
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		int num = 11;
		int num2 = num;
		IFilePreviewCreator previewCreator = default(IFilePreviewCreator);
		string text = default(string);
		ZipFile val = default(ZipFile);
		bool result = default(bool);
		ZipEntry entry = default(ZipEntry);
		while (true)
		{
			switch (num2)
			{
			case 11:
				previewCreator = GetPreviewCreator(file);
				num2 = 10;
				break;
			case 4:
			case 9:
				if (!djcAnVGPrHZDkPviXBUy(text))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 7;
			case 7:
				return false;
			case 1:
				val = new ZipFile((FileStream)faqxuaG1SCvXaIrGAHaA(text, FileMode.Open, FileAccess.Read, FileShare.Read), false);
				num2 = 8;
				break;
			default:
				if (ShiZKlGPz5VXeomuk8e4(text))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 7;
			case 3:
				if (f6homMG1B9EdwKJ8qthw(file))
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 5;
			case 6:
				return false;
			case 10:
				if (previewCreator == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 2;
					}
					break;
				}
				text = Path.ChangeExtension((string)E4ai5wG1F5uOoPssIWpI(previewCreator, file), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B37C869));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 1;
				}
				break;
			case 8:
				try
				{
					jMA5m7G1iVkycrKLduAg(val, (file.Encrypt && password != null) ? UnionPasswords(fileEncryptPassword, password) : (password ?? fileEncryptPassword));
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return result;
						case 5:
							SgWoHeG180vC2bXyNnHu(x8VLV6G1RhLmSKn5nTXP(val, entry), outputStream);
							num3 = 3;
							continue;
						case 3:
							result = true;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
							{
								num3 = 1;
							}
							continue;
						default:
							entry = val.GetEntry(path);
							num3 = 4;
							continue;
						case 4:
							if (entry != null)
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
								{
									num3 = 5;
								}
								continue;
							}
							break;
						case 2:
							break;
						}
						break;
					}
				}
				finally
				{
					if (val != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								rO1VWFG1Gjl52MSQSK3B(val);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 6;
			case 5:
				if (password != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 7;
			case 2:
				return false;
			}
		}
	}

	public string GetPreviewPath(BinaryFile file)
	{
		//Discarded unreachable code: IL_0076, IL_0085
		int num = 2;
		string text = default(string);
		IFilePreviewCreator previewCreator = default(IFilePreviewCreator);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (ShiZKlGPz5VXeomuk8e4(text))
					{
						return text;
					}
					goto end_IL_0012;
				case 2:
					previewCreator = GetPreviewCreator(file);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					return null;
				case 4:
					return null;
				case 5:
					text = (string)fuI82TG1qYNhSqw3DcJw(previewCreator, file);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					if (previewCreator != null)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public string GetTextPreviewPath(BinaryFile file)
	{
		int num = 2;
		string textFileName = default(string);
		IFilePreviewCreator previewCreator = default(IFilePreviewCreator);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return null;
				default:
					if (ShiZKlGPz5VXeomuk8e4(textFileName))
					{
						return textFileName;
					}
					num2 = 4;
					break;
				case 1:
					if (previewCreator != null)
					{
						textFileName = previewCreator.GetTextFileName(file);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto end_IL_0012;
				case 3:
					return null;
				case 2:
					previewCreator = GetPreviewCreator(file);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public long GetTextPreviewSize(BinaryFile file)
	{
		int num = 4;
		int num2 = num;
		IMultiFilePreviewCreator multiFilePreviewCreator = default(IMultiFilePreviewCreator);
		string textPreviewPath = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return EBypVdG1KiKdtFBwXqSc(multiFilePreviewCreator, file);
			case 3:
				if (multiFilePreviewCreator == null)
				{
					textPreviewPath = GetTextPreviewPath(file);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 1;
					}
				}
				break;
			case 2:
				if (File.Exists(textPreviewPath))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return 0L;
			case 4:
				multiFilePreviewCreator = GetPreviewCreator(file) as IMultiFilePreviewCreator;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 3;
				}
				break;
			default:
				return uFSDujG1XOKBZ0BAOMKR(new FileInfo(textPreviewPath));
			}
		}
	}

	public bool HasPreview(BinaryFile file)
	{
		return HasPreview(file, 5L);
	}

	public bool HasPreview(BinaryFile file, long priority)
	{
		int num = 2;
		IFilePreviewCreator previewCreator = default(IFilePreviewCreator);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return false;
				case 1:
					if (previewCreator != null)
					{
						if (!WmRikEGPm5PP9XdU4PjX(previewCreator, file))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
							{
								num2 = 0;
							}
							break;
						}
						return previewCreator.HasPreview(file, priority);
					}
					goto end_IL_0012;
				default:
					return false;
				case 2:
					previewCreator = GetPreviewCreator(file);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 1;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public string GetPreviewRelativePath(BinaryFile file)
	{
		//Discarded unreachable code: IL_0111, IL_0120, IL_0135, IL_0156
		int num = 10;
		int num2 = num;
		Guid uid = default(Guid);
		string previewPath = default(string);
		string previewDirectory = default(string);
		string input = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 10:
				if (!djcAnVGPrHZDkPviXBUy(PreviewDir))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 9;
					}
					continue;
				}
				goto case 4;
			case 4:
				return null;
			case 9:
				if (Qbm57fGPJwKHI5E1FkDp(fMC50iGPM2Q9HrF2XCwB(file), Guid.Empty))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 6;
			default:
				uid = file.Uid;
				num2 = 2;
				continue;
			case 1:
				previewPath = GetPreviewPath(file);
				num2 = 3;
				continue;
			case 3:
				if (!djcAnVGPrHZDkPviXBUy(previewPath))
				{
					num2 = 5;
					continue;
				}
				goto case 8;
			case 7:
				previewDirectory = FolderPreviewService.GetPreviewDirectory(Guid.Parse(input));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 1;
				}
				continue;
			case 6:
				obj = GnYjZgGPdHk6a8FQ4BJ2(file);
				break;
			case 8:
				return null;
			case 5:
				return ((string)k5gYTTG1TgNwWep4F2Rp(previewPath, previewDirectory, "")).Substring(1);
			case 2:
				obj = uid.ToString();
				break;
			}
			input = (string)obj;
			num2 = 7;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
			{
				num2 = 4;
			}
		}
	}

	public bool IsSupportPreview(BinaryFile file)
	{
		return GetPreviewCreator(file) != null;
	}

	public bool CheckPassword(BinaryFile file, string password)
	{
		//Discarded unreachable code: IL_0066
		int num = 3;
		int num2 = num;
		Guid guid = default(Guid);
		string text = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 3:
				if (!(fMC50iGPM2Q9HrF2XCwB(file) != Guid.Empty))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 2;
					}
					continue;
				}
				guid = fMC50iGPM2Q9HrF2XCwB(file);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				obj = GnYjZgGPdHk6a8FQ4BJ2(file);
				break;
			case 1:
				return vgsgdqGPcbrdRSDpuISF(FilePreviewServiceProvider, text, password);
			default:
				obj = guid.ToString();
				break;
			}
			text = (string)obj;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
			{
				num2 = 1;
			}
		}
	}

	public bool CheckPassword(BinaryFile file, string fileEncryptPassword, string password)
	{
		//Discarded unreachable code: IL_0069
		int num = 3;
		int num2 = num;
		string text = default(string);
		Guid guid = default(Guid);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				return MAQS47G1kWIr0urpc10F(FilePreviewServiceProvider, text, fileEncryptPassword, password);
			case 2:
				obj = GnYjZgGPdHk6a8FQ4BJ2(file);
				break;
			case 3:
				if (fMC50iGPM2Q9HrF2XCwB(file) != Guid.Empty)
				{
					guid = fMC50iGPM2Q9HrF2XCwB(file);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 1;
					}
				}
				continue;
			case 1:
				obj = guid.ToString();
				break;
			}
			text = (string)obj;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
			{
				num2 = 0;
			}
		}
	}

	private string GetEncryptFileName(IFilePreviewCreator creator, BinaryFile file)
	{
		return (string)vxu9ElG1n0JmBuRtpS5H(fuI82TG1qYNhSqw3DcJw(creator, file), BKhpi1G1oUidIk0DJDr6(-867826612 ^ -867735764));
	}

	internal static bool qVMR7TGP7jUdwNnPZ9m1()
	{
		return OmsEAWGPAmnaGfupbY8D == null;
	}

	internal static FilePreviewService FYePciGPxXRC24HtGDLF()
	{
		return OmsEAWGPAmnaGfupbY8D;
	}

	internal static object QCkbsrGP0w0BgFiiPS5A(object P_0)
	{
		return ((IFolderPreviewService)P_0).PreviewsPath;
	}

	internal static bool WmRikEGPm5PP9XdU4PjX(object P_0, object P_1)
	{
		return ((IFilePreviewCreator)P_0).IsAvaliable((BinaryFile)P_1);
	}

	internal static object jtWg5wGPyCPx0SKZKQQ4(object P_0, object P_1)
	{
		return ((IFilePreviewCreator)P_0).GetPreviewText((BinaryFile)P_1);
	}

	internal static Guid fMC50iGPM2Q9HrF2XCwB(object P_0)
	{
		return ((BinaryFile)P_0).Uid;
	}

	internal static bool Qbm57fGPJwKHI5E1FkDp(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static void mibgxiGP9YmGkNoNfFDS(object P_0, object P_1, long priority)
	{
		((IFilePreviewServiceProvider)P_0).AddFileToQueue((string)P_1, priority);
	}

	internal static object GnYjZgGPdHk6a8FQ4BJ2(object P_0)
	{
		return ((BinaryFile)P_0).Id;
	}

	internal static PreviewWorkStatus my57aMGPlNTfP6Xcjdh0(object P_0, object P_1)
	{
		return ((IFilePreviewServiceProvider)P_0).GetFilePreviewWorkStatus((string)P_1);
	}

	internal static bool djcAnVGPrHZDkPviXBUy(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool DB0jVtGPg6wZpXBYYSPb(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static Guid iJungfGP5ZHubUWWyCZ8(object P_0)
	{
		return Guid.Parse((string)P_0);
	}

	internal static object bBEBZuGPjFvb5VJKFToy(object P_0, Guid id)
	{
		return ((IFolderPreviewService)P_0).GetPreviewDirectory(id);
	}

	internal static void Lugm43GPYJOmE7mqQBuV(object P_0)
	{
		ExecuteHelper.InvokeSafe((Action)P_0);
	}

	internal static object cmCQjvGPLfD5ZfYwXqe9(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool vROGZ8GPUKf24TbpsiEg(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object zo99LPGPsdXhlZrZWPXn(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static bool vgsgdqGPcbrdRSDpuISF(object P_0, object P_1, object P_2)
	{
		return ((IFilePreviewServiceProvider)P_0).CheckPassword((string)P_1, (string)P_2);
	}

	internal static bool ShiZKlGPz5VXeomuk8e4(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object E4ai5wG1F5uOoPssIWpI(object P_0, object P_1)
	{
		return ((IFilePreviewCreator)P_0).GetTextFileName((BinaryFile)P_1);
	}

	internal static bool f6homMG1B9EdwKJ8qthw(object P_0)
	{
		return ((BinaryFile)P_0).Encrypt;
	}

	internal static void gexp38G1WsksbV4vpGRl(object P_0, object P_1)
	{
		((DeflaterOutputStream)P_0).set_Password((string)P_1);
	}

	internal static object BKhpi1G1oUidIk0DJDr6(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool oZoRjOG1bJVlFGTO5q0X(object P_0, object P_1)
	{
		return ((string)P_0).EndsWith((string)P_1);
	}

	internal static void Ar0eXoG1hBMyXRENNSwm(object P_0, object P_1, int folderOffset)
	{
		FileUtils.CompressFolder((string)P_0, (ZipOutputStream)P_1, folderOffset);
	}

	internal static void rO1VWFG1Gjl52MSQSK3B(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void eSenYCG1ELhJZ0ATJ0xs(object P_0)
	{
		File.Delete((string)P_0);
	}

	internal static void BOA0GNG1fIMhhxMwdSjj(object P_0, bool P_1)
	{
		Directory.Delete((string)P_0, P_1);
	}

	internal static bool EVWRIeG1Qt5rsMjtGuqF(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object f9fRsMG1C5nkgMkx7f72(object P_0)
	{
		return File.Create((string)P_0);
	}

	internal static long zKMMAKG1vjabkxjPAFLV(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static void SgWoHeG180vC2bXyNnHu(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static object OXOXKnG1Zt80usxi0Q1p(object P_0, object P_1)
	{
		return ((IEventHandlerSubscribeService)P_0).Subscribe((IEventHandler)P_1);
	}

	internal static void TL1irMG1ueSnQ873k5Le(object P_0, object P_1, long priority)
	{
		((FilePreviewService)P_0).AddPreviewWork((BinaryFile)P_1, priority);
	}

	internal static object MI6UmwG1IfZRPe7T9Vdp(object P_0)
	{
		return ((FilePreviewEventHandler)P_0).Wait;
	}

	internal static TaskAwaiter Phy6OaG1V0BASVOZM5OL(object P_0)
	{
		return ((Task)P_0).GetAwaiter();
	}

	internal static object faqxuaG1SCvXaIrGAHaA(object P_0, FileMode P_1, FileAccess P_2, FileShare P_3)
	{
		return File.Open((string)P_0, P_1, P_2, P_3);
	}

	internal static void jMA5m7G1iVkycrKLduAg(object P_0, object P_1)
	{
		((ZipFile)P_0).set_Password((string)P_1);
	}

	internal static object x8VLV6G1RhLmSKn5nTXP(object P_0, object P_1)
	{
		return ((ZipFile)P_0).GetInputStream((ZipEntry)P_1);
	}

	internal static object fuI82TG1qYNhSqw3DcJw(object P_0, object P_1)
	{
		return ((IFilePreviewCreator)P_0).GetMainFileName((BinaryFile)P_1);
	}

	internal static long EBypVdG1KiKdtFBwXqSc(object P_0, object P_1)
	{
		return ((IMultiFilePreviewCreator)P_0).GetTextPreviewFilesSize((BinaryFile)P_1);
	}

	internal static long uFSDujG1XOKBZ0BAOMKR(object P_0)
	{
		return ((FileInfo)P_0).Length;
	}

	internal static object k5gYTTG1TgNwWep4F2Rp(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static bool MAQS47G1kWIr0urpc10F(object P_0, object P_1, object P_2, object P_3)
	{
		return ((IFilePreviewServiceProvider)P_0).CheckPassword((string)P_1, (string)P_2, (string)P_3);
	}

	internal static object vxu9ElG1n0JmBuRtpS5H(object P_0, object P_1)
	{
		return Path.ChangeExtension((string)P_0, (string)P_1);
	}
}
