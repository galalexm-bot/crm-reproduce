using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FileProvider.Distributed.Models;
using EleWise.ELMA.Helpers;
using Newtonsoft.Json;

namespace EleWise.ELMA.FileProvider.Distributed;

internal class DistributedStorageApiUrlGenerator
{
	private static class ApiParameterNames
	{
		public const string Key = "Key";

		public const string Crc = "Crc";

		public const string SourceUrl = "SrcUrl";

		public const string SaltSecret = "Secret.Salt";

		public const string PasswordSecret = "Secret.Password";

		public const string HashAlgorithm = "HashAlgorithm";

		public const string Uid = "Uid";

		public const string ContentType = "ContentType";

		public const string Name = "Name";

		public const string UploadidFileName = "qqfile";

		public const string ProtectedContainer = "_payload";
	}

	private static class ApiUrlTemplates
	{
		public const string VersionParameter = "version";

		public static string RootApiUrl => string.Format("api/{{{0}}}/", "version");

		public static string UploadAjax => RootApiUrl + "UploadAjax";

		public static string Save => RootApiUrl + "save";

		public static string Decrypt => RootApiUrl + "decrypt";

		public static string Encrypt => RootApiUrl + "encrypt";

		public static string Hash => RootApiUrl + "hash";

		public static string Fetch => RootApiUrl + "fetch";

		public static string Check => RootApiUrl + "check";

		public static string Content => RootApiUrl + "content";
	}

	private class Secret
	{
		public string Salt { get; set; }

		public string Password { get; set; }
	}

	private class TimestampedRequest
	{
		public string Timestamp { get; set; }

		public TimestampedRequest()
		{
			Timestamp = DateTimeOffset.UtcNow.ToString("o", CultureInfo.InvariantCulture);
		}
	}

	private class GetStreamRequest : TimestampedRequest
	{
		public string Key { get; set; }

		public string Crc { get; set; }

		public string SrcUrl { get; set; }

		public string ContentType { get; set; }

		public string Name { get; set; }

		public Secret Secret { get; set; }
	}

	private class GetHashRequest : TimestampedRequest
	{
		public string Key { get; set; }

		public string Crc { get; set; }

		public string SrcUrl { get; set; }

		public string HashAlgorithm { get; set; }
	}

	private class EncryptRequest : TimestampedRequest
	{
		public string Key { get; set; }

		public string Crc { get; set; }

		public Secret Secret { get; set; }

		public EncryptRequest()
		{
			Secret = new Secret();
		}
	}

	private class DecryptRequest : TimestampedRequest
	{
		public string Key { get; set; }

		public string Crc { get; set; }

		public string SrcUrl { get; set; }

		public Secret Secret { get; set; }

		public DecryptRequest()
		{
			Secret = new Secret();
		}
	}

	private class SaveRequest : TimestampedRequest
	{
		public string Uid { get; set; }

		public string Name { get; set; }
	}

	private class FetchRequest : TimestampedRequest
	{
		public string Key { get; set; }

		public string Crc { get; set; }

		public string SrcUrl { get; set; }
	}

	private class CheckRequest : TimestampedRequest
	{
		public string Uid { get; set; }
	}

	private class SignedGatewayRequest
	{
		public string Arguments { get; set; }

		public string Signature { get; set; }
	}

	private const string GatewayApiVersion = "v1";

	private const string UploaderApi = "uploader";

	private readonly EndpointsCollection endpoints;

	private readonly RSAParameters serverPrivateKey;

	public DistributedStorageApiUrlGenerator(EndpointsCollection endpoints, string privateKeyPath)
	{
		this.endpoints = endpoints;
		serverPrivateKey = EncryptionHelper.LoadRsaKeyFromFile(privateKeyPath);
	}

	public Uri GetBaseUploadUrl(string gatewayName)
	{
		Uri baseAddress = new Uri(endpoints.GetOrDefault(gatewayName).Url);
		UriTemplate uriTemplate = new UriTemplate(ApiUrlTemplates.UploadAjax);
		Dictionary<string, string> parameters = new Dictionary<string, string> { { "version", "uploader" } };
		return uriTemplate.BindByName(baseAddress, parameters);
	}

