using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace EleWise.ELMA.Packaging.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				resourceMan = new ResourceManager("EleWise.ELMA.Packaging.Properties.Resources", typeof(Resources).Assembly);
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap Application => (Bitmap)ResourceManager.GetObject("Application", resourceCulture);

	internal static Bitmap BPM => (Bitmap)ResourceManager.GetObject("BPM", resourceCulture);

	internal static byte[] elma_root => (byte[])ResourceManager.GetObject("elma_root", resourceCulture);

	internal static Bitmap ExternalApplication => (Bitmap)ResourceManager.GetObject("ExternalApplication", resourceCulture);

	internal static Bitmap MobileApplication => (Bitmap)ResourceManager.GetObject("MobileApplication", resourceCulture);

	internal static Bitmap Module => (Bitmap)ResourceManager.GetObject("Module", resourceCulture);

	internal static Bitmap Platform => (Bitmap)ResourceManager.GetObject("Platform", resourceCulture);

	internal static Bitmap ProcessPackage => (Bitmap)ResourceManager.GetObject("ProcessPackage", resourceCulture);

	internal static Bitmap Report => (Bitmap)ResourceManager.GetObject("Report", resourceCulture);

	internal static Bitmap Solution => (Bitmap)ResourceManager.GetObject("Solution", resourceCulture);

	internal Resources()
	{
	}
}
