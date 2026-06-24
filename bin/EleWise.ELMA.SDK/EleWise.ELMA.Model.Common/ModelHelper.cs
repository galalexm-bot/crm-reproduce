using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.References;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Common;

public static class ModelHelper
{
	private class FullNamespaceLocalizer : SR.ILocalizer
	{
		private readonly object ns;

		internal static object cqfVfKvhBjMt5WifJmxn;

		public FullNamespaceLocalizer(string ns)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
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
					this.ns = ns;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public string Localize()
		{
			return GetNamespace(ns, (string _, string nsItemDisplayName) => nsItemDisplayName);
		}

		internal static bool k1dSi2vhWLjkbkt04q2F()
		{
			return cqfVfKvhBjMt5WifJmxn == null;
		}

		internal static FullNamespaceLocalizer PIrDkMvholFv2rgLZtMI()
		{
			return (FullNamespaceLocalizer)cqfVfKvhBjMt5WifJmxn;
		}
	}

	private class NamespacePartLocalizer : SR.ILocalizer
	{
		private readonly object nsMetadata;

		private readonly object nsInfo;

		private readonly object nsPart;

		private static object xeMswNvhbf8HuNWPRack;

		public NamespacePartLocalizer(string ns)
		{
			//Discarded unreachable code: IL_0043
			mlRmZVvhEEFpL7538fvc();
			_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
			CS_0024_003C_003E8__locals0.ns = ns;
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 3:
					nsPart = EEEDfcvhvl9USiWsDxn1(CS_0024_003C_003E8__locals0.ns, hT6NdCvhCXKZk3RfcMt9(CS_0024_003C_003E8__locals0.ns, '.') + 1);
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				case 1:
				{
					nsMetadata = ((IMetadataService)UxZAPOvhfWeoCEr2e2ju())?.GetMetadataList().OfType<NamespaceMetadata>().FirstOrDefault((NamespaceMetadata m) => _003C_003Ec__DisplayClass3_0.j5JxEYZqREQyWEJFRsIH(_003C_003Ec__DisplayClass3_0.JUenP0Zqibb9goXlEmcZ(m), CS_0024_003C_003E8__locals0.ns));
					int num2 = 2;
					num = num2;
					break;
				}
				case 2:
					nsInfo = ((((NamedMetadata)nsMetadata)?.DisplayName == null) ? ((ComponentManager)E9UtCdvhQ8fZZIYii3AH()).GetExtensionPoints<INamespaceInfo>().FirstOrDefault((INamespaceInfo ni) => _003C_003Ec__DisplayClass3_0.j5JxEYZqREQyWEJFRsIH(ni.Namespace, CS_0024_003C_003E8__locals0.ns)) : null);
					num = 3;
					break;
				}
			}
		}

		public string Localize()
		{
			int num = 4;
			int num2 = num;
			object obj;
			while (true)
			{
				switch (num2)
				{
				case 4:
				{
					object obj3 = nsMetadata;
					if (obj3 == null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					obj = ((NamedMetadata)obj3).DisplayName;
					goto IL_0062;
				}
				case 3:
					obj = null;
					goto IL_0062;
				case 1:
				{
					object obj2 = nsInfo;
					if (obj2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = egrRLlvh8Y0BQUlbpMvJ(obj2);
					goto IL_00bf;
				}
				default:
					obj = null;
					goto IL_00bf;
				case 2:
					{
						obj = nsPart;
						break;
					}
					IL_00bf:
					if (obj != null)
					{
						break;
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 2;
					}
					continue;
					IL_0062:
					if (obj != null)
					{
						break;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			return (string)obj;
		}

		internal static void mlRmZVvhEEFpL7538fvc()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object UxZAPOvhfWeoCEr2e2ju()
		{
			return MetadataServiceContext.ServiceOrNull;
		}

		internal static object E9UtCdvhQ8fZZIYii3AH()
		{
			return ComponentManager.Current;
		}

		internal static int hT6NdCvhCXKZk3RfcMt9(object P_0, char P_1)
		{
			return ((string)P_0).LastIndexOf(P_1);
		}

		internal static object EEEDfcvhvl9USiWsDxn1(object P_0, int P_1)
		{
			return ((string)P_0).Substring(P_1);
		}

		internal static bool w1q5RNvhhblw3ImTiuNL()
		{
			return xeMswNvhbf8HuNWPRack == null;
		}

		internal static NamespacePartLocalizer c4Da46vhGkZNKew0RihR()
		{
			return (NamespacePartLocalizer)xeMswNvhbf8HuNWPRack;
		}

		internal static object egrRLlvh8Y0BQUlbpMvJ(object P_0)
		{
			return ((INamespaceInfo)P_0).DisplayName;
		}
	}

	public const string FIELD_ENTITY_NAME = "_Name";

	public const string FIELD_ENTITY_SELECTOR = "_Selector";

	private static readonly Dictionary<string, SR.LocalizableString> loadedFullNamespaces;

	private static readonly Dictionary<string, string> loadedShortNamespaces;

	private static readonly Dictionary<string, SR.LocalizableString> loadedNamespaces;

	private static Func<Type, IEntityManager> getEntityManagerCached;

	internal static ModelHelper KI2iKrhXSKKubdRfk8gZ;

	public static string GetTypeAndSubTypeWithDelimeterString(this ReferenceOnType reference, string delimeter = ";")
	{
		return string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643687857), reference.TypeUid, delimeter, reference.SubTypeUid);
	}

	public static ITypeDescriptor GetTypeDescriptor(this ReferenceOnType reference, bool includeSubTypes = true)
	{
		//Discarded unreachable code: IL_00ba, IL_00c9, IL_00d4, IL_014c, IL_015b, IL_016b, IL_01e3, IL_0202, IL_0211, IL_023e, IL_0252, IL_02ad
		int num = 4;
		int num2 = num;
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		IEnumerator<ITypeDescriptor> enumerator = default(IEnumerator<ITypeDescriptor>);
		ITypeDescriptor result = default(ITypeDescriptor);
		ITypeDescriptor typeDescriptor2 = default(ITypeDescriptor);
		ITypeDescriptor current = default(ITypeDescriptor);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 4:
				if (reference != null)
				{
					num2 = 3;
					break;
				}
				goto IL_0057;
			case 6:
				return typeDescriptor;
			case 8:
				if (fwnJ6HhXK2aZUKrgw2FN(NIJYkmhXXVCmJNhJlfOF(reference), Guid.Empty))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					break;
				}
				num3 = 0;
				goto IL_02e7;
			default:
				enumerator = typeDescriptor.GetSubTypes(null).GetEnumerator();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				try
				{
					while (true)
					{
						int num4;
						if (!IISjOkhXkKCyPJnXCps1(enumerator))
						{
							num4 = 5;
							goto IL_00d8;
						}
						goto IL_0175;
						IL_00d8:
						while (true)
						{
							switch (num4)
							{
							case 5:
								return typeDescriptor;
							case 4:
								return result;
							case 6:
								if (typeDescriptor2 == null)
								{
									num4 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
									{
										num4 = 2;
									}
									continue;
								}
								goto case 7;
							case 7:
								result = typeDescriptor2;
								num4 = 4;
								continue;
							case 1:
								goto IL_0175;
							case 3:
								typeDescriptor2 = FindSubTypes(Cl3IHvhXquP38jpwJT9n(reference), NIJYkmhXXVCmJNhJlfOF(reference), current.GetSubTypes(null));
								num4 = 6;
								continue;
							}
							break;
						}
						continue;
						IL_0175:
						current = enumerator.Current;
						num4 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num4 = 0;
						}
						goto IL_00d8;
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num5 = 0;
						}
						goto IL_01e7;
					}
					goto IL_021c;
					IL_021c:
					ilquUJhXn3sqYSHLmncf(enumerator);
					num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num5 = 2;
					}
					goto IL_01e7;
					IL_01e7:
					switch (num5)
					{
					default:
						goto end_IL_01c2;
					case 0:
						goto end_IL_01c2;
					case 1:
						break;
					case 2:
						goto end_IL_01c2;
					}
					goto IL_021c;
					end_IL_01c2:;
				}
			case 2:
				num3 = ((typeDescriptor != null) ? 1 : 0);
				goto IL_02e7;
			case 7:
				if (fwnJ6HhXK2aZUKrgw2FN(NIJYkmhXXVCmJNhJlfOF(reference), Guid.Empty))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_0057;
			case 1:
			case 9:
				typeDescriptor = (ITypeDescriptor)LXPt6mhXTvfehNMKig7F(MetadataServiceContext.MetadataRuntimeService, Cl3IHvhXquP38jpwJT9n(reference), NIJYkmhXXVCmJNhJlfOF(reference));
				num2 = 8;
				break;
			case 3:
				{
					if (fwnJ6HhXK2aZUKrgw2FN(Cl3IHvhXquP38jpwJT9n(reference), Guid.Empty))
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 9;
						}
						break;
					}
					goto case 7;
				}
				IL_0057:
				return null;
				IL_02e7:
				if (((uint)num3 & (includeSubTypes ? 1u : 0u)) != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			}
		}
	}

	private static ITypeDescriptor FindSubTypes(Guid uid, Guid subTypeUid, IEnumerable<ITypeDescriptor> subTypes)
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals0.uid = uid;
		CS_0024_003C_003E8__locals0.subTypeUid = subTypeUid;
		if (subTypes != null)
		{
			ITypeDescriptor typeDescriptor = subTypes.FirstOrDefault(delegate(ITypeDescriptor t)
			{
				int num = 2;
				int num2 = num;
				Guid guid = default(Guid);
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (!guid.Equals(CS_0024_003C_003E8__locals0.uid))
						{
							return false;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
						{
							num2 = 0;
						}
						break;
					default:
						guid = _003C_003Ec__DisplayClass2_0.iDpAwkvhidPfs5xtLo2K(t);
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						return guid.Equals(CS_0024_003C_003E8__locals0.subTypeUid);
					case 2:
						guid = _003C_003Ec__DisplayClass2_0.CKTvj9vhSWXDakYJnXvv(t);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			});
			if (typeDescriptor != null)
			{
				return typeDescriptor;
			}
			foreach (ITypeDescriptor item in subTypes.Where((ITypeDescriptor t) => _003C_003Ec.OvtKgLvhT3yQ1aw0Qnow(t)))
			{
				ITypeDescriptor typeDescriptor2 = FindSubTypes(CS_0024_003C_003E8__locals0.uid, CS_0024_003C_003E8__locals0.subTypeUid, item.GetSubTypes(null));
				if (typeDescriptor2 != null)
				{
					return typeDescriptor2;
				}
			}
		}
		return null;
	}

	public static TypeHeaderInfo GetTypeInfoByTypeOrNull(Type type, bool loadImplementation = false)
	{
		//Discarded unreachable code: IL_028b, IL_029a, IL_02aa, IL_02dd, IL_02ec, IL_04e8, IL_055a, IL_05c3, IL_0627, IL_069c, IL_0736, IL_0782, IL_07a4, IL_07da, IL_07e9, IL_07f8, IL_0807, IL_08a9, IL_0905, IL_0914, IL_0924, IL_0954, IL_0963, IL_0972, IL_0a75, IL_0ac3, IL_0ad2, IL_0b06, IL_0bd0, IL_0bdf, IL_0c23, IL_0c82, IL_0d24, IL_0d7b, IL_0d8a, IL_0de8, IL_0df7, IL_0e17
		int num = 62;
		Type type3 = default(Type);
		TypeHeaderInfo typeHeaderInfo = default(TypeHeaderInfo);
		ActionSettings actionSettings = default(ActionSettings);
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		Type type2 = default(Type);
		IMetadataService metadataService = default(IMetadataService);
		Type type5 = default(Type);
		Type[] genericArguments = default(Type[]);
		IMetadataService serviceOrNull = default(IMetadataService);
		ImplementationUidAttribute attribute2 = default(ImplementationUidAttribute);
		Type type4 = default(Type);
		PropertySignature propertySignature = default(PropertySignature);
		ITypeDescriptor typeDescriptor2 = default(ITypeDescriptor);
		IMetadataService serviceOrNull2 = default(IMetadataService);
		UidAttribute attribute3 = default(UidAttribute);
		ITypeDescriptor typeDescriptor3 = default(ITypeDescriptor);
		UidAttribute attribute = default(UidAttribute);
		ImplementationUidAttribute attribute4 = default(ImplementationUidAttribute);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 116:
					if (xY4gVbhXp8dO8XLCgQ8m(type3, null))
					{
						num = 60;
						break;
					}
					goto case 34;
				case 4:
				{
					TypeHeaderInfo typeHeaderInfo2 = typeHeaderInfo;
					DataClassSettings dataClassSettings = new DataClassSettings();
					UJDxlYhX60cCtCOt5Tfq(dataClassSettings, RelationType.OneToMany);
					tRWLAMhXwGdy2bpbYZvp(typeHeaderInfo2, dataClassSettings);
					num2 = 67;
					continue;
				}
				case 60:
					type3 = type;
					num2 = 34;
					continue;
				case 103:
				case 111:
					if (qDpVfMhXx5JKxQJXnwrb(type))
					{
						num2 = 16;
						continue;
					}
					goto case 35;
				case 33:
					if (!xY4gVbhXp8dO8XLCgQ8m(type.GetGenericTypeDefinition(), LqAwZthXOJ2MuuuG2isf(typeof(Nullable<>).TypeHandle)))
					{
						num2 = 103;
						continue;
					}
					goto case 98;
				case 35:
					if (!XDJ6BuhXLmeMNscpYLvx())
					{
						num2 = 64;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
						{
							num2 = 119;
						}
						continue;
					}
					goto case 24;
				case 13:
					tRWLAMhXwGdy2bpbYZvp(typeHeaderInfo, actionSettings);
					num2 = 97;
					continue;
				case 47:
					return typeHeaderInfo;
				case 92:
					if (typeDescriptor == null)
					{
						num2 = 7;
						continue;
					}
					goto case 10;
				case 75:
					GcTMTohXeugv0IGOmUVD(typeHeaderInfo, DataClassDescriptor.UID);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 29;
					}
					continue;
				case 50:
				case 71:
					if (qWivlIhXzvZyU75MRD63(typeDescriptor))
					{
						num2 = 14;
						continue;
					}
					goto case 27;
				case 29:
					typeHeaderInfo.SubTypeUid = VWqCtthX4InYDPFoi5mw(type2);
					num2 = 4;
					continue;
				case 27:
				case 51:
				case 65:
				case 67:
				case 68:
				case 77:
				case 86:
				case 89:
				case 94:
				case 97:
				case 106:
				case 109:
				case 119:
					return typeHeaderInfo;
				case 8:
					if (xY4gVbhXp8dO8XLCgQ8m(type, LqAwZthXOJ2MuuuG2isf(typeof(object).TypeHandle)))
					{
						num2 = 36;
						continue;
					}
					typeDescriptor = (ITypeDescriptor)MXiFEvhXD2hjJdq1gPma(metadataService, type);
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 92;
					}
					continue;
				case 44:
					if (type2.IsEnum)
					{
						num = 113;
						break;
					}
					goto case 25;
				case 102:
					return typeHeaderInfo;
				case 85:
				case 104:
					type5 = genericArguments[0];
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 18;
					}
					continue;
				case 24:
					metadataService = (IMetadataService)TvBv2PhXUfOSMwXvFjNt();
					num2 = 53;
					continue;
				case 10:
					GcTMTohXeugv0IGOmUVD(typeHeaderInfo, cAAs4KhXtfGPJa9lnHVQ(typeDescriptor));
					num2 = 42;
					continue;
				case 96:
					GcTMTohXeugv0IGOmUVD(typeHeaderInfo, ListOfSimpleTypeDescriptor.UID);
					num2 = 30;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 5;
					}
					continue;
				case 117:
					if (type.IsInterface)
					{
						num2 = 107;
						continue;
					}
					goto case 78;
				case 53:
					if (metadataService != null)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 27;
				case 23:
					serviceOrNull = MetadataServiceContext.ServiceOrNull;
					num2 = 79;
					continue;
				case 48:
					attribute2 = AttributeHelper<ImplementationUidAttribute>.GetAttribute(type2, inherited: true);
					num2 = 41;
					continue;
				case 52:
					type = type.GetGenericArguments()[0];
					num2 = 70;
					continue;
				case 121:
					return typeHeaderInfo;
				case 2:
					if (KSJpbChXmTFdKvlJjEJE(type4, actionSettings))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num2 = 104;
						}
						continue;
					}
					goto case 102;
				case 40:
					if (!xY4gVbhXp8dO8XLCgQ8m(type.GetGenericTypeDefinition(), typeof(ICollection<>)))
					{
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 63;
						}
						continue;
					}
					goto case 69;
				case 42:
					if (!IiSau9hX2d1jtaCyZLq1(typeDescriptor.SettingsType, null))
					{
						num2 = 50;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 108;
				case 12:
					if (type.GetGenericArguments().Length == 1)
					{
						num2 = 40;
						continue;
					}
					goto case 59;
				case 70:
					typeHeaderInfo.TypeUid = EnumDescriptor.UID;
					num2 = 26;
					continue;
				case 3:
				case 7:
					if (TypeOf<IDataClass>.Raw.IsAssignableFrom(type))
					{
						num2 = 59;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 66;
						}
						continue;
					}
					goto case 27;
				case 26:
					qPs4HIhX1HRCevNe4Cbt(typeHeaderInfo, y8yskkhXA7NaX52bobAJ(type));
					num2 = 114;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 67;
					}
					continue;
				case 6:
				case 107:
					if (!IiSau9hX2d1jtaCyZLq1(type.GetInterface(LqAwZthXOJ2MuuuG2isf(typeof(IEntity).TypeHandle).FullName), null))
					{
						num2 = 78;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 38;
						}
						continue;
					}
					goto case 122;
				case 83:
					if (!loadImplementation)
					{
						num = 76;
						break;
					}
					goto case 87;
				case 91:
					qb1GT6hXY57G3dPRxdia(actionSettings, GCZZCOhXjXfsOF5iJjav(propertySignature));
					num2 = 58;
					continue;
				case 95:
					tRWLAMhXwGdy2bpbYZvp(typeHeaderInfo, new ListOfSimpleTypeSettings
					{
						SimpleTypeUid = cAAs4KhXtfGPJa9lnHVQ(typeDescriptor2)
					});
					num = 68;
					break;
				case 19:
					tRWLAMhXwGdy2bpbYZvp(typeHeaderInfo, new DataClassSettings
					{
						RelationType = RelationType.OneToOne
					});
					num2 = 86;
					continue;
				case 98:
					if (type.GetGenericArguments()[0].IsEnum)
					{
						num = 52;
						break;
					}
					goto case 103;
				case 31:
					if (serviceOrNull2 == null)
					{
						num2 = 109;
						continue;
					}
					goto case 20;
				case 114:
					tRWLAMhXwGdy2bpbYZvp(typeHeaderInfo, new EnumSettings());
					num2 = 22;
					continue;
				case 25:
					if (rbMJNrhXa8hmQGhSafVR(type2))
					{
						num2 = 96;
						continue;
					}
					goto case 38;
				case 93:
					return typeHeaderInfo;
				case 1:
				case 76:
					attribute3 = AttributeHelper<UidAttribute>.GetAttribute(type, inherited: true);
					num2 = 43;
					continue;
				case 30:
					serviceOrNull2 = MetadataServiceContext.ServiceOrNull;
					num2 = 31;
					continue;
				case 21:
					GcTMTohXeugv0IGOmUVD(typeHeaderInfo, EnumDescriptor.UID);
					num2 = 74;
					continue;
				case 49:
					qPs4HIhX1HRCevNe4Cbt(typeHeaderInfo, VWqCtthX4InYDPFoi5mw(type));
					num = 19;
					break;
				case 55:
				{
					TypeHeaderInfo typeHeaderInfo5 = typeHeaderInfo;
					ListOfSimpleTypeSettings listOfSimpleTypeSettings = new ListOfSimpleTypeSettings();
					Q6KxpuhXH9eqTA6xDxTF(listOfSimpleTypeSettings, cAAs4KhXtfGPJa9lnHVQ(typeDescriptor3));
					typeHeaderInfo5.Settings = listOfSimpleTypeSettings;
					num2 = 77;
					continue;
				}
				case 101:
					tRWLAMhXwGdy2bpbYZvp(typeHeaderInfo, new AnyTypeSettings
					{
						FullTypeName = type.FullName
					});
					num2 = 93;
					continue;
				case 17:
				case 37:
				case 90:
					if (!type.IsEnum)
					{
						num2 = 80;
						continue;
					}
					goto case 21;
				default:
				{
					TypeHeaderInfo typeHeaderInfo4 = typeHeaderInfo;
					EntitySettings entitySettings2 = new EntitySettings();
					b1VU3ZhX38N5DdSsPGn9(entitySettings2, RelationType.OneToOne);
					typeHeaderInfo4.Settings = entitySettings2;
					num2 = 94;
					continue;
				}
				case 82:
					typeHeaderInfo.TypeUid = ListOfSimpleTypeDescriptor.UID;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 23;
					}
					continue;
				case 100:
					typeHeaderInfo.Settings = new EnumSettings();
					num2 = 118;
					continue;
				case 62:
					typeHeaderInfo = new TypeHeaderInfo();
					num2 = 61;
					continue;
				case 64:
					if (typeDescriptor3 == null)
					{
						num2 = 89;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
						{
							num2 = 56;
						}
						continue;
					}
					goto case 55;
				case 58:
					GcTMTohXeugv0IGOmUVD(typeHeaderInfo, ActionDescriptor.UID);
					num2 = 13;
					continue;
				case 115:
					if (!xY4gVbhXp8dO8XLCgQ8m(type.GetGenericTypeDefinition(), LqAwZthXOJ2MuuuG2isf(typeof(IEnumerable<>).TypeHandle)))
					{
						num2 = 90;
						continue;
					}
					goto case 88;
				case 22:
					Ca2hvKhX7MrMXZn0mKov(typeHeaderInfo, true);
					num2 = 50;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 65;
					}
					continue;
				case 99:
					typeDescriptor3 = (ITypeDescriptor)MXiFEvhXD2hjJdq1gPma(serviceOrNull, type.GetGenericArguments()[0]);
					num2 = 57;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 64;
					}
					continue;
				case 61:
					if (type.IsClass)
					{
						num2 = 6;
						continue;
					}
					goto case 117;
				case 81:
				case 120:
				{
					TypeHeaderInfo typeHeaderInfo3 = typeHeaderInfo;
					EntitySettings entitySettings = new EntitySettings();
					b1VU3ZhX38N5DdSsPGn9(entitySettings, RelationType.OneToMany);
					typeHeaderInfo3.Settings = entitySettings;
					num2 = 27;
					continue;
				}
				case 72:
					if (genericArguments.Length > 2)
					{
						num2 = 5;
						continue;
					}
					actionSettings = new ActionSettings();
					num2 = 28;
					continue;
				case 39:
				case 57:
					GcTMTohXeugv0IGOmUVD(typeHeaderInfo, EntityDescriptor.UID);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 45;
					}
					continue;
				case 112:
					if (type.IsInterface)
					{
						num2 = 90;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 105;
						}
						continue;
					}
					goto case 59;
				case 18:
					if (!MrrJ0ihX0wSDlx2ROuSU(type5))
					{
						PropertyMetadata propertyMetadata = new PropertyMetadata();
						TypeHeaderInfo typeInfoByTypeOrNull = GetTypeInfoByTypeOrNull(type5);
						LcYc2hhXMGqxmuUWJvGC(propertyMetadata, khxIG2hXyRwIe00u3VE1(typeInfoByTypeOrNull));
						oXVAxthX9VE49EHDtjiq(propertyMetadata, rnL6RyhXJDup3U0EZOKl(typeInfoByTypeOrNull));
						iw6FfGhXlukIc96OVHbR(propertyMetadata, DQP8GqhXd6nXJ0EvRu7M(typeInfoByTypeOrNull));
						vTAGd0hXgsgGq32Z2QKO(propertyMetadata, D4eIqfhXro9a0Vf9iKJg(typeInfoByTypeOrNull));
						propertySignature = (PropertySignature)qHQ3WjhX5bugmGJUrXMQ(propertyMetadata);
						num2 = 91;
					}
					else
					{
						num2 = 46;
					}
					continue;
				case 9:
					attribute = AttributeHelper<UidAttribute>.GetAttribute(type2, inherited: true);
					num2 = 15;
					continue;
				case 45:
					if (loadImplementation)
					{
						num2 = 48;
						continue;
					}
					goto case 9;
				case 59:
				case 63:
					if (!type.IsGenericType)
					{
						num2 = 37;
						continue;
					}
					goto case 115;
				case 54:
					if (typeDescriptor2 != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num2 = 95;
						}
						continue;
					}
					goto case 27;
				case 122:
					GcTMTohXeugv0IGOmUVD(typeHeaderInfo, EntityDescriptor.UID);
					num2 = 83;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 1;
					}
					continue;
				case 108:
					tRWLAMhXwGdy2bpbYZvp(typeHeaderInfo, (TypeSettings)HVgy9thXctKpv8brlHfb(JVujI9hXst7XoY98RxtP(typeDescriptor)));
					num2 = 71;
					continue;
				case 5:
					return typeHeaderInfo;
				case 118:
					Ca2hvKhX7MrMXZn0mKov(typeHeaderInfo, false);
					num2 = 106;
					continue;
				case 74:
					qPs4HIhX1HRCevNe4Cbt(typeHeaderInfo, y8yskkhXA7NaX52bobAJ(type));
					num2 = 100;
					continue;
				case 32:
				case 80:
					if (type.GetGenericArguments().Length == 1)
					{
						num2 = 33;
						continue;
					}
					goto case 103;
				case 46:
					if (!KSJpbChXmTFdKvlJjEJE(type5, actionSettings))
					{
						num = 47;
						break;
					}
					goto case 58;
				case 28:
					if (genericArguments.Length != 2)
					{
						num2 = 85;
						continue;
					}
					goto case 56;
				case 20:
					typeDescriptor2 = (ITypeDescriptor)MXiFEvhXD2hjJdq1gPma(serviceOrNull2, type2);
					num2 = 54;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 42;
					}
					continue;
				case 78:
				case 110:
					if (!type.IsClass)
					{
						num2 = 112;
						continue;
					}
					goto case 105;
				case 84:
					if (MrrJ0ihX0wSDlx2ROuSU(type4))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 121;
				case 88:
					if (rbMJNrhXa8hmQGhSafVR(type.GetGenericArguments()[0]))
					{
						num2 = 82;
						continue;
					}
					goto case 17;
				case 36:
					GcTMTohXeugv0IGOmUVD(typeHeaderInfo, AnyTypeDescriptor.UID);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 101;
					}
					continue;
				case 34:
					type2 = type3.GetGenericArguments()[0];
					num2 = 44;
					continue;
				case 66:
					GcTMTohXeugv0IGOmUVD(typeHeaderInfo, DataClassDescriptor.UID);
					num2 = 49;
					continue;
				case 87:
					attribute4 = AttributeHelper<ImplementationUidAttribute>.GetAttribute(type, inherited: true);
					num = 11;
					break;
				case 69:
					type3 = type.GetInterface(typeof(ICollection<>).FullName);
					num2 = 116;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 110;
					}
					continue;
				case 38:
				case 113:
					if (!TypeOf<IDataClass>.Raw.IsAssignableFrom(type2))
					{
						num2 = 57;
						continue;
					}
					goto case 75;
				case 16:
					genericArguments = type.GetGenericArguments();
					num2 = 72;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 62;
					}
					continue;
				case 79:
					if (serviceOrNull != null)
					{
						num2 = 99;
						continue;
					}
					goto case 27;
				case 56:
					type4 = genericArguments[1];
					num2 = 84;
					continue;
				case 105:
					if (!(type.GetInterface(LqAwZthXOJ2MuuuG2isf(typeof(ICollection<>).TypeHandle).FullName) != null))
					{
						num2 = 12;
						continue;
					}
					goto case 69;
				case 11:
					qPs4HIhX1HRCevNe4Cbt(typeHeaderInfo, (attribute4 != null) ? YnVTj6hXPSgrLchJ3PTw(attribute4) : Guid.Empty);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 0;
					}
					continue;
				case 43:
					qPs4HIhX1HRCevNe4Cbt(typeHeaderInfo, (attribute3 != null) ? uMKVBvhXN2OeHP0Rpcql(attribute3) : Guid.Empty);
					num2 = 73;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 25;
					}
					continue;
				case 41:
					qPs4HIhX1HRCevNe4Cbt(typeHeaderInfo, (attribute2 != null) ? YnVTj6hXPSgrLchJ3PTw(attribute2) : Guid.Empty);
					num2 = 120;
					continue;
				case 15:
					typeHeaderInfo.SubTypeUid = ((attribute != null) ? uMKVBvhXN2OeHP0Rpcql(attribute) : Guid.Empty);
					num = 81;
					break;
				case 14:
					typeHeaderInfo.Nullable = type.GetGenericArguments().Length == 1 && xY4gVbhXp8dO8XLCgQ8m(type.GetGenericTypeDefinition(), typeof(Nullable<>));
					num2 = 51;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	private static bool CheckSimpleType(Type type)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_009c, IL_00ab
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (type.IsPrimitive)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			default:
				if (!(type == LqAwZthXOJ2MuuuG2isf(typeof(string).TypeHandle)))
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 3:
				return type.IsValueType;
			case 1:
				return true;
			case 4:
				return false;
			case 5:
				if (!IiSau9hX2d1jtaCyZLq1(type, typeof(object)))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto default;
			}
		}
	}

	private static bool ProcessReturnType(Type argument, object settings)
	{
		//Discarded unreachable code: IL_011a, IL_0129, IL_0210, IL_021f
		int num = 5;
		int num2 = num;
		Type[] genericArguments = default(Type[]);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		TypeHeaderInfo typeInfoByTypeOrNull = default(TypeHeaderInfo);
		PropertySignature propertySignature = default(PropertySignature);
		while (true)
		{
			switch (num2)
			{
			case 14:
				return false;
			case 6:
			{
				Type type = genericArguments[0];
				propertyMetadata = new PropertyMetadata();
				typeInfoByTypeOrNull = GetTypeInfoByTypeOrNull(type);
				num2 = 8;
				break;
			}
			case 8:
				LcYc2hhXMGqxmuUWJvGC(propertyMetadata, khxIG2hXyRwIe00u3VE1(typeInfoByTypeOrNull));
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 2;
				}
				break;
			case 9:
				ABaYPDhTodXD5fYiHiIQ(settings, propertySignature.Type);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if (!(argument.GetGenericTypeDefinition() != cgVWufhTWufCIiFmDaUy(TypeOf.Task1)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 10;
			case 16:
				propertySignature = propertyMetadata.CreatePropertySignature();
				num2 = 9;
				break;
			case 4:
				return false;
			case 5:
				if (!(KQxjXEhTBp2MC1fqhdGE(bhDWpXhTF2KLeBWh3sJy(settings)) != Guid.Empty))
				{
					if (!xY4gVbhXp8dO8XLCgQ8m(argument, TypeOf<Task>.Raw))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 11;
						}
						break;
					}
					goto case 13;
				}
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 0;
				}
				break;
			default:
				iw6FfGhXlukIc96OVHbR(propertyMetadata, DQP8GqhXd6nXJ0EvRu7M(typeInfoByTypeOrNull));
				num2 = 12;
				break;
			case 10:
				return false;
			case 2:
				genericArguments = argument.GetGenericArguments();
				num2 = 15;
				break;
			case 12:
				vTAGd0hXgsgGq32Z2QKO(propertyMetadata, typeInfoByTypeOrNull.Nullable);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 16;
				}
				break;
			case 15:
				if (genericArguments.Length <= 1)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 14;
			case 1:
				return true;
			case 13:
				return true;
			case 11:
				if (argument.IsGenericType)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 10;
			case 7:
				oXVAxthX9VE49EHDtjiq(propertyMetadata, rnL6RyhXJDup3U0EZOKl(typeInfoByTypeOrNull));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static string GetTypeAndSubTypeWithDelimeterString(this ITypeDescriptor desc, string delimeter = ";")
	{
		return (string)plgOl2hThQT92CWElodc(YONCx4hTbqrRGf6T5K3L(0x76DD48E ^ 0x76F5738), cAAs4KhXtfGPJa9lnHVQ(desc), delimeter, desc.SubTypeUid);
	}

	public static bool IsCLRTypeDescriptor(this ITypeDescriptor descriptor)
	{
		//Discarded unreachable code: IL_00f9, IL_0108, IL_0118, IL_0127, IL_014d, IL_015c, IL_019e
		int num = 6;
		Type type3 = default(Type);
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Type type2;
				switch (num2)
				{
				case 6:
					VZrPVhhTGPywUo0651M6(descriptor, YONCx4hTbqrRGf6T5K3L(-521266112 ^ -521245046));
					num2 = 5;
					continue;
				case 8:
					if (xY4gVbhXp8dO8XLCgQ8m(LqAwZthXOJ2MuuuG2isf(typeof(CLRTypeDescriptor<>).TypeHandle), type3))
					{
						num2 = 3;
						continue;
					}
					type = type.BaseType;
					num2 = 10;
					continue;
				case 3:
					return true;
				case 10:
				case 11:
					if (IiSau9hX2d1jtaCyZLq1(type, null))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 1;
				default:
					if (type.IsGenericType)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 7;
				case 5:
					goto end_IL_0012;
				case 4:
					if (type != LqAwZthXOJ2MuuuG2isf(typeof(object).TypeHandle))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 7:
					type2 = type;
					break;
				case 1:
					return false;
				case 9:
					type2 = type.GetGenericTypeDefinition();
					break;
				}
				type3 = type2;
				num2 = 8;
				continue;
				end_IL_0012:
				break;
			}
			type = descriptor.GetType();
			num = 11;
		}
	}

	public static (Guid, Guid) GetTypeAndSubTypeFromStringWithDelimeter(string typeUidSubTypeUidString, string delimeter = ";")
	{
		string[] array = typeUidSubTypeUidString.Split(delimeter.ToCharArray());
		if (array != null && array.Count() == 2 && Guid.TryParse(array[0], out var result) && Guid.TryParse(array[1], out var result2))
		{
			return (result, result2);
		}
		return (Guid.Empty, Guid.Empty);
	}

	public static IEnumerable<SelectListItem> GetEnumItems(ViewDataDictionary viewData)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		ModelMetadata modelMetadata = viewData.get_ModelMetadata();
		if (((modelMetadata != null) ? modelMetadata.get_ModelType() : null) == null)
		{
			SelectListItem[] array = new SelectListItem[1];
			SelectListItem val = new SelectListItem();
			val.set_Value(string.Empty);
			val.set_Text(string.Empty);
			val.set_Selected(viewData.get_Model() == null);
			array[0] = val;
			return (IEnumerable<SelectListItem>)(object)array;
		}
		return GetEnumItems(viewData, viewData.get_ModelMetadata().get_ModelType());
	}

	[IteratorStateMachine(typeof(_003CGetEnumItems_003Ed__10))]
	public static IEnumerable<SelectListItem> GetEnumItems(ViewDataDictionary viewData, Type type)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetEnumItems_003Ed__10(-2)
		{
			_003C_003E3__viewData = viewData,
			_003C_003E3__type = type
		};
	}

	public static string GetEnumDisplayName(object value)
	{
		//Discarded unreachable code: IL_0049, IL_0058, IL_011b
		int num = 9;
		int num2 = num;
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		EnumValueMetadata enumValueMetadata = default(EnumValueMetadata);
		EnumMetadata enumMetadata = default(EnumMetadata);
		while (true)
		{
			switch (num2)
			{
			case 9:
				_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
				num2 = 8;
				break;
			case 8:
				_003C_003Ec__DisplayClass11_.value = value;
				num2 = 2;
				break;
			case 3:
				return "";
			case 6:
				return "";
			case 1:
				if (enumValueMetadata != null)
				{
					return (string)E4YwYKhTEgxOVwrIQ7Jx(enumValueMetadata);
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				if (_003C_003Ec__DisplayClass11_.value != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 7:
				enumValueMetadata = enumMetadata.Values.FirstOrDefault(_003C_003Ec__DisplayClass11_._003CGetEnumDisplayName_003Eb__0);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				return string.Empty;
			default:
				enumMetadata = MetadataLoader.LoadMetadata(_003C_003Ec__DisplayClass11_.value.GetType()) as EnumMetadata;
				num2 = 4;
				break;
			case 4:
				if (enumMetadata == null)
				{
					num2 = 6;
					break;
				}
				goto case 7;
			}
		}
	}

	public static object GetEnumValue(Type enumType, Guid uid)
	{
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		EnumValueMetadata enumValueMetadata = default(EnumValueMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return null;
			case 4:
				_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
				num2 = 3;
				break;
			default:
				enumValueMetadata = ((EnumMetadata)MetadataLoader.LoadMetadata(enumType)).Values.FirstOrDefault(_003C_003Ec__DisplayClass12_._003CGetEnumValue_003Eb__0);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (enumValueMetadata != null)
				{
					return enumValueMetadata.EnumValue;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass12_.uid = uid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static object GetEnumValue([NotNull] Type enumType, [NotNull] string valueName)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_0064, IL_0073
		int num = 8;
		EnumValueMetadata enumValueMetadata = default(EnumValueMetadata);
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (enumValueMetadata != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 1;
				case 3:
					throw new ArgumentNullException((string)YONCx4hTbqrRGf6T5K3L(0x63ABA4E8 ^ 0x63A8EEAA));
				case 7:
					_003C_003Ec__DisplayClass13_.valueName = valueName;
					num2 = 6;
					break;
				case 6:
					if (!(enumType == null))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto default;
				default:
					throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957726806));
				case 2:
					if (_003C_003Ec__DisplayClass13_.valueName != null)
					{
						enumValueMetadata = ((EnumMetadata)MetadataLoader.LoadMetadata(enumType)).Values.FirstOrDefault(_003C_003Ec__DisplayClass13_._003CGetEnumValue_003Eb__0);
						num2 = 4;
						break;
					}
					goto end_IL_0012;
				case 8:
					_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
					num2 = 7;
					break;
				case 1:
					return null;
				case 5:
					return VV1LrUhTfVPh59A3q9hh(enumValueMetadata);
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public static IEnumerable<EnumValueMetadata> GetEnumValues(ViewDataDictionary viewData)
	{
		Contract.ArgumentNotNull(viewData, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97887730));
		EnumMetadata enumMetadata = MetadataLoader.LoadMetadata(viewData.get_ModelMetadata().get_ModelType()) as EnumMetadata;
		if (enumMetadata == null)
		{
			enumMetadata = MetadataLoader.LoadMetadata(viewData.get_ModelMetadata().get_ModelType().GetGenericArguments()
				.FirstOrDefault()) as EnumMetadata;
		}
		if (enumMetadata != null)
		{
			return enumMetadata.Values;
		}
		return new List<EnumValueMetadata>();
	}

	public static object GetEnumDefaultValue([NotNull] Type enumType)
	{
		//Discarded unreachable code: IL_003d
		int num = 3;
		int num2 = num;
		EnumValueMetadata enumValueMetadata = default(EnumValueMetadata);
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		while (true)
		{
			switch (num2)
			{
			default:
				if (enumValueMetadata != null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 6;
			case 4:
				throw new ArgumentNullException((string)YONCx4hTbqrRGf6T5K3L(-281842504 ^ -281964206));
			case 1:
				enumValueMetadata = _003C_003Ec__DisplayClass15_.metadata.Values.FirstOrDefault(_003C_003Ec__DisplayClass15_._003CGetEnumDefaultValue_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				return bpkMUKhTQhenmE1yqVvw(enumType);
			case 5:
				return VV1LrUhTfVPh59A3q9hh(enumValueMetadata);
			case 2:
				if (!xY4gVbhXp8dO8XLCgQ8m(enumType, null))
				{
					_003C_003Ec__DisplayClass15_.metadata = (EnumMetadata)MetadataLoader.LoadMetadata(enumType);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	public static IEntity GetEntity(Guid typeUid, Guid uid)
	{
		return (IEntity)Su093LhT8HjnORlAgn5b(OntqVvhTv5yT5TjeoU7b(((IMetadataRuntimeService)J8UavAhTCELP89BPcMGx()).GetTypeByUid(typeUid, loadImplementation: true)), uid);
	}

	public static IEntity GetEntity(Guid typeUid, object id)
	{
		int num = 1;
		int num2 = num;
		IEntityManager entityManager = default(IEntityManager);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				Type typeByUid = ((IMetadataRuntimeService)J8UavAhTCELP89BPcMGx()).GetTypeByUid(typeUid, loadImplementation: true);
				entityManager = (IEntityManager)OntqVvhTv5yT5TjeoU7b(typeByUid);
				id = qGoMfZhTZyjdlWHkhiJ4(typeByUid, id);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			case 2:
				return null;
			}
			if (id == null)
			{
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 2;
				}
				continue;
			}
			return (IEntity)cYExWrhTuHQkxIdgqwoD(entityManager, id);
		}
	}

	public static T GetEntity<T>(object id) where T : class, IEntity
	{
		IEntityManager entityManager = GetEntityManager(typeof(T));
		id = TryConvertEntityId(typeof(T), id);
		if (id == null)
		{
			return null;
		}
		return (T)entityManager.LoadOrNull(id);
	}

	public static ICollection<T> GetEntities<T>(params object[] ids) where T : class, IEntity
	{
		IEntityManager entityManager = GetEntityManager(typeof(T));
		List<T> list = new List<T>();
		if (ids != null)
		{
			foreach (object idValue in ids)
			{
				object obj = TryConvertEntityId(typeof(T), idValue);
				if (obj == null)
				{
					return null;
				}
				T val = (T)entityManager.LoadOrNull(obj);
				if (val != null)
				{
					list.Add(val);
				}
			}
		}
		return list;
	}

	public static Type GetEntityType(Guid typeUid, bool loadImplementation = true)
	{
		return ((IMetadataRuntimeService)J8UavAhTCELP89BPcMGx()).GetTypeByUid(typeUid, loadImplementation);
	}

	public static Type GetEntityIdType(Type entityType)
	{
		//Discarded unreachable code: IL_0045, IL_0087, IL_0096
		int num = 4;
		int num2 = num;
		Type[] genericArguments = default(Type[]);
		Type @interface = default(Type);
		Type result = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (genericArguments.Length == 0)
				{
					num2 = 8;
					continue;
				}
				break;
			case 3:
				@interface = entityType.GetInterface(LqAwZthXOJ2MuuuG2isf(typeof(IEntity<>).TypeHandle).FullName);
				num2 = 5;
				continue;
			default:
				genericArguments = @interface.GetGenericArguments();
				num2 = 6;
				continue;
			case 5:
				if (!IiSau9hX2d1jtaCyZLq1(@interface, null))
				{
					num2 = 7;
					continue;
				}
				goto default;
			case 1:
			case 7:
			case 8:
				return result;
			case 4:
				result = LqAwZthXOJ2MuuuG2isf(typeof(long).TypeHandle);
				num2 = 3;
				continue;
			case 2:
				break;
			}
			result = genericArguments[0];
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
			{
				num2 = 1;
			}
		}
	}

	public static IEntityManager GetEntityManagerByFilter(IEntityFilter filter)
	{
		return (IEntityManager)Tvk8D7hTIPkpuhxymHql(MetadataLoader.GetEntityMetadataByFilter(filter.GetType()).Uid);
	}

	public static IEntityManager GetEntityManager(Guid uid)
	{
		return GetEntityManager(MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(uid));
	}

	public static IEntityManager GetEntityManager(Type entityType)
	{
		//Discarded unreachable code: IL_005e, IL_006d
		int num = 3;
		int num2 = num;
		IEntityManager entityManager = default(IEntityManager);
		while (true)
		{
			switch (num2)
			{
			case 1:
				throw new ServiceNotFoundException(SR.T((string)YONCx4hTbqrRGf6T5K3L(0x57A5235E ^ 0x57A66932), entityType.FullName));
			default:
				return entityManager;
			case 2:
				if (entityManager != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 3:
				entityManager = (IEntityManager)TDB4pOhTVX0QFcwfqX0E(entityType);
				num2 = 2;
				break;
			}
		}
	}

	public static IEntityManager GetEntityManagerOrNull(Type entityType)
	{
		return getEntityManagerCached(entityType);
	}

	private static IEntityManager GetEntityManagerCached(Type entityType)
	{
		return (IEntityManager)Locator.GetService(typeof(IEntityManager<>).MakeGenericType(sliK1dhTSiBr6ZAco64H(entityType)));
	}

	public static object TryConvertEntityId(Guid typeUid, object idValue, bool loadImplementation = true)
	{
		return qGoMfZhTZyjdlWHkhiJ4(GetEntityType(typeUid, loadImplementation), idValue);
	}

	public static object TryConvertEntityId(Type entityType, object idValue)
	{
		//Discarded unreachable code: IL_009c, IL_00ab, IL_00e1, IL_0114, IL_017d
		int num = 7;
		int num2 = num;
		TypeConverter typeConverter = default(TypeConverter);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (!HdFUSIhTqOPUCK0d22Oj(typeConverter, idValue.GetType()))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 8;
			default:
				idValue = idValue.ToString();
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 5;
				}
				continue;
			case 5:
			case 6:
				return null;
			case 3:
				try
				{
					object obj = UgfFSJhTXXvJDoqrbgG7(typeConverter, null, ePMiVJhTKgrv0KSGlAAp(), idValue);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => obj, 
						_ => obj, 
					};
				}
				catch (Exception exception)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							((ILogger)aGbc16hTTM1pIyv0C4nd()).Debug(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112750072), idValue, type, entityType), exception);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
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
				goto case 5;
			case 7:
				if (idValue == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 6;
					}
					continue;
				}
				break;
			case 8:
				if (typeConverter.CanConvertFrom(idValue.GetType()))
				{
					num2 = 3;
					continue;
				}
				goto case 5;
			case 1:
				return idValue;
			case 2:
				if (!(type == idValue.GetType()))
				{
					typeConverter = (TypeConverter)yUjq1BhTRUTP5SP6vGTk(type);
					num2 = 4;
					continue;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				continue;
			case 9:
				break;
			}
			type = lPi0fIhTiSWq6PKo0cmn(entityType);
			num2 = 2;
		}
	}

	[NotNull]
	public static Type GetEntityFilterType([NotNull] Type entityType)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Contract.ArgumentNotNull(entityType, (string)YONCx4hTbqrRGf6T5K3L(0x7C1EE318 ^ 0x7C1E308C));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return GetEntityFilterType(((ClassMetadata)MetadataLoader.LoadMetadata(entityType)) ?? throw new MetadataException(string.Format((string)qPZ8NOhTkeaAB4BietCq(YONCx4hTbqrRGf6T5K3L(-1867198571 ^ -1867021139)), entityType.FullName)));
			}
		}
	}

	public static void CheckEntityAndTableNames(List<AbstractMetadata> metadataList)
	{
		Dictionary<string, string> usedEntityNames = new Dictionary<string, string>();
		Dictionary<string, string> usedTableNames = new Dictionary<string, string>();
		foreach (EntityMetadata item in metadataList.OfType<EntityMetadata>())
		{
			CheckEntityAndTableNames(item, "", usedEntityNames, usedTableNames);
		}
	}

	public static string GetNamespaceShortName(string ns)
	{
		//Discarded unreachable code: IL_0058, IL_007b, IL_008a, IL_0127, IL_015f
		int num = 1;
		int num2 = num;
		Dictionary<string, string> dictionary = default(Dictionary<string, string>);
		bool lockTaken = default(bool);
		string value = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					Monitor.Enter(dictionary, ref lockTaken);
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num3 = 3;
					}
					while (true)
					{
						switch (num3)
						{
						case 3:
							if (loadedShortNamespaces.TryGetValue(ns, out value))
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
								{
									num3 = 0;
								}
								break;
							}
							goto default;
						default:
							loadedShortNamespaces.Add(ns, value = GetNamespace(ns, (string nsPart, string _) => nsPart));
							num3 = 2;
							break;
						case 1:
							return value;
						case 2:
							return value;
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								boxwKThTOrFS32Aw1Drd(dictionary);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
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
			case 1:
				if (qevnZkhTn7VKqw9DeN3P(ns))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (!loadedShortNamespaces.TryGetValue(ns, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 4;
			case 2:
				dictionary = loadedShortNamespaces;
				num2 = 5;
				break;
			case 5:
				lockTaken = false;
				num2 = 3;
				break;
			case 4:
				return value;
			default:
				return string.Empty;
			}
		}
	}

	public static string GetNamespaceDisplayName(string ns)
	{
		//Discarded unreachable code: IL_007c, IL_008b, IL_00db, IL_016a, IL_01a2, IL_01b1
		int num = 4;
		int num2 = num;
		SR.LocalizableString value = default(SR.LocalizableString);
		bool lockTaken = default(bool);
		Dictionary<string, SR.LocalizableString> dictionary = default(Dictionary<string, SR.LocalizableString>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return string.Empty;
			case 3:
				if (!loadedFullNamespaces.TryGetValue(ns, out value))
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 5:
				lockTaken = false;
				num2 = 2;
				continue;
			case 6:
				dictionary = loadedFullNamespaces;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 5;
				}
				continue;
			case 2:
				try
				{
					Monitor.Enter(dictionary, ref lockTaken);
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							value = (loadedFullNamespaces[ns] = (SR.LocalizableString)zkFDxthT2rYpCDYeBkEj(new FullNamespaceLocalizer(ns)));
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
							if (!loadedFullNamespaces.TryGetValue(ns, out value))
							{
								num3 = 2;
								continue;
							}
							break;
						case 0:
							break;
						}
						break;
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								boxwKThTOrFS32Aw1Drd(dictionary);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
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
				break;
			case 4:
				if (!qevnZkhTn7VKqw9DeN3P(ns))
				{
					num2 = 3;
					continue;
				}
				goto case 1;
			}
			break;
		}
		return (string)egj0b8hTeRmDUbRMZmmQ(value);
	}

	public static string GetNamespacePartDisplayName(string ns)
	{
		//Discarded unreachable code: IL_009b, IL_00b9, IL_00f8, IL_0107, IL_015b, IL_019b, IL_01aa, IL_01b6, IL_01c5
		int num = 2;
		int num2 = num;
		bool lockTaken = default(bool);
		SR.LocalizableString value = default(SR.LocalizableString);
		Dictionary<string, SR.LocalizableString> obj = default(Dictionary<string, SR.LocalizableString>);
		while (true)
		{
			switch (num2)
			{
			case 4:
				lockTaken = false;
				num2 = 3;
				continue;
			case 2:
				if (loadedNamespaces.TryGetValue(ns, out value))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 5;
			case 5:
				obj = loadedNamespaces;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num3 = 2;
					while (true)
					{
						switch (num3)
						{
						default:
							goto end_IL_00bd;
						case 2:
							if (loadedNamespaces.TryGetValue(ns, out value))
							{
								num3 = 3;
								continue;
							}
							break;
						case 3:
							goto end_IL_00bd;
						case 1:
							break;
						case 0:
							goto end_IL_00bd;
						}
						value = (loadedNamespaces[ns] = SR.LocalizableString.Create(new NamespacePartLocalizer(ns)));
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num3 = 0;
						}
						continue;
						end_IL_00bd:
						break;
					}
				}
				finally
				{
					int num4;
					if (!lockTaken)
					{
						num4 = 2;
						goto IL_015f;
					}
					goto IL_0175;
					IL_015f:
					switch (num4)
					{
					default:
						goto end_IL_014a;
					case 1:
						break;
					case 2:
						goto end_IL_014a;
					case 0:
						goto end_IL_014a;
					}
					goto IL_0175;
					IL_0175:
					Monitor.Exit(obj);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num4 = 0;
					}
					goto IL_015f;
					end_IL_014a:;
				}
				break;
			}
			break;
		}
		return (string)egj0b8hTeRmDUbRMZmmQ(value);
	}

	private static string GetNamespace(object ns, Func<string, string, string> getItem)
	{
		string text = "";
		List<string> list = new List<string>();
		string[] array = ((string)ns).Split(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411202199).ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
		foreach (string text2 in array)
		{
			text = text + ((text.Length > 0) ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x511518D9) : "") + text2;
			string namespacePartDisplayName = GetNamespacePartDisplayName(text);
			if (!string.IsNullOrEmpty(namespacePartDisplayName))
			{
				list.Add(getItem(text2, namespacePartDisplayName));
			}
		}
		return string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A778D73), list);
	}

	[NotNull]
	private static Type GetEntityFilterType([NotNull] ClassMetadata metadata)
	{
		//Discarded unreachable code: IL_0138, IL_018f, IL_019e
		int num = 5;
		int num2 = num;
		Type reflectionType = default(Type);
		Type typeByUid = default(Type);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 11:
				reflectionType = typeByUid.Assembly.GetReflectionType((string)XjFWoMhT3XgVCGeiMBZB(VWEgNrhTNo80Tfgx74s7(metadata), YONCx4hTbqrRGf6T5K3L(0x48A7E34A ^ 0x48A7A076)));
				num2 = 3;
				break;
			case 1:
				return GetEntityFilterType(entityMetadata);
			case 10:
				return LqAwZthXOJ2MuuuG2isf(typeof(Filter).TypeHandle);
			case 8:
				return reflectionType;
			default:
				if (!fwnJ6HhXK2aZUKrgw2FN(qLghs6hTpv1caxwDJkmf(metadata), Guid.Empty))
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 10;
					}
					break;
				}
				goto case 7;
			case 5:
				Contract.ArgumentNotNull(metadata, (string)YONCx4hTbqrRGf6T5K3L(-1334993905 ^ -1334979279));
				num2 = 4;
				break;
			case 4:
				typeByUid = ((IMetadataRuntimeService)J8UavAhTCELP89BPcMGx()).GetTypeByUid(Ssmv1shTPn4Q4jB4I4Bj(metadata), loadImplementation: true);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 6;
				}
				break;
			case 7:
				entityMetadata = (EntityMetadata)MetadataServiceContext.MetadataRuntimeService.GetMetadata(qLghs6hTpv1caxwDJkmf(metadata));
				num2 = 9;
				break;
			case 9:
				if (entityMetadata != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 10;
			case 3:
				if (reflectionType != null)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto default;
			case 6:
				if (!(metadata is EntityMetadata))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				if (yro3wghT1UE0y7u05qky((EntityMetadata)metadata))
				{
					num2 = 11;
					break;
				}
				goto default;
			}
		}
	}

	private static void CheckEntityAndTableNames(object metadata, object parentMetadataName, Dictionary<string, string> usedEntityNames, Dictionary<string, string> usedTableNames)
	{
		string text = ((!string.IsNullOrEmpty((string)parentMetadataName)) ? ((string)parentMetadataName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F62D24)) : "") + ((NamedMetadata)metadata).DisplayName;
		string value;
		if (((EntityMetadata)metadata).Type == EntityMetadataType.Interface || ((EntityMetadata)metadata).Type == EntityMetadataType.Entity)
		{
			if (string.IsNullOrEmpty(((NamedMetadata)metadata).Name))
			{
				throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70253126), text));
			}
			if (usedEntityNames.TryGetValue(((NamedMetadata)metadata).Name.ToUpper(), out value))
			{
				throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870710307), ((NamedMetadata)metadata).Name, value, text));
			}
			usedEntityNames[((NamedMetadata)metadata).Name.ToUpper()] = text;
			if (string.IsNullOrEmpty(((EntityMetadata)metadata).TableName))
			{
				throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53FE0D5), text));
			}
			if (usedTableNames.TryGetValue(((EntityMetadata)metadata).TableName.ToUpper(), out value))
			{
				throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921021173), ((EntityMetadata)metadata).TableName, value, text));
			}
			usedTableNames[((EntityMetadata)metadata).TableName.ToUpper()] = text;
		}
		foreach (TablePartMetadata tablePart in ((EntityMetadata)metadata).TableParts)
		{
			CheckEntityAndTableNames(tablePart, text, usedEntityNames, usedTableNames);
		}
		foreach (PropertyMetadata property in ((ClassMetadata)metadata).Properties)
		{
			if (property.Settings is EntitySettings entitySettings && entitySettings.RelationType == RelationType.ManyToMany)
			{
				string text2 = text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70253706) + property.DisplayName;
				if (string.IsNullOrEmpty(entitySettings.RelationTableName))
				{
					throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A82F4D4), property.DisplayName, text));
				}
				if (usedTableNames.TryGetValue(entitySettings.RelationTableName.ToUpper(), out value))
				{
					throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463943F4), entitySettings.RelationTableName, value, text2));
				}
				usedTableNames[entitySettings.RelationTableName.ToUpper()] = text2;
			}
		}
	}

	static ModelHelper()
	{
		int num = 1;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					parameterExpression = (ParameterExpression)nDtm8DhTDhf7KCjDCUev(LqAwZthXOJ2MuuuG2isf(typeof(Type).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740411594));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 2;
					}
					continue;
				case 6:
					return;
				default:
					loadedFullNamespaces = new Dictionary<string, SR.LocalizableString>();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					toQtemhTaHQQ07Nu0Qh8();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					break;
				case 4:
					loadedShortNamespaces = new Dictionary<string, string>();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 3;
					}
					continue;
				case 3:
					loadedNamespaces = new Dictionary<string, SR.LocalizableString>();
					num2 = 5;
					continue;
				}
				break;
			}
			getEntityManagerCached = MetadataLoader.UseCachingForFunc(Expression.Lambda<Func<Type, IEntityManager>>((Expression)WN5fJghTw56KGDlKUGaU(null, (MethodInfo)rRLcBQhTtTZwNNZDujQF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[1] { parameterExpression }), new ParameterExpression[1] { parameterExpression }));
			num = 6;
		}
	}

	internal static bool Ay0AiyhXirqHE6YjbIbJ()
	{
		return KI2iKrhXSKKubdRfk8gZ == null;
	}

	internal static ModelHelper Ad1t1ThXROf4hplCYOEp()
	{
		return KI2iKrhXSKKubdRfk8gZ;
	}

	internal static Guid Cl3IHvhXquP38jpwJT9n(object P_0)
	{
		return ((ReferenceOnType)P_0).TypeUid;
	}

	internal static bool fwnJ6HhXK2aZUKrgw2FN(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid NIJYkmhXXVCmJNhJlfOF(object P_0)
	{
		return ((ReferenceOnType)P_0).SubTypeUid;
	}

	internal static object LXPt6mhXTvfehNMKig7F(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static bool IISjOkhXkKCyPJnXCps1(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void ilquUJhXn3sqYSHLmncf(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static Type LqAwZthXOJ2MuuuG2isf(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool IiSau9hX2d1jtaCyZLq1(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static void GcTMTohXeugv0IGOmUVD(object P_0, Guid value)
	{
		((TypeHeaderInfo)P_0).TypeUid = value;
	}

	internal static Guid YnVTj6hXPSgrLchJ3PTw(object P_0)
	{
		return ((ImplementationUidAttribute)P_0).Uid;
	}

	internal static void qPs4HIhX1HRCevNe4Cbt(object P_0, Guid value)
	{
		((TypeHeaderInfo)P_0).SubTypeUid = value;
	}

	internal static Guid uMKVBvhXN2OeHP0Rpcql(object P_0)
	{
		return ((UidAttribute)P_0).Uid;
	}

	internal static void b1VU3ZhX38N5DdSsPGn9(object P_0, RelationType value)
	{
		((EntitySettings)P_0).RelationType = value;
	}

	internal static bool xY4gVbhXp8dO8XLCgQ8m(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool rbMJNrhXa8hmQGhSafVR(Type type)
	{
		return CheckSimpleType(type);
	}

	internal static object MXiFEvhXD2hjJdq1gPma(object P_0, Type runtimeType)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(runtimeType);
	}

	internal static Guid cAAs4KhXtfGPJa9lnHVQ(object P_0)
	{
		return ((ITypeDescriptor)P_0).Uid;
	}

	internal static void tRWLAMhXwGdy2bpbYZvp(object P_0, object P_1)
	{
		((TypeHeaderInfo)P_0).Settings = (TypeSettings)P_1;
	}

	internal static Guid VWqCtthX4InYDPFoi5mw(Type type)
	{
		return DataClassDescriptor.GetSubtypeUid(type);
	}

	internal static void UJDxlYhX60cCtCOt5Tfq(object P_0, RelationType value)
	{
		((DataClassSettings)P_0).RelationType = value;
	}

	internal static void Q6KxpuhXH9eqTA6xDxTF(object P_0, Guid value)
	{
		((ListOfSimpleTypeSettings)P_0).SimpleTypeUid = value;
	}

	internal static Guid y8yskkhXA7NaX52bobAJ(Type type)
	{
		return EnumDescriptor.GetSubtypeUid(type);
	}

	internal static void Ca2hvKhX7MrMXZn0mKov(object P_0, bool value)
	{
		((TypeHeaderInfo)P_0).Nullable = value;
	}

	internal static bool qDpVfMhXx5JKxQJXnwrb(Type type)
	{
		return type.IsFunc();
	}

	internal static bool MrrJ0ihX0wSDlx2ROuSU(Type type)
	{
		return type.IsAsync();
	}

	internal static bool KSJpbChXmTFdKvlJjEJE(Type argument, object P_1)
	{
		return ProcessReturnType(argument, P_1);
	}

	internal static Guid khxIG2hXyRwIe00u3VE1(object P_0)
	{
		return ((TypeHeaderInfo)P_0).TypeUid;
	}

	internal static void LcYc2hhXMGqxmuUWJvGC(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).TypeUid = value;
	}

	internal static Guid rnL6RyhXJDup3U0EZOKl(object P_0)
	{
		return ((TypeHeaderInfo)P_0).SubTypeUid;
	}

	internal static void oXVAxthX9VE49EHDtjiq(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).SubTypeUid = value;
	}

	internal static object DQP8GqhXd6nXJ0EvRu7M(object P_0)
	{
		return ((TypeHeaderInfo)P_0).Settings;
	}

	internal static void iw6FfGhXlukIc96OVHbR(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).Settings = (TypeSettings)P_1;
	}

	internal static bool D4eIqfhXro9a0Vf9iKJg(object P_0)
	{
		return ((TypeHeaderInfo)P_0).Nullable;
	}

	internal static void vTAGd0hXgsgGq32Z2QKO(object P_0, bool value)
	{
		((PropertyMetadata)P_0).Nullable = value;
	}

	internal static object qHQ3WjhX5bugmGJUrXMQ(object P_0)
	{
		return ((IPropertyMetadata)P_0).CreatePropertySignature();
	}

	internal static object GCZZCOhXjXfsOF5iJjav(object P_0)
	{
		return ((PropertySignature)P_0).Type;
	}

	internal static void qb1GT6hXY57G3dPRxdia(object P_0, object P_1)
	{
		((ActionSettings)P_0).ParameterType = (TypeSignature)P_1;
	}

	internal static bool XDJ6BuhXLmeMNscpYLvx()
	{
		return Locator.Initialized;
	}

	internal static object TvBv2PhXUfOSMwXvFjNt()
	{
		return MetadataServiceContext.ServiceOrNull;
	}

	internal static Type JVujI9hXst7XoY98RxtP(object P_0)
	{
		return ((ITypeDescriptor)P_0).SettingsType;
	}

	internal static object HVgy9thXctKpv8brlHfb(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static bool qWivlIhXzvZyU75MRD63(object P_0)
	{
		return ((ITypeDescriptor)P_0).CanBeNullable;
	}

	internal static object bhDWpXhTF2KLeBWh3sJy(object P_0)
	{
		return ((ActionSettings)P_0).ReturnType;
	}

	internal static Guid KQxjXEhTBp2MC1fqhdGE(object P_0)
	{
		return ((TypeSignature)P_0).TypeUid;
	}

	internal static Type cgVWufhTWufCIiFmDaUy(object P_0)
	{
		return ((RipeType)P_0).Raw;
	}

	internal static void ABaYPDhTodXD5fYiHiIQ(object P_0, object P_1)
	{
		((ActionSettings)P_0).ReturnType = (TypeSignature)P_1;
	}

	internal static object YONCx4hTbqrRGf6T5K3L(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object plgOl2hThQT92CWElodc(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void VZrPVhhTGPywUo0651M6(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object E4YwYKhTEgxOVwrIQ7Jx(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object VV1LrUhTfVPh59A3q9hh(object P_0)
	{
		return ((EnumValueMetadata)P_0).EnumValue;
	}

	internal static object bpkMUKhTQhenmE1yqVvw(Type type)
	{
		return type.DefaultValue();
	}

	internal static object J8UavAhTCELP89BPcMGx()
	{
		return MetadataServiceContext.MetadataRuntimeService;
	}

	internal static object OntqVvhTv5yT5TjeoU7b(Type entityType)
	{
		return GetEntityManager(entityType);
	}

	internal static object Su093LhT8HjnORlAgn5b(object P_0, Guid uid)
	{
		return ((IEntityManager)P_0).LoadOrNull(uid);
	}

	internal static object qGoMfZhTZyjdlWHkhiJ4(Type entityType, object P_1)
	{
		return TryConvertEntityId(entityType, P_1);
	}

	internal static object cYExWrhTuHQkxIdgqwoD(object P_0, object P_1)
	{
		return ((IEntityManager)P_0).LoadOrNull(P_1);
	}

	internal static object Tvk8D7hTIPkpuhxymHql(Guid uid)
	{
		return GetEntityManager(uid);
	}

	internal static object TDB4pOhTVX0QFcwfqX0E(Type entityType)
	{
		return GetEntityManagerOrNull(entityType);
	}

	internal static Type sliK1dhTSiBr6ZAco64H(Type type)
	{
		return type.GetTypeWithoutProxy();
	}

	internal static Type lPi0fIhTiSWq6PKo0cmn(Type entityType)
	{
		return GetEntityIdType(entityType);
	}

	internal static object yUjq1BhTRUTP5SP6vGTk(Type P_0)
	{
		return System.ComponentModel.TypeDescriptor.GetConverter(P_0);
	}

	internal static bool HdFUSIhTqOPUCK0d22Oj(object P_0, Type P_1)
	{
		return ((TypeConverter)P_0).CanConvertFrom(P_1);
	}

	internal static object ePMiVJhTKgrv0KSGlAAp()
	{
		return CultureInfo.InvariantCulture;
	}

	internal static object UgfFSJhTXXvJDoqrbgG7(object P_0, object P_1, object P_2, object P_3)
	{
		return ((TypeConverter)P_0).ConvertFrom((ITypeDescriptorContext)P_1, (CultureInfo)P_2, P_3);
	}

	internal static object aGbc16hTTM1pIyv0C4nd()
	{
		return Logger.Log;
	}

	internal static object qPZ8NOhTkeaAB4BietCq(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool qevnZkhTn7VKqw9DeN3P(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void boxwKThTOrFS32Aw1Drd(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object zkFDxthT2rYpCDYeBkEj(object P_0)
	{
		return SR.LocalizableString.Create((SR.ILocalizer)P_0);
	}

	internal static object egj0b8hTeRmDUbRMZmmQ(object P_0)
	{
		return (string)(SR.LocalizableString)P_0;
	}

	internal static Guid Ssmv1shTPn4Q4jB4I4Bj(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool yro3wghT1UE0y7u05qky(object P_0)
	{
		return ((EntityMetadata)P_0).Filterable;
	}

	internal static object VWEgNrhTNo80Tfgx74s7(object P_0)
	{
		return ((ClassMetadata)P_0).FullTypeName;
	}

	internal static object XjFWoMhT3XgVCGeiMBZB(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static Guid qLghs6hTpv1caxwDJkmf(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static void toQtemhTaHQQ07Nu0Qh8()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object nDtm8DhTDhf7KCjDCUev(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object rRLcBQhTtTZwNNZDujQF(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object WN5fJghTw56KGDlKUGaU(object P_0, object P_1, object P_2)
	{
		return Expression.Call((Expression)P_0, (MethodInfo)P_1, (Expression[])P_2);
	}
}
