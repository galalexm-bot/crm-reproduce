using System;
using System.Collections.Generic;
using System.ServiceModel.Web;
using EleWise.ELMA.Common.Models.API;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Serialization;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Common.Models;

internal static class WebDataFactory
{
	public static WebData Create(IDictionary<string, object> dicObj)
	{
		if (WebOperationContext.Current != null)
		{
			string text = WebOperationContext.Current.IncomingRequest.Headers.Get(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921415677));
			if (!string.IsNullOrWhiteSpace(text) && string.Equals(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822639874), StringComparison.InvariantCultureIgnoreCase))
			{
				return new EleWise.ELMA.Common.Models.API.WebData(dicObj);
			}
		}
		return new WebData(dicObj);
	}

	[Obsolete("Метод устарел", true)]
	public static WebData CreateFromEntity(IEntity entity, Func<PropertyMetadata, bool> propertyFilter, Func<TablePartMetadata, bool> tablePartFilter)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.tablePartFilter = tablePartFilter;
		return CreateFromEntity(entity, propertyFilter, (ITablePartMetadata m) => CS_0024_003C_003E8__locals0.tablePartFilter((TablePartMetadata)m));
	}

	[Obsolete("Метод устарел", true)]
	public static WebData CreateFromEntity(IEntity entity, EntitySerializationSettings settings, Func<PropertyMetadata, bool> propertyFilter, Func<TablePartMetadata, bool> tablePartFilter)
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals0.tablePartFilter = tablePartFilter;
		return CreateFromEntity(entity, settings, propertyFilter, (ITablePartMetadata m) => CS_0024_003C_003E8__locals0.tablePartFilter((TablePartMetadata)m));
	}

	public static WebData CreateFromEntity(IEntity entity, Func<PropertyMetadata, bool> propertyFilter = null, Func<ITablePartMetadata, bool> tablePartFilter = null)
	{
		IDictionary<string, object> dictionary = WebData.DictionaryFromEntity(entity, propertyFilter, tablePartFilter);
		if (dictionary == null)
		{
			return null;
		}
		return Create(dictionary);
	}

	public static WebData CreateFromEntity(IEntity entity, EntitySerializationSettings settings, Func<PropertyMetadata, bool> propertyFilter = null, Func<ITablePartMetadata, bool> tablePartFilter = null)
	{
		IDictionary<string, object> dictionary = WebData.DictionaryFromEntity(entity, settings, propertyFilter, tablePartFilter);
		if (dictionary == null)
		{
			return null;
		}
		return Create(dictionary);
	}
}
