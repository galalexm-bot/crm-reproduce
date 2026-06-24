using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.NemerleParser;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using Iesi.Collections;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using Nemerle.Core;
using Nemerle.Peg;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.Hql.Util;
using NHibernate.Impl;
using NHibernate.Loader;
using NHibernate.Loader.Criteria;
using NHibernate.Persister.Collection;
using NHibernate.Persister.Entity;
using NHibernate.SqlCommand;
using NHibernate.Type;
using NHibernate.Util;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Managers.EQL;

public static class EQLHelper
{
	private class Aliases
	{
		private readonly List<string> aliases;

		private readonly List<EntityMetadata> metadatas;

		private int aliasIndex;

		private readonly object rootAlias;

		private object parameter;

		private bool onlyParse;

		private static object wKLZLYCLhQ1O9sKq7tPO;

		public string CurrentAlias => aliases[mAZN7ECLvAsi1qpBd40F(aliases) - 1];

		internal Aliases(ICriteria criteria, EntityMetadata metadata, ParsedQueryParameters parameters)
		{
			//Discarded unreachable code: IL_002e, IL_0033
			NHmVtiCLfwgV4t2FVCbu();
			this._002Ector(criteria, metadata, null, parameters);
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
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
					onlyParse = true;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public Aliases(ICriteria criteria, EntityMetadata metadata, string alias, QueryParameters parameters)
		{
			//Discarded unreachable code: IL_001a, IL_001f
			NHmVtiCLfwgV4t2FVCbu();
			base._002Ector();
			int num = 3;
			while (true)
			{
				switch (num)
				{
				default:
					metadatas = new List<EntityMetadata> { metadata };
					num = 2;
					break;
				case 1:
					return;
				case 3:
					aliases = new List<string> { (string)(alias ?? fjuEmZCLQDIjmNwSRTwl(criteria)) };
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num = 0;
					}
					break;
				case 2:
					parameter = parameters ?? new QueryParameters();
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num = 1;
					}
					break;
				}
			}
		}

