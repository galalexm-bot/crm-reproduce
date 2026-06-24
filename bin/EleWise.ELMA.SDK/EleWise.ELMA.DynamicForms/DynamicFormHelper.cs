using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Common;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using Iesi.Collections;
using Iesi.Collections.Generic;
using Newtonsoft.Json;
using NHibernate.Collection;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.DynamicForms;

public static class DynamicFormHelper
{
	internal const string ParentFormPrefix = "ParentB5857BD3_6DBE_48F0_9489_FD6C08F1528E";

	internal const string Separator = "-BEFE1D44-62F6-457E-B628-F6CDC62FC2C9-";

	internal const string FormActionsProviderId = "EleWise.ELMA.Web.Components.FormActionProvider";

	private static IMetadataRuntimeService metadataRuntimeService;

	internal static DynamicFormHelper QDnTn9OTtnmGr7FGCxv;

	private static IMetadataRuntimeService MetadataRuntimeService
	{
		get
		{
			int num = 1;
			int num2 = num;
			IMetadataRuntimeService obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = metadataRuntimeService;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = (metadataRuntimeService = Locator.GetServiceNotNull<IMetadataRuntimeService>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	public static bool ClosePopup
	{
		get
		{
			int num = 1;
			int num2 = num;
			bool value = default(bool);
			while (true)
			{
				switch (num2)
				{
				default:
					return value;
				case 1:
					ContextVars.TryGetValue<bool>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CB2813), out value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
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
				case 1:
					ContextVars.Set((string)R4jn40OOW7stH3wiytf(0x4EDCBA32 ^ 0x4EDCD46A), value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
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

	[Obsolete("Метод устарел, используйте GetContextNotifyMvcMessages")]
	public static List<KeyValuePair<string, string>> GetContextNotifyMessages()
	{
		ContextVars.TryGetValue<FormNotifier>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x36309DBD), out var value);
		return value?.Messages;
	}

	public static List<KeyValuePair<string, MvcHtmlString>> GetContextNotifyMvcMessages()
	{
		ContextVars.TryGetValue<FormNotifier>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A77F96B), out var value);
		return value?.MvcMessages;
	}

	public static IFormNotifier GetContextFormNotifier()
	{
		int num = 4;
		FormNotifier value = default(FormNotifier);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (value == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto default;
				case 1:
					ContextVars.Set((string)R4jn40OOW7stH3wiytf(0x2ACE37D ^ 0x2AC8DA1), value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					return value;
				case 2:
					value = new FormNotifier();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					break;
				}
				break;
			}
			ContextVars.TryGetValue<FormNotifier>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583750104), out value);
			num = 3;
		}
	}

	public static FormViewBuilderInfo GetFormViewBuilderInfo(PropertyViewInfoContainer propertyContainer)
	{
		//Discarded unreachable code: IL_0068, IL_00c5, IL_00d4, IL_0179, IL_0188, IL_0276, IL_02ae, IL_0305, IL_0314, IL_037f, IL_038e, IL_0399, IL_0476, IL_0489
		int num = 5;
		int num2 = num;
		FormViewBuilderInfo formViewBuilderInfo = default(FormViewBuilderInfo);
		IEnumerator<PropertyViewInfo> enumerator2 = default(IEnumerator<PropertyViewInfo>);
		PropertyViewInfo current2 = default(PropertyViewInfo);
		bool? flag = default(bool?);
		List<KeyValuePair<string, MvcHtmlString>>.Enumerator enumerator = default(List<KeyValuePair<string, MvcHtmlString>>.Enumerator);
		List<KeyValuePair<string, MvcHtmlString>> contextNotifyMvcMessages = default(List<KeyValuePair<string, MvcHtmlString>>);
		KeyValuePair<string, MvcHtmlString> current = default(KeyValuePair<string, MvcHtmlString>);
		NotificationType result = default(NotificationType);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 7:
				LgZAI0Oe16njA87xmwd(formViewBuilderInfo, ClosePopup);
				num2 = 3;
				break;
			case 1:
				try
				{
					while (true)
					{
						IL_021e:
						int num5;
						if (!OZjnAqO2BlE7BGG7gQU(enumerator2))
						{
							num5 = 14;
							goto IL_0076;
						}
						goto IL_0192;
						IL_0076:
						while (true)
						{
							int num6;
							switch (num5)
							{
							case 4:
								if (current2.Settings == null)
								{
									num5 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
									{
										num5 = 8;
									}
									continue;
								}
								goto case 6;
							case 13:
								if (!flag.HasValue)
								{
									num5 = 9;
									continue;
								}
								goto case 6;
							case 1:
								flag = current2.Required;
								num5 = 11;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
								{
									num5 = 13;
								}
								continue;
							case 12:
								flag = current2.ReadOnly;
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
								{
									num5 = 0;
								}
								continue;
							case 9:
								flag = current2.Visible;
								num5 = 2;
								continue;
							case 15:
								break;
							case 2:
								if (flag.HasValue)
								{
									num5 = 11;
									continue;
								}
								goto case 12;
							default:
								if (flag.HasValue)
								{
									num5 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
									{
										num5 = 6;
									}
									continue;
								}
								goto case 5;
							case 3:
								if (!flag.HasValue)
								{
									num6 = 4;
									goto IL_0072;
								}
								goto case 6;
							case 5:
								flag = current2.IsValid;
								num5 = 3;
								continue;
							case 7:
							case 8:
								goto IL_021e;
							case 6:
							case 10:
							case 11:
								formViewBuilderInfo.Properties.Add(current2);
								num6 = 7;
								goto IL_0072;
							case 14:
								goto end_IL_021e;
								IL_0072:
								num5 = num6;
								continue;
							}
							break;
						}
						goto IL_0192;
						IL_0192:
						current2 = enumerator2.Current;
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
						{
							num5 = 1;
						}
						goto IL_0076;
						continue;
						end_IL_021e:
						break;
					}
				}
				finally
				{
					if (enumerator2 != null)
					{
						int num7 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
						{
							num7 = 0;
						}
						while (true)
						{
							switch (num7)
							{
							case 1:
								enumerator2.Dispose();
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
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
				goto case 8;
			case 11:
				enumerator = contextNotifyMvcMessages.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
			case 9:
				contextNotifyMvcMessages = GetContextNotifyMvcMessages();
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 6;
				}
				break;
			case 5:
				formViewBuilderInfo = new FormViewBuilderInfo();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				enumerator2 = propertyContainer.GetAll().GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (propertyContainer == null)
				{
					num2 = 8;
					break;
				}
				goto case 10;
			case 3:
				return formViewBuilderInfo;
			default:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							goto IL_039d;
						}
						goto IL_0437;
						IL_039d:
						while (true)
						{
							switch (num3)
							{
							case 3:
								if (Enum.TryParse<NotificationType>(current.Key, out result))
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							case 4:
								break;
							default:
								formViewBuilderInfo.Notifications.Add(new NotificationInfo(((object)current.Value).ToString(), result));
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
								{
									num3 = 4;
								}
								continue;
							case 1:
								goto IL_0437;
							case 2:
								goto end_IL_03e8;
							}
							break;
						}
						continue;
						IL_0437:
						current = enumerator.Current;
						num3 = 3;
						goto IL_039d;
						continue;
						end_IL_03e8:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 2;
			case 6:
				if (contextNotifyMvcMessages == null)
				{
					num2 = 7;
					break;
				}
				goto case 11;
			}
		}
	}