	public Uri GetUploadUrl(string gatewayName, string fileName)
	{
		Uri baseAddress = new Uri(endpoints.GetOrDefault(gatewayName).Url);
		UriTemplate uriTemplate = new UriTemplate(ApiUrlTemplates.UploadAjax);
		Dictionary<string, string> parameters = new Dictionary<string, string>
		{
			{ "version", "uploader" },
			{ "qqfile", fileName }
		};
		return uriTemplate.BindByName(baseAddress, parameters);
	}

	public Uri GetStreamDownloadUrl(Uri contentLocation, string crc, AdditionalDownloadParameters parameters = null)
	{
		parameters = parameters ?? new AdditionalDownloadParameters();
		return GetStreamUrl(contentLocation, crc, parameters);
	}

	public Uri GetStreamMetadataUrl(Uri contentLocation)
	{
		return GetStreamUrl(contentLocation, null, new AdditionalDownloadParameters());
	}

	public Uri GetSaveContentUrl(Uri srcLocation, string dstName)
	{
		string name = (srcLocation.Host.IsNullOrEmpty() ? endpoints.DefaultEndpointName : srcLocation.Host);
		Endpoint orDefault = endpoints.GetOrDefault(name);
		Uri baseAddress = new Uri(orDefault.Url);
		UriTemplate uriTemplate = new UriTemplate(ApiUrlTemplates.Save);
		Dictionary<string, string> dictionary = new Dictionary<string, string> { { "version", "v1" } };
		if (orDefault.DisableSecurity)
		{
			dictionary.Add("Uid", VirtualContentPath.GetNameFromVirtualPath(srcLocation.LocalPath));
			dictionary.Add("Name", dstName);
		}
		else
		{
			SaveRequest saveRequest = new SaveRequest
			{
				Uid = VirtualContentPath.GetNameFromVirtualPath(srcLocation.LocalPath),
				Name = dstName
			};
			string value = SignRequestArguments(JsonConvert.SerializeObject((object)saveRequest));
			dictionary.Add("_payload", value);
		}
		return uriTemplate.BindByName(baseAddress, dictionary);
	}

	public Uri GetDecryptContentUrl(Uri location, string crc, string password, string salt, string sourceUrl)
	{
		string name = (location.Host.IsNullOrEmpty() ? endpoints.DefaultEndpointName : location.Host);
		Endpoint orDefault = endpoints.GetOrDefault(name);
		Uri baseAddress = new Uri(orDefault.Url);
		UriTemplate uriTemplate = new UriTemplate(ApiUrlTemplates.Decrypt);
		Dictionary<string, string> dictionary = new Dictionary<string, string> { { "version", "v1" } };
		Secret secret = new Secret
		{
			Salt = salt,
			Password = EncryptionHelper.RsaEncrypt(password, orDefault.PublicKey)
		};
		if (orDefault.DisableSecurity)
		{
			dictionary.Add("Key", VirtualContentPath.GetNameFromVirtualPath(location.LocalPath));
			dictionary.Add("Secret.Salt", secret.Salt);
			dictionary.Add("Secret.Password", secret.Password);
			if (!string.IsNullOrEmpty(crc))
			{
				dictionary.Add("Crc", crc);
			}
			if (!sourceUrl.IsNullOrEmpty())
			{
				dictionary.Add("SrcUrl", sourceUrl);
			}
		}
		else
		{
			DecryptRequest decryptRequest = new DecryptRequest
			{
				Key = VirtualContentPath.GetNameFromVirtualPath(location.LocalPath),
				Crc = (string.IsNullOrEmpty(crc) ? null : crc),
				SrcUrl = (sourceUrl.IsNullOrEmpty() ? null : sourceUrl),
				Secret = secret
			};
			string value = SignRequestArguments(JsonConvert.SerializeObject((object)decryptRequest));
			dictionary.Add("_payload", value);
		}
		return uriTemplate.BindByName(baseAddress, dictionary);
	}

