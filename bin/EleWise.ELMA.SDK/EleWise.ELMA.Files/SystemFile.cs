using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Files;

[Serializable]
public class SystemFile
{
	public static class Tables
	{
		public static class Fields
		{
			public const string Id = "Id";

			public const string Uid = "Uid";

			public const string Name = "Name";

			public const string ContentType = "ContentType";

			public const string CreateDate = "CreateDate";

			public const string FileCRC = "CRC";

			public const string FileSize = "FileSize";

			public const string Salt = "Salt";

			public const string Encrypt = "Encrypt";

			public const string IsDeleted = "IsDeleted";
		}

		public const string TableName = "FS_FILES";
	}

	private Guid _uid;

	private int _id;

	private string _name;

	private string _contentType;

	private DateTime _createDate;

	private string _fileCrc;

	private long? _fileSize;

	private string _salt;

	private bool _encrypt;

	private bool _isDeleted;

	private static SystemFile UCAw5kGk0ZyM26XVpqMG;

	public virtual Guid Uid
	{
		get
		{
			return _uid;
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
					_uid = value;
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

	public virtual int Id
	{
		get
		{
			return _id;
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
					_id = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual string Name
	{
		get
		{
			return _name;
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
					_name = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual string ContentType
	{
		get
		{
			return _contentType;
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
					_contentType = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
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

	public virtual DateTime CreateDate
	{
		get
		{
			return _createDate;
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
					_createDate = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual string FileCrc
	{
		get
		{
			return _fileCrc;
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
					_fileCrc = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
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

	public virtual long? FileSize
	{
		get
		{
			return _fileSize;
		}
		set
		{
			_fileSize = value;
		}
	}

	public virtual string Salt
	{
		get
		{
			return _salt;
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
					_salt = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
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
			return _encrypt;
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
					_encrypt = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual bool IsDeleted
	{
		get
		{
			return _isDeleted;
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
					_isDeleted = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
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

	public SystemFile()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IrpayhGkMuOWmmC2PbJ5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool P8IC5iGkmd8rbxkkviMN()
	{
		return UCAw5kGk0ZyM26XVpqMG == null;
	}

	internal static SystemFile Q7FOfKGky2SuCeuMRf1d()
	{
		return UCAw5kGk0ZyM26XVpqMG;
	}

	internal static void IrpayhGkMuOWmmC2PbJ5()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
