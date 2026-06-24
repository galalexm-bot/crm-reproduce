using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Types;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Runtime.Cache;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.ScriptDesigner.TranslateData;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db;

public class DbPreUpdater
{
	private static class DbPreUpdate
	{
		public static class Fields
		{
			public const string Version = "Ver";

			public const string Updating = "Updating";

			public const string NeedRecompileCfgModel = "NeedRecompileCfgModel";
		}
	}

	private static class DbConfigurationInfo
	{
		public static class Fields
		{
			public const string Id = "Id";

			public const string Uid = "Uid";

			public const string ServerTimeZone = "ServerTimeZone";
		}
	}

	private static class DbActivatedModule
	{
		public static class Fields
		{
			public const string ModuleName = "ModuleName";
		}
	}

	private static class DbDeactivatingModule
	{
		public static class Fields
		{
			public const string ModuleName = "ModuleName";
		}
	}

	private static class EntityMetadataHelper<T>
	{
		private static EntityMetadata metadata;

		private static Dictionary<string, PropertyMetadata> props;

		private static object g2kJ6qQpQB1v5DPCGvYs;

		public static string TableName => metadata.TableName;

		static EntityMetadataHelper()
		{
			//Discarded unreachable code: IL_0095, IL_00a4, IL_00af, IL_016f, IL_0182
			int num = 2;
			int num2 = num;
			List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
			PropertyMetadata current = default(PropertyMetadata);
			while (true)
			{
				switch (num2)
				{
				case 3:
					metadata = new EntityMetadata();
					num2 = 6;
					continue;
				case 1:
					props = new Dictionary<string, PropertyMetadata>();
					num2 = 3;
					continue;
				case 6:
					metadata.LoadFromType(typeof(T));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					SingletonReader.JJCZtPuTvSt();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					return;
				case 4:
					enumerator = metadata.Properties.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				try
				{
					while (true)
					{
						IL_00f0:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
							{
								num3 = 0;
							}
							goto IL_00b3;
						}
						goto IL_00cd;
						IL_00cd:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
						{
							num3 = 2;
						}
						goto IL_00b3;
						IL_00b3:
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								break;
							case 3:
								goto IL_00f0;
							case 2:
								props[current.Name] = current;
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
								{
									num3 = 3;
								}
								continue;
							case 0:
								return;
							}
							break;
						}
						goto IL_00cd;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
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

		public static string GetPropertyFieldName<TResult>(Expression<Func<T, TResult>> propAccessor)
		{
			if (!(propAccessor.Body is MemberExpression memberExpression))
			{
				throw new InvalidOperationException(string.Concat(propAccessor, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889284916)));
			}
			if (memberExpression.Member.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146542979))
			{
				return z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571E22C7);
			}
			if (!props.TryGetValue(memberExpression.Member.Name, out var value))
			{
				throw new InvalidOperationException(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889284990), memberExpression.Member.Name, typeof(T).FullName));
			}
			return ((SimpleTypeSettings)value.Settings).FieldName;
		}

		internal static bool I11KC1QpCgOifl2J2KZM()
		{
			return g2kJ6qQpQB1v5DPCGvYs == null;
		}

		internal static object u3LfOLQpvRSHs3GoO8uv()
		{
			return g2kJ6qQpQB1v5DPCGvYs;
		}
	}

	private sealed class MetadataItem : IMetadataItem, IEntity<long>, IEntity, IIdentified
	{
		internal static object rUrIBaQp8mDCEF54Bfrc;

		public long Id
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
					case 1:
						_003CId_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
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

		public Guid Uid
		{
			[CompilerGenerated]
			get
			{
				return _003CUid_003Ek__BackingField;
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
						_003CUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public DateTime CreationDate
		{
			[CompilerGenerated]
			get
			{
				return _003CCreationDate_003Ek__BackingField;
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
						_003CCreationDate_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
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

		public object Metadata
		{
			[CompilerGenerated]
			get
			{
				return _003CMetadata_003Ek__BackingField;
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
						_003CMetadata_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
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

		public IMetadataItemHeader Header
		{
			[CompilerGenerated]
			get
			{
				return _003CHeader_003Ek__BackingField;
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
						_003CHeader_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
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

		public string Comment
		{
			[CompilerGenerated]
			get
			{
				return _003CComment_003Ek__BackingField;
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
						_003CComment_003Ek__BackingField = value;
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
		}

		public long? CreationAuthorId { get; set; }

		public ScriptModule ScriptModule
		{
			[CompilerGenerated]
			get
			{
				return _003CScriptModule_003Ek__BackingField;
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
						_003CScriptModule_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ScriptModule ClientScriptModule
		{
			[CompilerGenerated]
			get
			{
				return _003CClientScriptModule_003Ek__BackingField;
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
						_003CClientScriptModule_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
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

		public object Dependencies
		{
			[CompilerGenerated]
			get
			{
				return _003CDependencies_003Ek__BackingField;
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
						_003CDependencies_003Ek__BackingField = value;
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

		public object GetId()
		{
			throw new NotImplementedException();
		}

		public void SetId(object id)
		{
			throw new NotImplementedException();
		}

		public string ToString(string format)
		{
			throw new NotImplementedException();
		}

		public object GetPropertyValue(Guid propertyUid)
		{
			throw new NotImplementedException();
		}

		public T GetPropertyValue<T>(Guid propertyUid)
		{
			throw new NotImplementedException();
		}

		public void SetPropertyValue(Guid propertyUid, object value)
		{
			throw new NotImplementedException();
		}

		public TSettings GetPropertySettings<TSettings>(Guid propertyUid) where TSettings : TypeSettings
		{
			throw new NotImplementedException();
		}

		public TypeSettings GetPropertySettings(Guid propertyUid)
		{
			throw new NotImplementedException();
		}

		public TypeSettings GetPropertySettings(Guid propertyUid, TypeSettings defaultSettings)
		{
			throw new NotImplementedException();
		}

		public TypeSettings LoadPropertyInstanceSettings(Guid propertyUid)
		{
			throw new NotImplementedException();
		}

		public void SavePropertyInstanceSettings(Guid propertyUid, TypeSettings settings)
		{
			throw new NotImplementedException();
		}

		public ITypeSettingsInstanceStore LoadSettingsInstanceStore(bool createIfNotExists, bool loadIfNotLoaded)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<IEntity> GetContainedEntities()
		{
			throw new NotImplementedException();
		}

		public IEntity GetRootEntity()
		{
			throw new NotImplementedException();
		}

		public void Save()
		{
			throw new NotImplementedException();
		}

		public void Delete()
		{
			throw new NotImplementedException();
		}

		public void Refresh()
		{
			throw new NotImplementedException();
		}

		public bool IsNew()
		{
			throw new NotImplementedException();
		}

		public bool IsDirty()
		{
			throw new NotImplementedException();
		}

		public Guid[] GetDirtyPropertyUids()
		{
			throw new NotImplementedException();
		}

		public MetadataItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool kBosc6QpZQ4WCaMZ5Kat()
		{
			return rUrIBaQp8mDCEF54Bfrc == null;
		}

		internal static MetadataItem WTwEH6Qput92inrB9HUN()
		{
			return (MetadataItem)rUrIBaQp8mDCEF54Bfrc;
		}
	}

	private class ScriptModuleReader
	{
		private object u;

		private object reader;

		private object alias;

		private static object codeItemsType;

		private static object asmRefsType;

		private static object webRefsType;

		private static Dictionary<string, bool> checkedColumnsExisting;

		internal static object YysnPQQpIuDK8QN4tehp;

		public ScriptModule Read(DbPreUpdater u, IDataReader reader, string alias)
		{
			//Discarded unreachable code: IL_00a8
			int num = 2;
			ScriptModule scriptModule = default(ScriptModule);
			long num3 = default(long);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 20:
						return null;
					case 16:
					{
						ScriptModule scriptModule15 = scriptModule;
						ParameterExpression parameterExpression = Expression.Parameter(oudkoeQpiiMT4csjieYL(typeof(ScriptModule).TypeHandle), (string)Fi2UWxQpRVKCN5NqCav8(-2099751081 ^ -2099647183));
						N7bqnAQpOhxqGpcEJYaP(scriptModule15, ReadString(Expression.Lambda<Func<ScriptModule, string>>((Expression)XFAnclQpTMgeLDdS5ADd(parameterExpression, (MethodInfo)E4KpoUQpKp1A2TchFi5t((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
						num2 = 9;
						continue;
					}
					case 4:
					case 6:
					{
						ScriptModule scriptModule8 = scriptModule;
						ParameterExpression parameterExpression = (ParameterExpression)pX1m34QpqW6qg7vagVP1(oudkoeQpiiMT4csjieYL(typeof(ScriptModule).TypeHandle), Fi2UWxQpRVKCN5NqCav8(0x1637C429 ^ 0x16367E4F));
						QMV1kvQpeSSqfkPclyeK(scriptModule8, ReadString(Expression.Lambda<Func<ScriptModule, string>>((Expression)XFAnclQpTMgeLDdS5ADd(parameterExpression, (MethodInfo)E4KpoUQpKp1A2TchFi5t((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num2 = 8;
						}
						continue;
					}
					case 13:
					{
						ScriptModule scriptModule4 = scriptModule;
						object obj = codeItemsType;
						DbDataReader rs = (DbDataReader)reader;
						string[] array = new string[1];
						ParameterExpression parameterExpression = (ParameterExpression)pX1m34QpqW6qg7vagVP1(typeof(ScriptModule), Fi2UWxQpRVKCN5NqCav8(0x7247028A ^ 0x7246B8EC));
						array[0] = alias + EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, RootCodeItemCollection>>((Expression)XFAnclQpTMgeLDdS5ADd(parameterExpression, (MethodInfo)E4KpoUQpKp1A2TchFi5t((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						e6i7c3Qp2FoPXSRi7rZg(scriptModule4, (RootCodeItemCollection)((XmlSerializableType<RootCodeItemCollection>)obj).NullSafeGet(rs, array, (ISessionImplementor)null, (object)null));
						num = 6;
						break;
					}
					case 7:
					{
						ScriptModule scriptModule3 = scriptModule;
						ParameterExpression parameterExpression = (ParameterExpression)pX1m34QpqW6qg7vagVP1(oudkoeQpiiMT4csjieYL(typeof(ScriptModule).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3367300));
						scriptModule3.Namespace = ReadString(Expression.Lambda<Func<ScriptModule, string>>(Expression.Property(parameterExpression, (MethodInfo)E4KpoUQpKp1A2TchFi5t((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 3;
						continue;
					}
					case 19:
					{
						ScriptModule scriptModule12 = scriptModule;
						ParameterExpression parameterExpression = Expression.Parameter(typeof(ScriptModule), (string)Fi2UWxQpRVKCN5NqCav8(-1765851862 ^ -1765898420));
						XakdugQpwfjVV3gMFXoO(scriptModule12, ReadString(Expression.Lambda<Func<ScriptModule, string>>(Expression.Property(parameterExpression, (MethodInfo)E4KpoUQpKp1A2TchFi5t((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
						num2 = 22;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					case 18:
					{
						ScriptModule scriptModule10 = scriptModule;
						object obj4 = asmRefsType;
						DbDataReader obj5 = (DbDataReader)reader;
						string[] array3 = new string[1];
						ParameterExpression parameterExpression = Expression.Parameter(oudkoeQpiiMT4csjieYL(typeof(ScriptModule).TypeHandle), (string)Fi2UWxQpRVKCN5NqCav8(0x4785BC0D ^ 0x4784066B));
						array3[0] = (string)sUJhejQpDSO6HrmAwrPy(alias, EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, List<AssemblyReference>>>((Expression)XFAnclQpTMgeLDdS5ADd(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
						scriptModule10.GlobalScriptModules = (List<AssemblyReference>)WbP2lEQptXnyclPXFxYq(obj4, obj5, array3, null, null);
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					case 21:
					{
						ScriptModule scriptModule6 = scriptModule;
						ParameterExpression parameterExpression = (ParameterExpression)pX1m34QpqW6qg7vagVP1(oudkoeQpiiMT4csjieYL(typeof(ScriptModule).TypeHandle), Fi2UWxQpRVKCN5NqCav8(-1978478350 ^ -1978439020));
						iBfNovQpkyMGSkjl85fk(scriptModule6, ReadString(Expression.Lambda<Func<ScriptModule, string>>((Expression)XFAnclQpTMgeLDdS5ADd(parameterExpression, (MethodInfo)E4KpoUQpKp1A2TchFi5t((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num2 = 23;
						}
						continue;
					}
					case 12:
						if (num3 != 0L)
						{
							scriptModule = new ScriptModule();
							num = 15;
							break;
						}
						num2 = 20;
						continue;
					case 22:
					{
						ScriptModule scriptModule19 = scriptModule;
						ParameterExpression parameterExpression = (ParameterExpression)pX1m34QpqW6qg7vagVP1(oudkoeQpiiMT4csjieYL(typeof(ScriptModule).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29350139));
						qKKIYvQp4ksGuRLSehng(scriptModule19, ReadString(Expression.Lambda<Func<ScriptModule, string>>((Expression)XFAnclQpTMgeLDdS5ADd(parameterExpression, (MethodInfo)E4KpoUQpKp1A2TchFi5t((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
						num2 = 14;
						continue;
					}
					case 5:
						this.alias = alias;
						num2 = 10;
						continue;
					case 26:
					{
						ScriptModule scriptModule18 = scriptModule;
						ParameterExpression parameterExpression = (ParameterExpression)pX1m34QpqW6qg7vagVP1(oudkoeQpiiMT4csjieYL(typeof(ScriptModule).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218383416));
						LZcBVTQpXGEKP3Bko2Z6(scriptModule18, ReadGuid(Expression.Lambda<Func<ScriptModule, Guid>>(Expression.Property(parameterExpression, (MethodInfo)E4KpoUQpKp1A2TchFi5t((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
						num = 21;
						break;
					}
					case 1:
						this.reader = reader;
						num2 = 5;
						continue;
					case 25:
					{
						ScriptModule scriptModule17 = scriptModule;
						ParameterExpression parameterExpression = (ParameterExpression)pX1m34QpqW6qg7vagVP1(oudkoeQpiiMT4csjieYL(typeof(ScriptModule).TypeHandle), Fi2UWxQpRVKCN5NqCav8(0x48A7E34A ^ 0x48A6592C));
						gPdJDAQpnSQ0B3tVVWjb(scriptModule17, (byte[])SafeRead(Expression.Lambda<Func<ScriptModule, byte[]>>((Expression)XFAnclQpTMgeLDdS5ADd(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
						num2 = 16;
						continue;
					}
					case 24:
					{
						ScriptModule scriptModule16 = scriptModule;
						ParameterExpression parameterExpression = (ParameterExpression)pX1m34QpqW6qg7vagVP1(oudkoeQpiiMT4csjieYL(typeof(ScriptModule).TypeHandle), Fi2UWxQpRVKCN5NqCav8(0x5DD55050 ^ 0x5DD4EA36));
						iVUCECQppHHiSBIeFdlh(scriptModule16, ReadString(Expression.Lambda<Func<ScriptModule, string>>((Expression)XFAnclQpTMgeLDdS5ADd(parameterExpression, (MethodInfo)E4KpoUQpKp1A2TchFi5t((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
						num2 = 17;
						continue;
					}
					case 11:
					{
						ScriptModule scriptModule14 = scriptModule;
						ParameterExpression parameterExpression = Expression.Parameter(oudkoeQpiiMT4csjieYL(typeof(ScriptModule).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099647183));
						NL37DTQpN8Jk0rZpyFhZ(scriptModule14, ReadGuid(Expression.Lambda<Func<ScriptModule, Guid>>((Expression)XFAnclQpTMgeLDdS5ADd(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					case 27:
					{
						ScriptModule scriptModule13 = scriptModule;
						object obj6 = asmRefsType;
						DbDataReader obj7 = (DbDataReader)reader;
						string[] array4 = new string[1];
						ParameterExpression parameterExpression = Expression.Parameter(oudkoeQpiiMT4csjieYL(typeof(ScriptModule).TypeHandle), (string)Fi2UWxQpRVKCN5NqCav8(0x1DE3DD89 ^ 0x1DE267EF));
						array4[0] = (string)sUJhejQpDSO6HrmAwrPy(alias, EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, List<AssemblyReference>>>((Expression)XFAnclQpTMgeLDdS5ADd(parameterExpression, (MethodInfo)E4KpoUQpKp1A2TchFi5t((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
						scriptModule13.LocalReferences = (List<AssemblyReference>)WbP2lEQptXnyclPXFxYq(obj6, obj7, array4, null, null);
						num2 = 18;
						continue;
					}
					case 2:
						this.u = u;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num2 = 1;
						}
						continue;
					default:
						return scriptModule;
					case 17:
					{
						ScriptModule scriptModule11 = scriptModule;
						ParameterExpression parameterExpression = Expression.Parameter(oudkoeQpiiMT4csjieYL(typeof(ScriptModule).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92EA8B3));
						R0IcxGQpa1uv99UEPK0V(scriptModule11, ReadString(Expression.Lambda<Func<ScriptModule, string>>(Expression.Property(parameterExpression, (MethodInfo)E4KpoUQpKp1A2TchFi5t((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
						num2 = 27;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num2 = 15;
						}
						continue;
					}
					case 14:
					{
						ScriptModule scriptModule9 = scriptModule;
						object obj2 = webRefsType;
						DbDataReader obj3 = (DbDataReader)reader;
						string[] array2 = new string[1];
						ParameterExpression parameterExpression = (ParameterExpression)pX1m34QpqW6qg7vagVP1(typeof(ScriptModule), Fi2UWxQpRVKCN5NqCav8(0x4DC2B14D ^ 0x4DC30B2B));
						array2[0] = (string)sUJhejQpDSO6HrmAwrPy(alias, EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, List<ScriptWebReference>>>((Expression)XFAnclQpTMgeLDdS5ADd(parameterExpression, (MethodInfo)E4KpoUQpKp1A2TchFi5t((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
						scriptModule9.WebReferences = (List<ScriptWebReference>)UFZpbMQp6IBBJ1HxiOmC(obj2, obj3, array2, null, null);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					case 8:
					{
						ScriptModule scriptModule7 = scriptModule;
						ParameterExpression parameterExpression = (ParameterExpression)pX1m34QpqW6qg7vagVP1(oudkoeQpiiMT4csjieYL(typeof(ScriptModule).TypeHandle), Fi2UWxQpRVKCN5NqCav8(0x4EDCBA32 ^ 0x4EDD0054));
						tL4hYYQpPSGLNgStE4BV(scriptModule7, (byte[])SafeRead(Expression.Lambda<Func<ScriptModule, byte[]>>((Expression)XFAnclQpTMgeLDdS5ADd(parameterExpression, (MethodInfo)E4KpoUQpKp1A2TchFi5t((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
						num2 = 20;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num2 = 23;
						}
						continue;
					}
					case 9:
					{
						ParameterExpression parameterExpression = (ParameterExpression)pX1m34QpqW6qg7vagVP1(oudkoeQpiiMT4csjieYL(typeof(ScriptModule).TypeHandle), Fi2UWxQpRVKCN5NqCav8(-1998538950 ^ -1998516900));
						if (!ColumnExists(Expression.Lambda<Func<ScriptModule, RootCodeItemCollection>>((Expression)XFAnclQpTMgeLDdS5ADd(parameterExpression, (MethodInfo)E4KpoUQpKp1A2TchFi5t((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })))
						{
							num2 = 4;
							continue;
						}
						goto case 13;
					}
					case 3:
					{
						ScriptModule scriptModule5 = scriptModule;
						ParameterExpression parameterExpression = Expression.Parameter(oudkoeQpiiMT4csjieYL(typeof(ScriptModule).TypeHandle), (string)Fi2UWxQpRVKCN5NqCav8(0x5A4C7B29 ^ 0x5A4DC14F));
						y7UfyfQp3oCC2kvBSJxU(scriptModule5, ReadGuid(Expression.Lambda<Func<ScriptModule, Guid>>((Expression)XFAnclQpTMgeLDdS5ADd(parameterExpression, (MethodInfo)E4KpoUQpKp1A2TchFi5t((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
						num2 = 24;
						continue;
					}
					case 15:
						scriptModule.Id = num3;
						num2 = 20;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 26;
						}
						continue;
					case 10:
					{
						ParameterExpression parameterExpression = (ParameterExpression)pX1m34QpqW6qg7vagVP1(oudkoeQpiiMT4csjieYL(typeof(ScriptModule).TypeHandle), Fi2UWxQpRVKCN5NqCav8(0x463A0F3C ^ 0x463BB55A));
						num3 = ReadInt64(Expression.Lambda<Func<ScriptModule, long>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(Entity<long>).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num2 = 12;
						}
						continue;
					}
					case 23:
					{
						ScriptModule scriptModule2 = scriptModule;
						ParameterExpression parameterExpression = Expression.Parameter(oudkoeQpiiMT4csjieYL(typeof(ScriptModule).TypeHandle), (string)Fi2UWxQpRVKCN5NqCav8(0x34A6D230 ^ 0x34A76856));
						ymbA4kQp1eRe9FdGZK2X(scriptModule2, ReadString(Expression.Lambda<Func<ScriptModule, string>>((Expression)XFAnclQpTMgeLDdS5ADd(parameterExpression, (MethodInfo)E4KpoUQpKp1A2TchFi5t((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
						num2 = 11;
						continue;
					}
					}
					break;
				}
			}
		}

		public bool ColumnExists<TPropResult>(Expression<Func<ScriptModule, TPropResult>> propAccessor)
		{
			return ColumnExists(EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(propAccessor));
		}

		public bool ColumnExists(string columnName)
		{
			//Discarded unreachable code: IL_0051, IL_0060, IL_0070, IL_007f, IL_014e, IL_015d
			int num = 5;
			int num2 = num;
			bool value = default(bool);
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 4:
					return value;
				case 3:
				case 7:
					if (bxibowQpHFRtXJCHKso2(((IDataRecord)reader).GetName(num3), columnName, StringComparison.CurrentCultureIgnoreCase))
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				default:
					checkedColumnsExisting[columnName] = value;
					num2 = 2;
					break;
				case 8:
					value = true;
					num2 = 11;
					break;
				case 2:
					return value;
				case 6:
				case 10:
					if (num3 < lBOPLQQpATnR39iPiUXk(reader))
					{
						num2 = 3;
						break;
					}
					goto default;
				case 5:
					if (!checkedColumnsExisting.TryGetValue(columnName, out value))
					{
						value = false;
						num2 = 9;
					}
					else
					{
						num2 = 4;
					}
					break;
				case 1:
					num3++;
					num2 = 10;
					break;
				case 9:
					num3 = 0;
					num2 = 6;
					break;
				}
			}
		}

		private object SafeRead<TPropResult>(Expression<Func<ScriptModule, TPropResult>> propAccessor)
		{
			object obj = ((IDataRecord)reader)[(string)alias + EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(propAccessor)];
			if (obj is DBNull)
			{
				return null;
			}
			return obj;
		}

		private long ReadInt64<TPropResult>(Expression<Func<ScriptModule, TPropResult>> propAccessor)
		{
			return Convert.ToInt64(SafeRead(propAccessor));
		}

		private Guid ReadGuid<TPropResult>(Expression<Func<ScriptModule, TPropResult>> propAccessor)
		{
			object obj = SafeRead(propAccessor);
			if (obj == null)
			{
				return Guid.Empty;
			}
			return ((DbPreUpdater)u).Transform.Dialect.GetGuid(obj);
		}

		private string ReadString<TPropResult>(Expression<Func<ScriptModule, TPropResult>> propAccessor)
		{
			return (string)SafeRead(propAccessor);
		}

		public ScriptModuleReader()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			wYgMTPQp7y14WI6OmoRE();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static ScriptModuleReader()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					asmRefsType = new AssemblyReferenceNHType();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 4;
					}
					break;
				case 2:
					return;
				case 4:
					webRefsType = new ScriptWebReferencesNHType();
					num2 = 5;
					break;
				default:
					codeItemsType = new RootCodeItemCollectionNH();
					num2 = 3;
					break;
				case 1:
					wYgMTPQp7y14WI6OmoRE();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					checkedColumnsExisting = new Dictionary<string, bool>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		internal static Type oudkoeQpiiMT4csjieYL(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object Fi2UWxQpRVKCN5NqCav8(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object pX1m34QpqW6qg7vagVP1(Type P_0, object P_1)
		{
			return Expression.Parameter(P_0, (string)P_1);
		}

		internal static object E4KpoUQpKp1A2TchFi5t(RuntimeMethodHandle P_0)
		{
			return MethodBase.GetMethodFromHandle(P_0);
		}

		internal static void LZcBVTQpXGEKP3Bko2Z6(object P_0, Guid value)
		{
			((ScriptModule)P_0).Uid = value;
		}

		internal static object XFAnclQpTMgeLDdS5ADd(object P_0, object P_1)
		{
			return Expression.Property((Expression)P_0, (MethodInfo)P_1);
		}

		internal static void iBfNovQpkyMGSkjl85fk(object P_0, object P_1)
		{
			((ScriptModule)P_0).AssemblyName = (string)P_1;
		}

		internal static void gPdJDAQpnSQ0B3tVVWjb(object P_0, object P_1)
		{
			((ScriptModule)P_0).AssemblyRaw = (byte[])P_1;
		}

		internal static void N7bqnAQpOhxqGpcEJYaP(object P_0, object P_1)
		{
			((ScriptModule)P_0).ClassName = (string)P_1;
		}

		internal static void e6i7c3Qp2FoPXSRi7rZg(object P_0, object P_1)
		{
			((ScriptModule)P_0).CodeItems = (RootCodeItemCollection)P_1;
		}

		internal static void QMV1kvQpeSSqfkPclyeK(object P_0, object P_1)
		{
			((ScriptModule)P_0).CompiledFileName = (string)P_1;
		}

		internal static void tL4hYYQpPSGLNgStE4BV(object P_0, object P_1)
		{
			((ScriptModule)P_0).DebugRaw = (byte[])P_1;
		}

		internal static void ymbA4kQp1eRe9FdGZK2X(object P_0, object P_1)
		{
			((ScriptModule)P_0).ModuleName = (string)P_1;
		}

		internal static void NL37DTQpN8Jk0rZpyFhZ(object P_0, Guid value)
		{
			((ScriptModule)P_0).ModuleTypeUid = value;
		}

		internal static void y7UfyfQp3oCC2kvBSJxU(object P_0, Guid value)
		{
			((ScriptModule)P_0).ObjectUid = value;
		}

		internal static void iVUCECQppHHiSBIeFdlh(object P_0, object P_1)
		{
			((ScriptModule)P_0).References = (string)P_1;
		}

		internal static void R0IcxGQpa1uv99UEPK0V(object P_0, object P_1)
		{
			((ScriptModule)P_0).ElmaReferences = (string)P_1;
		}

		internal static object sUJhejQpDSO6HrmAwrPy(object P_0, object P_1)
		{
			return (string)P_0 + (string)P_1;
		}

		internal static object WbP2lEQptXnyclPXFxYq(object P_0, object P_1, object P_2, object P_3, object P_4)
		{
			return ((XmlSerializableType<List<AssemblyReference>>)P_0).NullSafeGet((DbDataReader)P_1, (string[])P_2, (ISessionImplementor)P_3, P_4);
		}

		internal static void XakdugQpwfjVV3gMFXoO(object P_0, object P_1)
		{
			((ScriptModule)P_0).ScriptMetodsList = (string)P_1;
		}

		internal static void qKKIYvQp4ksGuRLSehng(object P_0, object P_1)
		{
			((ScriptModule)P_0).SourceCode = (string)P_1;
		}

		internal static object UFZpbMQp6IBBJ1HxiOmC(object P_0, object P_1, object P_2, object P_3, object P_4)
		{
			return ((XmlSerializableType<List<ScriptWebReference>>)P_0).NullSafeGet((DbDataReader)P_1, (string[])P_2, (ISessionImplementor)P_3, P_4);
		}

		internal static bool NqJAOOQpVY2yhhj49Vxw()
		{
			return YysnPQQpIuDK8QN4tehp == null;
		}

		internal static ScriptModuleReader fhfm2oQpS9cmknjcwl5I()
		{
			return (ScriptModuleReader)YysnPQQpIuDK8QN4tehp;
		}

		internal static bool bxibowQpHFRtXJCHKso2(object P_0, object P_1, StringComparison P_2)
		{
			return ((string)P_0).Equals((string)P_1, P_2);
		}

		internal static int lBOPLQQpATnR39iPiUXk(object P_0)
		{
			return ((IDataRecord)P_0).FieldCount;
		}

		internal static void wYgMTPQp7y14WI6OmoRE()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	public const int NewVersionNumber = 0;

	internal const string Index_ConfigInfo_Id = "Idx_ConfigInfo_Id";

	private ITransformationProvider transform;

	private BackupManager backupManager;

	private bool structuresCreated;

	private Guid configurationUid;

	private bool needRecompileConfigurationModel;

	private bool updatingStarted;

	private bool forLicenseCheck;

	private bool isFirstServerInCluster;

	private readonly XmlObjectSerializableType xmlObjSerType;

	private bool isFirstStart;

	private static DbPreUpdater jGk8IWW8tPAq0EJH7CW6;

	public Guid ConfigurationUid => configurationUid;

	public bool BackupCreated
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
				{
					BackupManager obj = backupManager;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 0;
						}
						break;
					}
					return obj.BackupCreated;
				}
				default:
					return false;
				}
			}
		}
	}

	public bool NeedRecompileConfigurationModel => needRecompileConfigurationModel;

	public bool IsFirstStart => isFirstStart;

	public int OldVersion
	{
		[CompilerGenerated]
		get
		{
			return _003COldVersion_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003COldVersion_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected internal ITransformationProvider Transform => transform;

	public DbPreUpdater(ITransformationProvider transform, BackupManager backupManager, bool forLicenseCheck, bool isFirstServerInCluster)
	{
		//Discarded unreachable code: IL_003a
		aevHXWW86ph861HmEOTP();
		xmlObjSerType = new XmlObjectSerializableType();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 5:
				return;
			case 3:
				this.forLicenseCheck = forLicenseCheck;
				num = 4;
				break;
			default:
				ImkeT9W8ASqT0oqM4uyb(transform, iwFuCyW8HqE3MaLgs2fW(0x49E27B8A ^ 0x49E3CB9C));
				num = 6;
				break;
			case 2:
				ReadOrCreateConfigurationInfo();
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num = 5;
				}
				break;
			case 6:
				this.transform = transform;
				num = 7;
				break;
			case 1:
			{
				CheckStructuresCreated();
				int num2 = 2;
				num = num2;
				break;
			}
			case 4:
				this.isFirstServerInCluster = isFirstServerInCluster;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num = 1;
				}
				break;
			case 7:
				this.backupManager = (forLicenseCheck ? null : backupManager);
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num = 3;
				}
				break;
			}
		}
	}

	internal ApplicationStartCache GetApplicationStartCache()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (ApplicationStartCache)jrUOQhW87XvhKq8xiWcO(transform);
			case 1:
				CheckStructuresCreated();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IEnumerable<AssemblyModelsMetadata> GetAssemblyModels(AssemblyModelsMetadataStatus status)
	{
		return GetAssemblyModels(status, Array.Empty<string>());
	}

	public IEnumerable<AssemblyModelsMetadata> GetAssemblyModels(AssemblyModelsMetadataStatus status, params string[] assemblyNames)
	{
		CheckStructuresCreated();
		List<AssemblyModelsMetadata> list = new List<AssemblyModelsMetadata>();
		int num = (int)status;
		string text = num.ToString();
		if (status == AssemblyModelsMetadataStatus.Runned)
		{
			text = text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A33F234) + 3;
		}
		string text2 = "";
		if (assemblyNames != null && assemblyNames.Length != 0)
		{
			text2 = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629873394), Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7E8242)), string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76D867E), assemblyNames.Select((string x) => (string)_003C_003Ec.eoWJ0lQpJlcm5iXeWlqd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477138812), x, _003C_003Ec.HngkJ9QpMAk3N4cANOIt(-1867198571 ^ -1867197749)))));
		}
		using IDataReader dataReader = Transform.ExecuteQuery(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3369866), Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1765896720)), Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63AB256E)), Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA59AB1F)), text, text2));
		while (dataReader.Read())
		{
			MemoryStream stream = dataReader.GetStream(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE0CA75));
			MemoryStream stream2 = dataReader.GetStream(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979271893));
			MemoryStream stream3 = dataReader.GetStream(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29348787));
			MemoryStream stream4 = dataReader.GetStream(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A6C0DD));
			AssemblyModelsMetadata assemblyModelsMetadata = new AssemblyModelsMetadata
			{
				Id = Convert.ToInt64(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583777878)]),
				Name = (string)dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FE7B09)],
				Status = (AssemblyModelsMetadataStatus)Convert.ToInt32(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138127362)]),
				AssemblyRawStream = stream,
				DocumentationRawStream = stream3,
				MetadataStream = stream4,
				DebugRawStream = stream2
			};
			if (status != AssemblyModelsMetadataStatus.Prepared || assemblyModelsMetadata.Name != z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3630F905))
			{
				list.Add(assemblyModelsMetadata);
			}
		}
		return list;
	}

	public IEnumerable<string> GetAssemblyModelNames()
	{
		CheckStructuresCreated();
		List<string> list = new List<string>();
		using IDataReader dataReader = Transform.ExecuteQuery(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x5114B34F), Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7E8242)), Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317688310))));
		while (dataReader.Read())
		{
			list.Add((string)dataReader[0]);
		}
		return list;
	}

	public void RecompileConfigurationModel(IMetadataRuntimeService runtimeService)
	{
		//Discarded unreachable code: IL_01fa, IL_02af, IL_030d, IL_0345, IL_0354
		int num = 2;
		int num2 = num;
		IStartInformation startInformation = default(IStartInformation);
		_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals0;
		IEnumerable<IMetadataItem> enumerable = default(IEnumerable<IMetadataItem>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				startInformation = (IStartInformation)Ty81mOW805BRhFyFA4Ci(12.0, suPfR4W8xUyaN4MydJQh(iwFuCyW8HqE3MaLgs2fW(0x5F3078B6 ^ 0x5F31C938)));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_0();
					int num3 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num3 = 2;
					}
					while (true)
					{
						object assemblyRaw;
						switch (num3)
						{
						case 6:
							Locator.GetServiceNotNull<IMetadataUidChecker>().AddUidIfNeeded(enumerable);
							num3 = 7;
							continue;
						case 5:
							tUDIjeW8yN7x3pP8fhLo(Transform);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
							CS_0024_003C_003E8__locals0.publishedAssemblyMetadata = GetAssemblyModels(AssemblyModelsMetadataStatus.Published);
							num3 = 4;
							continue;
						case 2:
							enumerable = LoadMetadataItems();
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
							{
								num3 = 6;
							}
							continue;
						case 7:
							enumerable = enumerable.ToReadOnlyCollection();
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
							{
								num3 = 1;
							}
							continue;
						case 4:
						{
							AssemblyModelsMetadata assemblyModelsMetadata = CS_0024_003C_003E8__locals0.publishedAssemblyMetadata.FirstOrDefault((AssemblyModelsMetadata a) => (string)_003C_003Ec.qdvptIQp9XBUqrmmlujd(a) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488879697));
							if (assemblyModelsMetadata == null)
							{
								int num4 = 3;
								num3 = num4;
								continue;
							}
							assemblyRaw = g96rFSW8mhCWlGtakJ60(assemblyModelsMetadata);
							goto IL_019f;
						}
						case 3:
							{
								assemblyRaw = null;
								goto IL_019f;
							}
							IL_019f:
							ConfigurationModelAssemblyBuilder.InitVersion((MemoryStream)assemblyRaw);
							num3 = 5;
							continue;
						}
						try
						{
							ConfigurationModelAssemblyBuilder.Publish(enumerable, delegate(string assemblyName, AssemblyModelsMetadataStatus status)
							{
								int num8 = 1;
								int num9 = num8;
								_003C_003Ec__DisplayClass12_1 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_1);
								while (true)
								{
									switch (num9)
									{
									default:
										_003C_003Ec__DisplayClass12_.assemblyName = assemblyName;
										num9 = 3;
										break;
									case 1:
										_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_1();
										num9 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
										{
											num9 = 0;
										}
										break;
									case 2:
										return null;
									case 3:
										if (status == AssemblyModelsMetadataStatus.Published)
										{
											return CS_0024_003C_003E8__locals0.publishedAssemblyMetadata.FirstOrDefault(_003C_003Ec__DisplayClass12_._003CRecompileConfigurationModel_003Eb__2);
										}
										num9 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
										{
											num9 = 2;
										}
										break;
									}
								}
							}, SaveAssemblyModelsMetadata, Locator.GetServiceNotNull<IMetadataRuntimeService>(), Locator.GetServiceNotNull<IModelAssemblyBuilderHandler>());
							int num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
							{
								num5 = 1;
							}
							while (true)
							{
								switch (num5)
								{
								case 2:
									return;
								case 1:
									Transform.Update((string)iwFuCyW8HqE3MaLgs2fW(0x49E27B8A ^ 0x49E243A8), new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939422364) }, new object[1] { (short)0 }, null);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
									{
										num5 = 0;
									}
									break;
								default:
									Gx7IQPW8MddjeXObG6UK(Transform);
									num5 = 2;
									break;
								}
							}
						}
						catch
						{
							int num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								case 1:
									throw;
								}
								SwVO9wW8JQNnmdbHuW7w(Transform);
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
								{
									num6 = 1;
								}
							}
						}
					}
				}
				finally
				{
					if (startInformation != null)
					{
						int num7 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num7 = 1;
						}
						while (true)
						{
							switch (num7)
							{
							case 1:
								Si324IW899daRPSvoG8Z(startInformation);
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
								{
									num7 = 0;
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
	}

	public IEnumerable<string> GetActivatedModules()
	{
		CheckStructuresCreated();
		List<string> list = new List<string>();
		using IDataReader dataReader = Transform.ExecuteQuery(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106546538), Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108674010)), Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70058994))));
		while (dataReader.Read())
		{
			list.Add((string)dataReader[0]);
		}
		return list;
	}

	public IEnumerable<string> GetDeactivatingModules()
	{
		CheckStructuresCreated();
		List<string> list = new List<string>();
		using IDataReader dataReader = Transform.ExecuteQuery(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFF4938), Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195650813)), Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335087529))));
		while (dataReader.Read())
		{
			list.Add((string)dataReader[0]);
		}
		return list;
	}

	public void StartUpdating()
	{
		//Discarded unreachable code: IL_0050, IL_0094, IL_00a3, IL_00b3, IL_00c2, IL_0143, IL_019e, IL_01db, IL_01ea, IL_023c, IL_0274, IL_0283
		int num = 2;
		int num2 = num;
		bool lockTaken = default(bool);
		DbPreUpdater dbPreUpdater = default(DbPreUpdater);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				lockTaken = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				dbPreUpdater = this;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			try
			{
				Monitor.Enter(dbPreUpdater, ref lockTaken);
				int num3 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						return;
					case 1:
						if (!updatingStarted)
						{
							num3 = 2;
							continue;
						}
						return;
					case 5:
						return;
					case 2:
					case 3:
						tUDIjeW8yN7x3pP8fhLo(Transform);
						num3 = 4;
						continue;
					case 4:
						try
						{
							Transform.Update((string)iwFuCyW8HqE3MaLgs2fW(0x31326106 ^ 0x31325924), new string[1] { (string)iwFuCyW8HqE3MaLgs2fW(-1886646897 ^ -1886535929) }, new object[1] { (short)1 }, null);
							int num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									Gx7IQPW8MddjeXObG6UK(Transform);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
									{
										num4 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
						catch
						{
							int num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
							{
								num5 = 1;
							}
							while (true)
							{
								switch (num5)
								{
								case 1:
									SwVO9wW8JQNnmdbHuW7w(Transform);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
									{
										num5 = 0;
									}
									break;
								default:
									throw;
								}
							}
						}
						break;
					case 6:
						break;
					case 0:
						return;
					}
					updatingStarted = true;
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num3 = 0;
					}
				}
			}
			finally
			{
				if (lockTaken)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						default:
							noyWtOW8d6ojcnfZSGx2(dbPreUpdater);
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
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
		}
	}

	public void EndUpdating()
	{
		//Discarded unreachable code: IL_0050, IL_00a4, IL_013c, IL_0197, IL_01d4, IL_0208, IL_0217, IL_0248, IL_0280, IL_028f
		int num = 1;
		int num2 = num;
		DbPreUpdater obj = default(DbPreUpdater);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 3:
						case 5:
							tUDIjeW8yN7x3pP8fhLo(Transform);
							num3 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
							{
								num3 = 0;
							}
							break;
						case 1:
							return;
						case 2:
							updatingStarted = false;
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
							{
								num3 = 4;
							}
							break;
						case 6:
							try
							{
								Transform.Update((string)iwFuCyW8HqE3MaLgs2fW(0x1C9495B4 ^ 0x1C94AD96), new string[1] { (string)iwFuCyW8HqE3MaLgs2fW(0x4D1C1EE4 ^ 0x4D1DAC6C) }, new object[1] { (short)0 }, null);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
								{
									num4 = 0;
								}
								while (true)
								{
									switch (num4)
									{
									default:
										Transform.CommitTransaction();
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
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
							catch
							{
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
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
									SwVO9wW8JQNnmdbHuW7w(Transform);
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
									{
										num5 = 0;
									}
								}
							}
							goto case 2;
						default:
							if (!updatingStarted)
							{
								return;
							}
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
							{
								num3 = 5;
							}
							break;
						case 4:
							return;
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num6 = 1;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								Monitor.Exit(obj);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
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
			case 1:
				obj = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 0;
				}
				break;
			default:
				lockTaken = false;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal void CheckMetadataList(IEnumerable<AssemblyModelsMetadata> metadata)
	{
		AssemblyModelsMetadata assemblyModelsMetadata = metadata.FirstOrDefault((AssemblyModelsMetadata a) => _003C_003Ec.GSAs0UQpd0xd9jvUR3Ho(_003C_003Ec.qdvptIQp9XBUqrmmlujd(a), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3330434)));
		if (assemblyModelsMetadata != null)
		{
			AbstractMetadata[] metadata2 = assemblyModelsMetadata.RestoreMetadata();
			if (Locator.GetServiceNotNull<IMetadataUidChecker>().AddUidIfNeeded(metadata2))
			{
				needRecompileConfigurationModel = true;
			}
		}
	}

	protected virtual void CreateStructures()
	{
		//Discarded unreachable code: IL_015e, IL_016d, IL_017e, IL_027a, IL_02b2, IL_02c1, IL_02ee, IL_03ea, IL_0427, IL_0495, IL_04a4, IL_04b3, IL_056e, IL_057d, IL_062d, IL_0688, IL_06c5, IL_07ba, IL_0815, IL_0852, IL_0b73, IL_0bb0, IL_0d4d, IL_0d5c, IL_0e39, IL_0e94, IL_0ed1, IL_0ee0
		int num = 6;
		IDataReader dataReader = default(IDataReader);
		int num3 = default(int);
		Column column2 = default(Column);
		Column column = default(Column);
		Table table2 = default(Table);
		IList<AssemblyModelsMetadataStatus> modelConfigurationStatuses = default(IList<AssemblyModelsMetadataStatus>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 24:
					tUDIjeW8yN7x3pP8fhLo(Transform);
					num2 = 7;
					continue;
				case 21:
					try
					{
						int num15;
						if (!uIf3x6W8zmoPMZGFkXfa(dataReader))
						{
							num15 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
							{
								num15 = 2;
							}
							goto IL_00fc;
						}
						goto IL_0183;
						IL_0183:
						OldVersion = Convert.ToInt32(WSxfrUWZF64N0Xup0NWn(dataReader, iwFuCyW8HqE3MaLgs2fW(0x76DD48E ^ 0x76C6612)));
						num15 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num15 = 0;
						}
						goto IL_00fc;
						IL_00fc:
						while (true)
						{
							int num17;
							switch (num15)
							{
							case 1:
								if (WSxfrUWZF64N0Xup0NWn(dataReader, iwFuCyW8HqE3MaLgs2fW(0x7247028A ^ 0x7246B002)) is DBNull)
								{
									num15 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
									{
										num15 = 4;
									}
									continue;
								}
								num17 = Convert.ToInt16(WSxfrUWZF64N0Xup0NWn(dataReader, iwFuCyW8HqE3MaLgs2fW(-1767720453 ^ -1767699597)));
								goto IL_01e2;
							case 3:
								goto end_IL_00fc;
							case 4:
								num17 = 0;
								goto IL_01e2;
							case 5:
							{
								needRecompileConfigurationModel = !(WSxfrUWZF64N0Xup0NWn(dataReader, iwFuCyW8HqE3MaLgs2fW(0x4A1640F ^ 0x4A0D5E7)) is DBNull) && QG244LWZB25dUs32Oscj(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488771037)]) != 0;
								int num16 = 2;
								num15 = num16;
								continue;
							}
							case 2:
								goto end_IL_00fc;
								IL_01e2:
								num3 = num17;
								num15 = 5;
								continue;
							}
							goto IL_0183;
							continue;
							end_IL_00fc:
							break;
						}
					}
					finally
					{
						if (dataReader != null)
						{
							int num18 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
							{
								num18 = 1;
							}
							while (true)
							{
								switch (num18)
								{
								case 1:
									Si324IW899daRPSvoG8Z(dataReader);
									num18 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
									{
										num18 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto case 13;
				case 2:
					try
					{
						isFirstStart = true;
						int num13 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num13 = 3;
						}
						while (true)
						{
							switch (num13)
							{
							case 3:
							{
								Table table = new Table();
								YmO9FYW8rrece5TlckWN(table, false);
								yKIaKJW8g7mismHyIbLN(table, iwFuCyW8HqE3MaLgs2fW(-561074844 ^ -561081018));
								table.Columns = new List<Column>
								{
									new Column((string)iwFuCyW8HqE3MaLgs2fW(-629844702 ^ -629872706), DbType.Int32),
									column2,
									column
								};
								table2 = table;
								num13 = 2;
								continue;
							}
							case 2:
								xZVBfWW85iZWwuMsmLIf(Transform, table2);
								num13 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
								{
									num13 = 0;
								}
								continue;
							default:
								Gx7IQPW8MddjeXObG6UK(Transform);
								num13 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
								{
									num13 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					catch
					{
						int num14 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num14 = 0;
						}
						while (true)
						{
							switch (num14)
							{
							case 1:
								throw;
							}
							SwVO9wW8JQNnmdbHuW7w(Transform);
							num14 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
							{
								num14 = 1;
							}
						}
					}
					goto case 13;
				case 35:
				case 38:
					tUDIjeW8yN7x3pP8fhLo(Transform);
					num2 = 30;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 10;
					}
					continue;
				case 8:
					Transform.BeginTransaction();
					num = 2;
					break;
				case 6:
					OldVersion = 0;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 2;
					}
					continue;
				case 32:
					return;
				case 19:
					if (OldVersion > 0)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 16;
				case 16:
					w4C35IWZbnjmbeoQ1j1r(Transform, iwFuCyW8HqE3MaLgs2fW(0x63ABA4E8 ^ 0x63AB9CCA), new string[2]
					{
						(string)iwFuCyW8HqE3MaLgs2fW(-1998538950 ^ -1998518874),
						(string)iwFuCyW8HqE3MaLgs2fW(0xE1229CF ^ 0xE139B47)
					}, new object[2]
					{
						417,
						(short)1
					});
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					num3 = 0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
					continue;
				case 20:
					if (!zOG0gyW8lNYgfxgquTpm(Transform, iwFuCyW8HqE3MaLgs2fW(0x35C0467B ^ 0x35C07E59)))
					{
						num2 = 8;
						continue;
					}
					goto case 9;
				case 9:
					if (!iuabpAW8YFXasruMAaOc(Transform, iwFuCyW8HqE3MaLgs2fW(-787452571 ^ -787458745), lb7TleW8jbo2SYpnhIyM(column2)))
					{
						num2 = 25;
						continue;
					}
					goto case 11;
				case 30:
					try
					{
						CreateSysTableGenerators(transform, OldVersion);
						int num11 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
						{
							num11 = 0;
						}
						while (true)
						{
							switch (num11)
							{
							default:
								Transform.CommitTransaction();
								num11 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
								{
									num11 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					catch
					{
						int num12 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
						{
							num12 = 0;
						}
						while (true)
						{
							switch (num12)
							{
							case 1:
								Transform.RollbackTransaction();
								num12 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
								{
									num12 = 0;
								}
								break;
							default:
								throw;
							}
						}
					}
					goto case 18;
				case 39:
					modelConfigurationStatuses = GetModelConfigurationStatuses();
					num2 = 36;
					continue;
				case 33:
					backupManager.DoBackup(g1joUOWZoDIZZb5rOLkc(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECFE626), OldVersion, 417));
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 19;
					}
					continue;
				case 25:
					tUDIjeW8yN7x3pP8fhLo(Transform);
					num2 = 10;
					continue;
				case 18:
					tUDIjeW8yN7x3pP8fhLo(Transform);
					num2 = 37;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 22;
					}
					continue;
				case 10:
					try
					{
						k9aU2nW8LZC6Kee0lLbp(Transform, iwFuCyW8HqE3MaLgs2fW(-561074844 ^ -561081018), column2);
						int num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
						{
							num9 = 0;
						}
						while (true)
						{
							switch (num9)
							{
							default:
								Transform.CommitTransaction();
								num9 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
								{
									num9 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					catch
					{
						int num10 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num10 = 0;
						}
						while (true)
						{
							switch (num10)
							{
							case 1:
								Transform.RollbackTransaction();
								num10 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
								{
									num10 = 0;
								}
								break;
							default:
								throw;
							}
						}
					}
					goto case 11;
				case 27:
					if (OldVersion != 417)
					{
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 29;
				case 4:
					num3 = 1;
					num2 = 35;
					continue;
				case 23:
					if (OldVersion > 0)
					{
						num2 = 33;
						continue;
					}
					goto case 27;
				case 37:
					try
					{
						yyMLbsWZhKTGHhvIkGY9(transform, OldVersion);
						int num6 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num6 = 2;
						}
						while (true)
						{
							switch (num6)
							{
							case 9:
							{
								cc2AIDWZEXij4MUocEdn(backupManager, transform, OldVersion);
								int num7 = 6;
								num6 = num7;
								continue;
							}
							case 4:
								if (!needRecompileConfigurationModel)
								{
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
									{
										num6 = 2;
									}
									continue;
								}
								goto case 5;
							case 8:
								CreateDbActivatedModule(OldVersion);
								num6 = 11;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
								{
									num6 = 4;
								}
								continue;
							case 5:
								Transform.ExecuteNonQuery((string)ELtx6oW8cdPO0PXgbxSY(iwFuCyW8HqE3MaLgs2fW(-289714582 ^ -289742408), QFlPFDW8sFBO8eZhF0Bo(aMPvkdW8Uc94lb5riaQU(Transform), iwFuCyW8HqE3MaLgs2fW(-218496594 ^ -218482292))));
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
								{
									num6 = 0;
								}
								continue;
							case 6:
								rsdanhWZfgB2SmlV3J2R(transform, OldVersion);
								num6 = 7;
								continue;
							case 2:
								needRecompileConfigurationModel = OldVersion > 0;
								num6 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
								{
									num6 = 5;
								}
								continue;
							case 1:
								Gx7IQPW8MddjeXObG6UK(Transform);
								num6 = 10;
								continue;
							case 3:
								v8QQACWZGmm2hsodlekT(transform, OldVersion);
								num6 = 9;
								continue;
							case 7:
								CreateDbConfigurationInfo(OldVersion);
								num6 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
								{
									num6 = 8;
								}
								continue;
							case 11:
								CreateDbDeactivatingModule(OldVersion);
								num6 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
								{
									num6 = 1;
								}
								continue;
							default:
								Transform.Insert((string)iwFuCyW8HqE3MaLgs2fW(-1858887263 ^ -1858889341), new string[3]
								{
									(string)iwFuCyW8HqE3MaLgs2fW(-2106517564 ^ -2106546856),
									(string)iwFuCyW8HqE3MaLgs2fW(-812025778 ^ -812070202),
									(string)iwFuCyW8HqE3MaLgs2fW(-1858887263 ^ -1858990007)
								}, new object[3]
								{
									417,
									(short)num3,
									(short)(needRecompileConfigurationModel ? 1 : 0)
								});
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
								{
									num6 = 1;
								}
								continue;
							case 10:
								break;
							}
							break;
						}
					}
					catch
					{
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num8 = 0;
						}
						while (true)
						{
							switch (num8)
							{
							case 1:
								throw;
							}
							Transform.RollbackTransaction();
							num8 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
							{
								num8 = 1;
							}
						}
					}
					goto case 29;
				case 12:
					StartUpdating();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 4;
					}
					continue;
				case 31:
					column = new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35950533), DbType.Int16);
					num = 20;
					break;
				default:
					column2 = new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852948340), DbType.Int16);
					num = 31;
					break;
				case 29:
					if (needRecompileConfigurationModel)
					{
						num2 = 32;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 39;
				case 13:
					if (num3 != 0)
					{
						num2 = 3;
						continue;
					}
					if (OldVersion > 417)
					{
						num = 14;
						break;
					}
					if (OldVersion > 0)
					{
						num2 = 34;
						continue;
					}
					goto case 22;
				case 15:
				case 26:
					dataReader = Transform.ExecuteQuery((string)ELtx6oW8cdPO0PXgbxSY(iwFuCyW8HqE3MaLgs2fW(0x4A1640F ^ 0x4A0D6A9), QFlPFDW8sFBO8eZhF0Bo(aMPvkdW8Uc94lb5riaQU(Transform), iwFuCyW8HqE3MaLgs2fW(0xE1229CF ^ 0xE1211ED))));
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 21;
					}
					continue;
				case 3:
					throw new InvalidOperationException(SR.T((string)iwFuCyW8HqE3MaLgs2fW(-1123633026 ^ -1123611976)));
				case 1:
					num3 = 0;
					num = 38;
					break;
				case 11:
					if (iuabpAW8YFXasruMAaOc(Transform, iwFuCyW8HqE3MaLgs2fW(0x6A81B9B4 ^ 0x6A818196), lb7TleW8jbo2SYpnhIyM(column)))
					{
						num2 = 15;
						continue;
					}
					goto case 24;
				case 14:
					throw new InvalidOperationException((string)xXdaXXWZW9Tj0HapouU1(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F31CB5E)));
				case 28:
					throw new InvalidOperationException((string)xXdaXXWZW9Tj0HapouU1(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E3CFE0)));
				case 22:
					if (OldVersion != 417)
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
						{
							num2 = 23;
						}
						continue;
					}
					goto case 27;
				case 34:
					if (OldVersion >= 17)
					{
						num2 = 22;
						continue;
					}
					goto case 28;
				case 17:
					return;
				case 7:
					try
					{
						k9aU2nW8LZC6Kee0lLbp(Transform, iwFuCyW8HqE3MaLgs2fW(0x53CB464B ^ 0x53CB7E69), column);
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								Gx7IQPW8MddjeXObG6UK(Transform);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					catch
					{
						int num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								SwVO9wW8JQNnmdbHuW7w(Transform);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
								{
									num5 = 0;
								}
								break;
							default:
								throw;
							}
						}
					}
					goto case 15;
				case 36:
					needRecompileConfigurationModel = !modelConfigurationStatuses.Contains(AssemblyModelsMetadataStatus.Published) || (isFirstServerInCluster && modelConfigurationStatuses.Contains(AssemblyModelsMetadataStatus.Prepared));
					num2 = 17;
					continue;
				}
				break;
			}
		}
	}

	public void SaveAssemblyModelsMetadata(AssemblyModelsMetadata asmModelsMetadata)
	{
		int num = 1;
		int num2 = num;
		string[] columns = default(string[]);
		object[] values = default(object[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (UWL7EqWZZKeONMDQ1dbs(asmModelsMetadata) <= 0)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 2;
					}
				}
				else
				{
					Transform.Update((string)iwFuCyW8HqE3MaLgs2fW(-1998538950 ^ -1998518304), columns, values, (string)zTE5i8WZuEquVqesUmMQ(((Dialect)aMPvkdW8Uc94lb5riaQU(Transform)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7FB34C)), iwFuCyW8HqE3MaLgs2fW(-3333094 ^ -3332080), asmModelsMetadata.Id));
					num2 = 5;
				}
				break;
			case 5:
				return;
			default:
				values = new object[6]
				{
					rhX1xaWZQXqD7lpfGYLU(asmModelsMetadata),
					(int)kUBdHNWZC5143WbtYD4a(asmModelsMetadata),
					new ParameterValue(DbType.Binary, asmModelsMetadata.AssemblyRawStream),
					new ParameterValue(DbType.Binary, TFWIF3WZvJsyHByalrUD(asmModelsMetadata)),
					new ParameterValue(DbType.Binary, asmModelsMetadata.MetadataStream),
					new ParameterValue(DbType.Binary, FI047GWZ8EMweiSiSZbV(asmModelsMetadata))
				};
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				columns = new string[6]
				{
					(string)iwFuCyW8HqE3MaLgs2fW(0x53CB464B ^ 0x53CAF61B),
					(string)iwFuCyW8HqE3MaLgs2fW(-1334993905 ^ -1335026295),
					(string)iwFuCyW8HqE3MaLgs2fW(-1751176224 ^ -1751213344),
					(string)iwFuCyW8HqE3MaLgs2fW(0x61EC0CB8 ^ 0x61EDBD96),
					(string)iwFuCyW8HqE3MaLgs2fW(0x7247028A ^ 0x7247B448),
					(string)iwFuCyW8HqE3MaLgs2fW(-1858887263 ^ -1858989893)
				};
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				Transform.Insert(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4DCBF3), columns, values, isNeedInsertId: true);
				num2 = 3;
				break;
			case 3:
				return;
			}
		}
	}

	public void DeletePreparedModelConfiguration()
	{
		int num = 2;
		int num2 = num;
		string sql = default(string);
		Dictionary<string, object> paramValues = default(Dictionary<string, object>);
		while (true)
		{
			switch (num2)
			{
			default:
				Transform.ExecuteNonQuery(sql, paramValues);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				return;
			case 2:
				sql = (string)e3GYhMWZVROXjnXmtF0G(iwFuCyW8HqE3MaLgs2fW(0x3A5D5EF ^ 0x3A46043), new object[4]
				{
					QFlPFDW8sFBO8eZhF0Bo(aMPvkdW8Uc94lb5riaQU(Transform), iwFuCyW8HqE3MaLgs2fW(0x3CE17B75 ^ 0x3CE0CBAF)),
					FoEeTYWZIjAGsxhSUhuV(Transform),
					QFlPFDW8sFBO8eZhF0Bo(aMPvkdW8Uc94lb5riaQU(Transform), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107933618)),
					QFlPFDW8sFBO8eZhF0Bo(aMPvkdW8Uc94lb5riaQU(Transform), iwFuCyW8HqE3MaLgs2fW(0x63ABA4E8 ^ 0x63AB256E))
				});
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				paramValues = new Dictionary<string, object>
				{
					{
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345440876),
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939375896)
					},
					{
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -137985927),
						2
					}
				};
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void CheckStructuresCreated()
	{
		//Discarded unreachable code: IL_0089, IL_0098, IL_00a7
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (!forLicenseCheck)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 3:
				return;
			case 0:
				return;
			case 1:
				if (!structuresCreated)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 6;
					}
					break;
				}
				return;
			case 4:
				YM9A7lWZSys0QpCuZDKE(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 3;
				}
				break;
			case 5:
				return;
			case 6:
				structuresCreated = true;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private void CreateSysTableGenerators(ITransformationProvider transformationProvider, int version)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				if (version != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 3:
				return;
			}
			XuEbntWZiWaPObecWaHU(transformationProvider);
			num2 = 3;
		}
	}

	private void CreateDbConfigurationInfo(int version)
	{
		//Discarded unreachable code: IL_00dd
		int num = 6;
		int num2 = num;
		Table table = default(Table);
		while (true)
		{
			switch (num2)
			{
			case 3:
			{
				Table table2 = new Table();
				yKIaKJW8g7mismHyIbLN(table2, iwFuCyW8HqE3MaLgs2fW(-882126494 ^ -882219196));
				table2.Columns = new List<Column>
				{
					new Column((string)iwFuCyW8HqE3MaLgs2fW(-538519530 ^ -538551992), DbType.Int32),
					new Column((string)iwFuCyW8HqE3MaLgs2fW(0x638095EB ^ 0x6380FA79), DbType.Guid),
					new Column((string)iwFuCyW8HqE3MaLgs2fW(0x1DE3DD89 ^ 0x1DE26BDD), DbType.String)
				};
				table = table2;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 2:
				return;
			case 1:
				return;
			case 6:
				if (version != 0)
				{
					return;
				}
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
			{
				ITransformationProvider transformationProvider = transform;
				Index index = new Index();
				YUHSZBWZR5sl2SlTlhuY(index, iwFuCyW8HqE3MaLgs2fW(0x53FA00CE ^ 0x53FBB6E8));
				PcwPwJWZqqG5tcBrl3WI(index, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812069318));
				index.Columns.Add((string)iwFuCyW8HqE3MaLgs2fW(0x1DE3DD89 ^ 0x1DE35CD7));
				s698xMWZKTkCnCqT9U1y(transformationProvider, index);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 1;
				}
				break;
			}
			case 5:
				if (zOG0gyW8lNYgfxgquTpm(transform, iwFuCyW8HqE3MaLgs2fW(-1638402543 ^ -1638514633)))
				{
					num2 = 2;
					break;
				}
				goto case 3;
			default:
				xZVBfWW85iZWwuMsmLIf(transform, table);
				num2 = 4;
				break;
			}
		}
	}

	private void CreateDbActivatedModule(int version)
	{
		//Discarded unreachable code: IL_0065, IL_0074
		int num = 3;
		Table table2 = default(Table);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (version != 0)
					{
						num2 = 2;
						continue;
					}
					goto case 1;
				case 2:
					return;
				case 5:
					return;
				case 1:
					if (zOG0gyW8lNYgfxgquTpm(transform, iwFuCyW8HqE3MaLgs2fW(-606654180 ^ -606698702)))
					{
						return;
					}
					num2 = 4;
					continue;
				case 4:
				{
					Table table = new Table();
					yKIaKJW8g7mismHyIbLN(table, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x4265802D));
					table.Columns = new List<Column>
					{
						new Column((string)iwFuCyW8HqE3MaLgs2fW(-35995181 ^ -35949627), new ColumnType(DbType.String, 255))
					};
					table2 = table;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				}
				break;
			}
			xZVBfWW85iZWwuMsmLIf(transform, table2);
			num = 5;
		}
	}

	private void CreateDbDeactivatingModule(int version)
	{
		int num = 2;
		int num2 = num;
		Table table2 = default(Table);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (version == 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 4:
				return;
			default:
				xZVBfWW85iZWwuMsmLIf(transform, table2);
				num2 = 4;
				break;
			case 1:
				if (transform.TableExists((string)iwFuCyW8HqE3MaLgs2fW(0x57A5235E ^ 0x57A49106)))
				{
					return;
				}
				num2 = 3;
				break;
			case 3:
			{
				Table table = new Table();
				yKIaKJW8g7mismHyIbLN(table, iwFuCyW8HqE3MaLgs2fW(-218496594 ^ -218385418));
				table.Columns = new List<Column>
				{
					new Column((string)iwFuCyW8HqE3MaLgs2fW(-2107978722 ^ -2107933176), new ColumnType(DbType.String, 255))
				};
				table2 = table;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	private void ReadOrCreateConfigurationInfo()
	{
		//Discarded unreachable code: IL_01be, IL_021a, IL_0273, IL_02e0, IL_0317, IL_03cb, IL_03ef, IL_056f, IL_05c7, IL_0665, IL_069d, IL_06ac
		int num = 5;
		string text = default(string);
		IDataReader dataReader = default(IDataReader);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					TZ.InitializeServerTimeZone(text);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 7;
					}
					continue;
				default:
					transform.BeginTransaction();
					num = 8;
					break;
				case 1:
					configurationUid = ja1Lc8WZnaeLYpce1jo6();
					num2 = 6;
					continue;
				case 4:
					return;
				case 8:
					try
					{
						transform.Insert((string)iwFuCyW8HqE3MaLgs2fW(--1360331293 ^ 0x5114B43B), new string[3]
						{
							z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195581877),
							z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A6198D),
							(string)iwFuCyW8HqE3MaLgs2fW(-1108654032 ^ -1108672924)
						}, new object[3] { 1, configurationUid, text });
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num7 = 0;
						}
						while (true)
						{
							switch (num7)
							{
							default:
								Gx7IQPW8MddjeXObG6UK(transform);
								num7 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
								{
									num7 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					catch (Exception innerException2)
					{
						int num8 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num8 = 1;
						}
						while (true)
						{
							switch (num8)
							{
							case 1:
								SwVO9wW8JQNnmdbHuW7w(transform);
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
								{
									num8 = 0;
								}
								break;
							default:
								throw new InitializationException((string)xXdaXXWZW9Tj0HapouU1(iwFuCyW8HqE3MaLgs2fW(--1418440330 ^ 0x548A19B0)), innerException2);
							}
						}
					}
					goto case 2;
				case 5:
					if (!forLicenseCheck)
					{
						dataReader = transform.ExecuteQuery((string)UQi4wIWZXEYxs9U4uOhm(iwFuCyW8HqE3MaLgs2fW(0x3A5D5EF ^ 0x3A46375), ((Dialect)aMPvkdW8Uc94lb5riaQU(transform)).QuoteIfNeeded((string)iwFuCyW8HqE3MaLgs2fW(-234299632 ^ -234264266)), QFlPFDW8sFBO8eZhF0Bo(aMPvkdW8Uc94lb5riaQU(transform), iwFuCyW8HqE3MaLgs2fW(0xA592A41 ^ 0xA59AB1F))));
						num = 3;
						break;
					}
					num2 = 4;
					continue;
				case 6:
					text = (string)jUgqMGWZODJkOJFG2kSe(transform);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					try
					{
						if (uIf3x6W8zmoPMZGFkXfa(dataReader))
						{
							int num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
							{
								num3 = 2;
							}
							while (true)
							{
								switch (num3)
								{
								case 1:
									return;
								case 8:
									if (transform.ColumnExists((string)iwFuCyW8HqE3MaLgs2fW(0x76DD48E ^ 0x76C62A8), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x830C266)))
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 3;
								case 6:
								case 7:
									QIVAl3WZkW2faECCmEoY(text);
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
									{
										num3 = 1;
									}
									continue;
								default:
									text = (string)WSxfrUWZF64N0Xup0NWn(dataReader, iwFuCyW8HqE3MaLgs2fW(-234299632 ^ -234264252));
									num3 = 6;
									continue;
								case 5:
									try
									{
										tUDIjeW8yN7x3pP8fhLo(transform);
										int num4 = 5;
										while (true)
										{
											switch (num4)
											{
											case 3:
												transform.Update((string)iwFuCyW8HqE3MaLgs2fW(0x1C9495B4 ^ 0x1C952392), new string[1] { (string)iwFuCyW8HqE3MaLgs2fW(-281842504 ^ -281879828) }, new object[1] { text }, (string)zkQpAUWZTdEjpSf5hKxs(iwFuCyW8HqE3MaLgs2fW(-281842504 ^ -281879968), QFlPFDW8sFBO8eZhF0Bo(aMPvkdW8Uc94lb5riaQU(transform), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FA8190))));
												num4 = 4;
												continue;
											case 5:
												transform.AddColumn(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE139FE9), new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC30719), DbType.String));
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
												{
													num4 = 0;
												}
												continue;
											case 4:
												transform.CommitTransaction();
												num4 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
												{
													num4 = 1;
												}
												continue;
											default:
												Gx7IQPW8MddjeXObG6UK(transform);
												num4 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
												{
													num4 = 0;
												}
												continue;
											case 2:
												tUDIjeW8yN7x3pP8fhLo(transform);
												num4 = 3;
												continue;
											case 1:
												break;
											}
											break;
										}
									}
									catch (Exception innerException)
									{
										int num5 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
										{
											num5 = 1;
										}
										while (true)
										{
											switch (num5)
											{
											case 1:
												SwVO9wW8JQNnmdbHuW7w(transform);
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
												{
													num5 = 0;
												}
												break;
											default:
												throw new InitializationException(SR.T((string)iwFuCyW8HqE3MaLgs2fW(0x26FFCB59 ^ 0x26FE7DBF)), innerException);
											}
										}
									}
									goto case 6;
								case 3:
									text = TZ.GetServerTimeZoneForSystemConfig(transform);
									num3 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
									{
										num3 = 4;
									}
									continue;
								case 2:
									configurationUid = ((Dialect)aMPvkdW8Uc94lb5riaQU(transform)).GetGuid(dataReader[(string)iwFuCyW8HqE3MaLgs2fW(0xE1229CF ^ 0xE12465D)]);
									num3 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
									{
										num3 = 8;
									}
									continue;
								case 4:
									break;
								}
								break;
							}
						}
					}
					finally
					{
						if (dataReader != null)
						{
							int num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								case 1:
									Si324IW899daRPSvoG8Z(dataReader);
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
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
					goto case 1;
				case 7:
					return;
				}
				break;
			}
		}
	}

	internal IEnumerable<IMetadataItem> LoadMetadataItems()
	{
		if (!Transform.TableExists(EntityMetadataHelper<IMetadataItemHeader>.TableName))
		{
			return Enumerable.Empty<IMetadataItem>();
		}
		List<IMetadataItem> list = new List<IMetadataItem>();
		ITransformationProvider transformationProvider = Transform;
		string table = Transform.Dialect.QuoteIfNeeded(EntityMetadataHelper<IMetadataItem>.TableName);
		Dialect dialect = Transform.Dialect;
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606616436));
		bool flag = transformationProvider.ColumnExists(table, dialect.QuoteIfNeeded(EntityMetadataHelper<IMetadataItem>.GetPropertyFieldName(Expression.Lambda<Func<IMetadataItem, ScriptModule>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }))));
		string text = Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107933818));
		string text2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281840004);
		Dialect dialect2 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(IMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x6380607B));
		string text3 = text + text2 + dialect2.QuoteIfNeeded(EntityMetadataHelper<IMetadataItem>.GetPropertyFieldName(Expression.Lambda<Func<IMetadataItem, long>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)), new ParameterExpression[1] { parameterExpression })));
		string text4 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x34184491);
		Dialect dialect3 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(IMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541776359));
		string text5 = text + text4 + dialect3.QuoteIfNeeded(EntityMetadataHelper<IMetadataItem>.GetPropertyFieldName(Expression.Lambda<Func<IMetadataItem, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		Dialect dialect4 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A1919F));
		string text6 = dialect4.QuoteIfNeeded(EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, long>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(Entity<long>).TypeHandle)), new ParameterExpression[1] { parameterExpression })));
		Dialect dialect5 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C53CD6F));
		string text7 = dialect5.QuoteIfNeeded(EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, Guid>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		Dialect dialect6 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31329496));
		string text8 = dialect6.QuoteIfNeeded(EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, string>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		Dialect dialect7 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870887001));
		string text9 = dialect7.QuoteIfNeeded(EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, byte[]>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		Dialect dialect8 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195568507));
		string text10 = dialect8.QuoteIfNeeded(EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, string>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		Dialect dialect9 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1CEB74));
		string text11 = dialect9.QuoteIfNeeded(EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, RootCodeItemCollection>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		Dialect dialect10 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A50F57));
		string text12 = dialect10.QuoteIfNeeded(EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, string>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		Dialect dialect11 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146531661));
		string text13 = dialect11.QuoteIfNeeded(EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, byte[]>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		Dialect dialect12 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A5D6CE));
		string text14 = dialect12.QuoteIfNeeded(EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, string>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		Dialect dialect13 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583781020));
		string text15 = dialect13.QuoteIfNeeded(EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, Guid>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		Dialect dialect14 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882170638));
		string text16 = dialect14.QuoteIfNeeded(EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, string>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		Dialect dialect15 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978522270));
		string text17 = dialect15.QuoteIfNeeded(EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, Guid>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		Dialect dialect16 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63AB5178));
		string text18 = dialect16.QuoteIfNeeded(EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, string>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		Dialect dialect17 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951452554));
		string text19 = dialect17.QuoteIfNeeded(EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, string>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		Dialect dialect18 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571E5609));
		string text20 = dialect18.QuoteIfNeeded(EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, List<AssemblyReference>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		Dialect dialect19 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979190879));
		string text21 = dialect19.QuoteIfNeeded(EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, List<AssemblyReference>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		Dialect dialect20 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289686534));
		string text22 = dialect20.QuoteIfNeeded(EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, List<ScriptWebReference>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		Dialect dialect21 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x3418ABC5));
		string text23 = dialect21.QuoteIfNeeded(EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, string>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		Dialect dialect22 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548B5B1A));
		string text24 = dialect22.QuoteIfNeeded(EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, string>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		string text25 = Transform.Dialect.QuoteIfNeeded(EntityMetadataHelper<IMetadataItem>.TableName);
		Dialect dialect23 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(IMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335006817));
		string text26 = dialect23.QuoteIfNeeded(EntityMetadataHelper<IMetadataItem>.GetPropertyFieldName(Expression.Lambda<Func<IMetadataItem, ScriptModule>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		Dialect dialect24 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(IMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521213488));
		string text27 = dialect24.QuoteIfNeeded(EntityMetadataHelper<IMetadataItem>.GetPropertyFieldName(Expression.Lambda<Func<IMetadataItem, ScriptModule>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		string text28 = Transform.Dialect.QuoteIfNeeded(EntityMetadataHelper<IMetadataItemHeader>.TableName);
		Dialect dialect25 = Transform.Dialect;
		parameterExpression = Expression.Parameter(typeof(IMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583781020));
		string text29 = dialect25.QuoteIfNeeded(EntityMetadataHelper<IMetadataItemHeader>.GetPropertyFieldName(Expression.Lambda<Func<IMetadataItemHeader, IMetadataItem>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		string text30 = Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210688905));
		string text31 = Transform.Dialect.QuoteIfNeeded(EntityMetadataHelper<ScriptModule>.TableName);
		string text32 = Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463BB8E0));
		string text33 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDD0DCA);
		string text34 = Transform.Dialect.QuoteIfNeeded(text33 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979218577));
		string text35 = Transform.Dialect.QuoteIfNeeded(text33 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112693500));
		string text36 = Transform.Dialect.QuoteIfNeeded(text33 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -98000890));
		string text37 = Transform.Dialect.QuoteIfNeeded(text33 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767700229));
		string text38 = Transform.Dialect.QuoteIfNeeded(text33 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583698186));
		string text39 = Transform.Dialect.QuoteIfNeeded(text33 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CAFE53));
		string text40 = Transform.Dialect.QuoteIfNeeded(text33 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637F91B5));
		string text41 = Transform.Dialect.QuoteIfNeeded(text33 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A324F2C));
		string text42 = Transform.Dialect.QuoteIfNeeded(text33 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398634166));
		string text43 = Transform.Dialect.QuoteIfNeeded(text33 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606697138));
		string text44 = Transform.Dialect.QuoteIfNeeded(text33 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281875724));
		string text45 = Transform.Dialect.QuoteIfNeeded(text33 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3367830));
		string text46 = Transform.Dialect.QuoteIfNeeded(text33 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269FE74C));
		string text47 = Transform.Dialect.QuoteIfNeeded(text33 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740364982));
		string text48 = Transform.Dialect.QuoteIfNeeded(text33 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822859610));
		string text49 = Transform.Dialect.QuoteIfNeeded(text33 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AD5B9D));
		string text50 = Transform.Dialect.QuoteIfNeeded(text33 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE1390C5));
		string text51 = Transform.Dialect.QuoteIfNeeded(text33 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541824345));
		string text52 = Transform.Dialect.QuoteIfNeeded(text33 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A608CF8));
		string text53 = Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x830CD56));
		string text54 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867155943);
		string text55 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C528167) + text3 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97969068) + text5 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317689986) + text32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411202199) + text6 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571EEABB) + text34 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463A033E) + text32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E4041F) + text7 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1EAA3A) + text35 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1C12E6) + text32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A17ECB) + text8 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643772197) + text36 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751177246) + text32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35988713) + text9 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088322822) + text37 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E5A775) + text32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A81A370) + text10 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3630BA43) + text38 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A52F5C) + text32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E2614E) + text11 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A617C9C) + text39 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A5F6C5) + text32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571EB95D) + text12 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858869117) + text40 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97998344) + text32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345417984) + text13 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542707521) + text41 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939374450) + text32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767726273) + text14 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E232A8) + text42 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x638099E9) + text32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B36B1CD) + text15 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x72474BA8) + text43 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x3133D8A8) + text32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1C0420) + text16 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541746517) + text44 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F3074B4) + text32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951512286) + text17 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459576317) + text45 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2ACEF7F) + text32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411202199) + text18 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108672238) + text46 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751215538) + text32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A778D73) + text19 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16771131) + text47 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812026804) + text32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B36B1CD) + text20 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B36E22B) + text48 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE17777) + text32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FA1A0A) + text21 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16771131) + text49 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459531121) + text32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x12440660) + text23 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3314376) + text50 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629843680) + text32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x1637DEED) + text24 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822904518) + text51 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63ABA8EA) + text32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6E40CF) + text22 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576131450) + text52;
		if (flag)
		{
			string text56 = Transform.Dialect.QuoteIfNeeded(text54 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C9414EA));
			string text57 = Transform.Dialect.QuoteIfNeeded(text54 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x12447336));
			string text58 = Transform.Dialect.QuoteIfNeeded(text54 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217420951));
			string text59 = Transform.Dialect.QuoteIfNeeded(text54 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195651563));
			string text60 = Transform.Dialect.QuoteIfNeeded(text54 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A49B5C));
			string text61 = Transform.Dialect.QuoteIfNeeded(text54 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x42658A1B));
			string text62 = Transform.Dialect.QuoteIfNeeded(text54 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECFEB24));
			string text63 = Transform.Dialect.QuoteIfNeeded(text54 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EDA425));
			string text64 = Transform.Dialect.QuoteIfNeeded(text54 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488771107));
			string text65 = Transform.Dialect.QuoteIfNeeded(text54 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A65B18));
			string text66 = Transform.Dialect.QuoteIfNeeded(text54 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463B8970));
			string text67 = Transform.Dialect.QuoteIfNeeded(text54 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17AC74A8));
			string text68 = Transform.Dialect.QuoteIfNeeded(text54 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x3419E6D3));
			string text69 = Transform.Dialect.QuoteIfNeeded(text54 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x36314BFF));
			string text70 = Transform.Dialect.QuoteIfNeeded(text54 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643751609));
			string text71 = Transform.Dialect.QuoteIfNeeded(text54 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A0DCEF));
			string text72 = Transform.Dialect.QuoteIfNeeded(text54 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103E507F));
			string text73 = Transform.Dialect.QuoteIfNeeded(text54 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978439204));
			string text74 = Transform.Dialect.QuoteIfNeeded(text54 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A762EF1));
			text55 = text55 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426178409) + text53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822884644) + text6 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629859328) + text56 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426093253) + text53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852839744) + text7 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A617C9C) + text57 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD55C52) + text53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629846042) + text8 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFEB148) + text58 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138955782) + text53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939380152) + text9 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108672238) + text59 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CAFFE5) + text53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFEE2AE) + text10 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858869117) + text60 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767721479) + text53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A81A370) + text11 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088322822) + text61 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A67A1D) + text53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x511518D9) + text12 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76D9DAC) + text62 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1F5AB6) + text53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x63808F2F) + text13 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998520808) + text63 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882123424) + text53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978480074) + text14 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317775886) + text64 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x2026164D) + text53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECE49CE) + text15 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE1260ED) + text65 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561048374) + text53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA593085) + text16 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939391570) + text66 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD55C52) + text53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C05CBF) + text17 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A77DE95) + text67 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281845574) + text53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637E335F) + text18 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675491683) + text68 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088392586) + text53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BBAFFA) + text19 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571EEABB) + text69 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70041054) + text53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463A15F8) + text20 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099765643) + text70 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957821374) + text53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138961604) + text21 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281860710) + text71 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE0C2DB) + text53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852839744) + text23 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309653858) + text72 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A33F234) + text53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6E40CF) + text24 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC10E92) + text73 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE17777) + text53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767726273) + text22 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269E16E8) + text74;
		}
		text55 = text55 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108676216) + text25 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307ED6F3) + text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876150939) + text28 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751162174) + text30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE26461) + text3 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521160484) + text30 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFEE2AE) + text29 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA4F9C8) + text31 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A63F3D) + text32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A0DDE7) + text32 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63ABBE2C) + text6 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234259572) + text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16759773) + text26;
		if (flag)
		{
			text55 = text55 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951537646) + text31 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538537676) + text53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A7CFF7) + text53 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E4041F) + text6 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A7D283) + text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979244811) + text27;
		}
		using IDataReader dataReader = Transform.ExecuteQuery(text55);
		ScriptModuleReader scriptModuleReader = new ScriptModuleReader();
		while (dataReader.Read())
		{
			list.Add(new MetadataItem
			{
				Id = Convert.ToInt64(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541764905)]),
				Metadata = (AbstractMetadata)xmlObjSerType.NullSafeGet((DbDataReader)dataReader, new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812003700) }, null, null),
				ScriptModule = scriptModuleReader.Read(this, dataReader, text33),
				ClientScriptModule = (flag ? scriptModuleReader.Read(this, dataReader, text54) : null)
			});
		}
		return list;
	}

	private ScriptModule LoadScriptModule(Guid uid)
	{
		//Discarded unreachable code: IL_003f, IL_0080, IL_008f, IL_009f, IL_00ae, IL_00df, IL_0117, IL_0126
		int num = 2;
		int num2 = num;
		IDataReader dataReader = default(IDataReader);
		ScriptModule result = default(ScriptModule);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					int num3;
					if (!uIf3x6W8zmoPMZGFkXfa(dataReader))
					{
						num3 = 2;
						goto IL_0043;
					}
					goto IL_005d;
					IL_0043:
					switch (num3)
					{
					default:
						goto end_IL_0029;
					case 1:
						break;
					case 2:
						goto end_IL_0029;
					case 0:
						goto end_IL_0029;
					case 3:
						return result;
					}
					goto IL_005d;
					IL_005d:
					result = new ScriptModuleReader().Read(this, dataReader, "");
					num3 = 3;
					goto IL_0043;
					end_IL_0029:;
				}
				finally
				{
					if (dataReader != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								Si324IW899daRPSvoG8Z(dataReader);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
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
				break;
			case 2:
			{
				ITransformationProvider transformationProvider = Transform;
				object obj = iwFuCyW8HqE3MaLgs2fW(0x463A0F3C ^ 0x463BB52C);
				string text = Transform.Dialect.QuoteIfNeeded((string)kTEZDSWZ2bwmnxO02GtY());
				object obj2 = aMPvkdW8Uc94lb5riaQU(Transform);
				ParameterExpression parameterExpression = Expression.Parameter(fITe1pWZePWSDAED0soO(typeof(ScriptModule).TypeHandle), (string)iwFuCyW8HqE3MaLgs2fW(-1767720453 ^ -1767701603));
				dataReader = transformationProvider.ExecuteQuery((string)pRMkoQWZNJAStYb6enLt(obj, text, QFlPFDW8sFBO8eZhF0Bo(obj2, EntityMetadataHelper<ScriptModule>.GetPropertyFieldName(Expression.Lambda<Func<ScriptModule, Guid>>((Expression)yLHMOMWZ12SJng4p64K4(parameterExpression, (MethodInfo)x52yJyWZPmfocl51QgDM((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }))), Transform.ParameterSeparator), new Dictionary<string, object> { 
				{
					(string)iwFuCyW8HqE3MaLgs2fW(0x3B36AB09 ^ 0x3B371165),
					uid
				} });
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 1;
				}
				continue;
			}
			}
			break;
		}
		return null;
	}

	private IList<AssemblyModelsMetadataStatus> GetModelConfigurationStatuses()
	{
		string sql = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281881032), Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957779302)), Transform.ParameterSeparator, Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281879320)), Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289681428)), Transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475890265)));
		Dictionary<string, object> paramValues = new Dictionary<string, object> { 
		{
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542701107),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867824088)
		} };
		List<AssemblyModelsMetadataStatus> list = new List<AssemblyModelsMetadataStatus>();
		using IDataReader dataReader = Transform.ExecuteQuery(sql, paramValues);
		while (dataReader.Read())
		{
			list.Add((AssemblyModelsMetadataStatus)Convert.ToInt32(dataReader[0]));
		}
		return list;
	}

	internal static void aevHXWW86ph861HmEOTP()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object iwFuCyW8HqE3MaLgs2fW(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void ImkeT9W8ASqT0oqM4uyb(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool JnpU1cW8wtQh2tAvPJCV()
	{
		return jGk8IWW8tPAq0EJH7CW6 == null;
	}

	internal static DbPreUpdater qLierEW847pTg1T0m5LI()
	{
		return jGk8IWW8tPAq0EJH7CW6;
	}

	internal static object jrUOQhW87XvhKq8xiWcO(object P_0)
	{
		return ApplicationStartCache.Load((ITransformationProvider)P_0);
	}

	internal static object suPfR4W8xUyaN4MydJQh(object P_0)
	{
		return SR.M((string)P_0);
	}

	internal static object Ty81mOW805BRhFyFA4Ci(double completePercent, object P_1)
	{
		return StartInformation.Operation(completePercent, (string)P_1);
	}

	internal static object g96rFSW8mhCWlGtakJ60(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).AssemblyRawStream;
	}

	internal static void tUDIjeW8yN7x3pP8fhLo(object P_0)
	{
		((ITransformationProvider)P_0).BeginTransaction();
	}

	internal static void Gx7IQPW8MddjeXObG6UK(object P_0)
	{
		((ITransformationProviderBase)P_0).CommitTransaction();
	}

	internal static void SwVO9wW8JQNnmdbHuW7w(object P_0)
	{
		((ITransformationProvider)P_0).RollbackTransaction();
	}

	internal static void Si324IW899daRPSvoG8Z(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void noyWtOW8d6ojcnfZSGx2(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool zOG0gyW8lNYgfxgquTpm(object P_0, object P_1)
	{
		return ((ITransformationProvider)P_0).TableExists((string)P_1);
	}

	internal static void YmO9FYW8rrece5TlckWN(object P_0, bool value)
	{
		((Table)P_0).Sequence = value;
	}

	internal static void yKIaKJW8g7mismHyIbLN(object P_0, object P_1)
	{
		((Table)P_0).Name = (string)P_1;
	}

	internal static void xZVBfWW85iZWwuMsmLIf(object P_0, object P_1)
	{
		((ITransformationProvider)P_0).AddTable((Table)P_1);
	}

	internal static object lb7TleW8jbo2SYpnhIyM(object P_0)
	{
		return ((Column)P_0).Name;
	}

	internal static bool iuabpAW8YFXasruMAaOc(object P_0, object P_1, object P_2)
	{
		return ((ITransformationProvider)P_0).ColumnExists((string)P_1, (string)P_2);
	}

	internal static void k9aU2nW8LZC6Kee0lLbp(object P_0, object P_1, object P_2)
	{
		((ITransformationProvider)P_0).AddColumn((string)P_1, (Column)P_2);
	}

	internal static object aMPvkdW8Uc94lb5riaQU(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object QFlPFDW8sFBO8eZhF0Bo(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object ELtx6oW8cdPO0PXgbxSY(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool uIf3x6W8zmoPMZGFkXfa(object P_0)
	{
		return ((IDataReader)P_0).Read();
	}

	internal static object WSxfrUWZF64N0Xup0NWn(object P_0, object P_1)
	{
		return ((IDataRecord)P_0)[(string)P_1];
	}

	internal static short QG244LWZB25dUs32Oscj(object P_0)
	{
		return Convert.ToInt16(P_0);
	}

	internal static object xXdaXXWZW9Tj0HapouU1(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static BackupParameters g1joUOWZoDIZZb5rOLkc()
	{
		return BackupParameters.OnlyMainDatabase;
	}

	internal static int w4C35IWZbnjmbeoQ1j1r(object P_0, object P_1, object P_2, object P_3)
	{
		return ((ITransformationProvider)P_0).Insert((string)P_1, (string[])P_2, (object[])P_3);
	}

	internal static void yyMLbsWZhKTGHhvIkGY9(object P_0, int version)
	{
		DbMetadata.CreateStructures((ITransformationProvider)P_0, version);
	}

	internal static void v8QQACWZGmm2hsodlekT(object P_0, int version)
	{
		ApplicationStartCache.CreateDbStructures((ITransformationProvider)P_0, version);
	}

	internal static void cc2AIDWZEXij4MUocEdn(object P_0, object P_1, int version)
	{
		((BackupManager)P_0).CreateDbStructures((ITransformationProvider)P_1, version);
	}

	internal static void rsdanhWZfgB2SmlV3J2R(object P_0, int version)
	{
		ModuleManager.CreateDbStructures((ITransformationProvider)P_0, version);
	}

	internal static object rhX1xaWZQXqD7lpfGYLU(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).Name;
	}

	internal static AssemblyModelsMetadataStatus kUBdHNWZC5143WbtYD4a(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).Status;
	}

	internal static object TFWIF3WZvJsyHByalrUD(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).DocumentationRawStream;
	}

	internal static object FI047GWZ8EMweiSiSZbV(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).DebugRawStream;
	}

	internal static long UWL7EqWZZKeONMDQ1dbs(object P_0)
	{
		return ((AssemblyModelsMetadata)P_0).Id;
	}

	internal static object zTE5i8WZuEquVqesUmMQ(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}

	internal static object FoEeTYWZIjAGsxhSUhuV(object P_0)
	{
		return ((ITransformationProvider)P_0).ParameterSeparator;
	}

	internal static object e3GYhMWZVROXjnXmtF0G(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static void YM9A7lWZSys0QpCuZDKE(object P_0)
	{
		((DbPreUpdater)P_0).CreateStructures();
	}

	internal static void XuEbntWZiWaPObecWaHU(object P_0)
	{
		((ITransformationProvider)P_0).InitTableGenerators();
	}

	internal static void YUHSZBWZR5sl2SlTlhuY(object P_0, object P_1)
	{
		((Index)P_0).TableName = (string)P_1;
	}

	internal static void PcwPwJWZqqG5tcBrl3WI(object P_0, object P_1)
	{
		((Index)P_0).Name = (string)P_1;
	}

	internal static void s698xMWZKTkCnCqT9U1y(object P_0, object P_1)
	{
		((ITransformationProvider)P_0).AddUniqueIndex((Index)P_1);
	}

	internal static object UQi4wIWZXEYxs9U4uOhm(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object zkQpAUWZTdEjpSf5hKxs(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void QIVAl3WZkW2faECCmEoY(object P_0)
	{
		TZ.InitializeServerTimeZone((string)P_0);
	}

	internal static Guid ja1Lc8WZnaeLYpce1jo6()
	{
		return Guid.NewGuid();
	}

	internal static object jUgqMGWZODJkOJFG2kSe(object P_0)
	{
		return TZ.GetServerTimeZoneForSystemConfig((ITransformationProvider)P_0);
	}

	internal static object kTEZDSWZ2bwmnxO02GtY()
	{
		return EntityMetadataHelper<ScriptModule>.TableName;
	}

	internal static Type fITe1pWZePWSDAED0soO(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object x52yJyWZPmfocl51QgDM(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object yLHMOMWZ12SJng4p64K4(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object pRMkoQWZNJAStYb6enLt(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}
}
