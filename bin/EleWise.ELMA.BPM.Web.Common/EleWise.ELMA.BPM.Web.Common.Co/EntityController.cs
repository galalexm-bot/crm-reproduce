using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Models.Forms;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Models.Inputs;
using EleWise.ELMA.Web.Mvc.Models.Selectors;
using EleWise.ELMA.Web.Mvc.Services;
using Telerik.Web.Mvc;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

public class EntityController : EntityBaseController
{
	private enum ExplorerFilterStyleEnum
	{
		SearchFilterEql,
		SearchFilter,
		Search
	}

	private static IEnumerable<IEntitySelectResolver> entitySelectResolvers;

	private static IEnumerable<IEntitySelectResolver> EntitySelectResolvers => entitySelectResolvers ?? (entitySelectResolvers = ComponentManager.Current.GetExtensionPoints<IEntitySelectResolver>());

	public IMemoryCacheService MemoryCacheService { get; set; }

	public IHierarchicalMetadataService HierarchicalMetadataService { get; set; }

	public IEnumerable<IFormCreator> FormCreators { get; set; }

	public IEnumerable<IEntityFilterProvider> EntityFilterProviders { get; set; }

	public IEnumerable<IEntityTitleResolver> EntityTitleResolvers { get; set; }

	public IEnumerable<IDefaultFilterCatalogExtension> DefaultFilterCatalogExtensions { get; set; }

	public EntityUrlResolverService EntityUrlResolverService { get; set; }

