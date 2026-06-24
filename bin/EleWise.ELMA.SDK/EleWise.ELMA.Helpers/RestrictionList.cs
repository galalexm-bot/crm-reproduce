using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Proxy;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

internal class RestrictionList : List<Restriction>
{
	internal bool nHibernate;

	private static RestrictionList Hv4B3Qhc2B8oVLybfrQH;

	internal bool CloneRecursive
	{
		[CompilerGenerated]
		get
		{
			return _003CCloneRecursive_003Ek__BackingField;
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
					_003CCloneRecursive_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
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

	private bool IsType(object obj, RuleType ruleType)
	{
		//Discarded unreachable code: IL_0058, IL_0067
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		while (true)
		{
			switch (num2)
			{
			default:
				if (!NHibernateProxyHelper.IsProxy(_003C_003Ec__DisplayClass5_.obj))
				{
					num2 = 3;
					break;
				}
				goto case 6;
			case 1:
				_003C_003Ec__DisplayClass5_.ruleType = ruleType;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
			case 4:
				return this.Any(_003C_003Ec__DisplayClass5_._003CIsType_003Eb__0);
			case 2:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				_003C_003Ec__DisplayClass5_.obj = Pc0s8NhcNGc8lkwCqT96(LFU5g0hc16Gp47ZcumHs((object)(INHibernateProxy)_003C_003Ec__DisplayClass5_.obj));
				num2 = 4;
				break;
			case 5:
				_003C_003Ec__DisplayClass5_.obj = obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool IsTypeIgnore(object obj)
	{
		return IsType(obj, RuleType.Ignore);
	}

	public bool IsTypeByRef(object obj)
	{
		return IsType(obj, RuleType.CopyByRef);
	}

	public bool IsTypeSaveRef(object obj)
	{
		return IsType(obj, RuleType.SaveRef);
	}

	public bool IsTypeClone(object obj)
	{
		return IsType(obj, RuleType.Clone);
	}

	public bool IsTypeAction(object obj)
	{
		return IsType(obj, RuleType.Action);
	}

	public CopyAction Action(object obj, object propertyValue)
	{
		//Discarded unreachable code: IL_0111
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		int num = 1;
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		Restriction restriction = default(Restriction);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					break;
				case 1:
					_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					return restriction.Action(obj, _003C_003Ec__DisplayClass11_.propertyValue);
				case 5:
					return CopyAction.Default;
				case 7:
					_003C_003Ec__DisplayClass11_.propertyValue = ((ILazyInitializer)LFU5g0hc16Gp47ZcumHs((object)(INHibernateProxy)_003C_003Ec__DisplayClass11_.propertyValue)).GetImplementation();
					num2 = 3;
					continue;
				case 2:
					if (NHibernateProxyHelper.IsProxy(_003C_003Ec__DisplayClass11_.propertyValue))
					{
						num2 = 7;
						continue;
					}
					break;
				case 4:
					if (restriction == null)
					{
						num2 = 5;
						continue;
					}
					goto case 6;
				default:
					_003C_003Ec__DisplayClass11_.propertyValue = propertyValue;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			restriction = this.FirstOrDefault(_003C_003Ec__DisplayClass11_._003CAction_003Eb__0);
			num = 4;
		}
	}

	private bool IsProperty(string propertyName, Type objectType, RuleType ruleType)
	{
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass12_.ruleType = ruleType;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return this.Any(_003C_003Ec__DisplayClass12_._003CIsProperty_003Eb__0);
			case 1:
				_003C_003Ec__DisplayClass12_.propertyName = propertyName;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass12_.objectType = objectType;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private bool IsProperty(string propertyName, Type objectType, CollectionUpdateMode collectionUpdateMode)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				_003C_003Ec__DisplayClass13_.objectType = objectType;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return this.Any(_003C_003Ec__DisplayClass13_._003CIsProperty_003Eb__0);
			default:
				_003C_003Ec__DisplayClass13_.propertyName = propertyName;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass13_.collectionUpdateMode = collectionUpdateMode;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool IsPropertyIgnore(PropertyInfo propertyInfo, Type objectType)
	{
		//Discarded unreachable code: IL_0073, IL_00a7, IL_00b6, IL_0183, IL_0192
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 7:
				if ((string)PxX05MhcD7mbTiPJkn66(propertyInfo) == (string)w8gxpIhctlmKjgoc2RwJ(0x2ACE37D ^ 0x2AC8CEF))
				{
					num2 = 6;
					break;
				}
				goto case 1;
			case 2:
				if (!nHibernate)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 9;
			case 4:
				if (OwQoD0hcaV9IFypeHMFM(Bwng9Ahc3HTmnGkG0qS4(propertyInfo), typeof(Guid)))
				{
					num2 = 7;
					break;
				}
				goto case 1;
			default:
				if (OwQoD0hcaV9IFypeHMFM(propertyInfo.PropertyType, pn88bnhcpKubyABYBpnq(typeof(int).TypeHandle)))
				{
					num2 = 5;
					break;
				}
				goto case 4;
			case 5:
				if ((string)PxX05MhcD7mbTiPJkn66(propertyInfo) == (string)w8gxpIhctlmKjgoc2RwJ(-957824448 ^ -957856994))
				{
					num2 = 8;
					break;
				}
				goto case 4;
			case 9:
				if (!(Bwng9Ahc3HTmnGkG0qS4(propertyInfo) == pn88bnhcpKubyABYBpnq(typeof(long).TypeHandle)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 1:
			case 3:
				return IsProperty(propertyInfo.Name, objectType, RuleType.Ignore);
			case 6:
			case 8:
				return true;
			}
		}
	}

	public bool IsPropertyByRef(PropertyInfo propertyInfo, Type objectType)
	{
		return IsProperty((string)PxX05MhcD7mbTiPJkn66(propertyInfo), objectType, RuleType.CopyByRef);
	}

	public bool IsPropertySaveRef(PropertyInfo propertyInfo, Type objectType)
	{
		return IsProperty((string)PxX05MhcD7mbTiPJkn66(propertyInfo), objectType, RuleType.SaveRef);
	}

	public bool IsPropertyClone(PropertyInfo propertyInfo, Type objectType)
	{
		return IsProperty((string)PxX05MhcD7mbTiPJkn66(propertyInfo), objectType, RuleType.Clone);
	}

	public bool IsPropertyAction(PropertyInfo propertyInfo, Type objectType)
	{
		return IsProperty((string)PxX05MhcD7mbTiPJkn66(propertyInfo), objectType, RuleType.Action);
	}

	public CopyAction PropertyAction(string propertyName, Type objectType, object obj, object propertyValue)
	{
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = default(_003C_003Ec__DisplayClass19_0);
		Restriction restriction = default(Restriction);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass19_.objectType = objectType;
				num2 = 3;
				continue;
			case 3:
				restriction = this.FirstOrDefault(_003C_003Ec__DisplayClass19_._003CPropertyAction_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return restriction.Action(obj, propertyValue);
			case 4:
				_003C_003Ec__DisplayClass19_.propertyName = propertyName;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				_003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 4;
				}
				continue;
			}
			if (restriction != null)
			{
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 2;
				}
				continue;
			}
			return CopyAction.Default;
		}
	}

	public bool IsAllPropertiesIgnore(Type objectType)
	{
		return IsProperty(null, objectType, RuleType.Ignore);
	}

	public bool IsAllPropertiesByRef(Type objectType)
	{
		return IsProperty(null, objectType, RuleType.CopyByRef);
	}

	public bool IsAllPropertiesSaveRef(Type objectType)
	{
		return IsProperty(null, objectType, RuleType.SaveRef);
	}

	public bool IsAllPropertiesClone(Type objectType)
	{
		return IsProperty(null, objectType, RuleType.Clone);
	}

	public bool IsAllPropertiesAction(Type objectType)
	{
		return IsProperty(null, objectType, RuleType.Action);
	}

	public CollectionUpdateMode GetCollectionUpdateMode(PropertyInfo propertyInfo)
	{
		//Discarded unreachable code: IL_006a
		int num = 2;
		int num2 = num;
		CollectionUpdateMode? collectionUpdateMode = default(CollectionUpdateMode?);
		Restriction matchingCollectionRule = default(Restriction);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return collectionUpdateMode.Value;
			default:
				return CollectionUpdateMode.Match;
			case 4:
				collectionUpdateMode = matchingCollectionRule.CollectionUpdateMode;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				if (!collectionUpdateMode.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 1:
				if (matchingCollectionRule != null)
				{
					num2 = 6;
					break;
				}
				goto default;
			case 6:
				collectionUpdateMode = matchingCollectionRule.CollectionUpdateMode;
				num2 = 3;
				break;
			case 2:
				matchingCollectionRule = GetMatchingCollectionRule(delegate(Restriction r)
				{
					int num3 = 1;
					int num4 = num3;
					CollectionUpdateMode? collectionUpdateMode2 = default(CollectionUpdateMode?);
					while (true)
					{
						switch (num4)
						{
						default:
							return collectionUpdateMode2.HasValue;
						case 1:
							collectionUpdateMode2 = r.CollectionUpdateMode;
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				}, propertyInfo);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public Comparer GetComparer(PropertyInfo propertyInfo)
	{
		//Discarded unreachable code: IL_0039, IL_0048
		int num = 1;
		int num2 = num;
		Restriction matchingCollectionRule = default(Restriction);
		while (true)
		{
			switch (num2)
			{
			default:
				if (matchingCollectionRule == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 2;
			case 2:
				if (matchingCollectionRule.CompareFunction == null)
				{
					num2 = 4;
					break;
				}
				return new Comparer(matchingCollectionRule.CompareFunction);
			case 5:
				return null;
			case 3:
			case 4:
				if (((IEnumerable<object>)LTqFp9hcwpxrvfGXai0F(propertyInfo, pn88bnhcpKubyABYBpnq(typeof(TablePartPropertyAttribute).TypeHandle), false)).Any())
				{
					return new BlockComparer();
				}
				num2 = 5;
				break;
			case 1:
				matchingCollectionRule = GetMatchingCollectionRule((Restriction r) => r.CompareFunction != null, propertyInfo);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private Restriction GetMatchingCollectionRule(Func<Restriction, bool> f, PropertyInfo propertyInfo)
	{
		_003C_003Ec__DisplayClass27_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass27_0();
		CS_0024_003C_003E8__locals0.propertyInfo = propertyInfo;
		List<Restriction> source = (from r in this.Where(f)
			where _003C_003Ec.rWyi8rvJBkeDrDurQdiA(r) == RuleType.Collection
			select r).ToList();
		return source.FirstOrDefault((Restriction r) => r.PropertyName == CS_0024_003C_003E8__locals0.propertyInfo.Name) ?? source.FirstOrDefault(delegate(Restriction r)
		{
			//Discarded unreachable code: IL_00b5
			int num3 = 2;
			int num4 = num3;
			Type type = default(Type);
			while (true)
			{
				switch (num4)
				{
				case 3:
					if (!_003C_003Ec__DisplayClass27_0.VlnFJnvJvddBwimhqJ22(type, null))
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
						{
							num4 = 0;
						}
						break;
					}
					goto case 4;
				case 1:
					return false;
				case 4:
					return _003C_003Ec__DisplayClass27_0.TpxL7GvJ89H8LQTvjhpi(r).IsAssignableFrom(type);
				default:
					return false;
				case 2:
					if (!_003C_003Ec__DisplayClass27_0.zpMhFEvJf0qcDIlV7cmc(r.ObjectType, null))
					{
						type = _003C_003Ec__DisplayClass27_0.IbA5hevJCmnXmMKugwAt(_003C_003Ec__DisplayClass27_0.QTeMRsvJQwmU7uRyeueR(CS_0024_003C_003E8__locals0.propertyInfo));
						num4 = 3;
					}
					else
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num4 = 1;
						}
					}
					break;
				}
			}
		}) ?? source.FirstOrDefault(delegate(Restriction r)
		{
			//Discarded unreachable code: IL_0061, IL_0070
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return _003C_003Ec.bYHwsUvJo0UpAJrZDwjE(r.ObjectType, null);
				default:
					return false;
				case 1:
					if (_003C_003Ec.tLgdfXvJWIfcYACqH1V8(r) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		});
	}

	public RestrictionList()
	{
		//Discarded unreachable code: IL_0036, IL_003b
		GkITUFhc40ct8q0e282E();
		nHibernate = true;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool P6GlPghcesVA9XWpyeOk()
	{
		return Hv4B3Qhc2B8oVLybfrQH == null;
	}

	internal static RestrictionList W74JmehcPwpaGhwfOBRp()
	{
		return Hv4B3Qhc2B8oVLybfrQH;
	}

	internal static object LFU5g0hc16Gp47ZcumHs(object P_0)
	{
		return ((INHibernateProxy)P_0).get_HibernateLazyInitializer();
	}

	internal static object Pc0s8NhcNGc8lkwCqT96(object P_0)
	{
		return ((ILazyInitializer)P_0).GetImplementation();
	}

	internal static Type Bwng9Ahc3HTmnGkG0qS4(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static Type pn88bnhcpKubyABYBpnq(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool OwQoD0hcaV9IFypeHMFM(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object PxX05MhcD7mbTiPJkn66(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object w8gxpIhctlmKjgoc2RwJ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object LTqFp9hcwpxrvfGXai0F(object P_0, Type P_1, bool P_2)
	{
		return ((MemberInfo)P_0).GetCustomAttributes(P_1, P_2);
	}

	internal static void GkITUFhc40ct8q0e282E()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
