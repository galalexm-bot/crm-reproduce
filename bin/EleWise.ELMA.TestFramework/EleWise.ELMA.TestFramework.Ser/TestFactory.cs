using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Ioc.Abstract;
using EleWise.ELMA.TestFramework.API;
using EleWise.ELMA.TestFramework.BDD;

namespace EleWise.ELMA.TestFramework.Services;

internal sealed class TestFactory : ITestFactory
{
	private readonly IContainer container;

	private readonly ILogger logger;

	public TestFactory(IContainer container, ILogger logger)
	{
		this.container = container;
		this.logger = logger;
	}

	public T CreateTest<T>()
	{
		return (T)CreateTest(typeof(T));
	}

	public object CreateTest(System.Type type)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (!type.IsInheritOrSame<IBDDTest>())
		{
			string text = SR.T("Переданный тип {0} не является {1}", type.get_Name(), "IBDDTest");
			logger.Error(text);
			throw new System.Exception(text);
		}
		string text2 = SR.T("Невозможно создать экземпляр интерфейса для типа {0}: {1}", type.get_Name(), type);
		try
		{
			object obj = null;
			if (type.get_IsClass())
			{
				obj = ((IScopeContext)container).Resolve(type);
			}
			else
			{
				System.Type type2 = typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(new System.Type[1] { type });
				System.Collections.IEnumerator enumerator = ((System.Collections.IEnumerable)((IScopeContext)container).Resolve(type2)).GetEnumerator();
				if (enumerator.MoveNext())
				{
					obj = enumerator.get_Current();
				}
			}
			if (obj == null)
			{
				logger.Error(text2);
				throw new System.Exception(text2);
			}
			if (obj is IComponentTest componentTest)
			{
				componentTest.TestComponentCreatorService = ((IScopeContext)container).Resolve<ITestComponentCreatorService>();
			}
			return obj;
		}
		catch (System.Exception ex)
		{
			logger.Error(text2, ex);
			throw new System.Exception(text2, ex);
		}
	}
}
