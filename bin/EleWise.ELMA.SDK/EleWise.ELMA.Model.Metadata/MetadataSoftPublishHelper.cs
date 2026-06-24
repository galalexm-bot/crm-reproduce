using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace EleWise.ELMA.Model.Metadata;

public static class MetadataSoftPublishHelper
{
	internal static MetadataSoftPublishHelper lfB5lXbwn8aKsgMleV5m;

	internal static PublicationType GetPublicationTypeOnChange(IMetadata oldMetadata, IMetadata newMetadata)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		IDeltaRootMetadata deltaRootMetadata = default(IDeltaRootMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return PublicationType.Restart;
			default:
				return SbvKnGbwecdkQocg7TLw(deltaRootMetadata, oldMetadata);
			case 1:
				if ((deltaRootMetadata = newMetadata as IDeltaRootMetadata) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	internal static PublicationType GetPublicationTypeOnCreate(IMetadata newMetadata)
	{
		//Discarded unreachable code: IL_0064, IL_0073
		int num = 3;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				if (entityMetadata.Type == EntityMetadataType.InterfaceExtension)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 4;
			case 1:
				return PublicationType.Restart;
			case 5:
			{
				EntityMetadata obj = (EntityMetadata)veucLrbw1caO6s10eb7I(newMetadata.GetType());
				obj.Type = entityMetadata.Type;
				obj.Uid = entityMetadata.Uid;
				pDNnRrbwNTBdevDUL6qG(obj, entityMetadata.BaseClassUid);
				xOnub5bwpX7TJEa4wDZ9(obj, wKGeE2bw3r2Shbr38oc0(entityMetadata));
				Ci7mZ6bwDoFAnd3yV1Hm(obj, x8jJwTbwaOvbxUhiC8OR(entityMetadata));
				nEY4ksbwtT6DJ83E1Wvi(obj, entityMetadata.DisplayName);
				obj.Description = entityMetadata.Description;
				obj.ImplementedExtensionUids = new List<Guid>();
				wsSqrFbw4pQtRhTlmXf5(obj, P5G6libwwvNuuIRaXRso(entityMetadata));
				qFx12xbwH5mV9H7rWsxO(obj, Bu41kVbw6fjwqDyE7YSU(entityMetadata));
				return HplEtdbwAUhv7VchUsBk(obj, newMetadata);
			}
			case 4:
				if (Pd5lrebw7JRUMedpCLI1(newMetadata))
				{
					return PublicationType.Delta;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return PublicationType.Restart;
			case 3:
				if (!Cpes6qbwP24eOB4Wv4qB(newMetadata as ClassMetadata))
				{
					if ((entityMetadata = newMetadata as EntityMetadata) == null)
					{
						num2 = 4;
						break;
					}
					goto default;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static void CopyChanges(IMetadata original, IMetadata changed)
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
				t12FWXbwxIP0cHStqqQR(original, changed);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static PublicationType IsEqualsObject(object oldObject, object newObject)
	{
		//Discarded unreachable code: IL_0062, IL_006c, IL_0134, IL_0147, IL_0186, IL_0195
		int num = 3;
		int num2 = num;
		PublicationType publicationType = default(PublicationType);
		List<PropertyInfo>.Enumerator enumerator = default(List<PropertyInfo>.Enumerator);
		PublicationBehaviourAttribute attribute = default(PublicationBehaviourAttribute);
		object value = default(object);
		object value2 = default(object);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (newObject == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 7;
			case 7:
			{
				if (V7TAiLbw0p9wWkfaglWw(oldObject.GetType(), newObject.GetType()))
				{
					num2 = 4;
					continue;
				}
				List<PropertyInfo> list = oldObject.GetType().GetProperties().Where(delegate(PropertyInfo p)
				{
					//Discarded unreachable code: IL_003d, IL_004c, IL_0081
					int num5 = 5;
					while (true)
					{
						int num6 = num5;
						while (true)
						{
							switch (num6)
							{
							case 3:
								if (p.CanWrite)
								{
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
									{
										num6 = 0;
									}
									continue;
								}
								break;
							case 5:
								if (!_003C_003Ec.nnNHRGCtxNZbXCCqB6XS(p))
								{
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
									{
										num6 = 4;
									}
									continue;
								}
								goto case 3;
							case 6:
								if (_003C_003Ec.xapi4LCtyXf5994DKS9F(p, _003C_003Ec.Wk7P7ZCtm99jXlSsaVCQ(typeof(XmlIgnoreAttribute).TypeHandle), true))
								{
									num6 = 2;
									continue;
								}
								goto case 1;
							default:
								if (((Array)_003C_003Ec.OYoSk4Ct0lLnkER7csYX(p)).Length != 0)
								{
									break;
								}
								goto end_IL_0012;
							case 1:
								return _003C_003Ec.xapi4LCtyXf5994DKS9F(p, _003C_003Ec.Wk7P7ZCtm99jXlSsaVCQ(typeof(PublicationBehaviourAttribute).TypeHandle), true);
							case 2:
							case 4:
								break;
							}
							return false;
							continue;
							end_IL_0012:
							break;
						}
						num5 = 6;
					}
				})
					.ToList();
				publicationType = PublicationType.Soft;
				enumerator = list.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				continue;
			}
			case 3:
				if (oldObject == null)
				{
					num2 = 2;
					continue;
				}
				goto case 5;
			case 6:
				return publicationType;
			case 1:
			case 2:
			case 4:
				return PublicationType.Restart;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 2;
						goto IL_0070;
					}
					goto IL_00cb;
					IL_0070:
					while (true)
					{
						switch (num3)
						{
						default:
							publicationType |= hms9j1bwm00qYlCMoVZn(attribute, CheckType.Change, value, value2);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
							break;
						case 3:
							goto IL_00cb;
						case 2:
							return publicationType;
						}
						break;
					}
					continue;
					IL_00cb:
					PropertyInfo current = enumerator.Current;
					attribute = AttributeHelper<PublicationBehaviourAttribute>.GetAttribute(current, inherited: true);
					value = current.GetValue(oldObject, null);
					value2 = current.GetValue(newObject, null);
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num3 = 0;
					}
					goto IL_0070;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
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

	internal static bool IsNewValuesDelta(object value, PublicationType type)
	{
		//Discarded unreachable code: IL_00ff, IL_010e, IL_011e, IL_021c, IL_025b, IL_026a, IL_0279, IL_02a7, IL_02b6
		int num = 15;
		int num3 = default(int);
		IList list = default(IList);
		Type type2 = default(Type);
		Type @interface = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
				case 20:
					if (num3 < KasWEjbw9KcgawurNDl0(list))
					{
						num2 = 19;
						continue;
					}
					goto case 5;
				case 5:
					return true;
				case 2:
					type2 = value.GetType();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 17;
					}
					continue;
				case 4:
					if (!TypeOf<IMetadata>.Raw.IsAssignableFrom(@interface.GetGenericArguments()[0]))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 13;
				case 7:
					if ((list = value as IList) != null)
					{
						num = 4;
						break;
					}
					goto case 2;
				case 9:
					return false;
				default:
					num3 = 0;
					num2 = 20;
					continue;
				case 14:
					return true;
				case 15:
					if (value != null)
					{
						@interface = value.GetType().GetInterface(aGPSIvbwy3Y74JFFIJpU(typeof(IList<>).TypeHandle).FullName);
						num2 = 8;
					}
					else
					{
						num2 = 14;
					}
					continue;
				case 8:
					if (!V7TAiLbw0p9wWkfaglWw(@interface, null))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 7;
				case 10:
					if (type != PublicationType.Delta)
					{
						num = 9;
						break;
					}
					goto case 5;
				case 16:
					return false;
				case 17:
					if (!type2.IsClass)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 3;
				case 13:
					if (list.OfType<IMetadata>().Any())
					{
						num2 = 10;
						continue;
					}
					goto case 5;
				case 1:
				case 18:
					return true;
				case 6:
					return Pd5lrebw7JRUMedpCLI1(value);
				case 3:
					if (!k0qBcQbwdBHKF9eQWXj4(type2, aGPSIvbwy3Y74JFFIJpU(typeof(string).TypeHandle)))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 1;
				case 12:
				case 19:
					if (hmwGQQbwJavQUjxOqjtL(Q1oVfdbwMlemkmiSpSO0(list, num3), type))
					{
						num3++;
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 10;
						}
					}
					else
					{
						num2 = 16;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static bool IsNewObjectDelta(object value)
	{
		//Discarded unreachable code: IL_0056, IL_0065, IL_01a5, IL_01b8, IL_01c7, IL_01d7
		int num = 1;
		int num2 = num;
		List<PropertyInfo>.Enumerator enumerator = default(List<PropertyInfo>.Enumerator);
		PropertyInfo current = default(PropertyInfo);
		DefaultValueAttribute attribute2 = default(DefaultValueAttribute);
		object obj = default(object);
		PublicationBehaviourAttribute attribute = default(PublicationBehaviourAttribute);
		PublicationType publicationType = default(PublicationType);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (value != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 3;
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
							{
								num3 = 1;
							}
							goto IL_0074;
						}
						goto IL_00f9;
						IL_00f9:
						current = enumerator.Current;
						int num4 = 6;
						num3 = num4;
						goto IL_0074;
						IL_0074:
						while (true)
						{
							switch (num3)
							{
							case 4:
								attribute2 = AttributeHelper<DefaultValueAttribute>.GetAttribute(current, inherited: true);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
								{
									num3 = 0;
								}
								continue;
							default:
								obj = mCcEBebwlswWJ34tcNKK(current, value, null);
								num3 = 2;
								continue;
							case 5:
								break;
							case 3:
								goto IL_00f9;
							case 6:
								attribute = AttributeHelper<PublicationBehaviourAttribute>.GetAttribute(current, inherited: true);
								num3 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
								{
									num3 = 4;
								}
								continue;
							case 2:
								publicationType |= hms9j1bwm00qYlCMoVZn(attribute, CheckType.Create, attribute2?.Value ?? tdII1fbwge8Nt7wyeXtq(m8QHF9bwroMk8RqBmY6C(current)), obj);
								num3 = 5;
								continue;
							case 1:
								goto end_IL_00d3;
							}
							break;
						}
						continue;
						end_IL_00d3:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
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
			case 4:
				return publicationType != PublicationType.Restart;
			case 3:
				return false;
			}
			List<PropertyInfo> list = value.GetType().GetProperties().Where(delegate(PropertyInfo p)
			{
				//Discarded unreachable code: IL_0041, IL_0050, IL_005f, IL_00a8, IL_00b7
				int num6 = 7;
				int num7 = num6;
				while (true)
				{
					switch (num7)
					{
					case 7:
						if (!_003C_003Ec.nnNHRGCtxNZbXCCqB6XS(p))
						{
							num7 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
							{
								num7 = 6;
							}
							break;
						}
						goto case 2;
					case 3:
						return p.IsDefined(_003C_003Ec.Wk7P7ZCtm99jXlSsaVCQ(typeof(PublicationBehaviourAttribute).TypeHandle), inherit: true);
					default:
						return false;
					case 2:
						if (!_003C_003Ec.G1uCA9CtMKLpKPK3lCbN(p))
						{
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
							{
								num7 = 0;
							}
							break;
						}
						goto case 1;
					case 1:
						if (p.GetIndexParameters().Length == 0)
						{
							num7 = 4;
							break;
						}
						goto default;
					case 4:
						if (_003C_003Ec.xapi4LCtyXf5994DKS9F(p, _003C_003Ec.Wk7P7ZCtm99jXlSsaVCQ(typeof(XmlIgnoreAttribute).TypeHandle), true))
						{
							num7 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
							{
								num7 = 4;
							}
							break;
						}
						goto case 3;
					}
				}
			})
				.ToList();
			publicationType = PublicationType.Soft;
			enumerator = list.GetEnumerator();
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
			{
				num2 = 2;
			}
		}
	}

	internal static Guid GetMetadataUid(IMetadata metadata)
	{
		int num = 1;
		int num2 = num;
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return Guid.Empty;
			case 2:
				return tablePartMetadata.TablePartPropertyUid;
			case 1:
				if (metadata != null)
				{
					if ((tablePartMetadata = metadata as TablePartMetadata) == null)
					{
						return tJmh4lbw5teG2GMWpkwc(metadata);
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	private static void CopyChangesObject(object original, object changed)
	{
		//Discarded unreachable code: IL_0076, IL_00a6, IL_00b0, IL_00bf, IL_0100, IL_016b, IL_0176, IL_01e7, IL_01f6, IL_0206, IL_0215, IL_0374, IL_039b, IL_03aa, IL_03ba, IL_042b, IL_043e, IL_044d, IL_045d
		int num = 2;
		int num2 = num;
		List<PropertyInfo>.Enumerator enumerator = default(List<PropertyInfo>.Enumerator);
		PropertyInfo current = default(PropertyInfo);
		object obj3 = default(object);
		LocalizableAttribute attribute = default(LocalizableAttribute);
		string text = default(string);
		object obj2 = default(object);
		object value = default(object);
		Type type = default(Type);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 10:
				if (changed != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 8:
				obj = null;
				goto IL_0495;
			case 2:
				if (original == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 10;
			case 1:
				return;
			case 11:
				return;
			default:
				if (!k0qBcQbwdBHKF9eQWXj4(original.GetType(), changed.GetType()))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 12;
					}
					break;
				}
				obj = original.GetType();
				goto IL_0495;
			case 7:
				if (!changed.GetType().IsInstanceOfType(original))
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 7;
					}
					break;
				}
				obj = changed.GetType();
				goto IL_0495;
			case 12:
				if (original.GetType().IsInstanceOfType(changed))
				{
					obj = original.GetType();
					goto IL_0495;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 7;
				}
				break;
			case 4:
				try
				{
					while (true)
					{
						IL_0269:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 10;
							goto IL_0180;
						}
						goto IL_0245;
						IL_0180:
						int num4 = num3;
						goto IL_0184;
						IL_0245:
						current = enumerator.Current;
						num4 = 14;
						goto IL_0184;
						IL_0184:
						while (true)
						{
							switch (num4)
							{
							case 13:
							case 20:
								obj3 = mCcEBebwlswWJ34tcNKK(current, original, null);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
								{
									num4 = 4;
								}
								continue;
							case 19:
								break;
							case 9:
								if (attribute == null)
								{
									num4 = 12;
									continue;
								}
								goto case 5;
							case 1:
							case 18:
								goto IL_0269;
							case 6:
								if ((text = obj2 as string) == null)
								{
									num4 = 11;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
									{
										num4 = 16;
									}
									continue;
								}
								goto IL_037e;
							case 11:
								if (value != null)
								{
									num4 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
									{
										num4 = 2;
									}
									continue;
								}
								goto IL_0269;
							default:
								if (obj3 != null)
								{
									num4 = 11;
									continue;
								}
								goto IL_0269;
							case 8:
								obj2 = Q0cdCZbwLHUgL8OcR3dl(text);
								num4 = 15;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
								{
									num4 = 8;
								}
								continue;
							case 14:
								if (UE9fSEbwjGuLIyrZsTdy(current, typeof(PublicationBehaviourAttribute), true))
								{
									num4 = 20;
									continue;
								}
								goto case 7;
							case 3:
							case 12:
							case 15:
							case 16:
								oETQpDbwUuQKxRXETlHs(current, original, obj2, null);
								num4 = 18;
								continue;
							case 2:
								fVYWYObwsC5iknvi5QXH(obj3, value);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
								{
									num4 = 1;
								}
								continue;
							case 7:
								obj2 = mCcEBebwlswWJ34tcNKK(current, changed, null);
								num4 = 6;
								continue;
							case 17:
								goto IL_037e;
							case 5:
								if (!LQ5JaVbwYN1fUk0ugj4L(attribute))
								{
									num4 = 3;
									continue;
								}
								goto case 8;
							case 4:
								value = current.GetValue(changed, null);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
								{
									num4 = 0;
								}
								continue;
							case 10:
								return;
							}
							break;
						}
						goto IL_0245;
						IL_037e:
						attribute = AttributeHelper<LocalizableAttribute>.GetAttribute(current, inherited: true);
						num3 = 9;
						goto IL_0180;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
			case 5:
				return;
			case 9:
				if (!k0qBcQbwdBHKF9eQWXj4(type, null))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 6:
				return;
			case 3:
				{
					enumerator = type.GetProperties().Where(delegate(PropertyInfo p)
					{
						//Discarded unreachable code: IL_0039, IL_00cf, IL_00de
						int num6 = 5;
						int num7 = num6;
						while (true)
						{
							switch (num7)
							{
							case 2:
								return !_003C_003Ec.xapi4LCtyXf5994DKS9F(p, typeof(XmlIgnoreAttribute), true);
							case 1:
							case 3:
								return false;
							default:
								if (((Array)_003C_003Ec.OYoSk4Ct0lLnkER7csYX(p)).Length != 0)
								{
									num7 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
									{
										num7 = 1;
									}
									break;
								}
								goto case 2;
							case 5:
								if (_003C_003Ec.nnNHRGCtxNZbXCCqB6XS(p))
								{
									num7 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
									{
										num7 = 3;
									}
									break;
								}
								goto case 1;
							case 4:
								if (!_003C_003Ec.G1uCA9CtMKLpKPK3lCbN(p))
								{
									num7 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
									{
										num7 = 1;
									}
									break;
								}
								goto default;
							}
						}
					}).ToList()
						.GetEnumerator();
					num2 = 4;
					break;
				}
				IL_0495:
				type = (Type)obj;
				num2 = 9;
				break;
			}
		}
	}

	private static void CopyValues(object originalValue, object changedValue)
	{
		//Discarded unreachable code: IL_0133, IL_01d1, IL_01e0, IL_01ef, IL_025a, IL_02a7, IL_02b6, IL_0337, IL_0346, IL_03f9, IL_041a, IL_0429, IL_046d, IL_047c, IL_048b, IL_049b, IL_04e8, IL_04f7, IL_0565
		int num = 32;
		object obj2 = default(object);
		IList list2 = default(IList);
		int num3 = default(int);
		IList list = default(IList);
		Type type = default(Type);
		object obj = default(object);
		IEnumerator enumerator = default(IEnumerator);
		IMetadata metadata = default(IMetadata);
		Dictionary<Guid, IMetadata> dictionary = default(Dictionary<Guid, IMetadata>);
		IMetadata value = default(IMetadata);
		Type type2 = default(Type);
		Type @interface = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 23:
					obj2 = list2[num3];
					num = 35;
					break;
				case 17:
					if (list == null)
					{
						num2 = 30;
						continue;
					}
					goto case 22;
				case 24:
					return;
				case 15:
				case 27:
				case 30:
					type = originalValue.GetType();
					num2 = 25;
					continue;
				case 7:
					if (obj == null)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 26;
						}
						continue;
					}
					goto case 21;
				case 8:
					t12FWXbwxIP0cHStqqQR(originalValue, changedValue);
					num2 = 9;
					continue;
				case 11:
					return;
				case 1:
					try
					{
						while (true)
						{
							IL_01b2:
							int num4;
							if (!enumerator.MoveNext())
							{
								num4 = 7;
								goto IL_013d;
							}
							goto IL_018a;
							IL_0224:
							num4 = 5;
							goto IL_013d;
							IL_018a:
							metadata = (IMetadata)x6dbYCbwzhCKBIc18K2h(enumerator);
							int num5 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
							{
								num5 = 6;
							}
							goto IL_0141;
							IL_013d:
							num5 = num4;
							goto IL_0141;
							IL_0141:
							while (true)
							{
								switch (num5)
								{
								case 7:
									return;
								default:
									if (!dictionary.TryGetValue(I0Iudqb4F0EZlx7Jst4p(metadata), out value))
									{
										num5 = 3;
										continue;
									}
									goto case 2;
								case 4:
									break;
								case 1:
								case 3:
								case 5:
									goto IL_01b2;
								case 2:
									t12FWXbwxIP0cHStqqQR(metadata, value);
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
									{
										num5 = 1;
									}
									continue;
								case 6:
									if (metadata != null)
									{
										goto default;
									}
									goto IL_0224;
								}
								break;
							}
							goto IL_018a;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								dyspilb4Bt72Hox3KSca(disposable);
								num6 = 2;
								continue;
							case 1:
								if (disposable != null)
								{
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
									{
										num6 = 0;
									}
									continue;
								}
								break;
							case 2:
								break;
							}
							break;
						}
					}
				case 29:
					type2 = @interface.GetGenericArguments()[0];
					num2 = 34;
					continue;
				case 36:
					enumerator = (IEnumerator)Go8t1YbwcyrmrFIupir5(list2);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					continue;
				case 18:
					list = changedValue as IList;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					continue;
				case 22:
					if (!V7TAiLbw0p9wWkfaglWw(@interface, null))
					{
						num2 = 15;
						continue;
					}
					goto case 29;
				case 13:
					if (obj2 == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 7;
				case 6:
					if (!V7TAiLbw0p9wWkfaglWw(type, typeof(string)))
					{
						num2 = 14;
						continue;
					}
					goto case 8;
				case 9:
					return;
				case 14:
					return;
				case 5:
				case 20:
					if (num3 >= KasWEjbw9KcgawurNDl0(list2))
					{
						num2 = 24;
						continue;
					}
					goto case 23;
				case 4:
					if (type2 != aGPSIvbwy3Y74JFFIJpU(typeof(string).TypeHandle))
					{
						num2 = 12;
						continue;
					}
					goto case 2;
				case 12:
					CopyChangesObject(obj2, obj);
					num2 = 19;
					continue;
				case 25:
					if (!type.IsClass)
					{
						return;
					}
					num2 = 6;
					continue;
				case 10:
					list2 = originalValue as IList;
					num2 = 18;
					continue;
				case 32:
					if (originalValue != null)
					{
						num = 31;
						break;
					}
					return;
				case 34:
					if (aGPSIvbwy3Y74JFFIJpU(typeof(IMetadata).TypeHandle).IsAssignableFrom(type2))
					{
						num2 = 3;
						continue;
					}
					goto case 16;
				case 16:
					if (KasWEjbw9KcgawurNDl0(list2) == KasWEjbw9KcgawurNDl0(list))
					{
						num3 = 0;
						num2 = 20;
					}
					else
					{
						num2 = 11;
					}
					continue;
				default:
					if (list2 == null)
					{
						num2 = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num2 = 27;
						}
						continue;
					}
					goto case 17;
				case 21:
					if (type2.IsClass)
					{
						num2 = 4;
						continue;
					}
					goto case 2;
				case 31:
					if (changedValue != null)
					{
						num = 28;
						break;
					}
					return;
				case 3:
					dictionary = list.OfType<IMetadata>().ToDictionary(GetMetadataUid);
					num2 = 36;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 30;
					}
					continue;
				case 2:
				case 19:
				case 26:
					num3++;
					num2 = 5;
					continue;
				case 35:
					obj = Q1oVfdbwMlemkmiSpSO0(list, num3);
					num2 = 13;
					continue;
				case 33:
					return;
				case 28:
					@interface = originalValue.GetType().GetInterface(aGPSIvbwy3Y74JFFIJpU(typeof(IList<>).TypeHandle).FullName);
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	private static bool HasOverrideInCustomCode(object classMetadata)
	{
		//Discarded unreachable code: IL_004d, IL_005c, IL_00b1, IL_01b4
		int num = 9;
		int num2 = num;
		SyntaxTree val = default(SyntaxTree);
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		IEnumerable<SyntaxNode> source;
		IEnumerable<SyntaxNode> enumerable = default(IEnumerable<SyntaxNode>);
		while (true)
		{
			switch (num2)
			{
			case 4:
			case 5:
				return false;
			case 6:
				val = SyntaxFactory.ParseSyntaxTree(_003C_003Ec__DisplayClass9_.classMetadata.CustomCode, (ParseOptions)null, "", (Encoding)KNvt2Nb4GvrPwBTXiM0Q(), (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
				if (!HvdjP8b4hLyfRjsVJ2pZ(BluEKib4b9IY5nMFN1Er(_003C_003Ec__DisplayClass9_.classMetadata), Guid.Empty))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 6;
					}
					continue;
				}
				goto case 4;
			case 7:
				if (_003C_003Ec__DisplayClass9_.classMetadata != null)
				{
					num2 = 3;
					continue;
				}
				goto case 4;
			case 3:
				if (PvE7krb4ofck2ur1MGKO(a7nfA4b4WCuZwIdK23AN(_003C_003Ec__DisplayClass9_.classMetadata)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto case 2;
			case 9:
				_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
				num2 = 8;
				continue;
			case 10:
				source = ((SyntaxNode)JxEHHmb4EQtOiIkaZCTf(val, default(CancellationToken))).ChildNodes().OfType<NamespaceDeclarationSyntax>().Where(_003C_003Ec__DisplayClass9_._003CHasOverrideInCustomCode_003Eb__0)
					.Cast<SyntaxNode>();
				break;
			case 8:
				_003C_003Ec__DisplayClass9_.classMetadata = (ClassMetadata)classMetadata;
				num2 = 7;
				continue;
			case 1:
				if (string.IsNullOrEmpty((string)x8jJwTbwaOvbxUhiC8OR(_003C_003Ec__DisplayClass9_.classMetadata)))
				{
					enumerable = (IEnumerable<SyntaxNode>)(object)new SyntaxNode[1] { (SyntaxNode)JxEHHmb4EQtOiIkaZCTf(val, default(CancellationToken)) };
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 10;
					}
				}
				continue;
			default:
				source = enumerable;
				break;
			}
			break;
		}
		return source.SelectMany(_003C_003Ec__DisplayClass9_._003CHasOverrideInCustomCode_003Eb__1).SelectMany((ClassDeclarationSyntax cd) => ((IEnumerable)(object)((TypeDeclarationSyntax)cd).get_Members()).OfType<PropertyDeclarationSyntax>()).Any((PropertyDeclarationSyntax p) => ((IEnumerable<SyntaxToken>)(object)_003C_003Ec.WEG6QUCtJwEViklcqIqu(p)).Any((SyntaxToken t) => (ushort)((SyntaxToken)(ref t)).get_RawKind() == 8355));
	}

	internal static PublicationType SbvKnGbwecdkQocg7TLw(object P_0, object P_1)
	{
		return ((IDeltaRootMetadata)P_0).GetPublicationTypeOnChange((IMetadata)P_1);
	}

	internal static bool fDTBcQbwOP2008YweNXD()
	{
		return lfB5lXbwn8aKsgMleV5m == null;
	}

	internal static MetadataSoftPublishHelper FvCmP2bw2Ycbkp1yKJA6()
	{
		return lfB5lXbwn8aKsgMleV5m;
	}

	internal static bool Cpes6qbwP24eOB4Wv4qB(object P_0)
	{
		return HasOverrideInCustomCode(P_0);
	}

	internal static object veucLrbw1caO6s10eb7I(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static void pDNnRrbwNTBdevDUL6qG(object P_0, Guid value)
	{
		((ClassMetadata)P_0).BaseClassUid = value;
	}

	internal static object wKGeE2bw3r2Shbr38oc0(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void xOnub5bwpX7TJEa4wDZ9(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static object x8jJwTbwaOvbxUhiC8OR(object P_0)
	{
		return ((ClassMetadata)P_0).Namespace;
	}

	internal static void Ci7mZ6bwDoFAnd3yV1Hm(object P_0, object P_1)
	{
		((ClassMetadata)P_0).Namespace = (string)P_1;
	}

	internal static void nEY4ksbwtT6DJ83E1Wvi(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static bool P5G6libwwvNuuIRaXRso(object P_0)
	{
		return ((EntityMetadata)P_0).SaveHistory;
	}

	internal static void wsSqrFbw4pQtRhTlmXf5(object P_0, bool value)
	{
		((EntityMetadata)P_0).SaveHistory = value;
	}

	internal static object Bu41kVbw6fjwqDyE7YSU(object P_0)
	{
		return ((EntityMetadata)P_0).Actions;
	}

	internal static void qFx12xbwH5mV9H7rWsxO(object P_0, object P_1)
	{
		((EntityMetadata)P_0).Actions = (EntityActionsMetadata)P_1;
	}

	internal static PublicationType HplEtdbwAUhv7VchUsBk(object P_0, object P_1)
	{
		return GetPublicationTypeOnChange((IMetadata)P_0, (IMetadata)P_1);
	}

	internal static bool Pd5lrebw7JRUMedpCLI1(object P_0)
	{
		return IsNewObjectDelta(P_0);
	}

	internal static void t12FWXbwxIP0cHStqqQR(object P_0, object P_1)
	{
		CopyChangesObject(P_0, P_1);
	}

	internal static bool V7TAiLbw0p9wWkfaglWw(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static PublicationType hms9j1bwm00qYlCMoVZn(object P_0, CheckType checkType, object P_2, object P_3)
	{
		return ((PublicationBehaviourAttribute)P_0).CheckProperty(checkType, P_2, P_3);
	}

	internal static Type aGPSIvbwy3Y74JFFIJpU(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Q1oVfdbwMlemkmiSpSO0(object P_0, int P_1)
	{
		return ((IList)P_0)[P_1];
	}

	internal static bool hmwGQQbwJavQUjxOqjtL(object P_0, PublicationType type)
	{
		return IsNewValuesDelta(P_0, type);
	}

	internal static int KasWEjbw9KcgawurNDl0(object P_0)
	{
		return ((ICollection)P_0).Count;
	}

	internal static bool k0qBcQbwdBHKF9eQWXj4(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object mCcEBebwlswWJ34tcNKK(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static Type m8QHF9bwroMk8RqBmY6C(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static object tdII1fbwge8Nt7wyeXtq(Type type)
	{
		return type.DefaultValue();
	}

	internal static Guid tJmh4lbw5teG2GMWpkwc(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static bool UE9fSEbwjGuLIyrZsTdy(object P_0, Type P_1, bool P_2)
	{
		return ((MemberInfo)P_0).IsDefined(P_1, P_2);
	}

	internal static bool LQ5JaVbwYN1fUk0ugj4L(object P_0)
	{
		return ((LocalizableAttribute)P_0).IsLocalizable;
	}

	internal static object Q0cdCZbwLHUgL8OcR3dl(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void oETQpDbwUuQKxRXETlHs(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static void fVYWYObwsC5iknvi5QXH(object P_0, object P_1)
	{
		CopyValues(P_0, P_1);
	}

	internal static object Go8t1YbwcyrmrFIupir5(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static object x6dbYCbwzhCKBIc18K2h(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static Guid I0Iudqb4F0EZlx7Jst4p(object P_0)
	{
		return GetMetadataUid((IMetadata)P_0);
	}

	internal static void dyspilb4Bt72Hox3KSca(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object a7nfA4b4WCuZwIdK23AN(object P_0)
	{
		return ((ClassMetadata)P_0).CustomCode;
	}

	internal static bool PvE7krb4ofck2ur1MGKO(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static Guid BluEKib4b9IY5nMFN1Er(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static bool HvdjP8b4hLyfRjsVJ2pZ(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object KNvt2Nb4GvrPwBTXiM0Q()
	{
		return Encoding.UTF8;
	}

	internal static object JxEHHmb4EQtOiIkaZCTf(object P_0, CancellationToken P_1)
	{
		return ((SyntaxTree)P_0).GetRoot(P_1);
	}
}
