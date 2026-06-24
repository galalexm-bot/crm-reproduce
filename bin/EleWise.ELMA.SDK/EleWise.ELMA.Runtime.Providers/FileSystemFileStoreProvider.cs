using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Configuration.Provider;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Threading;
using System.Threading.Tasks;
using Autofac;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Properties;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.Providers.Impl.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Providers.Impl;

[Component(EnableInterceptors = true)]
public class FileSystemFileStoreProvider : FileStoreProvider, INHManagerRegistrar, IBinaryFileStreams, IBinaryFileAsyncLoader, IBinaryFileHashService, IBinaryFileLegacyBehaviorProvider, IFileGatewayService
{
	[Serializable]
	public class LazyBinaryFile : BinaryFile
	{
		private bool _loaded;

		private bool _fileLoaded;

		private readonly string _privateFilesPath;

		private readonly bool _checkFile;

		private Uri _location;

		private uint contentCrc;

		private long? contentLength;

		private bool fileWasStubbed;

		private static LazyBinaryFile itvTthQNLYCBxs2clHIC;

		public bool Loaded => _loaded;

		public override string ContentType
		{
			get
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return base.ContentType;
					case 1:
						CheckLoaded();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num2 = 0;
						}
						break;
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
					case 1:
						base.ContentType = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						CheckLoaded();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num2 = 1;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public override DateTime CreateDate
		{
			get
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						CheckLoaded();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
						{
							num2 = 0;
						}
						break;
					default:
						return base.CreateDate;
					}
				}
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						CheckLoaded();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num2 = 0;
						}
						break;
					default:
						base.CreateDate = value;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 1;
						}
						break;
					case 2:
						return;
					}
				}
			}
		}

		public override string Name
		{
			get
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						CheckLoaded();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 0;
						}
						break;
					default:
						return base.Name;
					}
				}
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						CheckLoaded();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						return;
					default:
						base.Name = value;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			}
		}

		[Obsolete("Свойство устарело. Для доступа к контенту используйте GetContent() и PutContent().")]
		public override string ContentFilePath
		{
			get
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return (string)pWRhxwQ3IWeaubAL0G39(ContentLocation);
					case 1:
						CheckLoaded();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 0;
						}
						break;
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
						CheckLoaded();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 0;
						}
						break;
					case 1:
						a7FkZ6Q3QHBpGeepLYuk(this, new Uri(value));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public override Uri ContentLocation
		{
			get
			{
				int num = 2;
				int num2 = num;
				Uri uri = default(Uri);
				Uri uri2;
				while (true)
				{
					switch (num2)
					{
					case 1:
						uri = (_location = (Uri)oHQwRSQ3VgRsFXwyZUDo(Locator.GetServiceNotNull<FileSystemFileStoreProvider>(), base.Id));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
						uri2 = _location;
						if ((object)uri2 == null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
							{
								num2 = 1;
							}
							continue;
						}
						break;
					default:
						uri2 = uri;
						break;
					}
					break;
				}
				return uri2;
			}
			internal set
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
						_location = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public override Guid Uid
		{
			get
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						CheckLoaded();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 0;
						}
						break;
					default:
						return base.Uid;
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
						CheckLoaded();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						base.Uid = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public override string SecondId
		{
			get
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return base.SecondId;
					case 1:
						CheckLoaded();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
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
						base.SecondId = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public override bool Encrypt
		{
			get
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return base.Encrypt;
					case 1:
						CheckLoaded();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num2 = 0;
						}
						break;
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
					case 1:
						base.Encrypt = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					case 2:
						CheckLoaded();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			}
		}

		public override string Salt
		{
			get
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return base.Salt;
					case 1:
						CheckLoaded();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						base.Salt = value;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						return;
					case 1:
						CheckLoaded();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public LazyBinaryFile(string id, string privateFilesPath)
		{
			//Discarded unreachable code: IL_002d, IL_0032
			SingletonReader.JJCZtPuTvSt();
			this._002Ector(id, privateFilesPath, checkFile: true);
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public LazyBinaryFile(string id, string privateFilesPath, bool checkFile)
		{
			//Discarded unreachable code: IL_002a
			wJcL8uQNcXKOwNYd2lfc();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
			{
				num = 0;
			}
			while (true)
			{
				int num2;
				switch (num)
				{
				case 1:
					return;
				case 3:
					base.Id = id;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num = 0;
					}
					break;
				case 2:
					_checkFile = checkFile;
					num2 = 3;
					goto IL_002f;
				default:
					{
						_privateFilesPath = privateFilesPath;
						num2 = 2;
						goto IL_002f;
					}
					IL_002f:
					num = num2;
					break;
				}
			}
		}

		internal override void CheckLoaded(bool loadFile = false)
		{
			//Discarded unreachable code: IL_0115, IL_01e0, IL_01ef, IL_0264, IL_0273, IL_04d7, IL_053b, IL_054b, IL_055a, IL_05a1
			int num = 2;
			int num2 = num;
			SystemFileNHManager serviceNotNull = default(SystemFileNHManager);
			string text = default(string);
			uint crcValue = default(uint);
			while (true)
			{
				switch (num2)
				{
				case 9:
					try
					{
						SystemFile systemFile = serviceNotNull.LoadFile(base.Id);
						int num3 = 28;
						while (true)
						{
							int num4;
							switch (num3)
							{
							case 1:
								contentCrc = GuSGSYQ3E50vuhPDeS3a(systemFile.FileCrc);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
								{
									num3 = 26;
								}
								break;
							case 22:
								base.Salt = (string)OXcSIOQ3ZCJ73BjfV6Jh(systemFile);
								num4 = 3;
								goto IL_005e;
							case 4:
								throw new FileNotFoundException(SR.T((string)YnxSItQNz93r59SNKm1G(-29254301 ^ -29347551), base.Id));
							case 2:
								_loaded = true;
								num3 = 17;
								break;
							case 8:
								base.Uid = KhqZOMQ3CetB6btIaXol(systemFile);
								num3 = 21;
								break;
							case 11:
								base.SecondId = systemFile.Id.ToString(CultureInfo.InvariantCulture);
								num3 = 2;
								break;
							case 13:
								text = (string)v3CHSuQ3bo2PlniIPYYO(_privateFilesPath, text);
								num3 = 27;
								break;
							case 26:
								if (wEwJESQ3Fn7YGW1cJ2E4(systemFile) > 0)
								{
									num3 = 11;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
									{
										num3 = 3;
									}
									break;
								}
								goto case 2;
							case 19:
								throw new InvalidDataException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633159269), text));
							case 7:
								if (!fVkBKtQ3hPCEPLFgIkj6(text))
								{
									num3 = 5;
									break;
								}
								goto case 10;
							case 6:
								name = (string)pcmjUGQ3B0BnaAFJPAMt(systemFile);
								num3 = 20;
								break;
							case 10:
							case 15:
								a7FkZ6Q3QHBpGeepLYuk(this, new Uri(text));
								num3 = 24;
								break;
							case 25:
								if (!Crc32.CheckCrc(text, crcValue))
								{
									num3 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
									{
										num3 = 19;
									}
									break;
								}
								goto case 10;
							case 29:
								if (loadFile)
								{
									num3 = 23;
									break;
								}
								goto case 8;
							case 3:
								contentLength = systemFile.FileSize;
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
								{
									num3 = 0;
								}
								break;
							default:
								throw new FileNotFoundException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218137900), text));
							case 18:
								crcValue = GuSGSYQ3E50vuhPDeS3a(pqqd77Q3GZj4FORwj7rA(systemFile));
								num3 = 25;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
								{
									num3 = 25;
								}
								break;
							case 24:
								_fileLoaded = true;
								num3 = 8;
								break;
							case 28:
								if (systemFile != null)
								{
									text = (string)lPvlyyQ3WT5gkTHJLcPW(_privateFilesPath, wEwJESQ3Fn7YGW1cJ2E4(systemFile) + Path.GetExtension(((string)pcmjUGQ3B0BnaAFJPAMt(systemFile)).ReplaceInvalidFileNameChars()));
									num3 = 21;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
									{
										num3 = 29;
									}
								}
								else
								{
									num3 = 4;
								}
								break;
							case 14:
								if (!_checkFile)
								{
									num4 = 7;
									goto IL_005e;
								}
								goto case 9;
							case 23:
								if (vQwkfoQ3o6fgbgEQABae(systemFile))
								{
									num3 = 13;
									break;
								}
								goto case 14;
							case 27:
								fileWasStubbed = true;
								num3 = 15;
								break;
							case 16:
								fileWasStubbed = true;
								num3 = 8;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
								{
									num3 = 10;
								}
								break;
							case 21:
								base.CreateDate = vb81mEQ3vC9GZgW78UB2(systemFile);
								num3 = 6;
								break;
							case 9:
								if (fVkBKtQ3hPCEPLFgIkj6(text))
								{
									num4 = 18;
									goto IL_005e;
								}
								goto default;
							case 20:
								base.ContentType = systemFile.ContentType;
								num3 = 12;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
								{
									num3 = 3;
								}
								break;
							case 12:
								base.Encrypt = ntrgEkQ381tDQtHsWYsc(systemFile);
								num3 = 22;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
								{
									num3 = 2;
								}
								break;
							case 5:
								text = (string)cuJSYWQ3fKvmdK2rbVZg(_privateFilesPath, text);
								num3 = 16;
								break;
							case 17:
								return;
								IL_005e:
								num3 = num4;
								break;
							}
						}
					}
					catch (Exception ex)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								throw;
							}
							BK9abwQ3uC5HTyGqcsDh(EleWise.ELMA.Logging.Logger.GetLogger(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x313302CE)), YnxSItQNz93r59SNKm1G(0x6DC147B0 ^ 0x6DC43BE4), ex);
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
							{
								num5 = 1;
							}
						}
					}
				case 3:
					return;
				case 5:
					return;
				case 7:
					return;
				case 8:
					serviceNotNull = Locator.GetServiceNotNull<SystemFileNHManager>();
					num2 = 9;
					break;
				case 1:
					if (_loaded)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto default;
				case 2:
					if (!loadFile)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				case 6:
					if (!_loaded)
					{
						num2 = 8;
						break;
					}
					goto case 4;
				case 4:
					if (_fileLoaded)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 8;
				default:
					if (loadFile)
					{
						num2 = 6;
						break;
					}
					goto case 8;
				}
			}
		}

		public override long GetSize()
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return contentLength.Value;
				case 2:
					CheckLoaded();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					if (!contentLength.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				default:
					contentLength = LqTfAOQ3iDPJAZ3OHlfh(BeaAWnQ3ScgfH4OFUWEs(), base.Id);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		public override uint GetCrc()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					CheckLoaded();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return contentCrc;
				}
			}
		}

		public override Stream GetContent(GetContentOptions options = null)
		{
			//Discarded unreachable code: IL_0071, IL_0080
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return base.GetContent(options);
				default:
					return new FileStream(((Uri)S9hxiBQ3RBPaYjR09KMU(this)).LocalPath, FileMode.Open, FileAccess.Read);
				case 2:
					if (fileWasStubbed)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				case 3:
					CheckLoaded(loadFile: true);
					num2 = 2;
					break;
				}
			}
		}

		protected override bool IsLoaded()
		{
			return Loaded;
		}

		internal static bool m48kAwQNU2EBqnIQLkmu()
		{
			return itvTthQNLYCBxs2clHIC == null;
		}

		internal static LazyBinaryFile TqygqyQNsEFNA1OInkov()
		{
			return itvTthQNLYCBxs2clHIC;
		}

		internal static void wJcL8uQNcXKOwNYd2lfc()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object YnxSItQNz93r59SNKm1G(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static int wEwJESQ3Fn7YGW1cJ2E4(object P_0)
		{
			return ((SystemFile)P_0).Id;
		}

		internal static object pcmjUGQ3B0BnaAFJPAMt(object P_0)
		{
			return ((SystemFile)P_0).Name;
		}

		internal static object lPvlyyQ3WT5gkTHJLcPW(object P_0, object P_1)
		{
			return Path.Combine((string)P_0, (string)P_1);
		}

		internal static bool vQwkfoQ3o6fgbgEQABae(object P_0)
		{
			return ((SystemFile)P_0).IsDeleted;
		}

		internal static object v3CHSuQ3bo2PlniIPYYO(object P_0, object P_1)
		{
			return CreateFileDelete(P_0, P_1);
		}

		internal static bool fVkBKtQ3hPCEPLFgIkj6(object P_0)
		{
			return File.Exists((string)P_0);
		}

		internal static object pqqd77Q3GZj4FORwj7rA(object P_0)
		{
			return ((SystemFile)P_0).FileCrc;
		}

		internal static uint GuSGSYQ3E50vuhPDeS3a(object P_0)
		{
			return BinaryFile.ParseCrc((string)P_0);
		}

		internal static object cuJSYWQ3fKvmdK2rbVZg(object P_0, object P_1)
		{
			return CreateFileNotFound(P_0, P_1);
		}

		internal static void a7FkZ6Q3QHBpGeepLYuk(object P_0, object P_1)
		{
			((BinaryFile)P_0).ContentLocation = (Uri)P_1;
		}

		internal static Guid KhqZOMQ3CetB6btIaXol(object P_0)
		{
			return ((SystemFile)P_0).Uid;
		}

		internal static DateTime vb81mEQ3vC9GZgW78UB2(object P_0)
		{
			return ((SystemFile)P_0).CreateDate;
		}

		internal static bool ntrgEkQ381tDQtHsWYsc(object P_0)
		{
			return ((SystemFile)P_0).Encrypt;
		}

		internal static object OXcSIOQ3ZCJ73BjfV6Jh(object P_0)
		{
			return ((SystemFile)P_0).Salt;
		}

		internal static void BK9abwQ3uC5HTyGqcsDh(object P_0, object P_1, object P_2)
		{
			((ILogger)P_0).Info(P_1, (Exception)P_2);
		}

		internal static object pWRhxwQ3IWeaubAL0G39(object P_0)
		{
			return ((Uri)P_0).LocalPath;
		}

		internal static object oHQwRSQ3VgRsFXwyZUDo(object P_0, object P_1)
		{
			return ((FileSystemFileStoreProvider)P_0).GetLazyFileLocation((string)P_1);
		}

		internal static object BeaAWnQ3ScgfH4OFUWEs()
		{
			return DataAccessManager.FileManager;
		}

		internal static long LqTfAOQ3iDPJAZ3OHlfh(object P_0, object P_1)
		{
			return ((IFileManager)P_0).FileSize((string)P_1);
		}

		internal static object S9hxiBQ3RBPaYjR09KMU(object P_0)
		{
			return ((BinaryFile)P_0).ContentLocation;
		}
	}

	private IEnumerable<IPreUploadFile> componentsPreUploadFile;

	private SystemFileNHManager systemFileManager;

	private IStorageOperationsProvider storageOperationsProvider;

	internal const string ItemsKey = "EleWise.ELMA.Runtime.Providers.Impl.FileSystemFileStoreProvider.StoreOnCommit";

	internal const string StoreKey = "EleWise.ELMA.Runtime.Providers.Impl.FileSystemFileStoreProvider.ProcessStore";

	internal const string EncryptItemsKey = "EleWise.ELMA.Runtime.Providers.Impl.FileSystemFileStoreProvider.EncriptedFilesKeys";

	private string privateFilesPath;

	private string privatePreviewsPath;

	private string privateTempFilesPath;

	private bool initialized;

	protected bool ignoreNotExistsFiles;

	private ILogger logger;

	private static IAuthenticationService authenticationService;

	private static readonly IList<string> notFoundExtensions;

	private static FileSystemFileStoreProvider asrIwLWQt4N0iq3l3VrP;

	protected ILogger Logger
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (logger == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return logger;
				default:
					logger = EleWise.ELMA.Logging.Logger.GetLogger((string)zjGtgwWQH4ZdBdwcPAiW(-97972138 ^ -98012258));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}
	}

	protected static IAuthenticationService AuthenticationService
	{
		get
		{
			int num = 1;
			int num2 = num;
			IAuthenticationService obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = authenticationService;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = (authenticationService = Locator.GetService<IAuthenticationService>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	protected SystemFileNHManager SystemFileManager
	{
		get
		{
			int num = 1;
			int num2 = num;
			SystemFileNHManager systemFileNHManager = default(SystemFileNHManager);
			SystemFileNHManager systemFileNHManager2;
			while (true)
			{
				switch (num2)
				{
				default:
					systemFileNHManager = (systemFileManager = Locator.GetService<SystemFileNHManager>());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					systemFileNHManager2 = systemFileManager;
					if (systemFileNHManager2 != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					systemFileNHManager2 = systemFileNHManager;
					break;
				}
				break;
			}
			return systemFileNHManager2;
		}
	}

	protected virtual IStorageOperationsProvider StorageOperationsProvider => storageOperationsProvider;

	protected virtual IFileGatewayService FileGatewayService => this;

	protected bool Initialized => initialized;

	private string CurrentUser
	{
		get
		{
			//Discarded unreachable code: IL_003d, IL_0051, IL_005c, IL_0066, IL_0075
			int num = 5;
			int num2 = num;
			string text;
			IUser user = default(IUser);
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 3:
					text = string.Empty;
					break;
				case 2:
					obj = null;
					goto IL_00df;
				case 4:
					return string.Empty;
				case 5:
					if (Eg5apLWQApu3sMfYKK7y(Logger))
					{
						if (AuthenticationService != null)
						{
							num2 = 6;
							continue;
						}
						goto case 2;
					}
					num2 = 4;
					continue;
				case 1:
					if (user != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 6:
					obj = QMLaHHWQ7PNFBfRYdjiB(AuthenticationService);
					goto IL_00df;
				default:
					{
						text = user.UserName;
						break;
					}
					IL_00df:
					user = (IUser)obj;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			return (string)OKX2EnWQxYL1v96cCmMl(text, zjGtgwWQH4ZdBdwcPAiW(-561074844 ^ -561068752));
		}
	}

	public override string TempFilesPath
	{
		get
		{
			return privateTempFilesPath;
		}
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
					privateTempFilesPath = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
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

	public override string FilesPath
	{
		get
		{
			return privateFilesPath;
		}
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
					privateFilesPath = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
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

	public override string PreviewsPath
	{
		get
		{
			return privatePreviewsPath;
		}
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
					privatePreviewsPath = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override string ContextItemsKey => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195657365);

	public override string ProcessStoreKey => (string)zjGtgwWQH4ZdBdwcPAiW(-561074844 ^ -561052552);

	string IFileGatewayService.SystemGateway => string.Empty;

	string[] IFileGatewayService.AllGateways => new string[0];

	public FileSystemFileStoreProvider()
	{
		//Discarded unreachable code: IL_0061, IL_0066
		BxCLkOWQ6cNg7WloU7c4();
		privateFilesPath = (string)zjGtgwWQH4ZdBdwcPAiW(-867826612 ^ -867735676);
		privatePreviewsPath = (string)zjGtgwWQH4ZdBdwcPAiW(-538519530 ^ -538476622);
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
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
			componentsPreUploadFile = Enumerable.Empty<IPreUploadFile>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
			{
				num = 1;
			}
		}
	}

	public FileSystemFileStoreProvider(IEnumerable<IPreUploadFile> componentsPreUploadFile)
	{
		SingletonReader.JJCZtPuTvSt();
		privateFilesPath = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7ED76F7);
		privatePreviewsPath = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A4724B);
		base._002Ector();
		this.componentsPreUploadFile = componentsPreUploadFile;
	}

	public override void Initialize(string name, NameValueCollection config)
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					Kjcq2VWQyZ1AgRROCN04(this, name, config);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					name = (string)cadO6IWQmTh6igQ0FFB5(this, name, config);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return;
				case 1:
					break;
				case 4:
					AReyowWQ0Kckm3BpBhgN(config, zjGtgwWQH4ZdBdwcPAiW(-576149596 ^ -576126948));
					num2 = 3;
					continue;
				}
				break;
			}
			initialized = true;
			num = 2;
		}
	}

	protected virtual string DoProviderSpecificInitialization(string name, NameValueCollection config)
	{
		//Discarded unreachable code: IL_0223, IL_0232, IL_039d, IL_03db, IL_03ea, IL_04ce, IL_04dd
		int num = 16;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 23:
					privateTempFilesPath = (string)zjGtgwWQH4ZdBdwcPAiW(0x3A5D5EF ^ 0x3A4BDBF);
					num = 18;
					break;
				case 6:
					if (!uDS7aQWQMj4nE33ahKIX(privateTempFilesPath))
					{
						num2 = 33;
						continue;
					}
					goto case 23;
				case 26:
				case 36:
					if (Directory.Exists(privatePreviewsPath))
					{
						num2 = 20;
						continue;
					}
					goto case 8;
				case 15:
					name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108676616);
					num2 = 10;
					continue;
				case 10:
					privateFilesPath = (string)OBV0MWWQJtY5GU8b8YwP(config, zjGtgwWQH4ZdBdwcPAiW(0x5A4C7B29 ^ 0x5A4DD32B));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 1;
					}
					continue;
				case 28:
					PtcISBWQdV4ZSIfBirCv(config, zjGtgwWQH4ZdBdwcPAiW(-1979251663 ^ -1979274189), privateFilesPath);
					num2 = 30;
					continue;
				case 30:
					privatePreviewsPath = config[(string)zjGtgwWQH4ZdBdwcPAiW(-1767720453 ^ -1767697949)];
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 9;
					}
					continue;
				case 3:
				case 32:
					privateTempFilesPath = (string)gGWm3YWQL1xXAxg9YgPj(privateTempFilesPath);
					num = 21;
					break;
				case 34:
					config.Add((string)zjGtgwWQH4ZdBdwcPAiW(-2138958856 ^ -2138850356), privateFilesPath);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					Directory.CreateDirectory(privateTempFilesPath);
					num2 = 35;
					continue;
				case 16:
					if (uDS7aQWQMj4nE33ahKIX(name))
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 10;
				case 4:
					if (string.IsNullOrEmpty(privateFilesPath))
					{
						num2 = 31;
						continue;
					}
					goto case 30;
				case 9:
				case 17:
					text = (string)yOOQQWWQjwviuNyt7mgY(CWE5fZWQ5Gxf16FypDR8(xjsSIEWQgCUavKVs2qUd(QgPdWVWQrGEl5NMTRg33(((ComponentManager)r0xjxRWQlZbrlGoT2HGl()).GetExtensionPoints<IRuntimeApplication>().First()))));
					num2 = 13;
					continue;
				default:
					if (bool.TryParse(config[(string)zjGtgwWQH4ZdBdwcPAiW(0x269E5FCA ^ 0x269FF798)], out ignoreNotExistsFiles))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 12;
				case 25:
					privateTempFilesPath = (string)OBV0MWWQJtY5GU8b8YwP(config, zjGtgwWQH4ZdBdwcPAiW(-345420348 ^ -345446928));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 2;
					}
					continue;
				case 19:
					if (uDS7aQWQMj4nE33ahKIX(privatePreviewsPath))
					{
						num2 = 14;
						continue;
					}
					goto case 25;
				case 18:
					eea7PgWQ9W5u1LQgRtWp(config, zjGtgwWQH4ZdBdwcPAiW(-2138958856 ^ -2138850356));
					num2 = 34;
					continue;
				case 29:
					AeUo83WQsLGPb8rFOfWc(privateFilesPath);
					num2 = 36;
					continue;
				case 12:
					ignoreNotExistsFiles = false;
					num2 = 17;
					continue;
				case 24:
					return name;
				case 7:
					privatePreviewsPath = (string)Ty5XGhWQYVexiHXqAD85(text, privatePreviewsPath);
					num2 = 32;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 22;
					}
					continue;
				case 27:
					config.Add((string)zjGtgwWQH4ZdBdwcPAiW(0x1A33FE36 ^ 0x1A32562E), privatePreviewsPath);
					num = 25;
					break;
				case 35:
					storageOperationsProvider = (IStorageOperationsProvider)y5VjpYWQcdn8Pe1tkmNU(this);
					num2 = 24;
					continue;
				case 13:
					if (text == null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 1;
				case 14:
					privatePreviewsPath = (string)zjGtgwWQH4ZdBdwcPAiW(0x3C5338FF ^ 0x3C529F5B);
					num2 = 5;
					continue;
				case 11:
					eea7PgWQ9W5u1LQgRtWp(config, zjGtgwWQH4ZdBdwcPAiW(0x31326106 ^ 0x3133C904));
					num = 28;
					break;
				case 21:
					if (B3eXXMWQU4Gcbuv26ElV(privateFilesPath))
					{
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
						{
							num2 = 23;
						}
						continue;
					}
					goto case 29;
				case 1:
					privateFilesPath = (string)Ty5XGhWQYVexiHXqAD85(text, privateFilesPath);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 7;
					}
					continue;
				case 5:
					eea7PgWQ9W5u1LQgRtWp(config, zjGtgwWQH4ZdBdwcPAiW(-882126494 ^ -882214534));
					num2 = 27;
					continue;
				case 8:
					AeUo83WQsLGPb8rFOfWc(privatePreviewsPath);
					num2 = 22;
					continue;
				case 31:
					privateFilesPath = (string)zjGtgwWQH4ZdBdwcPAiW(-957824448 ^ -957767288);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 11;
					}
					continue;
				case 20:
				case 22:
					if (!Directory.Exists(privateTempFilesPath))
					{
						num2 = 2;
						continue;
					}
					goto case 35;
				}
				break;
			}
		}
	}

	protected virtual IStorageOperationsProvider CreateStorageOperationsProvider()
	{
		int num = 1;
		int num2 = num;
		LocalFsLocationSchema locationSchema = default(LocalFsLocationSchema);
		while (true)
		{
			switch (num2)
			{
			case 1:
				locationSchema = new LocalFsLocationSchema(privateFilesPath, privateTempFilesPath, privatePreviewsPath);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return new LocalFsStorageOperationsProvider(Logger, locationSchema);
			}
		}
	}

	[Transaction]
	public override string SaveFile([NotNull] BinaryFile binaryFile)
	{
		//Discarded unreachable code: IL_015d, IL_0529, IL_05c8, IL_05d7, IL_066b, IL_06b1, IL_071d, IL_072c
		int num = 2;
		IMimeMappingService service = default(IMimeMappingService);
		string text = default(string);
		FileEncryptData value2 = default(FileEncryptData);
		SystemFile systemFile2 = default(SystemFile);
		Dictionary<Guid, FileEncryptData> value = default(Dictionary<Guid, FileEncryptData>);
		Guid guid = default(Guid);
		Uri uri = default(Uri);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					if (Locator.Initialized)
					{
						num2 = 16;
						break;
					}
					goto default;
				case 4:
					if (StoreOnCommit(binaryFile))
					{
						num2 = 8;
						break;
					}
					goto case 9;
				case 16:
					if ((service = Locator.GetService<IMimeMappingService>()) == null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num2 = 12;
						}
						break;
					}
					goto case 13;
				case 2:
					AReyowWQ0Kckm3BpBhgN(binaryFile, zjGtgwWQH4ZdBdwcPAiW(-787452571 ^ -787364643));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					if (!uDS7aQWQMj4nE33ahKIX(binaryFile.Name))
					{
						num2 = 11;
						break;
					}
					goto default;
				case 3:
					if (!string.IsNullOrEmpty(binaryFile.ContentType))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 6;
				case 7:
					if (HJV403WQz9oIxyeKZUoO(binaryFile) == Guid.Empty)
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
						{
							num2 = 6;
						}
						break;
					}
					goto case 3;
				case 15:
					WRFrqaWCFPgyirfaRD6L(binaryFile, Guid.NewGuid());
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					Contract.ArgumentNotNull(binaryFile.ContentLocation, (string)zjGtgwWQH4ZdBdwcPAiW(0xA592A41 ^ 0xA588391));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 7;
					}
					break;
				case 13:
					binaryFile.ContentType = (string)covDZxWCWMnUmd2s2G3O(service, text);
					num2 = 5;
					break;
				case 9:
					if (!OHIHnqWCfZNEnMyPI1Li(binaryFile.Uid, Guid.Empty))
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 16;
						}
						break;
					}
					return null;
				case 8:
					try
					{
						Logger.InfoFormat((string)zjGtgwWQH4ZdBdwcPAiW(-1876063057 ^ -1876154713), CurrentUser, pwPeWRWCoaDhEFeoegbE(binaryFile), HJV403WQz9oIxyeKZUoO(binaryFile), binaryFile.ContentLocation);
						int num3 = 21;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num3 = 5;
						}
						while (true)
						{
							SystemFile systemFile;
							switch (num3)
							{
							case 12:
								value2 = null;
								num3 = 25;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
								{
									num3 = 25;
								}
								continue;
							case 14:
								xaoNSHWCi8egLXt5YXqA(systemFile2, false);
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
								{
									num3 = 3;
								}
								continue;
							case 17:
								txcOcZWCGCdx9v38TiTn(this, binaryFile);
								num3 = 13;
								continue;
							case 6:
								a2P0npWCvx261HlQJK6r(systemFile2, binaryFile.Uid);
								num3 = 16;
								continue;
							case 3:
								if (OHIHnqWCfZNEnMyPI1Li(T6pqnWWCEyAkKEfZa5a6(systemFile2), Guid.Empty))
								{
									num3 = 19;
									continue;
								}
								goto case 6;
							case 9:
								value.Remove(binaryFile.Uid);
								num3 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
								{
									num3 = 6;
								}
								continue;
							case 8:
								At6vZoWCkT1pHQiWF9jx(this, systemFile2, binaryFile);
								num3 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
								{
									num3 = 4;
								}
								continue;
							default:
								guid = T6pqnWWCEyAkKEfZa5a6(systemFile2);
								binaryFile.Id = guid.ToString();
								num3 = 12;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
								{
									num3 = 6;
								}
								continue;
							case 2:
								bVgMVJWCuPvX8OY39nqD(systemFile2, TjV9mtWCZeWsUixZb8fV(binaryFile));
								num3 = 22;
								continue;
							case 21:
								if (!string.IsNullOrEmpty((string)oL6SFQWCbe6V3WoQImtX(binaryFile)))
								{
									int num4 = 24;
									num3 = num4;
									continue;
								}
								goto case 17;
							case 7:
								Encrypt(systemFile2, (string)CbicZdWCOAYPJglA3BX9(value2), value2.Salt);
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
								{
									num3 = 15;
								}
								continue;
							case 19:
								eeZP1MWCCg1kShv0hCjy(systemFile2, k7TNmDWCQBPhhUd8TJIa(binaryFile));
								num3 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
								{
									num3 = 1;
								}
								continue;
							case 22:
								R6dwNNWCVf2diMPf9UHA(systemFile2, binaryFile.GetCrc().ToString((IFormatProvider)GrcXM7WCIMLvc7IupXrB()));
								num3 = 10;
								continue;
							case 4:
								c1oklHWCnYm6QcxofQWx(binaryFile, false);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
								{
									num3 = 0;
								}
								continue;
							case 11:
								uri = ((IStorageOperationsProvider)vEA5BFWCK9YpiBvQ6HPm(this)).SaveContent(binaryFile.ContentLocation, systemFile2, mmlTF3WCXLYQ8ZuPao98(binaryFile));
								num3 = 23;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
								{
									num3 = 23;
								}
								continue;
							case 10:
								systemFile2.FileSize = Br8ooaWCS9BqIt9cMsTJ(binaryFile);
								num3 = 14;
								continue;
							case 20:
								if (!value.TryGetValue(binaryFile.Uid, out value2))
								{
									break;
								}
								goto case 9;
							case 23:
								l7IbIgWCTSrVC5ALBFfM(this, binaryFile, uri);
								num3 = 8;
								continue;
							case 16:
								L4lLFUWC8UissaqMAKXj(systemFile2, pwPeWRWCoaDhEFeoegbE(binaryFile));
								num3 = 2;
								continue;
							case 25:
								if (ContextVars.TryGetValue<Dictionary<Guid, FileEncryptData>>((string)zjGtgwWQH4ZdBdwcPAiW(0x7C1EE318 ^ 0x7C1F4952), out value))
								{
									num3 = 20;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
									{
										num3 = 6;
									}
									continue;
								}
								break;
							case 24:
								s1YiV9WCh03a5CvOm5jA(binaryFile, null);
								num3 = 17;
								continue;
							case 5:
								gaC7jVWCq0IyFu0BFvCX(systemFile2, oj12U7WCRH9SGPDFp2eN(SystemFileManager, systemFile2));
								num3 = 11;
								continue;
							case 1:
								goto end_IL_0278;
							case 13:
								systemFile = SystemFileManager.LoadFile(HJV403WQz9oIxyeKZUoO(binaryFile));
								if (systemFile != null)
								{
									goto IL_061e;
								}
								num3 = 18;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
								{
									num3 = 15;
								}
								continue;
							case 18:
								systemFile = new SystemFile();
								goto IL_061e;
							case 15:
								goto end_IL_0278;
								IL_061e:
								systemFile2 = systemFile;
								num3 = 3;
								continue;
							}
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
							{
								num3 = 1;
							}
							continue;
							end_IL_0278:
							break;
						}
					}
					catch (Exception ex)
					{
						int num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								Hdj8quWCepXKdcnLt788(Logger, R57rr5WC2c2bvo7qa0Cc(ex), ex);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
								{
									num5 = 0;
								}
								break;
							default:
								throw;
							}
						}
					}
					goto case 9;
				case 11:
					text = (string)YLkZMkWCBWOSpCbBxbGX(binaryFile);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 4;
					}
					break;
				default:
					if (initialized)
					{
						goto end_IL_0012;
					}
					goto case 9;
				case 17:
					guid = HJV403WQz9oIxyeKZUoO(binaryFile);
					num2 = 14;
					break;
				case 14:
					return guid.ToString();
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	protected virtual void PostSaveActions(SystemFile file, BinaryFile binaryFile)
	{
	}

	protected virtual void PreSaveActions(BinaryFile binaryFile)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass48_0 _003C_003Ec__DisplayClass48_ = default(_003C_003Ec__DisplayClass48_0);
		while (true)
		{
			switch (num2)
			{
			default:
				componentsPreUploadFile.ForEach(_003C_003Ec__DisplayClass48_._003CPreSaveActions_003Eb__0);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass48_.binaryFile = binaryFile;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 3:
				_003C_003Ec__DisplayClass48_ = new _003C_003Ec__DisplayClass48_0();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	protected virtual void UpdateBinaryFileLocation(BinaryFile binaryFile, Uri newLocation)
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
				eGOmdNWCPS2Zot9ddNPt(binaryFile, newLocation);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void Encrypt(BinaryFile file, string password, string salt)
	{
		//Discarded unreachable code: IL_009d, IL_00ac, IL_010d
		int num = 11;
		int num2 = num;
		SystemFile systemFile = default(SystemFile);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				return;
			case 5:
				Encrypt(systemFile, password, salt);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 0;
				}
				continue;
			case 11:
				if (!initialized)
				{
					num2 = 10;
					continue;
				}
				goto case 8;
			case 2:
				if (systemFile != null)
				{
					num2 = 5;
					continue;
				}
				goto case 6;
			case 0:
				return;
			case 10:
				return;
			case 8:
				if (!fJ2kkiWC16MbYk3rSP6V(file))
				{
					num2 = 9;
					continue;
				}
				return;
			case 3:
				return;
			case 9:
				systemFile = (SystemFile)SYSpO6WCNZN0xTTRbZbw(SystemFileManager, HJV403WQz9oIxyeKZUoO(file));
				num2 = 2;
				continue;
			case 6:
				if (OHIHnqWCfZNEnMyPI1Li(HJV403WQz9oIxyeKZUoO(file), Guid.Empty))
				{
					num2 = 7;
					continue;
				}
				break;
			case 7:
				WRFrqaWCFPgyirfaRD6L(file, QMcLjVWC32j5wmxunVT5());
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 4;
				}
				continue;
			case 4:
				break;
			}
			Dictionary<Guid, FileEncryptData> orAdd = ContextVars.GetOrAdd((string)zjGtgwWQH4ZdBdwcPAiW(--1867379187 ^ 0x6F4C5BB9), () => new Dictionary<Guid, FileEncryptData>());
			Guid uid = file.Uid;
			FileEncryptData obj = new FileEncryptData
			{
				Salt = salt
			};
			vGal2WWCpvMWavp4O4J2(obj, password);
			orAdd[uid] = obj;
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
			{
				num2 = 1;
			}
		}
	}

	private void Encrypt(SystemFile systemFile, string password, string salt)
	{
		int num = 2;
		int num2 = num;
		BinaryFileContentInfo binaryFileContentInfo = default(BinaryFileContentInfo);
		while (true)
		{
			switch (num2)
			{
			case 6:
				SystemFileManager.InsertFile(systemFile);
				num2 = 4;
				break;
			case 3:
				R6dwNNWCVf2diMPf9UHA(systemFile, SBd9ugWCDfbbwmcXsutl(binaryFileContentInfo).ToString((IFormatProvider)GrcXM7WCIMLvc7IupXrB()));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				binaryFileContentInfo = ((IStorageOperationsProvider)vEA5BFWCK9YpiBvQ6HPm(this)).EncryptContent(systemFile, password);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return;
			case 2:
				HTaVT0WCawwFGtejQ0QG(systemFile, salt);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				systemFile.FileSize = lCTSG1WCtQSqGOCL8kYx(binaryFileContentInfo);
				num2 = 6;
				break;
			case 5:
				((IStorageOperationsProvider)vEA5BFWCK9YpiBvQ6HPm(this)).SaveContent(binaryFileContentInfo.ContentLocation, systemFile, deleteSourceAfterSave: true);
				num2 = 3;
				break;
			}
		}
	}

	public override BinaryFile Decrypt(BinaryFile file, string password)
	{
		//Discarded unreachable code: IL_00cd
		int num = 3;
		int num2 = num;
		SystemFile systemFile = default(SystemFile);
		BinaryFileContentInfo binaryFileContentInfo = default(BinaryFileContentInfo);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return file;
			case 1:
				systemFile = (SystemFile)SYSpO6WCNZN0xTTRbZbw(SystemFileManager, file.Uid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				binaryFileContentInfo = (BinaryFileContentInfo)fhrfnCWCw0UO6lPqmLM8(vEA5BFWCK9YpiBvQ6HPm(this), systemFile, password);
				num2 = 5;
				break;
			case 5:
				return (BinaryFile)p9YHHlWCAIrOcVOiF1ou(qUNSQxWCHxCZnsBAMhfP(pStENnWC4CRDcZUe0HQV(file), RJvH4ZWC6PW8q8HVFpR3(binaryFileContentInfo), binaryFileContentInfo.ContentLength, binaryFileContentInfo.Crc));
			case 2:
				if (fJ2kkiWC16MbYk3rSP6V(file))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 3:
				if (initialized)
				{
					num2 = 2;
					break;
				}
				goto case 4;
			}
		}
	}

	[Transaction]
	public override void CancelEncrypt(BinaryFile file, string password)
	{
		//Discarded unreachable code: IL_015b, IL_01c5
		int num = 15;
		IFilePreviewService service = default(IFilePreviewService);
		SystemFile systemFile = default(SystemFile);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					J02i9oWCMUBBThx1UpS7(service, file, 0L);
					num = 11;
					break;
				case 16:
					if (service != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					return;
				case 13:
					dDDj6sWC7VyxWvUwAssO(file, null);
					num2 = 10;
					continue;
				case 9:
					return;
				case 14:
					return;
				case 11:
					return;
				case 3:
					quF5HyWCmL6KJGJkPSDL(systemFile, false);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 7;
					}
					continue;
				default:
					service = Locator.GetService<IFilePreviewService>();
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 16;
					}
					continue;
				case 6:
					if (fJ2kkiWC16MbYk3rSP6V(file))
					{
						file.Encrypt = false;
						num2 = 13;
						continue;
					}
					num = 9;
					break;
				case 7:
					oj12U7WCRH9SGPDFp2eN(SystemFileManager, systemFile);
					num2 = 12;
					continue;
				case 15:
					if (!initialized)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 6;
				case 1:
					if (!bnFO7VWCyuZEcc52N64A(service, file, null))
					{
						return;
					}
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 1;
					}
					continue;
				case 10:
					hT53vMWCx73TXAwt4HID(this, file);
					num2 = 2;
					continue;
				case 8:
					if (systemFile == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 2:
					systemFile = (SystemFile)SYSpO6WCNZN0xTTRbZbw(SystemFileManager, HJV403WQz9oIxyeKZUoO(file));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 8;
					}
					continue;
				case 5:
					NFjQL3WC0r2TQwd7lkCq(systemFile, null);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	private bool StoreOnCommit(BinaryFile binaryFile)
	{
		//Discarded unreachable code: IL_0051, IL_0060
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (binaryFile != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				return false;
			case 1:
				ContextVars.GetOrAdd((string)zjGtgwWQH4ZdBdwcPAiW(-70037984 ^ -70064546), () => new Dictionary<Guid, BinaryFile>())[HJV403WQz9oIxyeKZUoO(binaryFile)] = binaryFile;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return ContextVars.GetOrAdd((string)zjGtgwWQH4ZdBdwcPAiW(-1822890472 ^ -1822863612), () => true);
			}
		}
	}

	public override string RenameFile(string id, string fileName)
	{
		//Discarded unreachable code: IL_0032, IL_006f, IL_0079, IL_0088, IL_0098, IL_0186, IL_01db, IL_01ea
		string result = default(string);
		switch (1)
		{
		case 1:
			try
			{
				int result2 = 0;
				int num = 6;
				Guid result3 = default(Guid);
				while (true)
				{
					object obj;
					switch (num)
					{
					case 3:
						obj = Hbb4YVWCdQJJ8mq7Ev2T(SystemFileManager, result2, fileName);
						goto IL_0144;
					case 6:
						if (!Guid.TryParse(id, out result3))
						{
							num = 5;
							break;
						}
						goto case 2;
					case 5:
						if (int.TryParse(id, out result2))
						{
							num = 2;
							break;
						}
						goto case 4;
					case 4:
						throw new ArgumentException((string)up3qLTWCJBVts8sYkhWP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BA1FCC)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234230678));
					case 2:
						if (yUFHIyWC9XwUZdCpqfmR(result3, Guid.Empty))
						{
							num = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
							{
								num = 1;
							}
							break;
						}
						goto case 3;
					case 1:
						obj = SystemFileManager.RenameFile(result3, fileName);
						goto IL_0144;
					default:
						return result;
					case 0:
						{
							return result;
						}
						IL_0144:
						result = (string)nqo3oSWClPPwrilrg1r7(obj);
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
				int num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 1;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						Hdj8quWCepXKdcnLt788(Logger, SR.T((string)zjGtgwWQH4ZdBdwcPAiW(-1767720453 ^ -1767697767)), ex);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num2 = 0;
						}
						break;
					default:
						throw;
					}
				}
			}
		default:
			return result;
		}
	}

	[Transaction]
	public override BinaryFile CopyFile(BinaryFile sourceBinaryFile)
	{
		//Discarded unreachable code: IL_00e4
		int num = 3;
		int num2 = num;
		BinaryFile binaryFile = default(BinaryFile);
		while (true)
		{
			switch (num2)
			{
			case 3:
				Contract.ArgumentNotNull(sourceBinaryFile, (string)zjGtgwWQH4ZdBdwcPAiW(0x7C1EE318 ^ 0x7C1F48BC));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 2;
				}
				break;
			default:
				if (Fa8ZhRWC5CnSDV2bivuD(hT53vMWCx73TXAwt4HID(this, binaryFile)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 2:
				binaryFile = (BinaryFile)p9YHHlWCAIrOcVOiF1ou(((BinaryFileBuilder)S5pgj4WCrY1iJHPJYJ58(pStENnWC4CRDcZUe0HQV(sourceBinaryFile), QMcLjVWC32j5wmxunVT5())).Created(vYp6YCWCgb8bCrKZSDDA()).Content(sourceBinaryFile.GetContent(GetContentOptions.NonSeekable), autoCloseStream: true));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return binaryFile;
			case 1:
				return null;
			}
		}
	}

	public override BinaryFile LoadFile(string id)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_00d1, IL_00e0, IL_014b
		int num = 3;
		int num2 = num;
		Dictionary<Guid, BinaryFile> value = default(Dictionary<Guid, BinaryFile>);
		Guid result = default(Guid);
		BinaryFile value2 = default(BinaryFile);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return null;
			case 6:
				return null;
			default:
				if (initialized)
				{
					return (BinaryFile)FIZAfZWCjjJYcmSXrLnh(this, id);
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				if (!ContextVars.TryGetValue<Dictionary<Guid, BinaryFile>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A452B9), out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 8;
			case 8:
				if (!value.TryGetValue(result, out value2))
				{
					num2 = 7;
					break;
				}
				goto case 5;
			case 3:
			{
				if (Guid.TryParse(id, out result))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 2;
					}
					break;
				}
				if (int.TryParse(id, out var _))
				{
					num2 = 4;
					break;
				}
				goto case 6;
			}
			case 5:
				return value2;
			}
		}
	}

	protected virtual BinaryFile GetLoadedBinaryFile(string id)
	{
		return new LazyBinaryFile(id, privateFilesPath, !ignoreNotExistsFiles);
	}

	protected BinaryFile LoadFileUnwrapped(string id)
	{
		object obj = jKux5NWCYr5aSEPp4wFR(this, id);
		pwPeWRWCoaDhEFeoegbE(obj);
		tohkq6WCLVIHB31MrHkI(obj);
		return (BinaryFile)obj;
	}

	public override BinaryFile[] LoadFiles(string[] idList)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				if (initialized)
				{
					return (BinaryFile[])huER4TWCUvlbox2RUcoD(this, idList);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual BinaryFile[] LoadFilesNonLazy(string[] idList)
	{
		//Discarded unreachable code: IL_0221, IL_0230, IL_030e, IL_03ef
		int num = 13;
		int num3 = default(int);
		List<Guid> list3 = default(List<Guid>);
		string text = default(string);
		int result2 = default(int);
		Uri sourceContentLocation = default(Uri);
		SystemFile systemFile = default(SystemFile);
		Guid result = default(Guid);
		SystemFile[] array = default(SystemFile[]);
		List<BinaryFile> list = default(List<BinaryFile>);
		BinaryFile binaryFile = default(BinaryFile);
		string[] array2 = default(string[]);
		List<long> list2 = default(List<long>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 21:
					num3 = 0;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 6;
					}
					continue;
				case 12:
					list3 = new List<Guid>();
					num2 = 11;
					continue;
				case 10:
					if (!int.TryParse(text, out result2))
					{
						num = 26;
						break;
					}
					goto IL_02de;
				case 19:
					sourceContentLocation = StorageOperationsProvider.GetSourceContentLocation(systemFile);
					num2 = 3;
					continue;
				case 17:
					list3.Add(result);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 1;
					}
					continue;
				case 24:
					result2 = 0;
					num = 15;
					break;
				case 6:
				case 7:
					if (num3 >= array.Length)
					{
						num2 = 9;
						continue;
					}
					goto case 16;
				case 9:
					return (BinaryFile[])Vn8WHPWvh5XyX5PmHRco(list);
				case 18:
					binaryFile.Id = T6pqnWWCEyAkKEfZa5a6(systemFile).ToString();
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 3;
					}
					continue;
				case 4:
				case 22:
					if (num3 >= array2.Length)
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 5;
				case 16:
					systemFile = array[num3];
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 18;
					}
					continue;
				case 15:
					if (!Guid.TryParse(text, out result))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto IL_02de;
				default:
					list2.Add(result2);
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 20;
					}
					continue;
				case 2:
					list.Add(binaryFile);
					num = 8;
					break;
				case 3:
				{
					BinaryFile binaryFile2 = new BinaryFile();
					YdEy3VWvFkkiUOLFO09A(binaryFile2, hnOHIjWCzdwsQddAn7m9(systemFile));
					eGOmdNWCPS2Zot9ddNPt(binaryFile2, sourceContentLocation);
					bsbVPXWvBSIYW5ICSIvC(binaryFile2, systemFile.CreateDate);
					fAqpjDWvWewJN4csDtLC(binaryFile2, nqo3oSWClPPwrilrg1r7(systemFile));
					binaryFile2.Uid = T6pqnWWCEyAkKEfZa5a6(systemFile);
					binaryFile = binaryFile2;
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 1:
				case 20:
					num3++;
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					continue;
				case 26:
					throw new ArgumentException(SR.T((string)zjGtgwWQH4ZdBdwcPAiW(-1487388570 ^ -1487279186), text));
				case 5:
					text = array2[num3];
					num2 = 24;
					continue;
				case 11:
					array2 = idList;
					num = 25;
					break;
				case 8:
					num3++;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 6;
					}
					continue;
				case 14:
				{
					object obj = qVvdB1WCcffclfB4vIy6(SystemFileManager, DTFihWWCs4atIbbrkCR8(list2), list3.ToArray());
					list = new List<BinaryFile>();
					array = (SystemFile[])obj;
					num2 = 21;
					continue;
				}
				case 13:
					list2 = new List<long>();
					num2 = 12;
					continue;
				case 25:
					num3 = 0;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 4;
					}
					continue;
				case 23:
					{
						qbJdV6WvbpEGr4SETEY3(binaryFile, IqiKf4WvoNJ4MuIlpmb1(systemFile).ToString((IFormatProvider)GrcXM7WCIMLvc7IupXrB()));
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 2;
						}
						continue;
					}
					IL_02de:
					if (OHIHnqWCfZNEnMyPI1Li(result, Guid.Empty))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 17;
				}
				break;
			}
		}
	}

	public override bool FileExists(string id)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 1:
				if (initialized)
				{
					return YFO3VNWvGXX1bqq2NT5s(SystemFileManager, id) != null;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override long FileSize(string id)
	{
		//Discarded unreachable code: IL_009e, IL_011c, IL_012b
		int num = 4;
		long? fileSize = default(long?);
		SystemFile systemFile = default(SystemFile);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (!fileSize.HasValue)
					{
						num2 = 8;
						continue;
					}
					goto case 1;
				default:
					return GetDeletedFileLength(systemFile);
				case 11:
					fileSize = systemFile.FileSize;
					num2 = 6;
					continue;
				case 3:
					return -1L;
				case 1:
					fileSize = systemFile.FileSize;
					num2 = 5;
					continue;
				case 8:
					break;
				case 4:
					if (initialized)
					{
						systemFile = (SystemFile)YFO3VNWvGXX1bqq2NT5s(SystemFileManager, id);
						num2 = 10;
						continue;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 3;
					}
					continue;
				case 10:
					if (systemFile != null)
					{
						num2 = 2;
						continue;
					}
					goto case 9;
				case 5:
					return fileSize.Value;
				case 9:
					throw new FileNotFoundException(SR.T((string)zjGtgwWQH4ZdBdwcPAiW(-70037984 ^ -70065566), id));
				case 2:
					if (!systemFile.IsDeleted)
					{
						num2 = 11;
						continue;
					}
					goto default;
				case 7:
					oj12U7WCRH9SGPDFp2eN(SystemFileManager, systemFile);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			systemFile.FileSize = mydxOpWvE10sEZWa3w4J(this, systemFile);
			num = 7;
		}
	}

	protected virtual long GetFileLength(SystemFile file)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 2;
		int num2 = num;
		long? contentSize = default(long?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (contentSize.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 2:
				contentSize = ((IStorageOperationsProvider)vEA5BFWCK9YpiBvQ6HPm(this)).GetContentSize(file);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (ignoreNotExistsFiles)
				{
					num2 = 3;
					break;
				}
				throw new FileNotFoundException(SR.T((string)zjGtgwWQH4ZdBdwcPAiW(-867826612 ^ -867718938), file.Id));
			case 3:
				return TsB4VpWvCyTnG0oeBxup(FEAe4oWvQgIRbIjGRnrp(CLUaO8WvfTVd5RYLLBSg(nqo3oSWClPPwrilrg1r7(file))));
			default:
				return contentSize.Value;
			}
		}
	}

	private static void MarkSystemFileAsEncrypt(object file, object salt)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				NFjQL3WC0r2TQwd7lkCq(file, salt);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				quF5HyWCmL6KJGJkPSDL(file, true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	protected virtual long GetDeletedFileLength(SystemFile file)
	{
		return TsB4VpWvCyTnG0oeBxup(FEAe4oWvQgIRbIjGRnrp(CLUaO8WvfTVd5RYLLBSg(file.Name)));
	}

	private static string CreateFileDelete(object privateFilesPath, object storePath)
	{
		//Discarded unreachable code: IL_0080, IL_00e7, IL_0166, IL_01ba, IL_01d9, IL_01e8, IL_0215, IL_0224
		int num = 5;
		int num2 = num;
		FileStream fileStream = default(FileStream);
		FileInfo fileInfo = default(FileInfo);
		string text = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 1:
				fileStream = (FileStream)OlxEENWvZDgqeAKDnZM2(fileInfo);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				continue;
			case 8:
				fileInfo = new FileInfo((string)storePath);
				num2 = 2;
				continue;
			case 7:
				return (string)storePath;
			case 5:
				text = (string)FEAe4oWvQgIRbIjGRnrp(storePath);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 3;
				}
				continue;
			case 2:
				if (!Yd4ShhWv8fHaRx2SLOkN(fileInfo))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 7;
			case 9:
				obj = zjGtgwWQH4ZdBdwcPAiW(-398663332 ^ -398635604);
				break;
			case 4:
				if (notFoundExtensions.Contains((string)XglHwnWvvNl280IEDor8(text)))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 9;
			default:
				try
				{
					byte[] array = (byte[])v19nRHWvu8fdHDxjcjCl(Resources.ResourceManager, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643746583) + text.Remove(0, 1));
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							return (string)storePath;
						case 0:
							return (string)storePath;
						case 1:
							fileStream.Write(array, 0, array.Length);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				finally
				{
					int num4;
					if (fileStream == null)
					{
						num4 = 2;
						goto IL_01be;
					}
					goto IL_01f3;
					IL_01be:
					switch (num4)
					{
					case 2:
						goto end_IL_01a9;
					case 1:
						goto end_IL_01a9;
					}
					goto IL_01f3;
					IL_01f3:
					IlWmTDWvIPVdgSQNhGwX(fileStream);
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num4 = 1;
					}
					goto IL_01be;
					end_IL_01a9:;
				}
			case 6:
				storePath = Path.Combine((string)privateFilesPath, (string)OKX2EnWQxYL1v96cCmMl(zjGtgwWQH4ZdBdwcPAiW(-138018305 ^ -137908989), text));
				num2 = 8;
				continue;
			case 3:
				obj = text;
				break;
			}
			text = (string)obj;
			num2 = 6;
		}
	}

	private static string CreateFileNotFound(object privateFilesPath, object storePath)
	{
		//Discarded unreachable code: IL_005f, IL_00e9, IL_0181, IL_0190, IL_019c, IL_01ab, IL_01bd, IL_01cc
		int num = 6;
		FileInfo fileInfo = default(FileInfo);
		FileStream fileStream = default(FileStream);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 8:
					obj = zjGtgwWQH4ZdBdwcPAiW(-1633514411 ^ -1633476443);
					break;
				case 4:
					fileInfo = new FileInfo((string)storePath);
					num2 = 7;
					continue;
				case 1:
					fileStream = (FileStream)OlxEENWvZDgqeAKDnZM2(fileInfo);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					try
					{
						byte[] array = (byte[])v19nRHWvu8fdHDxjcjCl(Wq1aPwWvViH6Qxh6aTtr(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63AA09F8) + (string)EAebepWvS6uyQKtvhfHw(text, 0, 1));
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								return (string)storePath;
							}
							fileStream.Write(array, 0, array.Length);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
							{
								num3 = 1;
							}
						}
					}
					finally
					{
						int num5;
						if (fileStream == null)
						{
							int num4 = 2;
							num5 = num4;
							goto IL_0145;
						}
						goto IL_015b;
						IL_0145:
						switch (num5)
						{
						case 2:
							goto end_IL_012c;
						case 1:
							goto end_IL_012c;
						}
						goto IL_015b;
						IL_015b:
						IlWmTDWvIPVdgSQNhGwX(fileStream);
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num5 = 1;
						}
						goto IL_0145;
						end_IL_012c:;
					}
				default:
					return (string)storePath;
				case 5:
					if (!notFoundExtensions.Contains((string)XglHwnWvvNl280IEDor8(text)))
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					obj = text;
					break;
				case 7:
					if (Yd4ShhWv8fHaRx2SLOkN(fileInfo))
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 9:
					storePath = Ty5XGhWQYVexiHXqAD85(privateFilesPath, (string)zjGtgwWQH4ZdBdwcPAiW(0x8317432 ^ 0x830D8CE) + text);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 4;
					}
					continue;
				case 6:
					text = (string)FEAe4oWvQgIRbIjGRnrp(storePath);
					num2 = 5;
					continue;
				}
				text = (string)obj;
				num2 = 9;
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	protected static long GetNotFoundStubSize(string extension)
	{
		return ((byte[])v19nRHWvu8fdHDxjcjCl(Wq1aPwWvViH6Qxh6aTtr(), OKX2EnWQxYL1v96cCmMl(zjGtgwWQH4ZdBdwcPAiW(-1939377524 ^ -1939415140), EAebepWvS6uyQKtvhfHw(extension, 0, 1)))).LongLength;
	}

	protected static Stream GetNotFoundStubStreamFromResources(string extension)
	{
		return MemoryHelper.GetMemoryStream((byte[])((ResourceManager)Wq1aPwWvViH6Qxh6aTtr()).GetObject((string)OKX2EnWQxYL1v96cCmMl(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420849098), EAebepWvS6uyQKtvhfHw(extension, 0, 1))), writable: false);
	}

	protected internal virtual Uri GetLazyFileLocation(string id)
	{
		//Discarded unreachable code: IL_009e, IL_00ad
		int num = 1;
		int num2 = num;
		SystemFile systemFile = default(SystemFile);
		while (true)
		{
			switch (num2)
			{
			default:
				if (systemFile != null)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 2:
				throw new FileNotFoundException(SR.T((string)zjGtgwWQH4ZdBdwcPAiW(-281842504 ^ -281886470), id));
			case 3:
				return (Uri)CSUkmTWvipjPCPb3okLT(StorageOperationsProvider, systemFile);
			case 1:
				systemFile = (SystemFile)YFO3VNWvGXX1bqq2NT5s(SystemFileManager, id);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual Task CopyToNearestStorageAsync(string id, CancellationToken token)
	{
		return CompletedTask.Default;
	}

	public virtual Task<BinaryFile> LoadFileAsync(string id, CancellationToken token)
	{
		_003C_003Ec__DisplayClass74_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass74_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.id = id;
		return CopyToNearestStorageAsync(CS_0024_003C_003E8__locals0.id, token).Then(delegate
		{
			//Discarded unreachable code: IL_0056, IL_008e, IL_00c6, IL_00d5
			int num = 1;
			int num2 = num;
			CallContextSessionOwner callContextSessionOwner = default(CallContextSessionOwner);
			BinaryFile result = default(BinaryFile);
			while (true)
			{
				switch (num2)
				{
				default:
					try
					{
						result = CS_0024_003C_003E8__locals0._003C_003E4__this.LoadFileUnwrapped(CS_0024_003C_003E8__locals0.id);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => result, 
							_ => result, 
						};
					}
					finally
					{
						if (callContextSessionOwner != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									_003C_003Ec__DisplayClass74_0.vc36MHQ3a8CXitANBACU(callContextSessionOwner);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
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
					callContextSessionOwner = (CallContextSessionOwner)_003C_003Ec__DisplayClass74_0.dBTXxnQ3p24oIXnAWtsP();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return result;
				}
			}
		}, token);
	}

	private void ThrowIfWritingToPersistantFile(BinaryFile binaryFile)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!ylLctpWvRMyaIenxPscI(oL6SFQWCbe6V3WoQImtX(binaryFile)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				throw new NotSupportedException((string)up3qLTWCJBVts8sYkhWP(zjGtgwWQH4ZdBdwcPAiW(-289714582 ^ -289742004)));
			}
		}
	}

	public virtual Stream GetContent(BinaryFile binaryFile, GetContentOptions options = null)
	{
		int num = 5;
		int num2 = num;
		SystemFile systemFile = default(SystemFile);
		while (true)
		{
			GetContentOptions getContentOptions;
			switch (num2)
			{
			case 2:
				if (systemFile != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				return StorageOperationsProvider.OpenTempContentReadStream((Uri)tohkq6WCLVIHB31MrHkI(binaryFile), options);
			case 1:
				return StorageOperationsProvider.OpenPersistentContentReadStream(systemFile, options);
			case 3:
				Logger.DebugFormat((string)zjGtgwWQH4ZdBdwcPAiW(0x10E41EDB ^ 0x10E5B373), tohkq6WCLVIHB31MrHkI(binaryFile), UmXqvQWvq36flwwha90M(options), eLF0OyWvK1nXCl2Fi38e(options));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 0;
				}
				continue;
			default:
				systemFile = (SystemFile)SYSpO6WCNZN0xTTRbZbw(SystemFileManager, HJV403WQz9oIxyeKZUoO(binaryFile));
				num2 = 2;
				continue;
			case 5:
				getContentOptions = options;
				if (getContentOptions != null)
				{
					break;
				}
				num2 = 4;
				continue;
			case 4:
				getContentOptions = GetContentOptions.Default;
				break;
			}
			options = getContentOptions;
			num2 = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
			{
				num2 = 1;
			}
		}
	}

	public void PutContent(BinaryFile binaryFile, Stream content, PutContentOptions options = null)
	{
		//Discarded unreachable code: IL_0062, IL_00af, IL_016f, IL_01c8, IL_0200, IL_020f
		int num = 3;
		int num2 = num;
		Stream stream = default(Stream);
		_003C_003Ec__DisplayClass77_0 _003C_003Ec__DisplayClass77_ = default(_003C_003Ec__DisplayClass77_0);
		Stream stream2 = default(Stream);
		while (true)
		{
			PutContentOptions putContentOptions;
			switch (num2)
			{
			default:
				try
				{
					Crc32 crc = new Crc32();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							MemoryHelper.ActionWithMemoryBuffer<byte, (Stream, Stream, Crc32)>(1048576, (content, stream, crc), PutContentCRC32Action);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
							{
								num4 = 2;
							}
							while (true)
							{
								switch (num4)
								{
								case 2:
									mnBLaTWvXydwkOOdiPnV(crc);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
									{
										num4 = 0;
									}
									break;
								default:
									CDf1pFWvkjsIrOKCN8B6(_003C_003Ec__DisplayClass77_.binaryFile, L0Ki8KWvTckRO7CtM0rx(stream));
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
									{
										num4 = 1;
									}
									break;
								case 1:
									nxdiSCWvOeJ3E9IXmqAd(_003C_003Ec__DisplayClass77_.binaryFile, echXVSWvnnnoWUYZU9Dm(crc));
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
									{
										num4 = 0;
									}
									break;
								case 3:
									return;
								}
							}
						}
						finally
						{
							if (crc != null)
							{
								int num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
								{
									num5 = 1;
								}
								while (true)
								{
									switch (num5)
									{
									case 1:
										IlWmTDWvIPVdgSQNhGwX(crc);
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
										{
											num5 = 0;
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
					if (stream2 != null)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								IlWmTDWvIPVdgSQNhGwX(stream2);
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
								{
									num6 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 8:
				stream2 = stream;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				return;
			case 6:
				ThrowIfWritingToPersistantFile(_003C_003Ec__DisplayClass77_.binaryFile);
				num2 = 7;
				continue;
			case 3:
				_003C_003Ec__DisplayClass77_ = new _003C_003Ec__DisplayClass77_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 2;
				}
				continue;
			case 7:
				stream = ((IStorageOperationsProvider)vEA5BFWCK9YpiBvQ6HPm(this)).OpenTempContentWriteStream((Action<Uri>)_003C_003Ec__DisplayClass77_._003CPutContent_003Eb__0, options);
				num2 = 8;
				continue;
			case 2:
				_003C_003Ec__DisplayClass77_.binaryFile = binaryFile;
				num2 = 4;
				continue;
			case 4:
				putContentOptions = options;
				if (putContentOptions != null)
				{
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				putContentOptions = PutContentOptions.Default;
				break;
			}
			options = putContentOptions;
			num2 = 6;
		}
	}

	private void PutContentCRC32Action(byte[] buffer, int offset, int length, (Stream, Stream, Crc32) param)
	{
		int num;
		do
		{
			(Stream, Stream, Crc32) tuple = param;
			Stream item = tuple.Item1;
			Stream item2 = tuple.Item2;
			Crc32 item3 = tuple.Item3;
			num = item.Read(buffer, offset, length);
			if (num > 0)
			{
				item3.HashBlock(buffer, offset, num);
				item2.Write(buffer, offset, num);
			}
		}
		while (num > 0);
	}

	public Task PutContentAsync(BinaryFile binaryFile, Stream content, PutContentOptions options = null)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			PutContentOptions putContentOptions;
			switch (num2)
			{
			case 1:
				putContentOptions = options;
				if (putContentOptions == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 3:
				ThrowIfWritingToPersistantFile(binaryFile);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				throw new NotImplementedException();
			default:
				putContentOptions = PutContentOptions.Default;
				break;
			}
			options = putContentOptions;
			num2 = 3;
		}
	}

	public string GetHash(BinaryFile binaryFile, HashAlogrithmEnum algorithm)
	{
		int num = 1;
		int num2 = num;
		SystemFile systemFile = default(SystemFile);
		while (true)
		{
			switch (num2)
			{
			default:
				return ((IStorageOperationsProvider)vEA5BFWCK9YpiBvQ6HPm(this)).GetContentHash(systemFile, algorithm);
			case 1:
				systemFile = (SystemFile)a2aauTWv2AY8dosjMeK7(SystemFileManager, HJV403WQz9oIxyeKZUoO(binaryFile));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public Task<string> GetHashAsync(BinaryFile binaryFile, HashAlogrithmEnum algorithm, CancellationToken token)
	{
		SystemFile systemFile = SystemFileManager.LoadFileRequired(binaryFile.Uid);
		return StorageOperationsProvider.GetContentHashAsync(systemFile, algorithm, token);
	}

	Uri IBinaryFileLegacyBehaviorProvider.InitializeContentLocation(BinaryFile binaryFile)
	{
		return new Uri(BinaryFile.CreateContentFilePath(binaryFile.Name));
	}

	long? IBinaryFileLegacyBehaviorProvider.GetLength(BinaryFile binaryFile)
	{
		long? result = null;
		Uri contentLocation = binaryFile.ContentLocation;
		string text = ((contentLocation != null && contentLocation.Scheme == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1765929262)) ? contentLocation.LocalPath : null);
		if (!text.IsNullOrEmpty())
		{
			FileInfo fileInfo = new FileInfo(text);
			if (fileInfo.Exists)
			{
				result = fileInfo.Length;
			}
		}
		return result;
	}

	uint? IBinaryFileLegacyBehaviorProvider.GetCrc(BinaryFile binaryFile)
	{
		uint? result = null;
		Uri contentLocation = binaryFile.ContentLocation;
		string text = ((contentLocation != null && contentLocation.Scheme == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488804301)) ? contentLocation.LocalPath : null);
		if (!text.IsNullOrEmpty() && new FileInfo(text).Exists)
		{
			result = Crc32.GetCrcValue(text);
		}
		return result;
	}

	public void Register(NHManagerRegisterParams parameters)
	{
		//Discarded unreachable code: IL_0097, IL_0113, IL_0153, IL_0162, IL_016e, IL_017d, IL_018d, IL_019c
		int num = 4;
		int num2 = num;
		IStartInformation startInformation = default(IStartInformation);
		while (true)
		{
			switch (num2)
			{
			case 2:
				startInformation = StartInformation.Operation(99.0, (string)sylKQXWveH3sZ0eGyJuU(zjGtgwWQH4ZdBdwcPAiW(-889460160 ^ -889568254)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return;
			case 4:
				if (!initialized)
				{
					num2 = 3;
					continue;
				}
				goto case 2;
			case 1:
				return;
			}
			try
			{
				aaPhOnWvPNOoYIOuVhAO(this, parameters);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						return;
					case 2:
						TqcEsVWvN5QeTkCskFMV(this, axH4XNWv11uPkL4IUtwA(parameters));
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num3 = 0;
						}
						break;
					case 1:
						RegisterExtendedBinaryFileProviders((ContainerBuilder)axH4XNWv11uPkL4IUtwA(parameters));
						num3 = 2;
						break;
					case 0:
						return;
					}
				}
			}
			finally
			{
				int num4;
				if (startInformation == null)
				{
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num4 = 1;
					}
					goto IL_0117;
				}
				goto IL_012d;
				IL_012d:
				IlWmTDWvIPVdgSQNhGwX(startInformation);
				num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num4 = 0;
				}
				goto IL_0117;
				IL_0117:
				switch (num4)
				{
				default:
					goto end_IL_00f2;
				case 2:
					break;
				case 1:
					goto end_IL_00f2;
				case 0:
					goto end_IL_00f2;
				}
				goto IL_012d;
				end_IL_00f2:;
			}
		}
	}

	protected virtual void RegisterManagers(NHManagerRegisterParams parameters)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				((ContainerBuilder)axH4XNWv11uPkL4IUtwA(parameters)).RegisterNHManager(k8UC08Wv34gfPyeouddv(typeof(SystemFileNHManager).TypeHandle)).As<SystemFileNHManager>().SingleInstance();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				parameters.Add<SystemFileMetadataMap>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void RegisterAdditionalServices(ContainerBuilder containerBuilder)
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
				RegistrationExtensions.RegisterInstance<FileSystemFileStoreProvider>(containerBuilder, this).As(new Type[2]
				{
					k8UC08Wv34gfPyeouddv(typeof(IFileGatewayService).TypeHandle),
					k8UC08Wv34gfPyeouddv(typeof(IBinaryFileHashService).TypeHandle)
				}).SingleInstance();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected virtual void RegisterExtendedBinaryFileProviders(ContainerBuilder containerBuilder)
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
				RegistrationExtensions.RegisterInstance<FileSystemFileStoreProvider>(containerBuilder, this).As(new Type[3]
				{
					k8UC08Wv34gfPyeouddv(typeof(IBinaryFileStreams).TypeHandle),
					k8UC08Wv34gfPyeouddv(typeof(IBinaryFileAsyncLoader).TypeHandle),
					k8UC08Wv34gfPyeouddv(typeof(IBinaryFileLegacyBehaviorProvider).TypeHandle)
				}).SingleInstance();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	string IFileGatewayService.GetClosestGateway()
	{
		return string.Empty;
	}

	string IFileGatewayService.GetUserGateway(IUser user)
	{
		return string.Empty;
	}

	void IFileGatewayService.SetUserGateway(IUser user, string gateway)
	{
	}

	static FileSystemFileStoreProvider()
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
				BxCLkOWQ6cNg7WloU7c4();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				notFoundExtensions = new string[18]
				{
					(string)zjGtgwWQH4ZdBdwcPAiW(-477139494 ^ -477221506),
					(string)zjGtgwWQH4ZdBdwcPAiW(-97972138 ^ -98021146),
					(string)zjGtgwWQH4ZdBdwcPAiW(0x31326106 ^ 0x313321B8),
					(string)zjGtgwWQH4ZdBdwcPAiW(0x63ABA4E8 ^ 0x63AA0A74),
					(string)zjGtgwWQH4ZdBdwcPAiW(-345420348 ^ -345447572),
					(string)zjGtgwWQH4ZdBdwcPAiW(-234299632 ^ -234262108),
					(string)zjGtgwWQH4ZdBdwcPAiW(-218496594 ^ -218387106),
					(string)zjGtgwWQH4ZdBdwcPAiW(-3333094 ^ -3298732),
					(string)zjGtgwWQH4ZdBdwcPAiW(0x6DC147B0 ^ 0x6DC07A0E),
					(string)zjGtgwWQH4ZdBdwcPAiW(-978351861 ^ -978400609),
					(string)zjGtgwWQH4ZdBdwcPAiW(-889460160 ^ -889530486),
					(string)zjGtgwWQH4ZdBdwcPAiW(-1837662597 ^ -1837743187),
					(string)zjGtgwWQH4ZdBdwcPAiW(-629844702 ^ -629905216),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576068604),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767638441),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487330554),
					(string)zjGtgwWQH4ZdBdwcPAiW(0x34A6D230 ^ 0x34A77CF0),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099644005)
				};
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void BxCLkOWQ6cNg7WloU7c4()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object zjGtgwWQH4ZdBdwcPAiW(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool agAHIXWQwPnKP7Csrxhf()
	{
		return asrIwLWQt4N0iq3l3VrP == null;
	}

	internal static FileSystemFileStoreProvider wkDxnQWQ4AF7FijOBYv3()
	{
		return asrIwLWQt4N0iq3l3VrP;
	}

	internal static bool Eg5apLWQApu3sMfYKK7y(object P_0)
	{
		return ((ILogger)P_0).IsDebugEnabled();
	}

	internal static object QMLaHHWQ7PNFBfRYdjiB(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static object OKX2EnWQxYL1v96cCmMl(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void AReyowWQ0Kckm3BpBhgN(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object cadO6IWQmTh6igQ0FFB5(object P_0, object P_1, object P_2)
	{
		return ((FileSystemFileStoreProvider)P_0).DoProviderSpecificInitialization((string)P_1, (NameValueCollection)P_2);
	}

	internal static void Kjcq2VWQyZ1AgRROCN04(object P_0, object P_1, object P_2)
	{
		((ProviderBase)P_0).Initialize((string)P_1, (NameValueCollection)P_2);
	}

	internal static bool uDS7aQWQMj4nE33ahKIX(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object OBV0MWWQJtY5GU8b8YwP(object P_0, object P_1)
	{
		return ((NameValueCollection)P_0)[(string)P_1];
	}

	internal static void eea7PgWQ9W5u1LQgRtWp(object P_0, object P_1)
	{
		((NameValueCollection)P_0).Remove((string)P_1);
	}

	internal static void PtcISBWQdV4ZSIfBirCv(object P_0, object P_1, object P_2)
	{
		((NameValueCollection)P_0).Add((string)P_1, (string)P_2);
	}

	internal static object r0xjxRWQlZbrlGoT2HGl()
	{
		return ComponentManager.Current;
	}

	internal static object QgPdWVWQrGEl5NMTRg33(object P_0)
	{
		return ((IRuntimeApplication)P_0).Configuration;
	}

	internal static object xjsSIEWQgCUavKVs2qUd(object P_0)
	{
		return ((RuntimeConfiguration)P_0).Config;
	}

	internal static object CWE5fZWQ5Gxf16FypDR8(object P_0)
	{
		return ((System.Configuration.Configuration)P_0).FilePath;
	}

	internal static object yOOQQWWQjwviuNyt7mgY(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static object Ty5XGhWQYVexiHXqAD85(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object gGWm3YWQL1xXAxg9YgPj(object P_0)
	{
		return IOExtensions.GetTempPath((string)P_0);
	}

	internal static bool B3eXXMWQU4Gcbuv26ElV(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object AeUo83WQsLGPb8rFOfWc(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object y5VjpYWQcdn8Pe1tkmNU(object P_0)
	{
		return ((FileSystemFileStoreProvider)P_0).CreateStorageOperationsProvider();
	}

	internal static Guid HJV403WQz9oIxyeKZUoO(object P_0)
	{
		return ((BinaryFile)P_0).Uid;
	}

	internal static void WRFrqaWCFPgyirfaRD6L(object P_0, Guid value)
	{
		((BinaryFile)P_0).Uid = value;
	}

	internal static object YLkZMkWCBWOSpCbBxbGX(object P_0)
	{
		return ((BinaryFile)P_0).Extension;
	}

	internal static object covDZxWCWMnUmd2s2G3O(object P_0, object P_1)
	{
		return ((IMimeMappingService)P_0).GetTypeByExtension((string)P_1);
	}

	internal static object pwPeWRWCoaDhEFeoegbE(object P_0)
	{
		return ((BinaryFile)P_0).Name;
	}

	internal static object oL6SFQWCbe6V3WoQImtX(object P_0)
	{
		return ((BinaryFile)P_0).Id;
	}

	internal static void s1YiV9WCh03a5CvOm5jA(object P_0, object P_1)
	{
		((BinaryFile)P_0).Id = (string)P_1;
	}

	internal static void txcOcZWCGCdx9v38TiTn(object P_0, object P_1)
	{
		((FileSystemFileStoreProvider)P_0).PreSaveActions((BinaryFile)P_1);
	}

	internal static Guid T6pqnWWCEyAkKEfZa5a6(object P_0)
	{
		return ((SystemFile)P_0).Uid;
	}

	internal static bool OHIHnqWCfZNEnMyPI1Li(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static DateTime k7TNmDWCQBPhhUd8TJIa(object P_0)
	{
		return ((BinaryFile)P_0).CreateDate;
	}

	internal static void eeZP1MWCCg1kShv0hCjy(object P_0, DateTime value)
	{
		((SystemFile)P_0).CreateDate = value;
	}

	internal static void a2P0npWCvx261HlQJK6r(object P_0, Guid value)
	{
		((SystemFile)P_0).Uid = value;
	}

	internal static void L4lLFUWC8UissaqMAKXj(object P_0, object P_1)
	{
		((SystemFile)P_0).Name = (string)P_1;
	}

	internal static object TjV9mtWCZeWsUixZb8fV(object P_0)
	{
		return ((BinaryFile)P_0).ContentType;
	}

	internal static void bVgMVJWCuPvX8OY39nqD(object P_0, object P_1)
	{
		((SystemFile)P_0).ContentType = (string)P_1;
	}

	internal static object GrcXM7WCIMLvc7IupXrB()
	{
		return CultureInfo.InvariantCulture;
	}

	internal static void R6dwNNWCVf2diMPf9UHA(object P_0, object P_1)
	{
		((SystemFile)P_0).FileCrc = (string)P_1;
	}

	internal static long Br8ooaWCS9BqIt9cMsTJ(object P_0)
	{
		return ((BinaryFile)P_0).GetSize();
	}

	internal static void xaoNSHWCi8egLXt5YXqA(object P_0, bool value)
	{
		((SystemFile)P_0).IsDeleted = value;
	}

	internal static int oj12U7WCRH9SGPDFp2eN(object P_0, object P_1)
	{
		return ((SystemFileNHManager)P_0).InsertFile((SystemFile)P_1);
	}

	internal static void gaC7jVWCq0IyFu0BFvCX(object P_0, int value)
	{
		((SystemFile)P_0).Id = value;
	}

	internal static object vEA5BFWCK9YpiBvQ6HPm(object P_0)
	{
		return ((FileSystemFileStoreProvider)P_0).StorageOperationsProvider;
	}

	internal static bool mmlTF3WCXLYQ8ZuPao98(object P_0)
	{
		return ((BinaryFile)P_0).DeleteTempFileAfterSave;
	}

	internal static void l7IbIgWCTSrVC5ALBFfM(object P_0, object P_1, object P_2)
	{
		((FileSystemFileStoreProvider)P_0).UpdateBinaryFileLocation((BinaryFile)P_1, (Uri)P_2);
	}

	internal static void At6vZoWCkT1pHQiWF9jx(object P_0, object P_1, object P_2)
	{
		((FileSystemFileStoreProvider)P_0).PostSaveActions((SystemFile)P_1, (BinaryFile)P_2);
	}

	internal static void c1oklHWCnYm6QcxofQWx(object P_0, bool value)
	{
		((BinaryFile)P_0).DeleteTempFileAfterSave = value;
	}

	internal static object CbicZdWCOAYPJglA3BX9(object P_0)
	{
		return ((FileEncryptData)P_0).Password;
	}

	internal static object R57rr5WC2c2bvo7qa0Cc(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void Hdj8quWCepXKdcnLt788(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void eGOmdNWCPS2Zot9ddNPt(object P_0, object P_1)
	{
		((BinaryFile)P_0).ContentLocation = (Uri)P_1;
	}

	internal static bool fJ2kkiWC16MbYk3rSP6V(object P_0)
	{
		return ((BinaryFile)P_0).Encrypt;
	}

	internal static object SYSpO6WCNZN0xTTRbZbw(object P_0, Guid uid)
	{
		return ((SystemFileNHManager)P_0).LoadFile(uid);
	}

	internal static Guid QMcLjVWC32j5wmxunVT5()
	{
		return Guid.NewGuid();
	}

	internal static void vGal2WWCpvMWavp4O4J2(object P_0, object P_1)
	{
		((FileEncryptData)P_0).Password = (string)P_1;
	}

	internal static void HTaVT0WCawwFGtejQ0QG(object P_0, object P_1)
	{
		MarkSystemFileAsEncrypt(P_0, P_1);
	}

	internal static uint SBd9ugWCDfbbwmcXsutl(object P_0)
	{
		return ((BinaryFileContentInfo)P_0).Crc;
	}

	internal static long lCTSG1WCtQSqGOCL8kYx(object P_0)
	{
		return ((BinaryFileContentInfo)P_0).ContentLength;
	}

	internal static object fhrfnCWCw0UO6lPqmLM8(object P_0, object P_1, object P_2)
	{
		return ((IStorageOperationsProvider)P_0).DecryptContent((SystemFile)P_1, (string)P_2);
	}

	internal static object pStENnWC4CRDcZUe0HQV(object P_0)
	{
		return BinaryFile.CreateFrom((BinaryFile)P_0);
	}

	internal static object RJvH4ZWC6PW8q8HVFpR3(object P_0)
	{
		return ((BinaryFileContentInfo)P_0).ContentLocation;
	}

	internal static object qUNSQxWCHxCZnsBAMhfP(object P_0, object P_1, long contentLength, uint contentCrc)
	{
		return ((BinaryFileBuilder)P_0).Content((Uri)P_1, contentLength, contentCrc);
	}

	internal static object p9YHHlWCAIrOcVOiF1ou(object P_0)
	{
		return ((BinaryFileBuilder)P_0).Build();
	}

	internal static void dDDj6sWC7VyxWvUwAssO(object P_0, object P_1)
	{
		((BinaryFile)P_0).Salt = (string)P_1;
	}

	internal static object hT53vMWCx73TXAwt4HID(object P_0, object P_1)
	{
		return ((FileStoreProvider)P_0).SaveFile((BinaryFile)P_1);
	}

	internal static void NFjQL3WC0r2TQwd7lkCq(object P_0, object P_1)
	{
		((SystemFile)P_0).Salt = (string)P_1;
	}

	internal static void quF5HyWCmL6KJGJkPSDL(object P_0, bool value)
	{
		((SystemFile)P_0).Encrypt = value;
	}

	internal static bool bnFO7VWCyuZEcc52N64A(object P_0, object P_1, object P_2)
	{
		return ((IFilePreviewService)P_0).CheckPassword((BinaryFile)P_1, (string)P_2);
	}

	internal static void J02i9oWCMUBBThx1UpS7(object P_0, object P_1, long priority)
	{
		((IFilePreviewService)P_0).AddPreviewWork((BinaryFile)P_1, priority);
	}

	internal static object up3qLTWCJBVts8sYkhWP(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool yUFHIyWC9XwUZdCpqfmR(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object Hbb4YVWCdQJJ8mq7Ev2T(object P_0, int id, object P_2)
	{
		return ((SystemFileNHManager)P_0).RenameFile(id, (string)P_2);
	}

	internal static object nqo3oSWClPPwrilrg1r7(object P_0)
	{
		return ((SystemFile)P_0).Name;
	}

	internal static object S5pgj4WCrY1iJHPJYJ58(object P_0, Guid uid)
	{
		return ((BinaryFileBuilder)P_0).Uid(uid);
	}

	internal static DateTime vYp6YCWCgb8bCrKZSDDA()
	{
		return DateTime.Now;
	}

	internal static bool Fa8ZhRWC5CnSDV2bivuD(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object FIZAfZWCjjJYcmSXrLnh(object P_0, object P_1)
	{
		return ((FileSystemFileStoreProvider)P_0).GetLoadedBinaryFile((string)P_1);
	}

	internal static object jKux5NWCYr5aSEPp4wFR(object P_0, object P_1)
	{
		return ((FileStoreProvider)P_0).LoadFile((string)P_1);
	}

	internal static object tohkq6WCLVIHB31MrHkI(object P_0)
	{
		return ((BinaryFile)P_0).ContentLocation;
	}

	internal static object huER4TWCUvlbox2RUcoD(object P_0, object P_1)
	{
		return ((FileSystemFileStoreProvider)P_0).LoadFilesNonLazy((string[])P_1);
	}

	internal static object DTFihWWCs4atIbbrkCR8(object P_0)
	{
		return ((List<long>)P_0).ToArray();
	}

	internal static object qVvdB1WCcffclfB4vIy6(object P_0, object P_1, object P_2)
	{
		return ((SystemFileNHManager)P_0).LoadFiles((long[])P_1, (Guid[])P_2);
	}

	internal static object hnOHIjWCzdwsQddAn7m9(object P_0)
	{
		return ((SystemFile)P_0).ContentType;
	}

	internal static void YdEy3VWvFkkiUOLFO09A(object P_0, object P_1)
	{
		((BinaryFile)P_0).ContentType = (string)P_1;
	}

	internal static void bsbVPXWvBSIYW5ICSIvC(object P_0, DateTime value)
	{
		((BinaryFile)P_0).CreateDate = value;
	}

	internal static void fAqpjDWvWewJN4csDtLC(object P_0, object P_1)
	{
		((BinaryFile)P_0).Name = (string)P_1;
	}

	internal static int IqiKf4WvoNJ4MuIlpmb1(object P_0)
	{
		return ((SystemFile)P_0).Id;
	}

	internal static void qbJdV6WvbpEGr4SETEY3(object P_0, object P_1)
	{
		((BinaryFile)P_0).SecondId = (string)P_1;
	}

	internal static object Vn8WHPWvh5XyX5PmHRco(object P_0)
	{
		return ((List<BinaryFile>)P_0).ToArray();
	}

	internal static object YFO3VNWvGXX1bqq2NT5s(object P_0, object P_1)
	{
		return ((SystemFileNHManager)P_0).LoadFile((string)P_1);
	}

	internal static long mydxOpWvE10sEZWa3w4J(object P_0, object P_1)
	{
		return ((FileSystemFileStoreProvider)P_0).GetFileLength((SystemFile)P_1);
	}

	internal static object CLUaO8WvfTVd5RYLLBSg(object P_0)
	{
		return ((string)P_0).ReplaceInvalidFileNameChars();
	}

	internal static object FEAe4oWvQgIRbIjGRnrp(object P_0)
	{
		return Path.GetExtension((string)P_0);
	}

	internal static long TsB4VpWvCyTnG0oeBxup(object P_0)
	{
		return GetNotFoundStubSize((string)P_0);
	}

	internal static object XglHwnWvvNl280IEDor8(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static bool Yd4ShhWv8fHaRx2SLOkN(object P_0)
	{
		return ((FileSystemInfo)P_0).Exists;
	}

	internal static object OlxEENWvZDgqeAKDnZM2(object P_0)
	{
		return ((FileInfo)P_0).Create();
	}

	internal static object v19nRHWvu8fdHDxjcjCl(object P_0, object P_1)
	{
		return ((ResourceManager)P_0).GetObject((string)P_1);
	}

	internal static void IlWmTDWvIPVdgSQNhGwX(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object Wq1aPwWvViH6Qxh6aTtr()
	{
		return Resources.ResourceManager;
	}

	internal static object EAebepWvS6uyQKtvhfHw(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Remove(P_1, P_2);
	}

	internal static object CSUkmTWvipjPCPb3okLT(object P_0, object P_1)
	{
		return ((IStorageOperationsProvider)P_0).GetSourceContentLocation((SystemFile)P_1);
	}

	internal static bool ylLctpWvRMyaIenxPscI(object P_0)
	{
		return ((string)P_0).IsNullOrEmpty();
	}

	internal static bool UmXqvQWvq36flwwha90M(object P_0)
	{
		return ((GetContentOptions)P_0).ForAsync;
	}

	internal static bool eLF0OyWvK1nXCl2Fi38e(object P_0)
	{
		return ((GetContentOptions)P_0).Seekable;
	}

	internal static object mnBLaTWvXydwkOOdiPnV(object P_0)
	{
		return ((Crc32)P_0).HashFinalBlock();
	}

	internal static long L0Ki8KWvTckRO7CtM0rx(object P_0)
	{
		return ((Stream)P_0).Position;
	}

	internal static void CDf1pFWvkjsIrOKCN8B6(object P_0, long contentLength)
	{
		((BinaryFile)P_0).SetSize(contentLength);
	}

	internal static uint echXVSWvnnnoWUYZU9Dm(object P_0)
	{
		return ((Crc32)P_0).CrcValue;
	}

	internal static void nxdiSCWvOeJ3E9IXmqAd(object P_0, uint contentCrc)
	{
		((BinaryFile)P_0).SetCrc(contentCrc);
	}

	internal static object a2aauTWv2AY8dosjMeK7(object P_0, Guid uid)
	{
		return ((SystemFileNHManager)P_0).LoadFileRequired(uid);
	}

	internal static object sylKQXWveH3sZ0eGyJuU(object P_0)
	{
		return SR.M((string)P_0);
	}

	internal static void aaPhOnWvPNOoYIOuVhAO(object P_0, object P_1)
	{
		((FileSystemFileStoreProvider)P_0).RegisterManagers((NHManagerRegisterParams)P_1);
	}

	internal static object axH4XNWv11uPkL4IUtwA(object P_0)
	{
		return ((NHManagerRegisterParams)P_0).Builder;
	}

	internal static void TqcEsVWvN5QeTkCskFMV(object P_0, object P_1)
	{
		((FileSystemFileStoreProvider)P_0).RegisterAdditionalServices((ContainerBuilder)P_1);
	}

	internal static Type k8UC08Wv34gfPyeouddv(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
