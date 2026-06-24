using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace EleWise.ELMA.KPI.Common.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resource
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
				resourceMan = new ResourceManager("EleWise.ELMA.KPI.Common.Properties.Resource", typeof(Resource).Assembly);
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

	internal static Bitmap Increase => (Bitmap)ResourceManager.GetObject("Increase", resourceCulture);

	internal static Bitmap MaxByPlan => (Bitmap)ResourceManager.GetObject("MaxByPlan", resourceCulture);

	internal static Bitmap MinByPlan => (Bitmap)ResourceManager.GetObject("MinByPlan", resourceCulture);

	internal static Bitmap Reduction => (Bitmap)ResourceManager.GetObject("Reduction", resourceCulture);

	internal static Bitmap Stable => (Bitmap)ResourceManager.GetObject("Stable", resourceCulture);

	internal Resource()
	{
	}
}
