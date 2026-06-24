using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Calendar.Export.Extensions;
using EleWise.ELMA.Calendar.Export.Models;
using EleWise.ELMA.Calendar.Export.Security;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Calendar.Export.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class ExternalCalendarManager : EntityManager<IExternalCalendar, long>
{
	private const double requestCacheTime = 5.0;

	public new static ExternalCalendarManager Instance => Locator.GetServiceNotNull<ExternalCalendarManager>();

	public ICacheService CacheService { get; set; }

	public IEnumerable<IExternalCalendar> FindCalendars(IEnumerable<ISchedule> schedules, bool disableSecurity)
	{
		InstanceOf<IExternalCalendarFilter> instanceOf = new InstanceOf<IExternalCalendarFilter>();
		instanceOf.New.Schedule = (ISet<ISchedule>)(object)new HashedSet<ISchedule>((ICollection<ISchedule>)schedules.ToList());
		instanceOf.New.DisableSecurity = disableSecurity;
		return Find(instanceOf.New, FetchOptions.All);
	}

	private void SetStatus(IExternalCalendar calendar, string status)
	{
		base.SecurityService.RunWithElevatedPrivilegies(delegate
		{
			calendar.UpdateDate = DateTime.Now;
			calendar.Status = status;
			calendar.Save();
		});
	}

	private string GetCalendarCacheKey(IExternalCalendar calendar)
	{
		return $"ExternalCalendar/{calendar.Uid}";
	}

	private string RequestContent(IExternalCalendar calendar)
	{
		WebRequest webRequest;
		try
		{
			webRequest = WebRequest.Create(calendar.Url);
			if (webRequest is HttpWebRequest)
			{
				((HttpWebRequest)webRequest).AllowAutoRedirect = true;
				((HttpWebRequest)webRequest).AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
			}
		}
		catch (UriFormatException)
		{
			throw new Exception(SR.T("Неверный формат Url"));
		}
		catch (ArgumentNullException)
		{
			throw new Exception(SR.T("Url не задан"));
		}
		using WebResponse webResponse = webRequest.GetResponse();
		string text = null;
		if (webResponse is HttpWebResponse)
		{
			text = ((HttpWebResponse)webResponse).CharacterSet;
		}
		StreamReader streamReader = (string.IsNullOrWhiteSpace(text) ? new StreamReader(webResponse.GetResponseStream(), detectEncodingFromByteOrderMarks: true) : new StreamReader(webResponse.GetResponseStream(), Encoding.GetEncoding(text)));
		using (streamReader)
		{
			return streamReader.ReadToEnd();
		}
	}

	public IEnumerable<ExternalCalendarItem> GetCalendarEvents(IExternalCalendar calendar, DateTime startDate, DateTime endDate)
	{
		try
		{
			IExternalCalendarEventConverter externalCalendarEventConverter = ComponentManager.Current.GetExtensionPoints<IExternalCalendarEventConverter>(useCache: true).FirstOrDefault((IExternalCalendarEventConverter p) => p.Uid == calendar.ConverterUid);
			if (externalCalendarEventConverter == null)
			{
				throw new Exception(SR.T("Не найден провайдер преобразования ({0})", calendar.ConverterUid));
			}
			string orAdd = CacheService.GetOrAdd(GetCalendarCacheKey(calendar), delegate
			{
				string result = RequestContent(calendar);
				SetStatus(calendar, null);
				return result;
			}, TimeSpan.FromMinutes(5.0));
			return externalCalendarEventConverter.Deserialize(calendar.Id.ToString(CultureInfo.InvariantCulture), orAdd, startDate, endDate).ToList();
		}
		catch (Exception ex)
		{
			SetStatus(calendar, ex.Message);
		}
		return new List<ExternalCalendarItem>();
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (filter is IExternalCalendarFilter externalCalendarFilter)
		{
			if (externalCalendarFilter.SharedOnly.HasValue || externalCalendarFilter.ScheduleOwner != null)
			{
				criteria.CreateAlias("Schedule", "sch");
			}
			if (externalCalendarFilter.SharedOnly.HasValue)
			{
				criteria.Add((ICriterion)(object)Restrictions.IsNull("sch.Owner"));
			}
			if (externalCalendarFilter.ScheduleOwner != null)
			{
				criteria.Add((ICriterion)(object)Restrictions.Eq("sch.Owner.Id", (object)externalCalendarFilter.ScheduleOwner.Id));
			}
		}
	}

	public override void Delete(IExternalCalendar obj)
	{
		if (!base.SecurityService.HasPermission(ExternalCalendarPermissionProvider.EditCalendarPermission, obj))
		{
			throw new SecurityException();
		}
		base.Delete(obj);
	}

	public override void Save(IExternalCalendar obj)
	{
		if (!base.SecurityService.HasPermission(ExternalCalendarPermissionProvider.EditCalendarPermission, obj))
		{
			throw new SecurityException();
		}
		base.Save(obj);
	}
}
