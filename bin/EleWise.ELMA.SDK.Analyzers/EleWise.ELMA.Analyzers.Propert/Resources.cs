using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace EleWise.ELMA.Analyzers.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
				resourceMan = new ResourceManager("EleWise.ELMA.Analyzers.Properties.Resources", typeof(Resources).Assembly);
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

	internal static string ELMA9001_description => ResourceManager.GetString("ELMA9001_description", resourceCulture);

	internal static string ELMA9001_messageFormat => ResourceManager.GetString("ELMA9001_messageFormat", resourceCulture);

	internal static string ELMA9001_title => ResourceManager.GetString("ELMA9001_title", resourceCulture);

	internal static string ELMA9002_description => ResourceManager.GetString("ELMA9002_description", resourceCulture);

	internal static string ELMA9002_messageFormat => ResourceManager.GetString("ELMA9002_messageFormat", resourceCulture);

	internal static string ELMA9002_title => ResourceManager.GetString("ELMA9002_title", resourceCulture);

	internal static string ELMAAsyncVoid_messageFormat => ResourceManager.GetString("ELMAAsyncVoid_messageFormat", resourceCulture);

	internal static string ELMAAsyncVoid_title => ResourceManager.GetString("ELMAAsyncVoid_title", resourceCulture);

	internal Resources()
	{
	}
}
