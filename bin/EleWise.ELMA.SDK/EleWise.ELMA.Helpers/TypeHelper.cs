using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public class TypeHelper
{
	private static AssemblyBuilder asmBuilder;

	private static ModuleBuilder modBuilder;

	private static IDictionary<string, Type> anonymousTypes;

	private static object _syncLock;

	internal static TypeHelper KF07oOhzL6vYV5ch3u91;

	public static object MergeTypes(object values1, object values2)
	{
		//Discarded unreachable code: IL_0070, IL_00b3, IL_01b8, IL_01e7, IL_0206, IL_0215, IL_0242, IL_0251
		int num = 2;
		int num2 = num;
		object result = default(object);
		bool lockTaken = default(bool);
		object syncLock = default(object);
		Type value = default(Type);
		string text = default(string);
		PropertyDescriptor[] properties = default(PropertyDescriptor[]);
		object obj = default(object);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return result;
			case 1:
				lockTaken = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				syncLock = _syncLock;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 1;
				}
				continue;
			}
			try
			{
				Monitor.Enter(syncLock, ref lockTaken);
				int num3 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 6:
						return result;
					case 8:
						return result;
					case 5:
						value = VmgacVhzzSRxRrBg19Zk(text, properties);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num3 = 0;
						}
						break;
					case 1:
						text = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C95D550), values1.GetType().AssemblyQualifiedName, values2.GetType().AssemblyQualifiedName);
						num3 = 2;
						break;
					case 9:
						result = iOCYwIGFFFMkSbNl61h4(text, values1, values2);
						num3 = 8;
						break;
					case 4:
					case 10:
						properties = GetProperties(values1, values2);
						num3 = 3;
						break;
					case 2:
						obj = CreateInstance(text, values1, values2);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num3 = 7;
						}
						break;
					case 7:
						if (obj == null)
						{
							num3 = 10;
							break;
						}
						goto case 11;
					default:
						anonymousTypes.Add(text, value);
						num3 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num3 = 1;
						}
						break;
					case 11:
						result = obj;
						num3 = 6;
						break;
					case 3:
						jh4SiThzcs2NL2GUkFlO();
						num3 = 5;
						break;
					}
				}
			}
			finally
			{
				int num4;
				if (!lockTaken)
				{
					num4 = 2;
					goto IL_01eb;
				}
				goto IL_0220;
				IL_01eb:
				switch (num4)
				{
				case 2:
					goto end_IL_01d6;
				case 1:
					goto end_IL_01d6;
				}
				goto IL_0220;
				IL_0220:
				AJgQtIGFBbjnXgEyuUnk(syncLock);
				num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num4 = 1;
				}
				goto IL_01eb;
				end_IL_01d6:;
			}
		}
	}

	private static object CreateInstance(object name, object values1, object values2)
	{
		//Discarded unreachable code: IL_0054, IL_0063, IL_0092, IL_0113, IL_0122, IL_0143, IL_0225, IL_0234
		int num = 10;
		object result = default(object);
		object syncLock = default(object);
		bool lockTaken = default(bool);
		Type type = default(Type);
		object[] array = default(object[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
				case 6:
					return result;
				case 11:
					try
					{
						Monitor.Enter(syncLock, ref lockTaken);
						int num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								return result;
							case 0:
								return result;
							case 1:
								anonymousTypes.Remove((string)name);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
								{
									num3 = 0;
								}
								break;
							}
						}
					}
					finally
					{
						int num4;
						if (!lockTaken)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
							{
								num4 = 0;
							}
							goto IL_00f8;
						}
						goto IL_012d;
						IL_012d:
						AJgQtIGFBbjnXgEyuUnk(syncLock);
						int num5 = 2;
						num4 = num5;
						goto IL_00f8;
						IL_00f8:
						switch (num4)
						{
						default:
							goto end_IL_00d3;
						case 0:
							goto end_IL_00d3;
						case 1:
							break;
						case 2:
							goto end_IL_00d3;
						}
						goto IL_012d;
						end_IL_00d3:;
					}
				case 3:
					if (!f5R1BZGFopyRT0PQIIG4(type, null))
					{
						num2 = 7;
						continue;
					}
					goto default;
				case 8:
					array = (object[])rWxxakGFWRAZsdUYVoBj(values1, values2);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 5;
					}
					continue;
				case 5:
					type = anonymousTypes[(string)name];
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 3;
					}
					continue;
				case 10:
					result = null;
					num2 = 9;
					continue;
				default:
					result = l3XsrmGFbdSyhiTfojIZ(type, array);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					lockTaken = false;
					num = 11;
					break;
				case 9:
					if (anonymousTypes.ContainsKey((string)name))
					{
						num2 = 8;
						continue;
					}
					goto case 4;
				case 1:
				case 7:
					syncLock = _syncLock;
					num = 2;
					break;
				}
				break;
			}
		}
	}

	private static PropertyDescriptor[] GetProperties(object values1, object values2)
	{
		//Discarded unreachable code: IL_0094, IL_00a3, IL_00c5, IL_00d4, IL_0123, IL_0132
		int num = 9;
		int num2 = num;
		List<PropertyDescriptor> list = default(List<PropertyDescriptor>);
		PropertyDescriptorCollection propertyDescriptorCollection2 = default(PropertyDescriptorCollection);
		int num3 = default(int);
		int num4 = default(int);
		PropertyDescriptorCollection propertyDescriptorCollection = default(PropertyDescriptorCollection);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 4:
				list.Add(propertyDescriptorCollection2[num3]);
				num2 = 5;
				break;
			default:
				num4 = 0;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 5;
				}
				break;
			case 8:
				propertyDescriptorCollection2 = (PropertyDescriptorCollection)QgCswlGFhdRLb4AT0NY9(values1);
				num2 = 3;
				break;
			case 11:
				num3 = 0;
				num2 = 10;
				break;
			case 10:
			case 12:
				if (num3 < propertyDescriptorCollection2.Count)
				{
					num2 = 2;
					break;
				}
				goto default;
			case 6:
				list.Add((PropertyDescriptor)HEEJV9GFGCn8Iwl7fH2a(propertyDescriptorCollection, num4));
				num2 = 13;
				break;
			case 1:
			case 7:
				if (num4 >= skoVDtGFEt9bn2F7fMYm(propertyDescriptorCollection))
				{
					num2 = 14;
					break;
				}
				goto case 6;
			case 9:
				list = new List<PropertyDescriptor>();
				num2 = 8;
				break;
			case 14:
				return (PropertyDescriptor[])S9h2YtGFfhQAl31Q9ujr(list);
			case 13:
				num4++;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				num3++;
				num2 = 12;
				break;
			case 3:
				propertyDescriptorCollection = (PropertyDescriptorCollection)QgCswlGFhdRLb4AT0NY9(values2);
				num2 = 11;
				break;
			}
		}
	}

	private static Type[] GetTypes(object pdc)
	{
		//Discarded unreachable code: IL_0072, IL_00e4, IL_00f3
		int num = 2;
		int num2 = num;
		int num3 = default(int);
		List<Type> list = default(List<Type>);
		while (true)
		{
			switch (num2)
			{
			default:
				if (num3 < ((Array)pdc).Length)
				{
					num2 = 5;
					continue;
				}
				break;
			case 1:
				num3 = 0;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 2;
				}
				continue;
			case 6:
				num3++;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
			case 5:
				list.Add(TDyS4UGFQ0K4PV0r2XhU(((object[])pdc)[num3]));
				num2 = 6;
				continue;
			case 2:
				list = new List<Type>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 1;
				}
				continue;
			case 7:
				break;
			}
			break;
		}
		return (Type[])GUZFJgGFC48gs22q4tFh(list);
	}

	private static object[] MergeValues(object values1, object values2)
	{
		//Discarded unreachable code: IL_006d, IL_018b
		int num = 1;
		int num4 = default(int);
		PropertyDescriptorCollection propertyDescriptorCollection = default(PropertyDescriptorCollection);
		int num3 = default(int);
		PropertyDescriptorCollection propertyDescriptorCollection2 = default(PropertyDescriptorCollection);
		List<object> list = default(List<object>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					num4++;
					num = 13;
					break;
				case 10:
				case 13:
					if (num4 >= skoVDtGFEt9bn2F7fMYm(propertyDescriptorCollection))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 3;
				case 9:
					num3++;
					num = 6;
					break;
				default:
					propertyDescriptorCollection2 = (PropertyDescriptorCollection)QgCswlGFhdRLb4AT0NY9(values2);
					num2 = 12;
					continue;
				case 5:
					list.Add(aMyu7EGFvadIEm859v3p(propertyDescriptorCollection2[num3], values2));
					num2 = 9;
					continue;
				case 12:
					list = new List<object>();
					num2 = 11;
					continue;
				case 11:
					num4 = 0;
					num2 = 10;
					continue;
				case 3:
					list.Add(aMyu7EGFvadIEm859v3p(HEEJV9GFGCn8Iwl7fH2a(propertyDescriptorCollection, num4), values1));
					num2 = 8;
					continue;
				case 4:
				case 6:
					if (num3 >= propertyDescriptorCollection2.Count)
					{
						num2 = 7;
						continue;
					}
					goto case 5;
				case 7:
					return list.ToArray();
				case 1:
					propertyDescriptorCollection = (PropertyDescriptorCollection)QgCswlGFhdRLb4AT0NY9(values1);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					num3 = 0;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
		}
	}

	private static void InitializeAssembly()
	{
		//Discarded unreachable code: IL_0079, IL_0088
		int num = 4;
		int num2 = num;
		AssemblyName assemblyName = default(AssemblyName);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				return;
			case 4:
				if (!TbueKUGF8jyn0HVDNmYC(asmBuilder, null))
				{
					num2 = 3;
					break;
				}
				goto case 1;
			case 1:
				assemblyName = new AssemblyName();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 3;
				}
				break;
			case 5:
				assemblyName.Name = (string)NAnPjYGFZpExwlj2xNOy(0x57A5235E ^ 0x57A69054);
				num2 = 2;
				break;
			case 6:
				modBuilder = (ModuleBuilder)uGqs1TGFIfG4ANe0Pntq(asmBuilder, asmBuilder.GetName().Name, false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				asmBuilder = ((AppDomain)iH5OofGFuIX1I6iyHGWV()).DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
				num2 = 6;
				break;
			}
		}
	}

	private static Type CreateType(object name, object pdc)
	{
		TypeBuilder typeBuilder = CreateTypeBuilder(name);
		Type[] types = GetTypes(pdc);
		FieldBuilder[] array = (FieldBuilder[])sM3Zi7GFVuudTC6GpO0A(typeBuilder, pdc);
		BuildCtor(typeBuilder, array, types);
		fmAy1TGFSTfcDv6IeXKN(typeBuilder, array);
		return typeBuilder.CreateType();
	}

	private static TypeBuilder CreateTypeBuilder(object typeName)
	{
		return modBuilder.DefineType((string)typeName, TypeAttributes.Public, S42anWGFiZBRb01ImpGR(typeof(object).TypeHandle));
	}

	private static void BuildCtor(object typeBuilder, object fields, object types)
	{
		//Discarded unreachable code: IL_010f, IL_0158, IL_0167
		int num = 1;
		int num2 = num;
		ILGenerator iLGenerator = default(ILGenerator);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 8:
				iLGenerator.Emit(OpCodes.Ldarg_0);
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 7;
				}
				break;
			case 1:
				iLGenerator = (ILGenerator)zKh0oNGFqSU2GPghw7ne(h8QHWeGFRrg4K4oDROal(typeBuilder, MethodAttributes.Public, CallingConventions.Standard, types));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				tqq5g9GFX8u4ljxyBBkY(iLGenerator, OpCodes.Stfld, ((object[])fields)[num3]);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				return;
			case 6:
			case 10:
				if (num3 < ((Array)fields).Length)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 4;
			default:
				num3 = 0;
				num2 = 6;
				break;
			case 4:
				HdGXWnGFTp7Nj2a2ebli(iLGenerator, OpCodes.Ret);
				num2 = 7;
				break;
			case 3:
				num3++;
				num2 = 10;
				break;
			case 9:
				JYAg9lGFK3Pake0AiEmy(iLGenerator, OpCodes.Ldarg, num3 + 1);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	private static FieldBuilder[] BuildFields(object typeBuilder, object pdc)
	{
		//Discarded unreachable code: IL_004d, IL_005c, IL_0102, IL_0111
		int num = 6;
		int num2 = num;
		List<FieldBuilder> list = default(List<FieldBuilder>);
		FieldBuilder item = default(FieldBuilder);
		int num3 = default(int);
		PropertyDescriptor propertyDescriptor = default(PropertyDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 7:
				list.Add(item);
				num2 = 10;
				break;
			case 10:
				num3++;
				num2 = 8;
				break;
			case 1:
				item = (FieldBuilder)gc70uvGFnEx60yacllb3(typeBuilder, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317778334), v9wUF3GFkqphlWJHvHGx(propertyDescriptor)), propertyDescriptor.PropertyType, FieldAttributes.Private);
				num2 = 2;
				break;
			case 3:
			case 9:
				propertyDescriptor = (PropertyDescriptor)((object[])pdc)[num3];
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				num3 = 0;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return (FieldBuilder[])F5SgxJGFOCXHlRyWui6N(list);
			case 6:
				list = new List<FieldBuilder>();
				num2 = 5;
				break;
			default:
				if (num3 < ((Array)pdc).Length)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 4;
			case 2:
				if (!list.Contains(item))
				{
					num2 = 7;
					break;
				}
				goto case 10;
			}
		}
	}

	private static void BuildProperties(object typeBuilder, object fields)
	{
		//Discarded unreachable code: IL_00aa, IL_0168, IL_0177
		int num = 1;
		int num3 = default(int);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					num3++;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 3;
					}
					continue;
				case 6:
					return;
				case 1:
					num3 = 0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
				case 7:
					text = (string)oUvM2iGFe5bg8b3dsUxX(LtfXarGF24LryskKRebh(((object[])fields)[num3]), 1);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 2;
					}
					continue;
				default:
					if (num3 >= ((Array)fields).Length)
					{
						return;
					}
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
					break;
				}
				break;
			}
			PropertyBuilder propertyBuilder = ((TypeBuilder)typeBuilder).DefineProperty(text, PropertyAttributes.None, SMnEoZGFPnS527gH7ILt(((object[])fields)[num3]), (Type[])null);
			MethodBuilder methodBuilder = (MethodBuilder)RehnxJGFNPrZ9yF5LIcF(typeBuilder, K7SZ0QGF1lqYIfuC1kfQ(NAnPjYGFZpExwlj2xNOy(0x7E6E5A0B ^ 0x7E6DE931), text), MethodAttributes.Public, ((FieldInfo)((object[])fields)[num3]).FieldType, Type.EmptyTypes);
			ILGenerator iLGenerator = methodBuilder.GetILGenerator();
			HdGXWnGFTp7Nj2a2ebli(iLGenerator, OpCodes.Ldarg_0);
			tqq5g9GFX8u4ljxyBBkY(iLGenerator, OpCodes.Ldfld, ((object[])fields)[num3]);
			HdGXWnGFTp7Nj2a2ebli(iLGenerator, OpCodes.Ret);
			XOceIBGF36ZyJUxU3w8o(propertyBuilder, methodBuilder);
			num = 5;
		}
	}

	public static T GetDefault<T>()
	{
		return (T)GetDefault(typeof(T));
	}

	public static object GetDefault(Type type)
	{
		//Discarded unreachable code: IL_0129, IL_014f, IL_0162, IL_018f, IL_01c2, IL_024a
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					if (type.IsNotPublic)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 6:
					throw new ArgumentException((string)eyZEQ1GFanmffEV3yiPm(new object[5]
					{
						NAnPjYGFZpExwlj2xNOy(0x61EC0CB8 ^ 0x61EC0744),
						MethodBase.GetCurrentMethod(),
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EFA673),
						type,
						NAnPjYGFZpExwlj2xNOy(-1824388195 ^ -1824409589)
					}));
				case 10:
					if (!type.IsValueType)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 11;
				case 11:
					if (!KIrXufGFpixQCaHnjHRE(type, S42anWGFiZBRb01ImpGR(typeof(void).TypeHandle)))
					{
						if (!type.ContainsGenericParameters)
						{
							if (!type.IsPrimitive)
							{
								num2 = 9;
								continue;
							}
							break;
						}
						num2 = 6;
						continue;
					}
					goto end_IL_0012;
				default:
					return null;
				case 5:
					try
					{
						object obj = b2qGpIGFDWgCl634Bcx2(type);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => obj, 
							_ => obj, 
						};
					}
					catch (Exception ex)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						default:
							throw new ArgumentException((string)eyZEQ1GFanmffEV3yiPm(new object[7]
							{
								NAnPjYGFZpExwlj2xNOy(-345420348 ^ -345422280),
								Gv4JttGFtQuNnN9hT3VX(),
								NAnPjYGFZpExwlj2xNOy(0x48A7E34A ^ 0x48A45762),
								type,
								NAnPjYGFZpExwlj2xNOy(-541731959 ^ -541694335),
								B8xJY1GFwwv03uNBKIPF(ex),
								NAnPjYGFZpExwlj2xNOy(-70007027 ^ -70225333)
							}), ex);
						}
					}
				case 3:
				case 7:
					throw new ArgumentException((string)eyZEQ1GFanmffEV3yiPm(new object[5]
					{
						NAnPjYGFZpExwlj2xNOy(0x3630F361 ^ 0x3630F89D),
						Gv4JttGFtQuNnN9hT3VX(),
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108804740),
						type,
						NAnPjYGFZpExwlj2xNOy(-1487388570 ^ -1487145688)
					}));
				case 1:
					if (KIrXufGFpixQCaHnjHRE(type, null))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 10;
				case 8:
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 5;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public static bool HasProperty(Type type, string name)
	{
		return dy20bBGF4oJflWxba2Gu(type.GetReflectionProperty(name), null);
	}

	public TypeHelper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		JhQq56GF6iU5guYn5SWS();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static TypeHelper()
	{
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				_syncLock = new object();
				num2 = 2;
				break;
			default:
				anonymousTypes = new Dictionary<string, Type>();
				num2 = 3;
				break;
			case 1:
				modBuilder = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 4:
				asmBuilder = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				JhQq56GF6iU5guYn5SWS();
				num2 = 4;
				break;
			}
		}
	}

	internal static void jh4SiThzcs2NL2GUkFlO()
	{
		InitializeAssembly();
	}

	internal static Type VmgacVhzzSRxRrBg19Zk(object P_0, object P_1)
	{
		return CreateType(P_0, P_1);
	}

	internal static object iOCYwIGFFFMkSbNl61h4(object P_0, object P_1, object P_2)
	{
		return CreateInstance(P_0, P_1, P_2);
	}

	internal static void AJgQtIGFBbjnXgEyuUnk(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool DW9UvGhzUQEU2lUcwvS4()
	{
		return KF07oOhzL6vYV5ch3u91 == null;
	}

	internal static TypeHelper TjSYNmhzseqZcfA4Ef0D()
	{
		return KF07oOhzL6vYV5ch3u91;
	}

	internal static object rWxxakGFWRAZsdUYVoBj(object P_0, object P_1)
	{
		return MergeValues(P_0, P_1);
	}

	internal static bool f5R1BZGFopyRT0PQIIG4(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object l3XsrmGFbdSyhiTfojIZ(Type P_0, object P_1)
	{
		return Activator.CreateInstance(P_0, (object[])P_1);
	}

	internal static object QgCswlGFhdRLb4AT0NY9(object P_0)
	{
		return TypeDescriptor.GetProperties(P_0);
	}

	internal static object HEEJV9GFGCn8Iwl7fH2a(object P_0, int P_1)
	{
		return ((PropertyDescriptorCollection)P_0)[P_1];
	}

	internal static int skoVDtGFEt9bn2F7fMYm(object P_0)
	{
		return ((PropertyDescriptorCollection)P_0).Count;
	}

	internal static object S9h2YtGFfhQAl31Q9ujr(object P_0)
	{
		return ((List<PropertyDescriptor>)P_0).ToArray();
	}

	internal static Type TDyS4UGFQ0K4PV0r2XhU(object P_0)
	{
		return ((PropertyDescriptor)P_0).PropertyType;
	}

	internal static object GUZFJgGFC48gs22q4tFh(object P_0)
	{
		return ((List<Type>)P_0).ToArray();
	}

	internal static object aMyu7EGFvadIEm859v3p(object P_0, object P_1)
	{
		return ((PropertyDescriptor)P_0).GetValue(P_1);
	}

	internal static bool TbueKUGF8jyn0HVDNmYC(object P_0, object P_1)
	{
		return (Assembly)P_0 == (Assembly)P_1;
	}

	internal static object NAnPjYGFZpExwlj2xNOy(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object iH5OofGFuIX1I6iyHGWV()
	{
		return Thread.GetDomain();
	}

	internal static object uGqs1TGFIfG4ANe0Pntq(object P_0, object P_1, bool P_2)
	{
		return ((AssemblyBuilder)P_0).DefineDynamicModule((string)P_1, P_2);
	}

	internal static object sM3Zi7GFVuudTC6GpO0A(object P_0, object P_1)
	{
		return BuildFields(P_0, P_1);
	}

	internal static void fmAy1TGFSTfcDv6IeXKN(object P_0, object P_1)
	{
		BuildProperties(P_0, P_1);
	}

	internal static Type S42anWGFiZBRb01ImpGR(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object h8QHWeGFRrg4K4oDROal(object P_0, MethodAttributes P_1, CallingConventions P_2, object P_3)
	{
		return ((TypeBuilder)P_0).DefineConstructor(P_1, P_2, (Type[])P_3);
	}

	internal static object zKh0oNGFqSU2GPghw7ne(object P_0)
	{
		return ((ConstructorBuilder)P_0).GetILGenerator();
	}

	internal static void JYAg9lGFK3Pake0AiEmy(object P_0, OpCode P_1, int P_2)
	{
		((ILGenerator)P_0).Emit(P_1, P_2);
	}

	internal static void tqq5g9GFX8u4ljxyBBkY(object P_0, OpCode P_1, object P_2)
	{
		((ILGenerator)P_0).Emit(P_1, (FieldInfo)P_2);
	}

	internal static void HdGXWnGFTp7Nj2a2ebli(object P_0, OpCode P_1)
	{
		((ILGenerator)P_0).Emit(P_1);
	}

	internal static object v9wUF3GFkqphlWJHvHGx(object P_0)
	{
		return ((MemberDescriptor)P_0).Name;
	}

	internal static object gc70uvGFnEx60yacllb3(object P_0, object P_1, Type P_2, FieldAttributes P_3)
	{
		return ((TypeBuilder)P_0).DefineField((string)P_1, P_2, P_3);
	}

	internal static object F5SgxJGFOCXHlRyWui6N(object P_0)
	{
		return ((List<FieldBuilder>)P_0).ToArray();
	}

	internal static object LtfXarGF24LryskKRebh(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object oUvM2iGFe5bg8b3dsUxX(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static Type SMnEoZGFPnS527gH7ILt(object P_0)
	{
		return ((FieldInfo)P_0).FieldType;
	}

	internal static object K7SZ0QGF1lqYIfuC1kfQ(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object RehnxJGFNPrZ9yF5LIcF(object P_0, object P_1, MethodAttributes P_2, Type P_3, object P_4)
	{
		return ((TypeBuilder)P_0).DefineMethod((string)P_1, P_2, P_3, (Type[])P_4);
	}

	internal static void XOceIBGF36ZyJUxU3w8o(object P_0, object P_1)
	{
		((PropertyBuilder)P_0).SetGetMethod((MethodBuilder)P_1);
	}

	internal static bool KIrXufGFpixQCaHnjHRE(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object eyZEQ1GFanmffEV3yiPm(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static object b2qGpIGFDWgCl634Bcx2(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static object Gv4JttGFtQuNnN9hT3VX()
	{
		return MethodBase.GetCurrentMethod();
	}

	internal static object B8xJY1GFwwv03uNBKIPF(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static bool dy20bBGF4oJflWxba2Gu(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static void JhQq56GF6iU5guYn5SWS()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
