using System;
using System.Collections;
using System.Collections.Concurrent;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Web.Hosting;
using EleWise.ELMA.Memory;

namespace EleWise.ELMA.Web.Mvc.MarkupRendering;

public class OnTheFlyVirtualPathProvider : VirtualPathProvider
{
	private class OnTheFlyVirtualFile : VirtualFile
	{
		private readonly string markup;

		private readonly byte[] bytes;

		public OnTheFlyVirtualFile(string markup, string virtualPath)
			: base(virtualPath)
		{
			this.markup = markup;
			bytes = Encoding.UTF8.GetBytes(markup);
		}

		public override Stream Open()
		{
			MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
			using (TextWriter textWriter = new StreamWriter(memoryStream.AsNoClose(), Encoding.UTF8))
			{
				textWriter.Write(markup);
				textWriter.Flush();
			}
			memoryStream.Seek(0L, SeekOrigin.Begin);
			return memoryStream;
		}
	}

	public const string VirtualPathPrefix = "/OnTheFlyViews";

	private static readonly ConcurrentDictionary<string, OnTheFlyVirtualFile> hashedMarkups = new ConcurrentDictionary<string, OnTheFlyVirtualFile>();

	private static readonly ConcurrentDictionary<string, string> hashes = new ConcurrentDictionary<string, string>();

	public static void AppInitialize()
	{
	}

	internal static string GetPathFormMarkup(string markup, string extension)
	{
		string orAdd = hashes.GetOrAdd(markup, (string m) => GetMd5Hash(m));
		string virtualPath = string.Format("{0}/{1}.{2}", "/OnTheFlyViews", orAdd, extension);
		hashedMarkups.GetOrAdd(virtualPath, (string k) => new OnTheFlyVirtualFile(markup, virtualPath));
		return virtualPath;
	}

	private static string GetMd5Hash(string input)
	{
		int byteCount = Encoding.Default.GetByteCount(input);
		if (byteCount == 0)
		{
			return string.Empty;
		}
		using MD5 item = MD5.Create();
		byte[] array = MemoryHelper.ActionWithMemoryBuffer<byte, (MD5, string), byte[]>(byteCount, (item, input), GetMd5HashAction);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	private static byte[] GetMd5HashAction(byte[] buffer, int offset, int length, (MD5, string) param)
	{
		var (mD, text) = param;
		Encoding.Default.GetBytes(text, 0, text.Length, buffer, offset);
		return mD.ComputeHash(buffer, offset, length);
	}

	public override bool FileExists(string virtualPath)
	{
		if (IsOnTheFlyViewVirtualPath(virtualPath))
		{
			return hashedMarkups.ContainsKey(virtualPath);
		}
		return base.FileExists(virtualPath);
	}

	public override VirtualFile GetFile(string virtualPath)
	{
		if (IsOnTheFlyViewVirtualPath(virtualPath))
		{
			if (!hashedMarkups.TryGetValue(virtualPath, out var value))
			{
				throw new InvalidOperationException(SR.T("Неправильный путь файла {0}. Хеш динамической разметки или устарел или вычислен неправильно.", virtualPath));
			}
			return value;
		}
		return base.GetFile(virtualPath);
	}

	public override string GetFileHash(string virtualPath, IEnumerable virtualPathDependencies)
	{
		if (IsOnTheFlyViewVirtualPath(virtualPath))
		{
			return virtualPath.Remove(virtualPath.LastIndexOf(".")).Substring(virtualPath.LastIndexOf("/") + 1) + "_onthefly";
		}
		return base.GetFileHash(virtualPath, virtualPathDependencies);
	}

	private bool IsOnTheFlyViewVirtualPath(string virtualPath)
	{
		return virtualPath.StartsWith("/OnTheFlyViews", StringComparison.Ordinal);
	}
}
