using System.IO;
using System.Web;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Binders;

[ModelBinder(typeof(XhrHttpPostedFileBinder))]
public class XhrPostedFile : HttpPostedFileBase
{
	public const string FILE_HEADER = "X-File-Name";

	private readonly HttpRequestBase _requestBase;

	private readonly string _modelName;

	public override int ContentLength => _requestBase.ContentLength;

	public override string ContentType => _requestBase.ContentType;

	public override string FileName => GetFileName(_requestBase, _modelName);

	public override Stream InputStream => _requestBase.InputStream;

	protected static string GetHeader(HttpRequestBase requestBase)
	{
		string text = requestBase["X-File-Name"];
		if (text == null)
		{
			if (requestBase.Headers == null)
			{
				return null;
			}
			text = requestBase.Headers["X-File-Name"];
		}
		return text;
	}

	protected static string GetFileName(HttpRequestBase requestBase, string modelName)
	{
		string text = requestBase[modelName] ?? ((requestBase.Headers != null) ? requestBase.Headers[modelName] : null);
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		return HttpUtility.UrlDecode(text);
	}

	public static XhrPostedFile Create(HttpRequestBase requestBase, string modelName)
	{
		if (!AjaxRequestExtensions.IsAjaxRequest(requestBase) || GetHeader(requestBase) == null || GetFileName(requestBase, modelName) == null)
		{
			return null;
		}
		return new XhrPostedFile(requestBase, modelName);
	}

	protected XhrPostedFile(HttpRequestBase requestBase, string modelName)
	{
		_requestBase = requestBase;
		_modelName = modelName;
	}

	public override void SaveAs(string filename)
	{
		try
		{
			using FileStream destination = File.Open(filename, FileMode.Create);
			InputStream.CopyTo(destination);
		}
		finally
		{
			InputStream.Seek(0L, SeekOrigin.Begin);
		}
	}
}
