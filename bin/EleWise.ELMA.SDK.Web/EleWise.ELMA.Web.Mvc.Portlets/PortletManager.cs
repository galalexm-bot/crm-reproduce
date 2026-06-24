using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security;
using Autofac;
using Autofac.Core;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Portal;
using EleWise.ELMA.Web.Mvc.Portlets.Layouts;

namespace EleWise.ELMA.Web.Mvc.Portlets;

[Service(Scope = ServiceScope.Transient, InjectProperties = true)]
[DeveloperApi(DeveloperApiType.Service)]
public class PortletManager
{
	private class EmptyPortletsRestrictionProvider : IPortletsRestrictionProvider
	{
		public static EmptyPortletsRestrictionProvider Instance = new EmptyPortletsRestrictionProvider();

		public bool Match(string path)
		{
			throw new NotImplementedException();
		}

		public bool AllowedView(string path)
		{
			return true;
		}

		public bool AllowedAddPortlet(IPortlet portlet, string path)
		{
			return true;
		}

		public bool AllowedAddPortlet(string path)
		{
			return true;
		}

		public bool AllowedPersonalization(string path)
		{
			return true;
		}

		public bool AllowedChangeSharedSettings(string path)
		{
			return true;
		}
	}

	private class PortletSetData
	{
		private readonly string path;

		private readonly PortletPersonalizationCollection portletUserData;

		private readonly PortletPersonalizationCollection portletDataShared;

		public string Path => path;

		public PortletPersonalizationCollection PortletUserData => portletUserData;

		public PortletPersonalizationCollection PortletDataShared => portletDataShared;

		public PortletSetData(string path, PortletPersonalizationCollection portletUserData, PortletPersonalizationCollection portletDataShared)
		{
			this.path = path;
			this.portletUserData = portletUserData;
			this.portletDataShared = portletDataShared;
		}
	}

	private readonly PersonalizationContext personalizationContext;

	private const string StateCollectionKey = "EleWise.ELMA.Web.Mvc.Portlets.PortletManager.PortletPersonalizationCollection";

	public IEnumerable<IPortlet> Portlets { get; set; }

	public IEnumerable<IPortletProvider> PortletProviders { get; set; }

	public IEnumerable<IPortletsRestrictionProvider> PortletsRestrictionProviders { get; set; }

	public IAuthenticationService AuthenticationService { get; set; }

	public ILifetimeScopeAccessor LifetimeScopeAccessor { get; set; }

	public IEnumerable<IPortletLayout> Layouts { get; set; }

	public PersonalizationContext PersonalizationContext => personalizationContext;

	private string CurrentUserName => AuthenticationService.GetCurrentUser()?.UserName;

	public PortletManager()
		: this(new PersonalizationContext(PersonalizationScope.User, null))
	{
	}

	public PortletManager(PersonalizationContext personalizationContext)
	{
		if (personalizationContext == null)
		{
			personalizationContext = new PersonalizationContext(PersonalizationScope.User, null);
		}
		this.personalizationContext = personalizationContext;
		if (PersonalizationAdministration.Provider == null)
		{
			throw new NotInitializedException("Cannot find default Personalization provider");
		}
	}

