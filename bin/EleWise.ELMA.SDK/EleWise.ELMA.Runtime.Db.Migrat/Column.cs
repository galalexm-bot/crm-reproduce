using System;
using System.Data;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Migrator.Framework;

public class Column : IColumn
{
	private static Column Y2bu0qWO5beuE8EtyEWJ;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
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

	public ColumnType ColumnType
	{
		[CompilerGenerated]
		get
		{
			return _003CColumnType_003Ek__BackingField;
		}
		[CompilerGenerated]
		protected set
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
					_003CColumnType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
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

	public ColumnProperty ColumnProperty
	{
		[CompilerGenerated]
		get
		{
			return _003CColumnProperty_003Ek__BackingField;
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
					_003CColumnProperty_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
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

	public object DefaultValue
	{
		[CompilerGenerated]
		get
		{
			return _003CDefaultValue_003Ek__BackingField;
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
					_003CDefaultValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
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

	public bool IsIdentity => (ColumnProperty & ColumnProperty.Identity) == ColumnProperty.Identity;

	public bool IsPrimaryKey => (ColumnProperty & ColumnProperty.PrimaryKey) == ColumnProperty.PrimaryKey;

	protected Column()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GldsXxWOLCw9gdRrcPXN();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
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
			ColumnType = new ColumnType(DbType.AnsiString);
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
			{
				num = 1;
			}
		}
	}

	public Column(string name)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GldsXxWOLCw9gdRrcPXN();
		this._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
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
			Name = name;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
			{
				num = 1;
			}
		}
	}

	public Column(string name, DbType type)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GldsXxWOLCw9gdRrcPXN();
		this._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				ColumnType.DataType = type;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num = 2;
				}
				break;
			case 2:
				return;
			default:
				Name = name;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public Column(string name, DbType type, int size)
	{
		//Discarded unreachable code: IL_001e
		GldsXxWOLCw9gdRrcPXN();
		this._002Ector();
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				ColumnType.Length = size;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 3:
				Name = name;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				ColumnType.DataType = type;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public Column(string name, DbType type, object defaultValue)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		GldsXxWOLCw9gdRrcPXN();
		this._002Ector(name, type);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				DefaultValue = defaultValue;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public Column(string name, DbType type, ColumnProperty property)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		GldsXxWOLCw9gdRrcPXN();
		this._002Ector(name, type);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
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
			ColumnProperty = property;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
			{
				num = 0;
			}
		}
	}

	public Column(string name, DbType type, int size, ColumnProperty property)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		GldsXxWOLCw9gdRrcPXN();
		this._002Ector(name, type, size);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				ColumnProperty = property;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public Column(string name, DbType type, int size, ColumnProperty property, object defaultValue)
	{
		//Discarded unreachable code: IL_001d, IL_0022
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(name, type, size);
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				DefaultValue = defaultValue;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			case 2:
				ColumnProperty = property;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public Column(string name, DbType type, ColumnProperty property, object defaultValue)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		GldsXxWOLCw9gdRrcPXN();
		this._002Ector(name, type);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				DefaultValue = defaultValue;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num = 1;
				}
				break;
			default:
				ColumnProperty = property;
				num = 2;
				break;
			case 1:
				return;
			}
		}
	}

	public Column(string name, ColumnType type)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GldsXxWOLCw9gdRrcPXN();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334996947));
			case 3:
				ColumnType = type;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num = 2;
				}
				continue;
			case 2:
				return;
			}
			if (type != null)
			{
				Name = name;
				num = 3;
				continue;
			}
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
			{
				num = 0;
			}
		}
	}

	public Column(string name, ColumnType type, ColumnProperty property)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		GldsXxWOLCw9gdRrcPXN();
		this._002Ector(name, type);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
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
			ColumnProperty = property;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
			{
				num = 1;
			}
		}
	}

	public Column(string name, ColumnType type, object defaultValue)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		GldsXxWOLCw9gdRrcPXN();
		this._002Ector(name, type);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
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
			DefaultValue = defaultValue;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
			{
				num = 1;
			}
		}
	}

	public Column(string name, ColumnType type, ColumnProperty property, object defaultValue)
	{
		//Discarded unreachable code: IL_001c, IL_0021
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(name, type);
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				ColumnProperty = property;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num = 1;
				}
				break;
			case 1:
				DefaultValue = defaultValue;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void SetColumnType(ColumnType type)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (type != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 3:
				return;
			default:
				throw new ArgumentNullException((string)Mv19qPWOUP2XOVMB4xsS(-867826612 ^ -867825554));
			case 1:
				ColumnType = type;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void GldsXxWOLCw9gdRrcPXN()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool tIP54QWOj4oa2L5NFQH8()
	{
		return Y2bu0qWO5beuE8EtyEWJ == null;
	}

	internal static Column ADS9F5WOYcuJDcMbFOgc()
	{
		return Y2bu0qWO5beuE8EtyEWJ;
	}

	internal static object Mv19qPWOUP2XOVMB4xsS(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
