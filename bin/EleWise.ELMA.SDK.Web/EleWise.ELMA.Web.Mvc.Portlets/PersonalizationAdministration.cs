using System;
using System.Configuration;
using System.Web.Configuration;

namespace EleWise.ELMA.Web.Mvc.Portlets;

public static class PersonalizationAdministration
{
	private static readonly object InitializationLock;

	private static bool initialized;

	private static PersonalizationProvider provider;

	private static PersonaliationProviderCollection providers;

	public static string ApplicationName
	{
		get
		{
			return Provider.ApplicationName;
		}
		set
		{
			Provider.ApplicationName = value;
		}
	}

	public static PersonalizationProvider Provider
	{
		get
		{
			Initialize();
			return provider;
		}
	}

	public static PersonaliationProviderCollection Providers
	{
		get
		{
			Initialize();
			return providers;
		}
	}

	static PersonalizationAdministration()
	{
		InitializationLock = new object();
		initialized = false;
	}

	private static void Initialize()
	{
		if (initialized)
		{
			return;
		}
		lock (InitializationLock)
		{
			if (!initialized)
			{
				PersonalizationConfigurationSection personalizationConfigurationSection = (PersonalizationConfigurationSection)ConfigurationManager.GetSection("personalization");
				if (personalizationConfigurationSection == null)
				{
					throw new Exception("Personalization is not configured for this application");
				}
				providers = new PersonaliationProviderCollection();
				ProvidersHelper.InstantiateProviders(personalizationConfigurationSection.Providers, providers, typeof(PersonalizationProvider));
				provider = providers[personalizationConfigurationSection.DefaultProvider];
				if (provider == null)
				{
					throw new ConfigurationErrorsException("Personalization provider must be set in configuration");
				}
				initialized = true;
			}
		}
	}

	private static void SaveStatePrivate<T>(string userName, string path, T state)
	{
		Initialize();
		provider.SaveState(userName, path, state);
	}

	private static T LoadStatePrivate<T>(string userName, string path)
	{
		Initialize();
		return provider.LoadState<T>(userName, path);
	}

	private static void ResetStatePrivate<T>(string userName, string path)
	{
		Initialize();
		provider.ResetState<T>(userName, path);
	}

	public static void SaveState<T>(string userName, string path, T state)
	{
		SaveStatePrivate(userName, path, state);
	}

	public static T LoadState<T>(string userName, string path)
	{
		return LoadStatePrivate<T>(userName, path);
	}

	public static void ResetState<T>(string userName, string path)
	{
		ResetStatePrivate<T>(userName, path);
	}
}