	public ActionResult PopupEntity(Guid uid, string inputId, [JsonBinder] ICollection<SelectListItem> selected, bool multiselect, string filterProviderUid = null, string filterProviderData = null)
	{
		if (string.IsNullOrEmpty(inputId))
		{
			throw new ArgumentNullException("inputId");
		}
		if (uid == Guid.Empty)
		{
			throw new ArgumentNullException("uid");
		}
		EntityPopupSelectorModel model = new EntityPopupSelectorModel
		{
			InputId = inputId,
			SelectedItems = ((selected != null) ? selected.ToList() : new List<SelectListItem>()),
			MultiSelect = multiselect
		};
		IEntityManager entityManager = ModelHelper.GetEntityManager(base.IMetadataRuntimeService.GetTypeByUid(uid));
		IEntityFilter filter = CreateEntityFilter(uid);
		if (!string.IsNullOrEmpty(filterProviderUid))
		{
			Guid uidFP = new Guid(filterProviderUid);
			IEntityFilterProvider entityFilterProvider = EntityFilterProviders.First((IEntityFilterProvider p) => p.ProviderUid == uidFP);
			IEntityFilter filter2 = entityFilterProvider.GetFilter(uid, filter);
			if (filter2 != null)
			{
				filter = filter2;
			}
			entityFilterProvider.ApplyFilter(filter, filterProviderData);
		}
		IEnumerable<IEntity> source = entityManager.Find(filter, FetchOptions.All).Cast<IEntity>();
		model.AvalibleItems = (from i in source.Select((Func<IEntity, SelectListItem>)delegate(IEntity i)
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Unknown result type (might be due to invalid IL or missing references)
				//IL_0023: Expected O, but got Unknown
				SelectListItem val = new SelectListItem();
				val.set_Value(i.GetId().ToString());
				val.set_Text(i.ToString());
				return val;
			})
			where !string.IsNullOrEmpty(i.get_Text())
			select i).ToList();
		if (model.SelectedItems.Any())
		{
			if (multiselect)
			{
				model.AvalibleItems = model.AvalibleItems.Where((SelectListItem a) => !model.SelectedItems.Any((SelectListItem s) => s.get_Value() == a.get_Value())).ToList();
			}
			else
			{
				model.AvalibleItems.First((SelectListItem a) => a.get_Value() == model.SelectedItems.First().get_Value()).set_Selected(true);
			}
		}
		model.AvalibleItems = model.AvalibleItems.OrderBy((SelectListItem i) => i.get_Text()).ToList();
		return (ActionResult)(object)((Controller)this).PartialView("EditorTemplates/PopupEntity", (object)model);
	}

	public static JsonResult SelectEntitiesForComboBox(EntitiesForComboboxSelectionModel model)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		if (model.Uid == Guid.Empty)
		{
			JsonResult val = new JsonResult();
			val.set_Data((object)new
			{
				total = 0,
				items = new { }
			});
			return val;
		}
		Func<string, IEntityFilter> func = delegate(string t)
		{
			IEntityFilter entityFilter3 = model.EntityFilter;
			if (!string.IsNullOrEmpty(t))
			{
				entityFilter3.SearchString = t;
			}
			entityFilter3.ShowOnlyGroups = model.ShowOnlyGroups;
			if (!string.IsNullOrEmpty(model.FilterProviderUid))
			{
				Guid uidFP = new Guid(model.FilterProviderUid);
				IEntityFilterProvider entityFilterProvider = model.EntityFilterProviders.FirstOrDefault((IEntityFilterProvider p) => p.ProviderUid == uidFP);
				if (entityFilterProvider != null)
				{
					IEntityFilter filter = entityFilterProvider.GetFilter(model.Uid, entityFilter3);
					if (filter != null)
					{
						entityFilter3 = filter;
						if (!string.IsNullOrEmpty(t))
						{
							entityFilter3.SearchString = t;
						}
					}
					entityFilterProvider.ApplyFilter(entityFilter3, model.FilterProviderData);
				}
			}
			return entityFilter3;
		};
		Func<EntitySelectModel, bool, bool, IEntityMetadata, IEntity, EntitySelectGroupStyles, SelectEntitiesAndGroupsModel> getObjects = delegate(EntitySelectModel esm, bool igm, bool ielem, IEntityMetadata em, IEntity lob, EntitySelectGroupStyles st)
		{
			if (igm && (model.ShowOnlyGroups ^ (bool)esm.Entity.GetPropertyValue(em.IsGroupPropertyUid)))
			{
				return new SelectEntitiesAndGroupsModel
				{
					IsGroup = true,
					Value = esm.Entity.GetId().ToString(),
					Text = ((model.EntityNameFunc != null) ? model.EntityNameFunc(esm.Entity) : null)
				};
			}
			string text = string.Empty;
			if (model.EntityNameFunc != null)
			{
				text = model.EntityNameFunc(esm.Entity);
			}
			if (model.Localize)
			{
				text = SR.T(text);
			}
			text = text.HtmlEncode();
			string text2 = string.Empty;
			if (model.DropDownTextFunc != null)
			{
				text2 = model.DropDownTextFunc(esm.Entity);
			}
			text2 = ((!string.IsNullOrEmpty(text2)) ? text2 : text);
			if (st != null)
			{
				string text3 = "";
				if (st.FontColor.HasValue)
				{
					text3 += $"color:{ColorTranslator.ToHtml(st.FontColor.Value)};";
				}
				if (st.BackgroundColor.HasValue)
				{
					text3 += $"background:{ColorTranslator.ToHtml(st.BackgroundColor.Value)};";
				}
				if (st.FontStyle.HasValue)
				{
					switch (st.FontStyle.Value)
					{
					case FontStyle.Italic:
						text3 += "font-style:italic;";
						break;
					case FontStyle.Bold:
						text3 += "font-weight:bold;";
						break;
					case FontStyle.Underline:
						text3 += "text-decoration:underline;";
						break;
					case FontStyle.Strikeout:
						text3 += "text-decoration:line-through;";
						break;
					}
				}
				if (!string.IsNullOrEmpty(text3))
				{
					text2 = string.Format("<div style='{1}'>{0}</div>", text2, text3);
				}
			}
			EntitySelectModel entitySelectModel = ((esm.GetParent != null) ? esm.GetParent() : null);
			return new SelectEntitiesAndGroupsModel
			{
				Value = esm.Entity.GetId().ToString(),
				Text = text,
				EntityUrl = model.Controller.get_Url().Entity(esm.Entity),
				DropDownText = text2,
				IsEndItem = (lob?.Equals(esm.Entity) ?? false),
				EndItemText = ((lob != null && lob.Equals(esm.Entity)) ? SR.T("Остальные") : null),
				Parent = entitySelectModel?.Entity.GetId().ToString(),
				Level = esm.Level
			};
		};
		IEntityMetadata entityMetadata;
		IEntity entity = model.EntityUrlResolverService.ParseEntityUrl(model.Text, model.Uid, out entityMetadata);
		if (entity != null)
		{
			IEntityFilter entityFilter = func(null);
			entityFilter.Id = entity.GetId();
			if (!model.EntityManager.Exists(entityFilter))
			{
				JsonResult val2 = new JsonResult();
				val2.set_Data((object)new List<SelectEntitiesAndGroupsModel>());
				return val2;
			}
			JsonResult val3 = new JsonResult();
			val3.set_Data((object)new List<SelectEntitiesAndGroupsModel> { getObjects(new EntitySelectModel
			{
				Entity = entity
			}, arg2: false, arg3: false, entityMetadata, null, null) });
			return val3;
		}
		Type typeByUid = model.MetadataRuntimeService.GetTypeByUid(model.Uid);
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeByUid);
		entityMetadata = classMetadata as IEntityMetadata;
		bool isGroupMetadata = entityMetadata != null && entityMetadata.Hierarchical && entityMetadata.HierarchyType == HierarchyType.GroupAndElements && entityMetadata.IsGroupPropertyUid != Guid.Empty;
		bool isHierarchyElement = !isGroupMetadata && entityMetadata.Hierarchical && entityMetadata.ParentPropertyUid != Guid.Empty && entityMetadata.HierarchyType == HierarchyType.Elements;
		IEntityFilter entityFilter2 = func(model.Text);
		IEnumerable<IEntity> items;
		if (!string.IsNullOrEmpty(model.Id))
		{
			string[] array = model.Id.Split('_');
			List<object> list = new List<object>();
			string[] array2 = array;
			for (int j = 0; j < array2.Length; j++)
			{
				if (long.TryParse(array2[j], out var result))
				{
					list.Add(result);
				}
			}
			if (list.Count != 0)
			{
				items = model.EntityManager.FindByIdArray(list.ToArray()).Cast<IEntity>();
			}
			else
			{
				entityFilter2.Id = ModelHelper.TryConvertEntityId(typeByUid, model.Id);
				items = model.EntityManager.Find(entityFilter2, new FetchOptions(0, model.Limit, model.SortExpression)).Cast<IEntity>();
			}
		}
		else
		{
			items = model.EntityManager.Find(entityFilter2, new FetchOptions(0, model.Limit, model.SortExpression)).Cast<IEntity>();
		}
		IEnumerable<IEntitySelectResolver> entitySortResolvers = ((string.IsNullOrEmpty(model.SortExpression) && EntitySelectResolvers != null) ? EntitySelectResolvers.Where((IEntitySelectResolver res) => res.CheckType(model.Uid)) : null);
		SelectEntitiesAndGroupsModel[] data = (from i in items.EntitySelectGroup(model.Uid, delegate(IEnumerable<IEntity> l, EntitySelectGroup g)
			{
				List<EntitySelectModel> list2 = new List<EntitySelectModel>();
				bool flag = entitySortResolvers != null && entitySortResolvers.Any();
				list2 = ((!flag) ? l.Select((IEntity en) => new EntitySelectModel
				{
					Entity = en
				}).ToList() : entitySortResolvers.SelectMany((IEntitySelectResolver res) => res.GetItems(model.Uid, l).ToList()).Distinct((EntitySelectModel a, EntitySelectModel b) => a.Entity == b.Entity && a.Priority > b.Priority).ToList());
				IEnumerable<SelectEntitiesAndGroupsModel> enumerable = from u in list2
					select getObjects(u, isGroupMetadata, isHierarchyElement, entityMetadata, null, (g != null) ? g.Styles : null) into i
					where !string.IsNullOrEmpty(i.Text)
					select i;
				return (!string.IsNullOrEmpty(model.SortExpression) || flag) ? enumerable : enumerable.OrderBy((SelectEntitiesAndGroupsModel i) => i.Text);
			}, (EntitySelectGroup g) => new SelectEntitiesAndGroupsModel
			{
				DropDownText = g.StyleHeader,
				ViewText = g.Header,
				Text = g.Header,
				VirtualItem = true,
				Level = g.Level
			})
			where !i.IsGroup
			select i).ToArray();
		JsonResult val4 = new JsonResult();
		val4.set_Data((object)data);
		return val4;
	}

	public JsonResult Select(string text, Guid uid, string id = null, bool showOnlyGroups = false, int max = 100, string filterProviderUid = null, string filterProviderData = null, string sortExpression = null, bool localize = false)
	{
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		try
		{
			return SelectEntitiesForComboBox(new EntitiesForComboboxSelectionModel
			{
				Text = text,
				Uid = uid,
				Id = id,
				ShowOnlyGroups = showOnlyGroups,
				Limit = max,
				FilterProviderUid = filterProviderUid,
				FilterProviderData = filterProviderData,
				SortExpression = sortExpression,
				Localize = localize,
				EntityManager = GetEntityManager(uid),
				EntityFilter = CreateEntityFilter(uid),
				EntityUrlResolverService = EntityUrlResolverService,
				Controller = (Controller)(object)this,
				MetadataRuntimeService = base.IMetadataRuntimeService,
				EntityFilterProviders = EntityFilterProviders,
				EntityNameFunc = (IEntity entity) => GetEntityTitle(entity),
				DropDownTextFunc = (IEntity entity) => GetFullEntityTitle(entity)
			});
		}
		catch (Exception ex)
		{
			base.Logger.Error(ex.Message, ex);
			string message = ex.Message;
			JsonResult val = new JsonResult();
			val.set_Data((object)new
			{
				error = message
			});
			return val;
		}
	}

	protected dynamic GetObjectForResult(IEntity u, bool showOnlyGroups, bool isGroupMetadata, IEntityMetadata entityMetadata, IEntity lastObjectEnd, EntitySelectGroupStyles styles = null, bool localize = false)
	{
		if (!showOnlyGroups)
		{
			if (isGroupMetadata && (bool)u.GetPropertyValue(entityMetadata.IsGroupPropertyUid))
			{
				return new
				{
					Text = ""
				};
			}
		}
		else if (isGroupMetadata && !(bool)u.GetPropertyValue(entityMetadata.IsGroupPropertyUid))
		{
			return new
			{
				Text = ""
			};
		}
		string text = GetEntityTitle(u);
		if (localize)
		{
			text = SR.T(text);
		}
		text = text.HtmlEncode();
		string fullEntityTitle = GetFullEntityTitle(u);
		fullEntityTitle = ((!string.IsNullOrWhiteSpace(fullEntityTitle)) ? fullEntityTitle : text);
		if (styles != null)
		{
			string text2 = "";
			if (styles.FontColor.HasValue)
			{
				text2 += $"color:{ColorTranslator.ToHtml(styles.FontColor.Value)};";
			}
			if (styles.BackgroundColor.HasValue)
			{
				text2 += $"background:{ColorTranslator.ToHtml(styles.BackgroundColor.Value)};";
			}
			if (styles.FontStyle.HasValue)
			{
				switch (styles.FontStyle.Value)
				{
				case FontStyle.Italic:
					text2 += "font-style:italic;";
					break;
				case FontStyle.Bold:
					text2 += "font-weight:bold;";
					break;
				case FontStyle.Underline:
					text2 += "text-decoration:underline;";
					break;
				case FontStyle.Strikeout:
					text2 += "text-decoration:line-through;";
					break;
				}
			}
			if (!string.IsNullOrEmpty(text2))
			{
				fullEntityTitle = string.Format("<div style='{1}'>{0}</div>", fullEntityTitle, text2);
			}
		}
		return new
		{
			Value = u.GetId().ToString(),
			Text = text,
			EntityUrl = ((Controller)this).get_Url().Entity(u),
			DropDownText = fullEntityTitle,
			IsEndItem = (lastObjectEnd?.Equals(u) ?? false),
			EndItemText = ((lastObjectEnd != null && lastObjectEnd.Equals(u)) ? SR.T("Остальные") : null)
		};
	}

	public JsonResult SelectHierarchical(string text, Guid uid, string id = null, int max = 100, string filterProviderData = null, string sortExpression = null)
	{
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		if (uid == Guid.Empty)
		{
			return ((Controller)this).Json((object)new
			{
				total = 0,
				items = new { }
			});
		}
		try
		{
			Type typeByUid = base.IMetadataRuntimeService.GetTypeByUid(uid);
			IEntityMetadata metadata = ((ClassMetadata)MetadataLoader.LoadMetadata(typeByUid)) as IEntityMetadata;
			IEntityFilter entityFilter = CreateEntityFilter(uid);
			entityFilter.SearchString = text;
			entityFilter.ShowOnlyGroups = false;
			if (!string.IsNullOrEmpty(id))
			{
				entityFilter.Id = ModelHelper.TryConvertEntityId(typeByUid, id);
			}
			long? parentId = null;
			int result = 0;
			int result2 = 0;
			if (!string.IsNullOrWhiteSpace(filterProviderData) && filterProviderData != null)
			{
				string[] source = filterProviderData.Trim().Split(';');
				if (source.Any())
				{
					Dictionary<string, string> dictionary = (from parStr in source
						select parStr.Trim().Split('=') into parStrList
						where parStrList != null && parStrList.Count() == 2
						select parStrList).ToDictionary((string[] parStrList) => parStrList[0], (string[] parStrList) => parStrList[1]);
					if (dictionary.ContainsKey("parentId"))
					{
						parentId = (long.TryParse(dictionary["parentId"], out var result3) ? result3 : 0);
					}
					if (dictionary.ContainsKey("parentRootId"))
					{
						parentId = null;
					}
					if (dictionary.ContainsKey("indent"))
					{
						int.TryParse(dictionary["indent"], out result);
					}
					if (dictionary.ContainsKey("deep"))
					{
						int.TryParse(dictionary["deep"], out result2);
					}
				}
			}
			List<object> data = (from u in HierarchicalMetadataService.GetAllHierarchicalEntities(metadata, parentId, result, result2)
				select GetHierarchicalObjectForResult(u) into i
				where !string.IsNullOrEmpty(i.Text)
				orderby i.Text
				select i).ToList();
			JsonResult val = new JsonResult();
			val.set_Data((object)data);
			return val;
		}
		catch (Exception ex)
		{
			base.Logger.Error(ex.Message, ex);
			string message = ex.Message;
			JsonResult val2 = new JsonResult();
			val2.set_Data((object)new
			{
				error = message
			});
			return val2;
		}
	}

	protected dynamic GetHierarchicalObjectForResult(KeyValuePair<long, string> u)
	{
		return new
		{
			Value = u.Key.ToString(),
			Text = u.Value,
			DropDownText = u.Value,
			Html = u.Value,
			IsEndItem = false,
			EndItemText = (string)null
		};
	}

	protected string GetFullEntityTitle(IEntity entity)
	{
		if (entity == null)
		{
			return string.Empty;
		}
		return ((object)EntityTitleResolvers.FirstOrDefault((IEntityTitleResolver r) => r.CheckType(entity))?.GetTitle(entity, ((Controller)this).get_Url())).ToString();
	}

	protected string GetEntityTitle(IEntity entity)
	{
		string text = entity.ToString();
		if (text.IsNullOrEmpty())
		{
			return SR.Untitled;
		}
		return text;
	}

	public JsonResult SelectToken(string text, Guid uid, int max = 100)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		if (uid == Guid.Empty)
		{
			return ((Controller)this).Json((object)new
			{
				total = 0,
				items = new { }
			});
		}
		IEntityManager entityManager = GetEntityManager(uid);
		Filter filter = CreateEntityFilter(uid);
		filter.SearchString = text;
		var data = (from IEntity u in entityManager.Find(filter, new FetchOptions(0, max, null))
			select new
			{
				id = u.GetId().ToString(),
				text = u.ToString()
			} into i
			where !string.IsNullOrEmpty(i.text)
			orderby i.text
			select i).ToList();
		JsonResult val = new JsonResult();
		val.set_Data((object)data);
		return val;
	}

	protected IEntityManager GetEntityManager(Guid uid)
	{
		if (uid == Guid.Empty)
		{
			return null;
		}
		return ModelHelper.GetEntityManager(base.IMetadataRuntimeService.GetTypeByUid(uid));
	}

	protected Filter CreateEntityFilter(Guid uid)
	{
		if (uid == Guid.Empty)
		{
			return new Filter();
		}
		Type typeByUid = base.IMetadataRuntimeService.GetTypeByUid(uid);
		try
		{
			Type entityFilterType = ModelHelper.GetEntityFilterType(typeByUid);
			if (entityFilterType == null)
			{
				return new Filter();
			}
			return (Filter)InterfaceActivator.Create(entityFilterType);
		}
		catch (Exception ex)
		{
			base.Logger.Error(ex.Message, ex);
		}
		return new Filter();
	}

	public JsonResult FullSelect(string query, long? start, long? limit, string sort, string dir, Guid uid)
	{
		if (uid == Guid.Empty)
		{
			return ((Controller)this).Json((object)new
			{
				total = 0,
				items = new { }
			});
		}
		Type typeByUid = base.IMetadataRuntimeService.GetTypeByUid(uid);
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(typeByUid);
		IEntityManager entityManager = ModelHelper.GetEntityManager(typeByUid);
		IEntityFilter entityFilter = CreateEntityFilter(uid);
		entityFilter.SearchString = query;
		int num = entityManager.Find(entityFilter, new FetchOptions(0, int.MaxValue, null)).Cast<IEntity>().Count();
		if (num == 0)
		{
			return ((Controller)this).Json((object)new
			{
				total = 0,
				items = new List<object>()
			}, (JsonRequestBehavior)0);
		}
		IEnumerable<IEntity> enumerable = entityManager.Find(entityFilter, new FetchOptions(Convert.ToInt32(start), Convert.ToInt32(limit), (dir == "DESC") ? ListSortDirection.Descending : ListSortDirection.Ascending, sort)).Cast<IEntity>();
		List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
		foreach (IEntity item in enumerable)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string> { 
			{
				"Id",
				item.GetId().ToString()
			} };
			foreach (EntityPropertyMetadata property in entityMetadata.Properties)
			{
				if (!property.ShowInTable)
				{
					continue;
				}
				PropertyInfo reflectionProperty = item.GetType().GetReflectionProperty(property.Name);
				if (!(reflectionProperty != null) || reflectionProperty.PropertyType.IsGenericType)
				{
					continue;
				}
				object value = reflectionProperty.GetValue(item, null);
				if (value == null)
				{
					dictionary.Add(property.Name, "");
					continue;
				}
				if (property.SubTypeUid == Guid.Empty)
				{
					dictionary.Add(property.Name, value.ToString());
					continue;
				}
				ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(property.SubTypeUid, inherit: false);
				if (value is IEntity)
				{
					dictionary.Add(property.Name, ((IEntity)value).ToString(classMetadata.DisplayFormat));
				}
			}
			list.Add(dictionary);
		}
		var anon = new
		{
			total = num,
			items = list
		};
		return ((Controller)this).Json((object)anon, (JsonRequestBehavior)0);
	}

	public ActionResult PropertySelector(Type objectType, Guid? typeUid, string typePath, string path, string displayPath, string popupId)
	{
		PropertySelectorInfo model = new PropertySelectorInfo();
		if (typeUid.HasValue)
		{
			((ClassMetadata)MetadataLoader.LoadMetadata(typeUid.Value)).Properties.ForEach(delegate(PropertyMetadata p)
			{
				if (p.SubTypeUid != Guid.Empty && p.Settings is EntitySettings)
				{
					if (((EntitySettings)p.Settings).RelationType == RelationType.OneToOne)
					{
						model.Properties.Add(p.Name, p);
					}
				}
				else
				{
					model.Properties.Add(p.Name, p);
				}
			});
			model.TypeUid = typeUid.Value;
		}
		else if (objectType != null)
		{
			GenerateTextModel generateTextModel = (GenerateTextModel)Activator.CreateInstance(objectType);
			model.Properties = generateTextModel.Properties;
		}
		model.Path = path;
		model.DisplayPath = displayPath;
		model.PopupId = popupId;
		model.ObjectType = objectType;
		model.TypePath = typePath;
		return (ActionResult)(object)((Controller)this).PartialView((object)model);
	}

	private FilterModel CreateFilter(Guid typeUid, bool existPropertiesForFastSearch = true)
	{
		FilterModel filterModel = new FilterModel(InterfaceActivator.Create<IFilter>(), typeUid, null, null, "Filter", null, null, EnableEqlQuery);
		((Controller)this).TryUpdateModel<IEntityFilter>(filterModel.Filter);
		filterModel.ExistPropertiesForFastSearch = existPropertiesForFastSearch;
		foreach (IDefaultFilterCatalogExtension item in DefaultFilterCatalogExtensions.Where((IDefaultFilterCatalogExtension a) => a.EntityTypeUid == typeUid))
		{
			filterModel.Filter = item.ModifyFilter(filterModel.Filter);
		}
		return filterModel;
	}

	private string CacheExplorerFilterStyleKey(Guid typeUid)
	{
		return "GetExplorerFilterStyle_" + typeUid.ToString("n");
	}

	private void SetCacheExplorerFilterStyle(Guid typeUid, ExplorerFilterStyleEnum style)
	{
		try
		{
			MemoryCacheService.Insert(CacheExplorerFilterStyleKey(typeUid), style);
		}
		catch (Exception)
		{
		}
	}

	private Type GetExplorerFilterController(Guid typeUid)
	{
		Type entityType = base.IMetadataRuntimeService.GetTypeByUidOrNull(typeUid);
		if (entityType == null)
		{
			return null;
		}
		Type typeFromHandle = typeof(IBaseController);
		foreach (Type extensionPointType in ComponentManager.Current.GetExtensionPointTypes(typeFromHandle))
		{
			IEnumerable<MethodInfo> enumerable = extensionPointType.GetMethods().Where(delegate(MethodInfo m)
			{
				EntityListLinkAttribute entityListLinkAttribute = (EntityListLinkAttribute)m.GetCustomAttributes(typeof(EntityListLinkAttribute), inherit: false).FirstOrDefault();
				return entityListLinkAttribute != null && entityListLinkAttribute.EntityType == entityType;
			});
			if (enumerable != null && enumerable.Any())
			{
				return extensionPointType;
			}
			Type type = extensionPointType;
			while (type != null && (!type.IsGenericType || type.GetGenericTypeDefinition() != typeof(FilterTreeBaseController<, >)))
			{
				type = type.BaseType;
			}
			if (type != null && type.IsGenericType)
			{
				Type[] genericArguments = type.GetGenericArguments();
				if (genericArguments != null && genericArguments.Length == 2 && (entityType == genericArguments[0] || (typeof(IEntity).IsAssignableFrom(genericArguments[0]) && typeUid == InterfaceActivator.UID(genericArguments[0]))))
				{
					return extensionPointType;
				}
			}
		}
		if (!(MetadataLoader.LoadMetadata(entityType) is EntityMetadata entityMetadata) || entityMetadata.BaseClassUid == Guid.Empty)
		{
			return null;
		}
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entityMetadata.BaseClassUid);
		if (classMetadata == null)
		{
			return null;
		}
		return GetExplorerFilterController(classMetadata.Uid);
	}

	private ExplorerFilterStyleEnum GetExplorerFilterStyle(Guid typeUid)
	{
		if (!MemoryCacheService.TryGetValue<ExplorerFilterStyleEnum>(CacheExplorerFilterStyleKey(typeUid), out var result))
		{
			Type explorerFilterController = GetExplorerFilterController(typeUid);
			if (explorerFilterController != null)
			{
				try
				{
					PropertyInfo property = explorerFilterController.GetProperty("EnableEqlQuery", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					if (property != null)
					{
						object obj = Activator.CreateInstance(explorerFilterController);
						if ((bool)property.GetValue(obj, null))
						{
							SetCacheExplorerFilterStyle(typeUid, ExplorerFilterStyleEnum.SearchFilterEql);
							return ExplorerFilterStyleEnum.SearchFilterEql;
						}
					}
					SetCacheExplorerFilterStyle(typeUid, ExplorerFilterStyleEnum.SearchFilter);
					return ExplorerFilterStyleEnum.SearchFilter;
				}
				catch (Exception)
				{
				}
			}
			IEnumerable<EntityMetadata> enumerable = from em in CatalogsController.EntityList.OfType<EntityMetadata>()
				where em.TypeUid == typeUid || em.ImplementationUid == typeUid
				select em;
			if (enumerable != null && enumerable.Any())
			{
				SetCacheExplorerFilterStyle(typeUid, ExplorerFilterStyleEnum.SearchFilterEql);
				return ExplorerFilterStyleEnum.SearchFilterEql;
			}
			SetCacheExplorerFilterStyle(typeUid, ExplorerFilterStyleEnum.Search);
			return ExplorerFilterStyleEnum.Search;
		}
		return result;
	}

	[CreatorForm]
	[CustomGridAction]
	public ActionResult Explorer(string inputId, Guid typeUid, string parentId = null, string searchQuery = null, bool justReload = false, bool showOnlyGroups = false, string filterProviderUid = null, string filterProviderData = null, bool multiSelect = false, string chooseHandler = null, string parentPage = null)
	{
		ExplorerFilterStyleEnum explorerFilterStyle = GetExplorerFilterStyle(typeUid);
		Type typeByUid = base.IMetadataRuntimeService.GetTypeByUid(typeUid);
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeByUid);
		IEntityMetadata entityMetadata = classMetadata as IEntityMetadata;
		bool existPropertiesForFastSearch = entityMetadata != null && EntityHelper.GetEntityManager(typeByUid).ExistPropertiesForFastSearch(entityMetadata);
		EntityViewModel entityViewModel = new EntityViewModel
		{
			Metadata = classMetadata,
			Filter = CreateFilter(classMetadata.Uid, existPropertiesForFastSearch)
		};
		if (entityViewModel.Filter != null)
		{
			entityViewModel.Filter.EnableSave = false;
			entityViewModel.Filter.EnableEqlQuery = string.IsNullOrEmpty(filterProviderData) && explorerFilterStyle == ExplorerFilterStyleEnum.SearchFilterEql;
			entityViewModel.Filter.Expandable = explorerFilterStyle == ExplorerFilterStyleEnum.SearchFilter || explorerFilterStyle == ExplorerFilterStyleEnum.SearchFilterEql;
		}
		PropertyMetadata propertyMetadata = ((entityMetadata != null && entityMetadata.Hierarchical && entityMetadata.ParentPropertyUid != Guid.Empty) ? classMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == entityMetadata.ParentPropertyUid) : null);
		if (entityMetadata != null && entityMetadata.Hierarchical && propertyMetadata != null)
		{
			object obj = ModelHelper.TryConvertEntityId(typeByUid, parentId);
			entityViewModel.CurrentFolderObject = ((obj != null) ? ((IEntity)ModelHelper.GetEntityManager(typeByUid).Load(obj)) : null);
			entityViewModel.ParentPropertyUid = propertyMetadata.Uid;
		}
		if (!justReload)
		{
			((ControllerBase)this).get_ViewData().set_Item("typeUid", (object)typeUid);
			((ControllerBase)this).get_ViewData().set_Item("inputId", (object)inputId);
		}
		string text = string.Format("Explorer_{0}", Guid.NewGuid().ToString("n"));
		((ControllerBase)this).get_ViewData().set_Item("filterGridId", (object)text);
		((Controller)this).get_RouteData().Values.Add("prefix", text);
		((ControllerBase)this).get_ViewData().set_Item("showOnlyGroups", (object)showOnlyGroups);
		((ControllerBase)this).get_ViewData().set_Item("filterProviderUid", (object)filterProviderUid);
		((ControllerBase)this).get_ViewData().set_Item("filterProviderData", (object)filterProviderData);
		((ControllerBase)this).get_ViewData().set_Item("multiSelect", (object)multiSelect);
		((ControllerBase)this).get_ViewData().set_Item("chooseHandler", (object)chooseHandler);
		return (ActionResult)(object)((Controller)this).PartialView("Entity/ExplorerEntity", (object)entityViewModel);
	}

	[CustomGridAction]
	public ActionResult ExplorerGrid(GridCommand command, [Bind(Prefix = "DataFilter")] FilterModel model, string inputId, Guid typeUid, string parentId = null, string searchQuery = null, bool justReload = false, bool showOnlyGroups = false, string filterProviderUid = null, string filterProviderData = null, bool multiSelect = false, string chooseHandler = null, string parentPage = null)
	{
		Type typeByUid = base.IMetadataRuntimeService.GetTypeByUid(typeUid);
		ClassMetadata metadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeByUid);
		IEntityMetadata entityMetadata = metadata as IEntityMetadata;
		HtmlHelper html = GetHtmlHelper();
		IEntityFilter filter = model?.Filter;
		GridResult gridResult = Grid(command, typeUid, typeByUid, metadata, entityMetadata, parentId, searchQuery, filter, null, showOnlyGroups, inputId, filterProviderUid, filterProviderData);
		if (gridResult == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		DynamicGrid gridData = gridResult.GridData;
		gridData.CallbackFunction = "closeWindow('gridSettings_" + gridData.UniqueName + "'); searchBooksFor" + inputId + "(); refreshCurrentPopup" + inputId + "();";
		gridData.RowHtmlAttributesDelegate = GetRowHtmlAttributesDelegate(typeByUid, inputId, typeUid, gridResult.ParentId, showOnlyGroups, multiSelect, chooseHandler);
		PropertyMetadata titleProperty = metadata.GetTitleProperty();
		if (titleProperty == null)
		{
			titleProperty = metadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "Name");
		}
		if (multiSelect)
		{
			DynamicGridColumn item = new DynamicGridColumn
			{
				Header = SelectAllHeaderTemplate(html, inputId),
				Sortable = false,
				Groupable = false,
				CellAlignment = LineAlignment.Left,
				Visible = true,
				UniqueName = "multiSelectGridColomn",
				Name = "multiSelectColomn",
				ValueType = typeof(bool),
				Metadata = metadata,
				Width = "1px",
				Template = (dynamic entity) => MultiSelectColumnTemplate((IEntity)entity, inputId, html, typeUid, (titleProperty != null) ? titleProperty.Uid : Guid.Empty, showOnlyGroups)
			};
			((List<GridColumn>)gridData.Columns).Add(item);
		}
		if (entityMetadata != null && entityMetadata.Hierarchical)
		{
			GridColumn gridColumn = new GridColumn
			{
				ValueType = typeof(string),
				Name = null,
				Header = "",
				Sortable = false,
				UniqueName = "folderColumn" + typeUid,
				Width = ((gridResult.GridTableView == null || gridResult.GridTableView.Resizeable) ? "48px" : "1%")
			};
			Func<object, string> func2 = (Func<object, string>)(gridColumn.Template = (Func<object, string>)((dynamic entity) => FolderCellTemplate(entity, inputId, typeUid, gridResult.ParentId, showOnlyGroups, multiSelect)));
			gridData.Columns.Add(gridColumn);
		}
		((List<GridColumn>)gridData.Columns).AddRange(GridBuilderExtensions.GetDefaultColumns(typeByUid, metadata, gridData.State));
		GridColumn gridColumn2 = ((titleProperty != null) ? gridData.Columns.FirstOrDefault((GridColumn c) => c.UniqueName == titleProperty.Uid.ToString()) : null);
		if (gridColumn2 != null)
		{
			gridColumn2.Template = (dynamic entity) => TitleCellTemplate((IEntity)entity, typeUid, titleProperty.Uid, gridResult.ParentId, metadata, inputId, showOnlyGroups, multiSelect, parentPage);
		}
		if (!justReload)
		{
			((ControllerBase)this).get_ViewData().set_Item("typeUid", (object)typeUid);
			((ControllerBase)this).get_ViewData().set_Item("inputId", (object)inputId);
			((ControllerBase)this).get_ViewData().set_Item("metadataDisplayname", (object)entityMetadata.DisplayName);
			((ControllerBase)this).get_ViewData().set_Item("hierarchical", (object)entityMetadata.Hierarchical);
		}
		((ControllerBase)this).get_ViewData().set_Item("showOnlyGroups", (object)showOnlyGroups);
		((ControllerBase)this).get_ViewData().set_Item("filterProviderUid", (object)filterProviderUid);
		((ControllerBase)this).get_ViewData().set_Item("filterProviderData", (object)filterProviderData);
		((ControllerBase)this).get_ViewData().set_Item("multiSelect", (object)multiSelect);
		((ControllerBase)this).get_ViewData().set_Item("chooseHandler", (object)chooseHandler);
		((ControllerBase)this).get_ViewData().set_Item("IsDynamicInitialized", (object)true);
		return (ActionResult)(object)((Controller)this).PartialView(justReload ? "Templates/DynamicGrid" : "Entity/Explorer", (object)gridData);
	}

	private string MultiSelectColumnTemplate(IEntity entity, string inputId, HtmlHelper html, Guid typeUid, Guid titlePropertyUid, bool showOnlyGroups)
	{
		if (entity == null)
		{
			return string.Empty;
		}
		object obj = string.Empty;
		try
		{
			obj = entity.GetPropertyValue(titlePropertyUid);
		}
		catch
		{
		}
		obj = ((obj != null) ? obj.ToString() : string.Empty);
		obj = HttpUtility.HtmlEncode(obj);
		obj = (string.IsNullOrWhiteSpace(obj.ToString()) ? SR.Untitled : obj);
		if ((ClassMetadata)base.IMetadataRuntimeService.GetMetadata(typeUid) is IEntityMetadata entityMetadata && (showOnlyGroups || entityMetadata.HierarchyType == HierarchyType.Elements || !(entityMetadata.IsGroupPropertyUid != Guid.Empty) || !(bool)entity.GetPropertyValue(entityMetadata.IsGroupPropertyUid)))
		{
			object id = entity.GetId();
			ModernCheckBoxBuilder modernCheckBoxBuilder = html.ModernCheckBox(renderUncheckedInput: false);
			modernCheckBoxBuilder.Id($"selectCheckbox{inputId}_{id}");
			return string.Format("<div>{0}</div><div>{1}</div>", modernCheckBoxBuilder.ToHtmlString(), string.Format("<input type=\"hidden\" id=\"{0}_{1}-titleInput\" value=\"{2}\" />", inputId.Replace("_", "x"), entity.GetId(), obj));
		}
		return string.Empty;
	}

	private string SelectAllHeaderTemplate(HtmlHelper html, string inputId)
	{
		string functionId = inputId.Replace("_", "x");
		ModernCheckBoxBuilder modernCheckBoxBuilder = html.ModernCheckBox(renderUncheckedInput: false);
		modernCheckBoxBuilder.Id("selectAll-checkbox" + functionId);
		modernCheckBoxBuilder.Attributes(delegate(HtmlAttributes a)
		{
			a.onclick = "selectAll" + functionId + "()";
		});
		modernCheckBoxBuilder.ContainerAttributes(delegate(HtmlAttributes a)
		{
			a.Add("tooltiptext", SR.T("Выбрать все/Снять выделение"));
		});
		return modernCheckBoxBuilder.ToHtmlString();
	}

	private Delegate GetRowHtmlAttributesDelegate(Type type, string inputId, Guid typeUid, object parentId, bool showOnlyGroups, bool multiSelect, string chooseHandler = null)
	{
		return (Delegate)((object)this).GetType().GetMethod("GetRowHtmlAttributesDelegateGeneric", BindingFlags.Instance | BindingFlags.NonPublic).MakeGenericMethod(type)
			.Invoke(this, new object[6] { inputId, typeUid, parentId, showOnlyGroups, multiSelect, chooseHandler });
	}

	private Delegate GetRowHtmlAttributesDelegateGeneric<T>(string inputId, Guid typeUid, object parentId, bool showOnlyGroups, bool multiSelect, string chooseHandler = null) where T : class, IEntity
	{
		return (Func<T, Grid<T>, object>)delegate(T r, Grid<T> grid)
		{
			IEntityMetadata entityMetadata = ((ClassMetadata)base.IMetadataRuntimeService.GetMetadata(typeUid)) as IEntityMetadata;
			bool flag = false;
			if (entityMetadata != null && entityMetadata.Hierarchical && entityMetadata.HierarchyType != HierarchyType.Elements)
			{
				flag = entityMetadata.Hierarchical && entityMetadata.HierarchyType == HierarchyType.GroupAndElements && entityMetadata.IsGroupPropertyUid != Guid.Empty && r != null && (bool)r.GetPropertyValue(entityMetadata.IsGroupPropertyUid);
			}
			string text = inputId.Replace("_", "x");
			string arg = ((!string.IsNullOrEmpty(chooseHandler)) ? chooseHandler : ((multiSelect ? "SelectItem" : "fieldClickEventHandler") + text));
			object obj = ((r != null) ? r.GetId() : parentId);
			return new
			{
				id = string.Format("{0}_{1}", text, obj ?? ""),
				gridUrl = GenerateViewUrl(typeUid, inputId, obj, showOnlyGroups, multiSelect),
				@class = "selectable",
				onclick = string.Format("{0}(event,this,{1});", arg, (!showOnlyGroups && flag) ? "true" : "false")
			};
		};
	}

	private string FolderCellTemplate(IEntity entity, string inputId, Guid uid, object parentId, bool showOnlyGroups, bool multiSelect)
	{
		object parentId2;
		if (entity == null)
		{
			parentId2 = parentId;
		}
		else
		{
			if (!((ClassMetadata)base.IMetadataRuntimeService.GetMetadata(uid) is IEntityMetadata entityMetadata) || !entityMetadata.Hierarchical)
			{
				return string.Empty;
			}
			bool flag = entityMetadata.HierarchyType == HierarchyType.GroupAndElements && entityMetadata.IsGroupPropertyUid != Guid.Empty && (bool)entity.GetPropertyValue(entityMetadata.IsGroupPropertyUid);
			if (!(entityMetadata.HierarchyType == HierarchyType.Elements || flag))
			{
				return string.Empty;
			}
			parentId2 = entity.GetId();
		}
		return HtmlExtensions.Image(((Controller)this).get_Url(), "#folder.svg", SR.T("Перейти в группу"), "", new
		{
			gridUrl = GenerateViewUrl(uid, inputId, parentId2, showOnlyGroups, multiSelect),
			@class = "folderIcon"
		});
	}

	private string TitleCellTemplate(IEntity entity, Guid uid, Guid titlePropertyUid, object parentId, ClassMetadata metadata, string inputId, bool showOnlyGroups, bool multiSelect, string parentPage = "")
	{
		if (entity == null)
		{
			return string.Format("<a id=\"{2}_{3}\" class=\"entityGridItem entityFolder\" gridUrl=\"{0}\" parentPage=\"{4}\" isGroup=\"true\">{1}</a>", GenerateViewUrl(uid, inputId, parentId, showOnlyGroups, multiSelect), HttpUtility.HtmlEncode(SR.T("...\\(на уровень выше)")), inputId.Replace("_", "x"), "up", parentPage);
		}
		IEntityMetadata entityMetadata = metadata as IEntityMetadata;
		bool flag = false;
		if (entityMetadata != null && entityMetadata.Hierarchical)
		{
			flag = entityMetadata.HierarchyType == HierarchyType.GroupAndElements && entityMetadata.IsGroupPropertyUid != Guid.Empty && (bool)entity.GetPropertyValue(entityMetadata.IsGroupPropertyUid);
			flag = entityMetadata.HierarchyType == HierarchyType.Elements || flag;
		}
		object propertyValue = entity.GetPropertyValue(titlePropertyUid);
		propertyValue = ((propertyValue != null) ? propertyValue.ToString() : string.Empty);
		propertyValue = HttpUtility.HtmlEncode(propertyValue);
		propertyValue = (string.IsNullOrWhiteSpace(propertyValue.ToString()) ? SR.Untitled : propertyValue);
		if (!flag)
		{
			return string.Format("<span id=\"{0}_{1}\" class=\"entityGridItem entityElement\">{2}</span>", inputId.Replace("_", "x"), entity.GetId(), propertyValue);
		}
		return string.Format("<a id=\"{2}_{3}\" class=\"entityGridItem entityFolder\" gridUrl=\"{0}\" parentPage=\"{4}\" isGroup=\"true\">{1}</a>", GenerateViewUrl(uid, inputId, entity.GetId(), showOnlyGroups, false), propertyValue, inputId.Replace("_", "x"), entity.GetId(), parentPage);
	}

	private string GenerateViewUrl(Guid uid, string id, object parentId, bool showOnlyGroups, bool? multiSelect = false)
	{
		return ((Controller)this).get_Url().Action("Explorer", "Entity", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			typeUid = uid,
			inputId = id,
			parentId = parentId,
			showOnlyGroups = showOnlyGroups,
			multiSelect = multiSelect
		});
	}

	public static dynamic CreateEntitySelectRouteValues(EntitySettings settings, ViewAttributes viewAttributes)
	{
		return CreateEntitySelectRouteValues(settings, viewAttributes, localize: false);
	}

	public static dynamic CreateEntitySelectRouteValues(EntitySettings settings, ViewAttributes viewAttributes, bool localize)
	{
		return CreateEntitySelectRouteValues(settings, viewAttributes, localize, null);
	}

	public static dynamic CreateEntitySelectRouteValues(EntitySettings settings, ViewAttributes viewAttributes, bool localize, ClassMetadata metadata)
	{
		string text = ((viewAttributes.EntityFilterProvider != Guid.Empty) ? viewAttributes.EntityFilterProvider.ToString() : null);
		string entityFilterData = viewAttributes.EntityFilterData;
		dynamic val = new ExpandoObject();
		val.area = "EleWise.ELMA.BPM.Web.Common";
		if (!string.IsNullOrEmpty(text))
		{
			val.filterProviderUid = text;
			val.filterProviderData = entityFilterData;
		}
		val.localize = localize;
		EntityController.CreateSortExpressionRouteValue(settings, metadata, val);
		return val;
	}

	private static void CreateSortExpressionRouteValue(EntitySettings settings, ClassMetadata metadata, dynamic routeValues)
	{
		if (metadata == null || !settings.CanSortProperty || !(settings.SortPropertyUid != Guid.Empty))
		{
			return;
		}
		PropertyMetadata propertyMetadata = metadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == settings.SortPropertyUid);
		if (propertyMetadata != null)
		{
			routeValues.sortExpression = PropertyHelper.GetNameSortExpression(propertyMetadata);
			if (settings.SortPropertyOrder == ListSortDirection.Descending)
			{
				routeValues.sortExpression += " DESC";
			}
		}
	}

	public ActionResult EntityTypeSelector(Guid typeUid, string containerId, string inputId, string popupId, string parentHtmlPrefix, string creatorParamsContainer, string openEntityCreator = null, string createEntityCallback = null)
	{
		EntityMetadata metadata = (EntityMetadata)MetadataLoader.LoadMetadata(typeUid);
		EntityTypeSelectorInfo entityTypeSelectorInfo = new EntityTypeSelectorInfo
		{
			Metadata = metadata,
			PopupId = popupId,
			InputId = inputId,
			ContainerId = containerId,
			ParentHtmlPrefix = parentHtmlPrefix,
			OpenEntityCreator = openEntityCreator,
			CreateEntityCallback = createEntityCallback,
			PropertyCollectionOnCallback = ((Controller)this).get_Request().QueryString["PropertyCollectionOnCallback"],
			ViewFormUid = ((Controller)this).get_Request().QueryString["ViewFormUid"],
			UniqueId = ((Controller)this).get_Request().QueryString["UniqueId"]
		};
		if (!string.IsNullOrEmpty(creatorParamsContainer))
		{
			entityTypeSelectorInfo.CreatorParamsContainer = ClassSerializationHelper.DeserializeObjectByJson<ObjectCreatorParamsContainer>(creatorParamsContainer);
		}
		return (ActionResult)(object)((Controller)this).PartialView("Entity/EntityTypeSelector", (object)entityTypeSelectorInfo);
	}

	public ActionResult CreatorForm(Guid typeUid, Guid creatorUid, string containerId, string inputId, string popupId, string previosPopupId, string creatorParams, string createEntityCallback = null)
	{
		Type type = base.IMetadataRuntimeService.GetTypeByUid(typeUid);
		IFormCreator formCreator = FormCreators.FirstOrDefault((IFormCreator c) => c.CheckType(type));
		if (formCreator == null)
		{
			throw new Exception(SR.T("Не найден создатель {0}", type.Name));
		}
		string creatorPrefix = "Bind" + UIExtensions.PrepareId(Guid.NewGuid().ToString());
		EntityCreatorInfo entityCreatorInfo = new EntityCreatorInfo
		{
			Creator = formCreator,
			PopupId = popupId,
			InputId = inputId,
			ContainerId = containerId,
			PreviosPopupId = previosPopupId,
			EntityType = typeUid,
			CreatorPrefix = creatorPrefix,
			Type = type,
			CreateEntityCallback = createEntityCallback,
			PropertyCollectionOnCallback = ((Controller)this).get_Request().QueryString["PropertyCollectionOnCallback"],
			ViewFormUid = ((Controller)this).get_Request().QueryString["ViewFormUid"],
			UniqueId = ((Controller)this).get_Request().QueryString["UniqueId"]
		};
		if (!string.IsNullOrEmpty(creatorParams))
		{
			entityCreatorInfo.CreatorParams = ClassSerializationHelper.DeserializeObjectByJson<ObjectCreatorParams>(creatorParams);
		}
		return (ActionResult)(object)((Controller)this).PartialView("Entity/CreatorForm", (object)entityCreatorInfo);
	}

	[WithoutSpa]
	public ActionResult ObjectNotFound(ObjectNotFoundModel model)
	{
		if (((ControllerBase)this).get_ControllerContext().get_IsChildAction())
		{
			return (ActionResult)(object)((Controller)this).PartialView("Entity/ObjectNotFound", (object)model);
		}
		return (ActionResult)(object)((Controller)this).View("Entity/ObjectNotFound", (object)model);
	}

	[WithoutSpa]
	public ActionResult ObjectIsDeleted(ObjectIsDeletedModel model)
	{
		if (((ControllerBase)this).get_ControllerContext().get_IsChildAction())
		{
			return (ActionResult)(object)((Controller)this).PartialView("Entity/ObjectIsDeleted", (object)model);
		}
		return (ActionResult)(object)((Controller)this).View("Entity/ObjectIsDeleted", (object)model);
	}

	[WithoutSpa]
	public ActionResult AccessDenided(string reason, string url, string routeDataText, Guid typeUid, long entityId, Guid[] permissions)
	{
		AccessDeniedEntityModel accessDeniedEntityModel = new AccessDeniedEntityModel
		{
			RouteDataText = routeDataText,
			Url = url,
			Reason = reason,
			Exception = new EntitySecurityException(reason)
			{
				Url = url,
				EntityId = entityId,
				TypeUid = typeUid,
				Permissions = permissions.ToList()
			}
		};
		if (((ControllerBase)this).get_ControllerContext().get_IsChildAction())
		{
			return (ActionResult)(object)((Controller)this).PartialView("Entity/AccessDenided", (object)accessDeniedEntityModel);
		}
		return (ActionResult)(object)((Controller)this).View("Entity/AccessDenided", (object)accessDeniedEntityModel);
	}

	[WithoutSpa]
	public ActionResult InvalidOperation(InvalidOperationModel model)
	{
		if (((ControllerBase)this).get_ControllerContext().get_IsChildAction())
		{
			return (ActionResult)(object)((Controller)this).PartialView("Entity/InvalidOperation", (object)model);
		}
		return (ActionResult)(object)((Controller)this).View("Entity/InvalidOperation", (object)model);
	}

	[HttpPost]
	public ActionResult UpdateHierarchyChildSelectUrl(Guid uid, string[] providerData)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		IEnumerable<string> selectUrls = providerData.Select((string data) => ((Controller)this).get_Url().Action("SelectHierarchical", "Entity", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			uid = uid,
			filterProviderUid = "{C4820978-7591-4324-BE26-A38E41D09365}",
			filterProviderData = data
		}));
		JsonResult val = new JsonResult();
		val.set_Data((object)new { selectUrls });
		return (ActionResult)val;
	}

	[HttpPost]
	public ActionResult GetEntityCrumb(long? id, Guid typeUid, string functionsId)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		if (!id.HasValue || id == 0)
		{
			JsonResult val = new JsonResult();
			val.set_Data((object)new
			{
				message = ""
			});
			return (ActionResult)val;
		}
		Type typeByUid = base.IMetadataRuntimeService.GetTypeByUid(typeUid);
		EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(typeByUid) as EntityMetadata;
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeByUid, inherit: false);
		PropertyMetadata propertyMetadata = ((entityMetadata != null && entityMetadata.Hierarchical && entityMetadata.ParentPropertyUid != Guid.Empty) ? classMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == entityMetadata.ParentPropertyUid) : null);
		string text = string.Empty;
		if (propertyMetadata != null)
		{
			IEntity entity = (IEntity)EntityHelper.GetEntityManager(typeByUid).LoadOrNull(id);
			if (entity != null)
			{
				IEntity entity2 = entity;
				List<IEntity> list = new List<IEntity>();
				while (entity != null)
				{
					list.Add(entity);
					string text2 = entity.ToString();
					if (string.IsNullOrEmpty(text2))
					{
						text2 = SR.Untitled;
					}
					text = ((entity == entity2) ? $"\\ <span>{entity.ToString()}</span>" : $"\\ <a href='javascript:SelectHierarchicalFolder{functionsId}({entity.GetId()})'>{text2}</a> {text}");
					entity = (IEntity)entity.GetPropertyValue(propertyMetadata.Uid);
					if (list.Contains(entity))
					{
						break;
					}
				}
			}
		}
		JsonResult val2 = new JsonResult();
		val2.set_Data((object)new
		{
			message = text
		});
		return (ActionResult)val2;
	}

	public ActionResult EntityCollectionEditForm(EntityCollectionEditFormModel model)
	{
		Contract.ArgumentNotNull(model, "model");
		Type type = base.IMetadataRuntimeService.GetTypeByUid(model.EntityType);
		IFormCreator formCreator = FormCreators.FirstOrDefault((IFormCreator c) => c.CheckType(type));
		if (formCreator == null)
		{
			throw new Exception(SR.T("Не найден создатель {0}", type.Name));
		}
		model.Type = type;
		model.Creator = formCreator;
		model.CreatorPrefix = "Bind" + UIExtensions.PrepareId(Guid.NewGuid().ToString());
		return (ActionResult)(object)((Controller)this).PartialView("EntityCollection/EditForm", (object)model);
	}

	[HttpPost]
	public ActionResult GetAvailableCreators(Guid typeUid, string inputId, string containerId, string popupId, string parentHtmlPrefix, bool disableSecurity, string serverParamsJson)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		Dictionary<Guid, ObjectCreatorParams> serverParams = ClassSerializationHelper.DeserializeObjectByJson<List<ObjectCreatorParams>>(serverParamsJson).ToDictionary((ObjectCreatorParams k) => k.CreatorGuid, (ObjectCreatorParams v) => v);
		HtmlHelper htmlHelper = GetHtmlHelper();
		ViewDataDictionary viewData = htmlHelper.get_ViewData();
		TemplateInfo val = new TemplateInfo();
		val.set_HtmlFieldPrefix(parentHtmlPrefix);
		viewData.set_TemplateInfo(val);
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeUid);
		ClassMetadata child;
		List<IFormCreator> inheritedCreatorsAndChild = UIExtensions.GetInheritedCreatorsAndChild(classMetadata, disableSecurity, out child);
		if (inheritedCreatorsAndChild.Count > 0)
		{
			if (inheritedCreatorsAndChild.Count == 1)
			{
				IFormCreator formCreator = inheritedCreatorsAndChild.First();
				Guid guid = child?.Uid ?? classMetadata.Uid;
				Type typeByUid = base.IMetadataRuntimeService.GetTypeByUid(guid);
				RouteValueDictionary routeValueDictionary = new RouteValueDictionary
				{
					{ "area", "EleWise.ELMA.BPM.Web.Common" },
					{
						"creatorUid",
						Guid.Empty
					},
					{ "inputId", inputId },
					{ "typeUid", guid },
					{ "containerId", containerId },
					{
						"popupId",
						$"CreateEntityPopup{popupId}"
					}
				};
				ObjectCreatorParams valueOrDefault = serverParams.GetValueOrDefault(formCreator.GetType().GUID, null);
				string text = ((valueOrDefault != null) ? $"data = 'creatorParams={ClassSerializationHelper.SerializeObjectByJson(valueOrDefault)}';" : string.Empty);
				text += formCreator.GetParamsFunc(htmlHelper, htmlHelper.get_ViewData().get_TemplateInfo().get_HtmlFieldPrefix());
				JsonResult val2 = new JsonResult();
				val2.set_Data((object)new
				{
					popupId = popupId,
					popupHeader = formCreator.PopupHeader(typeByUid),
					actionUrl = htmlHelper.Url().Action("CreatorForm", "Entity", routeValueDictionary),
					creatorsCount = inheritedCreatorsAndChild.Count,
					@params = text
				});
				val2.set_JsonRequestBehavior((JsonRequestBehavior)0);
				return (ActionResult)val2;
			}
			RouteValueDictionary routeValueDictionary2 = new RouteValueDictionary
			{
				{ "area", "EleWise.ELMA.BPM.Web.Common" },
				{ "typeUid", classMetadata.Uid },
				{ "inputId", inputId },
				{ "containerId", containerId },
				{
					"popupId",
					$"CreateEntityPopup{popupId}"
				},
				{ "parentHtmlPrefix", parentHtmlPrefix }
			};
			ObjectCreatorParamsContainer creatorParamsContainer = new ObjectCreatorParamsContainer();
			inheritedCreatorsAndChild.ForEach(delegate(IFormCreator o)
			{
				ObjectCreatorParams valueOrDefault2 = serverParams.GetValueOrDefault(o.GetType().GUID, null);
				if (valueOrDefault2 != null)
				{
					creatorParamsContainer.CreatorParams.Add(valueOrDefault2);
				}
			});
			string @params = ((creatorParamsContainer.CreatorParams.Count > 0) ? $"var data = 'creatorParamsContainer={ClassSerializationHelper.SerializeObjectByJson(creatorParamsContainer)}';" : null);
			JsonResult val3 = new JsonResult();
			val3.set_Data((object)new
			{
				popupId = popupId,
				popupHeader = SR.T("Выберите тип объекта"),
				actionUrl = htmlHelper.Url().Action("EntityTypeSelector", "Entity", routeValueDictionary2),
				creatorsCount = inheritedCreatorsAndChild.Count,
				@params = @params
			});
			val3.set_JsonRequestBehavior((JsonRequestBehavior)0);
			return (ActionResult)val3;
		}
		JsonResult val4 = new JsonResult();
		val4.set_Data((object)new
		{
			error = SR.T("Объект не может быть создан.")
		});
		val4.set_JsonRequestBehavior((JsonRequestBehavior)0);
		return (ActionResult)val4;
	}

	public bool CheckAvailableCreators(Guid typeUid, bool disableSecurity)
	{
		ClassMetadata child;
		return UIExtensions.GetInheritedCreatorsAndChild((ClassMetadata)MetadataLoader.LoadMetadata(typeUid), disableSecurity, out child).Count > 0;
	}

	[ChangeOriginalModel]
	[SelfInitialized]
	public ActionResult CustomView(IEntity customEntity, Guid viewFormUid, string uniqueId, bool hideEdit, bool hideDelete)
	{
		EntityFormModel entityFormModel = base.FormViewModelService.GetEntityFormModel(customEntity, viewFormUid);
		entityFormModel.UniqueId = uniqueId;
		entityFormModel.HideEdit = hideEdit;
		entityFormModel.HideDelete = hideDelete;
		return (ActionResult)(object)((Controller)this).PartialView("Templates/EntityViewForm", (object)entityFormModel);
	}

	public ActionResult CreateEntityPopup(Guid typeUid, Guid popupUid, Guid containerUid, string inputId)
	{
		CreateEntityPopupModel createEntityPopupModel = new CreateEntityPopupModel
		{
			EntityTypeUid = typeUid,
			PopupUid = popupUid,
			ContainerUid = containerUid,
			InputId = inputId
		};
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeUid);
		bool orDefault = ContextVars.GetOrDefault<bool>("ExecuteWithoutCreators");
		if (classMetadata != null && !orDefault)
		{
			ClassMetadata child;
			List<IFormCreator> inheritedCreatorsAndChild = UIExtensions.GetInheritedCreatorsAndChild(classMetadata, disableSecurity: false, out child);
			if (inheritedCreatorsAndChild.Count > 0)
			{
				createEntityPopupModel.SelectorForCreator = inheritedCreatorsAndChild.Count > 1;
				createEntityPopupModel.FormCreator = inheritedCreatorsAndChild;
			}
		}
		return (ActionResult)(object)((Controller)this).PartialView("Entity/CreateEntityPopup", (object)createEntityPopupModel);
	}

	public ActionResult SearchEntityPopup(Guid popupUid, string inputName, Guid typeUid, bool showOnlyGroups, string entityFilterProvider, string entityFilterData, int popupWidth, bool multiSelect)
	{
		SearchEntityPopupModel searchEntityPopupModel = new SearchEntityPopupModel
		{
			TypeUid = typeUid,
			PopupUid = popupUid,
			InputName = inputName,
			ShowOnlyGroups = showOnlyGroups,
			EntityFilterData = entityFilterData,
			EntityFilterProvider = entityFilterData,
			PopupWidth = popupWidth,
			MultiSelect = multiSelect
		};
		return (ActionResult)(object)((Controller)this).PartialView("Entity/SearchEntityPopup", (object)searchEntityPopupModel);
	}

	public ActionResult Link(string id, Guid typeUid)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		string text = UrlExtensions.Entity(new UrlHelper(new RequestContext(HttpContextAccessor.CurrentContext, RouteTable.Routes.GetRouteData(HttpContextAccessor.CurrentContext))), typeUid, id);
		if (!string.IsNullOrWhiteSpace(text))
		{
			return (ActionResult)(object)((Controller)this).Redirect(text);
		}
		return (ActionResult)(object)((Controller)this).HttpNotFound();
	}
}
