using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Ioc.Abstract;

namespace EleWise.ELMA.Services;

[Service]
internal sealed class ControllerFactory : IControllerFactory
{
	private readonly IScopeContext scopeContext;

	private readonly ILogger logger;

	public ControllerFactory(IScopeContext scopeContext, ILogger logger)
	{
		this.scopeContext = scopeContext;
		this.logger = logger;
	}

	public object CreateController(System.Type controllerType)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (controllerType == null)
		{
			throw new ArgumentNullException("controllerType");
		}
		if (!controllerType.IsInheritOrSame<IController>())
		{
			string text = SR.T("Переданный тип {0} не является {1}", controllerType.get_Name(), "IController");
			logger.Error(text);
			throw new System.Exception(text);
		}
		string text2 = SR.T("Невозможно создать экземпляр интерфейса для типа {0}: {1}", controllerType.get_Name(), controllerType);
		try
		{
			if (controllerType.get_IsClass())
			{
				if (scopeContext.get_Registry().GetResolver(controllerType) == null)
				{
					scopeContext.get_Registry().Register(controllerType);
					scopeContext.get_Registry().RegisterAsEnumerableResolver(typeof(IController), controllerType, 0);
				}
				return scopeContext.Resolve(controllerType);
			}
			System.Type type = typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(new System.Type[1] { controllerType });
			System.Collections.IEnumerator enumerator = ((System.Collections.IEnumerable)scopeContext.Resolve(type)).GetEnumerator();
			if (enumerator.MoveNext())
			{
				return enumerator.get_Current();
			}
			logger.Error(text2);
			throw new System.Exception(text2);
		}
		catch (System.Exception ex)
		{
			logger.Error(text2, ex);
			throw new System.Exception(text2, ex);
		}
	}
}
