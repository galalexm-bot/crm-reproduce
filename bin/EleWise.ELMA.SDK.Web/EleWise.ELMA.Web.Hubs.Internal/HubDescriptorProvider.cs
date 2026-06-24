using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Logging;
using Microsoft.AspNet.SignalR.Hubs;

namespace EleWise.ELMA.Web.Hubs.Internal;

internal sealed class HubDescriptorProvider : IHubDescriptorProvider
{
	private readonly Lazy<IDictionary<string, HubDescriptor>> hubs;

	public HubDescriptorProvider()
	{
		hubs = new Lazy<IDictionary<string, HubDescriptor>>(BuildHubsCache);
	}

	public IList<HubDescriptor> GetHubs()
	{
		return hubs.Value.Select((KeyValuePair<string, HubDescriptor> hub) => hub.Value).Distinct().ToList();
	}

	public bool TryGetHub(string hubName, out HubDescriptor descriptor)
	{
		return hubs.Value.TryGetValue(hubName, out descriptor);
	}

	private IDictionary<string, HubDescriptor> BuildHubsCache()
	{
		HubDescriptor[] array = ((IEnumerable<Type>)(from type in (from assembly in AppDomain.CurrentDomain.GetAssemblies()
				where assembly.GetName().Name == "EleWise.ELMA.SignalRHubs"
				select assembly).SelectMany(delegate(Assembly assembly)
			{
				try
				{
					return assembly.GetTypes();
				}
				catch (ReflectionTypeLoadException ex)
				{
					string text = string.Join("\n\r", ex.LoaderExceptions.Select((Exception e) => e.ToString()).ToArray());
					string message = "Error at load types from assembly " + assembly.FullName + " " + text;
					Logger.Log.Error(message, ex);
					throw;
				}
			})
			where TypeOf<IHub>.Raw.IsAssignableFrom(type) && !type.IsAbstract
			select type).ToArray()).Select((Func<Type, HubDescriptor>)delegate(Type type)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			HubDescriptor val2 = new HubDescriptor();
			((Descriptor)val2).set_NameSpecified(GetHubAttributeName(type) != null);
			((Descriptor)val2).set_Name(GetHubName(type));
			val2.set_HubType(type);
			return val2;
		}).ToArray();
		Dictionary<string, HubDescriptor> dictionary = new Dictionary<string, HubDescriptor>(StringComparer.OrdinalIgnoreCase);
		HubDescriptor[] array2 = array;
		foreach (HubDescriptor val in array2)
		{
			if (!dictionary.TryGetValue(((Descriptor)val).get_Name(), out var value))
			{
				dictionary[((Descriptor)val).get_Name()] = val;
				continue;
			}
			throw new InvalidOperationException(SR.T("Дублирующееся название хаба SignalR: '{0}'", ((Descriptor)value).get_Name()));
		}
		return dictionary;
	}

	private string GetHubAttributeName(Type hubType)
	{
		HubNameAttribute customAttribute = ((MemberInfo)hubType).GetCustomAttribute<HubNameAttribute>(inherit: false);
		if (customAttribute == null)
		{
			return null;
		}
		return customAttribute.get_HubName();
	}

	private string GetHubTypeName(Type hubType)
	{
		int num = hubType.Name.LastIndexOf('`');
		if (num != -1)
		{
			return hubType.Name.Substring(0, num);
		}
		return hubType.Name;
	}

	private string GetHubName(Type hubType)
	{
		return GetHubAttributeName(hubType) ?? GetHubTypeName(hubType);
	}
}
