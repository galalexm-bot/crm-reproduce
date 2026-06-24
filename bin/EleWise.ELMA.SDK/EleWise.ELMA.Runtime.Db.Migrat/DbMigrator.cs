using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Migrator;

public class DbMigrator
{
	private AbstractDbMetadataProvider dbMetadataProvider;

	private readonly ILogger logger;

	private ForeignKey[] foreignKeys;

	private Index[] indexes;

	private PrimaryKey[] primaryKeys;

	private List<ForeignKey> droppingForeignKeys;

	private List<Index> droppingIndexes;

	private List<PrimaryKey> droppingPrimaryKeys;

	private ITransformationProvider transform;

	private DateTime startTime;

	private readonly CollectionExtensions.DelegateComparer<ForeignKey> foreignKeyComparer;

	private readonly CollectionExtensions.DelegateComparer<Index> indexComparer;

	private readonly CollectionExtensions.DelegateComparer<PrimaryKey> primaryKeyComparer;

	private static DbMigrator ewQcXiWXWwBNLY7sUW6p;

	public DbMigrator(ITransformationProvider transform)
	{
		//Discarded unreachable code: IL_0195, IL_019a
		BF2AJ2WXhrXEPiH619Z0();
		logger = (ILogger)LvRwyxWXEyyQYNQXJrTS(lr3cdpWXGhL6a8aNFBBC(-1998538950 ^ -1998502058));
		droppingForeignKeys = new List<ForeignKey>();
		droppingIndexes = new List<Index>();
		droppingPrimaryKeys = new List<PrimaryKey>();
		foreignKeyComparer = new CollectionExtensions.DelegateComparer<ForeignKey>((ForeignKey a, ForeignKey b) => _003C_003Ec.elYEIvQw0WPlMKl1cNp6(_003C_003Ec.CbrPeGQwx0pYsxt9Jmmw(a), _003C_003Ec.CbrPeGQwx0pYsxt9Jmmw(b)), (ForeignKey i) => _003C_003Ec.CbrPeGQwx0pYsxt9Jmmw(i).GetHashCode());
		indexComparer = new CollectionExtensions.DelegateComparer<Index>((Index a, Index b) => (string)_003C_003Ec.WDV001QwmT7c55fHkk47(a) == (string)_003C_003Ec.WDV001QwmT7c55fHkk47(b), (Index i) => _003C_003Ec.WDV001QwmT7c55fHkk47(i).GetHashCode());
		primaryKeyComparer = new CollectionExtensions.DelegateComparer<PrimaryKey>((PrimaryKey a, PrimaryKey b) => _003C_003Ec.elYEIvQw0WPlMKl1cNp6(a.Name, _003C_003Ec.X1ZgvxQwyuHa3i0qqUPK(b)), (PrimaryKey i) => _003C_003Ec.X1ZgvxQwyuHa3i0qqUPK(i).GetHashCode());
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				dbMetadataProvider = transform.DbMetadataProvider;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num = 1;
				}
				break;
			case 2:
				this.transform = transform;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public void ReadDbMetadata()
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
					foreignKeys = dbMetadataProvider.GetForeignKeys().ToArray();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					primaryKeys = dbMetadataProvider.GetPrimaryKeys().ToArray();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					indexes = dbMetadataProvider.GetIndexes().ToArray();
					num2 = 2;
					continue;
				case 4:
					break;
				case 2:
					return;
				}
				break;
			}
			c7oAZrWXfhJrTnAFeIaV(logger, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541842273));
			num = 3;
		}
	}

	public void CreateNonStandardIndex(string indexName, string tableName, string query)
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 4:
				return;
			case 1:
				if (ph9COfWXQSI9VojbsQJ1(transform, tableName, indexName))
				{
					num2 = 4;
					continue;
				}
				break;
			case 2:
				logger.DebugFormat((string)lr3cdpWXGhL6a8aNFBBC(0x53CACA3 ^ 0x53D5BE5), indexName, tableName, query);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			transform.ExecuteNonQuery(query);
			num2 = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
			{
				num2 = 1;
			}
		}
	}

	public void CreateStandardIndex(Index index, bool isUnique = false)
	{
		//Discarded unreachable code: IL_00e0, IL_00ea, IL_00f9, IL_0155, IL_0169
		int num = 8;
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			object obj2;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 3:
					logger.DebugFormat((string)lr3cdpWXGhL6a8aNFBBC(-1876063057 ^ -1876133045), text, OelBAFWXCPI5bKNQeR59(index), text2, N2bf4PWXvVePpgZvkB9k(index));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					y0IdwNWX8yW9CuqLCx89(transform, index);
					num2 = 6;
					continue;
				case 1:
					if (!isUnique)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 2;
				case 4:
					return;
				case 7:
					obj2 = "";
					goto end_IL_0012;
				case 6:
					return;
				case 9:
					transform.AddIndex(index);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 3;
					}
					continue;
				case 8:
					if (index.Columns == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					obj2 = string.Join((string)lr3cdpWXGhL6a8aNFBBC(0x34185E55 ^ 0x34180CA5), index.Columns.Select((string c) => (string)_003C_003Ec.C5xYtoQwMi18vEjZOBea(0x463A0F3C ^ 0x463A1264) + c + (string)_003C_003Ec.C5xYtoQwMi18vEjZOBea(0x1C9495B4 ^ 0x1C9488EC)));
					goto end_IL_0012;
				default:
					obj = "";
					break;
				case 10:
					if (isUnique)
					{
						num2 = 5;
						continue;
					}
					goto default;
				case 5:
					obj = lr3cdpWXGhL6a8aNFBBC(-1978478350 ^ -1978456288);
					break;
				}
				text = (string)obj;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 3;
				}
				continue;
				end_IL_0012:
				break;
			}
			text2 = (string)obj2;
			num = 10;
		}
	}

	public void MarkDroppingIndex(Index droppingIndex)
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
				droppingIndexes.Add(droppingIndex);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void MarkDroppingIndex(string indexName, string tableName)
	{
		int num = 2;
		int num2 = num;
		Index item = default(Index);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				droppingIndexes.Add(item);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
			{
				Index index = new Index();
				BWkag1WXZ3TvKUSJ8dM1(index, indexName);
				t8OnHHWXuKBut4a2fTae(index, tableName);
				index.Columns = new List<string>();
				item = index;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 1;
				}
				break;
			}
			}
		}
	}

	public void MarkTouchedDbMetadata(string tableName, string columnName = null)
	{
		//Discarded unreachable code: IL_0074, IL_0176, IL_01ae, IL_01bd, IL_022e, IL_02d8, IL_02e2, IL_03a4, IL_03dc, IL_03ff, IL_040e, IL_0419, IL_0567, IL_0586, IL_0595, IL_05c2, IL_05d1
		int num = 2;
		int num2 = num;
		IEnumerable<ForeignKey> dependantForeignKeys = default(IEnumerable<ForeignKey>);
		IEnumerator<Index> enumerator3 = default(IEnumerator<Index>);
		string text4 = default(string);
		Index current3 = default(Index);
		string text3 = default(string);
		IEnumerable<Index> dependantIndexes = default(IEnumerable<Index>);
		IEnumerable<PrimaryKey> dependantPrimaryKeys = default(IEnumerable<PrimaryKey>);
		IEnumerator<PrimaryKey> enumerator2 = default(IEnumerator<PrimaryKey>);
		PrimaryKey current2 = default(PrimaryKey);
		IEnumerator<ForeignKey> enumerator = default(IEnumerator<ForeignKey>);
		string text2 = default(string);
		ForeignKey current = default(ForeignKey);
		string text = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 10:
				AppendDroppingForeignKeys(dependantForeignKeys);
				num2 = 15;
				continue;
			case 11:
				try
				{
					while (true)
					{
						IL_0136:
						int num8;
						if (!sPSqMrWXqyGAY7VrepkI(enumerator3))
						{
							int num7 = 4;
							num8 = num7;
							goto IL_0082;
						}
						goto IL_00c8;
						IL_0082:
						while (true)
						{
							switch (num8)
							{
							default:
								text4 = string.Join((string)lr3cdpWXGhL6a8aNFBBC(-35995181 ^ -36007133), current3.Columns);
								num8 = 3;
								continue;
							case 2:
								break;
							case 3:
								logger.DebugFormat((string)lr3cdpWXGhL6a8aNFBBC(-1998538950 ^ -1998500288), OelBAFWXCPI5bKNQeR59(current3), text4);
								num8 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
								{
									num8 = 1;
								}
								continue;
							case 1:
								goto IL_0136;
							case 4:
								goto end_IL_0136;
							}
							break;
						}
						goto IL_00c8;
						IL_00c8:
						current3 = enumerator3.Current;
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num8 = 0;
						}
						goto IL_0082;
						continue;
						end_IL_0136:
						break;
					}
				}
				finally
				{
					if (enumerator3 != null)
					{
						int num9 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num9 = 1;
						}
						while (true)
						{
							switch (num9)
							{
							case 1:
								kuQaNJWXKlZ5Rmcwxj9A(enumerator3);
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
								{
									num9 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				goto case 3;
			case 13:
				c7oAZrWXfhJrTnAFeIaV(logger, text3);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 9;
				}
				continue;
			case 2:
				dependantForeignKeys = GetDependantForeignKeys(tableName, columnName);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 0;
				}
				continue;
			case 12:
				obj = mmdFCuWXIoot7LU5Hi4h(lr3cdpWXGhL6a8aNFBBC(0x463A0F3C ^ 0x463BF756), tableName);
				break;
			case 15:
				AppendDroppingIndexes(dependantIndexes);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 5;
				}
				continue;
			case 6:
				return;
			case 8:
				if (columnName == null)
				{
					num2 = 12;
					continue;
				}
				obj = KFaGuTWXVcap6lxmhqxS(lr3cdpWXGhL6a8aNFBBC(0x10E41EDB ^ 0x10E5E67F), columnName, tableName);
				break;
			case 4:
				enumerator3 = dependantIndexes.GetEnumerator();
				num2 = 11;
				continue;
			case 5:
				AppendDroppingPrimaryKeys(dependantPrimaryKeys);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				dependantIndexes = GetDependantIndexes(tableName, columnName);
				num2 = 14;
				continue;
			case 3:
				enumerator2 = dependantPrimaryKeys.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 0;
				}
				continue;
			default:
				try
				{
					while (true)
					{
						IL_0323:
						int num5;
						if (!sPSqMrWXqyGAY7VrepkI(enumerator2))
						{
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
							{
								num5 = 1;
							}
							goto IL_02e6;
						}
						goto IL_0300;
						IL_0300:
						current2 = enumerator2.Current;
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num5 = 0;
						}
						goto IL_02e6;
						IL_02e6:
						while (true)
						{
							switch (num5)
							{
							case 3:
								break;
							case 2:
								goto IL_0323;
							default:
								logger.DebugFormat((string)lr3cdpWXGhL6a8aNFBBC(-675505729 ^ -675454961), l67FwpWXXX9xJEo6EXbJ(current2));
								num5 = 2;
								continue;
							case 1:
								goto end_IL_0323;
							}
							break;
						}
						goto IL_0300;
						continue;
						end_IL_0323:
						break;
					}
				}
				finally
				{
					if (enumerator2 != null)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								kuQaNJWXKlZ5Rmcwxj9A(enumerator2);
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
								{
									num6 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 10;
			case 9:
				enumerator = dependantForeignKeys.GetEnumerator();
				num2 = 7;
				continue;
			case 7:
				try
				{
					while (true)
					{
						IL_053b:
						int num3;
						if (!sPSqMrWXqyGAY7VrepkI(enumerator))
						{
							num3 = 2;
							goto IL_041d;
						}
						goto IL_0518;
						IL_041d:
						while (true)
						{
							switch (num3)
							{
							default:
								text2 = string.Join((string)lr3cdpWXGhL6a8aNFBBC(0x53CACA3 ^ 0x53CFE53), current.RefColumns);
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
								{
									num3 = 3;
								}
								continue;
							case 1:
								text = string.Join((string)lr3cdpWXGhL6a8aNFBBC(-475857671 ^ -475877879), current.Columns);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
								{
									num3 = 0;
								}
								continue;
							case 5:
								logger.DebugFormat((string)lr3cdpWXGhL6a8aNFBBC(-2099751081 ^ -2099662935), Ij5eDuWXSTNOZgJbUo25(current), ATQvRiWXiSoEdwmDyoFc(current), text, H7OshIWXRKjDqIh56KO1(current), text2);
								num3 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
								break;
							case 4:
								goto IL_053b;
							case 2:
								goto end_IL_053b;
							}
							break;
						}
						goto IL_0518;
						IL_0518:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num3 = 0;
						}
						goto IL_041d;
						continue;
						end_IL_053b:
						break;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 2;
						goto IL_056b;
					}
					goto IL_05a0;
					IL_056b:
					switch (num4)
					{
					default:
						goto end_IL_0556;
					case 2:
						goto end_IL_0556;
					case 1:
						break;
					case 0:
						goto end_IL_0556;
					}
					goto IL_05a0;
					IL_05a0:
					enumerator.Dispose();
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num4 = 0;
					}
					goto IL_056b;
					end_IL_0556:;
				}
				goto case 4;
			case 14:
				dependantPrimaryKeys = GetDependantPrimaryKeys(tableName, columnName);
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 8;
				}
				continue;
			}
			text3 = (string)obj;
			num2 = 13;
		}
	}

	public void OnMigrationStart()
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
			case 1:
				c7oAZrWXfhJrTnAFeIaV(logger, lr3cdpWXGhL6a8aNFBBC(-2107978722 ^ -2107951624));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				startTime = DateTime.Now;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void OnMigrationEnd()
	{
		int num = 2;
		TimeSpan timeSpan = default(TimeSpan);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 3:
					logger.DebugFormat((string)lr3cdpWXGhL6a8aNFBBC(-1426094279 ^ -1426162409), timeSpan);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					break;
				case 2:
					timeSpan = PZYdEjWXT8xsGwC6BQsd() - startTime;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			logger.Debug(lr3cdpWXGhL6a8aNFBBC(0x49E27B8A ^ 0x49E38186));
			num = 3;
		}
	}

	public void OnIndexesDropped()
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
				logger.DebugFormat((string)lr3cdpWXGhL6a8aNFBBC(-978351861 ^ -978422947), EVyqlLWXk2pPeIx2CYX1(droppingPrimaryKeys), primaryKeys.Length, YXNk7JWXnpHtdb0h3vsN(droppingForeignKeys), foreignKeys.Length, droppingIndexes.Count, indexes.Length);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void DropMarkedForeignKeys()
	{
		//Discarded unreachable code: IL_003a, IL_0049, IL_0054, IL_010a, IL_011d, IL_012c, IL_01b1, IL_01c0, IL_030e, IL_0321, IL_0330
		int num = 5;
		int num2 = num;
		List<ForeignKey>.Enumerator enumerator = default(List<ForeignKey>.Enumerator);
		ForeignKey current2 = default(ForeignKey);
		ForeignKey current = default(ForeignKey);
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					while (true)
					{
						int num6;
						if (!enumerator.MoveNext())
						{
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
							{
								num6 = 2;
							}
							goto IL_0058;
						}
						goto IL_00bb;
						IL_00bb:
						current2 = enumerator.Current;
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num6 = 1;
						}
						goto IL_0058;
						IL_0058:
						while (true)
						{
							switch (num6)
							{
							case 1:
								xLV8KiWXOQL9KsADjtRa(transform, ATQvRiWXiSoEdwmDyoFc(current2), Ij5eDuWXSTNOZgJbUo25(current2));
								num6 = 3;
								continue;
							case 3:
								break;
							default:
								goto IL_00bb;
							case 2:
								return;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
				}
			case 5:
				c7oAZrWXfhJrTnAFeIaV(logger, lr3cdpWXGhL6a8aNFBBC(-345420348 ^ -345459132));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 4;
				}
				continue;
			case 4:
				enumerator = droppingForeignKeys.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
				return;
			case 1:
				try
				{
					while (true)
					{
						IL_025f:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							goto IL_01cb;
						}
						goto IL_024c;
						IL_01cb:
						int num4 = num3;
						goto IL_01cf;
						IL_024c:
						current = enumerator.Current;
						num4 = 4;
						goto IL_01cf;
						IL_01cf:
						while (true)
						{
							switch (num4)
							{
							case 4:
								text = string.Join((string)lr3cdpWXGhL6a8aNFBBC(0x12441CA4 ^ 0x12444E54), current.Columns);
								num4 = 5;
								continue;
							case 5:
								break;
							default:
								goto IL_024c;
							case 1:
								goto IL_025f;
							case 2:
								logger.DebugFormat((string)lr3cdpWXGhL6a8aNFBBC(0x49E27B8A ^ 0x49E3803C), Ij5eDuWXSTNOZgJbUo25(current), ATQvRiWXiSoEdwmDyoFc(current), text, current.RefTableName, text2);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
								{
									num4 = 1;
								}
								continue;
							case 3:
								goto end_IL_025f;
							}
							break;
						}
						text2 = string.Join((string)lr3cdpWXGhL6a8aNFBBC(-978351861 ^ -978330629), current.RefColumns);
						num3 = 2;
						goto IL_01cb;
						continue;
						end_IL_025f:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				break;
			}
			enumerator = droppingForeignKeys.GetEnumerator();
			num2 = 3;
		}
	}

	public void DropMarkedPrimaryKeys()
	{
		//Discarded unreachable code: IL_003a, IL_0049, IL_0054, IL_016d, IL_0180, IL_01a8, IL_01b7, IL_027c, IL_028f, IL_029e
		int num = 2;
		int num2 = num;
		List<PrimaryKey>.Enumerator enumerator = default(List<PrimaryKey>.Enumerator);
		PrimaryKey current = default(PrimaryKey);
		PrimaryKey current2 = default(PrimaryKey);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
							{
								num3 = 1;
							}
							goto IL_0058;
						}
						goto IL_011e;
						IL_011e:
						current = enumerator.Current;
						num3 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num3 = 1;
						}
						goto IL_0058;
						IL_0058:
						while (true)
						{
							switch (num3)
							{
							case 3:
								logger.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A8045EE), l67FwpWXXX9xJEo6EXbJ(current), JlFWt8WX22hB5voVjvrC(current));
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
								{
									num3 = 0;
								}
								continue;
							case 4:
								string.Join((string)lr3cdpWXGhL6a8aNFBBC(0x49E27B8A ^ 0x49E2297A), current.Columns);
								num3 = 3;
								continue;
							case 2:
								break;
							default:
								goto IL_011e;
							case 1:
								goto end_IL_00f8;
							}
							break;
						}
						continue;
						end_IL_00f8:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
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
			case 1:
				enumerator = droppingPrimaryKeys.GetEnumerator();
				num2 = 3;
				continue;
			case 0:
				return;
			case 5:
				try
				{
					while (true)
					{
						int num5;
						if (!enumerator.MoveNext())
						{
							num5 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
							{
								num5 = 3;
							}
							goto IL_01c6;
						}
						goto IL_0206;
						IL_0206:
						current2 = enumerator.Current;
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num5 = 1;
						}
						goto IL_01c6;
						IL_01c6:
						while (true)
						{
							switch (num5)
							{
							case 3:
								return;
							case 2:
								break;
							default:
								goto IL_0206;
							case 1:
							{
								HPGEGnWXeAphfOX4ZJLk(transform, JlFWt8WX22hB5voVjvrC(current2), l67FwpWXXX9xJEo6EXbJ(current2));
								int num6 = 2;
								num5 = num6;
								continue;
							}
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
				}
			case 2:
				c7oAZrWXfhJrTnAFeIaV(logger, lr3cdpWXGhL6a8aNFBBC(0x20261A4F ^ 0x2027E66B));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 1;
				}
				continue;
			case 4:
				break;
			}
			enumerator = droppingPrimaryKeys.GetEnumerator();
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
			{
				num2 = 5;
			}
		}
	}

	public void DropMarkedIndexes()
	{
		//Discarded unreachable code: IL_009c, IL_00ab, IL_01c3, IL_01d6, IL_020e, IL_021d, IL_0228, IL_02ce, IL_02e1
		int num = 5;
		int num2 = num;
		List<Index>.Enumerator enumerator = default(List<Index>.Enumerator);
		Index current2 = default(Index);
		string text = default(string);
		Index current = default(Index);
		while (true)
		{
			switch (num2)
			{
			case 4:
				enumerator = droppingIndexes.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				logger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -672020089));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 1;
				}
				break;
			default:
				try
				{
					while (true)
					{
						IL_0171:
						int num5;
						if (!enumerator.MoveNext())
						{
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
							{
								num5 = 0;
							}
							goto IL_00ba;
						}
						goto IL_0104;
						IL_0104:
						current2 = enumerator.Current;
						num5 = 4;
						goto IL_00ba;
						IL_00ba:
						while (true)
						{
							switch (num5)
							{
							case 4:
							{
								text = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837683573), current2.Columns);
								int num6 = 2;
								num5 = num6;
								continue;
							}
							case 1:
								goto IL_0104;
							case 2:
								logger.DebugFormat((string)lr3cdpWXGhL6a8aNFBBC(-70037984 ^ -70077752), OelBAFWXCPI5bKNQeR59(current2), N2bf4PWXvVePpgZvkB9k(current2), text);
								num5 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
								{
									num5 = 1;
								}
								continue;
							case 3:
								goto IL_0171;
							case 0:
								break;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
				}
				goto case 3;
			case 2:
				return;
			case 3:
				enumerator = droppingIndexes.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					while (true)
					{
						IL_0259:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
							{
								num3 = 0;
							}
							goto IL_022c;
						}
						goto IL_0246;
						IL_0246:
						current = enumerator.Current;
						num3 = 3;
						goto IL_022c;
						IL_022c:
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								break;
							case 2:
								goto IL_0259;
							case 3:
								transform.RemoveIndex((string)N2bf4PWXvVePpgZvkB9k(current), (string)OelBAFWXCPI5bKNQeR59(current));
								num3 = 2;
								continue;
							}
							break;
						}
						goto IL_0246;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			}
		}
	}

	private void AppendDroppingForeignKeys(IEnumerable<ForeignKey> foreignKeys)
	{
		droppingForeignKeys.AddRange(foreignKeys.Except(droppingForeignKeys, foreignKeyComparer));
	}

	private void AppendDroppingIndexes(IEnumerable<Index> indexes)
	{
		droppingIndexes.AddRange(indexes.Except(droppingIndexes, indexComparer));
	}

	private void AppendDroppingPrimaryKeys(IEnumerable<PrimaryKey> primaryKeys)
	{
		droppingPrimaryKeys.AddRange(primaryKeys.Except(droppingPrimaryKeys, primaryKeyComparer));
	}

	private IEnumerable<ForeignKey> GetDependantForeignKeys(string tableName, string columnName = null)
	{
		_003C_003Ec__DisplayClass29_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass29_0();
		CS_0024_003C_003E8__locals0.tableName = tableName;
		CS_0024_003C_003E8__locals0.columnName = columnName;
		CS_0024_003C_003E8__locals0.tableName = dbMetadataProvider.GetAsDbIdentifier(CS_0024_003C_003E8__locals0.tableName);
		CS_0024_003C_003E8__locals0.columnName = dbMetadataProvider.GetAsDbIdentifier(CS_0024_003C_003E8__locals0.columnName);
		CS_0024_003C_003E8__locals0.isNullColumnName = string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.columnName);
		return foreignKeys.Where(delegate(ForeignKey fk)
		{
			//Discarded unreachable code: IL_0071, IL_0080, IL_00b0, IL_00bf
			int num = 5;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (!_003C_003Ec__DisplayClass29_0.SSDDaPQwghfAc6dJsTDx(_003C_003Ec__DisplayClass29_0.bL2b7lQwrg4jE782cNsu(fk), CS_0024_003C_003E8__locals0.tableName))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 3;
				case 1:
					if (fk.Columns.Contains(CS_0024_003C_003E8__locals0.columnName))
					{
						num2 = 2;
						break;
					}
					goto case 4;
				case 4:
				case 6:
					if (!_003C_003Ec__DisplayClass29_0.SSDDaPQwghfAc6dJsTDx(_003C_003Ec__DisplayClass29_0.fYu1XeQw5PyDRldUgmZr(fk), CS_0024_003C_003E8__locals0.tableName))
					{
						return false;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					break;
				case 7:
					return fk.RefColumns.Contains(CS_0024_003C_003E8__locals0.columnName);
				case 2:
					return true;
				case 3:
					if (!CS_0024_003C_003E8__locals0.isNullColumnName)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 2;
				default:
					if (CS_0024_003C_003E8__locals0.isNullColumnName)
					{
						return true;
					}
					num2 = 7;
					break;
				}
			}
		});
	}

	private IEnumerable<Index> GetDependantIndexes(string tableName, string columnName = null)
	{
		_003C_003Ec__DisplayClass30_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass30_0();
		CS_0024_003C_003E8__locals0.tableName = tableName;
		CS_0024_003C_003E8__locals0.columnName = columnName;
		CS_0024_003C_003E8__locals0.tableName = dbMetadataProvider.GetAsDbIdentifier(CS_0024_003C_003E8__locals0.tableName);
		CS_0024_003C_003E8__locals0.columnName = dbMetadataProvider.GetAsDbIdentifier(CS_0024_003C_003E8__locals0.columnName);
		CS_0024_003C_003E8__locals0.isNullColumnName = string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.columnName);
		return indexes.Where(delegate(Index idx)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!_003C_003Ec__DisplayClass30_0.Bi0CUJQwcitnUnORY7hE(_003C_003Ec__DisplayClass30_0.tQvmlmQwsCcYjuEvi8ak(idx), CS_0024_003C_003E8__locals0.tableName))
					{
						return false;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return idx.Columns.Contains(CS_0024_003C_003E8__locals0.columnName);
				default:
					if (CS_0024_003C_003E8__locals0.isNullColumnName)
					{
						return true;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		});
	}

	private IEnumerable<PrimaryKey> GetDependantPrimaryKeys(string tableName, string columnName = null)
	{
		_003C_003Ec__DisplayClass31_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass31_0();
		CS_0024_003C_003E8__locals0.tableName = tableName;
		CS_0024_003C_003E8__locals0.columnName = columnName;
		CS_0024_003C_003E8__locals0.tableName = dbMetadataProvider.GetAsDbIdentifier(CS_0024_003C_003E8__locals0.tableName);
		CS_0024_003C_003E8__locals0.columnName = dbMetadataProvider.GetAsDbIdentifier(CS_0024_003C_003E8__locals0.columnName);
		CS_0024_003C_003E8__locals0.isNullColumnName = string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.columnName);
		return primaryKeys.Where(delegate(PrimaryKey pk)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return pk.Columns.Contains(CS_0024_003C_003E8__locals0.columnName);
				case 1:
					if (CS_0024_003C_003E8__locals0.isNullColumnName)
					{
						return true;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (!_003C_003Ec__DisplayClass31_0.SedAT8Q4oIibTeCEQohF(_003C_003Ec__DisplayClass31_0.iT1ihAQ4WiZRt8h9ai6A(pk), CS_0024_003C_003E8__locals0.tableName))
					{
						return false;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		});
	}

	internal static void BF2AJ2WXhrXEPiH619Z0()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object lr3cdpWXGhL6a8aNFBBC(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object LvRwyxWXEyyQYNQXJrTS(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}

	internal static bool U9hy0yWXoYw24MWoNo4D()
	{
		return ewQcXiWXWwBNLY7sUW6p == null;
	}

	internal static DbMigrator rMewIuWXbnhdCdGXlZvE()
	{
		return ewQcXiWXWwBNLY7sUW6p;
	}

	internal static void c7oAZrWXfhJrTnAFeIaV(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static bool ph9COfWXQSI9VojbsQJ1(object P_0, object P_1, object P_2)
	{
		return ((ITransformationProvider)P_0).IndexExists((string)P_1, (string)P_2);
	}

	internal static object OelBAFWXCPI5bKNQeR59(object P_0)
	{
		return ((Index)P_0).Name;
	}

	internal static object N2bf4PWXvVePpgZvkB9k(object P_0)
	{
		return ((Index)P_0).TableName;
	}

	internal static void y0IdwNWX8yW9CuqLCx89(object P_0, object P_1)
	{
		((ITransformationProvider)P_0).AddUniqueIndex((Index)P_1);
	}

	internal static void BWkag1WXZ3TvKUSJ8dM1(object P_0, object P_1)
	{
		((Index)P_0).Name = (string)P_1;
	}

	internal static void t8OnHHWXuKBut4a2fTae(object P_0, object P_1)
	{
		((Index)P_0).TableName = (string)P_1;
	}

	internal static object mmdFCuWXIoot7LU5Hi4h(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object KFaGuTWXVcap6lxmhqxS(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object Ij5eDuWXSTNOZgJbUo25(object P_0)
	{
		return ((ForeignKey)P_0).Name;
	}

	internal static object ATQvRiWXiSoEdwmDyoFc(object P_0)
	{
		return ((ForeignKey)P_0).TableName;
	}

	internal static object H7OshIWXRKjDqIh56KO1(object P_0)
	{
		return ((ForeignKey)P_0).RefTableName;
	}

	internal static bool sPSqMrWXqyGAY7VrepkI(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void kuQaNJWXKlZ5Rmcwxj9A(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object l67FwpWXXX9xJEo6EXbJ(object P_0)
	{
		return ((PrimaryKey)P_0).Name;
	}

	internal static DateTime PZYdEjWXT8xsGwC6BQsd()
	{
		return DateTime.Now;
	}

	internal static int EVyqlLWXk2pPeIx2CYX1(object P_0)
	{
		return ((List<PrimaryKey>)P_0).Count;
	}

	internal static int YXNk7JWXnpHtdb0h3vsN(object P_0)
	{
		return ((List<ForeignKey>)P_0).Count;
	}

	internal static void xLV8KiWXOQL9KsADjtRa(object P_0, object P_1, object P_2)
	{
		((ITransformationProvider)P_0).RemoveForeignKey((string)P_1, (string)P_2);
	}

	internal static object JlFWt8WX22hB5voVjvrC(object P_0)
	{
		return ((PrimaryKey)P_0).TableName;
	}

	internal static void HPGEGnWXeAphfOX4ZJLk(object P_0, object P_1, object P_2)
	{
		((ITransformationProvider)P_0).RemovePrimaryKey((string)P_1, (string)P_2);
	}
}
