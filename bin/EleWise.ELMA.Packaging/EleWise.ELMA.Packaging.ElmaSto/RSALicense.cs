using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

public sealed class RSALicense
{
	private readonly Guid _moduleUid;

	private readonly string _id;

	private readonly string _version;

	private readonly IEnumerable<X509Certificate2> _certificates;

	private readonly Func<DateTime?> _getMainUnitExpiration;

	private bool initialized;

	private bool licensingInitialized;

	private X509Certificate2 lastCertificate;

	private string lastAppliedActKey;

	private string registrationKey;

	private ComponentLicenseInfo licenseInfo;

	private ComponentLicenseStatus initializedStatus;

	private const uint DRIVE_FIXED = 3u;

	public RSALicense(Guid moduleUid, string id, string version, IEnumerable<X509Certificate2> certificates, Func<DateTime?> getMainUnitExpiration)
	{
		if (string.IsNullOrEmpty(id))
		{
			throw new ArgumentNullException("id");
		}
		if (certificates == null)
		{
			throw new ArgumentNullException("certificates");
		}
		_moduleUid = moduleUid;
		_id = id;
		_version = version;
		_certificates = certificates;
		_getMainUnitExpiration = getMainUnitExpiration;
	}

	public string GetRegistrationKey()
	{
		InitLicense();
		return registrationKey;
	}

	public void ApplyActivationKey(string key)
	{
		foreach (X509Certificate2 certificate in _certificates)
		{
			ApplyActivationKey(key, certificate);
		}
	}

	public ComponentLicenseInfo GetLicenseInfo()
	{
		InitLicense();
		return licenseInfo;
	}

	public void CompleteLicensingInitialize()
	{
		InitLicense();
		licensingInitialized = true;
		UpdateTrialExpiration();
		initializedStatus = licenseInfo.Status;
	}

	public void UpdateLicenseInfo()
	{
		InitLicense();
		DecodeActivationKey(lastAppliedActKey, lastCertificate, out var status, out var _, out var _, out var _);
		licenseInfo.Status = status;
		UpdateTrialExpiration();
	}

	public byte[] GetActivationToken()
	{
		return null;
	}

	public byte[] GetActivationTokenV2()
	{
		InitLicense();
		DecodeActivationKey(lastAppliedActKey, lastCertificate, out var status, out var _, out var licType, out var expirationDate);
		if (status != 0)
		{
			return null;
		}
		int value = (expirationDate.HasValue ? ((int)(expirationDate.Value - new DateTime(2000, 1, 1)).TotalDays) : 0);
		return GetActivationToken(_id, _version, _certificates, licType, value);
	}

	public static byte[] GetActivationToken(string id, string version, IEnumerable<StoreComponentSignatureInfo> signatures)
	{
		if (string.IsNullOrEmpty(id) || signatures == null)
		{
			return null;
		}
		return GetActivationToken(id, version, signatures.Select((StoreComponentSignatureInfo s) => s.ComponentCertificate), null, null);
	}

	private void InitLicense()
	{
		if (initialized)
		{
			return;
		}
		lock (this)
		{
			if (!initialized)
			{
				registrationKey = GenerateRegistrationKey(1);
				licenseInfo = new ComponentLicenseInfo
				{
					Status = ComponentLicenseStatus.NotActivated
				};
				initialized = true;
			}
		}
	}

