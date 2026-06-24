using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace System.Linq.Dynamic;

internal class ClassFactory
{
	public static readonly ClassFactory Instance;

	private ModuleBuilder module;

	private Dictionary<Signature, Type> classes;

	private int classCount;

	private ReaderWriterLock rwLock;

	private static ClassFactory YOOd0shF3xyoGr3Y7lu;

	static ClassFactory()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				Instance = new ClassFactory();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private ClassFactory()
	{
		//Discarded unreachable code: IL_002a
		IZnlaZhoMOxX59Gn69w();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
		{
			num = 1;
		}
		AssemblyBuilder assemblyBuilder = default(AssemblyBuilder);
		AssemblyName assemblyName = default(AssemblyName);
		while (true)
		{
			switch (num)
			{
			default:
				assemblyBuilder = (AssemblyBuilder)uZZOlFhhQDfcpPF1p6A(cEqanehbvabFRsMiCyA(), assemblyName, AssemblyBuilderAccess.Run);
				num = 5;
				break;
			case 3:
			{
				rwLock = new ReaderWriterLock();
				int num2 = 2;
				num = num2;
				break;
			}
			case 5:
				module = (ModuleBuilder)gn7J6lhEmCiPeHpgayW(assemblyBuilder, CdGS9ohGH1euuchedQe(0x48A7E34A ^ 0x48A7EF04));
				num = 4;
				break;
			case 1:
				assemblyName = new AssemblyName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633517445));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num = 0;
				}
				break;
			case 4:
				classes = new Dictionary<Signature, Type>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num = 3;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public Type GetDynamicClass(IEnumerable<DynamicProperty> properties)
	{
		rwLock.AcquireReaderLock(-1);
		try
		{
			Signature signature = new Signature(properties);
			if (!classes.TryGetValue(signature, out var value))
			{
				value = CreateDynamicClass(signature.properties);
				classes.Add(signature, value);
			}
			return value;
		}
		finally
		{
			rwLock.ReleaseReaderLock();
		}
	}

