using System;
using System.Collections;
using System.Collections.Generic;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.Web.Mvc.Html.FileBrowser.Telerik;

public class ClientSideObjectWriterStub : IClientSideObjectWriter
{
	private object appendedObject;

	public object AppendedObject => appendedObject;

	public IClientSideObjectWriter Start()
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter Append(string keyValuePair)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter Append(string name, string value)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter AppendNullableString(string name, string value)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter Append(string name, int value)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter Append(string name, int value, int defaultValue)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter Append(string name, int? value)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter Append(string name, double value)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter Append(string name, double? value)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter Append(string name, decimal value)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter Append(string name, decimal? value)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter Append(string name, bool value)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter Append(string name, bool value, bool defaultValue)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter AppendDateOnly(string name, DateTime date)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter AppendDateOnly(string name, DateTime? date)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter AppendDatesOnly(string name, IEnumerable<DateTime> dates)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter Append(string name, DateTime value)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter Append(string name, DateTime? value)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter Append(string name, Action action)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter Append(string name, Func<object, object> func)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter Append(string name, HtmlTemplate htmlTemplate)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter AppendCollection(string name, IEnumerable value)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter AppendObject(string name, object value)
	{
		appendedObject = value;
		return (IClientSideObjectWriter)(object)this;
	}

	public IClientSideObjectWriter AppendClientEvent(string name, ClientEvent clientEvent)
	{
		throw new NotImplementedException();
	}

	public IClientSideObjectWriter Append<TEnum>(string name, TEnum value, TEnum defaultValue) where TEnum : IComparable, IFormattable
	{
		throw new NotImplementedException();
	}

	public void Complete()
	{
		throw new NotImplementedException();
	}
}