		private Aliases(Aliases currentAliases, EntityMetadata metadata, string alias)
		{
			//Discarded unreachable code: IL_001a
			NHmVtiCLfwgV4t2FVCbu();
			base._002Ector();
			int num = 3;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 1:
					metadatas.Add(metadata);
					num2 = 4;
					goto IL_001f;
				case 2:
					return;
				default:
					aliases = currentAliases.aliases.ToList();
					num2 = 6;
					goto IL_001f;
				case 7:
					metadatas = currentAliases.metadatas.ToList();
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num = 1;
					}
					break;
				case 3:
					onlyParse = currentAliases.onlyParse;
					num = 5;
					break;
				case 4:
					parameter = currentAliases.parameter;
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num = 1;
					}
					break;
				case 5:
					rootAlias = currentAliases.rootAlias ?? currentAliases;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num = 0;
					}
					break;
				case 6:
					{
						aliases.Add(alias ?? NewAlias());
						num = 7;
						break;
					}
					IL_001f:
					num = num2;
					break;
				}
			}
		}

		public string NewAlias()
		{
			return string.Concat(RF5xPdCLCvJSJDXqLfgM(-87337865 ^ -87101685), ++((Aliases)(rootAlias ?? this)).aliasIndex);
		}

		public Aliases CreateAlias(EntityMetadata metadata, string alias = null)
		{
			return new Aliases(this, metadata, alias);
		}

		public DetachedCriteria CreateDetachedCriteria(EntityMetadata metadata, TreeItem item, Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc, int level)
		{
			Aliases aliases = CreateAlias(metadata);
			return DetachedCriteriaFor(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(metadata.Uid), aliases.CurrentAlias).Add(GetCriterionNodeForQueryTreeItem(item, aliases, propertyCriterionFunc, level + 1));
		}

		public string GetProperty(string propName)
		{
			return (string)IkR25QCL8wFfYbh7S5O7(RF5xPdCLCvJSJDXqLfgM(-477139494 ^ -477155368), aliases[mAZN7ECLvAsi1qpBd40F(aliases) - 1], propName);
		}

		public string GetProperty(Property propExp)
		{
			//Discarded unreachable code: IL_007f, IL_008e
			int num = 1;
			int num2 = num;
			string text = default(string);
			while (true)
			{
				switch (num2)
				{
				case 3:
					text = (string)FDUHM0CLuvJi7hruXIZI(GetMetadata4Property(propExp));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					text = (string)FVNZJTCLZNstO7te1LFw(propExp);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (!(text == z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4DB391)))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 3;
				case 2:
				case 4:
					return GetProperty(propExp, text);
				}
			}
		}

		public string GetProperty(Property propExp, string propName)
		{
			//Discarded unreachable code: IL_00d1, IL_00e0, IL_0138
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return (string)IkR25QCL8wFfYbh7S5O7(RF5xPdCLCvJSJDXqLfgM(-234299632 ^ -234316526), aliases[0], propName);
				default:
					if (propExp.ParentProperty < 0)
					{
						num2 = 4;
						break;
					}
					goto case 6;
				case 6:
					if (wNNr3sCLVWvw71MdTKt5(propExp) < mAZN7ECLvAsi1qpBd40F(aliases))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 4;
				case 1:
					if (!yFN97pCLIF0MF66XbVl3(propExp))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				case 4:
				case 5:
					throw new PropertyNotFoundEQLException(y8mLjUCLSTMAuPBXYakH(propExp), propExp.ToString());
				case 2:
					return (string)IkR25QCL8wFfYbh7S5O7(RF5xPdCLCvJSJDXqLfgM(0x17ADCCD8 ^ 0x17AD8EDA), aliases[mAZN7ECLvAsi1qpBd40F(aliases) - wNNr3sCLVWvw71MdTKt5(propExp) - 1], propName);
				}
			}
		}

		public string GetAlias4Property(Property propExp)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					throw new PropertyNotFoundEQLException(y8mLjUCLSTMAuPBXYakH(propExp), propExp.ToString());
				case 1:
					if (yFN97pCLIF0MF66XbVl3(propExp))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num2 = 0;
						}
						break;
					}
					if (wNNr3sCLVWvw71MdTKt5(propExp) >= 0)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 3;
				case 2:
					if (wNNr3sCLVWvw71MdTKt5(propExp) < mAZN7ECLvAsi1qpBd40F(aliases))
					{
						return aliases[aliases.Count - wNNr3sCLVWvw71MdTKt5(propExp) - 1];
					}
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 2;
					}
					break;
				default:
					return aliases[0];
				}
			}
		}

		public EntityMetadata GetMetadata4Property(Property propExp)
		{
			//Discarded unreachable code: IL_00d3, IL_00e2, IL_00f2, IL_0101
			int num = 4;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (propExp.ParentProperty < mAZN7ECLvAsi1qpBd40F(aliases))
					{
						num2 = 2;
						break;
					}
					goto default;
				case 4:
					if (yFN97pCLIF0MF66XbVl3(propExp))
					{
						num2 = 3;
						break;
					}
					if (wNNr3sCLVWvw71MdTKt5(propExp) < 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 5;
				default:
					throw new PropertyNotFoundEQLException(y8mLjUCLSTMAuPBXYakH(propExp), propExp.ToString());
				case 2:
					return metadatas[mAZN7ECLvAsi1qpBd40F(aliases) - wNNr3sCLVWvw71MdTKt5(propExp) - 1];
				case 3:
					return metadatas[0];
				}
			}
		}

		public object GetParameter(string name, Property propExp, bool needCollection = false)
		{
			//Discarded unreachable code: IL_0069, IL_00cd, IL_00dc, IL_00eb, IL_0153, IL_0162, IL_0192, IL_01a1, IL_01e7, IL_01f6
			int num = 7;
			object value = default(object);
			IEnumerable source = default(IEnumerable);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					object obj;
					switch (num2)
					{
					case 7:
						if (!onlyParse)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
							{
								num2 = 6;
							}
							break;
						}
						goto case 17;
					case 17:
						if (((ParsedQueryParameters)parameter).TryCheckAndGet(name, GetMetadata4Property(propExp), (string)FVNZJTCLZNstO7te1LFw(propExp), needCollection, out value))
						{
							num2 = 9;
							break;
						}
						goto case 1;
					case 10:
						throw new VariableNotFoundException(name);
					case 4:
						if (!needCollection)
						{
							num2 = 5;
							break;
						}
						goto case 11;
					case 2:
					case 16:
						throw new VariableNotFoundException(name);
					case 15:
						if (value != null)
						{
							num2 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 10;
					case 3:
						if ((source = value as IEnumerable) != null)
						{
							num2 = 12;
							break;
						}
						goto case 15;
					case 11:
						throw new IncorrectVariableTypeException(name);
					case 5:
						return value;
					case 12:
						if (value is string)
						{
							num2 = 15;
							break;
						}
						goto case 13;
					case 8:
						throw new IncorrectVariableTypeException(name);
					case 13:
						if (needCollection)
						{
							if (!source.Cast<object>().Any())
							{
								goto end_IL_0012;
							}
							goto case 14;
						}
						num2 = 8;
						break;
					case 1:
						throw new IncorrectVariableTypeException(name);
					case 9:
						return value;
					case 6:
					{
						object obj2 = parameter;
						if (obj2 == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num2 = 0;
							}
							break;
						}
						obj = ((QueryParameters)obj2).Get(name);
						goto IL_0243;
					}
					default:
						obj = null;
						goto IL_0243;
					case 14:
						{
							if (source.Cast<object>().Any((object o) => o == null))
							{
								num2 = 2;
								break;
							}
							goto case 5;
						}
						IL_0243:
						value = obj;
						num2 = 3;
						break;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 16;
			}
		}

		internal static void NHmVtiCLfwgV4t2FVCbu()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool NC3Cu9CLG20RK0QdWBmK()
		{
			return wKLZLYCLhQ1O9sKq7tPO == null;
		}

		internal static Aliases sV9GOgCLEpZNjZtMYVGs()
		{
			return (Aliases)wKLZLYCLhQ1O9sKq7tPO;
		}

		internal static object fjuEmZCLQDIjmNwSRTwl(object P_0)
		{
			return ((ICriteria)P_0).get_Alias();
		}

		internal static object RF5xPdCLCvJSJDXqLfgM(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static int mAZN7ECLvAsi1qpBd40F(object P_0)
		{
			return ((List<string>)P_0).Count;
		}

		internal static object IkR25QCL8wFfYbh7S5O7(object P_0, object P_1, object P_2)
		{
			return string.Format((string)P_0, P_1, P_2);
		}

		internal static object FVNZJTCLZNstO7te1LFw(object P_0)
		{
			return ((Property)P_0).Name;
		}

		internal static object FDUHM0CLuvJi7hruXIZI(object P_0)
		{
			return NHibernateHelper.GetCriteriaTypeUidPropertyName((EntityMetadata)P_0);
		}

		internal static bool yFN97pCLIF0MF66XbVl3(object P_0)
		{
			return ((Property)P_0).RootProperty;
		}

		internal static int wNNr3sCLVWvw71MdTKt5(object P_0)
		{
			return ((Property)P_0).ParentProperty;
		}

		internal static int y8mLjUCLSTMAuPBXYakH(object P_0)
		{
			return ((TreeItem)P_0).Start;
		}
	}

	private class EQLPropertyInSubqueryExpression : SubqueryExpression
	{
		private class EQLCriteriaQueryTranslator : CriteriaQueryTranslator
		{
			private readonly IDictionary<ICriteria, ICriteriaInfoProvider> criteriaInfoMap;

			private readonly IDictionary<string, ICriteriaInfoProvider> nameCriteriaInfoMap;

			private readonly IDictionary<ICriteria, string> criteriaSQLAliasMap;

			private readonly IDictionary<string, ICriteria> aliasCriteriaMap;

			private static object lHetiPZSlTWCc5ehN98O;

			public EQLCriteriaQueryTranslator(ISessionFactoryImplementor factory, CriteriaImpl criteria, ICriteria rootCriteria, ICriteriaQuery outerQuery)
			{
				//Discarded unreachable code: IL_0097, IL_011f, IL_03bb
				//IL_054d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0557: Expected O, but got Unknown
				TYI4ZYZS5s4CIdSAurbx();
				criteriaInfoMap = new Dictionary<ICriteria, ICriteriaInfoProvider>();
				nameCriteriaInfoMap = new Dictionary<string, ICriteriaInfoProvider>();
				criteriaSQLAliasMap = new Dictionary<ICriteria, string>();
				aliasCriteriaMap = new Dictionary<string, ICriteria>();
				_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
				CS_0024_003C_003E8__locals0.factory = factory;
				CS_0024_003C_003E8__locals0.rootCriteria = rootCriteria;
				((CriteriaQueryTranslator)this)._002Ector(CS_0024_003C_003E8__locals0.factory, criteria, criteria.get_EntityOrClassName(), outerQuery.GenerateSQLAlias(), outerQuery);
				int num = 24;
				EQLCriteriaQueryTranslator eQLCriteriaQueryTranslator = default(EQLCriteriaQueryTranslator);
				ICriteriaInfoProvider val2 = default(ICriteriaInfoProvider);
				Subcriteria val = default(Subcriteria);
				_003C_003Ec__DisplayClass4_1 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_1);
				ICriteriaInfoProvider val3 = default(ICriteriaInfoProvider);
				while (true)
				{
					int num2;
					switch (num)
					{
					case 11:
						eQLCriteriaQueryTranslator.nameCriteriaInfoMap.Each(nameCriteriaInfoMap.Add);
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
						{
							num = 0;
						}
						break;
					case 7:
						eQLCriteriaQueryTranslator.aliasCriteriaMap.Each(aliasCriteriaMap.Add);
						num = 6;
						break;
					case 4:
					case 21:
						val2 = criteriaInfoMap.AddIfNotContainsKey(CS_0024_003C_003E8__locals0.rootCriteria, (Func<ICriteria, ICriteriaInfoProvider>)((ICriteria c) => (ICriteriaInfoProvider)new EntityCriteriaInfoProvider((IQueryable)_003C_003Ec__DisplayClass4_0.PlVjyIZpgVuwubYsgGCM(CS_0024_003C_003E8__locals0.factory, ((CriteriaImpl)CS_0024_003C_003E8__locals0.rootCriteria).get_EntityOrClassName()))));
						num = 22;
						break;
					case 3:
						if (val == null)
						{
							num = 4;
							break;
						}
						goto case 16;
					case 19:
						return;
					case 16:
						_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_1();
						num2 = 18;
						goto IL_009c;
					case 1:
						eQLCriteriaQueryTranslator.criteriaSQLAliasMap.Each(criteriaSQLAliasMap.Add);
						num = 7;
						break;
					case 24:
						CS_0024_003C_003E8__locals0._003C_003E4__this = this;
						num = 27;
						break;
					case 27:
						eQLCriteriaQueryTranslator = outerQuery as EQLCriteriaQueryTranslator;
						num = 14;
						break;
					case 17:
						aliasCriteriaMap.AddIfNotContainsKey((string)NQwRUGZSjQH3lgkPXCJm(_003C_003Ec__DisplayClass4_.root), (ICriteria)(object)_003C_003Ec__DisplayClass4_.root);
						num = 2;
						break;
					case 20:
						((IEnumerable<KeyValuePair<ICriteria, ICriteriaInfoProvider>>)eQLCriteriaQueryTranslator.criteriaInfoMap).Each((Action<KeyValuePair<ICriteria, ICriteriaInfoProvider>>)criteriaInfoMap.Add);
						num = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
						{
							num = 4;
						}
						break;
					case 6:
					case 25:
					{
						ICriteria rootCriteria2 = CS_0024_003C_003E8__locals0.rootCriteria;
						val = (Subcriteria)(object)((rootCriteria2 is Subcriteria) ? rootCriteria2 : null);
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
						{
							num = 3;
						}
						break;
					}
					case 13:
						((IEnumerable<KeyValuePair<ICriteria, ICriteriaInfoProvider>>)criteriaInfoMap).Each((Action<KeyValuePair<ICriteria, ICriteriaInfoProvider>>)base.criteriaInfoMap.AddIfNotContainsKey);
						num = 23;
						break;
					case 15:
						((IEnumerable<KeyValuePair<string, ICriteria>>)aliasCriteriaMap).Each((Action<KeyValuePair<string, ICriteria>>)base.aliasCriteriaMap.AddIfNotContainsKey);
						num2 = 19;
						goto IL_009c;
					case 14:
						if (eQLCriteriaQueryTranslator == null)
						{
							num = 25;
							break;
						}
						goto case 20;
					case 9:
						_003C_003Ec__DisplayClass4_.root = GetRootCriteria(val);
						num = 17;
						break;
					case 10:
						_003C_003Ec__DisplayClass4_.root.IterateSubcriteria().ForEach(_003C_003Ec__DisplayClass4_._003C_002Ector_003Eb__4);
						num = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num = 21;
						}
						break;
					case 22:
						nameCriteriaInfoMap.AddIfNotContainsKey((string)NqumJmZSYI9leEFXJYhQ(val2), val2);
						num = 5;
						break;
					default:
						((IEnumerable<KeyValuePair<ICriteria, string>>)criteriaSQLAliasMap).Each((Action<KeyValuePair<ICriteria, string>>)base.criteriaSQLAliasMap.AddIfNotContainsKey);
						num = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num = 2;
						}
						break;
					case 23:
						((IEnumerable<KeyValuePair<string, ICriteriaInfoProvider>>)nameCriteriaInfoMap).Each((Action<KeyValuePair<string, ICriteriaInfoProvider>>)base.nameCriteriaInfoMap.AddIfNotContainsKey);
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num = 0;
						}
						break;
					case 8:
						nameCriteriaInfoMap.AddIfNotContainsKey((string)NqumJmZSYI9leEFXJYhQ(val3), val3);
						num = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num = 3;
						}
						break;
					case 18:
						_003C_003Ec__DisplayClass4_.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
						num = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num = 9;
						}
						break;
					case 5:
						aliasCriteriaMap.AddIfNotContainsKey((string)FaruMvZSLAjL70nRGdlT(CS_0024_003C_003E8__locals0.rootCriteria), CS_0024_003C_003E8__locals0.rootCriteria);
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
						{
							num = 26;
						}
						break;
					case 12:
						val3 = criteriaInfoMap.AddIfNotContainsKey((ICriteria)(object)_003C_003Ec__DisplayClass4_.root, (Func<ICriteria, ICriteriaInfoProvider>)_003C_003Ec__DisplayClass4_._003C_002Ector_003Eb__3);
						num = 8;
						break;
					case 2:
						(from sub in _003C_003Ec__DisplayClass4_.root.IterateSubcriteria()
							where _003C_003Ec.OUrcwmZaGucXbIDZ6E9Q(sub) != null
							select sub).ForEach(delegate(Subcriteria s)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									_003C_003Ec__DisplayClass4_.CS_0024_003C_003E8__locals1._003C_003E4__this.aliasCriteriaMap.AddIfNotContainsKey((string)_003C_003Ec__DisplayClass4_0.tTU4I9Zpr7Z6ydcTC3dZ(s), (ICriteria)(object)s);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
									{
										num4 = 0;
									}
									break;
								}
							}
						});
						num = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num = 12;
						}
						break;
					case 26:
						{
							criteriaSQLAliasMap.AddIfNotContainsKey(CS_0024_003C_003E8__locals0.rootCriteria, (string)((outerQuery is CriteriaQueryTranslator) ? IxUwoqZSUECQlvLP3U2M((object)(CriteriaQueryTranslator)outerQuery) : CS_0024_003C_003E8__locals0.rootCriteria.get_Alias()));
							num = 13;
							break;
						}
						IL_009c:
						num = num2;
						break;
					}
				}
			}

			private CriteriaImpl GetRootCriteria(Subcriteria criteria)
			{
				//Discarded unreachable code: IL_004b, IL_005a
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Expected O, but got Unknown
				//IL_003b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0045: Expected O, but got Unknown
				int num = 2;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return (CriteriaImpl)dgvJWoZSsrCWTnvVlL68(criteria);
					case 1:
						return GetRootCriteria((Subcriteria)criteria.get_Parent());
					case 2:
						if (dgvJWoZSsrCWTnvVlL68(criteria) is Subcriteria)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto default;
					}
				}
			}

			private string GetWholeAssociationPath(CriteriaImpl rootCriteria, Subcriteria subcriteria)
			{
				//Discarded unreachable code: IL_0095, IL_00bb, IL_00ca, IL_00d9
				//IL_0189: Unknown result type (might be due to invalid IL or missing references)
				//IL_0193: Expected O, but got Unknown
				int num = 1;
				ICriteria value = default(ICriteria);
				string text2 = default(string);
				string text = default(string);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							value = null;
							num = 8;
							break;
						case 9:
						case 10:
							if (((object)value).Equals((object)rootCriteria))
							{
								num2 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
								{
									num2 = 1;
								}
								continue;
							}
							goto case 4;
						case 6:
							text2 = StringHelper.Root(text);
							num = 13;
							break;
						case 13:
							if (QVTHZmZSzpTMo3bLmwml(text2, subcriteria.get_Alias()))
							{
								num2 = 14;
								continue;
							}
							goto case 12;
						case 7:
							value = (ICriteria)dgvJWoZSsrCWTnvVlL68(subcriteria);
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
							{
								num2 = 10;
							}
							continue;
						case 5:
							text = (string)zPDGswZiF7pX9Ol7vocn(text);
							num2 = 9;
							continue;
						case 3:
						case 11:
						case 14:
							if (value == null)
							{
								num2 = 7;
								continue;
							}
							goto case 5;
						case 1:
							text = subcriteria.get_Path();
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
							{
								num2 = 0;
							}
							continue;
						case 12:
							aliasCriteriaMap.TryGetValue(text2, out value);
							num = 11;
							break;
						case 4:
							return (string)aG2QCAZiWSPgsRWAnXo8(GetWholeAssociationPath(rootCriteria, (Subcriteria)value), V4qey4ZiBtdCe5bvfhfe(0x4EDCBA32 ^ 0x4EDCA0F6), text);
						case 2:
							return text;
						case 8:
							if (X1lNM6ZSc2d7AoNUbHVs(text, '.') <= 0)
							{
								num2 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
								{
									num2 = 3;
								}
								continue;
							}
							goto case 6;
						}
						break;
					}
				}
			}

			private ICriteriaInfoProvider GetPathInfo(ISessionFactoryImplementor sessionFactory, CriteriaImpl rootCriteria, string path)
			{
				//Discarded unreachable code: IL_007f, IL_013d, IL_014c, IL_015c, IL_016b, IL_01a1, IL_01b0, IL_01e9, IL_01f8, IL_0208, IL_02a9, IL_035e, IL_0419, IL_0424, IL_042e, IL_043d, IL_04b5, IL_04ed, IL_04fc
				//IL_003e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0253: Unknown result type (might be due to invalid IL or missing references)
				//IL_025d: Expected O, but got Unknown
				//IL_0258: Unknown result type (might be due to invalid IL or missing references)
				//IL_025f: Expected O, but got Unknown
				//IL_0303: Unknown result type (might be due to invalid IL or missing references)
				//IL_030a: Expected O, but got Unknown
				//IL_0322: Unknown result type (might be due to invalid IL or missing references)
				//IL_0329: Expected O, but got Unknown
				//IL_0369: Unknown result type (might be due to invalid IL or missing references)
				//IL_0370: Expected O, but got Unknown
				//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f9: Expected O, but got Unknown
				//IL_044a: Unknown result type (might be due to invalid IL or missing references)
				int num = 1;
				int num2 = num;
				ICriteriaInfoProvider val2 = default(ICriteriaInfoProvider);
				string text = default(string);
				IEnumerator<string> enumerator = default(IEnumerator<string>);
				string current = default(string);
				IType type = default(IType);
				CollectionType val3 = default(CollectionType);
				IAssociationType val6 = default(IAssociationType);
				IType val5 = default(IType);
				SessionFactoryHelper val4 = default(SessionFactoryHelper);
				while (true)
				{
					switch (num2)
					{
					case 2:
						return val2;
					case 1:
					{
						StringTokenizer val = new StringTokenizer(path, (string)V4qey4ZiBtdCe5bvfhfe(-1998538950 ^ -1998541314), false);
						text = string.Empty;
						val2 = criteriaInfoMap[(ICriteria)(object)rootCriteria];
						enumerator = val.GetEnumerator();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					}
					try
					{
						while (true)
						{
							IL_03c3:
							int num3;
							if (!KIVGgEZi8V600mrO4JqG(enumerator))
							{
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
								{
									num3 = 10;
								}
								goto IL_008d;
							}
							goto IL_02b7;
							IL_02b7:
							current = enumerator.Current;
							num3 = 23;
							goto IL_008d;
							IL_008d:
							while (true)
							{
								int num4;
								object obj2;
								object obj;
								switch (num3)
								{
								case 10:
									return val2;
								case 23:
									text = (string)yYl8p9ZiorIqryU8jlmO(text, current);
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
									{
										num3 = 1;
									}
									continue;
								case 24:
									if (!type.get_IsAssociationType())
									{
										num3 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
										{
											num3 = 8;
										}
										continue;
									}
									goto case 3;
								case 1:
									type = val2.GetType(text);
									num3 = 24;
									continue;
								case 11:
									if (val3 != null)
									{
										num3 = 13;
										continue;
									}
									goto case 19;
								case 25:
									text = (string)yYl8p9ZiorIqryU8jlmO(text, V4qey4ZiBtdCe5bvfhfe(-643786247 ^ -643792067));
									num3 = 12;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
									{
										num3 = 7;
									}
									continue;
								case 4:
								case 7:
									val2 = (ICriteriaInfoProvider)new EntityCriteriaInfoProvider((IQueryable)TEW8BhZivRhKSAxCHNAh(sessionFactory, wdrHF6ZiCFd27p1AyAEj(val6, sessionFactory)));
									num3 = 17;
									continue;
								case 15:
								case 16:
								case 17:
									text = string.Empty;
									num4 = 29;
									goto IL_0089;
								case 9:
									if (!iAieciZibSv01rGUaHpL(type))
									{
										num3 = 5;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
										{
											num3 = 5;
										}
										continue;
									}
									obj2 = (object)(CollectionType)type;
									goto IL_044f;
								case 14:
									break;
								case 20:
									if (val3 != null)
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 21;
								case 13:
									if (!m98m5MZiGVyXK5LlojQn(val5))
									{
										num3 = 19;
										continue;
									}
									goto case 30;
								case 3:
									val6 = (IAssociationType)type;
									num3 = 9;
									continue;
								case 30:
									val2 = (ICriteriaInfoProvider)new ComponentCollectionCriteriaInfoProvider((IQueryableCollection)pD3ey7ZifUmIfI9FoHB1(val4, idmc3nZiETpZhCem2Clq(val3)));
									num3 = 16;
									continue;
								case 6:
									if (AVaxXvZiQqu7dLZHvZ0e(val5))
									{
										num3 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 18;
								case 2:
									val4 = new SessionFactoryHelper(sessionFactory);
									num3 = 11;
									continue;
								case 19:
								case 22:
									if (val3 != null)
									{
										num3 = 6;
										continue;
									}
									goto case 4;
								case 8:
								case 28:
									if (!m98m5MZiGVyXK5LlojQn(type))
									{
										num4 = 27;
										goto IL_0089;
									}
									goto case 25;
								case 26:
								case 27:
									throw new QueryException((string)V4qey4ZiBtdCe5bvfhfe(--1867379187 ^ 0x6F4BDC3F) + text);
								case 12:
								case 29:
									goto IL_03c3;
								case 18:
									val2 = (ICriteriaInfoProvider)new ScalarCollectionCriteriaInfoProvider(val4, (string)idmc3nZiETpZhCem2Clq(val3));
									num3 = 15;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
									{
										num3 = 9;
									}
									continue;
								case 5:
									obj2 = null;
									goto IL_044f;
								case 21:
									obj = null;
									goto IL_0473;
								default:
									{
										obj = QHDOQmZih2AC49UqvAbn(val3, sessionFactory);
										goto IL_0473;
									}
									IL_0089:
									num3 = num4;
									continue;
									IL_0473:
									val5 = (IType)obj;
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
									{
										num3 = 2;
									}
									continue;
									IL_044f:
									val3 = (CollectionType)obj2;
									num3 = 20;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
									{
										num3 = 5;
									}
									continue;
								}
								break;
							}
							goto IL_02b7;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									X3fBIsZiZPW6CJb0g2JY(enumerator);
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
									{
										num5 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				}
			}

			internal static void TYI4ZYZS5s4CIdSAurbx()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static object NQwRUGZSjQH3lgkPXCJm(object P_0)
			{
				return ((CriteriaImpl)P_0).get_Alias();
			}

			internal static object NqumJmZSYI9leEFXJYhQ(object P_0)
			{
				return ((ICriteriaInfoProvider)P_0).get_Name();
			}

			internal static object FaruMvZSLAjL70nRGdlT(object P_0)
			{
				return ((ICriteria)P_0).get_Alias();
			}

			internal static object IxUwoqZSUECQlvLP3U2M(object P_0)
			{
				return ((CriteriaQueryTranslator)P_0).get_RootSQLAlias();
			}

			internal static bool RiKMGsZSrJsGBq0rmqoj()
			{
				return lHetiPZSlTWCc5ehN98O == null;
			}

			internal static EQLCriteriaQueryTranslator j1ukMRZSg6hnCVenUbZ2()
			{
				return (EQLCriteriaQueryTranslator)lHetiPZSlTWCc5ehN98O;
			}

			internal static object dgvJWoZSsrCWTnvVlL68(object P_0)
			{
				return ((Subcriteria)P_0).get_Parent();
			}

			internal static int X1lNM6ZSc2d7AoNUbHVs(object P_0, char P_1)
			{
				return ((string)P_0).IndexOf(P_1);
			}

			internal static bool QVTHZmZSzpTMo3bLmwml(object P_0, object P_1)
			{
				return ((string)P_0).Equals((string)P_1);
			}

			internal static object zPDGswZiF7pX9Ol7vocn(object P_0)
			{
				return StringHelper.Unroot((string)P_0);
			}

			internal static object V4qey4ZiBtdCe5bvfhfe(int _0020)
			{
				return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static object aG2QCAZiWSPgsRWAnXo8(object P_0, object P_1, object P_2)
			{
				return (string)P_0 + (string)P_1 + (string)P_2;
			}

			internal static object yYl8p9ZiorIqryU8jlmO(object P_0, object P_1)
			{
				return (string)P_0 + (string)P_1;
			}

			internal static bool iAieciZibSv01rGUaHpL(object P_0)
			{
				return ((IType)P_0).get_IsCollectionType();
			}

			internal static object QHDOQmZih2AC49UqvAbn(object P_0, object P_1)
			{
				return ((CollectionType)P_0).GetElementType((ISessionFactoryImplementor)P_1);
			}

			internal static bool m98m5MZiGVyXK5LlojQn(object P_0)
			{
				return ((IType)P_0).get_IsComponentType();
			}

			internal static object idmc3nZiETpZhCem2Clq(object P_0)
			{
				return ((CollectionType)P_0).get_Role();
			}

			internal static object pD3ey7ZifUmIfI9FoHB1(object P_0, object P_1)
			{
				return ((SessionFactoryHelper)P_0).GetCollectionPersister((string)P_1);
			}

			internal static bool AVaxXvZiQqu7dLZHvZ0e(object P_0)
			{
				return ((IType)P_0).get_IsEntityType();
			}

			internal static object wdrHF6ZiCFd27p1AyAEj(object P_0, object P_1)
			{
				return ((IAssociationType)P_0).GetAssociatedEntityName((ISessionFactoryImplementor)P_1);
			}

			internal static object TEW8BhZivRhKSAxCHNAh(object P_0, object P_1)
			{
				return ((ISessionFactoryImplementor)P_0).GetEntityPersister((string)P_1);
			}

			internal static bool KIVGgEZi8V600mrO4JqG(object P_0)
			{
				return ((IEnumerator)P_0).MoveNext();
			}

			internal static void X3fBIsZiZPW6CJb0g2JY(object P_0)
			{
				((IDisposable)P_0).Dispose();
			}
		}

		private object propertyName;

		private object queryCast;

		private static object bJVwPXCLiYhkGBX1SQ9F;

		public EQLPropertyInSubqueryExpression(string propertyName, DetachedCriteria dc)
		{
			//Discarded unreachable code: IL_0042, IL_0047
			hdgcbICLK0A8GvZ8Vval();
			((SubqueryExpression)this)._002Ector((string)eFA10MCLX6H4StoKXEuP(0x66F566B6 ^ 0x66F0DD26), (string)null, dc);
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
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
				this.propertyName = propertyName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num = 1;
				}
			}
		}

		public EQLPropertyInSubqueryExpression(string propertyName, DetachedCriteria dc, IQueryCastExtension queryCast)
		{
			//Discarded unreachable code: IL_002c, IL_0031
			hdgcbICLK0A8GvZ8Vval();
			this._002Ector(propertyName, dc);
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
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
				this.queryCast = queryCast;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num = 0;
				}
			}
		}

		protected override SqlString ToLeftSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			return new SqlString(criteriaQuery.GetColumn(criteria, (string)propertyName));
		}

		public override SqlString ToSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery)
		{
			//Discarded unreachable code: IL_0073, IL_018f, IL_019e
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected O, but got Unknown
			//IL_020d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Unknown result type (might be due to invalid IL or missing references)
			//IL_022d: Expected O, but got Unknown
			//IL_02b1: Expected O, but got Unknown
			//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
			int num = 2;
			ISessionFactoryImplementor val = default(ISessionFactoryImplementor);
			CriteriaImpl val2 = default(CriteriaImpl);
			SqlString val5 = default(SqlString);
			SqlStringBuilder val4 = default(SqlStringBuilder);
			EQLCriteriaQueryTranslator eQLCriteriaQueryTranslator = default(EQLCriteriaQueryTranslator);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						val = (ISessionFactoryImplementor)hr7eA8CLTCvlw2qvQVqR(criteriaQuery);
						num = 14;
						break;
					case 2:
						val2 = (CriteriaImpl)((SubqueryExpression)this).get_Criteria();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num2 = 1;
						}
						continue;
					case 3:
					case 8:
						val5 = ((IMapping)val).get_Dialect().GetLimitString(val5, (int?)k8YKEfCLNb5mWyJeywKw(val2), (int?)Gef3lnCL1PAhQK2tepUC(val2), (Parameter)null, (Parameter)null);
						num = 7;
						break;
					case 7:
						return (SqlString)pCZ0rACL3woR9pF3H0Kg(((SqlStringBuilder)zAykIwCLeqmZ0wxv5fO6(val4.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317665770)), val5)).Add((string)eFA10MCLX6H4StoKXEuP(-1217523399 ^ -1217524091)));
					case 11:
						if (val2.get_FirstResult() != 0)
						{
							num2 = 3;
							continue;
						}
						goto default;
					case 10:
						if (tfaqVkCLkBvvkDWVTmBL(eQLCriteriaQueryTranslator))
						{
							num2 = 4;
							continue;
						}
						goto case 13;
					case 12:
						base.types = ((CriteriaQueryTranslator)eQLCriteriaQueryTranslator).get_ProjectedTypes();
						num2 = 6;
						continue;
					default:
						if (Gef3lnCL1PAhQK2tepUC(val2) != RowSelection.NoValue)
						{
							num2 = 8;
							continue;
						}
						goto case 7;
					case 4:
						base.parameters = ((CriteriaQueryTranslator)eQLCriteriaQueryTranslator).GetQueryParameters();
						num2 = 12;
						continue;
					case 5:
					case 6:
					{
						if (!tfaqVkCLkBvvkDWVTmBL(eQLCriteriaQueryTranslator))
						{
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
							{
								num2 = 9;
							}
							continue;
						}
						IOuterJoinLoadable val3 = (IOuterJoinLoadable)p0dydDCLn7Dm0qxWisPA(val, val2.get_EntityOrClassName());
						val4 = new SqlStringBuilder();
						if (queryCast != null)
						{
							zAykIwCLeqmZ0wxv5fO6(val4, N2MqUBCL2dgIfHokINCE(queryCast, x4GuNrCLO8fYZ9i2baIc(this, criteria, criteriaQuery)));
						}
						else
						{
							zAykIwCLeqmZ0wxv5fO6(val4, ((SubqueryExpression)this).ToLeftSqlString(criteria, criteriaQuery));
						}
						val2.set_Session((ISessionImplementor)U3rbMBCLPVPNO9I0H8Hc(criteria));
						EQLCriteriaQueryTranslator eQLCriteriaQueryTranslator2 = eQLCriteriaQueryTranslator;
						ISessionFactoryImplementor obj = val;
						CriteriaImpl obj2 = val2;
						string entityOrClassName = val2.get_EntityOrClassName();
						ISessionImplementor session = val2.get_Session();
						val5 = ((JoinWalker)new CriteriaJoinWalker(val3, (CriteriaQueryTranslator)(object)eQLCriteriaQueryTranslator2, obj, (ICriteria)(object)obj2, entityOrClassName, ((session != null) ? session.get_EnabledFilters() : null) ?? new Dictionary<string, IFilter>())).get_SqlString();
						num2 = 11;
						continue;
					}
					case 13:
						base.types = null;
						num2 = 5;
						continue;
					case 14:
						eQLCriteriaQueryTranslator = new EQLCriteriaQueryTranslator(val, val2, criteria, criteriaQuery);
						num2 = 10;
						continue;
					case 9:
						throw new QueryException((string)eFA10MCLX6H4StoKXEuP(0x4A1640F ^ 0x4A4DF97));
					}
					break;
				}
			}
		}

		private static ISessionImplementor DeriveRootSession(object criteria)
		{
			//Discarded unreachable code: IL_0039, IL_0075
			int num = 1;
			int num2 = num;
			CriteriaImpl val2 = default(CriteriaImpl);
			Subcriteria val = default(Subcriteria);
			while (true)
			{
				switch (num2)
				{
				case 3:
					return (ISessionImplementor)e3pPJwCLatI6N5qTmGtV(val2);
				case 5:
					return null;
				default:
					criteria = wiSqCmCLpDlWjRxa0rr4(val);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					if ((val2 = (CriteriaImpl)((criteria is CriteriaImpl) ? criteria : null)) == null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 3;
				case 1:
				case 2:
					if ((val = (Subcriteria)((criteria is Subcriteria) ? criteria : null)) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				}
			}
		}

		internal static void hdgcbICLK0A8GvZ8Vval()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object eFA10MCLX6H4StoKXEuP(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool fpp7rECLRJemuphF495t()
		{
			return bJVwPXCLiYhkGBX1SQ9F == null;
		}

		internal static EQLPropertyInSubqueryExpression OsQBgPCLqMkwrE0PH1D8()
		{
			return (EQLPropertyInSubqueryExpression)bJVwPXCLiYhkGBX1SQ9F;
		}

		internal static object hr7eA8CLTCvlw2qvQVqR(object P_0)
		{
			return ((ICriteriaQuery)P_0).get_Factory();
		}

		internal static bool tfaqVkCLkBvvkDWVTmBL(object P_0)
		{
			return ((CriteriaQueryTranslator)P_0).get_HasProjection();
		}

		internal static object p0dydDCLn7Dm0qxWisPA(object P_0, object P_1)
		{
			return ((ISessionFactoryImplementor)P_0).GetEntityPersister((string)P_1);
		}

		internal static object x4GuNrCLO8fYZ9i2baIc(object P_0, object P_1, object P_2)
		{
			return ((SubqueryExpression)P_0).ToLeftSqlString((ICriteria)P_1, (ICriteriaQuery)P_2);
		}

		internal static object N2MqUBCL2dgIfHokINCE(object P_0, object P_1)
		{
			return ((IQueryCastExtension)P_0).CastLeftOperand((SqlString)P_1);
		}

		internal static object zAykIwCLeqmZ0wxv5fO6(object P_0, object P_1)
		{
			return ((SqlStringBuilder)P_0).Add((SqlString)P_1);
		}

		internal static object U3rbMBCLPVPNO9I0H8Hc(object P_0)
		{
			return DeriveRootSession(P_0);
		}

		internal static int Gef3lnCL1PAhQK2tepUC(object P_0)
		{
			return ((CriteriaImpl)P_0).get_MaxResults();
		}

		internal static int k8YKEfCLNb5mWyJeywKw(object P_0)
		{
			return ((CriteriaImpl)P_0).get_FirstResult();
		}

		internal static object pCZ0rACL3woR9pF3H0Kg(object P_0)
		{
			return ((SqlStringBuilder)P_0).ToSqlString();
		}

		internal static object wiSqCmCLpDlWjRxa0rr4(object P_0)
		{
			return ((Subcriteria)P_0).get_Parent();
		}

		internal static object e3pPJwCLatI6N5qTmGtV(object P_0)
		{
			return ((CriteriaImpl)P_0).get_Session();
		}
	}

	private static readonly ISessionProvider SessionProvider;

	private static EQLHelper hsP6oGhv4uMbCOqpfc2q;

	internal static ICriteria AddEQLQuery(this ICriteria criteria, string query, EntityMetadata metadata, QueryParameters queryParameters = null, string alias = null, Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc = null)
	{
		option<Expression> option = new EQLParser().Parse(new SourceSnapshot(query).WithText(query.ToLowerInvariant()));
		if (option.HasValue)
		{
			Aliases aliases = new Aliases(criteria, metadata, alias, queryParameters);
			ICriterion criterionNodeForQueryTreeItem = GetCriterionNodeForQueryTreeItem(option.Value, aliases, propertyCriterionFunc, 0);
			if (criterionNodeForQueryTreeItem != null)
			{
				criteria.Add(criterionNodeForQueryTreeItem);
			}
			return criteria;
		}
		throw new EQLException(query, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103CD68B), query));
	}

	public static ParsedQueryParameters ParseEqlParameters(string query, EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_0049, IL_0058, IL_0112
		int num = 9;
		Aliases aliases = default(Aliases);
		Type typeByUid = default(Type);
		ParsedQueryParameters parsedQueryParameters = default(ParsedQueryParameters);
		option<Expression> option = default(option<Expression>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					aliases = new Aliases((ICriteria)YQB8Y8hvycLh4s0OMR7c(wlTs9ShvmvCJyQ615Bo3(Locator.GetServiceNotNull<ISessionProvider>(), ""), typeByUid), metadata, parsedQueryParameters);
					num2 = 6;
					continue;
				default:
					throw new EQLException(query, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210523075), query));
				case 4:
					return parsedQueryParameters;
				case 1:
					break;
				case 8:
					if (!wnxFmBhvAxNBwAS04THS(query))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 4;
				case 9:
					parsedQueryParameters = new ParsedQueryParameters();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 8;
					}
					continue;
				case 7:
					typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(z4WvcBhv0fbrBlF8b3U2(metadata));
					num2 = 5;
					continue;
				case 3:
					if (!JB1hichvxuoo3YexxUYc(option))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 7;
				case 6:
					GetCriterionNodeForQueryTreeItem(option.Value, aliases, null, 0);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			}
			option = new EQLParser().Parse(new SourceSnapshot(query).WithText((string)Uc9dPWhv7GTmJTJrHvwL(query)));
			num = 3;
		}
	}

	private static ICriterion GetCriterionNodeForQueryTreeItem(object item, object aliases, Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc, int level)
	{
		if (level >= 1000)
		{
			throw new StackOverflowException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x12475C90)));
		}
		if (item is BinaryExpression binaryExpression)
		{
			switch (binaryExpression.Operator)
			{
			case BinaryOperator.And:
			case BinaryOperator.Or:
			{
				ICriterion criterionNodeForQueryTreeItem = GetCriterionNodeForQueryTreeItem(binaryExpression.Operand1, aliases, propertyCriterionFunc, level + 1);
				ICriterion criterionNodeForQueryTreeItem2 = GetCriterionNodeForQueryTreeItem(binaryExpression.Operand2, aliases, propertyCriterionFunc, level + 1);
				ICriterion obj;
				if (criterionNodeForQueryTreeItem == null || criterionNodeForQueryTreeItem2 == null)
				{
					obj = criterionNodeForQueryTreeItem;
					if (obj == null)
					{
						return criterionNodeForQueryTreeItem2;
					}
				}
				else
				{
					ICriterion val = (ICriterion)(object)((binaryExpression.Operator == BinaryOperator.And) ? Restrictions.And(criterionNodeForQueryTreeItem, criterionNodeForQueryTreeItem2) : Restrictions.Or(criterionNodeForQueryTreeItem, criterionNodeForQueryTreeItem2));
					obj = val;
				}
				return obj;
			}
			case BinaryOperator.Equal:
			case BinaryOperator.NEqual:
			case BinaryOperator.GE:
			case BinaryOperator.GT:
			case BinaryOperator.LE:
			case BinaryOperator.LT:
			case BinaryOperator.IS:
			case BinaryOperator.IN:
			case BinaryOperator.LIKE:
				return GetBinaryExpressionCriterion(binaryExpression, aliases, propertyCriterionFunc, level + 1);
			default:
				return null;
			}
		}
		if (item is NotExpression notExpression)
		{
			return (ICriterion)(object)Restrictions.Not(GetCriterionNodeForQueryTreeItem(notExpression.Expression, aliases, propertyCriterionFunc, level + 1));
		}
		return null;
	}

	private static DetachedCriteria DetachedCriteriaFor(Type entityType, object alias)
	{
		int num = 1;
		int num2 = num;
		string text;
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = ((ISessionImplementor)njpOifhvMBHbZRRQ8V4u(SessionProvider.GetSession(string.Empty))).get_Factory().TryGetGuessEntityName(entityType);
				if (text != null)
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				text = entityType.FullName;
				break;
			}
			break;
		}
		return (DetachedCriteria)YBlUuohvJEo45pgAFiKx(text, alias);
	}

	private static ICriterion GetBinaryExpressionCriterion(object expression, object aliases, Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc, int level)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals0.aliases = (Aliases)aliases;
		CS_0024_003C_003E8__locals0.propertyCriterionFunc = propertyCriterionFunc;
		CS_0024_003C_003E8__locals0.level = level;
		AggregateSubqueryExpression obj = ((BinaryExpression)expression).Operand1 as AggregateSubqueryExpression;
		AggregateSubqueryExpression aggregateSubqueryExpression = ((BinaryExpression)expression).Operand2 as AggregateSubqueryExpression;
		if (obj != null || aggregateSubqueryExpression != null)
		{
			return GetCountExpression(expression, CS_0024_003C_003E8__locals0.aliases, CS_0024_003C_003E8__locals0.propertyCriterionFunc, CS_0024_003C_003E8__locals0.level);
		}
		CS_0024_003C_003E8__locals0.propExp = ((BinaryExpression)expression).Operand1 as Property;
		if (CS_0024_003C_003E8__locals0.propExp == null)
		{
			throw new PositionalEQLException(null, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53FEC2F), expression.ToString()), ((TreeItem)expression).Start);
		}
		EntityMetadata metadata4Property = CS_0024_003C_003E8__locals0.aliases.GetMetadata4Property(CS_0024_003C_003E8__locals0.propExp);
		Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(metadata4Property.Uid);
		PropertyInfo reflectionProperty = typeByUid.GetReflectionProperty(CS_0024_003C_003E8__locals0.propExp.Name);
		if (reflectionProperty == null)
		{
			throw new PropertyNotFoundEQLException(CS_0024_003C_003E8__locals0.propExp.Start, CS_0024_003C_003E8__locals0.propExp.Name);
		}
		if (typeof(ISet).IsAssignableFrom(reflectionProperty.PropertyType) || (reflectionProperty.PropertyType.IsGenericType && reflectionProperty.PropertyType.GetGenericTypeDefinition() == typeof(ISet<>)))
		{
			_003C_003Ec__DisplayClass6_1 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass6_1();
			CS_0024_003C_003E8__locals2.propMetadta = ((IEntityPropertyMetadata)metadata4Property.Properties.FirstOrDefault((PropertyMetadata p) => (string)_003C_003Ec__DisplayClass6_0.wUSx6mCL6MWBBMjTy8hc(p) == (string)_003C_003Ec__DisplayClass6_0.fiJtKeCLHxMWSSKYUkeE(CS_0024_003C_003E8__locals0.propExp))) ?? metadata4Property.TableParts.FirstOrDefault((TablePartMetadata tp) => (string)_003C_003Ec__DisplayClass6_0.T1XTcBCLASgkJiF1qRFU(tp) == (string)_003C_003Ec__DisplayClass6_0.fiJtKeCLHxMWSSKYUkeE(CS_0024_003C_003E8__locals0.propExp));
			if (CS_0024_003C_003E8__locals2.propMetadta == null || (CS_0024_003C_003E8__locals2.propMetadta.TypeUid != TablePartMetadata.UID && !(CS_0024_003C_003E8__locals2.propMetadta.Settings is EntitySettings)))
			{
				throw new PropertyNotFoundEQLException(CS_0024_003C_003E8__locals0.propExp.Start, CS_0024_003C_003E8__locals0.propExp.Name);
			}
			Aliases aliases2 = CS_0024_003C_003E8__locals0.aliases.CreateAlias((CS_0024_003C_003E8__locals2.propMetadta.TypeUid == TablePartMetadata.UID) ? ((EntityMetadata)CS_0024_003C_003E8__locals2.propMetadta) : ((EntityMetadata)MetadataLoader.LoadMetadata(CS_0024_003C_003E8__locals2.propMetadta.SubTypeUid)));
			DetachedCriteria val;
			string text;
			if (CS_0024_003C_003E8__locals2.propMetadta.TypeUid == TablePartMetadata.UID)
			{
				val = DetachedCriteriaFor(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(CS_0024_003C_003E8__locals2.propMetadta.Uid), aliases2.CurrentAlias);
				text = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234336474);
			}
			else if (CS_0024_003C_003E8__locals2.propMetadta.Settings is EntitySettings && ((EntitySettings)CS_0024_003C_003E8__locals2.propMetadta.Settings).RelationType == RelationType.OneToMany)
			{
				val = DetachedCriteriaFor(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(CS_0024_003C_003E8__locals2.propMetadta.SubTypeUid), aliases2.CurrentAlias);
				text = ((EntityMetadata)MetadataLoader.LoadMetadata(CS_0024_003C_003E8__locals2.propMetadta.SubTypeUid)).Properties.First((PropertyMetadata p) => _003C_003Ec__DisplayClass6_1.dqxGUeCLJYbUiqXFOCDx(_003C_003Ec__DisplayClass6_1.VvkqM5CLyTl14HWLTiAc(p), ((EntitySettings)_003C_003Ec__DisplayClass6_1.nLcDUcCLMeRt0bFuYWbU(CS_0024_003C_003E8__locals2.propMetadta)).KeyColumnUid)).Name;
			}
			else
			{
				val = DetachedCriteriaFor(typeByUid, aliases2.NewAlias()).CreateAlias(CS_0024_003C_003E8__locals0.propExp.Name, aliases2.CurrentAlias, (JoinType)0);
				text = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217490841);
			}
			val.SetProjection((IProjection)(object)Projections.Property(text));
			_003C_003Ec__DisplayClass6_2 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass6_2();
			switch (((BinaryExpression)expression).Operator)
			{
			case BinaryOperator.Equal:
				val.Add(GetRestriction((Func<string, string, ICriterion>)Restrictions.EqProperty, (Func<string, object, ICriterion>)Restrictions.Eq, (object)z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFE7934), (object)aliases2, (object)CS_0024_003C_003E8__locals0.propExp, (object)((BinaryExpression)expression).Operand2, (object)CS_0024_003C_003E8__locals0.aliases));
				break;
			case BinaryOperator.NEqual:
				val.Add((ICriterion)(object)Restrictions.Not(GetRestriction((Func<string, string, ICriterion>)Restrictions.EqProperty, (Func<string, object, ICriterion>)Restrictions.Eq, (object)z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x16374577), (object)aliases2, (object)CS_0024_003C_003E8__locals0.propExp, (object)((BinaryExpression)expression).Operand2, (object)CS_0024_003C_003E8__locals0.aliases)));
				break;
			case BinaryOperator.IN:
				if (((BinaryExpression)expression).Operand2 is SubqueryExpression subquery)
				{
					IQueryCastExtension queryCastExtension = GetQueryCastExtension(metadata4Property, CS_0024_003C_003E8__locals0.propExp.Name, subquery);
					val.Add((ICriterion)(object)new EQLPropertyInSubqueryExpression(aliases2.GetProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638434993)), GetCriteria4SubqueryExpression(subquery, queryCastExtension, CS_0024_003C_003E8__locals0.aliases, CS_0024_003C_003E8__locals0.propertyCriterionFunc, CS_0024_003C_003E8__locals0.level + 1), queryCastExtension));
					break;
				}
				CS_0024_003C_003E8__locals3.inFunc = ((BinaryExpression)expression).Operand2 as InFunction;
				if (CS_0024_003C_003E8__locals3.inFunc != null)
				{
					IQueryInFunction queryInFunction = ComponentManager.Current.GetExtensionPoints<IQueryInFunction>().FirstOrDefault((IQueryInFunction q) => _003C_003Ec__DisplayClass6_2.XZp2M3CLjSCti5QFbVE8(_003C_003Ec__DisplayClass6_2.YLf8cUCLgXlneyrrb1hg(q), _003C_003Ec__DisplayClass6_2.aj6YwBCL5jrLWdkuU2gO(CS_0024_003C_003E8__locals3.inFunc)));
					if (queryInFunction == null)
					{
						throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487208298), CS_0024_003C_003E8__locals3.inFunc.Name));
					}
					object[] parameters = (from Constant c in CS_0024_003C_003E8__locals3.inFunc.Parameters.GetChildItems()
						select GetConstantValue(CS_0024_003C_003E8__locals0.propExp, CS_0024_003C_003E8__locals0.aliases, c)).ToArray();
					val.Add(queryInFunction.GetCriterion(aliases2.CurrentAlias, metadata4Property, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63AB25B6), parameters));
				}
				else if (((BinaryExpression)expression).Operand2 is InExpression inExpression)
				{
					val.Add(GetCriterionNodeForQueryTreeItem(inExpression.Expression, aliases2, CS_0024_003C_003E8__locals0.propertyCriterionFunc, CS_0024_003C_003E8__locals0.level + 1));
				}
				else
				{
					object[] array = ((((BinaryExpression)expression).Operand2 is EleWise.ELMA.NemerleParser.Parameter) ? (GetParameterOperand(CS_0024_003C_003E8__locals0.propExp, CS_0024_003C_003E8__locals0.aliases, ((BinaryExpression)expression).Operand2, needCollection: true) as IEnumerable).CastToArrayOrNull<object>() : GetParametersOperand(CS_0024_003C_003E8__locals0.propExp, CS_0024_003C_003E8__locals0.aliases, ((BinaryExpression)expression).Operand2.GetChildItems()));
					val.Add((ICriterion)(object)Restrictions.In(aliases2.GetProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852869798)), array));
				}
				break;
			case BinaryOperator.IS:
				val.Add((ICriterion)(object)Restrictions.EqProperty(text, CS_0024_003C_003E8__locals0.aliases.GetProperty(CS_0024_003C_003E8__locals0.propExp, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC23013))));
				return (ICriterion)(object)Subqueries.NotExists(val);
			default:
				throw new PositionalEQLException(null, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x6383D4CF), expression.ToString()), ((TreeItem)expression).Start);
			}
			return (ICriterion)(object)new EQLPropertyInSubqueryExpression(CS_0024_003C_003E8__locals0.aliases.GetProperty(CS_0024_003C_003E8__locals0.propExp, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A6F741)), val);
		}
		_003C_003Ec__DisplayClass6_3 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass6_3();
		CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
		switch (((BinaryExpression)expression).Operator)
		{
		case BinaryOperator.Equal:
			return (ICriterion)(object)GetEqExpression(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propExp, ((BinaryExpression)expression).Operand2, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.aliases);
		case BinaryOperator.NEqual:
			return (ICriterion)(object)Restrictions.Not((ICriterion)(object)GetEqExpression(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propExp, ((BinaryExpression)expression).Operand2, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.aliases));
		case BinaryOperator.GE:
			return GetRestriction((Func<string, string, ICriterion>)Restrictions.GeProperty, (Func<string, object, ICriterion>)Restrictions.Ge, (object)CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propExp, (object)((BinaryExpression)expression).Operand2, (object)CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.aliases);
		case BinaryOperator.GT:
			return GetRestriction((Func<string, string, ICriterion>)Restrictions.GtProperty, (Func<string, object, ICriterion>)Restrictions.Gt, (object)CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propExp, (object)((BinaryExpression)expression).Operand2, (object)CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.aliases);
		case BinaryOperator.LE:
			return GetRestriction((Func<string, string, ICriterion>)Restrictions.LeProperty, (Func<string, object, ICriterion>)Restrictions.Le, (object)CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propExp, (object)((BinaryExpression)expression).Operand2, (object)CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.aliases);
		case BinaryOperator.LT:
			return GetRestriction((Func<string, string, ICriterion>)Restrictions.LtProperty, (Func<string, object, ICriterion>)Restrictions.Lt, (object)CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propExp, (object)((BinaryExpression)expression).Operand2, (object)CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.aliases);
		case BinaryOperator.LIKE:
		{
			object obj2 = null;
			if (((BinaryExpression)expression).Operand2 is EleWise.ELMA.NemerleParser.Parameter)
			{
				obj2 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.aliases.GetParameter(((EleWise.ELMA.NemerleParser.Parameter)((BinaryExpression)expression).Operand2).Name, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propExp);
			}
			else
			{
				if (!(((BinaryExpression)expression).Operand2 is Constant))
				{
					throw new FormatException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4786FD8B));
				}
				obj2 = ((Constant)((BinaryExpression)expression).Operand2).Value;
			}
			return (ICriterion)(object)ElmaRestrictions.InsensitiveLike(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.aliases.GetProperty(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propExp), obj2);
		}
		case BinaryOperator.IN:
		{
			if (((BinaryExpression)expression).Operand2 is SubqueryExpression subquery2)
			{
				IQueryCastExtension queryCastExtension2 = GetQueryCastExtension(metadata4Property, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propExp.Name, subquery2);
				return (ICriterion)(object)new EQLPropertyInSubqueryExpression(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.aliases.GetProperty(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propExp), GetCriteria4SubqueryExpression(subquery2, queryCastExtension2, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.aliases, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propertyCriterionFunc, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.level + 1), queryCastExtension2);
			}
			CS_0024_003C_003E8__locals1.inFunc = ((BinaryExpression)expression).Operand2 as InFunction;
			if (CS_0024_003C_003E8__locals1.inFunc != null)
			{
				IQueryInFunction queryInFunction2 = ComponentManager.Current.GetExtensionPoints<IQueryInFunction>().FirstOrDefault((IQueryInFunction q) => _003C_003Ec__DisplayClass6_3.gZrKLNCLzGjibtPIK9tF(_003C_003Ec__DisplayClass6_3.py1Ao6CLsAEltcA4N7Ex(q), _003C_003Ec__DisplayClass6_3.FsyI62CLc4Z2mIy71TyF(CS_0024_003C_003E8__locals1.inFunc)));
				if (queryInFunction2 == null)
				{
					throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633563483), CS_0024_003C_003E8__locals1.inFunc.Name));
				}
				object[] parameters2 = (from Constant c in CS_0024_003C_003E8__locals1.inFunc.Parameters.GetChildItems()
					select GetConstantValue(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propExp, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.aliases, c, availableConvertion: false)).ToArray();
				return queryInFunction2.GetCriterion(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.aliases.GetAlias4Property(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propExp), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.aliases.GetMetadata4Property(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propExp), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propExp.Name, parameters2);
			}
			CS_0024_003C_003E8__locals1.inExpr = ((BinaryExpression)expression).Operand2 as InExpression;
			if (CS_0024_003C_003E8__locals1.inExpr != null)
			{
				EntityPropertyMetadata entityPropertyMetadata = (EntityPropertyMetadata)metadata4Property.Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec__DisplayClass6_0.GrpvXuCL7e21pVRq5pmw(p.Name, _003C_003Ec__DisplayClass6_0.fiJtKeCLHxMWSSKYUkeE(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propExp)));
				if (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propertyCriterionFunc != null)
				{
					ICriterion val2 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propertyCriterionFunc(entityPropertyMetadata, (EntityMetadata em, string alias) => GetCriterionNodeForQueryTreeItem(_003C_003Ec__DisplayClass6_3.osAZ9nCUF9i48i48g4jo(CS_0024_003C_003E8__locals1.inExpr), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.aliases.CreateAlias(em, alias), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propertyCriterionFunc, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.level + 1), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.aliases.NewAlias);
					if (val2 != null)
					{
						return val2;
					}
				}
				DetachedCriteria dc = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.aliases.CreateDetachedCriteria((EntityMetadata)MetadataLoader.LoadMetadata(entityPropertyMetadata.SubTypeUid), CS_0024_003C_003E8__locals1.inExpr.Expression, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propertyCriterionFunc, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.level + 1).SetProjection((IProjection)(object)Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x16374577)));
				return (ICriterion)(object)new EQLPropertyInSubqueryExpression(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.aliases.GetProperty(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propExp), dc);
			}
			object[] array2 = ((((BinaryExpression)expression).Operand2 is EleWise.ELMA.NemerleParser.Parameter) ? (GetParameterOperand(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propExp, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.aliases, ((BinaryExpression)expression).Operand2, needCollection: true) as IEnumerable).CastToArrayOrNull<object>() : GetParametersOperand(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propExp, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.aliases, ((BinaryExpression)expression).Operand2.GetChildItems()));
			return (ICriterion)(object)Restrictions.In(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.aliases.GetProperty(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propExp), array2);
		}
		case BinaryOperator.IS:
			return (ICriterion)(object)Restrictions.IsNull(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.aliases.GetProperty(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propExp));
		default:
			throw new PositionalEQLException(null, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921022441), expression.ToString()), ((TreeItem)expression).Start);
		}
	}

	private static IQueryCastExtension GetQueryCastExtension(object entityMetadataLeftOperand, object propertyNameLeftOperand, object subquery)
	{
		//Discarded unreachable code: IL_01cc
		int num = 9;
		IQueryCastExtension queryCastExtension = default(IQueryCastExtension);
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		Type typeByUid = default(Type);
		EntityMetadata entityMetadata = default(EntityMetadata);
		Type typeByUid2 = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return queryCastExtension;
				case 10:
					throw new ClassNotFoundEQLException(aobMsVhvlGv6oo8R9Fdv(_003C_003Ec__DisplayClass7_.subquery), (string)gT2penhvr0mpNiGPktCB(_003C_003Ec__DisplayClass7_.subquery));
				case 3:
					typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(z4WvcBhv0fbrBlF8b3U2(entityMetadata));
					num2 = 11;
					break;
				case 1:
					if (!Eaywuwhv5lwL9PXcC8qf(_003C_003Ec__DisplayClass7_.propertyInfoRightOperand, null))
					{
						goto end_IL_0012;
					}
					num2 = 13;
					break;
				case 6:
					typeByUid2 = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(z4WvcBhv0fbrBlF8b3U2(entityMetadataLeftOperand));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					break;
				case 9:
					_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
					num2 = 8;
					break;
				case 13:
					throw new PropertyNotFoundEQLException(Sepr90hvjIJt3Vx56wj4(_003C_003Ec__DisplayClass7_.subquery), _003C_003Ec__DisplayClass7_.subquery.SelectProperty);
				default:
					_003C_003Ec__DisplayClass7_.propertyInfoLeftOperand = (PropertyInfo)a1EkeQhv980IXhmjalqu(typeByUid2, propertyNameLeftOperand);
					num2 = 5;
					break;
				case 2:
					if (queryCastExtension == null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num2 = 7;
						}
						break;
					}
					goto case 4;
				case 8:
					_003C_003Ec__DisplayClass7_.subquery = (SubqueryExpression)subquery;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 6;
					}
					break;
				case 11:
					_003C_003Ec__DisplayClass7_.propertyInfoRightOperand = (PropertyInfo)a1EkeQhv980IXhmjalqu(typeByUid, loSPmBhvggYpqR0k3JQC(_003C_003Ec__DisplayClass7_.subquery));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
					break;
				case 12:
					if (entityMetadata != null)
					{
						num2 = 3;
						break;
					}
					goto case 10;
				case 5:
					entityMetadata = ((ComponentManager)fhL8gahvducpY25IM2XS()).GetExtensionPoints<IEntityMetadataSearcher>().Select(_003C_003Ec__DisplayClass7_._003CGetQueryCastExtension_003Eb__0).FirstOrDefault((EntityMetadata m) => m != null);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 8;
					}
					break;
				case 7:
					queryCastExtension = ((ComponentManager)fhL8gahvducpY25IM2XS()).GetExtensionPoints<IQueryCastExtension>().FirstOrDefault(delegate(IQueryCastExtension cast)
					{
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								return _003C_003Ec.tSt9T6CUuCeD2Kq1GDvo(_003C_003Ec.LDdVO5CUIqfyC6InRtUT(cast), null);
							case 1:
								if (!_003C_003Ec.tSt9T6CUuCeD2Kq1GDvo(_003C_003Ec.o7H8rWCUZ61tdic9HsCd(cast), null))
								{
									return false;
								}
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					});
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 4;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			queryCastExtension = ComponentManager.Current.GetExtensionPoints<IQueryCastExtension>().FirstOrDefault(_003C_003Ec__DisplayClass7_._003CGetQueryCastExtension_003Eb__2);
			num = 2;
		}
	}

	private static object GetParameterOperand(object propExp, object aliases, object item, bool needCollection = false)
	{
		int num = 2;
		int num2 = num;
		EleWise.ELMA.NemerleParser.Parameter parameter = default(EleWise.ELMA.NemerleParser.Parameter);
		TreeItem treeItem = default(TreeItem);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (parameter != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 4;
			case 2:
				treeItem = (TreeItem)item;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 1;
				}
				continue;
			case 4:
				return GetConstantValue(propExp, aliases, treeItem as Constant);
			case 1:
				parameter = item as EleWise.ELMA.NemerleParser.Parameter;
				num2 = 3;
				continue;
			}
			Constant constant = new Constant();
			dkFhf5hvLrkCCV9ucW3T(constant, Os3pqphvYl8SqDg9itqJ(parameter));
			constant.Stop = gjfKyAhvUZiuD1SXHv1J(parameter);
			dRZ4LIhvco9FjEf5jScA(constant, ((Aliases)aliases).GetParameter((string)CO7yw9hvs69d2sFU5ApE(parameter), (Property)propExp, needCollection));
			treeItem = constant;
			num2 = 4;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
			{
				num2 = 4;
			}
		}
	}

	private static object[] GetParametersOperand(object propExp, object aliases, IEnumerable<TreeItem> obj)
	{
		List<object> list = new List<object>();
		foreach (TreeItem item in obj)
		{
			list.Add(GetParameterOperand(propExp, aliases, item));
		}
		return list.ToArray();
	}

	private static ICriterion GetCountExpression(object expression, object aliases, Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc, int level)
	{
		AggregateSubqueryExpression aggregateSubqueryExpression = ((BinaryExpression)expression).Operand1 as AggregateSubqueryExpression;
		AggregateSubqueryExpression aggregateSubqueryExpression2 = ((BinaryExpression)expression).Operand2 as AggregateSubqueryExpression;
		object aggregationOperand = GetAggregationOperand(((BinaryExpression)expression).Operand1, aliases, propertyCriterionFunc, level);
		object aggregationOperand2 = GetAggregationOperand(((BinaryExpression)expression).Operand2, aliases, propertyCriterionFunc, level);
		if (aggregateSubqueryExpression != null && aggregateSubqueryExpression2 != null)
		{
			DetachedCriteria val = (DetachedCriteria)((aggregationOperand is DetachedCriteria) ? aggregationOperand : null);
			DetachedCriteria val2 = (DetachedCriteria)((aggregationOperand2 is DetachedCriteria) ? aggregationOperand2 : null);
			return (ICriterion)(((BinaryExpression)expression).Operator switch
			{
				BinaryOperator.Equal => Restrictions.EqProperty(Projections.SubQuery(val), Projections.SubQuery(val2)), 
				BinaryOperator.NEqual => Restrictions.Not((ICriterion)(object)Restrictions.EqProperty(Projections.SubQuery(val), Projections.SubQuery(val2))), 
				BinaryOperator.GE => Restrictions.GeProperty(Projections.SubQuery(val), Projections.SubQuery(val2)), 
				BinaryOperator.GT => Restrictions.GtProperty(Projections.SubQuery(val), Projections.SubQuery(val2)), 
				BinaryOperator.LE => Restrictions.LeProperty(Projections.SubQuery(val), Projections.SubQuery(val2)), 
				BinaryOperator.LT => Restrictions.LtProperty(Projections.SubQuery(val), Projections.SubQuery(val2)), 
				_ => throw new PositionalEQLException(null, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309852568), expression.ToString()), ((TreeItem)expression).Start), 
			});
		}
		object obj;
		DetachedCriteria detach;
		if (aggregateSubqueryExpression != null)
		{
			obj = aggregationOperand2;
			detach = (DetachedCriteria)((aggregationOperand is DetachedCriteria) ? aggregationOperand : null);
			switch (((BinaryExpression)expression).Operator)
			{
			case BinaryOperator.GE:
				((BinaryExpression)expression).Operator = BinaryOperator.LE;
				break;
			case BinaryOperator.GT:
				((BinaryExpression)expression).Operator = BinaryOperator.LT;
				break;
			case BinaryOperator.LE:
				((BinaryExpression)expression).Operator = BinaryOperator.GE;
				break;
			case BinaryOperator.LT:
				((BinaryExpression)expression).Operator = BinaryOperator.GT;
				break;
			}
		}
		else
		{
			obj = aggregationOperand;
			detach = (DetachedCriteria)((aggregationOperand2 is DetachedCriteria) ? aggregationOperand2 : null);
		}
		if (!(obj is TreeItem property))
		{
			throw new PositionalEQLException(null, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4F3AFD), expression.ToString()), ((TreeItem)expression).Start);
		}
		return (ICriterion)(((BinaryExpression)expression).Operator switch
		{
			BinaryOperator.Equal => GetRestrictionSubqueries((Func<string, DetachedCriteria, ICriterion>)Subqueries.PropertyEq, (Func<object, DetachedCriteria, ICriterion>)Subqueries.Eq, (object)property, aliases, (object)detach), 
			BinaryOperator.NEqual => Restrictions.Not(GetRestrictionSubqueries((Func<string, DetachedCriteria, ICriterion>)Subqueries.PropertyEq, (Func<object, DetachedCriteria, ICriterion>)Subqueries.Eq, (object)property, aliases, (object)detach)), 
			BinaryOperator.GE => GetRestrictionSubqueries((Func<string, DetachedCriteria, ICriterion>)Subqueries.PropertyGe, (Func<object, DetachedCriteria, ICriterion>)Subqueries.Ge, (object)property, aliases, (object)detach), 
			BinaryOperator.GT => GetRestrictionSubqueries((Func<string, DetachedCriteria, ICriterion>)Subqueries.PropertyGt, (Func<object, DetachedCriteria, ICriterion>)Subqueries.Gt, (object)property, aliases, (object)detach), 
			BinaryOperator.LE => GetRestrictionSubqueries((Func<string, DetachedCriteria, ICriterion>)Subqueries.PropertyLe, (Func<object, DetachedCriteria, ICriterion>)Subqueries.Le, (object)property, aliases, (object)detach), 
			BinaryOperator.LT => GetRestrictionSubqueries((Func<string, DetachedCriteria, ICriterion>)Subqueries.PropertyLt, (Func<object, DetachedCriteria, ICriterion>)Subqueries.Lt, (object)property, aliases, (object)detach), 
			_ => throw new PositionalEQLException(null, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC1F099), expression.ToString()), ((TreeItem)expression).Start), 
		});
	}

	private static object GetAggregationOperand(object expression, object aliases, Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc, int level)
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals0.property = expression as AggregateSubqueryExpression;
		if (CS_0024_003C_003E8__locals0.property != null)
		{
			_003C_003Ec__DisplayClass11_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass11_1();
			CS_0024_003C_003E8__locals1.func = CS_0024_003C_003E8__locals0.property.Expression as ConstantFunction;
			if (CS_0024_003C_003E8__locals1.func != null)
			{
				IQueryInFunction queryInFunction = ComponentManager.Current.GetExtensionPoints<IQueryInFunction>().FirstOrDefault((IQueryInFunction q) => (string)_003C_003Ec__DisplayClass11_1.GaTpKrCUexHIrMMODCMD(q) == CS_0024_003C_003E8__locals1.func.Name);
				IEQLFunction iEQLFunction = queryInFunction as IEQLFunction;
				if (queryInFunction == null || iEQLFunction == null)
				{
					throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867875652), CS_0024_003C_003E8__locals1.func.Name));
				}
				Guid uid = default(Guid);
				foreach (EQLFunction eqlFunction in iEQLFunction.GetEqlFunctions())
				{
					uid = eqlFunction.Types.First();
				}
				Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(uid);
				Aliases aliases2 = ((Aliases)aliases).CreateAlias((EntityMetadata)MetadataLoader.LoadMetadata(typeByUid), (string)null);
				Constant[] array = (from Constant c in CS_0024_003C_003E8__locals1.func.Parameters.GetChildItems()
					select (c)).ToArray();
				DetachedCriteria obj = DetachedCriteriaFor(typeByUid, aliases2.CurrentAlias);
				string currentAlias = aliases2.CurrentAlias;
				EntityMetadata metadata = (EntityMetadata)MetadataLoader.LoadMetadata(typeByUid);
				string propName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1C9FBA);
				object[] parameters = array;
				obj.Add(queryInFunction.GetCriterion(currentAlias, metadata, propName, parameters));
				obj.SetProjection((IProjection)(object)Projections.Count((IProjection)(object)Projections.Id()));
				return obj;
			}
			if (CS_0024_003C_003E8__locals0.property.Short)
			{
				EntityMetadata metadata4Property = ((Aliases)aliases).GetMetadata4Property(CS_0024_003C_003E8__locals0.property.Expression as Property);
				Type typeByUid2 = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(metadata4Property.Uid);
				PropertyInfo reflectionProperty = typeByUid2.GetReflectionProperty(CS_0024_003C_003E8__locals0.property.Name);
				if (reflectionProperty == null)
				{
					throw new PropertyNotFoundEQLException(CS_0024_003C_003E8__locals0.property.Start, CS_0024_003C_003E8__locals0.property.Name);
				}
				if (typeof(ISet).IsAssignableFrom(reflectionProperty.PropertyType) || (reflectionProperty.PropertyType.IsGenericType && reflectionProperty.PropertyType.GetGenericTypeDefinition() == typeof(ISet<>)))
				{
					_003C_003Ec__DisplayClass11_2 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass11_2();
					CS_0024_003C_003E8__locals2.propMetadta = ((IEntityPropertyMetadata)metadata4Property.Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec__DisplayClass11_0.JtlVBLCUKEfOuki8KaY8(_003C_003Ec__DisplayClass11_0.nik9iOCURISPceA8VQiI(p), _003C_003Ec__DisplayClass11_0.TjAAohCUqr0kCFU2EiUc(CS_0024_003C_003E8__locals0.property)))) ?? metadata4Property.TableParts.FirstOrDefault((TablePartMetadata tp) => _003C_003Ec__DisplayClass11_0.JtlVBLCUKEfOuki8KaY8(_003C_003Ec__DisplayClass11_0.zjVVpDCUXWN0JXpfeMgc(tp), CS_0024_003C_003E8__locals0.property.Name));
					if (CS_0024_003C_003E8__locals2.propMetadta == null || (CS_0024_003C_003E8__locals2.propMetadta.TypeUid != TablePartMetadata.UID && !(CS_0024_003C_003E8__locals2.propMetadta.Settings is EntitySettings)))
					{
						throw new PropertyNotFoundEQLException(CS_0024_003C_003E8__locals0.property.Start, CS_0024_003C_003E8__locals0.property.Name);
					}
					Aliases aliases3 = ((Aliases)aliases).CreateAlias((CS_0024_003C_003E8__locals2.propMetadta.TypeUid == TablePartMetadata.UID) ? ((EntityMetadata)CS_0024_003C_003E8__locals2.propMetadta) : ((EntityMetadata)MetadataLoader.LoadMetadata(CS_0024_003C_003E8__locals2.propMetadta.SubTypeUid)), (string)null);
					DetachedCriteria val;
					string text;
					if (CS_0024_003C_003E8__locals2.propMetadta.TypeUid == TablePartMetadata.UID)
					{
						val = DetachedCriteriaFor(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(CS_0024_003C_003E8__locals2.propMetadta.Uid), aliases3.CurrentAlias);
						text = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811997064);
					}
					else if (CS_0024_003C_003E8__locals2.propMetadta.Settings is EntitySettings && ((EntitySettings)CS_0024_003C_003E8__locals2.propMetadta.Settings).RelationType == RelationType.OneToMany)
					{
						val = DetachedCriteriaFor(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(CS_0024_003C_003E8__locals2.propMetadta.SubTypeUid), aliases3.CurrentAlias);
						text = ((EntityMetadata)MetadataLoader.LoadMetadata(CS_0024_003C_003E8__locals2.propMetadta.SubTypeUid)).Properties.First((PropertyMetadata p) => _003C_003Ec__DisplayClass11_2.LXXwxFCUtS8oWPckxvdV(_003C_003Ec__DisplayClass11_2.Fl52DjCUpJY3PIqv4Ycl(p), _003C_003Ec__DisplayClass11_2.astrVLCUDJ3Qhj7RDYhy((EntitySettings)_003C_003Ec__DisplayClass11_2.onUKPNCUaxSLdqAxVPN6(CS_0024_003C_003E8__locals2.propMetadta)))).Name;
					}
					else
					{
						val = DetachedCriteriaFor(typeByUid2, aliases3.NewAlias()).CreateAlias(CS_0024_003C_003E8__locals0.property.Name, aliases3.CurrentAlias, (JoinType)0);
						text = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583777878);
					}
					val.SetProjection((IProjection)(object)Projections.Count((IProjection)(object)Projections.Id()));
					val.Add((ICriterion)(object)Restrictions.EqProperty(text, ((Aliases)aliases).GetProperty((Property)CS_0024_003C_003E8__locals0.property, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x12449DFA))));
					return val;
				}
				throw new PropertyNotFoundEQLException(CS_0024_003C_003E8__locals0.property.Start, CS_0024_003C_003E8__locals0.property.Name);
			}
			if (CS_0024_003C_003E8__locals0.property.Function == null || !CS_0024_003C_003E8__locals0.property.Function.Name.Equals(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x1244174A), StringComparison.OrdinalIgnoreCase))
			{
				return null;
			}
			EntityMetadata entityMetadata = (from p in ComponentManager.Current.GetExtensionPoints<IEntityMetadataSearcher>()
				select p.FindEntityMetadata((string)_003C_003Ec__DisplayClass11_0.M3veANCUT2vZiWdkGEsM(CS_0024_003C_003E8__locals0.property))).FirstOrDefault((EntityMetadata m) => m != null);
			if (entityMetadata == null)
			{
				throw new ClassNotFoundEQLException(CS_0024_003C_003E8__locals0.property.FromEntityStart, CS_0024_003C_003E8__locals0.property.FromEntity);
			}
			DetachedCriteria obj2 = ((Aliases)aliases).CreateDetachedCriteria(entityMetadata, (TreeItem)CS_0024_003C_003E8__locals0.property.Expression, propertyCriterionFunc, level + 1);
			obj2.SetProjection((IProjection)(object)Projections.Count((IProjection)(object)Projections.Id()));
			return obj2;
		}
		return expression;
	}

	private static DetachedCriteria GetCriteria4SubqueryExpression(object subquery, object queryCast, object aliases, Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc, int level)
	{
		_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_0();
		CS_0024_003C_003E8__locals0.subquery = (SubqueryExpression)subquery;
		EntityMetadata entityMetadata = (from p in ComponentManager.Current.GetExtensionPoints<IEntityMetadataSearcher>()
			select (EntityMetadata)_003C_003Ec__DisplayClass12_0.zZKW4dCU7qJXwH6vnkFW(p, _003C_003Ec__DisplayClass12_0.t85v3KCUAXu4YXcvXabn(CS_0024_003C_003E8__locals0.subquery))).FirstOrDefault((EntityMetadata m) => m != null);
		EntityMetadata entityMetadata2 = (InterfaceActivator.LoadMetadata(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(entityMetadata.Uid)) as EntityMetadata) ?? entityMetadata;
		IEntityPropertyMetadata entityPropertyMetadata = ((IEntityPropertyMetadata)entityMetadata2.Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec__DisplayClass12_0.UERvX4CUm5iuXf4WGgww(_003C_003Ec__DisplayClass12_0.PWuBVoCUxPcCLAj5ESHu(p), _003C_003Ec__DisplayClass12_0.iDiePoCU0hG0P3RKgn5y(CS_0024_003C_003E8__locals0.subquery)))) ?? entityMetadata2.TableParts.FirstOrDefault((TablePartMetadata tp) => _003C_003Ec__DisplayClass12_0.UERvX4CUm5iuXf4WGgww(_003C_003Ec__DisplayClass12_0.Y11tSYCUyWdq0JroHteX(tp), _003C_003Ec__DisplayClass12_0.iDiePoCU0hG0P3RKgn5y(CS_0024_003C_003E8__locals0.subquery)));
		DetachedCriteria val = ((Aliases)aliases).CreateDetachedCriteria(entityMetadata2, (TreeItem)CS_0024_003C_003E8__locals0.subquery.Expression, propertyCriterionFunc, level + 1);
		if (entityPropertyMetadata == null || (entityPropertyMetadata.TypeUid != TablePartMetadata.UID && !(entityPropertyMetadata.Settings is EntitySettings)) || (!(entityPropertyMetadata.TypeUid == TablePartMetadata.UID) && ((EntitySettings)entityPropertyMetadata.Settings).RelationType == RelationType.OneToOne))
		{
			val.SetProjection(((IQueryCastExtension)queryCast).CastRightOperand(CS_0024_003C_003E8__locals0.subquery.SelectProperty));
		}
		else
		{
			string text = ((Aliases)aliases).NewAlias();
			val.CreateAlias(CS_0024_003C_003E8__locals0.subquery.SelectProperty, text).SetProjection(((IQueryCastExtension)queryCast).CastRightOperand(text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420910718)));
		}
		return val;
	}

	private static EqExpression GetEqExpression(object prop1Exp, object item, object aliases)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
				num2 = 2;
				break;
			case 2:
				_003C_003Ec__DisplayClass13_.aliases = (Aliases)aliases;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass13_.prop1Exp = (Property)prop1Exp;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return EQLHelper.GetRestriction<EqExpression>((Func<Property, EqExpression>)_003C_003Ec__DisplayClass13_._003CGetEqExpression_003Eb__0, (Func<Constant, EqExpression>)_003C_003Ec__DisplayClass13_._003CGetEqExpression_003Eb__1, item, (object)_003C_003Ec__DisplayClass13_.aliases, (object)_003C_003Ec__DisplayClass13_.prop1Exp);
			}
		}
	}

	private static ICriterion GetRestriction(Func<string, string, ICriterion> projFunc, Func<string, object, ICriterion> valFunc, object propName, object lAliases, object propExp, object item, object rAliases)
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
		CS_0024_003C_003E8__locals0.projFunc = projFunc;
		CS_0024_003C_003E8__locals0.lAliases = (Aliases)lAliases;
		CS_0024_003C_003E8__locals0.propName = (string)propName;
		CS_0024_003C_003E8__locals0.rAliases = (Aliases)rAliases;
		CS_0024_003C_003E8__locals0.valFunc = valFunc;
		CS_0024_003C_003E8__locals0.propExp = (Property)propExp;
		return EQLHelper.GetRestriction<ICriterion>((Func<Property, ICriterion>)((Property rhsPropName) => CS_0024_003C_003E8__locals0.projFunc(CS_0024_003C_003E8__locals0.lAliases.GetProperty(CS_0024_003C_003E8__locals0.propName), (string)_003C_003Ec__DisplayClass14_0.esU999CUYx1SOurJXPWm(CS_0024_003C_003E8__locals0.rAliases, rhsPropName))), (Func<Constant, ICriterion>)((Constant constExp) => CS_0024_003C_003E8__locals0.valFunc((string)_003C_003Ec__DisplayClass14_0.YWjdhCCUL12h5hqB07Gl(CS_0024_003C_003E8__locals0.lAliases, CS_0024_003C_003E8__locals0.propName), GetConstantValue(CS_0024_003C_003E8__locals0.propExp, CS_0024_003C_003E8__locals0.rAliases, constExp))), item, (object)CS_0024_003C_003E8__locals0.rAliases, (object)CS_0024_003C_003E8__locals0.propExp);
	}

	private static ICriterion GetRestriction(Func<string, string, ICriterion> projFunc, Func<string, object, ICriterion> valFunc, object propExp, object item, object aliases)
	{
		_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_0();
		CS_0024_003C_003E8__locals0.projFunc = projFunc;
		CS_0024_003C_003E8__locals0.aliases = (Aliases)aliases;
		CS_0024_003C_003E8__locals0.propExp = (Property)propExp;
		CS_0024_003C_003E8__locals0.valFunc = valFunc;
		return EQLHelper.GetRestriction<ICriterion>((Func<Property, ICriterion>)((Property rhsPropName) => CS_0024_003C_003E8__locals0.projFunc((string)_003C_003Ec__DisplayClass15_0.wXiTNHCsFLYNiFOrnDKx(CS_0024_003C_003E8__locals0.aliases, CS_0024_003C_003E8__locals0.propExp), (string)_003C_003Ec__DisplayClass15_0.wXiTNHCsFLYNiFOrnDKx(CS_0024_003C_003E8__locals0.aliases, rhsPropName))), (Func<Constant, ICriterion>)((Constant constExp) => CS_0024_003C_003E8__locals0.valFunc(CS_0024_003C_003E8__locals0.aliases.GetProperty(CS_0024_003C_003E8__locals0.propExp), GetConstantValue(CS_0024_003C_003E8__locals0.propExp, CS_0024_003C_003E8__locals0.aliases, constExp))), item, (object)CS_0024_003C_003E8__locals0.aliases, (object)CS_0024_003C_003E8__locals0.propExp);
	}

	private static ICriterion GetRestrictionSubqueries(Func<string, DetachedCriteria, ICriterion> projFunc, Func<object, DetachedCriteria, ICriterion> valFunc, object property, object aliases, object detach)
	{
		_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass16_0();
		CS_0024_003C_003E8__locals0.projFunc = projFunc;
		CS_0024_003C_003E8__locals0.aliases = (Aliases)aliases;
		CS_0024_003C_003E8__locals0.detach = (DetachedCriteria)detach;
		CS_0024_003C_003E8__locals0.valFunc = valFunc;
		return EQLHelper.GetRestriction<ICriterion>((Func<Property, ICriterion>)((Property rhsPropName) => CS_0024_003C_003E8__locals0.projFunc((string)_003C_003Ec__DisplayClass16_0.sqFMPNCsh1BVZFqCtGe0(CS_0024_003C_003E8__locals0.aliases, rhsPropName), CS_0024_003C_003E8__locals0.detach)), (Func<Constant, ICriterion>)((Constant constExp) => CS_0024_003C_003E8__locals0.valFunc(constExp.Value, CS_0024_003C_003E8__locals0.detach)), property, (object)CS_0024_003C_003E8__locals0.aliases, (object)null);
	}

	private static TCriterion GetRestriction<TCriterion>(Func<Property, TCriterion> projFunc, Func<Constant, TCriterion> valFunc, object item, object aliases, object leftProperty) where TCriterion : class, ICriterion
	{
		if (item is Property property)
		{
			if (Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(((Aliases)aliases).GetMetadata4Property(property).Uid).GetReflectionProperty(property.Name) != null)
			{
				return projFunc(property);
			}
			throw new PropertyNotFoundEQLException(property.Start, property.Name);
		}
		if (item is EleWise.ELMA.NemerleParser.Parameter parameter)
		{
			Constant arg = new Constant
			{
				Start = parameter.Start,
				Stop = parameter.Stop,
				Value = ((Aliases)aliases).GetParameter(parameter.Name, (Property)leftProperty, needCollection: false)
			};
			return valFunc(arg);
		}
		if (item is Constant arg2)
		{
			return valFunc(arg2);
		}
		return null;
	}

	private static object GetConstantValue(object propExp, object aliases, object constExp, bool availableConvertion = true)
	{
		//Discarded unreachable code: IL_01b5, IL_01c4, IL_0236, IL_02a9, IL_02b8, IL_035c
		int num = 29;
		_003C_003Ec__DisplayClass18_2 _003C_003Ec__DisplayClass18_3 = default(_003C_003Ec__DisplayClass18_2);
		_003C_003Ec__DisplayClass18_1 _003C_003Ec__DisplayClass18_2 = default(_003C_003Ec__DisplayClass18_1);
		IQueryFunctionResult queryFunctionResult = default(IQueryFunctionResult);
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = default(_003C_003Ec__DisplayClass18_0);
		object[] array = default(object[]);
		IQueryTypeConvertion queryTypeConvertion = default(IQueryTypeConvertion);
		object obj = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					_003C_003Ec__DisplayClass18_3.CS_0024_003C_003E8__locals2 = _003C_003Ec__DisplayClass18_2;
					num2 = 6;
					continue;
				case 24:
					if (!_003C_003Ec__DisplayClass18_2.valueType.IsEnumerable())
					{
						num2 = 5;
						continue;
					}
					goto case 17;
				case 6:
					_003C_003Ec__DisplayClass18_3.CS_0024_003C_003E8__locals2.valueType = _003C_003Ec__DisplayClass18_3.CS_0024_003C_003E8__locals2.valueType.GetInterface((string)k6UCYRh8FBUIE99VboA8(TypeOf.IEnumerable)).GetGenericArguments()[0];
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 15;
					}
					continue;
				case 20:
					return j4CdhHh8hksGvG4P291X(queryFunctionResult, hhEZSgh8BTQpWO0VKTsJ(_003C_003Ec__DisplayClass18_.aliases, _003C_003Ec__DisplayClass18_.propExp), lPSghwh8WhkwviDBOEHm(_003C_003Ec__DisplayClass18_.propExp), array);
				case 7:
					_003C_003Ec__DisplayClass18_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass18_;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
				case 27:
					queryTypeConvertion = ((ComponentManager)fhL8gahvducpY25IM2XS()).GetExtensionPoints<IQueryTypeConvertion>().FirstOrDefault(_003C_003Ec__DisplayClass18_2._003CGetConstantValue_003Eb__4);
					num2 = 13;
					continue;
				case 9:
					if (queryFunctionResult != null)
					{
						num2 = 2;
						continue;
					}
					goto case 21;
				case 13:
					if (queryTypeConvertion != null)
					{
						num2 = 4;
						continue;
					}
					goto default;
				case 12:
					if (availableConvertion)
					{
						num2 = 22;
						continue;
					}
					goto default;
				case 22:
					if (aJFxnLhvzol61JYipW2Z(constExp) != null)
					{
						num2 = 23;
						continue;
					}
					goto default;
				case 15:
					_003C_003Ec__DisplayClass18_3.queryTypeConvertion = ((ComponentManager)fhL8gahvducpY25IM2XS()).GetExtensionPoints<IQueryTypeConvertion>().FirstOrDefault((IQueryTypeConvertion q) => _003C_003Ec__DisplayClass18_1.Feluc2CsiSWYJ6QBwCV8(q, _003C_003Ec__DisplayClass18_1.ewUWCCCsVFuhQpCagBPg(_003C_003Ec__DisplayClass18_3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.aliases, _003C_003Ec__DisplayClass18_3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.propExp), _003C_003Ec__DisplayClass18_1.wwWIqECsSYQodd3RpQTd(_003C_003Ec__DisplayClass18_3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.propExp), _003C_003Ec__DisplayClass18_3.CS_0024_003C_003E8__locals2.valueType));
					num2 = 16;
					continue;
				case 25:
					_003C_003Ec__DisplayClass18_.constFuncExp = constExp as ConstantFunction;
					num = 11;
					break;
				case 1:
					_003C_003Ec__DisplayClass18_2.valueType = obj.GetType();
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 26;
					}
					continue;
				default:
					return obj;
				case 29:
					_003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
					num2 = 28;
					continue;
				case 4:
					obj = utHDOvh8oL0yWxxvIfpP(queryTypeConvertion, hhEZSgh8BTQpWO0VKTsJ(_003C_003Ec__DisplayClass18_2.CS_0024_003C_003E8__locals1.aliases, _003C_003Ec__DisplayClass18_2.CS_0024_003C_003E8__locals1.propExp), lPSghwh8WhkwviDBOEHm(_003C_003Ec__DisplayClass18_2.CS_0024_003C_003E8__locals1.propExp), obj);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 0;
					}
					continue;
				case 19:
					obj = ((IEnumerable)obj).Cast<object>().Select(_003C_003Ec__DisplayClass18_3._003CGetConstantValue_003Eb__3).ToArray();
					num2 = 18;
					continue;
				case 28:
					_003C_003Ec__DisplayClass18_.aliases = (Aliases)aliases;
					num2 = 8;
					continue;
				case 16:
					if (_003C_003Ec__DisplayClass18_3.queryTypeConvertion == null)
					{
						num = 14;
						break;
					}
					goto case 19;
				case 11:
					if (_003C_003Ec__DisplayClass18_.constFuncExp != null)
					{
						queryFunctionResult = ComponentManager.Current.GetExtensionPoints<IQueryFunctionResult>().FirstOrDefault(_003C_003Ec__DisplayClass18_._003CGetConstantValue_003Eb__0);
						num2 = 9;
					}
					else
					{
						num2 = 10;
					}
					continue;
				case 23:
					_003C_003Ec__DisplayClass18_2 = new _003C_003Ec__DisplayClass18_1();
					num2 = 7;
					continue;
				case 17:
					_003C_003Ec__DisplayClass18_3 = new _003C_003Ec__DisplayClass18_2();
					num2 = 3;
					continue;
				case 8:
					_003C_003Ec__DisplayClass18_.propExp = (Property)propExp;
					num2 = 25;
					continue;
				case 26:
					if (_003C_003Ec__DisplayClass18_2.valueType != TypeOf<string>.Raw)
					{
						num2 = 24;
						continue;
					}
					goto case 5;
				case 21:
					throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979431743), yVeqGPh8bu86ciTT0E4T(_003C_003Ec__DisplayClass18_.constFuncExp)));
				case 2:
					array = _003C_003Ec__DisplayClass18_.constFuncExp.Parameters.GetChildItems().Cast<Constant>().Select(_003C_003Ec__DisplayClass18_._003CGetConstantValue_003Eb__1)
						.ToArray();
					num2 = 20;
					continue;
				case 10:
					obj = aJFxnLhvzol61JYipW2Z(constExp);
					num2 = 12;
					continue;
				}
				break;
			}
		}
	}

	static EQLHelper()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				iGPRqkh8Go9GCB68tCAB();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				SessionProvider = Locator.GetServiceNotNull<ISessionProvider>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool wnxFmBhvAxNBwAS04THS(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object Uc9dPWhv7GTmJTJrHvwL(object P_0)
	{
		return ((string)P_0).ToLowerInvariant();
	}

	internal static bool JB1hichvxuoo3YexxUYc(object P_0)
	{
		return ((option<Expression>)P_0).HasValue;
	}

	internal static Guid z4WvcBhv0fbrBlF8b3U2(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object wlTs9ShvmvCJyQ615Bo3(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static object YQB8Y8hvycLh4s0OMR7c(object P_0, Type P_1)
	{
		return ((ISession)P_0).CreateCriteria(P_1);
	}

	internal static bool bSm84ohv6Ydmv4RKM9h7()
	{
		return hsP6oGhv4uMbCOqpfc2q == null;
	}

	internal static EQLHelper CT8JFMhvHyejBcCad4rl()
	{
		return hsP6oGhv4uMbCOqpfc2q;
	}

	internal static object njpOifhvMBHbZRRQ8V4u(object P_0)
	{
		return ((ISession)P_0).GetSessionImplementation();
	}

	internal static object YBlUuohvJEo45pgAFiKx(object P_0, object P_1)
	{
		return DetachedCriteria.ForEntityName((string)P_0, (string)P_1);
	}

	internal static object a1EkeQhv980IXhmjalqu(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static object fhL8gahvducpY25IM2XS()
	{
		return ComponentManager.Current;
	}

	internal static int aobMsVhvlGv6oo8R9Fdv(object P_0)
	{
		return ((SubqueryExpression)P_0).FromEntityStart;
	}

	internal static object gT2penhvr0mpNiGPktCB(object P_0)
	{
		return ((SubqueryExpression)P_0).FromEntity;
	}

	internal static object loSPmBhvggYpqR0k3JQC(object P_0)
	{
		return ((SubqueryExpression)P_0).SelectProperty;
	}

	internal static bool Eaywuwhv5lwL9PXcC8qf(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static int Sepr90hvjIJt3Vx56wj4(object P_0)
	{
		return ((SubqueryExpression)P_0).SelectPropertyStart;
	}

	internal static int Os3pqphvYl8SqDg9itqJ(object P_0)
	{
		return ((TreeItem)P_0).Start;
	}

	internal static void dkFhf5hvLrkCCV9ucW3T(object P_0, int P_1)
	{
		((TreeItem)P_0).Start = P_1;
	}

	internal static int gjfKyAhvUZiuD1SXHv1J(object P_0)
	{
		return ((TreeItem)P_0).Stop;
	}

	internal static object CO7yw9hvs69d2sFU5ApE(object P_0)
	{
		return ((EleWise.ELMA.NemerleParser.Parameter)P_0).Name;
	}

	internal static void dRZ4LIhvco9FjEf5jScA(object P_0, object P_1)
	{
		((Constant)P_0).Value = P_1;
	}

	internal static object aJFxnLhvzol61JYipW2Z(object P_0)
	{
		return ((Constant)P_0).Value;
	}

	internal static object k6UCYRh8FBUIE99VboA8(object P_0)
	{
		return ((RipeType)P_0).FullName;
	}

	internal static object hhEZSgh8BTQpWO0VKTsJ(object P_0, object P_1)
	{
		return ((Aliases)P_0).GetMetadata4Property((Property)P_1);
	}

	internal static object lPSghwh8WhkwviDBOEHm(object P_0)
	{
		return ((Property)P_0).Name;
	}

	internal static object utHDOvh8oL0yWxxvIfpP(object P_0, object P_1, object P_2, object P_3)
	{
		return ((IQueryTypeConvertion)P_0).ConvertValue((EntityMetadata)P_1, (string)P_2, P_3);
	}

	internal static object yVeqGPh8bu86ciTT0E4T(object P_0)
	{
		return ((ConstantFunction)P_0).Name;
	}

	internal static object j4CdhHh8hksGvG4P291X(object P_0, object P_1, object P_2, object P_3)
	{
		return ((IQueryFunctionResult)P_0).GetValue((EntityMetadata)P_1, (string)P_2, (object[])P_3);
	}

	internal static void iGPRqkh8Go9GCB68tCAB()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
