using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.CodeGeneration.Analyzers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Collections.Generic;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

internal static class ConfigurationModelAssemblyBuilder
{
	private class ParameterDefinitionComparer : IEqualityComparer<ParameterDefinition>
	{
		internal static object Lqpmcmv8QKAQvqpmtKbA;

		public static IEqualityComparer<ParameterDefinition> Instance { get; }

		private ParameterDefinitionComparer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			zEeg4fv88uJkL6Ey1A42();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public bool Equals(ParameterDefinition x, ParameterDefinition y)
		{
			return dUgDPMv8IYWZPWT28qgt(KU4yS6v8uFvSonWSKJ74(tmRxT2v8ZSjgpNoxdhNi(x)), KU4yS6v8uFvSonWSKJ74(tmRxT2v8ZSjgpNoxdhNi(y)));
		}

		public int GetHashCode(ParameterDefinition obj)
		{
			return ((MemberReference)tmRxT2v8ZSjgpNoxdhNi(obj)).get_FullName().GetHashCode();
		}

		static ParameterDefinitionComparer()
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
					Instance = new ParameterDefinitionComparer();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					zEeg4fv88uJkL6Ey1A42();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				}
			}
		}

		internal static void zEeg4fv88uJkL6Ey1A42()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool QOBYlYv8CPhhettUPemq()
		{
			return Lqpmcmv8QKAQvqpmtKbA == null;
		}

		internal static ParameterDefinitionComparer Cnydmfv8vlJMKjiWnXkL()
		{
			return (ParameterDefinitionComparer)Lqpmcmv8QKAQvqpmtKbA;
		}

		internal static object tmRxT2v8ZSjgpNoxdhNi(object P_0)
		{
			return ((ParameterReference)P_0).get_ParameterType();
		}

		internal static object KU4yS6v8uFvSonWSKJ74(object P_0)
		{
			return ((MemberReference)P_0).get_FullName();
		}

		internal static bool dUgDPMv8IYWZPWT28qgt(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}
	}

	private static ILogger publishLogger;

	internal const string CONFIGURAION_MODEL_DELTA_ASSEMBLY_NAME = "EleWise.ELMA.ConfigurationModel.Delta";

	internal const string DYNAMIC_MODEL_DELTA_ASSEMBLY_NAME = "EleWise.ELMA.DynamicModel.Delta";

	private static bool versionIniting;

	private static Version version;

	private static bool existDataClassTable;

	private static readonly XmlObjectSerializableType xmlObjSerType;

	private static readonly ContextVars.Local<bool> isConfigurationModelBuild;

	private static ConfigurationModelAssemblyBuilder DIZ4SUh2KcTBW3s8pYim;

	internal static bool IsConfigurationModelBuild => isConfigurationModelBuild.Value;

	internal static Version Version
	{
		get
		{
			//Discarded unreachable code: IL_0079, IL_0088
			int num = 7;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					object obj;
					switch (num2)
					{
					case 2:
					case 5:
						if (versionIniting)
						{
							num2 = 4;
							continue;
						}
						return version;
					case 1:
						versionIniting = true;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num2 = 0;
						}
						continue;
					case 7:
						if (CfvnDAh2A405sHcoT2M3(version, null))
						{
							goto end_IL_0012;
						}
						goto case 2;
					case 4:
						return null;
					case 6:
						if (versionIniting)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
							{
								num2 = 2;
							}
							continue;
						}
						goto case 1;
					case 8:
						versionIniting = false;
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num2 = 1;
						}
						continue;
					default:
					{
						object obj2 = wOxsOKh27UeOG9WlKr3l(jd6noph2kB36YcYQqbQu(-35995181 ^ -35992649), false);
						if (obj2 == null)
						{
							num2 = 3;
							continue;
						}
						obj = ((AssemblyName)o3wc2Rh2xyAJ3bXsShIj(obj2)).Version;
						break;
					}
					case 3:
						obj = null;
						break;
					}
					version = (Version)obj;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 6;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 6;
			}
		}
	}

	internal static Version CurrentVersion { get; private set; }

	internal static Version NextVersion { get; private set; }

	private static MemoryStream Merge(object assemblyRaw, object deltaAssemblyRaw, IDictionary<string, string> referencesRewrite = null)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		EntityDynamicGenerator.AssemblyResolver assemblyResolver = new EntityDynamicGenerator.AssemblyResolver();
		ReaderParameters val = new ReaderParameters();
		val.set_AssemblyResolver((IAssemblyResolver)(object)assemblyResolver);
		AssemblyDefinition obj = AssemblyDefinition.ReadAssembly((Stream)assemblyRaw, val);
		ReaderParameters val2 = new ReaderParameters();
		val2.set_AssemblyResolver((IAssemblyResolver)(object)assemblyResolver);
		AssemblyDefinition deltaAssembly = AssemblyDefinition.ReadAssembly((Stream)deltaAssemblyRaw, val2);
		ConfigurationModelAssemblyBuilder.Merge((object)obj, (object)deltaAssembly, referencesRewrite);
		MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
		obj.Write((Stream)memoryStream);
		((Stream)assemblyRaw).Seek(0L, SeekOrigin.Begin);
		((Stream)deltaAssemblyRaw).Seek(0L, SeekOrigin.Begin);
		memoryStream.Seek(0L, SeekOrigin.Begin);
		return memoryStream;
	}

	private static void Merge(object assembly, object deltaAssembly, IDictionary<string, string> referencesRewrite = null)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_00fe: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected O, but got Unknown
		//IL_052f: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected O, but got Unknown
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Expected O, but got Unknown
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected O, but got Unknown
		//IL_094f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a54: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.assembly = (AssemblyDefinition)assembly;
		CS_0024_003C_003E8__locals0.referencesRewrite = referencesRewrite;
		CS_0024_003C_003E8__locals0.module = CS_0024_003C_003E8__locals0.assembly.get_MainModule();
		CS_0024_003C_003E8__locals0.deltaModule = ((AssemblyDefinition)deltaAssembly).get_MainModule();
		CS_0024_003C_003E8__locals0.resolvedTypes = new Dictionary<TypeReference, TypeReference>();
		CS_0024_003C_003E8__locals0.resolvedMethods = new Dictionary<MethodReference, MethodReference>();
		CS_0024_003C_003E8__locals0.resolvedFields = new Dictionary<FieldReference, FieldReference>();
		CS_0024_003C_003E8__locals0.types = new List<(TypeDefinition, TypeDefinition)>();
		CS_0024_003C_003E8__locals0.newTypes = new List<(TypeDefinition, TypeDefinition)>();
		foreach (TypeDefinition item4 in ((IEnumerable<TypeDefinition>)CS_0024_003C_003E8__locals0.deltaModule.get_Types()).Where((TypeDefinition t) => _003C_003Ec.RhajJnvZ6JTS4Ws5ljsj(_003C_003Ec.iIl0ZlvZ40CLm3hEPQdy(t), "<Module>")))
		{
			TypeDefinition val = CS_0024_003C_003E8__locals0.module.GetType(((TypeReference)item4).get_Namespace(), ((MemberReference)item4).get_Name());
			if (val == null)
			{
				Collection<TypeDefinition> types = CS_0024_003C_003E8__locals0.module.get_Types();
				TypeDefinition val2 = new TypeDefinition(((TypeReference)item4).get_Namespace(), ((MemberReference)item4).get_Name(), item4.get_Attributes());
				val = val2;
				types.Add(val2);
				CS_0024_003C_003E8__locals0.newTypes.Add((val, item4));
				Enumerator<GenericParameter> enumerator2 = ((TypeReference)item4).get_GenericParameters().GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						GenericParameter current2 = enumerator2.get_Current();
						GenericParameter val3 = new GenericParameter(((MemberReference)current2).get_Name(), (IGenericParameterProvider)(object)val);
						((TypeReference)val).get_GenericParameters().Add(val3);
						val3.set_Attributes(current2.get_Attributes());
						CreateCustomAttributes(current2.get_CustomAttributes(), val3.get_CustomAttributes());
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
				}
			}
			else
			{
				Enumerator<GenericParameter> enumerator2 = ((TypeReference)item4).get_GenericParameters().GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						GenericParameter current3 = enumerator2.get_Current();
						GenericParameter val4 = ((TypeReference)val).get_GenericParameters().get_Item(current3.get_Position());
						CreateCustomAttributes(current3.get_CustomAttributes(), val4.get_CustomAttributes());
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
				}
			}
			CS_0024_003C_003E8__locals0.types.Add((val, item4));
			AddNestedTypes(val, item4);
		}
		foreach (var newType in CS_0024_003C_003E8__locals0.newTypes)
		{
			TypeDefinition item = newType.type;
			TypeDefinition item2 = newType.deltaType;
			Enumerator<GenericParameter> enumerator2 = ((TypeReference)item2).get_GenericParameters().GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					GenericParameter current5 = enumerator2.get_Current();
					GenericParameter val5 = ((TypeReference)item).get_GenericParameters().get_Item(current5.get_Position());
					Enumerator<TypeReference> enumerator4 = current5.get_Constraints().GetEnumerator();
					try
					{
						while (enumerator4.MoveNext())
						{
							TypeReference current6 = enumerator4.get_Current();
							val5.get_Constraints().Add(ResolveTypeReference(current6));
						}
					}
					finally
					{
						((IDisposable)enumerator4).Dispose();
					}
				}
			}
			finally
			{
				((IDisposable)enumerator2).Dispose();
			}
			if (item2.get_BaseType() != null)
			{
				item.set_BaseType(ResolveTypeReference(item2.get_BaseType()));
			}
		}
		List<(MethodDefinition, MethodDefinition)> list = new List<(MethodDefinition, MethodDefinition)>();
		List<(MethodDefinition, MethodDefinition)> list2 = new List<(MethodDefinition, MethodDefinition)>();
		foreach (var (val6, val7) in CS_0024_003C_003E8__locals0.types)
		{
			val6.get_Interfaces().Clear();
			((IEnumerable<TypeReference>)val7.get_Interfaces()).Select(ResolveTypeReference).ForEach((Action<TypeReference>)val6.get_Interfaces().Add);
			CreateCustomAttributes(val7.get_CustomAttributes(), val6.get_CustomAttributes());
			Enumerator<FieldDefinition> enumerator5 = val7.get_Fields().GetEnumerator();
			try
			{
				while (enumerator5.MoveNext())
				{
					_003C_003Ec__DisplayClass1_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass1_1();
					CS_0024_003C_003E8__locals1.deltaField = enumerator5.get_Current();
					FieldDefinition val8 = ((IEnumerable<FieldDefinition>)val6.get_Fields()).FirstOrDefault((FieldDefinition f) => _003C_003Ec__DisplayClass1_1.TiFAgSv8UiBNTKLVVaoU(_003C_003Ec__DisplayClass1_1.VSRqMnv8LCEAujhICsh2(f), ((MemberReference)CS_0024_003C_003E8__locals1.deltaField).get_Name()));
					if (val8 == null)
					{
						val8 = new FieldDefinition(((MemberReference)CS_0024_003C_003E8__locals1.deltaField).get_Name(), CS_0024_003C_003E8__locals1.deltaField.get_Attributes(), ResolveTypeReference(((FieldReference)CS_0024_003C_003E8__locals1.deltaField).get_FieldType()));
						val6.get_Fields().Add(val8);
					}
					CreateCustomAttributes(CS_0024_003C_003E8__locals1.deltaField.get_CustomAttributes(), val8.get_CustomAttributes());
					val8.set_Constant(CS_0024_003C_003E8__locals1.deltaField.get_Constant());
					val8.set_Offset(CS_0024_003C_003E8__locals1.deltaField.get_Offset());
				}
			}
			finally
			{
				((IDisposable)enumerator5).Dispose();
			}
			Dictionary<MethodDefinition, MethodDefinition> dictionary = new Dictionary<MethodDefinition, MethodDefinition>();
			Enumerator<MethodDefinition> enumerator6 = val7.get_Methods().GetEnumerator();
			try
			{
				while (enumerator6.MoveNext())
				{
					_003C_003Ec__DisplayClass1_2 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass1_2();
					CS_0024_003C_003E8__locals2.deltaMethod = enumerator6.get_Current();
					MethodDefinition val9 = ((IEnumerable<MethodDefinition>)val6.get_Methods()).FirstOrDefault(delegate(MethodDefinition m)
					{
						int num18 = 1;
						int num19 = num18;
						while (true)
						{
							switch (num19)
							{
							default:
								return ((IEnumerable<ParameterDefinition>)((MethodReference)m).get_Parameters()).SequenceEqual((IEnumerable<ParameterDefinition>)((MethodReference)CS_0024_003C_003E8__locals2.deltaMethod).get_Parameters(), ParameterDefinitionComparer.Instance);
							case 1:
								if (!(((MemberReference)m).get_Name() == (string)_003C_003Ec__DisplayClass1_2.asHrjDvZB3UI6wW48nMg(CS_0024_003C_003E8__locals2.deltaMethod)))
								{
									return false;
								}
								num19 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
								{
									num19 = 0;
								}
								break;
							}
						}
					});
					if (val9 == null)
					{
						Collection<MethodDefinition> methods = val6.get_Methods();
						MethodDefinition val10 = new MethodDefinition(((MemberReference)CS_0024_003C_003E8__locals2.deltaMethod).get_Name(), CS_0024_003C_003E8__locals2.deltaMethod.get_Attributes(), ResolveTypeReference(((MethodReference)CS_0024_003C_003E8__locals2.deltaMethod).get_ReturnType()));
						val9 = val10;
						methods.Add(val10);
						list2.Add((val9, CS_0024_003C_003E8__locals2.deltaMethod));
						Enumerator<GenericParameter> enumerator2 = ((MethodReference)CS_0024_003C_003E8__locals2.deltaMethod).get_GenericParameters().GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								GenericParameter current7 = enumerator2.get_Current();
								GenericParameter val11 = new GenericParameter(((MemberReference)current7).get_Name(), (IGenericParameterProvider)(object)val9);
								((MethodReference)val9).get_GenericParameters().Add(val11);
								val11.set_Attributes(current7.get_Attributes());
								CreateCustomAttributes(current7.get_CustomAttributes(), val11.get_CustomAttributes());
							}
						}
						finally
						{
							((IDisposable)enumerator2).Dispose();
						}
						enumerator2 = ((MethodReference)CS_0024_003C_003E8__locals2.deltaMethod).get_GenericParameters().GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								GenericParameter current8 = enumerator2.get_Current();
								GenericParameter val12 = ((MethodReference)val9).get_GenericParameters().get_Item(current8.get_Position());
								Enumerator<TypeReference> enumerator4 = current8.get_Constraints().GetEnumerator();
								try
								{
									while (enumerator4.MoveNext())
									{
										TypeReference current9 = enumerator4.get_Current();
										val12.get_Constraints().Add(ResolveTypeReference(current9));
									}
								}
								finally
								{
									((IDisposable)enumerator4).Dispose();
								}
							}
						}
						finally
						{
							((IDisposable)enumerator2).Dispose();
						}
						Enumerator<ParameterDefinition> enumerator7 = ((MethodReference)CS_0024_003C_003E8__locals2.deltaMethod).get_Parameters().GetEnumerator();
						try
						{
							while (enumerator7.MoveNext())
							{
								ParameterDefinition current10 = enumerator7.get_Current();
								ParameterDefinition val13 = new ParameterDefinition(((ParameterReference)current10).get_Name(), current10.get_Attributes(), ResolveTypeReference(((ParameterReference)current10).get_ParameterType()));
								((MethodReference)val9).get_Parameters().Add(val13);
								CreateCustomAttributes(current10.get_CustomAttributes(), val13.get_CustomAttributes());
							}
						}
						finally
						{
							((IDisposable)enumerator7).Dispose();
						}
						((MethodReference)val9).set_CallingConvention(((MethodReference)CS_0024_003C_003E8__locals2.deltaMethod).get_CallingConvention());
						val9.set_ImplAttributes(CS_0024_003C_003E8__locals2.deltaMethod.get_ImplAttributes());
					}
					else
					{
						Enumerator<GenericParameter> enumerator2 = ((MethodReference)CS_0024_003C_003E8__locals2.deltaMethod).get_GenericParameters().GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								GenericParameter current11 = enumerator2.get_Current();
								GenericParameter val14 = ((MethodReference)val9).get_GenericParameters().get_Item(current11.get_Position());
								CreateCustomAttributes(current11.get_CustomAttributes(), val14.get_CustomAttributes());
							}
						}
						finally
						{
							((IDisposable)enumerator2).Dispose();
						}
					}
					dictionary[CS_0024_003C_003E8__locals2.deltaMethod] = val9;
					if (val9.get_HasBody())
					{
						list.Add((val9, CS_0024_003C_003E8__locals2.deltaMethod));
					}
					CreateCustomAttributes(CS_0024_003C_003E8__locals2.deltaMethod.get_CustomAttributes(), val9.get_CustomAttributes());
				}
			}
			finally
			{
				((IDisposable)enumerator6).Dispose();
			}
			Enumerator<PropertyDefinition> enumerator8 = val7.get_Properties().GetEnumerator();
			try
			{
				while (enumerator8.MoveNext())
				{
					_003C_003Ec__DisplayClass1_3 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass1_3();
					CS_0024_003C_003E8__locals3.deltaProperty = enumerator8.get_Current();
					PropertyDefinition val15 = ((IEnumerable<PropertyDefinition>)val6.get_Properties()).FirstOrDefault((PropertyDefinition p) => _003C_003Ec__DisplayClass1_3.mboHV7vZEXRXrNcqD4GM(_003C_003Ec__DisplayClass1_3.U7qV5ovZGA5R46CEnLlE(p), _003C_003Ec__DisplayClass1_3.U7qV5ovZGA5R46CEnLlE(CS_0024_003C_003E8__locals3.deltaProperty)));
					if (val15 == null)
					{
						val15 = new PropertyDefinition(((MemberReference)CS_0024_003C_003E8__locals3.deltaProperty).get_Name(), CS_0024_003C_003E8__locals3.deltaProperty.get_Attributes(), ResolveTypeReference(((PropertyReference)CS_0024_003C_003E8__locals3.deltaProperty).get_PropertyType()));
						val6.get_Properties().Add(val15);
						val15.set_GetMethod((CS_0024_003C_003E8__locals3.deltaProperty.get_GetMethod() != null) ? dictionary[CS_0024_003C_003E8__locals3.deltaProperty.get_GetMethod()] : null);
						val15.set_SetMethod((CS_0024_003C_003E8__locals3.deltaProperty.get_SetMethod() != null) ? dictionary[CS_0024_003C_003E8__locals3.deltaProperty.get_SetMethod()] : null);
					}
					CreateCustomAttributes(CS_0024_003C_003E8__locals3.deltaProperty.get_CustomAttributes(), val15.get_CustomAttributes());
				}
			}
			finally
			{
				((IDisposable)enumerator8).Dispose();
			}
		}
		foreach (var item5 in list2)
		{
			MethodDefinition item3 = item5.Item1;
			Enumerator<MethodReference> enumerator10 = item5.Item2.get_Overrides().GetEnumerator();
			try
			{
				while (enumerator10.MoveNext())
				{
					MethodReference current13 = enumerator10.get_Current();
					item3.get_Overrides().Add(ResolveMethodReference(current13));
				}
			}
			finally
			{
				((IDisposable)enumerator10).Dispose();
			}
		}
		foreach (var (val16, val17) in list)
		{
			val16.set_Body(val17.get_Body());
			val17.set_Body((MethodBody)null);
			Enumerator<VariableDefinition> enumerator11 = val16.get_Body().get_Variables().GetEnumerator();
			try
			{
				while (enumerator11.MoveNext())
				{
					VariableDefinition current14 = enumerator11.get_Current();
					((VariableReference)current14).set_VariableType(ResolveTypeReference(((VariableReference)current14).get_VariableType()));
				}
			}
			finally
			{
				((IDisposable)enumerator11).Dispose();
			}
			Enumerator<Instruction> enumerator12 = val16.get_Body().get_Instructions().GetEnumerator();
			try
			{
				while (enumerator12.MoveNext())
				{
					Instruction current15 = enumerator12.get_Current();
					object operand = current15.get_Operand();
					if (operand == null)
					{
						continue;
					}
					ParameterDefinition val18;
					if ((val18 = (ParameterDefinition)((operand is ParameterDefinition) ? operand : null)) == null)
					{
						MethodReference val19;
						if ((val19 = (MethodReference)((operand is MethodReference) ? operand : null)) == null)
						{
							TypeReference val20;
							if ((val20 = (TypeReference)((operand is TypeReference) ? operand : null)) == null)
							{
								FieldReference val21;
								if ((val21 = (FieldReference)((operand is FieldReference) ? operand : null)) != null)
								{
									FieldReference fieldReference2 = val21;
									current15.set_Operand((object)ResolveFieldReference(fieldReference2));
								}
							}
							else
							{
								TypeReference typeReference2 = val20;
								current15.set_Operand((object)ResolveTypeReference(typeReference2));
							}
						}
						else
						{
							MethodReference methodReference2 = val19;
							current15.set_Operand((object)ResolveMethodReference(methodReference2));
						}
					}
					else
					{
						ParameterDefinition val22 = val18;
						current15.set_Operand((object)((MethodReference)val16).get_Parameters().get_Item(((ParameterReference)val22).get_Index()));
					}
				}
			}
			finally
			{
				((IDisposable)enumerator12).Dispose();
			}
		}
		HashSet<Resource> hashSet = ((IEnumerable<Resource>)((IEnumerable)CS_0024_003C_003E8__locals0.deltaModule.get_Resources()).OfType<EmbeddedResource>().Select((Func<EmbeddedResource, EmbeddedResource>)((EmbeddedResource r) => new EmbeddedResource((string)_003C_003Ec.sXER1ZvZH6GcP8IgEGpm(r), _003C_003Ec.FEmrhAvZAtPu0srl8bGI(r), (byte[])_003C_003Ec.lrHq2JvZ70ExvrSVMK4U(r))))).ToHashSet(FunctorEqualityComparer<Resource>.Create((Resource r1, Resource r2) => _003C_003Ec.BowSaGvZx0ZX0r6IegY2(_003C_003Ec.sXER1ZvZH6GcP8IgEGpm(r1), r2.get_Name()), (Resource r) => _003C_003Ec.sXER1ZvZH6GcP8IgEGpm(r).GetHashCode()));
		((ICollection<Resource>)CS_0024_003C_003E8__locals0.module.get_Resources()).RemoveAll(hashSet.Contains);
		((ICollection<Resource>)CS_0024_003C_003E8__locals0.module.get_Resources()).AddRange(hashSet);
		((AssemblyNameReference)CS_0024_003C_003E8__locals0.assembly.get_Name()).set_Version(((AssemblyNameReference)((AssemblyDefinition)deltaAssembly).get_Name()).get_Version());
		void AddNestedTypes(TypeDefinition type, TypeDefinition deltaType)
		{
			//Discarded unreachable code: IL_0056, IL_00b3, IL_0105, IL_0114, IL_0207, IL_021a, IL_02fd, IL_0446, IL_0459, IL_0468, IL_056c, IL_057f, IL_058e
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02db: Unknown result type (might be due to invalid IL or missing references)
			//IL_033e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0345: Expected O, but got Unknown
			//IL_0363: Unknown result type (might be due to invalid IL or missing references)
			//IL_0514: Unknown result type (might be due to invalid IL or missing references)
			//IL_0519: Unknown result type (might be due to invalid IL or missing references)
			//IL_051e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0521: Expected O, but got Unknown
			//IL_0526: Expected O, but got Unknown
			int num3 = 1;
			int num4 = num3;
			Enumerator<TypeDefinition> enumerator13 = default(Enumerator<TypeDefinition>);
			_003C_003Ec__DisplayClass1_4 _003C_003Ec__DisplayClass1_2 = default(_003C_003Ec__DisplayClass1_4);
			TypeDefinition val26 = default(TypeDefinition);
			Enumerator<GenericParameter> enumerator14 = default(Enumerator<GenericParameter>);
			GenericParameter current17 = default(GenericParameter);
			GenericParameter val29 = default(GenericParameter);
			GenericParameter current16 = default(GenericParameter);
			GenericParameter val27 = default(GenericParameter);
			while (true)
			{
				switch (num4)
				{
				case 2:
					return;
				case 1:
					enumerator13 = deltaType.get_NestedTypes().GetEnumerator();
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num4 = 0;
					}
					break;
				default:
					try
					{
						while (true)
						{
							int num5;
							if (!enumerator13.MoveNext())
							{
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
								{
									num5 = 1;
								}
								goto IL_0068;
							}
							goto IL_04ce;
							IL_04ce:
							_003C_003Ec__DisplayClass1_2 = new _003C_003Ec__DisplayClass1_4();
							num5 = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
							{
								num5 = 3;
							}
							goto IL_0068;
							IL_0068:
							while (true)
							{
								switch (num5)
								{
								case 1:
									return;
								case 10:
									if (val26 != null)
									{
										int num9 = 5;
										num5 = num9;
										continue;
									}
									goto case 4;
								case 9:
									enumerator14 = ((TypeReference)_003C_003Ec__DisplayClass1_2.deltaNestedType).get_GenericParameters().GetEnumerator();
									num5 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
									{
										num5 = 7;
									}
									continue;
								case 3:
									try
									{
										while (true)
										{
											IL_0187:
											int num10;
											if (!enumerator14.MoveNext())
											{
												num10 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
												{
													num10 = 0;
												}
												goto IL_0123;
											}
											goto IL_0170;
											IL_0170:
											current17 = enumerator14.get_Current();
											int num11 = 3;
											num10 = num11;
											goto IL_0123;
											IL_0123:
											while (true)
											{
												switch (num10)
												{
												case 3:
													val29 = ((TypeReference)val26).get_GenericParameters().get_Item(_003C_003Ec__DisplayClass1_0.hHXD6tv8TgjJrtSTWGm3(current17));
													num10 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
													{
														num10 = 4;
													}
													continue;
												case 2:
													break;
												default:
													goto IL_0187;
												case 4:
													CreateCustomAttributes(current17.get_CustomAttributes(), val29.get_CustomAttributes());
													num10 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
													{
														num10 = 0;
													}
													continue;
												case 1:
													goto end_IL_0187;
												}
												break;
											}
											goto IL_0170;
											continue;
											end_IL_0187:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator14).Dispose();
										int num12 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
										{
											num12 = 0;
										}
										switch (num12)
										{
										case 0:
											break;
										}
									}
									goto case 6;
								case 12:
									CS_0024_003C_003E8__locals0.newTypes.Add((val26, _003C_003Ec__DisplayClass1_2.deltaNestedType));
									num5 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
									{
										num5 = 9;
									}
									continue;
								case 8:
									AddNestedTypes(val26, _003C_003Ec__DisplayClass1_2.deltaNestedType);
									num5 = 13;
									continue;
								case 13:
									break;
								default:
									val26 = ((IEnumerable<TypeDefinition>)type.get_NestedTypes()).FirstOrDefault(_003C_003Ec__DisplayClass1_2._003CMerge_003Eb__12);
									num5 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
									{
										num5 = 10;
									}
									continue;
								case 2:
								case 5:
									enumerator14 = ((TypeReference)_003C_003Ec__DisplayClass1_2.deltaNestedType).get_GenericParameters().GetEnumerator();
									num5 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
									{
										num5 = 3;
									}
									continue;
								case 7:
									try
									{
										while (true)
										{
											IL_03f4:
											int num6;
											if (!enumerator14.MoveNext())
											{
												num6 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
												{
													num6 = 0;
												}
												goto IL_030f;
											}
											goto IL_03a3;
											IL_03a3:
											current16 = enumerator14.get_Current();
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
											{
												num6 = 0;
											}
											goto IL_030f;
											IL_030f:
											while (true)
											{
												switch (num6)
												{
												default:
													val27 = new GenericParameter((string)_003C_003Ec__DisplayClass1_0.iShDl4v8KaiMtEcvp3dj(current16), (IGenericParameterProvider)(object)val26);
													num6 = 4;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
													{
														num6 = 1;
													}
													continue;
												case 3:
												{
													_003C_003Ec__DisplayClass1_0.C3EU01v8XfHjB89bG96W(val27, current16.get_Attributes());
													int num7 = 5;
													num6 = num7;
													continue;
												}
												case 4:
													((TypeReference)val26).get_GenericParameters().Add(val27);
													num6 = 3;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
													{
														num6 = 1;
													}
													continue;
												case 6:
													break;
												case 5:
													CreateCustomAttributes(current16.get_CustomAttributes(), val27.get_CustomAttributes());
													num6 = 2;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
													{
														num6 = 0;
													}
													continue;
												case 2:
													goto IL_03f4;
												case 1:
													goto end_IL_03f4;
												}
												break;
											}
											goto IL_03a3;
											continue;
											end_IL_03f4:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator14).Dispose();
										int num8 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
										{
											num8 = 0;
										}
										switch (num8)
										{
										case 0:
											break;
										}
									}
									goto case 6;
								case 6:
									CS_0024_003C_003E8__locals0.types.Add((val26, _003C_003Ec__DisplayClass1_2.deltaNestedType));
									num5 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
									{
										num5 = 1;
									}
									continue;
								case 11:
									_003C_003Ec__DisplayClass1_2.deltaNestedType = enumerator13.get_Current();
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
									{
										num5 = 0;
									}
									continue;
								case 14:
									goto IL_04ce;
								case 4:
								{
									Collection<TypeDefinition> nestedTypes = type.get_NestedTypes();
									TypeDefinition val28 = new TypeDefinition((string)_003C_003Ec__DisplayClass1_0.vbxudSv8RRUmtBNXGFNK(_003C_003Ec__DisplayClass1_2.deltaNestedType), ((MemberReference)_003C_003Ec__DisplayClass1_2.deltaNestedType).get_Name(), _003C_003Ec__DisplayClass1_0.qfCceDv8qn3Eq7HXQi8G(_003C_003Ec__DisplayClass1_2.deltaNestedType));
									val26 = val28;
									nestedTypes.Add(val28);
									num5 = 12;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
									{
										num5 = 8;
									}
									continue;
								}
								}
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator13).Dispose();
						int num13 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num13 = 0;
						}
						switch (num13)
						{
						case 0:
							break;
						}
					}
				}
			}
		}
		CustomAttributeArgument CreateCustomAttributeArgument(CustomAttributeArgument argument)
		{
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			TypeReference obj2 = ResolveTypeReference(((CustomAttributeArgument)(ref argument)).get_Type());
			object value2 = ((CustomAttributeArgument)(ref argument)).get_Value();
			TypeReference typeReference3;
			return new CustomAttributeArgument(obj2, ((typeReference3 = (TypeReference)((value2 is TypeReference) ? value2 : null)) != null) ? ResolveTypeReference(typeReference3) : ((CustomAttributeArgument)(ref argument)).get_Value());
		}
		void CreateCustomAttributes(Collection<CustomAttribute> fromCustomAttributes, Collection<CustomAttribute> toCustomAttributes)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			toCustomAttributes.Clear();
			Enumerator<CustomAttribute> enumerator15 = fromCustomAttributes.GetEnumerator();
			try
			{
				while (enumerator15.MoveNext())
				{
					CustomAttribute current18 = enumerator15.get_Current();
					CustomAttribute val40 = new CustomAttribute(ResolveMethodReference(current18.get_Constructor()));
					toCustomAttributes.Add(val40);
					Enumerator<CustomAttributeArgument> enumerator16 = current18.get_ConstructorArguments().GetEnumerator();
					try
					{
						while (enumerator16.MoveNext())
						{
							CustomAttributeArgument current19 = enumerator16.get_Current();
							val40.get_ConstructorArguments().Add(CreateCustomAttributeArgument(current19));
						}
					}
					finally
					{
						((IDisposable)enumerator16).Dispose();
					}
					Enumerator<CustomAttributeNamedArgument> enumerator17 = current18.get_Fields().GetEnumerator();
					try
					{
						while (enumerator17.MoveNext())
						{
							CustomAttributeNamedArgument current20 = enumerator17.get_Current();
							val40.get_Fields().Add(new CustomAttributeNamedArgument(((CustomAttributeNamedArgument)(ref current20)).get_Name(), CreateCustomAttributeArgument(((CustomAttributeNamedArgument)(ref current20)).get_Argument())));
						}
					}
					finally
					{
						((IDisposable)enumerator17).Dispose();
					}
					enumerator17 = current18.get_Properties().GetEnumerator();
					try
					{
						while (enumerator17.MoveNext())
						{
							CustomAttributeNamedArgument current21 = enumerator17.get_Current();
							val40.get_Properties().Add(new CustomAttributeNamedArgument(((CustomAttributeNamedArgument)(ref current21)).get_Name(), CreateCustomAttributeArgument(((CustomAttributeNamedArgument)(ref current21)).get_Argument())));
						}
					}
					finally
					{
						((IDisposable)enumerator17).Dispose();
					}
				}
			}
			finally
			{
				((IDisposable)enumerator15).Dispose();
			}
		}
		FieldReference ResolveFieldReference(FieldReference fieldReference)
		{
			//Discarded unreachable code: IL_0050
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Expected O, but got Unknown
			//IL_01c0: Expected O, but got Unknown
			int num = 8;
			int num2 = num;
			FieldReference value = default(FieldReference);
			_003C_003Ec__DisplayClass1_8 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_8);
			AssemblyNameReference val23 = default(AssemblyNameReference);
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 3:
					return value;
				case 8:
					_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_8();
					num2 = 7;
					break;
				default:
				{
					object obj = _003C_003Ec__DisplayClass1_0.ryaSFGv8NyfCZeZROPhv(_003C_003Ec__DisplayClass1_0.W1Srlnv8eNDjJeMM4dC1(_003C_003Ec__DisplayClass1_.fieldReference));
					if ((val23 = (AssemblyNameReference)((obj is AssemblyNameReference) ? obj : null)) != null)
					{
						num2 = 4;
						break;
					}
					goto case 9;
				}
				case 5:
					value = (CS_0024_003C_003E8__locals0.resolvedFields[_003C_003Ec__DisplayClass1_.fieldReference] = (FieldReference)(object)((IEnumerable<FieldDefinition>)((TypeDefinition)_003C_003Ec__DisplayClass1_0.shr5vLv87nSyS3QBwHMx(ResolveTypeReference((TypeReference)_003C_003Ec__DisplayClass1_0.W1Srlnv8eNDjJeMM4dC1(_003C_003Ec__DisplayClass1_.fieldReference)))).get_Fields()).First(_003C_003Ec__DisplayClass1_._003CMerge_003Eb__19));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 1;
					}
					break;
				case 6:
					if (_003C_003Ec__DisplayClass1_.fieldReference == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num2 = 2;
						}
						break;
					}
					if (!CS_0024_003C_003E8__locals0.resolvedFields.TryGetValue(_003C_003Ec__DisplayClass1_.fieldReference, out value))
					{
						num2 = 10;
						break;
					}
					goto case 1;
				case 10:
					if (_003C_003Ec__DisplayClass1_0.ryaSFGv8NyfCZeZROPhv(_003C_003Ec__DisplayClass1_0.W1Srlnv8eNDjJeMM4dC1(_003C_003Ec__DisplayClass1_.fieldReference)) != CS_0024_003C_003E8__locals0.deltaModule)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 5;
				case 4:
					if (_003C_003Ec__DisplayClass1_0.ToTo7Fv8anYy136Oki8p(val23.get_FullName(), CS_0024_003C_003E8__locals0.assembly.get_FullName()))
					{
						num2 = 5;
						break;
					}
					goto case 9;
				case 9:
				{
					Dictionary<FieldReference, FieldReference> resolvedFields = CS_0024_003C_003E8__locals0.resolvedFields;
					FieldReference fieldReference3 = _003C_003Ec__DisplayClass1_.fieldReference;
					FieldReference val24 = new FieldReference((string)_003C_003Ec__DisplayClass1_0.iShDl4v8KaiMtEcvp3dj(_003C_003Ec__DisplayClass1_.fieldReference), ResolveTypeReference((TypeReference)_003C_003Ec__DisplayClass1_0.BgigmUv8riRAaHovYFW5(_003C_003Ec__DisplayClass1_.fieldReference)), ResolveTypeReference((TypeReference)_003C_003Ec__DisplayClass1_0.W1Srlnv8eNDjJeMM4dC1(_003C_003Ec__DisplayClass1_.fieldReference)));
					value = val24;
					resolvedFields[fieldReference3] = val24;
					num2 = 3;
					break;
				}
				case 2:
					return null;
				case 7:
					_003C_003Ec__DisplayClass1_.fieldReference = fieldReference;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 6;
					}
					break;
				}
			}
		}
		MethodReference ResolveMethodReference(MethodReference methodReference)
		{
			//Discarded unreachable code: IL_00ed, IL_0216, IL_0225, IL_03e6, IL_03f5, IL_045a, IL_0469
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Expected O, but got Unknown
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Expected O, but got Unknown
			//IL_01ca: Expected O, but got Unknown
			//IL_0269: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0276: Unknown result type (might be due to invalid IL or missing references)
			//IL_0280: Expected O, but got Unknown
			//IL_0280: Unknown result type (might be due to invalid IL or missing references)
			//IL_0292: Expected O, but got Unknown
			//IL_0292: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a7: Expected O, but got Unknown
			//IL_02ac: Expected O, but got Unknown
			int num16 = 7;
			_003C_003Ec__DisplayClass1_7 _003C_003Ec__DisplayClass1_10 = default(_003C_003Ec__DisplayClass1_7);
			AssemblyNameReference val37 = default(AssemblyNameReference);
			while (true)
			{
				int num17 = num16;
				while (true)
				{
					switch (num17)
					{
					case 3:
					case 12:
					case 15:
					case 17:
						return _003C_003Ec__DisplayClass1_10.result;
					case 5:
						if (_003C_003Ec__DisplayClass1_10.methodReference != null)
						{
							num17 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
							{
								num17 = 0;
							}
							continue;
						}
						goto case 19;
					case 14:
						((IEnumerable<TypeReference>)((GenericInstanceMethod)_003C_003Ec__DisplayClass1_10.methodReference).get_GenericArguments()).Select(ResolveTypeReference).ForEach((Action<TypeReference>)((GenericInstanceMethod)_003C_003Ec__DisplayClass1_10.result).get_GenericArguments().Add);
						num17 = 12;
						continue;
					case 4:
					{
						object obj7 = _003C_003Ec__DisplayClass1_0.ryaSFGv8NyfCZeZROPhv(_003C_003Ec__DisplayClass1_0.W1Srlnv8eNDjJeMM4dC1(_003C_003Ec__DisplayClass1_10.methodReference));
						if ((val37 = (AssemblyNameReference)((obj7 is AssemblyNameReference) ? obj7 : null)) != null)
						{
							num17 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
							{
								num17 = 0;
							}
							continue;
						}
						goto case 11;
					}
					case 6:
						_003C_003Ec__DisplayClass1_10.methodReference = methodReference;
						num17 = 5;
						continue;
					case 16:
						CS_0024_003C_003E8__locals0.resolvedMethods[_003C_003Ec__DisplayClass1_10.methodReference] = (_003C_003Ec__DisplayClass1_10.result = (MethodReference)(object)((IEnumerable<MethodDefinition>)((TypeDefinition)_003C_003Ec__DisplayClass1_0.shr5vLv87nSyS3QBwHMx(ResolveTypeReference((TypeReference)_003C_003Ec__DisplayClass1_0.W1Srlnv8eNDjJeMM4dC1(_003C_003Ec__DisplayClass1_10.methodReference)))).get_Methods()).First(_003C_003Ec__DisplayClass1_10._003CMerge_003Eb__16));
						num17 = 15;
						continue;
					case 8:
					{
						Dictionary<MethodReference, MethodReference> resolvedMethods2 = CS_0024_003C_003E8__locals0.resolvedMethods;
						MethodReference methodReference4 = _003C_003Ec__DisplayClass1_10.methodReference;
						_003C_003Ec__DisplayClass1_7 _003C_003Ec__DisplayClass1_12 = _003C_003Ec__DisplayClass1_10;
						GenericInstanceMethod val39 = new GenericInstanceMethod(ResolveMethodReference((MethodReference)_003C_003Ec__DisplayClass1_0.BYaNV8v8AJvRcEoqYeBo((object)(GenericInstanceMethod)_003C_003Ec__DisplayClass1_10.methodReference)));
						MethodReference value4 = (MethodReference)val39;
						_003C_003Ec__DisplayClass1_12.result = (MethodReference)val39;
						resolvedMethods2[methodReference4] = value4;
						num17 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num17 = 14;
						}
						continue;
					}
					case 1:
						if (_003C_003Ec__DisplayClass1_0.ToTo7Fv8anYy136Oki8p(_003C_003Ec__DisplayClass1_0.bAPaSPv83XklVf3itqR1(val37), _003C_003Ec__DisplayClass1_0.F2YOBfv8pgyDLXoTaqwy(CS_0024_003C_003E8__locals0.assembly)))
						{
							num17 = 16;
							continue;
						}
						goto case 11;
					case 11:
					{
						Dictionary<MethodReference, MethodReference> resolvedMethods = CS_0024_003C_003E8__locals0.resolvedMethods;
						MethodReference methodReference3 = _003C_003Ec__DisplayClass1_10.methodReference;
						_003C_003Ec__DisplayClass1_7 _003C_003Ec__DisplayClass1_11 = _003C_003Ec__DisplayClass1_10;
						MethodReference val38 = new MethodReference((string)_003C_003Ec__DisplayClass1_0.iShDl4v8KaiMtEcvp3dj(_003C_003Ec__DisplayClass1_10.methodReference), (TypeReference)_003C_003Ec__DisplayClass1_0.hygSUCv8xHCrrh1vReNG(_003C_003Ec__DisplayClass1_10.methodReference), ResolveTypeReference((TypeReference)_003C_003Ec__DisplayClass1_0.W1Srlnv8eNDjJeMM4dC1(_003C_003Ec__DisplayClass1_10.methodReference)));
						_003C_003Ec__DisplayClass1_0.JqoyNHv8mabnXrA7sZpO((object)val38, _003C_003Ec__DisplayClass1_0.IiGy69v80qCSwtURIekG(_003C_003Ec__DisplayClass1_10.methodReference));
						_003C_003Ec__DisplayClass1_0.xgCVlcv8MRsfcP8Qu2ul((object)val38, _003C_003Ec__DisplayClass1_0.h5tX9xv8y0QO7rJEsynn(_003C_003Ec__DisplayClass1_10.methodReference));
						val38.set_HasThis(_003C_003Ec__DisplayClass1_10.methodReference.get_HasThis());
						MethodReference value4 = val38;
						_003C_003Ec__DisplayClass1_11.result = val38;
						resolvedMethods[methodReference3] = value4;
						num17 = 9;
						continue;
					}
					case 18:
						if (_003C_003Ec__DisplayClass1_0.ryaSFGv8NyfCZeZROPhv(((MemberReference)_003C_003Ec__DisplayClass1_10.methodReference).get_DeclaringType()) != CS_0024_003C_003E8__locals0.deltaModule)
						{
							num17 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
							{
								num17 = 4;
							}
							continue;
						}
						goto case 16;
					case 13:
						((IEnumerable<ParameterDefinition>)_003C_003Ec__DisplayClass1_10.methodReference.get_Parameters()).Select((Func<ParameterDefinition, ParameterDefinition>)((ParameterDefinition p) => new ParameterDefinition((string)_003C_003Ec__DisplayClass1_0.SJH7hbv89tW9nN8lCQy3(p), _003C_003Ec__DisplayClass1_0.cMEMjfv8dPsKOHFrjkal(p), ResolveTypeReference((TypeReference)_003C_003Ec__DisplayClass1_0.OcWQ6Iv8lB8avde1wHAn(p))))).ForEach((Action<ParameterDefinition>)_003C_003Ec__DisplayClass1_10.result.get_Parameters().Add);
						num17 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num17 = 17;
						}
						continue;
					case 10:
						_003C_003Ec__DisplayClass1_0.bPWjSjv8JDVsqZI6oPqm(_003C_003Ec__DisplayClass1_10.result, ResolveTypeReference((TypeReference)_003C_003Ec__DisplayClass1_0.hygSUCv8xHCrrh1vReNG(_003C_003Ec__DisplayClass1_10.methodReference)));
						num16 = 13;
						break;
					default:
						if (_003C_003Ec__DisplayClass1_0.Md5xT8v8H0dbL8yKDY8g(_003C_003Ec__DisplayClass1_10.methodReference))
						{
							num16 = 8;
							break;
						}
						goto case 18;
					case 7:
						_003C_003Ec__DisplayClass1_10 = new _003C_003Ec__DisplayClass1_7();
						num17 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num17 = 5;
						}
						continue;
					case 19:
						return null;
					case 2:
						if (CS_0024_003C_003E8__locals0.resolvedMethods.TryGetValue(_003C_003Ec__DisplayClass1_10.methodReference, out _003C_003Ec__DisplayClass1_10.result))
						{
							num16 = 3;
							break;
						}
						goto default;
					case 9:
						((IEnumerable<GenericParameter>)_003C_003Ec__DisplayClass1_10.methodReference.get_GenericParameters()).Select(_003C_003Ec__DisplayClass1_10._003CMerge_003Eb__17).ForEach((Action<GenericParameter>)_003C_003Ec__DisplayClass1_10.result.get_GenericParameters().Add);
						num17 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num17 = 10;
						}
						continue;
					}
					break;
				}
			}
		}
		TypeReference ResolveTypeReference(TypeReference typeReference)
		{
			//Discarded unreachable code: IL_010d, IL_02bb, IL_02ce, IL_02dd, IL_02ec, IL_0344, IL_0353, IL_0362, IL_0387, IL_0457, IL_0466, IL_04d1, IL_04f1, IL_0536, IL_05c5, IL_05ed, IL_0621, IL_064f, IL_065e
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Expected O, but got Unknown
			//IL_01e1: Expected O, but got Unknown
			//IL_022b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected O, but got Unknown
			//IL_0238: Expected O, but got Unknown
			//IL_024a: Unknown result type (might be due to invalid IL or missing references)
			//IL_026c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0302: Unknown result type (might be due to invalid IL or missing references)
			//IL_030c: Expected O, but got Unknown
			//IL_0311: Unknown result type (might be due to invalid IL or missing references)
			//IL_0316: Unknown result type (might be due to invalid IL or missing references)
			//IL_0319: Expected O, but got Unknown
			//IL_031e: Expected O, but got Unknown
			//IL_0422: Unknown result type (might be due to invalid IL or missing references)
			//IL_0427: Unknown result type (might be due to invalid IL or missing references)
			//IL_0439: Unknown result type (might be due to invalid IL or missing references)
			//IL_043c: Expected O, but got Unknown
			//IL_0441: Expected O, but got Unknown
			//IL_0639: Unknown result type (might be due to invalid IL or missing references)
			//IL_0640: Expected O, but got Unknown
			//IL_0674: Unknown result type (might be due to invalid IL or missing references)
			//IL_067e: Expected O, but got Unknown
			//IL_0696: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a0: Expected O, but got Unknown
			//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
			int num14 = 6;
			_003C_003Ec__DisplayClass1_5 _003C_003Ec__DisplayClass1_3 = default(_003C_003Ec__DisplayClass1_5);
			_003C_003Ec__DisplayClass1_6 _003C_003Ec__DisplayClass1_6 = default(_003C_003Ec__DisplayClass1_6);
			AssemblyNameReference val33 = default(AssemblyNameReference);
			AssemblyNameReference val32 = default(AssemblyNameReference);
			AssemblyNameReference val31 = default(AssemblyNameReference);
			while (true)
			{
				int num15 = num14;
				while (true)
				{
					switch (num15)
					{
					case 4:
					case 10:
					case 13:
					case 15:
					case 16:
					case 21:
					case 36:
					case 42:
						return _003C_003Ec__DisplayClass1_3.result;
					case 17:
					case 35:
						_003C_003Ec__DisplayClass1_6 = new _003C_003Ec__DisplayClass1_6();
						num14 = 19;
						break;
					case 12:
					case 41:
						if (_003C_003Ec__DisplayClass1_0.ryaSFGv8NyfCZeZROPhv(typeReference) != CS_0024_003C_003E8__locals0.deltaModule)
						{
							num14 = 9;
							break;
						}
						goto case 1;
					case 1:
						CS_0024_003C_003E8__locals0.resolvedTypes[typeReference] = (_003C_003Ec__DisplayClass1_3.result = (TypeReference)(object)CS_0024_003C_003E8__locals0.module.GetType((string)_003C_003Ec__DisplayClass1_0.IG6MjPv8D13WmUK6hDOZ(typeReference)));
						num15 = 15;
						continue;
					case 27:
						((IEnumerable<GenericParameter>)typeReference.get_GenericParameters()).Select(_003C_003Ec__DisplayClass1_3._003CMerge_003Eb__15).ForEach((Action<GenericParameter>)_003C_003Ec__DisplayClass1_3.result.get_GenericParameters().Add);
						num15 = 42;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num15 = 40;
						}
						continue;
					case 8:
						if (!_003C_003Ec__DisplayClass1_0.ToTo7Fv8anYy136Oki8p(_003C_003Ec__DisplayClass1_0.bAPaSPv83XklVf3itqR1(val33), _003C_003Ec__DisplayClass1_0.F2YOBfv8pgyDLXoTaqwy(CS_0024_003C_003E8__locals0.assembly)))
						{
							num15 = 35;
							continue;
						}
						goto case 1;
					case 22:
					{
						Dictionary<TypeReference, TypeReference> resolvedTypes2 = CS_0024_003C_003E8__locals0.resolvedTypes;
						_003C_003Ec__DisplayClass1_5 _003C_003Ec__DisplayClass1_5 = _003C_003Ec__DisplayClass1_3;
						ArrayType val30 = new ArrayType(ResolveTypeReference((TypeReference)_003C_003Ec__DisplayClass1_0.hBNUbnv8kBnSqhBVrSWw(typeReference)));
						TypeReference value3 = (TypeReference)val30;
						_003C_003Ec__DisplayClass1_5.result = (TypeReference)val30;
						resolvedTypes2[typeReference] = value3;
						num15 = 4;
						continue;
					}
					case 39:
						return null;
					case 31:
						if (CS_0024_003C_003E8__locals0.resolvedTypes.TryGetValue(typeReference, out _003C_003Ec__DisplayClass1_3.result))
						{
							num15 = 10;
							continue;
						}
						goto case 43;
					case 33:
					{
						Dictionary<TypeReference, TypeReference> resolvedTypes5 = CS_0024_003C_003E8__locals0.resolvedTypes;
						_003C_003Ec__DisplayClass1_5 _003C_003Ec__DisplayClass1_9 = _003C_003Ec__DisplayClass1_3;
						ByReferenceType val36 = new ByReferenceType(ResolveTypeReference((TypeReference)_003C_003Ec__DisplayClass1_0.hBNUbnv8kBnSqhBVrSWw(typeReference)));
						TypeReference value3 = (TypeReference)val36;
						_003C_003Ec__DisplayClass1_9.result = (TypeReference)val36;
						resolvedTypes5[typeReference] = value3;
						num15 = 21;
						continue;
					}
					case 34:
						((IEnumerable<TypeReference>)((GenericInstanceType)typeReference).get_GenericArguments()).Select(ResolveTypeReference).ForEach((Action<TypeReference>)((GenericInstanceType)_003C_003Ec__DisplayClass1_3.result).get_GenericArguments().Add);
						num15 = 36;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num15 = 27;
						}
						continue;
					case 11:
					case 18:
						if (_003C_003Ec__DisplayClass1_0.xrLuyav8OJ1aPHT0NfiM(typeReference))
						{
							num15 = 37;
							continue;
						}
						goto case 25;
					case 7:
					{
						Dictionary<TypeReference, TypeReference> resolvedTypes3 = CS_0024_003C_003E8__locals0.resolvedTypes;
						_003C_003Ec__DisplayClass1_5 _003C_003Ec__DisplayClass1_7 = _003C_003Ec__DisplayClass1_3;
						GenericInstanceType val34 = new GenericInstanceType(ResolveTypeReference((TypeReference)_003C_003Ec__DisplayClass1_0.doHBlpv81o1946mFGTZa((object)(GenericInstanceType)typeReference)));
						TypeReference value3 = (TypeReference)val34;
						_003C_003Ec__DisplayClass1_7.result = (TypeReference)val34;
						resolvedTypes3[typeReference] = value3;
						num15 = 34;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num15 = 6;
						}
						continue;
					}
					case 19:
						if (CS_0024_003C_003E8__locals0.referencesRewrite == null)
						{
							num15 = 29;
							continue;
						}
						goto case 2;
					default:
						val32 = ((IEnumerable<AssemblyNameReference>)CS_0024_003C_003E8__locals0.module.get_AssemblyReferences()).FirstOrDefault(_003C_003Ec__DisplayClass1_6._003CMerge_003Eb__14);
						num15 = 38;
						continue;
					case 2:
					{
						object obj6 = _003C_003Ec__DisplayClass1_0.ryaSFGv8NyfCZeZROPhv(typeReference);
						if ((val31 = (AssemblyNameReference)((obj6 is AssemblyNameReference) ? obj6 : null)) == null)
						{
							num15 = 24;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
							{
								num15 = 30;
							}
							continue;
						}
						goto case 32;
					}
					case 5:
						if (typeReference != null)
						{
							num14 = 31;
							break;
						}
						goto case 39;
					case 23:
					case 26:
					{
						Dictionary<TypeReference, TypeReference> resolvedTypes4 = CS_0024_003C_003E8__locals0.resolvedTypes;
						_003C_003Ec__DisplayClass1_5 _003C_003Ec__DisplayClass1_8 = _003C_003Ec__DisplayClass1_3;
						TypeReference val35 = new TypeReference((string)_003C_003Ec__DisplayClass1_0.vbxudSv8RRUmtBNXGFNK(typeReference), ((MemberReference)typeReference).get_Name(), CS_0024_003C_003E8__locals0.module, (IMetadataScope)(object)val32, typeReference.get_IsValueType());
						((MemberReference)val35).set_DeclaringType(ResolveTypeReference((TypeReference)_003C_003Ec__DisplayClass1_0.W1Srlnv8eNDjJeMM4dC1(typeReference)));
						TypeReference value3 = val35;
						_003C_003Ec__DisplayClass1_8.result = val35;
						resolvedTypes4[typeReference] = value3;
						num15 = 27;
						continue;
					}
					case 9:
					{
						object obj5 = _003C_003Ec__DisplayClass1_0.ryaSFGv8NyfCZeZROPhv(typeReference);
						if ((val33 = (AssemblyNameReference)((obj5 is AssemblyNameReference) ? obj5 : null)) != null)
						{
							num15 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
							{
								num15 = 6;
							}
							continue;
						}
						goto case 17;
					}
					case 29:
					case 30:
					case 40:
						CS_0024_003C_003E8__locals0.resolvedTypes[typeReference] = (_003C_003Ec__DisplayClass1_3.result = (TypeReference)_003C_003Ec__DisplayClass1_0.U7VI5pv86bbJResTt6CQ(CS_0024_003C_003E8__locals0.module, typeReference));
						num15 = 13;
						continue;
					case 38:
						if (val32 == null)
						{
							num15 = 24;
							continue;
						}
						goto case 14;
					case 43:
						if (!(typeReference is ByReferenceType))
						{
							num15 = 20;
							continue;
						}
						goto case 33;
					case 6:
						_003C_003Ec__DisplayClass1_3 = new _003C_003Ec__DisplayClass1_5();
						num15 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num15 = 5;
						}
						continue;
					case 32:
						if (CS_0024_003C_003E8__locals0.referencesRewrite.TryGetValue((string)_003C_003Ec__DisplayClass1_0.fOtyRJv8tnLy1JT4I3Iy(val31), out _003C_003Ec__DisplayClass1_6.rewrite))
						{
							num15 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
							{
								num15 = 0;
							}
							continue;
						}
						goto case 29;
					case 14:
						_003C_003Ec__DisplayClass1_0.fjgpvqv84t8oiffx1J3w(val32, val31.get_Version());
						num15 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
						{
							num15 = 23;
						}
						continue;
					case 28:
						CS_0024_003C_003E8__locals0.module.get_AssemblyReferences().Add(val32);
						num14 = 26;
						break;
					case 3:
					case 20:
						if (!_003C_003Ec__DisplayClass1_0.fteVmav8nJ3rWVPR7gNK(typeReference))
						{
							num14 = 11;
							break;
						}
						goto case 22;
					case 25:
						if (!_003C_003Ec__DisplayClass1_0.OqkCPtv8PlQNDtRgOftq(typeReference))
						{
							num15 = 16;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
							{
								num15 = 41;
							}
							continue;
						}
						goto case 7;
					case 24:
						val32 = new AssemblyNameReference(_003C_003Ec__DisplayClass1_6.rewrite, (Version)_003C_003Ec__DisplayClass1_0.XaEEd7v8w2kb5GyAFcm9(val31));
						num15 = 28;
						continue;
					case 37:
					{
						Dictionary<TypeReference, TypeReference> resolvedTypes = CS_0024_003C_003E8__locals0.resolvedTypes;
						_003C_003Ec__DisplayClass1_5 _003C_003Ec__DisplayClass1_4 = _003C_003Ec__DisplayClass1_3;
						MethodReference obj3 = ResolveMethodReference((MethodReference)_003C_003Ec__DisplayClass1_0.IBUa0Mv82w5PiwMm0TwG((object)(GenericParameter)typeReference));
						GenericParameter obj4 = ((obj3 != null) ? obj3.get_GenericParameters().get_Item(_003C_003Ec__DisplayClass1_0.hHXD6tv8TgjJrtSTWGm3((object)(GenericParameter)typeReference)) : null) ?? ResolveTypeReference((TypeReference)_003C_003Ec__DisplayClass1_0.W1Srlnv8eNDjJeMM4dC1(typeReference)).get_GenericParameters().get_Item(((GenericParameter)typeReference).get_Position());
						TypeReference value3 = (TypeReference)(object)obj4;
						_003C_003Ec__DisplayClass1_4.result = (TypeReference)(object)obj4;
						resolvedTypes[typeReference] = value3;
						num15 = 16;
						continue;
					}
					}
					break;
				}
			}
		}
	}

	private static MemoryStream MergeDocumentation(object docRaw, object deltaDocRaw)
	{
		//Discarded unreachable code: IL_0166, IL_0188, IL_0197
		int num = 12;
		Regex regex = default(Regex);
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (((Stream)deltaDocRaw).Length != 0L)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 9;
				case 9:
					return (MemoryStream)docRaw;
				case 1:
					regex = new Regex((string)jd6noph2kB36YcYQqbQu(-475857671 ^ -475943121), RegexOptions.Singleline);
					num2 = 7;
					continue;
				case 2:
					if (((Stream)docRaw).Length == 0L)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num2 = 9;
						}
						continue;
					}
					if (deltaDocRaw != null)
					{
						num2 = 3;
						continue;
					}
					goto case 9;
				case 12:
					_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
					num2 = 11;
					continue;
				case 5:
					if (_003C_003Ec__DisplayClass2_.deltaMembers.Count > 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				case 8:
					return (MemoryStream)UMBrZfh234A42cm4EViJ(cirkUFh2NqtqjCVoZ4nM(Encoding.UTF8, text), false);
				case 11:
					if (docRaw == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 2;
				case 6:
					text = (string)uc7yrfh2e48nCOZe4IFZ(regex, ((Encoding)Iebw0ph22FNJPZDHleG3()).GetString((byte[])UYLVyQh2n75Q2HxQnL6d(docRaw)), new MatchEvaluator(_003C_003Ec__DisplayClass2_._003CMergeDocumentation_003Eb__2));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 5;
					}
					continue;
				case 4:
				case 10:
					return (MemoryStream)deltaDocRaw;
				case 7:
					_003C_003Ec__DisplayClass2_.deltaMembers = regex.Matches((string)kykDiZh2O5maKboJtRgv(Encoding.UTF8, UYLVyQh2n75Q2HxQnL6d(deltaDocRaw))).Cast<Match>().ToDictionary((Match m) => (string)_003C_003Ec.al7cXbvZmKGH9PwkdWBx(_003C_003Ec.i8YApBvZ0A9x0bqQslBM(m.Groups, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521269162))), (Match m) => (string)_003C_003Ec.al7cXbvZmKGH9PwkdWBx(m));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 6;
					}
					continue;
				}
				break;
			}
			text = text.Insert(chqQrEh21U1nABbtfjsy(text, jd6noph2kB36YcYQqbQu(0x1C9495B4 ^ 0x1C94F68A), EhiU2Hh2Pj2Q9Enl11PH(text, jd6noph2kB36YcYQqbQu(0x7459E02 ^ 0x746CA4C))) + 2, string.Concat(_003C_003Ec__DisplayClass2_.deltaMembers.Values));
			num = 8;
		}
	}

	public static MetadataAssemblyPublishResult Publish(IEnumerable<IMetadataItem> publishedMetadataItems, Func<string, AssemblyModelsMetadataStatus, AssemblyModelsMetadata> loadAssemblyMetadata, Action<AssemblyModelsMetadata> saveAssemblyMetadata, IMetadataRuntimeService metadataRuntimeService, IModelAssemblyBuilderHandler modelAssemblyBuilderHandler, IEnumerable<AbstractMetadata> xmlMetadataList = null, IList<ScriptModule> allScriptModules = null, bool ignoreScriptsErrors = true, bool buildDynamicAssembly = false, bool buildClientScripts = false, bool buildDeltaAssemblies = false)
	{
		_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
		CS_0024_003C_003E8__locals0.buildDeltaAssemblies = buildDeltaAssemblies;
		List<AbstractMetadata> list = publishedMetadataItems.Select((IMetadataItem item) => (AbstractMetadata)_003C_003Ec.GFUrwsvZyQCIQo9sEspD(item)).ToList();
		ScriptModule[] array = (from item in publishedMetadataItems
			select (ScriptModule)_003C_003Ec.VjvbHQvZMr3i7SxvmN3l(item) into item
			where item != null
			select item).ToArray();
		ScriptModule[] clientScriptModules = (from item in publishedMetadataItems
			select (ScriptModule)_003C_003Ec.DUGNZBvZJKrcroL6PVB7(item) into item
			where item != null
			select item).ToArray();
		ModelHelper.CheckEntityAndTableNames(list);
		Dictionary<IMetadata, MetadataItemValidationError[]> dictionary = new Dictionary<IMetadata, MetadataItemValidationError[]>();
		foreach (IValidatableMetadata item in list.OfType<IValidatableMetadata>())
		{
			MetadataItemValidationError[] array2 = item.Validate();
			if (array2 != null && array2.Length != 0)
			{
				dictionary[(IMetadata)item] = array2;
			}
		}
		if (dictionary.Count > 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822707074)));
			foreach (KeyValuePair<IMetadata, MetadataItemValidationError[]> item2 in dictionary)
			{
				string value = ((item2.Key is NamedMetadata namedMetadata) ? namedMetadata.DisplayName : (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859062505) + item2.Key.Uid));
				stringBuilder.Append(value);
				if (item2.Value.Length == 1)
				{
					stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548BC6DE));
					stringBuilder.AppendLine(item2.Value[0].Message);
					continue;
				}
				stringBuilder.AppendLine(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA4117E));
				MetadataItemValidationError[] value2 = item2.Value;
				foreach (MetadataItemValidationError metadataItemValidationError in value2)
				{
					stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643772197));
					stringBuilder.AppendLine(metadataItemValidationError.Message);
				}
			}
			throw new MetadataPublishingException(stringBuilder.ToString())
			{
				ValidationErrors = dictionary.Values.SelectMany((MetadataItemValidationError[] e) => e).ToArray()
			};
		}
		MemoryStream memoryStream = null;
		MemoryStream memoryStream2 = null;
		MemoryStream memoryStream3 = null;
		MemoryStream debugRawStream = null;
		MemoryStream memoryStream4 = null;
		MemoryStream memoryStream5 = null;
		MemoryStream memoryStream6 = null;
		AbstractMetadata[] array3 = null;
		CS_0024_003C_003E8__locals0.metadataList = ((xmlMetadataList != null) ? xmlMetadataList.ToDictionary((AbstractMetadata m) => _003C_003Ec.KM8jh7vZ9QqM6xvNPojE(m)) : (metadataRuntimeService.GetAssemblyModelsMetadataList().FirstOrDefault((AssemblyModelsMetadata a) => _003C_003Ec.BowSaGvZx0ZX0r6IegY2(_003C_003Ec.YTaXmmvZdkrZqN5pDKqU(a), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138957412)))?.RestoreMetadata()?.ToDictionary((AbstractMetadata m) => _003C_003Ec.KM8jh7vZ9QqM6xvNPojE(m)) ?? new Dictionary<Guid, AbstractMetadata>()));
		list.ForEach(delegate(AbstractMetadata m)
		{
			int num15 = 1;
			int num16 = num15;
			while (true)
			{
				switch (num16)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					CS_0024_003C_003E8__locals0.metadataList[_003C_003Ec__DisplayClass9_0.fu1BcPvuhESjlxeDVbbe(m)] = m;
					num16 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num16 = 0;
					}
					break;
				}
			}
		});
		CS_0024_003C_003E8__locals0.tempMetadataService = new ConfigurationModelBuilderMetadataService(metadataRuntimeService, CS_0024_003C_003E8__locals0.metadataList.Values);
		IEnumerable<AbstractMetadata> source = null;
		ScriptCompiler scriptCompiler = null;
		CS_0024_003C_003E8__locals0.scriptErrorsBuilder = null;
		try
		{
			using (new MetadataServiceContext(CS_0024_003C_003E8__locals0.tempMetadataService))
			{
				_003C_003Ec__DisplayClass9_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass9_1();
				CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
				CS_0024_003C_003E8__locals1.version = NextVersion.ToString();
				using (ModelAssemblyBuilder modelAssemblyBuilder = new ModelAssemblyBuilder(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.buildDeltaAssemblies ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217521497) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4DFB97)))
				{
					if (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.buildDeltaAssemblies)
					{
						publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123685198));
					}
					else
					{
						publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4F2E3B));
					}
					modelAssemblyBuilder.AddDefaultReferences();
					try
					{
						isConfigurationModelBuild.Value = true;
						IEnumerable<AbstractMetadata> enumerable;
						if (!CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.buildDeltaAssemblies)
						{
							IEnumerable<AbstractMetadata> values = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.metadataList.Values;
							enumerable = values;
						}
						else
						{
							enumerable = list.AsEnumerable();
						}
						foreach (AbstractMetadata item3 in enumerable)
						{
							modelAssemblyBuilder.AddMetadata(item3);
						}
					}
					finally
					{
						isConfigurationModelBuild.Value = false;
					}
					modelAssemblyBuilder.GenerateAssemblyInfo(delegate(string a)
					{
						//Discarded unreachable code: IL_00a8
						int num13 = 5;
						int num14 = num13;
						string text2 = default(string);
						bool? dynamicPublicationEnable2 = default(bool?);
						while (true)
						{
							switch (num14)
							{
							case 5:
								text2 = (string)_003C_003Ec__DisplayClass9_1.rEyRJRvuS7Jl7F7RSmHM(_003C_003Ec__DisplayClass9_1.rEyRJRvuS7Jl7F7RSmHM(_003C_003Ec__DisplayClass9_1.rEyRJRvuS7Jl7F7RSmHM(a, _003C_003Ec__DisplayClass9_1.vRUw7VvuVr1uD48yKV11(-1123633026 ^ -1123865656), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289717234)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951280148), CS_0024_003C_003E8__locals1.version), _003C_003Ec__DisplayClass9_1.vRUw7VvuVr1uD48yKV11(0x3A6135BE ^ 0x3A64A18C), CS_0024_003C_003E8__locals1.version);
								num14 = 4;
								break;
							case 3:
								text2 = (string)_003C_003Ec__DisplayClass9_1.lBIbbbvuiqEeMIPo6nRT(text2, _003C_003Ec__DisplayClass9_1.vRUw7VvuVr1uD48yKV11(0x3B36AB09 ^ 0x3B336B1B));
								num14 = 2;
								break;
							default:
								if (!dynamicPublicationEnable2.Value)
								{
									num14 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
									{
										num14 = 0;
									}
									break;
								}
								goto case 3;
							case 4:
								dynamicPublicationEnable2 = ReflectionType.DynamicPublicationEnable;
								num14 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
								{
									num14 = 0;
								}
								break;
							case 1:
							case 2:
								return text2;
							}
						}
					});
					if (CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.buildDeltaAssemblies)
					{
						MemoryStream loadedAssemblyRawAsStream = ComponentManager.GetLoadedAssemblyRawAsStream(ComponentManager.FindLoadedAssembly(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE1223AB), isFullName: false));
						modelAssemblyBuilder.AddReference(loadedAssemblyRawAsStream.AsNoClose());
						publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889667828));
						memoryStream = modelAssemblyBuilder.BuildToStream(pdb: false);
						publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309849552));
						publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -575933830));
						CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.cfgModelAssemblyRaw = ConfigurationModelAssemblyBuilder.Merge((object)loadedAssemblyRawAsStream, (object)memoryStream, (IDictionary<string, string>)null);
						foreach (AssemblyModelsMetadata assemblyModelsMetadata4 in MetadataServiceContext.MetadataRuntimeService.GetAssemblyModelsMetadataList())
						{
							if (assemblyModelsMetadata4.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921200729))
							{
								memoryStream2 = assemblyModelsMetadata4.DocumentationRawStream;
							}
							if (assemblyModelsMetadata4.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17ADC6F6))
							{
								memoryStream6 = assemblyModelsMetadata4.DocumentationRawStream;
								array3 = assemblyModelsMetadata4.RestoreMetadata();
							}
						}
						memoryStream2 = MergeDocumentation(memoryStream2, modelAssemblyBuilder.DocumentationRawStream);
						publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1DB50A));
					}
					else
					{
						publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EF5AE0));
						CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.cfgModelAssemblyRaw = modelAssemblyBuilder.BuildToStream(pdb: false);
						memoryStream2 = modelAssemblyBuilder.DocumentationRawStream;
						publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92C4459));
					}
				}
				publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x6383C339));
				modelAssemblyBuilderHandler.ConfigurationModelAssemblyBuilt(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.metadataList.Values);
				publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA5A7D0D));
				IList<(MemoryStream, IMetadata)> publishedDataClassAssemblies = GetPublishedDataClassAssemblies();
				publishedDataClassAssemblies.ForEach(delegate((MemoryStream, IMetadata) d)
				{
					CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.tempMetadataService.AddMetadata(d.Item2);
				});
				CS_0024_003C_003E8__locals1.scriptModules = allScriptModules?.ToDictionary((ScriptModule sm) => _003C_003Ec.df6TupvZlLU1tpgSgUku(sm)) ?? new Dictionary<Guid, ScriptModule>();
				array?.ForEach(delegate(ScriptModule sm)
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
							CS_0024_003C_003E8__locals1.scriptModules[_003C_003Ec__DisplayClass9_1.DyvSPCvuRMFOV2TRSiyg(sm)] = sm;
							num12 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
							{
								num12 = 0;
							}
							break;
						}
					}
				});
				if (CS_0024_003C_003E8__locals1.scriptModules.Count > 0)
				{
					scriptCompiler = new ScriptCompiler(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x1244D622), CS_0024_003C_003E8__locals1.scriptModules.Values);
					scriptCompiler.AddReference(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.cfgModelAssemblyRaw.AsNoClose());
					scriptCompiler.AddAnalyzers(new ComponentsAnalyzer());
					foreach (KeyValuePair<Guid, AbstractMetadata> metadata in CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.metadataList)
					{
						EntityMetadata entityMetadata = metadata.Value as EntityMetadata;
						if (entityMetadata?.ViewModelMetadata != null)
						{
							scriptCompiler.AddSourceCode(GenerateScriptPartialCode(entityMetadata, MetadataServiceContext.Service));
						}
					}
					foreach (var item4 in publishedDataClassAssemblies)
					{
						scriptCompiler.AddReference(item4.Item1);
					}
					scriptCompiler.GenerateAssemblyInfoFile((string a) => (string)_003C_003Ec__DisplayClass9_1.rEyRJRvuS7Jl7F7RSmHM(_003C_003Ec__DisplayClass9_1.rEyRJRvuS7Jl7F7RSmHM(a.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217690993), (string)_003C_003Ec__DisplayClass9_1.vRUw7VvuVr1uD48yKV11(-218496594 ^ -218445016)), _003C_003Ec__DisplayClass9_1.vRUw7VvuVr1uD48yKV11(0x18A6761F ^ 0x18A3E215), CS_0024_003C_003E8__locals1.version), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309406834), CS_0024_003C_003E8__locals1.version));
					publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x83223EA));
					ScriptCompileResult scriptCompileResult = scriptCompiler.Compile();
					if (!scriptCompileResult.Success)
					{
						CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.scriptErrorsBuilder = new StringBuilder();
						scriptCompileResult.Messages.ForEach(delegate(ScriptCompileMessage m)
						{
							//Discarded unreachable code: IL_003a
							int num9 = 1;
							int num10 = num9;
							NamedMetadata namedMetadata2 = default(NamedMetadata);
							while (true)
							{
								object obj;
								switch (num10)
								{
								case 5:
									obj = null;
									goto IL_00be;
								case 4:
								{
									if (!CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.metadataList.TryGetValue(m.ObjectUid, out var value3))
									{
										num10 = 5;
										break;
									}
									obj = value3 as NamedMetadata;
									goto IL_00be;
								}
								case 3:
									return;
								default:
									if (_003C_003Ec__DisplayClass9_0.IR8cUvvuECyLAU6MExjF(m) != ScriptCompileMessageType.Error)
									{
										return;
									}
									num10 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
									{
										num10 = 3;
									}
									break;
								case 1:
									if (!(_003C_003Ec__DisplayClass9_0.Y9BUmLvuGbiQXhods2fP(m) != Guid.Empty))
									{
										return;
									}
									num10 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
									{
										num10 = 0;
									}
									break;
								case 2:
									{
										CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.scriptErrorsBuilder.AppendLine(SR.T((string)_003C_003Ec__DisplayClass9_0.hHgdNPvufsFDVauo5Cnq(-488881205 ^ -489030609), ((namedMetadata2 != null) ? _003C_003Ec__DisplayClass9_0.UHyeV0vuQRqpuP7Hq9in(namedMetadata2) : null) ?? m.ObjectUid.ToString(), m.Line, _003C_003Ec__DisplayClass9_0.DLJhAtvuCZw1W3wWUaX7(m)));
										num10 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
										{
											num10 = 3;
										}
										break;
									}
									IL_00be:
									namedMetadata2 = (NamedMetadata)obj;
									num10 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
									{
										num10 = 2;
									}
									break;
								}
							}
						});
						Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EF4D23) + CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.scriptErrorsBuilder.ToString());
						if (!ignoreScriptsErrors)
						{
							throw new MetadataPublishingException(scriptCompileResult);
						}
					}
					memoryStream3 = scriptCompiler.AssemblyRawStream;
					debugRawStream = scriptCompiler.DebugRawStream;
					publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE223F9));
				}
				if (buildDynamicAssembly)
				{
					_003C_003Ec__DisplayClass9_2 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass9_2();
					CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2 = CS_0024_003C_003E8__locals1;
					DynamicModelAssemblyBuilder dynamicModelAssemblyBuilder = new DynamicModelAssemblyBuilder(CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.buildDeltaAssemblies ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDCB3DE) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979249121));
					CS_0024_003C_003E8__locals2.dynamicModelCurrentAssemblyRaw = null;
					if (CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.buildDeltaAssemblies)
					{
						dynamicModelAssemblyBuilder.BuildDeltaAssembly();
						IMetadata[] array4 = (from m in list.OfType<EntityMetadata>()
							where _003C_003Ec.KNKWcXvZrxK84cEFa4IO(m) == EntityMetadataType.InterfaceExtension
							select CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.tempMetadataService.GetMetadata(_003C_003Ec__DisplayClass9_0.nMaT2bvuvpHVBdv7tPbU(m), loadImplementation: false)).SelectMany(delegate(IMetadata m)
						{
							IEnumerable<Guid> enumerable2 = (CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.tempMetadataService.GetMetadata(((EntityMetadata)m).ImplementationUid) as EntityMetadata)?.ImplementedExtensionUids;
							return (from u in enumerable2 ?? Enumerable.Empty<Guid>()
								where !CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.metadataList.ContainsKey(u)
								select CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.tempMetadataService.GetMetadata(u, loadImplementation: false)).Prepend(m);
						}).ToArray();
						IMetadata[] array5 = (from m in list.OfType<EntityMetadata>()
							where m.Filterable
							select m).Select(delegate(EntityMetadata m)
						{
							int num7 = 1;
							int num8 = num7;
							IMetadata result = default(IMetadata);
							while (true)
							{
								switch (num8)
								{
								default:
									result = m;
									num8 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
									{
										num8 = 1;
									}
									break;
								case 2:
									return result;
								case 1:
									if (_003C_003Ec__DisplayClass9_0.KDbi74vu83mSjZRxjwFb(m) == EntityMetadataType.InterfaceExtension)
									{
										return CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.tempMetadataService.GetMetadata(m.BaseClassUid, loadImplementation: false);
									}
									num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
									{
										num8 = 0;
									}
									break;
								}
							}
						}).ToArray();
						if (array4.Length != 0 || array5.Length != 0)
						{
							CS_0024_003C_003E8__locals2.dynamicModelCurrentAssemblyRaw = EntityDynamicGenerator.RemoveDynamicTypes(ComponentManager.GetLoadedAssemblyRawAsStream(ComponentManager.FindLoadedAssembly(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637E23B5), isFullName: false)), array4, array5);
						}
						dynamicModelAssemblyBuilder.RegisterMetadataList(list.Concat(array4));
					}
					else
					{
						List<Type> types = DynamicModelAssemblyBuilder.GetEntityInterfaceTypes().Where(delegate(Type t)
						{
							//Discarded unreachable code: IL_003d, IL_004c, IL_010e, IL_011d
							int num5 = 6;
							int num6 = num5;
							while (true)
							{
								switch (num6)
								{
								case 5:
									if (!_003C_003Ec.RhajJnvZ6JTS4Ws5ljsj(ComponentManager.GetAssemblyShortName(t.Assembly), _003C_003Ec.V6D4aLvZ5f0gSXUtpDdB(0x68BBB53E ^ 0x68BBBF5A)))
									{
										num6 = 4;
										break;
									}
									goto case 1;
								default:
									return _003C_003Ec.RhajJnvZ6JTS4Ws5ljsj(_003C_003Ec.jZWKcvvZjsHbutf2tF8m(t.Assembly), _003C_003Ec.V6D4aLvZ5f0gSXUtpDdB(--1333735954 ^ 0x4F7F3BFE));
								case 3:
								case 4:
									return false;
								case 1:
									if (_003C_003Ec.RhajJnvZ6JTS4Ws5ljsj(_003C_003Ec.jZWKcvvZjsHbutf2tF8m(t.Assembly), _003C_003Ec.V6D4aLvZ5f0gSXUtpDdB(0x31326106 ^ 0x31326B28)))
									{
										num6 = 2;
										break;
									}
									goto case 3;
								case 6:
									if (_003C_003Ec.kNLBPOvZgB6PPbDqyF3l(t.Assembly) != null)
									{
										num6 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
										{
											num6 = 5;
										}
										break;
									}
									goto case 3;
								case 2:
									if (!_003C_003Ec.RhajJnvZ6JTS4Ws5ljsj(_003C_003Ec.jZWKcvvZjsHbutf2tF8m(t.Assembly), _003C_003Ec.V6D4aLvZ5f0gSXUtpDdB(0x2A7797B7 ^ 0x2A779E29)))
									{
										num6 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
										{
											num6 = 3;
										}
										break;
									}
									goto default;
								}
							}
						}).ToList();
						dynamicModelAssemblyBuilder.RegisterTypes(types);
						dynamicModelAssemblyBuilder.RegisterTypes(DynamicModelAssemblyBuilder.GetAutoImplementTypes());
						dynamicModelAssemblyBuilder.RegisterMetadataList(CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.metadataList.Values.AsEnumerable());
					}
					dynamicModelAssemblyBuilder.RegisterConfigurationMetadataList(CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.metadataList.Values);
					dynamicModelAssemblyBuilder.RegisterDependentAssembly(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103FE311), CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.cfgModelAssemblyRaw);
					ICollection<EntityMetadata> implementationMetadataList = dynamicModelAssemblyBuilder.GetImplementationMetadataList();
					if (implementationMetadataList.Count > 0)
					{
						foreach (EntityMetadata item5 in implementationMetadataList)
						{
							CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.tempMetadataService.AddMetadata(item5);
						}
						if (CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.buildDeltaAssemblies && CS_0024_003C_003E8__locals2.dynamicModelCurrentAssemblyRaw == null)
						{
							CS_0024_003C_003E8__locals2.dynamicModelCurrentAssemblyRaw = ComponentManager.GetLoadedAssemblyRawAsStream(ComponentManager.FindLoadedAssembly(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3330508), isFullName: false));
						}
						MemoryStream memoryStream7 = dynamicModelAssemblyBuilder.BuildAssemblyToStream(delegate(ModelAssemblyBuilder b)
						{
							int num = 5;
							while (true)
							{
								int num2 = num;
								while (true)
								{
									switch (num2)
									{
									case 1:
										_003C_003Ec__DisplayClass9_2.RdGt1Kvuna1I9UqX32L8(b, _003C_003Ec__DisplayClass9_2.eYMu8vvukbnr4KGTPfVD(CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.cfgModelAssemblyRaw));
										num2 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
										{
											num2 = 0;
										}
										break;
									case 3:
										_003C_003Ec__DisplayClass9_2.RdGt1Kvuna1I9UqX32L8(b, _003C_003Ec__DisplayClass9_2.eYMu8vvukbnr4KGTPfVD(CS_0024_003C_003E8__locals2.dynamicModelCurrentAssemblyRaw));
										num2 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
										{
											num2 = 1;
										}
										break;
									case 4:
										if (CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.buildDeltaAssemblies)
										{
											goto end_IL_0012;
										}
										goto case 1;
									case 5:
										_003C_003Ec__DisplayClass9_2.jpqMPFvuT0XkAuMlTkfW(b);
										num2 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
										{
											num2 = 4;
										}
										break;
									case 2:
										return;
									default:
										b.GenerateAssemblyInfo(delegate(string a)
										{
											int num3 = 1;
											int num4 = num3;
											string text = default(string);
											bool? dynamicPublicationEnable = default(bool?);
											while (true)
											{
												switch (num4)
												{
												case 2:
													return text;
												case 4:
													if (dynamicPublicationEnable.Value)
													{
														num4 = 3;
														break;
													}
													goto case 2;
												case 1:
													text = ((string)_003C_003Ec__DisplayClass9_1.rEyRJRvuS7Jl7F7RSmHM(a.Replace((string)_003C_003Ec__DisplayClass9_1.vRUw7VvuVr1uD48yKV11(-97972138 ^ -97745952), (string)_003C_003Ec__DisplayClass9_1.vRUw7VvuVr1uD48yKV11(0x12441CA4 ^ 0x1244168A)), _003C_003Ec__DisplayClass9_1.vRUw7VvuVr1uD48yKV11(-882126494 ^ -881965720), CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.version)).Replace((string)_003C_003Ec__DisplayClass9_1.vRUw7VvuVr1uD48yKV11(-1979251663 ^ -1979543549), CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.version);
													num4 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
													{
														num4 = 0;
													}
													break;
												case 3:
													text += (string)_003C_003Ec__DisplayClass9_1.vRUw7VvuVr1uD48yKV11(0x53CB464B ^ 0x53CEFFA3);
													num4 = 2;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
													{
														num4 = 2;
													}
													break;
												default:
													dynamicPublicationEnable = ReflectionType.DynamicPublicationEnable;
													num4 = 4;
													break;
												}
											}
										});
										num2 = 2;
										break;
									}
									continue;
									end_IL_0012:
									break;
								}
								num = 3;
							}
						});
						if (CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.buildDeltaAssemblies)
						{
							publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4F23CB));
							memoryStream4 = memoryStream7;
							memoryStream5 = ConfigurationModelAssemblyBuilder.Merge((object)CS_0024_003C_003E8__locals2.dynamicModelCurrentAssemblyRaw, (object)memoryStream4, (IDictionary<string, string>)new Dictionary<string, string> { [z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837664283)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521267676) });
							memoryStream6 = MergeDocumentation(memoryStream6, dynamicModelAssemblyBuilder.DocumentationRawStream);
							publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B35F203));
						}
						else
						{
							memoryStream5 = memoryStream7;
							memoryStream6 = dynamicModelAssemblyBuilder.DocumentationRawStream;
						}
					}
					if (CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.buildDeltaAssemblies && array3 != null)
					{
						_003C_003Ec__DisplayClass9_3 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass9_3();
						CS_0024_003C_003E8__locals3.exists = implementationMetadataList.Select((EntityMetadata m) => _003C_003Ec.KM8jh7vZ9QqM6xvNPojE(m)).ToHashSet();
						implementationMetadataList.AddRange(array3.Where((AbstractMetadata m) => !CS_0024_003C_003E8__locals3.exists.Contains(_003C_003Ec__DisplayClass9_3.zS7uYPvu1D1iLpgf3cE8(m))).OfType<EntityMetadata>());
					}
					publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A4BA0E));
					modelAssemblyBuilderHandler.DynamicModelAssemblyBuilt(implementationMetadataList);
					publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EF4C8D));
					source = implementationMetadataList.Cast<AbstractMetadata>();
				}
				if (buildClientScripts)
				{
					publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837882295));
					modelAssemblyBuilderHandler.AfterAll(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.metadataList.Values, array, clientScriptModules);
					publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92C48AB));
				}
			}
			publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AFB9A1));
			AssemblyModelsMetadata assemblyModelsMetadata = loadAssemblyMetadata(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867824088), AssemblyModelsMetadataStatus.Published);
			if (assemblyModelsMetadata == null)
			{
				assemblyModelsMetadata = new AssemblyModelsMetadata
				{
					Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583742832),
					Status = AssemblyModelsMetadataStatus.Published
				};
			}
			assemblyModelsMetadata.AssemblyRawStream = CS_0024_003C_003E8__locals0.cfgModelAssemblyRaw;
			assemblyModelsMetadata.DocumentationRawStream = memoryStream2;
			assemblyModelsMetadata.SetMetadata(CS_0024_003C_003E8__locals0.metadataList.Values.ToArray());
			saveAssemblyMetadata(assemblyModelsMetadata);
			AssemblyModelsMetadata assemblyModelsMetadata2 = null;
			if (memoryStream3 != null || CS_0024_003C_003E8__locals0.scriptErrorsBuilder != null)
			{
				assemblyModelsMetadata2 = loadAssemblyMetadata(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210740923), AssemblyModelsMetadataStatus.Published);
				if (assemblyModelsMetadata2 == null)
				{
					assemblyModelsMetadata2 = new AssemblyModelsMetadata
					{
						Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD59AD6),
						Status = AssemblyModelsMetadataStatus.Published
					};
				}
				assemblyModelsMetadata2.AssemblyRawStream = memoryStream3;
				assemblyModelsMetadata2.DebugRawStream = debugRawStream;
				if (CS_0024_003C_003E8__locals0.scriptErrorsBuilder != null)
				{
					assemblyModelsMetadata2.DocumentationRawStream = MemoryHelper.GetMemoryStream();
					using (StreamWriter streamWriter = new StreamWriter(assemblyModelsMetadata2.DocumentationRawStream.AsNoClose(), Encoding.UTF8))
					{
						streamWriter.Write(CS_0024_003C_003E8__locals0.scriptErrorsBuilder.ToString());
					}
					assemblyModelsMetadata2.DocumentationRawStream.Seek(0L, SeekOrigin.Begin);
				}
				saveAssemblyMetadata(assemblyModelsMetadata2);
			}
			AssemblyModelsMetadata assemblyModelsMetadata3 = null;
			if (buildDynamicAssembly && memoryStream5 != null)
			{
				assemblyModelsMetadata3 = loadAssemblyMetadata(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4DFBDD), AssemblyModelsMetadataStatus.Prepared);
				if (assemblyModelsMetadata3 == null)
				{
					assemblyModelsMetadata3 = new AssemblyModelsMetadata
					{
						Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16755511),
						Status = AssemblyModelsMetadataStatus.Prepared
					};
				}
				assemblyModelsMetadata3.AssemblyRawStream = memoryStream5;
				assemblyModelsMetadata3.DocumentationRawStream = memoryStream6;
				assemblyModelsMetadata3.SetMetadata(source.ToArray());
				saveAssemblyMetadata(assemblyModelsMetadata3);
			}
			return new MetadataAssemblyPublishResult(assemblyModelsMetadata, assemblyModelsMetadata2, assemblyModelsMetadata3, memoryStream, memoryStream4);
		}
		finally
		{
			scriptCompiler?.Dispose();
		}
	}

	private static string GenerateScriptPartialCode(object entityMetadata, object metadataService)
	{
		int num = 1;
		int num2 = num;
		ICodeGenerator codeGenerator = default(ICodeGenerator);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return Encoding.UTF8.GetString((byte[])T63F4ph2HOoRnX179bRg(Tiot7Fh26U4eGw3FlTDi(codeGenerator)));
			case 1:
				codeGenerator = new EntityScriptGenerator((IMetadataService)metadataService);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				yP4khUh2DRwacX57VI28(codeGenerator.GenerationParams, AnGQLHh2aMIUqiRdJAS3(((NamedMetadata)entityMetadata).Name, jd6noph2kB36YcYQqbQu(-812025778 ^ -812097280)));
				num2 = 4;
				break;
			case 4:
				PFy9nQh24jELDSd9gyk9(cHAlrMh2txNkGEgR2n3t(codeGenerator), x0B2qeh2w06sf1lPHPeL(entityMetadata));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				HgHcF6h2puB5DUg1ADdV(codeGenerator, entityMetadata);
				num2 = 3;
				break;
			}
		}
	}

	internal static IList<(MemoryStream, IMetadata)> GetPublishedDataClassAssemblies()
	{
		List<(MemoryStream, IMetadata)> list = new List<(MemoryStream, IMetadata)>();
		IRuntimeApplication service = Locator.GetService<IRuntimeApplication>();
		if (service == null)
		{
			return list;
		}
		ITransformationProvider transformationProvider = service.TransformationProvider;
		if (transformationProvider == null)
		{
			return list;
		}
		Dialect dialect = transformationProvider.Dialect;
		string text = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824491957));
		if (!existDataClassTable)
		{
			existDataClassTable = transformationProvider.TableExists(text);
			if (!existDataClassTable)
			{
				return list;
			}
		}
		string text2 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583699980));
		string text3 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x3418E897));
		string text4 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195734391));
		string text5 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426127257));
		string text6 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106365602));
		string sql = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138236800) + text2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583558176) + text3 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542776645) + text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x1247479C) + text4 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811982034) + text5 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487201308) + text6 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951430530) + text2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317583002);
		string text7 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852947708));
		string text8 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x47850ACF));
		string text9 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957694926));
		string text10 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822773852));
		string text11 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583777878));
		string text12 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7D4C88));
		string sql2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108057652) + text7 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x202541A3) + text8 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C5063D9) + text9 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307DC42D) + text10 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E742F9) + text11 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA61C7C) + text12 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68B8E96A) + text7 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487201328);
		using (IDataReader dataReader = transformationProvider.ExecuteQuery(sql))
		{
			while (dataReader.Read())
			{
				list.Add((dataReader.GetStream(text2), xmlObjSerType.NullSafeGet((DbDataReader)dataReader, new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x63802329) }, null, null) as IMetadata));
			}
		}
		using IDataReader dataReader2 = transformationProvider.ExecuteQuery(sql2);
		while (dataReader2.Read())
		{
			list.Add((dataReader2.GetStream(text7), xmlObjSerType.NullSafeGet((DbDataReader)dataReader2, new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AC55BF) }, null, null) as IMetadata));
		}
		return list;
	}

	internal static Version ReadVersion(MemoryStream assemblyRaw)
	{
		//Discarded unreachable code: IL_007f, IL_008e, IL_009e, IL_00ad
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (Version)qh3l81h2mgVKUx0JrORJ(((AssemblyDefinition)qnmfWLh20qMsqCMNONsZ(assemblyRaw)).get_Name());
			case 2:
			case 4:
				return null;
			case 1:
				if (assemblyRaw.Length <= 0)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 3:
				if (assemblyRaw == null)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			}
		}
	}

	internal static void InitVersion(MemoryStream assemblyRaw)
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
				InitVersion(wsgTxih2yfHXQuBbWlxn(assemblyRaw));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void InitVersion(Assembly assembly)
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
				uqcxUPh2Jw797M2uhUDm(Gp76QJh2MRq2pIGdNnns(assembly.GetName()));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void IncrementNextVersion()
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
				D6sUsvh2jy0igJREeyFf(new Version(LSqGloh2l1QYsqitYmo3(IEbE0Oh298sSABOsuw0M()), qdJ9MCh2rrDZg019PWgX(IEbE0Oh298sSABOsuw0M()), PFPbEfh2geGxqOZYorpG(NextVersion), mSKm11h2538C3hHdQIs1(IEbE0Oh298sSABOsuw0M()) + 1));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				ECTRGQh2dQHH484xZMZx(IEbE0Oh298sSABOsuw0M());
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private static void InitVersion(object oldVersion)
	{
		int num = 4;
		Version version = default(Version);
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
				case 1:
					if (qdJ9MCh2rrDZg019PWgX(version) == qdJ9MCh2rrDZg019PWgX(oldVersion))
					{
						num2 = 5;
						continue;
					}
					goto IL_0039;
				case 4:
					version = VersionInfo.GetVersion<SR>();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					if (LSqGloh2l1QYsqitYmo3(version) == LSqGloh2l1QYsqitYmo3(oldVersion))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto IL_0039;
				case 6:
					return;
				case 5:
					D6sUsvh2jy0igJREeyFf(new Version(version.Major, qdJ9MCh2rrDZg019PWgX(version), nJ0bPlh2Lxel915anPTf(0, PFPbEfh2geGxqOZYorpG(oldVersion)) + 1, 0));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					{
						if (Q44bojh2Yn5LXCt6yl0s(oldVersion, null))
						{
							break;
						}
						goto IL_0039;
					}
					IL_0039:
					NextVersion = new Version(version.Major, qdJ9MCh2rrDZg019PWgX(version), 0, 0);
					num2 = 6;
					continue;
				}
				break;
			}
			num = 2;
		}
	}

	static ConfigurationModelAssemblyBuilder()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				xmlObjSerType = new XmlObjectSerializableType();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				return;
			default:
				publishLogger = Logger.GetLogger(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17AED318));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				isConfigurationModelBuild = new ContextVars.Local<bool>();
				num2 = 3;
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object jd6noph2kB36YcYQqbQu(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object UYLVyQh2n75Q2HxQnL6d(object P_0)
	{
		return ((Stream)P_0).ReadAllBytes();
	}

	internal static object kykDiZh2O5maKboJtRgv(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static object Iebw0ph22FNJPZDHleG3()
	{
		return Encoding.UTF8;
	}

	internal static object uc7yrfh2e48nCOZe4IFZ(object P_0, object P_1, object P_2)
	{
		return ((Regex)P_0).Replace((string)P_1, (MatchEvaluator)P_2);
	}

	internal static int EhiU2Hh2Pj2Q9Enl11PH(object P_0, object P_1)
	{
		return ((string)P_0).IndexOf((string)P_1);
	}

	internal static int chqQrEh21U1nABbtfjsy(object P_0, object P_1, int P_2)
	{
		return ((string)P_0).LastIndexOf((string)P_1, P_2);
	}

	internal static object cirkUFh2NqtqjCVoZ4nM(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	internal static object UMBrZfh234A42cm4EViJ(object P_0, bool writable)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, writable);
	}

	internal static bool Qjrox2h2X5aUIwDWVH7w()
	{
		return DIZ4SUh2KcTBW3s8pYim == null;
	}

	internal static ConfigurationModelAssemblyBuilder AX3fWyh2TUU6oWFWXoTu()
	{
		return DIZ4SUh2KcTBW3s8pYim;
	}

	internal static void HgHcF6h2puB5DUg1ADdV(object P_0, object P_1)
	{
		((ICodeGenerator)P_0).Metadata = (IMetadata)P_1;
	}

	internal static object AnGQLHh2aMIUqiRdJAS3(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void yP4khUh2DRwacX57VI28(object P_0, object P_1)
	{
		((GenerationParams)P_0).FileName = (string)P_1;
	}

	internal static object cHAlrMh2txNkGEgR2n3t(object P_0)
	{
		return ((ICodeGenerator)P_0).GenerationParams;
	}

	internal static object x0B2qeh2w06sf1lPHPeL(object P_0)
	{
		return ((ClassMetadata)P_0).Namespace;
	}

	internal static void PFy9nQh24jELDSd9gyk9(object P_0, object P_1)
	{
		((GenerationParams)P_0).Namespace = (string)P_1;
	}

	internal static object Tiot7Fh26U4eGw3FlTDi(object P_0)
	{
		return ((ICodeGenerator)P_0).GenerateMainFile();
	}

	internal static object T63F4ph2HOoRnX179bRg(object P_0)
	{
		return ((GeneratedFileInfo)P_0).Data;
	}

	internal static bool CfvnDAh2A405sHcoT2M3(object P_0, object P_1)
	{
		return (Version)P_0 == (Version)P_1;
	}

	internal static object wOxsOKh27UeOG9WlKr3l(object P_0, bool isFullName)
	{
		return ComponentManager.FindLoadedAssembly((string)P_0, isFullName);
	}

	internal static object o3wc2Rh2xyAJ3bXsShIj(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object qnmfWLh20qMsqCMNONsZ(object P_0)
	{
		return AssemblyDefinition.ReadAssembly((Stream)P_0);
	}

	internal static object qh3l81h2mgVKUx0JrORJ(object P_0)
	{
		return ((AssemblyNameReference)P_0).get_Version();
	}

	internal static object wsgTxih2yfHXQuBbWlxn(object P_0)
	{
		return ReadVersion((MemoryStream)P_0);
	}

	internal static object Gp76QJh2MRq2pIGdNnns(object P_0)
	{
		return ((AssemblyName)P_0).Version;
	}

	internal static void uqcxUPh2Jw797M2uhUDm(object P_0)
	{
		InitVersion(P_0);
	}

	internal static object IEbE0Oh298sSABOsuw0M()
	{
		return NextVersion;
	}

	internal static void ECTRGQh2dQHH484xZMZx(object P_0)
	{
		CurrentVersion = (Version)P_0;
	}

	internal static int LSqGloh2l1QYsqitYmo3(object P_0)
	{
		return ((Version)P_0).Major;
	}

	internal static int qdJ9MCh2rrDZg019PWgX(object P_0)
	{
		return ((Version)P_0).Minor;
	}

	internal static int PFPbEfh2geGxqOZYorpG(object P_0)
	{
		return ((Version)P_0).Build;
	}

	internal static int mSKm11h2538C3hHdQIs1(object P_0)
	{
		return ((Version)P_0).Revision;
	}

	internal static void D6sUsvh2jy0igJREeyFf(object P_0)
	{
		NextVersion = (Version)P_0;
	}

	internal static bool Q44bojh2Yn5LXCt6yl0s(object P_0, object P_1)
	{
		return (Version)P_0 != (Version)P_1;
	}

	internal static int nJ0bPlh2Lxel915anPTf(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}
}
