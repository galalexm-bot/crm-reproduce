using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Components;
using EleWise.ELMA.Content.ExtensionPoints;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate.Criterion;

namespace EleWise.ELMA.Content.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class WorkPlaceManager : EntityManager<IWorkPlace, long>
{
	public static readonly Guid DefaultWorkPlaceUid = new Guid("99DCF87C-EE24-4A83-BF47-01A6104A3A9F");

	public static readonly Guid DefaultWorkplacePagesUid = new Guid("CECC132A-9164-4BD0-A7A2-7A870E2C052D");

	public static readonly Guid LiteWorkPlaceUid = new Guid("2CB49778-5EAE-4C6D-B64F-123FA0AF42D6");

	public static readonly Guid MobileWorkPlaceUid = new Guid("958DB7DA-578F-4299-B84B-09C582832DBD");

	private static WorkPlaceManager instance;

	private static string WorkPlaceByUserFormat = "WorkPlaceByUser_{0}";

	private static string WorkPlaceByUserTimestampFormat = "WorkPlaceByUser_timestamp_{0}";

	private static readonly ConcurrentDictionary<Guid, long> ids = new ConcurrentDictionary<Guid, long>();

	private static Dictionary<Guid, IWorkPlaceType> workPlaceTypes;

	private static object workPlaceTypesLocker = new object();

	private const string CustomizerSessionKey = "E02CB7AA-D3D6-4A2C-BCA9-A8EA6202CAB7";

	private static PropertyInfo customizatorIdProperty;

	[NotNull]
	public new static WorkPlaceManager Instance => instance ?? (instance = Locator.GetServiceNotNull<WorkPlaceManager>());

	public IUnionComplexCacheService ComplexCacheService { get; set; }

	internal static long? CustomizatorId
	{
		get
		{
			if (!SessionVars.TryGetValue<object>("E02CB7AA-D3D6-4A2C-BCA9-A8EA6202CAB7", out var value))
			{
				return null;
			}
			if (customizatorIdProperty == null)
			{
				customizatorIdProperty = value.GetType().GetProperty("CustomizatorId");
			}
			if (!(customizatorIdProperty != null))
			{
				return null;
			}
			return customizatorIdProperty.GetValue(value, null) as long?;
		}
	}

	[ContextCache]
	public virtual IWorkPlace GetWorkPlaceByUser(long userId, bool loadDefaultWorkPlace = false)
	{
		long? workPlaceIdByUser = GetWorkPlaceIdByUser(userId);
		if (!workPlaceIdByUser.HasValue)
		{
			if (!loadDefaultWorkPlace)
			{
				return null;
			}
			return Load(DefaultWorkPlaceUid);
		}
		return Load(workPlaceIdByUser.Value);
	}

	internal long? GetWorkPlaceIdByUser(long userId)
	{
		return ComplexCacheService.GetOrAdd(string.Format(WorkPlaceByUserFormat, userId), string.Format(WorkPlaceByUserTimestampFormat, userId), () => CreateCriteria(null, InterfaceActivator.TypeOf<IUser>()).Add((ICriterion)(object)Restrictions.IdEq((object)userId)).CreateAlias("WorkPlace", "wp").Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq("wp.Uid", (object)DefaultWorkPlaceUid)))
			.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property("wp.Id") })
			.UniqueResult<long?>());
	}

	internal void RefreshWorkPlaceByUserCache(IUser user)
	{
		if (user != null)
		{
			ComplexCacheService.RefreshTimestamp(string.Format(WorkPlaceByUserTimestampFormat, user.Id));
		}
	}

	[Transaction]
	public override void Delete(IWorkPlace obj)
	{
		IWorkPlace workPlace = null;
		IColorScheme colorScheme = null;
		foreach (IUserWorkPlace item in EntityManager<IUserWorkPlace>.Instance.Find((IUserWorkPlace u) => u.WorkPlace == obj))
		{
			workPlace = (item.WorkPlace = workPlace ?? Load(DefaultWorkPlaceUid));
			colorScheme = (item.ColorScheme = colorScheme ?? ColorSchemeManager.Instance.GetUserColorScheme(item.WorkPlace, item));
			item.Save();
		}
		base.Delete(obj);
	}

	protected override IWorkPlace LoadByUid(Guid uid)
	{
		if (ids.TryGetValue(uid, out var value))
		{
			return Load(value);
		}
		IWorkPlace workPlace = base.LoadByUid(uid);
		if (workPlace != null)
		{
			ids.TryAdd(uid, workPlace.Id);
		}
		return workPlace;
	}

	private static void CheckWorkPlaceTypes()
	{
		if (workPlaceTypes != null)
		{
			return;
		}
		lock (workPlaceTypesLocker)
		{
			if (workPlaceTypes == null)
			{
				workPlaceTypes = ComponentManager.Current.GetExtensionPoints<IWorkPlaceType>().ToDictionary((IWorkPlaceType type) => type.Uid);
			}
		}
	}

	public IWorkPlaceType GetWorkPlaceType(Guid uid)
	{
		CheckWorkPlaceTypes();
		if (!workPlaceTypes.TryGetValue(uid, out var value))
		{
			return workPlaceTypes[StandardWorkPlaceType.Uid];
		}
		return value;
	}

	public static IEnumerable<IWorkPlaceType> GetWorkPlaceTypes()
	{
		CheckWorkPlaceTypes();
		return workPlaceTypes.Values;
	}
}
