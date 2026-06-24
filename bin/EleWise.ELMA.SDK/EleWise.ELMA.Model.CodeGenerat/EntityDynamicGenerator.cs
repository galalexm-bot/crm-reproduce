using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Accessors;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.SDK;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Collections.Generic;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public class EntityDynamicGenerator : EntityGenerator
{
	private class TypeReferenceFullNameComparer : IEqualityComparer<TypeReference>
	{
		private static object phYcphvGOYjv4v4Hhbo1;

		public static IEqualityComparer<TypeReference> Instance { get; }

		public bool Equals(TypeReference x, TypeReference y)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return v4b76WvG11c8U3dLKRjU(APW4vEvGPVq2KtAgqHeM(x), APW4vEvGPVq2KtAgqHeM(y));
				case 1:
					if (x == y)
					{
						return true;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public int GetHashCode(TypeReference obj)
		{
			return ((MemberReference)obj).get_FullName().GetHashCode();
		}

		public TypeReferenceFullNameComparer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.PushGlobal();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static TypeReferenceFullNameComparer()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					Instance = new TypeReferenceFullNameComparer();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					return;
				case 1:
					lLh9OyvGNFX9JtROvUOI();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static object APW4vEvGPVq2KtAgqHeM(object P_0)
		{
			return ((MemberReference)P_0).get_FullName();
		}

		internal static bool v4b76WvG11c8U3dLKRjU(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static bool GC5mATvG2Lx64qJqR5HL()
		{
			return phYcphvGOYjv4v4Hhbo1 == null;
		}

		internal static TypeReferenceFullNameComparer HUJQ9uvGe7TEMLyFjXBZ()
		{
			return (TypeReferenceFullNameComparer)phYcphvGOYjv4v4Hhbo1;
		}

		internal static void lLh9OyvGNFX9JtROvUOI()
		{
			SingletonReader.PushGlobal();
		}
	}

	private class MethodReferenceFullNameComparer : IEqualityComparer<MethodReference>
	{
		private static object jDpYgXvG3LDaaL7aDwU8;

		public static IEqualityComparer<MethodReference> Instance { get; }

		public bool Equals(MethodReference x, MethodReference y)
		{
			return x == y;
		}

		public int GetHashCode(MethodReference obj)
		{
			return ((object)obj).GetHashCode();
		}

		public MethodReferenceFullNameComparer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			V1h62EvGDjfDqZN4ap4x();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static MethodReferenceFullNameComparer()
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
					Instance = new MethodReferenceFullNameComparer();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					SingletonReader.PushGlobal();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				}
			}
		}

		internal static bool YNV2tvvGpn4IxTUJEkYT()
		{
			return jDpYgXvG3LDaaL7aDwU8 == null;
		}

		internal static MethodReferenceFullNameComparer K6G47lvGaW2LFpTcX3ES()
		{
			return (MethodReferenceFullNameComparer)jDpYgXvG3LDaaL7aDwU8;
		}

		internal static void V1h62EvGDjfDqZN4ap4x()
		{
			SingletonReader.PushGlobal();
		}
	}

	private class LazyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		private readonly IDictionary<TKey, Lazy<TValue>> dictionary;

		private static object nXJHO0vGt6gxfcyOmpZp;

		public TValue this[TKey key]
		{
			get
			{
				return dictionary[key].Value;
			}
			set
			{
				_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
				CS_0024_003C_003E8__locals0.value = value;
				dictionary[key] = new Lazy<TValue>(() => CS_0024_003C_003E8__locals0.value);
			}
		}

		public ICollection<TKey> Keys => dictionary.Keys;

		public ICollection<TValue> Values
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int Count => dictionary.Count;

		public bool IsReadOnly => false;

		public LazyDictionary()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.PushGlobal();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
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
				dictionary = new Dictionary<TKey, Lazy<TValue>>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num = 1;
				}
			}
		}

		public LazyDictionary(IEqualityComparer<TKey> comparer)
		{
			SingletonReader.PushGlobal();
			base._002Ector();
			dictionary = new Dictionary<TKey, Lazy<TValue>>(comparer);
		}

		public void Add(TKey key, TValue value)
		{
			_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
			CS_0024_003C_003E8__locals0.value = value;
			dictionary.Add(key, new Lazy<TValue>(() => CS_0024_003C_003E8__locals0.value));
		}

		public void Add(TKey key, Func<TValue> valueFunc)
		{
			dictionary.Add(key, new Lazy<TValue>(valueFunc));
		}

		public void Add(KeyValuePair<TKey, TValue> item)
		{
			Add(item.Key, item.Value);
		}

		public void Clear()
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
					dictionary.Clear();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public bool ContainsKey(TKey key)
		{
			return dictionary.ContainsKey(key);
		}

		public bool Remove(TKey key)
		{
			return dictionary.Remove(key);
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			if (dictionary.TryGetValue(key, out var value2))
			{
				value = value2.Value;
				return true;
			}
			value = default(TValue);
			return false;
		}

		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			throw new NotImplementedException();
		}

		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			throw new NotImplementedException();
		}

		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			throw new NotImplementedException();
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		internal static bool sxPN0rvGwss3QUdoBfEb()
		{
			return nXJHO0vGt6gxfcyOmpZp == null;
		}

		internal static object uGREQcvG4tS9Oyu84YaZ()
		{
			return nXJHO0vGt6gxfcyOmpZp;
		}
	}

	private class DeltaAssemblyProcessor
	{
		private readonly object module;

		private readonly IList<Type> changedTypes;

		private readonly IList<TypeDefinition> newTypes;

		private readonly IList<TypeDefinition> newPublicApiTypes;

		private readonly IList<TypeDefinition> dataClasses;

		private readonly ISet<TypeDefinition> typesToRemove;

		private readonly IList<(Type type, TypeDefinition typeDefinition, int index)> typesToRename;

		private readonly IDictionary<TypeReference, TypeReference> typesToReplace;

		private readonly LazyDictionary<MethodReference, MethodReference> methodsToReplace;

		private readonly LazyDictionary<FieldReference, FieldReference> fieldsToReplace;

		private readonly IDictionary<MethodDefinition, string> replaceMethods;

		internal static object J3I0fUvG6IXsDGOEv1d5;

		public DeltaAssemblyProcessor(ModuleDefinition module)
		{
			//Discarded unreachable code: IL_00d4, IL_00d9
			yJV7eEvG7LJ5q9M2EslM();
			changedTypes = new List<Type>();
			newTypes = new List<TypeDefinition>();
			newPublicApiTypes = new List<TypeDefinition>();
			dataClasses = new List<TypeDefinition>();
			typesToRemove = new HashSet<TypeDefinition>();
			typesToRename = new List<(Type, TypeDefinition, int)>();
			typesToReplace = new Dictionary<TypeReference, TypeReference>(TypeReferenceFullNameComparer.Instance);
			methodsToReplace = new LazyDictionary<MethodReference, MethodReference>(MethodReferenceFullNameComparer.Instance);
			fieldsToReplace = new LazyDictionary<FieldReference, FieldReference>();
			replaceMethods = new Dictionary<MethodDefinition, string>();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
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
					this.module = module;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public void Process()
		{
			int num = 2;
			Dictionary<TypeReference, string> dictionary = default(Dictionary<TypeReference, string>);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 7:
						return;
					default:
						ProcessDataClasses();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num2 = 6;
						}
						continue;
					case 5:
						ProceedPublicApi(((ModuleDefinition)module).GetType((string)uvMl8QvGxXJLNc1YU10F(-951514650 ^ -951498544)), dictionary);
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num2 = 3;
						}
						continue;
					case 2:
						ProceedTypes();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
						dictionary = new Dictionary<TypeReference, string>();
						num2 = 5;
						continue;
					case 4:
						ReplaceTypes();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 0;
						}
						continue;
					case 6:
						dictionary.ForEach(delegate(KeyValuePair<TypeReference, string> p)
						{
							EntityDynamicGenerator.AddReplace((object)p.Value, (object)CreateReference(p.Key));
						});
						num2 = 3;
						continue;
					case 3:
						replaceMethods.ForEach(delegate(KeyValuePair<MethodDefinition, string> p)
						{
							EntityDynamicGenerator.AddReplace((object)p.Value, (object)CreateReference((MethodReference)(object)p.Key));
						});
						num = 7;
						break;
					}
					break;
				}
			}
		}

		public Assembly PostProcess(Assembly result, out IEnumerable<Type> changedTypes, out IEnumerable<Type> newTypes)
		{
			//Discarded unreachable code: IL_00c1, IL_00d0, IL_00db, IL_0200, IL_0230, IL_023f, IL_024b
			int num = 6;
			int num2 = num;
			_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_0);
			IEnumerator<(Type, Type)> enumerator = default(IEnumerator<(Type, Type)>);
			Type item = default(Type);
			Type item2 = default(Type);
			while (true)
			{
				switch (num2)
				{
				case 5:
					_003C_003Ec__DisplayClass13_.result = result;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					ReflectionType.Register(newPublicApiTypes.Select(_003C_003Ec__DisplayClass13_._003CPostProcess_003Eb__1).ToArray());
					num2 = 2;
					break;
				case 6:
					_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 5;
					}
					break;
				default:
					return _003C_003Ec__DisplayClass13_.result;
				case 3:
					try
					{
						while (true)
						{
							int num3;
							if (!nI2mXnvGmait7AmwPp5n(enumerator))
							{
								num3 = 4;
								goto IL_00df;
							}
							goto IL_013d;
							IL_00df:
							while (true)
							{
								switch (num3)
								{
								case 3:
									break;
								case 1:
									S0PAadvG08Qi9OROsEwM(item, item2.GetNestedType((string)uvMl8QvGxXJLNc1YU10F(-105199646 ^ -105282088), BindingFlags.NonPublic));
									num3 = 3;
									continue;
								default:
									goto IL_013d;
								case 2:
									item.AddAccessors(from t in item2.GetNestedTypes(BindingFlags.NonPublic)
										where _003C_003Ec.HwTT9tZq3qv44OlWRBLi(_003C_003Ec.L92kUoZq10ciSaZcsHp6(t), _003C_003Ec.a9fLdkZqNth1063Ec3v1(0x269E5FCA ^ 0x269D0FD6))
										select _003C_003Ec.mQcwDqZqpWQHARjF5EP1(t.GetField((string)_003C_003Ec.a9fLdkZqNth1063Ec3v1(0x1637C429 ^ 0x16327A35)), null));
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
									{
										num3 = 1;
									}
									continue;
								case 4:
									goto end_IL_00fd;
								}
								break;
							}
							continue;
							IL_013d:
							(Type, Type) current = enumerator.Current;
							item = current.Item1;
							item2 = current.Item2;
							num3 = 2;
							goto IL_00df;
							continue;
							end_IL_00fd:
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator == null)
						{
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
							{
								num4 = 0;
							}
							goto IL_0204;
						}
						goto IL_021a;
						IL_021a:
						UwdDNsvGyVPTLJ7XKuQ5(enumerator);
						num4 = 2;
						goto IL_0204;
						IL_0204:
						switch (num4)
						{
						case 1:
							goto end_IL_01df;
						case 2:
							goto end_IL_01df;
						}
						goto IL_021a;
						end_IL_01df:;
					}
					goto case 7;
				case 8:
					newTypes = this.newTypes.Select(_003C_003Ec__DisplayClass13_._003CPostProcess_003Eb__0).ToArray();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 1;
					}
					break;
				case 9:
					changedTypes = this.changedTypes;
					num2 = 8;
					break;
				case 7:
					ReflectionType.Register(newTypes);
					num2 = 4;
					break;
				case 1:
					enumerator = typesToRename.Where(((Type type, TypeDefinition typeDefinition, int index) t) => t.index > 0).Select(_003C_003Ec__DisplayClass13_._003CPostProcess_003Eb__4).GetEnumerator();
					num2 = 3;
					break;
				case 2:
					ReflectionType.AddManifestResources(_003C_003Ec__DisplayClass13_.result, from r in ((IEnumerable)((ModuleDefinition)module).get_Resources()).OfType<EmbeddedResource>()
						select (((Resource)r).get_Name(), r.GetResourceData()));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		private void AddMethodReplace(MethodReference fromMethod, MethodDefinition toMethod)
		{
			int num = 2;
			int num2 = num;
			string text = default(string);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					text = (string)eh79NsvGMsWrtjkBuyqL(fromMethod);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					replaceMethods[toMethod] = text;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 1:
					EntityDynamicGenerator.AddReplace((object)text, (object)toMethod);
					num2 = 3;
					break;
				}
			}
		}

		private void ProceedTypes()
		{
			//Discarded unreachable code: IL_002f, IL_02a8, IL_02b7, IL_0547, IL_0556, IL_0566, IL_0575, IL_05ac, IL_05bb, IL_0643, IL_0652, IL_0662, IL_06ea, IL_06f9, IL_07b1, IL_08c0, IL_08d3, IL_08e3, IL_08ed, IL_09ea, IL_09fd, IL_0a9c, IL_0aab, IL_0c28, IL_0cdf, IL_0daf, IL_0de0, IL_0f3c, IL_0f4b, IL_0fdb, IL_100c, IL_101b, IL_10b3, IL_10bd, IL_112d, IL_113c, IL_133c, IL_134f, IL_13a5, IL_17ad, IL_17ed, IL_17f8, IL_1807
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0292: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_0412: Unknown result type (might be due to invalid IL or missing references)
			//IL_0417: Unknown result type (might be due to invalid IL or missing references)
			//IL_046b: Unknown result type (might be due to invalid IL or missing references)
			//IL_047a: Expected O, but got Unknown
			//IL_0c41: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c46: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d47: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d4c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d80: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d8a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e41: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e52: Expected O, but got Unknown
			//IL_102e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1033: Unknown result type (might be due to invalid IL or missing references)
			//IL_13fa: Unknown result type (might be due to invalid IL or missing references)
			int num = 2;
			int num2 = num;
			IEnumerator<TypeDefinition> enumerator = default(IEnumerator<TypeDefinition>);
			_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
			TypeDefinition val = default(TypeDefinition);
			_003C_003Ec__DisplayClass15_2 CS_0024_003C_003E8__locals0 = default(_003C_003Ec__DisplayClass15_2);
			_003C_003Ec__DisplayClass15_1 _003C_003Ec__DisplayClass15_2 = default(_003C_003Ec__DisplayClass15_1);
			MethodDefinition val2 = default(MethodDefinition);
			TypeReference val5 = default(TypeReference);
			Enumerator<PropertyDefinition> enumerator3 = default(Enumerator<PropertyDefinition>);
			Dictionary<TypeReference, TypeDefinition> dictionary = default(Dictionary<TypeReference, TypeDefinition>);
			CustomAttribute val6 = default(CustomAttribute);
			Enumerator<FieldDefinition> enumerator2 = default(Enumerator<FieldDefinition>);
			TypeReference toType = default(TypeReference);
			PropertyDefinition property = default(PropertyDefinition);
			MethodReference toMethod = default(MethodReference);
			_003C_003Ec__DisplayClass15_4 _003C_003Ec__DisplayClass15_3 = default(_003C_003Ec__DisplayClass15_4);
			CustomAttributeArgument val4 = default(CustomAttributeArgument);
			CustomAttribute val3 = default(CustomAttribute);
			_003C_003Ec__DisplayClass15_7 _003C_003Ec__DisplayClass15_4 = default(_003C_003Ec__DisplayClass15_7);
			TypeReference value = default(TypeReference);
			PropertyDefinition val7 = default(PropertyDefinition);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					try
					{
						while (true)
						{
							int num3;
							if (!nI2mXnvGmait7AmwPp5n(enumerator))
							{
								num3 = 42;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
								{
									num3 = 25;
								}
								goto IL_003d;
							}
							goto IL_0cbd;
							IL_0cbd:
							_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
							num3 = 84;
							goto IL_003d;
							IL_003d:
							while (true)
							{
								int num4;
								TypeDefinition obj;
								switch (num3)
								{
								case 42:
									return;
								case 79:
									val.get_Interfaces().Remove((TypeReference)(object)CS_0024_003C_003E8__locals0.dataInterface);
									num3 = 67;
									continue;
								case 11:
									_003C_003Ec__DisplayClass15_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass15_;
									num3 = 33;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
									{
										num3 = 15;
									}
									continue;
								case 15:
									((GenericInstanceType)uiODTXvEXjtqE8iVvQ63(val2)).get_GenericArguments().set_Item(1, val5);
									num3 = 69;
									continue;
								case 16:
									eTRpChvES4aQlwFnuCXQ(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.typeDefinition.get_Properties());
									num3 = 20;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
									{
										num3 = 5;
									}
									continue;
								case 60:
									if (!TjuKRVvGr77Vq9RWDrQ3(Kh22nkvGlDuDhQEdwFuH(Yux9bmvGdusih5pI7WbC(((ModuleDefinition)module).get_Assembly())), uvMl8QvGxXJLNc1YU10F(-138018305 ^ -138016671)))
									{
										num3 = 34;
										continue;
									}
									goto case 2;
								case 40:
								case 54:
									CS_0024_003C_003E8__locals0.oldProperties = new Dictionary<string, TypeReference>();
									num3 = 62;
									continue;
								case 50:
									enumerator3 = val.get_Properties().GetEnumerator();
									num3 = 41;
									continue;
								case 86:
									fiJ5oMvEiWsx9rNYFLiI(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.typeDefinition.get_Interfaces());
									num3 = 38;
									continue;
								case 51:
									((ICollection<TypeReference>)val.get_Interfaces()).AddRange(((IEnumerable<TypeDefinition>)dictionary.Values).Select((Func<TypeDefinition, TypeReference>)((ModuleDefinition)module).Import));
									num3 = 24;
									continue;
								case 83:
									if (val6 != null)
									{
										num3 = 27;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
										{
											num3 = 3;
										}
										continue;
									}
									goto case 71;
								case 2:
									_003C_003Ec__DisplayClass15_2.type = blrqYKvGjPVUAOiDUwKf(o30ebSvG5buVdwaPnnni(ve3HnmvGg9SRuNo1X9NL(_003C_003Ec__DisplayClass15_2.CS_0024_003C_003E8__locals1.typeDefinition), uvMl8QvGxXJLNc1YU10F(0x5F3078B6 ^ 0x5F3074B4), uvMl8QvGxXJLNc1YU10F(0x571EA399 ^ 0x571EA9B7)));
									num3 = 80;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
									{
										num3 = 68;
									}
									continue;
								case 84:
									_003C_003Ec__DisplayClass15_._003C_003E4__this = this;
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
									{
										num3 = 0;
									}
									continue;
								case 48:
									dataClasses.Add(val);
									num3 = 37;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
									{
										num3 = 74;
									}
									continue;
								case 10:
								case 77:
									changedTypes.Add(_003C_003Ec__DisplayClass15_2.type);
									num3 = 19;
									continue;
								case 59:
									enumerator2 = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.typeDefinition.get_Fields().GetEnumerator();
									num3 = 81;
									continue;
								case 30:
									EntityDynamicGenerator.AddReplace((object)((MemberReference)_003C_003Ec__DisplayClass15_2.CS_0024_003C_003E8__locals1.typeDefinition).get_FullName(), (object)CreateReference(_003C_003Ec__DisplayClass15_2.type));
									num3 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
									{
										num3 = 5;
									}
									continue;
								case 47:
									bvuQN2vECrVeDy0OfQR8((object)(AssemblyNameReference)nSDsHdvEQbrUbcNuMVtd(CS_0024_003C_003E8__locals0.interfaceReference), ConfigurationModelAssemblyBuilder.Version);
									num3 = 54;
									continue;
								case 37:
									if (t0LFWQvGLkwCNOQT7Nkv(_003C_003Ec__DisplayClass15_2.CS_0024_003C_003E8__locals1.typeDefinition))
									{
										num3 = 23;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
										{
											num3 = 55;
										}
										continue;
									}
									goto case 12;
								case 63:
									typesToReplace.Add((TypeReference)(object)_003C_003Ec__DisplayClass15_2.CS_0024_003C_003E8__locals1.typeDefinition, (TypeReference)HmmgRuvGzuZoSyXVH2J0(module, _003C_003Ec__DisplayClass15_2.type));
									num3 = 26;
									continue;
								case 78:
									if (TryGetReplace((object)CS_0024_003C_003E8__locals0.interfaceReference, out toType))
									{
										num3 = 44;
										continue;
									}
									goto case 76;
								case 67:
									CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.typeDefinition.get_NestedTypes().Remove(CS_0024_003C_003E8__locals0.dataInterface);
									num3 = 53;
									continue;
								case 66:
									CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_2();
									num3 = 70;
									continue;
								case 31:
								case 32:
								case 65:
								case 68:
								case 74:
									break;
								case 39:
									try
									{
										while (true)
										{
											IL_0618:
											int num7;
											if (!enumerator3.MoveNext())
											{
												num7 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
												{
													num7 = 0;
												}
												goto IL_05ca;
											}
											goto IL_066c;
											IL_066c:
											property = enumerator3.get_Current();
											num7 = 7;
											goto IL_05ca;
											IL_05ca:
											while (true)
											{
												object obj3;
												object obj2;
												MethodReference toMethod2;
												switch (num7)
												{
												case 6:
												case 10:
												case 15:
												case 16:
													goto IL_0618;
												case 11:
													goto IL_066c;
												case 9:
													CS_0024_003C_003E8__locals0.oldProperties.Add((string)wInmYJvEv3L9TNLy3x4u(property), (TypeReference)kQK1kPvEIqbY1Us6wjtc(module, wEI7NVvEuI7pod8jreDD(toMethod)));
													num7 = 15;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
													{
														num7 = 14;
													}
													continue;
												case 8:
													obj3 = BygEN7vE8efWKaQSk1lt(property);
													if (obj3 == null)
													{
														num7 = 13;
														continue;
													}
													goto IL_0832;
												case 5:
												case 12:
													if (((IEnumerable<char>)wInmYJvEv3L9TNLy3x4u(property)).Contains('.'))
													{
														num7 = 14;
														continue;
													}
													goto case 2;
												case 3:
													ChangeMethod((MethodDefinition)Vv3A5dvEZU8w4vZdEDAL(property));
													num7 = 16;
													continue;
												case 7:
													if (CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.type.GetProperty((string)wInmYJvEv3L9TNLy3x4u(property), BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic) != null)
													{
														int num8 = 4;
														num7 = num8;
														continue;
													}
													goto case 8;
												case 2:
													ChangeMethod((MethodDefinition)BygEN7vE8efWKaQSk1lt(property));
													num7 = 3;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
													{
														num7 = 0;
													}
													continue;
												case 4:
													CS_0024_003C_003E8__locals0.oldProperties.Add(((MemberReference)property).get_Name(), typesToReplace[(TypeReference)(object)CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.typeDefinition]);
													num7 = 10;
													continue;
												case 14:
													obj2 = BygEN7vE8efWKaQSk1lt(property);
													if (obj2 == null)
													{
														num7 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
														{
															num7 = 1;
														}
														continue;
													}
													goto IL_0864;
												case 13:
													obj3 = Vv3A5dvEZU8w4vZdEDAL(property);
													goto IL_0832;
												case 1:
													obj2 = Vv3A5dvEZU8w4vZdEDAL(property);
													goto IL_0864;
												case 0:
													break;
													IL_0864:
													if (TryGetReplace((object)((IEnumerable<MethodReference>)((MethodDefinition)obj2).get_Overrides()).Single(), out toMethod2))
													{
														num7 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
														{
															num7 = 6;
														}
														continue;
													}
													goto case 2;
													IL_0832:
													if (!TryGetReplace(obj3, out toMethod))
													{
														num7 = 5;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
														{
															num7 = 2;
														}
														continue;
													}
													goto case 9;
												}
												break;
											}
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator3).Dispose();
										int num9 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
										{
											num9 = 0;
										}
										switch (num9)
										{
										case 0:
											break;
										}
									}
									goto case 59;
								case 81:
									try
									{
										while (true)
										{
											IL_0985:
											int num5;
											if (!enumerator2.MoveNext())
											{
												num5 = 5;
												goto IL_08f1;
											}
											goto IL_0964;
											IL_08f1:
											while (true)
											{
												switch (num5)
												{
												case 1:
													_003C_003Ec__DisplayClass15_3.field = enumerator2.get_Current();
													num5 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
													{
														num5 = 2;
													}
													continue;
												case 2:
													fieldsToReplace.Add((FieldReference)(object)_003C_003Ec__DisplayClass15_3.field, (Func<FieldReference>)_003C_003Ec__DisplayClass15_3._003CProceedTypes_003Eb__12);
													num5 = 4;
													continue;
												case 3:
													break;
												case 4:
													goto IL_0985;
												default:
													_003C_003Ec__DisplayClass15_3.CS_0024_003C_003E8__locals3 = CS_0024_003C_003E8__locals0;
													num5 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
													{
														num5 = 1;
													}
													continue;
												case 5:
													goto end_IL_0985;
												}
												break;
											}
											goto IL_0964;
											IL_0964:
											_003C_003Ec__DisplayClass15_3 = new _003C_003Ec__DisplayClass15_4();
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
											{
												num5 = 0;
											}
											goto IL_08f1;
											continue;
											end_IL_0985:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator2).Dispose();
										int num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
										{
											num6 = 0;
										}
										switch (num6)
										{
										case 0:
											break;
										}
									}
									goto case 57;
								case 76:
									CS_0024_003C_003E8__locals0.interfaceReference = (TypeReference)SgYwTBvGsZXiv9mcMcLn(CS_0024_003C_003E8__locals0.interfaceReference);
									num4 = 47;
									goto IL_0039;
								case 8:
								case 34:
								case 55:
								case 75:
									if (NHZVdivG9EIWnGIEo7Wb(_003C_003Ec__DisplayClass15_2.type, null))
									{
										num3 = 23;
										continue;
									}
									goto case 10;
								case 70:
									CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2 = _003C_003Ec__DisplayClass15_2;
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
									{
										num3 = 6;
									}
									continue;
								case 45:
									if (TjsW5bvEWsXmqfRMRj1S(_003C_003Ec__DisplayClass15_2.CS_0024_003C_003E8__locals1.typeDefinition))
									{
										num3 = 20;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
										{
											num3 = 61;
										}
										continue;
									}
									goto case 36;
								case 21:
									typesToReplace.Add((TypeReference)(object)_003C_003Ec__DisplayClass15_2.CS_0024_003C_003E8__locals1.typeDefinition, null);
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
									{
										num3 = 1;
									}
									continue;
								case 57:
									h1944kvEVF6xL7w5IdmZ(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.typeDefinition.get_Fields());
									num3 = 16;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
									{
										num3 = 14;
									}
									continue;
								case 52:
								case 53:
									val5 = (TypeReference)HmmgRuvGzuZoSyXVH2J0(module, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.type.GetNestedType((string)uvMl8QvGxXJLNc1YU10F(-1978478350 ^ -1978556814), BindingFlags.NonPublic));
									num3 = 3;
									continue;
								case 56:
									if (CS_0024_003C_003E8__locals0.interfaceReference != null)
									{
										num3 = 78;
										continue;
									}
									goto case 40;
								case 24:
									typesToRename.Add((CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.type, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.typeDefinition, dk3BxavEqNqF5pqWao9W(dictionary)));
									num3 = 22;
									continue;
								case 73:
									((ICollection<TypeDefinition>)CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.typeDefinition.get_NestedTypes()).RemoveAll(CS_0024_003C_003E8__locals0._003CProceedTypes_003Eb__9);
									num4 = 86;
									goto IL_0039;
								case 23:
									WvokcgvGc651au2ZrVEN(((MemberReference)_003C_003Ec__DisplayClass15_2.CS_0024_003C_003E8__locals1.typeDefinition).get_FullName(), SgYwTBvGsZXiv9mcMcLn(_003C_003Ec__DisplayClass15_2.CS_0024_003C_003E8__locals1.typeDefinition));
									num3 = 21;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
									{
										num3 = 15;
									}
									continue;
								case 58:
								{
									Type type = _003C_003Ec__DisplayClass15_2.type;
									val4 = val3.get_ConstructorArguments().get_Item(0);
									PublishCacheContext.RemoveFromCache(type, new Guid((string)((CustomAttributeArgument)(ref val4)).get_Value()));
									num3 = 63;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
									{
										num3 = 11;
									}
									continue;
								}
								case 80:
									if (!hZ5pgtvGYIsGToUNxTBI(_003C_003Ec__DisplayClass15_2.type, null))
									{
										num3 = 75;
										continue;
									}
									goto case 37;
								case 49:
									((ICollection<PropertyDefinition>)CS_0024_003C_003E8__locals0.dataInterface.get_Properties()).RemoveAll(CS_0024_003C_003E8__locals0._003CProceedTypes_003Eb__16);
									num3 = 9;
									continue;
								case 17:
									goto IL_0cbd;
								case 71:
									obj = _003C_003Ec__DisplayClass15_2.CS_0024_003C_003E8__locals1.typeDefinition;
									goto IL_1404;
								case 43:
									_003C_003Ec__DisplayClass15_2 = new _003C_003Ec__DisplayClass15_1();
									num3 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
									{
										num3 = 11;
									}
									continue;
								case 46:
									if (!NHZVdivG9EIWnGIEo7Wb(_003C_003Ec__DisplayClass15_2.type, null))
									{
										num3 = 77;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
										{
											num3 = 38;
										}
										continue;
									}
									goto case 60;
								case 18:
									enumerator3 = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.typeDefinition.get_Properties().GetEnumerator();
									num3 = 39;
									continue;
								case 13:
									if (CS_0024_003C_003E8__locals0.dataInterface == null)
									{
										num3 = 65;
										continue;
									}
									goto case 49;
								case 25:
								{
									TypeDefinition typeDefinition = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.typeDefinition;
									GTCaPpvEfFhWLaE6pBsm(typeDefinition, (TypeAttributes)(liM4RfvEEUCDxVFNfy8q(typeDefinition) | 0x180));
									num3 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
									{
										num3 = 1;
									}
									continue;
								}
								case 61:
									typesToRemove.Add(_003C_003Ec__DisplayClass15_2.CS_0024_003C_003E8__locals1.typeDefinition);
									num3 = 5;
									continue;
								case 7:
									KBZboEvEGtxDPjt5srNF(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.typeDefinition, gE6YgSvEhHS3Vuexw5Hc(Y5kG0wvEbiHEwhpSdYxY(module)));
									num3 = 9;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
									{
										num3 = 25;
									}
									continue;
								case 69:
									cdBAdVvEnWbbUqffIMS1((object)(MethodReference)PT5qrFvEkeAydYxrNoNv(((MethodBody)KmMBmEvETLs96EVeDsVO(val2)).get_Instructions().get_Item(2)), uiODTXvEXjtqE8iVvQ63(val2));
									num3 = 50;
									continue;
								case 64:
									typesToRemove.Add(_003C_003Ec__DisplayClass15_2.CS_0024_003C_003E8__locals1.typeDefinition);
									num4 = 35;
									goto IL_0039;
								case 12:
									Qwa0HyvGU9pCKbqYjQSr(_003C_003Ec__DisplayClass15_2.type);
									num3 = 30;
									continue;
								case 44:
									CS_0024_003C_003E8__locals0.interfaceReference = toType;
									num3 = 40;
									continue;
								case 26:
									if (e8DWhivEF9AG02bN9PuV(_003C_003Ec__DisplayClass15_2.CS_0024_003C_003E8__locals1.typeDefinition))
									{
										num3 = 64;
										continue;
									}
									goto case 45;
								case 36:
									if (OEvGWZvEo54avmnJjd48(_003C_003Ec__DisplayClass15_2.CS_0024_003C_003E8__locals1.typeDefinition))
									{
										num3 = 66;
										continue;
									}
									break;
								default:
									_003C_003Ec__DisplayClass15_.typeDefinition = enumerator.Current;
									num4 = 43;
									goto IL_0039;
								case 22:
									if (CIeW1LvEKJqbRVaJsJ3O(CS_0024_003C_003E8__locals0.dataInterface.get_Properties()) != 0)
									{
										num3 = 49;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
										{
											num3 = 52;
										}
										continue;
									}
									goto case 79;
								case 1:
									newTypes.Add(_003C_003Ec__DisplayClass15_2.CS_0024_003C_003E8__locals1.typeDefinition);
									num3 = 32;
									continue;
								case 6:
									EntityDynamicProvider.AddType(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.type, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.typeDefinition);
									num3 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
									{
										num3 = 5;
									}
									continue;
								case 28:
									((MethodReference)val2).set_ReturnType(val5);
									num3 = 13;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
									{
										num3 = 72;
									}
									continue;
								case 5:
									EntityDynamicProvider.AddType(_003C_003Ec__DisplayClass15_2.type, _003C_003Ec__DisplayClass15_2.CS_0024_003C_003E8__locals1.typeDefinition);
									num3 = 14;
									continue;
								case 27:
									val4 = val6.get_ConstructorArguments().get_Item(0);
									num4 = 85;
									goto IL_0039;
								case 20:
									((ICollection<MethodDefinition>)CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.typeDefinition.get_Methods()).RemoveAll(delegate(MethodDefinition method)
									{
										//Discarded unreachable code: IL_00b3, IL_00c2, IL_0166, IL_0218
										int num16 = 9;
										_003C_003Ec__DisplayClass15_6 _003C_003Ec__DisplayClass15_6 = default(_003C_003Ec__DisplayClass15_6);
										_003C_003Ec__DisplayClass15_5 _003C_003Ec__DisplayClass15_5 = default(_003C_003Ec__DisplayClass15_5);
										while (true)
										{
											int num17 = num16;
											while (true)
											{
												switch (num17)
												{
												case 7:
													_003C_003Ec__DisplayClass15_6.CS_0024_003C_003E8__locals5 = _003C_003Ec__DisplayClass15_5;
													num16 = 4;
													break;
												case 13:
													if (!CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this.replaceMethods.ContainsKey(_003C_003Ec__DisplayClass15_5.method))
													{
														num17 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
														{
															num17 = 1;
														}
														continue;
													}
													goto case 15;
												case 15:
													CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this.methodsToReplace.Add((MethodReference)(object)_003C_003Ec__DisplayClass15_5.method, (MethodReference)(object)_003C_003Ec__DisplayClass15_5.method);
													num17 = 12;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
													{
														num17 = 2;
													}
													continue;
												case 3:
												case 10:
												case 14:
													return true;
												case 8:
													_003C_003Ec__DisplayClass15_5.CS_0024_003C_003E8__locals4 = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2;
													num17 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
													{
														num17 = 0;
													}
													continue;
												case 12:
													return false;
												case 1:
													if (_003C_003Ec__DisplayClass15_1.Lyu3YbZKotyEKEoiTAXT(_003C_003Ec__DisplayClass15_1.KHQwAfZKBriaEWbaFnEY(_003C_003Ec__DisplayClass15_5.method), _003C_003Ec__DisplayClass15_1.SKhi3uZKWwfV5LeRrC5n(-1998538950 ^ -1998330254)))
													{
														num17 = 5;
														continue;
													}
													goto case 11;
												case 4:
													if (TryGetReplace((object)_003C_003Ec__DisplayClass15_6.CS_0024_003C_003E8__locals5.method, out _003C_003Ec__DisplayClass15_6.m))
													{
														num17 = 2;
														continue;
													}
													goto case 6;
												case 9:
													_003C_003Ec__DisplayClass15_5 = new _003C_003Ec__DisplayClass15_5();
													num17 = 8;
													continue;
												default:
													_003C_003Ec__DisplayClass15_5.method = method;
													num17 = 13;
													continue;
												case 11:
													_003C_003Ec__DisplayClass15_6 = new _003C_003Ec__DisplayClass15_6();
													num17 = 7;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
													{
														num17 = 3;
													}
													continue;
												case 2:
													CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this.methodsToReplace.Add((MethodReference)(object)_003C_003Ec__DisplayClass15_6.CS_0024_003C_003E8__locals5.method, (Func<MethodReference>)_003C_003Ec__DisplayClass15_6._003CProceedTypes_003Eb__14);
													num17 = 14;
													continue;
												case 6:
													CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this.methodsToReplace.Add((MethodReference)(object)_003C_003Ec__DisplayClass15_6.CS_0024_003C_003E8__locals5.method, (Func<MethodReference>)delegate
													{
														//Discarded unreachable code: IL_003a, IL_0049, IL_0054, IL_00ff, IL_0112, IL_0121, IL_014f, IL_015e, IL_0169, IL_0230, IL_0243, IL_0252
														//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
														//IL_01ea: Expected O, but got Unknown
														//IL_0268: Unknown result type (might be due to invalid IL or missing references)
														//IL_026d: Unknown result type (might be due to invalid IL or missing references)
														//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
														//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
														//IL_02df: Expected O, but got Unknown
														//IL_02df: Unknown result type (might be due to invalid IL or missing references)
														//IL_02f0: Expected O, but got Unknown
														//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
														//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
														//IL_0301: Expected O, but got Unknown
														//IL_0303: Expected O, but got Unknown
														//IL_0318: Unknown result type (might be due to invalid IL or missing references)
														//IL_031d: Unknown result type (might be due to invalid IL or missing references)
														int num18 = 3;
														int num19 = num18;
														Enumerator<ParameterDefinition> enumerator4 = default(Enumerator<ParameterDefinition>);
														ParameterDefinition current = default(ParameterDefinition);
														MethodReference val11 = default(MethodReference);
														Enumerator<GenericParameter> enumerator5 = default(Enumerator<GenericParameter>);
														GenericParameter current2 = default(GenericParameter);
														while (true)
														{
															switch (num19)
															{
															default:
																try
																{
																	while (true)
																	{
																		int num20;
																		if (!enumerator4.MoveNext())
																		{
																			num20 = 1;
																			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
																			{
																				num20 = 2;
																			}
																			goto IL_0058;
																		}
																		goto IL_0098;
																		IL_0098:
																		current = enumerator4.get_Current();
																		num20 = 0;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
																		{
																			num20 = 0;
																		}
																		goto IL_0058;
																		IL_0058:
																		while (true)
																		{
																			switch (num20)
																			{
																			case 3:
																				break;
																			case 1:
																				goto IL_0098;
																			default:
																				val11.get_Parameters().Add(current);
																				num20 = 3;
																				continue;
																			case 2:
																				goto end_IL_0072;
																			}
																			break;
																		}
																		continue;
																		end_IL_0072:
																		break;
																	}
																}
																finally
																{
																	((IDisposable)enumerator4).Dispose();
																	int num21 = 0;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
																	{
																		num21 = 0;
																	}
																	switch (num21)
																	{
																	case 0:
																		break;
																	}
																}
																break;
															case 1:
																return (MethodReference)_003C_003Ec__DisplayClass15_5.c4MZy1ZKHwlIOPMqoftp(_003C_003Ec__DisplayClass15_6.CS_0024_003C_003E8__locals5.CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals1._003C_003E4__this.module, val11);
															case 5:
																try
																{
																	while (true)
																	{
																		int num22;
																		if (!enumerator5.MoveNext())
																		{
																			num22 = 3;
																			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
																			{
																				num22 = 1;
																			}
																			goto IL_016d;
																		}
																		goto IL_01ad;
																		IL_01ad:
																		current2 = enumerator5.get_Current();
																		num22 = 0;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
																		{
																			num22 = 0;
																		}
																		goto IL_016d;
																		IL_016d:
																		while (true)
																		{
																			switch (num22)
																			{
																			case 1:
																				break;
																			case 2:
																				goto IL_01ad;
																			default:
																				val11.get_GenericParameters().Add(new GenericParameter((string)_003C_003Ec__DisplayClass15_5.dclQlHZKpBqWMvNl5Pe2(current2), (IGenericParameterProvider)(object)val11));
																				num22 = 0;
																				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
																				{
																					num22 = 1;
																				}
																				continue;
																			case 3:
																				goto end_IL_0187;
																			}
																			break;
																		}
																		continue;
																		end_IL_0187:
																		break;
																	}
																}
																finally
																{
																	((IDisposable)enumerator5).Dispose();
																	int num23 = 0;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
																	{
																		num23 = 0;
																	}
																	switch (num23)
																	{
																	case 0:
																		break;
																	}
																}
																goto case 1;
															case 2:
																enumerator4 = ((MethodReference)_003C_003Ec__DisplayClass15_6.CS_0024_003C_003E8__locals5.method).get_Parameters().GetEnumerator();
																num19 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
																{
																	num19 = 0;
																}
																continue;
															case 3:
															{
																MethodReference val10 = new MethodReference((string)_003C_003Ec__DisplayClass15_5.dclQlHZKpBqWMvNl5Pe2(_003C_003Ec__DisplayClass15_6.CS_0024_003C_003E8__locals5.method), (TypeReference)_003C_003Ec__DisplayClass15_5.sfQyVqZKaQgMl4bZhdyC(_003C_003Ec__DisplayClass15_6.CS_0024_003C_003E8__locals5.method), _003C_003Ec__DisplayClass15_6.CS_0024_003C_003E8__locals5.CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals1._003C_003E4__this.typesToReplace[(TypeReference)(object)_003C_003Ec__DisplayClass15_6.CS_0024_003C_003E8__locals5.CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals1.typeDefinition]);
																_003C_003Ec__DisplayClass15_5.FK1vJTZKtJieQi8xFy0N((object)val10, _003C_003Ec__DisplayClass15_5.A1g8vGZKDYRQPuIw8xbf(_003C_003Ec__DisplayClass15_6.CS_0024_003C_003E8__locals5.method));
																_003C_003Ec__DisplayClass15_5.RwoxNqZK4jZjwfaaMlNA((object)val10, _003C_003Ec__DisplayClass15_5.b2MaBNZKwREdEc7Bcdeo(_003C_003Ec__DisplayClass15_6.CS_0024_003C_003E8__locals5.method));
																_003C_003Ec__DisplayClass15_5.vWRiMdZK6QW5IFqXy5dR((object)val10, ((MethodReference)_003C_003Ec__DisplayClass15_6.CS_0024_003C_003E8__locals5.method).get_CallingConvention());
																val11 = val10;
																num19 = 2;
																continue;
															}
															case 4:
																break;
															}
															enumerator5 = ((MethodReference)_003C_003Ec__DisplayClass15_6.CS_0024_003C_003E8__locals5.method).get_GenericParameters().GetEnumerator();
															num19 = 5;
														}
													});
													num17 = 3;
													continue;
												case 5:
													CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this.methodsToReplace.Add((MethodReference)(object)_003C_003Ec__DisplayClass15_5.method, (Func<MethodReference>)(() => (MethodReference)_003C_003Ec__DisplayClass15_1.es1wI3ZKb2o60fPnA0WZ(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this.module, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.type.GetMethod((string)_003C_003Ec__DisplayClass15_1.SKhi3uZKWwfV5LeRrC5n(0x3630F361 ^ 0x3633A229), BindingFlags.Instance | BindingFlags.NonPublic))));
													num16 = 10;
													break;
												}
												break;
											}
										}
									});
									num3 = 73;
									continue;
								case 35:
									XCdEAevEB8b2mmjLX91w(_003C_003Ec__DisplayClass15_2.type, _003C_003Ec__DisplayClass15_2.CS_0024_003C_003E8__locals1.typeDefinition);
									num3 = 68;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
									{
										num3 = 33;
									}
									continue;
								case 41:
									try
									{
										while (true)
										{
											IL_120e:
											int num10;
											if (!enumerator3.MoveNext())
											{
												num10 = 7;
												goto IL_10c1;
											}
											goto IL_1107;
											IL_10c1:
											while (true)
											{
												switch (num10)
												{
												case 10:
													break;
												case 4:
												case 8:
													goto IL_1147;
												case 3:
												case 14:
													goto IL_1174;
												default:
													_003C_003Ec__DisplayClass15_4.property = enumerator3.get_Current();
													num10 = 11;
													continue;
												case 11:
													if (!CS_0024_003C_003E8__locals0.oldProperties.TryGetValue(((MemberReference)_003C_003Ec__DisplayClass15_4.property).get_Name(), out value))
													{
														num10 = 5;
														continue;
													}
													goto case 12;
												case 12:
													val7 = ((IEnumerable<PropertyDefinition>)dictionary[value].get_Properties()).First(_003C_003Ec__DisplayClass15_4._003CProceedTypes_003Eb__23);
													num10 = 2;
													continue;
												case 5:
												case 6:
												case 13:
													goto IL_120e;
												case 2:
													goto IL_1224;
												case 1:
												case 9:
													goto IL_12b3;
												case 7:
													goto end_IL_120e;
												}
												break;
												IL_12b3:
												object obj4 = Vv3A5dvEZU8w4vZdEDAL(_003C_003Ec__DisplayClass15_4.property);
												if (obj4 == null)
												{
													num10 = 13;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
													{
														num10 = 1;
													}
												}
												else
												{
													((MethodDefinition)obj4).get_Overrides().Add((MethodReference)QidgY9vEO7IEW9oKN9td(module, val7.get_SetMethod()));
													num10 = 6;
												}
												continue;
												IL_1224:
												object obj5 = BygEN7vE8efWKaQSk1lt(_003C_003Ec__DisplayClass15_4.property);
												if (obj5 == null)
												{
													num10 = 3;
													continue;
												}
												((MethodDefinition)obj5).get_Overrides().Clear();
												num10 = 14;
												continue;
												IL_1174:
												object obj6 = BygEN7vE8efWKaQSk1lt(_003C_003Ec__DisplayClass15_4.property);
												if (obj6 == null)
												{
													num10 = 8;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
													{
														num10 = 1;
													}
												}
												else
												{
													((MethodDefinition)obj6).get_Overrides().Add((MethodReference)QidgY9vEO7IEW9oKN9td(module, BygEN7vE8efWKaQSk1lt(val7)));
													num10 = 4;
												}
												continue;
												IL_1147:
												object obj7 = Vv3A5dvEZU8w4vZdEDAL(_003C_003Ec__DisplayClass15_4.property);
												if (obj7 == null)
												{
													num10 = 5;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
													{
														num10 = 9;
													}
													continue;
												}
												pqyNxMvE2fjFRux3yLHj(((MethodDefinition)obj7).get_Overrides());
												num10 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
												{
													num10 = 1;
												}
											}
											goto IL_1107;
											IL_1107:
											_003C_003Ec__DisplayClass15_4 = new _003C_003Ec__DisplayClass15_7();
											num10 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
											{
												num10 = 0;
											}
											goto IL_10c1;
											continue;
											end_IL_120e:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator3).Dispose();
										int num11 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
										{
											num11 = 0;
										}
										switch (num11)
										{
										case 0:
											break;
										}
									}
									goto case 48;
								case 29:
									if (val3 != null)
									{
										num3 = 57;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
										{
											num3 = 58;
										}
										continue;
									}
									goto case 63;
								case 33:
									_003C_003Ec__DisplayClass15_2.type = JqxPZcvGJ1K5l85qJuyh(_003C_003Ec__DisplayClass15_2.CS_0024_003C_003E8__locals1.typeDefinition);
									num4 = 46;
									goto IL_0039;
								case 19:
									val6 = ((IEnumerable<CustomAttribute>)_003C_003Ec__DisplayClass15_2.CS_0024_003C_003E8__locals1.typeDefinition.get_CustomAttributes()).SingleOrDefault((CustomAttribute ca) => _003C_003Ec.DAK0RBZqte1jhB7xkPtu(((MemberReference)_003C_003Ec.w6Q6sNZqDUDuN5FbKHke(ca)).get_FullName(), TypeOf<EleWise.ELMA.Model.Attributes.FilterForAttribute>.FullName));
									num3 = 83;
									continue;
								case 85:
									obj = ((TypeReference)((CustomAttributeArgument)(ref val4)).get_Value()).Resolve();
									goto IL_1404;
								case 14:
									configurationModelProperties[(string)ve3HnmvGg9SRuNo1X9NL(_003C_003Ec__DisplayClass15_2.CS_0024_003C_003E8__locals1.typeDefinition)] = ((IEnumerable<PropertyDefinition>)_003C_003Ec__DisplayClass15_2.CS_0024_003C_003E8__locals1.typeDefinition.get_Properties()).ToDictionary((PropertyDefinition p) => ((MemberReference)p).get_Name(), (PropertyDefinition p) => (TypeReference)_003C_003Ec.mGutCLZqwLgNSMZYdHqj(((PropertyReference)p).get_PropertyType()));
									num3 = 31;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
									{
										num3 = 28;
									}
									continue;
								case 4:
									CS_0024_003C_003E8__locals0.interfaceReference = ((IEnumerable<TypeReference>)CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.typeDefinition.get_Interfaces()).FirstOrDefault(delegate(TypeReference i)
									{
										int num24 = 1;
										int num25 = num24;
										AssemblyNameReference val12 = default(AssemblyNameReference);
										while (true)
										{
											switch (num25)
											{
											default:
												return _003C_003Ec.DAK0RBZqte1jhB7xkPtu(_003C_003Ec.ibb3E9Zq6UxxiCCcIAWq(val12), _003C_003Ec.a9fLdkZqNth1063Ec3v1(0x20261A4F ^ 0x2026102B));
											case 1:
											{
												object obj8 = _003C_003Ec.pW3aZYZq4faLqLChhLXV(i);
												if ((val12 = (AssemblyNameReference)((obj8 is AssemblyNameReference) ? obj8 : null)) == null)
												{
													return false;
												}
												num25 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
												{
													num25 = 0;
												}
												break;
											}
											}
										}
									});
									num3 = 56;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
									{
										num3 = 9;
									}
									continue;
								case 62:
									CS_0024_003C_003E8__locals0.interfaceProperties = (from n in ((IEnumerable<PropertyDefinition>)CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.typeDefinition.get_Properties()).Select(delegate(PropertyDefinition p)
										{
											//Discarded unreachable code: IL_006c, IL_007b
											int num26 = 2;
											int num27 = num26;
											int num28 = default(int);
											while (true)
											{
												switch (num27)
												{
												default:
													return null;
												case 3:
													return (string)_003C_003Ec.r4oipkZq7WVLtqrR1pxu(_003C_003Ec.FPSwiEZqAExXcRqpq46x(p), num28 + 1);
												case 2:
													num28 = _003C_003Ec.K2FW7cZqHeQHM9ysuHc7(((MemberReference)p).get_Name(), '.');
													num27 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
													{
														num27 = 1;
													}
													break;
												case 1:
													if (num28 > 0)
													{
														num27 = 3;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
														{
															num27 = 3;
														}
														break;
													}
													goto default;
												}
											}
										})
										where n != null
										select n).ToHashSet();
									num3 = 16;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
									{
										num3 = 18;
									}
									continue;
								case 38:
									CS_0024_003C_003E8__locals0.dataInterface = ((IEnumerable<TypeDefinition>)CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.typeDefinition.get_NestedTypes()).FirstOrDefault((TypeDefinition t) => _003C_003Ec.DAK0RBZqte1jhB7xkPtu(_003C_003Ec.FPSwiEZqAExXcRqpq46x(t), _003C_003Ec.a9fLdkZqNth1063Ec3v1(-1088304168 ^ -1088256680)));
									num3 = 13;
									continue;
								case 9:
									val = ((IEnumerable<TypeDefinition>)CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.typeDefinition.get_NestedTypes()).First((TypeDefinition t) => (string)_003C_003Ec.FPSwiEZqAExXcRqpq46x(t) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487207844));
									num3 = 82;
									continue;
								case 82:
									dictionary = CS_0024_003C_003E8__locals0.oldProperties.Values.Append(typesToReplace[(TypeReference)(object)CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.typeDefinition]).Distinct((IEqualityComparer<TypeReference>)QIxgXxvERds4rycVaNVm()).ToDictionary((TypeReference t) => t, (TypeReference t) => ((IEnumerable<TypeDefinition>)((TypeDefinition)_003C_003Ec.eMA0uCZqxnDcUk8Z77vt(t)).get_NestedTypes()).First((TypeDefinition t2) => _003C_003Ec.DAK0RBZqte1jhB7xkPtu(_003C_003Ec.FPSwiEZqAExXcRqpq46x(t2), _003C_003Ec.a9fLdkZqNth1063Ec3v1(-2106517564 ^ -2106435260))), (IEqualityComparer<TypeReference>)QIxgXxvERds4rycVaNVm());
									num3 = 51;
									continue;
								case 3:
									val2 = ((IEnumerable<MethodDefinition>)val.get_Methods()).First(delegate(MethodDefinition m)
									{
										//Discarded unreachable code: IL_002d, IL_003c
										int num29 = 2;
										int num30 = num29;
										while (true)
										{
											switch (num30)
											{
											case 2:
												if (!((string)_003C_003Ec.FPSwiEZqAExXcRqpq46x(m) == (string)_003C_003Ec.a9fLdkZqNth1063Ec3v1(-97972138 ^ -97955294)))
												{
													num30 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
													{
														num30 = 1;
													}
													break;
												}
												goto default;
											default:
												return _003C_003Ec.Fh1EBvZq0Ns5HwrD62ZS(((MethodReference)m).get_Parameters()) == 1;
											case 1:
												return false;
											}
										}
									});
									num3 = 11;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
									{
										num3 = 28;
									}
									continue;
								case 72:
									{
										val2 = ((IEnumerable<MethodDefinition>)val.get_Methods()).First(delegate(MethodDefinition m)
										{
											int num31 = 1;
											int num32 = num31;
											while (true)
											{
												switch (num32)
												{
												default:
													return _003C_003Ec.Fh1EBvZq0Ns5HwrD62ZS(((MethodReference)m).get_Parameters()) == 0;
												case 1:
													if (!((string)_003C_003Ec.FPSwiEZqAExXcRqpq46x(m) == (string)_003C_003Ec.a9fLdkZqNth1063Ec3v1(0x1637C429 ^ 0x1637865D)))
													{
														return false;
													}
													num32 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
													{
														num32 = 0;
													}
													break;
												}
											}
										});
										num3 = 15;
										continue;
									}
									IL_1404:
									val3 = ((IEnumerable<CustomAttribute>)obj.get_CustomAttributes()).SingleOrDefault((CustomAttribute ca) => _003C_003Ec.DAK0RBZqte1jhB7xkPtu(((MemberReference)_003C_003Ec.w6Q6sNZqDUDuN5FbKHke(ca)).get_FullName(), TypeOf<UidAttribute>.FullName));
									num3 = 29;
									continue;
									IL_0039:
									num3 = num4;
									continue;
								}
								break;
							}
						}
					}
					finally
					{
						int num12;
						if (enumerator == null)
						{
							num12 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
							{
								num12 = 0;
							}
							goto IL_17b1;
						}
						goto IL_17c7;
						IL_17c7:
						UwdDNsvGyVPTLJ7XKuQ5(enumerator);
						num12 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num12 = 0;
						}
						goto IL_17b1;
						IL_17b1:
						switch (num12)
						{
						default:
							goto end_IL_178c;
						case 2:
							break;
						case 1:
							goto end_IL_178c;
						case 0:
							goto end_IL_178c;
						}
						goto IL_17c7;
						end_IL_178c:;
					}
				case 2:
					enumerator = ((IEnumerable<TypeDefinition>)((ModuleDefinition)module).get_Types()).Where(delegate(TypeDefinition t)
					{
						int num33 = 1;
						int num34 = num33;
						while (true)
						{
							switch (num34)
							{
							case 1:
								if (!((string)_003C_003Ec.BT0sQpZqaDafrV2McCSg(t) != "<Module>"))
								{
									return false;
								}
								num34 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
								{
									num34 = 0;
								}
								break;
							default:
								return (string)_003C_003Ec.BT0sQpZqaDafrV2McCSg(t) != z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C5379C9);
							}
						}
					}).GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		private void ProceedPublicApi(TypeDefinition typeDefinition, IDictionary<TypeReference, string> publicApiReplaces)
		{
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_036d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0377: Expected O, but got Unknown
			//IL_03af: Unknown result type (might be due to invalid IL or missing references)
			//IL_040a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0563: Unknown result type (might be due to invalid IL or missing references)
			//IL_056a: Expected O, but got Unknown
			//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d3: Expected O, but got Unknown
			_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass16_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.publicApiReplaces = publicApiReplaces;
			if (typeDefinition == null)
			{
				return;
			}
			Type type = Resolve((TypeReference)(object)typeDefinition);
			if (type == null)
			{
				EntityDynamicGenerator.AddReplace((object)((MemberReference)typeDefinition).get_FullName(), (object)typeDefinition);
				CS_0024_003C_003E8__locals0.publicApiReplaces.Add((TypeReference)(object)typeDefinition, ((MemberReference)typeDefinition).get_FullName());
				typesToReplace.Add((TypeReference)(object)typeDefinition, null);
				newPublicApiTypes.Add(typeDefinition);
				return;
			}
			typesToReplace.Add((TypeReference)(object)typeDefinition, ((ModuleDefinition)module).Import(type));
			CS_0024_003C_003E8__locals0.isRoot = typeDefinition.get_DeclaringType() == null;
			MethodDefinition val = ((IEnumerable<MethodDefinition>)typeDefinition.get_Methods()).FirstOrDefault(delegate(MethodDefinition m)
			{
				int num12 = 1;
				int num13 = num12;
				while (true)
				{
					switch (num13)
					{
					default:
						return _003C_003Ec__DisplayClass16_0.vqKZGjZK54yp7cMp07Ai(m) == CS_0024_003C_003E8__locals0.isRoot;
					case 1:
						if (!m.get_IsConstructor())
						{
							return false;
						}
						num13 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num13 = 0;
						}
						break;
					}
				}
			});
			if (CS_0024_003C_003E8__locals0.isRoot)
			{
				((ICollection<MethodDefinition>)typeDefinition.get_Methods()).RemoveAll(delegate(MethodDefinition m)
				{
					int num10 = 1;
					int num11 = num10;
					while (true)
					{
						switch (num11)
						{
						default:
							return !_003C_003Ec.EnQ4M9Zqy7WceLJ4Nj9m(m);
						case 1:
							if (!_003C_003Ec.KIQ1xvZqmIxNvcoFT5wd(m))
							{
								return false;
							}
							num11 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
							{
								num11 = 0;
							}
							break;
						}
					}
				});
			}
			else
			{
				((MemberReference)val).set_Name(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107674118));
				((MethodReference)val).set_HasThis(false);
				val.set_Attributes((MethodAttributes)6289);
				int num = val.get_Body().get_Instructions().get_Count() - 3;
				val.get_Body().get_Instructions().RemoveAt(num);
				val.get_Body().get_Instructions().RemoveAt(num);
			}
			typeDefinition.set_BaseType(((ModuleDefinition)module).get_TypeSystem().get_Object());
			typeDefinition.set_Attributes((TypeAttributes)(typeDefinition.get_Attributes() | 0x180));
			PropertyDefinition[] array = typeDefinition.get_Properties().ToArray();
			for (int j = 0; j < array.Length; j++)
			{
				_003C_003Ec__DisplayClass16_1 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass16_1();
				CS_0024_003C_003E8__locals3.property = array[j];
				_003C_003Ec__DisplayClass16_2 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass16_2();
				CS_0024_003C_003E8__locals4.field = ((IEnumerable<FieldDefinition>)typeDefinition.get_Fields()).First((FieldDefinition f) => _003C_003Ec__DisplayClass16_1.GEDndQZKcggdJQfs1j57(f) == _003C_003Ec__DisplayClass16_1.V05x82ZKzxyvjGiLl8SP(CS_0024_003C_003E8__locals3.property));
				if (TryGetReplace((object)CS_0024_003C_003E8__locals3.property.get_GetMethod(), out MethodReference _) || type.GetProperty(((MemberReference)CS_0024_003C_003E8__locals3.property).get_Name(), BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public) != null)
				{
					Instruction val2 = ((val != null) ? ((IEnumerable<Instruction>)val.get_Body().get_Instructions()).FirstOrDefault(delegate(Instruction i)
					{
						int num8 = 1;
						int num9 = num8;
						FieldDefinition val8 = default(FieldDefinition);
						while (true)
						{
							switch (num9)
							{
							case 1:
							{
								object obj2 = _003C_003Ec__DisplayClass16_2.aW9EZ2ZXbMZjrD28tT69(i);
								if ((val8 = (FieldDefinition)((obj2 is FieldDefinition) ? obj2 : null)) == null)
								{
									return false;
								}
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
								{
									num9 = 0;
								}
								break;
							}
							default:
								return val8 == CS_0024_003C_003E8__locals4.field;
							}
						}
					}) : null);
					if (val2 != null)
					{
						if (!CS_0024_003C_003E8__locals4.field.get_IsStatic())
						{
							val.get_Body().get_Instructions().Remove(val2.get_Previous().get_Previous());
						}
						val.get_Body().get_Instructions().Remove(val2.get_Previous());
						val.get_Body().get_Instructions().Remove(val2);
					}
					typeDefinition.get_Fields().Remove(CS_0024_003C_003E8__locals4.field);
					typeDefinition.get_Methods().Remove(CS_0024_003C_003E8__locals3.property.get_GetMethod());
					typeDefinition.get_Properties().Remove(CS_0024_003C_003E8__locals3.property);
					continue;
				}
				AddMethodReplace((MethodReference)(object)CS_0024_003C_003E8__locals3.property.get_GetMethod(), CS_0024_003C_003E8__locals3.property.get_GetMethod());
				if (CS_0024_003C_003E8__locals3.property.get_GetMethod().get_IsStatic())
				{
					continue;
				}
				CS_0024_003C_003E8__locals4.field.set_Attributes((FieldAttributes)49);
				CS_0024_003C_003E8__locals3.property.get_GetMethod().set_Attributes((MethodAttributes)22);
				CS_0024_003C_003E8__locals3.property.get_GetMethod().get_Overrides().Clear();
				((MethodReference)CS_0024_003C_003E8__locals3.property.get_GetMethod()).set_HasThis(false);
				((MethodReference)CS_0024_003C_003E8__locals3.property.get_GetMethod()).get_Parameters().Insert(0, new ParameterDefinition(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDF192C), (ParameterAttributes)1, ((ModuleDefinition)module).Import(type)));
				CS_0024_003C_003E8__locals3.property.get_GetMethod().get_Body().get_Instructions()
					.RemoveAt(0);
				CS_0024_003C_003E8__locals3.property.get_GetMethod().get_Body().get_Instructions()
					.get_Item(0)
					.set_OpCode(OpCodes.Ldsfld);
				Instruction val3 = ((val != null) ? ((IEnumerable<Instruction>)val.get_Body().get_Instructions()).FirstOrDefault(delegate(Instruction i)
				{
					int num6 = 1;
					int num7 = num6;
					FieldDefinition val7 = default(FieldDefinition);
					while (true)
					{
						switch (num7)
						{
						default:
							return val7 == CS_0024_003C_003E8__locals4.field;
						case 1:
						{
							object obj = _003C_003Ec__DisplayClass16_2.aW9EZ2ZXbMZjrD28tT69(i);
							if ((val7 = (FieldDefinition)((obj is FieldDefinition) ? obj : null)) == null)
							{
								return false;
							}
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
							{
								num7 = 0;
							}
							break;
						}
						}
					}
				}) : null);
				if (val3 != null)
				{
					val.get_Body().get_Instructions().Remove(val3.get_Previous().get_Previous());
					val3.set_OpCode(OpCodes.Stsfld);
				}
				typeDefinition.get_Properties().Remove(CS_0024_003C_003E8__locals3.property);
			}
			MethodDefinition[] array2 = ((IEnumerable<MethodDefinition>)typeDefinition.get_Methods()).Where(delegate(MethodDefinition m)
			{
				//Discarded unreachable code: IL_002d, IL_003c
				int num4 = 2;
				int num5 = num4;
				while (true)
				{
					switch (num5)
					{
					default:
						return !CS_0024_003C_003E8__locals0._003C_003E4__this.replaceMethods.ContainsKey(m);
					case 1:
						return false;
					case 2:
						if (_003C_003Ec__DisplayClass16_0.FG2dXgZKjteJ4Q5TSN16(m))
						{
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
							{
								num5 = 1;
							}
							break;
						}
						goto default;
					}
				}
			}).ToArray();
			foreach (MethodDefinition val4 in array2)
			{
				_003C_003Ec__DisplayClass16_3 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass16_3();
				CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
				if (TryGetReplace((object)val4, out CS_0024_003C_003E8__locals1.m))
				{
					typeDefinition.get_Methods().Remove(val4);
					methodsToReplace.Add((MethodReference)(object)val4, (Func<MethodReference>)(() => (MethodReference)_003C_003Ec__DisplayClass16_3.d0aBhJZXQ6YyxChqrAeD(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.module, CS_0024_003C_003E8__locals1.m)));
				}
				else if (type.GetMember(((MemberReference)val4).get_Name(), BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public).Length != 0)
				{
					_003C_003Ec__DisplayClass16_4 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass16_4();
					CS_0024_003C_003E8__locals2.methodName = ((MemberReference)val4).get_FullName();
					typeDefinition.get_Methods().Remove(val4);
					methodsToReplace.Add((MethodReference)(object)val4, (Func<MethodReference>)delegate
					{
						throw new NotImplementedException((string)_003C_003Ec__DisplayClass16_4.lKm8UxZXIBdIa8m2jbmB(_003C_003Ec__DisplayClass16_4.jMYcQIZXuDFf0q7dAFgb(0x1ECE530A ^ 0x1EC87EF2), CS_0024_003C_003E8__locals2.methodName));
					});
				}
				else if (!val4.get_IsGetter())
				{
					AddMethodReplace((MethodReference)(object)val4, val4);
					methodsToReplace.Add((MethodReference)(object)val4, (MethodReference)(object)val4);
					TypeReference val5 = ((ModuleDefinition)module).Import(type);
					if (type.IsGenericType)
					{
						GenericInstanceType val6 = new GenericInstanceType(val5);
						((ICollection<TypeReference>)val6.get_GenericArguments()).AddRange((IEnumerable<TypeReference>)((TypeReference)typeDefinition).get_GenericParameters());
						val5 = ((ModuleDefinition)module).Import((TypeReference)(object)val6);
					}
					val4.set_Attributes((MethodAttributes)22);
					val4.get_Overrides().Clear();
					((MethodReference)val4).set_HasThis(false);
					((MethodReference)val4).get_Parameters().Insert(0, new ParameterDefinition(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70193858), (ParameterAttributes)1, val5));
				}
			}
			((IEnumerable<TypeDefinition>)typeDefinition.get_NestedTypes()).ForEach(delegate(TypeDefinition t)
			{
				int num2 = 1;
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						CS_0024_003C_003E8__locals0._003C_003E4__this.ProceedPublicApi(t, CS_0024_003C_003E8__locals0.publicApiReplaces);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num3 = 0;
						}
						break;
					}
				}
			});
			if (((IEnumerable<TypeDefinition>)typeDefinition.get_NestedTypes()).All(typesToRemove.Contains) && ((IEnumerable<MethodDefinition>)typeDefinition.get_Methods()).All((MethodDefinition m) => _003C_003Ec.KIQ1xvZqmIxNvcoFT5wd(m)))
			{
				typesToRemove.Add(typeDefinition);
			}
		}

		private void ReplaceTypes()
		{
			//Discarded unreachable code: IL_0065, IL_00cf, IL_00d9, IL_0127, IL_01c9, IL_01dc, IL_01eb, IL_01fb, IL_020a, IL_02d7, IL_02e1, IL_031c, IL_032b, IL_03b5, IL_0458, IL_046b, IL_051d, IL_052b, IL_0573, IL_0581, IL_066e, IL_0681, IL_0690, IL_06a1, IL_06b0, IL_0729, IL_0738, IL_0743, IL_0791, IL_07a0, IL_0833, IL_0846, IL_0855, IL_08f1, IL_0904, IL_0913, IL_0a26, IL_0a35, IL_0a40, IL_0a6b, IL_0a7a, IL_0b30, IL_0b43, IL_0b52, IL_0b61, IL_0b98, IL_0bab, IL_0bbb, IL_0bc5, IL_0bf0, IL_0bff, IL_0cb5, IL_0cc8, IL_0cd7, IL_0d1b, IL_0d53, IL_0d62, IL_0d73, IL_0d82, IL_0d8d, IL_0db5, IL_0e6e, IL_0eba, IL_0f8c, IL_0fcc, IL_0fd7, IL_0fe6, IL_10e3, IL_1102, IL_1111, IL_113e, IL_114d, IL_115d, IL_116c
			//IL_0256: Unknown result type (might be due to invalid IL or missing references)
			//IL_025b: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_047c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0481: Unknown result type (might be due to invalid IL or missing references)
			//IL_0881: Unknown result type (might be due to invalid IL or missing references)
			//IL_0886: Unknown result type (might be due to invalid IL or missing references)
			//IL_092a: Unknown result type (might be due to invalid IL or missing references)
			//IL_092f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0998: Unknown result type (might be due to invalid IL or missing references)
			//IL_099d: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e94: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e99: Unknown result type (might be due to invalid IL or missing references)
			//IL_0efc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f01: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f0c: Unknown result type (might be due to invalid IL or missing references)
			int num = 4;
			int num2 = num;
			IEnumerator<TypeDefinition> enumerator = default(IEnumerator<TypeDefinition>);
			TypeDefinition current = default(TypeDefinition);
			Enumerator<PropertyDefinition> enumerator8 = default(Enumerator<PropertyDefinition>);
			PropertyDefinition current9 = default(PropertyDefinition);
			TypeReference replaceTo = default(TypeReference);
			int num18 = default(int);
			Enumerator<FieldDefinition> enumerator2 = default(Enumerator<FieldDefinition>);
			Enumerator<GenericParameter> enumerator7 = default(Enumerator<GenericParameter>);
			GenericParameter current8 = default(GenericParameter);
			int num20 = default(int);
			Enumerator<MethodDefinition> enumerator3 = default(Enumerator<MethodDefinition>);
			Enumerator<ParameterDefinition> enumerator5 = default(Enumerator<ParameterDefinition>);
			ParameterDefinition current5 = default(ParameterDefinition);
			Enumerator<MethodReference> enumerator6 = default(Enumerator<MethodReference>);
			MethodReference current6 = default(MethodReference);
			ParameterDefinition current7 = default(ParameterDefinition);
			Enumerator<VariableDefinition> enumerator4 = default(Enumerator<VariableDefinition>);
			MethodDefinition current4 = default(MethodDefinition);
			VariableDefinition current3 = default(VariableDefinition);
			FieldDefinition current2 = default(FieldDefinition);
			IEnumerator<CustomAttribute> enumerator9 = default(IEnumerator<CustomAttribute>);
			CustomAttribute current11 = default(CustomAttribute);
			int num28 = default(int);
			CustomAttributeArgument val = default(CustomAttributeArgument);
			TypeReference typeReference = default(TypeReference);
			TypeReference replaceTo2 = default(TypeReference);
			TypeDefinition current10 = default(TypeDefinition);
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (op17aRvEeJTqV24h5Mhd(typesToReplace) <= 0)
					{
						num2 = 3;
						break;
					}
					goto default;
				case 7:
					try
					{
						while (true)
						{
							IL_04e1:
							int num3;
							if (!nI2mXnvGmait7AmwPp5n(enumerator))
							{
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
								{
									num3 = 13;
								}
								goto IL_0073;
							}
							goto IL_027f;
							IL_027f:
							current = enumerator.Current;
							int num4 = 17;
							num3 = num4;
							goto IL_0073;
							IL_0073:
							while (true)
							{
								switch (num3)
								{
								case 5:
									try
									{
										while (true)
										{
											IL_0187:
											int num22;
											if (!enumerator8.MoveNext())
											{
												num22 = 5;
												goto IL_00dd;
											}
											goto IL_0131;
											IL_00dd:
											while (true)
											{
												switch (num22)
												{
												case 2:
													sLLA6YvE36yJ9IJU38Mo(current9, replaceTo);
													num22 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
													{
														num22 = 1;
													}
													continue;
												case 3:
													break;
												default:
													if (!CheckType(typesToReplace, qjh1ZbvENiKg7TDriHC9(current9), out replaceTo))
													{
														num22 = 4;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
														{
															num22 = 1;
														}
														continue;
													}
													goto case 2;
												case 1:
												case 4:
													goto IL_0187;
												case 5:
													goto end_IL_0187;
												}
												break;
											}
											goto IL_0131;
											IL_0131:
											current9 = enumerator8.get_Current();
											num22 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
											{
												num22 = 0;
											}
											goto IL_00dd;
											continue;
											end_IL_0187:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator8).Dispose();
										int num23 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
										{
											num23 = 0;
										}
										switch (num23)
										{
										case 0:
											break;
										}
									}
									goto default;
								case 15:
									num18 = 0;
									num3 = 9;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
									{
										num3 = 9;
									}
									continue;
								case 4:
								case 9:
									if (num18 >= m8VANjvE1F9DxbXsAeqQ(current.get_Interfaces()))
									{
										num3 = 12;
										continue;
									}
									goto case 18;
								case 3:
									enumerator8 = current.get_Properties().GetEnumerator();
									num3 = 5;
									continue;
								default:
									enumerator2 = current.get_Fields().GetEnumerator();
									num3 = 8;
									continue;
								case 2:
									break;
								case 17:
									if (CheckType(typesToReplace, n1C8QQvEPfDxcYobxkov(current), out replaceTo))
									{
										num3 = 14;
										continue;
									}
									goto case 15;
								case 12:
									enumerator7 = ((TypeReference)current).get_GenericParameters().GetEnumerator();
									num3 = 7;
									continue;
								case 7:
									try
									{
										while (true)
										{
											IL_0406:
											int num19;
											if (!enumerator7.MoveNext())
											{
												num19 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
												{
													num19 = 1;
												}
												goto IL_02e5;
											}
											goto IL_0370;
											IL_0370:
											current8 = enumerator7.get_Current();
											num19 = 5;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
											{
												num19 = 1;
											}
											goto IL_02e5;
											IL_02e5:
											while (true)
											{
												switch (num19)
												{
												case 7:
													if (!CheckType(typesToReplace, current8.get_Constraints().get_Item(num20), out replaceTo))
													{
														num19 = 8;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
														{
															num19 = 1;
														}
														continue;
													}
													goto default;
												case 2:
													break;
												case 5:
													num20 = 0;
													num19 = 4;
													continue;
												case 6:
												case 8:
													num20++;
													num19 = 3;
													continue;
												default:
													current8.get_Constraints().set_Item(num20, replaceTo);
													num19 = 6;
													continue;
												case 3:
												case 4:
													if (num20 >= m8VANjvE1F9DxbXsAeqQ(current8.get_Constraints()))
													{
														num19 = 2;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
														{
															num19 = 9;
														}
														continue;
													}
													goto case 7;
												case 9:
													goto IL_0406;
												case 1:
													goto end_IL_0406;
												}
												break;
											}
											goto IL_0370;
											continue;
											end_IL_0406:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator7).Dispose();
										int num21 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
										{
											num21 = 0;
										}
										switch (num21)
										{
										case 0:
											break;
										}
									}
									goto case 3;
								case 1:
									enumerator3 = current.get_Methods().GetEnumerator();
									num3 = 11;
									continue;
								case 16:
									current.get_Interfaces().set_Item(num18, replaceTo);
									num3 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
									{
										num3 = 6;
									}
									continue;
								case 18:
									if (CheckType(typesToReplace, current.get_Interfaces().get_Item(num18), out replaceTo))
									{
										num3 = 16;
										continue;
									}
									goto case 6;
								case 10:
									goto IL_04e1;
								case 6:
									num18++;
									num3 = 4;
									continue;
								case 11:
									try
									{
										while (true)
										{
											IL_0a0a:
											int num7;
											if (!enumerator3.MoveNext())
											{
												num7 = 9;
												goto IL_052f;
											}
											goto IL_09a9;
											IL_052f:
											while (true)
											{
												switch (num7)
												{
												case 5:
													try
													{
														while (true)
														{
															IL_05d6:
															int num10;
															if (!enumerator5.MoveNext())
															{
																num10 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
																{
																	num10 = 0;
																}
																goto IL_0585;
															}
															goto IL_05fc;
															IL_05fc:
															current5 = enumerator5.get_Current();
															num10 = 2;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
															{
																num10 = 0;
															}
															goto IL_0585;
															IL_0585:
															while (true)
															{
																switch (num10)
																{
																case 2:
																	if (CheckType(typesToReplace, aW4AbAvEDOW3qvItRHmw(current5), out replaceTo))
																	{
																		num10 = 0;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
																		{
																			num10 = 3;
																		}
																		continue;
																	}
																	goto IL_05d6;
																case 1:
																	goto IL_05d6;
																case 4:
																	goto IL_05fc;
																case 3:
																	NMaT1QvEtIbaq3NV2y7o(current5, replaceTo);
																	num10 = 1;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
																	{
																		num10 = 1;
																	}
																	continue;
																case 0:
																	break;
																}
																break;
															}
															break;
														}
													}
													finally
													{
														((IDisposable)enumerator5).Dispose();
														int num11 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
														{
															num11 = 0;
														}
														switch (num11)
														{
														case 0:
															break;
														}
													}
													goto case 4;
												case 11:
													try
													{
														while (true)
														{
															IL_0860:
															int num12;
															if (!enumerator6.MoveNext())
															{
																num12 = 3;
																goto IL_06bb;
															}
															goto IL_08a2;
															IL_06bb:
															int num13 = num12;
															goto IL_06bf;
															IL_08a2:
															current6 = enumerator6.get_Current();
															num13 = 2;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
															{
																num13 = 4;
															}
															goto IL_06bf;
															IL_06fe:
															num12 = 2;
															goto IL_06bb;
															IL_06bf:
															while (true)
															{
																switch (num13)
																{
																case 4:
																	if (CheckType(typesToReplace, uiODTXvEXjtqE8iVvQ63(current6), out replaceTo))
																	{
																		goto IL_06fe;
																	}
																	goto case 5;
																case 2:
																	break;
																case 6:
																	try
																	{
																		while (true)
																		{
																			IL_07e1:
																			int num14;
																			if (!enumerator5.MoveNext())
																			{
																				num14 = 4;
																				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
																				{
																					num14 = 3;
																				}
																				goto IL_0747;
																			}
																			goto IL_0769;
																			IL_0769:
																			current7 = enumerator5.get_Current();
																			num14 = 0;
																			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
																			{
																				num14 = 0;
																			}
																			goto IL_0747;
																			IL_0747:
																			while (true)
																			{
																				switch (num14)
																				{
																				case 3:
																					break;
																				default:
																					if (!CheckType(typesToReplace, aW4AbAvEDOW3qvItRHmw(current7), out replaceTo))
																					{
																						num14 = 5;
																						continue;
																					}
																					goto case 1;
																				case 1:
																					((ParameterReference)current7).set_ParameterType(replaceTo);
																					num14 = 2;
																					continue;
																				case 2:
																				case 5:
																					goto IL_07e1;
																				case 4:
																					goto end_IL_07e1;
																				}
																				break;
																			}
																			goto IL_0769;
																			continue;
																			end_IL_07e1:
																			break;
																		}
																	}
																	finally
																	{
																		((IDisposable)enumerator5).Dispose();
																		int num15 = 0;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
																		{
																			num15 = 0;
																		}
																		switch (num15)
																		{
																		case 0:
																			break;
																		}
																	}
																	goto IL_0860;
																case 1:
																	goto IL_0860;
																case 5:
																	enumerator5 = current6.get_Parameters().GetEnumerator();
																	num13 = 0;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
																	{
																		num13 = 6;
																	}
																	continue;
																default:
																	goto IL_08a2;
																case 3:
																	goto end_IL_0860;
																}
																break;
															}
															qkerTuvEaifyqiVXDWjc(current6, replaceTo);
															num12 = 5;
															goto IL_06bb;
															continue;
															end_IL_0860:
															break;
														}
													}
													finally
													{
														((IDisposable)enumerator6).Dispose();
														int num16 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
														{
															num16 = 0;
														}
														switch (num16)
														{
														case 0:
															break;
														}
													}
													goto case 3;
												case 6:
													enumerator4 = ((MethodBody)KmMBmEvETLs96EVeDsVO(current4)).get_Variables().GetEnumerator();
													num7 = 10;
													continue;
												default:
													qkerTuvEaifyqiVXDWjc(current4, replaceTo);
													num7 = 4;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
													{
														num7 = 8;
													}
													continue;
												case 2:
													if (!CheckType(typesToReplace, uiODTXvEXjtqE8iVvQ63(current4), out replaceTo))
													{
														num7 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
														{
															num7 = 1;
														}
														continue;
													}
													goto default;
												case 1:
												case 8:
													enumerator5 = ((MethodReference)current4).get_Parameters().GetEnumerator();
													num7 = 5;
													continue;
												case 12:
													break;
												case 3:
													if (FNDHCWvEwxkjiP3j2p54(current4))
													{
														num7 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
														{
															num7 = 6;
														}
														continue;
													}
													goto IL_0a0a;
												case 4:
													enumerator6 = current4.get_Overrides().GetEnumerator();
													num7 = 8;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
													{
														num7 = 11;
													}
													continue;
												case 7:
													goto IL_0a0a;
												case 10:
													try
													{
														while (true)
														{
															IL_0aa8:
															int num8;
															if (!enumerator4.MoveNext())
															{
																num8 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
																{
																	num8 = 0;
																}
																goto IL_0a44;
															}
															goto IL_0ace;
															IL_0ace:
															current3 = enumerator4.get_Current();
															num8 = 3;
															goto IL_0a44;
															IL_0a44:
															while (true)
															{
																switch (num8)
																{
																case 2:
																	((VariableReference)current3).set_VariableType(replaceTo);
																	num8 = 1;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
																	{
																		num8 = 0;
																	}
																	continue;
																case 1:
																case 5:
																	goto IL_0aa8;
																case 4:
																	goto IL_0ace;
																case 3:
																	if (!CheckType(typesToReplace, ((VariableReference)current3).get_VariableType(), out replaceTo))
																	{
																		num8 = 5;
																		continue;
																	}
																	goto case 2;
																case 0:
																	break;
																}
																break;
															}
															break;
														}
													}
													finally
													{
														((IDisposable)enumerator4).Dispose();
														int num9 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
														{
															num9 = 0;
														}
														switch (num9)
														{
														case 0:
															break;
														}
													}
													goto IL_0a0a;
												case 9:
													goto end_IL_0a0a;
												}
												break;
											}
											goto IL_09a9;
											IL_09a9:
											current4 = enumerator3.get_Current();
											num7 = 2;
											goto IL_052f;
											continue;
											end_IL_0a0a:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator3).Dispose();
										int num17 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
										{
											num17 = 0;
										}
										switch (num17)
										{
										case 0:
											break;
										}
									}
									goto IL_04e1;
								case 8:
									try
									{
										while (true)
										{
											IL_0c63:
											int num5;
											if (!enumerator2.MoveNext())
											{
												num5 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
												{
													num5 = 1;
												}
												goto IL_0bc9;
											}
											goto IL_0c40;
											IL_0c40:
											current2 = enumerator2.get_Current();
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
											{
												num5 = 0;
											}
											goto IL_0bc9;
											IL_0bc9:
											while (true)
											{
												switch (num5)
												{
												default:
													if (!CheckType(typesToReplace, KTqbO4vEpugjJbiVEwWx(current2), out replaceTo))
													{
														num5 = 4;
														continue;
													}
													goto case 3;
												case 3:
													((FieldReference)current2).set_FieldType(replaceTo);
													num5 = 5;
													continue;
												case 2:
													break;
												case 4:
												case 5:
													goto IL_0c63;
												case 1:
													goto end_IL_0c63;
												}
												break;
											}
											goto IL_0c40;
											continue;
											end_IL_0c63:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator2).Dispose();
										int num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
										{
											num6 = 0;
										}
										switch (num6)
										{
										case 0:
											break;
										}
									}
									goto case 1;
								case 14:
									KBZboEvEGtxDPjt5srNF(current, replaceTo);
									num3 = 15;
									continue;
								case 13:
									goto end_IL_04e1;
								}
								break;
							}
							goto IL_027f;
							continue;
							end_IL_04e1:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num24 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
							{
								num24 = 0;
							}
							while (true)
							{
								switch (num24)
								{
								default:
									UwdDNsvGyVPTLJ7XKuQ5(enumerator);
									num24 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
									{
										num24 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 2;
				case 6:
					try
					{
						while (true)
						{
							IL_1014:
							int num25;
							if (!nI2mXnvGmait7AmwPp5n(enumerator))
							{
								num25 = 4;
								goto IL_0d91;
							}
							goto IL_0ff1;
							IL_0d91:
							while (true)
							{
								switch (num25)
								{
								case 3:
									try
									{
										while (true)
										{
											IL_0ec4:
											int num26;
											if (!enumerator9.MoveNext())
											{
												num26 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
												{
													num26 = 1;
												}
												goto IL_0dc3;
											}
											goto IL_0e78;
											IL_0e78:
											current11 = enumerator9.Current;
											num26 = 7;
											goto IL_0dc3;
											IL_0dc3:
											while (true)
											{
												int num27;
												switch (num26)
												{
												case 7:
													num28 = 0;
													num26 = 9;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
													{
														num26 = 9;
													}
													continue;
												case 4:
												case 9:
													if (num28 >= zhnvbQvE4c6QZOPg0SVI(current11.get_ConstructorArguments()))
													{
														num26 = 2;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
														{
															num26 = 0;
														}
														continue;
													}
													goto case 3;
												case 8:
												{
													object value = ((CustomAttributeArgument)(ref val)).get_Value();
													if ((typeReference = (TypeReference)((value is TypeReference) ? value : null)) != null)
													{
														num27 = 5;
														goto IL_0dbf;
													}
													goto default;
												}
												case 6:
													break;
												case 3:
													val = current11.get_ConstructorArguments().get_Item(num28);
													num26 = 8;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
													{
														num26 = 1;
													}
													continue;
												case 2:
													goto IL_0ec4;
												case 10:
												{
													Collection<CustomAttributeArgument> constructorArguments = current11.get_ConstructorArguments();
													int num29 = num28;
													val = current11.get_ConstructorArguments().get_Item(num28);
													constructorArguments.set_Item(num29, new CustomAttributeArgument(((CustomAttributeArgument)(ref val)).get_Type(), (object)replaceTo2));
													num26 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
													{
														num26 = 0;
													}
													continue;
												}
												case 5:
													if (!CheckType(typesToReplace, typeReference, out replaceTo2))
													{
														num27 = 11;
														goto IL_0dbf;
													}
													goto case 10;
												default:
													num28++;
													num27 = 4;
													goto IL_0dbf;
												case 1:
													goto end_IL_0ec4;
													IL_0dbf:
													num26 = num27;
													continue;
												}
												break;
											}
											goto IL_0e78;
											continue;
											end_IL_0ec4:
											break;
										}
									}
									finally
									{
										int num30;
										if (enumerator9 == null)
										{
											num30 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
											{
												num30 = 1;
											}
											goto IL_0f90;
										}
										goto IL_0fa6;
										IL_0fa6:
										enumerator9.Dispose();
										num30 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
										{
											num30 = 0;
										}
										goto IL_0f90;
										IL_0f90:
										switch (num30)
										{
										default:
											goto end_IL_0f6b;
										case 2:
											break;
										case 1:
											goto end_IL_0f6b;
										case 0:
											goto end_IL_0f6b;
										}
										goto IL_0fa6;
										end_IL_0f6b:;
									}
									goto IL_1014;
								case 1:
									break;
								case 2:
									goto IL_1014;
								default:
									enumerator9 = ((IEnumerable<CustomAttribute>)current10.get_CustomAttributes()).Concat(((IEnumerable<PropertyDefinition>)current10.get_Properties()).SelectMany((PropertyDefinition p) => (IEnumerable<CustomAttribute>)p.get_CustomAttributes())).Concat(((IEnumerable<MethodDefinition>)current10.get_Methods()).SelectMany((MethodDefinition p) => (IEnumerable<CustomAttribute>)p.get_CustomAttributes())).GetEnumerator();
									num25 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
									{
										num25 = 3;
									}
									continue;
								case 4:
									return;
								}
								break;
							}
							goto IL_0ff1;
							IL_0ff1:
							current10 = enumerator.Current;
							num25 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
							{
								num25 = 0;
							}
							goto IL_0d91;
						}
					}
					finally
					{
						int num31;
						if (enumerator == null)
						{
							num31 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
							{
								num31 = 2;
							}
							goto IL_10e7;
						}
						goto IL_111c;
						IL_111c:
						enumerator.Dispose();
						num31 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
						{
							num31 = 0;
						}
						goto IL_10e7;
						IL_10e7:
						switch (num31)
						{
						default:
							goto end_IL_10c2;
						case 2:
							goto end_IL_10c2;
						case 1:
							break;
						case 0:
							goto end_IL_10c2;
						}
						goto IL_111c;
						end_IL_10c2:;
					}
				case 1:
					return;
				case 5:
					typesToRemove.Count(delegate(TypeDefinition t)
					{
						//Discarded unreachable code: IL_0041, IL_0050
						int num34 = 1;
						int num35 = num34;
						while (true)
						{
							switch (num35)
							{
							case 2:
								return ((TypeDefinition)JtJ2RSvElF2LQ8W7yaej(t)).get_NestedTypes().Remove(t);
							default:
								return true;
							case 1:
								if (((ModuleDefinition)module).get_Types().Remove(t))
								{
									num35 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
									{
										num35 = 0;
									}
									break;
								}
								goto case 2;
							}
						}
					});
					num2 = 9;
					break;
				case 2:
					UpdateModule(module, typesToReplace, methodsToReplace, fieldsToReplace, (TypeDefinition t) => !typesToRemove.Contains(t));
					num2 = 5;
					break;
				default:
					enumerator = (from t in ((IEnumerable<TypeDefinition>)((ModuleDefinition)module).get_Types()).Where((TypeDefinition t) => _003C_003Ec.HN21ihZqMVIOkiokLc79(((MemberReference)t).get_FullName(), "<Module>")).SelectRecursive((TypeDefinition t) => (IEnumerable<TypeDefinition>)t.get_NestedTypes())
						where !typesToRemove.Contains(t)
						select t).GetEnumerator();
					num2 = 7;
					break;
				case 3:
				case 9:
					(from t in (from t in ((ModuleDefinition)module).GetTypeReferences().Where(delegate(TypeReference t)
							{
								//Discarded unreachable code: IL_00b1, IL_00c0
								int num32 = 2;
								int num33 = num32;
								AssemblyNameReference val2 = default(AssemblyNameReference);
								while (true)
								{
									switch (num33)
									{
									case 2:
									{
										object obj = _003C_003Ec.pW3aZYZq4faLqLChhLXV(t);
										if ((val2 = (AssemblyNameReference)((obj is AssemblyNameReference) ? obj : null)) == null)
										{
											num33 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
											{
												num33 = 1;
											}
											break;
										}
										goto default;
									}
									default:
										if (_003C_003Ec.DAK0RBZqte1jhB7xkPtu(_003C_003Ec.ibb3E9Zq6UxxiCCcIAWq(val2), _003C_003Ec.a9fLdkZqNth1063Ec3v1(0x3630F361 ^ 0x3630F905)))
										{
											return true;
										}
										num33 = 3;
										break;
									case 3:
										return _003C_003Ec.DAK0RBZqte1jhB7xkPtu(_003C_003Ec.ibb3E9Zq6UxxiCCcIAWq(val2), _003C_003Ec.a9fLdkZqNth1063Ec3v1(-488881205 ^ -488879643));
									case 1:
										return false;
									}
								}
							})
							select (t, Resolve(t))).Where<(TypeReference, Type)>(delegate((TypeReference typeReference, Type type) t)
						{
							string text = t.type?.Assembly.GetName().Name;
							return text == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317792434) || text == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740336584);
						})
						group t by t.type.Assembly.FullName).ForEach(delegate(IGrouping<string, (TypeReference typeReference, Type type)> g)
					{
						//IL_0062: Unknown result type (might be due to invalid IL or missing references)
						//IL_006c: Expected O, but got Unknown
						_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass17_0();
						CS_0024_003C_003E8__locals0._003C_003E4__this = this;
						CS_0024_003C_003E8__locals0.g = g;
						CS_0024_003C_003E8__locals0.assemblyReference = ((IEnumerable<AssemblyNameReference>)((ModuleDefinition)module).get_AssemblyReferences()).FirstOrDefault((AssemblyNameReference r) => _003C_003Ec__DisplayClass17_0.DjTvZCZXKGvn6gcl6d1N(_003C_003Ec__DisplayClass17_0.JcIT5dZXqbuFuTgRO9ms(r), CS_0024_003C_003E8__locals0.g.Key));
						if (CS_0024_003C_003E8__locals0.assemblyReference == null)
						{
							CS_0024_003C_003E8__locals0.assemblyReference = (AssemblyNameReference)((ModuleDefinition)module).Import(CS_0024_003C_003E8__locals0.g.First().type).get_Scope();
						}
						CS_0024_003C_003E8__locals0.g.ForEach(delegate((TypeReference typeReference, Type type) t)
						{
							t.typeReference.set_Scope((IMetadataScope)(object)CS_0024_003C_003E8__locals0.assemblyReference);
							CS_0024_003C_003E8__locals0._003C_003E4__this.typesToReplace[t.typeReference] = t.typeReference;
						});
					});
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 8;
					}
					break;
				case 8:
					enumerator = ((IEnumerable<TypeDefinition>)((ModuleDefinition)module).get_Types()).Where((TypeDefinition t) => (string)_003C_003Ec.BT0sQpZqaDafrV2McCSg(t) != "<Module>").SelectRecursive((TypeDefinition t) => (IEnumerable<TypeDefinition>)t.get_NestedTypes()).GetEnumerator();
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		private void ProcessDataClasses()
		{
			int num = 2;
			int num2 = num;
			MethodReference[] source = default(MethodReference[]);
			HashSet<TypeReference> source2 = default(HashSet<TypeReference>);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
				{
					object[] source3 = dataClasses.SelectMany((TypeDefinition d) => (IEnumerable<PropertyDefinition>)d.get_Properties()).SelectMany(delegate(PropertyDefinition p)
					{
						MethodDefinition getMethod = p.get_GetMethod();
						IEnumerable<object> first = ((getMethod != null) ? ((IEnumerable<Instruction>)getMethod.get_Body().get_Instructions()).Select((Instruction i) => _003C_003Ec.KDjPTvZqJDMOdoSyCGAy(i)) : null) ?? Enumerable.Empty<object>();
						MethodDefinition setMethod = p.get_SetMethod();
						return first.Concat(((setMethod != null) ? ((IEnumerable<Instruction>)setMethod.get_Body().get_Instructions()).Select((Instruction i) => i.get_Operand()) : null) ?? Enumerable.Empty<object>());
					}).ToArray();
					source = source3.OfType<MethodReference>().ToArray();
					source2 = source3.OfType<TypeReference>().Concat(source.Select((MethodReference m) => (TypeReference)_003C_003Ec.EOmUBgZq9XbdjOO4qXLP(m))).ToHashSet();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					break;
				}
				case 1:
					(from AssemblyNameReference a in (from m in source.Where(delegate(MethodReference m)
							{
								//IL_002a: Unknown result type (might be due to invalid IL or missing references)
								int num5 = 1;
								int num6 = num5;
								while (true)
								{
									switch (num6)
									{
									default:
										return A9uSVEvE5yAoDIUC5j1i(p63fUlvEgLODVrTw4fYm(Xy356bvErabC7DxcFKbI(m)));
									case 1:
										if (IsModuleScope(((MemberReference)m).get_DeclaringType()))
										{
											return false;
										}
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
										{
											num6 = 0;
										}
										break;
									}
								}
							})
							select (TypeReference)_003C_003Ec.EOmUBgZq9XbdjOO4qXLP(m)).Concat(source2.Where(delegate(TypeReference t)
						{
							//IL_002a: Unknown result type (might be due to invalid IL or missing references)
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return FOAQ4FvEYnW935MHK3qU(liM4RfvEEUCDxVFNfy8q(IeCkGpvEjrAv0brMAecd(t)));
								case 1:
									if (IsModuleScope(t))
									{
										return false;
									}
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
									{
										num4 = 0;
									}
									break;
								}
							}
						})).Select(GetScope)
						select (string)_003C_003Ec.ibb3E9Zq6UxxiCCcIAWq(a)).Distinct().ForEach(AddIgnoresAccessChecksToAttribute);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		private static bool CheckMethodAccessMask(MethodAttributes attributes)
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Invalid comparison between Unknown and I4
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Invalid comparison between Unknown and I4
			int num = 1;
			int num2 = num;
			MethodAttributes val = default(MethodAttributes);
			while (true)
			{
				switch (num2)
				{
				case 1:
					val = (MethodAttributes)(attributes & 7);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return (int)val == 4;
				}
				if ((int)val != 1)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				return true;
			}
		}

		private static bool CheckTypeAccessMask(TypeAttributes attributes)
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Invalid comparison between Unknown and I4
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Invalid comparison between Unknown and I4
			int num = 1;
			int num2 = num;
			TypeAttributes val = default(TypeAttributes);
			while (true)
			{
				switch (num2)
				{
				case 1:
					val = (TypeAttributes)(attributes & 7);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return (int)val == 4;
				default:
					if ((int)val != 0)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto IL_0051;
				case 3:
					{
						if ((int)val != 3)
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
							{
								num2 = 2;
							}
							break;
						}
						goto IL_0051;
					}
					IL_0051:
					return true;
				}
			}
		}

		private IMetadataScope GetScope(TypeReference type)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return (IMetadataScope)nSDsHdvEQbrUbcNuMVtd(type);
				case 1:
					if (btZMXovE6YGMeyylmnDy(type))
					{
						return GetScope((TypeReference)wEI7NVvEuI7pod8jreDD(type));
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		private bool IsModuleScope(TypeReference type)
		{
			return GetScope(type) == module;
		}

		private void AddIgnoresAccessChecksToAttribute(string assemblyName)
		{
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected O, but got Unknown
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			int num = 3;
			int num2 = num;
			CustomAttribute val = default(CustomAttribute);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					val = new CustomAttribute((MethodReference)moiA5lvEAdmxqGUgm5jA(module, e5aHAgvEHtRx2jal079E(typeof(IgnoresAccessChecksToAttribute).TypeHandle).GetConstructor(new Type[1] { e5aHAgvEHtRx2jal079E(typeof(string).TypeHandle) })));
					num2 = 2;
					break;
				case 1:
					((ModuleDefinition)module).get_Assembly().get_CustomAttributes().Add(val);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					val.get_ConstructorArguments().Add(new CustomAttributeArgument((TypeReference)h10rsRvE7HS9FfhOrAE1(((ModuleDefinition)module).get_TypeSystem()), (object)assemblyName));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		private void AddInterfaceMethodImplementation(TypeDefinition typeDefinition, string propertyName, TypeReference parameterType, MethodDefinition method, ref TypeReference interfaceReference)
		{
			//Discarded unreachable code: IL_0095, IL_00a4, IL_00fb, IL_010a, IL_020f, IL_021e, IL_0276, IL_0285
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Expected O, but got Unknown
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Expected O, but got Unknown
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_02da: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e4: Expected O, but got Unknown
			//IL_0372: Unknown result type (might be due to invalid IL or missing references)
			//IL_037c: Expected O, but got Unknown
			//IL_0398: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0417: Unknown result type (might be due to invalid IL or missing references)
			//IL_041e: Expected O, but got Unknown
			int num = 10;
			ILProcessor val2 = default(ILProcessor);
			MethodReference val3 = default(MethodReference);
			TypeReference value = default(TypeReference);
			MethodDefinition val = default(MethodDefinition);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 9:
						return;
					case 4:
						val2.Emit(OpCodes.Ret);
						num2 = 27;
						continue;
					case 13:
						return;
					case 16:
					case 17:
					case 25:
						val2.Emit(OpCodes.Call, (MethodReference)(object)method);
						num2 = 4;
						continue;
					case 18:
						return;
					case 26:
						if (fCBLyEvExGxeaIgqZsNp(interfaceReference) == null)
						{
							num2 = 15;
							continue;
						}
						goto case 14;
					case 2:
						val3.get_Parameters().Add(new ParameterDefinition(value));
						num2 = 8;
						continue;
					case 10:
						if (interfaceReference == null)
						{
							num2 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 7;
					case 7:
						if (!configurationModelProperties[((MemberReference)interfaceReference).get_FullName()].TryGetValue(propertyName, out value))
						{
							return;
						}
						num = 26;
						break;
					case 14:
						value = (TypeReference)kQK1kPvEIqbY1Us6wjtc(module, value);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 0;
						}
						continue;
					case 12:
						BYRFXmvEMACT45Ghpqib(val2, OpCodes.Ldarg_0);
						num2 = 28;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
						{
							num2 = 15;
						}
						continue;
					case 23:
						val3 = new MethodReference((string)wInmYJvEv3L9TNLy3x4u(method), (TypeReference)uiODTXvEXjtqE8iVvQ63(val), interfaceReference);
						num2 = 6;
						continue;
					case 22:
						val2 = (ILProcessor)lP9HpevEyPTldhGwJDff(val.get_Body());
						num2 = 12;
						continue;
					case 15:
						interfaceReference = (TypeReference)kQK1kPvEIqbY1Us6wjtc(module, interfaceReference);
						num2 = 14;
						continue;
					case 28:
						val2.Emit(OpCodes.Castclass, parameterType);
						num2 = 3;
						continue;
					case 6:
						if (jqFuYyvEJrYhth0D4udS(method))
						{
							num2 = 2;
							continue;
						}
						goto case 8;
					case 8:
						AddMethodReplace(val3, val);
						num2 = 13;
						continue;
					case 11:
						UqQXFdvEmS552wp8HMqw(val, (MethodImplAttributes)0);
						num2 = 22;
						continue;
					case 27:
						typeDefinition.get_Methods().Add(val);
						num = 23;
						break;
					default:
						((MethodReference)val).get_Parameters().Add(new ParameterDefinition(value));
						num2 = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
						{
							num2 = 24;
						}
						continue;
					case 3:
						if (!jqFuYyvEJrYhth0D4udS(method))
						{
							num2 = 17;
							continue;
						}
						goto default;
					case 5:
						if (!msXkNhvE94Q9RWpZ0TIq(((MemberReference)aW4AbAvEDOW3qvItRHmw(((MethodReference)val).get_Parameters().get_Item(1))).get_FullName(), ve3HnmvGg9SRuNo1X9NL(aW4AbAvEDOW3qvItRHmw(((MethodReference)method).get_Parameters().get_Item(0)))))
						{
							num2 = 25;
							continue;
						}
						goto case 20;
					case 19:
						((MethodReference)val).get_Parameters().Add(new ParameterDefinition((string)uvMl8QvGxXJLNc1YU10F(-812025778 ^ -811934896), (ParameterAttributes)1, interfaceReference));
						num2 = 21;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num2 = 7;
						}
						continue;
					case 20:
						MESGb0vEdJO3o4y1p1ws(val2, OpCodes.Castclass, aW4AbAvEDOW3qvItRHmw(((MethodReference)method).get_Parameters().get_Item(0)));
						num2 = 16;
						continue;
					case 21:
						P9qOl7vE0apan4feyj2s(val, false);
						num2 = 11;
						continue;
					case 24:
						BYRFXmvEMACT45Ghpqib(val2, OpCodes.Ldarg_1);
						num2 = 5;
						continue;
					case 1:
						val = new MethodDefinition((string)wInmYJvEv3L9TNLy3x4u(method), (MethodAttributes)22, method.get_IsGetter() ? value : ((ModuleDefinition)module).get_TypeSystem().get_Void());
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					break;
				}
			}
		}

		internal static void yJV7eEvG7LJ5q9M2EslM()
		{
			SingletonReader.PushGlobal();
		}

		internal static bool dAoYyKvGHd46hjPAX2v3()
		{
			return J3I0fUvG6IXsDGOEv1d5 == null;
		}

		internal static DeltaAssemblyProcessor Il8uAevGAc1BYm01Ceer()
		{
			return (DeltaAssemblyProcessor)J3I0fUvG6IXsDGOEv1d5;
		}

		internal static object uvMl8QvGxXJLNc1YU10F(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void S0PAadvG08Qi9OROsEwM(Type entityType, Type dataClassType)
		{
			SetCreator(entityType, dataClassType);
		}

		internal static bool nI2mXnvGmait7AmwPp5n(object P_0)
		{
			return ((IEnumerator)P_0).MoveNext();
		}

		internal static void UwdDNsvGyVPTLJ7XKuQ5(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		internal static object eh79NsvGMsWrtjkBuyqL(object P_0)
		{
			return MethodName(P_0);
		}

		internal static Type JqxPZcvGJ1K5l85qJuyh(object P_0)
		{
			return Resolve((TypeReference)P_0);
		}

		internal static bool NHZVdivG9EIWnGIEo7Wb(Type P_0, Type P_1)
		{
			return P_0 == P_1;
		}

		internal static object Yux9bmvGdusih5pI7WbC(object P_0)
		{
			return ((AssemblyDefinition)P_0).get_Name();
		}

		internal static object Kh22nkvGlDuDhQEdwFuH(object P_0)
		{
			return ((AssemblyNameReference)P_0).get_Name();
		}

		internal static bool TjuKRVvGr77Vq9RWDrQ3(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static object ve3HnmvGg9SRuNo1X9NL(object P_0)
		{
			return ((MemberReference)P_0).get_FullName();
		}

		internal static object o30ebSvG5buVdwaPnnni(object P_0, object P_1, object P_2)
		{
			return (string)P_0 + (string)P_1 + (string)P_2;
		}

		internal static Type blrqYKvGjPVUAOiDUwKf(object P_0)
		{
			return Type.GetType((string)P_0);
		}

		internal static bool hZ5pgtvGYIsGToUNxTBI(Type P_0, Type P_1)
		{
			return P_0 != P_1;
		}

		internal static bool t0LFWQvGLkwCNOQT7Nkv(object P_0)
		{
			return EntityDynamicGenerator.ContainsReplace(P_0);
		}

		internal static void Qwa0HyvGU9pCKbqYjQSr(Type type)
		{
			ReflectionType.Register(type);
		}

		internal static object SgYwTBvGsZXiv9mcMcLn(object P_0)
		{
			return CreateReference((TypeReference)P_0);
		}

		internal static void WvokcgvGc651au2ZrVEN(object P_0, object P_1)
		{
			EntityDynamicGenerator.AddReplace(P_0, P_1);
		}

		internal static object HmmgRuvGzuZoSyXVH2J0(object P_0, Type P_1)
		{
			return ((ModuleDefinition)P_0).Import(P_1);
		}

		internal static bool e8DWhivEF9AG02bN9PuV(object P_0)
		{
			return ((TypeDefinition)P_0).get_IsEnum();
		}

		internal static void XCdEAevEB8b2mmjLX91w(Type type, object P_1)
		{
			EnumProvider.AddType(type, (TypeDefinition)P_1);
		}

		internal static bool TjsW5bvEWsXmqfRMRj1S(object P_0)
		{
			return ((TypeDefinition)P_0).get_IsInterface();
		}

		internal static bool OEvGWZvEo54avmnJjd48(object P_0)
		{
			return ((TypeDefinition)P_0).get_IsClass();
		}

		internal static object Y5kG0wvEbiHEwhpSdYxY(object P_0)
		{
			return ((ModuleDefinition)P_0).get_TypeSystem();
		}

		internal static object gE6YgSvEhHS3Vuexw5Hc(object P_0)
		{
			return ((TypeSystem)P_0).get_Object();
		}

		internal static void KBZboEvEGtxDPjt5srNF(object P_0, object P_1)
		{
			((TypeDefinition)P_0).set_BaseType((TypeReference)P_1);
		}

		internal static TypeAttributes liM4RfvEEUCDxVFNfy8q(object P_0)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			return ((TypeDefinition)P_0).get_Attributes();
		}

		internal static void GTCaPpvEfFhWLaE6pBsm(object P_0, TypeAttributes P_1)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			((TypeDefinition)P_0).set_Attributes(P_1);
		}

		internal static object nSDsHdvEQbrUbcNuMVtd(object P_0)
		{
			return ((TypeReference)P_0).get_Scope();
		}

		internal static void bvuQN2vECrVeDy0OfQR8(object P_0, object P_1)
		{
			((AssemblyNameReference)P_0).set_Version((Version)P_1);
		}

		internal static object wInmYJvEv3L9TNLy3x4u(object P_0)
		{
			return ((MemberReference)P_0).get_Name();
		}

		internal static object BygEN7vE8efWKaQSk1lt(object P_0)
		{
			return ((PropertyDefinition)P_0).get_GetMethod();
		}

		internal static object Vv3A5dvEZU8w4vZdEDAL(object P_0)
		{
			return ((PropertyDefinition)P_0).get_SetMethod();
		}

		internal static object wEI7NVvEuI7pod8jreDD(object P_0)
		{
			return ((MemberReference)P_0).get_DeclaringType();
		}

		internal static object kQK1kPvEIqbY1Us6wjtc(object P_0, object P_1)
		{
			return ((ModuleDefinition)P_0).Import((TypeReference)P_1);
		}

		internal static void h1944kvEVF6xL7w5IdmZ(object P_0)
		{
			((Collection<FieldDefinition>)P_0).Clear();
		}

		internal static void eTRpChvES4aQlwFnuCXQ(object P_0)
		{
			((Collection<PropertyDefinition>)P_0).Clear();
		}

		internal static void fiJ5oMvEiWsx9rNYFLiI(object P_0)
		{
			((Collection<TypeReference>)P_0).Clear();
		}

		internal static object QIxgXxvERds4rycVaNVm()
		{
			return TypeReferenceComparer.Instance;
		}

		internal static int dk3BxavEqNqF5pqWao9W(object P_0)
		{
			return ((Dictionary<TypeReference, TypeDefinition>)P_0).Count;
		}

		internal static int CIeW1LvEKJqbRVaJsJ3O(object P_0)
		{
			return ((Collection<PropertyDefinition>)P_0).get_Count();
		}

		internal static object uiODTXvEXjtqE8iVvQ63(object P_0)
		{
			return ((MethodReference)P_0).get_ReturnType();
		}

		internal static object KmMBmEvETLs96EVeDsVO(object P_0)
		{
			return ((MethodDefinition)P_0).get_Body();
		}

		internal static object PT5qrFvEkeAydYxrNoNv(object P_0)
		{
			return ((Instruction)P_0).get_Operand();
		}

		internal static void cdBAdVvEnWbbUqffIMS1(object P_0, object P_1)
		{
			((MemberReference)P_0).set_DeclaringType((TypeReference)P_1);
		}

		internal static object QidgY9vEO7IEW9oKN9td(object P_0, object P_1)
		{
			return ((ModuleDefinition)P_0).Import((MethodReference)P_1);
		}

		internal static void pqyNxMvE2fjFRux3yLHj(object P_0)
		{
			((Collection<MethodReference>)P_0).Clear();
		}

		internal static int op17aRvEeJTqV24h5Mhd(object P_0)
		{
			return ((ICollection<KeyValuePair<TypeReference, TypeReference>>)P_0).Count;
		}

		internal static object n1C8QQvEPfDxcYobxkov(object P_0)
		{
			return ((TypeDefinition)P_0).get_BaseType();
		}

		internal static int m8VANjvE1F9DxbXsAeqQ(object P_0)
		{
			return ((Collection<TypeReference>)P_0).get_Count();
		}

		internal static object qjh1ZbvENiKg7TDriHC9(object P_0)
		{
			return ((PropertyReference)P_0).get_PropertyType();
		}

		internal static void sLLA6YvE36yJ9IJU38Mo(object P_0, object P_1)
		{
			((PropertyReference)P_0).set_PropertyType((TypeReference)P_1);
		}

		internal static object KTqbO4vEpugjJbiVEwWx(object P_0)
		{
			return ((FieldReference)P_0).get_FieldType();
		}

		internal static void qkerTuvEaifyqiVXDWjc(object P_0, object P_1)
		{
			((MethodReference)P_0).set_ReturnType((TypeReference)P_1);
		}

		internal static object aW4AbAvEDOW3qvItRHmw(object P_0)
		{
			return ((ParameterReference)P_0).get_ParameterType();
		}

		internal static void NMaT1QvEtIbaq3NV2y7o(object P_0, object P_1)
		{
			((ParameterReference)P_0).set_ParameterType((TypeReference)P_1);
		}

		internal static bool FNDHCWvEwxkjiP3j2p54(object P_0)
		{
			return ((MethodDefinition)P_0).get_HasBody();
		}

		internal static int zhnvbQvE4c6QZOPg0SVI(object P_0)
		{
			return ((Collection<CustomAttributeArgument>)P_0).get_Count();
		}

		internal static bool btZMXovE6YGMeyylmnDy(object P_0)
		{
			return ((TypeReference)P_0).get_IsNested();
		}

		internal static Type e5aHAgvEHtRx2jal079E(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object moiA5lvEAdmxqGUgm5jA(object P_0, object P_1)
		{
			return ((ModuleDefinition)P_0).Import((MethodBase)P_1);
		}

		internal static object h10rsRvE7HS9FfhOrAE1(object P_0)
		{
			return ((TypeSystem)P_0).get_String();
		}

		internal static object fCBLyEvExGxeaIgqZsNp(object P_0)
		{
			return ((MemberReference)P_0).get_Module();
		}

		internal static void P9qOl7vE0apan4feyj2s(object P_0, bool P_1)
		{
			((MethodReference)P_0).set_HasThis(P_1);
		}

		internal static void UqQXFdvEmS552wp8HMqw(object P_0, MethodImplAttributes P_1)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			((MethodDefinition)P_0).set_ImplAttributes(P_1);
		}

		internal static object lP9HpevEyPTldhGwJDff(object P_0)
		{
			return ((MethodBody)P_0).GetILProcessor();
		}

		internal static void BYRFXmvEMACT45Ghpqib(object P_0, OpCode P_1)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			((ILProcessor)P_0).Emit(P_1);
		}

		internal static bool jqFuYyvEJrYhth0D4udS(object P_0)
		{
			return ((MethodDefinition)P_0).get_IsSetter();
		}

		internal static bool msXkNhvE94Q9RWpZ0TIq(object P_0, object P_1)
		{
			return (string)P_0 != (string)P_1;
		}

		internal static void MESGb0vEdJO3o4y1p1ws(object P_0, OpCode P_1, object P_2)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			((ILProcessor)P_0).Emit(P_1, (TypeReference)P_2);
		}

		internal static object JtJ2RSvElF2LQ8W7yaej(object P_0)
		{
			return ((TypeDefinition)P_0).get_DeclaringType();
		}

		internal static object Xy356bvErabC7DxcFKbI(object P_0)
		{
			return ((MethodReference)P_0).Resolve();
		}

		internal static MethodAttributes p63fUlvEgLODVrTw4fYm(object P_0)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			return ((MethodDefinition)P_0).get_Attributes();
		}

		internal static bool A9uSVEvE5yAoDIUC5j1i(MethodAttributes attributes)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return CheckMethodAccessMask(attributes);
		}

		internal static object IeCkGpvEjrAv0brMAecd(object P_0)
		{
			return ((TypeReference)P_0).Resolve();
		}

		internal static bool FOAQ4FvEYnW935MHK3qU(TypeAttributes attributes)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return CheckTypeAccessMask(attributes);
		}
	}

	private class TypeReferenceComparer : IComparer<TypeReference>, IEqualityComparer<TypeReference>
	{
		internal static object YQX2DAvELRB7psJVCMJc;

		public static TypeReferenceComparer Instance { get; }

		private TypeReferenceComparer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			HhfLvlvEcZUvRp56IhRf();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		int IComparer<TypeReference>.Compare(TypeReference x, TypeReference y)
		{
			int num = 3;
			int num2 = num;
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				default:
					num3 = j4SiJZvfBsrBULRxl9Fd(PiU8t9vEzvoHhEYxT51s(), AssemblyName((IMetadataScope)Hb5hwbvfFef6eCf0UG8p(x)), AssemblyName(y.get_Scope()));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					if (num3 == 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				case 1:
					return num3;
				case 3:
					num3 = ((StringComparer)PiU8t9vEzvoHhEYxT51s()).Compare(((MemberReference)x).get_FullName(), ((MemberReference)y).get_FullName());
					num2 = 2;
					break;
				}
			}
		}

		bool IEqualityComparer<TypeReference>.Equals(TypeReference x, TypeReference y)
		{
			return ((IComparer<TypeReference>)this).Compare(x, y) == 0;
		}

		int IEqualityComparer<TypeReference>.GetHashCode(TypeReference obj)
		{
			return (1925753114 * -1521134295 + vUWh4PvfWuVXiDmeh7WO(obj).GetHashCode()) * -1521134295 + AssemblyName(obj.get_Scope()).GetHashCode();
		}

		private string AssemblyName(IMetadataScope scope)
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			int num = 1;
			int num2 = num;
			object obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = ((scope is AssemblyNameReference) ? scope : null);
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = ((AssemblyDefinition)G5ICcmvfopILftcxRkw8((object)(ModuleDefinition)scope)).get_Name();
					break;
				}
				break;
			}
			return (string)GvDmFSvfbUwI6XYVGdUT(obj);
		}

		static TypeReferenceComparer()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				default:
					Instance = new TypeReferenceComparer();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					SingletonReader.PushGlobal();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static void HhfLvlvEcZUvRp56IhRf()
		{
			SingletonReader.PushGlobal();
		}

		internal static bool MvX3LMvEUZFF2D3MW3ju()
		{
			return YQX2DAvELRB7psJVCMJc == null;
		}

		internal static TypeReferenceComparer elctHJvEs8bw6IIhyDPx()
		{
			return (TypeReferenceComparer)YQX2DAvELRB7psJVCMJc;
		}

		internal static object PiU8t9vEzvoHhEYxT51s()
		{
			return StringComparer.Ordinal;
		}

		internal static object Hb5hwbvfFef6eCf0UG8p(object P_0)
		{
			return ((TypeReference)P_0).get_Scope();
		}

		internal static int j4SiJZvfBsrBULRxl9Fd(object P_0, object P_1, object P_2)
		{
			return ((StringComparer)P_0).Compare((string)P_1, (string)P_2);
		}

		internal static object vUWh4PvfWuVXiDmeh7WO(object P_0)
		{
			return ((MemberReference)P_0).get_FullName();
		}

		internal static object G5ICcmvfopILftcxRkw8(object P_0)
		{
			return ((ModuleDefinition)P_0).get_Assembly();
		}

		internal static object GvDmFSvfbUwI6XYVGdUT(object P_0)
		{
			return ((AssemblyNameReference)P_0).get_FullName();
		}
	}

	private class CloneScope : IDisposable
	{
		[ThreadStatic]
		private static CloneScope current;

		private readonly object module;

		private readonly object prev;

		private readonly IDictionary<(string, Version), AssemblyNameReference> assemblyNameReferences;

		private readonly IDictionary<string, TypeReference> typeReferences;

		private static object vQ7p0yvfhEwo4iidpAok;

		public CloneScope(ModuleDefinition module = null)
		{
			//Discarded unreachable code: IL_004a, IL_004f
			hWkTgCvff4ffLkwAcH5L();
			assemblyNameReferences = new Dictionary<(string, Version), AssemblyNameReference>();
			typeReferences = new Dictionary<string, TypeReference>();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					prev = current;
					num = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num = 0;
					}
					break;
				case 3:
					current = this;
					num = 2;
					break;
				case 2:
					this.module = ((prev != null) ? ((CloneScope)prev).module : module);
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		public void Dispose()
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
					current = (CloneScope)prev;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public bool TryGetAssemblyNameReference(string name, Version version, out AssemblyNameReference assemblyNameReference)
		{
			//Discarded unreachable code: IL_0031, IL_0040
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_006a: Expected O, but got Unknown
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return true;
				case 1:
					if (!current.assemblyNameReferences.TryGetValue((name, version), out assemblyNameReference))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 3:
					return false;
				}
				IDictionary<(string, Version), AssemblyNameReference> dictionary = current.assemblyNameReferences;
				(string, Version) key = (name, version);
				AssemblyNameReference val = new AssemblyNameReference(name, version);
				AssemblyNameReference value = val;
				assemblyNameReference = val;
				dictionary[key] = value;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 2;
				}
			}
		}

		public bool TryGetTypeReference(string fullName, string @namespace, string name, IMetadataScope scope, bool isValueType, out TypeReference typeReference)
		{
			//Discarded unreachable code: IL_0031, IL_0040
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_006a: Expected O, but got Unknown
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return true;
				default:
				{
					IDictionary<string, TypeReference> dictionary = current.typeReferences;
					TypeReference val = new TypeReference(@namespace, name, (ModuleDefinition)null, scope, isValueType);
					TypeReference value = val;
					typeReference = val;
					dictionary[fullName] = value;
					num2 = 3;
					break;
				}
				case 3:
					return false;
				case 1:
					if (!current.typeReferences.TryGetValue(fullName, out typeReference))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}

		public TypeReference Import(TypeReference typeReference)
		{
			int num = 1;
			int num2 = num;
			object obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					object obj2 = module;
					if (obj2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = yM7tlLvfQCTGhXAkGtKl(obj2, typeReference);
					goto IL_005b;
				}
				default:
					obj = null;
					goto IL_005b;
				case 2:
					{
						obj = typeReference;
						break;
					}
					IL_005b:
					if (obj != null)
					{
						break;
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			return (TypeReference)obj;
		}

		internal static void hWkTgCvff4ffLkwAcH5L()
		{
			SingletonReader.PushGlobal();
		}

		internal static bool wSk2XMvfGqBcc47jXuAq()
		{
			return vQ7p0yvfhEwo4iidpAok == null;
		}

		internal static CloneScope ryhJkjvfEhvmdqTNyolG()
		{
			return (CloneScope)vQ7p0yvfhEwo4iidpAok;
		}

		internal static object yM7tlLvfQCTGhXAkGtKl(object P_0, object P_1)
		{
			return ((ModuleDefinition)P_0).Import((TypeReference)P_1);
		}
	}

	private class IdentifierRewriter : CSharpSyntaxRewriter
	{
		private readonly object generator;

		private object semanticModel;

		private ISet<INamedTypeSymbol> entityTypes;

		private static readonly object entityCode;

		private static readonly object entityDynamicTypeSyntax;

		private static object s8sieKvfCV4DTiFihhm6;

		public IdentifierRewriter(EntityDynamicGenerator generator)
		{
			//Discarded unreachable code: IL_002b, IL_0030
			iF1JJUvfZsFVFKIRySrN();
			((CSharpSyntaxRewriter)this)._002Ector(false);
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
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
				this.generator = generator;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num = 1;
				}
			}
		}

		static IdentifierRewriter()
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
					entityDynamicTypeSyntax = typeof(EntityDynamic<long>).CreateTypeSyntax();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 3;
					}
					break;
				case 2:
					SingletonReader.PushGlobal();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					entityCode = eAjCFFvfSoC9PIvggw8p(EleWise.ELMA.SDK.TypeOf.EntityDynamic1.Raw.Namespace.NamespaceDeclaration(((string)x3T6cjvfuWyaK6COQWrK(-1411196499 ^ -1410898855)).ClassDeclaration(new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x3137DF14) }, Accessibility.Public, DeclarationModifiers.Abstract, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x741C00E).CreateTypeSyntax((ISyntaxNode)rEi3btvfIGCNA9q4ZZjB(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858723917)))), ((string)x3T6cjvfuWyaK6COQWrK(-345420348 ^ -345173048)).ClassDeclaration(from t in zW7N13vfVo7Zuv2XwgJx(EleWise.ELMA.SDK.TypeOf.Entity1).GetGenericArguments()
						select (string)_003C_003Ec.JfbBWmZXO9aCq3tD5a3F(t), Accessibility.Public, DeclarationModifiers.Abstract, null, null, (from p in EleWise.ELMA.SDK.TypeOf.Entity1.Raw.GetProperties()
						select p.Name.PropertyDeclaration((ISyntaxNode)_003C_003Ec.KK8dhBZXeBqdvaR1rcYF(_003C_003Ec.XtClRvZX2QjFb0fcOl47(p)), Accessibility.Public)).Concat(from m in zW7N13vfVo7Zuv2XwgJx(EleWise.ELMA.SDK.TypeOf.Entity1).GetMethods()
						where !m.Attributes.HasFlag(MethodAttributes.SpecialName)
						select ((string)_003C_003Ec.JfbBWmZXO9aCq3tD5a3F(m)).MethodDeclaration(from p in m.GetParameters()
							select ((string)_003C_003Ec.PLZwW8ZXN0HEgUdLhqNU(p)).ParameterDeclaration((ISyntaxNode)_003C_003Ec.KK8dhBZXeBqdvaR1rcYF(_003C_003Ec.iQ1BL4ZX3jduf1pa80l6(p))), m.IsGenericMethod ? ((IEnumerable<Type>)_003C_003Ec.daAqI9ZXP8Cu85C76lQC(m)).Select((Type t) => (string)_003C_003Ec.JfbBWmZXO9aCq3tD5a3F(t)) : null, _003C_003Ec.SNZAsIZX1chXVPufPRjs(m).CreateTypeSyntax(), Accessibility.Public, DeclarationModifiers.Abstract)))));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		private SymbolInfo GetSymbolInfo(ExpressionSyntax expression)
		{
			//Discarded unreachable code: IL_0095, IL_00a4, IL_025d, IL_026d, IL_02a9, IL_02b8, IL_02c3, IL_03be, IL_03cd, IL_03ee, IL_042e, IL_043d, IL_0449, IL_0458, IL_0481, IL_04ae, IL_04bd, IL_04cc
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			int num = 20;
			_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
			IEnumerable<SyntaxTree> enumerable = default(IEnumerable<SyntaxTree>);
			EntityMetadata metadata = default(EntityMetadata);
			CSharpCompilation val = default(CSharpCompilation);
			ISyntaxNode syntaxNode = default(ISyntaxNode);
			IEnumerator<ClassDeclarationSyntax> enumerator = default(IEnumerator<ClassDeclarationSyntax>);
			ClassDeclarationSyntax current = default(ClassDeclarationSyntax);
			INamedTypeSymbol val2 = default(INamedTypeSymbol);
			EntityMetadata entityMetadata = default(EntityMetadata);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					object obj;
					switch (num2)
					{
					case 13:
						if (IM7FfFvfX7FMh4D4AoZy(xlQt1YvfK83boKcAJAeA(_003C_003Ec__DisplayClass7_.md), Guid.Empty))
						{
							num2 = 25;
							continue;
						}
						goto case 21;
					case 16:
						enumerable = enumerable.Append(SyntaxFactory.ParseSyntaxTree((string)entityCode, (ParseOptions)null, "", (Encoding)null, (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken)));
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
						{
							num2 = 10;
						}
						continue;
					case 22:
						metadata = ((EntityGenerator)generator).metadata;
						num = 15;
						break;
					case 11:
						enumerable = enumerable.Append(SyntaxFactory.ParseSyntaxTree((string)xLnp90vfRdStOVfWQrXs(_003C_003Ec__DisplayClass7_.md), (ParseOptions)null, "", (Encoding)null, (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken)));
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 14;
						}
						continue;
					case 18:
						if (XlGAJ4vfqho0Q4bhwJeP(_003C_003Ec__DisplayClass7_.md.CustomCode))
						{
							num2 = 3;
							continue;
						}
						goto case 11;
					case 12:
					case 19:
						return p2LNAavf3qpCSkVq21hX(semanticModel, expression, default(CancellationToken));
					case 1:
						if (((string)RML6TSvfO2uv9QK8uAjn(metadata)).IsNullOrWhiteSpace())
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
							{
								num2 = 2;
							}
							continue;
						}
						goto case 28;
					case 6:
						semanticModel = iSgfgkvf2RwHjqrRJQaY(val, FsusBIvfi9H6opNSwyWJ(expression), false);
						num2 = 17;
						continue;
					case 26:
						if (!XlGAJ4vfqho0Q4bhwJeP(xLnp90vfRdStOVfWQrXs(metadata)))
						{
							num2 = 7;
							continue;
						}
						goto case 9;
					case 7:
						enumerable = enumerable.Append(SyntaxFactory.ParseSyntaxTree((string)xLnp90vfRdStOVfWQrXs(metadata), (ParseOptions)null, "", (Encoding)null, (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken)));
						num2 = 9;
						continue;
					case 15:
						enumerable = Enumerable.Repeat<SyntaxTree>((SyntaxTree)FsusBIvfi9H6opNSwyWJ(expression), 1);
						num2 = 26;
						continue;
					case 21:
						obj = null;
						goto IL_05cc;
					case 2:
					case 27:
						enumerable = enumerable.Append(SyntaxFactory.ParseSyntaxTree((string)eAjCFFvfSoC9PIvggw8p(syntaxNode), (ParseOptions)null, "", (Encoding)null, (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken)));
						num2 = 18;
						continue;
					case 23:
						try
						{
							while (true)
							{
								IL_0393:
								int num3;
								if (!enumerator.MoveNext())
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
									{
										num3 = 1;
									}
									goto IL_02c7;
								}
								goto IL_0358;
								IL_0358:
								current = enumerator.Current;
								num3 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
								{
									num3 = 0;
								}
								goto IL_02c7;
								IL_02c7:
								while (true)
								{
									switch (num3)
									{
									case 3:
									case 6:
										if (val2 == null)
										{
											num3 = 4;
											continue;
										}
										goto case 2;
									case 7:
										val2 = (INamedTypeSymbol)Bwmga2vfPImxWDOyTO3b(semanticModel, current, default(CancellationToken));
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
										{
											num3 = 6;
										}
										continue;
									case 5:
										val2 = (INamedTypeSymbol)afblLVvf1h7jeOceADLS(val2);
										num3 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
										{
											num3 = 3;
										}
										continue;
									case 2:
										entityTypes.Add(val2);
										num3 = 5;
										continue;
									case 4:
										goto IL_0393;
									case 1:
										goto end_IL_0393;
									}
									break;
								}
								goto IL_0358;
								continue;
								end_IL_0393:
								break;
							}
						}
						finally
						{
							int num4;
							if (enumerator == null)
							{
								num4 = 2;
								goto IL_03f2;
							}
							goto IL_0408;
							IL_03f2:
							switch (num4)
							{
							default:
								goto end_IL_03dd;
							case 1:
								break;
							case 2:
								goto end_IL_03dd;
							case 0:
								goto end_IL_03dd;
							}
							goto IL_0408;
							IL_0408:
							YO5wX7vfNSnxhLtDyW0n(enumerator);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
							{
								num4 = 0;
							}
							goto IL_03f2;
							end_IL_03dd:;
						}
						goto case 12;
					case 20:
						if (semanticModel != null)
						{
							num = 19;
							break;
						}
						goto case 8;
					default:
						if (_003C_003Ec__DisplayClass7_.md == null)
						{
							num = 16;
							break;
						}
						goto case 13;
					case 10:
						val = CSharpCompilation.Create(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87335525), enumerable, (IEnumerable<MetadataReference>)null, (CSharpCompilationOptions)null);
						num2 = 6;
						continue;
					case 28:
						syntaxNode = ((string)RML6TSvfO2uv9QK8uAjn(metadata)).NamespaceDeclaration(syntaxNode);
						num2 = 27;
						continue;
					case 17:
						entityTypes = new HashSet<INamedTypeSymbol>();
						num2 = 24;
						continue;
					case 8:
						_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
						num = 22;
						break;
					case 3:
					case 14:
						_003C_003Ec__DisplayClass7_.md = entityMetadata;
						num2 = 5;
						continue;
					case 9:
						_003C_003Ec__DisplayClass7_.md = (IM7FfFvfX7FMh4D4AoZy(xlQt1YvfK83boKcAJAeA(metadata), Guid.Empty) ? ((EntityMetadata)MetadataServiceContext.Service.GetMetadata(metadata.BaseClassUid)) : null);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num2 = 0;
						}
						continue;
					case 25:
						obj = (EntityMetadata)((IMetadataService)BJvoMfvfT4AThqnXkvSk()).GetMetadata(xlQt1YvfK83boKcAJAeA(_003C_003Ec__DisplayClass7_.md), loadImplementation: true);
						goto IL_05cc;
					case 4:
						syntaxNode = ((string)VAjDl9vfk4XYL4XVmIyH(_003C_003Ec__DisplayClass7_.md)).ClassDeclaration(Accessibility.Public, DeclarationModifiers.Partial, (ISyntaxNode)(((entityMetadata != null) ? rEi3btvfIGCNA9q4ZZjB(WLOQotvfnIA7LyZoFwh3(entityMetadata)) : null) ?? entityDynamicTypeSyntax), null, _003C_003Ec__DisplayClass7_.md.Properties.Concat(_003C_003Ec__DisplayClass7_.md.TableParts.EmptyIfNull().Select(_003C_003Ec__DisplayClass7_._003CGetSymbolInfo_003Eb__0)).Select(delegate(PropertyMetadata p)
						{
							int num5 = 1;
							int num6 = num5;
							ISyntaxNode type = default(ISyntaxNode);
							ITypeGenerationInfo typeGenerationInfo = default(ITypeGenerationInfo);
							while (true)
							{
								switch (num6)
								{
								case 2:
									return ((string)ltg27PvfARnVHtwhQCVM(p)).PropertyDeclaration(type, Accessibility.Public);
								default:
									type = (ISyntaxNode)DQmyG7vfH4Anjf6VKlGu(generator, p, typeGenerationInfo);
									num6 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
									{
										num6 = 2;
									}
									break;
								case 1:
									typeGenerationInfo = (ITypeGenerationInfo)OrfX8Dvf6Mfto2pxjHwO(generator, p);
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
									{
										num6 = 0;
									}
									break;
								}
							}
						}));
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 1;
						}
						continue;
					case 24:
						{
							enumerator = ((SyntaxNode)r2J81RvfeVDaTdc0PFLP(FsusBIvfi9H6opNSwyWJ(expression), default(CancellationToken))).DescendantNodes((Func<SyntaxNode, bool>)((SyntaxNode n) => !(n is ClassDeclarationSyntax)), false).OfType<ClassDeclarationSyntax>().GetEnumerator();
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
							{
								num2 = 23;
							}
							continue;
						}
						IL_05cc:
						entityMetadata = (EntityMetadata)obj;
						num2 = 4;
						continue;
					}
					break;
				}
			}
		}

		public override SyntaxNode VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			return (SyntaxNode)RWifmjvfDCZv3cWgDKkL(node, (object)(ExpressionSyntax)((CSharpSyntaxVisitor<SyntaxNode>)(object)this).Visit((SyntaxNode)(object)node.get_Expression()), UnP0kHvfp6bAQ3da6sNF(node), eZgHV4vfaCXmnNs8iIv2(node));
		}

		public override SyntaxNode VisitVariableDeclaration(VariableDeclarationSyntax node)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			return (SyntaxNode)(object)node.Update((TypeSyntax)KvGt5vvft18Lcg5Nnq42(node), ((CSharpSyntaxRewriter)this).VisitList<VariableDeclaratorSyntax>(node.get_Variables()));
		}

		public override SyntaxNode VisitThisExpression(ThisExpressionSyntax node)
		{
			return (SyntaxNode)(object)SyntaxFactory.IdentifierName((string)x3T6cjvfuWyaK6COQWrK(-475857671 ^ -475943887));
		}

		public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node)
		{
			//Discarded unreachable code: IL_0049, IL_0058, IL_00d0, IL_00df, IL_0140
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			int num = 3;
			int num2 = num;
			SymbolInfo symbolInfo = default(SymbolInfo);
			System.Collections.Immutable.ImmutableArray<ISymbol> candidateSymbols = default(System.Collections.Immutable.ImmutableArray<ISymbol>);
			ISymbol val = default(ISymbol);
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 9:
					return (SyntaxNode)jjNBSPvf40aGWAfa4Gf2((SyntaxKind)8689, (object)(ExpressionSyntax)((CSharpSyntaxVisitor<SyntaxNode>)(object)this).VisitThisExpression((ThisExpressionSyntax)null), node);
				case 1:
					return (SyntaxNode)(object)node;
				case 3:
					symbolInfo = GetSymbolInfo((ExpressionSyntax)(object)node);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 2;
					}
					break;
				case 5:
					candidateSymbols = ((SymbolInfo)(ref symbolInfo)).get_CandidateSymbols();
					num2 = 8;
					break;
				case 2:
					obj = ((SymbolInfo)(ref symbolInfo)).get_Symbol();
					if (obj == null)
					{
						num2 = 5;
						break;
					}
					goto IL_0146;
				case 7:
					candidateSymbols = ((SymbolInfo)(ref symbolInfo)).get_CandidateSymbols();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 4;
					}
					break;
				case 8:
					if (candidateSymbols.get_IsEmpty())
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 7;
				case 4:
					obj = candidateSymbols[0];
					goto IL_0146;
				case 6:
					obj = null;
					goto IL_0146;
				default:
					{
						if (!entityTypes.Contains((INamedTypeSymbol)((val != null) ? K0dJA4vfwFCWXgS6WSL8(val) : null)))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 9;
					}
					IL_0146:
					val = (ISymbol)obj;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static void iF1JJUvfZsFVFKIRySrN()
		{
			SingletonReader.PushGlobal();
		}

		internal static bool WTeLwLvfv9H2lff6gt9o()
		{
			return s8sieKvfCV4DTiFihhm6 == null;
		}

		internal static IdentifierRewriter GfCb5Ovf8lfopXFAkhYR()
		{
			return (IdentifierRewriter)s8sieKvfCV4DTiFihhm6;
		}

		internal static object x3T6cjvfuWyaK6COQWrK(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object rEi3btvfIGCNA9q4ZZjB(object P_0)
		{
			return ((string)P_0).CreateTypeSyntax();
		}

		internal static Type zW7N13vfVo7Zuv2XwgJx(object P_0)
		{
			return ((RipeType)P_0).Raw;
		}

		internal static object eAjCFFvfSoC9PIvggw8p(object P_0)
		{
			return ((ISyntaxNode)P_0).GenerateCSCodeString();
		}

		internal static object FsusBIvfi9H6opNSwyWJ(object P_0)
		{
			return ((SyntaxNode)P_0).get_SyntaxTree();
		}

		internal static object xLnp90vfRdStOVfWQrXs(object P_0)
		{
			return ((ClassMetadata)P_0).CustomCode;
		}

		internal static bool XlGAJ4vfqho0Q4bhwJeP(object P_0)
		{
			return string.IsNullOrWhiteSpace((string)P_0);
		}

		internal static Guid xlQt1YvfK83boKcAJAeA(object P_0)
		{
			return ((ClassMetadata)P_0).BaseClassUid;
		}

		internal static bool IM7FfFvfX7FMh4D4AoZy(Guid P_0, Guid P_1)
		{
			return P_0 != P_1;
		}

		internal static object BJvoMfvfT4AThqnXkvSk()
		{
			return MetadataServiceContext.Service;
		}

		internal static object VAjDl9vfk4XYL4XVmIyH(object P_0)
		{
			return ((ClassMetadata)P_0).TypeName;
		}

		internal static object WLOQotvfnIA7LyZoFwh3(object P_0)
		{
			return ((ClassMetadata)P_0).FullTypeName;
		}

		internal static object RML6TSvfO2uv9QK8uAjn(object P_0)
		{
			return ((ClassMetadata)P_0).Namespace;
		}

		internal static object iSgfgkvf2RwHjqrRJQaY(object P_0, object P_1, bool P_2)
		{
			return ((CSharpCompilation)P_0).GetSemanticModel((SyntaxTree)P_1, P_2);
		}

		internal static object r2J81RvfeVDaTdc0PFLP(object P_0, CancellationToken P_1)
		{
			return CSharpExtensions.GetCompilationUnitRoot((SyntaxTree)P_0, P_1);
		}

		internal static object Bwmga2vfPImxWDOyTO3b(object P_0, object P_1, CancellationToken P_2)
		{
			return CSharpExtensions.GetDeclaredSymbol((SemanticModel)P_0, (BaseTypeDeclarationSyntax)P_1, P_2);
		}

		internal static object afblLVvf1h7jeOceADLS(object P_0)
		{
			return ((ITypeSymbol)P_0).get_BaseType();
		}

		internal static void YO5wX7vfNSnxhLtDyW0n(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		internal static SymbolInfo p2LNAavf3qpCSkVq21hX(object P_0, object P_1, CancellationToken P_2)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			return CSharpExtensions.GetSymbolInfo((SemanticModel)P_0, (ExpressionSyntax)P_1, P_2);
		}

		internal static SyntaxToken UnP0kHvfp6bAQ3da6sNF(object P_0)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			return ((MemberAccessExpressionSyntax)P_0).get_OperatorToken();
		}

		internal static object eZgHV4vfaCXmnNs8iIv2(object P_0)
		{
			return ((MemberAccessExpressionSyntax)P_0).get_Name();
		}

		internal static object RWifmjvfDCZv3cWgDKkL(object P_0, object P_1, SyntaxToken P_2, object P_3)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return ((MemberAccessExpressionSyntax)P_0).Update((ExpressionSyntax)P_1, P_2, (SimpleNameSyntax)P_3);
		}

		internal static object KvGt5vvft18Lcg5Nnq42(object P_0)
		{
			return ((VariableDeclarationSyntax)P_0).get_Type();
		}

		internal static object K0dJA4vfwFCWXgS6WSL8(object P_0)
		{
			return ((ISymbol)P_0).get_ContainingType();
		}

		internal static object jjNBSPvf40aGWAfa4Gf2(SyntaxKind P_0, object P_1, object P_2)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return SyntaxFactory.MemberAccessExpression(P_0, (ExpressionSyntax)P_1, (SimpleNameSyntax)P_2);
		}

		internal static object OrfX8Dvf6Mfto2pxjHwO(object P_0, object P_1)
		{
			return ((ClassGenerator)P_0).GetPropertyTypeDescriptor((PropertyMetadata)P_1);
		}

		internal static object DQmyG7vfH4Anjf6VKlGu(object P_0, object P_1, object P_2)
		{
			return ((ClassGenerator)P_0).GetPropertyTypeReference((PropertyMetadata)P_1, (ITypeGenerationInfo)P_2);
		}

		internal static object ltg27PvfARnVHtwhQCVM(object P_0)
		{
			return ((NamedMetadata)P_0).Name;
		}
	}

	public class AssemblyResolver : IAssemblyResolver
	{
		private readonly IDictionary<string, AssemblyDefinition> references;

		internal static AssemblyResolver EhsHK6vf7m2LPYjIkLEC;

		public AssemblyDefinition Resolve(AssemblyNameReference name)
		{
			//Discarded unreachable code: IL_00b1, IL_00c0, IL_00f1, IL_013a, IL_0149, IL_0192, IL_0269
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected O, but got Unknown
			//IL_00dd: Expected O, but got Unknown
			//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Expected O, but got Unknown
			//IL_01e3: Expected O, but got Unknown
			int num = 12;
			int num2 = num;
			MemoryStream memoryStream = default(MemoryStream);
			AssemblyDefinition value = default(AssemblyDefinition);
			Assembly assembly = default(Assembly);
			while (true)
			{
				object obj2;
				switch (num2)
				{
				case 11:
					if (!xaOdXXvfJNq7SI5EuNh3(t8kRmMvfyflBo9aRHGfi(name), vRnAOhvfMw15ZpN93tBU(-1411196499 ^ -1411198007)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 5:
				{
					MemoryStream memoryStream2 = memoryStream;
					ReaderParameters val2 = new ReaderParameters();
					EtYAifvfgZIRnuODr8FM((object)val2, this);
					value = (AssemblyDefinition)aTa5sqvfLwlKHICppDF5(memoryStream2, (object)val2);
					num2 = 13;
					continue;
				}
				case 17:
					return value;
				default:
					if ((string)t8kRmMvfyflBo9aRHGfi(name) == (string)vRnAOhvfMw15ZpN93tBU(-542721635 ^ -542723149))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 3:
				case 9:
				case 18:
					memoryStream = (MemoryStream)zfEJjmvfjJwagaTWlg63(assembly);
					num2 = 15;
					continue;
				case 16:
					if (!(assembly != null))
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 10;
				case 19:
					if (Ga1uKMvfrSnp4KQMVBkU(TO0PFQvfld9CYK6urPAh(assembly)))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 4;
				case 4:
				{
					object obj = TO0PFQvfld9CYK6urPAh(assembly);
					ReaderParameters val = new ReaderParameters();
					EtYAifvfgZIRnuODr8FM((object)val, this);
					value = (AssemblyDefinition)xpG9RSvf5bRIfjXnkW4r(obj, (object)val);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 15:
					if (memoryStream == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 2;
				case 10:
					if (kAl3MOvfdxPC2OsoU2Lx(assembly))
					{
						num2 = 18;
						continue;
					}
					goto case 19;
				case 12:
					if (!references.TryGetValue((string)n6OlSrvfmtfFpG1uMiwl(name), out value))
					{
						num2 = 11;
						continue;
					}
					goto case 17;
				case 6:
					obj2 = NtT5N8vf9blcHPsnmopH(n6OlSrvfmtfFpG1uMiwl(name), true);
					break;
				case 2:
					GbvlAVvfYJ46DopHXtpU(memoryStream, 0L, SeekOrigin.Begin);
					num2 = 5;
					continue;
				case 7:
				case 8:
				case 13:
				case 14:
					references[(string)n6OlSrvfmtfFpG1uMiwl(name)] = value;
					num2 = 17;
					continue;
				case 1:
					obj2 = ComponentManager.FindLoadedAssembly((string)t8kRmMvfyflBo9aRHGfi(name), isFullName: false);
					break;
				}
				assembly = (Assembly)obj2;
				num2 = 16;
			}
		}

		public AssemblyDefinition Resolve(AssemblyNameReference name, ReaderParameters parameters)
		{
			throw new NotImplementedException();
		}

		public AssemblyDefinition Resolve(string fullName)
		{
			throw new NotImplementedException();
		}

		public AssemblyDefinition Resolve(string fullName, ReaderParameters parameters)
		{
			throw new NotImplementedException();
		}

		public AssemblyResolver()
		{
			//Discarded unreachable code: IL_003a, IL_003f
			NTbNy2vfUxiyONhFSE5x();
			references = new Dictionary<string, AssemblyDefinition>();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object n6OlSrvfmtfFpG1uMiwl(object P_0)
		{
			return ((AssemblyNameReference)P_0).get_FullName();
		}

		internal static object t8kRmMvfyflBo9aRHGfi(object P_0)
		{
			return ((AssemblyNameReference)P_0).get_Name();
		}

		internal static object vRnAOhvfMw15ZpN93tBU(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool xaOdXXvfJNq7SI5EuNh3(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static object NtT5N8vf9blcHPsnmopH(object P_0, bool isFullName)
		{
			return ComponentManager.FindLoadedAssembly((string)P_0, isFullName);
		}

		internal static bool kAl3MOvfdxPC2OsoU2Lx(object P_0)
		{
			return ((Assembly)P_0).IsDynamic;
		}

		internal static object TO0PFQvfld9CYK6urPAh(object P_0)
		{
			return ((Assembly)P_0).Location;
		}

		internal static bool Ga1uKMvfrSnp4KQMVBkU(object P_0)
		{
			return string.IsNullOrEmpty((string)P_0);
		}

		internal static void EtYAifvfgZIRnuODr8FM(object P_0, object P_1)
		{
			((ReaderParameters)P_0).set_AssemblyResolver((IAssemblyResolver)P_1);
		}

		internal static object xpG9RSvf5bRIfjXnkW4r(object P_0, object P_1)
		{
			return AssemblyDefinition.ReadAssembly((string)P_0, (ReaderParameters)P_1);
		}

		internal static object zfEJjmvfjJwagaTWlg63(object P_0)
		{
			return ComponentManager.GetLoadedAssemblyRawAsStream((Assembly)P_0);
		}

		internal static long GbvlAVvfYJ46DopHXtpU(object P_0, long P_1, SeekOrigin P_2)
		{
			return ((Stream)P_0).Seek(P_1, P_2);
		}

		internal static object aTa5sqvfLwlKHICppDF5(object P_0, object P_1)
		{
			return AssemblyDefinition.ReadAssembly((Stream)P_0, (ReaderParameters)P_1);
		}

		internal static bool DjsFnQvfxdUsbaCj61bh()
		{
			return EhsHK6vf7m2LPYjIkLEC == null;
		}

		internal static AssemblyResolver RiXiAjvf072B8JJhFQ6b()
		{
			return EhsHK6vf7m2LPYjIkLEC;
		}

		internal static void NTbNy2vfUxiyONhFSE5x()
		{
			SingletonReader.PushGlobal();
		}
	}

	private sealed class EntityDynamicPermissionsGenerator : EntityDynamicGenerator
	{
		private readonly object entityMetadata;

		private static object QaritgvfsYFmHnIEOUAO;

		protected override bool HasCustomCode => true;

		public EntityDynamicPermissionsGenerator(EntityMetadata entityMetadata)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.PushGlobal();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					this.entityMetadata = entityMetadata;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		protected override IEnumerable<ISyntaxNode> GenerateMainFile()
		{
			return EntityPermissionsGenerator.GenerateMainFile(metadata, base.GenerateMainFile);
		}

		protected override IEnumerable<GeneratedFileInfo> GenerateCustomCodeResources()
		{
			return EntityPermissionsGenerator.GenerateCustomCodeResources((EntityMetadata)entityMetadata, metadata);
		}

		protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal()
		{
			return GenerateCustomCodeResources();
		}

		internal static bool ecs38CvfcBGe74qmxFwH()
		{
			return QaritgvfsYFmHnIEOUAO == null;
		}

		internal static EntityDynamicPermissionsGenerator hI004mvfzm7yl521Ohil()
		{
			return (EntityDynamicPermissionsGenerator)QaritgvfsYFmHnIEOUAO;
		}
	}

	private static readonly int AccessorClassNamePostfixLength;

	private static IDictionary<string, IDictionary<string, TypeReference>> configurationModelProperties;

	private static readonly Type CreatorType;

	private static readonly ILogger PublishLogger;

	private static readonly IDictionary<string, MethodReference> ReplaceMethods;

	private static readonly IDictionary<string, TypeReference> ReplaceTypes;

	[ThreadStatic]
	private static bool isEntityDynamicGenerating;

	internal const string DataClassName = "Data\u034f";

	[EditorBrowsable(EditorBrowsableState.Never)]
	public const string DataEntityFieldName = "entity\u034f";

	[EditorBrowsable(EditorBrowsableState.Never)]
	public const string ResolveDataMethodName = "ResolveData\u034f";

	private ISet<string> csScripts;

	private ISyntaxNode dataCtor;

	private IList<ISyntaxNode> dataInterfaceMembers;

	private IList<ISyntaxNode> dataClassMembers;

	private static EntityDynamicGenerator C511m3hkDxih6u0pCvk4;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static bool IsEntityDynamicGenerating
	{
		get
		{
			//Discarded unreachable code: IL_0035, IL_0044
			int num = 2;
			bool? dynamicPublicationEnable = default(bool?);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
						if (dynamicPublicationEnable.HasValue)
						{
							return dynamicPublicationEnable.GetValueOrDefault();
						}
						goto end_IL_0012;
					case 2:
						if (!isEntityDynamicGenerating)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						break;
					case 3:
						return false;
					case 1:
						return false;
					}
					dynamicPublicationEnable = ReflectionType.DynamicPublicationEnable;
					num2 = 4;
					continue;
					end_IL_0012:
					break;
				}
				num = 3;
			}
		}
	}

	private bool DynamicPublicationEnable
	{
		get
		{
			//Discarded unreachable code: IL_0062, IL_0071
			int num = 3;
			int num2 = num;
			bool? dynamicPublicationEnable = default(bool?);
			while (true)
			{
				switch (num2)
				{
				case 4:
					return false;
				case 2:
					return false;
				default:
					dynamicPublicationEnable = ReflectionType.DynamicPublicationEnable;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (dynamicPublicationEnable.HasValue)
					{
						return dynamicPublicationEnable.GetValueOrDefault();
					}
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 3;
					}
					break;
				case 3:
					if (D1hI47hns7WsrckyHJp7(metadata))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				}
			}
		}
	}

	protected override bool HasFilterClass
	{
		get
		{
			//Discarded unreachable code: IL_0064, IL_0073
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (metadata is TablePartMetadata)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return true;
				default:
					return base.HasFilterClass;
				case 3:
					if (!DynamicPublicationEnable)
					{
						num2 = 2;
						break;
					}
					goto case 1;
				}
			}
		}
	}

	internal static Assembly LoadDeltaAssembly(MemoryStream assemblyRaw, out IEnumerable<Type> changedTypes, out IEnumerable<Type> newTypes)
	{
		//Discarded unreachable code: IL_003d, IL_004c, IL_0139, IL_0148
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		int num = 5;
		int num2 = num;
		AssemblyResolver assemblyResolver = default(AssemblyResolver);
		AssemblyDefinition val = default(AssemblyDefinition);
		while (true)
		{
			switch (num2)
			{
			case 4:
			{
				ReaderParameters val2 = new ReaderParameters();
				val2.set_AssemblyResolver((IAssemblyResolver)(object)assemblyResolver);
				val = (AssemblyDefinition)eonSTThk4E7EQOr98lKN(assemblyRaw, (object)val2);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 6;
				}
				break;
			}
			case 1:
			{
				DeltaAssemblyProcessor deltaAssemblyProcessor = new DeltaAssemblyProcessor((ModuleDefinition)NNxEjmhkyEwD9BWgkfBY(val));
				Xakg6EhkMGJI3disi1jI(deltaAssemblyProcessor);
				MemoryStream memoryStream = (MemoryStream)j3moPjhkJfBAnjtd3BiK();
				YW4wC5hk9KsWtvtaV1XY(val, memoryStream);
				MU2aP8hkdxC4Yk7IqUQh(memoryStream, 0L, SeekOrigin.Begin);
				return deltaAssemblyProcessor.PostProcess((Assembly)u0RVOMhklXaIAWFamFWj(memoryStream, null), out changedTypes, out newTypes);
			}
			default:
				ybpkLYhkx6U2rQqwMxNP(SKuovGhk6fuKJCWWtcMA(val), new Version(((AssemblyNameReference)SKuovGhk6fuKJCWWtcMA(val)).get_Version().Major, BiLU2VhkATEw6kjqVkLx(r3TPvHhkHpuap4HlX5O8(SKuovGhk6fuKJCWWtcMA(val))), E11vVMhk729qg4RhV6V6(r3TPvHhkHpuap4HlX5O8(SKuovGhk6fuKJCWWtcMA(val))), ((Version)r3TPvHhkHpuap4HlX5O8(SKuovGhk6fuKJCWWtcMA(val))).Revision + 1));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 3;
				}
				break;
			case 5:
				assemblyResolver = new AssemblyResolver();
				num2 = 4;
				break;
			case 3:
			case 6:
				if (iEqA3LhkmuHDBqZnIkvq(ComponentManager.FindLoadedAssembly((string)AsNnoJhk0j4rprL1pWdc(val), isFullName: true), null))
				{
					num2 = 2;
					break;
				}
				goto case 1;
			}
		}
	}

	internal static MemoryStream RemoveDynamicTypes(MemoryStream assemblyRaw, IEnumerable<IMetadata> systemExtendedMetadata, IEnumerable<IMetadata> filterableMetadata)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		AssemblyResolver assemblyResolver = new AssemblyResolver();
		ReaderParameters val = new ReaderParameters();
		val.set_AssemblyResolver((IAssemblyResolver)(object)assemblyResolver);
		AssemblyDefinition val2 = AssemblyDefinition.ReadAssembly((Stream)assemblyRaw, val);
		CS_0024_003C_003E8__locals0.typeNames = systemExtendedMetadata.Cast<ClassMetadata>().ToDictionary((ClassMetadata m) => (string)_003C_003Ec.CDkIJHvQKDW95mUmlkiW(m.Namespace, _003C_003Ec.Tgs9RuvQq5pEfWSAs3bn(0x68BBB53E ^ 0x68BBAFFA), m.Name), (ClassMetadata m) => (string)_003C_003Ec.GRXT7fvQTCiVt8htb3is(_003C_003Ec.REbcGxvQXIaEDRZpTfW2(m)));
		filterableMetadata.Cast<ClassMetadata>().ForEach(delegate(ClassMetadata m)
		{
			int num = 1;
			int num2 = num;
			string text = default(string);
			while (true)
			{
				switch (num2)
				{
				case 1:
					text = (string)_003C_003Ec__DisplayClass3_0.lwqOeavQEOhEyarApQLJ(_003C_003Ec__DisplayClass3_0.F17iBgvQbtKAPiiqvJng(m), _003C_003Ec__DisplayClass3_0.RSenmevQhIhDjc0puSZC(0x76DD48E ^ 0x76DCE4A), _003C_003Ec__DisplayClass3_0.aBtdIjvQGustxrHHVa28(m));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				default:
				{
					CS_0024_003C_003E8__locals0.typeNames.Add(text + (string)_003C_003Ec__DisplayClass3_0.RSenmevQhIhDjc0puSZC(-488881205 ^ -488898313), (string)_003C_003Ec__DisplayClass3_0.EvyPdZvQQXsVpv8dCbFQ(CS_0024_003C_003E8__locals0.typeNames.TryGetValue(text, out var value) ? value : _003C_003Ec__DisplayClass3_0.NnfPn9vQfodCIR6xla1I(m), _003C_003Ec__DisplayClass3_0.RSenmevQhIhDjc0puSZC(0x49E27B8A ^ 0x49E238B6)));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 1;
					}
					break;
				}
				}
			}
		});
		TypeDefinition[] array = ((IEnumerable<TypeDefinition>)val2.get_MainModule().get_Types()).Where((TypeDefinition t) => CS_0024_003C_003E8__locals0.typeNames.ContainsKey((string)_003C_003Ec__DisplayClass3_0.daqEUhvQCpLdVMwWX4Fs(t))).ToArray();
		foreach (TypeDefinition val3 in array)
		{
			_003C_003Ec__DisplayClass3_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass3_1();
			CS_0024_003C_003E8__locals1.interfaceName = CS_0024_003C_003E8__locals0.typeNames[((MemberReference)val3).get_FullName()];
			TypeReference obj = ((IEnumerable<TypeReference>)val3.get_Interfaces()).SingleOrDefault((TypeReference i) => _003C_003Ec__DisplayClass3_1.YGevEivQIr7YSGslp5on(((MemberReference)i).get_FullName(), CS_0024_003C_003E8__locals1.interfaceName));
			TypeDefinition val4 = (TypeDefinition)(object)((obj is TypeDefinition) ? obj : null);
			if (val4 != null)
			{
				val3.get_Interfaces().Remove((TypeReference)(object)val4);
				val2.get_MainModule().get_Types().Remove(val4);
			}
		}
		MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
		val2.Write((Stream)memoryStream);
		memoryStream.Seek(0L, SeekOrigin.Begin);
		return memoryStream;
	}

	private static void SetCreator(Type entityType, Type dataClassType)
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
				Type type = CreatorType.MakeGenericType(entityType);
				MethodInfo method = dataClassType.GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637E6BEF));
				E3DvSnhkg14KJsj2wGOF(type.GetMethod((string)aKKQkChkr8RWXNo8cDHU(0x57A5235E ^ 0x57A66D36), BindingFlags.Static | BindingFlags.NonPublic).MakeGenericMethod(entityType.GetNestedType((string)aKKQkChkr8RWXNo8cDHU(-1870892489 ^ -1870709577), BindingFlags.NonPublic)), null, new object[2]
				{
					method.Invoke(null, null),
					dataClassType
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	private static AssemblyNameReference CreateReference(object name)
	{
		//Discarded unreachable code: IL_00e3, IL_00f2, IL_01a3, IL_01db, IL_01ea
		int num = 1;
		int num2 = num;
		CloneScope cloneScope = default(CloneScope);
		AssemblyNameReference result = default(AssemblyNameReference);
		while (true)
		{
			switch (num2)
			{
			case 1:
				cloneScope = new CloneScope();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				int num3;
				if (cloneScope.TryGetAssemblyNameReference((string)Q4L8MNhk5vu7cNYiJAPh(name), (Version)ivqncshkj5Tt6q9RGxYY(name), out var assemblyNameReference))
				{
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num3 = 1;
					}
					goto IL_0086;
				}
				goto IL_0156;
				IL_0156:
				assemblyNameReference.set_Culture((string)s1uE7bhkYP8YX1NbM01V(name));
				num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num3 = 0;
				}
				goto IL_0086;
				IL_0086:
				while (true)
				{
					switch (num3)
					{
					case 5:
						return result;
					case 2:
					{
						zEXsNXhkcmTSKAgeHCUd(assemblyNameReference, ((AssemblyName)name).GetPublicKeyToken());
						int num4 = 6;
						num3 = num4;
						continue;
					}
					default:
						KrQUpWhkL2ft7QNheeJZ(assemblyNameReference, (AssemblyHashAlgorithm)((AssemblyName)name).HashAlgorithm);
						num3 = 3;
						continue;
					case 3:
						L8DslRhksqtmYKrx3wLy(assemblyNameReference, uosokNhkUQeNnqL4MbA8(name).HasFlag(AssemblyNameFlags.Retargetable));
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num3 = 2;
						}
						continue;
					case 1:
					case 6:
						result = assemblyNameReference;
						num3 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num3 = 3;
						}
						continue;
					case 4:
						break;
					}
					break;
				}
				goto IL_0156;
			}
			finally
			{
				if (cloneScope != null)
				{
					int num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num5 = 1;
					}
					while (true)
					{
						switch (num5)
						{
						case 1:
							tNcLjRhkzumcZrtq5X5u(cloneScope);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
							{
								num5 = 0;
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

	private static TypeReference CreateReference(Type type)
	{
		//Discarded unreachable code: IL_007e, IL_00df, IL_0117, IL_0126
		int num = 1;
		int num2 = num;
		CloneScope cloneScope = default(CloneScope);
		TypeReference result = default(TypeReference);
		while (true)
		{
			switch (num2)
			{
			case 1:
				cloneScope = new CloneScope();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				cloneScope.TryGetTypeReference((string)qk78g7hnFlRgPdbvtOID(type.FullName, '+', '/'), type.Namespace, (string)tyblcIhnB7rUgH0mbXRr(type), (IMetadataScope)l9JSaAhno456rwu0XE9d(J4YrL5hnWD3sjkq0DINm(type.Assembly)), type.IsValueType, out var typeReference);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						result = (TypeReference)oI2MPOhnbKqkeYbZqJ9h(cloneScope, typeReference);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num3 = 0;
						}
						break;
					default:
						return result;
					case 0:
						return result;
					}
				}
			}
			finally
			{
				if (cloneScope != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							tNcLjRhkzumcZrtq5X5u(cloneScope);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
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
		}
	}

	private static MethodReference CreateReference(object method)
	{
		//Discarded unreachable code: IL_00a7, IL_0164, IL_019c, IL_01ab
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008d: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		CloneScope cloneScope = default(CloneScope);
		MethodReference result = default(MethodReference);
		while (true)
		{
			switch (num2)
			{
			case 1:
				cloneScope = new CloneScope();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				MethodReference val = new MethodReference((string)tyblcIhnB7rUgH0mbXRr(method), (TypeReference)JvlmUhhnGMDjcsLAgBhk(f3tMUwhnhMyGbcp34OdJ(method)), (TypeReference)JvlmUhhnGMDjcsLAgBhk(((MemberInfo)method).DeclaringType));
				amL2IUhnfxBSmBR7EZex((object)val, rbHFDRhnE2GY4HupLoBY(method).HasFlag(CallingConventions.HasThis));
				eIckYihnQpwNiGKo9sYN((object)val, rbHFDRhnE2GY4HupLoBY(method).HasFlag(CallingConventions.ExplicitThis));
				jiuNWjhnCUtNoMAmBlRC((object)val, (MethodCallingConvention)0);
				MethodReference val2 = val;
				int num3 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num3 = 2;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						result = val2;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num3 = 0;
						}
						break;
					case 2:
						((IEnumerable<ParameterInfo>)SkgmXOhnvs2sMIyGtQpc(method)).Select((Func<ParameterInfo, ParameterDefinition>)((ParameterInfo p) => new ParameterDefinition((TypeReference)_003C_003Ec.UHFo8pvQk48HWdxjVvIo(p.ParameterType)))).ForEach((Action<ParameterDefinition>)val2.get_Parameters().Add);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num3 = 0;
						}
						break;
					case 1:
						return result;
					}
				}
			}
			finally
			{
				if (cloneScope != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							((IDisposable)cloneScope).Dispose();
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
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
		}
	}

	private static AssemblyNameReference CreateReference(object name)
	{
		//Discarded unreachable code: IL_0072, IL_0154, IL_0167, IL_022f, IL_0267, IL_0276
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num2 = num;
		AssemblyNameReference result = default(AssemblyNameReference);
		CloneScope cloneScope = default(CloneScope);
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 2:
				cloneScope = new CloneScope();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					int num3;
					if (cloneScope.TryGetAssemblyNameReference((string)o8xwr1hn8QFrgSQawYTL(name), ((AssemblyNameReference)name).get_Version(), out var assemblyNameReference))
					{
						num3 = 11;
						goto IL_0076;
					}
					goto IL_0198;
					IL_0076:
					while (true)
					{
						switch (num3)
						{
						case 7:
							return result;
						case 6:
							array = new byte[((Array)r2vLb2hnI8WhkjRBsatI(name)).Length];
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
							{
								num3 = 2;
							}
							continue;
						case 2:
							BKCVPqhnVhtIHFwcG8jA(r2vLb2hnI8WhkjRBsatI(name), array, 0);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
							{
								num3 = 0;
							}
							continue;
						case 4:
							KrQUpWhkL2ft7QNheeJZ(assemblyNameReference, ((AssemblyNameReference)name).get_HashAlgorithm());
							num3 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
							{
								num3 = 6;
							}
							continue;
						case 5:
						{
							object obj = r2vLb2hnI8WhkjRBsatI(name);
							if (obj == null)
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
								{
									num3 = 10;
								}
								continue;
							}
							if (((Array)obj).Length != 0)
							{
								goto case 6;
							}
							goto case 10;
						}
						case 9:
							L8DslRhksqtmYKrx3wLy(assemblyNameReference, syFZfChnuR3gD6oEGH58(name));
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
							{
								num3 = 5;
							}
							continue;
						case 8:
							break;
						default:
							zEXsNXhkcmTSKAgeHCUd(assemblyNameReference, array);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
						case 3:
						case 11:
							result = assemblyNameReference;
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
							{
								num3 = 7;
							}
							continue;
						case 10:
							num3 = 3;
							continue;
						}
						break;
					}
					goto IL_0198;
					IL_0198:
					QvXIZuhnZl9ZH18gcyJc(assemblyNameReference, ((AssemblyNameReference)name).get_Culture());
					num3 = 4;
					goto IL_0076;
				}
				finally
				{
					if (cloneScope != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								tNcLjRhkzumcZrtq5X5u(cloneScope);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
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
				}
			}
		}
	}

	private static IMetadataScope CreateReference(object scope)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj = ((scope is AssemblyNameReference) ? scope : null);
				if (obj != null)
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				obj = SKuovGhk6fuKJCWWtcMA(((ModuleDefinition)scope).get_Assembly());
				break;
			}
			break;
		}
		return (IMetadataScope)wQ5Zt3hnSKhywmgQWoi0(obj);
	}

	internal static TypeReference CreateReference(TypeReference type)
	{
		return CreateReference((object)type, (Func<GenericParameter, GenericParameter>)null);
	}

	private static TypeReference CreateReference(object type, Func<GenericParameter, GenericParameter> genericParameterResolver)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass16_0();
		CS_0024_003C_003E8__locals0.genericParameterResolver = genericParameterResolver;
		using CloneScope cloneScope = new CloneScope();
		if (type != null)
		{
			ArrayType val;
			if ((val = (ArrayType)((type is ArrayType) ? type : null)) != null)
			{
				ArrayType val2 = val;
				ArrayType val3 = new ArrayType(CreateReference((object)((TypeSpecification)val2).get_ElementType(), CS_0024_003C_003E8__locals0.genericParameterResolver));
				if (!val2.get_IsVector())
				{
					val3.get_Dimensions().Clear();
					((IEnumerable<ArrayDimension>)val2.get_Dimensions()).Select((Func<ArrayDimension, ArrayDimension>)((ArrayDimension d) => new ArrayDimension(((ArrayDimension)(ref d)).get_LowerBound(), ((ArrayDimension)(ref d)).get_UpperBound()))).ForEach((Action<ArrayDimension>)val3.get_Dimensions().Add);
				}
				return cloneScope.Import((TypeReference)(object)val3);
			}
			PointerType val4;
			if ((val4 = (PointerType)((type is PointerType) ? type : null)) != null)
			{
				PointerType val5 = val4;
				return cloneScope.Import((TypeReference)new PointerType(CreateReference((object)((TypeSpecification)val5).get_ElementType(), CS_0024_003C_003E8__locals0.genericParameterResolver)));
			}
			ByReferenceType val6;
			if ((val6 = (ByReferenceType)((type is ByReferenceType) ? type : null)) != null)
			{
				ByReferenceType val7 = val6;
				return cloneScope.Import((TypeReference)new ByReferenceType(CreateReference((object)((TypeSpecification)val7).get_ElementType(), CS_0024_003C_003E8__locals0.genericParameterResolver)));
			}
			PinnedType val8;
			if ((val8 = (PinnedType)((type is PinnedType) ? type : null)) != null)
			{
				PinnedType val9 = val8;
				return cloneScope.Import((TypeReference)new PinnedType(CreateReference((object)((TypeSpecification)val9).get_ElementType(), CS_0024_003C_003E8__locals0.genericParameterResolver)));
			}
			SentinelType val10;
			if ((val10 = (SentinelType)((type is SentinelType) ? type : null)) != null)
			{
				SentinelType val11 = val10;
				return cloneScope.Import((TypeReference)new SentinelType(CreateReference((object)((TypeSpecification)val11).get_ElementType(), CS_0024_003C_003E8__locals0.genericParameterResolver)));
			}
			OptionalModifierType val12;
			if ((val12 = (OptionalModifierType)((type is OptionalModifierType) ? type : null)) != null)
			{
				OptionalModifierType val13 = val12;
				return cloneScope.Import((TypeReference)new OptionalModifierType(CreateReference((object)val13.get_ModifierType(), CS_0024_003C_003E8__locals0.genericParameterResolver), CreateReference((object)((TypeSpecification)val13).get_ElementType(), CS_0024_003C_003E8__locals0.genericParameterResolver)));
			}
			RequiredModifierType val14;
			if ((val14 = (RequiredModifierType)((type is RequiredModifierType) ? type : null)) != null)
			{
				RequiredModifierType val15 = val14;
				return cloneScope.Import((TypeReference)new RequiredModifierType(CreateReference((object)val15.get_ModifierType(), CS_0024_003C_003E8__locals0.genericParameterResolver), CreateReference((object)((TypeSpecification)val15).get_ElementType(), CS_0024_003C_003E8__locals0.genericParameterResolver)));
			}
			GenericInstanceType val16;
			if ((val16 = (GenericInstanceType)((type is GenericInstanceType) ? type : null)) != null)
			{
				GenericInstanceType val17 = new GenericInstanceType(CreateReference(((TypeSpecification)val16).get_ElementType()));
				((IEnumerable<TypeReference>)val16.get_GenericArguments()).Select((TypeReference a) => CreateReference((object)a, CS_0024_003C_003E8__locals0.genericParameterResolver)).ForEach((Action<TypeReference>)val17.get_GenericArguments().Add);
				return cloneScope.Import((TypeReference)(object)val17);
			}
			GenericParameter val18;
			if ((val18 = (GenericParameter)((type is GenericParameter) ? type : null)) != null)
			{
				GenericParameter arg = val18;
				return (TypeReference)(object)(CS_0024_003C_003E8__locals0.genericParameterResolver?.Invoke(arg) ?? throw new NotSupportedException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561126412)));
			}
		}
		_003C_003Ec__DisplayClass16_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass16_1();
		if (!cloneScope.TryGetTypeReference(((MemberReference)type).get_FullName(), ((TypeReference)type).get_Namespace(), ((MemberReference)type).get_Name(), EntityDynamicGenerator.CreateReference((object)((TypeReference)type).get_Scope()), ((TypeReference)type).get_IsValueType(), out CS_0024_003C_003E8__locals1.reference))
		{
			if (((TypeReference)type).get_IsNested())
			{
				((MemberReference)CS_0024_003C_003E8__locals1.reference).set_DeclaringType(CreateReference(((MemberReference)type).get_DeclaringType()));
			}
			if (((TypeReference)type).get_HasGenericParameters())
			{
				((IEnumerable<GenericParameter>)((TypeReference)type).get_GenericParameters()).Select((Func<GenericParameter, GenericParameter>)((GenericParameter p) => new GenericParameter((string)_003C_003Ec__DisplayClass16_1.AEEKFkvQ5kpXXJDjgc5U(p), (IGenericParameterProvider)(object)CS_0024_003C_003E8__locals1.reference))).ForEach((Action<GenericParameter>)CS_0024_003C_003E8__locals1.reference.get_GenericParameters().Add);
			}
			CS_0024_003C_003E8__locals1.reference = cloneScope.Import(CS_0024_003C_003E8__locals1.reference);
		}
		return CS_0024_003C_003E8__locals1.reference;
	}

	internal static Type Resolve(TypeReference type)
	{
		//Discarded unreachable code: IL_0095, IL_0153, IL_0162, IL_0172, IL_0181, IL_01f7, IL_0206, IL_02a2, IL_02b1, IL_0300, IL_030f, IL_031f, IL_032e, IL_0468, IL_047b
		int num = 26;
		GenericInstanceType val4 = default(GenericInstanceType);
		Type type2 = default(Type);
		TypeReference val = default(TypeReference);
		ArrayType val7 = default(ArrayType);
		ArrayType val8 = default(ArrayType);
		ByReferenceType val5 = default(ByReferenceType);
		PointerType val6 = default(PointerType);
		GenericInstanceType val3 = default(GenericInstanceType);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 4:
					return iRZ96shnRtiPlIIchpNs(h9y15jhnifgRJAE2wDrn(val4)).MakeGenericType(((IEnumerable<TypeReference>)val4.get_GenericArguments()).Select(Resolve).ToArray());
				case 9:
					throw new NotSupportedException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A30B0A6));
				case 18:
					type2 = ReflectionType.GetType((string)hJ2KTshnTG9rxiU91BuJ(qk78g7hnFlRgPdbvtOID(Ofp4m0hnKhKS8lVhbBkZ(type), '/', '+'), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x72470E88), cWAOhIhnXlY19adVMb14(type)));
					num2 = 22;
					continue;
				case 16:
				{
					OptionalModifierType val12;
					if ((val12 = (OptionalModifierType)(object)((val is OptionalModifierType) ? val : null)) == null)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					throw new NotSupportedException((string)aKKQkChkr8RWXNo8cDHU(0x20261A4F ^ 0x20255573));
				}
				case 3:
				case 15:
					val7 = val8;
					num2 = 13;
					continue;
				case 21:
				{
					GenericParameter val9;
					if ((val9 = (GenericParameter)(object)((val is GenericParameter) ? val : null)) == null)
					{
						num2 = 18;
						continue;
					}
					goto case 9;
				}
				case 26:
					val = type;
					num2 = 25;
					continue;
				case 6:
					if ((val5 = (ByReferenceType)(object)((val is ByReferenceType) ? val : null)) != null)
					{
						num2 = 27;
						continue;
					}
					goto case 10;
				default:
					if ((val6 = (PointerType)(object)((val is PointerType) ? val : null)) != null)
					{
						num2 = 19;
						continue;
					}
					goto case 6;
				case 5:
					if ((val8 = (ArrayType)(object)((val is ArrayType) ? val : null)) != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto default;
				case 8:
					if ((val3 = (GenericInstanceType)(object)((val is GenericInstanceType) ? val : null)) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 21;
				case 10:
				{
					PinnedType val11;
					if ((val11 = (PinnedType)(object)((val is PinnedType) ? val : null)) == null)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num2 = 24;
						}
						continue;
					}
					throw new NotSupportedException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105281230));
				}
				case 25:
					if (val != null)
					{
						num2 = 5;
						continue;
					}
					goto case 18;
				case 12:
				{
					RequiredModifierType val10;
					if ((val10 = (RequiredModifierType)(object)((val is RequiredModifierType) ? val : null)) != null)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 8;
				}
				case 22:
					if (!QwsILFhnkkeNjevxqvGL(type2, null))
					{
						num2 = 23;
						continue;
					}
					goto case 17;
				case 13:
					return iRZ96shnRtiPlIIchpNs(h9y15jhnifgRJAE2wDrn(val7)).MakeArrayType(LCb6BqhnqEgZoVpNs8AQ(val7));
				case 19:
					return iRZ96shnRtiPlIIchpNs(((TypeSpecification)val6).get_ElementType()).MakePointerType();
				case 27:
					return iRZ96shnRtiPlIIchpNs(((TypeSpecification)val5).get_ElementType()).MakeByRefType();
				case 20:
					throw new NotSupportedException((string)aKKQkChkr8RWXNo8cDHU(-2138958856 ^ -2139005700));
				case 11:
					throw new NotSupportedException((string)aKKQkChkr8RWXNo8cDHU(0x35C0467B ^ 0x35C309FF));
				case 2:
					val4 = val3;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 4;
					}
					continue;
				case 14:
				{
					Type type3 = iRZ96shnRtiPlIIchpNs(LdH5vfhnO6EQ5e4ytaxo(type));
					if ((object)type3 == null)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num2 = 28;
						}
						continue;
					}
					obj = type3.GetNestedType((string)kLX18Ahn2UGIsgI90Krv(type), BindingFlags.Public | BindingFlags.NonPublic);
					break;
				}
				case 24:
				{
					SentinelType val2;
					if ((val2 = (SentinelType)(object)((val is SentinelType) ? val : null)) != null)
					{
						goto end_IL_0012;
					}
					goto case 16;
				}
				case 1:
				case 7:
				case 23:
					return type2;
				case 17:
					if (!OYTKwyhnnm0mC72xGd1p(type))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 14;
				case 28:
					obj = null;
					break;
				}
				type2 = (Type)obj;
				num2 = 7;
				continue;
				end_IL_0012:
				break;
			}
			num = 20;
		}
	}

	internal static MethodReference CreateReference(MethodReference method, TypeReference declaringType = null, ModuleDefinition module = null)
	{
		//Discarded unreachable code: IL_0148, IL_02fa, IL_03ad, IL_0455, IL_048d, IL_049c
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_02eb: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = default(_003C_003Ec__DisplayClass18_0);
		CloneScope cloneScope = default(CloneScope);
		MethodReference result = default(MethodReference);
		_003C_003Ec__DisplayClass18_1 CS_0024_003C_003E8__locals0;
		GenericInstanceMethod val2 = default(GenericInstanceMethod);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass18_.declaringType = declaringType;
				num2 = 3;
				continue;
			case 3:
				cloneScope = new CloneScope(module);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				_003C_003Ec__DisplayClass18_.method = method;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
				return result;
			case 5:
				_003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
				num2 = 4;
				continue;
			}
			try
			{
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_1();
				int num3 = 3;
				while (true)
				{
					object obj;
					int num4;
					switch (num3)
					{
					case 4:
						return result;
					case 15:
						return result;
					case 13:
						if (WLvp2mhnaT0cacECS6yp(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.method))
						{
							num3 = 12;
							break;
						}
						goto case 1;
					case 6:
						if (!tShT2uhntpun8GmBD0O0(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.method))
						{
							num3 = 16;
							break;
						}
						goto case 5;
					case 8:
						obj = null;
						goto IL_0407;
					case 2:
						result = (MethodReference)(object)val2;
						num3 = 15;
						break;
					case 5:
						((IEnumerable<ParameterDefinition>)CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.method.get_Parameters()).Select((Func<ParameterDefinition, ParameterDefinition>)((ParameterDefinition p) => new ParameterDefinition(CreateReference(_003C_003Ec__DisplayClass18_1.EWSHqRvCF0K9seHk6C2r(p), GenericParameterResolver)))).ForEach((Action<ParameterDefinition>)CS_0024_003C_003E8__locals0.reference.get_Parameters().Add);
						num3 = 11;
						break;
					case 12:
						((IEnumerable<GenericParameter>)CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.method.get_GenericParameters()).Select((Func<GenericParameter, GenericParameter>)((GenericParameter p) => new GenericParameter(((MemberReference)p).get_Name(), (IGenericParameterProvider)(object)CS_0024_003C_003E8__locals0.reference))).ForEach((Action<GenericParameter>)CS_0024_003C_003E8__locals0.reference.get_GenericParameters().Add);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num3 = 0;
						}
						break;
					case 1:
						XB2NxnhnD5OO0PA9xyxd(CS_0024_003C_003E8__locals0.reference, CreateReference(LxKIANhn1G8BE9oV6iei(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.method), GenericParameterResolver));
						num3 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num3 = 6;
						}
						break;
					default:
						if (ou9hK2hnecrPsmYkXx7w(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.method))
						{
							num4 = 10;
							goto IL_00b0;
						}
						goto case 9;
					case 7:
					{
						MethodReference val3 = new MethodReference((string)kLX18Ahn2UGIsgI90Krv(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.method), (TypeReference)LxKIANhn1G8BE9oV6iei(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.method), CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.declaringType);
						amL2IUhnfxBSmBR7EZex((object)val3, WiUJAjhnNUNPeIv6Nd2q(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.method));
						eIckYihnQpwNiGKo9sYN((object)val3, JiZx8xhn3aVY27d17ln3(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.method));
						jiuNWjhnCUtNoMAmBlRC((object)val3, jJu9iOhnpLhulQdTiq30(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.method));
						CS_0024_003C_003E8__locals0.reference = val3;
						num3 = 13;
						break;
					}
					case 10:
					{
						GenericInstanceMethod val = (GenericInstanceMethod)CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.method;
						val2 = new GenericInstanceMethod(CreateReference(((MethodSpecification)val).get_ElementMethod()));
						((IEnumerable<TypeReference>)val.get_GenericArguments()).Select(CreateReference).ForEach((Action<TypeReference>)val2.get_GenericArguments().Add);
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num3 = 1;
						}
						break;
					}
					case 11:
					case 16:
						if (module == null)
						{
							num3 = 8;
							break;
						}
						obj = module.Import(CS_0024_003C_003E8__locals0.reference);
						goto IL_0407;
					case 3:
						CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass18_;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num3 = 0;
						}
						break;
					case 9:
						CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.declaringType = (TypeReference)(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.declaringType ?? dEerjphnPjn7FcxFYbXZ(LdH5vfhnO6EQ5e4ytaxo(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.method)));
						num4 = 7;
						goto IL_00b0;
					case 14:
						{
							obj = CS_0024_003C_003E8__locals0.reference;
							goto IL_041f;
						}
						IL_041f:
						result = (MethodReference)obj;
						num4 = 4;
						goto IL_00b0;
						IL_00b0:
						num3 = num4;
						break;
						IL_0407:
						if (obj == null)
						{
							num3 = 14;
							break;
						}
						goto IL_041f;
					}
				}
				GenericParameter GenericParameterResolver(GenericParameter genericParameter)
				{
					//Discarded unreachable code: IL_0035, IL_00b3
					int num6 = 2;
					int num7 = num6;
					object obj2;
					GenericInstanceType val4 = default(GenericInstanceType);
					while (true)
					{
						switch (num7)
						{
						case 2:
							if (genericParameter.get_DeclaringMethod() != CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.method)
							{
								num7 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
								{
									num7 = 0;
								}
								continue;
							}
							return CS_0024_003C_003E8__locals0.reference.get_GenericParameters().get_Item(_003C_003Ec__DisplayClass18_1.ODU47DvCo3xWINsKNgbF(genericParameter));
						case 3:
							return null;
						case 4:
							obj2 = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.declaringType;
							break;
						case 1:
						{
							object obj3 = _003C_003Ec__DisplayClass18_1.xomFH0vCB8cYJ6mlQCW5(genericParameter);
							TypeReference declaringType2 = ((MemberReference)CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.method).get_DeclaringType();
							GenericInstanceType val5;
							if (obj3 != (((val5 = (GenericInstanceType)(object)((declaringType2 is GenericInstanceType) ? declaringType2 : null)) != null) ? _003C_003Ec__DisplayClass18_1.sgg2lPvCWUjD7bFekQp9(val5) : _003C_003Ec__DisplayClass18_1.xomFH0vCB8cYJ6mlQCW5(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.method)))
							{
								num7 = 3;
								continue;
							}
							TypeReference declaringType3 = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.declaringType;
							if ((val4 = (GenericInstanceType)(object)((declaringType3 is GenericInstanceType) ? declaringType3 : null)) != null)
							{
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
								{
									num7 = 0;
								}
								continue;
							}
							goto case 4;
						}
						default:
							obj2 = _003C_003Ec__DisplayClass18_1.sgg2lPvCWUjD7bFekQp9(val4);
							break;
						}
						break;
					}
					return ((TypeReference)obj2).get_GenericParameters().get_Item(_003C_003Ec__DisplayClass18_1.ODU47DvCo3xWINsKNgbF(genericParameter));
				}
			}
			finally
			{
				if (cloneScope != null)
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num5 = 1;
					}
					while (true)
					{
						switch (num5)
						{
						case 1:
							((IDisposable)cloneScope).Dispose();
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
							{
								num5 = 0;
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

	private static string AssemblyName(object typeReference)
	{
		//Discarded unreachable code: IL_008f, IL_009e
		int num = 2;
		AssemblyNameReference val2 = default(AssemblyNameReference);
		ModuleDefinition val3 = default(ModuleDefinition);
		IMetadataScope val = default(IMetadataScope);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return (string)MWThlghn49KGlBcfmwJx(val2);
				case 4:
					return (string)MWThlghn49KGlBcfmwJx(SKuovGhk6fuKJCWWtcMA(val3.get_Assembly()));
				case 5:
					if ((val2 = (AssemblyNameReference)(object)((val is AssemblyNameReference) ? val : null)) == null)
					{
						num2 = 3;
						break;
					}
					goto default;
				case 3:
					if ((val3 = (ModuleDefinition)(object)((val is ModuleDefinition) ? val : null)) != null)
					{
						goto end_IL_0012;
					}
					goto IL_004e;
				case 2:
					val = (IMetadataScope)bycSo2hnwnQC3Ubt5XTN(typeReference);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					{
						if (val != null)
						{
							num2 = 5;
							break;
						}
						goto IL_004e;
					}
					IL_004e:
					throw new NotImplementedException();
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	private byte[] RewriteCSScripts(byte[] data, ISet<string> csScripts)
	{
		_003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass23_0();
		CS_0024_003C_003E8__locals0.csScripts = csScripts;
		if (CS_0024_003C_003E8__locals0.csScripts.Count == 0)
		{
			return data;
		}
		SyntaxTree val = SyntaxFactory.ParseSyntaxTree(SourceText.From(data, data.Length, (Encoding)null, (SourceHashAlgorithm)1, false, false), (ParseOptions)null, "", (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken));
		CompilationUnitSyntax compilationUnitRoot = CSharpExtensions.GetCompilationUnitRoot(val, default(CancellationToken));
		ClassDeclarationSyntax[] array = ((SyntaxNode)compilationUnitRoot).DescendantNodes((Func<SyntaxNode, bool>)null, false).OfType<ClassDeclarationSyntax>().Where(delegate(ClassDeclarationSyntax c)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			int num = 1;
			int num2 = num;
			SyntaxToken val3 = default(SyntaxToken);
			while (true)
			{
				switch (num2)
				{
				case 1:
					val3 = _003C_003Ec.SYcKRuvQnjT1AboPDiEd(c);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return ((SyntaxToken)(ref val3)).get_ValueText() == (string)_003C_003Ec.Tgs9RuvQq5pEfWSAs3bn(0x1A33FE36 ^ 0x1A30BC0C);
				}
			}
		})
			.ToArray();
		if (array.Length == 0)
		{
			PublishLogger.WarnFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87548997), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A30BC0C), Environment.NewLine, Encoding.UTF8.GetString(data));
			return data;
		}
		PropertyDeclarationSyntax[] array2 = array.SelectMany((ClassDeclarationSyntax c) => (IEnumerable<MemberDeclarationSyntax>)(object)((TypeDeclarationSyntax)c).get_Members()).OfType<PropertyDeclarationSyntax>().Where(delegate(PropertyDeclarationSyntax p)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			ISet<string> set = CS_0024_003C_003E8__locals0.csScripts;
			SyntaxToken val2 = _003C_003Ec__DisplayClass23_0.HJHP7xvCEsvnqX0SST5i(p);
			return set.Contains(((SyntaxToken)(ref val2)).get_ValueText());
		})
			.ToArray();
		if (array2.Length == 0)
		{
			return data;
		}
		CS_0024_003C_003E8__locals0.identifierRewriter = new IdentifierRewriter(this);
		val = ((SyntaxNode)SyntaxNodeExtensions.ReplaceNodes<CompilationUnitSyntax, PropertyDeclarationSyntax>(compilationUnitRoot, (IEnumerable<PropertyDeclarationSyntax>)array2, (Func<PropertyDeclarationSyntax, PropertyDeclarationSyntax, SyntaxNode>)((PropertyDeclarationSyntax o, PropertyDeclarationSyntax r) => ((CSharpSyntaxVisitor<SyntaxNode>)(object)CS_0024_003C_003E8__locals0.identifierRewriter).Visit((SyntaxNode)(object)o)))).get_SyntaxTree();
		using MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
		using (StreamWriter streamWriter = new StreamWriter(memoryStream.AsNoClose()))
		{
			val.GetText(default(CancellationToken)).Write((TextWriter)streamWriter, default(CancellationToken));
		}
		return memoryStream.ToArray();
	}

	static EntityDynamicGenerator()
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					JNuy0Nhn6Or8X7R3ZkVZ();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 3;
					}
					continue;
				case 8:
					break;
				case 7:
					configurationModelProperties = PublishCacheContext.CreateCache((IDictionary<string, IDictionary<string, TypeReference>> _) => new Dictionary<string, IDictionary<string, TypeReference>>(), null, delegate(IDictionary<string, IDictionary<string, TypeReference>> _)
					{
						_.Clear();
					}, delegate(IDictionary<string, IDictionary<string, TypeReference>> _)
					{
						_.Clear();
					});
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 2;
					}
					continue;
				default:
					ReplaceMethods = PublishCacheContext.CreateCache<string, MethodReference>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					CreatorType = ahs6yrhnAd4G7pxVVsxB(typeof(Creator<>).TypeHandle);
					num2 = 6;
					continue;
				case 1:
					ReplaceTypes = PublishCacheContext.CreateCache<string, TypeReference>();
					num2 = 5;
					continue;
				case 9:
					return;
				case 3:
					AccessorClassNamePostfixLength = BY9XIHhnHqi0quIsV0Ks(aKKQkChkr8RWXNo8cDHU(0x1637C429 ^ 0x16349435));
					num2 = 7;
					continue;
				case 6:
					PublishLogger = (ILogger)M0S5U0hn75XaSWyQJutH(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571DBC59));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					ReplaceMethods[(string)X4WaZKhnxGUP3rTQy1sm() + (string)aKKQkChkr8RWXNo8cDHU(0x49E27B8A ^ 0x49E232A8) + (string)oqmjfShn0JZU8r1EAQPq() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A685DB)] = (MethodReference)bpUg2NhnmAsdhiRYT1c4(ahs6yrhnAd4G7pxVVsxB(typeof(EntityDynamicExtensions).TypeHandle).GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F3328E0)));
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 8;
					}
					continue;
				}
				break;
			}
			ReplaceMethods[(string)Pw7fsqhny3B22cJQgTQk(System.Reflection.TypeOf.Void) + (string)aKKQkChkr8RWXNo8cDHU(-561074844 ^ -561060794) + TypeOf<IInheritable>.FullName + (string)aKKQkChkr8RWXNo8cDHU(-629844702 ^ -629799604) + (string)X4WaZKhnxGUP3rTQy1sm() + (string)aKKQkChkr8RWXNo8cDHU(-951514650 ^ -951511462)] = EntityDynamicGenerator.CreateReference((object)ahs6yrhnAd4G7pxVVsxB(typeof(EntityDynamicExtensions).TypeHandle).GetMethod((string)aKKQkChkr8RWXNo8cDHU(0x269E5FCA ^ 0x269D0F44)));
			num = 9;
		}
	}

	private static void AddReplace(object typeName, object type)
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
				ReplaceTypes[(string)typeName] = (TypeReference)type;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private static void AddReplace(object methodName, object method)
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
				ReplaceMethods[(string)methodName] = (MethodReference)method;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private static bool ContainsReplace(object method)
	{
		return ReplaceMethods.ContainsKey((string)keXJsnhnMwyfCU8Tu0Zh(method));
	}

	private static bool ContainsReplace(object type)
	{
		return ReplaceTypes.ContainsKey((string)Ofp4m0hnKhKS8lVhbBkZ(type));
	}

	private static bool TryGetReplace(object fromMethod, out MethodReference toMethod)
	{
		return ReplaceMethods.TryGetValue((string)(keXJsnhnMwyfCU8Tu0Zh(fromMethod) ?? string.Empty), out toMethod);
	}

	private static bool TryGetReplace(object fromType, out TypeReference toType)
	{
		return ReplaceTypes.TryGetValue((string)(((fromType != null) ? Ofp4m0hnKhKS8lVhbBkZ(fromType) : null) ?? string.Empty), out toType);
	}

	private static string TypeName(object type)
	{
		//Discarded unreachable code: IL_011f, IL_012e, IL_013e
		int num = 4;
		int num2 = num;
		GenericParameter val = default(GenericParameter);
		GenericInstanceType val2 = default(GenericInstanceType);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return (string)e9MT9YhnJ1cJVENhQULv(aKKQkChkr8RWXNo8cDHU(0x18A6761F ^ 0x18A526B9), val.get_Position());
			case 3:
				if ((val2 = (GenericInstanceType)((type is GenericInstanceType) ? type : null)) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 4:
				if ((val = (GenericParameter)((type is GenericParameter) ? type : null)) == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 1:
				return (string)s0N42whndrdPVcyTJ75J(F5e4CIhn9pERVVBPIW10(((TypeSpecification)val2).get_ElementType()), aKKQkChkr8RWXNo8cDHU(0x3B36AB09 ^ 0x3B36E4CF), string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76D867E), ((IEnumerable<TypeReference>)val2.get_GenericArguments()).Select(TypeName)), aKKQkChkr8RWXNo8cDHU(0x92F12D5 ^ 0x92F5D15));
			default:
				return ((MemberReference)type).get_FullName();
			}
		}
	}

	private static string MethodName(object method)
	{
		//Discarded unreachable code: IL_0085
		int num = 3;
		GenericInstanceType val2 = default(GenericInstanceType);
		TypeReference val = default(TypeReference);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if ((val2 = (GenericInstanceType)(object)((val is GenericInstanceType) ? val : null)) != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 1:
					val = ((TypeSpecification)val2).get_ElementType();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					return null;
				case 2:
					goto end_IL_0012;
				case 3:
					if (method != null)
					{
						num2 = 2;
						continue;
					}
					goto case 4;
				}
				return (string)x1sAH6hnlV7amNoNuvfv(new string[8]
				{
					(string)F5e4CIhn9pERVVBPIW10(LxKIANhn1G8BE9oV6iei(method)),
					(string)aKKQkChkr8RWXNo8cDHU(-643786247 ^ -643772197),
					(string)F5e4CIhn9pERVVBPIW10(val),
					(string)aKKQkChkr8RWXNo8cDHU(0x63ABA4E8 ^ 0x63AA448E),
					(string)kLX18Ahn2UGIsgI90Krv(method),
					(string)aKKQkChkr8RWXNo8cDHU(-541731959 ^ -541733825),
					string.Join((string)aKKQkChkr8RWXNo8cDHU(-1921202237 ^ -1921215181), ((IEnumerable<ParameterDefinition>)((MethodReference)method).get_Parameters()).Select((ParameterDefinition p) => (string)_003C_003Ec.jkmkVfvQ2XGH0L15HmsU(_003C_003Ec.kp6J73vQOGLXhU97Rgq2(p)))),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538523734)
				});
				continue;
				end_IL_0012:
				break;
			}
			val = ((MemberReference)method).get_DeclaringType();
			num = 5;
		}
	}

	public static MemoryStream CheckAssembly(MemoryStream assemblyRaw)
	{
		//Discarded unreachable code: IL_01c0, IL_01cf, IL_0287, IL_0296, IL_02a6, IL_02b5, IL_0306, IL_0310, IL_035b, IL_0439, IL_0458, IL_0484, IL_0493
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		int num = 20;
		List<AssemblyNameReference> list = default(List<AssemblyNameReference>);
		IEnumerator<TypeReference> enumerator = default(IEnumerator<TypeReference>);
		ModuleDefinition val = default(ModuleDefinition);
		AssemblyDefinition val3 = default(AssemblyDefinition);
		MemoryStream memoryStream = default(MemoryStream);
		TypeReference current = default(TypeReference);
		TypeReference val2 = default(TypeReference);
		TypeReference toType = default(TypeReference);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (gqTmBLhnjx8eFrfardME(list) != 0)
					{
						num = 17;
						break;
					}
					goto case 13;
				case 3:
					enumerator = val.GetTypeReferences().GetEnumerator();
					num2 = 10;
					continue;
				case 15:
					val3.Write((Stream)memoryStream);
					num2 = 12;
					continue;
				case 12:
					MU2aP8hkdxC4Yk7IqUQh(memoryStream, 0L, SeekOrigin.Begin);
					num2 = 9;
					continue;
				case 2:
				case 14:
				case 18:
					return assemblyRaw;
				case 1:
					if (!((string)o8xwr1hn8QFrgSQawYTL(SKuovGhk6fuKJCWWtcMA(val3)) == (string)aKKQkChkr8RWXNo8cDHU(0x34A6D230 ^ 0x34A6DBDC)))
					{
						val = (ModuleDefinition)NNxEjmhkyEwD9BWgkfBY(val3);
						num2 = 21;
					}
					else
					{
						num2 = 14;
					}
					continue;
				case 8:
				{
					ReaderParameters val4 = new ReaderParameters();
					val4.set_AssemblyResolver((IAssemblyResolver)(object)new AssemblyResolver());
					val3 = (AssemblyDefinition)eonSTThk4E7EQOr98lKN(assemblyRaw, (object)val4);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				case 5:
					if (!val.GetMemberReferences().OfType<MethodReference>().Any(ContainsReplace))
					{
						num2 = 13;
						continue;
					}
					goto default;
				case 19:
					return assemblyRaw;
				case 20:
					if (!pdc1nxhng8NbBTLjYhcF(kImPPthnrGgq6aBjF2vT(), null))
					{
						assemblyRaw.Seek(0L, SeekOrigin.Begin);
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
						{
							num2 = 5;
						}
					}
					else
					{
						num2 = 19;
					}
					continue;
				case 7:
					memoryStream = (MemoryStream)j3moPjhkJfBAnjtd3BiK();
					num2 = 15;
					continue;
				case 4:
					if (uY8Yg2hn5di72k4aOt8I(((AssemblyNameReference)val3.get_Name()).get_Name(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852835744)))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 16;
				case 22:
					UpdateModule(val, new Dictionary<TypeReference, TypeReference>(), new Dictionary<MethodReference, MethodReference>());
					num2 = 3;
					continue;
				case 9:
					return memoryStream;
				case 17:
					if (val.GetTypeReferences().Any(EntityDynamicGenerator.ContainsReplace))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 16:
					if (uY8Yg2hn5di72k4aOt8I(o8xwr1hn8QFrgSQawYTL(SKuovGhk6fuKJCWWtcMA(val3)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138957354)))
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 11;
				case 10:
					try
					{
						while (true)
						{
							IL_03b2:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
								{
									num3 = 0;
								}
								goto IL_0314;
							}
							goto IL_03f0;
							IL_03f0:
							current = enumerator.Current;
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
							{
								num3 = 3;
							}
							goto IL_0314;
							IL_0314:
							while (true)
							{
								switch (num3)
								{
								case 1:
									m6Xci2hnL17pVeQHSnXI(current, LdH5vfhnO6EQ5e4ytaxo(val2));
									num3 = 3;
									continue;
								case 3:
									OkwYh8hnUSTaE31L5XcY(current, bycSo2hnwnQC3Ubt5XTN(val2));
									num3 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
									{
										num3 = 5;
									}
									continue;
								case 2:
									val2 = (TypeReference)rlLnDohnYQkcwMWBUxCL(val, toType);
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
									{
										num3 = 1;
									}
									continue;
								case 5:
								case 7:
									goto IL_03b2;
								case 4:
									if (!TryGetReplace((object)current, out toType))
									{
										num3 = 7;
										continue;
									}
									goto case 2;
								case 6:
									goto IL_03f0;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator == null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
							{
								num4 = 0;
							}
							goto IL_043d;
						}
						goto IL_0462;
						IL_0462:
						enumerator.Dispose();
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num4 = 1;
						}
						goto IL_043d;
						IL_043d:
						switch (num4)
						{
						default:
							goto end_IL_0418;
						case 0:
							goto end_IL_0418;
						case 2:
							break;
						case 1:
							goto end_IL_0418;
						}
						goto IL_0462;
						end_IL_0418:;
					}
					goto case 7;
				case 11:
					if (!uY8Yg2hn5di72k4aOt8I(o8xwr1hn8QFrgSQawYTL(SKuovGhk6fuKJCWWtcMA(val3)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138957210)))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 21:
					list = ((IEnumerable<AssemblyNameReference>)val.get_AssemblyReferences()).Where(delegate(AssemblyNameReference r)
					{
						//Discarded unreachable code: IL_009f, IL_00c1, IL_00d0
						int num7 = 1;
						int num8 = num7;
						while (true)
						{
							switch (num8)
							{
							case 1:
								if (_003C_003Ec.EMBgDDvQeVcYY7NiXHt7(r.get_Name(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561076480)))
								{
									num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
									{
										num8 = 0;
									}
									break;
								}
								goto case 2;
							case 2:
								if (!_003C_003Ec.EMBgDDvQeVcYY7NiXHt7(r.get_Name(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A613F90)))
								{
									num8 = 3;
									break;
								}
								goto default;
							default:
								return _003C_003Ec.kPGlrhvQPVSASU4lsTsH(r.get_Version(), ConfigurationModelAssemblyBuilder.Version);
							case 3:
								return false;
							}
						}
					}).ToList();
					num2 = 6;
					continue;
				case 13:
					return assemblyRaw;
				default:
					list.ForEach(delegate(AssemblyNameReference r)
					{
						int num5 = 1;
						int num6 = num5;
						while (true)
						{
							switch (num6)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								_003C_003Ec.ajyZ1TvQNE8xOH2LDWqa(r, _003C_003Ec.qWOA2yvQ1xdiasybCKqy());
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
								{
									num6 = 0;
								}
								break;
							}
						}
					});
					num = 22;
					break;
				}
				break;
			}
		}
	}

	private static void UpdateModule(object module, IDictionary<TypeReference, TypeReference> typesToReplace, IDictionary<MethodReference, MethodReference> methodsToReplace, IDictionary<FieldReference, FieldReference> fieldsToReplace = null, Func<TypeDefinition, bool> typesFilter = null)
	{
		_003C_003Ec__DisplayClass38_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass38_0();
		CS_0024_003C_003E8__locals0.typesFilter = typesFilter;
		CS_0024_003C_003E8__locals0.typesToReplace = typesToReplace;
		CS_0024_003C_003E8__locals0.module = (ModuleDefinition)module;
		CS_0024_003C_003E8__locals0.methodsToReplace = methodsToReplace;
		CS_0024_003C_003E8__locals0.fieldsToReplace = fieldsToReplace;
		((IEnumerable<TypeDefinition>)CS_0024_003C_003E8__locals0.module.get_Types()).Where((TypeDefinition t) => _003C_003Ec.uaeVYSvQp7yp7t2hFTCj(_003C_003Ec.Q46l0QvQ3xOse1EsHGsW(t), "<Module>")).SelectRecursive((TypeDefinition t) => (IEnumerable<TypeDefinition>)t.get_NestedTypes()).If(CS_0024_003C_003E8__locals0.typesFilter != null, (IEnumerable<TypeDefinition> _) => _.Where(CS_0024_003C_003E8__locals0.typesFilter))
			.ForEach(delegate(TypeDefinition tr)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						return;
					case 1:
						((IEnumerable<CustomAttribute>)tr.get_CustomAttributes()).Concat(((IEnumerable<PropertyDefinition>)tr.get_Properties()).SelectMany((PropertyDefinition p) => (IEnumerable<CustomAttribute>)p.get_CustomAttributes())).Concat(((IEnumerable<MethodDefinition>)tr.get_Methods()).SelectMany((MethodDefinition p) => (IEnumerable<CustomAttribute>)p.get_CustomAttributes())).ForEach(delegate(CustomAttribute attr)
						{
							//Discarded unreachable code: IL_0076, IL_0085, IL_0095
							//IL_00af: Unknown result type (might be due to invalid IL or missing references)
							//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
							//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
							//IL_00df: Unknown result type (might be due to invalid IL or missing references)
							//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
							int num3 = 7;
							int num5 = default(int);
							CustomAttributeArgument val = default(CustomAttributeArgument);
							TypeReference replaceTo = default(TypeReference);
							TypeReference typeReference = default(TypeReference);
							while (true)
							{
								int num4 = num3;
								while (true)
								{
									switch (num4)
									{
									case 6:
									case 8:
										if (num5 < _003C_003Ec__DisplayClass38_0.cgjIa5vC8OUsnHHvQJqn(attr.get_ConstructorArguments()))
										{
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
											{
												num4 = 0;
											}
											continue;
										}
										return;
									case 3:
										return;
									case 1:
									{
										Collection<CustomAttributeArgument> constructorArguments = attr.get_ConstructorArguments();
										int num6 = num5;
										val = attr.get_ConstructorArguments().get_Item(num5);
										constructorArguments.set_Item(num6, new CustomAttributeArgument(((CustomAttributeArgument)(ref val)).get_Type(), (object)replaceTo));
										num3 = 5;
										break;
									}
									default:
										val = attr.get_ConstructorArguments().get_Item(num5);
										num4 = 4;
										continue;
									case 5:
										num5++;
										num4 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
										{
											num4 = 8;
										}
										continue;
									case 7:
										num5 = 0;
										num4 = 6;
										continue;
									case 9:
										if (CheckType(CS_0024_003C_003E8__locals0.typesToReplace, typeReference, out replaceTo))
										{
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
											{
												num4 = 1;
											}
											continue;
										}
										goto case 5;
									case 4:
									{
										object value = ((CustomAttributeArgument)(ref val)).get_Value();
										if ((typeReference = (TypeReference)((value is TypeReference) ? value : null)) != null)
										{
											num3 = 9;
											break;
										}
										goto case 5;
									}
									}
									break;
								}
							}
						});
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 0;
						}
						break;
					default:
						((IEnumerable<MethodDefinition>)tr.get_Methods()).Where((MethodDefinition m) => _003C_003Ec.kudnTAvQaG2rWBEp0VcS(m)).SelectMany((MethodDefinition m) => (IEnumerable<Instruction>)m.get_Body().get_Instructions()).ForEach(delegate(Instruction i)
						{
							//Discarded unreachable code: IL_0166, IL_02b7, IL_0362, IL_03b1, IL_0453, IL_0475, IL_0484, IL_05d0, IL_05df, IL_0604, IL_0613, IL_066c, IL_06b3, IL_06c2, IL_06d1, IL_070a, IL_07de, IL_07ed, IL_0800, IL_0834, IL_0843, IL_086d, IL_087c, IL_0920
							//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
							//IL_0236: Unknown result type (might be due to invalid IL or missing references)
							//IL_0240: Expected O, but got Unknown
							//IL_02df: Unknown result type (might be due to invalid IL or missing references)
							//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
							//IL_031b: Unknown result type (might be due to invalid IL or missing references)
							//IL_0419: Unknown result type (might be due to invalid IL or missing references)
							//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
							//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
							int num7 = 16;
							bool flag = default(bool);
							FieldReference key = default(FieldReference);
							FieldReference val9 = default(FieldReference);
							TypeReference typeReference2 = default(TypeReference);
							TypeReference val3 = default(TypeReference);
							MethodReference val2 = default(MethodReference);
							MethodReference val5 = default(MethodReference);
							TypeReference replaceTo2 = default(TypeReference);
							MethodReference value2 = default(MethodReference);
							FieldReference value3 = default(FieldReference);
							_003C_003Ec__DisplayClass38_1 _003C_003Ec__DisplayClass38_ = default(_003C_003Ec__DisplayClass38_1);
							TypeReference replaceTo3 = default(TypeReference);
							GenericInstanceType val8 = default(GenericInstanceType);
							int num9 = default(int);
							GenericInstanceMethod val4 = default(GenericInstanceMethod);
							object operand = default(object);
							while (true)
							{
								int num8 = num7;
								while (true)
								{
									switch (num8)
									{
									case 58:
										flag = true;
										num8 = 31;
										continue;
									case 60:
										return;
									case 51:
										key = val9;
										num7 = 40;
										break;
									case 61:
									case 76:
										typeReference2 = val3;
										num8 = 23;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
										{
											num8 = 4;
										}
										continue;
									case 21:
										if (!((MethodDefinition)val2).get_IsConstructor())
										{
											num8 = 7;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
											{
												num8 = 5;
											}
											continue;
										}
										goto case 11;
									case 77:
										val5 = CreateReference(val2, replaceTo2);
										num8 = 55;
										continue;
									case 27:
										if (CS_0024_003C_003E8__locals0.methodsToReplace.TryGetValue(val2, out value2))
										{
											num7 = 12;
											break;
										}
										if (!TryGetReplace((object)val2, out value2))
										{
											num8 = 48;
											continue;
										}
										goto case 50;
									case 53:
										if (CS_0024_003C_003E8__locals0.fieldsToReplace.TryGetValue(key, out value3))
										{
											num8 = 32;
											continue;
										}
										return;
									case 29:
										_003C_003Ec__DisplayClass38_.declaringType = new GenericInstanceType((TypeReference)_003C_003Ec__DisplayClass38_0.VcOesSvCSL2R2FFcZEPc(CS_0024_003C_003E8__locals0.module, _003C_003Ec__DisplayClass38_0.Re70LuvCVPLZhFZChVdf(value2)));
										num8 = 62;
										continue;
									case 9:
										i.set_Operand((object)replaceTo3);
										num8 = 49;
										continue;
									case 47:
										_003C_003Ec__DisplayClass38_ = new _003C_003Ec__DisplayClass38_1();
										num8 = 10;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
										{
											num8 = 6;
										}
										continue;
									case 32:
										_003C_003Ec__DisplayClass38_0.gccMGpvCuc4oIVkhD2dT(i, value3);
										num8 = 59;
										continue;
									case 62:
										((IEnumerable<TypeReference>)val8.get_GenericArguments()).ForEach(_003C_003Ec__DisplayClass38_._003CUpdateModule_003Eb__10);
										num8 = 54;
										continue;
									case 3:
										return;
									case 43:
										flag = false;
										num8 = 57;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
										{
											num8 = 27;
										}
										continue;
									case 72:
										if (!_003C_003Ec__DisplayClass38_0.LHnrVwvCI1hfAlLHiOfL(_003C_003Ec__DisplayClass38_0.noLHOIvCRwUODb4ljo1a(i), OpCodes.Callvirt))
										{
											num8 = 52;
											continue;
										}
										goto case 37;
									case 4:
										i.set_Operand(_003C_003Ec__DisplayClass38_0.GHuc5KvCirivv2NAW7Ys(CS_0024_003C_003E8__locals0.module, val2));
										num8 = 71;
										continue;
									case 37:
										_003C_003Ec__DisplayClass38_0.Ue4udWvCqRyRdBalWWTX(i, OpCodes.Call);
										num8 = 73;
										continue;
									case 50:
									{
										TypeReference declaringType = ((MemberReference)val2).get_DeclaringType();
										if ((val8 = (GenericInstanceType)(object)((declaringType is GenericInstanceType) ? declaringType : null)) == null)
										{
											num8 = 14;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
											{
												num8 = 6;
											}
											continue;
										}
										goto case 47;
									}
									case 52:
										return;
									case 41:
									case 68:
									{
										MethodReference val7 = (CS_0024_003C_003E8__locals0.methodsToReplace[val2] = (MethodReference)_003C_003Ec__DisplayClass38_0.GHuc5KvCirivv2NAW7Ys(CS_0024_003C_003E8__locals0.module, val5));
										i.set_Operand((object)val7);
										num8 = 75;
										continue;
									}
									case 12:
										if (value2 != null)
										{
											num8 = 67;
											continue;
										}
										return;
									case 13:
									case 33:
										num9 = 0;
										num8 = 13;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
										{
											num8 = 64;
										}
										continue;
									case 35:
									case 74:
									{
										MethodReference val7 = (CS_0024_003C_003E8__locals0.methodsToReplace[val2] = value2);
										_003C_003Ec__DisplayClass38_0.gccMGpvCuc4oIVkhD2dT(i, val7);
										num8 = 72;
										continue;
									}
									case 71:
										CS_0024_003C_003E8__locals0.methodsToReplace[val2] = null;
										num7 = 60;
										break;
									case 38:
										i.set_OpCode(OpCodes.Call);
										num8 = 63;
										continue;
									case 55:
										_003C_003Ec__DisplayClass38_0.SD1jpovCXS6FKJKtpIiw(val5, ((TypeSystem)_003C_003Ec__DisplayClass38_0.TNNJNlvCKLfHCETYhggb(CS_0024_003C_003E8__locals0.module)).get_Void());
										num8 = 70;
										continue;
									case 19:
										return;
									case 49:
										return;
									case 66:
										if (!CheckType(CS_0024_003C_003E8__locals0.typesToReplace, _003C_003Ec__DisplayClass38_0.Re70LuvCVPLZhFZChVdf(_003C_003Ec__DisplayClass38_0.OquyLFvCONUASNKeiCuX(val4)), out replaceTo2))
										{
											num8 = 33;
											continue;
										}
										goto case 28;
									case 22:
										if ((val3 = (TypeReference)((operand is TypeReference) ? operand : null)) != null)
										{
											num8 = 76;
											continue;
										}
										goto case 30;
									case 39:
										if (_003C_003Ec__DisplayClass38_0.LHnrVwvCI1hfAlLHiOfL(i.get_OpCode(), OpCodes.Callvirt))
										{
											num8 = 12;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
											{
												num8 = 38;
											}
											continue;
										}
										return;
									case 45:
										if (_003C_003Ec__DisplayClass38_0.TlxaXHvCZ7qnBNHTAWuo(CS_0024_003C_003E8__locals0.module, i))
										{
											num7 = 42;
											break;
										}
										goto case 27;
									case 28:
										_003C_003Ec__DisplayClass38_0.iDTMOhvC2lF2YIqnF1Ue(_003C_003Ec__DisplayClass38_0.OquyLFvCONUASNKeiCuX(val4), replaceTo2);
										num8 = 8;
										continue;
									case 67:
										_003C_003Ec__DisplayClass38_0.gccMGpvCuc4oIVkhD2dT(i, value2);
										num8 = 39;
										continue;
									case 10:
										_003C_003Ec__DisplayClass38_.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
										num8 = 29;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
										{
											num8 = 22;
										}
										continue;
									case 34:
										if ((val4 = (GenericInstanceMethod)(object)((val2 is GenericInstanceMethod) ? val2 : null)) != null)
										{
											num8 = 66;
											continue;
										}
										goto case 20;
									case 16:
										operand = i.get_Operand();
										num8 = 15;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
										{
											num8 = 10;
										}
										continue;
									case 20:
									case 26:
										if (!CheckType(CS_0024_003C_003E8__locals0.typesToReplace, ((MemberReference)val2).get_DeclaringType(), out replaceTo2))
										{
											num8 = 17;
											continue;
										}
										goto case 36;
									case 40:
										if (CS_0024_003C_003E8__locals0.fieldsToReplace == null)
										{
											num8 = 19;
											continue;
										}
										goto case 53;
									case 54:
										value2 = CreateReference(value2, (TypeReference)(object)_003C_003Ec__DisplayClass38_.declaringType, CS_0024_003C_003E8__locals0.module);
										num8 = 35;
										continue;
									case 30:
									{
										MethodReference val11;
										if ((val11 = (MethodReference)((operand is MethodReference) ? operand : null)) != null)
										{
											val2 = val11;
											num8 = 45;
										}
										else
										{
											num8 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
											{
												num8 = 1;
											}
										}
										continue;
									}
									case 11:
										if (!CheckType(CS_0024_003C_003E8__locals0.typesToReplace, ((MemberReference)val2).get_DeclaringType(), out replaceTo2))
										{
											num8 = 69;
											continue;
										}
										goto case 77;
									case 15:
										if (operand == null)
										{
											num8 = 44;
											continue;
										}
										goto case 22;
									case 1:
									case 42:
										if ((val9 = (FieldReference)((operand is FieldReference) ? operand : null)) != null)
										{
											num8 = 51;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
											{
												num8 = 12;
											}
											continue;
										}
										return;
									case 14:
									case 56:
										value2 = (MethodReference)_003C_003Ec__DisplayClass38_0.GHuc5KvCirivv2NAW7Ys(CS_0024_003C_003E8__locals0.module, value2);
										num8 = 74;
										continue;
									case 44:
										return;
									case 59:
										return;
									case 70:
										if (_003C_003Ec__DisplayClass38_0.jxKq46vCTylVPnT1x1K5(val5))
										{
											num8 = 6;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
											{
												num8 = 68;
											}
											continue;
										}
										goto case 25;
									case 23:
										if (CheckType(CS_0024_003C_003E8__locals0.typesToReplace, typeReference2, out replaceTo3))
										{
											num8 = 9;
											continue;
										}
										goto case 30;
									case 36:
										((MemberReference)val2).set_DeclaringType(replaceTo2);
										num8 = 65;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
										{
											num8 = 16;
										}
										continue;
									case 73:
										return;
									case 48:
										if (!((MemberReference)val2).get_IsDefinition())
										{
											num8 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
											{
												num8 = 1;
											}
											continue;
										}
										goto case 21;
									case 63:
										return;
									case 25:
										((MemberReference)val5).set_Name((string)_003C_003Ec__DisplayClass38_0.iv9ixcvCkExuIcQhVurB(-1978478350 ^ -1978175820));
										num7 = 5;
										break;
									case 24:
										val4.get_GenericArguments().set_Item(num9, replaceTo2);
										num8 = 58;
										continue;
									case 46:
										if (CheckType(CS_0024_003C_003E8__locals0.typesToReplace, val4.get_GenericArguments().get_Item(num9), out replaceTo2))
										{
											num8 = 24;
											continue;
										}
										goto case 31;
									default:
										if (num9 >= _003C_003Ec__DisplayClass38_0.wPSFmFvCe5Fe7iBfJB6e(val4.get_GenericArguments()))
										{
											num8 = 6;
											continue;
										}
										goto case 46;
									case 8:
										flag = true;
										num8 = 13;
										continue;
									case 6:
									case 17:
									case 18:
										if (!flag)
										{
											return;
										}
										num8 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
										{
											num8 = 4;
										}
										continue;
									case 5:
										val5.set_HasThis(true);
										num8 = 41;
										continue;
									case 65:
										flag = true;
										num8 = 18;
										continue;
									case 31:
										num9++;
										num8 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
										{
											num8 = 0;
										}
										continue;
									case 75:
										return;
									case 2:
									case 7:
									case 69:
										if (_003C_003Ec__DisplayClass38_0.DdrY4kvCnbF0EeuCDDlE(val2))
										{
											num8 = 3;
											continue;
										}
										goto case 43;
									case 57:
										if (!val2.get_IsGenericInstance())
										{
											num8 = 7;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
											{
												num8 = 20;
											}
											continue;
										}
										goto case 34;
									}
									break;
								}
							}
						});
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			});
	}

	private static bool CheckType(IDictionary<TypeReference, TypeReference> typesToReplace, object typeReference, out TypeReference replaceTo)
	{
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		if (typeReference == null)
		{
			replaceTo = null;
			return false;
		}
		if (typesToReplace.TryGetValue((TypeReference)typeReference, out replaceTo))
		{
			return replaceTo != null;
		}
		if (TryGetReplace(typeReference, out replaceTo))
		{
			typesToReplace[(TypeReference)typeReference] = (replaceTo = ((MemberReference)typeReference).get_Module().Import(replaceTo));
			return true;
		}
		TypeReference val = (TypeReference)typeReference;
		if (val != null)
		{
			ArrayType val2;
			if ((val2 = (ArrayType)(object)((val is ArrayType) ? val : null)) != null)
			{
				ArrayType val3 = val2;
				if (CheckType(typesToReplace, ((TypeSpecification)val3).get_ElementType(), out replaceTo))
				{
					typesToReplace[(TypeReference)typeReference] = (replaceTo = ((MemberReference)typeReference).get_Module().Import((TypeReference)new ArrayType(replaceTo)));
					return true;
				}
			}
			ByReferenceType val4;
			if ((val4 = (ByReferenceType)(object)((val is ByReferenceType) ? val : null)) != null)
			{
				ByReferenceType val5 = val4;
				if (CheckType(typesToReplace, ((TypeSpecification)val5).get_ElementType(), out replaceTo))
				{
					typesToReplace[(TypeReference)typeReference] = (replaceTo = ((MemberReference)typeReference).get_Module().Import((TypeReference)new ByReferenceType(replaceTo)));
					return true;
				}
			}
			GenericInstanceType val6;
			if ((val6 = (GenericInstanceType)(object)((val is GenericInstanceType) ? val : null)) != null)
			{
				GenericInstanceType val7 = val6;
				bool flag = CheckType(typesToReplace, ((TypeSpecification)val7).get_ElementType(), out replaceTo);
				GenericInstanceType val8 = new GenericInstanceType(flag ? replaceTo : ((TypeSpecification)val7).get_ElementType());
				Enumerator<TypeReference> enumerator = val7.get_GenericArguments().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						TypeReference current = enumerator.get_Current();
						if (CheckType(typesToReplace, current, out replaceTo))
						{
							val8.get_GenericArguments().Add(replaceTo);
							flag = true;
						}
						else
						{
							val8.get_GenericArguments().Add(current);
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
				if (flag)
				{
					typesToReplace[(TypeReference)typeReference] = (replaceTo = ((MemberReference)typeReference).get_Module().Import((TypeReference)(object)val8));
					return true;
				}
			}
		}
		typesToReplace[(TypeReference)typeReference] = (replaceTo = null);
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static GeneratedFileInfo RunAsDynamicGenerating(bool isEntityDynamicGenerating, Func<GeneratedFileInfo> action)
	{
		bool flag = EntityDynamicGenerator.isEntityDynamicGenerating;
		try
		{
			EntityDynamicGenerator.isEntityDynamicGenerating = isEntityDynamicGenerating;
			return action();
		}
		finally
		{
			EntityDynamicGenerator.isEntityDynamicGenerating = flag;
		}
	}

	protected override GeneratedFileInfo GenerateMainFileInternal()
	{
		//Discarded unreachable code: IL_00ce, IL_00dd, IL_0136, IL_01b8, IL_01c7
		GeneratedFileInfo result = default(GeneratedFileInfo);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				csScripts = new HashSet<string>();
				int num = 4;
				GeneratedFileInfo generatedFileInfo = default(GeneratedFileInfo);
				while (true)
				{
					int num2;
					switch (num)
					{
					case 5:
						return result;
					default:
						if (!DynamicPublicationEnable)
						{
							num2 = 2;
							goto IL_003d;
						}
						goto case 1;
					case 4:
						generatedFileInfo = RunAsDynamicGenerating(!D1hI47hns7WsrckyHJp7(metadata), base.GenerateMainFileInternal);
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num = 0;
						}
						break;
					case 2:
					case 3:
						result = generatedFileInfo;
						num2 = 5;
						goto IL_003d;
					case 1:
						{
							O092mGhnzbsidBg7kRwD(generatedFileInfo, RewriteCSScripts((byte[])ExPxlIhnc6shpyR6usW6(generatedFileInfo), csScripts));
							num2 = 3;
							goto IL_003d;
						}
						IL_003d:
						num = num2;
						break;
					}
				}
			}
			finally
			{
				csScripts = null;
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num3 = 2;
				}
				while (true)
				{
					switch (num3)
					{
					case 3:
						dataInterfaceMembers = null;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num3 = 1;
						}
						continue;
					case 2:
						dataCtor = null;
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num3 = 0;
						}
						continue;
					case 1:
						dataClassMembers = null;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num3 = 0;
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

	protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal()
	{
		bool flag = isEntityDynamicGenerating;
		try
		{
			isEntityDynamicGenerating = true;
			return base.GenerateAdditionalFilesInternal().Concat(GenerateConfigExt());
		}
		finally
		{
			isEntityDynamicGenerating = flag;
		}
	}

	private bool IsConfig(Guid uid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				ISet<Guid> configurationModelUids = DynamicModelAssemblyBuilder.ConfigurationModelUids;
				if (configurationModelUids == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return configurationModelUids.Contains(uid);
			}
			default:
				return true;
			}
		}
	}

	private static string GetConfigExtTypeName(object typeName)
	{
		return (string)IJGXnahOF6DHMQcNTTXB(typeName, aKKQkChkr8RWXNo8cDHU(-2112703338 ^ -2112756700));
	}

	private static string GetConfigExtTypeName(object metadata)
	{
		return (string)HmKtEPhOW8h4nS67PRYR(bNUY8fhOBwdhH6GVVKQ4(metadata));
	}

	[IteratorStateMachine(typeof(_003CGenerateConfigExt_003Ed__66))]
	private IEnumerable<GeneratedFileInfo> GenerateConfigExt()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerateConfigExt_003Ed__66(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected override ISyntaxNode GetBasicEntity(ISyntaxNode idTypeRef)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return base.GetBasicEntity(idTypeRef);
			case 1:
				if (DynamicPublicationEnable)
				{
					return w3AXI9hOoeG6fKLAS8BW(EleWise.ELMA.SDK.TypeOf.EntityDynamic1).CreateTypeSyntax(idTypeRef);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override IEnumerable<ISyntaxNode> GetBaseInterfaces()
	{
		return base.GetBaseInterfaces().If(DynamicPublicationEnable && !IsConfig(metadata.ImplementationUid) && !metadata.ImplementedExtensionUids.Any(IsConfig), (IEnumerable<ISyntaxNode> _) => _.Append(EntityDynamicGenerator.GetConfigExtTypeName((object)(EntityMetadata)MetadataServiceContext.Service.GetMetadata(metadata.ImplementationUid)).CreateTypeSyntax()));
	}

	protected override IEnumerable<ISyntaxNode> GetCtors(List<ISyntaxNode> ctorStatements)
	{
		if (!DynamicPublicationEnable)
		{
			return base.GetCtors(ctorStatements);
		}
		dataCtor = SyntaxGeneratorExtensions.ConstructorDeclaration(new ISyntaxNode[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x163494E1).ParameterDeclaration(metadata.TypeName.CreateTypeSyntax()) }, Accessibility.Public, DeclarationModifiers.None, null, ctorStatements.Prepend(SyntaxGeneratorExtensions.This.MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541686975)).AssignmentStatement(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4EA13B).IdentifierName())));
		return Enumerable.Empty<ISyntaxNode>();
	}

	protected virtual IEnumerable<ISyntaxNode> DataMembers(IEnumerable<ISyntaxNode> members, ISyntaxNode type, string getDataMethodName, string resolveCreatorMethodName, bool generateConstructor = false)
	{
		return DataMembers(members, type, getDataMethodName, resolveCreatorMethodName, generateConstructor, metadata, dataInterfaceMembers, dataClassMembers, dataCtor);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static IEnumerable<ISyntaxNode> DataMembers(IEnumerable<ISyntaxNode> members, ISyntaxNode type, string getDataMethodName, string resolveCreatorMethodName, bool generateConstructor, ClassMetadata metadata, IList<ISyntaxNode> dataInterfaceMembers, IList<ISyntaxNode> dataClassMembers, ISyntaxNode dataCtor)
	{
		_003C_003Ec__DisplayClass71_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass71_0();
		CS_0024_003C_003E8__locals0.dataCtor = dataCtor;
		return members.If(generateConstructor, (IEnumerable<ISyntaxNode> _) => _.Prepend(SyntaxGeneratorExtensions.ConstructorDeclaration(Accessibility.Public, DeclarationModifiers.None, null, new ISyntaxNode[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x511652F7).IdentifierName().AssignmentStatement(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A582C8).IdentifierName().MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A77D5C3))
			.InvocationExpression(SyntaxGeneratorExtensions.This)) }))).Prepend(getDataMethodName.MethodDeclaration(null, null, TypeOf<IEnumerable<object>>.Raw.CreateTypeSyntax(), Accessibility.Protected, DeclarationModifiers.Override, new ISyntaxNode[1] { typeof(Enumerable).CreateTypeSyntax().MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477348608)).InvocationExpression(SyntaxGeneratorExtensions.Base.MemberAccessExpression(getDataMethodName).InvocationExpression(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A234E5).IdentifierName())
			.ReturnStatement() })).If(!generateConstructor, (IEnumerable<ISyntaxNode> _) => _.Prepend(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87554753).MethodDeclaration(null, null, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675293377).CreateTypeSyntax(), Accessibility.Internal, DeclarationModifiers.None, new ISyntaxNode[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -575932594).IdentifierName().CoalesceExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDFEAD8).IdentifierName().AssignmentStatement(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939594636).IdentifierName().MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76D96FA))
			.InvocationExpression(SyntaxGeneratorExtensions.This)))
			.ReturnStatement() })))
			.Prepend(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE117925).FieldDeclaration(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289931030).CreateTypeSyntax(), (!generateConstructor) ? Accessibility.Private : Accessibility.Internal, generateConstructor ? DeclarationModifiers.ReadOnly : DeclarationModifiers.None))
			.Prepend(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE22B8D).FieldDeclaration(typeof(ICreator<, >).CreateTypeSyntax(type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398479396).CreateTypeSyntax()), Accessibility.Private, DeclarationModifiers.Static | DeclarationModifiers.ReadOnly, resolveCreatorMethodName.GenericName(type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -671908933).CreateTypeSyntax(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x12475E9E).CreateTypeSyntax()).InvocationExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -575937122).CreateTypeSyntax().MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633497567)))))
			.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978556814).InterfaceDeclaration(Accessibility.Internal, DeclarationModifiers.None, null, dataInterfaceMembers))
			.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978531535).ClassDeclaration(Accessibility.Private, DeclarationModifiers.Sealed, null, new ISyntaxNode[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A66DDE).CreateTypeSyntax() }, dataClassMembers.Prepend(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FF892D).MethodDeclaration(new ISyntaxNode[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921018101).ParameterDeclaration(type) }, null, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475942279).CreateTypeSyntax(), Accessibility.Internal, DeclarationModifiers.Static, new ISyntaxNode[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099571347).CreateTypeSyntax().ObjectCreationExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217576463).IdentifierName())
				.ReturnStatement() })).Prepend(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A69044).MethodDeclaration(null, null, System.Reflection.TypeOf.Func2.Raw.CreateTypeSyntax(type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1DAD98).CreateTypeSyntax()), Accessibility.Public, DeclarationModifiers.Static, new ISyntaxNode[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CB043F).IdentifierName().ReturnStatement() })).If(CS_0024_003C_003E8__locals0.dataCtor != null, (IEnumerable<ISyntaxNode> _) => _.Prepend(CS_0024_003C_003E8__locals0.dataCtor))
				.Prepend(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195790371).FieldDeclaration(type, Accessibility.Private, DeclarationModifiers.ReadOnly))))
			.Concat(GettersSetter(type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870712819).CreateTypeSyntax(), metadata, dataInterfaceMembers));
	}

	[IteratorStateMachine(typeof(_003CGettersSetter_003Ed__72))]
	private static IEnumerable<ISyntaxNode> GettersSetter(object ownerType, object dataClassType, object metadata, IList<ISyntaxNode> dataInterfaceMembers)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGettersSetter_003Ed__72(-2)
		{
			_003C_003E3__ownerType = (ISyntaxNode)ownerType,
			_003C_003E3__dataClassType = (ISyntaxNode)dataClassType,
			_003C_003E3__metadata = (ClassMetadata)metadata,
			_003C_003E3__dataInterfaceMembers = dataInterfaceMembers
		};
	}

	protected override IEnumerable<ISyntaxNode> GetMembers()
	{
		if (!DynamicPublicationEnable)
		{
			return base.GetMembers();
		}
		dataInterfaceMembers = new List<ISyntaxNode>();
		dataClassMembers = new List<ISyntaxNode>();
		return DataMembers(base.GetMembers().ToArray(), metadata.TypeName.CreateTypeSyntax(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571DF28D), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571DF2B1));
	}

	protected override IEnumerable<ISyntaxNode> WriteProperty(PropertyMetadata propertyMetadata, List<ISyntaxNode> ctorStatements, bool writeAttributes = true, Action<ISyntaxNode> propertyAction = null)
	{
		if (!DynamicPublicationEnable)
		{
			return base.WriteProperty(propertyMetadata, ctorStatements, writeAttributes, propertyAction);
		}
		Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A7AA18));
		ITypeGenerationInfo typeGenerationInfo = (ITypeGenerationInfo)GetPropertyTypeDescriptor(propertyMetadata);
		ISyntaxNode propertyTypeReference = typeGenerationInfo.GetPropertyTypeReference(metadata, propertyMetadata, forFilter: false);
		ISyntaxNode expression = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70246552).IdentifierName().InvocationExpression();
		object obj;
		if (!typeGenerationInfo.HasPropertyGetter)
		{
			obj = null;
		}
		else if (!metadata.IsInterfaceType)
		{
			IEnumerable<ISyntaxNode> enumerable = new ISyntaxNode[1] { expression.MemberAccessExpression(propertyMetadata.Name).ReturnStatement() };
			obj = enumerable;
		}
		else
		{
			obj = Enumerable.Empty<ISyntaxNode>();
		}
		IEnumerable<ISyntaxNode> getAccessorStatements = (IEnumerable<ISyntaxNode>)obj;
		object obj2;
		if (!typeGenerationInfo.HasPropertySetter)
		{
			obj2 = null;
		}
		else if (!metadata.IsInterfaceType)
		{
			IEnumerable<ISyntaxNode> enumerable = new ISyntaxNode[1] { expression.MemberAccessExpression(propertyMetadata.Name).AssignmentStatement(SyntaxGeneratorExtensions.Value) };
			obj2 = enumerable;
		}
		else
		{
			obj2 = Enumerable.Empty<ISyntaxNode>();
		}
		IEnumerable<ISyntaxNode> setAccessorStatements = (IEnumerable<ISyntaxNode>)obj2;
		ISyntaxNode syntaxNode = propertyMetadata.Name.PropertyDeclaration(propertyTypeReference, Accessibility.Public, DeclarationModifiers.Virtual, getAccessorStatements, setAccessorStatements);
		if (writeAttributes)
		{
			WritePropertyComments(syntaxNode, propertyMetadata);
			WritePropertyAttributes(syntaxNode, propertyMetadata);
		}
		propertyAction?.Invoke(syntaxNode);
		string text = FieldName(propertyMetadata);
		if (!metadata.IsInterfaceType && propertyMetadata.CalculateType != PropertyCalculateType.CSScript)
		{
			dataClassMembers.Add(text.FieldDeclaration(propertyTypeReference, Accessibility.Private));
		}
		if (typeGenerationInfo.HasPropertyGetter)
		{
			if (propertyMetadata.CalculateType == PropertyCalculateType.CSScript)
			{
				csScripts.Add(propertyMetadata.Name);
				getAccessorStatements = new ISyntaxNode[1] { propertyMetadata.CalculateScript.ParseExpression().ReturnStatement() };
			}
			else
			{
				getAccessorStatements = GetPropertyGetterExpressions(typeGenerationInfo, propertyMetadata, text);
			}
		}
		else
		{
			getAccessorStatements = null;
		}
		setAccessorStatements = ((!typeGenerationInfo.HasPropertySetter) ? null : ((propertyMetadata.CalculateType != PropertyCalculateType.CSScript) ? GetPropertySetterExpressions(typeGenerationInfo, propertyMetadata, text) : Enumerable.Empty<ISyntaxNode>()));
		dataInterfaceMembers.Add(propertyMetadata.Name.PropertyDeclaration(propertyTypeReference, Accessibility.Public, DeclarationModifiers.None, getAccessorStatements, setAccessorStatements));
		ISyntaxNode syntaxNode2 = propertyMetadata.Name.PropertyDeclaration(propertyTypeReference, Accessibility.Public, DeclarationModifiers.None, getAccessorStatements, setAccessorStatements);
		if (writeAttributes)
		{
			WritePropertyAttributes(syntaxNode2, propertyMetadata);
		}
		propertyAction?.Invoke(syntaxNode2);
		if (ctorStatements != null && propertyMetadata.CalculateType != PropertyCalculateType.CSScript)
		{
			ISyntaxNode propertyInitExpression = GetPropertyInitExpression(propertyMetadata, typeGenerationInfo);
			if (propertyInitExpression != null)
			{
				ctorStatements.Add(FieldName(propertyMetadata).IdentifierName().AssignmentStatement(propertyInitExpression));
			}
		}
		dataClassMembers.Add(syntaxNode2);
		return syntaxNode.Concat(typeGenerationInfo.GetAdditionalTypeMembers(metadata, propertyMetadata));
	}

	protected override IEnumerable<ISyntaxNode> GetPropertyGetterExpressions(ITypeGenerationInfo typeDescr, PropertyMetadata propertyMetadata, string fieldName)
	{
		if (csScripts == null || !DynamicPublicationEnable)
		{
			return base.GetPropertyGetterExpressions(typeDescr, propertyMetadata, fieldName);
		}
		IEnumerable<ISyntaxNode> enumerable = typeDescr.GetPropertyGetterExpressions(metadata, propertyMetadata, fieldName);
		if (enumerable == null)
		{
			enumerable = new ISyntaxNode[1] { fieldName.IdentifierName().ReturnStatement() };
		}
		else
		{
			csScripts.Add(propertyMetadata.Name);
		}
		return enumerable;
	}

	protected override IEnumerable<ISyntaxNode> GetPropertySetterExpressions(ITypeGenerationInfo typeDescr, PropertyMetadata propertyMetadata, string fieldName)
	{
		if (csScripts == null || !DynamicPublicationEnable)
		{
			return base.GetPropertySetterExpressions(typeDescr, propertyMetadata, fieldName);
		}
		IEnumerable<ISyntaxNode> enumerable = typeDescr.GetPropertySetterExpressions(metadata, propertyMetadata, fieldName);
		if (enumerable == null)
		{
			enumerable = new ISyntaxNode[1] { fieldName.IdentifierName().AssignmentStatement(SyntaxGeneratorExtensions.Value) };
		}
		else
		{
			csScripts.Add(propertyMetadata.Name);
		}
		return enumerable;
	}

	protected override IEnumerable<ISyntaxNode> GetProperties(List<ISyntaxNode> ctorStatements)
	{
		return base.GetProperties(ctorStatements).If(DynamicPublicationEnable, (IEnumerable<ISyntaxNode> _) => _.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD38514C).PropertyDeclaration(TypeOf<Guid>.Raw.CreateTypeSyntax(), Accessibility.Protected, DeclarationModifiers.Override, new ISyntaxNode[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EF5CEE).InvocationExpression(SyntaxGeneratorExtensions.This, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F3329D2).IdentifierName()).ReturnStatement() })));
	}

	protected override ISyntaxNode GetUidField(ISyntaxNode guidType)
	{
		return ((string)aKKQkChkr8RWXNo8cDHU(0x26FFCB59 ^ 0x26FC9A3D)).FieldDeclaration(guidType, Accessibility.Internal, DeclarationModifiers.Static, guidType.ObjectCreationExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x746CF72).IdentifierName()));
	}

	protected override IEnumerable<ISyntaxNode> WriteTypeUidProperty()
	{
		if (!DynamicPublicationEnable)
		{
			return base.WriteTypeUidProperty();
		}
		ISyntaxNode type = TypeOf<Guid>.Raw.CreateTypeSyntax();
		ISyntaxNode syntaxNode = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8313650).PropertyDeclaration(type, Accessibility.Public, (metadata.BaseClassUid != Guid.Empty) ? DeclarationModifiers.Override : DeclarationModifiers.Virtual, new ISyntaxNode[1] { typeof(EntityDynamicExtensions).CreateTypeSyntax().MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112756544)).InvocationExpression(SyntaxGeneratorExtensions.This)
			.ReturnStatement() }, Enumerable.Empty<ISyntaxNode>());
		syntaxNode.XmlComments(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345367366)).SummaryComment());
		return Enumerable.Repeat(syntaxNode, 1);
	}

	protected override ISyntaxNode ToStringMethod()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return base.ToStringMethod();
			case 1:
				if (DynamicPublicationEnable)
				{
					return null;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override ISyntaxNode GetBasicFilter()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!DynamicPublicationEnable)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return TypeOf<FilterDynamic>.Raw.CreateTypeSyntax();
			default:
				return base.GetBasicFilter();
			}
		}
	}

	protected override string GetInterfaceTypeName()
	{
		//Discarded unreachable code: IL_0086
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!DynamicPublicationEnable)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 3:
				if (!IsConfig(iv1ooQhObXDAs4JZu1uZ(metadata)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (string)YI78jHhOGILFYUydLNfp((ClassMetadata)HYn2ELhOhSSRFofIOX51(this, iv1ooQhObXDAs4JZu1uZ(metadata)));
			default:
				return base.GetInterfaceTypeName();
			}
		}
	}

	protected override ISyntaxNode WriteFilterClassByBaseClass(List<ISyntaxNode> attributes, List<ISyntaxNode> interfaceTypes)
	{
		if (!DynamicPublicationEnable)
		{
			return base.WriteFilterClassByBaseClass(attributes, interfaceTypes);
		}
		ISyntaxNode result = ((metadata.BaseClassUid != Guid.Empty) ? (((ClassMetadata)GetMetadata(metadata.BaseClassUid)).FullTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x724741B6)).CreateTypeSyntax() : GetBasicFilter());
		if (!metadata.Filterable)
		{
			attributes.Add(TypeOf<EditorBrowsableAttribute>.Raw.CreateAttribute(EditorBrowsableState.Never.CreateSyntaxNode()));
		}
		EntityMetadata entityMetadata = (EntityMetadata)GetMetadata(metadata.ImplementationUid);
		if (IsConfig(entityMetadata.Uid) || entityMetadata.Filterable)
		{
			ISyntaxNode syntaxNode = (entityMetadata.FullTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87353525)).CreateTypeSyntax();
			interfaceTypes.Add(syntaxNode);
			if (entityMetadata.Filterable)
			{
				attributes.Add(TypeOf<ImplementAttribute>.Raw.CreateAttribute(syntaxNode.TypeOfExpression()));
			}
		}
		if (metadata.ImplementedExtensionUids != null)
		{
			foreach (Guid implementedExtensionUid in metadata.ImplementedExtensionUids)
			{
				if (GetMetadata(implementedExtensionUid) is EntityMetadata entityMetadata2 && entityMetadata2.Filterable)
				{
					ISyntaxNode syntaxNode2 = (entityMetadata2.FullTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548BEDB6)).CreateTypeSyntax();
					interfaceTypes.Add(syntaxNode2);
					attributes.Add(TypeOf<ImplementAttribute>.Raw.CreateAttribute(syntaxNode2.TypeOfExpression()));
				}
			}
		}
		if (!IsConfig(entityMetadata.Uid))
		{
			EntityMetadata entityMetadata3 = metadata.ImplementedExtensionUids.EmptyIfNull().Where(IsConfig).Select(GetMetadata)
				.Cast<EntityMetadata>()
				.FirstOrDefault();
			if (entityMetadata3 == null || !entityMetadata3.Filterable)
			{
				ISyntaxNode item = (EntityDynamicGenerator.GetConfigExtTypeName((object)entityMetadata.FullTypeName) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571EE0A5)).CreateTypeSyntax();
				interfaceTypes.Add(item);
			}
		}
		return result;
	}

	protected override IEnumerable<ISyntaxNode> GetFilterCtors(List<ISyntaxNode> ctorStatements)
	{
		if (!DynamicPublicationEnable)
		{
			return base.GetFilterCtors(ctorStatements);
		}
		dataCtor = SyntaxGeneratorExtensions.ConstructorDeclaration(new ISyntaxNode[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138238288).ParameterDeclaration(FilterClassName.CreateTypeSyntax()) }, Accessibility.Public, DeclarationModifiers.None, null, ctorStatements.Prepend(SyntaxGeneratorExtensions.This.MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146423829)).AssignmentStatement(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740555492).IdentifierName())));
		return Enumerable.Empty<ISyntaxNode>();
	}

	protected override IEnumerable<ISyntaxNode> WriteFilterMembers()
	{
		if (!DynamicPublicationEnable)
		{
			return base.WriteFilterMembers();
		}
		dataInterfaceMembers = new List<ISyntaxNode>();
		dataClassMembers = new List<ISyntaxNode>();
		return DataMembers(base.WriteFilterMembers().ToArray(), FilterClassName.CreateTypeSyntax(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583560736), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3633A249), generateConstructor: true);
	}

	[IteratorStateMachine(typeof(_003CWriteFilterClassProperty_003Ed__88))]
	protected override IEnumerable<ISyntaxNode> WriteFilterClassProperty(PropertyMetadata filterPropertyMetadata, List<ISyntaxNode> ctorStatements, bool isCustomProperty, ITypeDescriptor filterType)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CWriteFilterClassProperty_003Ed__88(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__filterPropertyMetadata = filterPropertyMetadata,
			_003C_003E3__ctorStatements = ctorStatements,
			_003C_003E3__isCustomProperty = isCustomProperty,
			_003C_003E3__filterType = filterType
		};
	}

	protected override IEnumerable<ISyntaxTrivia> WriteLocalizationResources()
	{
		if (DynamicPublicationEnable && !metadata.IsInterfaceType)
		{
			return Enumerable.Empty<ISyntaxTrivia>();
		}
		return base.WriteLocalizationResources();
	}

	protected override EntityGenerator CreateTablePartGenerator(TablePartMetadata tablePart)
	{
		//Discarded unreachable code: IL_0035
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return new EntityDynamicPermissionsGenerator(metadata)
				{
					csScripts = csScripts
				};
			case 3:
				return new EntityDynamicGenerator
				{
					csScripts = csScripts
				};
			case 4:
				if (Np9uaPhOEFKs7rBtYEmb(tablePart))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 1:
				return base.CreateTablePartGenerator(tablePart);
			case 2:
				if (DynamicPublicationEnable)
				{
					if (tablePart == null)
					{
						num2 = 3;
						break;
					}
					goto case 4;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public EntityDynamicGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.PushGlobal();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object eonSTThk4E7EQOr98lKN(object P_0, object P_1)
	{
		return AssemblyDefinition.ReadAssembly((Stream)P_0, (ReaderParameters)P_1);
	}

	internal static object SKuovGhk6fuKJCWWtcMA(object P_0)
	{
		return ((AssemblyDefinition)P_0).get_Name();
	}

	internal static object r3TPvHhkHpuap4HlX5O8(object P_0)
	{
		return ((AssemblyNameReference)P_0).get_Version();
	}

	internal static int BiLU2VhkATEw6kjqVkLx(object P_0)
	{
		return ((Version)P_0).Minor;
	}

	internal static int E11vVMhk729qg4RhV6V6(object P_0)
	{
		return ((Version)P_0).Build;
	}

	internal static void ybpkLYhkx6U2rQqwMxNP(object P_0, object P_1)
	{
		((AssemblyNameReference)P_0).set_Version((Version)P_1);
	}

	internal static object AsNnoJhk0j4rprL1pWdc(object P_0)
	{
		return ((AssemblyDefinition)P_0).get_FullName();
	}

	internal static bool iEqA3LhkmuHDBqZnIkvq(object P_0, object P_1)
	{
		return (Assembly)P_0 != (Assembly)P_1;
	}

	internal static object NNxEjmhkyEwD9BWgkfBY(object P_0)
	{
		return ((AssemblyDefinition)P_0).get_MainModule();
	}

	internal static void Xakg6EhkMGJI3disi1jI(object P_0)
	{
		((DeltaAssemblyProcessor)P_0).Process();
	}

	internal static object j3moPjhkJfBAnjtd3BiK()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static void YW4wC5hk9KsWtvtaV1XY(object P_0, object P_1)
	{
		((AssemblyDefinition)P_0).Write((Stream)P_1);
	}

	internal static long MU2aP8hkdxC4Yk7IqUQh(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static object u0RVOMhklXaIAWFamFWj(object P_0, object P_1)
	{
		return ComponentManager.LoadAssembly((MemoryStream)P_0, (MemoryStream)P_1);
	}

	internal static bool ySPWi6hkti3sbOkKhWW0()
	{
		return C511m3hkDxih6u0pCvk4 == null;
	}

	internal static EntityDynamicGenerator NTLb7DhkwlPdDoXMxblW()
	{
		return C511m3hkDxih6u0pCvk4;
	}

	internal static object aKKQkChkr8RWXNo8cDHU(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object E3DvSnhkg14KJsj2wGOF(object P_0, object P_1, object P_2)
	{
		return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
	}

	internal static object Q4L8MNhk5vu7cNYiJAPh(object P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	internal static object ivqncshkj5Tt6q9RGxYY(object P_0)
	{
		return ((AssemblyName)P_0).Version;
	}

	internal static object s1uE7bhkYP8YX1NbM01V(object P_0)
	{
		return ((AssemblyName)P_0).CultureName;
	}

	internal static void KrQUpWhkL2ft7QNheeJZ(object P_0, AssemblyHashAlgorithm P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((AssemblyNameReference)P_0).set_HashAlgorithm(P_1);
	}

	internal static AssemblyNameFlags uosokNhkUQeNnqL4MbA8(object P_0)
	{
		return ((AssemblyName)P_0).Flags;
	}

	internal static void L8DslRhksqtmYKrx3wLy(object P_0, bool P_1)
	{
		((AssemblyNameReference)P_0).set_IsRetargetable(P_1);
	}

	internal static void zEXsNXhkcmTSKAgeHCUd(object P_0, object P_1)
	{
		((AssemblyNameReference)P_0).set_PublicKeyToken((byte[])P_1);
	}

	internal static void tNcLjRhkzumcZrtq5X5u(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object qk78g7hnFlRgPdbvtOID(object P_0, char P_1, char P_2)
	{
		return ((string)P_0).Replace(P_1, P_2);
	}

	internal static object tyblcIhnB7rUgH0mbXRr(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object J4YrL5hnWD3sjkq0DINm(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object l9JSaAhno456rwu0XE9d(object P_0)
	{
		return EntityDynamicGenerator.CreateReference(P_0);
	}

	internal static object oI2MPOhnbKqkeYbZqJ9h(object P_0, object P_1)
	{
		return ((CloneScope)P_0).Import((TypeReference)P_1);
	}

	internal static Type f3tMUwhnhMyGbcp34OdJ(object P_0)
	{
		return ((MethodInfo)P_0).ReturnType;
	}

	internal static object JvlmUhhnGMDjcsLAgBhk(Type type)
	{
		return CreateReference(type);
	}

	internal static CallingConventions rbHFDRhnE2GY4HupLoBY(object P_0)
	{
		return ((MethodBase)P_0).CallingConvention;
	}

	internal static void amL2IUhnfxBSmBR7EZex(object P_0, bool P_1)
	{
		((MethodReference)P_0).set_HasThis(P_1);
	}

	internal static void eIckYihnQpwNiGKo9sYN(object P_0, bool P_1)
	{
		((MethodReference)P_0).set_ExplicitThis(P_1);
	}

	internal static void jiuNWjhnCUtNoMAmBlRC(object P_0, MethodCallingConvention P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((MethodReference)P_0).set_CallingConvention(P_1);
	}

	internal static object SkgmXOhnvs2sMIyGtQpc(object P_0)
	{
		return ((MethodBase)P_0).GetParameters();
	}

	internal static object o8xwr1hn8QFrgSQawYTL(object P_0)
	{
		return ((AssemblyNameReference)P_0).get_Name();
	}

	internal static void QvXIZuhnZl9ZH18gcyJc(object P_0, object P_1)
	{
		((AssemblyNameReference)P_0).set_Culture((string)P_1);
	}

	internal static bool syFZfChnuR3gD6oEGH58(object P_0)
	{
		return ((AssemblyNameReference)P_0).get_IsRetargetable();
	}

	internal static object r2vLb2hnI8WhkjRBsatI(object P_0)
	{
		return ((AssemblyNameReference)P_0).get_PublicKeyToken();
	}

	internal static void BKCVPqhnVhtIHFwcG8jA(object P_0, object P_1, int P_2)
	{
		((Array)P_0).CopyTo((Array)P_1, P_2);
	}

	internal static object wQ5Zt3hnSKhywmgQWoi0(object P_0)
	{
		return EntityDynamicGenerator.CreateReference(P_0);
	}

	internal static object h9y15jhnifgRJAE2wDrn(object P_0)
	{
		return ((TypeSpecification)P_0).get_ElementType();
	}

	internal static Type iRZ96shnRtiPlIIchpNs(object P_0)
	{
		return Resolve((TypeReference)P_0);
	}

	internal static int LCb6BqhnqEgZoVpNs8AQ(object P_0)
	{
		return ((ArrayType)P_0).get_Rank();
	}

	internal static object Ofp4m0hnKhKS8lVhbBkZ(object P_0)
	{
		return ((MemberReference)P_0).get_FullName();
	}

	internal static object cWAOhIhnXlY19adVMb14(object P_0)
	{
		return AssemblyName(P_0);
	}

	internal static object hJ2KTshnTG9rxiU91BuJ(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool QwsILFhnkkeNjevxqvGL(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool OYTKwyhnnm0mC72xGd1p(object P_0)
	{
		return ((TypeReference)P_0).get_IsNested();
	}

	internal static object LdH5vfhnO6EQ5e4ytaxo(object P_0)
	{
		return ((MemberReference)P_0).get_DeclaringType();
	}

	internal static object kLX18Ahn2UGIsgI90Krv(object P_0)
	{
		return ((MemberReference)P_0).get_Name();
	}

	internal static bool ou9hK2hnecrPsmYkXx7w(object P_0)
	{
		return ((MethodReference)P_0).get_IsGenericInstance();
	}

	internal static object dEerjphnPjn7FcxFYbXZ(object P_0)
	{
		return CreateReference((TypeReference)P_0);
	}

	internal static object LxKIANhn1G8BE9oV6iei(object P_0)
	{
		return ((MethodReference)P_0).get_ReturnType();
	}

	internal static bool WiUJAjhnNUNPeIv6Nd2q(object P_0)
	{
		return ((MethodReference)P_0).get_HasThis();
	}

	internal static bool JiZx8xhn3aVY27d17ln3(object P_0)
	{
		return ((MethodReference)P_0).get_ExplicitThis();
	}

	internal static MethodCallingConvention jJu9iOhnpLhulQdTiq30(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((MethodReference)P_0).get_CallingConvention();
	}

	internal static bool WLvp2mhnaT0cacECS6yp(object P_0)
	{
		return ((MethodReference)P_0).get_HasGenericParameters();
	}

	internal static void XB2NxnhnD5OO0PA9xyxd(object P_0, object P_1)
	{
		((MethodReference)P_0).set_ReturnType((TypeReference)P_1);
	}

	internal static bool tShT2uhntpun8GmBD0O0(object P_0)
	{
		return ((MethodReference)P_0).get_HasParameters();
	}

	internal static object bycSo2hnwnQC3Ubt5XTN(object P_0)
	{
		return ((TypeReference)P_0).get_Scope();
	}

	internal static object MWThlghn49KGlBcfmwJx(object P_0)
	{
		return ((AssemblyNameReference)P_0).get_FullName();
	}

	internal static void JNuy0Nhn6Or8X7R3ZkVZ()
	{
		SingletonReader.PushGlobal();
	}

	internal static int BY9XIHhnHqi0quIsV0Ks(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static Type ahs6yrhnAd4G7pxVVsxB(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object M0S5U0hn75XaSWyQJutH(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}

	internal static object X4WaZKhnxGUP3rTQy1sm()
	{
		return TypeOf<Guid>.FullName;
	}

	internal static object oqmjfShn0JZU8r1EAQPq()
	{
		return TypeOf<IInheritable>.FullName;
	}

	internal static object bpUg2NhnmAsdhiRYT1c4(object P_0)
	{
		return EntityDynamicGenerator.CreateReference(P_0);
	}

	internal static object Pw7fsqhny3B22cJQgTQk(object P_0)
	{
		return ((RipeType)P_0).FullName;
	}

	internal static object keXJsnhnMwyfCU8Tu0Zh(object P_0)
	{
		return MethodName(P_0);
	}

	internal static object e9MT9YhnJ1cJVENhQULv(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object F5e4CIhn9pERVVBPIW10(object P_0)
	{
		return TypeName(P_0);
	}

	internal static object s0N42whndrdPVcyTJ75J(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static object x1sAH6hnlV7amNoNuvfv(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static object kImPPthnrGgq6aBjF2vT()
	{
		return ConfigurationModelAssemblyBuilder.Version;
	}

	internal static bool pdc1nxhng8NbBTLjYhcF(object P_0, object P_1)
	{
		return (Version)P_0 == (Version)P_1;
	}

	internal static bool uY8Yg2hn5di72k4aOt8I(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static int gqTmBLhnjx8eFrfardME(object P_0)
	{
		return ((List<AssemblyNameReference>)P_0).Count;
	}

	internal static object rlLnDohnYQkcwMWBUxCL(object P_0, object P_1)
	{
		return ((ModuleDefinition)P_0).Import((TypeReference)P_1);
	}

	internal static void m6Xci2hnL17pVeQHSnXI(object P_0, object P_1)
	{
		((MemberReference)P_0).set_DeclaringType((TypeReference)P_1);
	}

	internal static void OkwYh8hnUSTaE31L5XcY(object P_0, object P_1)
	{
		((TypeReference)P_0).set_Scope((IMetadataScope)P_1);
	}

	internal static bool D1hI47hns7WsrckyHJp7(object P_0)
	{
		return ((ClassMetadata)P_0).IsInterfaceType;
	}

	internal static object ExPxlIhnc6shpyR6usW6(object P_0)
	{
		return ((GeneratedFileInfo)P_0).Data;
	}

	internal static void O092mGhnzbsidBg7kRwD(object P_0, object P_1)
	{
		((GeneratedFileInfo)P_0).Data = (byte[])P_1;
	}

	internal static object IJGXnahOF6DHMQcNTTXB(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object bNUY8fhOBwdhH6GVVKQ4(object P_0)
	{
		return ((ClassMetadata)P_0).TypeName;
	}

	internal static object HmKtEPhOW8h4nS67PRYR(object P_0)
	{
		return EntityDynamicGenerator.GetConfigExtTypeName(P_0);
	}

	internal static Type w3AXI9hOoeG6fKLAS8BW(object P_0)
	{
		return ((RipeType)P_0).Raw;
	}

	internal static Guid iv1ooQhObXDAs4JZu1uZ(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static object HYn2ELhOhSSRFofIOX51(object P_0, Guid uid)
	{
		return ((CodeGenerator)P_0).GetMetadata(uid);
	}

	internal static object YI78jHhOGILFYUydLNfp(object P_0)
	{
		return ((ClassMetadata)P_0).FullTypeName;
	}

	internal static bool Np9uaPhOEFKs7rBtYEmb(object P_0)
	{
		return ((EntityMetadata)P_0).IsActivePermissionMetadata();
	}
}
