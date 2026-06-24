using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files;

[Serializable]
public class BinaryFile : ICloneable
{
	private uint? contentCrc;

	private long? contentLength;

	private static IBinaryFileLegacyBehaviorProvider binaryFileLegacyBehaviorProvider;

	private string extension;

	[OptionalField]
	private string secondId;

	[OptionalField]
	private string salt;

	[OptionalField]
	private bool encrypt;

	private Guid uid;

	protected string name;

	private static BinaryFile bncyCBGkJYbSGNq53DEJ;

	private static IBinaryFileLegacyBehaviorProvider BinaryFileLegacyBehaviorProvider
	{
		get
		{
			int num = 1;
			int num2 = num;
			IBinaryFileLegacyBehaviorProvider obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = binaryFileLegacyBehaviorProvider;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = (binaryFileLegacyBehaviorProvider = Locator.GetServiceNotNull<IBinaryFileLegacyBehaviorProvider>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return _003CId_003Ek__BackingField;
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
					_003CId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual string SecondId
	{
		get
		{
			return secondId;
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
					secondId = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual Guid Uid
	{
		get
		{
			return uid;
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
					uid = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
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

	public virtual string Salt
	{
		get
		{
			return salt;
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
					salt = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual bool Encrypt
	{
		get
		{
			return encrypt;
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
					encrypt = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
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

	public virtual string Name
	{
		get
		{
			return name;
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
					FhMFQ1GkYyptP8QC45Fr(this, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					if (GmswjgGkjyNfDaLMPrQ9(name, value))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				case 2:
					return;
				}
			}
		}
	}

	public virtual string ContentType
	{
		[CompilerGenerated]
		get
		{
			return _003CContentType_003Ek__BackingField;
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
					_003CContentType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
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

	[Obsolete("Свойство устарело. Для доступа к контенту используйте BinaryFile.GetContent(). Для установки контента рекомендуется создать новый файл через BinaryFile.CreateNew() или BinaryFile.CreateFrom().")]
	public virtual string ContentFilePath
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
					return null;
				case 1:
					if (!G06u02GkL6XcV2Ou8R2E(ContentLocation, null))
					{
						return (string)ODsIBfGksmA2xE3KFR5l(c3YU3DGkUUjAigFkmUxy(this));
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_00db, IL_00ea, IL_00fa, IL_0109
			int num = 7;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 7:
					if (xCLl9CGkcMmjLxfeRIA1(value))
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 1;
				default:
					contentLength = 0L;
					num2 = 5;
					break;
				case 1:
					SetContentFilePath(value);
					num2 = 3;
					break;
				case 4:
				case 6:
					odWmfFGkzSGPE3B1LvBh(this, null);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 1;
					}
					break;
				case 8:
					contentCrc = 0u;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
				case 5:
					NjLHN2GkrH87GEx6JOZg(this, false);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}
	}

	public virtual DateTime CreateDate
	{
		[CompilerGenerated]
		get
		{
			return _003CCreateDate_003Ek__BackingField;
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
					_003CCreateDate_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual bool DeleteTempFileAfterSave
	{
		[CompilerGenerated]
		get
		{
			return _003CDeleteTempFileAfterSave_003Ek__BackingField;
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
					_003CDeleteTempFileAfterSave_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual Uri ContentLocation
	{
		[CompilerGenerated]
		get
		{
			return _003CContentLocation_003Ek__BackingField;
		}
		[CompilerGenerated]
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
				case 1:
					_003CContentLocation_003Ek__BackingField = value;
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

	public virtual string Extension
	{
		get
		{
			//Discarded unreachable code: IL_004a, IL_0059
			int num = 3;
			int num2 = num;
			string text = default(string);
			while (true)
			{
				string text2;
				switch (num2)
				{
				case 3:
					if (D1EJOAGnOyOHTah34uSD(this) == null)
					{
						num2 = 2;
						break;
					}
					goto default;
				case 4:
					text = (extension = (string)vm2xKNGneZTdvndSDEHu(A4KBnjGn2CK8m6pbj9m6(D1EJOAGnOyOHTah34uSD(this))));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 1;
					}
					break;
				default:
					text2 = extension;
					if (text2 == null)
					{
						num2 = 4;
						break;
					}
					goto IL_00b0;
				case 1:
					text2 = text;
					goto IL_00b0;
				case 2:
					{
						return string.Empty;
					}
					IL_00b0:
					return text2;
				}
			}
		}
	}

	public BinaryFile()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sggpSvGklnsbvuyKaQ47();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
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
				uid = Guid.Empty;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public BinaryFile(string contentFilePath)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		sggpSvGklnsbvuyKaQ47();
		this._002Ector(contentFilePath, deleteAfterSave: false);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public BinaryFile(string contentFilePath, bool deleteAfterSave)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				contentCrc = CrTHGIGk5QyhimKBHORY(contentFilePath);
				num = 4;
				break;
			case 2:
				contentLength = rcM9yaGkgm7i8F5xQEL3(new FileInfo(contentFilePath));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num = 1;
				}
				break;
			case 3:
				ContentLocation = new Uri(contentFilePath);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num = 0;
				}
				break;
			case 4:
				return;
			default:
				NjLHN2GkrH87GEx6JOZg(this, deleteAfterSave);
				num = 2;
				break;
			}
		}
	}

	[Obsolete("Свойство устарело. Для доступа к контенту используйте BinaryFile.GetContent(). Для установки контента рекомендуется создать новый файл через BinaryFile.CreateNew() или BinaryFile.CreateFrom().")]
	public virtual void InitializeContentFilePath()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				odWmfFGkzSGPE3B1LvBh(this, ((IBinaryFileLegacyBehaviorProvider)I2X3b2GnFtBx7teSN05y()).InitializeContentLocation(this));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				NjLHN2GkrH87GEx6JOZg(this, true);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public static string CreateContentFilePath(string originalFileName)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_00d2
		int num = 5;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 1:
					text = (string)vpwiZkGnBYFpZEBm7fN7(0x6A81B9B4 ^ 0x6A80DA62);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					if (!string.IsNullOrEmpty(text))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				default:
					return (string)CNuaarGnWXFCfZ6FDYml(text);
				case 5:
					if (!xCLl9CGkcMmjLxfeRIA1(originalFileName))
					{
						obj = Path.GetExtension(originalFileName.ReplaceInvalidFileNameChars());
						break;
					}
					goto end_IL_0012;
				case 4:
					obj = null;
					break;
				}
				text = (string)obj;
				num2 = 2;
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	[Obsolete("Метод устарел. Для передачи контента в BinaryFile используйте метод IBinaryFileStreams.PutContent().", true)]
	public virtual void SetContentFilePath(string contentFilePath, bool deleteTempFileAfterSave = false)
	{
		//Discarded unreachable code: IL_0056, IL_00b3, IL_00d2, IL_00e1, IL_010e, IL_011d
		int num = 1;
		int num2 = num;
		FileStream fileStream = default(FileStream);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				fileStream = new FileStream(contentFilePath, FileMode.Open, FileAccess.Read);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				((IBinaryFileStreams)zeUfELGnoUuQF5WIFPEn()).PutContent(this, (Stream)fileStream, PutContentOptions.Default);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						return;
					}
					NjLHN2GkrH87GEx6JOZg(this, deleteTempFileAfterSave);
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num3 = 1;
					}
				}
			}
			finally
			{
				int num4;
				if (fileStream == null)
				{
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num4 = 0;
					}
					goto IL_00b7;
				}
				goto IL_00ec;
				IL_00ec:
				D0Al7qGnbr5TK0BwkvEr(fileStream);
				num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num4 = 1;
				}
				goto IL_00b7;
				IL_00b7:
				switch (num4)
				{
				default:
					goto end_IL_0092;
				case 0:
					goto end_IL_0092;
				case 2:
					break;
				case 1:
					goto end_IL_0092;
				}
				goto IL_00ec;
				end_IL_0092:;
			}
		}
	}

	public static BinaryFileBuilder CreateFrom(BinaryFile templateFile)
	{
		return new BinaryFileBuilder(templateFile);
	}

	public static BinaryFileBuilder CreateNew()
	{
		return new BinaryFileBuilder();
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_00a1, IL_00d8, IL_0176, IL_0198
		int num = 10;
		int num2 = num;
		Guid? guid5 = default(Guid?);
		Guid? guid2 = default(Guid?);
		Guid? guid4 = default(Guid?);
		BinaryFile binaryFile = default(BinaryFile);
		while (true)
		{
			Guid? guid3;
			Guid? guid;
			switch (num2)
			{
			case 1:
				if (guid5.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto IL_013c;
			case 5:
				guid2 = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 12;
				}
				continue;
			case 6:
				if (guid4.HasValue)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto IL_013c;
			case 12:
				guid3 = guid2;
				goto IL_01be;
			case 10:
				binaryFile = obj as BinaryFile;
				num2 = 9;
				continue;
			case 3:
				return false;
			case 4:
				if (!KiveHhGnhLJpqekh3CnX(this))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 5;
					}
					continue;
				}
				guid3 = GIJ1nBGnG91klSo60Rra(this);
				goto IL_01be;
			case 11:
				guid2 = null;
				num2 = 13;
				continue;
			default:
				return iii9svGnQcikZLMiDMg0(guid4.Value, guid5.Value);
			case 2:
				return true;
			case 7:
				if (fJZRdLGnfauBr0pYCy0r(zGjIOuGnELXHtUQb4Zft(binaryFile), Id))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 6;
			case 9:
				if (binaryFile != null)
				{
					num2 = 4;
					continue;
				}
				goto case 3;
			case 13:
				guid = guid2;
				break;
			case 8:
				{
					if (!KiveHhGnhLJpqekh3CnX(binaryFile))
					{
						num2 = 11;
						continue;
					}
					guid = binaryFile.Uid;
					break;
				}
				IL_01be:
				guid4 = guid3;
				num2 = 8;
				continue;
				IL_013c:
				return false;
			}
			guid5 = guid;
			num2 = 7;
		}
	}

	public override string ToString()
	{
		return Name;
	}

	public virtual bool Rename(string fileName)
	{
		//Discarded unreachable code: IL_00d0, IL_015e, IL_016d, IL_01d3
		int num = 10;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 14:
					return true;
				default:
					return true;
				case 8:
					name = fileName;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 7;
					}
					break;
				case 12:
					name = fileName;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 11;
					}
					break;
				case 10:
					if (JcXLp0GnCm5mNpbiN84Z(fileName))
					{
						num2 = 9;
						break;
					}
					fileName = (string)QxjMipGnvZfrbs5OVwgO(fileName);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 16;
					}
					break;
				case 1:
					fileName = (string)k0FhggGnueo9WagmjTu4(H0bkdeGnZwofyKpYGFud(), Id, fileName);
					num2 = 2;
					break;
				case 6:
					return true;
				case 15:
					if (Id == null)
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num2 = 8;
						}
						break;
					}
					goto case 1;
				case 7:
					extension = null;
					num2 = 6;
					break;
				case 5:
					return true;
				case 4:
					return false;
				case 13:
					name = fileName;
					num2 = 3;
					break;
				case 11:
					extension = null;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 5;
					}
					break;
				case 2:
					if (JcXLp0GnCm5mNpbiN84Z(fileName))
					{
						goto end_IL_0012;
					}
					goto case 12;
				case 16:
					if (!MttZKWGn83k3t6034CBU(fileName, name, StringComparison.CurrentCulture))
					{
						if (name != null)
						{
							num2 = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
							{
								num2 = 15;
							}
							break;
						}
						goto case 8;
					}
					num2 = 14;
					break;
				case 3:
					extension = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
					break;
				case 9:
					throw new ArgumentNullException((string)vpwiZkGnBYFpZEBm7fN7(0x638095EB ^ 0x6380EBF1));
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public virtual BinaryFile Clone()
	{
		//Discarded unreachable code: IL_005d, IL_00dc
		int num = 6;
		int num2 = num;
		BinaryFileBuilder binaryFileBuilder = default(BinaryFileBuilder);
		Uri contentLocation = default(Uri);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
			{
				object obj2 = O9GfVUGnXGaquNEqqjMk(binaryFileBuilder);
				Iui8ZRGnTNAaNLSQEUlO(obj2, Id);
				CURIBEGnntAe80lpHCEn(obj2, NnOUQgGnkBLCQN9rIJ2W(this));
				return (BinaryFile)obj2;
			}
			case 6:
				contentLocation = ContentLocation;
				num2 = 5;
				continue;
			case 5:
				binaryFileBuilder = (BinaryFileBuilder)oBJnL1GnIeQqrajBEx8f(this);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 3;
				}
				continue;
			case 3:
				if (!aK4Ym9GnVeDIou8IAoKs(contentLocation, null))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 4;
			case 1:
				obj = DDOw4hGnqx2FYEtdmU7T(binaryFileBuilder, contentLocation, DkyXCcGni7ef3UfQhu5m(this), GOuybZGnRNUwPEimZC86(this));
				break;
			case 4:
				if (!f2rkkeGnSMZE3ASVDIJn(this))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				obj = binaryFileBuilder.Content(GetContent(GetContentOptions.NonSeekable), autoCloseStream: true, (string)D3UrGZGnKshCnTNBTvRR(this));
				break;
			}
			binaryFileBuilder = (BinaryFileBuilder)obj;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
			{
				num2 = 0;
			}
		}
	}

	public virtual Stream GetContent(GetContentOptions options = null)
	{
		return ((IBinaryFileStreams)zeUfELGnoUuQF5WIFPEn()).GetContent(this, options);
	}

	public virtual long GetSize()
	{
		//Discarded unreachable code: IL_00a4, IL_00b3
		int num = 2;
		int num2 = num;
		long? length = default(long?);
		while (true)
		{
			switch (num2)
			{
			default:
				return length.Value;
			case 3:
				if (!contentLength.HasValue)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					break;
				}
				return contentLength.Value;
			case 2:
				length = ((IBinaryFileLegacyBehaviorProvider)I2X3b2GnFtBx7teSN05y()).GetLength(this);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (!length.HasValue)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 4:
				throw new InvalidOperationException(SR.T((string)vpwiZkGnBYFpZEBm7fN7(-1824388195 ^ -1824396701), Id));
			}
		}
	}

	internal void SetSize(long contentLength)
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
				this.contentLength = contentLength;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual uint GetCrc()
	{
		//Discarded unreachable code: IL_00b4
		int num = 2;
		int num2 = num;
		uint? crc = default(uint?);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return crc.Value;
			case 1:
				if (!crc.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 3;
			case 2:
				crc = ((IBinaryFileLegacyBehaviorProvider)I2X3b2GnFtBx7teSN05y()).GetCrc(this);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				throw new InvalidOperationException(SR.T((string)vpwiZkGnBYFpZEBm7fN7(-951514650 ^ -951391304), Id));
			}
			if (!contentCrc.HasValue)
			{
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			return contentCrc.Value;
		}
	}

	internal void SetCrc(uint contentCrc)
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
				this.contentCrc = contentCrc;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected virtual bool IsLoaded()
	{
		return true;
	}

	object ICloneable.Clone()
	{
		return Uv2A0YGnPFv5DCXVRmCo(this);
	}

	protected static uint ParseCrc(string crcStringValue)
	{
		//Discarded unreachable code: IL_0054, IL_0063
		int num = 2;
		int num2 = num;
		uint result = default(uint);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (uint.TryParse(crcStringValue, out result))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				throw new InvalidDataException((string)jrx14SGn1ynnNJKX2ac1(vpwiZkGnBYFpZEBm7fN7(0x4DC2B14D ^ 0x4DC317E9)));
			case 1:
				return result;
			}
		}
	}

	internal virtual void CheckLoaded(bool loadFile = false)
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
				CheckLoadedImpl(loadFile);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void CheckLoadedImpl(bool loadFile = false)
	{
	}

	internal static bool AIJknsGk9kkHXCMF8DeZ()
	{
		return bncyCBGkJYbSGNq53DEJ == null;
	}

	internal static BinaryFile Gi5LyjGkdpAerrWEJMa0()
	{
		return bncyCBGkJYbSGNq53DEJ;
	}

	internal static void sggpSvGklnsbvuyKaQ47()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void NjLHN2GkrH87GEx6JOZg(object P_0, bool value)
	{
		((BinaryFile)P_0).DeleteTempFileAfterSave = value;
	}

	internal static long rcM9yaGkgm7i8F5xQEL3(object P_0)
	{
		return ((FileInfo)P_0).Length;
	}

	internal static uint CrTHGIGk5QyhimKBHORY(object P_0)
	{
		return Crc32.GetCrcValue((string)P_0);
	}

	internal static bool GmswjgGkjyNfDaLMPrQ9(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static bool FhMFQ1GkYyptP8QC45Fr(object P_0, object P_1)
	{
		return ((BinaryFile)P_0).Rename((string)P_1);
	}

	internal static bool G06u02GkL6XcV2Ou8R2E(object P_0, object P_1)
	{
		return (Uri)P_0 == (Uri)P_1;
	}

	internal static object c3YU3DGkUUjAigFkmUxy(object P_0)
	{
		return ((BinaryFile)P_0).ContentLocation;
	}

	internal static object ODsIBfGksmA2xE3KFR5l(object P_0)
	{
		return ((Uri)P_0).LocalPath;
	}

	internal static bool xCLl9CGkcMmjLxfeRIA1(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void odWmfFGkzSGPE3B1LvBh(object P_0, object P_1)
	{
		((BinaryFile)P_0).ContentLocation = (Uri)P_1;
	}

	internal static object I2X3b2GnFtBx7teSN05y()
	{
		return BinaryFileLegacyBehaviorProvider;
	}

	internal static object vpwiZkGnBYFpZEBm7fN7(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object CNuaarGnWXFCfZ6FDYml(object P_0)
	{
		return IOExtensions.GetTempFileName((string)P_0);
	}

	internal static object zeUfELGnoUuQF5WIFPEn()
	{
		return DataAccessManager.BinaryFileStreams;
	}

	internal static void D0Al7qGnbr5TK0BwkvEr(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool KiveHhGnhLJpqekh3CnX(object P_0)
	{
		return ((BinaryFile)P_0).IsLoaded();
	}

	internal static Guid GIJ1nBGnG91klSo60Rra(object P_0)
	{
		return ((BinaryFile)P_0).Uid;
	}

	internal static object zGjIOuGnELXHtUQb4Zft(object P_0)
	{
		return ((BinaryFile)P_0).Id;
	}

	internal static bool fJZRdLGnfauBr0pYCy0r(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool iii9svGnQcikZLMiDMg0(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool JcXLp0GnCm5mNpbiN84Z(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object QxjMipGnvZfrbs5OVwgO(object P_0)
	{
		return ((string)P_0).ReplaceControlCharacters();
	}

	internal static bool MttZKWGn83k3t6034CBU(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static object H0bkdeGnZwofyKpYGFud()
	{
		return DataAccessManager.FileManager;
	}

	internal static object k0FhggGnueo9WagmjTu4(object P_0, object P_1, object P_2)
	{
		return ((IFileManager)P_0).RenameFile((string)P_1, (string)P_2);
	}

	internal static object oBJnL1GnIeQqrajBEx8f(object P_0)
	{
		return CreateFrom((BinaryFile)P_0);
	}

	internal static bool aK4Ym9GnVeDIou8IAoKs(object P_0, object P_1)
	{
		return (Uri)P_0 != (Uri)P_1;
	}

	internal static bool f2rkkeGnSMZE3ASVDIJn(object P_0)
	{
		return ((BinaryFile)P_0).DeleteTempFileAfterSave;
	}

	internal static long DkyXCcGni7ef3UfQhu5m(object P_0)
	{
		return ((BinaryFile)P_0).GetSize();
	}

	internal static uint GOuybZGnRNUwPEimZC86(object P_0)
	{
		return ((BinaryFile)P_0).GetCrc();
	}

	internal static object DDOw4hGnqx2FYEtdmU7T(object P_0, object P_1, long contentLength, uint contentCrc)
	{
		return ((BinaryFileBuilder)P_0).Content((Uri)P_1, contentLength, contentCrc);
	}

	internal static object D3UrGZGnKshCnTNBTvRR(object P_0)
	{
		return ((BinaryFile)P_0).Extension;
	}

	internal static object O9GfVUGnXGaquNEqqjMk(object P_0)
	{
		return ((BinaryFileBuilder)P_0).Build();
	}

	internal static void Iui8ZRGnTNAaNLSQEUlO(object P_0, object P_1)
	{
		((BinaryFile)P_0).Id = (string)P_1;
	}

	internal static object NnOUQgGnkBLCQN9rIJ2W(object P_0)
	{
		return ((BinaryFile)P_0).SecondId;
	}

	internal static void CURIBEGnntAe80lpHCEn(object P_0, object P_1)
	{
		((BinaryFile)P_0).SecondId = (string)P_1;
	}

	internal static object D1EJOAGnOyOHTah34uSD(object P_0)
	{
		return ((BinaryFile)P_0).Name;
	}

	internal static object A4KBnjGn2CK8m6pbj9m6(object P_0)
	{
		return ((string)P_0).ReplaceInvalidFileNameChars();
	}

	internal static object vm2xKNGneZTdvndSDEHu(object P_0)
	{
		return Path.GetExtension((string)P_0);
	}

	internal static object Uv2A0YGnPFv5DCXVRmCo(object P_0)
	{
		return ((BinaryFile)P_0).Clone();
	}

	internal static object jrx14SGn1ynnNJKX2ac1(object P_0)
	{
		return SR.T((string)P_0);
	}
}
