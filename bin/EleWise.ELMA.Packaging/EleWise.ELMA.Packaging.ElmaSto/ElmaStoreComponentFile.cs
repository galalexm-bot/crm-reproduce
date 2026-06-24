using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Packaging.Logging;
using NuGet;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

public class ElmaStoreComponentFile
{
	public const string ComponentBinFileName = "component.bin";

	public const string ManifestFileName = "manifest.elma4manifest";

	public static readonly string[] SupportedManifestFileNames = new string[1] { "manifest.elma3manifest" };

	public const string ManifestExtension = ".elma4manifest";

	public static readonly string[] SupportedManifestExtension = new string[1] { ".elma3manifest" };

	public const string ManifestMask = "*.elma4manifest";

	public static readonly string[] SupportedManifestMask = new string[1] { "*.elma3manifest" };

	public const string ComponentExtension = ".elma4";

	public static readonly string[] SupportedComponentExtension = new string[1] { ".elma3" };

	public const string ComponentMask = "*.elma4";

	public static readonly string[] SupportedComponentMask = new string[1] { "*.elma3" };

	public const string ManifestIconPostfix = "Manifest";

	public static string[] ManifestImgExt = new string[4] { ".PNG", ".GIF", ".JPG", ".JPEG" };

	private string _path;

	private string _manifestFileName;

	private string _componentFileName;

	private ElmaStoreComponentManifest _manifest;

	private string _imagePath;

	public string Id => _manifest.Id;

	public SemanticVersion Version => _manifest.SemanticVersion;

	public ElmaStoreComponentManifest Manifest => _manifest;

	public string IconPath => _imagePath;

	public bool ComponentFileExists
	{
		get
		{
			if (!string.IsNullOrEmpty(_componentFileName))
			{
				return File.Exists(_componentFileName);
			}
			return false;
		}
	}

	public ElmaStoreComponentFile(string fileName)
	{
		if (string.IsNullOrEmpty(fileName))
		{
			throw new ArgumentNullException("fileName");
		}
		_manifestFileName = GetManifestFileName(fileName);
		_componentFileName = GetComponentFileName(fileName);
		_path = Path.GetDirectoryName(fileName);
		if (!string.IsNullOrEmpty(_manifestFileName))
		{
			string xml = File.ReadAllText(_manifestFileName);
			_manifest = ManifestBuilder.DeserializeByXml<ElmaStoreComponentManifest>(xml);
			string directoryName = Path.GetDirectoryName(_manifestFileName);
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(_manifestFileName);
			_imagePath = Directory.GetFiles(directoryName, fileNameWithoutExtension + ".*").FirstOrDefault(delegate(string f)
			{
				string ext = Path.GetExtension(f).ToUpper();
				return ManifestImgExt.Any((string i) => i.Equals(ext, StringComparison.OrdinalIgnoreCase));
			});
			return;
		}
		if (!string.IsNullOrEmpty(_componentFileName))
		{
			_manifest = ElmaStoreComponentsBuilder.Read(_componentFileName, out var icon);
			if (icon != null)
			{
				string directoryName2 = Path.GetDirectoryName(_componentFileName);
				_imagePath = Path.Combine(directoryName2, $"{_manifest.Id}.png");
				if (!File.Exists(_imagePath))
				{
					icon.Save(_imagePath, ImageFormat.Png);
				}
			}
			return;
		}
		throw new ArgumentException(SR.T("Файл компонента ELMA '{0}' не существует", fileName));
	}

	private string GetManifestFileName(string fileName)
	{
		return (from ext in new string[1] { ".elma4manifest" }.Concat(SupportedManifestExtension)
			select Path.ChangeExtension(fileName, ext)).FirstOrDefault(File.Exists);
	}

	private string GetComponentFileName(string fileName)
	{
		return (from ext in new string[1] { ".elma4" }.Concat(SupportedComponentExtension)
			select Path.ChangeExtension(fileName, ext)).FirstOrDefault(File.Exists);
	}

	public void SaveTo(string fileName)
	{
		if (!File.Exists(_componentFileName))
		{
			ElmaStoreComponentsBuilder.Create(_manifestFileName, fileName);
		}
		else
		{
			FS.CopyFile(_componentFileName, fileName, overwrite: true);
		}
	}

	public void UnpackTo(string folder)
	{
		UnpackTo(folder, overwrite: true);
	}

	public void UnpackTo(string folder, bool overwrite)
	{
		UnpackTo(folder, overwrite, null, null);
	}

