using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.CodeGeneration;
using j3AmrhgkCleVTGdEwA;
using Mono.Cecil;

namespace EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;

internal class CustomAttributesData
{
	private class AttributeData
	{
		private class AttributeTypedArgument
		{
			private readonly object typeReference;

			private readonly object value;

			internal static object oDW4jxZiOsxUTvX9041b;

			public AttributeTypedArgument(CustomAttributeArgument argument)
			{
				//Discarded unreachable code: IL_002a
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				dm8oBIZiPuU1jiolqUUl();
				base._002Ector();
				int num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						typeReference = MXKVSuZi1rTeV7mSTW3T(((CustomAttributeArgument)(ref argument)).get_Type());
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num = 0;
						}
						break;
					case 2:
						return;
					default:
					{
						value = ResolveAttributeArgument(argument);
						int num2 = 2;
						num = num2;
						break;
					}
					}
				}
			}

			public CustomAttributeTypedArgument Resolve()
			{
				Type argumentType = n8NgCjZiNtqPheTBNoDY(typeReference);
				object obj = value;
				TypeReference val;
				return new CustomAttributeTypedArgument(argumentType, ((val = (TypeReference)((obj is TypeReference) ? obj : null)) != null) ? n8NgCjZiNtqPheTBNoDY(val) : value);
			}

			private object ResolveAttributeArgument(CustomAttributeArgument argument)
			{
				//Discarded unreachable code: IL_0049, IL_0058, IL_00e9
				//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_00af: Unknown result type (might be due to invalid IL or missing references)
				//IL_011e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0130: Unknown result type (might be due to invalid IL or missing references)
				//IL_0135: Unknown result type (might be due to invalid IL or missing references)
				int num = 2;
				int num2 = num;
				TypeReference val2 = default(TypeReference);
				object obj = default(object);
				CustomAttributeArgument argument2 = default(CustomAttributeArgument);
				CustomAttributeArgument val = default(CustomAttributeArgument);
				object obj2 = default(object);
				while (true)
				{
					switch (num2)
					{
					case 5:
						if ((val2 = (TypeReference)((obj is TypeReference) ? obj : null)) == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
							{
								num2 = 7;
							}
							break;
						}
						goto case 4;
					case 4:
						return MXKVSuZi1rTeV7mSTW3T(val2);
					case 9:
						argument2 = val;
						num2 = 3;
						break;
					case 7:
						if (obj is CustomAttributeArgument[] source)
						{
							return source.Select(ResolveAttributeArgument).ToArray();
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num2 = 0;
						}
						break;
					case 1:
						if (obj == null)
						{
							num2 = 6;
							break;
						}
						goto case 5;
					default:
						if ((obj2 = obj) is CustomAttributeArgument)
						{
							num2 = 8;
							break;
						}
						goto case 6;
					case 3:
						return ResolveAttributeArgument(argument2);
					case 6:
						return ((CustomAttributeArgument)(ref argument)).get_Value();
					case 8:
						val = (CustomAttributeArgument)obj2;
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
						{
							num2 = 8;
						}
						break;
					case 2:
						obj = ((CustomAttributeArgument)(ref argument)).get_Value();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			}

			internal static void dm8oBIZiPuU1jiolqUUl()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static object MXKVSuZi1rTeV7mSTW3T(object P_0)
			{
				return EntityDynamicGenerator.CreateReference((TypeReference)P_0);
			}

			internal static bool CaY2dkZi2sIMQxZFkmFd()
			{
				return oDW4jxZiOsxUTvX9041b == null;
			}

			internal static AttributeTypedArgument o3Mj43ZierhqUu45T7Lv()
			{
				return (AttributeTypedArgument)oDW4jxZiOsxUTvX9041b;
			}

			internal static Type n8NgCjZiNtqPheTBNoDY(object P_0)
			{
				return EntityDynamicGenerator.Resolve((TypeReference)P_0);
			}
		}

		private abstract class AttributeNamedArgument
		{
			protected readonly object Name;

			protected readonly object Argument;

			private static object jMMxyAZi37fq7FQ4cbcd;

			public AttributeNamedArgument(string name, CustomAttributeNamedArgument argument)
			{
				//Discarded unreachable code: IL_002a, IL_002f
				//IL_004c: Unknown result type (might be due to invalid IL or missing references)
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						Argument = new AttributeTypedArgument(((CustomAttributeNamedArgument)(ref argument)).get_Argument());
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num = 2;
						}
						break;
					case 2:
						return;
					case 1:
						Name = name;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			public abstract CustomAttributeNamedArgument Resolve(Type attributeType);

			internal static bool yeU7AnZipADt4PnT6Lo1()
			{
				return jMMxyAZi37fq7FQ4cbcd == null;
			}

			internal static AttributeNamedArgument wSEeJHZiaAsX7unxmOUX()
			{
				return (AttributeNamedArgument)jMMxyAZi37fq7FQ4cbcd;
			}
		}

		private class AttributeNamedFieldArgument : AttributeNamedArgument
		{
			internal static object xHEF73ZiDsZNwkInTTTN;

			public AttributeNamedFieldArgument(string name, CustomAttributeNamedArgument argument)
			{
				//Discarded unreachable code: IL_002c, IL_0031
				//IL_000c: Unknown result type (might be due to invalid IL or missing references)
				k8ZL5vZi4cNyO9r3IvqF();
				base._002Ector(name, argument);
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			public override CustomAttributeNamedArgument Resolve(Type attributeType)
			{
				return new CustomAttributeNamedArgument(attributeType.GetField((string)Name), ((AttributeTypedArgument)Argument).Resolve());
			}

			internal static void k8ZL5vZi4cNyO9r3IvqF()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static bool q6NO2FZitf9xlhUwCMc6()
			{
				return xHEF73ZiDsZNwkInTTTN == null;
			}

			internal static AttributeNamedFieldArgument SvAu6BZiwBhO57H74Enb()
			{
				return (AttributeNamedFieldArgument)xHEF73ZiDsZNwkInTTTN;
			}
		}

		private class AttributeNamedPropertyArgument : AttributeNamedArgument
		{
			private static object LYcQmEZi6UW4po1M6rLH;

			public AttributeNamedPropertyArgument(string name, CustomAttributeNamedArgument argument)
			{
				//Discarded unreachable code: IL_002c, IL_0031
				//IL_000c: Unknown result type (might be due to invalid IL or missing references)
				SingletonReader.JJCZtPuTvSt();
				base._002Ector(name, argument);
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			public override CustomAttributeNamedArgument Resolve(Type attributeType)
			{
				return new CustomAttributeNamedArgument(attributeType.GetProperty((string)Name), rvRDyBZi74FDhsHPwFDc(Argument));
			}

			internal static bool YHt7BWZiH3Y1kdO8Ulsn()
			{
				return LYcQmEZi6UW4po1M6rLH == null;
			}

			internal static AttributeNamedPropertyArgument WmjPYmZiAl46Wtu1tKET()
			{
				return (AttributeNamedPropertyArgument)LYcQmEZi6UW4po1M6rLH;
			}

			internal static CustomAttributeTypedArgument rvRDyBZi74FDhsHPwFDc(object P_0)
			{
				return ((AttributeTypedArgument)P_0).Resolve();
			}
		}

		private readonly object constructorReference;

		private readonly object constructorArguments;

		private readonly object namedArguments;

		private static object Tcj98ZvFbmnAmm7VLys5;

		public AttributeData(CustomAttribute customAttribute)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
			{
				num = 2;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					constructorReference = EntityDynamicGenerator.CreateReference((MethodReference)XboZ5RvFEfhWBnt9F3uo(customAttribute));
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num = 0;
					}
					break;
				case 1:
					return;
				default:
					constructorArguments = ((IEnumerable<CustomAttributeArgument>)customAttribute.get_ConstructorArguments()).Select((CustomAttributeArgument a) => new AttributeTypedArgument(a)).ToArray();
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num = 3;
					}
					break;
				case 3:
					namedArguments = ((IEnumerable<CustomAttributeNamedArgument>)customAttribute.get_Fields()).Select((Func<CustomAttributeNamedArgument, AttributeNamedArgument>)((CustomAttributeNamedArgument f) => new AttributeNamedFieldArgument(((CustomAttributeNamedArgument)(ref f)).get_Name(), f))).Concat(((IEnumerable<CustomAttributeNamedArgument>)customAttribute.get_Properties()).Select((CustomAttributeNamedArgument p) => new AttributeNamedPropertyArgument(((CustomAttributeNamedArgument)(ref p)).get_Name(), p))).ToArray();
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num = 1;
					}
					break;
				}
			}
		}

		public CustomAttributeData Resolve()
		{
			int num = 3;
			int num2 = num;
			_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
			while (true)
			{
				switch (num2)
				{
				case 3:
					_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
					num2 = 2;
					break;
				case 2:
					_003C_003Ec__DisplayClass4_._003C_003E4__this = this;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					_003C_003Ec__DisplayClass4_.attributeType = EntityDynamicGenerator.Resolve(((MemberReference)constructorReference).get_DeclaringType());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return new EntityCustomAttributeData(_003C_003Ec__DisplayClass4_.attributeType.GetConstructors().FirstOrDefault(_003C_003Ec__DisplayClass4_._003CResolve_003Eb__0), ((IEnumerable<AttributeTypedArgument>)constructorArguments).Select((AttributeTypedArgument a) => _003C_003Ec.Tb1UvNZiMrPKJ3rVMcq7(a)).ToArray(), ((IEnumerable<AttributeNamedArgument>)namedArguments).Select(_003C_003Ec__DisplayClass4_._003CResolve_003Eb__2).ToArray());
				}
			}
		}

		private static bool SequenceEqual(IList<ParameterInfo> parameters1, IList<ParameterDefinition> parameters2)
		{
			if (parameters1.Count != parameters2.Count)
			{
				return false;
			}
			for (int i = 0; i < parameters1.Count; i++)
			{
				if (!Equal(parameters1[i].ParameterType, ((ParameterReference)parameters2[i]).get_ParameterType()))
				{
					return false;
				}
			}
			return true;
		}

		private static bool SequenceEqual(IList<Type> types1, IList<TypeReference> types2)
		{
			if (types1.Count != types2.Count)
			{
				return false;
			}
			for (int i = 0; i < types1.Count; i++)
			{
				if (!Equal(types1[i], types2[i]))
				{
					return false;
				}
			}
			return true;
		}

		private static bool Equal(Type type1, object type2)
		{
			//Discarded unreachable code: IL_0142, IL_0151, IL_0175, IL_0184, IL_01e3, IL_01f2, IL_0202, IL_0211, IL_0259, IL_0303, IL_032a, IL_0339, IL_03d0, IL_03df, IL_0429, IL_0438
			int num = 11;
			ArrayType val5 = default(ArrayType);
			GenericInstanceType val2 = default(GenericInstanceType);
			GenericParameter val = default(GenericParameter);
			GenericInstanceType val4 = default(GenericInstanceType);
			ByReferenceType val3 = default(ByReferenceType);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 10:
						if ((val5 = (ArrayType)((type2 is ArrayType) ? type2 : null)) == null)
						{
							num2 = 16;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
							{
								num2 = 14;
							}
							continue;
						}
						goto case 13;
					case 17:
						if ((val2 = (GenericInstanceType)((type2 is GenericInstanceType) ? type2 : null)) != null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
							{
								num2 = 4;
							}
							continue;
						}
						goto case 21;
					case 5:
						if (Yt1UHLvFCKd3eTvkDcZA(type1.DeclaringType, null))
						{
							num2 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
							{
								num2 = 9;
							}
							continue;
						}
						goto case 23;
					case 1:
					case 12:
						return type1.FullName == (string)MT9MNUvFV79YejZ2rGFL(type2);
					case 2:
						if (type1.Name == (string)hHMFPKvFSQFhtutYyifK(type2))
						{
							num2 = 3;
							continue;
						}
						return false;
					case 3:
						return Equal(type1.DeclaringType, NfBOuDvFvZaoqEUYgiTR(type2));
					default:
						return SequenceEqual(type1.GetGenericArguments(), (IList<TypeReference>)val2.get_GenericArguments());
					case 21:
						return false;
					case 28:
						if (!type1.IsNested)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 14;
					case 9:
						if (NfBOuDvFvZaoqEUYgiTR(val) != null)
						{
							num2 = 15;
							continue;
						}
						goto case 23;
					case 26:
						return m0ZObGvFQLymhQuYggGm(type1.GetGenericTypeDefinition(), ((TypeSpecification)val4).get_ElementType());
					case 22:
						if (type1.IsGenericType)
						{
							num2 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
							{
								num2 = 17;
							}
							continue;
						}
						goto case 28;
					case 19:
						return Equal(type1.GetElementType(), emChldvFfWwofp2PcDvR(val3));
					case 7:
						return false;
					case 27:
						if ((val = (GenericParameter)((type2 is GenericParameter) ? type2 : null)) == null)
						{
							num2 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
							{
								num2 = 8;
							}
							continue;
						}
						goto case 5;
					case 24:
						if (eXBSSjvFZ4np0mYvA64J(val) != null)
						{
							num = 25;
							break;
						}
						goto case 18;
					case 23:
						if (cFI7ucvF8TYHaLbYr6pV(type1.DeclaringMethod, null))
						{
							num2 = 10;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
							{
								num2 = 24;
							}
							continue;
						}
						goto case 18;
					case 6:
						if ((val4 = (GenericInstanceType)((type2 is GenericInstanceType) ? type2 : null)) == null)
						{
							num2 = 28;
							continue;
						}
						goto case 26;
					case 11:
						if (type1.IsArray)
						{
							num2 = 10;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
							{
								num2 = 9;
							}
							continue;
						}
						if (!type1.IsByRef)
						{
							if (type1.IsGenericParameter)
							{
								num = 27;
								break;
							}
							if (!type1.IsGenericTypeDefinition)
							{
								num2 = 22;
								continue;
							}
							goto case 6;
						}
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
						{
							num2 = 20;
						}
						continue;
					case 20:
						if ((val3 = (ByReferenceType)((type2 is ByReferenceType) ? type2 : null)) == null)
						{
							num = 7;
							break;
						}
						goto case 19;
					case 4:
						if (!m0ZObGvFQLymhQuYggGm(type1.GetGenericTypeDefinition(), emChldvFfWwofp2PcDvR(val2)))
						{
							num2 = 21;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
							{
								num2 = 12;
							}
							continue;
						}
						goto default;
					case 14:
						if (MkHIePvFIJJ1qSC2TCBW(type2))
						{
							num2 = 2;
							continue;
						}
						goto case 1;
					case 13:
						return m0ZObGvFQLymhQuYggGm(type1.GetElementType(), emChldvFfWwofp2PcDvR(val5));
					case 16:
						return false;
					case 18:
						return false;
					case 25:
						return type1.GenericParameterPosition == bg6WKRvFuWQi3RduUoO3(val);
					case 15:
						return type1.GenericParameterPosition == bg6WKRvFuWQi3RduUoO3(val);
					case 8:
						return false;
					}
					break;
				}
			}
		}

		internal static object XboZ5RvFEfhWBnt9F3uo(object P_0)
		{
			return ((CustomAttribute)P_0).get_Constructor();
		}

		internal static bool GvebMvvFhQhao8IcGmQJ()
		{
			return Tcj98ZvFbmnAmm7VLys5 == null;
		}

		internal static AttributeData dV4vUxvFGbbDscuagHlc()
		{
			return (AttributeData)Tcj98ZvFbmnAmm7VLys5;
		}

		internal static object emChldvFfWwofp2PcDvR(object P_0)
		{
			return ((TypeSpecification)P_0).get_ElementType();
		}

		internal static bool m0ZObGvFQLymhQuYggGm(Type type1, object P_1)
		{
			return Equal(type1, P_1);
		}

		internal static bool Yt1UHLvFCKd3eTvkDcZA(Type P_0, Type P_1)
		{
			return P_0 != P_1;
		}

		internal static object NfBOuDvFvZaoqEUYgiTR(object P_0)
		{
			return ((MemberReference)P_0).get_DeclaringType();
		}

		internal static bool cFI7ucvF8TYHaLbYr6pV(object P_0, object P_1)
		{
			return (MethodBase)P_0 != (MethodBase)P_1;
		}

		internal static object eXBSSjvFZ4np0mYvA64J(object P_0)
		{
			return ((GenericParameter)P_0).get_DeclaringMethod();
		}

		internal static int bg6WKRvFuWQi3RduUoO3(object P_0)
		{
			return ((GenericParameter)P_0).get_Position();
		}

		internal static bool MkHIePvFIJJ1qSC2TCBW(object P_0)
		{
			return ((TypeReference)P_0).get_IsNested();
		}

		internal static object MT9MNUvFV79YejZ2rGFL(object P_0)
		{
			return ((MemberReference)P_0).get_FullName();
		}

		internal static object hHMFPKvFSQFhtutYyifK(object P_0)
		{
			return ((MemberReference)P_0).get_Name();
		}
	}

	private readonly AttributeData[] attributesData;

	private IList<CustomAttributeData> customAttributesData;

	private object[] customAttributes;

	internal static CustomAttributesData ahLwpvhVJbFhKNuiMfDM;

	public CustomAttributesData(IList<CustomAttributeData> customAttributesData)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.customAttributesData = customAttributesData;
	}

	public CustomAttributesData(ICollection<CustomAttribute> customAttributes)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		attributesData = customAttributes.Select((CustomAttribute customAttribute) => new AttributeData(customAttribute)).ToArray();
	}

	public IList<CustomAttributeData> GetCustomAttributesData()
	{
		return customAttributesData ?? (customAttributesData = attributesData.Select((AttributeData a) => a.Resolve()).ToArray());
	}

	public object[] GetCustomAttributes()
	{
		int num = 2;
		int num2 = num;
		object[] array2;
		object[] array = default(object[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				array2 = customAttributes;
				if (array2 != null)
				{
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				array = (customAttributes = GetCustomAttributesData().Select(delegate(CustomAttributeData d)
				{
					int num3 = 1;
					int num4 = num3;
					_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
					while (true)
					{
						switch (num4)
						{
						case 3:
							return _003C_003Ec__DisplayClass6_.attr;
						case 1:
							_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
							{
								num4 = 0;
							}
							break;
						case 2:
							d.NamedArguments.ForEach(_003C_003Ec__DisplayClass6_._003CGetCustomAttributes_003Eb__2);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
							{
								num4 = 3;
							}
							break;
						default:
							_003C_003Ec__DisplayClass6_.attr = d.Constructor.Invoke(d.ConstructorArguments.Select((CustomAttributeTypedArgument a) => a.Value).ToArray());
							num4 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
							{
								num4 = 2;
							}
							break;
						}
					}
				}).ToArray());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				array2 = array;
				break;
			}
			break;
		}
		return array2;
	}

	public bool IsDefined(Type attributeType, bool inherit, Type baseType = null)
	{
		return IsDefined(GetCustomAttributesData(), attributeType, inherit, baseType, null);
	}

	public object[] GetCustomAttributes(bool inherit, Type baseType = null)
	{
		return GetCustomAttributes(TypeOf<object>.Raw, inherit, baseType);
	}

	public object[] GetCustomAttributes(Type attributeType, bool inherit, Type baseType = null)
	{
		//Discarded unreachable code: IL_00a8, IL_00b7
		int num = 7;
		int num2 = num;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		object[] array = default(object[]);
		List<object> list = default(List<object>);
		while (true)
		{
			switch (num2)
			{
			case 8:
				if (baseType != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 4:
				if (!inherit)
				{
					num2 = 10;
					break;
				}
				goto case 8;
			case 9:
				_003C_003Ec__DisplayClass9_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 5;
				}
				break;
			case 2:
				return array;
			case 6:
				_003C_003Ec__DisplayClass9_.attributeType = attributeType;
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 9;
				}
				break;
			case 5:
				list = GetCustomAttributes().Where(_003C_003Ec__DisplayClass9_._003CGetCustomAttributes_003Eb__0).ToList();
				num2 = 4;
				break;
			case 1:
			case 10:
				array = (object[])EJBbwxhVl4MUbo4126kx(_003C_003Ec__DisplayClass9_.attributeType, list.Count);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				list.AddRange(baseType.GetCustomAttributes(_003C_003Ec__DisplayClass9_.attributeType, inherit: true).Where(_003C_003Ec__DisplayClass9_._003CGetCustomAttributes_003Eb__1));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				dTFxpLhVrM9aYSdTqbid(list, array);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
				num2 = 6;
				break;
			}
		}
	}

	private static bool IsDefined(IList<CustomAttributeData> customAttributesData, Type attributeType, bool inherit, Type baseType, Func<Type, bool> check)
	{
		_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass10_0();
		CS_0024_003C_003E8__locals0.attributeType = attributeType;
		CS_0024_003C_003E8__locals0.check = check;
		if (!customAttributesData.Any(delegate(CustomAttributeData d)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					Func<Type, bool> check2 = CS_0024_003C_003E8__locals0.check;
					if (check2 != null)
					{
						return check2(_003C_003Ec__DisplayClass10_0.jjdLG1vFtqBLWopF6Ebs(d));
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 0;
					}
					break;
				}
				case 2:
					if (!CS_0024_003C_003E8__locals0.attributeType.IsAssignableFrom(_003C_003Ec__DisplayClass10_0.jjdLG1vFtqBLWopF6Ebs(d)))
					{
						return false;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return true;
				}
			}
		}))
		{
			if (inherit && baseType != null)
			{
				return IsDefined(baseType.GetCustomAttributesData(), CS_0024_003C_003E8__locals0.attributeType, inherit: true, baseType.BaseType, (Type t) => CheckAttributeType(t, null));
			}
			return false;
		}
		return true;
	}

	private static bool CheckAttributeType(Type attributeType, IList<CustomAttributeData> customAttributesData)
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals0.attributeType = attributeType;
		AttributeUsageAttribute attribute = AttributeHelper<AttributeUsageAttribute>.GetAttribute(CS_0024_003C_003E8__locals0.attributeType, inherited: true);
		if (attribute == null || attribute.Inherited)
		{
			if (!attribute.AllowMultiple && customAttributesData != null)
			{
				return customAttributesData.All((CustomAttributeData d) => _003C_003Ec__DisplayClass11_0.MPJRn7vFAZiKUfH1nK9m(d.AttributeType, CS_0024_003C_003E8__locals0.attributeType));
			}
			return true;
		}
		return false;
	}

	internal static bool XB9A8JhV9hNICcixrx25()
	{
		return ahLwpvhVJbFhKNuiMfDM == null;
	}

	internal static CustomAttributesData R10xBbhVdY5umn3QNK3H()
	{
		return ahLwpvhVJbFhKNuiMfDM;
	}

	internal static object EJBbwxhVl4MUbo4126kx(Type P_0, int P_1)
	{
		return Array.CreateInstance(P_0, P_1);
	}

	internal static void dTFxpLhVrM9aYSdTqbid(object P_0, object P_1)
	{
		((List<object>)P_0).CopyTo((object[])P_1);
	}
}
