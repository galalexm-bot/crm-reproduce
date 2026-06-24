using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.BackgroundOperations;
using EleWise.ELMA.Model.BackgroundOperations.FetchBinaryFile;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Components.BackgroundOperations;

internal class FetchBinaryFileBackgroundOperationExecutor : BackgroundOperationExecutorBase
{
	[Serializable]
	internal class BackgroundBinaryFile : BinaryFile
	{
		private byte[] content;

		private bool isLegacyMode;

		private BinaryFile originalBinaryFile;

		private static BackgroundBinaryFile wRwiPb8dJ9R0I0tobfcy;

		[Obsolete("Свойство устарело. Для доступа к контенту используйте GetContent() и PutContent().")]
		public override string ContentFilePath
		{
			get
			{
				//Discarded unreachable code: IL_008d, IL_009c
				int num = 2;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return (string)ABP4lo8lGFI8oMmMQgC2(base.ContentLocation);
					case 3:
						TransitToLegacyMode((string)OQmCxg8lhdMFlrdC8m3K(DsIUOU8ds00TIHcJB7aT(this)));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						if (isLegacyMode)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 3;
					}
				}
			}
			set
			{
				int num = 2;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 2:
						TransitToLegacyMode(value);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						base.ContentLocation = new Uri(value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		protected virtual bool IsPrecached => content != null;

		public BackgroundBinaryFile(BinaryFile binaryFile)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			KMSWTU8dl9Rc8R5s9DXn();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 7:
					Nfb5lI8dUbBItbIHiK9k(this, uvJk0D8dLam0JK1L07AL(binaryFile));
					num = 8;
					break;
				case 3:
					base.Id = (string)jnRCcN8dcBVQTeaOJ5yc(binaryFile);
					num = 6;
					break;
				default:
					originalBinaryFile = binaryFile;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num = 9;
					}
					break;
				case 10:
					NKYT1S8djUq1AuS9ty28(this, oD0XwM8d5WLO1NolqhB4(binaryFile));
					num = 2;
					break;
				case 9:
					YIdnh08dgOqTFiX8rvkk(this, MHgBit8dr8TbNy6dhkJq(binaryFile));
					num = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num = 10;
					}
					break;
				case 2:
					a0CPMx8dYWF87AXJpb0w(this, binaryFile.Encrypt);
					num = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num = 3;
					}
					break;
				case 6:
					opU6AE8lFTW2WwPBu23j(this, MA8eMW8dz6ycl9JYIjae(binaryFile));
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num = 1;
					}
					break;
				case 4:
					return;
				case 1:
					zJtf6l8lWemVmBwUfpcT(this, qv0EqN8lB7yStCjxX81k(binaryFile));
					num = 5;
					break;
				case 5:
					FOp01m8lbMNDSwKDt8cj(this, f4uWN28loOEhwFtRYyrF(binaryFile));
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num = 4;
					}
					break;
				case 8:
					Name = (string)DsIUOU8ds00TIHcJB7aT(binaryFile);
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num = 3;
					}
					break;
				}
			}
		}

		public override Stream GetContent(GetContentOptions options = null)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return originalBinaryFile.GetContent(options);
				case 1:
					if (JqEUtn8lEEFiiKRbmmYd(this))
					{
						return MemoryHelper.GetMemoryStream(content, writable: false);
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public override uint GetCrc()
		{
			return VIx3f78lf8s6LlbUpdSw(originalBinaryFile);
		}

		public override long GetSize()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!JqEUtn8lEEFiiKRbmmYd(this))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return content.LongLength;
				default:
					return LDmhuw8lQxRsTdgPjS9A(originalBinaryFile);
				}
			}
		}

		protected virtual void DropCache()
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
					content = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		internal Task<BackgroundBinaryFile> PrecacheAsync(CancellationToken token)
		{
			Func<Stream> function = delegate
			{
				//Discarded unreachable code: IL_0074, IL_00ac, IL_00e4, IL_00f3
				int num3 = 2;
				int num4 = num3;
				CallContextSessionOwner callContextSessionOwner = default(CallContextSessionOwner);
				Stream stream2 = default(Stream);
				while (true)
				{
					switch (num4)
					{
					default:
						return stream2;
					case 2:
						callContextSessionOwner = CallContextSessionOwner.Create();
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num4 = 1;
						}
						break;
					case 1:
						try
						{
							stream2 = GetContent(GetContentOptions.NonSeekableForAsync);
							int num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
							{
								num5 = 0;
							}
							return num5 switch
							{
								0 => stream2, 
								_ => stream2, 
							};
						}
						finally
						{
							if (callContextSessionOwner != null)
							{
								int num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
								{
									num6 = 1;
								}
								while (true)
								{
									switch (num6)
									{
									case 1:
										xRJ7Es8lZOGPcRCej9Ov(callContextSessionOwner);
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
										{
											num6 = 0;
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
			};
			return Task.Factory.StartNew(function, token).Then((Stream stream) => stream.ReadAllBytesAsync(), token).Then(delegate(byte[] buf)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return this;
					case 1:
						content = buf;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}, token);
		}

		internal void TransitToLegacyMode(string filename)
		{
			//Discarded unreachable code: IL_009a, IL_00a9, IL_00c9
			int num = 7;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					object source;
					FileStream destination;
					switch (num2)
					{
					case 1:
						return;
					case 6:
						if (!JqEUtn8lEEFiiKRbmmYd(this))
						{
							num = 2;
							break;
						}
						source = kj3ZJ28lC0YCxTt4VYdE(content, false);
						goto IL_011c;
					case 4:
						base.ContentLocation = new Uri(filename);
						num = 5;
						break;
					case 7:
						if (isLegacyMode)
						{
							return;
						}
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
						source = originalBinaryFile.GetContent(GetContentOptions.NonSeekable);
						goto IL_011c;
					default:
						isLegacyMode = true;
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num2 = 3;
						}
						continue;
					case 5:
						return;
					case 3:
						{
							c2jbdN8l8f9MI4mochQf(this);
							num2 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
							{
								num2 = 4;
							}
							continue;
						}
						IL_011c:
						destination = (FileStream)Q2Z97y8lvqm94no6Jml1(filename);
						((Stream)source).CopyAllBytesToStream(destination);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
			}
		}

		internal static void KMSWTU8dl9Rc8R5s9DXn()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object MHgBit8dr8TbNy6dhkJq(object P_0)
		{
			return ((BinaryFile)P_0).ContentType;
		}

		internal static void YIdnh08dgOqTFiX8rvkk(object P_0, object P_1)
		{
			((BinaryFile)P_0).ContentType = (string)P_1;
		}

		internal static DateTime oD0XwM8d5WLO1NolqhB4(object P_0)
		{
			return ((BinaryFile)P_0).CreateDate;
		}

		internal static void NKYT1S8djUq1AuS9ty28(object P_0, DateTime value)
		{
			((BinaryFile)P_0).CreateDate = value;
		}

		internal static void a0CPMx8dYWF87AXJpb0w(object P_0, bool value)
		{
			((BinaryFile)P_0).Encrypt = value;
		}

		internal static object uvJk0D8dLam0JK1L07AL(object P_0)
		{
			return ((BinaryFile)P_0).Salt;
		}

		internal static void Nfb5lI8dUbBItbIHiK9k(object P_0, object P_1)
		{
			((BinaryFile)P_0).Salt = (string)P_1;
		}

		internal static object DsIUOU8ds00TIHcJB7aT(object P_0)
		{
			return ((BinaryFile)P_0).Name;
		}

		internal static object jnRCcN8dcBVQTeaOJ5yc(object P_0)
		{
			return ((BinaryFile)P_0).Id;
		}

		internal static object MA8eMW8dz6ycl9JYIjae(object P_0)
		{
			return ((BinaryFile)P_0).SecondId;
		}

		internal static void opU6AE8lFTW2WwPBu23j(object P_0, object P_1)
		{
			((BinaryFile)P_0).SecondId = (string)P_1;
		}

		internal static Guid qv0EqN8lB7yStCjxX81k(object P_0)
		{
			return ((BinaryFile)P_0).Uid;
		}

		internal static void zJtf6l8lWemVmBwUfpcT(object P_0, Guid value)
		{
			((BinaryFile)P_0).Uid = value;
		}

		internal static object f4uWN28loOEhwFtRYyrF(object P_0)
		{
			return ((BinaryFile)P_0).ContentLocation;
		}

		internal static void FOp01m8lbMNDSwKDt8cj(object P_0, object P_1)
		{
			((BinaryFile)P_0).ContentLocation = (Uri)P_1;
		}

		internal static bool Pwc9tc8d9X6IVKTwcKy1()
		{
			return wRwiPb8dJ9R0I0tobfcy == null;
		}

		internal static BackgroundBinaryFile t3og6O8ddlHxEESlNtin()
		{
			return wRwiPb8dJ9R0I0tobfcy;
		}

		internal static object OQmCxg8lhdMFlrdC8m3K(object P_0)
		{
			return BinaryFile.CreateContentFilePath((string)P_0);
		}

		internal static object ABP4lo8lGFI8oMmMQgC2(object P_0)
		{
			return ((Uri)P_0).LocalPath;
		}

		internal static bool JqEUtn8lEEFiiKRbmmYd(object P_0)
		{
			return ((BackgroundBinaryFile)P_0).IsPrecached;
		}

		internal static uint VIx3f78lf8s6LlbUpdSw(object P_0)
		{
			return ((BinaryFile)P_0).GetCrc();
		}

		internal static long LDmhuw8lQxRsTdgPjS9A(object P_0)
		{
			return ((BinaryFile)P_0).GetSize();
		}

		internal static object kj3ZJ28lC0YCxTt4VYdE(object P_0, bool writable)
		{
			return MemoryHelper.GetMemoryStream((byte[])P_0, writable);
		}

		internal static object Q2Z97y8lvqm94no6Jml1(object P_0)
		{
			return File.OpenWrite((string)P_0);
		}

		internal static void c2jbdN8l8f9MI4mochQf(object P_0)
		{
			((BackgroundBinaryFile)P_0).DropCache();
		}

		internal static void xRJ7Es8lZOGPcRCej9Ov(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}
	}

	private readonly IFileManager fileManager;

	private readonly IBinaryFileAsyncLoader binaryFileAsyncLoader;

	internal static FetchBinaryFileBackgroundOperationExecutor AFEWOWfGcoRISoI7yq2G;

	protected long MaxFileSizeToPrecache => SR.GetSetting((string)ukkx5nfEW2w36000vj9x(-2107978722 ^ -2107643766), 10485760L);

	public FetchBinaryFileBackgroundOperationExecutor(IFileManager fileManager, IBinaryFileAsyncLoader binaryFileAsyncLoader)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		jgVNR7fEBWQw2OstvEUD();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				this.fileManager = fileManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			default:
				this.binaryFileAsyncLoader = binaryFileAsyncLoader;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public override bool CanExecute(IBackgroundOperation executionInfo)
	{
		return executionInfo is FetchBinaryFileBackgroundOperation;
	}

	public override string GetDescription(IBackgroundOperation executionInfo)
	{
		//Discarded unreachable code: IL_0090, IL_009f
		int num = 2;
		int num2 = num;
		FetchBinaryFileBackgroundOperation fetchBinaryFileBackgroundOperation = default(FetchBinaryFileBackgroundOperation);
		while (true)
		{
			switch (num2)
			{
			case 2:
				fetchBinaryFileBackgroundOperation = executionInfo as FetchBinaryFileBackgroundOperation;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (fetchBinaryFileBackgroundOperation != null)
				{
					num2 = 3;
					break;
				}
				goto default;
			default:
				return string.Empty;
			case 3:
				return SR.T((string)ukkx5nfEW2w36000vj9x(-1858887263 ^ -1858697851), trCsPufEoH1u6mdjGZqt(fetchBinaryFileBackgroundOperation));
			}
		}
	}

	protected override Task<object> RunTaskImpl(IBackgroundOperation executionInfo, CancellationToken token)
	{
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals0.token = token;
		FetchBinaryFileBackgroundOperation fetchBinaryFileBackgroundOperation = CastTo<FetchBinaryFileBackgroundOperation>(executionInfo);
		long num = fileManager.FileSize(fetchBinaryFileBackgroundOperation.Key);
		Task<BackgroundBinaryFile> task = binaryFileAsyncLoader.LoadFileAsync(fetchBinaryFileBackgroundOperation.Key, CS_0024_003C_003E8__locals0.token).Then((BinaryFile f) => new BackgroundBinaryFile(f), CS_0024_003C_003E8__locals0.token);
		return ((num > MaxFileSizeToPrecache) ? task : task.Then((BackgroundBinaryFile f) => f.PrecacheAsync(CS_0024_003C_003E8__locals0.token), CS_0024_003C_003E8__locals0.token)).Then((Func<BackgroundBinaryFile, object>)((BackgroundBinaryFile r) => r), CS_0024_003C_003E8__locals0.token);
	}

	internal static void jgVNR7fEBWQw2OstvEUD()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool UA1LBBfGz9Smvo9mUBO0()
	{
		return AFEWOWfGcoRISoI7yq2G == null;
	}

	internal static FetchBinaryFileBackgroundOperationExecutor W7jRFEfEFFKMkl9JDwwa()
	{
		return AFEWOWfGcoRISoI7yq2G;
	}

	internal static object ukkx5nfEW2w36000vj9x(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object trCsPufEoH1u6mdjGZqt(object P_0)
	{
		return ((FetchBinaryFileBackgroundOperation)P_0).Key;
	}
}
