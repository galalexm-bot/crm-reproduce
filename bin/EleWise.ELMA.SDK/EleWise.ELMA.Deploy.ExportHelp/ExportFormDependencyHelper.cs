using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.ExportHelper;

public static class ExportFormDependencyHelper
{
	internal static readonly string ObjectFormsPrefix;

	internal static readonly string FormDependencyPrefix;

	internal static readonly string FormDependencyDisplayName;

	private static ExportFormDependencyHelper UvnAkwEaLNEu6JB5dDdt;

	public static void AddFormDependenciesInfo(Guid uid, string displayName, Dictionary<string, object> serviceData)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals0.uid = uid;
		IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
		using (IEnumerator<IFormDependencyData> enumerator = FormDependencyHelper.LoadByDependObjectUid(CS_0024_003C_003E8__locals0.uid).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass3_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass3_1();
				CS_0024_003C_003E8__locals1.dep = enumerator.Current;
				Type typeByUidOrNull = serviceNotNull.GetTypeByUidOrNull(CS_0024_003C_003E8__locals1.dep.UsesObjectUid, loadImplementation: false);
				bool flag = false;
				if (typeByUidOrNull != null && serviceNotNull.GetMetadata(CS_0024_003C_003E8__locals1.dep.UsesObjectUid, loadImplementation: false) is EntityMetadata entityMetadata)
				{
					flag = entityMetadata.Forms.Any((FormViewItem q) => q.Uid == _003C_003Ec__DisplayClass3_1.TV8L9f82q8NIyj7uIcJS(CS_0024_003C_003E8__locals1.dep));
				}
				if (flag || typeByUidOrNull == null)
				{
					string key = string.Join(FormDependencyHelper.KeySplitter, FormDependencyPrefix, CS_0024_003C_003E8__locals1.dep.GenerateDependInfo());
					if (!serviceData.ContainsKey(key))
					{
						serviceData.Add(key, CS_0024_003C_003E8__locals1.dep.GenerateUsesInfo());
					}
					string key2 = string.Join(FormDependencyHelper.KeySplitter, FormDependencyDisplayName, CS_0024_003C_003E8__locals1.dep.GenerateDependInfo());
					if (!serviceData.ContainsKey(key2))
					{
						serviceData.Add(key2, displayName);
					}
				}
			}
		}
		IFormDependencyExtension formDependencyExtension = ComponentManager.Current.GetExtensionPoints<IFormDependencyExtension>().FirstOrDefault((IFormDependencyExtension q) => _003C_003Ec__DisplayClass3_0.YxJSsH82Is5boggvocVd(q, CS_0024_003C_003E8__locals0.uid));
		if (formDependencyExtension == null)
		{
			return;
		}
		List<Guid> list = formDependencyExtension.GetFormUids(CS_0024_003C_003E8__locals0.uid).ToList();
		if (list.Count != 0)
		{
			string key3 = string.Join(FormDependencyHelper.KeySplitter, ObjectFormsPrefix, CS_0024_003C_003E8__locals0.uid);
			if (!serviceData.ContainsKey(key3))
			{
				serviceData.Add(key3, string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -671855227), list));
			}
		}
	}

	static ExportFormDependencyHelper()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				ObjectFormsPrefix = (string)yrVE7QEazeDndxBi0cGM(-16752921 ^ -16459615);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				yh5MtCEacaRcR5AB3Zql();
				num2 = 3;
				break;
			default:
				FormDependencyPrefix = (string)yrVE7QEazeDndxBi0cGM(0x5F3078B6 ^ 0x5F34FED6);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				FormDependencyDisplayName = (string)yrVE7QEazeDndxBi0cGM(0x637E299B ^ 0x637AAF1B);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	internal static void yh5MtCEacaRcR5AB3Zql()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object yrVE7QEazeDndxBi0cGM(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool xqQx1aEaUY8hOuFJ663P()
	{
		return UvnAkwEaLNEu6JB5dDdt == null;
	}

	internal static ExportFormDependencyHelper cK1fsNEas9hdJYaT7WZB()
	{
		return UvnAkwEaLNEu6JB5dDdt;
	}
}
