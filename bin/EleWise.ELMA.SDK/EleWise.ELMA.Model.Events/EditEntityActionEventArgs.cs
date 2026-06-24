using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Events;

[Uid("0654B7BC-81E6-4BEC-9227-E529104EB144")]
public class EditEntityActionEventArgs : EntityActionEventArgs
{
	public const string EventArgsUid_S = "0654B7BC-81E6-4BEC-9227-E529104EB144";

	public static readonly Guid EventArgsUid;

	private IEnumerable<string> dirtyProperties;

	private byte[] additionalData;

	private IList<PropertyMetadata> changedProperties;

	private static EditEntityActionEventArgs fIgSWkoF4PVh2uwanNRN;

	public IList<PropertyMetadata> ChangedProperties
	{
		get
		{
			if (changedProperties == null)
			{
				GetAdditionalData();
			}
			return changedProperties;
		}
	}

	protected EditEntityActionEventArgs(IEntity entity, Guid objectUid, Guid actionUid)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		MytiX8oFAHGkUJyvNx6s();
		base._002Ector(entity, objectUid, actionUid);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
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
			dirtyProperties = new string[0];
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
			{
				num = 0;
			}
		}
	}

	public EditEntityActionEventArgs(IEntity entity, IEntity newEntity, IEnumerable<string> dirtyProperties)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(entity, newEntity, DefaultEntityActions.UpdateGuid);
		this.dirtyProperties = dirtyProperties;
	}

	public EditEntityActionEventArgs(IEntity entity, IEntity newEntity, Guid actionUid)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(entity, newEntity, actionUid);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
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
			dirtyProperties = new string[0];
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
			{
				num = 1;
			}
		}
	}

	public static EditEntityActionEventArgs TryCreate(IEntity old, IEntity @new, string[] dirtyProperties)
	{
		//Discarded unreachable code: IL_003c, IL_00ce, IL_00dd, IL_0108, IL_0140, IL_014f
		EditEntityActionEventArgs result = default(EditEntityActionEventArgs);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				EditEntityActionEventArgs editEntityActionEventArgs = new EditEntityActionEventArgs(old, @new, dirtyProperties);
				int num = 5;
				while (true)
				{
					switch (num)
					{
					case 1:
						return result;
					case 3:
						return result;
					case 5:
						if (editEntityActionEventArgs.Action != null)
						{
							num = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
							{
								num = 0;
							}
							continue;
						}
						goto case 4;
					default:
						if (fJb2JeoF7Wu4RDZBEvEv(editEntityActionEventArgs) == null)
						{
							num = 4;
							continue;
						}
						break;
					case 4:
						result = null;
						num = 3;
						continue;
					case 2:
						break;
					}
					result = editEntityActionEventArgs;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num = 1;
					}
				}
			}
			catch
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						return result;
					}
					result = null;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
				}
			}
		}
	}

	public override byte[] GetAdditionalData()
	{
		//Discarded unreachable code: IL_0100, IL_010f, IL_0170, IL_017a, IL_0202, IL_0211, IL_031f, IL_0332, IL_0341, IL_038f
		int num = 13;
		int num2 = num;
		IMetadataRuntimeService serviceNotNull = default(IMetadataRuntimeService);
		Collection<PropertyCompareData> collection = default(Collection<PropertyCompareData>);
		ClassMetadata classMetadata = default(ClassMetadata);
		byte[] result = default(byte[]);
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		PropertyMetadata current = default(PropertyMetadata);
		PropertyCompareData compareData = default(PropertyCompareData);
		TypeDescriptor typeDescriptor = default(TypeDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 8:
				if (FZyQV0oFxTxj6XUdwORK(this) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 14;
			case 9:
				serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
				num2 = 4;
				break;
			case 13:
				if (additionalData == null)
				{
					num2 = 12;
					break;
				}
				goto case 2;
			case 2:
				return additionalData;
			case 12:
				collection = new Collection<PropertyCompareData>();
				num2 = 5;
				break;
			case 5:
				changedProperties = new List<PropertyMetadata>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 9;
				}
				break;
			case 14:
				if (iPTo01oF0oZpZrlkNyQM(this) != FZyQV0oFxTxj6XUdwORK(this))
				{
					num2 = 6;
					break;
				}
				goto default;
			case 6:
				classMetadata = MetadataLoader.LoadMetadata(iPTo01oF0oZpZrlkNyQM(this).GetType()) as ClassMetadata;
				num2 = 11;
				break;
			case 7:
				return result;
			default:
				result = (additionalData = (byte[])CHMF54oF957cV7W0kBn8(collection));
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 7;
				}
				break;
			case 10:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							goto IL_017e;
						}
						goto IL_02cd;
						IL_017e:
						while (true)
						{
							switch (num3)
							{
							default:
								changedProperties.Add(current);
								num3 = 8;
								continue;
							case 10:
								if (!CollectionExtensions.ByteArrayCompare((byte[])BnhyH3oFM2Jq6LSM4KR7(compareData), (byte[])mgEVUAoFJjOgeqJknM7C(compareData)))
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							case 2:
							case 6:
								break;
							case 7:
								if (!dirtyProperties.Contains((string)pn3BZxoFmJ9PN0RP2rpN(current)))
								{
									num3 = 2;
									continue;
								}
								goto case 1;
							case 4:
								if (typeDescriptor != null)
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
									{
										num3 = 5;
									}
									continue;
								}
								break;
							case 1:
								typeDescriptor = serviceNotNull.GetTypeDescriptor(M6IudcoFytMkoFrR2KRM(current), current.SubTypeUid) as TypeDescriptor;
								num3 = 4;
								continue;
							case 5:
								compareData = typeDescriptor.GetCompareData(iPTo01oF0oZpZrlkNyQM(this), New, classMetadata, current);
								num3 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
								{
									num3 = 8;
								}
								continue;
							case 9:
								goto IL_02cd;
							case 8:
								collection.Add(compareData);
								num3 = 6;
								continue;
							case 3:
								goto end_IL_021c;
							}
							break;
						}
						continue;
						IL_02cd:
						current = enumerator.Current;
						num3 = 7;
						goto IL_017e;
						continue;
						end_IL_021c:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto default;
			case 4:
				if (Old != null)
				{
					num2 = 8;
					break;
				}
				goto default;
			case 3:
				enumerator = classMetadata.Properties.GetEnumerator();
				num2 = 10;
				break;
			case 11:
				if (classMetadata != null)
				{
					num2 = 3;
					break;
				}
				goto default;
			}
		}
	}

	public override void SetAdditionalData(byte[] data)
	{
		//Discarded unreachable code: IL_00db, IL_00ea, IL_0123, IL_0132, IL_013d, IL_01ab, IL_01ba, IL_026b, IL_027e, IL_028d, IL_02f2, IL_0301, IL_0312, IL_0373, IL_0382, IL_0431, IL_04a4, IL_04b3, IL_0567, IL_0576, IL_05db, IL_05ea, IL_05f6, IL_0622, IL_06ca, IL_06d4, IL_078c, IL_079b, IL_07d2, IL_07e5
		int num = 26;
		ClassMetadata classMetadata = default(ClassMetadata);
		IEntity entity2 = default(IEntity);
		ClassMetadata classMetadata2 = default(ClassMetadata);
		IEntity entity3 = default(IEntity);
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		PropertyMetadata current = default(PropertyMetadata);
		TypeDescriptor typeDescriptor = default(TypeDescriptor);
		IEntity entity = default(IEntity);
		IMetadataRuntimeService serviceNotNull = default(IMetadataRuntimeService);
		IEnumerator<PropertyCompareData> enumerator2 = default(IEnumerator<PropertyCompareData>);
		PropertyCompareData current3 = default(PropertyCompareData);
		TypeDescriptor typeDescriptor3 = default(TypeDescriptor);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		Collection<PropertyCompareData> collection = default(Collection<PropertyCompareData>);
		PropertyMetadata current2 = default(PropertyMetadata);
		TypeDescriptor typeDescriptor2 = default(TypeDescriptor);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 4:
					classMetadata = MetadataLoader.LoadMetadata(entity2.GetType()) as ClassMetadata;
					num2 = 18;
					continue;
				case 26:
					if (data == null)
					{
						num2 = 25;
						continue;
					}
					goto case 7;
				case 18:
					classMetadata2 = MetadataLoader.LoadMetadata(entity3.GetType()) as ClassMetadata;
					num2 = 19;
					continue;
				case 16:
					enumerator = classMetadata2.Properties.GetEnumerator();
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 3;
					}
					continue;
				case 3:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
								{
									num3 = 2;
								}
								goto IL_0141;
							}
							goto IL_021c;
							IL_021c:
							current = enumerator.Current;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
							{
								num3 = 1;
							}
							goto IL_0141;
							IL_0141:
							while (true)
							{
								switch (num3)
								{
								case 4:
								case 5:
									break;
								case 6:
									typeDescriptor.Copy(entity, entity2, classMetadata, current);
									num3 = 4;
									continue;
								case 1:
									typeDescriptor = serviceNotNull.GetTypeDescriptor(M6IudcoFytMkoFrR2KRM(current), i4uo4joFr0KsuKh85ZJk(current)) as TypeDescriptor;
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
									{
										num3 = 0;
									}
									continue;
								default:
									if (typeDescriptor == null)
									{
										num3 = 5;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
										{
											num3 = 3;
										}
										continue;
									}
									goto case 6;
								case 3:
									goto IL_021c;
								case 2:
									goto end_IL_0167;
								}
								break;
							}
							continue;
							end_IL_0167:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto default;
				case 2:
				case 12:
				case 15:
					bhCiyQoFUpm0hZC3RORB(this, entity2);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 3;
					}
					continue;
				case 6:
					New = entity3;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 11;
					}
					continue;
				case 24:
					serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
					num2 = 10;
					continue;
				case 5:
					try
					{
						while (true)
						{
							IL_0466:
							int num7;
							if (!S2uvCnoFYwbd6jiXCkRD(enumerator2))
							{
								num7 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
								{
									num7 = 6;
								}
								goto IL_0320;
							}
							goto IL_03c3;
							IL_03c3:
							current3 = enumerator2.Current;
							num7 = 4;
							goto IL_0320;
							IL_0320:
							while (true)
							{
								int num8;
								switch (num7)
								{
								case 9:
									typeDescriptor3 = serviceNotNull.GetTypeDescriptor(M6IudcoFytMkoFrR2KRM(propertyMetadata), i4uo4joFr0KsuKh85ZJk(propertyMetadata)) as TypeDescriptor;
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
									{
										num7 = 0;
									}
									continue;
								case 16:
									break;
								case 13:
									propertyMetadata = classMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass12_._003CSetAdditionalData_003Eb__0);
									num7 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
									{
										num7 = 11;
									}
									continue;
								default:
									if (typeDescriptor3 == null)
									{
										num7 = 7;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
										{
											num7 = 10;
										}
										continue;
									}
									goto case 1;
								case 5:
								case 14:
									typeDescriptor3.SetCompareData(entity2, entity3, classMetadata, propertyMetadata, current3);
									num7 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
									{
										num7 = 7;
									}
									continue;
								case 2:
								case 3:
								case 7:
								case 10:
									goto IL_0466;
								case 12:
									_003C_003Ec__DisplayClass12_.cmp = current3;
									num7 = 13;
									continue;
								case 11:
									if (propertyMetadata == null)
									{
										num7 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
										{
											num7 = 1;
										}
										continue;
									}
									goto case 9;
								case 4:
									_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
									num7 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
									{
										num7 = 8;
									}
									continue;
								case 1:
									if (zEsMZ5oFjGpN0EPE7u8a(BnhyH3oFM2Jq6LSM4KR7(current3), mgEVUAoFJjOgeqJknM7C(current3)))
									{
										num8 = 5;
										goto IL_031c;
									}
									goto case 15;
								case 15:
									changedProperties.Add(propertyMetadata);
									num8 = 14;
									goto IL_031c;
								case 8:
									if (current3 == null)
									{
										num7 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
										{
											num7 = 0;
										}
										continue;
									}
									goto case 12;
								case 6:
									goto end_IL_0466;
									IL_031c:
									num7 = num8;
									continue;
								}
								break;
							}
							goto IL_03c3;
							continue;
							end_IL_0466:
							break;
						}
					}
					finally
					{
						int num10;
						if (enumerator2 == null)
						{
							int num9 = 2;
							num10 = num9;
							goto IL_059f;
						}
						goto IL_05b5;
						IL_059f:
						switch (num10)
						{
						default:
							goto end_IL_0586;
						case 1:
							break;
						case 2:
							goto end_IL_0586;
						case 0:
							goto end_IL_0586;
						}
						goto IL_05b5;
						IL_05b5:
						DjoOSeoFLBScJA8qjBPs(enumerator2);
						num10 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num10 = 0;
						}
						goto IL_059f;
						end_IL_0586:;
					}
					goto case 2;
				case 17:
					entity2 = (IEntity)sG9O0hoFlYyhjpR42GC8(entity.GetType());
					num2 = 22;
					continue;
				case 25:
					return;
				case 23:
					if (classMetadata2 == null)
					{
						goto end_IL_0012;
					}
					goto case 13;
				case 21:
					changedProperties = new List<PropertyMetadata>();
					num2 = 24;
					continue;
				case 19:
					if (classMetadata == null)
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 23;
				case 13:
					enumerator = classMetadata.Properties.GetEnumerator();
					num2 = 3;
					continue;
				case 14:
					enumerator2 = collection.GetEnumerator();
					num2 = 5;
					continue;
				case 22:
					entity3 = (IEntity)InterfaceActivator.Create(entity.GetType());
					num2 = 4;
					continue;
				case 11:
					return;
				case 8:
					try
					{
						while (true)
						{
							IL_0737:
							int num5;
							if (!enumerator.MoveNext())
							{
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
								{
									num5 = 1;
								}
								goto IL_06d8;
							}
							goto IL_06fe;
							IL_06fe:
							current2 = enumerator.Current;
							num5 = 4;
							goto IL_06d8;
							IL_06d8:
							while (true)
							{
								switch (num5)
								{
								case 6:
									break;
								case 4:
									typeDescriptor2 = o3FRWToFgSm9OZrATmXc(serviceNotNull, M6IudcoFytMkoFrR2KRM(current2), i4uo4joFr0KsuKh85ZJk(current2)) as TypeDescriptor;
									num5 = 2;
									continue;
								case 3:
								case 5:
									goto IL_0737;
								case 2:
									if (typeDescriptor2 == null)
									{
										num5 = 3;
										continue;
									}
									goto default;
								default:
									typeDescriptor2.Copy(entity, entity3, classMetadata2, current2);
									num5 = 5;
									continue;
								case 1:
									goto end_IL_0737;
								}
								break;
							}
							goto IL_06fe;
							continue;
							end_IL_0737:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 20;
				case 1:
					collection = (Collection<PropertyCompareData>)pqxT6loFdl2PK3A9s3Nc(data);
					num2 = 21;
					continue;
				default:
					entity2.SetId(entity.GetId());
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 16;
					}
					continue;
				case 20:
					Jsond6oF5g982iE0nyyu(entity3, entity.GetId());
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 14;
					}
					continue;
				case 7:
					additionalData = data;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 1;
					}
					continue;
				case 10:
					obj = FZyQV0oFxTxj6XUdwORK(this);
					if (obj == null)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num2 = 7;
						}
						continue;
					}
					break;
				case 9:
					obj = iPTo01oF0oZpZrlkNyQM(this);
					break;
				}
				entity = (IEntity)obj;
				num2 = 17;
				continue;
				end_IL_0012:
				break;
			}
			num = 12;
		}
	}

	public void SetPropertyDirty(string[] propertyNames)
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
				dirtyProperties = dirtyProperties.Union(propertyNames).Distinct();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	static EditEntityActionEventArgs()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				MytiX8oFAHGkUJyvNx6s();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				EventArgsUid = new Guid((string)PZoRX0oFsa8Z3VK3aTTc(0x3CE17B75 ^ 0x3CE33D77));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void MytiX8oFAHGkUJyvNx6s()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool u8Y3g8oF6HJq6C4SdRLl()
	{
		return fIgSWkoF4PVh2uwanNRN == null;
	}

	internal static EditEntityActionEventArgs xeQ6YroFHihRD715JTtp()
	{
		return fIgSWkoF4PVh2uwanNRN;
	}

	internal static object fJb2JeoF7Wu4RDZBEvEv(object P_0)
	{
		return ((AuditEventArgs)P_0).Object;
	}

	internal static object FZyQV0oFxTxj6XUdwORK(object P_0)
	{
		return ((EntityActionEventArgs)P_0).New;
	}

	internal static object iPTo01oF0oZpZrlkNyQM(object P_0)
	{
		return ((EntityActionEventArgs)P_0).Old;
	}

	internal static object pn3BZxoFmJ9PN0RP2rpN(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static Guid M6IudcoFytMkoFrR2KRM(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static object BnhyH3oFM2Jq6LSM4KR7(object P_0)
	{
		return ((PropertyCompareData)P_0).OldPropertyData;
	}

	internal static object mgEVUAoFJjOgeqJknM7C(object P_0)
	{
		return ((PropertyCompareData)P_0).NewPropertyData;
	}

	internal static object CHMF54oF957cV7W0kBn8(object P_0)
	{
		return ClassSerializationHelper.SerializeObject(P_0);
	}

	internal static object pqxT6loFdl2PK3A9s3Nc(object P_0)
	{
		return ClassSerializationHelper.DeserializeObject((byte[])P_0);
	}

	internal static object sG9O0hoFlYyhjpR42GC8(Type t)
	{
		return InterfaceActivator.Create(t);
	}

	internal static Guid i4uo4joFr0KsuKh85ZJk(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static object o3FRWToFgSm9OZrATmXc(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static void Jsond6oF5g982iE0nyyu(object P_0, object P_1)
	{
		((IIdentified)P_0).SetId(P_1);
	}

	internal static bool zEsMZ5oFjGpN0EPE7u8a(object P_0, object P_1)
	{
		return CollectionExtensions.ByteArrayCompare((byte[])P_0, (byte[])P_1);
	}

	internal static bool S2uvCnoFYwbd6jiXCkRD(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void DjoOSeoFLBScJA8qjBPs(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void bhCiyQoFUpm0hZC3RORB(object P_0, object P_1)
	{
		((EntityActionEventArgs)P_0).Old = (IEntity)P_1;
	}

	internal static object PZoRX0oFsa8Z3VK3aTTc(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
