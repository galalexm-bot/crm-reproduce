using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Metadata;

[Serializable]
public class FormContextMetadata : EntityMetadata
{
	internal static FormContextMetadata LfquvYBGzUJ0jEXWbp4a;

	public FormContextMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xe7S86BEWTTHvIYb2iIK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
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
			MdGijOBEo4BMKLe1mWII(this, EntityMetadataType.Entity);
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
			{
				num = 0;
			}
		}
	}

	public override void LoadFromType(Type type, bool inherit = true)
	{
		//Discarded unreachable code: IL_004f, IL_005e, IL_0069, IL_0123, IL_015b, IL_016a, IL_017b
		int num = 3;
		EntityMetadata entityMetadata = default(EntityMetadata);
		IEnumerator<PropertyInfo> enumerator = default(IEnumerator<PropertyInfo>);
		PropertyInfo current = default(PropertyInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					if (entityMetadata != null)
					{
						num2 = 5;
						continue;
					}
					goto case 4;
				case 6:
					try
					{
						while (true)
						{
							int num3;
							if (!VJbV6PBEEJOIW2aS91tH(enumerator))
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
								{
									num3 = 2;
								}
								goto IL_006d;
							}
							goto IL_00da;
							IL_00da:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
							{
								num3 = 1;
							}
							goto IL_006d;
							IL_006d:
							while (true)
							{
								switch (num3)
								{
								case 1:
									tcaw7bBEG2XSNpeoFwDj(current, this, current.GetValue(entityMetadata, null), null);
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
									{
										num3 = 3;
									}
									continue;
								case 3:
									break;
								default:
									goto IL_00da;
								case 2:
									return;
								}
								break;
							}
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									bajaZjBEfgvvPvKr94OK(enumerator);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
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
					return;
				case 3:
					entityMetadata = (EntityMetadata)FHWlntBEbsybiReSpKyF(type);
					num2 = 2;
					continue;
				case 4:
					base.LoadFromType(type, inherit);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					return;
				case 5:
					enumerator = nPw8KVBEhPj8r51KR5X0(this).GetProperties().Where(delegate(PropertyInfo p)
					{
						//Discarded unreachable code: IL_0060, IL_006f
						int num5 = 1;
						int num6 = num5;
						while (true)
						{
							switch (num6)
							{
							case 1:
								if (((Array)_003C_003Ec.pnGLKwQo0eNBeJMefA6a(p)).Length != 0)
								{
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
									{
										num6 = 0;
									}
									break;
								}
								goto case 2;
							case 3:
								return _003C_003Ec.eejnQFQoyukEQXGlTGjE(p);
							default:
								return false;
							case 2:
								if (_003C_003Ec.XUmLoDQom5JaGlZBVtDP(p))
								{
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
									{
										num6 = 3;
									}
									break;
								}
								goto default;
							}
						}
					}).GetEnumerator();
					num = 6;
					break;
				}
				break;
			}
		}
	}

	public virtual void GenerateNewUids()
	{
		GenerateNewUids(this);
	}

	internal static void GenerateNewUids(EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_007f, IL_0089, IL_01da, IL_01ed, IL_01fc
		int num = 1;
		int num2 = num;
		List<TablePartMetadata>.Enumerator enumerator = default(List<TablePartMetadata>.Enumerator);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		while (true)
		{
			switch (num2)
			{
			default:
				enumerator = metadata.TableParts.GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				return;
			case 1:
				metadata.Uid = Guid.NewGuid();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				try
				{
					while (true)
					{
						IL_0198:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							goto IL_008d;
						}
						goto IL_0156;
						IL_008d:
						while (true)
						{
							switch (num3)
							{
							case 2:
								return;
							case 4:
								NsUg3oBECRfB65Hk5ixa(propertyMetadata, HoEL0oBEQuovVZkpFhQS(metadata));
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
								{
									num3 = 1;
								}
								continue;
							case 7:
								_003C_003Ec__DisplayClass3_.tp = enumerator.Current;
								num3 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
								{
									num3 = 6;
								}
								continue;
							case 1:
								CEl66PBEvBCbB1a1xBEQ(_003C_003Ec__DisplayClass3_.tp);
								num3 = 3;
								continue;
							case 6:
								propertyMetadata = _003C_003Ec__DisplayClass3_.tp.Properties.FirstOrDefault(_003C_003Ec__DisplayClass3_._003CGenerateNewUids_003Eb__0);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
								{
									num3 = 0;
								}
								continue;
							case 5:
								break;
							default:
								if (propertyMetadata != null)
								{
									num3 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
									{
										num3 = 2;
									}
									continue;
								}
								goto case 1;
							case 3:
								goto IL_0198;
							}
							break;
						}
						goto IL_0156;
						IL_0156:
						_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
						num3 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
						{
							num3 = 7;
						}
						goto IL_008d;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			}
		}
	}

	internal static EntityMetadata FindMetadata(Type type)
	{
		//Discarded unreachable code: IL_0049, IL_0058, IL_008c
		int num = 3;
		int num2 = num;
		FormMetadata formMetadata = default(FormMetadata);
		UidAttribute attribute = default(UidAttribute);
		Type reflectedType = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return null;
			case 9:
				return null;
			case 4:
				return (EntityMetadata)a7qQx2BEZBtSOaMPlVK4(formMetadata, attribute.Uid);
			case 1:
				if (attribute != null)
				{
					num2 = 4;
					continue;
				}
				goto case 9;
			case 7:
				return null;
			case 3:
				if (type.IsNested)
				{
					reflectedType = type.ReflectedType;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 5;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 2;
					}
				}
				continue;
			case 8:
				return null;
			case 5:
				formMetadata = (FormMetadata)MetadataLoader.LoadMetadata(reflectedType);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				if (!dqeL91BE86mWcRroeQ4M(reflectedType, null))
				{
					num2 = 5;
					continue;
				}
				goto case 8;
			}
			if (formMetadata != null)
			{
				attribute = AttributeHelper<UidAttribute>.GetAttribute(type, inherited: false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 1;
				}
			}
			else
			{
				num2 = 7;
			}
		}
	}

	public override TablePartMetadata CreateTablePart()
	{
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return _003C_003Ec__DisplayClass5_.tp;
			case 1:
				MdGijOBEo4BMKLe1mWII(_003C_003Ec__DisplayClass5_.tp, EntityMetadataType.Entity);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				NsUg3oBECRfB65Hk5ixa(_003C_003Ec__DisplayClass5_.tp.Properties.First(_003C_003Ec__DisplayClass5_._003CCreateTablePart_003Eb__0), Uid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass5_.tp = new FormTablePartMetadata();
				num2 = 2;
				break;
			case 4:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				LFC8U8BEuPfWa4SlmuV7(_003C_003Ec__DisplayClass5_.tp);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void xe7S86BEWTTHvIYb2iIK()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void MdGijOBEo4BMKLe1mWII(object P_0, EntityMetadataType value)
	{
		((EntityMetadata)P_0).Type = value;
	}

	internal static bool ttHLTGBEFomZTpq9mcvR()
	{
		return LfquvYBGzUJ0jEXWbp4a == null;
	}

	internal static FormContextMetadata tmEXqmBEBWBwGv2VKW9C()
	{
		return LfquvYBGzUJ0jEXWbp4a;
	}

	internal static object FHWlntBEbsybiReSpKyF(Type type)
	{
		return FindMetadata(type);
	}

	internal static Type nPw8KVBEhPj8r51KR5X0(object P_0)
	{
		return P_0.GetType();
	}

	internal static void tcaw7bBEG2XSNpeoFwDj(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static bool VJbV6PBEEJOIW2aS91tH(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void bajaZjBEfgvvPvKr94OK(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static Guid HoEL0oBEQuovVZkpFhQS(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void NsUg3oBECRfB65Hk5ixa(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).SubTypeUid = value;
	}

	internal static void CEl66PBEvBCbB1a1xBEQ(object P_0)
	{
		GenerateNewUids((EntityMetadata)P_0);
	}

	internal static bool dqeL91BE86mWcRroeQ4M(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object a7qQx2BEZBtSOaMPlVK4(object P_0, Guid uid)
	{
		return ((FormMetadata)P_0).GetPartContext(uid);
	}

	internal static void LFC8U8BEuPfWa4SlmuV7(object P_0)
	{
		((AbstractMetadata)P_0).InitNew();
	}
}
