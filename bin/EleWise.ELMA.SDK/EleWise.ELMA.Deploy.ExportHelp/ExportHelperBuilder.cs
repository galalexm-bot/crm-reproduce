using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Proxy;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.ExportHelper;

public class ExportHelperBuilder
{
	private static ExportHelperBuilder eiEWX3EDoZuwwAZUQajp;

	public static ExportHelperBuilder<T> Create<T>(T exportObject) where T : class
	{
		return new ExportHelperBuilder<T>(exportObject);
	}

	public ExportHelperBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		LnP1KFEDGUl74nILUNqy();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void LnP1KFEDGUl74nILUNqy()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool fAe4cpEDbl1kLk4Z9ylb()
	{
		return eiEWX3EDoZuwwAZUQajp == null;
	}

	internal static ExportHelperBuilder OlyuDDEDheZABoeqEUxq()
	{
		return eiEWX3EDoZuwwAZUQajp;
	}
}
public class ExportHelperBuilder<T> where T : class
{
	private T exportObject;

	private ExportRuleList rules;

	private Dictionary<object, object> exportedObjects;

	private static object tY9Z9EEDEm5tsKpwwJnh;

	public ExportRuleList ExportRuleList
	{
		get
		{
			return rules;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					rules = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public T ExportObject
	{
		get
		{
			return exportObject;
		}
		set
		{
			exportObject = value;
		}
	}

	public Dictionary<object, object> ExportedObjects
	{
		get
		{
			return exportedObjects;
		}
		set
		{
			exportedObjects = value;
		}
	}

	private ExportHelperBuilder<T1> Create<T1>(T1 cloneObject, ExportHelperBuilder<T> helper) where T1 : class
	{
		ExportHelperBuilder<T1> exportHelperBuilder = new ExportHelperBuilder<T1>(cloneObject);
		if (helper != null)
		{
			exportHelperBuilder.ExportRuleList = helper.ExportRuleList;
			exportHelperBuilder.ExportedObjects = helper.ExportedObjects;
		}
		return exportHelperBuilder;
	}

	public ExportHelperBuilder(T exportObject)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		SingletonReader.JJCZtPuTvSt();
		rules = new ExportRuleList();
		exportedObjects = new Dictionary<object, object>();
		base._002Ector();
		this.exportObject = exportObject;
		if (NHibernateProxyHelper.IsProxy((object)exportObject))
		{
			this.exportObject = (T)((INHibernateProxy)exportObject).get_HibernateLazyInitializer().GetImplementation();
		}
	}

	public ExportHelperBuilder<T> ExportRule(Action<ExportRuleBuilder<T>> exportRuleBuilder)
	{
		ExportRuleBuilder<T> obj = new ExportRuleBuilder<T>(rules);
		exportRuleBuilder(obj);
		return this;
	}

	public List<IEntity> EntityExportList(T resObj = null)
	{
		exportedObjects = new Dictionary<object, object>();
		return entityExportList(resObj);
	}

	private List<IEntity> entityExportList(T resObj = null)
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass16_0();
		CS_0024_003C_003E8__locals0.resultList = new List<IEntity>();
		if (exportObject == null || !(exportObject is IEntity))
		{
			return CS_0024_003C_003E8__locals0.resultList;
		}
		CS_0024_003C_003E8__locals0.resultList.Add(exportObject as IEntity);
		Type type = exportObject.GetType();
		if (NHibernateProxyHelper.IsProxy((object)exportObject))
		{
			type = NHibernateUtil.GetClass((object)exportObject);
		}
		if (typeof(EnumBase).IsAssignableFrom(type) || type.IsEnum)
		{
			return CS_0024_003C_003E8__locals0.resultList;
		}
		if (exportedObjects.ContainsKey(exportObject))
		{
			return CS_0024_003C_003E8__locals0.resultList;
		}
		PropertyInfo[] reflectionProperties = type.GetReflectionProperties();
		ExportRuleList exportRuleList = Locator.GetServiceNotNull<IExportRulesService>().BaseMerge(exportObject as IEntity, rules);
		PropertyInfo[] array = reflectionProperties;
		foreach (PropertyInfo propertyInfo in array)
		{
			ExportAction exportAction = (exportRuleList.IsPropertyIgnore(propertyInfo) ? ExportAction.Ignore : (exportRuleList.IsPropertyExport(propertyInfo) ? ExportAction.Export : (exportRuleList.IsPropertyDeepExport(propertyInfo) ? ExportAction.DeepExport : ExportAction.Ignore)));
			if (exportAction != ExportAction.DeepExport)
			{
				continue;
			}
			object obj = propertyInfo.GetValue(exportObject, null);
			if (NHibernateProxyHelper.IsProxy(obj))
			{
				obj = ((INHibernateProxy)obj).get_HibernateLazyInitializer().GetImplementation();
			}
			if (obj != null && obj.GetType().GetInterface(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633498789)) != null)
			{
				if (obj.GetType().GetMethods().FirstOrDefault((MethodInfo f) => f.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487346598)) == null)
				{
					continue;
				}
				foreach (object item in ((IEnumerable)obj).Cast<object>())
				{
					ExportHelperBuilder<object> exportHelperBuilder = ExportHelperBuilder.Create(item);
					exportHelperBuilder.ExportRuleList = ExportRuleList;
					List<IEntity> source = exportHelperBuilder.EntityExportList();
					CS_0024_003C_003E8__locals0.resultList.AddRange(source.Where((IEntity r) => !CS_0024_003C_003E8__locals0.resultList.Contains(r)));
				}
			}
			else
			{
				if (!(obj is IEntity) || CS_0024_003C_003E8__locals0.resultList.Contains(obj as IEntity))
				{
					continue;
				}
				CS_0024_003C_003E8__locals0.resultList.Add(obj as IEntity);
				if (exportAction == ExportAction.DeepExport)
				{
					ExportHelperBuilder<object> exportHelperBuilder2 = ExportHelperBuilder.Create(obj);
					exportHelperBuilder2.ExportRuleList = ExportRuleList;
					List<IEntity> source2 = exportHelperBuilder2.EntityExportList();
					CS_0024_003C_003E8__locals0.resultList.AddRange(source2.Where((IEntity r) => !CS_0024_003C_003E8__locals0.resultList.Contains(r)));
				}
			}
		}
		return CS_0024_003C_003E8__locals0.resultList;
	}

	internal static bool YCXHfhEDfvvKahfj7v17()
	{
		return tY9Z9EEDEm5tsKpwwJnh == null;
	}

	internal static object w5wYiEEDQFJIW9ymIsMC()
	{
		return tY9Z9EEDEm5tsKpwwJnh;
	}
}
