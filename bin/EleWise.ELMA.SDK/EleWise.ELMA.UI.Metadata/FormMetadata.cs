using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Metadata;

public abstract class FormMetadata : NamedMetadata, ICodeItemMetadata, IMetadata, IXsiType, IRootMetadata
{
	private static FormMetadata mirmE1BEIyxWexdAAiic;

	public string Namespace
	{
		[CompilerGenerated]
		get
		{
			return _003CNamespace_003Ek__BackingField;
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
					_003CNamespace_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
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

	[DefaultValue("")]
	public string NamespaceForDisplay
	{
		[CompilerGenerated]
		get
		{
			return _003CNamespaceForDisplay_003Ek__BackingField;
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
					_003CNamespaceForDisplay_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
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

	public string FullTypeName => (string)dgO3mNBEq5cJ2EPmxUUO(Namespace, LTZJ9NBEik7Hjkntgkgn(0x7247028A ^ 0x7247184E), k3PtfBBERuVYtsWjDFJw(this));

	public abstract IEnumerable<Guid> PartUids { get; }

	public abstract Guid GetTypeUid();

	public virtual void LoadFromType(Type type, bool inherit = true)
	{
		//Discarded unreachable code: IL_004b, IL_00ad, IL_00e9, IL_00f8, IL_0134, IL_0143, IL_014e, IL_01e8, IL_0207, IL_0216, IL_0243, IL_0252, IL_02d7, IL_0330, IL_034f, IL_035e, IL_037b, IL_038a
		int num = 2;
		int num2 = num;
		Stream reflectionManifestResourceStream = default(Stream);
		XmlTextReader xmlTextReader = default(XmlTextReader);
		FormMetadata formMetadata = default(FormMetadata);
		IEnumerator<PropertyInfo> enumerator = default(IEnumerator<PropertyInfo>);
		PropertyInfo current = default(PropertyInfo);
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
					int num3;
					if (reflectionManifestResourceStream == null)
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num3 = 1;
						}
					}
					else
					{
						xmlTextReader = new XmlTextReader(reflectionManifestResourceStream);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num3 = 0;
						}
					}
					switch (num3)
					{
					case 1:
						throw new InvalidOperationException((string)LTZJ9NBEik7Hjkntgkgn(-2106517564 ^ -2106459412));
					default:
						try
						{
							Type type2 = SqofaOBEXF6GMICWLuvc(this);
							int num4 = 3;
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 0:
									return;
								case 5:
									return;
								case 1:
									if (formMetadata == null)
									{
										num4 = 5;
										continue;
									}
									break;
								case 3:
									formMetadata = (FormMetadata)ClassSerializationHelper.DeserializeObjectByXml(type2, xmlTextReader);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
									{
										num4 = 1;
									}
									continue;
								case 2:
									try
									{
										while (true)
										{
											int num5;
											if (!tytNTjBEnpfCiqSyAbe5(enumerator))
											{
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
												{
													num5 = 0;
												}
												goto IL_0152;
											}
											goto IL_0192;
											IL_0192:
											current = enumerator.Current;
											num5 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
											{
												num5 = 2;
											}
											goto IL_0152;
											IL_0152:
											while (true)
											{
												switch (num5)
												{
												default:
													return;
												case 0:
													return;
												case 3:
													break;
												case 1:
													goto IL_0192;
												case 2:
													QAWjAeBEkCyqIpv13r4T(current, this, gAlstABETyCdebUYNPa0(current, formMetadata, null), null);
													num5 = 3;
													continue;
												}
												break;
											}
										}
									}
									finally
									{
										int num6;
										if (enumerator == null)
										{
											num6 = 2;
											goto IL_01ec;
										}
										goto IL_0221;
										IL_01ec:
										switch (num6)
										{
										case 2:
											goto end_IL_01d7;
										case 1:
											goto end_IL_01d7;
										}
										goto IL_0221;
										IL_0221:
										yNqBLABEORePWDTVwHxw(enumerator);
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
										{
											num6 = 1;
										}
										goto IL_01ec;
										end_IL_01d7:;
									}
								case 4:
									break;
								}
								enumerator = type2.GetProperties().Where(delegate(PropertyInfo p)
								{
									int num9 = 2;
									int num10 = num9;
									while (true)
									{
										switch (num10)
										{
										default:
											return _003C_003Ec.MlLlXiQbbhr258hu7ZH7(p);
										case 1:
											if (_003C_003Ec.WTEynLQboHgyAeyjjMU2(p))
											{
												num10 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
												{
													num10 = 0;
												}
												break;
											}
											goto IL_002f;
										case 2:
											{
												if (((Array)_003C_003Ec.YJbWHHQbWo6LxFld79vW(p)).Length == 0)
												{
													num10 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
													{
														num10 = 1;
													}
													break;
												}
												goto IL_002f;
											}
											IL_002f:
											return false;
										}
									}
								}).GetEnumerator();
								num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
								{
									num4 = 1;
								}
							}
						}
						finally
						{
							if (xmlTextReader != null)
							{
								int num7 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
								{
									num7 = 1;
								}
								while (true)
								{
									switch (num7)
									{
									case 1:
										yNqBLABEORePWDTVwHxw(xmlTextReader);
										num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
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
				finally
				{
					int num8;
					if (reflectionManifestResourceStream == null)
					{
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num8 = 0;
						}
						goto IL_0334;
					}
					goto IL_0369;
					IL_0369:
					yNqBLABEORePWDTVwHxw(reflectionManifestResourceStream);
					num8 = 2;
					goto IL_0334;
					IL_0334:
					switch (num8)
					{
					default:
						goto end_IL_030f;
					case 0:
						goto end_IL_030f;
					case 1:
						break;
					case 2:
						goto end_IL_030f;
					}
					goto IL_0369;
					end_IL_030f:;
				}
			case 2:
				reflectionManifestResourceStream = type.Assembly.GetReflectionManifestResourceStream((string)ddaoqGBEKwcTOU95dftq(type.FullName, LTZJ9NBEik7Hjkntgkgn(-1837662597 ^ -1837648853)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public bool IsRestartNeeded(IRootMetadata metadata)
	{
		return false;
	}

	public void ApplyRestartUnrequiredChanges(bool inherit)
	{
	}

	public IEnumerable<IMetadata> GetMetadataToRegister()
	{
		List<IMetadata> list = new List<IMetadata>();
		GetMetadataToRegister(list);
		return list;
	}

	public abstract EntityMetadata GetPartContext(Guid uid);

	public abstract FormPartMetadata GetPart(Guid partUid);

	public virtual void GenerateNewUids()
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
				i0f3qyBEekCgj1UP01NY(this, Bqjds7BE2i2aVEVf0Qti());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected abstract void GetMetadataToRegister(List<IMetadata> metadataList);

	protected EntityMetadata FindFormContextRecursive(EntityMetadata metadata, Guid uid)
	{
		//Discarded unreachable code: IL_0036, IL_0040, IL_00cb, IL_0142, IL_0155, IL_01b1, IL_01c0
		int num = 2;
		List<TablePartMetadata>.Enumerator enumerator = default(List<TablePartMetadata>.Enumerator);
		TablePartMetadata current = default(TablePartMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		EntityMetadata result = default(EntityMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
								{
									num3 = 1;
								}
								goto IL_0044;
							}
							goto IL_00d5;
							IL_00d5:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
							{
								num3 = 0;
							}
							goto IL_0044;
							IL_0044:
							while (true)
							{
								switch (num3)
								{
								case 2:
									break;
								case 5:
									if (entityMetadata != null)
									{
										num3 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
										{
											num3 = 3;
										}
										continue;
									}
									break;
								default:
									entityMetadata = FindFormContextRecursive(current, uid);
									num3 = 5;
									continue;
								case 6:
									goto IL_00d5;
								case 4:
									result = entityMetadata;
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
									{
										num3 = 3;
									}
									continue;
								case 1:
									goto end_IL_006a;
								case 3:
									return result;
								}
								break;
							}
							continue;
							end_IL_006a:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 4;
				case 2:
					if (!z0QBd6BE1d9n5IQVfJrR(Xxc9LqBEPP6ciee3wlpc(metadata), uid))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 4:
					return null;
				case 1:
					goto end_IL_0012;
				}
				return metadata;
				continue;
				end_IL_0012:
				break;
			}
			enumerator = metadata.TableParts.GetEnumerator();
			num = 3;
		}
	}

	protected FormMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jT8pwkBENP5pRDbvNpyJ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool BRncqdBEVNwxrxDZBjSY()
	{
		return mirmE1BEIyxWexdAAiic == null;
	}

	internal static FormMetadata RSEW2YBESNl6FN0Sv75Y()
	{
		return mirmE1BEIyxWexdAAiic;
	}

	internal static object LTZJ9NBEik7Hjkntgkgn(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object k3PtfBBERuVYtsWjDFJw(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object dgO3mNBEq5cJ2EPmxUUO(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object ddaoqGBEKwcTOU95dftq(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static Type SqofaOBEXF6GMICWLuvc(object P_0)
	{
		return P_0.GetType();
	}

	internal static object gAlstABETyCdebUYNPa0(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static void QAWjAeBEkCyqIpv13r4T(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static bool tytNTjBEnpfCiqSyAbe5(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void yNqBLABEORePWDTVwHxw(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static Guid Bqjds7BE2i2aVEVf0Qti()
	{
		return Guid.NewGuid();
	}

	internal static void i0f3qyBEekCgj1UP01NY(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).Uid = value;
	}

	internal static Guid Xxc9LqBEPP6ciee3wlpc(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool z0QBd6BE1d9n5IQVfJrR(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static void jT8pwkBENP5pRDbvNpyJ()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
