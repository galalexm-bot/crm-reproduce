using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.PublicationBehaviours;

public sealed class NotRestartIfCollectionItemAddBehaviour : IPublicationBehaviourChecker
{
	internal static NotRestartIfCollectionItemAddBehaviour xOpmR0bru6yG83o5iuU2;

	public PublicationType Check(CheckType action, object oldValue, object newValue)
	{
		//Discarded unreachable code: IL_00fd, IL_010c, IL_011c, IL_017a, IL_0189, IL_01e7, IL_01f6, IL_0276, IL_0285, IL_0290, IL_02f8, IL_0373, IL_03e3, IL_03f2, IL_0402, IL_044b, IL_045e, IL_046d
		int num = 3;
		int num2 = num;
		IList list2 = default(IList);
		Dictionary<Guid, IMetadata> dictionary = default(Dictionary<Guid, IMetadata>);
		IList list = default(IList);
		Dictionary<Guid, IMetadata>.Enumerator enumerator = default(Dictionary<Guid, IMetadata>.Enumerator);
		Type @interface = default(Type);
		PublicationType result = default(PublicationType);
		PublicationType publicationType = default(PublicationType);
		KeyValuePair<Guid, IMetadata> current = default(KeyValuePair<Guid, IMetadata>);
		IMetadata value = default(IMetadata);
		while (true)
		{
			switch (num2)
			{
			case 4:
			{
				Dictionary<Guid, IMetadata> dictionary2 = list2.OfType<IMetadata>().ToDictionary(MetadataSoftPublishHelper.GetMetadataUid);
				dictionary = list.OfType<IMetadata>().ToDictionary(MetadataSoftPublishHelper.GetMetadataUid);
				enumerator = dictionary2.GetEnumerator();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 7;
				}
				break;
			}
			case 11:
				if (qA96axbrqiZNNi5B7Rku(list) != qA96axbrqiZNNi5B7Rku(list2))
				{
					num2 = 16;
					break;
				}
				return PublicationType.Soft;
			case 10:
				if ((list = newValue as IList) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 12:
				if (!iCbalnbriyjVUUQvCRFh(@interface, null))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 6;
			case 13:
				return PublicationType.Delta;
			case 1:
				return PublicationType.Soft;
			case 5:
			case 8:
			case 9:
			case 14:
				return PublicationType.Restart;
			case 2:
				if (action == CheckType.Change)
				{
					@interface = oldValue.GetType().GetInterface(S9cbOWbrSCp9FhlMGUuc(typeof(IList<>).TypeHandle).FullName);
					num2 = 12;
				}
				else
				{
					num2 = 9;
				}
				break;
			case 16:
				return PublicationType.Delta;
			case 15:
				if (!((IEnumerable<object>)list2).SequenceEqual((IEnumerable<object>)list))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 1;
			case 3:
				if (action != 0)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 13;
			case 6:
				if ((list2 = oldValue as IList) == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 14;
					}
					break;
				}
				goto case 10;
			default:
				if (!typeof(IMetadata).IsAssignableFrom(@interface.GetGenericArguments()[0]))
				{
					num2 = 15;
					break;
				}
				goto case 4;
			case 7:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 9;
							goto IL_0294;
						}
						goto IL_040c;
						IL_0294:
						while (true)
						{
							switch (num3)
							{
							case 8:
								return result;
							case 11:
								return result;
							case 12:
								return result;
							case 1:
								result = PublicationType.Restart;
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
								{
									num3 = 8;
								}
								continue;
							case 4:
							case 5:
								result = PublicationType.Restart;
								num3 = 12;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
								{
									num3 = 6;
								}
								continue;
							case 7:
								publicationType = i8STyibrRFa4K5qIj5t5(current.Value, value);
								num3 = 13;
								continue;
							case 10:
								break;
							case 3:
								if (!dictionary.TryGetValue(current.Key, out value))
								{
									num3 = 4;
									continue;
								}
								goto case 7;
							default:
								if (publicationType == PublicationType.Delta)
								{
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
									{
										num3 = 1;
									}
									continue;
								}
								break;
							case 13:
								if (publicationType == PublicationType.Restart)
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto default;
							case 2:
								result = PublicationType.Delta;
								num3 = 11;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
								{
									num3 = 0;
								}
								continue;
							case 6:
								goto IL_040c;
							case 9:
								goto end_IL_0339;
							}
							break;
						}
						continue;
						IL_040c:
						current = enumerator.Current;
						num3 = 3;
						goto IL_0294;
						continue;
						end_IL_0339:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 11;
			}
		}
	}

	public NotRestartIfCollectionItemAddBehaviour()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		UU8rrEbrKsdvcq6H8XDC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type S9cbOWbrSCp9FhlMGUuc(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool iCbalnbriyjVUUQvCRFh(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static PublicationType i8STyibrRFa4K5qIj5t5(object P_0, object P_1)
	{
		return MetadataSoftPublishHelper.IsEqualsObject(P_0, P_1);
	}

	internal static int qA96axbrqiZNNi5B7Rku(object P_0)
	{
		return ((ICollection)P_0).Count;
	}

	internal static bool w7WoT4brIMCm92Veybba()
	{
		return xOpmR0bru6yG83o5iuU2 == null;
	}

	internal static NotRestartIfCollectionItemAddBehaviour wMVYyYbrVn3FUPmtg88k()
	{
		return xOpmR0bru6yG83o5iuU2;
	}

	internal static void UU8rrEbrKsdvcq6H8XDC()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