	public void UnpackTo(string folder, IEnumerable<string> activationKeys, Func<DateTime?> getMainUnitExpiration)
	{
		UnpackTo(folder, overwrite: true, activationKeys, getMainUnitExpiration);
	}

	public Stream GetStream()
	{
		if (!ComponentFileExists)
		{
			return null;
		}
		return new FileStream(_componentFileName, FileMode.Open, FileAccess.Read, FileShare.Read);
	}

	public void UnpackTo(string folder, bool overwrite, IEnumerable<string> activationKeys, Func<DateTime?> getMainUnitExpiration)
	{
		Action<Image, string> action = delegate(Image image, string imageFileName)
		{
			FS.CreateFile(imageFileName, delegate
			{
				image.Save(imageFileName, ImageFormat.Png);
			});
		};
		if (_componentFileName != null && File.Exists(_componentFileName) && activationKeys != null && activationKeys.Any())
		{
			string text = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("n"));
			Directory.CreateDirectory(text);
			try
			{
				if (ElmaStoreComponentsBuilder.UnpackIfSigned(_componentFileName, text, activationKeys, getMainUnitExpiration, out var _) == StoreComponentUnpackStatus.Success)
				{
					string path = Path.Combine(text, "Packages");
					if (Directory.Exists(path))
					{
						string[] files = Directory.GetFiles(path, "*.nupkg");
						foreach (string text2 in files)
						{
							string text3 = Path.Combine(folder, Path.GetFileName(text2));
							if (overwrite || !File.Exists(text3))
							{
								File.Copy(text2, text3, overwrite: true);
							}
						}
					}
					Image image2 = ElmaStoreComponentsBuilder.ReadIcon(_componentFileName);
					if (image2 != null)
					{
						string arg = Path.ChangeExtension(_componentFileName, ".png");
						action(image2, arg);
					}
					return;
				}
			}
			finally
			{
				try
				{
					Directory.Delete(text);
				}
				catch
				{
				}
			}
		}
		if (!Directory.Exists(folder))
		{
			FS.CreateDirectory(folder);
		}
		string text4 = Path.Combine(folder, string.Concat(Id, ".", Version, ".elma4manifest"));
		if (!File.Exists(text4) || overwrite)
		{
			ManifestBuilder.SerializeByXmlToFile<ElmaStoreComponentManifest>(_manifest, text4);
		}
		if (!overwrite)
		{
			bool flag = true;
			foreach (PackageManifest package in _manifest.Packages)
			{
				if (!File.Exists(Path.Combine(folder, package.GetFileName())))
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				return;
			}
		}
		if (_componentFileName != null && File.Exists(_componentFileName))
		{
			ElmaStoreComponentsBuilder.Read(_componentFileName, needPackages: true, folder, needIcon: true, out var _, out var icon);
			if (icon != null)
			{
				string arg2 = Path.ChangeExtension(text4, ".png");
				action(icon, arg2);
			}
			return;
		}
		foreach (PackageManifest package2 in _manifest.Packages)
		{
			string text5 = Path.Combine(_path, package2.GetFileName());
			string text6 = Path.Combine(folder, package2.GetFileName());
			if (File.Exists(text5) && !text5.Equals(text6, StringComparison.CurrentCultureIgnoreCase))
			{
				FS.CopyFile(text5, text6, overwrite: true);
			}
		}
	}

	public void Unpack(bool overwrite)
	{
		UnpackTo(_path, overwrite);
	}

	public void Delete()
	{
		Logger.Log.Info(SR.T("Удаление файлов компонента '{0}'", Id + " " + Version));
		if (File.Exists(_manifestFileName))
		{
			FS.DeleteFile(_manifestFileName);
		}
		if (File.Exists(_componentFileName))
		{
			FS.DeleteFile(_componentFileName);
		}
		if (!string.IsNullOrEmpty(_imagePath) && File.Exists(_imagePath))
		{
			FS.DeleteFile(_imagePath);
		}
	}

	public override string ToString()
	{
		return Id + " " + Version;
	}

	public ComponentLicenseInfo GetLicenseInfo(IEnumerable<string> activationKeys, Func<DateTime?> getMainUnitExpiration)
	{
		if (_componentFileName != null && File.Exists(_componentFileName))
		{
			return ElmaStoreComponentsBuilder.GetLicenseInfo(_componentFileName, activationKeys, getMainUnitExpiration);
		}
		return null;
	}

	public IEnumerable<StoreComponentSignatureInfo> GetSignatures()
	{
		if (_componentFileName != null && File.Exists(_componentFileName))
		{
			return ElmaStoreComponentsBuilder.GetSignatures(_componentFileName);
		}
		return null;
	}
}