	private void ApplyActivationKey(string key, X509Certificate2 certificate)
	{
		InitLicense();
		if (!DecodeActivationKey(key, certificate, out var status, out var licCount, out var licType, out var expirationDate))
		{
			return;
		}
		if (lastAppliedActKey == null)
		{
			SetLastAppliedKey(key, certificate, status, licCount, expirationDate, licType);
			return;
		}
		DecodeActivationKey(lastAppliedActKey, lastCertificate, out var _, out var licCount2, out var licType2, out var expirationDate2);
		byte b = (byte)((licType == 2) ? 1 : licType);
		byte b2 = (byte)((licType2 == 2) ? 1 : licType2);
		if (b < b2)
		{
			SetLastAppliedKey(key, certificate, status, licCount, expirationDate, licType);
		}
		else if (b <= b2)
		{
			if ((licType == 1 || licType == 2) && expirationDate.HasValue && (!expirationDate2.HasValue || expirationDate.Value > expirationDate2.Value))
			{
				SetLastAppliedKey(key, certificate, status, licCount, expirationDate, licType);
			}
			else if (licCount > licCount2)
			{
				SetLastAppliedKey(key, certificate, status, licCount, expirationDate, licType);
			}
		}
	}

	[DllImport("kernel32.dll")]
	private static extern long GetVolumeInformation(string PathName, StringBuilder VolumeNameBuffer, uint VolumeNameSize, ref uint VolumeSerialNumber, ref uint MaximumComponentLength, ref uint FileSystemFlags, StringBuilder FileSystemNameBuffer, uint FileSystemNameSize);

	[DllImport("kernel32.dll")]
	private static extern uint GetDriveType(string lpRootPathName);

	private static ulong GHN()
	{
		ulong num = 0uL;
		char[] array = new char[24]
		{
			'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
			'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
			'W', 'X', 'Y', 'Z'
		};
		for (int i = 0; i < array.Length; i++)
		{
			char c = array[i];
			try
			{
				uint VolumeSerialNumber = 0u;
				uint MaximumComponentLength = 0u;
				StringBuilder stringBuilder = new StringBuilder(256);
				uint FileSystemFlags = 0u;
				StringBuilder stringBuilder2 = new StringBuilder(256);
				string text = c + ":\\";
				GetVolumeInformation(text, stringBuilder, (uint)stringBuilder.Capacity, ref VolumeSerialNumber, ref MaximumComponentLength, ref FileSystemFlags, stringBuilder2, (uint)stringBuilder2.Capacity);
				if (GetDriveType(text) != 3 || VolumeSerialNumber == 0)
				{
					continue;
				}
				for (int j = 0; j < 48; j++)
				{
					int num2 = j % 32;
					if (j % 2 == 0)
					{
						num2 = 31 - num2;
					}
					num2 = (num2 + j / 16) % 32;
					num = (num << 1) | ((VolumeSerialNumber >> num2) & 1u);
				}
				if (num == 0L)
				{
					num = 1uL;
					return num;
				}
				return num;
			}
			catch
			{
			}
		}
		return num;
	}

	private static string GenerateRegistrationKey(ushort algorithm)
	{
		ulong num = GHN();
		ulong[] array = new ulong[2] { num, algorithm };
		byte[] array2 = new byte[64]
		{
			0, 1, 0, 0, 0, 0, 1, 0, 0, 0,
			1, 0, 0, 1, 0, 0, 1, 0, 0, 0,
			0, 0, 0, 1, 0, 0, 0, 1, 1, 0,
			0, 0, 1, 0, 0, 0, 0, 0, 0, 1,
			0, 1, 0, 0, 0, 0, 1, 0, 0, 0,
			1, 0, 0, 1, 0, 0, 0, 0, 0, 1,
			1, 0, 0, 0
		};
		uint[] array3 = new uint[array2.Length / 32];
		for (int i = 0; i < array2.Length; i++)
		{
			int num2 = array2.Length - i - 1;
			byte b = array2[num2];
			int num3 = num2 / 32;
			int num4 = i % 32;
			byte b2 = (byte)(array[b] & 1);
			array[b] >>= 1;
			array3[num3] |= (uint)(b2 << num4);
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int j = 0; j < array3.Length; j++)
		{
			string text = array3[j].ToString();
			while (text.Length < 10)
			{
				text = "0" + text;
			}
			stringBuilder.Append(text);
		}
		return FormatKey(stringBuilder.ToString());
	}

