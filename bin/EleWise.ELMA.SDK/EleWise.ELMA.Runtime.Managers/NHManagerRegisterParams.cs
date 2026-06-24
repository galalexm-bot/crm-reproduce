using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Autofac;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Managers;

public class NHManagerRegisterParams
{
	private readonly ISet<Type> typeMappings;

	private readonly IDictionary<Type, (string entityName, int? tableNumber, bool? dynamicInsert, bool? dynamicUpdate)> mappings;

	internal static NHManagerRegisterParams HvO7TCW9oNm4OyPU5uat;

	public ContainerBuilder Builder
	{
		[CompilerGenerated]
		get
		{
			return _003CBuilder_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CBuilder_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use NHibernate Mapping instead Fluent NHibernate and method NHManagerRegisterParams.Add", true)]
	public CustomFluentMappingsContainer FluentMappings
	{
		get
		{
			throw new NotImplementedException((string)pV4x1SW9Geg8HtuH1fZO(-475857671 ^ -475995359));
		}
	}

	public ITransformationProvider TransformationProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CTransformationProvider_003Ek__BackingField;
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
					_003CTransformationProvider_003Ek__BackingField = value;
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

	internal IEnumerable<Assembly> MappingAssemblies => typeMappings.Select((Type t) => t.Assembly).Distinct();

	internal bool HasItems
	{
		get
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (mappings.Count > 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return TpThD9W9fkTRpoP0txXw(typeMappings) > 0;
				default:
					return true;
				}
			}
		}
	}

	public void Add<T>() where T : class, IConformistHoldersProvider
	{
		Add(typeof(T));
	}

	public void Add(Type type)
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
				d6p0dAW9EO5fAb5TLQqG(TypeOf<IConformistHoldersProvider>.Raw.IsAssignableFrom(type), SR.T((string)pV4x1SW9Geg8HtuH1fZO(-420743386 ^ -420887006)));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				typeMappings.Add(type);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void AddRange(IEnumerable<Type> types)
	{
		typeMappings.AddRange(types);
	}

	internal void AddNHibernateClassMapping(Type type, string entityName, int? tableNumber, bool? dynamicInsert, bool? dynamicUpdate)
	{
		mappings[type] = (entityName, tableNumber, dynamicInsert, dynamicUpdate);
	}

	internal void AddNHibernateClassMappingRange(IEnumerable<Type> types)
	{
		types.ForEach(delegate(Type t)
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
					mappings[t] = (null, null, null, null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		});
	}

	internal ModelMapper CreateModelMapper()
	{
		int num = 2;
		int num2 = num;
		ModelMapper val = default(ModelMapper);
		while (true)
		{
			switch (num2)
			{
			default:
				return val;
			case 2:
				val = NHibernateClassMapping.CreateModelMapper(mappings);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				((IEnumerable<Type>)typeMappings).ForEach((Action<Type>)val.AddMapping);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal void Add(NHManagerRegisterParams @params)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				@params.mappings.ForEach(delegate(KeyValuePair<Type, (string entityName, int? tableNumber, bool? dynamicInsert, bool? dynamicUpdate)> p)
				{
					mappings[p.Key] = p.Value;
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				typeMappings.UnionWith(@params.typeMappings);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public NHManagerRegisterParams()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		SingletonReader.JJCZtPuTvSt();
		typeMappings = new HashSet<Type>();
		mappings = new Dictionary<Type, (string, int?, bool?, bool?)>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool jtWtMbW9bKGfIhov968p()
	{
		return HvO7TCW9oNm4OyPU5uat == null;
	}

	internal static NHManagerRegisterParams kJHT36W9hoURowP4m7Do()
	{
		return HvO7TCW9oNm4OyPU5uat;
	}

	internal static object pV4x1SW9Geg8HtuH1fZO(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void d6p0dAW9EO5fAb5TLQqG(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static int TpThD9W9fkTRpoP0txXw(object P_0)
	{
		return ((ICollection<Type>)P_0).Count;
	}
}
