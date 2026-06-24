using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using Bridge;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Types.Storage;

namespace EleWise.ELMA.Scripts;

[Service]
internal sealed class ScriptLoaderService : IScriptLoaderService
{
	private readonly Dictionary<string, Queue<Action>> loadedAssemblies;

	private readonly TypedMap<string, string> assemblies = new TypedMap<string, string>();

	private readonly ILogger logger;

	public ScriptLoaderService(ILogger logger)
	{
		this.logger = logger;
		loadedAssemblies = new Dictionary<string, Queue<Action>>();
	}

	public object LoadModule(string moduleName)
	{
		moduleName = Regex.Replace(moduleName, "[^\\w_\\d]", "_");
		object obj = Script.Write<object>("Bridge.global[{0}]", new object[1] { moduleName });
		if (obj == null)
		{
			try
			{
				return Script.Write<object>("require({0})", new object[1] { moduleName });
			}
			catch
			{
				return null;
			}
		}
		return obj;
	}

	public void ApplyScript(string assemblyName, string sourceCode, Action afterLoadAction)
	{
		try
		{
			if (!string.IsNullOrWhiteSpace(assemblyName))
			{
				if (string.IsNullOrWhiteSpace(sourceCode))
				{
					logger.Info(SR.T("Не удалось загрузить клиентский скрипт {0}: пустой исходный код", assemblyName));
				}
				else
				{
					UnloadScript(assemblyName);
					AfterLoad(assemblyName, afterLoadAction);
				}
			}
		}
		catch
		{
			logger.Error(SR.T("Не удалось загрузить клиентский скрипт {0}", assemblyName));
		}
	}

	public void UnloadAllScripts()
	{
		string[] keys = assemblies.get_Keys();
		foreach (string assemblyName in keys)
		{
			UnloadScript(assemblyName);
		}
		assemblies.Clear();
	}

	private void AfterLoad(string assemblyFullName, Action callback)
	{
		try
		{
			OnLoad(assemblyFullName, callback);
		}
		catch
		{
			logger.Error(SR.T("Не удалось загрузить клиентский скрипт {0}", assemblyFullName));
		}
	}

	private void UnloadScript(string assemblyName)
	{
		assemblies.Delete(assemblyName);
		Script.Write("unloadModule({0});", new object[1] { assemblyName });
	}

	private void OnLoad(string assemblyName, Action callback)
	{
		AfterLoad(assemblyName);
		if (callback != null)
		{
			callback.Invoke();
		}
		ExecuteQueue(assemblyName);
	}

	private void AfterLoad(string assemblyName)
	{
		Assembly.Load(assemblyName);
		assemblies.Set(assemblyName, "");
	}

	private void ExecuteQueue(string assemblyName)
	{
		Queue<Action> val = default(Queue<Action>);
		if (!loadedAssemblies.TryGetValue(assemblyName, ref val))
		{
			return;
		}
		if (val.get_Count() == 0)
		{
			loadedAssemblies.Remove(assemblyName);
			return;
		}
		Action obj = val.Dequeue();
		if (obj != null)
		{
			obj.Invoke();
		}
		ExecuteQueue(assemblyName);
	}
}
