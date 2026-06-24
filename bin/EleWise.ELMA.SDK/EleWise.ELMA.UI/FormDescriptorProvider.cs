using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI;

[Service(Type = ComponentType.Server)]
public class FormDescriptorProvider
{
	private class FormDescriptorEntry
	{
		internal static object giSNJEfgpjfFKDFelEIs;

		public Guid Uid
		{
			[CompilerGenerated]
			get
			{
				return _003CUid_003Ek__BackingField;
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
						_003CUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
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

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return _003CName_003Ek__BackingField;
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
						_003CName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
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

		public FormDescriptor Published
		{
			[CompilerGenerated]
			get
			{
				return _003CPublished_003Ek__BackingField;
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
						_003CPublished_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public FormDescriptor Emulation
		{
			[CompilerGenerated]
			get
			{
				return _003CEmulation_003Ek__BackingField;
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
						_003CEmulation_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
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

		public FormDescriptorEntry()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
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

		internal static bool tDDW8xfgaR4FLxLHkmG4()
		{
			return giSNJEfgpjfFKDFelEIs == null;
		}

		internal static FormDescriptorEntry EfICZZfgDaHqi2JpLNEd()
		{
			return (FormDescriptorEntry)giSNJEfgpjfFKDFelEIs;
		}
	}

	private class FormDescriptorCollection
	{
		private object _owner;

		private ConcurrentDictionary<Guid, FormDescriptor> _descriptors;

		private ConcurrentDictionary<Guid, FormDescriptorEntry> _entries;

		private ConcurrentDictionary<Guid, FormDescriptorEntry> _entriesByHeaderUid;

		private ConcurrentDictionary<string, FormDescriptorEntry> _entriesByName;

		internal static object teDnoyfgtKTyPaMENWov;

		public Guid MetadataType
		{
			[CompilerGenerated]
			get
			{
				return _003CMetadataType_003Ek__BackingField;
			}
			[CompilerGenerated]
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
					case 0:
						return;
					case 1:
						_003CMetadataType_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public long Timestamp
		{
			[CompilerGenerated]
			get
			{
				return _003CTimestamp_003Ek__BackingField;
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
						_003CTimestamp_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public FormDescriptorCollection(FormDescriptorProvider owner, Guid metadataType)
		{
			//Discarded unreachable code: IL_005a, IL_005f
			IiPmOJfg603HViTRcixo();
			_descriptors = new ConcurrentDictionary<Guid, FormDescriptor>();
			_entries = new ConcurrentDictionary<Guid, FormDescriptorEntry>();
			_entriesByHeaderUid = new ConcurrentDictionary<Guid, FormDescriptorEntry>();
			_entriesByName = new ConcurrentDictionary<string, FormDescriptorEntry>();
			base._002Ector();
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					MetadataType = metadataType;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num = 0;
					}
					break;
				case 3:
					_owner = owner;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num = 1;
					}
					break;
				case 2:
					r6X8GXfgAq3ftTLmgdD5(owner, NVMj7JfgHRAFvGQoHm7f(-3333094 ^ -3650266));
					num = 3;
					break;
				}
			}
		}

		public void Put(FormDescriptorEntry entry)
		{
			//Discarded unreachable code: IL_018b, IL_028d, IL_02a0, IL_02af, IL_02bf
			int num = 15;
			_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
			FormDescriptorEntry value = default(FormDescriptorEntry);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 5:
						goto end_IL_0012;
					case 9:
					case 18:
						_entries[rd7AM5fgmPHjg8i67HwH(_003C_003Ec__DisplayClass9_.entry)] = _003C_003Ec__DisplayClass9_.entry;
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num2 = 0;
						}
						continue;
					case 1:
						return;
					case 11:
						if (!KbBTT5fgJbXlpN4SRKrr(cFS9rqfgMBbA3EvUZAKG(q83kBmfgyvqKoDtboRUq(value)), _003C_003Ec__DisplayClass9_.entry.Name.ToLower()))
						{
							num2 = 20;
							continue;
						}
						break;
					case 12:
						r6X8GXfgAq3ftTLmgdD5(_003C_003Ec__DisplayClass9_.entry, NVMj7JfgHRAFvGQoHm7f(0x2ACE37D ^ 0x2A98A37));
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 8;
						}
						continue;
					case 21:
						if (value != null)
						{
							num2 = 11;
							continue;
						}
						goto case 10;
					case 19:
						if (!_descriptors.ContainsKey(YMweaqfgxbr1E70gykbA(lul5xHfg058xCyiBIkhX(_003C_003Ec__DisplayClass9_.entry))))
						{
							num2 = 13;
							continue;
						}
						goto case 9;
					default:
						_entriesByName.TryRemove((string)cFS9rqfgMBbA3EvUZAKG(q83kBmfgyvqKoDtboRUq(value)), out value);
						num2 = 2;
						continue;
					case 3:
					case 6:
						if (lul5xHfg058xCyiBIkhX(_003C_003Ec__DisplayClass9_.entry) == null)
						{
							num2 = 18;
							continue;
						}
						goto case 19;
					case 16:
						value = _entriesByName.Values.FirstOrDefault(_003C_003Ec__DisplayClass9_._003CPut_003Eb__0);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 21;
						}
						continue;
					case 2:
					case 7:
						_entriesByHeaderUid[rd7AM5fgmPHjg8i67HwH(_003C_003Ec__DisplayClass9_.entry)] = _003C_003Ec__DisplayClass9_.entry;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num2 = 1;
						}
						continue;
					case 13:
						_descriptors[YMweaqfgxbr1E70gykbA(lul5xHfg058xCyiBIkhX(_003C_003Ec__DisplayClass9_.entry))] = (FormDescriptor)lul5xHfg058xCyiBIkhX(_003C_003Ec__DisplayClass9_.entry);
						num2 = 9;
						continue;
					case 15:
						_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
						num2 = 14;
						continue;
					case 14:
						_003C_003Ec__DisplayClass9_.entry = entry;
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num2 = 9;
						}
						continue;
					case 10:
					case 20:
						_entriesByName[(string)cFS9rqfgMBbA3EvUZAKG(_003C_003Ec__DisplayClass9_.entry.Name)] = _003C_003Ec__DisplayClass9_.entry;
						num2 = 7;
						continue;
					case 8:
						if (Vp9q5afg7DfBCFqeZGnI(_003C_003Ec__DisplayClass9_.entry) != null)
						{
							num2 = 17;
							continue;
						}
						goto case 3;
					case 17:
						if (_descriptors.ContainsKey(YMweaqfgxbr1E70gykbA(Vp9q5afg7DfBCFqeZGnI(_003C_003Ec__DisplayClass9_.entry))))
						{
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
							{
								num2 = 3;
							}
							continue;
						}
						goto end_IL_0012;
					case 4:
						break;
					}
					_entriesByName[((string)q83kBmfgyvqKoDtboRUq(_003C_003Ec__DisplayClass9_.entry)).ToLower()] = _003C_003Ec__DisplayClass9_.entry;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 0;
					}
					continue;
					end_IL_0012:
					break;
				}
				_descriptors[YMweaqfgxbr1E70gykbA(Vp9q5afg7DfBCFqeZGnI(_003C_003Ec__DisplayClass9_.entry))] = (FormDescriptor)Vp9q5afg7DfBCFqeZGnI(_003C_003Ec__DisplayClass9_.entry);
				num = 6;
			}
		}

		public FormDescriptor GetDescriptor(Guid uid)
		{
			int num = 1;
			int num2 = num;
			FormDescriptor value = default(FormDescriptor);
			while (true)
			{
				switch (num2)
				{
				case 1:
					_descriptors.TryGetValue(uid, out value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return value;
				}
			}
		}

		public FormDescriptor GetDescriptorByHeaderUid(Guid uid, bool forEmulation)
		{
			//Discarded unreachable code: IL_003d, IL_004c, IL_005c, IL_006b
			int num = 3;
			int num2 = num;
			FormDescriptorEntry value = default(FormDescriptorEntry);
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (value != null)
					{
						num2 = 5;
						break;
					}
					goto case 1;
				case 3:
					_entriesByHeaderUid.TryGetValue(uid, out value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					return null;
				case 5:
					if (forEmulation)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				default:
					if (lul5xHfg058xCyiBIkhX(value) != null)
					{
						num2 = 6;
						break;
					}
					goto case 4;
				case 4:
					return (FormDescriptor)Vp9q5afg7DfBCFqeZGnI(value);
				case 6:
					return (FormDescriptor)lul5xHfg058xCyiBIkhX(value);
				}
			}
		}

		public FormDescriptor GetDescriptor(string name, bool forEmulation)
		{
			//Discarded unreachable code: IL_00b1, IL_00c0
			int num = 6;
			FormDescriptorEntry value = default(FormDescriptorEntry);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return (FormDescriptor)Vp9q5afg7DfBCFqeZGnI(value);
					case 1:
						return null;
					case 3:
						if (forEmulation)
						{
							goto end_IL_0012;
						}
						goto default;
					case 5:
						_entriesByName.TryGetValue((string)cFS9rqfgMBbA3EvUZAKG(name), out value);
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num2 = 2;
						}
						break;
					case 6:
						zdOkr5fg9UaoHsvZJNhP(name, NVMj7JfgHRAFvGQoHm7f(-675505729 ^ -675506775));
						num2 = 5;
						break;
					case 4:
						if (value != null)
						{
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
							{
								num2 = 3;
							}
							break;
						}
						goto case 1;
					case 2:
						if (lul5xHfg058xCyiBIkhX(value) != null)
						{
							return (FormDescriptor)lul5xHfg058xCyiBIkhX(value);
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
						{
							num2 = 0;
						}
						break;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 2;
			}
		}

		public IEnumerable<FormDescriptor> GetDescriptors(bool forEmulation)
		{
			_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
			CS_0024_003C_003E8__locals0.forEmulation = forEmulation;
			return (from e in _entries
				select (!CS_0024_003C_003E8__locals0.forEmulation) ? e.Value.Published : e.Value.Emulation into d
				where d != null
				select d).ToArray();
		}

		public FormDescriptorEntry GetEntry(Guid uid)
		{
			int num = 1;
			int num2 = num;
			FormDescriptorEntry value = default(FormDescriptorEntry);
			while (true)
			{
				switch (num2)
				{
				case 1:
					_entries.TryGetValue(uid, out value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return value;
				}
			}
		}

		internal static void IiPmOJfg603HViTRcixo()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object NVMj7JfgHRAFvGQoHm7f(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void r6X8GXfgAq3ftTLmgdD5(object P_0, object P_1)
		{
			Contract.ArgumentNotNull(P_0, (string)P_1);
		}

		internal static bool tmClxkfgwjubJKkyfUku()
		{
			return teDnoyfgtKTyPaMENWov == null;
		}

		internal static FormDescriptorCollection xhNXCvfg4096fIt2mHWY()
		{
			return (FormDescriptorCollection)teDnoyfgtKTyPaMENWov;
		}

		internal static object Vp9q5afg7DfBCFqeZGnI(object P_0)
		{
			return ((FormDescriptorEntry)P_0).Published;
		}

		internal static Guid YMweaqfgxbr1E70gykbA(object P_0)
		{
			return ((FormDescriptor)P_0).Uid;
		}

		internal static object lul5xHfg058xCyiBIkhX(object P_0)
		{
			return ((FormDescriptorEntry)P_0).Emulation;
		}

		internal static Guid rd7AM5fgmPHjg8i67HwH(object P_0)
		{
			return ((FormDescriptorEntry)P_0).Uid;
		}

		internal static object q83kBmfgyvqKoDtboRUq(object P_0)
		{
			return ((FormDescriptorEntry)P_0).Name;
		}

		internal static object cFS9rqfgMBbA3EvUZAKG(object P_0)
		{
			return ((string)P_0).ToLower();
		}

		internal static bool KbBTT5fgJbXlpN4SRKrr(object P_0, object P_1)
		{
			return (string)P_0 != (string)P_1;
		}

		internal static void zdOkr5fg9UaoHsvZJNhP(object P_0, object P_1)
		{
			Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
		}
	}

	private ConcurrentDictionary<Type, Type> _descriptorTypes;

	private static FormDescriptorProvider VHeCCjyhvHAnQr070iS;

	public IMemoryCacheService MemoryCacheService
	{
		[CompilerGenerated]
		get
		{
			return _003CMemoryCacheService_003Ek__BackingField;
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
					_003CMemoryCacheService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
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

	public ICacheService CacheService
	{
		[CompilerGenerated]
		get
		{
			return _003CCacheService_003Ek__BackingField;
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
					_003CCacheService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual FormDescriptor GetDescriptor(Guid metadataType, string name, bool forEmulation)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (FormDescriptor)IUiqQVyCNHVVgvSOIEm(GetCollection(metadataType), name, forEmulation);
			case 2:
				pxsh3nyfoU4BNavq4G7(MemoryCacheService, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837639287));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				Contract.ServiceNotNull(CacheService, (string)axj46syQ0FHvPGG6UeX(-672123589 ^ -672096991));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual FormDescriptor GetDescriptorByHeaderUid(Guid metadataType, Guid headerUid, bool forEmulation)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				pxsh3nyfoU4BNavq4G7(MemoryCacheService, axj46syQ0FHvPGG6UeX(0x1ECE530A ^ 0x1ECEF4F8));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return (FormDescriptor)gWPiJ7yvHup9Exd67B5(GetCollection(metadataType), headerUid, forEmulation);
			default:
				Contract.ServiceNotNull(CacheService, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751153670));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public virtual FormDescriptor GetDescriptor(Guid metadataType, Guid descriptorUid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				pxsh3nyfoU4BNavq4G7(CacheService, axj46syQ0FHvPGG6UeX(-1824388195 ^ -1824349305));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				pxsh3nyfoU4BNavq4G7(MemoryCacheService, axj46syQ0FHvPGG6UeX(-289714582 ^ -289674856));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return (FormDescriptor)F3uEiPy8vdbkJSTZgZt(GetCollection(metadataType), descriptorUid);
			}
		}
	}

	public virtual IEnumerable<FormDescriptor> GetDescriptors(Guid metadataType, bool forEmulation)
	{
		return GetCollection(metadataType).GetDescriptors(forEmulation);
	}

	internal void UpdateCache(Guid metadataType)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				pxsh3nyfoU4BNavq4G7(CacheService, axj46syQ0FHvPGG6UeX(0x34A6D230 ^ 0x34A67A2A));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				Contract.ServiceNotNull(MemoryCacheService, (string)axj46syQ0FHvPGG6UeX(-289714582 ^ -289674856));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				CacheService.Insert(string.Concat(axj46syQ0FHvPGG6UeX(-1886646897 ^ -1886607943), metadataType), Dn9hhtyZg4Mi7ZMG6uj().Ticks);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				return;
			}
		}
	}

	internal FormDescriptor CreateDescriptor(IFormMetadataItem item)
	{
		//Discarded unreachable code: IL_009a, IL_00ed, IL_00fc, IL_024b, IL_025a
		int num = 16;
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_0);
		Type value = default(Type);
		IFormDescriptorInfo formDescriptorInfo = default(IFormDescriptorInfo);
		IEnumerable<IFormDescriptorInfo> extensionPoints = default(IEnumerable<IFormDescriptorInfo>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 12:
					_003C_003Ec__DisplayClass13_.t = gBA2E3yV2ekbjTkQRCB(item).GetType();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					obj = null;
					goto IL_02d6;
				case 13:
					if (!(value == null))
					{
						num2 = 7;
						continue;
					}
					goto case 2;
				case 6:
					if (formDescriptorInfo == null)
					{
						num2 = 10;
						continue;
					}
					obj = KSts59yi7lk2jTbQ90Q(formDescriptorInfo);
					goto IL_02d6;
				case 9:
					_003C_003Ec__DisplayClass13_.t = _003C_003Ec__DisplayClass13_.t.BaseType;
					num = 5;
					break;
				default:
					value = null;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
					num2 = 8;
					continue;
				case 8:
					extensionPoints = ((ComponentManager)exw2MeyST8kiYaGUZpq()).GetExtensionPoints<IFormDescriptorInfo>();
					num = 12;
					break;
				case 7:
					if (!c336PbyqByxTEMx4AfC(value, null))
					{
						num2 = 18;
						continue;
					}
					goto case 14;
				case 11:
					if (_descriptorTypes.TryGetValue(gBA2E3yV2ekbjTkQRCB(item).GetType(), out value))
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 3;
				case 14:
					throw new InvalidOperationException((string)uob5n6yKxYaSfnk3DTh(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317751704), _003C_003Ec__DisplayClass13_.t.FullName));
				case 18:
					_descriptorTypes[item.Metadata.GetType()] = value;
					num2 = 4;
					continue;
				case 15:
					ziw837yIlksXKE3MmYW(item.Metadata != null, axj46syQ0FHvPGG6UeX(-978351861 ^ -978378367));
					num2 = 11;
					continue;
				case 4:
				case 17:
					return (FormDescriptor)pAVBysyXY8KEboq1Pb4(value, new object[1] { item });
				case 1:
				case 5:
					if (xllTC9yRgfBTkdKkpfS(_003C_003Ec__DisplayClass13_.t, null))
					{
						num2 = 13;
						continue;
					}
					goto case 7;
				case 16:
					xOn5tByus6cQJUg46yr(item, axj46syQ0FHvPGG6UeX(-105199646 ^ -105222244));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 15;
					}
					continue;
				case 2:
					{
						formDescriptorInfo = extensionPoints.FirstOrDefault(_003C_003Ec__DisplayClass13_._003CCreateDescriptor_003Eb__0);
						num2 = 6;
						continue;
					}
					IL_02d6:
					value = (Type)obj;
					num = 9;
					break;
				}
				break;
			}
		}
	}

	private long GetTimestamp(Guid metadataType)
	{
		int num = 2;
		int num2 = num;
		long? num3 = default(long?);
		while (true)
		{
			switch (num2)
			{
			default:
				return 0L;
			case 1:
				if (num3.HasValue)
				{
					return num3.Value;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				num3 = CacheService.Get<long?>(string.Concat(axj46syQ0FHvPGG6UeX(0x53CB464B ^ 0x53CBEE7D), metadataType));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private FormDescriptorCollection GetCollection(Guid metadataType)
	{
		//Discarded unreachable code: IL_0070, IL_00b5, IL_00c4, IL_00f3, IL_013b, IL_014a, IL_0155, IL_0216, IL_026f, IL_028e, IL_029d, IL_02ca, IL_02d9
		int num = 3;
		long timestamp = default(long);
		bool flag = default(bool);
		string key = default(string);
		FormDescriptorCollection result = default(FormDescriptorCollection);
		FormDescriptorCollection formDescriptorCollection = default(FormDescriptorCollection);
		bool lockTaken = default(bool);
		IEnumerator<FormMetadataItemHeaderManager.HeaderDescriptorInfo> enumerator = default(IEnumerator<FormMetadataItemHeaderManager.HeaderDescriptorInfo>);
		FormDescriptorEntry existingEntry = default(FormDescriptorEntry);
		FormMetadataItemHeaderManager.HeaderDescriptorInfo current = default(FormMetadataItemHeaderManager.HeaderDescriptorInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					timestamp = GetTimestamp(metadataType);
					num2 = 2;
					break;
				case 2:
					flag = false;
					num2 = 10;
					break;
				case 12:
					MemoryCacheService.Insert(key, result);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					break;
				case 14:
					try
					{
						Monitor.Enter(formDescriptorCollection, ref lockTaken);
						int num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								enumerator = Locator.GetServiceNotNull<FormMetadataItemHeaderManager>().GetPublishedHeaderDescriptorInfos(metadataType).GetEnumerator();
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
								{
									num3 = 0;
								}
								continue;
							}
							try
							{
								while (true)
								{
									int num4;
									if (!u67kb9y2AvIRRJ7GQ7d(enumerator))
									{
										num4 = 4;
										goto IL_0159;
									}
									goto IL_01cd;
									IL_0159:
									while (true)
									{
										switch (num4)
										{
										case 2:
											break;
										default:
											existingEntry = (FormDescriptorEntry)CE575JyOsT07QFdoYnH(result, xr0ofFynQBK4OuKM4QS(current));
											num4 = 3;
											continue;
										case 3:
											CheckEntry(result, current, existingEntry);
											num4 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
											{
												num4 = 0;
											}
											continue;
										case 1:
											goto IL_01cd;
										case 4:
											return result;
										}
										break;
									}
									continue;
									IL_01cd:
									current = enumerator.Current;
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
									{
										num4 = 0;
									}
									goto IL_0159;
								}
							}
							finally
							{
								if (enumerator != null)
								{
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
									{
										num5 = 0;
									}
									while (true)
									{
										switch (num5)
										{
										default:
											enumerator.Dispose();
											num5 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
											{
												num5 = 1;
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
					finally
					{
						int num6;
						if (!lockTaken)
						{
							num6 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
							{
								num6 = 2;
							}
							goto IL_0273;
						}
						goto IL_02a8;
						IL_02a8:
						x8yBnUyec1jpbIW3Rhr(formDescriptorCollection);
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num6 = 0;
						}
						goto IL_0273;
						IL_0273:
						switch (num6)
						{
						default:
							goto end_IL_024e;
						case 2:
							goto end_IL_024e;
						case 1:
							break;
						case 0:
							goto end_IL_024e;
						}
						goto IL_02a8;
						end_IL_024e:;
					}
				case 1:
					flag = fYSHFoykeemElDLZoZd(result) != timestamp;
					num2 = 5;
					break;
				case 7:
					flag = true;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 7;
					}
					break;
				case 9:
					result = new FormDescriptorCollection(this, metadataType);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 12;
					}
					break;
				case 4:
				case 13:
					return result;
				default:
					formDescriptorCollection = result;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 5;
					}
					break;
				case 6:
					lockTaken = false;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 14;
					}
					break;
				case 5:
				case 11:
					if (!flag)
					{
						goto end_IL_0012;
					}
					goto default;
				case 10:
					key = (string)E2uMBiyT7XIrBm3wDbM(axj46syQ0FHvPGG6UeX(-882126494 ^ -882149292), metadataType);
					num2 = 8;
					break;
				case 8:
					if (MemoryCacheService.TryGetValue<FormDescriptorCollection>(key, out result))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 9;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	private void CheckEntry(FormDescriptorCollection collection, FormMetadataItemHeaderManager.HeaderDescriptorInfo di, FormDescriptorEntry existingEntry)
	{
		//Discarded unreachable code: IL_00d9, IL_0161, IL_0182, IL_01ec, IL_027b, IL_028f, IL_02d7, IL_02e6, IL_03af, IL_0475, IL_0484, IL_04ca, IL_04fd, IL_0559, IL_0568, IL_0578, IL_0587, IL_05b7, IL_05ea, IL_0646, IL_0655
		int num = 32;
		FormDescriptor formDescriptor = default(FormDescriptor);
		long? num7 = default(long?);
		bool flag = default(bool);
		FormMetadataItemManager serviceNotNull = default(FormMetadataItemManager);
		IFormMetadataItem item = default(IFormMetadataItem);
		FormDescriptor formDescriptor2 = default(FormDescriptor);
		FormDescriptorEntry formDescriptorEntry = default(FormDescriptorEntry);
		IFormMetadataItem item2 = default(IFormMetadataItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				object obj2;
				switch (num2)
				{
				case 45:
				{
					long num9 = b4X0kKy1YXJrXCM5EGU(formDescriptor);
					num7 = di.EmulationId;
					if (num9 != num7.Value)
					{
						num2 = 10;
						continue;
					}
					goto case 18;
				}
				case 14:
				case 34:
					if (existingEntry != null)
					{
						num2 = 11;
						continue;
					}
					goto case 17;
				case 38:
					num7 = di.PublishedId;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 8;
					}
					continue;
				case 33:
					flag = true;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					obj = null;
					goto IL_069b;
				case 15:
					if (num7.HasValue)
					{
						num2 = 42;
						continue;
					}
					goto case 36;
				case 44:
					return;
				case 10:
				case 41:
				{
					FormMetadataItemManager formMetadataItemManager = serviceNotNull;
					num7 = di.EmulationId;
					item = formMetadataItemManager.Load(num7.Value);
					num2 = 27;
					continue;
				}
				case 2:
				{
					FormDescriptorEntry formDescriptorEntry2 = new FormDescriptorEntry();
					yZnvnjyD4qLTUyTxPsw(formDescriptorEntry2, xr0ofFynQBK4OuKM4QS(di));
					DYAwgYytaVnkKqpeWbS(formDescriptorEntry2, vdkY0xy3YlOG0022lNk(di));
					BlN0mwyw2vD23E4n3UY(formDescriptorEntry2, formDescriptor2);
					lnrH1Oy4rG2a3kMTTMT(formDescriptorEntry2, formDescriptor);
					formDescriptorEntry = formDescriptorEntry2;
					num2 = 28;
					continue;
				}
				case 32:
					serviceNotNull = Locator.GetServiceNotNull<FormMetadataItemManager>();
					num2 = 31;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 11;
					}
					continue;
				case 9:
					flag = true;
					num2 = 34;
					continue;
				case 11:
					if (!((string)jdycL2yawZrqXXq0Y4i(existingEntry) != (string)vdkY0xy3YlOG0022lNk(di)))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 17;
				case 24:
				case 40:
				{
					FormMetadataItemManager formMetadataItemManager2 = serviceNotNull;
					num7 = di.PublishedId;
					item2 = formMetadataItemManager2.Load(num7.Value);
					num2 = 19;
					continue;
				}
				case 6:
					obj2 = null;
					break;
				case 43:
					flag = true;
					num2 = 14;
					continue;
				case 31:
					if (existingEntry != null)
					{
						num2 = 3;
						continue;
					}
					goto case 12;
				case 23:
					if (formDescriptor == null)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 41;
						}
						continue;
					}
					goto case 45;
				case 8:
					if (!num7.HasValue)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
						{
							num2 = 30;
						}
						continue;
					}
					goto case 22;
				case 22:
					if (formDescriptor2 == null)
					{
						num2 = 24;
						continue;
					}
					goto case 37;
				case 26:
					if (!num7.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 14;
				case 17:
					flag = true;
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 12;
					}
					continue;
				case 1:
					if (formDescriptor != null)
					{
						num2 = 16;
						continue;
					}
					goto case 14;
				case 21:
					formDescriptor2 = null;
					num2 = 35;
					continue;
				case 36:
					if (formDescriptor2 == null)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num2 = 29;
						}
						continue;
					}
					goto case 21;
				case 18:
					num7 = di.EmulationId;
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 26;
					}
					continue;
				default:
					num7 = di.EmulationId;
					num2 = 7;
					continue;
				case 39:
					if (existingEntry == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num2 = 6;
						}
						continue;
					}
					obj2 = existingEntry.Emulation;
					break;
				case 5:
					goto end_IL_0012;
				case 35:
					flag = true;
					num2 = 20;
					continue;
				case 4:
				case 13:
					if (!flag)
					{
						return;
					}
					num2 = 2;
					continue;
				case 25:
				case 30:
					num7 = di.PublishedId;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 15;
					}
					continue;
				case 28:
					vmwqDny69ysdYxd17WT(collection, formDescriptorEntry);
					num2 = 44;
					continue;
				case 7:
					if (num7.HasValue)
					{
						num2 = 23;
						continue;
					}
					goto case 18;
				case 19:
					try
					{
						formDescriptor2 = CreateDescriptor(item2);
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					catch (Exception ex2)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								qY5bHnypx53tQh8eG7U(asUmf9yNFcyb5M3LdBr(), uob5n6yKxYaSfnk3DTh(axj46syQ0FHvPGG6UeX(0x3C5338FF ^ 0x3C539193), vdkY0xy3YlOG0022lNk(di)), ex2);
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
								{
									num6 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 33;
				case 27:
					try
					{
						formDescriptor = CreateDescriptor(item);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch (Exception ex)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								qY5bHnypx53tQh8eG7U(asUmf9yNFcyb5M3LdBr(), uob5n6yKxYaSfnk3DTh(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE12801D), di.Name), ex);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
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
					goto case 9;
				case 16:
					formDescriptor = null;
					num2 = 43;
					continue;
				case 37:
				{
					long num8 = b4X0kKy1YXJrXCM5EGU(formDescriptor2);
					num7 = di.PublishedId;
					if (num8 != num7.Value)
					{
						num2 = 40;
						continue;
					}
					goto case 25;
				}
				case 3:
					{
						obj = knZW7JyPsWKlYg3BQTP(existingEntry);
						goto IL_069b;
					}
					IL_069b:
					formDescriptor2 = (FormDescriptor)obj;
					num2 = 39;
					continue;
				}
				formDescriptor = (FormDescriptor)obj2;
				num2 = 5;
				continue;
				end_IL_0012:
				break;
			}
			flag = false;
			num = 38;
		}
	}

	public FormDescriptorProvider()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		u69M9iyHEDZNAWlh45x();
		_descriptorTypes = new ConcurrentDictionary<Type, Type>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool ltwdOPyGeZgxqlY6m4P()
	{
		return VHeCCjyhvHAnQr070iS == null;
	}

	internal static FormDescriptorProvider dyMn4iyEnIgQtpx5DZx()
	{
		return VHeCCjyhvHAnQr070iS;
	}

	internal static void pxsh3nyfoU4BNavq4G7(object P_0, object P_1)
	{
		Contract.ServiceNotNull(P_0, (string)P_1);
	}

	internal static object axj46syQ0FHvPGG6UeX(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object IUiqQVyCNHVVgvSOIEm(object P_0, object P_1, bool forEmulation)
	{
		return ((FormDescriptorCollection)P_0).GetDescriptor((string)P_1, forEmulation);
	}

	internal static object gWPiJ7yvHup9Exd67B5(object P_0, Guid uid, bool forEmulation)
	{
		return ((FormDescriptorCollection)P_0).GetDescriptorByHeaderUid(uid, forEmulation);
	}

	internal static object F3uEiPy8vdbkJSTZgZt(object P_0, Guid uid)
	{
		return ((FormDescriptorCollection)P_0).GetDescriptor(uid);
	}

	internal static DateTime Dn9hhtyZg4Mi7ZMG6uj()
	{
		return DateTime.Now;
	}

	internal static void xOn5tByus6cQJUg46yr(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void ziw837yIlksXKE3MmYW(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static object gBA2E3yV2ekbjTkQRCB(object P_0)
	{
		return ((IFormMetadataItem)P_0).Metadata;
	}

	internal static object exw2MeyST8kiYaGUZpq()
	{
		return ComponentManager.Current;
	}

	internal static Type KSts59yi7lk2jTbQ90Q(object P_0)
	{
		return ((IFormDescriptorInfo)P_0).DescriptorType;
	}

	internal static bool xllTC9yRgfBTkdKkpfS(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool c336PbyqByxTEMx4AfC(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object uob5n6yKxYaSfnk3DTh(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object pAVBysyXY8KEboq1Pb4(Type P_0, object P_1)
	{
		return Activator.CreateInstance(P_0, (object[])P_1);
	}

	internal static object E2uMBiyT7XIrBm3wDbM(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static long fYSHFoykeemElDLZoZd(object P_0)
	{
		return ((FormDescriptorCollection)P_0).Timestamp;
	}

	internal static Guid xr0ofFynQBK4OuKM4QS(object P_0)
	{
		return ((FormMetadataItemHeaderManager.HeaderDescriptorInfo)P_0).Uid;
	}

	internal static object CE575JyOsT07QFdoYnH(object P_0, Guid uid)
	{
		return ((FormDescriptorCollection)P_0).GetEntry(uid);
	}

	internal static bool u67kb9y2AvIRRJ7GQ7d(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void x8yBnUyec1jpbIW3Rhr(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object knZW7JyPsWKlYg3BQTP(object P_0)
	{
		return ((FormDescriptorEntry)P_0).Published;
	}

	internal static long b4X0kKy1YXJrXCM5EGU(object P_0)
	{
		return ((FormDescriptor)P_0).MetadataItemId;
	}

	internal static object asUmf9yNFcyb5M3LdBr()
	{
		return Logger.Log;
	}

	internal static object vdkY0xy3YlOG0022lNk(object P_0)
	{
		return ((FormMetadataItemHeaderManager.HeaderDescriptorInfo)P_0).Name;
	}

	internal static void qY5bHnypx53tQh8eG7U(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object jdycL2yawZrqXXq0Y4i(object P_0)
	{
		return ((FormDescriptorEntry)P_0).Name;
	}

	internal static void yZnvnjyD4qLTUyTxPsw(object P_0, Guid value)
	{
		((FormDescriptorEntry)P_0).Uid = value;
	}

	internal static void DYAwgYytaVnkKqpeWbS(object P_0, object P_1)
	{
		((FormDescriptorEntry)P_0).Name = (string)P_1;
	}

	internal static void BlN0mwyw2vD23E4n3UY(object P_0, object P_1)
	{
		((FormDescriptorEntry)P_0).Published = (FormDescriptor)P_1;
	}

	internal static void lnrH1Oy4rG2a3kMTTMT(object P_0, object P_1)
	{
		((FormDescriptorEntry)P_0).Emulation = (FormDescriptor)P_1;
	}

	internal static void vmwqDny69ysdYxd17WT(object P_0, object P_1)
	{
		((FormDescriptorCollection)P_0).Put((FormDescriptorEntry)P_1);
	}

	internal static void u69M9iyHEDZNAWlh45x()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
