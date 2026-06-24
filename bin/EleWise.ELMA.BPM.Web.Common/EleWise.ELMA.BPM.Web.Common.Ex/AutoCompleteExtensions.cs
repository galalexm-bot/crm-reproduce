using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[Component]
public class AutoCompleteExtensions : IAutoComplete
{
	private const string EmptyUid = "{00000000-0000-0000-0000-000000000000}";

	private const string ObjectsTypeUid = "{D030EE61-94FB-401E-81FF-7171C34BBBEE}";

	private const string ReferenceOnEntityUid = "{1F289B26-0607-4BC7-ADC0-9ED814C80C90}";

	private const string ReferenceOnEntityTypeUid = "{2DF8E9CA-3AC4-4BA5-832F-18F6374397E7}";

	private const string DropDownItemUid = "{55888705-4BFA-431B-8A93-71B80EED484D}";

	private const string EntityUid = "{72ED98CA-F260-4671-9BCD-FF1D80235F47}";

	private const string EnumUid = "{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}";

	private const string GuidUid = "{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}";

	private const string DateTimeUid = "{DAC9211E-E02B-47CD-8868-89A3BFC0F749}";

	private const string StringUid = "{9B9AAC17-22BB-425C-AA93-9C02C5146965}";

	private const string BoolUid = "{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}";

	private const string Int16Uid = "{C1D5FC22-B8ED-4CFA-8029-82EC19E17B7F}";

	private const string Int32Uid = "{D6B44BCE-B236-424D-AA74-D80DA3C8DB75}";

	private const string LongUid = "{D90A59AF-7E47-48C5-8C4C-DAD04834E6E3}";

	private const string DoubleUid = "{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}";

	private const string BinaryFileUid = "{289F266B-2805-457E-BCE0-B0BCD4D38143}";

	private const string MoneyUid = "{38934BC2-601F-45DA-851F-1BBF1054D85E}";

	private const string WorkTimeUid = "{CDD9F627-2A60-4E36-9C10-ECB492B1ADAD}";

	private const string HtmlStringUid = "{0AEF74A9-D37C-4731-813B-D5F0B5EC4392}";

	private const string UrlUid = "{66A64042-0490-4AD6-B804-4D08FA6C85F0}";

