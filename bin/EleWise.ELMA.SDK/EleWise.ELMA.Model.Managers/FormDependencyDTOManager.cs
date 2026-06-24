using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.UI.DTO.Managers;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Managers;

public class FormDependencyDTOManager : DTOManager, IFormDependencyDTOManager, IConfigurationService
{
	private readonly IFormMetadataItemHeaderDTOManager formMetadataItemHeaderDtoManager;

	internal static FormDependencyDTOManager AGclduhGiOCcFHobVOSw;

	public FormDependencyDTOManager(IFormMetadataItemHeaderDTOManager formMetadataItemHeaderDtoManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oCYdH8hGKVFvjBIPtmgv();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.formMetadataItemHeaderDtoManager = formMetadataItemHeaderDtoManager;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
			{
				num = 1;
			}
		}
	}

	public virtual IEnumerable<IFormDependencyData> LoadByDependObjectUid(Guid uid)
	{
		return FormDependencyHelper.LoadByDependObjectUid(uid).ToList();
	}

	public virtual IEnumerable<IFormDependencyData> LoadByBaseUids(IEnumerable<Guid> baseUids)
	{
		return FormDependencyHelper.LoadByBaseUids(baseUids).ToList();
	}

	public virtual IEnumerable<IFormDependencyData> LoadByUsesObjectUid(Guid uid)
	{
		return FormDependencyHelper.LoadByUsesObjectUid(uid);
	}

	public virtual string GetInterfaceFormDisplayInfo(Guid objectUid, Guid formUid)
	{
		return (string)R9AfQwhGn4urQMJRLF2t(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787474209), (objectUid == PageMetadata.TypeUid) ? vwQFj2hGTsqaRE2ySnrx(Vd176khGXypaEVYiU7Mm(-1867198571 ^ -1866995317)) : SR.T((string)Vd176khGXypaEVYiU7Mm(-643786247 ^ -643579915)), hyW3QlhGkLtk3uKeqjx0(formMetadataItemHeaderDtoManager, formUid));
	}

	internal static void oCYdH8hGKVFvjBIPtmgv()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Mb0JeIhGRQcXLvlB47Zm()
	{
		return AGclduhGiOCcFHobVOSw == null;
	}

	internal static FormDependencyDTOManager l2I4IEhGq46JmynukyDi()
	{
		return AGclduhGiOCcFHobVOSw;
	}

	internal static object Vd176khGXypaEVYiU7Mm(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object vwQFj2hGTsqaRE2ySnrx(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object hyW3QlhGkLtk3uKeqjx0(object P_0, Guid uid)
	{
		return ((IFormMetadataItemHeaderDTOManager)P_0).GetDisplayName(uid);
	}

	internal static object R9AfQwhGn4urQMJRLF2t(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}
}
