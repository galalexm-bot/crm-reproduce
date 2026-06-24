using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

internal static class FunctionMetadataHelper
{
	internal const string AssemblyPrefix = "__FunctionAssembly__";

	internal const string FunctionCode = "FunctionCode";

	internal const string Executor = "Executor";

	internal const string MethodName = "Execute";

	private static FunctionMetadataHelper g9k2jpb14PfccHfFADaj;

	internal static string ExecutorTypeName(FunctionMetadata metadata)
	{
		return metadata.Namespace + (string)jmQXcRb1AhoSZ2G38tja(-1123633026 ^ -1123638598) + (string)Ww8F1Sb17LGFNTyessp4(metadata);
	}

	internal static string ExecutorName(FunctionMetadata metadata)
	{
		return (string)hxswXlb1xJs5qWCJJM3S(metadata) + (string)jmQXcRb1AhoSZ2G38tja(0x7EC153F ^ 0x7EEF0E3);
	}

	internal static string ServerAssemblyName(FunctionMetadata metadata)
	{
		return (string)Wwjbbqb1mi25nyFR9HUZ(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x313084F6), UgCZ0ab10CklsCMI0dA0(metadata), jmQXcRb1AhoSZ2G38tja(0x637E299B ^ 0x637E335F), metadata.Name);
	}

	internal static object jmQXcRb1AhoSZ2G38tja(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Ww8F1Sb17LGFNTyessp4(object P_0)
	{
		return ExecutorName((FunctionMetadata)P_0);
	}

	internal static bool dAObZbb16C2xESQtdjxH()
	{
		return g9k2jpb14PfccHfFADaj == null;
	}

	internal static FunctionMetadataHelper onwJvbb1HngYlWXU7IDr()
	{
		return g9k2jpb14PfccHfFADaj;
	}

	internal static object hxswXlb1xJs5qWCJJM3S(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object UgCZ0ab10CklsCMI0dA0(object P_0)
	{
		return ((FunctionMetadata)P_0).Namespace;
	}

	internal static object Wwjbbqb1mi25nyFR9HUZ(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}
}