	public IEnumerable<EQLOperator> GetOperators()
	{
		yield return new EQLOperator
		{
			types = new object[2] { "{1F289B26-0607-4BC7-ADC0-9ED814C80C90}", "{2DF8E9CA-3AC4-4BA5-832F-18F6374397E7}" },
			operators = new string[4] { "=", "<>", "in", "is" }
		};
		yield return new EQLOperator
		{
			types = new object[1] { "{72ED98CA-F260-4671-9BCD-FF1D80235F47}" },
			operators = new string[4] { "=", "<>", "in", "is" }
		};
		yield return new EQLOperator
		{
			types = new object[2] { "{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "{55888705-4BFA-431B-8A93-71B80EED484D}" },
			operators = new string[4] { "=", "<>", "in", "is" }
		};
		yield return new EQLOperator
		{
			types = new object[4] { 1, 2, 3, 4 },
			operators = new string[2] { "in", "is" }
		};
		yield return new EQLOperator
		{
			types = new object[2] { "{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}", "{D030EE61-94FB-401E-81FF-7171C34BBBEE}" },
			operators = new string[4] { "=", "<>", "in", "is" }
		};
		yield return new EQLOperator
		{
			types = new object[1] { "{DAC9211E-E02B-47CD-8868-89A3BFC0F749}" },
			operators = new string[8] { "=", "<>", "<", "<=", ">", ">=", "in", "is" }
		};
		yield return new EQLOperator
		{
			types = new object[3] { "{9B9AAC17-22BB-425C-AA93-9C02C5146965}", "{0AEF74A9-D37C-4731-813B-D5F0B5EC4392}", "{66A64042-0490-4AD6-B804-4D08FA6C85F0}" },
			operators = new string[5] { "=", "<>", "like", "in", "is" }
		};
		yield return new EQLOperator
		{
			types = new object[1] { "{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}" },
			operators = new string[3] { "=", "<>", "is" }
		};
		yield return new EQLOperator
		{
			types = new object[6] { "{C1D5FC22-B8ED-4CFA-8029-82EC19E17B7F}", "{D6B44BCE-B236-424D-AA74-D80DA3C8DB75}", "{D90A59AF-7E47-48C5-8C4C-DAD04834E6E3}", "{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}", "{38934BC2-601F-45DA-851F-1BBF1054D85E}", "{CDD9F627-2A60-4E36-9C10-ECB492B1ADAD}" },
			operators = new string[8] { "=", "<>", "<", "<=", ">", ">=", "in", "is" }
		};
		yield return new EQLOperator
		{
			types = new object[1] { "{289F266B-2805-457E-BCE0-B0BCD4D38143}" },
			operators = new string[4] { "=", "<>", "in", "is" }
		};
	}

	public IEnumerable<EleWise.ELMA.BPM.Web.Common.ExtensionPoints.EQLFunction> GetFunctions(EntityMetadata entityMetadata)
	{
		IEnumerable<IEQLFunction> source = ComponentManager.Current.GetExtensionPoints<IQueryFunctionResult>().OfType<IEQLFunction>();
		foreach (EleWise.ELMA.Model.Common.EQLFunction item in source.SelectMany((IEQLFunction f) => f.GetEqlFunctions()))
		{
			yield return new EleWise.ELMA.BPM.Web.Common.ExtensionPoints.EQLFunction
			{
				displayName = item.DisplayName,
				description = item.Description,
				value = item.Value,
				types = item.Types.Select((Guid t) => t.ToString("B").ToUpper())
			};
		}
		IEnumerable<IEQLFunction> source2 = ComponentManager.Current.GetExtensionPoints<IQueryInFunction>().OfType<IEQLFunction>();
		foreach (EleWise.ELMA.Model.Common.EQLFunction item2 in source2.SelectMany((IEQLFunction f) => f.GetEqlFunctions()))
		{
			yield return new EleWise.ELMA.BPM.Web.Common.ExtensionPoints.EQLFunction
			{
				displayName = item2.DisplayName,
				description = item2.Description,
				value = item2.Value,
				types = item2.Types.Select((Guid t) => t.ToString("B").ToUpper()),
				isInFunction = true
			};
		}
		yield return new EleWise.ELMA.BPM.Web.Common.ExtensionPoints.EQLFunction
		{
			displayName = "TRUE",
			value = "TRUE",
			types = new string[1] { "{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}" }
		};
		yield return new EleWise.ELMA.BPM.Web.Common.ExtensionPoints.EQLFunction
		{
			displayName = "FALSE",
			value = "FALSE",
			types = new string[1] { "{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}" }
		};
		yield return new EleWise.ELMA.BPM.Web.Common.ExtensionPoints.EQLFunction
		{
			displayName = "COUNT",
			value = "COUNT",
			types = new string[1] { "{D90A59AF-7E47-48C5-8C4C-DAD04834E6E3}" }
		};
		if (entityMetadata == null)
		{
			yield break;
		}
		if (entityMetadata.AllowCreateHeirs)
		{
			List<ClassMetadata> childs = MetadataLoader.GetChildClasses(entityMetadata);
			yield return new EleWise.ELMA.BPM.Web.Common.ExtensionPoints.EQLFunction
			{
				value = $"'{QuoteReplace(entityMetadata.Name)}'",
				displayName = entityMetadata.DisplayName + " <span class=\"suggestvalue\">[ '" + entityMetadata.Name + "' ]</span>",
				types = new string[1] { "{D030EE61-94FB-401E-81FF-7171C34BBBEE}" }
			};
			foreach (ClassMetadata item3 in childs)
			{
				yield return new EleWise.ELMA.BPM.Web.Common.ExtensionPoints.EQLFunction
				{
					value = $"'{QuoteReplace(item3.Name)}'",
					displayName = item3.DisplayName + " <span class=\"suggestvalue\">[ '" + item3.Name + "' ]</span>",
					types = new string[1] { "{D030EE61-94FB-401E-81FF-7171C34BBBEE}" }
				};
			}
		}
		IEnumerable<Guid> usedenums = new Guid[0];
		List<PropertyMetadata> properties = entityMetadata.Properties;
		foreach (PropertyMetadata prop in properties)
		{
			if (prop.TypeUid == EnumDescriptor.UID && !usedenums.Contains(prop.SubTypeUid))
			{
				usedenums = usedenums.Concat(new Guid[1] { prop.SubTypeUid });
				List<EnumValueMetadata> values = (MetadataLoader.LoadMetadata(prop.SubTypeUid) as EnumMetadata).Values;
				foreach (EnumValueMetadata item4 in values)
				{
					yield return new EleWise.ELMA.BPM.Web.Common.ExtensionPoints.EQLFunction
					{
						value = $"'{QuoteReplace(item4.Name)}'",
						displayName = item4.DisplayName,
						types = new string[1] { prop.SubTypeUid.ToString("B").ToUpper() }
					};
				}
			}
			if (!(prop.TypeUid == DropDownListDescriptor.UID))
			{
				continue;
			}
			prop.Settings.GetSettingsValuePairs().TryGetValue("ItemsString", out var value);
			string text = (string)value;
			if (!string.IsNullOrEmpty(text))
			{
				string[] array = text.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					yield return new EleWise.ELMA.BPM.Web.Common.ExtensionPoints.EQLFunction
					{
						value = $"'{QuoteReplace(text2)}'",
						displayName = text2,
						types = new string[1] { prop.Uid.ToString("B").ToUpper() }
					};
				}
			}
		}
	}

