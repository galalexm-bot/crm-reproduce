using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Export.Metadata;

public class MetadataExportObject : IExportObject
{
	private string serializedMd;

	internal static MetadataExportObject a4j40MEYNk0DlbeK2lUl;

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use property Metadata", true)]
	public IGroupedMetadata Md
	{
		get
		{
			return Metadata as IGroupedMetadata;
		}
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
					Metadata = Md;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IMetadata Metadata
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
				case 0:
					return;
				case 1:
					_003CMetadata_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Dictionary<string, Guid> ScriptModules { get; set; }

	public MetadataExportObject()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		gX1BcXEYant7xoo3okhR();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public MetadataExportObject(IGroupedMetadata metadata)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		gX1BcXEYant7xoo3okhR();
		this._002Ector((IMetadata)metadata);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public MetadataExportObject(IMetadata metadata)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		gX1BcXEYant7xoo3okhR();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
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
				Metadata = metadata;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public IExportObject Read()
	{
		//Discarded unreachable code: IL_00a8, IL_00b7, IL_01ed, IL_01f7, IL_02b1, IL_02d0, IL_02df, IL_030c, IL_031b
		int num = 1;
		int num2 = num;
		string assemblyQualifiedName = default(string);
		IEnumerator<IPostEntityXmlSerializer> enumerator = default(IEnumerator<IPostEntityXmlSerializer>);
		IPostEntityXmlSerializer current = default(IPostEntityXmlSerializer);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (assemblyQualifiedName == null)
				{
					num2 = 6;
					break;
				}
				goto case 2;
			case 8:
				NppiZwEYx52ooW8RLcV1(Logger.Log, string.Format((string)ofhww2EYte97hNywjPyx(-210725949 ^ -210398627), jN3ZpcEYwSw2JYqP7fHx(Metadata)));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 4;
				}
				break;
			case 6:
			case 10:
				enumerator = ComponentManager.Current.GetExtensionPoints<IPostEntityXmlSerializer>().GetEnumerator();
				num2 = 9;
				break;
			case 5:
				assemblyQualifiedName = Metadata.GetType().AssemblyQualifiedName;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 7;
				}
				break;
			default:
				serializedMd = ClassSerializationHelper.SerializeObjectByXml(Metadata);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				serializedMd = assemblyQualifiedName + serializedMd;
				num2 = 10;
				break;
			case 1:
				((ILogger)ytda25EYDdmoJKelSAj6()).Info(string.Format((string)ofhww2EYte97hNywjPyx(0x48A7E34A ^ 0x48A2E212), jN3ZpcEYwSw2JYqP7fHx(Metadata)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				serializedMd = (string)iLs22uEY6F84xmkpSrFg(serializedMd, 0, utmeI8EY425ERTvOttK2(serializedMd, ofhww2EYte97hNywjPyx(-281842504 ^ -281861256)) + 1);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return this;
			case 9:
				try
				{
					while (true)
					{
						int num3;
						if (!yZTTrCEYAHt6KidXtvJq(enumerator))
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
							{
								num3 = 1;
							}
							goto IL_01fb;
						}
						goto IL_0268;
						IL_0268:
						current = enumerator.Current;
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
						{
							num3 = 2;
						}
						goto IL_01fb;
						IL_01fb:
						while (true)
						{
							switch (num3)
							{
							case 2:
								serializedMd = (string)w3AGnlEYHLFx3tXKESQ7(current, serializedMd);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
								goto IL_0268;
							case 1:
								goto end_IL_0215;
							}
							break;
						}
						continue;
						end_IL_0215:
						break;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num4 = 1;
						}
						goto IL_02b5;
					}
					goto IL_02ea;
					IL_02ea:
					Kk4GUYEY7XRrFXuVyCak(enumerator);
					num4 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num4 = 0;
					}
					goto IL_02b5;
					IL_02b5:
					switch (num4)
					{
					case 1:
						goto end_IL_0290;
					case 2:
						goto end_IL_0290;
					}
					goto IL_02ea;
					end_IL_0290:;
				}
				goto case 8;
			}
		}
	}

	public DeployLogMessage Write(XmlWriter writer)
	{
		//Discarded unreachable code: IL_00f3, IL_0186, IL_0195, IL_0264, IL_0277, IL_0286, IL_0295, IL_0324
		int num = 3;
		ClassMetadata classMetadata = default(ClassMetadata);
		Dictionary<string, Guid>.Enumerator enumerator = default(Dictionary<string, Guid>.Enumerator);
		KeyValuePair<string, Guid> current = default(KeyValuePair<string, Guid>);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				string text;
				switch (num2)
				{
				default:
					cEXMB1EYMhfV1C56gX4h(writer);
					num2 = 9;
					continue;
				case 1:
					classMetadata = Metadata as ClassMetadata;
					num2 = 6;
					continue;
				case 4:
				case 5:
					writer.WriteCData(serializedMd);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					if (!Ioyid8EY9pDxgNuIh3sQ(sWSgvYEYJW5fW77JbShT(classMetadata)))
					{
						num2 = 14;
						continue;
					}
					goto case 13;
				case 13:
					text = SR.T((string)ofhww2EYte97hNywjPyx(-398663332 ^ -398859468), jN3ZpcEYwSw2JYqP7fHx(Metadata));
					goto IL_0366;
				case 10:
					if (ScriptModules == null)
					{
						num2 = 4;
						continue;
					}
					goto case 11;
				case 2:
					vkbDdNEYmpkEoLyRbufQ(writer, ofhww2EYte97hNywjPyx(-1751176224 ^ -1751147230));
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 7;
					}
					continue;
				case 3:
					NppiZwEYx52ooW8RLcV1(ytda25EYDdmoJKelSAj6(), pYkRKFEY0TCTxM3rOpxO(ofhww2EYte97hNywjPyx(-35995181 ^ -35667917), Metadata.Uid));
					num = 2;
					break;
				case 7:
					try
					{
						while (true)
						{
							IL_0212:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
								{
									num3 = 3;
								}
								goto IL_01a4;
							}
							goto IL_01ef;
							IL_01ef:
							current = enumerator.Current;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
							{
								num3 = 0;
							}
							goto IL_01a4;
							IL_01a4:
							while (true)
							{
								switch (num3)
								{
								case 1:
								{
									C0L6ABEYy5oLHLjTwJhX(writer, current.Key, current.Value.ToString());
									int num4 = 2;
									num3 = num4;
									continue;
								}
								case 2:
									goto IL_0212;
								case 3:
									goto end_IL_0212;
								}
								break;
							}
							goto IL_01ef;
							continue;
							end_IL_0212:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 4;
				case 6:
					if (classMetadata != null)
					{
						num = 12;
						break;
					}
					goto case 13;
				case 8:
					return new DeployLogMessage(DeployLogMessageType.Info, text2, endProcess: false);
				case 11:
					enumerator = ScriptModules.GetEnumerator();
					num2 = 7;
					continue;
				case 9:
					NppiZwEYx52ooW8RLcV1(ytda25EYDdmoJKelSAj6(), pYkRKFEY0TCTxM3rOpxO(ofhww2EYte97hNywjPyx(0x269E5FCA ^ 0x269B5DEC), jN3ZpcEYwSw2JYqP7fHx(Metadata)));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 1;
					}
					continue;
				case 14:
					{
						text = SR.T((string)ofhww2EYte97hNywjPyx(-740338220 ^ -740665476), Metadata.Uid, classMetadata.DisplayName);
						goto IL_0366;
					}
					IL_0366:
					text2 = text;
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	public static string GetViewNamePrefix(ClassMetadata classMetadata)
	{
		//Discarded unreachable code: IL_00a8
		int num = 6;
		int num2 = num;
		IMetadataService service = default(IMetadataService);
		ClassMetadata classMetadata2 = default(ClassMetadata);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 3:
				service = Locator.GetService<IMetadataEditorService>();
				num2 = 2;
				continue;
			default:
				return (string)cIPDrgEYg6D2qhEVSlp2(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463F0DC8), oIhyCkEYrsBIgR2u5iBu(classMetadata2), ofhww2EYte97hNywjPyx(0xE1229CF ^ 0xE124D9F));
			case 6:
				classMetadata2 = classMetadata;
				num2 = 5;
				continue;
			case 4:
				if (Og1dn6EYdP1aDbX3F9TF((EntityMetadata)classMetadata2) == EntityMetadataType.InterfaceExtension)
				{
					num2 = 3;
					continue;
				}
				goto default;
			case 5:
				if (!(classMetadata2 is EntityMetadata))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 4;
			case 2:
				obj = service;
				if (obj == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 1:
				obj = Locator.GetServiceNotNull<IMetadataRuntimeService>();
				break;
			}
			classMetadata2 = (ClassMetadata)((IMetadataService)obj).GetMetadata(wXc7pIEYl3TptLQhOXiW(classMetadata2), loadImplementation: false);
			num2 = 7;
		}
	}

	[IteratorStateMachine(typeof(_003CGetFormExportData_003Ed__18))]
	public IEnumerable<FormExportData> GetFormExportData()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetFormExportData_003Ed__18(-2)
		{
			_003C_003E4__this = this
		};
	}

	internal static bool nfv9aQEY3Cc1SIFhpWp2()
	{
		return a4j40MEYNk0DlbeK2lUl == null;
	}

	internal static MetadataExportObject DaYR0oEYpguvLGgGjZWX()
	{
		return a4j40MEYNk0DlbeK2lUl;
	}

	internal static void gX1BcXEYant7xoo3okhR()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object ytda25EYDdmoJKelSAj6()
	{
		return Logger.Log;
	}

	internal static object ofhww2EYte97hNywjPyx(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Guid jN3ZpcEYwSw2JYqP7fHx(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static int utmeI8EY425ERTvOttK2(object P_0, object P_1)
	{
		return ((string)P_0).IndexOf((string)P_1);
	}

	internal static object iLs22uEY6F84xmkpSrFg(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Remove(P_1, P_2);
	}

	internal static object w3AGnlEYHLFx3tXKESQ7(object P_0, object P_1)
	{
		return ((IPostEntityXmlSerializer)P_0).Replace((string)P_1);
	}

	internal static bool yZTTrCEYAHt6KidXtvJq(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void Kk4GUYEY7XRrFXuVyCak(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void NppiZwEYx52ooW8RLcV1(object P_0, object P_1)
	{
		((ILogger)P_0).Info(P_1);
	}

	internal static object pYkRKFEY0TCTxM3rOpxO(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void vkbDdNEYmpkEoLyRbufQ(object P_0, object P_1)
	{
		((XmlWriter)P_0).WriteStartElement((string)P_1);
	}

	internal static void C0L6ABEYy5oLHLjTwJhX(object P_0, object P_1, object P_2)
	{
		((XmlWriter)P_0).WriteAttributeString((string)P_1, (string)P_2);
	}

	internal static void cEXMB1EYMhfV1C56gX4h(object P_0)
	{
		((XmlWriter)P_0).WriteEndElement();
	}

	internal static object sWSgvYEYJW5fW77JbShT(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static bool Ioyid8EY9pDxgNuIh3sQ(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static EntityMetadataType Og1dn6EYdP1aDbX3F9TF(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static Guid wXc7pIEYl3TptLQhOXiW(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static object oIhyCkEYrsBIgR2u5iBu(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object cIPDrgEYg6D2qhEVSlp2(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}
}
