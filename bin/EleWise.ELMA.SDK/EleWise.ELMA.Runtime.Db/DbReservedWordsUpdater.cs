using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db;

[Component(Order = -10)]
internal class DbReservedWordsUpdater : DbUpdateHandler
{
	private List<string> oldReservedWords;

	private List<string> newReservedWords;

	private bool hasChanges;

	private readonly Dictionary<Guid, EntityMetadata> prevMetadata;

	internal static DbReservedWordsUpdater cOUtv4Wv5DeSUhdWbbqD;

	private IEnumerable<EntityMetadata> AllEnitityMetadata => MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>();

	public IMetadataRuntimeService MetadataService
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadataService_003Ek__BackingField;
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
					_003CMetadataService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override Guid ProviderUid => Guid.Empty;

	public override bool HasChanges => hasChanges;

	public override bool NeedRecreateConstraints => hasChanges;

	public override void Init()
	{
		//Discarded unreachable code: IL_0083, IL_0092, IL_0131, IL_0140
		int num = 10;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 8:
					return;
				case 9:
					InitReservedWords();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 3;
					}
					continue;
				case 5:
					return;
				default:
					if (newReservedWords.Count != 0)
					{
						if (oldReservedWords == null)
						{
							return;
						}
						num2 = 4;
					}
					else
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
						{
							num2 = 2;
						}
					}
					continue;
				case 2:
					return;
				case 10:
					base.Init();
					num2 = 9;
					continue;
				case 4:
					if (QKfGdjWvLb5L77tAPK9H(oldReservedWords) <= 0)
					{
						num2 = 5;
						continue;
					}
					break;
				case 6:
					break;
				case 3:
					if (newReservedWords == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto default;
				case 7:
					FillDbActions(AllEnitityMetadata, prevMetadata, newReservedWords);
					num2 = 2;
					continue;
				}
				break;
			}
			LoadPreviousMetadata();
			num = 7;
		}
	}

	public override void CreateInitialStructures()
	{
		//Discarded unreachable code: IL_00ff, IL_015c, IL_0199, IL_01a8
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				base.CreateInitialStructures();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				if (!bSNxiJWvsZO2ViHriAqi(base.Transform, GcrTyJWvU4CaDo91xeK1(-195614443 ^ -195656123)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					continue;
				}
				return;
			case 1:
				return;
			}
			try
			{
				Table table = new Table();
				TJn5x9WvcXPAcRlU2Bai(table, false);
				I8TrxPWvzjcuwdQBURtW(table, GcrTyJWvU4CaDo91xeK1(-29254301 ^ -29347277));
				table.Columns = new List<Column>
				{
					new Column((string)GcrTyJWvU4CaDo91xeK1(-1867198571 ^ -1867161571), DbType.String, int.MaxValue)
				};
				Table table2 = table;
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
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
					vMpeSfW8FPfWr9rttlFO(base.Transform, table2);
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num3 = 1;
					}
				}
			}
			catch
			{
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num4 = 1;
				}
				while (true)
				{
					switch (num4)
					{
					case 1:
						base.Transform.RollbackTransaction();
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num4 = 0;
						}
						break;
					default:
						throw;
					}
				}
			}
		}
	}

	public override void OnComplete()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				SetReservedWords(newReservedWords.Union(oldReservedWords));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				base.OnComplete();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected void FillDbActions(IEnumerable<EntityMetadata> allMetadata, Dictionary<Guid, EntityMetadata> oldMetadata, List<string> reservedWords)
	{
		using IEnumerator<EntityMetadata> enumerator = allMetadata.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass19_0();
			CS_0024_003C_003E8__locals0.metadata = enumerator.Current;
			if (CS_0024_003C_003E8__locals0.metadata.Type != EntityMetadataType.InterfaceImplementation || !oldMetadata.ContainsKey(CS_0024_003C_003E8__locals0.metadata.Uid))
			{
				continue;
			}
			if (reservedWords.Any((string rw) => _003C_003Ec__DisplayClass19_0.HZUyy4Q30IRgrQSrqWDa(StringComparer.OrdinalIgnoreCase, rw, CS_0024_003C_003E8__locals0.metadata.TableName)))
			{
				base.TablesCreatedActions.Add(new DbRenameTableAction(base.Transform, CS_0024_003C_003E8__locals0.metadata.TableName, CS_0024_003C_003E8__locals0.metadata.TableName));
				hasChanges = true;
			}
			foreach (PropertyMetadata property in CS_0024_003C_003E8__locals0.metadata.Properties)
			{
				_003C_003Ec__DisplayClass19_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass19_1();
				CS_0024_003C_003E8__locals1.simpleTypeSettings = property.Settings as SimpleTypeSettings;
				if (CS_0024_003C_003E8__locals1.simpleTypeSettings != null && reservedWords.Any((string rw) => _003C_003Ec__DisplayClass19_1.CCdfXEQ3l1WNyNF3ycaM(_003C_003Ec__DisplayClass19_1.nX7VKGQ39ctfrFDrfyGu(), rw, _003C_003Ec__DisplayClass19_1.qIhTleQ3dbd1Tt96m8mN(CS_0024_003C_003E8__locals1.simpleTypeSettings))))
				{
					base.TablesCreatedActions.Add(new DbRenameColumnAction(base.Transform, CS_0024_003C_003E8__locals0.metadata.TableName, CS_0024_003C_003E8__locals1.simpleTypeSettings.FieldName, CS_0024_003C_003E8__locals1.simpleTypeSettings.FieldName));
					hasChanges = true;
				}
				CS_0024_003C_003E8__locals1.entitySettings = property.Settings as EntitySettings;
				if (CS_0024_003C_003E8__locals1.entitySettings != null)
				{
					if (reservedWords.Any((string rw) => _003C_003Ec__DisplayClass19_1.CCdfXEQ3l1WNyNF3ycaM(_003C_003Ec__DisplayClass19_1.nX7VKGQ39ctfrFDrfyGu(), rw, _003C_003Ec__DisplayClass19_1.NFhe7SQ3r6YKsw64JN4r(CS_0024_003C_003E8__locals1.entitySettings))))
					{
						base.TablesCreatedActions.Add(new DbRenameTableAction(base.Transform, CS_0024_003C_003E8__locals1.entitySettings.RelationTableName, CS_0024_003C_003E8__locals1.entitySettings.RelationTableName));
						hasChanges = true;
					}
					if (reservedWords.Any((string rw) => _003C_003Ec__DisplayClass19_1.CCdfXEQ3l1WNyNF3ycaM(StringComparer.OrdinalIgnoreCase, rw, _003C_003Ec__DisplayClass19_1.rVCADlQ3gk4WtS7HQRXS(CS_0024_003C_003E8__locals1.entitySettings))))
					{
						base.TablesCreatedActions.Add(new DbRenameColumnAction(base.Transform, CS_0024_003C_003E8__locals1.entitySettings.RelationTableName, CS_0024_003C_003E8__locals1.entitySettings.ParentColumnName, CS_0024_003C_003E8__locals1.entitySettings.ParentColumnName));
						hasChanges = true;
					}
					if (reservedWords.Any((string rw) => _003C_003Ec__DisplayClass19_1.CCdfXEQ3l1WNyNF3ycaM(_003C_003Ec__DisplayClass19_1.nX7VKGQ39ctfrFDrfyGu(), rw, CS_0024_003C_003E8__locals1.entitySettings.ChildColumnName)))
					{
						base.TablesCreatedActions.Add(new DbRenameColumnAction(base.Transform, CS_0024_003C_003E8__locals1.entitySettings.RelationTableName, CS_0024_003C_003E8__locals1.entitySettings.ChildColumnName, CS_0024_003C_003E8__locals1.entitySettings.ChildColumnName));
						hasChanges = true;
					}
				}
			}
		}
	}

	private void InitReservedWords()
	{
		//Discarded unreachable code: IL_00ba, IL_00c9, IL_00d9
		int num = 2;
		int num2 = num;
		List<string> source = default(List<string>);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (QKfGdjWvLb5L77tAPK9H(oldReservedWords) != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 5:
			case 6:
				newReservedWords = source;
				num2 = 8;
				break;
			case 8:
				return;
			default:
				newReservedWords = source.Where((string a) => !oldReservedWords.Contains(a)).ToList();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 3;
				}
				break;
			case 4:
				if (oldReservedWords == null)
				{
					num2 = 5;
					break;
				}
				goto case 7;
			case 2:
				InitOldReservedWords();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			case 1:
				source = ((Dialect)L13FvjW8BMkvIH1UySSt(base.Transform)).ReservedWords.Where((string a) => !string.IsNullOrEmpty(a)).ToList();
				num2 = 4;
				break;
			}
		}
	}

	private void InitOldReservedWords()
	{
		//Discarded unreachable code: IL_004f, IL_0103, IL_013b, IL_014a
		int num = 2;
		int num2 = num;
		IDataReader dataReader = default(IDataReader);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					if (!dataReader.Read())
					{
						return;
					}
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							oldReservedWords = GetReservedWords(zOT93AW8b1bJld54IlYu(dataReader, GcrTyJWvU4CaDo91xeK1(-289714582 ^ -289742366)).ToString());
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
							{
								num3 = 1;
							}
							break;
						default:
							if (!(dataReader[(string)GcrTyJWvU4CaDo91xeK1(0x7E6E5A0B ^ 0x7E6FF583)] is DBNull))
							{
								num3 = 2;
								break;
							}
							return;
						case 1:
							return;
						}
					}
				}
				finally
				{
					if (dataReader != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								UDiUpSW8hecK6Kxvp8n1(dataReader);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
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
			case 0:
				return;
			case 2:
				dataReader = base.Transform.ExecuteQuery((string)oA8NGCW8oykfBgqrOLft(GcrTyJWvU4CaDo91xeK1(0x5F3078B6 ^ 0x5F31D71E), NAIIIMW8WKao84MDJtaY(L13FvjW8BMkvIH1UySSt(base.Transform), GcrTyJWvU4CaDo91xeK1(-234299632 ^ -234262376)), NAIIIMW8WKao84MDJtaY(base.Transform.Dialect, GcrTyJWvU4CaDo91xeK1(0x3CE17B75 ^ 0x3CE0D425))));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private List<string> GetReservedWords(string reservedWords)
	{
		return (from a in reservedWords.Split('\'')
			where !_003C_003Ec.T9kuS8Q3UuKhClcYMqRH(a)
			select a).ToList() ?? new List<string>();
	}

	private void SetReservedWords(IEnumerable<string> reservedWords)
	{
		SetReservedWords(string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3327676), reservedWords));
	}

	private void SetReservedWords(string reservedWords)
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
				base.Transform.ExecuteNonQuery(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A0CBDD) + (string)NAIIIMW8WKao84MDJtaY(L13FvjW8BMkvIH1UySSt(base.Transform), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541819687)));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				base.Transform.Insert((string)GcrTyJWvU4CaDo91xeK1(-538519530 ^ -538478778), new string[1] { (string)GcrTyJWvU4CaDo91xeK1(0x12441CA4 ^ 0x1245B32C) }, new object[1] { reservedWords });
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void LoadPreviousMetadata()
	{
		//Discarded unreachable code: IL_0057, IL_0061, IL_00fc, IL_010f, IL_01a8, IL_01c7, IL_01d6, IL_0203, IL_0212
		int num = 2;
		int num2 = num;
		IEnumerator<AssemblyModelsMetadata> enumerator = default(IEnumerator<AssemblyModelsMetadata>);
		AbstractMetadata[] array = default(AbstractMetadata[]);
		AbstractMetadata metadata = default(AbstractMetadata);
		int num4 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				prevMetadata.Clear();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				try
				{
					while (true)
					{
						IL_0119:
						int num3;
						if (!FfXOvFW8E991dAq8jqQ6(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
							{
								num3 = 1;
							}
							goto IL_0065;
						}
						goto IL_00df;
						IL_00df:
						array = (AbstractMetadata[])AtXPjcW8GRMGJK3xcAwn(enumerator.Current);
						num3 = 2;
						goto IL_0065;
						IL_0065:
						while (true)
						{
							switch (num3)
							{
							case 4:
								AddMetadataToDictionary(prevMetadata, metadata);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
								{
									num3 = 0;
								}
								continue;
							default:
								num4++;
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
								{
									num3 = 5;
								}
								continue;
							case 7:
								break;
							case 9:
								goto IL_0119;
							case 6:
							case 8:
								metadata = array[num4];
								num3 = 4;
								continue;
							case 2:
								num4 = 0;
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
								{
									num3 = 3;
								}
								continue;
							case 3:
							case 5:
								if (num4 < array.Length)
								{
									num3 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
									{
										num3 = 4;
									}
									continue;
								}
								goto IL_0119;
							case 1:
								return;
							}
							break;
						}
						goto IL_00df;
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 2;
						goto IL_01ac;
					}
					goto IL_01e1;
					IL_01ac:
					switch (num5)
					{
					case 2:
						goto end_IL_0197;
					case 1:
						goto end_IL_0197;
					}
					goto IL_01e1;
					IL_01e1:
					enumerator.Dispose();
					num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num5 = 0;
					}
					goto IL_01ac;
					end_IL_0197:;
				}
			case 0:
				return;
			case 1:
				enumerator = MetadataService.GetPreviousAssemblyModelsMetadataList().GetEnumerator();
				num2 = 3;
				break;
			}
		}
	}

	private void AddMetadataToDictionary(Dictionary<Guid, EntityMetadata> dictionary, AbstractMetadata metadata)
	{
		if (metadata is EntityMetadata value)
		{
			dictionary[metadata.Uid] = value;
		}
		if (!(metadata is ICompositeMetadata compositeMetadata))
		{
			return;
		}
		IEnumerable<IMetadata> compositeParts = compositeMetadata.GetCompositeParts();
		if (compositeParts == null)
		{
			return;
		}
		foreach (IMetadata item in compositeParts)
		{
			if (item is EntityMetadata metadata2)
			{
				AddMetadataToDictionary(dictionary, metadata2);
			}
		}
	}

	public DbReservedWordsUpdater()
	{
		//Discarded unreachable code: IL_005a, IL_005f
		GglgcLW8flLlwJPZnJwM();
		oldReservedWords = new List<string>();
		newReservedWords = new List<string>();
		prevMetadata = new Dictionary<Guid, EntityMetadata>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool rGAn6dWvj7XW4hZLloFS()
	{
		return cOUtv4Wv5DeSUhdWbbqD == null;
	}

	internal static DbReservedWordsUpdater WPf6HcWvY5iyyIS0mRKC()
	{
		return cOUtv4Wv5DeSUhdWbbqD;
	}

	internal static int QKfGdjWvLb5L77tAPK9H(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static object GcrTyJWvU4CaDo91xeK1(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool bSNxiJWvsZO2ViHriAqi(object P_0, object P_1)
	{
		return ((ITransformationProvider)P_0).TableExists((string)P_1);
	}

	internal static void TJn5x9WvcXPAcRlU2Bai(object P_0, bool value)
	{
		((Table)P_0).Sequence = value;
	}

	internal static void I8TrxPWvzjcuwdQBURtW(object P_0, object P_1)
	{
		((Table)P_0).Name = (string)P_1;
	}

	internal static void vMpeSfW8FPfWr9rttlFO(object P_0, object P_1)
	{
		((ITransformationProvider)P_0).AddTable((Table)P_1);
	}

	internal static object L13FvjW8BMkvIH1UySSt(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object NAIIIMW8WKao84MDJtaY(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object oA8NGCW8oykfBgqrOLft(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object zOT93AW8b1bJld54IlYu(object P_0, object P_1)
	{
		return ((IDataRecord)P_0)[(string)P_1];
	}

	internal static void UDiUpSW8hecK6Kxvp8n1(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object AtXPjcW8GRMGJK3xcAwn(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).RestoreMetadata();
	}

	internal static bool FfXOvFW8E991dAq8jqQ6(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void GglgcLW8flLlwJPZnJwM()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
