using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using EleWise.ELMA.Memory;

namespace EleWise.ELMA.BPM.Web.Content;

public class TinyMCE_GZip_Handler : IHttpHandler
{
	private HttpResponse Response;

	private HttpRequest Request;

	private HttpServerUtility Server;

	public bool IsReusable => false;

	public void ProcessRequest(HttpContext context)
	{
		Response = context.Response;
		Request = context.Request;
		Server = context.Server;
		StreamGzipContents();
	}

	private void StreamGzipContents()
	{
		string text = "";
		string text2 = "";
		string text3 = "";
		Encoding encoding = Encoding.GetEncoding("windows-1252");
		string[] array = GetParam("plugins", "").Split(',');
		string[] array2 = GetParam("languages", "").Split(',');
		string[] array3 = GetParam("themes", "").Split(',');
		bool flag = GetParam("diskcache", "") == "true";
		bool flag2 = GetParam("js", "") == "true";
		bool flag3 = GetParam("compress", "true") == "true";
		bool flag4 = GetParam("core", "true") == "true";
		string text4 = ((GetParam("suffix", "") == "_src") ? "_src" : "");
		string text5 = Server.MapPath(".");
		int num = 10;
		string[] array4 = new string[0];
		Response.ContentType = "text/javascript";
		Response.Charset = "UTF-8";
		Response.Buffer = false;
		Response.Cache.SetExpires(DateTime.Now.AddDays(num));
		Response.Cache.SetCacheability(HttpCacheability.Public);
		Response.Cache.SetValidUntilExpires(validUntilExpires: false);
		Response.Cache.VaryByHeaders["Accept-Encoding"] = true;
		Response.Cache.VaryByParams["theme"] = true;
		Response.Cache.VaryByParams["language"] = true;
		Response.Cache.VaryByParams["plugins"] = true;
		Response.Cache.VaryByParams["lang"] = true;
		Response.Cache.VaryByParams["index"] = true;
		if (!flag2)
		{
			Response.WriteFile(Server.MapPath("tiny_mce_gzip.js"));
			Response.Write("tinyMCE_GZ.init({});");
			return;
		}
		if (flag)
		{
			text = GetParam("plugins", "") + GetParam("languages", "") + GetParam("themes", "");
			for (int i = 0; i < array4.Length; i++)
			{
				text += array4[i];
			}
			text = MD5(text);
			text2 = ((!flag3) ? (text5 + "/tiny_mce_" + text + ".js") : (text5 + "/tiny_mce_" + text + ".gz"));
		}
		string text6 = Regex.Replace(Request.Headers["Accept-Encoding"] ?? "", "\\s+", "").ToLower();
		bool flag5 = text6.IndexOf("gzip") != -1 || Request.Headers["---------------"] != null;
		text6 = ((text6.IndexOf("x-gzip") != -1) ? "x-gzip" : "gzip");
		if (flag && flag5 && File.Exists(text2))
		{
			Response.AppendHeader("Content-Encoding", text6);
			Response.WriteFile(text2);
			return;
		}
		if (flag4)
		{
			text3 += GetFileContents("tiny_mce" + text4 + ".js");
			text3 += "tinyMCE_GZ.start();";
		}
		for (int j = 0; j < array2.Length; j++)
		{
			text3 += GetFileContents("langs/" + array2[j] + ".js");
		}
		for (int i = 0; i < array3.Length; i++)
		{
			text3 += GetFileContents("themes/" + array3[i] + "/editor_template" + text4 + ".js");
			for (int j = 0; j < array2.Length; j++)
			{
				text3 += GetFileContents("themes/" + array3[i] + "/langs/" + array2[j] + ".js");
			}
		}
		for (int i = 0; i < array.Length; i++)
		{
			text3 += GetFileContents("plugins/" + array[i] + "/editor_plugin" + text4 + ".js");
			for (int j = 0; j < array2.Length; j++)
			{
				text3 += GetFileContents("plugins/" + array[i] + "/langs/" + array2[j] + ".js");
			}
		}
		for (int i = 0; i < array4.Length; i++)
		{
			text3 += GetFileContents(array4[i]);
		}
		if (flag4)
		{
			text3 += "tinyMCE_GZ.end();";
		}
		if (flag5)
		{
			if (flag3)
			{
				Response.AppendHeader("Content-Encoding", text6);
			}
			if (flag && text != "")
			{
				if (flag3)
				{
					using Stream stream = File.Create(text2);
					GZipStream gZipStream = new GZipStream(stream, CompressionMode.Compress, leaveOpen: true);
					byte[] bytes = encoding.GetBytes(text3.ToCharArray());
					gZipStream.Write(bytes, 0, bytes.Length);
					gZipStream.Close();
				}
				else
				{
					using StreamWriter streamWriter = File.CreateText(text2);
					streamWriter.Write(text3);
				}
				Response.WriteFile(text2);
			}
			else
			{
				GZipStream gZipStream2 = new GZipStream(Response.OutputStream, CompressionMode.Compress, leaveOpen: true);
				byte[] bytes = encoding.GetBytes(text3.ToCharArray());
				gZipStream2.Write(bytes, 0, bytes.Length);
				gZipStream2.Close();
			}
		}
		else
		{
			Response.Write(text3);
		}
	}

	private string GetParam(string name, string def)
	{
		return Regex.Replace((Request.QueryString[name] != null) ? (Request.QueryString[name] ?? "") : def, "[^0-9a-zA-Z\\\\-_,]+", "");
	}

	private string GetFileContents(string path)
	{
		try
		{
			path = Server.MapPath(path);
			if (!File.Exists(path))
			{
				return "";
			}
			StreamReader streamReader = new StreamReader(path);
			string result = streamReader.ReadToEnd();
			streamReader.Close();
			return result;
		}
		catch (Exception)
		{
		}
		return "";
	}

	private string MD5(string str)
	{
		using MD5CryptoServiceProvider item = new MD5CryptoServiceProvider();
		return MemoryHelper.ActionWithMemoryBuffer<byte, (MD5CryptoServiceProvider, string), string>(Encoding.ASCII.GetByteCount(str), (item, str), GetMD5Action);
	}

	private string GetMD5Action(byte[] buffer, int offset, int length, (MD5CryptoServiceProvider, string) param)
	{
		var (mD5CryptoServiceProvider, text) = param;
		Encoding.ASCII.GetBytes(text, 0, text.Length, buffer, offset);
		return BitConverter.ToString(mD5CryptoServiceProvider.ComputeHash(buffer, offset, length)).Replace("-", "");
	}
}
