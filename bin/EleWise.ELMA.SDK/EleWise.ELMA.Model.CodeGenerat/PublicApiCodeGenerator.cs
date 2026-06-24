using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.CodeGeneration.PublicApi;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public sealed class PublicApiCodeGenerator
{
	private class PublicApiNodeDictionary : IDictionary<string, IEnumerable<IPublicApiNode>>, ICollection<KeyValuePair<string, IEnumerable<IPublicApiNode>>>, IEnumerable<KeyValuePair<string, IEnumerable<IPublicApiNode>>>, IEnumerable
	{
		private readonly IDictionary<string, IEnumerable<IPublicApiNode>> _tree;

		private static object BXKDBbvIwRhLEuQbNxRu;

		public IEnumerable<IPublicApiNode> this[string key]
		{
			get
			{
				if (!_tree.TryGetValue(key, out var value))
				{
					return Enumerable.Empty<IPublicApiNode>();
				}
				return value;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int Count => _tree.Count();

		public bool IsReadOnly => true;

		public ICollection<string> Keys => _tree.Keys;

		public ICollection<IEnumerable<IPublicApiNode>> Values => _tree.Values;

		public PublicApiNodeDictionary(IEnumerable<IPublicApiNode> nodes)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			_tree = (from n in nodes
				group n by (string)_003C_003Ec.aJNd40ZXAKe31pdixPqa(n)).ToDictionary((IGrouping<string, IPublicApiNode> g) => g.Key, (IGrouping<string, IPublicApiNode> g) => g.ToArray().AsEnumerable());
		}

		public void Add(KeyValuePair<string, IEnumerable<IPublicApiNode>> item)
		{
			throw new NotImplementedException();
		}

		public void Add(string key, IEnumerable<IPublicApiNode> value)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public bool Contains(KeyValuePair<string, IEnumerable<IPublicApiNode>> item)
		{
			return _tree.Contains(item);
		}

		public bool ContainsKey(string key)
		{
			return _tree.ContainsKey(key);
		}

		public void CopyTo(KeyValuePair<string, IEnumerable<IPublicApiNode>>[] array, int arrayIndex)
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
					Y774StvIHUqoa3gao8KK(_tree, array, arrayIndex);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public IEnumerator<KeyValuePair<string, IEnumerable<IPublicApiNode>>> GetEnumerator()
		{
			return _tree.GetEnumerator();
		}

		public bool Remove(KeyValuePair<string, IEnumerable<IPublicApiNode>> item)
		{
			throw new NotImplementedException();
		}

		public bool Remove(string key)
		{
			throw new NotImplementedException();
		}

		public bool TryGetValue(string key, out IEnumerable<IPublicApiNode> value)
		{
			return _tree.TryGetValue(key, out value);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		internal static bool eNpLR8vI45Qey9sUHFB9()
		{
			return BXKDBbvIwRhLEuQbNxRu == null;
		}

		internal static PublicApiNodeDictionary pIh99SvI6Fx2WeWKpAQD()
		{
			return (PublicApiNodeDictionary)BXKDBbvIwRhLEuQbNxRu;
		}

		internal static void Y774StvIHUqoa3gao8KK(object P_0, object P_1, int P_2)
		{
			((ICollection<KeyValuePair<string, IEnumerable<IPublicApiNode>>>)P_0).CopyTo((KeyValuePair<string, IEnumerable<IPublicApiNode>>[])P_1, P_2);
		}
	}

	private class PublicApiNoImplementContext : IDisposable
	{
		private static object b1lbYsvIApMjYnijV9nc;

		public PublicApiNoImplementContext()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			FQeqv9vI0ncuWoo9Wbvd();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
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
				Ij17y1vImjpy9uTeVErR(value: true);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num = 1;
				}
			}
		}

		void IDisposable.Dispose()
		{
			Ij17y1vImjpy9uTeVErR(value: false);
		}

		internal static void FQeqv9vI0ncuWoo9Wbvd()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static void Ij17y1vImjpy9uTeVErR(bool value)
		{
			PublicApiNoImplementation = value;
		}

		internal static bool Ry9VkFvI7mTFFS3dyvfF()
		{
			return b1lbYsvIApMjYnijV9nc == null;
		}

		internal static PublicApiNoImplementContext VwkWh1vIxuJQYi0ytI43()
		{
			return (PublicApiNoImplementContext)b1lbYsvIApMjYnijV9nc;
		}
	}

	private readonly IEnumerable<Type> autoImplementInterfaces;

	private readonly IEnumerable<IPublicApiNodeProvider> publicApiNodeProviders;

	private readonly ISet<Guid> usesMetadata;

	private readonly HashSet<string> usedKeys;

	private readonly Dictionary<string, List<string>> propertyClassNodes;

	private readonly Dictionary<string, Pair<List<string>, List<string>>> propertyPropertyNodes;

	private bool useHiddenProperty;

	private ISet<Guid> configurationModelUids;

	private readonly ISet<Guid> metadataUids;

	private static readonly AsyncLocal<bool> NoImplementationLocal;

	private ILogger logger;

	private static PublicApiCodeGenerator OZNeUJhNWWVQ07usg7qD;

	public static PublicApiCodeGenerator Current
	{
		get
		{
			return cC7k86hNGKFZvmQ4xsYF(xqDh2uhNhjkDkV9jKLAc(0x571EA399 ^ 0x571DC22D)) as PublicApiCodeGenerator;
		}
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
				case 1:
					lyPyuDhNExCOlSlSdpjN(xqDh2uhNhjkDkV9jKLAc(-345420348 ^ -345363344), value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
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

	public static bool PublicApiNoImplementation
	{
		get
		{
			return NoImplementationLocal.Value;
		}
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
				case 1:
					NoImplementationLocal.Value = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
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

	internal static IDisposable NoImplementContext => new PublicApiNoImplementContext();

	public PublicApiCodeGenerator(IEnumerable<Type> autoImplementInterfaces, IEnumerable<IMetadata> metadataList, IEnumerable<IMetadata> configurationMetadataList, IEnumerable<IPublicApiNodeProvider> publicApiNodeProviders)
	{
		SingletonReader.JJCZtPuTvSt();
		usesMetadata = new HashSet<Guid>();
		usedKeys = new HashSet<string>();
		propertyClassNodes = new Dictionary<string, List<string>>();
		propertyPropertyNodes = new Dictionary<string, Pair<List<string>, List<string>>>();
		logger = Logger.GetLogger(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426266557));
		base._002Ector();
		this.autoImplementInterfaces = autoImplementInterfaces;
		metadataUids = metadataList?.Select((IMetadata m) => m.Uid).ToHashSet();
		configurationModelUids = configurationMetadataList?.Select((IMetadata m) => _003C_003Ec.sacTIOvIdlMU1K1Gm5Dv(m)).ToHashSet();
		this.publicApiNodeProviders = ((metadataUids == null) ? publicApiNodeProviders : publicApiNodeProviders.Where((IPublicApiNodeProvider p) => !(p is PublicApiCustomMethodsNodeProvider)));
	}

	public IMetadata GetMetadata(Guid metadataUid, bool loadImplementation = false)
	{
		return ((IMetadataService)BH0m6shNfFlv57XE1Zb9()).GetMetadata(metadataUid, loadImplementation);
	}

	public IEnumerable<IMetadata> GetAllMetadata()
	{
		return MetadataServiceContext.Service.GetMetadataList();
	}

	public IEnumerable<EntityMetadata> GetEntityMetadataList()
	{
		return from m in GetAllMetadata().OfType<EntityMetadata>()
			where !_003C_003Ec.hxfgxvvIlvpA3jIm7nBK(m)
			select m;
	}

	public Type GetTypeByUid(Guid uid)
	{
		return ((IMetadataRuntimeService)DsLMe6hNQNxR3lWCmBbQ()).GetTypeByUid(uid, loadImplementation: false);
	}

	public bool IsSystem(IMetadata md)
	{
		//Discarded unreachable code: IL_004d, IL_005c, IL_0135, IL_0144
		int num = 10;
		int num2 = num;
		AssemblyModelsMetadata assemblyModelsMetadata = default(AssemblyModelsMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (assemblyModelsMetadata == null)
				{
					num2 = 2;
					continue;
				}
				break;
			case 2:
				configurationModelUids = new HashSet<Guid>();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 0;
				}
				continue;
			default:
				return !configurationModelUids.Contains(ub876yhNv0GKVckSH2di(md));
			case 5:
				if (configurationModelUids != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 8;
			case 7:
				md = GetMetadata(entityMetadata.ImplementationUid);
				num2 = 5;
				continue;
			case 10:
				if ((entityMetadata = md as EntityMetadata) != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 9;
					}
					continue;
				}
				goto case 5;
			case 9:
				if (vVOOTihNCXmfARUgr6rL(entityMetadata) == EntityMetadataType.InterfaceImplementation)
				{
					num2 = 7;
					continue;
				}
				goto case 5;
			case 8:
				assemblyModelsMetadata = ((IMetadataRuntimeService)DsLMe6hNQNxR3lWCmBbQ()).GetAssemblyModelsMetadataList().FirstOrDefault((AssemblyModelsMetadata m) => _003C_003Ec.nTi1uCvIg8NU4PWDL09T(m.Name, _003C_003Ec.u6UI90vIrxk8y9CDsreD(-1123633026 ^ -1123634662)));
				num2 = 4;
				continue;
			case 6:
				break;
			}
			configurationModelUids = (from m in assemblyModelsMetadata.RestoreMetadata()
				select _003C_003Ec.mO32LcvI5oPDOfB20Vlc(m)).ToHashSet();
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
			{
				num2 = 0;
			}
		}
	}

	public ITypeDescriptor GetTypeDescriptor(Guid typeUid, Guid subTypeUid)
	{
		return (ITypeDescriptor)myFpSihN8KNWU49CwwK2(BH0m6shNfFlv57XE1Zb9(), typeUid, subTypeUid);
	}

	public ITypeDescriptor GetIdTypeDescriptor(Guid typeUid)
	{
		return (ITypeDescriptor)Aroj1PhNZCZAcYECE6ND(BH0m6shNfFlv57XE1Zb9(), typeUid);
	}

	public string GenerateCode()
	{
		//Discarded unreachable code: IL_00c3, IL_00cd, IL_014b, IL_01b5, IL_01c4, IL_01e5, IL_0204, IL_0213, IL_0240, IL_024f, IL_0297, IL_0549, IL_05e5, IL_065c, IL_066b
		int num = 1;
		int num2 = num;
		string result = default(string);
		PublicApiCodeGenerator publicApiCodeGenerator = default(PublicApiCodeGenerator);
		_003C_003Ec__DisplayClass29_0 CS_0024_003C_003E8__locals0;
		IEnumerator<Guid> enumerator = default(IEnumerator<Guid>);
		Guid guid = default(Guid);
		Dictionary<Guid, Guid> dictionary = default(Dictionary<Guid, Guid>);
		_003C_003Ec__DisplayClass29_1 _003C_003Ec__DisplayClass29_ = default(_003C_003Ec__DisplayClass29_1);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				publicApiCodeGenerator = (PublicApiCodeGenerator)SqrjD7hNuhuOiZ2dYbS6();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass29_0();
				int num3 = 13;
				while (true)
				{
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 9:
							return result;
						case 17:
							try
							{
								while (true)
								{
									int num5;
									if (!enumerator.MoveNext())
									{
										num5 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
										{
											num5 = 2;
										}
										goto IL_00d1;
									}
									goto IL_019d;
									IL_019d:
									guid = enumerator.Current;
									num5 = 6;
									goto IL_00d1;
									IL_00d1:
									while (true)
									{
										switch (num5)
										{
										default:
											guid = dictionary[guid];
											num5 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
											{
												num5 = 1;
											}
											continue;
										case 3:
											break;
										case 7:
											if (_003C_003Ec__DisplayClass29_.metadataBaseUids.Add(guid))
											{
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
												{
													num5 = 5;
												}
												continue;
											}
											break;
										case 1:
										case 6:
											if (G8VbtlhNSbr077KuZUB9(guid, Guid.Empty))
											{
												num5 = 7;
												continue;
											}
											break;
										case 4:
											goto IL_019d;
										case 2:
											goto end_IL_0120;
										}
										break;
									}
									continue;
									end_IL_0120:
									break;
								}
							}
							finally
							{
								int num6;
								if (enumerator == null)
								{
									num6 = 2;
									goto IL_01e9;
								}
								goto IL_021e;
								IL_01e9:
								switch (num6)
								{
								default:
									goto end_IL_01d4;
								case 2:
									goto end_IL_01d4;
								case 1:
									break;
								case 0:
									goto end_IL_01d4;
								}
								goto IL_021e;
								IL_021e:
								FDhfFFhNiIsVKXgORpHB(enumerator);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
								{
									num6 = 0;
								}
								goto IL_01e9;
								end_IL_01d4:;
							}
							goto case 1;
						case 16:
							_003C_003Ec__DisplayClass29_.metadataBaseUids = new HashSet<Guid>();
							num4 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
							{
								num4 = 1;
							}
							continue;
						case 13:
							CS_0024_003C_003E8__locals0._003C_003E4__this = this;
							num4 = 10;
							continue;
						case 8:
							result = Enumerable.Repeat(CS_0024_003C_003E8__locals0.nodes.OfType<PublicApiRootNode>().Single().Generate(CS_0024_003C_003E8__locals0.tree), 1).If(metadataUids == null, (IEnumerable<ISyntaxNode> _) => _.Concat(from n in CS_0024_003C_003E8__locals0.nodes.OfType<PublicApiCustomBuilderMethodNode>()
								group n by n.Namespace into g
								select g.Key.NamespaceDeclaration(from n in g
									select n.Generate(CS_0024_003C_003E8__locals0.tree) into n
									where n != null
									select n))).GenerateCSCodeString();
							num4 = 9;
							continue;
						case 7:
							_003C_003Ec__DisplayClass29_.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
							{
								num4 = 0;
							}
							continue;
						case 1:
							_003C_003Ec__DisplayClass29_.CS_0024_003C_003E8__locals1.nodes = _003C_003Ec__DisplayClass29_.CS_0024_003C_003E8__locals1.nodes.Where(_003C_003Ec__DisplayClass29_._003CGenerateCode_003Eb__4);
							num4 = 12;
							continue;
						case 4:
							logger.Info(xqDh2uhNhjkDkV9jKLAc(-2138160520 ^ -2138234818));
							num4 = 2;
							continue;
						case 5:
							_003C_003Ec__DisplayClass29_ = new _003C_003Ec__DisplayClass29_1();
							num4 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
							{
								num4 = 7;
							}
							continue;
						case 11:
							KlHsbThNVkYCp0kh4xlX(this);
							num4 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
							{
								num4 = 4;
							}
							continue;
						case 3:
							if (metadataUids == null)
							{
								num4 = 14;
								continue;
							}
							goto case 5;
						case 10:
							AVwoyhhNILn5A5sMhG6X(logger, xqDh2uhNhjkDkV9jKLAc(-477139494 ^ -477360172));
							num4 = 11;
							continue;
						case 12:
						case 14:
							CS_0024_003C_003E8__locals0.tree = new PublicApiNodeDictionary(CS_0024_003C_003E8__locals0.nodes);
							num4 = 18;
							continue;
						case 18:
							AVwoyhhNILn5A5sMhG6X(logger, xqDh2uhNhjkDkV9jKLAc(-787452571 ^ -787279913));
							num4 = 8;
							continue;
						case 6:
							enumerator = metadataUids.GetEnumerator();
							num4 = 17;
							continue;
						case 15:
							break;
						case 2:
							CS_0024_003C_003E8__locals0.nodes = publicApiNodeProviders.SelectMany((IPublicApiNodeProvider p) => p.CreatePublicApiNodes()).ToArray().AsEnumerable();
							num4 = 15;
							continue;
						default:
							dictionary = GetAllMetadata().ToDictionary((IMetadata m) => _003C_003Ec.sacTIOvIdlMU1K1Gm5Dv(m), delegate(IMetadata m)
							{
								int num9 = 1;
								int num10 = num9;
								while (true)
								{
									switch (num10)
									{
									case 1:
									{
										ClassMetadata obj = m as ClassMetadata;
										if (obj != null)
										{
											return _003C_003Ec.enT3Y1vIjdE54pfWy23s(obj);
										}
										num10 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
										{
											num10 = 0;
										}
										break;
									}
									default:
										return Guid.Empty;
									}
								}
							});
							num4 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
							{
								num4 = 16;
							}
							continue;
						}
						break;
					}
					AVwoyhhNILn5A5sMhG6X(logger, xqDh2uhNhjkDkV9jKLAc(0x49E27B8A ^ 0x49E119F4));
					num3 = 3;
				}
			}
			catch (Exception ex)
			{
				int num7 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num7 = 1;
				}
				while (true)
				{
					switch (num7)
					{
					case 1:
						PMQM7yhNqyOgjMcDk9dB(logger, QurexIhNRsJG8iHUdtYW(ex), ex);
						num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num7 = 0;
						}
						break;
					default:
						throw new CodeGenerationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFD9AB4)), ex);
					}
				}
			}
			finally
			{
				AVwoyhhNILn5A5sMhG6X(logger, xqDh2uhNhjkDkV9jKLAc(-606654180 ^ -606842308));
				int num8 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num8 = 2;
				}
				while (true)
				{
					switch (num8)
					{
					case 1:
						AVwoyhhNILn5A5sMhG6X(logger, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70242968));
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num8 = 0;
						}
						continue;
					case 2:
						KlHsbThNVkYCp0kh4xlX(publicApiCodeGenerator);
						num8 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num8 = 1;
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

	public bool IsSystemObjects(EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_0091, IL_00a0, IL_0117, IL_0126, IL_0136, IL_0145, IL_01b5, IL_01c4, IL_01d4, IL_01e3
		int num = 11;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (NtlHibhNTsHTGG8iLSms(metadata.FullTypeName, xqDh2uhNhjkDkV9jKLAc(-29254301 ^ -29165193)))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 8;
						}
						break;
					}
					goto case 1;
				case 4:
					return metadata.Type == EntityMetadataType.Interface;
				case 6:
					return true;
				case 5:
				case 7:
				case 8:
				case 10:
					return false;
				case 2:
					if (!(dNPMpihNXv6NLXsksFmv(metadata) != new Guid((string)xqDh2uhNhjkDkV9jKLAc(-812025778 ^ -811983994))))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 9;
				case 1:
					if (vVOOTihNCXmfARUgr6rL(metadata) == EntityMetadataType.Entity)
					{
						goto end_IL_0012;
					}
					goto case 4;
				case 9:
					if (metadata is TablePartMetadata)
					{
						num2 = 7;
						break;
					}
					goto case 3;
				default:
					if (G8VbtlhNSbr077KuZUB9(PSEE5AhNKmTTDlSH2Lmx(metadata), new Guid((string)xqDh2uhNhjkDkV9jKLAc(0x1DE3DD89 ^ 0x1DE0BEF5))))
					{
						num2 = 2;
						break;
					}
					goto case 5;
				case 11:
					if (IsUsesMetadata(metadata))
					{
						num2 = 10;
						break;
					}
					goto default;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	public bool IsUserObject(IMetadata metadata)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (IsUsesMetadata(metadata))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return !IsSystem(metadata);
			case 1:
				return false;
			}
		}
	}

	public void SaveUsesMetadata<T>()
	{
		SaveUsesMetadata(TypeOf<T>.Raw);
	}

	public void SaveUsesMetadata(Type type)
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
				SaveUsesMetadata(InterfaceActivator.UID(type));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void SaveUsesMetadata(IMetadata metadata)
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
				SaveUsesMetadata(ub876yhNv0GKVckSH2di(metadata));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private bool IsUsesMetadata(IMetadata metadata)
	{
		//Discarded unreachable code: IL_0068, IL_0077
		int num = 3;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return usesMetadata.Contains(dpUbAJhNk3XMhhuihGER(entityMetadata));
				case 4:
					return false;
				case 2:
					if ((entityMetadata = metadata as EntityMetadata) == null)
					{
						goto end_IL_0012;
					}
					goto default;
				case 3:
					if (usesMetadata.Contains(ub876yhNv0GKVckSH2di(metadata)))
					{
						return true;
					}
					num2 = 2;
					break;
				default:
					if (G8VbtlhNSbr077KuZUB9(entityMetadata.ImplementationUid, Guid.Empty))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 4;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	private void SaveUsesMetadata(Guid guid)
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
				usesMetadata.Add(guid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ISyntaxNode GetCodeTypeReference([NotNull] Type type, IList<TypeArgument> typeArguments = null)
	{
		TypeArgument typeArgument = null;
		return GetCodeTypeReference(type, typeArguments, checkType: true, ref typeArgument);
	}

	public ISyntaxNode GetCodeTypeReference([NotNull] Type type, ref TypeArgument typeArgument, IList<TypeArgument> typeArguments = null)
	{
		return GetCodeTypeReference(type, typeArguments, checkType: true, ref typeArgument);
	}

	private ISyntaxNode GetCodeTypeReference([NotNull] Type type, IList<TypeArgument> typeArguments, bool checkType, ref TypeArgument typeArgument)
	{
		_003C_003Ec__DisplayClass39_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass39_0();
		CS_0024_003C_003E8__locals0.type = type;
		if (CS_0024_003C_003E8__locals0.type == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -672122599));
		}
		if (CS_0024_003C_003E8__locals0.type.IsGenericParameter && CS_0024_003C_003E8__locals0.type.DeclaringMethod == null && typeArguments != null)
		{
			typeArgument = typeArguments[CS_0024_003C_003E8__locals0.type.GenericParameterPosition];
			return typeArgument.CreateTypeSyntax();
		}
		if (CS_0024_003C_003E8__locals0.type.IsGenericType)
		{
			Type genericTypeDefinition = CS_0024_003C_003E8__locals0.type.GetGenericTypeDefinition();
			bool checkType2 = checkType && genericTypeDefinition.GetInterfaces().Any((Type i) => i.IsAssignableFrom(TypeOf.IEnumerable.Raw));
			List<ISyntaxNode> list = new List<ISyntaxNode>();
			Type[] genericArguments = CS_0024_003C_003E8__locals0.type.GetGenericArguments();
			foreach (Type type2 in genericArguments)
			{
				list.Add(GetCodeTypeReference(type2, typeArguments, checkType2, ref typeArgument));
			}
			return genericTypeDefinition.CreateTypeSyntax(list.ToArray());
		}
		if (CS_0024_003C_003E8__locals0.type.IsArray)
		{
			return GetCodeTypeReference(CS_0024_003C_003E8__locals0.type.GetElementType(), typeArguments, checkType: true, ref typeArgument).CreateArrayTypeSyntax();
		}
		if (CS_0024_003C_003E8__locals0.type == TypeOf<IUser>.Raw)
		{
			EntityMetadata entityMetadata = (EntityMetadata)GetMetadata(new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637D4DAF)));
			if (entityMetadata == null)
			{
				return CS_0024_003C_003E8__locals0.type.CreateTypeSyntax();
			}
			typeArgument = entityMetadata;
			return typeArgument?.CreateTypeSyntax();
		}
		if (checkType)
		{
			if (TypeOf<IEntity>.Raw.IsAssignableFrom(CS_0024_003C_003E8__locals0.type) && MetadataLoader.LoadMetadata(CS_0024_003C_003E8__locals0.type, inherit: true, loadImplementation: false) is EntityMetadata entityMetadata2)
			{
				if (entityMetadata2.Type == EntityMetadataType.InterfaceExtension)
				{
					entityMetadata2 = (EntityMetadata)GetMetadata(entityMetadata2.BaseClassUid);
				}
				typeArgument = entityMetadata2;
				return typeArgument.CreateTypeSyntax();
			}
			if (CS_0024_003C_003E8__locals0.type.IsInterface)
			{
				Type type3 = autoImplementInterfaces.FirstOrDefault((Type a) => a.IsAssignableFrom(CS_0024_003C_003E8__locals0.type));
				if (type3 != null)
				{
					return PublicApiPropertyClassNode.GetTypeName(type3).CreateTypeSyntax();
				}
			}
		}
		return CS_0024_003C_003E8__locals0.type.CreateTypeSyntax();
	}

	internal void UseHiddenProperty(bool useHidden, Action action)
	{
		int num = 2;
		_003C_003Ec__DisplayClass40_0 _003C_003Ec__DisplayClass40_ = default(_003C_003Ec__DisplayClass40_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 2:
					_003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					_003C_003Ec__DisplayClass40_.action = action;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			UseHiddenProperty(useHidden, (Func<int>)_003C_003Ec__DisplayClass40_._003CUseHiddenProperty_003Eb__0);
			num = 3;
		}
	}

	internal T UseHiddenProperty<T>(bool useHidden, Func<T> func)
	{
		bool flag = useHiddenProperty;
		useHiddenProperty |= useHidden;
		try
		{
			return func();
		}
		finally
		{
			useHiddenProperty = flag;
		}
	}

	public string GetNodeFullPath(Type type)
	{
		return GetNodeFullPath((string)Om8uw2hNniB6hnoJtDDv(type));
	}

	public string GetNodeFullPath(EntityMetadata metadata)
	{
		return GetNodeFullPath((string)A2Nb4phNOItdRZbJbYaI(metadata));
	}

	public string GetNodeFullPath(EnumMetadata metadata)
	{
		return GetNodeFullPath((string)f0cvsRhN23t4fP0JMPhp(metadata));
	}

	private string GetNodeFullPath(string typeName)
	{
		//Discarded unreachable code: IL_0051, IL_0060, IL_00ea, IL_013f, IL_014e, IL_0196, IL_01a5
		int num = 6;
		int num2 = num;
		List<string> list = default(List<string>);
		Pair<List<string>, List<string>> value = default(Pair<List<string>, List<string>>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				list = value.First;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return string.Join((string)xqDh2uhNhjkDkV9jKLAc(0x638095EB ^ 0x638099E9), list);
			case 1:
			case 3:
				return null;
			case 8:
				if (list.Count != 0)
				{
					num2 = 11;
					break;
				}
				goto case 4;
			case 9:
			case 10:
			case 11:
				if (KyLkJ4hNP9rwtpCxKhtV(list) <= 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 5:
				if (!propertyPropertyNodes.TryGetValue(typeName, out value))
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 6:
				if (!qeWk4whNe5kYOaZkMIyt(typeName))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 1;
			case 7:
				list = value.Second;
				num2 = 10;
				break;
			case 4:
				if (!useHiddenProperty)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 7;
			}
		}
	}

	public bool AddIfNotExists(string key)
	{
		return usedKeys.Add(key);
	}

	internal void AddPropertyClassNode(string className, string path)
	{
		int num = 3;
		int num2 = num;
		List<string> value = default(List<string>);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (!propertyClassNodes.TryGetValue(className, out value))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 1:
				return;
			case 2:
				value = (propertyClassNodes[className] = new List<string>());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			value.Add(path);
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
			{
				num2 = 0;
			}
		}
	}

	internal void AddPropertyTypeNode(string typeName, string path, bool hidden)
	{
		//Discarded unreachable code: IL_0050, IL_00c5, IL_00d4, IL_0104, IL_0113
		int num = 8;
		int num2 = num;
		Pair<List<string>, List<string>> value = default(Pair<List<string>, List<string>>);
		while (true)
		{
			List<string> list;
			switch (num2)
			{
			case 6:
				list = value.First;
				break;
			default:
				AddPropertyTypeNode((string)xqDh2uhNhjkDkV9jKLAc(-643786247 ^ -643564225), path, hidden);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				value = (propertyPropertyNodes[typeName] = new Pair<List<string>, List<string>>(new List<string>(), new List<string>()));
				num2 = 9;
				continue;
			case 3:
				return;
			case 7:
				return;
			case 8:
				if (typeName == null)
				{
					num2 = 7;
					continue;
				}
				goto case 2;
			case 4:
			case 9:
				if (!hidden)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				list = value.Second;
				break;
			case 5:
				if (!sRuvy5hN1VZY8l3rSonf(typeName, xqDh2uhNhjkDkV9jKLAc(0x35C0467B ^ 0x35C322FB)))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				if (propertyPropertyNodes.TryGetValue(typeName, out value))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto case 1;
			}
			list.Add(path);
			num2 = 5;
		}
	}

	internal IEnumerable<string> GetPropertyClassNodePath(string className)
	{
		if (!propertyClassNodes.TryGetValue(className, out var value))
		{
			return Enumerable.Repeat(className, 1);
		}
		return value;
	}

	static PublicApiCodeGenerator()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				NoImplementationLocal = new AsyncLocal<bool>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static object xqDh2uhNhjkDkV9jKLAc(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object cC7k86hNGKFZvmQ4xsYF(object P_0)
	{
		return CallContext.GetData((string)P_0);
	}

	internal static bool jldXpHhNoL84hbHe6OYa()
	{
		return OZNeUJhNWWVQ07usg7qD == null;
	}

	internal static PublicApiCodeGenerator I4HPpQhNbbyEdAGgkAeZ()
	{
		return OZNeUJhNWWVQ07usg7qD;
	}

	internal static void lyPyuDhNExCOlSlSdpjN(object P_0, object P_1)
	{
		CallContext.SetData((string)P_0, P_1);
	}

	internal static object BH0m6shNfFlv57XE1Zb9()
	{
		return MetadataServiceContext.Service;
	}

	internal static object DsLMe6hNQNxR3lWCmBbQ()
	{
		return MetadataServiceContext.MetadataRuntimeService;
	}

	internal static EntityMetadataType vVOOTihNCXmfARUgr6rL(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static Guid ub876yhNv0GKVckSH2di(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static object myFpSihN8KNWU49CwwK2(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static object Aroj1PhNZCZAcYECE6ND(object P_0, Guid typeUid)
	{
		return ((IMetadataService)P_0).GetIdTypeDescriptor(typeUid);
	}

	internal static object SqrjD7hNuhuOiZ2dYbS6()
	{
		return Current;
	}

	internal static void AVwoyhhNILn5A5sMhG6X(object P_0, object P_1)
	{
		((ILogger)P_0).Info(P_1);
	}

	internal static void KlHsbThNVkYCp0kh4xlX(object P_0)
	{
		Current = (PublicApiCodeGenerator)P_0;
	}

	internal static bool G8VbtlhNSbr077KuZUB9(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static void FDhfFFhNiIsVKXgORpHB(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object QurexIhNRsJG8iHUdtYW(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void PMQM7yhNqyOgjMcDk9dB(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static Guid PSEE5AhNKmTTDlSH2Lmx(object P_0)
	{
		return ((EntityMetadata)P_0).TypeUid;
	}

	internal static Guid dNPMpihNXv6NLXsksFmv(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static bool NtlHibhNTsHTGG8iLSms(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static Guid dpUbAJhNk3XMhhuihGER(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static object Om8uw2hNniB6hnoJtDDv(Type type)
	{
		return PublicApiPropertyClassNode.GetTypeName(type);
	}

	internal static object A2Nb4phNOItdRZbJbYaI(object P_0)
	{
		return PublicApiPropertyClassNode.GetTypeName((EntityMetadata)P_0);
	}

	internal static object f0cvsRhN23t4fP0JMPhp(object P_0)
	{
		return ((EnumMetadata)P_0).FullTypeName;
	}

	internal static bool qeWk4whNe5kYOaZkMIyt(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static int KyLkJ4hNP9rwtpCxKhtV(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static bool sRuvy5hN1VZY8l3rSonf(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}
}
