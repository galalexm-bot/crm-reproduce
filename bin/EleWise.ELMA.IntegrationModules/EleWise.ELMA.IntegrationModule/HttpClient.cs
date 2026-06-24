using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.IntegrationModules.Models;

public class HttpClient
{
	private const string ContentType = "application/json";

	private readonly Uri uri;

	public Dictionary<string, string> Headers { get; set; }

	public HttpClient()
	{
		Headers = new Dictionary<string, string>();
	}

	public HttpClient(Uri baseUri)
	{
		uri = baseUri;
		Headers = new Dictionary<string, string>();
	}

	public HttpWebResponse Post(string url)
	{
		return Post(url, null, null, null);
	}

	public HttpWebResponse Post(string url, IDictionary<string, string> headers)
	{
		return Post(url, headers, null, null);
	}

	public HttpWebResponse Post(string url, IDictionary<string, string> headers, byte[] data, string contentType)
	{
		Contract.ArgumentNotNull(url, "url");
		HttpWebRequest httpWebRequest = RequestFor(url, headers);
		httpWebRequest.Method = "POST";
		if (contentType != null)
		{
			httpWebRequest.ContentType = contentType;
		}
		if (data != null)
		{
			httpWebRequest.ContentLength = data.Length;
			using Stream stream = httpWebRequest.GetRequestStream();
			stream.Write(data, 0, data.Length);
		}
		else
		{
			httpWebRequest.ContentLength = 0L;
		}
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		if (httpWebResponse.StatusCode != HttpStatusCode.Created && httpWebResponse.StatusCode != HttpStatusCode.OK)
		{
			throw new WebException(SR.T("Ошибка отправки '{0}' в {1}", data, uri));
		}
		return httpWebResponse;
	}

	public HttpWebResponse Get(string url)
	{
		return Get(url, null);
	}

	public HttpWebResponse Get(string url, IDictionary<string, string> headers)
	{
		Contract.ArgumentNotNull(url, "url");
		HttpWebRequest httpWebRequest = RequestFor(url, headers);
		httpWebRequest.Method = "GET";
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		if (httpWebResponse.StatusCode != HttpStatusCode.Created && httpWebResponse.StatusCode != HttpStatusCode.OK)
		{
			throw new WebException(SR.T("Ошибка отправки '{0}'", uri));
		}
		return httpWebResponse;
	}

	private HttpWebRequest RequestFor(string url, IDictionary<string, string> headers)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
		httpWebRequest.ContentType = "application/json";
		if (uri != null && !uri.UserInfo.IsNullOrEmpty())
		{
			httpWebRequest.Headers.Remove(HttpRequestHeader.Authorization);
			httpWebRequest.Headers.Add(HttpRequestHeader.Authorization, "Basic " + uri.UserInfo.ToBase64String(Encoding.ASCII));
		}
		if (headers != null)
		{
			foreach (KeyValuePair<string, string> header in headers)
			{
				httpWebRequest.Headers.Add(header.Key, header.Value);
			}
		}
		foreach (KeyValuePair<string, string> header2 in Headers)
		{
			httpWebRequest.Headers.Add(header2.Key, header2.Value);
		}
		return httpWebRequest;
	}
}
