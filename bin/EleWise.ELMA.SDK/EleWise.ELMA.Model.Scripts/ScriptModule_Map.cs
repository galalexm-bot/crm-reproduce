using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Scripts.Types;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.ScriptDesigner.TranslateData;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode.Impl.CustomizersImpl;
using NHibernate.Properties;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts;

internal class ScriptModule_Map : ClassMapping<ScriptModule>
{
	private sealed class References_Acessor : IPropertyAccessor
	{
		[Serializable]
		private sealed class Getter : IGetter
		{
			private static object Cm2rJFZV9U2g6TWwDKUe;

			public Type ReturnType => TypeOf<string>.Raw;

			public string PropertyName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63AA1C6E);

			public MethodInfo Method => null;

			public object Get(object target)
			{
				return fQXNJhZVrOqcUfFs2FYI((ScriptModule)target);
			}

			public object GetForInsert(object owner, IDictionary mergeMap, ISessionImplementor session)
			{
				return Get(owner);
			}

			public Getter()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				gAF5H4ZVgAPe0h0KiwtD();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static bool JI2rp9ZVdHBeoruKosEl()
			{
				return Cm2rJFZV9U2g6TWwDKUe == null;
			}

			internal static Getter nUQO5jZVlNGIQsYna9SX()
			{
				return (Getter)Cm2rJFZV9U2g6TWwDKUe;
			}

			internal static object fQXNJhZVrOqcUfFs2FYI(object P_0)
			{
				return ((ScriptModule)P_0).References;
			}

			internal static void gAF5H4ZVgAPe0h0KiwtD()
			{
				SingletonReader.JJCZtPuTvSt();
			}
		}

		[Serializable]
		private sealed class Setter : ISetter
		{
			internal static object MF7KRSZV5aSg5qClDOGi;

			public string PropertyName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088392354);

			public MethodInfo Method => null;

