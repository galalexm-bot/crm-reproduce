using System;
using System.Collections.Generic;
using EleWise.ELMA.CAB.Properties;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB.Commands;

public class CommandAdapterMapService : ICommandAdapterMapService
{
	private readonly Dictionary<Type, Type> map = new Dictionary<Type, Type>();

	public void Register(Type invokerType, Type adapterType)
	{
		Guard.ArgumentNotNull(invokerType, "invokerType");
		Guard.ArgumentNotNull(adapterType, "adapterType");
		if (!typeof(CommandAdapter).IsAssignableFrom(adapterType))
		{
			throw new AdapterMapServiceException(Resources.InvalidAdapter);
		}
		map[invokerType] = adapterType;
	}

	public CommandAdapter CreateAdapter(Type invokerType)
	{
		Guard.ArgumentNotNull(invokerType, "invokerType");
		CommandAdapter commandAdapter = null;
		if (map.ContainsKey(invokerType))
		{
			return (CommandAdapter)Activator.CreateInstance(map[invokerType]);
		}
		return FindAssignableAdapter(invokerType);
	}

	public void UnRegister(Type invokerType)
	{
		map.Remove(invokerType);
	}

	private CommandAdapter FindAssignableAdapter(Type type)
	{
		CommandAdapter result = null;
		foreach (KeyValuePair<Type, Type> item in map)
		{
			if (item.Key.IsAssignableFrom(type))
			{
				result = (CommandAdapter)Activator.CreateInstance(item.Value);
				break;
			}
		}
		return result;
	}
}
