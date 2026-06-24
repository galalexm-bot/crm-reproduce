using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Extensions;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts;

internal static class ReferencesListHelper
{
	private static ReferencesListHelper qVicLobuFgW2DpXZg29U;

	internal static ElmaReferencesList ParseElmaReferenceString(string referenceString)
	{
		int num = 1;
		int num2 = num;
		bool marker = default(bool);
		IEnumerable<string> references = default(IEnumerable<string>);
		while (true)
		{
			string text;
			switch (num2)
			{
			case 3:
				return new ElmaReferencesList(marker, references);
			case 2:
			{
				object obj = j2qky4buoUdG5qAA1QPo(referenceString);
				marker = ((IEnumerable<string>)obj).Contains((string)lp92CububYEX4wBBZFMe(-812025778 ^ -811872308));
				references = FilterOutMarkers((IEnumerable<string>)obj);
				num2 = 3;
				continue;
			}
			case 1:
				text = referenceString;
				if (text == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				text = string.Empty;
				break;
			}
			referenceString = text;
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
			{
				num2 = 0;
			}
		}
	}

	internal static IEnumerable<string> GetReferences(string referenceString)
	{
		referenceString = referenceString ?? string.Empty;
		return from x in SplitReferences(referenceString)
			select (string)_003C_003Ec.byyLlUCerglbEZtTJ99u(x);
	}

	internal static IEnumerable<string> GetElmaReferences(string referenceString)
	{
		referenceString = referenceString ?? string.Empty;
		return FilterOutMarkers(GetReferences(referenceString));
	}

	internal static string StringifyReferences(IEnumerable<string> references)
	{
		return string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146490369), references.OrderBy((string x) => (string)_003C_003Ec.LtoOBBCeg7sII6PWogSK(x)));
	}

	internal static string StringifyElmaReferences(ElmaReferencesList elmaReferencesList)
	{
		return StringifyReferences(Enumerable.Empty<string>().If(vsIs7ybuhpRZImt836fJ(elmaReferencesList), (IEnumerable<string> c) => c.Concat(new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F32CF34) })).Union(elmaReferencesList.References));
	}

	private static string[] SplitReferences(object referencesString)
	{
		return (string[])zdHfwCbuEDsZ5BF6f1ej(referencesString, UyqBxTbuGKpKoaUMoXgo(lp92CububYEX4wBBZFMe(0x1DE3DD89 ^ 0x1DE38955)), StringSplitOptions.RemoveEmptyEntries);
	}

	private static IEnumerable<string> FilterOutMarkers(IEnumerable<string> collection)
	{
		return collection.Where((string x) => !_003C_003Ec.ERWoSTCejx4u8ZfyqIrd(x, _003C_003Ec.GqmwFoCe5QjXVuLfw8jm(-1334993905 ^ -1335347817)));
	}

	internal static object j2qky4buoUdG5qAA1QPo(object P_0)
	{
		return SplitReferences(P_0);
	}

	internal static object lp92CububYEX4wBBZFMe(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool jBLux6buB3GwZqXjMqLj()
	{
		return qVicLobuFgW2DpXZg29U == null;
	}

	internal static ReferencesListHelper i1KSUUbuWBadWmKVTUK6()
	{
		return qVicLobuFgW2DpXZg29U;
	}

	internal static bool vsIs7ybuhpRZImt836fJ(object P_0)
	{
		return ((ElmaReferencesList)P_0).AllReferencesMarker;
	}

	internal static object UyqBxTbuGKpKoaUMoXgo(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object zdHfwCbuEDsZ5BF6f1ej(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((char[])P_1, P_2);
	}
}