	public PortletManager Create(PersonalizationScope scope, string path)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_007b: Expected O, but got Unknown
		if (path != null && scope == PersonalizationScope.Shared && !AllowedChangeSharedSettings(path))
		{
			throw new SecurityException(SR.T("Нет прав на shared scope {0}", path));
		}
		Portlets = Portlets.ToList();
		PersonalizationContext personalizationContext = new PersonalizationContext(scope, path);
		return (PortletManager)ResolutionExtensions.ResolveService((IComponentContext)(object)LifetimeScopeAccessor.Current, (Service)new TypedService(typeof(PortletManager)), (Parameter[])(object)new Parameter[1] { (Parameter)new TypedParameter(typeof(PersonalizationContext), (object)personalizationContext) });
	}

	public PortletPersonalization GetPersonalization(Guid portletUid, Guid instanceId, string path, bool addIfNotExists = false, Type portletPersonalisationType = null)
	{
		PortletSetData dataForPath = GetDataForPath(path);
		PortletPersonalization res = GetPersonalizationInternal(dataForPath, portletUid, instanceId, path);
		if (res == null && addIfNotExists)
		{
			return AddPortlet(GetPortlet(portletUid), path, instanceId);
		}
		if (res != null && portletPersonalisationType != null)
		{
			IPortletPersonalizationOldConverterExtensions portletPersonalizationOldConverterExtensions = ComponentManager.Current.GetExtensionPoints<IPortletPersonalizationOldConverterExtensions>().FirstOrDefault((IPortletPersonalizationOldConverterExtensions e) => e.OldSettingsType == res.GetType() && e.NewSettingsType == portletPersonalisationType);
			if (portletPersonalizationOldConverterExtensions != null)
			{
				if (res.GetType() != portletPersonalisationType)
				{
					res = portletPersonalizationOldConverterExtensions.Convert(res) ?? res;
				}
				else
				{
					portletPersonalizationOldConverterExtensions.Update(res);
				}
			}
		}
		return res;
	}

	private PortletPersonalization GetPersonalizationInternal(PortletSetData data, Guid portletUid, Guid instanceId, string path)
	{
		PortletPersonalization portletPersonalization = null;
		if (personalizationContext.CurrentScope == PersonalizationScope.Shared)
		{
			portletPersonalization = data.PortletDataShared.Get(portletUid, instanceId);
			if (portletPersonalization != null)
			{
				portletPersonalization.Shared = true;
			}
		}
		else
		{
			portletPersonalization = data.PortletDataShared.Get(portletUid, instanceId);
			if (portletPersonalization != null)
			{
				portletPersonalization.Shared = true;
				portletPersonalization = ClonePersonalization(portletPersonalization);
				PortletPersonalization source = data.PortletUserData.Get(portletUid, instanceId) ?? portletPersonalization;
				portletPersonalization.SetPersonalizationContext(new PersonalizationContext(PersonalizationScope.User, personalizationContext.Path));
				ApplyPersonalization(portletPersonalization, source, PersonalizationScope.User);
			}
			else
			{
				portletPersonalization = data.PortletUserData.Get(portletUid, instanceId);
				if (portletPersonalization != null)
				{
					portletPersonalization.Shared = false;
				}
			}
		}
		if (portletPersonalization != null)
		{
			portletPersonalization.Path = path;
		}
		return portletPersonalization;
	}

	private void ApplyPersonalization(PortletPersonalization target, PortletPersonalization source, PersonalizationScope personalizationScope)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		Type type = target.GetType();
		IPortletPersonalizationOldConverterExtensions portletPersonalizationOldConverterExtensions = ComponentManager.Current.GetExtensionPoints<IPortletPersonalizationOldConverterExtensions>().FirstOrDefault((IPortletPersonalizationOldConverterExtensions e) => e.OldSettingsType == source.GetType() && e.NewSettingsType == target.GetType());
		if (portletPersonalizationOldConverterExtensions != null)
		{
			if (type != source.GetType())
			{
				source = portletPersonalizationOldConverterExtensions.Convert(source) ?? source;
				if (type != source.GetType())
				{
					throw new InvalidOperationException(SR.T("Не совпадают типы target и source"));
				}
			}
			else
			{
				portletPersonalizationOldConverterExtensions.Update(source);
			}
		}
		foreach (PropertyInfo personalizationProperty in GetPersonalizationProperties(type, personalizationScope))
		{
			personalizationProperty.SetValue(target, personalizationProperty.GetValue(source, new object[0]), new object[0]);
		}
	}

	private List<PropertyInfo> GetPersonalizationProperties(Type type, PersonalizationScope personalizationScope)
	{
		return type.GetProperties().Where(delegate(PropertyInfo p)
		{
			if (!p.CanRead || !p.CanWrite)
			{
				return false;
			}
			PersonalizationScope? personalizationScope2 = PropertyScope(p);
			return personalizationScope2.HasValue && personalizationScope2 == personalizationScope;
		}).ToList();
	}

	private PersonalizationScope? PropertyScope(PropertyInfo p)
	{
		return AttributeHelper<PersonalizationAttribute>.GetAttribute(p, inherited: true)?.Scope;
	}

	private PortletPersonalization GetInstance(Guid instanceId, string path)
	{
		PortletSetData dataForPath = GetDataForPath(path);
		PortletPersonalization obj = dataForPath.PortletUserData.FirstOrDefault((PortletPersonalization d) => d.InstanceId == instanceId) ?? dataForPath.PortletDataShared.FirstOrDefault((PortletPersonalization d) => d.InstanceId == instanceId);
		obj.Path = path;
		return obj;
	}

	private PortletSetData GetDataForPath(string path)
	{
		if (!AllowedView(path))
		{
			throw new SecurityException(SR.T("Нет прав на загрузку данных ({0})", path));
		}
		PortletPersonalizationCollection portletUserData = LoadPersonalizationState("u_" + CurrentUserName, path);
		PortletPersonalizationCollection portletDataShared = LoadPersonalizationState(null, path);
		return new PortletSetData(path, portletUserData, portletDataShared);
	}

	private void SavePersonalizationState(string userName, string path, PortletPersonalizationCollection data)
	{
		if (data == null)
		{
			ContextVars.Remove("EleWise.ELMA.Web.Mvc.Portlets.PortletManager.PortletPersonalizationCollection" + userName + path);
			PersonalizationAdministration.ResetState<PortletPersonalizationStateWrapper[]>(userName, path);
			return;
		}
		ContextVars.Set("EleWise.ELMA.Web.Mvc.Portlets.PortletManager.PortletPersonalizationCollection" + userName + path, data);
		List<PortletPersonalizationStateWrapper> list = new List<PortletPersonalizationStateWrapper>(data.Count);
		foreach (PortletPersonalization datum in data)
		{
			IDictionary<string, string> storageValues = ((IStoreValuesObject)datum).GetStorageValues();
			PortletPersonalizationStateWrapper item = new PortletPersonalizationStateWrapper
			{
				PortletUid = datum.PortletUid,
				Values = storageValues
			};
			list.Add(item);
		}
		PersonalizationAdministration.SaveState(userName, path, list.ToArray());
	}

	private PortletPersonalizationCollection LoadPersonalizationState(string userName, string path)
	{
		return ContextVars.GetOrAdd("EleWise.ELMA.Web.Mvc.Portlets.PortletManager.PortletPersonalizationCollection" + userName + path, () => LoadPersonalizationCollectionNoCache(userName, path));
	}

	private PortletPersonalizationCollection LoadPersonalizationCollectionNoCache(string userName, string path)
	{
		PortletPersonalizationStateWrapper[] array;
		try
		{
			array = PersonalizationAdministration.LoadState<PortletPersonalizationStateWrapper[]>(userName, path);
		}
		catch (TargetInvocationException ex)
		{
			if (!(ex.InnerException is InvalidCastException))
			{
				throw;
			}
			array = null;
		}
		catch (InvalidCastException)
		{
			array = null;
		}
		if (array != null)
		{
			PortletPersonalizationCollection portletPersonalizationCollection = new PortletPersonalizationCollection();
			PortletPersonalizationStateWrapper[] array2 = array;
			foreach (PortletPersonalizationStateWrapper portletPersonalizationStateWrapper in array2)
			{
				IPortlet portlet = GetPortlet(portletPersonalizationStateWrapper.PortletUid);
				if (portlet != null && Activator.CreateInstance(portlet.SettingsType) is PortletPersonalization portletPersonalization)
				{
					((IStoreValuesObject)portletPersonalization).SetStorageValues(portletPersonalizationStateWrapper.Values);
					portletPersonalization.SetPersonalizationContext(personalizationContext);
					portletPersonalizationCollection.Add(portletPersonalization);
				}
			}
			return portletPersonalizationCollection;
		}
		return PersonalizationAdministration.LoadState<PortletPersonalizationCollection>(userName, path) ?? new PortletPersonalizationCollection();
	}

	private void RewriteSharedProperties(PortletPersonalizationCollection userData, PortletPersonalizationCollection sharedData)
	{
		foreach (PortletPersonalization ud in userData)
		{
			PortletPersonalization portletPersonalization = sharedData.FirstOrDefault((PortletPersonalization s) => s.InstanceId == ud.InstanceId);
			if (portletPersonalization == null)
			{
				continue;
			}
			Type type = ud.GetType();
			if (portletPersonalization.GetType() != type)
			{
				continue;
			}
			PropertyInfo[] properties = type.GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				if (PropertyScope(propertyInfo) != PersonalizationScope.Shared)
				{
					continue;
				}
				try
				{
					if (propertyInfo.CanRead && propertyInfo.CanWrite)
					{
						object value = propertyInfo.GetValue(portletPersonalization, null);
						propertyInfo.SetValue(ud, value, null);
					}
				}
				catch (Exception)
				{
				}
			}
		}
	}

	private void SaveAllData(PortletSetData data)
	{
		RewriteSharedProperties(data.PortletUserData, data.PortletDataShared);
		SavePersonalizationState("u_" + CurrentUserName, data.Path, data.PortletUserData);
		SavePersonalizationState(null, data.Path, data.PortletDataShared);
	}

	[Transaction]
	public virtual void SavePersonalization(Guid instanceId, string path, bool? collapse, string zone, int? zoneOrder, bool? closed)
	{
		PortletPersonalization instance = GetInstance(instanceId, path);
		if (instance == null)
		{
			throw new InvalidOperationException(SR.T("Портлет был удален instanceId: {0} path: {1}", instanceId, path));
		}
		instance = ClonePersonalization(instance);
		if (collapse.HasValue)
		{
			instance.Collapsed = collapse.Value;
		}
		if (zone != null)
		{
			instance.Zone = zone;
		}
		if (zoneOrder.HasValue)
		{
			instance.Order = zoneOrder.Value;
		}
		if (closed.HasValue)
		{
			instance.Closed = closed.Value;
		}
		SavePersonalization(instance, path);
	}

	[Transaction]
	public virtual void SavePersonalization(PortalModel model)
	{
		if (model == null || string.IsNullOrEmpty(model.PersonalPath) || model.Zones == null || model.Zones.Count <= 0)
		{
			return;
		}
		foreach (PortalZone zone in model.Zones)
		{
			if (zone == null || zone.Instnaces == null || zone.Instnaces.Count <= 0)
			{
				continue;
			}
			int num = 0;
			foreach (Guid instnace in zone.Instnaces)
			{
				if (GetInstance(instnace, model.PersonalPath) != null)
				{
					SavePersonalization(instnace, model.PersonalPath, null, zone.Name, num, null);
					num++;
				}
			}
		}
	}

	[Transaction]
	public virtual void SavePersonalization(PortletPersonalization portletPersonalization, string path)
	{
		PortletSetData dataForPath = GetDataForPath(path);
		if (GetPortlet(portletPersonalization.PortletUid) == null)
		{
			return;
		}
		PortletPersonalization personalization = GetPersonalization(portletPersonalization.PortletUid, portletPersonalization.InstanceId, path, addIfNotExists: false, portletPersonalization.GetType());
		if (personalizationContext.CurrentScope == PersonalizationScope.Shared)
		{
			ApplyPersonalization(personalization, portletPersonalization, PersonalizationScope.Shared);
			ApplyPersonalization(personalization, portletPersonalization, PersonalizationScope.User);
			SaveInternal(dataForPath, personalization, shared: true);
		}
		else if (personalization.Shared)
		{
			PortletPersonalization portletPersonalization2 = dataForPath.PortletUserData.Get(portletPersonalization.PortletUid, portletPersonalization.InstanceId);
			if (portletPersonalization2 == null)
			{
				portletPersonalization2 = ClonePersonalization(personalization);
				dataForPath.PortletUserData.Add(portletPersonalization2);
			}
			ApplyPersonalization(portletPersonalization2, portletPersonalization, PersonalizationScope.User);
			SaveInternal(dataForPath, portletPersonalization2, shared: false);
		}
		else
		{
			ApplyPersonalization(personalization, portletPersonalization, PersonalizationScope.User);
			ApplyPersonalization(personalization, portletPersonalization, PersonalizationScope.Shared);
			SaveInternal(dataForPath, personalization, shared: false);
		}
		SaveAllData(dataForPath);
	}

	private void SaveInternal(PortletSetData data, PortletPersonalization portletPersonalization, bool shared)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (portletPersonalization == null)
		{
			throw new ArgumentNullException("portletPersonalization");
		}
		PortletPersonalizationCollection portletPersonalizationCollection = (shared ? data.PortletDataShared : data.PortletUserData);
		portletPersonalizationCollection.RemoveAll((PortletPersonalization item) => item.PortletUid == portletPersonalization.PortletUid && item.InstanceId == portletPersonalization.InstanceId);
		if (!portletPersonalization.Closed)
		{
			portletPersonalizationCollection.Add(portletPersonalization);
		}
	}

	[Transaction]
	public virtual void RemovePersonalization(Guid uid, Guid instanceId, string path)
	{
		PortletSetData dataForPath = GetDataForPath(path);
		if (GetPortlet(uid) != null)
		{
			dataForPath.PortletUserData.RemoveAll((PortletPersonalization item) => item.PortletUid == uid && item.InstanceId == instanceId);
			dataForPath.PortletDataShared.RemoveAll((PortletPersonalization item) => item.PortletUid == uid && item.InstanceId == instanceId);
			SaveAllData(dataForPath);
		}
	}

	public IPortlet GetPortlet(Guid portletUid)
	{
		IPortlet portlet = Portlets.FirstOrDefault((IPortlet p) => p.Uid == portletUid);
		if (portlet != null)
		{
			return portlet;
		}
		foreach (IPortletProvider portletProvider in PortletProviders)
		{
			portlet = portletProvider.GetPortlet(portletUid);
			if (portlet != null)
			{
				return portlet;
			}
		}
		return null;
	}

	public IEnumerable<PortletViewModel> GetAllPortlets(string path)
	{
		PortletSetData data = GetDataForPath(path);
		IEnumerable<PortletPersonalization> enumerable = null;
		if (personalizationContext.CurrentScope == PersonalizationScope.Shared)
		{
			enumerable = data.PortletDataShared;
		}
		else
		{
			List<PortletPersonalization> source = data.PortletDataShared.Select((PortletPersonalization p) => GetPersonalizationInternal(data, p.PortletUid, p.InstanceId, path)).ToList();
			List<PortletPersonalization> values = (from p in data.PortletUserData
				where data.PortletDataShared.Get(p.PortletUid, p.InstanceId) == null && !p.Shared
				select GetPersonalizationInternal(data, p.PortletUid, p.InstanceId, path)).ToList();
			enumerable = source.ImmutableAdd(values);
		}
		return (from d in enumerable
			select new
			{
				d = d,
				p = GetPortlet(d.PortletUid)
			} into v
			where v.p != null
			select new PortletViewModel(v.p, v.d, path, personalizationContext.CurrentScope, AllowedProperties(v.d, v.p, path))).ToList();
	}

	public string[] AllowedProperties(PortletPersonalization portletPersonalization, IPortlet portlet, string path)
	{
		return (from p in portletPersonalization.GetType().GetProperties()
			where p.GetCustomAttributes(typeof(PersonalizationAttribute), inherit: true).Length != 0
			where portletPersonalization.PropertyIsShow(p.Name) && portlet.CanChangeProperty(portletPersonalization, p.Name, path) && CanChageProperty(portletPersonalization, p)
			select p.Name).ToArray();
	}

	private bool CanChangeProperty(PortletPersonalization portletPersonalization, string propertyName)
	{
		PropertyInfo property = portletPersonalization.GetType().GetProperty(propertyName);
		return CanChageProperty(portletPersonalization, property);
	}

	private bool CanChageProperty(PortletPersonalization portletPersonalization, PropertyInfo propertyInfo)
	{
		PersonalizationScope? personalizationScope = PropertyScope(propertyInfo);
		if (!personalizationScope.HasValue)
		{
			throw new ArgumentException(SR.T("Свойство {0} не персонализировано", propertyInfo.Name), "propertyName");
		}
		if (personalizationContext.CurrentScope == PersonalizationScope.Shared)
		{
			return true;
		}
		if (personalizationScope == PersonalizationScope.User)
		{
			return true;
		}
		if (!portletPersonalization.Shared)
		{
			return true;
		}
		return false;
	}

	public IEnumerable<IPortlet> AllowedPortlets(string path)
	{
		return (from p in (from portlet in GetAllPortlets()
				where portlet.AllowMultipleInstance || !GetAllPortlets(path).Any((PortletViewModel p) => p.Portlet.Uid == portlet.Uid)
				select portlet).ToList()
			where p.HasPermission() && CanAddPortlet(p, path)
			select p).ToList();
	}

	public IEnumerable<AddPortlet> GetAllAllowedPortlets(string path)
	{
		IEnumerable<IPortlet> allPortlets = GetAllPortlets();
		IEnumerable<PortletViewModel> allPortletsWithPath = GetAllPortlets(path);
		return from portlet in allPortlets
			select portlet.HasPermission() ? new AddPortlet
			{
				Portlet = portlet,
				CanAdd = ((portlet.AllowMultipleInstance || !allPortletsWithPath.Any((PortletViewModel p) => p.Portlet.Uid == portlet.Uid)) && CanAddPortlet(portlet, path))
			} : null into a
			where a != null
			select a;
	}

	public IEnumerable<PortletViewModel> GetClosedPortlets(string path)
	{
		return from portletView in GetAllPortlets(path)
			where portletView.Personalization.Closed
			select portletView;
	}

	public IEnumerable<PortletViewModel> GetCurrentPortlets(IPortletLayout layout, string path)
	{
		List<PortletViewModel> allPortlets = (from m in GetAllPortlets(layout, path)
			where m.Portlet.HasViewPermission(m.Personalization)
			select m).ToList();
		List<PortletViewModel> list = allPortlets.Where((PortletViewModel p) => !p.Portlet.AllowMultipleInstance && !p.Personalization.Shared && allPortlets.Count((PortletViewModel viewModel) => viewModel.Personalization.Shared && viewModel.Portlet.Uid == p.Portlet.Uid) != 0).ToList();
		allPortlets.RemoveAll(list.Contains);
		return allPortlets;
	}

	public IEnumerable<PortletViewModel> GetAllPortlets(IPortletLayout layout, string path)
	{
		List<PortletViewModel> allPortlets = (from portletView in GetAllPortlets(path)
			where !portletView.Personalization.Closed
			select portletView).ToList();
		List<string> portletsZones = allPortlets.Select((PortletViewModel p) => p.Personalization.Zone).Distinct().ToList();
		if (layout.Id == CustomLayout.id)
		{
			var covertLayouts = (from l in Layouts.SelectMany((IPortletLayout l) => l.Zones.Select((ZoneDescriptor z, int i) => new
				{
					zone = z.Id,
					index = i,
					layout = l
				}))
				where portletsZones.Contains(l.zone)
				select l).ToDictionary(l => l.zone);
			if (covertLayouts.Count == 0)
			{
				return allPortlets;
			}
			return allPortlets.Select(delegate(PortletViewModel p)
			{
				if (!covertLayouts.ContainsKey(p.Personalization.Zone))
				{
					return p;
				}
				PortletPersonalization portletPersonalization2 = ClonePersonalization(p.Personalization);
				var anon = covertLayouts[p.Personalization.Zone];
				portletPersonalization2.Zone = "00_" + anon.layout.ConvertToCustomLayout + "_" + anon.index;
				return new PortletViewModel(p.Portlet, portletPersonalization2, p.Path, p.Scope, p.AllowedProperties);
			}).ToArray();
		}
		List<string> layoutZones = layout.Zones.Select((ZoneDescriptor z) => z.Id).ToList();
		if (!layoutZones.Any())
		{
			throw new InvalidOperationException(SR.T("Макет не содержит ни одной зоны"));
		}
		if (portletsZones.SequenceEqual(layoutZones) || portletsZones.IsSubsetOf(layoutZones))
		{
			return allPortlets;
		}
		Dictionary<string, string> covertZones = (from l in Layouts.SelectMany((IPortletLayout l) => l.Zones.Select((ZoneDescriptor z, int i) => new
			{
				zone = z.Id,
				index = i
			}))
			where portletsZones.Contains(l.zone)
			select l).ToDictionary(l => l.zone, l => l.index.ToString());
		string[][][] source = (from z in portletsZones.Select(delegate(string zone)
			{
				int num2 = zone.IndexOf('_');
				int num3 = ((num2 >= 0) ? zone.LastIndexOf('_') : num2);
				return new
				{
					row = ((num2 >= 0) ? zone.Substring(0, num2) : "00"),
					column = ((num3 >= 0) ? zone.Substring(num3 + 1) : (covertZones.ContainsKey(zone) ? covertZones[zone] : "0")),
					zone = zone
				};
			})
			group z by z.column into g
			select (from z in g
				group z by z.row into gg
				select gg.Select(z => z.zone).ToArray()).ToArray()).ToArray();
		int zoneOrder = 0;
		return source.SelectMany(delegate(string[][] zonesCollection, int zoneIdx)
		{
			string layoutZone = layoutZones[Math.Min(zoneIdx, layoutZones.Count - 1)];
			if (zoneIdx < layoutZones.Count - 1)
			{
				zoneOrder = 0;
			}
			return zonesCollection.SelectMany((string[] zones) => (from p in allPortlets
				where zones.Contains(p.Personalization.Zone)
				orderby p.Personalization.Order
				select p).Select(delegate(PortletViewModel p)
			{
				PortletPersonalization portletPersonalization = ClonePersonalization(p.Personalization);
				portletPersonalization.Zone = layoutZone;
				int num = zoneOrder;
				zoneOrder = num + 1;
				portletPersonalization.Order = num;
				return new PortletViewModel(p.Portlet, portletPersonalization, p.Path, p.Scope, p.AllowedProperties);
			}).ToArray());
		}).ToList();
	}

	public virtual PortletPersonalization AddPortlet(IPortlet portlet, string path, Guid? instanceId = null)
	{
		if (!CanAddPortlet(portlet, path))
		{
			throw new SecurityException(SR.T("Нет прав на добавление портлета {0} по пути {1}", portlet.Name, path));
		}
		return AddPortlet(portlet.Uid, () => portlet.CreateDefaultSettings(path), path, instanceId);
	}

	[Transaction]
	public virtual PortletPersonalization AddPortlet(Guid portletUid, Func<PortletPersonalization> createDefaultSettingsFunc, string path, Guid? instanceId = null)
	{
		if (!AllowedAddPortlet(path))
		{
			throw new SecurityException(SR.T("Нет прав на добавление портлетов по пути {0}", path));
		}
		PortletSetData dataForPath = GetDataForPath(path);
		if (instanceId.HasValue && GetPersonalizationInternal(dataForPath, portletUid, instanceId.Value, path) != null)
		{
			throw new InvalidOperationException(string.Concat("Already exists portlet.Uid:", portletUid, " instanceId:", instanceId, " path:", path));
		}
		PortletPersonalization portletPersonalization = createDefaultSettingsFunc();
		portletPersonalization.PortletUid = portletUid;
		portletPersonalization.InstanceId = (instanceId.HasValue ? instanceId.Value : Guid.NewGuid());
		PersonalizationScope personalizationScope = PersonalizationScope.User;
		if (personalizationContext.CurrentScope == PersonalizationScope.Shared)
		{
			personalizationScope = PersonalizationScope.Shared;
			portletPersonalization.Shared = true;
		}
		switch (personalizationScope)
		{
		case PersonalizationScope.User:
			dataForPath.PortletUserData.Add(portletPersonalization);
			break;
		case PersonalizationScope.Shared:
			dataForPath.PortletDataShared.Add(portletPersonalization);
			break;
		}
		portletPersonalization.Path = path;
		SaveAllData(dataForPath);
		return portletPersonalization;
	}

	[Transaction]
	public virtual PortletPersonalization CopyPortletFromPersonalization(IPortlet portlet, string path, PortletPersonalization personalization, Action<PortletPersonalization> action = null)
	{
		if (!AllowedAddPortlet(path))
		{
			throw new SecurityException(SR.T("Нет прав на добавление портлетов по пути {0}", path));
		}
		if (!CanAddPortlet(portlet, path))
		{
			throw new SecurityException(SR.T("Нет прав на добавление портлета {0} по пути {1}", portlet.Name, path));
		}
		PortletPersonalization portletPersonalization = ClonePersonalization(personalization);
		portletPersonalization.NameUrl = null;
		portletPersonalization.InstanceId = Guid.NewGuid();
		PortletSetData dataForPath = GetDataForPath(path);
		switch (portletPersonalization.Shared ? 1 : 0)
		{
		case 0:
			dataForPath.PortletUserData.Add(portletPersonalization);
			break;
		case 1:
			dataForPath.PortletDataShared.Add(portletPersonalization);
			break;
		}
		portletPersonalization.Path = path;
		action?.Invoke(portletPersonalization);
		SaveAllData(dataForPath);
		return portletPersonalization;
	}

	public PortletPersonalization CreateDefaultSettings(IPortlet portlet, string path = null)
	{
		if (portlet == null)
		{
			throw new ArgumentNullException("portlet");
		}
		return CreateDefaultSettings(portlet.Uid, () => portlet.CreateDefaultSettings(path));
	}

	public PortletPersonalization CreateDefaultSettings(Guid portletUid, Func<PortletPersonalization> createDefaultSettingsFunc)
	{
		PortletPersonalization personalization = GetPersonalization(portletUid, portletUid, DefaultSettingsPath(portletUid));
		if (personalization != null)
		{
			return personalization;
		}
		return createDefaultSettingsFunc();
	}

	public string DefaultSettingsPath(IPortlet portlet)
	{
		if (portlet == null)
		{
			throw new ArgumentNullException("portlet");
		}
		return DefaultSettingsPath(portlet.Uid);
	}

	public string DefaultSettingsPath(Guid portletUid)
	{
		return $"default_portlet_settings_page";
	}

	public Guid DefaultSettingsInstanceId(IPortlet portlet)
	{
		if (portlet == null)
		{
			throw new ArgumentNullException("portlet");
		}
		return portlet.Uid;
	}

	private bool EvalRestriction(string path, Func<IPortletsRestrictionProvider, bool> func)
	{
		bool flag = true;
		foreach (IPortletsRestrictionProvider item in PortletsRestrictionProviders.Where((IPortletsRestrictionProvider p) => p.Match(path)))
		{
			flag = flag && func(item);
		}
		return flag;
	}

	public bool CanAddPortlet(IPortlet portlet, string path)
	{
		if (portlet.HasPermission())
		{
			return EvalRestriction(path, (IPortletsRestrictionProvider p) => p.AllowedAddPortlet(portlet, path));
		}
		return false;
	}

	public bool AllowedView(string path)
	{
		return EvalRestriction(path, (IPortletsRestrictionProvider p) => p.AllowedView(path));
	}

	public bool AllowedAddPortlet(string path)
	{
		return EvalRestriction(path, (IPortletsRestrictionProvider p) => p.AllowedAddPortlet(path));
	}

	public bool AllowedPersonalization(string path)
	{
		return EvalRestriction(path, (IPortletsRestrictionProvider p) => p.AllowedPersonalization(path));
	}

	public bool AllowedChangeSharedSettings(string path)
	{
		return EvalRestriction(path, (IPortletsRestrictionProvider p) => p.AllowedChangeSharedSettings(path));
	}

	[Transaction]
	public virtual void ResetPersonalization(string path)
	{
		if (personalizationContext.CurrentScope != 0)
		{
			throw new InvalidOperationException(SR.T("Операция доступна только для режима User"));
		}
		PortletSetData dataForPath = GetDataForPath(path);
		dataForPath.PortletUserData.Clear();
		SaveAllData(dataForPath);
	}

	[Transaction]
	public virtual void ResetSharedSharedPersonalization(string path)
	{
		if (personalizationContext.CurrentScope != PersonalizationScope.Shared)
		{
			throw new InvalidOperationException(SR.T("Операция доступна только для режима Shared"));
		}
		if (!AllowedView(path))
		{
			throw new SecurityException(SR.T("Нет прав на загрузку данных ({0})", path));
		}
		PortletPersonalizationCollection portletPersonalizationCollection = LoadPersonalizationState(null, path);
		portletPersonalizationCollection.Clear();
		SavePersonalizationState(null, path, portletPersonalizationCollection);
	}

	public bool HasSavedData(string path)
	{
		PortletSetData dataForPath = GetDataForPath(path);
		if (dataForPath.PortletUserData.Count <= 0)
		{
			return dataForPath.PortletDataShared.Count > 0;
		}
		return true;
	}

	public bool HasSavedPersonalization(string path)
	{
		if (personalizationContext.CurrentScope == PersonalizationScope.Shared)
		{
			return false;
		}
		return GetDataForPath(path).PortletUserData.Count > 0;
	}

	private static PortletPersonalization ClonePersonalization(PortletPersonalization personalization)
	{
		if (personalization == null)
		{
			return null;
		}
		if (personalization == null)
		{
			return ClassSerializationHelper.CloneObject(personalization);
		}
		PortletPersonalization obj = (PortletPersonalization)Activator.CreateInstance(personalization.GetType());
		((IStoreValuesObject)obj).SetStorageValues(((IStoreValuesObject)personalization).GetStorageValues());
		return obj;
	}

	private IEnumerable<IPortlet> GetAllPortlets()
	{
		List<IPortlet> list = new List<IPortlet>();
		if (Portlets != null)
		{
			list.AddRange(Portlets);
		}
		foreach (IPortletProvider portletProvider in PortletProviders)
		{
			list.AddRange(portletProvider.GetPortlets());
		}
		return list;
	}
}
