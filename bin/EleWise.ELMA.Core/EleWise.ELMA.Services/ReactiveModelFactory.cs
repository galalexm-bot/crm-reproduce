using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Ioc.Abstract;
using EleWise.ELMA.Model;

namespace EleWise.ELMA.Services;

[Service]
internal sealed class ReactiveModelFactory : IReactiveModelFactory
{
	private readonly ILifetimeScope scope;

	private readonly ILogger logger;

	public ReactiveModelFactory(ILifetimeScope scope, ILogger logger)
	{
		this.scope = scope;
		this.logger = logger;
	}

	public T CreateModel<T>()
	{
		return (T)CreateModel(typeof(T));
	}

	public object CreateModel(System.Type modelType)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (modelType == null)
		{
			throw new ArgumentNullException("modelType");
		}
		if (!modelType.IsInheritOrSame<IReactive>())
		{
			string text = SR.T("Переданный тип {0} не является {1}", modelType.get_Name(), "IReactive");
			logger.Error(text);
			throw new System.Exception(text);
		}
		string text2 = SR.T("Невозможно создать экземпляр интерфейса для типа {0}: {1}", modelType.get_Name(), modelType);
		try
		{
			return ((IScopeContext)scope).Resolve(modelType);
		}
		catch (System.Exception ex)
		{
			logger.Error(text2, ex);
			throw new System.Exception(text2, ex);
		}
	}
}
