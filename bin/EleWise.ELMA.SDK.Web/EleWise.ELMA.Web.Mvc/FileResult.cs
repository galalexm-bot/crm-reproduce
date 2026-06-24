using System;
using System.Net.Mime;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc;

public abstract class FileResult : ActionResult
{
	internal static class ContentDispositionUtil
	{
		private const string HexDigits = "0123456789ABCDEF";

		private static void AddByteToStringBuilder(byte b, StringBuilder builder)
		{
			builder.Append('%');
			AddHexDigitToStringBuilder(b >> 4, builder);
			AddHexDigitToStringBuilder((int)b % 16, builder);
		}

		private static void AddHexDigitToStringBuilder(int digit, StringBuilder builder)
		{
			builder.Append("0123456789ABCDEF"[digit]);
		}

		private static string CreateRfc2231HeaderValue(string filename)
		{
			StringBuilder stringBuilder = new StringBuilder("attachment; filename*=UTF-8''");
			byte[] bytes = Encoding.UTF8.GetBytes(filename);
			foreach (byte b in bytes)
			{
				if (IsByteValidHeaderValueCharacter(b))
				{
					stringBuilder.Append((char)b);
				}
				else
				{
					AddByteToStringBuilder(b, stringBuilder);
				}
			}
			return stringBuilder.ToString();
		}

		public static string GetHeaderValue(string fileName)
		{
			for (int i = 0; i < fileName.Length; i++)
			{
				if (fileName[i] > '\u007f')
				{
					return CreateRfc2231HeaderValue(fileName);
				}
			}
			return new ContentDisposition
			{
				FileName = fileName
			}.ToString();
		}

		[Obsolete("Метод устарел и больше не используется", false)]
		public static string GetHeaderValue(string fileName, HttpRequestBase request)
		{
			return GetHeaderValue(fileName);
		}

		private static bool IsByteValidHeaderValueCharacter(byte b)
		{
			if (48 <= b && b <= 57)
			{
				return true;
			}
			if (97 <= b && b <= 122)
			{
				return true;
			}
			if (65 <= b && b <= 90)
			{
				return true;
			}
			switch (b)
			{
			case 33:
			case 36:
			case 38:
			case 43:
			case 45:
			case 46:
			case 58:
			case 95:
			case 126:
				return true;
			default:
				return false;
			}
		}
	}

	private string _fileDownloadName;

	public string ContentType { get; private set; }

	public string FileDownloadName
	{
		get
		{
			return _fileDownloadName ?? string.Empty;
		}
		set
		{
			_fileDownloadName = value;
		}
	}

	protected FileResult(string contentType)
	{
		if (string.IsNullOrEmpty(contentType))
		{
			throw new ArgumentNullException("contentType");
		}
		ContentType = contentType;
	}

	public override void ExecuteResult(ControllerContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		HttpResponseBase response = context.get_HttpContext().Response;
		response.ContentType = ContentType;
		if (!string.IsNullOrEmpty(FileDownloadName))
		{
			string headerValue = ContentDispositionUtil.GetHeaderValue(FileDownloadName);
			context.get_HttpContext().Response.AddHeader("Content-Disposition", headerValue);
		}
		WriteFile(response);
	}

	protected abstract void WriteFile(HttpResponseBase response);
}
