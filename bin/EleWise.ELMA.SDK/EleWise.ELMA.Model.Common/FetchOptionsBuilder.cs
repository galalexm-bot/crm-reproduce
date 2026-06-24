using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Common;

public class FetchOptionsBuilder
{
	private static readonly Func<Guid, IEnumerable<string>, int> getColumnCountCached;

	private FetchOptions _options;

	private static FetchOptionsBuilder C3mmekhKWZI0E3igTJpr;

	private static int GetColumnCount(Guid metadataUid, IEnumerable<string> properties)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.metadata = (EntityMetadata)MetadataServiceContext.MetadataRuntimeService.GetMetadata(metadataUid);
		List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(CS_0024_003C_003E8__locals0.metadata);
		childClasses.Add(CS_0024_003C_003E8__locals0.metadata);
		int num = childClasses.SelectMany((ClassMetadata t) => t.Properties).Distinct((PropertyMetadata l, PropertyMetadata r) => l.Uid == r.Uid).Count();
		int num2 = properties.Select(delegate(string p)
		{
			int num3 = 1;
			int num4 = num3;
			ClassMetadata classMetadata = default(ClassMetadata);
			while (true)
			{
				switch (num4)
				{
				case 1:
					classMetadata = (ClassMetadata)_003C_003Ec__DisplayClass1_0.qOb2A5vbTKqQD3ltDTS4(CS_0024_003C_003E8__locals0.metadata, p);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num4 = 0;
					}
					break;
				case 2:
					return 0;
				default:
					if (classMetadata != null)
					{
						return _003C_003Ec__DisplayClass1_0.VL3IUmvbkUfYBLgR9k5E(classMetadata.Properties);
					}
					num4 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num4 = 2;
					}
					break;
				}
			}
		}).Sum();
		return num + num2;
	}

	public static FetchOptionsBuilder Create()
	{
		return new FetchOptionsBuilder();
	}

	public static FetchOptionsBuilder Create(FetchOptions f)
	{
		return new FetchOptionsBuilder(f);
	}

	public static bool IsCanOptimaze(ICriteria criteria, IEnumerable<string> properties, EntityMetadata metadata)
	{
		int setting = SR.GetSetting(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -671911795), 1000);
		return getColumnCountCached(metadata.Uid, properties) < setting;
	}

	public static void ResolveFetchColumns(ICriteria criteria, IEnumerable<string> properties, bool isProjection, ref long aliasIndex, bool usingAlias = false)
	{
		ResolveFetchColumns(criteria, properties, (SelectMode)1, usingAlias);
	}

	public static void ResolveFetchColumns(ICriteria criteria, IEnumerable<string> properties, SelectMode selectMode, bool usingAlias = false)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals0.criteria = criteria;
		CS_0024_003C_003E8__locals0.selectMode = selectMode;
		ResolveFetchColumns((object)CS_0024_003C_003E8__locals0.criteria, properties, (Action<string>)delegate(string joinPath)
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
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
					SelectModeExtensions.Fetch(CS_0024_003C_003E8__locals0.criteria, CS_0024_003C_003E8__locals0.selectMode, joinPath, (string)null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}, usingAlias);
	}

	private static void ResolveFetchColumns(object criteria, IEnumerable<string> properties, Action<string> action, bool usingAlias = false)
	{
		foreach (string property in properties)
		{
			string obj = property;
			if (!usingAlias && property.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16759773)))
			{
				string[] array = property.Split(new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740339952) }, StringSplitOptions.RemoveEmptyEntries);
				string text = "";
				for (int i = 0; i < array.Length - 1; i++)
				{
					string text2 = array[i];
					string text3 = ((!string.IsNullOrEmpty(text)) ? string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957841342), text, text2) : text2);
					ICriteria criteriaByPath = ((ICriteria)criteria).GetCriteriaByPath(text3);
					if (criteriaByPath == null)
					{
						text = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234353158), text, array[i]);
						((ICriteria)criteria).CreateAlias(text3, text, (JoinType)1);
					}
					else
					{
						text = criteriaByPath.get_Alias();
					}
				}
				obj = ((!string.IsNullOrEmpty(text)) ? string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x42647001), text, array[array.Length - 1]) : property);
			}
			action(obj);
		}
	}

	public static bool IsRefTypeColumn(EntityMetadata metadata, string name)
	{
		//Discarded unreachable code: IL_0066, IL_0075, IL_00a6, IL_014f, IL_015e
		int num = 7;
		EntitySettings entitySettings = default(EntitySettings);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		CacheEntityAttribute attribute = default(CacheEntityAttribute);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					return false;
				case 13:
					return hcyHP9hKQMnqhTtOvZmc(entitySettings) == RelationType.OneToOne;
				case 12:
					if (propertyMetadata == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				case 8:
					if (DwEOjuhKhc0TftPTK8h4(propertyMetadata.SubTypeUid, Guid.Empty))
					{
						num2 = 11;
						continue;
					}
					entitySettings = eeFuB6hKG9kyTgSIVPjC(propertyMetadata) as EntitySettings;
					num2 = 3;
					continue;
				case 6:
					_003C_003Ec__DisplayClass8_.name = name;
					num2 = 2;
					continue;
				default:
					return false;
				case 1:
					return false;
				case 5:
					break;
				case 2:
					propertyMetadata = metadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass8_._003CIsRefTypeColumn_003Eb__0);
					num2 = 12;
					continue;
				case 9:
					if (attribute != null)
					{
						num2 = 4;
						continue;
					}
					goto case 13;
				case 3:
					if (entitySettings != null)
					{
						num2 = 5;
						continue;
					}
					goto case 1;
				case 4:
					if (!Ie6jJkhKfZb4lSDry5m3(attribute))
					{
						num2 = 13;
						continue;
					}
					goto case 10;
				case 7:
					_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
					num2 = 6;
					continue;
				}
				break;
			}
			attribute = AttributeHelper<CacheEntityAttribute>.GetAttribute(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(QyQ3CXhKERXEaCPRx0t5(propertyMetadata)), inherited: true);
			num = 9;
		}
	}

	public static ClassMetadata RefTypeForColumn(EntityMetadata metadata, string name)
	{
		int num = 1;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					propertyMetadata = metadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass9_._003CRefTypeForColumn_003Eb__0);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					if (!(QyQ3CXhKERXEaCPRx0t5(propertyMetadata) == Guid.Empty))
					{
						return (ClassMetadata)MetadataLoader.LoadMetadata(propertyMetadata.SubTypeUid);
					}
					goto end_IL_0012;
				case 2:
					if (propertyMetadata != null)
					{
						num2 = 4;
						break;
					}
					goto case 5;
				case 5:
					return null;
				default:
					_003C_003Ec__DisplayClass9_.name = name;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 3;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public FetchOptionsBuilder()
	{
		//Discarded unreachable code: IL_002f, IL_0034
		pgOaN6hKCvSEu86XEGTX();
		this._002Ector(new FetchOptions());
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public FetchOptionsBuilder(FetchOptions f)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
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
			_options = f;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
			{
				num = 1;
			}
		}
	}

	public FetchOptionsBuilder(int firstResult, int maxResults)
	{
		//Discarded unreachable code: IL_0031, IL_0036
		pgOaN6hKCvSEu86XEGTX();
		this._002Ector(new FetchOptions(firstResult, maxResults));
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

	public FetchOptionsBuilder(int firstResult, int maxResults, ListSortDirection sortDirection, string sortExpression)
	{
		//Discarded unreachable code: IL_0034, IL_0039
		pgOaN6hKCvSEu86XEGTX();
		this._002Ector(new FetchOptions(firstResult, maxResults, sortDirection, sortExpression));
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

	public FetchOptionsBuilder FirstResult(int firstResult)
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
				KOifQ7hKvBL4foTfTTIF(_options, firstResult);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public FetchOptionsBuilder MaxResults(int maxResults)
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
				_options.MaxResults = maxResults;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public FetchOptionsBuilder SortDirection(ListSortDirection sortDirection)
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
				_options.SortDirection = sortDirection;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public FetchOptionsBuilder SortExpression(string sortExpression)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				GGsLQmhK8DnBBvuVgKaJ(_options, sortExpression);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return this;
			}
		}
	}

	public FetchOptionsBuilder UseProjections(bool useProjections = true)
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
				mV08eRhKZOFZtt76lo7J(_options, useProjections);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public FetchOptionsBuilder UsePartialFetching(bool usePartialFetching = false)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				VFWjbvhKuP4ljuyAqAjS(_options, usePartialFetching);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return this;
			}
		}
	}

	public FetchOptionsBuilder QueryKey(string queryKey)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				LgOer8hKIxwwT3iwbF40(_options, queryKey);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return this;
			}
		}
	}

	public FetchOptionsBuilder SelectColumns(string propertyName)
	{
		//Discarded unreachable code: IL_0047, IL_0056
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = default(_003C_003Ec__DisplayClass21_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 7:
				return this;
			case 4:
				_003C_003Ec__DisplayClass21_.propertyName = propertyName;
				num2 = 3;
				break;
			default:
				_options.SelectColumns.Add(_003C_003Ec__DisplayClass21_.propertyName);
				num2 = 7;
				break;
			case 1:
				if (!_options.SelectColumns.All(_003C_003Ec__DisplayClass21_._003CSelectColumns_003Eb__0))
				{
					num2 = 2;
					break;
				}
				goto default;
			case 6:
				_options.SelectColumns = new List<string>();
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (_options.SelectColumns == null)
				{
					num2 = 6;
					break;
				}
				goto case 8;
			case 5:
				_003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
				num2 = 4;
				break;
			case 8:
				if (!bknyqjhKVkigXkQ8aYst(_003C_003Ec__DisplayClass21_.propertyName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public FetchOptionsBuilder SelectColumns<T>(params Expression<Func<T, object>>[] listPropertySpecifier)
	{
		for (int i = 0; i < listPropertySpecifier.Length; i++)
		{
			string propertyName = LinqUtils.FullNameOf(listPropertySpecifier[i]);
			SelectColumns(propertyName);
		}
		return this;
	}

	public FetchOptionsBuilder FetchRelations(string propertyName)
	{
		//Discarded unreachable code: IL_012d, IL_013c
		int num = 4;
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = default(_003C_003Ec__DisplayClass23_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					_003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 3;
					}
					continue;
				case 8:
					if (_options.FetchRelations.All(_003C_003Ec__DisplayClass23_._003CFetchRelations_003Eb__0))
					{
						num2 = 5;
						continue;
					}
					goto case 6;
				default:
					_options.FetchRelations = new List<string>();
					num = 2;
					break;
				case 7:
					if (_options.FetchRelations != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto default;
				case 3:
					_003C_003Ec__DisplayClass23_.propertyName = propertyName;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 7;
					}
					continue;
				case 5:
					_options.FetchRelations.Add(_003C_003Ec__DisplayClass23_.propertyName);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 5;
					}
					continue;
				case 1:
				case 2:
					if (!bknyqjhKVkigXkQ8aYst(_003C_003Ec__DisplayClass23_.propertyName))
					{
						num = 8;
						break;
					}
					goto case 6;
				case 6:
					return this;
				}
				break;
			}
		}
	}

	public FetchOptionsBuilder FetchRelations<T>(params Expression<Func<T, object>>[] propertySpecifier)
	{
		for (int i = 0; i < propertySpecifier.Length; i++)
		{
			string propertyName = LinqUtils.FullNameOf(propertySpecifier[i]);
			SelectColumns(propertyName);
		}
		return this;
	}

	static FetchOptionsBuilder()
	{
		int num = 4;
		int num2 = num;
		ParameterExpression parameterExpression = default(ParameterExpression);
		ParameterExpression parameterExpression2 = default(ParameterExpression);
		while (true)
		{
			switch (num2)
			{
			case 3:
				parameterExpression = (ParameterExpression)oTlrvyhKRr8sAPgTpXlJ(YCpRs6hKSQiemv2WnM1x(typeof(Guid).TypeHandle), b4GPVXhKiSec4oRkUkvM(0x53CACA3 ^ 0x53D6F75));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				parameterExpression2 = (ParameterExpression)oTlrvyhKRr8sAPgTpXlJ(YCpRs6hKSQiemv2WnM1x(typeof(IEnumerable<string>).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487263996));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			case 4:
				pgOaN6hKCvSEu86XEGTX();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				getColumnCountCached = MetadataLoader.UseCachingForFunc(Expression.Lambda<Func<Guid, IEnumerable<string>, int>>((Expression)ahhw5uhKKHxI4aIaSXsE(null, (MethodInfo)dQtecjhKqBkK18XhI7RL((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[2] { parameterExpression, parameterExpression2 }), new ParameterExpression[2] { parameterExpression, parameterExpression2 }));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool DwEOjuhKhc0TftPTK8h4(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object eeFuB6hKG9kyTgSIVPjC(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static Guid QyQ3CXhKERXEaCPRx0t5(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static bool Ie6jJkhKfZb4lSDry5m3(object P_0)
	{
		return ((CacheEntityAttribute)P_0).Enabled;
	}

	internal static RelationType hcyHP9hKQMnqhTtOvZmc(object P_0)
	{
		return ((EntitySettings)P_0).RelationType;
	}

	internal static bool mowEOKhKo0op7woWn3Pg()
	{
		return C3mmekhKWZI0E3igTJpr == null;
	}

	internal static FetchOptionsBuilder bTvyNXhKbbbBkmSAUZ2h()
	{
		return C3mmekhKWZI0E3igTJpr;
	}

	internal static void pgOaN6hKCvSEu86XEGTX()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void KOifQ7hKvBL4foTfTTIF(object P_0, int value)
	{
		((FetchOptions)P_0).FirstResult = value;
	}

	internal static void GGsLQmhK8DnBBvuVgKaJ(object P_0, object P_1)
	{
		((FetchOptions)P_0).SortExpression = (string)P_1;
	}

	internal static void mV08eRhKZOFZtt76lo7J(object P_0, bool value)
	{
		((FetchOptions)P_0).UseProjections = value;
	}

	internal static void VFWjbvhKuP4ljuyAqAjS(object P_0, bool value)
	{
		((FetchOptions)P_0).UsePartialFetching = value;
	}

	internal static void LgOer8hKIxwwT3iwbF40(object P_0, object P_1)
	{
		((FetchOptions)P_0).QueryKey = (string)P_1;
	}

	internal static bool bknyqjhKVkigXkQ8aYst(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static Type YCpRs6hKSQiemv2WnM1x(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object b4GPVXhKiSec4oRkUkvM(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object oTlrvyhKRr8sAPgTpXlJ(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object dQtecjhKqBkK18XhI7RL(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object ahhw5uhKKHxI4aIaSXsE(object P_0, object P_1, object P_2)
	{
		return Expression.Call((Expression)P_0, (MethodInfo)P_1, (Expression[])P_2);
	}
}
