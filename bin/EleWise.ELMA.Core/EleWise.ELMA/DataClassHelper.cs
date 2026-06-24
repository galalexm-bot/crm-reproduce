using System;
using System.Collections.Generic;
using Bridge;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA;

public static class DataClassHelper
{
	public static T Clone<T>(this T obj) where T : class
	{
		return ObjectExtensions.Cast<T>(obj.Clone(null));
	}

	internal static object Clone(this object obj, ClassMetadata classMetadata = null)
	{
		if (obj == null)
		{
			return null;
		}
		ICloneable val;
		if ((val = (ICloneable)((obj is ICloneable) ? obj : null)) != null)
		{
			return val.Clone();
		}
		if (obj.GetPlainPropertyValue("$jsonObj") == null)
		{
			new object();
		}
		object json = Script.Write<object>("JSON.parse(JSON.stringify(json))", new object[0]);
		string plainPropertyValue = obj.GetPlainPropertyValue<string>("$$name");
		ReactiveProxy reactiveProxy = ObjectExtensions.As<ReactiveProxy>(obj);
		if (plainPropertyValue == "EleWise.ELMA.DTO.ReactiveProxy")
		{
			classMetadata = reactiveProxy.Metadata;
		}
		ReactiveProxy reactiveProxy2 = InternalClone(json, reactiveProxy.proxyService, classMetadata);
		reactiveProxy2.Actions = (IDictionary<string, object>)(object)new Dictionary<string, object>(reactiveProxy.Actions);
		return reactiveProxy2;
	}

	private static ReactiveProxy InternalClone(object json, IProxyGeneratorService proxyGeneratorService, ClassMetadata classMetadata)
	{
		ReactiveProxy reactiveProxy = proxyGeneratorService.GenerateProxy(classMetadata);
		reactiveProxy.SetAndCreatePlainPropertyValue("$jsonObj", json);
		return reactiveProxy;
	}
}
