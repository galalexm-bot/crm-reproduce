using System;
using System.ComponentModel.Composition;
using System.Threading;
using EleWise.ELMA.Packaging.Components.Web.Settings;
using EleWise.ELMA.Packaging.Logging;
using Microsoft.Web.Administration;

namespace EleWise.ELMA.Packaging.Components.Web;

[Export(typeof(IISManager))]
public class IISManager
{
	private ILogger _logger;

	[Import]
	public ILogger Logger
	{
		get
		{
			return _logger.GetPropertyNotNull("Logger");
		}
		set
		{
			_logger = value;
		}
	}

	public void ChangePhysicalPath(string webSitePath, IISHostingSettings settings)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		try
		{
			ServerManager serverManager = new ServerManager();
			Site site = serverManager.Sites[settings.SiteName];
			if (site == null)
			{
				site = serverManager.Sites.Add(settings.SiteName, webSitePath, settings.Port);
			}
			if (!site.Applications[0].VirtualDirectories[0].PhysicalPath.Equals(webSitePath, StringComparison.CurrentCultureIgnoreCase))
			{
				Logger.Debug(SR.T("Изменение физического пути сайта '{0}' в IIS...", settings.SiteName));
				bool num = IsStarted(settings);
				if (num)
				{
					Stop(settings);
				}
				site.Applications[0].VirtualDirectories[0].PhysicalPath = webSitePath;
				serverManager.CommitChanges();
				if (num)
				{
					Start(settings);
				}
			}
		}
		catch (Exception ex)
		{
			throw new InvalidOperationException(SR.T("Не удалось изменить физический путь сайта '{0}' в IIS.", settings.SiteName) + GetAdditionalExceptionText(ex), ex);
		}
	}

	public string GetPhysicalPath(IISHostingSettings settings)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		try
		{
			return new ServerManager().Sites[settings.SiteName]?.Applications[0].VirtualDirectories[0].PhysicalPath;
		}
		catch (Exception ex)
		{
			throw new InvalidOperationException(SR.T("Не удалось получить физический путь сайта '{0}' в IIS.", settings.SiteName) + GetAdditionalExceptionText(ex), ex);
		}
	}

	public void Install(string webSitePath, IISHostingSettings settings)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		try
		{
			Logger.Info(SR.T("Установка сайта '{0}' в IIS...", settings.SiteName));
			ServerManager serverManager = new ServerManager();
			Site site = serverManager.Sites[settings.SiteName];
			if (site == null)
			{
				site = serverManager.Sites.Add(settings.SiteName, webSitePath, settings.Port);
			}
			site.Applications[0].VirtualDirectories[0].PhysicalPath = webSitePath;
			ApplicationPool applicationPool = serverManager.ApplicationPools[settings.PoolName];
			if (applicationPool == null)
			{
				applicationPool = serverManager.ApplicationPools.Add(settings.PoolName);
				switch (settings.AuthenticationType)
				{
				case IISAuthenticationType.LocalSystem:
					applicationPool.ProcessModel.IdentityType = ProcessModelIdentityType.LocalSystem;
					break;
				case IISAuthenticationType.LocalService:
					applicationPool.ProcessModel.IdentityType = ProcessModelIdentityType.LocalService;
					break;
				case IISAuthenticationType.NetworkService:
					applicationPool.ProcessModel.IdentityType = ProcessModelIdentityType.NetworkService;
					break;
				case IISAuthenticationType.ApplicationPoolIdentity:
					applicationPool.ProcessModel.IdentityType = ProcessModelIdentityType.ApplicationPoolIdentity;
					break;
				case IISAuthenticationType.User:
					applicationPool.ProcessModel.IdentityType = ProcessModelIdentityType.SpecificUser;
					applicationPool.ProcessModel.UserName = settings.UserName;
					applicationPool.ProcessModel.Password = settings.Password;
					break;
				}
				applicationPool.AutoStart = true;
				applicationPool.ProcessModel.IdleTimeout = TimeSpan.Zero;
				applicationPool.Recycling.PeriodicRestart.Time = TimeSpan.Zero;
			}
			SetPoolMandatoryValues(applicationPool);
			site.Applications[0].ApplicationPoolName = settings.PoolName;
			serverManager.CommitChanges();
			Logger.Info(SR.T("Сайт '{0}' установлен.", settings.SiteName));
		}
		catch (Exception ex)
		{
			throw new InvalidOperationException(SR.T("Не удалось установить сайт '{0}' в IIS.", settings.SiteName) + GetAdditionalExceptionText(ex), ex);
		}
	}

	public void Update(IISHostingSettings settings)
	{
		ServerManager serverManager = new ServerManager();
		ApplicationPool applicationPool = serverManager.ApplicationPools[settings.PoolName];
		if (applicationPool != null)
		{
			SetPoolMandatoryValues(applicationPool);
			serverManager.CommitChanges();
		}
	}

	private static void SetPoolMandatoryValues(ApplicationPool pool)
	{
		pool.ManagedRuntimeVersion = "v4.0";
		pool.Recycling.DisallowOverlappingRotation = true;
	}

	public void Uninstall(IISHostingSettings settings)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		try
		{
			Logger.Info(SR.T("Удаление сайта '{0}' в IIS...", settings.SiteName));
			ServerManager serverManager = new ServerManager();
			Site site = serverManager.Sites[settings.SiteName];
			if (site != null)
			{
				serverManager.Sites.Remove(site);
			}
			ApplicationPool applicationPool = serverManager.ApplicationPools[settings.PoolName];
			if (applicationPool != null)
			{
				serverManager.ApplicationPools.Remove(applicationPool);
			}
			serverManager.CommitChanges();
			Logger.Info(SR.T("Сайт '{0}' удален.", settings.SiteName));
		}
		catch (Exception ex)
		{
			throw new InvalidOperationException(SR.T("Не удалось удалить сайт '{0}' из IIS.", settings.SiteName) + GetAdditionalExceptionText(ex), ex);
		}
	}

	public bool IsStarted(IISHostingSettings settings)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		try
		{
			ServerManager serverManager = new ServerManager();
			ApplicationPool applicationPool = serverManager.ApplicationPools[settings.PoolName];
			if (applicationPool == null || (applicationPool.State != ObjectState.Started && applicationPool.State != 0))
			{
				return false;
			}
			Site site = serverManager.Sites[settings.SiteName];
			if (site == null || (site.State != ObjectState.Started && site.State != 0))
			{
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			throw new InvalidOperationException(SR.T("Не удалось проверить статус запуска сайта '{0}' в IIS.", settings.SiteName) + GetAdditionalExceptionText(ex), ex);
		}
	}

	public void Start(IISHostingSettings settings)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		try
		{
			Logger.Info(SR.T("Запуск сайта '{0}' в IIS...", settings.SiteName));
			ServerManager serverManager = new ServerManager();
			ApplicationPool applicationPool = serverManager.ApplicationPools[settings.PoolName];
			if (applicationPool != null && applicationPool.State == ObjectState.Stopped)
			{
				applicationPool.Start();
				DateTime now = DateTime.Now;
				while (applicationPool.State == ObjectState.Starting && DateTime.Now - now < TimeSpan.FromMinutes(5.0))
				{
					Thread.Sleep(1000);
				}
			}
			Site site = serverManager.Sites[settings.SiteName];
			if (site != null && site.State == ObjectState.Stopped)
			{
				site.Start();
				DateTime now2 = DateTime.Now;
				while (site.State == ObjectState.Starting && DateTime.Now - now2 < TimeSpan.FromMinutes(5.0))
				{
					Thread.Sleep(1000);
				}
			}
			Logger.Info(SR.T("Сайт '{0}' запущен.", settings.SiteName));
		}
		catch (Exception ex)
		{
			throw new InvalidOperationException(SR.T("Не удалось запустить сайт '{0}' в IIS.", settings.SiteName) + GetAdditionalExceptionText(ex), ex);
		}
	}

	public void Stop(IISHostingSettings settings)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		try
		{
			Logger.Info(SR.T("Остановка сайта '{0}' в IIS...", settings.SiteName));
			ServerManager serverManager = new ServerManager();
			Site site = serverManager.Sites[settings.SiteName];
			if (site != null && site.State == ObjectState.Started)
			{
				site.Stop();
				DateTime now = DateTime.Now;
				while (site.State == ObjectState.Stopping && DateTime.Now - now < TimeSpan.FromMinutes(5.0))
				{
					Thread.Sleep(1000);
				}
			}
			ApplicationPool applicationPool = serverManager.ApplicationPools[settings.PoolName];
			if (applicationPool != null && applicationPool.State == ObjectState.Started)
			{
				applicationPool.Stop();
				DateTime now2 = DateTime.Now;
				while (applicationPool.State == ObjectState.Stopping && DateTime.Now - now2 < TimeSpan.FromMinutes(5.0))
				{
					Thread.Sleep(1000);
				}
			}
			Logger.Info(SR.T("Сайт '{0}' остановлен.", settings.SiteName));
		}
		catch (Exception ex)
		{
			throw new InvalidOperationException(SR.T("Не удалось остановить сайт '{0}' в IIS.", settings.SiteName) + GetAdditionalExceptionText(ex), ex);
		}
	}

	private string GetAdditionalExceptionText(Exception ex)
	{
		if (!(ex is UnauthorizedAccessException ex2))
		{
			return "";
		}
		return " " + SR.T("Скорее всего, у пользователя, под которым запущен пул приложений IIS, отсутсвуют необходимые привилегии. Оригинальный текст ошибки: {0}", ex2.Message);
	}
}