	public Uri GetEncryptContentUrl(Uri location, string crc, string password, string salt)
	{
		string name = (location.Host.IsNullOrEmpty() ? endpoints.DefaultEndpointName : location.Host);
		Endpoint orDefault = endpoints.GetOrDefault(name);
		Uri baseAddress = new Uri(orDefault.Url);
		UriTemplate uriTemplate = new UriTemplate(ApiUrlTemplates.Encrypt);
		Dictionary<string, string> dictionary = new Dictionary<string, string> { { "version", "v1" } };
		Secret secret = new Secret
		{
			Salt = salt,
			Password = EncryptionHelper.RsaEncrypt(password, orDefault.PublicKey)
		};
		if (orDefault.DisableSecurity)
		{
			dictionary.Add("Key", VirtualContentPath.GetNameFromVirtualPath(location.LocalPath));
			dictionary.Add("Secret.Salt", secret.Salt);
			dictionary.Add("Secret.Password", secret.Password);
			if (!string.IsNullOrEmpty(crc))
			{
				dictionary.Add("Crc", crc);
			}
		}
		else
		{
			EncryptRequest encryptRequest = new EncryptRequest
			{
				Key = VirtualContentPath.GetNameFromVirtualPath(location.LocalPath),
				Crc = (string.IsNullOrEmpty(crc) ? null : crc),
				Secret = secret
			};
			string value = SignRequestArguments(JsonConvert.SerializeObject((object)encryptRequest));
			dictionary.Add("_payload", value);
		}
		return uriTemplate.BindByName(baseAddress, dictionary);
	}

	public Uri GetContentHashUrl(Uri location, string hashAlgorithm, string crc, string sourceUrl)
	{
		string name = (location.Host.IsNullOrEmpty() ? endpoints.DefaultEndpointName : location.Host);
		Endpoint orDefault = endpoints.GetOrDefault(name);
		Uri baseAddress = new Uri(orDefault.Url);
		UriTemplate uriTemplate = new UriTemplate(ApiUrlTemplates.Hash);
		Dictionary<string, string> dictionary = new Dictionary<string, string> { { "version", "v1" } };
		if (orDefault.DisableSecurity)
		{
			dictionary.Add("Key", VirtualContentPath.GetNameFromVirtualPath(location.LocalPath));
			dictionary.Add("HashAlgorithm", hashAlgorithm);
			dictionary.Add("Crc", crc);
			if (!sourceUrl.IsNullOrEmpty())
			{
				dictionary.Add("SrcUrl", sourceUrl);
			}
		}
		else
		{
			GetHashRequest getHashRequest = new GetHashRequest
			{
				Key = VirtualContentPath.GetNameFromVirtualPath(location.LocalPath),
				Crc = crc,
				SrcUrl = sourceUrl,
				HashAlgorithm = hashAlgorithm
			};
			string value = SignRequestArguments(JsonConvert.SerializeObject((object)getHashRequest));
			dictionary.Add("_payload", value);
		}
		return uriTemplate.BindByName(baseAddress, dictionary);
	}

	public Uri GetFetchContentUrl(Uri location, string crc, string sourceUrl)
	{
		string name = (location.Host.IsNullOrEmpty() ? endpoints.DefaultEndpointName : location.Host);
		Endpoint orDefault = endpoints.GetOrDefault(name);
		Uri baseAddress = new Uri(orDefault.Url);
		UriTemplate uriTemplate = new UriTemplate(ApiUrlTemplates.Fetch);
		Dictionary<string, string> dictionary = new Dictionary<string, string> { { "version", "v1" } };
		if (orDefault.DisableSecurity)
		{
			dictionary.Add("Key", VirtualContentPath.GetNameFromVirtualPath(location.LocalPath));
			dictionary.Add("Crc", crc);
			dictionary.Add("SrcUrl", sourceUrl);
		}
		else
		{
			FetchRequest fetchRequest = new FetchRequest
			{
				Key = VirtualContentPath.GetNameFromVirtualPath(location.LocalPath),
				Crc = crc,
				SrcUrl = sourceUrl
			};
			string value = SignRequestArguments(JsonConvert.SerializeObject((object)fetchRequest));
			dictionary.Add("_payload", value);
		}
		return uriTemplate.BindByName(baseAddress, dictionary);
	}