	protected string QuoteReplace(string value)
	{
		return value.Replace("'", "''");
	}

	public IEnumerable<EQLField> GetFields(EntityMetadata entityMetadata)
	{
		yield return new EQLField
		{
			displayName = string.Format("{0} <span class=\"suggestvalue\">[ Id ]</span>", SR.T("Идентификатор")),
			description = "",
			value = "Id",
			auto = true,
			types = new object[3] { "{D90A59AF-7E47-48C5-8C4C-DAD04834E6E3}", null, "{00000000-0000-0000-0000-000000000000}" }
		};
		if (entityMetadata == null)
		{
			yield break;
		}
		if (entityMetadata.AllowCreateHeirs)
		{
			yield return new EQLField
			{
				value = "TypeUid",
				displayName = string.Format("{0} <span class=\"suggestvalue\">[ TypeUid ]</span>", SR.T("Тип объектов")),
				description = "",
				auto = true,
				types = new object[3] { "{D030EE61-94FB-401E-81FF-7171C34BBBEE}", null, "{00000000-0000-0000-0000-000000000000}" }
			};
		}
		List<PropertyMetadata> properties = entityMetadata.Properties;
		foreach (PropertyMetadata item in properties)
		{
			item.Settings.GetSettingsValuePairs().TryGetValue("RelationType", out var value);
			string text;
			string text2;
			if (item.TypeUid == DropDownListDescriptor.UID)
			{
				text = item.Uid.ToString("B").ToUpper();
				text2 = "{55888705-4BFA-431B-8A93-71B80EED484D}";
			}
			else if (item.SubTypeUid != Guid.Empty)
			{
				text = item.SubTypeUid.ToString("B").ToUpper();
				text2 = item.TypeUid.ToString("B").ToUpper();
			}
			else
			{
				text = item.TypeUid.ToString("B").ToUpper();
				text2 = item.SubTypeUid.ToString("B").ToUpper();
			}
			yield return new EQLField
			{
				value = item.Name,
				displayName = item.DisplayName + " <span class=\"suggestvalue\">[ " + item.Name + " ]</span>",
				description = item.Description,
				auto = true,
				types = new object[3] { text, value, text2 }
			};
		}
		List<TablePartMetadata> tableParts = entityMetadata.TableParts;
		foreach (TablePartMetadata item2 in tableParts)
		{
			yield return new EQLField
			{
				value = item2.TablePartPropertyName,
				displayName = item2.DisplayName + " <span class=\"suggestvalue\">[ " + item2.TablePartPropertyName + " ]</span>",
				description = item2.Description,
				auto = true,
				types = new object[3]
				{
					item2.Uid.ToString("B").ToUpper(),
					4,
					"{00000000-0000-0000-0000-000000000000}"
				}
			};
		}
	}

