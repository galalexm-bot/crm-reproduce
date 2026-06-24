using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Templates.Content.IconPack;
using EleWise.ELMA.Web.Service;
using Newtonsoft.Json;
using NuGet;

namespace EleWise.ELMA.Web.Mvc.Controllers;

public class ImagesController : BaseController
{
	private static readonly IDictionary<ImageFormatType, string> TypeToMime = new Dictionary<ImageFormatType, string>
	{
		{
			ImageFormatType.Png,
			"image/png"
		},
		{
			ImageFormatType.Jpg,
			"image/jpeg"
		},
		{
			ImageFormatType.Gif,
			"image/gif"
		},
		{
			ImageFormatType.Svg,
			"image/svg+xml"
		},
		{
			ImageFormatType.IconPack,
			"image/svg+xml"
		}
	};

	private static readonly object StoreComponentImagePathsLocker = new object();

	private static ConcurrentDictionary<string, string> _storeComponentImagePaths;

	private const int MaxPhotoSize = 340;

	private const int MaxGifSize = 1;

	public IIconPackService IconPackService { get; set; }

	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	public IAuditManager AuditManager { get; set; }

	public PackageService PackageService { get; set; }

	private ActionResult GetImageFromMetadata([NotNull] MetadataImage metadata)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		if (TypeToMime.TryGetValue(metadata.Format, out var value))
		{
			if (metadata.IsSvg())
			{
				string content = metadata.RawData;
				if (metadata.Format == ImageFormatType.IconPack)
				{
					IconModel icon = IconPackService.GetIcon(metadata.ResourceName);
					if (icon != null)
					{
						content = SvgHelper.SvgResize(icon.Data, metadata.Size);
					}
				}
				return (ActionResult)(object)GetVectorImage(content, value);
			}
			return (ActionResult)(object)GetRasterImage(metadata.Data, value);
		}
		return (ActionResult)new EmptyResult();
	}

	public string GetSvgMarkup(string fileName, IDictionary<string, object> htmlAttributes)
	{
		HtmlHelper htmlHelper = GetHtmlHelper();
		if (htmlHelper != null)
		{
			return ((object)htmlHelper.SvgImage(fileName, htmlAttributes)).ToString();
		}
		return string.Empty;
	}

	public string GetSvgMarkupRaw(string fileName)
	{
		HtmlHelper htmlHelper = GetHtmlHelper();
		if (htmlHelper != null)
		{
			return SvgService.GetContent(htmlHelper.Url().Image(fileName), resetColor: false);
		}
		return string.Empty;
	}

	public string GetSvgMarkup(string fileName)
	{
		return GetSvgMarkup(fileName, null);
	}

	public ActionResult GetIcon(string fileName, [JsonBinder] IDictionary<string, object> htmlAttributes = null)
	{
		return (ActionResult)(object)((Controller)this).Json((object)GetSvgMarkup(fileName, htmlAttributes), (JsonRequestBehavior)0);
	}

	private static ContentResult GetVectorImage(string content, string format)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		ContentResult val = new ContentResult();
		val.set_ContentType(format);
		val.set_Content(SvgHelper.MergeAttributes(content, new Dictionary<string, string> { { "opacity", "0.65" } }));
		val.set_ContentEncoding(Encoding.UTF8);
		return val;
	}

	private static FileStreamResult GetRasterImage(byte[] data, string format)
	{
		return new FileStreamResult(MemoryHelper.GetMemoryStream(data, writable: false), format);
	}

	private string SvgMarkupFromMetadata(Guid uid, int size, string image)
	{
		return SvgMarkupFromMetadataAllType(uid, size, image, () => GetMetadataImage(uid, image, size));
	}

	private string SvgMarkupFromMetadataEnum(Guid uid, object enumValue, int size, string image)
	{
		return SvgMarkupFromMetadataAllType(uid, size, image, () => GetMetadataImageEnum(uid, enumValue, image, size));
	}

	private string SvgMarkupFromMetadataAllType(Guid uid, int size, string image, Func<MetadataImage> getMetadataImage)
	{
		MetadataImage metadataImage = getMetadataImage();
		if (metadataImage != null)
		{
			if (metadataImage.Format == ImageFormatType.IconPack)
			{
				IconModel icon = IconPackService.GetIcon(metadataImage.ResourceName);
				if (icon != null)
				{
					return SvgHelper.ResetColor(icon.Data);
				}
			}
			return SvgHelper.ResetColor(metadataImage.RawData);
		}
		return string.Empty;
	}

	[AuthenticationFilter(NotRequired = true)]
	[OutputCache(VaryByParam = "id;image;size;useParent", Location = OutputCacheLocation.ServerAndClient, Duration = 10000000)]
	public ActionResult Object(string id, string image = null, int size = 16, bool useParent = false)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		MetadataImage metadataImage = GetMetadataImage(new Guid(id), image, size);
		if (metadataImage == null || metadataImage.Data == null)
		{
			return (ActionResult)new EmptyResult();
		}
		return GetImageFromMetadata(metadataImage);
	}

	public MetadataImage GetMetadataImage(Guid uid, string image, int size)
	{
		return GetMetadataImageAllType(uid, image, size, (NamedMetadata metadata) => MetadataLoader.ParentImage((ClassMetadata)metadata, size));
	}

	public MetadataImage GetMetadataImageEnum(Guid uid, object enumValue, string image, int size)
	{
		return GetMetadataImageAllType(uid, image, size, (NamedMetadata metadata) => ((EnumMetadata)metadata).Values.FirstOrDefault((EnumValueMetadata v) => v.EnumValue != null && v.EnumValue.Equals(enumValue))?.GetImage(size));
	}

	private MetadataImage GetMetadataImageAllType(Guid uid, string image, int size, Func<NamedMetadata, MetadataImage> getMetadataImage)
	{
		Contract.ServiceNotNull(MetadataRuntimeService, "MetadataRuntimeService");
		NamedMetadata namedMetadata = (NamedMetadata)MetadataRuntimeService.GetMetadata(uid);
		if (namedMetadata == null)
		{
			throw new InvalidOperationException(SR.T("Не найдены метаданные объекта с UID={0}", uid));
		}
		MetadataImage metadataImage;
		if (string.IsNullOrWhiteSpace(image))
		{
			metadataImage = namedMetadata.GetImage(size);
			if (metadataImage == null || metadataImage.Data == null)
			{
				metadataImage = getMetadataImage(namedMetadata);
			}
		}
		else
		{
			metadataImage = namedMetadata.GetNamedImage(image);
		}
		return metadataImage;
	}

	[AuthenticationFilter(NotRequired = true)]
	public ActionResult MetadataImage(Guid uid, string image, int size, object htmlAttributes, MetadataImageFormat imageType)
	{
		return MetadataImageAllType(uid, image, size, htmlAttributes, imageType, () => SvgMarkupFromMetadata(uid, size, image));
	}

	[AuthenticationFilter(NotRequired = true)]
	public ActionResult MetadataImageEnum(Guid uid, object enumValue, string image, int size, object htmlAttributes, MetadataImageFormat imageType)
	{
		return MetadataImageAllType(uid, image, size, htmlAttributes, imageType, () => SvgMarkupFromMetadataEnum(uid, enumValue, size, image));
	}

	private ActionResult MetadataImageAllType(Guid uid, string image, int size, object htmlAttributes, MetadataImageFormat imageType, Func<string> getSvgMarkup)
	{
		string text = string.Empty;
		if (imageType == MetadataImageFormat.Markup)
		{
			text = getSvgMarkup();
			if (text.IsNullOrEmpty())
			{
				return MetadataImage(uid, image, size, htmlAttributes, MetadataImageFormat.Image);
			}
		}
		return (ActionResult)(object)((Controller)this).Content(CreateContainer(imageType, text, htmlAttributes, uid, size));
	}

	private string CreateContainer(MetadataImageFormat format, string markup, object htmlAttributes, Guid uid, int size)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		TagBuilder val = new TagBuilder((format == MetadataImageFormat.Image) ? "img" : "i");
		val.get_Attributes()["data-source"] = uid.ToString();
		if (htmlAttributes != null)
		{
			val.MergeAttributes<string, object>((IDictionary<string, object>)new RouteValueDictionary(htmlAttributes));
		}
		val.AddCssClass("svg-element");
		if (format == MetadataImageFormat.Image)
		{
			val.get_Attributes()["src"] = $"/SDK.Action/Images/Object/{uid}?size={size}";
		}
		else
		{
			val.set_InnerHtml(markup);
		}
		return ((object)val).ToString();
	}

	[AuthenticationFilter(NotRequired = true)]
	[OutputCache(VaryByParam = "id;typeUid;image;size", Location = OutputCacheLocation.ServerAndClient, Duration = 10000000)]
	public ActionResult Form(string id, string typeUid, string image, int size = 16)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		Contract.ServiceNotNull(MetadataRuntimeService, "MetadataRuntimeService");
		Guid descriptorUid = new Guid(id);
		Guid metadataType = new Guid(typeUid);
		FormDescriptor descriptor = Locator.GetServiceNotNull<FormDescriptorProvider>().GetDescriptor(metadataType, descriptorUid);
		if (descriptor == null)
		{
			return (ActionResult)new EmptyResult();
		}
		MetadataImage namedImage = descriptor.Metadata.GetNamedImage(image);
		if (namedImage == null || namedImage.Data == null)
		{
			return (ActionResult)new EmptyResult();
		}
		return GetImageFromMetadata(namedImage);
	}

	[AuthenticationFilter(NotRequired = true)]
	[OutputCache(VaryByParam = "id;size;valueid", Location = OutputCacheLocation.ServerAndClient, Duration = 10000000)]
	public ActionResult EnumObject(string id, string valueid, int size = 16)
	{
		Contract.ServiceNotNull(MetadataRuntimeService, "MetadataRuntimeService");
		Guid guid = new Guid(id);
		EnumMetadata enumMetadata = (EnumMetadata)MetadataRuntimeService.GetMetadata(guid);
		if (enumMetadata == null)
		{
			throw new InvalidOperationException(SR.T("Не найдены метаданные объекта с UID={0}", guid));
		}
		EnumValueMetadata enumValueMetadata = enumMetadata.Values.FirstOrDefault((EnumValueMetadata b) => b.Uid == new Guid(valueid));
		if (enumValueMetadata == null)
		{
			throw new InvalidOperationException(SR.T("Не найдены метаданные объекта с UID={0}", guid));
		}
		MetadataImage image = enumValueMetadata.GetImage(size);
		return GetImageFromMetadata(image);
	}

	[AuthenticationFilter(NotRequired = true)]
	[OutputCache(VaryByParam = "id;size;format", Location = OutputCacheLocation.ServerAndClient, Duration = 10000000)]
	public ActionResult AuditObject(string id, int size = 16, string format = null)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		Contract.ServiceNotNull(AuditManager, "AuditManager");
		Guid uid = new Guid(id);
		IAuditObject @object = AuditManager.GetObject(uid);
		if (@object == null || @object.MetadataImage == null || @object.MetadataImage.Data == null)
		{
			return (ActionResult)new EmptyResult();
		}
		MetadataImage image = @object.GetImage(size);
		if (!(format == "png"))
		{
			if (format == "svg")
			{
				image.Format = ImageFormatType.Svg;
			}
		}
		else
		{
			image.Format = ImageFormatType.Png;
		}
		return GetImageFromMetadata(image);
	}

	[AuthenticationFilter(NotRequired = true)]
	[OutputCache(VaryByParam = "actionId;size;objectId", Location = OutputCacheLocation.ServerAndClient, Duration = 10000000)]
	public ActionResult AuditAction(string actionId, string objectId, int size = 16)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		Contract.ServiceNotNull(AuditManager, "AuditManager");
		Guid uid = new Guid(actionId);
		IAuditAction auditAction = null;
		if (!string.IsNullOrEmpty(objectId))
		{
			Guid uid2 = new Guid(objectId);
			IAuditObject @object = AuditManager.GetObject(uid2);
			if (@object == null)
			{
				return (ActionResult)new EmptyResult();
			}
			auditAction = AuditManager.GetAction(@object, uid);
		}
		else
		{
			auditAction = AuditManager.GetAction(uid);
		}
		if (auditAction == null || auditAction.MetadataImage == null || auditAction.MetadataImage.Data == null)
		{
			return (ActionResult)new EmptyResult();
		}
		return GetImageFromMetadata(auditAction.MetadataImage);
	}

	[AuthenticationFilter(NotRequired = true)]
	[OutputCache(VaryByParam = "id;size;format", Location = OutputCacheLocation.ServerAndClient, Duration = 10000000)]
	public ActionResult AgentAuditAction(string id, int size = 16, string format = null)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		Contract.ServiceNotNull(AuditManager, "AuditManager");
		Guid uid = new Guid(id);
		IAuditAction action = AuditManager.GetAction(uid);
		if (action == null || action.MetadataImage == null || action.MetadataImage.Data == null)
		{
			return (ActionResult)new EmptyResult();
		}
		action.MetadataImage.Format = ImageFormatType.Png;
		return GetImageFromMetadata(action.MetadataImage);
	}

	[AuthenticationFilter(NotRequired = true)]
	[OutputCache(VaryByParam = "componentId;version", Location = OutputCacheLocation.ServerAndClient, Duration = 10000000)]
	public ActionResult StoreComponent(string componentId, string version)
	{
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		Contract.ServiceNotNull(PackageService, "PackageService");
		Func<IStoreComponentInfo, string> imagePathFunc = delegate(IStoreComponentInfo componentsInfo)
		{
			if (componentsInfo == null)
			{
				return null;
			}
			return (componentsInfo.ImagePath != null) ? componentsInfo.ImagePath : (componentsInfo.Type switch
			{
				ManifestComponentType.Application => "~/Content/IconPack/apps.svg", 
				ManifestComponentType.Solution => "~/Content/IconPack/solution.svg", 
				ManifestComponentType.MobileApplication => "~/Content/IconPack/apps.svg", 
				ManifestComponentType.ProcessPackage => "~/Content/IconPack/workflow_doc.svg", 
				ManifestComponentType.Process => "~/Content/IconPack/process.svg", 
				ManifestComponentType.ExternalApplication => "~/Content/IconPack/apps.svg", 
				ManifestComponentType.Report => "~/Content/IconPack/report.svg", 
				ManifestComponentType.Platform => null, 
				_ => "~/Content/IconPack/modules.svg", 
			});
		};
		Func<string, string, string> keyFunc = (string i, string v) => i + " " + v;
		Func<IStoreComponentInfo, string> versionFunc = delegate(IStoreComponentInfo c)
		{
			SemanticVersion val = (c.IsInstalled ? c.InstalledVersion : c.LastVersion);
			return (!(val != (SemanticVersion)null)) ? "" : ((object)val).ToString();
		};
		if (_storeComponentImagePaths == null)
		{
			lock (StoreComponentImagePathsLocker)
			{
				if (_storeComponentImagePaths == null)
				{
					_storeComponentImagePaths = PackageService.GetStoreComponentsInfo(forRuntime: true).ToConcurrentDictionary((IStoreComponentInfo c) => keyFunc(c.Id, versionFunc(c)), imagePathFunc);
				}
			}
		}
		string orAdd = _storeComponentImagePaths.GetOrAdd(keyFunc(componentId, version), (string i) => imagePathFunc(PackageService.GetStoreComponentsInfo(forRuntime: true).FirstOrDefault((IStoreComponentInfo c) => c.Id == componentId && versionFunc(c) == (version ?? ""))));
		if (orAdd == null)
		{
			return (ActionResult)new EmptyResult();
		}
		if (IconPack.HasSvgExtension(orAdd))
		{
			return (ActionResult)(object)GetVectorImage(SvgService.GetContent(orAdd, resetColor: false), "image/svg+xml");
		}
		Stream stream;
		if (orAdd.StartsWith("~"))
		{
			stream = HostingEnvironment.VirtualPathProvider.GetFile(orAdd).Open();
		}
		else
		{
			using (Image image = Image.FromFile(orAdd))
			{
				stream = MemoryHelper.GetMemoryStream();
				image.Save(stream, ImageFormat.Png);
			}
			stream.Seek(0L, SeekOrigin.Begin);
		}
		return (ActionResult)(object)new FileStreamResult(stream, "image/png");
	}

	[HttpPost]
	public ActionResult UploadImageAjax([ModelBinder(typeof(XhrHttpPostedFileBinder))] HttpPostedFileBase qqfile)
	{
		CachFileUploadInfo cachFileUploadInfo = BinaryFilesController.UploadAjax(qqfile, ((ControllerBase)this).get_ControllerContext());
		if (!cachFileUploadInfo.UploadComplete)
		{
			return (ActionResult)(object)((Controller)this).Content(cachFileUploadInfo.JsonData);
		}
		var anon = new
		{
			success = false,
			uid = Guid.Empty,
			fileHref = "",
			fileSize = 0L,
			fileHash = 0u
		};
		var anon2 = JsonConvert.DeserializeAnonymousType(cachFileUploadInfo.JsonData, anon);
		Guid uid = anon2.uid;
		string fileHref = anon2.fileHref;
		long fileSize = anon2.fileSize;
		uint fileHash = anon2.fileHash;
		int width = 0;
		int height = 0;
		bool flag = false;
		using (Image image = Image.FromFile(base.CacheFilesService.GetFilePath(uid)))
		{
			width = image.Width;
			height = image.Height;
			flag = image.RawFormat.Guid == ImageFormat.Gif.Guid && image.GetFrameCount(FrameDimension.Time) > 1;
			if (flag && fileSize > 1048576)
			{
				return (ActionResult)(object)((Controller)this).Content(JsonConvert.SerializeObject((object)new
				{
					success = false,
					message = SR.T("Поддерживаются анимированные изображения размером до {0} МБ", 1)
				}));
			}
		}
		return (ActionResult)(object)((Controller)this).Content(JsonConvert.SerializeObject((object)new
		{
			success = true,
			uid = uid,
			fileHref = fileHref,
			fileSize = fileSize,
			fileHash = fileHash,
			width = width,
			height = height,
			animated = flag
		}));
	}

	[HttpPost]
	public JsonResult CropImageAjax(Guid id, int x, int y, int width, int height)
	{
		try
		{
			string filePath = base.CacheFilesService.GetFilePath(id);
			Bitmap bitmap = new Bitmap(filePath);
			ImageFormat rawFormat = bitmap.RawFormat;
			int num = Math.Min(width, height);
			Bitmap bitmap2 = CropImage(bitmap, x, y, num, num);
			Bitmap bitmap3 = ResizeImage(bitmap2, 340, 340, preserveAspectRatio: false);
			if (bitmap2 != bitmap && bitmap2 != bitmap3)
			{
				bitmap2.Dispose();
			}
			if (bitmap3 != bitmap)
			{
				bitmap.Dispose();
				System.IO.File.Delete(filePath);
				bitmap3.Save(filePath, rawFormat);
				bitmap3.Dispose();
			}
			else
			{
				bitmap.Dispose();
			}
			uint crcValue = Crc32.GetCrcValue(filePath);
			string fileName = base.CacheFilesService.GetFileName(id);
			long length = new FileInfo(filePath).Length;
			return ((Controller)this).Json((object)new
			{
				success = true,
				uid = id,
				fileName = fileName,
				fileSize = length,
				fileHash = crcValue
			});
		}
		catch (Exception ex)
		{
			return ((Controller)this).Json((object)new
			{
				success = false,
				message = ex.Message
			});
		}
	}

	protected Bitmap CropImage(Bitmap image, int x, int y, int width, int height)
	{
		if (x < 0)
		{
			x = 0;
		}
		if (y < 0)
		{
			y = 0;
		}
		if (x > image.Width - 1)
		{
			x = image.Width - 1;
		}
		if (y > image.Height - 1)
		{
			y = image.Height - 1;
		}
		if (width > image.Width)
		{
			width = image.Width;
		}
		if (height > image.Height)
		{
			height = image.Height;
		}
		if (width != image.Width || height != image.Height || x != 0 || y != 0)
		{
			return image.Clone(new Rectangle(x, y, width, height), image.PixelFormat);
		}
		return image;
	}

	protected Bitmap ResizeImage(Bitmap image, int width, int height, bool preserveAspectRatio)
	{
		if (image.Width <= 340)
		{
			return image;
		}
		if (preserveAspectRatio)
		{
			int width2 = image.Width;
			int height2 = image.Height;
			float num = (float)width / (float)width2;
			float num2 = (float)height / (float)height2;
			float num3 = ((num2 < num) ? num2 : num);
			width = (int)((float)width2 * num3);
			height = (int)((float)height2 * num3);
		}
		Bitmap bitmap = new Bitmap(width, height);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.SmoothingMode = SmoothingMode.AntiAlias;
		graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics.DrawImage(image, new Rectangle(0, 0, width, height));
		graphics.Dispose();
		return bitmap;
	}
}