	private Type CreateDynamicClass(DynamicProperty[] properties)
	{
		//Discarded unreachable code: IL_0067, IL_014b, IL_015e, IL_016d
		int num = 2;
		int num2 = num;
		FieldInfo[] fields = default(FieldInfo[]);
		TypeBuilder typeBuilder = default(TypeBuilder);
		Type result = default(Type);
		LockCookie lockCookie = default(LockCookie);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					string text = (string)pUC3p2hQFOSS15iIxjW(CdGS9ohGH1euuchedQe(-606654180 ^ -606651070), classCount + 1);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 5:
							fields = GenerateProperties(typeBuilder, properties);
							num3 = 4;
							break;
						default:
							typeBuilder = (TypeBuilder)Bs1yOlhvZxSc6YMvSxR(module, text, TypeAttributes.Public, NRYT8AhCZyPuPfSwSGn(typeof(DynamicClass).TypeHandle));
							num3 = 5;
							break;
						case 2:
							GenerateGetHashCode(typeBuilder, fields);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
							{
								num3 = 1;
							}
							break;
						case 4:
							GenerateEquals(typeBuilder, fields);
							num3 = 2;
							break;
						case 1:
						{
							Type type = NWmmQTh8Ooj2lwKEMEw(typeBuilder);
							classCount++;
							result = type;
							num3 = 3;
							break;
						}
						case 3:
							return result;
						}
					}
				}
				finally
				{
					rwLock.DowngradeFromWriterLock(ref lockCookie);
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
			case 2:
				lockCookie = evTqpxhflBOFQNPOhH9(rwLock, -1);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return result;
			}
		}
	}

	private FieldInfo[] GenerateProperties(TypeBuilder tb, DynamicProperty[] properties)
	{
		//Discarded unreachable code: IL_01ef, IL_01fe, IL_0257, IL_0266
		int num = 1;
		FieldBuilder fieldBuilder = default(FieldBuilder);
		DynamicProperty dynamicProperty = default(DynamicProperty);
		MethodBuilder methodBuilder2 = default(MethodBuilder);
		PropertyBuilder propertyBuilder = default(PropertyBuilder);
		FieldInfo[] array = default(FieldInfo[]);
		MethodBuilder methodBuilder = default(MethodBuilder);
		FieldInfo[] array2 = default(FieldInfo[]);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					fieldBuilder = (FieldBuilder)SQgiHDhVbHC7Tch2aXg(tb, FExVJshuJnn7pMcwXLq(CdGS9ohGH1euuchedQe(0x6A81B9B4 ^ 0x6A81B5CE), BhZ0iuhZnTBlKgunFmt(dynamicProperty)), dB6RxOhIuKesMW6TrZJ(dynamicProperty), FieldAttributes.Private);
					num = 8;
					break;
				case 9:
					methodBuilder2 = (MethodBuilder)uVs3shhSOZxYP1oWfhf(tb, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475860875) + (string)BhZ0iuhZnTBlKgunFmt(dynamicProperty), MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName, null, new Type[1] { dB6RxOhIuKesMW6TrZJ(dynamicProperty) });
					num2 = 6;
					continue;
				case 8:
					propertyBuilder = tb.DefineProperty((string)BhZ0iuhZnTBlKgunFmt(dynamicProperty), PropertyAttributes.HasDefault, dynamicProperty.Type, null);
					num2 = 7;
					continue;
				case 6:
				{
					object obj2 = hJbjBqhiM2PKu48rLEX(methodBuilder2);
					((ILGenerator)obj2).Emit(OpCodes.Ldarg_0);
					((ILGenerator)obj2).Emit(OpCodes.Ldarg_1);
					wOI7QIhq3at4y3asB7D(obj2, OpCodes.Stfld, fieldBuilder);
					rCxlxNhRTQt0qnL8EQV(obj2, OpCodes.Ret);
					num2 = 15;
					continue;
				}
				case 4:
					return array;
				case 16:
					propertyBuilder.SetSetMethod(methodBuilder2);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 2;
					}
					continue;
				case 15:
					Wend0dhK8wL7vaIfFpY(propertyBuilder, methodBuilder);
					num2 = 16;
					continue;
				default:
					array = array2;
					num2 = 11;
					continue;
				case 1:
					array2 = new FieldBuilder[properties.Length];
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					num3 = 0;
					num2 = 10;
					continue;
				case 14:
					num3++;
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 10;
					}
					continue;
				case 3:
				case 12:
					dynamicProperty = properties[num3];
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 5;
					}
					continue;
				case 2:
					array[num3] = fieldBuilder;
					num2 = 14;
					continue;
				case 10:
				case 17:
					if (num3 < properties.Length)
					{
						num = 12;
						break;
					}
					goto case 4;
				case 7:
					methodBuilder = (MethodBuilder)uVs3shhSOZxYP1oWfhf(tb, FExVJshuJnn7pMcwXLq(CdGS9ohGH1euuchedQe(-1217523399 ^ -1217520199), BhZ0iuhZnTBlKgunFmt(dynamicProperty)), MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName, dB6RxOhIuKesMW6TrZJ(dynamicProperty), Type.EmptyTypes);
					num = 13;
					break;
				case 13:
				{
					object obj = hJbjBqhiM2PKu48rLEX(methodBuilder);
					rCxlxNhRTQt0qnL8EQV(obj, OpCodes.Ldarg_0);
					wOI7QIhq3at4y3asB7D(obj, OpCodes.Ldfld, fieldBuilder);
					rCxlxNhRTQt0qnL8EQV(obj, OpCodes.Ret);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 9;
					}
					continue;
				}
				}
				break;
			}
		}
	}

	private void GenerateEquals(TypeBuilder tb, FieldInfo[] fields)
	{
		//Discarded unreachable code: IL_025a, IL_04c2, IL_04d1
		int num = 20;
		ILGenerator iLGenerator = default(ILGenerator);
		Label label = default(Label);
		int num3 = default(int);
		FieldInfo[] array = default(FieldInfo[]);
		FieldInfo fieldInfo = default(FieldInfo);
		LocalBuilder localBuilder = default(LocalBuilder);
		Type type = default(Type);
		Type fieldType = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					l94FPThnKM93lwu0hpX(iLGenerator, label);
					num2 = 24;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 31;
					}
					continue;
				case 33:
					rCxlxNhRTQt0qnL8EQV(iLGenerator, OpCodes.Ret);
					num2 = 3;
					continue;
				case 9:
				case 13:
					if (num3 < array.Length)
					{
						num2 = 21;
						continue;
					}
					goto case 24;
				case 25:
					EaE74yhXdXRuJEcajW4(iLGenerator, OpCodes.Isinst, tb);
					num2 = 26;
					continue;
				case 16:
					iLGenerator.Emit(OpCodes.Ldarg_1);
					num = 25;
					break;
				case 18:
				case 21:
					fieldInfo = array[num3];
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 4;
					}
					continue;
				case 24:
					rCxlxNhRTQt0qnL8EQV(iLGenerator, OpCodes.Ldc_I4_1);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 2;
					}
					continue;
				case 19:
					localBuilder = iLGenerator.DeclareLocal(tb);
					num2 = 11;
					continue;
				case 32:
					label = KOIW6phOrYA71d7ryUI(iLGenerator);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 10;
					}
					continue;
				case 7:
					rCxlxNhRTQt0qnL8EQV(iLGenerator, OpCodes.Ret);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					wOI7QIhq3at4y3asB7D(iLGenerator, OpCodes.Ldfld, fieldInfo);
					num2 = 4;
					continue;
				case 15:
					IBF3bHhk7x2lZeigS6S(iLGenerator, OpCodes.Brtrue_S, label);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 30;
					}
					continue;
				case 29:
					IBF3bHhk7x2lZeigS6S(iLGenerator, OpCodes.Brtrue_S, label);
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 3;
					}
					continue;
				case 27:
					type = typeof(EqualityComparer<>).MakeGenericType(fieldType);
					num2 = 32;
					continue;
				case 6:
					VZje1ZhTv74FC1O4b5I(iLGenerator, OpCodes.Ldloc, localBuilder);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 15;
					}
					continue;
				case 5:
					fieldType = fieldInfo.FieldType;
					num2 = 27;
					continue;
				default:
					l94FPThnKM93lwu0hpX(iLGenerator, label);
					num2 = 12;
					continue;
				case 28:
					E6bs58h2I5H55a0jwrU(iLGenerator, OpCodes.Callvirt, type.GetMethod((string)CdGS9ohGH1euuchedQe(-889460160 ^ -889461032), new Type[2] { fieldType, fieldType }), null);
					num = 29;
					break;
				case 2:
					rCxlxNhRTQt0qnL8EQV(iLGenerator, OpCodes.Ret);
					num2 = 17;
					continue;
				case 10:
					E6bs58h2I5H55a0jwrU(iLGenerator, OpCodes.Call, type.GetMethod((string)CdGS9ohGH1euuchedQe(0x571EA399 ^ 0x571EAF31)), null);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 1;
					}
					continue;
				case 22:
					rCxlxNhRTQt0qnL8EQV(iLGenerator, OpCodes.Ldc_I4_0);
					num2 = 33;
					continue;
				case 4:
					iLGenerator.Emit(OpCodes.Ldloc, localBuilder);
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 19;
					}
					continue;
				case 1:
					num3 = 0;
					num2 = 13;
					continue;
				case 30:
					iLGenerator.Emit(OpCodes.Ldc_I4_0);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 7;
					}
					continue;
				case 14:
					iLGenerator.Emit(OpCodes.Ldarg_0);
					num = 8;
					break;
				case 23:
					wOI7QIhq3at4y3asB7D(iLGenerator, OpCodes.Ldfld, fieldInfo);
					num2 = 28;
					continue;
				case 26:
					iLGenerator.Emit(OpCodes.Stloc, localBuilder);
					num2 = 6;
					continue;
				case 31:
					num3++;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 9;
					}
					continue;
				case 20:
					iLGenerator = ((MethodBuilder)uVs3shhSOZxYP1oWfhf(tb, CdGS9ohGH1euuchedQe(0x4A1640F ^ 0x4A16897), MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig, NRYT8AhCZyPuPfSwSGn(typeof(bool).TypeHandle), new Type[1] { NRYT8AhCZyPuPfSwSGn(typeof(object).TypeHandle) })).GetILGenerator();
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 18;
					}
					continue;
				case 17:
					return;
				case 11:
					label = iLGenerator.DefineLabel();
					num2 = 16;
					continue;
				case 12:
					array = fields;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	private void GenerateGetHashCode(TypeBuilder tb, FieldInfo[] fields)
	{
		//Discarded unreachable code: IL_021c, IL_022b
		int num = 15;
		ILGenerator iLGenerator = default(ILGenerator);
		Type type = default(Type);
		Type type2 = default(Type);
		FieldInfo fieldInfo = default(FieldInfo);
		int num3 = default(int);
		FieldInfo[] array = default(FieldInfo[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					return;
				case 8:
					iLGenerator.Emit(OpCodes.Ret);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 10;
					}
					continue;
				case 16:
					E6bs58h2I5H55a0jwrU(iLGenerator, OpCodes.Callvirt, type.GetMethod((string)CdGS9ohGH1euuchedQe(0x31326106 ^ 0x31326DC4), new Type[1] { type2 }), null);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 4;
					}
					continue;
				case 12:
					iLGenerator.Emit(OpCodes.Ldfld, fieldInfo);
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 13;
					}
					continue;
				case 4:
					rCxlxNhRTQt0qnL8EQV(iLGenerator, OpCodes.Xor);
					num = 11;
					break;
				case 14:
					rCxlxNhRTQt0qnL8EQV(iLGenerator, OpCodes.Ldc_I4_0);
					num2 = 7;
					continue;
				case 15:
					iLGenerator = (ILGenerator)hJbjBqhiM2PKu48rLEX(uVs3shhSOZxYP1oWfhf(tb, CdGS9ohGH1euuchedQe(0xA592A41 ^ 0xA592683), MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig, NRYT8AhCZyPuPfSwSGn(typeof(int).TypeHandle), Type.EmptyTypes));
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 3;
					}
					continue;
				case 3:
					E6bs58h2I5H55a0jwrU(iLGenerator, OpCodes.Call, type.GetMethod((string)CdGS9ohGH1euuchedQe(0x4DC2B14D ^ 0x4DC2BDE5)), null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 2;
					}
					continue;
				case 6:
					type = typeof(EqualityComparer<>).MakeGenericType(type2);
					num = 3;
					break;
				case 11:
					num3++;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					rCxlxNhRTQt0qnL8EQV(iLGenerator, OpCodes.Ldarg_0);
					num2 = 12;
					continue;
				case 13:
					fieldInfo = array[num3];
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					num3 = 0;
					num2 = 5;
					continue;
				case 1:
					type2 = Hc3e22hecur3B2vkmKa(fieldInfo);
					num2 = 6;
					continue;
				default:
					if (num3 >= array.Length)
					{
						num2 = 8;
						continue;
					}
					goto case 13;
				case 7:
					array = fields;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static bool dC0Z5PhBlnfNT7VAoav()
	{
		return YOOd0shF3xyoGr3Y7lu == null;
	}

	internal static ClassFactory V1xs4UhW10DI2CMlY2p()
	{
		return YOOd0shF3xyoGr3Y7lu;
	}

	internal static void IZnlaZhoMOxX59Gn69w()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object cEqanehbvabFRsMiCyA()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object uZZOlFhhQDfcpPF1p6A(object P_0, object P_1, AssemblyBuilderAccess P_2)
	{
		return ((AppDomain)P_0).DefineDynamicAssembly((AssemblyName)P_1, P_2);
	}

	internal static object CdGS9ohGH1euuchedQe(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object gn7J6lhEmCiPeHpgayW(object P_0, object P_1)
	{
		return ((AssemblyBuilder)P_0).DefineDynamicModule((string)P_1);
	}

	internal static LockCookie evTqpxhflBOFQNPOhH9(object P_0, int P_1)
	{
		return ((ReaderWriterLock)P_0).UpgradeToWriterLock(P_1);
	}

	internal static object pUC3p2hQFOSS15iIxjW(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static Type NRYT8AhCZyPuPfSwSGn(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Bs1yOlhvZxSc6YMvSxR(object P_0, object P_1, TypeAttributes P_2, Type P_3)
	{
		return ((ModuleBuilder)P_0).DefineType((string)P_1, P_2, P_3);
	}

	internal static Type NWmmQTh8Ooj2lwKEMEw(object P_0)
	{
		return ((TypeBuilder)P_0).CreateType();
	}

	internal static object BhZ0iuhZnTBlKgunFmt(object P_0)
	{
		return ((DynamicProperty)P_0).Name;
	}

	internal static object FExVJshuJnn7pMcwXLq(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static Type dB6RxOhIuKesMW6TrZJ(object P_0)
	{
		return ((DynamicProperty)P_0).Type;
	}

	internal static object SQgiHDhVbHC7Tch2aXg(object P_0, object P_1, Type P_2, FieldAttributes P_3)
	{
		return ((TypeBuilder)P_0).DefineField((string)P_1, P_2, P_3);
	}

	internal static object uVs3shhSOZxYP1oWfhf(object P_0, object P_1, MethodAttributes P_2, Type P_3, object P_4)
	{
		return ((TypeBuilder)P_0).DefineMethod((string)P_1, P_2, P_3, (Type[])P_4);
	}

	internal static object hJbjBqhiM2PKu48rLEX(object P_0)
	{
		return ((MethodBuilder)P_0).GetILGenerator();
	}

	internal static void rCxlxNhRTQt0qnL8EQV(object P_0, OpCode P_1)
	{
		((ILGenerator)P_0).Emit(P_1);
	}

	internal static void wOI7QIhq3at4y3asB7D(object P_0, OpCode P_1, object P_2)
	{
		((ILGenerator)P_0).Emit(P_1, (FieldInfo)P_2);
	}

	internal static void Wend0dhK8wL7vaIfFpY(object P_0, object P_1)
	{
		((PropertyBuilder)P_0).SetGetMethod((MethodBuilder)P_1);
	}

	internal static void EaE74yhXdXRuJEcajW4(object P_0, OpCode P_1, Type P_2)
	{
		((ILGenerator)P_0).Emit(P_1, P_2);
	}

	internal static void VZje1ZhTv74FC1O4b5I(object P_0, OpCode P_1, object P_2)
	{
		((ILGenerator)P_0).Emit(P_1, (LocalBuilder)P_2);
	}

	internal static void IBF3bHhk7x2lZeigS6S(object P_0, OpCode P_1, Label P_2)
	{
		((ILGenerator)P_0).Emit(P_1, P_2);
	}

	internal static void l94FPThnKM93lwu0hpX(object P_0, Label P_1)
	{
		((ILGenerator)P_0).MarkLabel(P_1);
	}

	internal static Label KOIW6phOrYA71d7ryUI(object P_0)
	{
		return ((ILGenerator)P_0).DefineLabel();
	}

	internal static void E6bs58h2I5H55a0jwrU(object P_0, OpCode P_1, object P_2, object P_3)
	{
		((ILGenerator)P_0).EmitCall(P_1, (MethodInfo)P_2, (Type[])P_3);
	}

	internal static Type Hc3e22hecur3B2vkmKa(object P_0)
	{
		return ((FieldInfo)P_0).FieldType;
	}
}
