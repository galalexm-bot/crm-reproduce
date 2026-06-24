using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.Caching;
using Orchard.Data;
using Orchard.Localization.Records;

namespace Orchard.Localization.Services;

public class DefaultCultureManager : ICultureManager, IDependency
{
	private readonly IRepository<CultureRecord> _cultureRepository;

	private readonly ISignals _signals;

	private readonly IWorkContextAccessor _workContextAccessor;

	private readonly ICacheManager _cacheManager;

	public DefaultCultureManager(IRepository<CultureRecord> cultureRepository, ISignals signals, IWorkContextAccessor workContextAccessor, ICacheManager cacheManager)
	{
		_cultureRepository = cultureRepository;
		_signals = signals;
		_workContextAccessor = workContextAccessor;
		_cacheManager = cacheManager;
	}

	public IEnumerable<string> ListCultures()
	{
		return _cacheManager.Get("Cultures", preventConcurrentCalls: true, delegate(AcquireContext<string> context)
		{
			context.Monitor(_signals.When("culturesChanged"));
			return _cultureRepository.Table.Select((CultureRecord o) => o.Culture).ToList();
		});
	}

	public void AddCulture(string cultureName)
	{
		if (!IsValidCulture(cultureName))
		{
			throw new ArgumentException("cultureName");
		}
		if (!ListCultures().Any((string culture) => culture == cultureName))
		{
			_cultureRepository.Create(new CultureRecord
			{
				Culture = cultureName
			});
			_signals.Trigger("culturesChanged");
		}
	}

	public void DeleteCulture(string cultureName)
	{
		if (!IsValidCulture(cultureName))
		{
			throw new ArgumentException("cultureName");
		}
		if (ListCultures().Any((string culture) => culture == cultureName))
		{
			CultureRecord entity = _cultureRepository.Get((CultureRecord cr) => cr.Culture == cultureName);
			_cultureRepository.Delete(entity);
			_signals.Trigger("culturesChanged");
		}
	}

	public string GetCurrentCulture(HttpContextBase requestContext)
	{
		return _workContextAccessor.GetContext().CurrentCulture;
	}

	public CultureRecord GetCultureById(int id)
	{
		return _cultureRepository.Get(id);
	}

	public CultureRecord GetCultureByName(string cultureName)
	{
		return _cultureRepository.Get((CultureRecord cr) => cr.Culture == cultureName);
	}

	public string GetSiteCulture()
	{
		if (_workContextAccessor.GetContext().CurrentSite != null)
		{
			return _workContextAccessor.GetContext().CurrentSite.SiteCulture;
		}
		return null;
	}

	public bool IsValidCulture(string cultureName)
	{
		string[] array = cultureName.Split('-');
		if (array.Length == 0)
		{
			return false;
		}
		if (array.Length > 3)
		{
			return false;
		}
		if (array.Any((string s) => s.Length < 2))
		{
			return false;
		}
		return true;
	}
}
