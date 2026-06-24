using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Entities;
using EleWise.ELMA.Model.Services.Models;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Services.FindComponent;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Services;

[Service]
internal sealed class SearchFormService : ISearchFormServiceInternal, ISearchFormService
{
	private sealed class ExtendMetadataModel
	{
		internal static object IR2Tf2CkJOR40MFRTfaS;

		public EntityMetadata Metadata
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
					case 1:
						_003CMetadata_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
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

		public bool IsSystem
		{
			[CompilerGenerated]
			get
			{
				return _003CIsSystem_003Ek__BackingField;
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
						_003CIsSystem_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
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

		public EntityMetadata ConfigExtMetadata
		{
			[CompilerGenerated]
			get
			{
				return _003CConfigExtMetadata_003Ek__BackingField;
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
						_003CConfigExtMetadata_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
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

		public ExtendMetadataModel()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			a5ZPZ8Cklsyf1ye7V2kG();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool Lm88bdCk9CGF4xqtyG6R()
		{
			return IR2Tf2CkJOR40MFRTfaS == null;
		}

		internal static ExtendMetadataModel Ad64XICkdvyvnTr4NTxk()
		{
			return (ExtendMetadataModel)IR2Tf2CkJOR40MFRTfaS;
		}

		internal static void a5ZPZ8Cklsyf1ye7V2kG()
		{
			SingletonReader.PushGlobal();
		}
	}

	private readonly IEnumerable<IObjectFormProvider> objectFormProviders;

	private readonly IEntityScriptingService entityScriptingService;

	private readonly IFindComponentService findComponentService;

	private readonly MetadataItemHeaderManager metadataItemHeaderManager;

	private readonly IEnumerable<IEntityFilterProvider> entityFilterProviders;

	private readonly IMetadataRuntimeService metadataRuntimeService;

	private readonly IEnumerable<IPropertyViewItemAdjustmentRuntime2> propertyViewItemAdjustmentRuntime2;

	internal static SearchFormService NVBXMObQs7n5nhHFPcNr;

	public SearchFormService(IEnumerable<IObjectFormProvider> objectFormProviders, IEntityScriptingService entityScriptingService, IFindComponentService findComponentService, IMetadataRuntimeService metadataRuntimeService, MetadataItemHeaderManager metadataItemHeaderManager, IEnumerable<IEntityFilterProvider> entityFilterProviders, IEnumerable<IPropertyViewItemAdjustmentRuntime2> propertyViewItemAdjustmentRuntime2)
	{
		SingletonReader.PushGlobal();
		base._002Ector();
		this.objectFormProviders = objectFormProviders;
		this.entityScriptingService = entityScriptingService;
		this.findComponentService = findComponentService;
		this.metadataRuntimeService = metadataRuntimeService;
		this.metadataItemHeaderManager = metadataItemHeaderManager;
		this.entityFilterProviders = entityFilterProviders;
		this.propertyViewItemAdjustmentRuntime2 = propertyViewItemAdjustmentRuntime2;
	}

	public EntityFormView GetEntityForm(SearchForm searchForm)
	{
		//Discarded unreachable code: IL_01b2, IL_01c1, IL_024a, IL_02f8, IL_0307, IL_037d, IL_041d, IL_042c, IL_048b, IL_049a, IL_04cc, IL_04db, IL_04e6, IL_05e9, IL_0629, IL_0638, IL_0644, IL_0653, IL_06a6, IL_0790, IL_079f, IL_084a, IL_091f, IL_092e, IL_0939, IL_09de, IL_09fd, IL_0a29, IL_0a43, IL_0a60, IL_0a6f, IL_0ac3, IL_0ad2, IL_0b1f, IL_0b2e
		int num = 33;
		IEntity entity = default(IEntity);
		EntityMetadata entityMetadata = default(EntityMetadata);
		IEntity entity2 = default(IEntity);
		IEnumerator<EntityPropertyMetadata> enumerator = default(IEnumerator<EntityPropertyMetadata>);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		IEntityManager entityManager3 = default(IEntityManager);
		Guid guid3 = default(Guid);
		string entityId = default(string);
		long result5 = default(long);
		IObjectFormProvider objectFormProvider = default(IObjectFormProvider);
		ViewType viewType = default(ViewType);
		FormViewItem formViewItem = default(FormViewItem);
		IEntity value = default(IEntity);
		long result4 = default(long);
		IEntityManager entityManager2 = default(IEntityManager);
		Guid guid2 = default(Guid);
		EntityPropertyMetadata current = default(EntityPropertyMetadata);
		TypeSettings typeSettings = default(TypeSettings);
		Guid result6 = default(Guid);
		Type type = default(Type);
		IEnumerator<PropertyViewItem> enumerator2 = default(IEnumerator<PropertyViewItem>);
		IEntityManager entityManager = default(IEntityManager);
		long result2 = default(long);
		PropertyViewItem current2 = default(PropertyViewItem);
		Guid guid = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj3;
				switch (num2)
				{
				case 14:
				case 27:
				case 62:
					uhT9nvbC8XEotcgWAOkE(entity, AoKfN8bCvas366CIoNTT(entityMetadata), entity2);
					num2 = 34;
					continue;
				case 46:
					enumerator = ((IEnumerable<EntityPropertyMetadata>)entityMetadata.EntityProperties).GetEnumerator();
					num2 = 46;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 61;
					}
					continue;
				case 18:
					if ((entityMetadata = MetadataLoader.LoadMetadata(_003C_003Ec__DisplayClass8_.typeUid) as EntityMetadata) == null)
					{
						num = 51;
						break;
					}
					entityManager3 = (IEntityManager)BQ3mtHbCW3jnjRjS76dj(_003C_003Ec__DisplayClass8_.typeUid);
					num2 = 52;
					continue;
				case 57:
					entity.SetPropertyValue(i2tjS5bCGjRFLnydAysa(entityMetadata), true);
					num = 45;
					break;
				case 9:
					entity = entityManager3.Create() as IEntity;
					num = 43;
					break;
				case 25:
					if (jsqrinbCIK8sdkTxl6dt(guid3, Guid.Empty))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 17;
				case 4:
				case 29:
				case 34:
				case 60:
					if (long.TryParse(entityId, out result5))
					{
						num2 = 13;
						continue;
					}
					goto case 17;
				case 54:
					objectFormProvider.InitObject(entity, viewType, new Dictionary<string, object>());
					num2 = 46;
					continue;
				case 10:
					throw new ObjectNotFoundException(null, SR.T((string)kO2QWgbCBPnyI7kIw3yC(-1767720453 ^ -1767896263), wvBDtcbCo0cPB7BkBIwZ(entityMetadata)));
				case 49:
					viewType = rF3wRobCiayhppPUrq9P(searchForm);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 54;
					}
					continue;
				default:
					if (searchForm.IsGroup)
					{
						num2 = 34;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 57;
						}
						continue;
					}
					goto case 45;
				case 42:
					UYHxc4bCP6MAhhD5NcWD(formViewItem);
					num2 = 55;
					continue;
				case 12:
				case 16:
				case 21:
					entity.SetPropertyValue(entityMetadata.ParentPropertyUid, value);
					num2 = 35;
					continue;
				case 31:
				case 63:
					guid3 = HUevtDbCEeZ3JpEaD8jG(searchForm);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 25;
					}
					continue;
				case 52:
					if (entityManager3 == null)
					{
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num2 = 2;
						}
					}
					else
					{
						entityId = searchForm.EntityId;
						num2 = 3;
					}
					continue;
				case 56:
					if (result4 <= 0)
					{
						num2 = 39;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 38;
						}
						continue;
					}
					goto case 44;
				case 15:
					entityManager2 = (IEntityManager)BQ3mtHbCW3jnjRjS76dj(guid2);
					num = 19;
					break;
				case 28:
					entity = RsVG9ybCQTpQELLxRsc8(entityManager3) as IEntity;
					num2 = 40;
					continue;
				case 48:
					return ProcessEntityForm(entityMetadata, entity, formViewItem, viewType, byMmvQbCNnNWqa3hyegr(searchForm), searchForm.ExistingMetadataUids, searchForm.EntityDependencies);
				case 3:
					entity = null;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 1;
					}
					continue;
				case 44:
					entity2 = KNrYGnbCCiSmoJA56gwN(entityManager2, result4) as IEntity;
					num2 = 27;
					continue;
				case 17:
				case 22:
				case 35:
					if (entity != null)
					{
						num2 = 58;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 51;
						}
						continue;
					}
					goto case 24;
				case 5:
					uhT9nvbC8XEotcgWAOkE(entity, entityMetadata.IsGroupPropertyUid, true);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 63;
					}
					continue;
				case 45:
					guid2 = HUevtDbCEeZ3JpEaD8jG(searchForm);
					num2 = 59;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 32;
					}
					continue;
				case 61:
					try
					{
						while (true)
						{
							IL_050c:
							int num3;
							if (!doXQUvbCKpJCxq2dUjLd(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
								{
									num3 = 0;
								}
								goto IL_04ea;
							}
							goto IL_057f;
							IL_057f:
							current = enumerator.Current;
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
							{
								num3 = 2;
							}
							goto IL_04ea;
							IL_04ea:
							while (true)
							{
								switch (num3)
								{
								case 5:
									goto IL_050c;
								case 2:
									typeSettings = entity.LoadPropertyInstanceSettings(gGO6IVbCR2arCar1tH58(current));
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
									{
										num3 = 3;
									}
									continue;
								case 4:
									dr7toubCqbJExtv1jikV(current, typeSettings);
									num3 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
									{
										num3 = 4;
									}
									continue;
								case 1:
									goto IL_057f;
								case 3:
									if (typeSettings != null)
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
										{
											num3 = 4;
										}
										continue;
									}
									goto IL_050c;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator == null)
						{
							num4 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
							{
								num4 = 2;
							}
							goto IL_05ed;
						}
						goto IL_0603;
						IL_0603:
						enumerator.Dispose();
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num4 = 1;
						}
						goto IL_05ed;
						IL_05ed:
						switch (num4)
						{
						case 2:
							goto end_IL_05c8;
						case 1:
							goto end_IL_05c8;
						}
						goto IL_0603;
						end_IL_05c8:;
					}
					goto case 1;
				case 20:
					if (!XE5KAUbCugQiPUtWvVss(searchForm))
					{
						num = 31;
						break;
					}
					goto case 5;
				case 6:
				case 26:
					entity = HicQb8bCZkgew4GmdXbR(entityManager3, result6) as IEntity;
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 29;
					}
					continue;
				case 24:
					throw PublicServiceException.CreateWebFault(SR.T((string)kO2QWgbCBPnyI7kIw3yC(-138018305 ^ -138103847), wvBDtcbCo0cPB7BkBIwZ(entityMetadata), entityId), 404);
				case 58:
					objectFormProvider = objectFormProviders.FirstOrDefault(_003C_003Ec__DisplayClass8_._003CGetEntityForm_003Eb__0);
					num = 38;
					break;
				case 39:
					entity2 = RsVG9ybCQTpQELLxRsc8(entityManager2) as IEntity;
					num = 62;
					break;
				case 33:
					_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
					num2 = 32;
					continue;
				case 55:
				{
					IEnumerable<PropertyViewItem> allProperties = formViewItem.GetAllProperties();
					type = entity.GetType();
					enumerator2 = allProperties.GetEnumerator();
					num2 = 50;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 32;
					}
					continue;
				}
				case 47:
					value = KNrYGnbCCiSmoJA56gwN(entityManager, result2) as IEntity;
					num2 = 12;
					continue;
				case 51:
					throw new ObjectNotFoundException(null, SR.T((string)kO2QWgbCBPnyI7kIw3yC(0x61EC0CB8 ^ 0x61EEBDC8), _003C_003Ec__DisplayClass8_.typeUid));
				case 41:
					entity = X4SKK1bCSaaqcGBG5yA8(entityManager3, result5) as IEntity;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 17;
					}
					continue;
				case 7:
					entityManager = (IEntityManager)BQ3mtHbCW3jnjRjS76dj(guid3);
					num2 = 37;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					if (vEiGRIbCe3Nk8Sy74VSo(CMERd8bCOgsJhQUT369W(nTrkvEbCnV5NoX5GyC6r()), CMERd8bCOgsJhQUT369W(mmlXZ9bC2nK9fFe5Z0rs())))
					{
						num = 42;
						break;
					}
					goto case 55;
				case 36:
					if (!YTRWwQbCbOy9VwyXTlbM(result6, Guid.Empty))
					{
						num2 = 26;
						continue;
					}
					goto case 9;
				case 40:
					if (!TFbD63bChkwVFIRyJ5gZ(searchForm))
					{
						num2 = 22;
						continue;
					}
					goto case 20;
				case 43:
					if (!TFbD63bChkwVFIRyJ5gZ(searchForm))
					{
						num2 = 55;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 60;
						}
						continue;
					}
					goto default;
				case 23:
					throw new ObjectNotFoundException(null, SR.T((string)kO2QWgbCBPnyI7kIw3yC(-29254301 ^ -29152083), wvBDtcbCo0cPB7BkBIwZ(entityMetadata)));
				case 50:
					try
					{
						while (true)
						{
							int num5;
							if (!doXQUvbCKpJCxq2dUjLd(enumerator2))
							{
								num5 = 3;
								goto IL_093d;
							}
							goto IL_0995;
							IL_093d:
							while (true)
							{
								switch (num5)
								{
								case 2:
									FillFilterProvider(current2, type, entity, entityMetadata);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
									{
										num5 = 0;
									}
									continue;
								case 1:
									goto IL_0995;
								case 3:
									goto end_IL_0957;
								}
								break;
							}
							continue;
							IL_0995:
							current2 = enumerator2.Current;
							num5 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
							{
								num5 = 0;
							}
							goto IL_093d;
							continue;
							end_IL_0957:
							break;
						}
					}
					finally
					{
						int num6;
						if (enumerator2 == null)
						{
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
							{
								num6 = 1;
							}
							goto IL_09e2;
						}
						goto IL_0a07;
						IL_0a07:
						yv4bNobC1tcjD7gZeRNe(enumerator2);
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num6 = 0;
						}
						goto IL_09e2;
						IL_09e2:
						switch (num6)
						{
						default:
							goto end_IL_09bd;
						case 1:
							goto end_IL_09bd;
						case 2:
							break;
						case 0:
							goto end_IL_09bd;
						}
						goto IL_0a07;
						end_IL_09bd:;
					}
					goto case 48;
				case 53:
					obj3 = J7dosDbCT5dPcyvUnC7X(objectFormProvider, entity, viewType);
					goto IL_0c60;
				case 64:
					if (result2 <= 0)
					{
						num2 = 11;
						continue;
					}
					goto case 47;
				case 38:
					if (objectFormProvider != null)
					{
						num2 = 49;
						continue;
					}
					goto case 10;
				case 59:
					if (guid2 != Guid.Empty)
					{
						num2 = 15;
						continue;
					}
					goto case 4;
				case 11:
					value = entityManager.Create() as IEntity;
					num2 = 16;
					continue;
				case 1:
					guid = o7qlJtbCXEV3qOydG0EF(searchForm);
					num2 = 30;
					continue;
				case 30:
					if (!jsqrinbCIK8sdkTxl6dt(guid, Guid.Empty))
					{
						num2 = 53;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num2 = 48;
						}
						continue;
					}
					obj3 = z2k9DxbCksYItboeXJ1v(objectFormProvider, entity, guid);
					goto IL_0c60;
				case 32:
					_003C_003Ec__DisplayClass8_.typeUid = axsrr7bCFRb0l9fFVI0P(searchForm);
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 18;
					}
					continue;
				case 2:
					if (!Guid.TryParse(entityId, out result6))
					{
						num2 = 4;
						continue;
					}
					goto case 36;
				case 13:
					if (result5 <= 0)
					{
						num2 = 28;
						continue;
					}
					goto case 41;
				case 19:
				{
					object obj2 = Tf5ma0bCfdH7jofT80n6(searchForm);
					entity2 = null;
					if (Guid.TryParse((string)obj2, out var result3))
					{
						entity2 = ((!YTRWwQbCbOy9VwyXTlbM(result3, Guid.Empty)) ? (entityManager2.Load(result3) as IEntity) : (RsVG9ybCQTpQELLxRsc8(entityManager2) as IEntity));
					}
					if (!long.TryParse((string)obj2, out result4))
					{
						num2 = 14;
						continue;
					}
					goto case 56;
				}
				case 37:
					{
						object obj = Tf5ma0bCfdH7jofT80n6(searchForm);
						value = null;
						if (Guid.TryParse((string)obj, out var result))
						{
							value = ((!YTRWwQbCbOy9VwyXTlbM(result, Guid.Empty)) ? (lGNZdubCV4WqaNoqWvQu(entityManager, result) as IEntity) : (entityManager.Create() as IEntity));
						}
						if (!long.TryParse((string)obj, out result2))
						{
							num2 = 21;
							continue;
						}
						goto case 64;
					}
					IL_0c60:
					formViewItem = (FormViewItem)obj3;
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	public EntityFormView ProcessEntityForm(EntityForm entityForm)
	{
		return ProcessEntityForm((EntityMetadata)QrETUObC3dH1eddUDPUh(entityForm), (IEntity)KYPAKDbCp1DGZW7PT9QU(entityForm), entityForm.Form, null, entityForm.Debug, entityForm.ExistingMetadataUids, entityForm.EntityDependencies);
	}

	public void ClearCache()
	{
	}

	private EntityFormView ProcessEntityForm(EntityMetadata md, IEntity entity, FormViewItem viewItem, ViewType? viewType, bool debug, IEnumerable<Guid> existingMetadataUids, IEnumerable<EntityDependency> entityDependencies)
	{
		if (viewItem.RuntimeVersion != 0)
		{
			return ProcessEntityFormRuntimeVersion2(md, entity, viewItem, viewType, debug, existingMetadataUids, entityDependencies);
		}
		return ProcessEntityFormRuntimeVersion1(md, entity, viewItem);
	}

	private EntityFormView ProcessEntityFormRuntimeVersion1(EntityMetadata entityMetadata, IEntity entity, FormViewItem formViewItem)
	{
		int num = 1;
		string formOnLoadScriptName = default(string);
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		FormViewBuilderInfo formViewBuilderInfo = default(FormViewBuilderInfo);
		Dictionary<string, object> parameters = default(Dictionary<string, object>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					formOnLoadScriptName = GetFormOnLoadScriptName(_003C_003Ec__DisplayClass12_.formViewItem, entityMetadata);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					if (!gkAtcgbCa9JDCnZVBix9(formOnLoadScriptName))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 7;
				case 3:
					_003C_003Ec__DisplayClass12_.propertyContainer = null;
					num2 = 4;
					continue;
				case 1:
					_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					formViewBuilderInfo = DynamicFormHelper.GetFormViewBuilderInfo(_003C_003Ec__DisplayClass12_.propertyContainer);
					num2 = 5;
					continue;
				case 5:
				{
					EntityFormView entityFormView = new EntityFormView();
					Bew8CObCDq4WCRT4L0aK(entityFormView, new EntityJsonSerializer().Serialize(entity));
					swoMlbbCtBPFscP3wwZr(entityFormView, _003C_003Ec__DisplayClass12_.formViewItem);
					qRjQQLbCwst6yPO7K3Mt(entityFormView, entityMetadata);
					Fg0ddlbC402iiZ0hXWDV(entityFormView, formViewBuilderInfo);
					ModelInfo modelInfo = new ModelInfo();
					VtUXJ9bC6ThKdcpEID62(modelInfo, EntityMetadata.UID);
					o8Qed0bCHa07KeIstkHD(modelInfo, gGO6IVbCR2arCar1tH58(entityMetadata));
					entityFormView.ModelInfo = modelInfo;
					return entityFormView;
				}
				case 4:
					parameters = new Dictionary<string, object>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 6;
					}
					continue;
				case 2:
					entityScriptingService.ExecuteScript(entity, formOnLoadScriptName, parameters, _003C_003Ec__DisplayClass12_._003CProcessEntityFormRuntimeVersion1_003Eb__0);
					num2 = 7;
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass12_.formViewItem = formViewItem;
			num = 3;
		}
	}

	private EntityFormView ProcessEntityFormRuntimeVersion2(EntityMetadata entityMetadata, IEntity entity, FormViewItem formViewItem, ViewType? viewType, bool debug, IEnumerable<Guid> existingMetadataUids, IEnumerable<EntityDependency> clientEntityDependencies)
	{
		_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
		CS_0024_003C_003E8__locals0.existingMetadataUids = existingMetadataUids;
		CS_0024_003C_003E8__locals0.entityMetadata = entityMetadata;
		List<ClientScriptModel> clientScriptModels = new List<ClientScriptModel>();
		List<EnumDependency> list = new List<EnumDependency>();
		List<EntityDependency> list2 = new List<EntityDependency>();
		List<IMetadata> list3 = new List<IMetadata>();
		CS_0024_003C_003E8__locals0.excludeFromChooseMetadata = new HashSet<Guid>();
		ObjectFormFindComponentModel objectFormFindComponentModel = new ObjectFormFindComponentModel
		{
			Form = formViewItem,
			MetadataUid = CS_0024_003C_003E8__locals0.entityMetadata.Uid,
			MetadataDisplayName = CS_0024_003C_003E8__locals0.entityMetadata.DisplayName,
			ItemUid = CS_0024_003C_003E8__locals0.entityMetadata.Uid
		};
		Guid currentFormUid = formViewItem.Uid;
		foreach (ExtendMetadataModel metadataListWithParent in GetMetadataListWithParents(CS_0024_003C_003E8__locals0.entityMetadata))
		{
			EntityMetadata metadata = metadataListWithParent.Metadata;
			if (metadataListWithParent.IsSystem)
			{
				if (metadata.Uid != CS_0024_003C_003E8__locals0.entityMetadata.Uid)
				{
					CS_0024_003C_003E8__locals0.excludeFromChooseMetadata.Add(metadata.Uid);
					list3.Add(metadata);
				}
				EntityMetadata configExtMetadata = metadataListWithParent.ConfigExtMetadata;
				if (configExtMetadata?.ViewModelMetadata != null)
				{
					Guid uid = configExtMetadata.Uid;
					currentFormUid = ProcessMetadata(uid, currentFormUid, list, list2, clientScriptModels, objectFormFindComponentModel, debug);
					CS_0024_003C_003E8__locals0.excludeFromChooseMetadata.Add(configExtMetadata.Uid);
					list3.Add(configExtMetadata);
				}
			}
			else
			{
				Guid headerUid = ((metadata.Type == EntityMetadataType.InterfaceImplementation) ? metadata.ImplementationUid : metadata.Uid);
				currentFormUid = ProcessMetadata(headerUid, currentFormUid, list, list2, clientScriptModels, objectFormFindComponentModel, debug);
				if (metadata.Uid != CS_0024_003C_003E8__locals0.entityMetadata.Uid)
				{
					list3.Add(metadata);
					CS_0024_003C_003E8__locals0.excludeFromChooseMetadata.Add(metadata.Uid);
				}
			}
		}
		List<EntityDependency> list4 = new List<EntityDependency>();
		if (CS_0024_003C_003E8__locals0.entityMetadata.Hierarchical)
		{
			if (CS_0024_003C_003E8__locals0.entityMetadata.ParentPropertyUid != Guid.Empty)
			{
				list4.Add(new EntityDependency
				{
					HeaderUid = CS_0024_003C_003E8__locals0.entityMetadata.Uid,
					Name = CS_0024_003C_003E8__locals0.entityMetadata.Name,
					DisplayName = CS_0024_003C_003E8__locals0.entityMetadata.DisplayName,
					Properties = new List<PropertySignature>
					{
						new PropertySignature
						{
							Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1765823204),
							Uid = CS_0024_003C_003E8__locals0.entityMetadata.ParentPropertyUid
						}
					}
				});
			}
			if (CS_0024_003C_003E8__locals0.entityMetadata.IsGroupPropertyUid != Guid.Empty)
			{
				list4.Add(new EntityDependency
				{
					HeaderUid = CS_0024_003C_003E8__locals0.entityMetadata.Uid,
					Name = CS_0024_003C_003E8__locals0.entityMetadata.Name,
					DisplayName = CS_0024_003C_003E8__locals0.entityMetadata.DisplayName,
					Properties = new List<PropertySignature>
					{
						new PropertySignature
						{
							Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1875951681),
							Uid = CS_0024_003C_003E8__locals0.entityMetadata.IsGroupPropertyUid
						}
					}
				});
			}
		}
		RecursiveComponentModel recursiveComponentModel = findComponentService.FindComponent(objectFormFindComponentModel, new FindComponentOptions
		{
			ViewMode = InterfaceBuilderViewMode.Runtime
		});
		List<EntityDependency> list5 = DependencyHelper.CombineClassDependencies(list2.Concat(recursiveComponentModel.EntityDependencies).Concat(clientEntityDependencies).Concat(list4)).ToList();
		List<EntityMetadata> list6 = (from a in list5
			select MetadataLoader.LoadMetadata(_003C_003Ec.QO0LEVCnaDOCm1jy9vye(a)) as EntityMetadata into a
			where a != null
			select a).ToList();
		HashSet<EntityMetadata> hashSet = new HashSet<EntityMetadata>();
		foreach (EntityMetadata item in list6)
		{
			hashSet.Add(item);
			using (List<ClassMetadata>.Enumerator enumerator3 = MetadataLoader.GetChildClasses(item).GetEnumerator())
			{
				while (enumerator3.MoveNext())
				{
					_003C_003Ec__DisplayClass13_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass13_1();
					CS_0024_003C_003E8__locals1.childClass = enumerator3.Current;
					hashSet.Add((EntityMetadata)MetadataLoader.LoadMetadata(CS_0024_003C_003E8__locals1.childClass.Uid));
					if (!list5.Any((EntityDependency c) => _003C_003Ec__DisplayClass13_1.BAVNAuCnSxlk0s9fGfsk(_003C_003Ec__DisplayClass13_1.vKd9CBCnILZXkiYsLVSE(c), _003C_003Ec__DisplayClass13_1.UFDSRVCnVvtK7gOlaFDN(CS_0024_003C_003E8__locals1.childClass))))
					{
						list5.Add(new EntityDependency
						{
							HeaderUid = CS_0024_003C_003E8__locals1.childClass.Uid,
							Name = CS_0024_003C_003E8__locals1.childClass.Name,
							DisplayName = CS_0024_003C_003E8__locals1.childClass.DisplayName
						});
					}
				}
			}
			using List<ClassMetadata>.Enumerator enumerator3 = MetadataLoader.GetBaseClasses(item).GetEnumerator();
			while (enumerator3.MoveNext())
			{
				_003C_003Ec__DisplayClass13_2 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass13_2();
				CS_0024_003C_003E8__locals2.baseClass = enumerator3.Current;
				hashSet.Add((EntityMetadata)MetadataLoader.LoadMetadata(CS_0024_003C_003E8__locals2.baseClass.Uid));
				if (!list5.Any((EntityDependency c) => _003C_003Ec__DisplayClass13_2.LX8qXZCnTq8dLEt13D70(c.HeaderUid, _003C_003Ec__DisplayClass13_2.iRUADiCnXHJIfgsSTY26(CS_0024_003C_003E8__locals2.baseClass))))
				{
					list5.Add(new EntityDependency
					{
						HeaderUid = CS_0024_003C_003E8__locals2.baseClass.Uid,
						Name = CS_0024_003C_003E8__locals2.baseClass.Name,
						DisplayName = CS_0024_003C_003E8__locals2.baseClass.DisplayName
					});
				}
			}
		}
		HashSet<Guid> hashSet2 = new HashSet<Guid>();
		HashSet<Guid> hashSet3 = new HashSet<Guid>();
		EntityMetadata[] array = hashSet.Where(delegate(EntityMetadata m)
		{
			int num6 = 1;
			int num7 = num6;
			while (true)
			{
				switch (num7)
				{
				default:
					return !CS_0024_003C_003E8__locals0.excludeFromChooseMetadata.Contains(m.Uid);
				case 1:
					if (m == null)
					{
						return false;
					}
					num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num7 = 0;
					}
					break;
				}
			}
		}).ToArray();
		EntityMetadata[] array2 = array;
		foreach (EntityMetadata entityMetadata2 in array2)
		{
			hashSet2.Add(entityMetadata2.Uid);
		}
		IEnumerable<EntityMetadata> collection = array.Where((EntityMetadata m) => !CS_0024_003C_003E8__locals0.existingMetadataUids.Contains(_003C_003Ec__DisplayClass13_0.Hg6GRcCnEjVJTS3wZvf6(m)));
		list3.AddRange(collection);
		EnumMetadata[] array3 = (from a in DependencyHelper.CombineDependencies(list.Concat(recursiveComponentModel.EnumDependencies))
			select MetadataLoader.LoadMetadata(a.HeaderUid) as EnumMetadata into m
			where m != null
			select m).ToArray();
		EnumMetadata[] array4 = array3;
		foreach (EnumMetadata enumMetadata in array4)
		{
			hashSet3.Add(enumMetadata.Uid);
		}
		IEnumerable<EnumMetadata> collection2 = array3.Where((EnumMetadata m) => !CS_0024_003C_003E8__locals0.existingMetadataUids.Contains(_003C_003Ec__DisplayClass13_0.Hg6GRcCnEjVJTS3wZvf6(m)));
		list3.AddRange(collection2);
		foreach (Guid entityMetadataUid in recursiveComponentModel.EntityMetadataUids)
		{
			hashSet2.Add(entityMetadataUid);
		}
		foreach (Guid enumMetadataUid in recursiveComponentModel.EnumMetadataUids)
		{
			hashSet2.Add(enumMetadataUid);
		}
		EntitySerializationSettings entitySerializationSettings = new EntitySerializationSettings
		{
			WriteReferences = true
		};
		if (list5.Count == 0)
		{
			EntityDependency signature = CS_0024_003C_003E8__locals0.entityMetadata.GetSignature(simple: true);
			EntityPropertyMetadata uidProperty = CS_0024_003C_003E8__locals0.entityMetadata.GetUidProperty();
			if (uidProperty != null)
			{
				signature.Properties.Add(uidProperty.CreatePropertySignature());
			}
			list5.Add(signature);
		}
		else
		{
			EntityDependency entityDependency = list5.Find(delegate(EntityDependency a)
			{
				int num4 = 1;
				int num5 = num4;
				while (true)
				{
					switch (num5)
					{
					default:
						return _003C_003Ec__DisplayClass13_0.dvO5KmCnftWD3c1l3FBH(a) == _003C_003Ec__DisplayClass13_0.fWJ0vxCnCkRPigwOyVIe(CS_0024_003C_003E8__locals0.entityMetadata);
					case 1:
						if (_003C_003Ec__DisplayClass13_0.U4tERmCnQD0jhsV35qTq(_003C_003Ec__DisplayClass13_0.dvO5KmCnftWD3c1l3FBH(a), _003C_003Ec__DisplayClass13_0.Hg6GRcCnEjVJTS3wZvf6(CS_0024_003C_003E8__locals0.entityMetadata)))
						{
							return true;
						}
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num5 = 0;
						}
						break;
					}
				}
			});
			if (entityDependency == null)
			{
				entityDependency = CS_0024_003C_003E8__locals0.entityMetadata.GetSignature(simple: true);
				list5.Add(entityDependency);
			}
			if (entityDependency.Properties.Find((PropertySignature a) => _003C_003Ec.O3ORPbCntnx2tiP5uxxC(_003C_003Ec.KutplTCnDP4CEWuts8TL(a), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103F86E7))) == null)
			{
				EntityPropertyMetadata uidProperty2 = CS_0024_003C_003E8__locals0.entityMetadata.GetUidProperty();
				if (uidProperty2 != null)
				{
					entityDependency.Properties.Add(uidProperty2.CreatePropertySignature());
				}
			}
		}
		if (list5.Count > 0)
		{
			List<EntityDependency> source = list5.Where((EntityDependency a) => _003C_003Ec.DFk1lUCnwjw78YmNlDh4(a.Properties) > 0).ToList();
			entitySerializationSettings.Mode = EntitySerializationMode.Default;
			entitySerializationSettings.TypePropertySelector = source.ToDictionary((EntityDependency d) => _003C_003Ec.QO0LEVCnaDOCm1jy9vye(d), delegate(EntityDependency d)
			{
				//Discarded unreachable code: IL_00a7, IL_00b6, IL_00c5, IL_010d
				int num = 5;
				List<string> list7 = default(List<string>);
				EntityMetadata entityMetadata3 = default(EntityMetadata);
				IPropertyMetadata[] source2 = default(IPropertyMetadata[]);
				_003C_003Ec__DisplayClass13_3 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_3);
				string[] array5 = default(string[]);
				int num3 = default(int);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 8:
							return (EntitySerializationSelector)_003C_003Ec.ROVw2mCnHZirFRIOOBJA(string.Join((string)_003C_003Ec.RetRutCn4nfg9hVGhhtP(-1334993905 ^ -1334980865), list7), entityMetadata3);
						case 13:
							if (source2.FirstOrDefault(_003C_003Ec__DisplayClass13_._003CProcessEntityFormRuntimeVersion2_003Eb__15) != null)
							{
								num2 = 9;
								continue;
							}
							goto case 15;
						case 10:
							array5 = (string[])_003C_003Ec.FprBUyCn6fQ4YfUIMoJb(list7);
							num2 = 14;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
							{
								num2 = 13;
							}
							continue;
						default:
							if (num3 >= array5.Length)
							{
								num2 = 8;
								continue;
							}
							goto case 2;
						case 5:
							entityMetadata3 = MetadataLoader.LoadMetadata(d.HeaderUid) as EntityMetadata;
							num2 = 4;
							continue;
						case 16:
							list7.Add((string)_003C_003Ec.RetRutCn4nfg9hVGhhtP(-70037984 ^ -70049358));
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
							{
								num2 = 1;
							}
							continue;
						case 14:
							break;
						case 3:
						case 9:
							num3++;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
							{
								num2 = 0;
							}
							continue;
						case 1:
						case 12:
							source2 = entityMetadata3.GetPropertiesAndTableParts().ToArray();
							num2 = 10;
							continue;
						case 2:
							_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_3();
							num2 = 7;
							continue;
						case 6:
							if (list7.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146500431)))
							{
								num2 = 12;
								continue;
							}
							goto case 16;
						case 7:
							_003C_003Ec__DisplayClass13_.name = array5[num3];
							num2 = 13;
							continue;
						case 15:
							list7.Remove(_003C_003Ec__DisplayClass13_.name);
							num2 = 3;
							continue;
						case 4:
							list7 = d.Properties.Select((PropertySignature p) => (string)_003C_003Ec.KutplTCnDP4CEWuts8TL(p)).ToList();
							num2 = 6;
							continue;
						}
						break;
					}
					num3 = 0;
					num = 11;
				}
			});
		}
		ContextVars.Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112720530), new UIRuntimeModel());
		IEnumerable<ClientComponentModel> additionalModules = findComponentService.GetAdditionalModules();
		recursiveComponentModel.ComponentCache.AddRange(additionalModules);
		string model = new EntityJsonSerializer().Serialize(entity, entitySerializationSettings);
		EntityFormView entityFormView = new EntityFormView
		{
			Model = model,
			View = formViewItem,
			Metadata = CS_0024_003C_003E8__locals0.entityMetadata,
			AdditionalMetadata = list3,
			ModelInfo = new ModelInfo
			{
				TypeUid = EntityMetadata.UID,
				SubTypeUid = CS_0024_003C_003E8__locals0.entityMetadata.Uid
			},
			ClientScriptModels = clientScriptModels,
			RecursiveComponentModel = recursiveComponentModel,
			EntityDependencies = list5,
			EntityMetadataUids = hashSet2,
			EnumMetadataUids = hashSet3
		};
		if (viewType.HasValue)
		{
			AdjustFormPropertyViewItems(entityFormView.View, entity, viewType.Value);
		}
		return entityFormView;
	}

	private Guid ProcessMetadata(Guid headerUid, Guid currentFormUid, List<EnumDependency> enumDependencies, List<EntityDependency> entityDependencies, List<ClientScriptModel> clientScriptModels, ObjectFormFindComponentModel findComponentModel, bool debug)
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
		IMetadataItemHeader metadataItemHeader = metadataItemHeaderManager.LoadOrNull(headerUid, new string[3]
		{
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951355524),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541630293),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459464077)
		});
		if (metadataItemHeader?.Published == null)
		{
			throw new Exception();
		}
		CS_0024_003C_003E8__locals0.formUid = currentFormUid;
		if (metadataItemHeader.Published.Dependencies is MetadataDependencyContainer metadataDependencyContainer)
		{
			FormViewItemDependencyContainer formViewItemDependencyContainer = metadataDependencyContainer.FormDependencies.Find((FormViewItemDependencyContainer dep) => _003C_003Ec__DisplayClass14_0.GHkkbbCn0weRT8YPTySV(dep) == CS_0024_003C_003E8__locals0.formUid);
			if (formViewItemDependencyContainer != null)
			{
				enumDependencies.AddRange(formViewItemDependencyContainer.EnumDependencies);
				entityDependencies.AddRange(formViewItemDependencyContainer.EntityDependencies);
				findComponentModel.ComponentDependencies.AddRange(formViewItemDependencyContainer.ComponentDependencies);
				findComponentModel.DataClassDependencies.AddRange(formViewItemDependencyContainer.DataClassDependencies);
			}
			if (metadataItemHeader.Published.Metadata is EntityMetadata entityMetadata)
			{
				FormViewItemTransformation formViewItemTransformation = entityMetadata.FormTransformations.Find((FormViewItemTransformation transformation) => _003C_003Ec__DisplayClass14_0.dNwaG7CnyWOlCY2rKdix(_003C_003Ec__DisplayClass14_0.eQJY4FCnmTeytt9LTImm(transformation), CS_0024_003C_003E8__locals0.formUid));
				if (formViewItemTransformation != null)
				{
					CS_0024_003C_003E8__locals0.formUid = formViewItemTransformation.Uid;
					FormViewItemDependencyContainer formViewItemDependencyContainer2 = metadataDependencyContainer.FormDependencies.Find((FormViewItemDependencyContainer dep) => _003C_003Ec__DisplayClass14_0.dNwaG7CnyWOlCY2rKdix(_003C_003Ec__DisplayClass14_0.GHkkbbCn0weRT8YPTySV(dep), CS_0024_003C_003E8__locals0.formUid));
					if (formViewItemDependencyContainer2 != null)
					{
						enumDependencies.AddRange(formViewItemDependencyContainer2.EnumDependencies);
						entityDependencies.AddRange(formViewItemDependencyContainer2.EntityDependencies);
						findComponentModel.ComponentDependencies.AddRange(formViewItemDependencyContainer2.ComponentDependencies);
						findComponentModel.DataClassDependencies.AddRange(formViewItemDependencyContainer2.DataClassDependencies);
					}
				}
			}
			findComponentModel.FunctionDependencies.AddRange(metadataDependencyContainer.FunctionDependencies);
			findComponentModel.DataClassDependencies.AddRange(metadataDependencyContainer.DataClassDependencies);
		}
		ScriptModule clientScriptModule = metadataItemHeader.Published.ClientScriptModule;
		if (clientScriptModule != null)
		{
			byte[] array = (debug ? clientScriptModule.DebugRaw : clientScriptModule.AssemblyRaw);
			ClientScriptModel item = new ClientScriptModel
			{
				AssemblyName = clientScriptModule.AssemblyName,
				SourceCode = Encoding.UTF8.GetString(array ?? new byte[0])
			};
			clientScriptModels.Add(item);
			if (clientScriptModule.Dependencies is ScriptModuleDependencyContainer scriptModuleDependencyContainer)
			{
				enumDependencies.AddRange(scriptModuleDependencyContainer.EnumDependencies);
				entityDependencies.AddRange(scriptModuleDependencyContainer.EntityDependencies);
				findComponentModel.DataClassDependencies.AddRange(scriptModuleDependencyContainer.DataClassDependencies);
			}
		}
		return CS_0024_003C_003E8__locals0.formUid;
	}

	private List<ExtendMetadataModel> GetMetadataListWithParents(EntityMetadata entityMetadata)
	{
		List<ExtendMetadataModel> list = new List<ExtendMetadataModel>();
		EntityMetadata entityMetadata2 = entityMetadata;
		do
		{
			ExtendMetadataModel extendMetadataModel = new ExtendMetadataModel();
			extendMetadataModel.Metadata = entityMetadata2;
			extendMetadataModel.IsSystem = (entityMetadata2.IsInterfaceType ? entityMetadata2.Uid.IsSystemMetadata() : entityMetadata2.ImplementationUid.IsSystemMetadata());
			if (entityMetadata2.ImplementedExtensionUids != null)
			{
				extendMetadataModel.ConfigExtMetadata = (from uid in entityMetadata2.ImplementedExtensionUids.EmptyIfNull()
					where uid.IsConfigMetadata()
					select (EntityMetadata)metadataRuntimeService.GetMetadata(uid, loadImplementation: false)).FirstOrDefault();
			}
			list.Add(extendMetadataModel);
			if (entityMetadata2.BaseClassUid == Guid.Empty)
			{
				break;
			}
			entityMetadata2 = metadataRuntimeService.GetMetadata(entityMetadata2.BaseClassUid) as EntityMetadata;
		}
		while (entityMetadata2 != null);
		return list;
	}

	private string GetFormOnLoadScriptName(FormViewItem formViewItem, EntityMetadata entityMetadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (gkAtcgbCa9JDCnZVBix9(mcHbsmbCAJZo66OxZV79(formViewItem)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return (string)mcHbsmbCAJZo66OxZV79(formViewItem);
			default:
				return entityMetadata.OnViewLoadScriptName;
			}
		}
	}

	private void FillFilterProvider(PropertyViewItem propertyViewItem, Type containerType, IEntity entity, EntityMetadata contextMetadata)
	{
		//Discarded unreachable code: IL_0071, IL_0080, IL_0132, IL_0151, IL_017d, IL_018c, IL_019d, IL_01ac, IL_0216, IL_0245, IL_02e1, IL_0321, IL_032c, IL_033b, IL_03c2
		int num = 1;
		int num2 = num;
		Type item2 = default(Type);
		IEnumerator<PropertyViewItem> enumerator = default(IEnumerator<PropertyViewItem>);
		PropertyViewItem current = default(PropertyViewItem);
		IEnumerator<IEntityFilterProvider> enumerator2 = default(IEnumerator<IEntityFilterProvider>);
		string text = default(string);
		ViewAttributes attributes = default(ViewAttributes);
		IEntityFilterProvider current2 = default(IEntityFilterProvider);
		PropertyMetadata item = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (item2 != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 6;
			case 3:
				try
				{
					while (true)
					{
						IL_00e6:
						int num3;
						if (!doXQUvbCKpJCxq2dUjLd(enumerator))
						{
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
							{
								num3 = 0;
							}
							goto IL_008f;
						}
						goto IL_00c3;
						IL_00c3:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num3 = 0;
						}
						goto IL_008f;
						IL_008f:
						while (true)
						{
							switch (num3)
							{
							case 1:
							{
								FillFilterProvider(current, containerType, entity, contextMetadata);
								int num4 = 3;
								num3 = num4;
								continue;
							}
							case 3:
								goto IL_00e6;
							case 2:
								return;
							}
							break;
						}
						goto IL_00c3;
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num5 = 0;
						}
						goto IL_0136;
					}
					goto IL_015b;
					IL_015b:
					yv4bNobC1tcjD7gZeRNe(enumerator);
					num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num5 = 0;
					}
					goto IL_0136;
					IL_0136:
					switch (num5)
					{
					default:
						goto end_IL_0111;
					case 0:
						goto end_IL_0111;
					case 2:
						break;
					case 1:
						goto end_IL_0111;
					}
					goto IL_015b;
					end_IL_0111:;
				}
			case 7:
				try
				{
					while (true)
					{
						IL_028b:
						int num6;
						if (!doXQUvbCKpJCxq2dUjLd(enumerator2))
						{
							num6 = 5;
							goto IL_01bb;
						}
						goto IL_01e9;
						IL_01bb:
						while (true)
						{
							object obj;
							switch (num6)
							{
							case 8:
								if (text != null)
								{
									int num7 = 7;
									num6 = num7;
									continue;
								}
								goto IL_028b;
							case 4:
								goto end_IL_028b;
							case 1:
								attributes.EntityFilterData = text;
								num6 = 4;
								continue;
							case 6:
								obj = FTmqRRbC7qSf3kxTcbqR(current2, item2, item, attributes);
								goto IL_02af;
							case 7:
								rQ37XgbCmHirDitB6Ppr(attributes, vlc0MHbC0pPP99FILgJn(current2));
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
								{
									num6 = 1;
								}
								continue;
							case 3:
								if (!(current2 is IEntityInstanceFilterProvider entityInstanceFilterProvider))
								{
									num6 = 6;
									continue;
								}
								obj = B3cgO3bCx2ZkagPvFyl1(entityInstanceFilterProvider, entity, item2, item, attributes);
								goto IL_02af;
							case 2:
								goto IL_028b;
							case 5:
								goto end_IL_028b;
								IL_02af:
								text = (string)obj;
								num6 = 8;
								continue;
							}
							break;
						}
						goto IL_01e9;
						IL_01e9:
						current2 = enumerator2.Current;
						num6 = 3;
						goto IL_01bb;
						continue;
						end_IL_028b:
						break;
					}
				}
				finally
				{
					int num8;
					if (enumerator2 == null)
					{
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num8 = 1;
						}
						goto IL_02e5;
					}
					goto IL_02fb;
					IL_02fb:
					yv4bNobC1tcjD7gZeRNe(enumerator2);
					num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num8 = 0;
					}
					goto IL_02e5;
					IL_02e5:
					switch (num8)
					{
					default:
						goto end_IL_02c0;
					case 2:
						break;
					case 1:
						goto end_IL_02c0;
					case 0:
						goto end_IL_02c0;
					}
					goto IL_02fb;
					end_IL_02c0:;
				}
				goto case 6;
			case 4:
				enumerator2 = entityFilterProviders.GetEnumerator();
				num2 = 7;
				break;
			case 6:
			case 9:
				enumerator = propertyViewItem.Items.OfType<PropertyViewItem>().GetEnumerator();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				attributes = propertyViewItem.Attributes;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 4;
				}
				break;
			default:
				if (item == null)
				{
					num2 = 6;
					break;
				}
				goto case 5;
			case 8:
				return;
			case 1:
			{
				(PropertyMetadata, Type) tuple = FindProperty(containerType, contextMetadata, propertyViewItem.PropertyUid, propertyViewItem.PropertyParents);
				item = tuple.Item1;
				item2 = tuple.Item2;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	private (PropertyMetadata, Type) FindProperty(Type containerType, EntityMetadata entityMetadata, Guid propertyUid, IEnumerable<Guid> propertyParents)
	{
		_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass19_0();
		CS_0024_003C_003E8__locals0.propertyUid = propertyUid;
		PropertyMetadata propertyMetadata = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec__DisplayClass19_0.x8UyorCnrm7MpQTLFXhN(_003C_003Ec__DisplayClass19_0.mckPkaCnlofAManS0eCx(p), CS_0024_003C_003E8__locals0.propertyUid));
		if (propertyMetadata != null)
		{
			return (propertyMetadata, containerType);
		}
		DataClassMetadata viewModelMetadata = entityMetadata.ViewModelMetadata;
		if (viewModelMetadata != null)
		{
			propertyMetadata = viewModelMetadata.Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec__DisplayClass19_0.x8UyorCnrm7MpQTLFXhN(p.Uid, CS_0024_003C_003E8__locals0.propertyUid));
			if (propertyMetadata != null)
			{
				return (propertyMetadata, containerType);
			}
		}
		foreach (TablePartMetadata item in (IEnumerable<TablePartMetadata>)entityMetadata.EntityTableParts)
		{
			Type typeByUidOrNull = MetadataServiceContext.MetadataRuntimeService.GetTypeByUidOrNull(item.Uid);
			var (propertyMetadata2, type) = FindProperty(typeByUidOrNull, item, CS_0024_003C_003E8__locals0.propertyUid, propertyParents);
			if (propertyMetadata2 != null && type != null)
			{
				return (propertyMetadata2, type);
			}
		}
		return (null, null);
	}

	private void AdjustFormPropertyViewItems(ViewItem viewItem, IEntity entity, ViewType viewType)
	{
		//Discarded unreachable code: IL_0058, IL_0067, IL_00db, IL_00ea, IL_00f5, IL_01a4, IL_01b3, IL_01d4, IL_026f, IL_02a7
		int num = 3;
		int num2 = num;
		RootViewItem rootViewItem = default(RootViewItem);
		IEnumerator<ViewItem> enumerator = default(IEnumerator<ViewItem>);
		PropertyViewItem propertyViewItem = default(PropertyViewItem);
		ViewItem current = default(ViewItem);
		IEnumerator<IPropertyViewItemAdjustmentRuntime2> enumerator2 = default(IEnumerator<IPropertyViewItemAdjustmentRuntime2>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				return;
			case 2:
				if (rootViewItem == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					break;
				}
				enumerator = ((EventedList<ViewItem>)wfZcDibCytx2s4GGfufy(rootViewItem)).GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!doXQUvbCKpJCxq2dUjLd(enumerator))
						{
							num3 = 7;
							goto IL_0072;
						}
						goto IL_0232;
						IL_0072:
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 7:
								return;
							case 1:
								if (propertyViewItem != null)
								{
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
									{
										num4 = 2;
									}
									continue;
								}
								goto case 4;
							case 4:
								AdjustFormPropertyViewItems(current, entity, viewType);
								num4 = 6;
								continue;
							case 2:
								try
								{
									while (true)
									{
										int num5;
										if (!enumerator2.MoveNext())
										{
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
											{
												num5 = 0;
											}
											goto IL_00f9;
										}
										goto IL_010f;
										IL_010f:
										rEOVVJbCMrlmvOhA6LnL(enumerator2.Current, propertyViewItem, entity, viewType);
										num5 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
										{
											num5 = 0;
										}
										goto IL_00f9;
										IL_00f9:
										switch (num5)
										{
										case 2:
											goto IL_010f;
										case 1:
											continue;
										case 0:
											break;
										}
										break;
									}
								}
								finally
								{
									int num6;
									if (enumerator2 == null)
									{
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
										{
											num6 = 1;
										}
										goto IL_0189;
									}
									goto IL_01be;
									IL_01be:
									yv4bNobC1tcjD7gZeRNe(enumerator2);
									int num7 = 2;
									num6 = num7;
									goto IL_0189;
									IL_0189:
									switch (num6)
									{
									case 1:
										goto end_IL_0164;
									case 2:
										goto end_IL_0164;
									}
									goto IL_01be;
									end_IL_0164:;
								}
								break;
							case 6:
								break;
							case 3:
								enumerator2 = propertyViewItemAdjustmentRuntime2.GetEnumerator();
								num4 = 2;
								continue;
							case 5:
								propertyViewItem = current as PropertyViewItem;
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
								{
									num4 = 0;
								}
								continue;
							default:
								goto IL_0232;
							}
							break;
						}
						continue;
						IL_0232:
						current = enumerator.Current;
						num3 = 5;
						goto IL_0072;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num8 = 0;
						}
						while (true)
						{
							switch (num8)
							{
							default:
								yv4bNobC1tcjD7gZeRNe(enumerator);
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
								{
									num8 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 3:
				rootViewItem = viewItem as RootViewItem;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 2;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static Guid axsrr7bCFRb0l9fFVI0P(object P_0)
	{
		return ((SearchForm)P_0).TypeUid;
	}

	internal static object kO2QWgbCBPnyI7kIw3yC(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object BQ3mtHbCW3jnjRjS76dj(Guid uid)
	{
		return ModelHelper.GetEntityManager(uid);
	}

	internal static object wvBDtcbCo0cPB7BkBIwZ(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static bool YTRWwQbCbOy9VwyXTlbM(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool TFbD63bChkwVFIRyJ5gZ(object P_0)
	{
		return ((SearchForm)P_0).Hierarchical;
	}

	internal static Guid i2tjS5bCGjRFLnydAysa(object P_0)
	{
		return ((EntityMetadata)P_0).IsGroupPropertyUid;
	}

	internal static Guid HUevtDbCEeZ3JpEaD8jG(object P_0)
	{
		return ((SearchForm)P_0).ParentTypeUid;
	}

	internal static object Tf5ma0bCfdH7jofT80n6(object P_0)
	{
		return ((SearchForm)P_0).ParentEntityId;
	}

	internal static object RsVG9ybCQTpQELLxRsc8(object P_0)
	{
		return ((IEntityManager)P_0).Create();
	}

	internal static object KNrYGnbCCiSmoJA56gwN(object P_0, object P_1)
	{
		return ((IEntityManager)P_0).Load(P_1);
	}

	internal static Guid AoKfN8bCvas366CIoNTT(object P_0)
	{
		return ((EntityMetadata)P_0).ParentPropertyUid;
	}

	internal static void uhT9nvbC8XEotcgWAOkE(object P_0, Guid propertyUid, object P_2)
	{
		((IEntity)P_0).SetPropertyValue(propertyUid, P_2);
	}

	internal static object HicQb8bCZkgew4GmdXbR(object P_0, Guid uid)
	{
		return ((IEntityManager)P_0).LoadOrNull(uid);
	}

	internal static bool XE5KAUbCugQiPUtWvVss(object P_0)
	{
		return ((SearchForm)P_0).IsGroup;
	}

	internal static bool jsqrinbCIK8sdkTxl6dt(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object lGNZdubCV4WqaNoqWvQu(object P_0, Guid uid)
	{
		return ((IEntityManager)P_0).Load(uid);
	}

	internal static object X4SKK1bCSaaqcGBG5yA8(object P_0, object P_1)
	{
		return ((IEntityManager)P_0).LoadOrNull(P_1);
	}

	internal static ViewType rF3wRobCiayhppPUrq9P(object P_0)
	{
		return ((SearchForm)P_0).ViewType;
	}

	internal static Guid gGO6IVbCR2arCar1tH58(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void dr7toubCqbJExtv1jikV(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).Settings = (TypeSettings)P_1;
	}

	internal static bool doXQUvbCKpJCxq2dUjLd(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static Guid o7qlJtbCXEV3qOydG0EF(object P_0)
	{
		return ((SearchForm)P_0).FormUid;
	}

	internal static object J7dosDbCT5dPcyvUnC7X(object P_0, object P_1, ViewType viewType)
	{
		return ((IObjectFormProvider)P_0).GetFormByType(P_1, viewType);
	}

	internal static object z2k9DxbCksYItboeXJ1v(object P_0, object P_1, Guid formUid)
	{
		return ((IObjectFormProvider)P_0).GetFormByUid(P_1, formUid);
	}

	internal static object nTrkvEbCnV5NoX5GyC6r()
	{
		return SR.GetCurrentCulture();
	}

	internal static object CMERd8bCOgsJhQUT369W(object P_0)
	{
		return ((CultureInfo)P_0).Name;
	}

	internal static object mmlXZ9bC2nK9fFe5Z0rs()
	{
		return SR.KeyCultureInfo;
	}

	internal static bool vEiGRIbCe3Nk8Sy74VSo(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void UYHxc4bCP6MAhhD5NcWD(object P_0)
	{
		((ViewItem)P_0).ApplyLocalization();
	}

	internal static void yv4bNobC1tcjD7gZeRNe(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool byMmvQbCNnNWqa3hyegr(object P_0)
	{
		return ((SearchForm)P_0).Debug;
	}

	internal static bool zOHWC6bQcXpDIY2FLCO1()
	{
		return NVBXMObQs7n5nhHFPcNr == null;
	}

	internal static SearchFormService eFvsSKbQzP0A5WFXtHQV()
	{
		return NVBXMObQs7n5nhHFPcNr;
	}

	internal static object QrETUObC3dH1eddUDPUh(object P_0)
	{
		return ((EntityForm)P_0).Metadata;
	}

	internal static object KYPAKDbCp1DGZW7PT9QU(object P_0)
	{
		return ((EntityForm)P_0).Entity;
	}

	internal static bool gkAtcgbCa9JDCnZVBix9(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void Bew8CObCDq4WCRT4L0aK(object P_0, object P_1)
	{
		((EntityFormView)P_0).Model = (string)P_1;
	}

	internal static void swoMlbbCtBPFscP3wwZr(object P_0, object P_1)
	{
		((EntityFormView)P_0).View = (FormViewItem)P_1;
	}

	internal static void qRjQQLbCwst6yPO7K3Mt(object P_0, object P_1)
	{
		((EntityFormView)P_0).Metadata = (IMetadata)P_1;
	}

	internal static void Fg0ddlbC402iiZ0hXWDV(object P_0, object P_1)
	{
		((EntityFormView)P_0).FormViewBuilderInfo = (FormViewBuilderInfo)P_1;
	}

	internal static void VtUXJ9bC6ThKdcpEID62(object P_0, Guid value)
	{
		((ModelInfo)P_0).TypeUid = value;
	}

	internal static void o8Qed0bCHa07KeIstkHD(object P_0, Guid value)
	{
		((ModelInfo)P_0).SubTypeUid = value;
	}

	internal static object mcHbsmbCAJZo66OxZV79(object P_0)
	{
		return ((FormView)P_0).OnLoadScriptName;
	}

	internal static object FTmqRRbC7qSf3kxTcbqR(object P_0, Type entityType, object P_2, object P_3)
	{
		return ((IEntityFilterProvider)P_0).GetFilterProviderData(entityType, (PropertyMetadata)P_2, (ViewAttributes)P_3);
	}

	internal static object B3cgO3bCx2ZkagPvFyl1(object P_0, object P_1, Type entityType, object P_3, object P_4)
	{
		return ((IEntityInstanceFilterProvider)P_0).GetFilterProviderData((IEntity)P_1, entityType, (PropertyMetadata)P_3, (ViewAttributes)P_4);
	}

	internal static Guid vlc0MHbC0pPP99FILgJn(object P_0)
	{
		return ((IEntityFilterProvider)P_0).ProviderUid;
	}

	internal static void rQ37XgbCmHirDitB6Ppr(object P_0, Guid value)
	{
		((ViewAttributes)P_0).EntityFilterProvider = value;
	}

	internal static object wfZcDibCytx2s4GGfufy(object P_0)
	{
		return ((RootViewItem)P_0).Items;
	}

	internal static void rEOVVJbCMrlmvOhA6LnL(object P_0, object P_1, object P_2, ViewType viewType)
	{
		((IPropertyViewItemAdjustmentRuntime2)P_0).Adjust((PropertyViewItem)P_1, P_2, viewType);
	}
}