	private static string FormatKey(string key)
	{
		if (key == null)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		char[] array = key.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			if (i > 0 && i % 5 == 0)
			{
				stringBuilder.Append('-');
			}
			stringBuilder.Append(array[i]);
		}
		return stringBuilder.ToString();
	}

	private bool DecodeLastActivationKey(out ComponentLicenseStatus status, out ushort licCount, out byte licType, out DateTime? expirationDate)
	{
		return DecodeActivationKey(lastAppliedActKey, lastCertificate, out status, out licCount, out licType, out expirationDate);
	}

	private bool DecodeActivationKey(string key, X509Certificate2 certificate, out ComponentLicenseStatus status, out ushort licCount, out byte licType, out DateTime? expirationDate)
	{
		InitLicense();
		expirationDate = null;
		status = ComponentLicenseStatus.NotActivated;
		licCount = 0;
		licType = 0;
		string[] unitActivationKeys = ActivationKeyHelper.GetUnitActivationKeys(key, _moduleUid);
		foreach (string text in unitActivationKeys)
		{
			if (text == null)
			{
				continue;
			}
			try
			{
				string text2 = text.Replace("-", "");
				uint[] array = new uint[text2.Length / 10];
				for (int j = 0; j < array.Length; j++)
				{
					array[j] = uint.Parse(text2.Substring(j * 10, 10));
				}
				if (array.Length < 2)
				{
					continue;
				}
				uint num = array[0];
				int num2 = Marshal.SizeOf(typeof(uint));
				byte[] array2 = new byte[(array.Length - 1) * num2];
				for (int k = 1; k < array.Length; k++)
				{
					byte[] bytes = BitConverter.GetBytes(array[k]);
					for (int l = 0; l < num2; l++)
					{
						array2[(k - 1) * num2 + l] = bytes[l];
					}
				}
				if (num < 0 || num > array2.Length)
				{
					continue;
				}
				if (num < array2.Length)
				{
					Array.Resize(ref array2, (int)num);
				}
				byte[] array3 = ((RSACryptoServiceProvider)certificate.PublicKey.Key).PublicDecryption(array2);
				int num3 = Marshal.SizeOf(typeof(uint));
				uint[] array4 = new uint[array3.Length / num3];
				for (int m = 0; m < array4.Length; m++)
				{
					array4[m] = BitConverter.ToUInt32(array3, m * num3);
				}
				if (array4.Length != 4)
				{
					continue;
				}
				byte[] array5 = new byte[128]
				{
					0, 3, 1, 0, 0, 0, 2, 0, 0, 5,
					0, 3, 0, 2, 1, 2, 3, 0, 0, 1,
					0, 5, 3, 0, 0, 4, 5, 4, 3, 4,
					0, 4, 0, 5, 2, 0, 0, 4, 4, 4,
					0, 1, 0, 3, 0, 0, 5, 0, 5, 4,
					1, 5, 4, 4, 5, 0, 1, 4, 3, 0,
					0, 5, 0, 3, 5, 1, 0, 0, 3, 0,
					4, 5, 0, 3, 4, 0, 0, 2, 5, 2,
					3, 0, 4, 1, 0, 5, 0, 3, 4, 4,
					0, 1, 1, 0, 4, 3, 4, 3, 4, 1,
					4, 2, 4, 1, 1, 0, 5, 0, 4, 0,
					0, 1, 0, 2, 0, 0, 1, 3, 0, 0,
					0, 5, 1, 4, 5, 4, 0, 3
				};
				ulong[] array6 = new ulong[6];
				int[] array7 = new int[array6.Length];
				for (int n = 0; n < array5.Length; n++)
				{
					int num4 = array5.Length - n - 1;
					int num5 = num4 / 32;
					byte b = array5[num4];
					int num6 = array7[b];
					array7[b]++;
					byte b2 = (byte)(array4[num5] & 1u);
					array4[num5] >>= 1;
					array6[b] |= (ulong)b2 << num6;
				}
				ulong num7 = array6[0];
				if (GHN() != num7)
				{
					continue;
				}
				status = ComponentLicenseStatus.Activated;
				licCount = (ushort)array6[1];
				licType = (byte)array6[2];
				ushort num8 = (ushort)array6[3];
				expirationDate = ((licType == 1 || licType == 2) ? new DateTime?(new DateTime(2000, 1, 1).AddDays((int)num8)) : null);
				if (licensingInitialized)
				{
					UpdateTrialExpiration(ref expirationDate, ref status);
				}
				if (expirationDate.HasValue && DateTime.Now.Date > expirationDate.Value)
				{
					status = ComponentLicenseStatus.DateExpired;
				}
				return true;
			}
			catch
			{
			}
		}
		return false;
	}

	private void SetLastAppliedKey(string key, X509Certificate2 certificate, ComponentLicenseStatus newStatus, ushort newLicCount, DateTime? newExpirationDate, byte newLicType)
	{
		lastAppliedActKey = key;
		lastCertificate = certificate;
		if (licensingInitialized && newStatus == ComponentLicenseStatus.Activated && initializedStatus != 0)
		{
			licenseInfo.Status = ComponentLicenseStatus.NeedRestart;
		}
		else
		{
			licenseInfo.Status = newStatus;
		}
		licenseInfo.LicenseType = newLicType;
		licenseInfo.WorkplaceCount = ((newLicCount >= 65000) ? null : new uint?(newLicCount));
		licenseInfo.TrialExpiration = newExpirationDate;
		if (licensingInitialized)
		{
			UpdateTrialExpiration();
		}
	}

	private static byte[] GetActivationToken(string id, string version, IEnumerable<X509Certificate2> certificates, byte? licType, int? expired)
	{
		using MemoryStream memoryStream = new MemoryStream();
		BinaryWriter writer = new BinaryWriter(memoryStream, Encoding.UTF8);
		try
		{
			Action<string> action = delegate(string s)
			{
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				if (bytes.Length > 32767)
				{
					throw new Exception("Too long string for activation token: " + s);
				}
				writer.Write((short)bytes.Length);
				writer.Write(bytes);
			};
			writer.Write((byte)((!licType.HasValue) ? 10 : 11));
			action(id);
			action(version ?? "");
			if (licType.HasValue)
			{
				writer.Write(licType.Value);
				writer.Write(expired.HasValue ? expired.Value : 0);
			}
			writer.Write((short)((certificates != null) ? ((short)certificates.Count()) : 0));
			if (certificates != null)
			{
				foreach (X509Certificate2 certificate in certificates)
				{
					action(certificate.Issuer);
				}
			}
		}
		finally
		{
			if (writer != null)
			{
				((IDisposable)writer).Dispose();
			}
		}
		return memoryStream.ToArray();
	}

	private void UpdateTrialExpiration()
	{
		if (licenseInfo != null && licenseInfo.TrialExpiration.HasValue)
		{
			DateTime? trialExpiration = licenseInfo.TrialExpiration;
			ComponentLicenseStatus status = licenseInfo.Status;
			UpdateTrialExpiration(ref trialExpiration, ref status);
			licenseInfo.TrialExpiration = trialExpiration;
			licenseInfo.Status = status;
		}
	}

	private void UpdateTrialExpiration(ref DateTime? trialExpiration, ref ComponentLicenseStatus status)
	{
		if (trialExpiration.HasValue && _getMainUnitExpiration != null)
		{
			DateTime? dateTime = _getMainUnitExpiration();
			if (dateTime.HasValue)
			{
				trialExpiration = dateTime;
			}
			if (trialExpiration.HasValue && (status == ComponentLicenseStatus.Activated || status == ComponentLicenseStatus.DateExpired))
			{
				status = ((DateTime.Now.Date > trialExpiration.Value) ? ComponentLicenseStatus.DateExpired : ComponentLicenseStatus.Activated);
			}
		}
	}
}
