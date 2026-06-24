using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db;

[Serializable]
public class DbStructure
{
	public enum ExecuteTime
	{
		OnBeforeStart,
		OnStart,
		OnTriggersDeleted,
		OnProceduresDeleted,
		OnViewsDeleted,
		OnIndexesDeleted,
		OnForeignKeysDeleted,
		OnPrimaryKeysDeleted,
		OnTablesCreating,
		OnTablesCreated,
		OnTablesDeleting,
		OnTablesDeleted,
		OnForeignKeysCreated,
		OnPrimaryKeysCreated,
		OnIndexesCreated,
		OnViewsCreated,
		OnProceduresCreated,
		OnTriggersCreated,
		OnComplete
	}

	public interface IDbText
	{
		string Text { get; set; }
	}

	public interface IDbMappings
	{
		string Mappings { get; set; }
	}

	[Serializable]
	public class DbTable
	{
		private string name;

		private string description;

		private string module;

		private SerializableDictionary<string, DbColumn> columns;

		private SerializableDictionary<string, DbForeignKey> foreignKeys;

		private List<string> ignoreVersions;

		private static DbTable gYvDqZQaiPBqskv7PyKi;

		public string Name
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
						return;
					case 0:
						return;
					case 1:
						name = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Description
		{
			get
			{
				return description;
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
						description = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Module
		{
			get
			{
				return module;
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
						module = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
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

		public SerializableDictionary<string, DbColumn> Columns => columns;

		public SerializableDictionary<string, DbForeignKey> ForeignKeys => foreignKeys;

		public DbColumn PrimaryColumn
		{
			get
			{
				//Discarded unreachable code: IL_005a, IL_0069, IL_0074, IL_00e0, IL_0152, IL_0165, IL_0174
				int num = 2;
				int num2 = num;
				Dictionary<string, DbColumn>.ValueCollection.Enumerator enumerator = default(Dictionary<string, DbColumn>.ValueCollection.Enumerator);
				DbColumn current = default(DbColumn);
				DbColumn result = default(DbColumn);
				while (true)
				{
					switch (num2)
					{
					case 2:
						enumerator = columns.Values.GetEnumerator();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
						try
						{
							while (true)
							{
								IL_0100:
								int num3;
								if (!enumerator.MoveNext())
								{
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
									{
										num3 = 2;
									}
									goto IL_0078;
								}
								goto IL_00b8;
								IL_00b8:
								current = enumerator.Current;
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
								{
									num3 = 1;
								}
								goto IL_0078;
								IL_0078:
								while (true)
								{
									switch (num3)
									{
									case 5:
										result = current;
										num3 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
										{
											num3 = 3;
										}
										continue;
									case 1:
										if (current.PrimaryKey)
										{
											num3 = 5;
											continue;
										}
										goto IL_0100;
									case 4:
										goto IL_0100;
									case 2:
										goto end_IL_0100;
									case 3:
										return result;
									}
									break;
								}
								goto IL_00b8;
								continue;
								end_IL_0100:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							case 0:
								break;
							}
						}
						break;
					}
					break;
				}
				return null;
			}
		}

		public List<string> IgnoreVersions
		{
			get
			{
				return ignoreVersions;
			}
			set
			{
				ignoreVersions = value;
			}
		}

		public DbTable()
		{
			//Discarded unreachable code: IL_005a, IL_005f
			HyP0cvQaKZ1ypbWMDfWH();
			columns = new SerializableDictionary<string, DbColumn>();
			foreignKeys = new SerializableDictionary<string, DbForeignKey>();
			ignoreVersions = new List<string>();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool cZHO9OQaR1MfRE6qOQbY()
		{
			return gYvDqZQaiPBqskv7PyKi == null;
		}

		internal static DbTable jhxVFsQaqO0pPYZMiEAK()
		{
			return gYvDqZQaiPBqskv7PyKi;
		}

		internal static void HyP0cvQaKZ1ypbWMDfWH()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	[Serializable]
	public class DbColumn
	{
		private string name;

		private string description;

		private string type;

		private bool notNull;

		private bool primaryKey;

		private bool uniqueKey;

		private int stringFieldLength;

		private string defVal;

		private string index;

		private string afterCreation;

		private List<string> ignoreVersions;

		internal static DbColumn lXYpW1QaXa1TKmkGkOvo;

		public string Name
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
						return;
					case 1:
						name = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
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

		public string Description
		{
			get
			{
				return description;
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
						description = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Type
		{
			get
			{
				return type;
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
						type = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool NotNull
		{
			get
			{
				return notNull;
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
						notNull = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
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

		public bool PrimaryKey
		{
			get
			{
				return primaryKey;
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
						primaryKey = value;
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

		public bool UniqueKey
		{
			get
			{
				return uniqueKey;
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
						uniqueKey = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
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

		public int StringFieldLength
		{
			get
			{
				return stringFieldLength;
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
						stringFieldLength = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
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

		public string DefaultValue
		{
			get
			{
				return defVal;
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
						defVal = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Index
		{
			get
			{
				return index;
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
						index = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string AfterCreation
		{
			get
			{
				return afterCreation;
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
						afterCreation = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
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

		public List<string> IgnoreVersions
		{
			get
			{
				return ignoreVersions;
			}
			set
			{
				ignoreVersions = value;
			}
		}

		public DbColumn()
		{
			//Discarded unreachable code: IL_004a, IL_004f
			PhxHbrQanfGdc2XLuc9E();
			stringFieldLength = 255;
			ignoreVersions = new List<string>();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool cclJoiQaTlM3Ix5JCBgw()
		{
			return lXYpW1QaXa1TKmkGkOvo == null;
		}

		internal static DbColumn lKIxDYQak9gMrWSpOsAu()
		{
			return lXYpW1QaXa1TKmkGkOvo;
		}

		internal static void PhxHbrQanfGdc2XLuc9E()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	[Serializable]
	public class DbForeignKey
	{
		private string name;

		private string keyColumn;

		private string refTable;

		private string refColumn;

		private string onDelete;

		private string alteraction;

		private List<string> ignoreVersions;

		internal static DbForeignKey Ypwcd1QaOqFtAg2F5CKh;

		public string Name
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
						return;
					case 1:
						name = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
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

		public string KeyColumn
		{
			get
			{
				return keyColumn;
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
						keyColumn = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
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

		public string RefTable
		{
			get
			{
				return refTable;
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
						refTable = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
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

		public string RefColumn
		{
			get
			{
				return refColumn;
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
						refColumn = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string OnDelete
		{
			get
			{
				return onDelete;
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
						onDelete = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
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

		public string AlterAction
		{
			get
			{
				return alteraction;
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
						alteraction = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public List<string> IgnoreVersions
		{
			get
			{
				return ignoreVersions;
			}
			set
			{
				ignoreVersions = value;
			}
		}

		public DbForeignKey()
		{
			//Discarded unreachable code: IL_003a, IL_003f
			vladEfQaPoTmXrTQ2WQ9();
			ignoreVersions = new List<string>();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool XdMtpdQa2aVwyVGw6haJ()
		{
			return Ypwcd1QaOqFtAg2F5CKh == null;
		}

		internal static DbForeignKey OyFYxoQaevfyPMePaw1I()
		{
			return Ypwcd1QaOqFtAg2F5CKh;
		}

		internal static void vladEfQaPoTmXrTQ2WQ9()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	[Serializable]
	public class DbView : IDbText, IDbMappings
	{
		private string name;

		private string text;

		private string mappings;

		private List<string> ignoreVersions;

		internal static DbView YQLbx2Qa1S8qWqNurgWq;

		public string Name
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
						return;
					case 0:
						return;
					case 1:
						name = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Text
		{
			get
			{
				return text;
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
						text = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Mappings
		{
			get
			{
				return mappings;
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
						mappings = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
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

		public List<string> IgnoreVersions
		{
			get
			{
				return ignoreVersions;
			}
			set
			{
				ignoreVersions = value;
			}
		}

		public DbView()
		{
			//Discarded unreachable code: IL_003a, IL_003f
			OMhhlgQapEoix3bKyHIT();
			ignoreVersions = new List<string>();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool hV6ToYQaN34iKGQUQMbG()
		{
			return YQLbx2Qa1S8qWqNurgWq == null;
		}

		internal static DbView KpJ5AnQa3tvtDAtkpStY()
		{
			return YQLbx2Qa1S8qWqNurgWq;
		}

		internal static void OMhhlgQapEoix3bKyHIT()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	[Serializable]
	public class DbTrigger : IDbText
	{
		private string name;

		private string text;

		private List<string> ignoreVersions;

		internal static DbTrigger OcA3p9QaaZxXwvpBMkuC;

		public string Name
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
						return;
					case 1:
						name = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
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

		public string Text
		{
			get
			{
				return text;
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
						text = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public List<string> IgnoreVersions
		{
			get
			{
				return ignoreVersions;
			}
			set
			{
				ignoreVersions = value;
			}
		}

		public DbTrigger()
		{
			//Discarded unreachable code: IL_003a, IL_003f
			fN0KBBQawsG3TRGAiLGG();
			ignoreVersions = new List<string>();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool iNO0RIQaDRRjeq1hNCw1()
		{
			return OcA3p9QaaZxXwvpBMkuC == null;
		}

		internal static DbTrigger Ldg2mPQatpFHuq1DagJN()
		{
			return OcA3p9QaaZxXwvpBMkuC;
		}

		internal static void fN0KBBQawsG3TRGAiLGG()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	[Serializable]
	public class DbScript : IDbText
	{
		private string name;

		private ExecuteTime executeTime;

		private bool alwaysExecute;

		private string text;

		private List<string> ignoreVersions;

		private List<string> executeVersions;

		private bool onDeactivate;

		private static DbScript RZpGDUQa4OO7l9UeTbSK;

		public string Name
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
						return;
					case 0:
						return;
					case 1:
						name = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ExecuteTime ExecuteTime
		{
			get
			{
				return executeTime;
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
						executeTime = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool AlwaysExecute
		{
			get
			{
				return alwaysExecute;
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
						alwaysExecute = value;
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

		public string Text
		{
			get
			{
				return text;
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
						text = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
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

		public List<string> IgnoreVersions
		{
			get
			{
				return ignoreVersions;
			}
			set
			{
				ignoreVersions = value;
			}
		}

		public List<string> ExecuteVersions
		{
			get
			{
				return executeVersions;
			}
			set
			{
				executeVersions = value;
			}
		}

		public bool OnDeactivate
		{
			get
			{
				return onDeactivate;
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
						onDeactivate = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
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

		public string TransformationInVersion
		{
			[CompilerGenerated]
			get
			{
				return _003CTransformationInVersion_003Ek__BackingField;
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
						_003CTransformationInVersion_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
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

		public DbScript()
		{
			//Discarded unreachable code: IL_004a, IL_004f
			SingletonReader.JJCZtPuTvSt();
			ignoreVersions = new List<string>();
			executeVersions = new List<string>();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool bs6OkZQa6OMfmgGhN3VU()
		{
			return RZpGDUQa4OO7l9UeTbSK == null;
		}

		internal static DbScript wNmCw0QaHZUux3NMcuYM()
		{
			return RZpGDUQa4OO7l9UeTbSK;
		}
	}

	[Serializable]
	public class DbProcedure : IDbText, IDbMappings
	{
		private string name;

		private string text;

		private string mappings;

		private List<string> ignoreVersions;

		private static DbProcedure c8h1ALQaA3QRj4JWq3mW;

		public string Name
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
						return;
					case 0:
						return;
					case 1:
						name = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Text
		{
			get
			{
				return text;
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
						text = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Mappings
		{
			get
			{
				return mappings;
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
						mappings = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
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

		public List<string> IgnoreVersions
		{
			get
			{
				return ignoreVersions;
			}
			set
			{
				ignoreVersions = value;
			}
		}

		public DbProcedure()
		{
			//Discarded unreachable code: IL_003a, IL_003f
			bpxcfEQa0AcuX3QMtvTv();
			ignoreVersions = new List<string>();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool Flavb0Qa7ekDRBhR4XJq()
		{
			return c8h1ALQaA3QRj4JWq3mW == null;
		}

		internal static DbProcedure JqruF9QaxNClMgFV08UB()
		{
			return c8h1ALQaA3QRj4JWq3mW;
		}

		internal static void bpxcfEQa0AcuX3QMtvTv()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	[Serializable]
	public class UserMethod
	{
		private string name;

		private bool alwaysExecute;

		private string method;

		private ExecuteTime executeTime;

		private List<string> ignoreVersions;

		private object methodExecutor;

		private bool onDeactivate;

		private static UserMethod PbebKuQamfwkmqjIqBJc;

		public string Name
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
						return;
					case 1:
						name = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
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

		public bool AlwaysExecute
		{
			get
			{
				return alwaysExecute;
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
						alwaysExecute = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
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

		public string Method
		{
			get
			{
				return method;
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
						method = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ExecuteTime ExecuteTime
		{
			get
			{
				return executeTime;
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
						executeTime = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public List<string> IgnoreVersions
		{
			get
			{
				return ignoreVersions;
			}
			set
			{
				ignoreVersions = value;
			}
		}

		public object MethodExecutor
		{
			get
			{
				return methodExecutor;
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
						methodExecutor = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
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

		public bool OnDeactivate
		{
			get
			{
				return onDeactivate;
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
						onDeactivate = value;
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

		public string TransformationInVersion
		{
			[CompilerGenerated]
			get
			{
				return _003CTransformationInVersion_003Ek__BackingField;
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
						_003CTransformationInVersion_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public UserMethod()
		{
			//Discarded unreachable code: IL_003a, IL_003f
			twbZSvQaJ4LFvZAZuAuQ();
			ignoreVersions = new List<string>();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool rycZOOQayF5EQ3dW2iBV()
		{
			return PbebKuQamfwkmqjIqBJc == null;
		}

		internal static UserMethod EJw8AiQaM9ZMPGSW1uuJ()
		{
			return PbebKuQamfwkmqjIqBJc;
		}

		internal static void twbZSvQaJ4LFvZAZuAuQ()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	[Serializable]
	public class DbIndex : IDbText
	{
		private string name;

		private string tableName;

		private string text;

		private bool isUnique;

		private List<string> columns;

		private List<string> ignoreVersions;

		private List<string> executeVersions;

		private bool onDeactivate;

		internal static DbIndex sUF1hNQa9tlWitFh1OQB;

		public string Name
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
						return;
					case 0:
						return;
					case 1:
						name = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string TableName
		{
			get
			{
				return tableName;
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
						tableName = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
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

		public ExecuteTime ExecuteTime => ExecuteTime.OnIndexesCreated;

		public bool AlwaysExecute => true;

		public string Text
		{
			get
			{
				return text;
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
						text = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool IsUnique
		{
			get
			{
				return isUnique;
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
						isUnique = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public List<string> Columns
		{
			get
			{
				return columns;
			}
			set
			{
				columns = value;
			}
		}

		public List<string> IgnoreVersions
		{
			get
			{
				return ignoreVersions;
			}
			set
			{
				ignoreVersions = value;
			}
		}

		public List<string> ExecuteVersions
		{
			get
			{
				return executeVersions;
			}
			set
			{
				executeVersions = value;
			}
		}

		public DbIndex()
		{
			//Discarded unreachable code: IL_005a, IL_005f
			up1Jf2QarFKkpPXX3SHp();
			columns = new List<string>();
			ignoreVersions = new List<string>();
			executeVersions = new List<string>();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool tTgSsbQadEQ0fgPVum1Y()
		{
			return sUF1hNQa9tlWitFh1OQB == null;
		}

		internal static DbIndex vrKLKKQal7em7rUlT6ds()
		{
			return sUF1hNQa9tlWitFh1OQB;
		}

		internal static void up1Jf2QarFKkpPXX3SHp()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private string xml;

	private object methodExecutor;

	private Guid uid;

	private SerializableDictionary<string, DbTable> tables;

	private SerializableDictionary<string, DbView> views;

	private SerializableDictionary<string, DbTrigger> triggers;

	private SerializableDictionary<string, DbScript> scripts;

	private SerializableDictionary<string, DbProcedure> procedures;

	private SerializableDictionary<string, UserMethod> methods;

	private SerializableDictionary<string, DbIndex> indexes;

	internal static DbStructure REK1TFWuip1GeydpvaOw;

	public bool Deactivating
	{
		[CompilerGenerated]
		get
		{
			return _003CDeactivating_003Ek__BackingField;
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
					_003CDeactivating_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Xml => xml;

	public object MethodExecutor => methodExecutor;

	public Guid Uid => uid;

	public SerializableDictionary<string, DbTable> Tables => tables;

	public SerializableDictionary<string, DbView> Views => views;

	public SerializableDictionary<string, DbTrigger> Triggers
	{
		get
		{
			return triggers;
		}
		set
		{
			triggers = value;
		}
	}

	public SerializableDictionary<string, DbScript> Scripts
	{
		get
		{
			return scripts;
		}
		set
		{
			scripts = value;
		}
	}

	public SerializableDictionary<string, DbProcedure> Procedures => procedures;

	public SerializableDictionary<string, UserMethod> Methods
	{
		get
		{
			return methods;
		}
		set
		{
			methods = value;
		}
	}

	public SerializableDictionary<string, DbIndex> Indexes
	{
		get
		{
			return indexes;
		}
		set
		{
			indexes = value;
		}
	}

	public DbStructure()
	{
		//Discarded unreachable code: IL_009a, IL_009f
		ioi9jIWuKC0cWo9G7nv0();
		tables = new SerializableDictionary<string, DbTable>();
		views = new SerializableDictionary<string, DbView>();
		triggers = new SerializableDictionary<string, DbTrigger>();
		scripts = new SerializableDictionary<string, DbScript>();
		procedures = new SerializableDictionary<string, DbProcedure>();
		methods = new SerializableDictionary<string, UserMethod>();
		indexes = new SerializableDictionary<string, DbIndex>();
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

	public DbStructure(string xml, object methodExecutor)
	{
		//Discarded unreachable code: IL_009a, IL_009f
		SingletonReader.JJCZtPuTvSt();
		tables = new SerializableDictionary<string, DbTable>();
		views = new SerializableDictionary<string, DbView>();
		triggers = new SerializableDictionary<string, DbTrigger>();
		scripts = new SerializableDictionary<string, DbScript>();
		procedures = new SerializableDictionary<string, DbProcedure>();
		methods = new SerializableDictionary<string, UserMethod>();
		indexes = new SerializableDictionary<string, DbIndex>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				iB13pWWuXpI0KQIW6T42(this);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num = 1;
				}
				break;
			case 3:
				this.methodExecutor = methodExecutor;
				num = 2;
				break;
			default:
				this.xml = xml;
				num = 3;
				break;
			case 1:
				return;
			}
		}
	}

	public static DbStructure Merge(IEnumerable<DbStructure> structures)
	{
		DbStructure dbStructure = new DbStructure();
		if (structures != null)
		{
			foreach (DbStructure structure in structures)
			{
				dbStructure.Merge(structure);
			}
			return dbStructure;
		}
		return dbStructure;
	}

	public void Merge(DbStructure structure)
	{
		//Discarded unreachable code: IL_00a2, IL_012f, IL_01d8, IL_01e7, IL_0231, IL_0244, IL_0254, IL_0263, IL_0327, IL_0336, IL_03a0, IL_044e, IL_045d, IL_04c4, IL_04d7, IL_04e6, IL_0529, IL_05c2, IL_06ab, IL_06be, IL_06f5, IL_0704, IL_070f, IL_073a, IL_0749, IL_081d, IL_0830, IL_083f, IL_087c, IL_091c, IL_092b, IL_09e8, IL_09f7, IL_0a21, IL_0aaf, IL_0ac2, IL_0ad2, IL_0ae1, IL_0aec, IL_0b2f, IL_0b3e, IL_0c1f, IL_0c2e, IL_0c69, IL_0c78, IL_0cd0, IL_0ce3, IL_0d0a, IL_0d19, IL_0d24, IL_0dcb, IL_0e32, IL_0e45, IL_0e54
		int num = 3;
		Dictionary<string, DbTable>.Enumerator enumerator = default(Dictionary<string, DbTable>.Enumerator);
		Dictionary<string, UserMethod>.Enumerator enumerator2 = default(Dictionary<string, UserMethod>.Enumerator);
		KeyValuePair<string, UserMethod> current4 = default(KeyValuePair<string, UserMethod>);
		Dictionary<string, DbView>.Enumerator enumerator7 = default(Dictionary<string, DbView>.Enumerator);
		DbView value3 = default(DbView);
		KeyValuePair<string, DbView> current7 = default(KeyValuePair<string, DbView>);
		Dictionary<string, DbScript>.Enumerator enumerator3 = default(Dictionary<string, DbScript>.Enumerator);
		Dictionary<string, DbIndex>.Enumerator enumerator6 = default(Dictionary<string, DbIndex>.Enumerator);
		KeyValuePair<string, DbIndex> current6 = default(KeyValuePair<string, DbIndex>);
		DbIndex value2 = default(DbIndex);
		Dictionary<string, DbTrigger>.Enumerator enumerator5 = default(Dictionary<string, DbTrigger>.Enumerator);
		KeyValuePair<string, DbTrigger> current5 = default(KeyValuePair<string, DbTrigger>);
		Dictionary<string, DbProcedure>.Enumerator enumerator4 = default(Dictionary<string, DbProcedure>.Enumerator);
		KeyValuePair<string, DbProcedure> current3 = default(KeyValuePair<string, DbProcedure>);
		DbProcedure value = default(DbProcedure);
		KeyValuePair<string, DbScript> current2 = default(KeyValuePair<string, DbScript>);
		KeyValuePair<string, DbTable> current = default(KeyValuePair<string, DbTable>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					return;
				case 8:
					return;
				case 14:
					enumerator = structure.Tables.GetEnumerator();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
					try
					{
						while (true)
						{
							int num10;
							if (!enumerator2.MoveNext())
							{
								num10 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
								{
									num10 = 1;
								}
								goto IL_00b0;
							}
							goto IL_01f2;
							IL_01f2:
							current4 = enumerator2.Current;
							num10 = 4;
							goto IL_00b0;
							IL_00b0:
							while (true)
							{
								switch (num10)
								{
								case 4:
									if (!Methods.ContainsKey(current4.Key))
									{
										num10 = 7;
										continue;
									}
									break;
								default:
									Methods.Add(current4.Key, current4.Value);
									num10 = 5;
									continue;
								case 9:
									if (trEqLFWuTgY9LLxMO2Ua(structure))
									{
										num10 = 2;
										continue;
									}
									goto case 6;
								case 7:
									if (trEqLFWuTgY9LLxMO2Ua(structure))
									{
										num10 = 3;
										continue;
									}
									goto case 9;
								case 3:
									if (PDSUGZWuksG5xdbGYRd6(current4.Value))
									{
										num10 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
										{
											num10 = 0;
										}
										continue;
									}
									goto case 9;
								case 6:
									if (!PDSUGZWuksG5xdbGYRd6(current4.Value))
									{
										int num11 = 8;
										num10 = num11;
										continue;
									}
									break;
								case 2:
								case 5:
									break;
								case 10:
									goto IL_01f2;
								case 1:
									goto end_IL_01ad;
								}
								break;
							}
							continue;
							end_IL_01ad:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num12 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num12 = 0;
						}
						switch (num12)
						{
						case 0:
							break;
						}
					}
					goto case 10;
				case 9:
					try
					{
						while (true)
						{
							IL_03dd:
							int num18;
							if (!enumerator7.MoveNext())
							{
								num18 = 7;
								goto IL_026e;
							}
							goto IL_02ff;
							IL_03f7:
							if (!H4b3BlWu2X3AsLUHZf3D(dH4hJdWupYieB3MmHhax(value3)))
							{
								continue;
							}
							num18 = 11;
							goto IL_026e;
							IL_02ff:
							current7 = enumerator7.Current;
							int num19 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
							{
								num19 = 13;
							}
							goto IL_0272;
							IL_026e:
							num19 = num18;
							goto IL_0272;
							IL_0272:
							while (true)
							{
								switch (num19)
								{
								case 4:
									if (string.IsNullOrEmpty((string)WK9nYVWuNgpnFWkSQXMV(current7.Value)))
									{
										num19 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
										{
											num19 = 9;
										}
										continue;
									}
									goto case 10;
								case 12:
									if (string.IsNullOrEmpty((string)WK9nYVWuNgpnFWkSQXMV(value3)))
									{
										num19 = 4;
										continue;
									}
									goto IL_03f7;
								case 5:
									break;
								case 10:
									FXEwPVWu3hnhcWgn5yJm(value3, WK9nYVWuNgpnFWkSQXMV(current7.Value));
									num19 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
									{
										num19 = 1;
									}
									continue;
								case 3:
									value3.Mappings = (string)dH4hJdWupYieB3MmHhax(current7.Value);
									num19 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
									{
										num19 = 0;
									}
									continue;
								case 13:
									if (!Views.TryGetValue(current7.Key, out value3))
									{
										num19 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
										{
											num19 = 2;
										}
										continue;
									}
									goto case 12;
								default:
									goto IL_03dd;
								case 1:
								case 9:
									goto IL_03f7;
								case 2:
									Views.Add(current7.Key, current7.Value);
									num19 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
									{
										num19 = 1;
									}
									continue;
								case 11:
									if (H4b3BlWu2X3AsLUHZf3D(dH4hJdWupYieB3MmHhax(current7.Value)))
									{
										num19 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
										{
											num19 = 8;
										}
										continue;
									}
									goto case 3;
								case 7:
									goto end_IL_03dd;
								}
								break;
							}
							goto IL_02ff;
							continue;
							end_IL_03dd:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator7).Dispose();
						int num20 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num20 = 0;
						}
						switch (num20)
						{
						case 0:
							break;
						}
					}
					goto case 15;
				case 10:
					enumerator3 = structure.Scripts.GetEnumerator();
					num2 = 11;
					continue;
				case 5:
					break;
				case 12:
					try
					{
						while (true)
						{
							int num16;
							if (!enumerator6.MoveNext())
							{
								int num15 = 4;
								num16 = num15;
								goto IL_0537;
							}
							goto IL_062f;
							IL_0537:
							while (true)
							{
								switch (num16)
								{
								case 4:
									return;
								case 1:
									if (!Indexes.TryGetValue(current6.Key, out value2))
									{
										num16 = 2;
										continue;
									}
									goto case 3;
								case 3:
									if (H4b3BlWu2X3AsLUHZf3D(wp6hOnWuaa8J28UVjc2b(value2)))
									{
										num16 = 6;
										continue;
									}
									break;
								case 2:
									Indexes.Add(current6.Key, current6.Value);
									num16 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
									{
										num16 = 5;
									}
									continue;
								case 6:
									if (!H4b3BlWu2X3AsLUHZf3D(current6.Value.Text))
									{
										num16 = 5;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
										{
											num16 = 7;
										}
										continue;
									}
									break;
								case 8:
									goto IL_062f;
								case 7:
									pQmXFxWuDy0KUIbW4U9O(value2, wp6hOnWuaa8J28UVjc2b(current6.Value));
									num16 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
									{
										num16 = 0;
									}
									continue;
								}
								break;
							}
							continue;
							IL_062f:
							current6 = enumerator6.Current;
							num16 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
							{
								num16 = 1;
							}
							goto IL_0537;
						}
					}
					finally
					{
						((IDisposable)enumerator6).Dispose();
						int num17 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
						{
							num17 = 0;
						}
						switch (num17)
						{
						case 0:
							break;
						}
					}
				case 1:
					enumerator5 = structure.Triggers.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					try
					{
						while (true)
						{
							IL_0767:
							int num13;
							if (!enumerator5.MoveNext())
							{
								num13 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
								{
									num13 = 3;
								}
								goto IL_0713;
							}
							goto IL_0754;
							IL_0754:
							current5 = enumerator5.Current;
							num13 = 4;
							goto IL_0713;
							IL_0713:
							while (true)
							{
								switch (num13)
								{
								case 5:
									break;
								case 1:
								case 2:
									goto IL_0767;
								case 4:
									if (Triggers.ContainsKey(current5.Key))
									{
										num13 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
										{
											num13 = 1;
										}
										continue;
									}
									goto default;
								default:
									Triggers.Add(current5.Key, current5.Value);
									num13 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
									{
										num13 = 2;
									}
									continue;
								case 3:
									goto end_IL_0767;
								}
								break;
							}
							goto IL_0754;
							continue;
							end_IL_0767:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator5).Dispose();
						int num14 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num14 = 0;
						}
						switch (num14)
						{
						case 0:
							break;
						}
					}
					break;
				case 15:
					enumerator6 = structure.Indexes.GetEnumerator();
					num2 = 12;
					continue;
				case 6:
					if (!trEqLFWuTgY9LLxMO2Ua(structure))
					{
						enumerator4 = structure.Procedures.GetEnumerator();
						num2 = 13;
					}
					else
					{
						num2 = 7;
					}
					continue;
				case 13:
					try
					{
						while (true)
						{
							int num7;
							if (!enumerator4.MoveNext())
							{
								num7 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
								{
									num7 = 1;
								}
								goto IL_088a;
							}
							goto IL_09a9;
							IL_09a9:
							current3 = enumerator4.Current;
							num7 = 6;
							goto IL_088a;
							IL_088a:
							while (true)
							{
								int num8;
								switch (num7)
								{
								case 3:
								case 5:
								case 9:
									break;
								case 8:
									N7XCXRWu1xDkMid83fLe(value, ds3cB6WuPDJU63hAHwx3(current3.Value));
									num8 = 9;
									goto IL_0886;
								case 13:
									Procedures.Add(current3.Key, current3.Value);
									num7 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
									{
										num7 = 3;
									}
									continue;
								case 7:
									if (H4b3BlWu2X3AsLUHZf3D(gOhQLsWuOsXErWNKWeRV(current3.Value)))
									{
										num7 = 4;
										continue;
									}
									goto case 2;
								default:
									if (!H4b3BlWu2X3AsLUHZf3D(ds3cB6WuPDJU63hAHwx3(current3.Value)))
									{
										num7 = 8;
										continue;
									}
									break;
								case 14:
									goto IL_09a9;
								case 6:
									if (Procedures.TryGetValue(current3.Key, out value))
									{
										num8 = 10;
										goto IL_0886;
									}
									goto case 13;
								case 4:
								case 12:
									if (!H4b3BlWu2X3AsLUHZf3D(ds3cB6WuPDJU63hAHwx3(value)))
									{
										num7 = 5;
										continue;
									}
									goto default;
								case 2:
									hvcA37WueBmlPlq5l0F6(value, gOhQLsWuOsXErWNKWeRV(current3.Value));
									num7 = 12;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
									{
										num7 = 8;
									}
									continue;
								case 10:
								case 11:
									if (H4b3BlWu2X3AsLUHZf3D(gOhQLsWuOsXErWNKWeRV(value)))
									{
										num7 = 7;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
										{
											num7 = 3;
										}
										continue;
									}
									goto case 4;
								case 1:
									goto end_IL_08d0;
									IL_0886:
									num7 = num8;
									continue;
								}
								break;
							}
							continue;
							end_IL_08d0:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator4).Dispose();
						int num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num9 = 0;
						}
						switch (num9)
						{
						case 0:
							break;
						}
					}
					goto case 14;
				case 11:
					try
					{
						while (true)
						{
							IL_0bf4:
							int num5;
							if (!enumerator3.MoveNext())
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
								{
									num5 = 6;
								}
								goto IL_0af0;
							}
							goto IL_0b7c;
							IL_0b7c:
							current2 = enumerator3.Current;
							num5 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
							{
								num5 = 2;
							}
							goto IL_0af0;
							IL_0af0:
							while (true)
							{
								switch (num5)
								{
								default:
									Scripts.Add(current2.Key, current2.Value);
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
									{
										num5 = 0;
									}
									continue;
								case 10:
									break;
								case 5:
									if (kMXXyVWunp8oC5mn5VMC(current2.Value))
									{
										num5 = 11;
										continue;
									}
									goto default;
								case 9:
									if (trEqLFWuTgY9LLxMO2Ua(structure))
									{
										num5 = 5;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
										{
											num5 = 7;
										}
										continue;
									}
									goto case 8;
								case 8:
									if (trEqLFWuTgY9LLxMO2Ua(structure))
									{
										num5 = 3;
										continue;
									}
									goto case 5;
								case 1:
								case 3:
								case 11:
									goto IL_0bf4;
								case 7:
									if (current2.Value.OnDeactivate)
									{
										num5 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
										{
											num5 = 4;
										}
										continue;
									}
									goto case 8;
								case 2:
									if (!Scripts.ContainsKey(current2.Key))
									{
										num5 = 9;
										continue;
									}
									goto IL_0bf4;
								case 6:
									goto end_IL_0bf4;
								}
								break;
							}
							goto IL_0b7c;
							continue;
							end_IL_0bf4:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 6;
				case 3:
					enumerator2 = structure.Methods.GetEnumerator();
					num2 = 2;
					continue;
				case 4:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
								{
									num3 = 1;
								}
								goto IL_0d28;
							}
							goto IL_0da3;
							IL_0da3:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
							{
								num3 = 0;
							}
							goto IL_0d28;
							IL_0d28:
							while (true)
							{
								switch (num3)
								{
								case 2:
									Tables.Add(current.Key, current.Value);
									num3 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
									{
										num3 = 1;
									}
									continue;
								case 3:
								case 4:
									break;
								case 5:
									goto IL_0da3;
								default:
									if (Tables.ContainsKey(current.Key))
									{
										num3 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
										{
											num3 = 3;
										}
										continue;
									}
									goto case 2;
								case 1:
									goto end_IL_0d7d;
								}
								break;
							}
							continue;
							end_IL_0d7d:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 1;
				}
				break;
			}
			enumerator7 = structure.Views.GetEnumerator();
			num = 9;
		}
	}

	public void ApplyDescriptions(DbStructure descr)
	{
		//Discarded unreachable code: IL_0052, IL_0061, IL_006c, IL_013c, IL_0176, IL_0185, IL_01c1, IL_0229, IL_0238, IL_024b, IL_025a, IL_0342, IL_0355, IL_03c7, IL_03d6, IL_040d, IL_0420
		int num = 2;
		int num2 = num;
		Dictionary<string, DbTable>.ValueCollection.Enumerator enumerator = default(Dictionary<string, DbTable>.ValueCollection.Enumerator);
		DbTable current = default(DbTable);
		DbTable value = default(DbTable);
		Dictionary<string, DbColumn>.ValueCollection.Enumerator enumerator2 = default(Dictionary<string, DbColumn>.ValueCollection.Enumerator);
		DbColumn current2 = default(DbColumn);
		DbColumn value2 = default(DbColumn);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (descr == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				enumerator = descr.Tables.Values.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				return;
			case 3:
				return;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 12;
						goto IL_0070;
					}
					goto IL_03af;
					IL_0070:
					while (true)
					{
						switch (num3)
						{
						case 7:
							if (!tables.TryGetValue((string)UL6griWutes0x4AGY86U(current.Name), out value))
							{
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto default;
						case 14:
							NsmOIaWu4ffWds0N5pmA(value, ajoLFkWuwmxu4XxyL2C0(current));
							num3 = 6;
							continue;
						case 1:
							if (H4b3BlWu2X3AsLUHZf3D(ajoLFkWuwmxu4XxyL2C0(current)))
							{
								num3 = 13;
								continue;
							}
							goto case 14;
						case 5:
						case 8:
							break;
						case 6:
						case 13:
							if (!H4b3BlWu2X3AsLUHZf3D(hKblOrWu6WFJQq2TRrv5(value)))
							{
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
								{
									num3 = 2;
								}
								continue;
							}
							goto case 9;
						default:
							if (H4b3BlWu2X3AsLUHZf3D(ajoLFkWuwmxu4XxyL2C0(value)))
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto case 6;
						case 4:
							try
							{
								while (true)
								{
									IL_02fc:
									int num5;
									if (!enumerator2.MoveNext())
									{
										int num4 = 5;
										num5 = num4;
										goto IL_01cf;
									}
									goto IL_0201;
									IL_01cf:
									while (true)
									{
										switch (num5)
										{
										case 7:
											break;
										case 6:
											if (!value.Columns.TryGetValue((string)UL6griWutes0x4AGY86U(FhvyAaWuAC4JyAPwAUFj(current2)), out value2))
											{
												num5 = 8;
												continue;
											}
											goto default;
										case 9:
											VjYMO2WuxdNC5xsMMdpu(value2, TWsZIsWu7LbRNkC4oX43(current2));
											num5 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
											{
												num5 = 3;
											}
											continue;
										case 2:
											if (string.IsNullOrEmpty((string)TWsZIsWu7LbRNkC4oX43(current2)))
											{
												num5 = 3;
												continue;
											}
											goto case 9;
										default:
											if (!H4b3BlWu2X3AsLUHZf3D(TWsZIsWu7LbRNkC4oX43(value2)))
											{
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
												{
													num5 = 1;
												}
												continue;
											}
											goto case 2;
										case 1:
										case 3:
										case 4:
										case 8:
											goto IL_02fc;
										case 5:
											goto end_IL_02fc;
										}
										break;
									}
									goto IL_0201;
									IL_0201:
									current2 = enumerator2.Current;
									num5 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
									{
										num5 = 6;
									}
									goto IL_01cf;
									continue;
									end_IL_02fc:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator2).Dispose();
								int num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
								{
									num6 = 0;
								}
								switch (num6)
								{
								case 0:
									break;
								}
							}
							break;
						case 2:
						case 3:
							enumerator2 = current.Columns.Values.GetEnumerator();
							num3 = 4;
							continue;
						case 9:
							if (!H4b3BlWu2X3AsLUHZf3D(hKblOrWu6WFJQq2TRrv5(current)))
							{
								num3 = 10;
								continue;
							}
							goto case 2;
						case 10:
							Oa13ZhWuHZdrHtaV9q6V(value, hKblOrWu6WFJQq2TRrv5(current));
							num3 = 3;
							continue;
						case 11:
							goto IL_03af;
						case 12:
							return;
						}
						break;
					}
					continue;
					IL_03af:
					current = enumerator.Current;
					num3 = 7;
					goto IL_0070;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num7 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num7 = 0;
				}
				switch (num7)
				{
				case 0:
					break;
				}
			}
		}
	}

	protected virtual void ReadXml()
	{
		//Discarded unreachable code: IL_0230, IL_023f, IL_024e, IL_025d, IL_02a3, IL_02b2, IL_02e8, IL_0393, IL_03a2, IL_03b1, IL_03e4, IL_03f3, IL_0456, IL_0469, IL_04be, IL_04cd, IL_0510, IL_051f, IL_0568, IL_0577, IL_0586, IL_05ec, IL_05fb, IL_07b6, IL_07c5, IL_07d4, IL_084f, IL_0882, IL_08d3, IL_08e2, IL_08f1, IL_0901, IL_09b0, IL_09bf, IL_09df, IL_09ee, IL_09fe, IL_0a0d, IL_0a40, IL_0ab1, IL_0c61, IL_0c74, IL_0d21, IL_0f07, IL_0f16
		int num = 4;
		DbScript dbScript = default(DbScript);
		XmlNode xmlNode5 = default(XmlNode);
		DbTable dbTable = default(DbTable);
		XmlNode xmlNode9 = default(XmlNode);
		XmlNode xmlNode = default(XmlNode);
		UserMethod userMethod = default(UserMethod);
		XmlNode xmlNode4 = default(XmlNode);
		XmlNode xmlNode6 = default(XmlNode);
		XmlNode xmlNode3 = default(XmlNode);
		XmlNode xmlNode8 = default(XmlNode);
		XmlNode xmlNode2 = default(XmlNode);
		DbView dbView = default(DbView);
		DbIndex dbIndex = default(DbIndex);
		XmlNode xmlNode7 = default(XmlNode);
		DbProcedure dbProcedure = default(DbProcedure);
		DbTrigger dbTrigger = default(DbTrigger);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 74:
					if (scripts.ContainsKey(dbScript.Name.ToUpper()))
					{
						num2 = 45;
						continue;
					}
					scripts.Add(((string)mPFrMfWuzEMgdbWscN4V(dbScript)).ToUpper(), dbScript);
					num2 = 51;
					continue;
				case 9:
					xmlNode5 = (XmlNode)bTjM5DWuUPoS170aP7XU(xmlNode5);
					num2 = 93;
					continue;
				case 69:
					throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE13ECC1), GHT8GcWujYYXdxwndgLH(dbTable)));
				case 8:
					xmlNode9 = xmlNode9.NextSibling;
					num2 = 16;
					continue;
				case 66:
					xmlNode = xmlNode.NextSibling;
					num2 = 83;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 1;
					}
					continue;
				case 48:
					if (!tables.ContainsKey((string)UL6griWutes0x4AGY86U(dbTable.Name)))
					{
						tables.Add(((string)GHT8GcWujYYXdxwndgLH(dbTable)).ToUpper(), dbTable);
						num2 = 90;
					}
					else
					{
						num2 = 69;
					}
					continue;
				case 65:
					throw new Exception(SR.T((string)AXZlKCWuybnW6tTSTg3l(-643786247 ^ -643735953), userMethod.Name));
				case 22:
					methods.Add((string)UL6griWutes0x4AGY86U(UPfvs0WIouLew7b4n7gn(userMethod)), userMethod);
					num2 = 68;
					continue;
				case 45:
					throw new Exception(SR.T((string)AXZlKCWuybnW6tTSTg3l(-138018305 ^ -137902223), mPFrMfWuzEMgdbWscN4V(dbScript)));
				case 33:
				case 37:
				case 42:
				case 47:
				case 61:
				case 64:
				case 96:
					xmlNode4 = (XmlNode)bTjM5DWuUPoS170aP7XU(xmlNode4);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 1;
					}
					continue;
				case 12:
				case 36:
					if (ssnjbcWugJciBU2pwqBZ(UL6griWutes0x4AGY86U(vxQjf0WumMOPHjXhdvJl(xmlNode6)), AXZlKCWuybnW6tTSTg3l(-35995181 ^ -35978069)))
					{
						num2 = 75;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 47;
						}
						continue;
					}
					goto case 39;
				case 41:
					xmlNode3 = (XmlNode)UrX5u6Wu0wbcaqrsv4N0(xmlNode4);
					num2 = 6;
					continue;
				case 57:
					if (ssnjbcWugJciBU2pwqBZ(UL6griWutes0x4AGY86U(vxQjf0WumMOPHjXhdvJl(xmlNode4)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6F9D7F)))
					{
						num2 = 43;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 46;
						}
						continue;
					}
					goto case 92;
				case 3:
				case 21:
					if (xmlNode8 == null)
					{
						num2 = 62;
						continue;
					}
					goto case 28;
				case 4:
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.LoadXml(xml);
					xmlNode8 = (XmlNode)UrX5u6Wu0wbcaqrsv4N0(xmlDocument);
					num2 = 3;
					continue;
				}
				case 46:
					xmlNode2 = (XmlNode)UrX5u6Wu0wbcaqrsv4N0(xmlNode4);
					num2 = 80;
					continue;
				case 43:
					if (!views.ContainsKey(((string)RDVHQUWuLXU4uNrLiK7m(dbView)).ToUpper()))
					{
						num2 = 23;
						continue;
					}
					goto case 5;
				case 13:
					if ((string)UL6griWutes0x4AGY86U(vxQjf0WumMOPHjXhdvJl(xmlNode4)) == (string)AXZlKCWuybnW6tTSTg3l(-1921202237 ^ -1921187021))
					{
						num2 = 41;
						continue;
					}
					goto case 56;
				case 68:
				case 81:
					xmlNode2 = (XmlNode)bTjM5DWuUPoS170aP7XU(xmlNode2);
					num2 = 52;
					continue;
				case 58:
					dbIndex = ReadUserIndex(xmlNode);
					num2 = 72;
					continue;
				case 75:
					dbView = (DbView)vsmjMZWuYdUdEMs9tkYN(xmlNode6);
					num = 43;
					break;
				case 92:
					if (ssnjbcWugJciBU2pwqBZ(UL6griWutes0x4AGY86U(xmlNode4.Name), AXZlKCWuybnW6tTSTg3l(0x3B36AB09 ^ 0x3B376CE5)))
					{
						num2 = 53;
						continue;
					}
					goto case 33;
				case 77:
					if (!ssnjbcWugJciBU2pwqBZ(xmlNode4.Name.ToUpper(), AXZlKCWuybnW6tTSTg3l(-1939377524 ^ -1939425440)))
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num2 = 30;
						}
						continue;
					}
					goto case 91;
				case 18:
					if (ssnjbcWugJciBU2pwqBZ(((string)vxQjf0WumMOPHjXhdvJl(xmlNode)).ToUpper(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97986648)))
					{
						num2 = 58;
						continue;
					}
					goto case 66;
				case 71:
				case 78:
					if (!ssnjbcWugJciBU2pwqBZ(((string)vxQjf0WumMOPHjXhdvJl(xmlNode7)).ToUpper(), AXZlKCWuybnW6tTSTg3l(--1418440330 ^ 0x548A68F4)))
					{
						num2 = 14;
						continue;
					}
					goto case 20;
				case 50:
					xmlNode6 = (XmlNode)UrX5u6Wu0wbcaqrsv4N0(xmlNode4);
					num2 = 76;
					continue;
				case 79:
					return;
				case 5:
					throw new Exception(SR.T((string)AXZlKCWuybnW6tTSTg3l(-1837662597 ^ -1837712385), RDVHQUWuLXU4uNrLiK7m(dbView)));
				case 23:
					views.Add((string)UL6griWutes0x4AGY86U(RDVHQUWuLXU4uNrLiK7m(dbView)), dbView);
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 39;
					}
					continue;
				case 59:
				case 84:
					if (!ssnjbcWugJciBU2pwqBZ(UL6griWutes0x4AGY86U(vxQjf0WumMOPHjXhdvJl(xmlNode2)), AXZlKCWuybnW6tTSTg3l(-1487388570 ^ -1487304736)))
					{
						num2 = 81;
						continue;
					}
					goto case 34;
				case 54:
				case 62:
					if (xmlNode8 != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 15;
				case 11:
					dbProcedure = (DbProcedure)eL9B3SWIFIyPvap5IIXA(xmlNode5);
					num2 = 89;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 31;
					}
					continue;
				case 19:
					try
					{
						uid = new Guid((string)tpxbeyWul9cYgV4dHtTj(GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(xmlNode8), AXZlKCWuybnW6tTSTg3l(0x6A81B9B4 ^ 0x6A807A62))));
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch (Exception ex)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						default:
							throw new Exception((string)O5NYb5WuJa4ZO2C52yMy(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477189756)) + (string)AXZlKCWuybnW6tTSTg3l(0x68BBB53E ^ 0x68BA71D8) + (string)Ow3Z4xWur7bRGMTwQwEW(ex), ex);
						}
					}
					goto case 94;
				case 17:
				case 35:
					if (ssnjbcWugJciBU2pwqBZ(UL6griWutes0x4AGY86U(vxQjf0WumMOPHjXhdvJl(xmlNode3)), AXZlKCWuybnW6tTSTg3l(0x5DD55050 ^ 0x5DD49550)))
					{
						num2 = 49;
						continue;
					}
					goto case 90;
				case 95:
					if (!triggers.ContainsKey((string)UL6griWutes0x4AGY86U(dbTrigger.Name)))
					{
						num2 = 46;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num2 = 60;
						}
						continue;
					}
					goto case 86;
				case 89:
					if (procedures.ContainsKey((string)UL6griWutes0x4AGY86U(RXfOh8WIBFhRhuFMMfxj(dbProcedure))))
					{
						num2 = 55;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
						{
							num2 = 52;
						}
						continue;
					}
					procedures.Add(((string)RXfOh8WIBFhRhuFMMfxj(dbProcedure)).ToUpper(), dbProcedure);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 9;
					}
					continue;
				case 70:
				case 87:
					if (xmlNode7 == null)
					{
						goto case 33;
					}
					num2 = 78;
					continue;
				case 90:
					xmlNode3 = xmlNode3.NextSibling;
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 31;
					}
					continue;
				case 20:
					dbScript = ReadScript(xmlNode7);
					num2 = 74;
					continue;
				case 73:
					throw new Exception(SR.T((string)AXZlKCWuybnW6tTSTg3l(-812025778 ^ -812076990), GemKxfWIbUJyHsmSB4rS(dbIndex)));
				case 82:
					indexes.Add((string)UL6griWutes0x4AGY86U(dbIndex.Name), dbIndex);
					num2 = 66;
					continue;
				case 56:
					if (((string)vxQjf0WumMOPHjXhdvJl(xmlNode4)).ToUpper() == (string)AXZlKCWuybnW6tTSTg3l(-672123589 ^ -672010159))
					{
						num2 = 50;
						continue;
					}
					goto case 77;
				case 76:
				case 88:
					if (xmlNode6 == null)
					{
						goto case 33;
					}
					num2 = 36;
					continue;
				case 55:
					throw new Exception(SR.T((string)AXZlKCWuybnW6tTSTg3l(-1867198571 ^ -1867183999), RXfOh8WIBFhRhuFMMfxj(dbProcedure)));
				case 34:
					userMethod = (UserMethod)xfW5sKWIWPVo3wDRXnZ6(xmlNode2, methodExecutor);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 2;
					}
					continue;
				case 86:
					throw new Exception(SR.T((string)AXZlKCWuybnW6tTSTg3l(--1418440330 ^ 0x548A6898), tg63PuWucfpnEslapXoy(dbTrigger)));
				case 60:
					triggers.Add((string)UL6griWutes0x4AGY86U(tg63PuWucfpnEslapXoy(dbTrigger)), dbTrigger);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 8;
					}
					continue;
				case 94:
					xmlNode4 = (XmlNode)UrX5u6Wu0wbcaqrsv4N0(xmlNode8);
					num2 = 67;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 38;
					}
					continue;
				case 26:
				case 85:
					if (ssnjbcWugJciBU2pwqBZ(UL6griWutes0x4AGY86U(vxQjf0WumMOPHjXhdvJl(xmlNode4)), AXZlKCWuybnW6tTSTg3l(-2106517564 ^ -2106535646)))
					{
						num2 = 40;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 44;
						}
						continue;
					}
					goto case 57;
				case 16:
				case 63:
					if (xmlNode9 == null)
					{
						num2 = 61;
						continue;
					}
					goto case 2;
				case 2:
					if (ssnjbcWugJciBU2pwqBZ(UL6griWutes0x4AGY86U(vxQjf0WumMOPHjXhdvJl(xmlNode9)), AXZlKCWuybnW6tTSTg3l(-1858887263 ^ -1858967647)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				case 44:
					xmlNode5 = (XmlNode)UrX5u6Wu0wbcaqrsv4N0(xmlNode4);
					num2 = 27;
					continue;
				case 6:
				case 31:
					if (xmlNode3 == null)
					{
						goto case 33;
					}
					num2 = 35;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
				case 51:
					xmlNode7 = (XmlNode)bTjM5DWuUPoS170aP7XU(xmlNode7);
					num2 = 87;
					continue;
				default:
					dbTrigger = (DbTrigger)PklhiDWus7dgyfDYFKC7(xmlNode9);
					num = 95;
					break;
				case 30:
				case 97:
					if (!(((string)vxQjf0WumMOPHjXhdvJl(xmlNode4)).ToUpper() == (string)AXZlKCWuybnW6tTSTg3l(0x53FA00CE ^ 0x53FBC6A2)))
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
						{
							num2 = 26;
						}
						continue;
					}
					goto case 38;
				case 27:
				case 93:
					if (xmlNode5 == null)
					{
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num2 = 33;
						}
						continue;
					}
					goto case 25;
				case 40:
					throw new Exception(SR.T((string)AXZlKCWuybnW6tTSTg3l(-1837662597 ^ -1837711973)));
				case 24:
					num2 = 19;
					continue;
				case 15:
					throw new Exception((string)O5NYb5WuJa4ZO2C52yMy(AXZlKCWuybnW6tTSTg3l(-576149596 ^ -576101140)));
				case 10:
					if (GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(xmlNode8), AXZlKCWuybnW6tTSTg3l(0x53FA00CE ^ 0x53FBC318)) != null)
					{
						num2 = 24;
						continue;
					}
					goto case 40;
				case 29:
					xmlNode8 = xmlNode8.NextSibling;
					num2 = 21;
					continue;
				case 38:
					xmlNode7 = (XmlNode)UrX5u6Wu0wbcaqrsv4N0(xmlNode4);
					num = 70;
					break;
				case 53:
					xmlNode = (XmlNode)UrX5u6Wu0wbcaqrsv4N0(xmlNode4);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 32;
					}
					continue;
				case 91:
					xmlNode9 = (XmlNode)UrX5u6Wu0wbcaqrsv4N0(xmlNode4);
					num2 = 63;
					continue;
				case 52:
				case 80:
					if (xmlNode2 == null)
					{
						goto case 33;
					}
					num2 = 59;
					continue;
				case 25:
					if (ssnjbcWugJciBU2pwqBZ(UL6griWutes0x4AGY86U(vxQjf0WumMOPHjXhdvJl(xmlNode5)), AXZlKCWuybnW6tTSTg3l(-1867198571 ^ -1867183765)))
					{
						num2 = 11;
						continue;
					}
					goto case 9;
				case 72:
					if (!indexes.ContainsKey((string)UL6griWutes0x4AGY86U(GemKxfWIbUJyHsmSB4rS(dbIndex))))
					{
						num2 = 69;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 82;
						}
						continue;
					}
					goto case 73;
				case 1:
				case 67:
					if (xmlNode4 == null)
					{
						num2 = 39;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 79;
						}
						continue;
					}
					goto case 13;
				case 7:
					if (!methods.ContainsKey((string)UL6griWutes0x4AGY86U(UPfvs0WIouLew7b4n7gn(userMethod))))
					{
						num2 = 22;
						continue;
					}
					goto case 65;
				case 39:
					xmlNode6 = (XmlNode)bTjM5DWuUPoS170aP7XU(xmlNode6);
					num2 = 88;
					continue;
				case 49:
					dbTable = (DbTable)Q3jEoKWu5H7IZ3sAjQbu(xmlNode3);
					num2 = 48;
					continue;
				case 32:
				case 83:
					if (xmlNode == null)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num2 = 96;
						}
						continue;
					}
					goto case 18;
				case 28:
					if (!temBa1WuMEuxPtC2qUkq(vxQjf0WumMOPHjXhdvJl(xmlNode8), AXZlKCWuybnW6tTSTg3l(0x48A7E34A ^ 0x48A62076)))
					{
						num2 = 54;
						continue;
					}
					goto case 29;
				}
				break;
			}
		}
	}

	private DbIndex ReadUserIndex(XmlNode indexNode)
	{
		//Discarded unreachable code: IL_00bd, IL_00cc, IL_015c, IL_016b, IL_017b, IL_0202, IL_0337, IL_0346, IL_03d2, IL_03e1
		int num = 25;
		DbIndex dbIndex = default(DbIndex);
		bool result = default(bool);
		XmlAttribute xmlAttribute2 = default(XmlAttribute);
		XmlAttribute xmlAttribute = default(XmlAttribute);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824275793)));
				case 6:
				case 14:
					return dbIndex;
				case 4:
					if (dbIndex.Columns != null)
					{
						num2 = 11;
						continue;
					}
					goto case 7;
				case 15:
				case 16:
					qnrL1AWIGQL4CRSEWyM7(dbIndex, result);
					num2 = 10;
					continue;
				case 18:
					throw new Exception((string)O5NYb5WuJa4ZO2C52yMy(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882239226)));
				case 19:
					if (GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(indexNode), AXZlKCWuybnW6tTSTg3l(0x53CACA3 ^ 0x53D65B3)) == null)
					{
						num2 = 15;
						continue;
					}
					goto case 2;
				case 1:
					if (H4b3BlWu2X3AsLUHZf3D(tpxbeyWul9cYgV4dHtTj(xmlAttribute2)))
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num2 = 22;
						}
						continue;
					}
					dbIndex.TableName = (string)tpxbeyWul9cYgV4dHtTj(GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(indexNode), AXZlKCWuybnW6tTSTg3l(-951514650 ^ -951533244)));
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 8;
					}
					continue;
				case 20:
					if (!H4b3BlWu2X3AsLUHZf3D(tpxbeyWul9cYgV4dHtTj(xmlAttribute)))
					{
						Q8L236WIhrvxTVQM94uG(dbIndex, tpxbeyWul9cYgV4dHtTj(xmlAttribute));
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
						{
							num2 = 13;
						}
					}
					continue;
				case 9:
					if (xmlAttribute2 == null)
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 1;
				case 7:
				case 8:
					if (!H4b3BlWu2X3AsLUHZf3D(dbIndex.Text))
					{
						num = 6;
						break;
					}
					goto case 3;
				case 25:
					dbIndex = new DbIndex();
					num2 = 24;
					continue;
				case 24:
					xmlAttribute = ((XmlAttributeCollection)pt0cfaWu9N4ZdF1DSZ9E(indexNode))[(string)AXZlKCWuybnW6tTSTg3l(0x2ACE37D ^ 0x2ACEF6B)];
					num2 = 12;
					continue;
				case 10:
					if (GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(indexNode), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1F2A38)) != null)
					{
						num2 = 21;
						continue;
					}
					goto case 23;
				case 5:
					xmlAttribute2 = ((XmlAttributeCollection)pt0cfaWu9N4ZdF1DSZ9E(indexNode))[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571F6B3B)];
					num2 = 9;
					continue;
				case 13:
				case 22:
					throw new Exception((string)O5NYb5WuJa4ZO2C52yMy(AXZlKCWuybnW6tTSTg3l(-740338220 ^ -740385428)));
				case 12:
					if (xmlAttribute != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 20;
						}
						continue;
					}
					goto case 18;
				case 23:
					dbIndex.IgnoreVersions = ReadVersions(indexNode);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 0;
					}
					continue;
				case 17:
					result = false;
					num2 = 19;
					continue;
				case 2:
					bool.TryParse(((XmlNode)GjPaCSWudS7TMqtfvAdF(indexNode.Attributes, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561027980))).Value, out result);
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 10;
					}
					continue;
				default:
					iIwBFDWIf4AWTX9b5FwA(dbIndex, indexNode);
					num2 = 4;
					continue;
				case 21:
					dbIndex.Columns = ((IEnumerable<string>)odv9OWWIEGuQN40Jyldg(tpxbeyWul9cYgV4dHtTj(GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(indexNode), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x16360D09))), new char[1] { ',' })).Select((string c) => (string)_003C_003Ec.pYUmCvQaLotntjT0Dc9U(c, new char[1] { ' ' })).ToList();
					num = 23;
					break;
				case 11:
					if (iXQbQAWIQ4No2NQwl8i0(dbIndex.Columns) != 0)
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 7;
				}
				break;
			}
		}
	}

	private static List<string> ReadVersions(object node)
	{
		List<string> list = new List<string>();
		if (((XmlNode)node).Attributes[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A62AB2)] != null)
		{
			string[] array = ((XmlNode)node).Attributes[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDD73CA)].Value.Split(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957835620).ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
			foreach (string text in array)
			{
				list.Add(text.Trim());
			}
		}
		return list;
	}

	private static List<string> ReadExecuteVersions(object node)
	{
		List<string> list = new List<string>();
		XmlAttribute xmlAttribute = ((XmlNode)node).Attributes[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x7246C892)] ?? ((XmlNode)node).Attributes[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146589415)];
		if (xmlAttribute != null)
		{
			string[] array = xmlAttribute.Value.Split(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BBE1E2).ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
			foreach (string text in array)
			{
				list.Add(text.Trim());
			}
		}
		return list;
	}

	private static DbView ReadView(object viewNode)
	{
		DbView dbView = new DbView();
		if (GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(viewNode), AXZlKCWuybnW6tTSTg3l(0x5A4C7B29 ^ 0x5A4C773F)) == null)
		{
			throw new Exception((string)O5NYb5WuJa4ZO2C52yMy(AXZlKCWuybnW6tTSTg3l(-1886646897 ^ -1886533677)));
		}
		dbView.Name = ((XmlAttributeCollection)pt0cfaWu9N4ZdF1DSZ9E(viewNode))[(string)AXZlKCWuybnW6tTSTg3l(-195614443 ^ -195615485)].Value;
		iIwBFDWIf4AWTX9b5FwA(dbView, viewNode);
		hGPFBTWICWNdrgaNIbCX(dbView, viewNode);
		dbView.IgnoreVersions = ReadVersions(viewNode);
		return dbView;
	}

	private static DbTrigger ReadTrigger(object triggerNode)
	{
		DbTrigger dbTrigger = new DbTrigger();
		if (GjPaCSWudS7TMqtfvAdF(((XmlNode)triggerNode).Attributes, AXZlKCWuybnW6tTSTg3l(-218496594 ^ -218493512)) == null)
		{
			throw new Exception(SR.T((string)AXZlKCWuybnW6tTSTg3l(-87337865 ^ -87384377)));
		}
		dbTrigger.Name = (string)tpxbeyWul9cYgV4dHtTj(GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(triggerNode), AXZlKCWuybnW6tTSTg3l(0x307E9FD1 ^ 0x307E93C7)));
		iIwBFDWIf4AWTX9b5FwA(dbTrigger, triggerNode);
		dbTrigger.IgnoreVersions = ReadVersions(triggerNode);
		return dbTrigger;
	}

	private static DbScript ReadScript(object scriptNode)
	{
		DbScript dbScript = new DbScript();
		if (GjPaCSWudS7TMqtfvAdF(((XmlNode)scriptNode).Attributes, AXZlKCWuybnW6tTSTg3l(-1638402543 ^ -1638401529)) == null)
		{
			throw new Exception((string)O5NYb5WuJa4ZO2C52yMy(AXZlKCWuybnW6tTSTg3l(-812025778 ^ -812076364)));
		}
		eMMneaWIvlLjdQN2I2Fj(dbScript, tpxbeyWul9cYgV4dHtTj(GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(scriptNode), AXZlKCWuybnW6tTSTg3l(-1751176224 ^ -1751177226))));
		UtmrWtWIZLWLloEjXSgR(dbScript, S2PJObWI8FTGVLcVhBlD(scriptNode));
		M15rXdWIIOdOpdgJtv4v(dbScript, GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(scriptNode), AXZlKCWuybnW6tTSTg3l(0x307E9FD1 ^ 0x307F5493)) != null && zfHKGeWIuD7BVxUZ0fHg(tpxbeyWul9cYgV4dHtTj(((XmlNode)scriptNode).Attributes[(string)AXZlKCWuybnW6tTSTg3l(0xD3DEF7E ^ 0xD3C243C)]), AXZlKCWuybnW6tTSTg3l(-1411196499 ^ -1411230661), StringComparison.CurrentCultureIgnoreCase));
		dbScript.ExecuteVersions = ReadExecuteVersions(scriptNode);
		iIwBFDWIf4AWTX9b5FwA(dbScript, scriptNode);
		dbScript.IgnoreVersions = ReadVersions(scriptNode);
		hmRhvOWIVZlDJRURZiTG(dbScript, GjPaCSWudS7TMqtfvAdF(((XmlNode)scriptNode).Attributes, AXZlKCWuybnW6tTSTg3l(0x638095EB ^ 0x63815E8B)) != null && zfHKGeWIuD7BVxUZ0fHg(tpxbeyWul9cYgV4dHtTj(((XmlAttributeCollection)pt0cfaWu9N4ZdF1DSZ9E(scriptNode))[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3C241E)]), AXZlKCWuybnW6tTSTg3l(--1867379187 ^ 0x6F4D7C65), StringComparison.CurrentCultureIgnoreCase));
		sXTpnjWIS6hJuvpCFdV4(dbScript, (GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(scriptNode), AXZlKCWuybnW6tTSTg3l(0x49E27B8A ^ 0x49E3B0F6)) != null) ? ((XmlNode)GjPaCSWudS7TMqtfvAdF(((XmlNode)scriptNode).Attributes, AXZlKCWuybnW6tTSTg3l(0x4DC2B14D ^ 0x4DC37A31))).Value : null);
		return dbScript;
	}

	private static DbTable ReadTable(object tableNode)
	{
		//Discarded unreachable code: IL_0252, IL_0273, IL_0282, IL_02d6, IL_02e5, IL_0482, IL_0507, IL_0516, IL_0525, IL_074b, IL_075a, IL_0858, IL_0867, IL_08ae, IL_08bd, IL_098a, IL_0999, IL_0a0d, IL_0a1c, IL_0e33, IL_0e42, IL_0e52, IL_0e8c
		int num = 6;
		DbColumn dbColumn = default(DbColumn);
		DbTable dbTable = default(DbTable);
		XmlNode xmlNode = default(XmlNode);
		DbForeignKey dbForeignKey = default(DbForeignKey);
		int result = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 47:
					throw new Exception(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x1245D136)), FhvyAaWuAC4JyAPwAUFj(dbColumn), GHT8GcWujYYXdxwndgLH(dbTable)));
				case 27:
					if (GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(xmlNode), AXZlKCWuybnW6tTSTg3l(0x4A1640F ^ 0x4A0AA29)) == null)
					{
						num2 = 44;
						continue;
					}
					goto case 24;
				case 4:
					if (ssnjbcWugJciBU2pwqBZ(((string)tpxbeyWul9cYgV4dHtTj(GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(xmlNode), AXZlKCWuybnW6tTSTg3l(0x571EA399 ^ 0x571F6EAD)))).ToUpper(), AXZlKCWuybnW6tTSTg3l(0x2ACE37D ^ 0x2AC6EEB)))
					{
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num2 = 25;
						}
						continue;
					}
					goto case 38;
				case 7:
				case 49:
					if (xmlNode == null)
					{
						num = 12;
						break;
					}
					goto case 73;
				case 24:
					D6kycEWInlLBWNwMqpkm(dbColumn, tpxbeyWul9cYgV4dHtTj(((XmlAttributeCollection)pt0cfaWu9N4ZdF1DSZ9E(xmlNode))[(string)AXZlKCWuybnW6tTSTg3l(-740338220 ^ -740385806)]));
					num2 = 14;
					continue;
				case 34:
					WUuR3OWIXnNeBmOjAWh5(dbColumn, true);
					num2 = 40;
					continue;
				case 60:
					dhUvhqWIPJhnQpRwAZ9g(dbForeignKey, null);
					num2 = 41;
					continue;
				case 53:
					MUEMDIWIkbieB26UsG3b(dbColumn, ((XmlNode)GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(xmlNode), AXZlKCWuybnW6tTSTg3l(-675505729 ^ -675457845))).Value);
					num2 = 11;
					continue;
				case 8:
					if (GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(tableNode), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AD8169)) != null)
					{
						num2 = 55;
						continue;
					}
					goto case 56;
				case 48:
					throw new Exception((string)wZ1W2HWIRisIbHFZ5m53(O5NYb5WuJa4ZO2C52yMy(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97985480)), dbColumn.Name, dbTable.Name));
				case 6:
					dbTable = new DbTable();
					num2 = 5;
					continue;
				case 20:
					MgHddAWI17D8lvKIaIy8(dbForeignKey, tpxbeyWul9cYgV4dHtTj(xmlNode.Attributes[(string)AXZlKCWuybnW6tTSTg3l(-561074844 ^ -561021922)]));
					num2 = 68;
					continue;
				case 9:
					if (((XmlAttributeCollection)pt0cfaWu9N4ZdF1DSZ9E(xmlNode))[(string)AXZlKCWuybnW6tTSTg3l(-521266112 ^ -521153782)] == null)
					{
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
						{
							num2 = 65;
						}
						continue;
					}
					iuq5bkWI2SZffvyoELcM(dbForeignKey, ((XmlNode)GjPaCSWudS7TMqtfvAdF(xmlNode.Attributes, AXZlKCWuybnW6tTSTg3l(0x3A5D5EF ^ 0x3A41AA5))).Value);
					num = 59;
					break;
				case 32:
				case 41:
					if (GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(xmlNode), AXZlKCWuybnW6tTSTg3l(-541731959 ^ -541850893)) == null)
					{
						num2 = 54;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
						{
							num2 = 47;
						}
						continue;
					}
					goto case 20;
				case 10:
					if (GjPaCSWudS7TMqtfvAdF(xmlNode.Attributes, AXZlKCWuybnW6tTSTg3l(-1852837372 ^ -1852834266)) == null)
					{
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 62;
						}
						continue;
					}
					hFan0pWIqBTbY24GNXEK(dbColumn, tpxbeyWul9cYgV4dHtTj(GjPaCSWudS7TMqtfvAdF(xmlNode.Attributes, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477142536))));
					num2 = 64;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 15;
					}
					continue;
				case 37:
					dbColumn.StringFieldLength = result;
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 26;
					}
					continue;
				case 1:
					dbColumn.UniqueKey = true;
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 43;
					}
					continue;
				case 18:
					if (((XmlAttributeCollection)pt0cfaWu9N4ZdF1DSZ9E(xmlNode))[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A0A97B)] == null)
					{
						num2 = 23;
						continue;
					}
					goto case 53;
				case 45:
					if (GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(xmlNode), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269F8EAC)) == null)
					{
						num2 = 60;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num2 = 54;
						}
						continue;
					}
					goto case 16;
				case 28:
				case 43:
					if (GjPaCSWudS7TMqtfvAdF(xmlNode.Attributes, AXZlKCWuybnW6tTSTg3l(0x1637C429 ^ 0x16374881)) != null)
					{
						num2 = 33;
						continue;
					}
					goto case 18;
				case 67:
					xmlNode = (XmlNode)UrX5u6Wu0wbcaqrsv4N0(tableNode);
					num2 = 7;
					continue;
				case 35:
					throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335078903), GHT8GcWujYYXdxwndgLH(dbTable)));
				case 72:
					r2Xml9WIiP2cd9wKrdyW(dbColumn, tpxbeyWul9cYgV4dHtTj(GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(xmlNode), AXZlKCWuybnW6tTSTg3l(-210725949 ^ -210722859))));
					num2 = 42;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 42;
					}
					continue;
				case 33:
					Ql1xm3WIT2tHH0Xqewcq(dbColumn, ((XmlNode)GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(xmlNode), AXZlKCWuybnW6tTSTg3l(-561074844 ^ -561110580))).Value);
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 6;
					}
					continue;
				case 52:
					if (!dbTable.Columns.ContainsKey(((string)FhvyAaWuAC4JyAPwAUFj(dbColumn)).ToUpper()))
					{
						dbTable.Columns.Add((string)UL6griWutes0x4AGY86U(FhvyAaWuAC4JyAPwAUFj(dbColumn)), dbColumn);
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num2 = 7;
						}
					}
					else
					{
						num2 = 48;
					}
					continue;
				case 61:
					throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606674684), K15hUsWIOsry5nh2lhET(dbForeignKey), dbTable.Name));
				case 55:
					dbTable.Description = (string)tpxbeyWul9cYgV4dHtTj(GjPaCSWudS7TMqtfvAdF(((XmlNode)tableNode).Attributes, AXZlKCWuybnW6tTSTg3l(0x3C5338FF ^ 0x3C525AEB)));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 56;
					}
					continue;
				case 12:
					return dbTable;
				case 73:
					if (ssnjbcWugJciBU2pwqBZ(((string)vxQjf0WumMOPHjXhdvJl(xmlNode)).ToUpper(), AXZlKCWuybnW6tTSTg3l(0x8317432 ^ 0x830BFC4)))
					{
						num2 = 13;
						continue;
					}
					goto case 3;
				case 38:
				case 75:
					if (xmlNode.Attributes[(string)AXZlKCWuybnW6tTSTg3l(0x638095EB ^ 0x638158AD)] == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 71;
				case 15:
					throw new Exception(SR.T((string)AXZlKCWuybnW6tTSTg3l(0x4EDCBA32 ^ 0x4EDD6AF8), dbForeignKey.Name, GHT8GcWujYYXdxwndgLH(dbTable)));
				case 70:
					dbForeignKey.RefColumn = (string)tpxbeyWul9cYgV4dHtTj(GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(xmlNode), AXZlKCWuybnW6tTSTg3l(-1217523399 ^ -1217412723)));
					num2 = 38;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 45;
					}
					continue;
				case 36:
					if (!dbTable.ForeignKeys.ContainsKey((string)UL6griWutes0x4AGY86U(K15hUsWIOsry5nh2lhET(dbForeignKey))))
					{
						num2 = 41;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
						{
							num2 = 66;
						}
						continue;
					}
					goto case 22;
				case 21:
					throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C18DD5)));
				case 57:
					dbTable.Name = (string)tpxbeyWul9cYgV4dHtTj(GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(tableNode), AXZlKCWuybnW6tTSTg3l(-29254301 ^ -29257355)));
					num2 = 8;
					continue;
				case 2:
					if (GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(xmlNode), AXZlKCWuybnW6tTSTg3l(0x49E27B8A ^ 0x49E3AB3E)) != null)
					{
						num2 = 70;
						continue;
					}
					goto case 15;
				case 56:
					if (GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(tableNode), AXZlKCWuybnW6tTSTg3l(-1822890472 ^ -1822828864)) != null)
					{
						num2 = 58;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num2 = 44;
						}
						continue;
					}
					goto case 46;
				case 5:
					if (((XmlAttributeCollection)pt0cfaWu9N4ZdF1DSZ9E(tableNode))[(string)AXZlKCWuybnW6tTSTg3l(-1876063057 ^ -1876066119)] != null)
					{
						num = 57;
						break;
					}
					goto case 21;
				case 3:
					if (!ssnjbcWugJciBU2pwqBZ(UL6griWutes0x4AGY86U(vxQjf0WumMOPHjXhdvJl(xmlNode)), AXZlKCWuybnW6tTSTg3l(-889460160 ^ -889576444)))
					{
						num2 = 39;
						continue;
					}
					goto case 31;
				case 51:
					if (GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(xmlNode), AXZlKCWuybnW6tTSTg3l(-1459557599 ^ -1459558601)) != null)
					{
						num2 = 72;
						continue;
					}
					goto case 35;
				case 54:
					dbForeignKey.AlterAction = null;
					num2 = 50;
					continue;
				case 31:
					dbForeignKey = new DbForeignKey();
					num2 = 74;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 40;
					}
					continue;
				case 63:
					if (int.TryParse((string)tpxbeyWul9cYgV4dHtTj(xmlNode.Attributes[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AD2EFF)]), out result))
					{
						num2 = 37;
						continue;
					}
					goto case 47;
				case 25:
					xuA8FhWIKYuU4dKQ2D3E(dbColumn, true);
					num2 = 38;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 37;
					}
					continue;
				case 26:
					dbColumn.Description = ((XmlNode)GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(xmlNode), AXZlKCWuybnW6tTSTg3l(-309639236 ^ -309713496))).Value;
					num = 52;
					break;
				case 71:
					if (ssnjbcWugJciBU2pwqBZ(((string)tpxbeyWul9cYgV4dHtTj(GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(xmlNode), AXZlKCWuybnW6tTSTg3l(-1837662597 ^ -1837714627)))).ToUpper(), AXZlKCWuybnW6tTSTg3l(0x57A5235E ^ 0x57A5AEC8)))
					{
						num2 = 34;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 28;
						}
						continue;
					}
					goto default;
				case 30:
					throw new Exception(SR.T((string)AXZlKCWuybnW6tTSTg3l(0x3CE17B75 ^ 0x3CE0B529), GHT8GcWujYYXdxwndgLH(dbTable)));
				default:
					if (GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(xmlNode), AXZlKCWuybnW6tTSTg3l(0x1FFEF86A ^ 0x1FFF3534)) == null)
					{
						num2 = 28;
						continue;
					}
					goto case 29;
				case 17:
				case 39:
					xmlNode = (XmlNode)bTjM5DWuUPoS170aP7XU(xmlNode);
					num2 = 49;
					continue;
				case 14:
				case 44:
					dbColumn.IgnoreVersions = ReadVersions(xmlNode);
					num2 = 3;
					continue;
				case 62:
					throw new Exception((string)wZ1W2HWIRisIbHFZ5m53(O5NYb5WuJa4ZO2C52yMy(AXZlKCWuybnW6tTSTg3l(-629844702 ^ -629892616)), FhvyAaWuAC4JyAPwAUFj(dbColumn), GHT8GcWujYYXdxwndgLH(dbTable)));
				case 64:
					if (GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(xmlNode), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951532334)) == null)
					{
						num2 = 50;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num2 = 75;
						}
						continue;
					}
					goto case 4;
				case 58:
					Oa13ZhWuHZdrHtaV9q6V(dbTable, tpxbeyWul9cYgV4dHtTj(GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(tableNode), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488803565))));
					num2 = 43;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 46;
					}
					continue;
				case 19:
				case 23:
					MUEMDIWIkbieB26UsG3b(dbColumn, null);
					num = 69;
					break;
				case 13:
					dbColumn = new DbColumn();
					num2 = 51;
					continue;
				case 22:
					throw new Exception(SR.T((string)AXZlKCWuybnW6tTSTg3l(-1459557599 ^ -1459542541), dbForeignKey.Name, GHT8GcWujYYXdxwndgLH(dbTable)));
				case 66:
					dbTable.ForeignKeys.Add(((string)K15hUsWIOsry5nh2lhET(dbForeignKey)).ToUpper(), dbForeignKey);
					num2 = 9;
					continue;
				case 42:
					if (GjPaCSWudS7TMqtfvAdF(xmlNode.Attributes, AXZlKCWuybnW6tTSTg3l(0x42643203 ^ 0x42655017)) != null)
					{
						num2 = 26;
						continue;
					}
					goto case 52;
				case 16:
					dhUvhqWIPJhnQpRwAZ9g(dbForeignKey, tpxbeyWul9cYgV4dHtTj(GjPaCSWudS7TMqtfvAdF(xmlNode.Attributes, AXZlKCWuybnW6tTSTg3l(0x1A33FE36 ^ 0x1A322F50))));
					num2 = 32;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 21;
					}
					continue;
				case 74:
					if (GjPaCSWudS7TMqtfvAdF(xmlNode.Attributes, AXZlKCWuybnW6tTSTg3l(0x637E299B ^ 0x637E258D)) != null)
					{
						dbForeignKey.Name = (string)tpxbeyWul9cYgV4dHtTj(GjPaCSWudS7TMqtfvAdF(xmlNode.Attributes, AXZlKCWuybnW6tTSTg3l(-1217523399 ^ -1217520337)));
						num2 = 34;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 36;
						}
					}
					else
					{
						num2 = 30;
					}
					continue;
				case 50:
				case 68:
					dbForeignKey.IgnoreVersions = ReadVersions(xmlNode);
					num2 = 17;
					continue;
				case 59:
					if (GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(xmlNode), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x638145EF)) != null)
					{
						KVi7mtWIeIRuWhioNMdK(dbForeignKey, tpxbeyWul9cYgV4dHtTj(((XmlAttributeCollection)pt0cfaWu9N4ZdF1DSZ9E(xmlNode))[(string)AXZlKCWuybnW6tTSTg3l(0x6DC147B0 ^ 0x6DC097B4)]));
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num2 = 2;
						}
					}
					else
					{
						num2 = 61;
					}
					continue;
				case 11:
				case 69:
					if (xmlNode.Attributes[(string)AXZlKCWuybnW6tTSTg3l(-105199646 ^ -105182624)] != null)
					{
						num2 = 63;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num2 = 49;
						}
						continue;
					}
					goto case 27;
				case 29:
					if (ssnjbcWugJciBU2pwqBZ(((XmlNode)GjPaCSWudS7TMqtfvAdF(xmlNode.Attributes, AXZlKCWuybnW6tTSTg3l(-70037984 ^ -70089858))).Value.ToUpper(), AXZlKCWuybnW6tTSTg3l(0x3C5338FF ^ 0x3C53B569)))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 28;
				case 46:
					dbTable.IgnoreVersions = ReadVersions(tableNode);
					num2 = 67;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 51;
					}
					continue;
				case 65:
					throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138841960), K15hUsWIOsry5nh2lhET(dbForeignKey), GHT8GcWujYYXdxwndgLH(dbTable)));
				}
				break;
			}
		}
	}

	private static DbProcedure ReadProcedure(object procNode)
	{
		DbProcedure dbProcedure = new DbProcedure();
		if (((XmlAttributeCollection)pt0cfaWu9N4ZdF1DSZ9E(procNode))[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998537940)] == null)
		{
			throw new Exception((string)O5NYb5WuJa4ZO2C52yMy(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998494034)));
		}
		dbProcedure.Name = ((XmlNode)GjPaCSWudS7TMqtfvAdF(((XmlNode)procNode).Attributes, AXZlKCWuybnW6tTSTg3l(-1088304168 ^ -1088305202))).Value;
		iIwBFDWIf4AWTX9b5FwA(dbProcedure, procNode);
		hGPFBTWICWNdrgaNIbCX(dbProcedure, procNode);
		dbProcedure.IgnoreVersions = ReadVersions(procNode);
		return dbProcedure;
	}

	private static UserMethod ReadUserMethods(object methNode, object methodExecutor)
	{
		//Discarded unreachable code: IL_0130, IL_013f
		int num = 4;
		UserMethod userMethod = default(UserMethod);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					return userMethod;
				case 8:
					rZpZgaWIaD0JlVy9CZIW(userMethod, ReadExecuteTime(methNode));
					num2 = 9;
					continue;
				case 1:
					throw new Exception((string)O5NYb5WuJa4ZO2C52yMy(AXZlKCWuybnW6tTSTg3l(-542721635 ^ -542676867)));
				case 5:
					break;
				case 3:
					if (GjPaCSWudS7TMqtfvAdF(((XmlNode)methNode).Attributes, AXZlKCWuybnW6tTSTg3l(-1638402543 ^ -1638401529)) != null)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 2:
					userMethod.IgnoreVersions = ReadVersions(methNode);
					num2 = 10;
					continue;
				case 4:
				{
					UserMethod userMethod2 = new UserMethod();
					tP51tfWINxSS5u8Zhuyv(userMethod2, methodExecutor);
					userMethod = userMethod2;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				case 6:
					r4kvWkWIp5HkkkEqx1Gn(userMethod, (GjPaCSWudS7TMqtfvAdF(((XmlNode)methNode).Attributes, AXZlKCWuybnW6tTSTg3l(-583745292 ^ -583672350)) != null) ? ((XmlNode)methNode).Attributes[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87406239)].Value : UPfvs0WIouLew7b4n7gn(userMethod));
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 3;
					}
					continue;
				case 9:
					loBBvHWIDFkI2GuaPM5R(userMethod, GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(methNode), AXZlKCWuybnW6tTSTg3l(-70007027 ^ -70120369)) != null && zfHKGeWIuD7BVxUZ0fHg(tpxbeyWul9cYgV4dHtTj(GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(methNode), AXZlKCWuybnW6tTSTg3l(0x1A33FE36 ^ 0x1A323574))), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x12449132), StringComparison.CurrentCultureIgnoreCase));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					c3dAH8WIto12iuxmSDMS(userMethod, GjPaCSWudS7TMqtfvAdF(((XmlNode)methNode).Attributes, AXZlKCWuybnW6tTSTg3l(-281842504 ^ -281892904)) != null && zfHKGeWIuD7BVxUZ0fHg(((XmlNode)GjPaCSWudS7TMqtfvAdF(((XmlNode)methNode).Attributes, AXZlKCWuybnW6tTSTg3l(-1088304168 ^ -1088421704))).Value, AXZlKCWuybnW6tTSTg3l(0x48A7E34A ^ 0x48A76EDC), StringComparison.CurrentCultureIgnoreCase));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					vkJT9UWIwOJudNiKDIgY(userMethod, (GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(methNode), AXZlKCWuybnW6tTSTg3l(-561074844 ^ -561027560)) != null) ? tpxbeyWul9cYgV4dHtTj(GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(methNode), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571F68E5))) : null);
					num2 = 7;
					continue;
				}
				break;
			}
			QvRs4fWI35wM5O6SeVw7(userMethod, ((XmlNode)GjPaCSWudS7TMqtfvAdF(pt0cfaWu9N4ZdF1DSZ9E(methNode), AXZlKCWuybnW6tTSTg3l(-477139494 ^ -477142580))).Value);
			num = 6;
		}
	}

	private static ExecuteTime ReadExecuteTime(object node)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (GjPaCSWudS7TMqtfvAdF(((XmlNode)node).Attributes, AXZlKCWuybnW6tTSTg3l(-629844702 ^ -629897468)) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 0;
					}
					break;
				}
				return (ExecuteTime)V3ar7PWI6CqNuiE6rfrL(AK1rgiWI4BMr5629HpKX(typeof(ExecuteTime).TypeHandle), tpxbeyWul9cYgV4dHtTj(((XmlAttributeCollection)pt0cfaWu9N4ZdF1DSZ9E(node))[(string)AXZlKCWuybnW6tTSTg3l(0x2A7797B7 ^ 0x2A764591)]));
			default:
				return ExecuteTime.OnComplete;
			}
		}
	}

	private static void ReadText(object textObj, object node)
	{
		//Discarded unreachable code: IL_006a, IL_0127, IL_0136, IL_0146, IL_0155
		int num = 6;
		int num2 = num;
		XmlNode xmlNode = default(XmlNode);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 5:
				if (xmlNode == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			case 6:
				xmlNode = (XmlNode)UrX5u6Wu0wbcaqrsv4N0(node);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (!ssnjbcWugJciBU2pwqBZ(vxQjf0WumMOPHjXhdvJl(xmlNode), AXZlKCWuybnW6tTSTg3l(-105199646 ^ -105179742)))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 9;
			default:
				Enae4TWIAT0ZcaL3ma6m(textObj, z8OnhLWIHJ4Htqrym9HG(xmlNode));
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 8;
				}
				break;
			case 3:
				return;
			case 9:
				if (z8OnhLWIHJ4Htqrym9HG(xmlNode) == null)
				{
					num2 = 7;
					break;
				}
				goto default;
			case 4:
			case 7:
			case 8:
				xmlNode = (XmlNode)bTjM5DWuUPoS170aP7XU(xmlNode);
				num2 = 2;
				break;
			}
		}
	}

	private static void ReadMappings(object mappingsObj, object node)
	{
		//Discarded unreachable code: IL_00d0, IL_00df, IL_0155, IL_0164
		int num = 2;
		int num2 = num;
		XmlNode xmlNode = default(XmlNode);
		while (true)
		{
			switch (num2)
			{
			case 2:
				xmlNode = (XmlNode)UrX5u6Wu0wbcaqrsv4N0(node);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				return;
			case 6:
				FiqSCLWIxlKdDcPWmuNr(mappingsObj, F9FaTrWI7lHtn9Igwevh(xmlNode));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 9;
				}
				break;
			case 4:
			case 5:
			case 10:
				xmlNode = (XmlNode)bTjM5DWuUPoS170aP7XU(xmlNode);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				if (xmlNode.InnerXml == null)
				{
					num2 = 10;
					break;
				}
				goto case 6;
			case 3:
				if (!ssnjbcWugJciBU2pwqBZ(vxQjf0WumMOPHjXhdvJl(xmlNode), AXZlKCWuybnW6tTSTg3l(-1837662597 ^ -1837716425)))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 7;
			case 9:
				FiqSCLWIxlKdDcPWmuNr(mappingsObj, KEwwx6WImcdcMyoSim8t(AhoR6CWI0bwKSLCP9BtV(mappingsObj)));
				num2 = 4;
				break;
			default:
				if (xmlNode == null)
				{
					num2 = 8;
					break;
				}
				goto case 3;
			}
		}
	}

	internal static void ioi9jIWuKC0cWo9G7nv0()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool sM3iRjWuRmQA2ijAGurK()
	{
		return REK1TFWuip1GeydpvaOw == null;
	}

	internal static DbStructure amjBbIWuqgtFg6Cv9qFI()
	{
		return REK1TFWuip1GeydpvaOw;
	}

	internal static void iB13pWWuXpI0KQIW6T42(object P_0)
	{
		((DbStructure)P_0).ReadXml();
	}

	internal static bool trEqLFWuTgY9LLxMO2Ua(object P_0)
	{
		return ((DbStructure)P_0).Deactivating;
	}

	internal static bool PDSUGZWuksG5xdbGYRd6(object P_0)
	{
		return ((UserMethod)P_0).OnDeactivate;
	}

	internal static bool kMXXyVWunp8oC5mn5VMC(object P_0)
	{
		return ((DbScript)P_0).OnDeactivate;
	}

	internal static object gOhQLsWuOsXErWNKWeRV(object P_0)
	{
		return ((DbProcedure)P_0).Text;
	}

	internal static bool H4b3BlWu2X3AsLUHZf3D(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void hvcA37WueBmlPlq5l0F6(object P_0, object P_1)
	{
		((DbProcedure)P_0).Text = (string)P_1;
	}

	internal static object ds3cB6WuPDJU63hAHwx3(object P_0)
	{
		return ((DbProcedure)P_0).Mappings;
	}

	internal static void N7XCXRWu1xDkMid83fLe(object P_0, object P_1)
	{
		((DbProcedure)P_0).Mappings = (string)P_1;
	}

	internal static object WK9nYVWuNgpnFWkSQXMV(object P_0)
	{
		return ((DbView)P_0).Text;
	}

	internal static void FXEwPVWu3hnhcWgn5yJm(object P_0, object P_1)
	{
		((DbView)P_0).Text = (string)P_1;
	}

	internal static object dH4hJdWupYieB3MmHhax(object P_0)
	{
		return ((DbView)P_0).Mappings;
	}

	internal static object wp6hOnWuaa8J28UVjc2b(object P_0)
	{
		return ((DbIndex)P_0).Text;
	}

	internal static void pQmXFxWuDy0KUIbW4U9O(object P_0, object P_1)
	{
		((DbIndex)P_0).Text = (string)P_1;
	}

	internal static object UL6griWutes0x4AGY86U(object P_0)
	{
		return ((string)P_0).ToUpper();
	}

	internal static object ajoLFkWuwmxu4XxyL2C0(object P_0)
	{
		return ((DbTable)P_0).Description;
	}

	internal static void NsmOIaWu4ffWds0N5pmA(object P_0, object P_1)
	{
		((DbTable)P_0).Description = (string)P_1;
	}

	internal static object hKblOrWu6WFJQq2TRrv5(object P_0)
	{
		return ((DbTable)P_0).Module;
	}

	internal static void Oa13ZhWuHZdrHtaV9q6V(object P_0, object P_1)
	{
		((DbTable)P_0).Module = (string)P_1;
	}

	internal static object FhvyAaWuAC4JyAPwAUFj(object P_0)
	{
		return ((DbColumn)P_0).Name;
	}

	internal static object TWsZIsWu7LbRNkC4oX43(object P_0)
	{
		return ((DbColumn)P_0).Description;
	}

	internal static void VjYMO2WuxdNC5xsMMdpu(object P_0, object P_1)
	{
		((DbColumn)P_0).Description = (string)P_1;
	}

	internal static object UrX5u6Wu0wbcaqrsv4N0(object P_0)
	{
		return ((XmlNode)P_0).FirstChild;
	}

	internal static object vxQjf0WumMOPHjXhdvJl(object P_0)
	{
		return ((XmlNode)P_0).Name;
	}

	internal static object AXZlKCWuybnW6tTSTg3l(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool temBa1WuMEuxPtC2qUkq(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object O5NYb5WuJa4ZO2C52yMy(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object pt0cfaWu9N4ZdF1DSZ9E(object P_0)
	{
		return ((XmlNode)P_0).Attributes;
	}

	internal static object GjPaCSWudS7TMqtfvAdF(object P_0, object P_1)
	{
		return ((XmlAttributeCollection)P_0)[(string)P_1];
	}

	internal static object tpxbeyWul9cYgV4dHtTj(object P_0)
	{
		return ((XmlNode)P_0).Value;
	}

	internal static object Ow3Z4xWur7bRGMTwQwEW(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static bool ssnjbcWugJciBU2pwqBZ(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object Q3jEoKWu5H7IZ3sAjQbu(object P_0)
	{
		return ReadTable(P_0);
	}

	internal static object GHT8GcWujYYXdxwndgLH(object P_0)
	{
		return ((DbTable)P_0).Name;
	}

	internal static object vsmjMZWuYdUdEMs9tkYN(object P_0)
	{
		return ReadView(P_0);
	}

	internal static object RDVHQUWuLXU4uNrLiK7m(object P_0)
	{
		return ((DbView)P_0).Name;
	}

	internal static object bTjM5DWuUPoS170aP7XU(object P_0)
	{
		return ((XmlNode)P_0).NextSibling;
	}

	internal static object PklhiDWus7dgyfDYFKC7(object P_0)
	{
		return ReadTrigger(P_0);
	}

	internal static object tg63PuWucfpnEslapXoy(object P_0)
	{
		return ((DbTrigger)P_0).Name;
	}

	internal static object mPFrMfWuzEMgdbWscN4V(object P_0)
	{
		return ((DbScript)P_0).Name;
	}

	internal static object eL9B3SWIFIyPvap5IIXA(object P_0)
	{
		return ReadProcedure(P_0);
	}

	internal static object RXfOh8WIBFhRhuFMMfxj(object P_0)
	{
		return ((DbProcedure)P_0).Name;
	}

	internal static object xfW5sKWIWPVo3wDRXnZ6(object P_0, object P_1)
	{
		return ReadUserMethods(P_0, P_1);
	}

	internal static object UPfvs0WIouLew7b4n7gn(object P_0)
	{
		return ((UserMethod)P_0).Name;
	}

	internal static object GemKxfWIbUJyHsmSB4rS(object P_0)
	{
		return ((DbIndex)P_0).Name;
	}

	internal static void Q8L236WIhrvxTVQM94uG(object P_0, object P_1)
	{
		((DbIndex)P_0).Name = (string)P_1;
	}

	internal static void qnrL1AWIGQL4CRSEWyM7(object P_0, bool value)
	{
		((DbIndex)P_0).IsUnique = value;
	}

	internal static object odv9OWWIEGuQN40Jyldg(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static void iIwBFDWIf4AWTX9b5FwA(object P_0, object P_1)
	{
		ReadText(P_0, P_1);
	}

	internal static int iXQbQAWIQ4No2NQwl8i0(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static void hGPFBTWICWNdrgaNIbCX(object P_0, object P_1)
	{
		ReadMappings(P_0, P_1);
	}

	internal static void eMMneaWIvlLjdQN2I2Fj(object P_0, object P_1)
	{
		((DbScript)P_0).Name = (string)P_1;
	}

	internal static ExecuteTime S2PJObWI8FTGVLcVhBlD(object P_0)
	{
		return ReadExecuteTime(P_0);
	}

	internal static void UtmrWtWIZLWLloEjXSgR(object P_0, ExecuteTime value)
	{
		((DbScript)P_0).ExecuteTime = value;
	}

	internal static bool zfHKGeWIuD7BVxUZ0fHg(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static void M15rXdWIIOdOpdgJtv4v(object P_0, bool value)
	{
		((DbScript)P_0).AlwaysExecute = value;
	}

	internal static void hmRhvOWIVZlDJRURZiTG(object P_0, bool value)
	{
		((DbScript)P_0).OnDeactivate = value;
	}

	internal static void sXTpnjWIS6hJuvpCFdV4(object P_0, object P_1)
	{
		((DbScript)P_0).TransformationInVersion = (string)P_1;
	}

	internal static void r2Xml9WIiP2cd9wKrdyW(object P_0, object P_1)
	{
		((DbColumn)P_0).Name = (string)P_1;
	}

	internal static object wZ1W2HWIRisIbHFZ5m53(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void hFan0pWIqBTbY24GNXEK(object P_0, object P_1)
	{
		((DbColumn)P_0).Type = (string)P_1;
	}

	internal static void xuA8FhWIKYuU4dKQ2D3E(object P_0, bool value)
	{
		((DbColumn)P_0).NotNull = value;
	}

	internal static void WUuR3OWIXnNeBmOjAWh5(object P_0, bool value)
	{
		((DbColumn)P_0).PrimaryKey = value;
	}

	internal static void Ql1xm3WIT2tHH0Xqewcq(object P_0, object P_1)
	{
		((DbColumn)P_0).DefaultValue = (string)P_1;
	}

	internal static void MUEMDIWIkbieB26UsG3b(object P_0, object P_1)
	{
		((DbColumn)P_0).Index = (string)P_1;
	}

	internal static void D6kycEWInlLBWNwMqpkm(object P_0, object P_1)
	{
		((DbColumn)P_0).AfterCreation = (string)P_1;
	}

	internal static object K15hUsWIOsry5nh2lhET(object P_0)
	{
		return ((DbForeignKey)P_0).Name;
	}

	internal static void iuq5bkWI2SZffvyoELcM(object P_0, object P_1)
	{
		((DbForeignKey)P_0).KeyColumn = (string)P_1;
	}

	internal static void KVi7mtWIeIRuWhioNMdK(object P_0, object P_1)
	{
		((DbForeignKey)P_0).RefTable = (string)P_1;
	}

	internal static void dhUvhqWIPJhnQpRwAZ9g(object P_0, object P_1)
	{
		((DbForeignKey)P_0).OnDelete = (string)P_1;
	}

	internal static void MgHddAWI17D8lvKIaIy8(object P_0, object P_1)
	{
		((DbForeignKey)P_0).AlterAction = (string)P_1;
	}

	internal static void tP51tfWINxSS5u8Zhuyv(object P_0, object P_1)
	{
		((UserMethod)P_0).MethodExecutor = P_1;
	}

	internal static void QvRs4fWI35wM5O6SeVw7(object P_0, object P_1)
	{
		((UserMethod)P_0).Name = (string)P_1;
	}

	internal static void r4kvWkWIp5HkkkEqx1Gn(object P_0, object P_1)
	{
		((UserMethod)P_0).Method = (string)P_1;
	}

	internal static void rZpZgaWIaD0JlVy9CZIW(object P_0, ExecuteTime value)
	{
		((UserMethod)P_0).ExecuteTime = value;
	}

	internal static void loBBvHWIDFkI2GuaPM5R(object P_0, bool value)
	{
		((UserMethod)P_0).AlwaysExecute = value;
	}

	internal static void c3dAH8WIto12iuxmSDMS(object P_0, bool value)
	{
		((UserMethod)P_0).OnDeactivate = value;
	}

	internal static void vkJT9UWIwOJudNiKDIgY(object P_0, object P_1)
	{
		((UserMethod)P_0).TransformationInVersion = (string)P_1;
	}

	internal static Type AK1rgiWI4BMr5629HpKX(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object V3ar7PWI6CqNuiE6rfrL(Type P_0, object P_1)
	{
		return Enum.Parse(P_0, (string)P_1);
	}

	internal static object z8OnhLWIHJ4Htqrym9HG(object P_0)
	{
		return ((XmlNode)P_0).InnerText;
	}

	internal static void Enae4TWIAT0ZcaL3ma6m(object P_0, object P_1)
	{
		((IDbText)P_0).Text = (string)P_1;
	}

	internal static object F9FaTrWI7lHtn9Igwevh(object P_0)
	{
		return ((XmlNode)P_0).InnerXml;
	}

	internal static void FiqSCLWIxlKdDcPWmuNr(object P_0, object P_1)
	{
		((IDbMappings)P_0).Mappings = (string)P_1;
	}

	internal static object AhoR6CWI0bwKSLCP9BtV(object P_0)
	{
		return ((IDbMappings)P_0).Mappings;
	}

	internal static object KEwwx6WImcdcMyoSim8t(object P_0)
	{
		return DbStructureReader.PrepareSqlText((string)P_0);
	}
}