			public void Set(object target, object value)
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
					{
						ScriptModule obj = (ScriptModule)target;
						string obj2 = (string)value;
						OZBal7ZVstRu6tW4ljUj(obj, (obj2 != null) ? QfYTVYZVUxWrp2e37ga6(obj2, wq7pnNZVLkgckQafkVEa(-3333094 ^ -3470916), "") : null);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num2 = 0;
						}
						break;
					}
					}
				}
			}

			public Setter()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				NDY1YMZVcyJc6gJlnpba();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static bool FE9u9aZVjrR56uQETvqk()
			{
				return MF7KRSZV5aSg5qClDOGi == null;
			}

			internal static Setter P2thJ5ZVYxGhfrBj05vN()
			{
				return (Setter)MF7KRSZV5aSg5qClDOGi;
			}

			internal static object wq7pnNZVLkgckQafkVEa(int _0020)
			{
				return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static object QfYTVYZVUxWrp2e37ga6(object P_0, object P_1, object P_2)
			{
				return ((string)P_0).Replace((string)P_1, (string)P_2);
			}

			internal static void OZBal7ZVstRu6tW4ljUj(object P_0, object P_1)
			{
				((ScriptModule)P_0).References = (string)P_1;
			}

			internal static void NDY1YMZVcyJc6gJlnpba()
			{
				SingletonReader.JJCZtPuTvSt();
			}
		}

		private static object uxv823CNFqqeGXRxHp7x;

		public bool CanAccessThroughReflectionOptimizer => false;

		public IGetter GetGetter(Type theClass, string propertyName)
		{
			return (IGetter)(object)new Getter();
		}

		public ISetter GetSetter(Type theClass, string propertyName)
		{
			return (ISetter)(object)new Setter();
		}

		public References_Acessor()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool BZRMNhCNBsJehaZNZbXY()
		{
			return uxv823CNFqqeGXRxHp7x == null;
		}

		internal static References_Acessor XnjjniCNW0YWiQKJ7VuR()
		{
			return (References_Acessor)uxv823CNFqqeGXRxHp7x;
		}
	}

	private sealed class ElmaReferences_Acessor : IPropertyAccessor
	{
		[Serializable]
		private sealed class Getter : IGetter
		{
			private static object sLuJlmZVzX59L2OtJwnh;

			public Type ReturnType => TypeOf<string>.Raw;

			public string PropertyName => (string)QFPLDvZSWQ650WvVTp0y(-542721635 ^ -542703357);

			public MethodInfo Method => null;

			public object Get(object target)
			{
				return ((ScriptModule)target).ElmaReferences;
			}

			public object GetForInsert(object owner, IDictionary mergeMap, ISessionImplementor session)
			{
				return Get(owner);
			}

			public Getter()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				ARtBv9ZSoLZQRpEO0uVT();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static object QFPLDvZSWQ650WvVTp0y(int _0020)
			{
				return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static bool cPM7rHZSFRwGpFj5b43G()
			{
				return sLuJlmZVzX59L2OtJwnh == null;
			}

			internal static Getter k6AxXJZSBlD16mtM0oHS()
			{
				return (Getter)sLuJlmZVzX59L2OtJwnh;
			}

			internal static void ARtBv9ZSoLZQRpEO0uVT()
			{
				SingletonReader.JJCZtPuTvSt();
			}
		}

		[Serializable]
		private sealed class Setter : ISetter
		{
			internal static object UoT9TMZSbwjeR1TElPGY;

			public string PropertyName => (string)RblgxvZSEAffq8bZHB30(-1870892489 ^ -1870804311);

			public MethodInfo Method => null;

			public void Set(object target, object value)
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
						((ScriptModule)target).ElmaReferences = ((string)value)?.Replace((string)RblgxvZSEAffq8bZHB30(-2112703338 ^ -2112579280), "");
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			public Setter()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				PT045JZSfYt1KVUu0Elw();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static object RblgxvZSEAffq8bZHB30(int _0020)
			{
				return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static bool ekkHEWZShfap7GTDn7VK()
			{
				return UoT9TMZSbwjeR1TElPGY == null;
			}

			internal static Setter gVXa4ZZSGC0eKSXm4osG()
			{
				return (Setter)UoT9TMZSbwjeR1TElPGY;
			}

			internal static void PT045JZSfYt1KVUu0Elw()
			{
				SingletonReader.JJCZtPuTvSt();
			}
		}

		internal static object P1e5R2CNo5vbBtKdWTAJ;

		public bool CanAccessThroughReflectionOptimizer => false;

		public IGetter GetGetter(Type theClass, string propertyName)
		{
			return (IGetter)(object)new Getter();
		}

		public ISetter GetSetter(Type theClass, string propertyName)
		{
			return (ISetter)(object)new Setter();
		}

		public ElmaReferences_Acessor()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			sohh98CNGpjXXW5E53JO();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void sohh98CNGpjXXW5E53JO()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool DKeE8FCNbj9j2kL5VyuJ()
		{
			return P1e5R2CNo5vbBtKdWTAJ == null;
		}

		internal static ElmaReferences_Acessor kaXyoECNhlmPH5maqo9i()
		{
			return (ElmaReferences_Acessor)P1e5R2CNo5vbBtKdWTAJ;
		}
	}

	internal static ScriptModule_Map nrshfpbqexNO9eS52XXg;

	public ScriptModule_Map()
	{
		//Discarded unreachable code: IL_001a
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 3;
		while (true)
		{
			int num2;
			switch (num)
			{
			case 22:
			{
				ParameterExpression parameterExpression = Expression.Parameter(wOgtIobqpiTqDgfkaxP2(typeof(ScriptModule).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477124862));
				((PropertyContainerCustomizer<ScriptModule>)(object)this).Property<Guid>(Expression.Lambda<Func<ScriptModule, Guid>>(Expression.Property(parameterExpression, (MethodInfo)coSTalbqtsBZ8afVpKgY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num = 21;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num = 23;
				}
				break;
			}
			case 14:
			{
				ParameterExpression parameterExpression = (ParameterExpression)zx7IgLbqabxmG3xBTd6C(typeof(ScriptModule), jfAnZ7bqNaMCC6sqg9Jb(-1123633026 ^ -1123650906));
				((PropertyContainerCustomizer<ScriptModule>)(object)this).Property<Guid>(Expression.Lambda<Func<ScriptModule, Guid>>((Expression)smPd3mbqwG14oflpGnbH(parameterExpression, (MethodInfo)coSTalbqtsBZ8afVpKgY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num = 2;
				}
				break;
			}
			case 3:
				r2yxM8bq3mFLfEp0Y1Av(this, jfAnZ7bqNaMCC6sqg9Jb(-1411196499 ^ -1411240131));
				num = 21;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num = 19;
				}
				break;
			case 8:
			{
				ParameterExpression parameterExpression = (ParameterExpression)zx7IgLbqabxmG3xBTd6C(wOgtIobqpiTqDgfkaxP2(typeof(ScriptModule).TypeHandle), jfAnZ7bqNaMCC6sqg9Jb(-812025778 ^ -812010858));
				((PropertyContainerCustomizer<ScriptModule>)(object)this).ManyToOne<ScriptModule>(Expression.Lambda<Func<ScriptModule, ScriptModule>>(Expression.Property(parameterExpression, (MethodInfo)coSTalbqtsBZ8afVpKgY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num = 19;
				break;
			}
			case 13:
			{
				ParameterExpression parameterExpression = (ParameterExpression)zx7IgLbqabxmG3xBTd6C(wOgtIobqpiTqDgfkaxP2(typeof(ScriptModule).TypeHandle), jfAnZ7bqNaMCC6sqg9Jb(-957824448 ^ -957871976));
				((PropertyContainerCustomizer<ScriptModule>)(object)this).Property<Guid>(Expression.Lambda<Func<ScriptModule, Guid>>((Expression)smPd3mbqwG14oflpGnbH(parameterExpression, (MethodInfo)coSTalbqtsBZ8afVpKgY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num = 22;
				break;
			}
			case 19:
				return;
			case 21:
			{
				ParameterExpression parameterExpression = (ParameterExpression)zx7IgLbqabxmG3xBTd6C(wOgtIobqpiTqDgfkaxP2(typeof(ScriptModule).TypeHandle), jfAnZ7bqNaMCC6sqg9Jb(0x7EC153F ^ 0x7ECDFE7));
				((ClassCustomizer<ScriptModule>)(object)this).Id<long>(Expression.Lambda<Func<ScriptModule, long>>(Expression.Property(parameterExpression, (MethodInfo)L7VMVtbqDPabDNDt7fZN((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(Entity<long>).TypeHandle)), new ParameterExpression[1] { parameterExpression }), (Action<IIdMapper>)delegate(IIdMapper p)
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 1:
							_003C_003Ec.YTdj95CN8G6rhWPIZ4yP(p, _003C_003Ec.C9Z1JgCNvtPIjTooE6iO(-812025778 ^ -812020002), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538551992));
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
							{
								num4 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				num = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num = 14;
				}
				break;
			}
			case 23:
			{
				ParameterExpression parameterExpression = (ParameterExpression)zx7IgLbqabxmG3xBTd6C(wOgtIobqpiTqDgfkaxP2(typeof(ScriptModule).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459609095));
				((PropertyContainerCustomizer<ScriptModule>)(object)this).Property<string>(Expression.Lambda<Func<ScriptModule, string>>((Expression)smPd3mbqwG14oflpGnbH(parameterExpression, (MethodInfo)coSTalbqtsBZ8afVpKgY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num21 = 1;
					int num22 = num21;
					while (true)
					{
						switch (num22)
						{
						default:
							return;
						case 1:
							p.Length(int.MaxValue);
							num22 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
							{
								num22 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				num = 7;
				break;
			}
			case 7:
			{
				ParameterExpression parameterExpression = (ParameterExpression)zx7IgLbqabxmG3xBTd6C(wOgtIobqpiTqDgfkaxP2(typeof(ScriptModule).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837648733));
				((PropertyContainerCustomizer<ScriptModule>)(object)this).Property<string>(Expression.Lambda<Func<ScriptModule, string>>(Expression.Property(parameterExpression, (MethodInfo)coSTalbqtsBZ8afVpKgY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num9 = 1;
					int num10 = num9;
					while (true)
					{
						switch (num10)
						{
						default:
							return;
						case 1:
							_003C_003Ec.dRGIFBCNZ5lf7S77bm8C(p, int.MaxValue);
							num10 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
							{
								num10 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num = 1;
				}
				break;
			}
			case 1:
			{
				ParameterExpression parameterExpression = Expression.Parameter(wOgtIobqpiTqDgfkaxP2(typeof(ScriptModule).TypeHandle), (string)jfAnZ7bqNaMCC6sqg9Jb(-1426094279 ^ -1426108959));
				((PropertyContainerCustomizer<ScriptModule>)(object)this).Property<string>(Expression.Lambda<Func<ScriptModule, string>>((Expression)smPd3mbqwG14oflpGnbH(parameterExpression, (MethodInfo)coSTalbqtsBZ8afVpKgY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num15 = 1;
					int num16 = num15;
					while (true)
					{
						switch (num16)
						{
						default:
							return;
						case 1:
							_003C_003Ec.dRGIFBCNZ5lf7S77bm8C(p, int.MaxValue);
							num16 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
							{
								num16 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num = 0;
				}
				break;
			}
			default:
			{
				ParameterExpression parameterExpression = (ParameterExpression)zx7IgLbqabxmG3xBTd6C(wOgtIobqpiTqDgfkaxP2(typeof(ScriptModule).TypeHandle), jfAnZ7bqNaMCC6sqg9Jb(-867826612 ^ -867774828));
				((PropertyContainerCustomizer<ScriptModule>)(object)this).Property<string>(Expression.Lambda<Func<ScriptModule, string>>((Expression)smPd3mbqwG14oflpGnbH(parameterExpression, (MethodInfo)coSTalbqtsBZ8afVpKgY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num19 = 1;
					int num20 = num19;
					while (true)
					{
						switch (num20)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							p.Length(int.MaxValue);
							num20 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
							{
								num20 = 0;
							}
							break;
						}
					}
				});
				num2 = 15;
				goto IL_001f;
			}
			case 15:
			{
				ParameterExpression parameterExpression = (ParameterExpression)zx7IgLbqabxmG3xBTd6C(wOgtIobqpiTqDgfkaxP2(typeof(ScriptModule).TypeHandle), jfAnZ7bqNaMCC6sqg9Jb(0x42643203 ^ 0x4264F8DB));
				((PropertyContainerCustomizer<ScriptModule>)(object)this).Property<string>(Expression.Lambda<Func<ScriptModule, string>>((Expression)smPd3mbqwG14oflpGnbH(parameterExpression, (MethodInfo)coSTalbqtsBZ8afVpKgY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num5 = 1;
					int num6 = num5;
					while (true)
					{
						switch (num6)
						{
						default:
							_003C_003Ec.Dhh7jOCNImjhH2JbgdHV(p, _003C_003Ec.oDZApZCNuYRCisQrukCN(typeof(References_Acessor).TypeHandle));
							num6 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
							{
								num6 = 2;
							}
							break;
						case 2:
							return;
						case 1:
							_003C_003Ec.dRGIFBCNZ5lf7S77bm8C(p, int.MaxValue);
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
							{
								num6 = 0;
							}
							break;
						}
					}
				});
				num = 5;
				break;
			}
			case 5:
			{
				ParameterExpression parameterExpression = (ParameterExpression)zx7IgLbqabxmG3xBTd6C(wOgtIobqpiTqDgfkaxP2(typeof(ScriptModule).TypeHandle), jfAnZ7bqNaMCC6sqg9Jb(-70037984 ^ -70023944));
				((PropertyContainerCustomizer<ScriptModule>)(object)this).Property<string>(Expression.Lambda<Func<ScriptModule, string>>(Expression.Property(parameterExpression, (MethodInfo)coSTalbqtsBZ8afVpKgY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num7 = 1;
					int num8 = num7;
					while (true)
					{
						switch (num8)
						{
						case 1:
							p.Length(int.MaxValue);
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
							{
								num8 = 0;
							}
							break;
						default:
							_003C_003Ec.Dhh7jOCNImjhH2JbgdHV(p, _003C_003Ec.oDZApZCNuYRCisQrukCN(typeof(ElmaReferences_Acessor).TypeHandle));
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
							{
								num8 = 2;
							}
							break;
						case 2:
							return;
						}
					}
				});
				num2 = 16;
				goto IL_001f;
			}
			case 16:
			{
				ParameterExpression parameterExpression = (ParameterExpression)zx7IgLbqabxmG3xBTd6C(wOgtIobqpiTqDgfkaxP2(typeof(ScriptModule).TypeHandle), jfAnZ7bqNaMCC6sqg9Jb(-675505729 ^ -675523737));
				((PropertyContainerCustomizer<ScriptModule>)(object)this).Property<List<ScriptWebReference>>(Expression.Lambda<Func<ScriptModule, List<ScriptWebReference>>>((Expression)smPd3mbqwG14oflpGnbH(parameterExpression, (MethodInfo)coSTalbqtsBZ8afVpKgY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper m)
				{
					m.Type<ScriptWebReferencesNHType>();
				});
				num = 6;
				break;
			}
			case 6:
			{
				ParameterExpression parameterExpression = (ParameterExpression)zx7IgLbqabxmG3xBTd6C(typeof(ScriptModule), jfAnZ7bqNaMCC6sqg9Jb(-542721635 ^ -542739643));
				((PropertyContainerCustomizer<ScriptModule>)(object)this).Property<List<AssemblyReference>>(Expression.Lambda<Func<ScriptModule, List<AssemblyReference>>>((Expression)smPd3mbqwG14oflpGnbH(parameterExpression, (MethodInfo)coSTalbqtsBZ8afVpKgY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper m)
				{
					m.Type<AssemblyReferenceNHType>();
				});
				num = 20;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num = 1;
				}
				break;
			}
			case 20:
			{
				ParameterExpression parameterExpression = Expression.Parameter(typeof(ScriptModule), (string)jfAnZ7bqNaMCC6sqg9Jb(0x269E5FCA ^ 0x269E9512));
				((PropertyContainerCustomizer<ScriptModule>)(object)this).Property<List<AssemblyReference>>(Expression.Lambda<Func<ScriptModule, List<AssemblyReference>>>((Expression)smPd3mbqwG14oflpGnbH(parameterExpression, (MethodInfo)coSTalbqtsBZ8afVpKgY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper m)
				{
					m.Type<AssemblyReferenceNHType>();
				});
				num = 4;
				break;
			}
			case 4:
			{
				ParameterExpression parameterExpression = (ParameterExpression)zx7IgLbqabxmG3xBTd6C(wOgtIobqpiTqDgfkaxP2(typeof(ScriptModule).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099733105));
				((PropertyContainerCustomizer<ScriptModule>)(object)this).Property<RootCodeItemCollection>(Expression.Lambda<Func<ScriptModule, RootCodeItemCollection>>((Expression)smPd3mbqwG14oflpGnbH(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper m)
				{
					m.Type<RootCodeItemCollectionNH>();
				});
				num = 2;
				break;
			}
			case 2:
			{
				ParameterExpression parameterExpression = (ParameterExpression)zx7IgLbqabxmG3xBTd6C(wOgtIobqpiTqDgfkaxP2(typeof(ScriptModule).TypeHandle), jfAnZ7bqNaMCC6sqg9Jb(-2107978722 ^ -2108029242));
				((PropertyContainerCustomizer<ScriptModule>)(object)this).Property<List<ScriptMethodDeclaration>>(Expression.Lambda<Func<ScriptModule, List<ScriptMethodDeclaration>>>((Expression)smPd3mbqwG14oflpGnbH(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper m)
				{
					m.Type<ScriptMethodDeclarationNHType>();
				});
				num = 10;
				break;
			}
			case 10:
			{
				ParameterExpression parameterExpression = Expression.Parameter(wOgtIobqpiTqDgfkaxP2(typeof(ScriptModule).TypeHandle), (string)jfAnZ7bqNaMCC6sqg9Jb(0x1A33FE36 ^ 0x1A3334EE));
				((PropertyContainerCustomizer<ScriptModule>)(object)this).Property<string>(Expression.Lambda<Func<ScriptModule, string>>((Expression)smPd3mbqwG14oflpGnbH(parameterExpression, (MethodInfo)coSTalbqtsBZ8afVpKgY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num11 = 1;
					int num12 = num11;
					while (true)
					{
						switch (num12)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							_003C_003Ec.dRGIFBCNZ5lf7S77bm8C(p, int.MaxValue);
							num12 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
							{
								num12 = 0;
							}
							break;
						}
					}
				});
				num = 17;
				break;
			}
			case 17:
			{
				ParameterExpression parameterExpression = Expression.Parameter(wOgtIobqpiTqDgfkaxP2(typeof(ScriptModule).TypeHandle), (string)jfAnZ7bqNaMCC6sqg9Jb(-1411196499 ^ -1411247243));
				((PropertyContainerCustomizer<ScriptModule>)(object)this).Property<string>(Expression.Lambda<Func<ScriptModule, string>>((Expression)smPd3mbqwG14oflpGnbH(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num13 = 1;
					int num14 = num13;
					while (true)
					{
						switch (num14)
						{
						default:
							return;
						case 1:
							_003C_003Ec.dRGIFBCNZ5lf7S77bm8C(p, int.MaxValue);
							num14 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
							{
								num14 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				num = 18;
				break;
			}
			case 18:
			{
				ParameterExpression parameterExpression = (ParameterExpression)zx7IgLbqabxmG3xBTd6C(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x3132ABDE));
				((PropertyContainerCustomizer<ScriptModule>)(object)this).Property<string>(Expression.Lambda<Func<ScriptModule, string>>((Expression)smPd3mbqwG14oflpGnbH(parameterExpression, (MethodInfo)coSTalbqtsBZ8afVpKgY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num17 = 1;
					int num18 = num17;
					while (true)
					{
						switch (num18)
						{
						default:
							return;
						case 1:
							_003C_003Ec.dRGIFBCNZ5lf7S77bm8C(p, int.MaxValue);
							num18 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
							{
								num18 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				num = 11;
				break;
			}
			case 11:
			{
				ParameterExpression parameterExpression = (ParameterExpression)zx7IgLbqabxmG3xBTd6C(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867250355));
				((PropertyContainerCustomizer<ScriptModule>)(object)this).Property<byte[]>(Expression.Lambda<Func<ScriptModule, byte[]>>(Expression.Property(parameterExpression, (MethodInfo)coSTalbqtsBZ8afVpKgY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper m)
				{
					m.Type<FixedBinaryUserType>();
				});
				num = 12;
				break;
			}
			case 12:
			{
				ParameterExpression parameterExpression = (ParameterExpression)zx7IgLbqabxmG3xBTd6C(typeof(ScriptModule), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606602300));
				((PropertyContainerCustomizer<ScriptModule>)(object)this).Property<byte[]>(Expression.Lambda<Func<ScriptModule, byte[]>>((Expression)smPd3mbqwG14oflpGnbH(parameterExpression, (MethodInfo)coSTalbqtsBZ8afVpKgY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper m)
				{
					m.Type<FixedBinaryUserType>();
				});
				num = 9;
				break;
			}
			case 9:
				{
					ParameterExpression parameterExpression = (ParameterExpression)zx7IgLbqabxmG3xBTd6C(wOgtIobqpiTqDgfkaxP2(typeof(ScriptModule).TypeHandle), jfAnZ7bqNaMCC6sqg9Jb(0x4A1640F ^ 0x4A1AED7));
					((PropertyContainerCustomizer<ScriptModule>)(object)this).Property<object>(Expression.Lambda<Func<ScriptModule, object>>((Expression)smPd3mbqwG14oflpGnbH(parameterExpression, (MethodInfo)coSTalbqtsBZ8afVpKgY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper m)
					{
						m.Type<XmlObjectSerializableType>();
					});
					num = 8;
					break;
				}
				IL_001f:
				num = num2;
				break;
			}
		}
	}

	internal static object jfAnZ7bqNaMCC6sqg9Jb(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void r2yxM8bq3mFLfEp0Y1Av(object P_0, object P_1)
	{
		((ClassCustomizer<ScriptModule>)P_0).Table((string)P_1);
	}

	internal static Type wOgtIobqpiTqDgfkaxP2(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object zx7IgLbqabxmG3xBTd6C(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object L7VMVtbqDPabDNDt7fZN(RuntimeMethodHandle P_0, RuntimeTypeHandle P_1)
	{
		return MethodBase.GetMethodFromHandle(P_0, P_1);
	}

	internal static object coSTalbqtsBZ8afVpKgY(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object smPd3mbqwG14oflpGnbH(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static bool ecXh1UbqPmuj9TnjSkP9()
	{
		return nrshfpbqexNO9eS52XXg == null;
	}

	internal static ScriptModule_Map zsrA3Obq1x4XQAADH1nH()
	{
		return nrshfpbqexNO9eS52XXg;
	}
}
