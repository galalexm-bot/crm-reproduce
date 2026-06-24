using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using EleWise.ELMA.Packaging.Extensions;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

public class StoreComponentSignatureInfo
{
	public static class FileNames
	{
		public const string SignaturesFolder = "signatures";

		public const string SignaturePrefix = "/s";

		public const string ManifestSignature = ".manifest.signature";

		public const string ComponentSignature = ".component.signature";

		public const string ComponentCertificate = ".component.cer";

		public const string StoreCertificate = ".store.cer";
	}

	private readonly X509Certificate2 _componentCertificate;

	private readonly X509Certificate2 _storeCertificate;

	private readonly byte[] _componentSignature;

	private readonly byte[] _manifestSignature;

	public X509Certificate2 ComponentCertificate => _componentCertificate;

	public X509Certificate2 StoreCertificate => _storeCertificate;

	public byte[] ComponentSignature => _componentSignature;

	public byte[] ManifestSignature => _manifestSignature;

	public StoreComponentSignatureInfo(X509Certificate2 componentCertificate, X509Certificate2 storeCertificate, byte[] componentSignature, byte[] manifestSignature)
	{
		if (componentCertificate == null)
		{
			throw new ArgumentNullException("componentCertificate");
		}
		if (componentCertificate == null)
		{
			throw new ArgumentNullException("componentCertificate");
		}
		if (componentSignature == null)
		{
			throw new ArgumentNullException("componentSignature");
		}
		if (manifestSignature == null)
		{
			throw new ArgumentNullException("manifestSignature");
		}
		_componentCertificate = componentCertificate;
		_storeCertificate = storeCertificate;
		_componentSignature = componentSignature;
		_manifestSignature = manifestSignature;
	}

	public static byte[] Compress(IEnumerable<StoreComponentSignatureInfo> signatures)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		using MemoryStream memoryStream = new MemoryStream();
		ZipOutputStream val = new ZipOutputStream((Stream)memoryStream);
		try
		{
			((DeflaterOutputStream)val).set_IsStreamOwner(false);
			int num = 0;
			foreach (StoreComponentSignatureInfo signature in signatures)
			{
				num++;
				WriteEntry(val, num + ".component.cer", signature.ComponentCertificate.Export(X509ContentType.Cert));
				WriteEntry(val, num + ".store.cer", signature.StoreCertificate.Export(X509ContentType.Cert));
				WriteEntry(val, num + ".component.signature", signature.ComponentSignature);
				WriteEntry(val, num + ".manifest.signature", signature.ManifestSignature);
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		return memoryStream.ToArray();
	}

	public static IEnumerable<StoreComponentSignatureInfo> Decompress(byte[] data)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		List<StoreComponentSignatureInfo> list = new List<StoreComponentSignatureInfo>();
		using MemoryStream memoryStream = new MemoryStream(data);
		ZipFile val = new ZipFile((Stream)memoryStream);
		try
		{
			val.set_IsStreamOwner(false);
			int num = 0;
			while (true)
			{
				num++;
				ZipEntry entry = val.GetEntry(num + ".component.cer");
				if (entry != null)
				{
					ZipEntry entry2 = val.GetEntry(num + ".store.cer");
					if (entry2 != null)
					{
						ZipEntry entry3 = val.GetEntry(num + ".component.signature");
						if (entry3 != null)
						{
							ZipEntry entry4 = val.GetEntry(num + ".manifest.signature");
							if (entry4 == null)
							{
								break;
							}
							byte[] rawData = val.GetInputStream(entry2).ReadAllBytes();
							byte[] rawData2 = val.GetInputStream(entry).ReadAllBytes();
							StoreComponentSignatureInfo item = new StoreComponentSignatureInfo(manifestSignature: val.GetInputStream(entry4).ReadAllBytes(), componentSignature: val.GetInputStream(entry3).ReadAllBytes(), componentCertificate: new X509Certificate2(rawData2), storeCertificate: new X509Certificate2(rawData));
							list.Add(item);
							continue;
						}
						return list;
					}
					return list;
				}
				return list;
			}
			return list;
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private static void WriteEntry(ZipOutputStream zipStream, string entryName, byte[] bytes)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		entryName = ZipEntry.CleanName(entryName);
		ZipEntry val = new ZipEntry(entryName);
		val.set_Size((long)bytes.Length);
		ZipEntry val2 = val;
		zipStream.PutNextEntry(val2);
		((Stream)(object)zipStream).Write(bytes, 0, bytes.Length);
		zipStream.CloseEntry();
	}
}