	protected string GetEntityTitle(IEntity entity)
	{
		if (entity == null)
		{
			return string.Empty;
		}
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entity.GetType());
		Guid titlePropertyGuid = classMetadata.GetTitlePropertyUid();
		object obj = ((titlePropertyGuid != Guid.Empty && classMetadata.Properties.Any((PropertyMetadata p) => p.Uid == titlePropertyGuid)) ? entity.GetPropertyValue(titlePropertyGuid) : entity.ToString());
		if (obj == null)
		{
			return string.Empty;
		}
		return obj.ToString();
	}

	public IEnumerable<EQLSuggestion> GetEntities(Guid Uid, string entityValue)
	{
		if (!(Uid != Guid.Empty))
		{
			yield break;
		}
		Type entityType = ModelHelper.GetEntityType(Uid);
		IEntityManager entityManager = ModelHelper.GetEntityManager(entityType);
		if (long.TryParse(entityValue, out var entity1Id) && entityManager.LoadOrNull(entity1Id) is IEntity entity)
		{
			string entityTitle = GetEntityTitle(entity);
			string text = entity.GetId().ToString();
			yield return new EQLSuggestion
			{
				value = text,
				displayName = entityTitle + " <span class=\"suggestvalue\">[ " + text + " ]</span>"
			};
		}
		IEntityFilter entityFilter = (IEntityFilter)InterfaceActivator.Create(ModelHelper.GetEntityFilterType(entityType));
		entityFilter.SearchString = entityValue;
		IEnumerable<IEntity> enumerable = entityManager.Find(entityFilter, new FetchOptions
		{
			FirstResult = 0,
			MaxResults = 15
		}).Cast<IEntity>();
		foreach (IEntity item in enumerable)
		{
			string text2 = item.GetId().ToString();
			if (!(text2 == entity1Id.ToString()))
			{
				string entityTitle2 = GetEntityTitle(item);
				if (!string.IsNullOrEmpty(entityTitle2))
				{
					yield return new EQLSuggestion
					{
						value = text2,
						displayName = entityTitle2 + " <span class=\"suggestvalue\">[ " + text2 + " ]</span>"
					};
				}
			}
		}
	}

	public IEnumerable<EQLEntity> GetAllEntities()
	{
		IEnumerable<IEntityMetadataSearcher> extensionPoints = ComponentManager.Current.GetExtensionPoints<IEntityMetadataSearcher>();
		HashSet<Guid> entity = new HashSet<Guid>();
		foreach (IEntityMetadataSearcher item in extensionPoints)
		{
			IEnumerable<EntityMetadata> source = from m in item.GetEntityMetadataList()
				where m != null && (m.Type == EntityMetadataType.InterfaceImplementation || m.Type == EntityMetadataType.Entity) && m.ShowInTypeTree
				select m;
			foreach (EntityMetadata item2 in source.OrderBy((EntityMetadata o) => o.DisplayName))
			{
				if (entity.Add(item2.Uid) && !string.IsNullOrWhiteSpace(item2.DisplayName))
				{
					string displayName = item2.DisplayName;
					string name = item2.Name;
					string uid = item2.Uid.ToString("B").ToUpper();
					string description = item2.Description;
					string baseClassUid = item2.BaseClassUid.ToString("B").ToUpper();
					if (name == "TypeUid")
					{
						yield return new EQLEntity
						{
							value = name,
							displayName = displayName + " <span class=\"suggestvalue\">[ " + name + " ]</span>",
							description = "",
							types = new object[3] { "{D030EE61-94FB-401E-81FF-7171C34BBBEE}", null, "{00000000-0000-0000-0000-000000000000}" }
						};
					}
					yield return new EQLEntity
					{
						value = name,
						displayName = displayName + " <span class=\"suggestvalue\">[ " + name + " ]</span>",
						types = new object[3] { uid, null, baseClassUid },
						description = description
					};
				}
			}
		}
	}
}