	public static DynamicFormResult ExecuteScript([NotNull] IEntity entity, [NotNull] DynamicFormSettings settings, RootViewItem view, string scriptName)
	{
		return ExecuteScript(entity, settings, view, scriptName, (object)null);
	}

	public static DynamicFormResult ExecuteScript([NotNull] IEntity entity, [NotNull] DynamicFormSettings settings, RootViewItem view, string scriptName, object originalStateObj)
	{
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return ExecuteScript(_003C_003Ec__DisplayClass16_.entity, _003C_003Ec__DisplayClass16_.settings, view, originalStateObj, _003C_003Ec__DisplayClass16_._003CExecuteScript_003Eb__1);
			default:
				return null;
			case 6:
				if (_003C_003Ec__DisplayClass16_.provider != null)
				{
					_003C_003Ec__DisplayClass16_.sn = scriptName;
					num2 = 2;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
				num2 = 3;
				break;
			case 5:
				_003C_003Ec__DisplayClass16_.entity = entity;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass16_.provider = ((ComponentManager)AVePmvOPq14pBfYiTJ5()).GetExtensionPoints<IDynamicFormsProvider>().FirstOrDefault(_003C_003Ec__DisplayClass16_._003CExecuteScript_003Eb__0);
				num2 = 6;
				break;
			case 3:
				_003C_003Ec__DisplayClass16_.settings = settings;
				num2 = 5;
				break;
			}
		}
	}

	public static DynamicFormResult ExecuteScript([NotNull] IEntity entity, [NotNull] DynamicFormSettings settings, RootViewItem view, object originalStateObj, Action<RootViewItem, DynamicFormResultData> executeScriptAction)
	{
		return ExecuteScript(entity, settings, view, originalStateObj, executeScriptAction, null);
	}

	public static DynamicFormResult ExecuteScript([NotNull] IEntity entity, [NotNull] DynamicFormSettings settings, RootViewItem view, string scriptName, object originalStateObj, IDictionary<string, object> realrootEntityState)
	{
		_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_0();
		CS_0024_003C_003E8__locals0.settings = settings;
		CS_0024_003C_003E8__locals0.entity = entity;
		CS_0024_003C_003E8__locals0.provider = ComponentManager.Current.GetExtensionPoints<IDynamicFormsProvider>().FirstOrDefault((IDynamicFormsProvider p) => _003C_003Ec__DisplayClass18_0.IVt1WafmprYDuFjWSj70(_003C_003Ec__DisplayClass18_0.CUMYaVfm3HFw4tUSYWFQ(p), CS_0024_003C_003E8__locals0.settings.DynamicFormsProviderUid));
		if (CS_0024_003C_003E8__locals0.provider == null)
		{
			return null;
		}
		CS_0024_003C_003E8__locals0.sn = scriptName;
		return ExecuteScript(CS_0024_003C_003E8__locals0.entity, CS_0024_003C_003E8__locals0.settings, view, originalStateObj, delegate(RootViewItem v, DynamicFormResultData data)
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
					CS_0024_003C_003E8__locals0.provider.ExecuteScript(CS_0024_003C_003E8__locals0.entity, v, CS_0024_003C_003E8__locals0.settings, CS_0024_003C_003E8__locals0.sn, data);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}, realrootEntityState);
	}

	public static DynamicFormResult ExecuteScript([NotNull] IEntity entity, [NotNull] DynamicFormSettings settings, RootViewItem view, object originalStateObj, Action<RootViewItem, DynamicFormResultData> executeScriptAction, IDictionary<string, object> realrootEntityState = null)
	{
		_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass19_0();
		CS_0024_003C_003E8__locals0.view = view;
		RootViewItem view2 = CS_0024_003C_003E8__locals0.view;
		RootViewItem rootViewItem = CS_0024_003C_003E8__locals0.view;
		if (CS_0024_003C_003E8__locals0.view != null)
		{
			CS_0024_003C_003E8__locals0.view = CS_0024_003C_003E8__locals0.view.Transformate(settings.ViewTransformation) as RootViewItem;
			if (settings.ViewTransformationAdditional != null)
			{
				settings.ViewTransformationAdditional.Apply(CS_0024_003C_003E8__locals0.view);
			}
			rootViewItem = ClassSerializationHelper.CloneObjectByXml(CS_0024_003C_003E8__locals0.view);
		}
		IDictionary<string, object> dictionary = null;
		dictionary = ((realrootEntityState == null) ? EntityCompareHelper.GetState(entity) : realrootEntityState);
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(entity.CastAsRealType().GetType());
		TypeSettingsInstanceData typeSettingsInstanceData = GetTypeSettingsInstanceData(entity, entityMetadata);
		DynamicFormResult dynamicFormResult = new DynamicFormResult();
		executeScriptAction(CS_0024_003C_003E8__locals0.view, dynamicFormResult.ResultData);
		IEntity rootEntity = entity.GetRootEntity();
		ProcessNewTablePartItems(rootEntity, null);
		if (rootEntity != entity)
		{
			ProcessNewTablePartItems(entity, entityMetadata);
		}
		dynamicFormResult.ChangedPropertyNames = EntityCompareHelper.Compare(entity, dictionary).ToList();
		if (CS_0024_003C_003E8__locals0.view != null)
		{
			FormViewItemTransformation formViewItemTransformation = CS_0024_003C_003E8__locals0.view.CreateTransformation(rootViewItem);
			if (formViewItemTransformation != null)
			{
				_003C_003Ec__DisplayClass19_1 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass19_1();
				IEnumerable<IPropertyMetadata> propertiesAndTableParts = entityMetadata.GetPropertiesAndTableParts();
				CS_0024_003C_003E8__locals2.transformatedItems = (from t in formViewItemTransformation.Items
					select CS_0024_003C_003E8__locals0.view.FindItem<PropertyViewItem>(t.Uid) into i
					where i != null
					select i).ToArray();
				foreach (IPropertyMetadata item in propertiesAndTableParts.Where(delegate(IPropertyMetadata p)
				{
					int num2 = 1;
					int num3 = num2;
					_003C_003Ec__DisplayClass19_2 _003C_003Ec__DisplayClass19_ = default(_003C_003Ec__DisplayClass19_2);
					while (true)
					{
						switch (num3)
						{
						case 2:
							return CS_0024_003C_003E8__locals2.transformatedItems.Any(_003C_003Ec__DisplayClass19_._003CExecuteScript_003Eb__3);
						default:
							_003C_003Ec__DisplayClass19_.p = p;
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
							{
								num3 = 0;
							}
							break;
						case 1:
							_003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_2();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}))
				{
					if (!dynamicFormResult.ChangedPropertyNames.Contains(item.Name))
					{
						dynamicFormResult.ChangedPropertyNames.Add(item.Name);
					}
				}
			}
			PropertyViewItem[] source = rootViewItem.GetAllProperties().ToArray();
			PropertyViewItem[] array = CS_0024_003C_003E8__locals0.view.GetAllProperties().ToArray();
			dynamicFormResult.ChangedValidationPropertyUids = new List<Guid>();
			PropertyViewItem[] array2 = array;
			for (int j = 0; j < array2.Length; j++)
			{
				_003C_003Ec__DisplayClass19_3 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass19_3();
				CS_0024_003C_003E8__locals1.propertyAfter = array2[j];
				PropertyViewItem propertyViewItem = source.FirstOrDefault((PropertyViewItem p) => _003C_003Ec__DisplayClass19_3.Rq8uiIfmlGHFb1RAKYIF(p.Uid, CS_0024_003C_003E8__locals1.propertyAfter.Uid));
				if (propertyViewItem != null)
				{
					bool flag = !string.IsNullOrEmpty(propertyViewItem.Attributes.ValidationError);
					bool flag2 = !string.IsNullOrEmpty(CS_0024_003C_003E8__locals1.propertyAfter.Attributes.ValidationError);
					bool num = ((flag && flag2) ? (propertyViewItem.Attributes.ValidationError != CS_0024_003C_003E8__locals1.propertyAfter.Attributes.ValidationError) : (flag || flag2));
					bool flag3 = propertyViewItem.Attributes.Required != CS_0024_003C_003E8__locals1.propertyAfter.Attributes.Required;
					bool flag4 = propertyViewItem.Attributes.ReadOnly != CS_0024_003C_003E8__locals1.propertyAfter.Attributes.ReadOnly;
					bool flag5 = CS_0024_003C_003E8__locals1.propertyAfter.Attributes.Visible && propertyViewItem.Attributes.Visible != CS_0024_003C_003E8__locals1.propertyAfter.Attributes.Visible;
					if (num || flag3 || flag4 || flag5)
					{
						dynamicFormResult.ChangedValidationPropertyUids.Add(CS_0024_003C_003E8__locals1.propertyAfter.PropertyUid);
					}
				}
			}
		}
		foreach (TypeSettingsInstanceData.DataItem item2 in GetTypeSettingsInstanceData(entity, entityMetadata).Items)
		{
			TypeSettings typeSettings = typeSettingsInstanceData[item2.PropertyUid];
			if (typeSettings == null || !IsEquals(item2.Settings, typeSettings))
			{
				IPropertyMetadata propertyMetadata = FindProperty(entityMetadata, item2.PropertyUid);
				if (propertyMetadata != null && !dynamicFormResult.ChangedPropertyNames.Contains(propertyMetadata.Name))
				{
					dynamicFormResult.ChangedPropertyNames.Add(propertyMetadata.Name);
				}
			}
		}
		dynamicFormResult.ModelJsonState = ModelJsonState(entity, originalStateObj, needProcessNewTablePartItems: false);
		dynamicFormResult.ChangedView = CS_0024_003C_003E8__locals0.view;
		if (dynamicFormResult.ChangedView != null)
		{
			dynamicFormResult.ViewTransformation = dynamicFormResult.ChangedView.CreateTransformation(view2);
		}
		return dynamicFormResult;
	}

	private static bool IsEquals(object left, object right)
	{
		//Discarded unreachable code: IL_006f, IL_00a7, IL_00df, IL_0138, IL_0170, IL_017f
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				memoryStream = ClassSerializationHelper.SerializeObjectByXmlToMemoryStream(left);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				MemoryStream memoryStream2 = ClassSerializationHelper.SerializeObjectByXmlToMemoryStream(right);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				default:
					try
					{
						result = bBtyrvO197gaqZcHcK6(memoryStream, memoryStream2);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num4 = 0;
						}
						return num4 switch
						{
							0 => result, 
							_ => result, 
						};
					}
					finally
					{
						if (memoryStream2 != null)
						{
							int num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									NlXpfgONDUYLivmVaw5(memoryStream2);
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
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
				if (memoryStream != null)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						default:
							((IDisposable)memoryStream).Dispose();
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
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
			}
		}
	}

	private static bool? NeedPostfixCheck(object viewItem, IEnumerable<PropertyViewItem> props, Func<PropertyViewItem, bool> checkType, Func<PropertyViewItem, bool> checkNonType)
	{
		_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass21_0();
		CS_0024_003C_003E8__locals0.checkNonType = checkNonType;
		CS_0024_003C_003E8__locals0.viewItem = (PropertyViewItem)viewItem;
		if (!checkType(CS_0024_003C_003E8__locals0.viewItem))
		{
			return null;
		}
		PropertyViewItem propertyViewItem = props.FirstOrDefault((PropertyViewItem p) => !CS_0024_003C_003E8__locals0.checkNonType(CS_0024_003C_003E8__locals0.viewItem));
		return propertyViewItem != CS_0024_003C_003E8__locals0.viewItem && (checkType(propertyViewItem) || !CS_0024_003C_003E8__locals0.checkNonType(props.FirstOrDefault()));
	}

	public static bool NeedPostfix(this PropertyViewItem viewItem)
	{
		//Discarded unreachable code: IL_0061, IL_0070, IL_009d, IL_00cb, IL_0143, IL_01e0
		int num = 8;
		bool? flag = default(bool?);
		bool value = default(bool);
		PropertyViewItem[] array = default(PropertyViewItem[]);
		_003C_003Ec__DisplayClass22_0 _003C_003Ec__DisplayClass22_ = default(_003C_003Ec__DisplayClass22_0);
		FormViewItem formViewItem = default(FormViewItem);
		bool? flag2 = default(bool?);
		Func<PropertyViewItem, bool> func = default(Func<PropertyViewItem, bool>);
		bool? flag3 = default(bool?);
		while (true)
		{
			int num2 = num;
			PropertyViewItem viewItem2;
			PropertyViewItem[] props;
			Func<PropertyViewItem, bool> checkType;
			Func<PropertyViewItem, bool> checkNonType;
			while (true)
			{
				bool num3;
				switch (num2)
				{
				case 10:
					if (flag.HasValue)
					{
						num2 = 6;
						continue;
					}
					goto case 2;
				case 12:
					return value;
				case 9:
					array = (PropertyViewItem[])eRKG2wOaBImpglaklIG(_003C_003Ec__DisplayClass22_.viewItem, formViewItem);
					num2 = 14;
					continue;
				default:
					if (flag2.HasValue)
					{
						num3 = flag2.GetValueOrDefault();
						break;
					}
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 1;
					}
					continue;
				case 14:
					func = _003C_003Ec__DisplayClass22_._003CNeedPostfix_003Eb__0;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 4;
					}
					continue;
				case 8:
					_003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_0();
					num2 = 7;
					continue;
				case 5:
					num3 = func(array.FirstOrDefault());
					break;
				case 11:
					if (flag3.HasValue)
					{
						num3 = flag3.GetValueOrDefault();
						break;
					}
					num2 = 5;
					continue;
				case 15:
					if (formViewItem == null)
					{
						num2 = 13;
						continue;
					}
					if (!((PropertiesContainer)hfUHPfOpoNa4759K0Px(_003C_003Ec__DisplayClass22_.viewItem)).TryGetValue((string)R4jn40OOW7stH3wiytf(-1921202237 ^ -1921210201), out value))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 12;
				case 1:
					formViewItem = (FormViewItem)p179oUO37BQuIITNNpM(_003C_003Ec__DisplayClass22_.viewItem);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 15;
					}
					continue;
				case 13:
					return false;
				case 7:
					_003C_003Ec__DisplayClass22_.viewItem = viewItem;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					flag = NeedPostfixCheck(_003C_003Ec__DisplayClass22_.viewItem, array, (PropertyViewItem i) => i is PropertyCaptionViewItem, delegate(PropertyViewItem i)
					{
						//Discarded unreachable code: IL_002d, IL_003c
						int num6 = 2;
						int num7 = num6;
						while (true)
						{
							switch (num7)
							{
							default:
								return i is PropertyDescriptionViewItem;
							case 1:
								return true;
							case 2:
								if (i is PropertyValueViewItem)
								{
									num7 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
									{
										num7 = 0;
									}
									break;
								}
								goto default;
							}
						}
					});
					num2 = 10;
					continue;
				case 2:
					flag2 = NeedPostfixCheck(_003C_003Ec__DisplayClass22_.viewItem, array, (PropertyViewItem i) => i is PropertyValueViewItem, delegate(PropertyViewItem i)
					{
						//Discarded unreachable code: IL_005e, IL_006d
						int num4 = 2;
						int num5 = num4;
						while (true)
						{
							switch (num5)
							{
							case 2:
								if (i is PropertyCaptionViewItem)
								{
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
									{
										num5 = 1;
									}
									break;
								}
								goto default;
							default:
								return i is PropertyDescriptionViewItem;
							case 1:
								return true;
							}
						}
					});
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					viewItem2 = _003C_003Ec__DisplayClass22_.viewItem;
					props = array;
					checkType = (PropertyViewItem i) => i is PropertyDescriptionViewItem;
					checkNonType = delegate(PropertyViewItem i)
					{
						int num8 = 1;
						int num9 = num8;
						while (true)
						{
							switch (num9)
							{
							case 1:
								if (i is PropertyCaptionViewItem)
								{
									return true;
								}
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
								{
									num9 = 0;
								}
								break;
							default:
								return i is PropertyValueViewItem;
							}
						}
					};
					goto end_IL_0012;
				case 6:
					num3 = flag.GetValueOrDefault();
					break;
				}
				if (num3)
				{
					yN5WkIODOevLiQXWNLy(_003C_003Ec__DisplayClass22_.viewItem.TypeSettings, R4jn40OOW7stH3wiytf(-1867198571 ^ -1867210511), true);
				}
				return num3;
				continue;
				end_IL_0012:
				break;
			}
			flag3 = NeedPostfixCheck(viewItem2, props, checkType, checkNonType);
			num = 11;
		}
	}

	public static string ModelJsonState(IEntity entity)
	{
		return ModelJsonState(entity, null);
	}

	public static string ModelJsonState(IEntity entity, object originalStateObj, bool needProcessNewTablePartItems = true)
	{
		int num = 4;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
			{
				EntityJsonSerializer entityJsonSerializer = new EntityJsonSerializer();
				EntitySerializationSettings entitySerializationSettings = new EntitySerializationSettings();
				FosQu4Owe8KXOrtcw1e(entitySerializationSettings, EntitySerializationMode.ChangesOnly);
				entitySerializationSettings.OriginalState = originalStateObj;
				return (string)FfFQYNO4ECxXpNDUpwH(entityJsonSerializer.ConvertToSerializable(entity, entitySerializationSettings));
			}
			case 1:
				pG8wEXOtE71WlY0nJEj(entity, entityMetadata);
				num2 = 2;
				break;
			default:
				if (entityMetadata != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 3:
				entityMetadata = MetadataLoader.LoadMetadata(entity.CastAsRealType().GetType()) as EntityMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (needProcessNewTablePartItems)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			}
		}
	}

	public static FormViewItem FormWithExecutedLoadScripts(FormViewItem formViewItem, IEntity entity, ClassMetadata metadata, DynamicFormSettings dynamicFormSettings)
	{
		//Discarded unreachable code: IL_0074, IL_0083, IL_0148, IL_0157, IL_0166, IL_01e4, IL_01f3
		int num = 3;
		DynamicFormResult dynamicFormResult = default(DynamicFormResult);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 8:
					Don6brOxFB1TJbxLkPo(dynamicFormSettings, aDp8X5O71as9MtHdoJW(dynamicFormResult));
					num2 = 13;
					continue;
				case 13:
					dynamicFormSettings.ViewTransformation = (ViewItemTransformation)qZw9RDO0OvQSgK9yKUO(dynamicFormResult);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 12;
					}
					continue;
				default:
					dynamicFormResult = ExecuteScript(entity, dynamicFormSettings, formViewItem, text);
					num2 = 8;
					continue;
				case 14:
					if (w6fQWAOmwDDGQcprBnR(dynamicFormResult) != null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 11:
					dynamicFormSettings.ModelJsonState = (string)FfogdSOyFLMv4KsS6ja(entity);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 12;
					}
					continue;
				case 6:
					formViewItem = (FormViewItem)w6fQWAOmwDDGQcprBnR(dynamicFormResult);
					num = 5;
					break;
				case 3:
					if (formViewItem != null)
					{
						num2 = 2;
						continue;
					}
					goto case 10;
				case 9:
					if (metadata == null)
					{
						num = 7;
						break;
					}
					goto case 1;
				case 10:
					return null;
				case 2:
					if (MAijTKOHp6qpEQWRFQJ(Ter285O62QVYPoTml8P(formViewItem)))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					obj = Ter285O62QVYPoTml8P(formViewItem);
					goto IL_01fe;
				case 5:
				case 12:
					return formViewItem;
				case 4:
					if (!string.IsNullOrEmpty(text))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 11;
				case 1:
					obj = n0q4hEOAIUfJW5lZ5gm(metadata);
					goto IL_01fe;
				case 7:
					{
						obj = string.Empty;
						goto IL_01fe;
					}
					IL_01fe:
					text = (string)obj;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
		}
	}

	public static void ProcessNewTablePartItems(IEntity entity, IEntityMetadata metadata)
	{
		//Discarded unreachable code: IL_0065, IL_00b3, IL_00c2, IL_01d3, IL_0295, IL_02a4, IL_0345, IL_0354, IL_03d8, IL_03e7, IL_03f7, IL_0427, IL_045f, IL_0497, IL_057d, IL_05b5, IL_05c4, IL_05d4
		int num = 3;
		int num2 = num;
		IEnumerator<ITablePartMetadata> enumerator = default(IEnumerator<ITablePartMetadata>);
		IEnumerator<IEntity> enumerator2 = default(IEnumerator<IEntity>);
		ITablePartMetadata current = default(ITablePartMetadata);
		object id = default(object);
		IEntity current2 = default(IEntity);
		ITablePartManager tablePartManager = default(ITablePartManager);
		Guid? guid = default(Guid?);
		HashedSet<Guid> val = default(HashedSet<Guid>);
		ISet val3 = default(ISet);
		IPersistentCollection val2 = default(IPersistentCollection);
		while (true)
		{
			switch (num2)
			{
			default:
				metadata = MetadataLoader.LoadMetadata(entity.CastAsRealType().GetType()) as IEntityMetadata;
				num2 = 6;
				continue;
			case 7:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							goto IL_0073;
						}
						goto IL_047f;
						IL_0073:
						while (true)
						{
							switch (num3)
							{
							case 8:
								try
								{
									while (true)
									{
										int num4;
										if (!OZjnAqO2BlE7BGG7gQU(enumerator2))
										{
											num4 = 5;
											goto IL_00d1;
										}
										goto IL_032d;
										IL_00d1:
										while (true)
										{
											switch (num4)
											{
											case 16:
											{
												Type typeByUid = ((IMetadataRuntimeService)cQBfu1OgR4rLOUcPH0d()).GetTypeByUid(gsxbmqO51XhE33prNwt(current), loadImplementation: true);
												Type entityIdType = ModelHelper.GetEntityIdType(typeByUid);
												if (!zlP3tUOjtsnvPi98xDu(typeByUid, entityIdType, id))
												{
													num4 = 19;
													continue;
												}
												goto case 15;
											}
											case 4:
												current2.SetPropertyValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088314294), Guid.NewGuid());
												num4 = 7;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
												{
													num4 = 0;
												}
												continue;
											case 14:
												tablePartManager = kOLjKXOUeguao4IQxc6(current2.CastAsRealType().GetType()) as ITablePartManager;
												num4 = 8;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
												{
													num4 = 3;
												}
												continue;
											case 8:
												if (tablePartManager == null)
												{
													num4 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
													{
														num4 = 3;
													}
													continue;
												}
												goto case 9;
											case 1:
												guid = DW3jh7OlMg5H6CTTcdG(current2, R4jn40OOW7stH3wiytf(0x4785BC0D ^ 0x4785D39F), null) as Guid?;
												num4 = 12;
												continue;
											case 17:
												if (A5q1iKOdKAFPEyy52Yf(current2))
												{
													num4 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
													{
														num4 = 0;
													}
													continue;
												}
												goto case 3;
											case 12:
												if (!guid.HasValue)
												{
													int num5 = 18;
													num4 = num5;
													continue;
												}
												goto case 2;
											case 2:
												if (xXO9fDOrN7VcuN1DiUi(guid.Value, Guid.Empty))
												{
													num4 = 4;
													continue;
												}
												goto case 13;
											case 9:
												V43RUHOseSTJL0w8W32(tablePartManager, current2);
												num4 = 10;
												continue;
											case 13:
												if (((Set<Guid>)(object)val).Add(guid.Value))
												{
													num4 = 7;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
													{
														num4 = 20;
													}
													continue;
												}
												goto case 6;
											case 3:
											case 10:
											case 19:
												pG8wEXOtE71WlY0nJEj(current2, (IEntityMetadata)current);
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
												{
													num4 = 0;
												}
												continue;
											case 11:
												goto IL_032d;
											case 15:
												Wu920JOLXlyMvhQhqw2(current2, LEtdyUOY0rANOBylVcg());
												num4 = 14;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
												{
													num4 = 0;
												}
												continue;
											case 6:
												throw new Exception(SR.T((string)R4jn40OOW7stH3wiytf(-1765851862 ^ -1765846346), guid.Value));
											case 7:
											case 18:
											case 20:
												id = current2.GetId();
												num4 = 16;
												continue;
											case 5:
												goto end_IL_02c2;
											}
											break;
										}
										continue;
										IL_032d:
										current2 = enumerator2.Current;
										num4 = 17;
										goto IL_00d1;
										continue;
										end_IL_02c2:
										break;
									}
								}
								finally
								{
									if (enumerator2 != null)
									{
										int num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
										{
											num6 = 0;
										}
										while (true)
										{
											switch (num6)
											{
											default:
												enumerator2.Dispose();
												num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
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
								}
								break;
							case 10:
								break;
							case 9:
								goto IL_047f;
							case 1:
								if (val3 != null)
								{
									num3 = 4;
									continue;
								}
								break;
							case 5:
							{
								object obj = kWs6KvOJ7lZJPNolBuc(entity, Xy4blNOMasG8jl54bYd(current));
								val3 = (ISet)((obj is ISet) ? obj : null);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
								{
									num3 = 1;
								}
								continue;
							}
							case 6:
								enumerator2 = ((IEnumerable)val3).OfType<IEntity>().GetEnumerator();
								num3 = 8;
								continue;
							case 4:
							{
								val2 = (IPersistentCollection)(object)((val3 is IPersistentCollection) ? val3 : null);
								int num7 = 7;
								num3 = num7;
								continue;
							}
							case 11:
								if (KQMXGaO9Ryrkw66EFUL(val2))
								{
									num3 = 2;
									continue;
								}
								break;
							case 7:
								if (val2 == null)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 11;
							default:
								val = new HashedSet<Guid>();
								num3 = 6;
								continue;
							case 3:
								return;
							}
							break;
						}
						continue;
						IL_047f:
						current = enumerator.Current;
						num3 = 5;
						goto IL_0073;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num8 = 0;
						}
						while (true)
						{
							switch (num8)
							{
							default:
								NlXpfgONDUYLivmVaw5(enumerator);
								num8 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
								{
									num8 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 4:
				return;
			case 2:
				if (metadata == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 3:
				if (entity == null)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				enumerator = metadata.GetPropertiesAndTableParts().OfType<ITablePartMetadata>().GetEnumerator();
				num2 = 7;
				continue;
			case 1:
				return;
			case 6:
				break;
			}
			if (metadata == null)
			{
				break;
			}
			num2 = 5;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
			{
				num2 = 2;
			}
		}
	}

	private static TypeSettingsInstanceData GetTypeSettingsInstanceData(object entity, object metadata)
	{
		TypeSettingsInstanceData typeSettingsInstanceData = new TypeSettingsInstanceData();
		QUDZLTOc5i2vXc7NY47(typeSettingsInstanceData, entity, metadata);
		return typeSettingsInstanceData;
	}

	private static void GetTypeSettingsInstanceData(object data, object entity, object metadata)
	{
		//Discarded unreachable code: IL_0074, IL_0083, IL_008e, IL_0182, IL_0195, IL_01a4, IL_01b5, IL_01c4, IL_01cf, IL_0265, IL_0278
		int num = 3;
		int num2 = num;
		List<TablePartMetadata>.Enumerator enumerator2 = default(List<TablePartMetadata>.Enumerator);
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		PropertyMetadata current = default(PropertyMetadata);
		TypeSettings typeSettings = default(TypeSettings);
		TablePartMetadata current2 = default(TablePartMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator2 = ((EntityMetadata)metadata).TableParts.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				enumerator = ((ClassMetadata)metadata).Properties.GetEnumerator();
				num2 = 2;
				continue;
			case 2:
				try
				{
					while (true)
					{
						IL_0117:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
							{
								num3 = 0;
							}
							goto IL_0092;
						}
						goto IL_00e3;
						IL_00e3:
						current = enumerator.Current;
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num3 = 4;
						}
						goto IL_0092;
						IL_0092:
						while (true)
						{
							switch (num3)
							{
							case 2:
								bry0CN2BpuAhOgDZDVF(data, current.Uid, ClassSerializationHelper.CloneObjectByXml(typeSettings));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
								break;
							case 5:
								if (typeSettings != null)
								{
									num3 = 2;
									continue;
								}
								goto IL_0117;
							default:
								goto IL_0117;
							case 4:
								typeSettings = (TypeSettings)vtDgBR2FHDlFmsCt1Gw(entity, bb8irROzDf3CaVuHaAl(current));
								num3 = 5;
								continue;
							case 1:
								goto end_IL_0117;
							}
							break;
						}
						goto IL_00e3;
						continue;
						end_IL_0117:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 1;
			case 4:
				return;
			}
			try
			{
				while (true)
				{
					IL_0210:
					int num5;
					if (!enumerator2.MoveNext())
					{
						num5 = 2;
						goto IL_01d3;
					}
					goto IL_01ed;
					IL_01d3:
					while (true)
					{
						switch (num5)
						{
						case 3:
							goto IL_0210;
						case 1:
							QUDZLTOc5i2vXc7NY47(data, entity, current2);
							num5 = 3;
							continue;
						case 2:
							return;
						}
						break;
					}
					goto IL_01ed;
					IL_01ed:
					current2 = enumerator2.Current;
					num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num5 = 0;
					}
					goto IL_01d3;
				}
			}
			finally
			{
				((IDisposable)enumerator2).Dispose();
				int num6 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num6 = 0;
				}
				switch (num6)
				{
				case 0:
					break;
				}
			}
		}
	}

	private static IPropertyMetadata FindProperty(object metadata, Guid propertyUid)
	{
		//Discarded unreachable code: IL_00ed, IL_015b, IL_016a, IL_01a0, IL_0203, IL_0216
		int num = 3;
		_003C_003Ec__DisplayClass30_0 _003C_003Ec__DisplayClass30_ = default(_003C_003Ec__DisplayClass30_0);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		List<TablePartMetadata>.Enumerator enumerator = default(List<TablePartMetadata>.Enumerator);
		TablePartMetadata current = default(TablePartMetadata);
		IPropertyMetadata result = default(IPropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Ec__DisplayClass30_.propertyUid = propertyUid;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					if (propertyMetadata != null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num2 = 3;
						}
						continue;
					}
					enumerator = ((EntityMetadata)metadata).TableParts.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					_003C_003Ec__DisplayClass30_ = new _003C_003Ec__DisplayClass30_0();
					num = 2;
					break;
				default:
					propertyMetadata = ((ClassMetadata)metadata).Properties.FirstOrDefault(_003C_003Ec__DisplayClass30_._003CFindProperty_003Eb__0);
					num = 4;
					break;
				case 5:
					return null;
				case 6:
					return propertyMetadata;
				case 1:
					try
					{
						while (true)
						{
							IL_0175:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
								{
									num3 = 1;
								}
								goto IL_00fb;
							}
							goto IL_0121;
							IL_0121:
							current = enumerator.Current;
							int num4 = 4;
							num3 = num4;
							goto IL_00fb;
							IL_00fb:
							while (true)
							{
								switch (num3)
								{
								case 3:
									return result;
								case 6:
									break;
								case 5:
									result = current;
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
									{
										num3 = 3;
									}
									continue;
								default:
									goto IL_0175;
								case 4:
									if (sZIFBM2Wfx5Jjapa2Jk(current, _003C_003Ec__DisplayClass30_.propertyUid) == null)
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 5;
								case 1:
									goto end_IL_0175;
								}
								break;
							}
							goto IL_0121;
							continue;
							end_IL_0175:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 5;
				}
				break;
			}
		}
	}

	internal static bool n1FpHIOkoB5AcD0jjyO()
	{
		return QDnTn9OTtnmGr7FGCxv == null;
	}

	internal static DynamicFormHelper lajhGHOnTMNX5TFPBrD()
	{
		return QDnTn9OTtnmGr7FGCxv;
	}

	internal static object R4jn40OOW7stH3wiytf(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool OZjnAqO2BlE7BGG7gQU(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void LgZAI0Oe16njA87xmwd(object P_0, bool value)
	{
		((FormViewBuilderInfo)P_0).ClosePopup = value;
	}

	internal static object AVePmvOPq14pBfYiTJ5()
	{
		return ComponentManager.Current;
	}

	internal static bool bBtyrvO197gaqZcHcK6(object P_0, object P_1)
	{
		return ((MemoryStream)P_0).Compare((MemoryStream)P_1);
	}

	internal static void NlXpfgONDUYLivmVaw5(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object p179oUO37BQuIITNNpM(object P_0)
	{
		return ((ViewItem)P_0).FormViewItem;
	}

	internal static object hfUHPfOpoNa4759K0Px(object P_0)
	{
		return ((PropertyViewItem)P_0).TypeSettings;
	}

	internal static object eRKG2wOaBImpglaklIG(object P_0, object P_1)
	{
		return ((PropertyViewItem)P_0).GetEqualPropertiesFromForm((FormViewItem)P_1);
	}

	internal static void yN5WkIODOevLiQXWNLy(object P_0, object P_1, object P_2)
	{
		((PropertiesContainer)P_0)[(string)P_1] = P_2;
	}

	internal static void pG8wEXOtE71WlY0nJEj(object P_0, object P_1)
	{
		ProcessNewTablePartItems((IEntity)P_0, (IEntityMetadata)P_1);
	}

	internal static void FosQu4Owe8KXOrtcw1e(object P_0, EntitySerializationMode value)
	{
		((EntitySerializationSettings)P_0).Mode = value;
	}

	internal static object FfFQYNO4ECxXpNDUpwH(object P_0)
	{
		return JsonConvert.SerializeObject(P_0);
	}

	internal static object Ter285O62QVYPoTml8P(object P_0)
	{
		return ((FormView)P_0).OnLoadScriptName;
	}

	internal static bool MAijTKOHp6qpEQWRFQJ(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object n0q4hEOAIUfJW5lZ5gm(object P_0)
	{
		return ((ClassMetadata)P_0).OnViewLoadScriptName;
	}

	internal static object aDp8X5O71as9MtHdoJW(object P_0)
	{
		return ((DynamicFormResult)P_0).ModelJsonState;
	}

	internal static void Don6brOxFB1TJbxLkPo(object P_0, object P_1)
	{
		((DynamicFormSettings)P_0).ModelJsonState = (string)P_1;
	}

	internal static object qZw9RDO0OvQSgK9yKUO(object P_0)
	{
		return ((DynamicFormResult)P_0).ViewTransformation;
	}

	internal static object w6fQWAOmwDDGQcprBnR(object P_0)
	{
		return ((DynamicFormResult)P_0).ChangedView;
	}

	internal static object FfogdSOyFLMv4KsS6ja(object P_0)
	{
		return ModelJsonState((IEntity)P_0);
	}

	internal static Guid Xy4blNOMasG8jl54bYd(object P_0)
	{
		return ((ITablePartMetadata)P_0).TablePartPropertyUid;
	}

	internal static object kWs6KvOJ7lZJPNolBuc(object P_0, Guid propertyUid)
	{
		return ((IEntity)P_0).GetPropertyValue(propertyUid);
	}

	internal static bool KQMXGaO9Ryrkw66EFUL(object P_0)
	{
		return ((IPersistentCollection)P_0).get_WasInitialized();
	}

	internal static bool A5q1iKOdKAFPEyy52Yf(object P_0)
	{
		return ((IEntity)P_0).IsNew();
	}

	internal static object DW3jh7OlMg5H6CTTcdG(object P_0, object P_1, object P_2)
	{
		return P_0.GetPropertyValue((string)P_1, P_2);
	}

	internal static bool xXO9fDOrN7VcuN1DiUi(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object cQBfu1OgR4rLOUcPH0d()
	{
		return MetadataRuntimeService;
	}

	internal static Guid gsxbmqO51XhE33prNwt(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static bool zlP3tUOjtsnvPi98xDu(Type type, Type idType, object P_2)
	{
		return type.IsDefaultId(idType, P_2);
	}

	internal static long LEtdyUOY0rANOBylVcg()
	{
		return TablePartHelper.GetNextTemporaryId();
	}

	internal static void Wu920JOLXlyMvhQhqw2(object P_0, object P_1)
	{
		((IIdentified)P_0).SetId(P_1);
	}

	internal static object kOLjKXOUeguao4IQxc6(Type entityType)
	{
		return EntityHelper.GetEntityManager(entityType);
	}

	internal static void V43RUHOseSTJL0w8W32(object P_0, object P_1)
	{
		((ITablePartManager)P_0).PutToContextCache((IEntity)P_1);
	}

	internal static void QUDZLTOc5i2vXc7NY47(object P_0, object P_1, object P_2)
	{
		GetTypeSettingsInstanceData(P_0, P_1, P_2);
	}

	internal static Guid bb8irROzDf3CaVuHaAl(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object vtDgBR2FHDlFmsCt1Gw(object P_0, Guid propertyUid)
	{
		return ((IEntity)P_0).LoadPropertyInstanceSettings(propertyUid);
	}

	internal static void bry0CN2BpuAhOgDZDVF(object P_0, Guid uid, object P_2)
	{
		((TypeSettingsInstanceData)P_0)[uid] = (TypeSettings)P_2;
	}

	internal static object sZIFBM2Wfx5Jjapa2Jk(object P_0, Guid propertyUid)
	{
		return FindProperty(P_0, propertyUid);
	}
}