	public Uri GetCheckUrl(string gatewayId, Guid uid)
	{
		Endpoint orDefault = endpoints.GetOrDefault(gatewayId);
		Uri baseAddress = new Uri(orDefault.Url);
		UriTemplate uriTemplate = new UriTemplate(ApiUrlTemplates.Check);
		Dictionary<string, string> dictionary = new Dictionary<string, string> { { "version", "v1" } };
		if (orDefault.DisableSecurity)
		{
			dictionary.Add("Uid", uid.ToString());
		}
		else
		{
			CheckRequest checkRequest = new CheckRequest
			{
				Uid = uid.ToString()
			};
			string value = SignRequestArguments(JsonConvert.SerializeObject((object)checkRequest));
			dictionary.Add("_payload", value);
		}
		return uriTemplate.BindByName(baseAddress, dictionary);
	}

	private Uri GetStreamUrl(Uri contentLocation, string crc, AdditionalDownloadParameters parameters)
	{
		string name = (contentLocation.Host.IsNullOrEmpty() ? endpoints.DefaultEndpointName : contentLocation.Host);
		Endpoint orDefault = endpoints.GetOrDefault(name);
		Uri baseAddress = new Uri(orDefault.Url);
		UriTemplate uriTemplate = new UriTemplate(ApiUrlTemplates.Content);
		Dictionary<string, string> dictionary = new Dictionary<string, string> { { "version", "v1" } };
		if (orDefault.DisableSecurity)
		{
			dictionary.Add("Key", VirtualContentPath.GetNameFromVirtualPath(contentLocation.LocalPath));
			if (!string.IsNullOrEmpty(crc))
			{
				dictionary.Add("Crc", crc);
			}
			if (!parameters.SourceUrl.IsNullOrEmpty())
			{
				dictionary.Add("SrcUrl", parameters.SourceUrl);
			}
			if (!parameters.ContentType.IsNullOrEmpty())
			{
				dictionary.Add("ContentType", parameters.ContentType);
			}
			if (!parameters.DownloadName.IsNullOrEmpty())
			{
				dictionary.Add("Name", parameters.DownloadName);
			}
			if (parameters.Secret != null)
			{
				dictionary.Add("Secret.Salt", parameters.Secret.Salt);
				dictionary.Add("Secret.Password", EncryptionHelper.RsaEncrypt(parameters.Secret.Password, orDefault.PublicKey));
			}
		}
		else
		{
			GetStreamRequest getStreamRequest = new GetStreamRequest
			{
				Key = VirtualContentPath.GetNameFromVirtualPath(contentLocation.LocalPath),
				Crc = (string.IsNullOrEmpty(crc) ? null : crc),
				SrcUrl = (parameters.SourceUrl.IsNullOrEmpty() ? null : parameters.SourceUrl),
				ContentType = (parameters.ContentType.IsNullOrEmpty() ? null : parameters.ContentType),
				Name = (parameters.DownloadName.IsNullOrEmpty() ? null : parameters.DownloadName),
				Secret = ((parameters.Secret == null) ? null : new Secret
				{
					Salt = parameters.Secret.Salt,
					Password = EncryptionHelper.RsaEncrypt(parameters.Secret.Password, orDefault.PublicKey)
				})
			};
			string value = SignRequestArguments(JsonConvert.SerializeObject((object)getStreamRequest));
			dictionary.Add("_payload", value);
		}
		return uriTemplate.BindByName(baseAddress, dictionary);
	}

	private string SignRequestArguments(string serializedRequestArguments)
	{
		string signature = EncryptionHelper.RsaSign(serializedRequestArguments, serverPrivateKey);
		return JsonConvert.SerializeObject((object)new SignedGatewayRequest
		{
			Arguments = serializedRequestArguments,
			Signature = signature
		}).ToBase64String();
	}
}
