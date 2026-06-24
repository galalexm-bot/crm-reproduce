using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Globalization;

public abstract class BaseLocalizationFileResolver : ILocalizationFileResolver
{
	private static BaseLocalizationFileResolver YnktLUGox97ofNHvIyhZ;

	public abstract string FileName { get; }

	public abstract IEnumerable<PoLineDescriptor> CollectResources(LocalizationLoadSettings settings);

	protected virtual EntityMetadata LoadOrNullMetadata(Guid uid)
	{
		//Discarded unreachable code: IL_007c, IL_00af, IL_00f7
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass3_.metadata = null;
				num2 = 4;
				break;
			case 3:
				return _003C_003Ec__DisplayClass3_.metadata;
			case 4:
				try
				{
					SR.RunWithCulture((CultureInfo)jrQl5WGoyhQZe6HhCEKG(), _003C_003Ec__DisplayClass3_._003CLoadOrNullMetadata_003Eb__0);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception ex)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							ECuDeBGo9Zi43hEDMTtm(ne0Y0GGoMnii35RUWuEV(), xp0uVmGoJOZt3GsK8Ma4(ex), ex);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				goto case 3;
			case 1:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass3_.uid = uid;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected virtual EnumMetadata LoadOrNullEnumMetadata(Guid uid)
	{
		//Discarded unreachable code: IL_0095, IL_00c8, IL_0110, IL_011f
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass4_.uid = uid;
				num2 = 2;
				continue;
			case 4:
				_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				continue;
			default:
				try
				{
					sTdDnRGodpWd6iREdFMR(jrQl5WGoyhQZe6HhCEKG(), new Action(_003C_003Ec__DisplayClass4_._003CLoadOrNullEnumMetadata_003Eb__0));
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							ECuDeBGo9Zi43hEDMTtm(ne0Y0GGoMnii35RUWuEV(), xp0uVmGoJOZt3GsK8Ma4(ex), ex);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
							{
								num4 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass4_.metadata = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				break;
			}
			break;
		}
		return _003C_003Ec__DisplayClass4_.metadata;
	}

	protected virtual void GetFromEnum(EnumMetadata metadata, List<PoLineDescriptor> res)
	{
		if (metadata == null)
		{
			return;
		}
		AddWithCheck(res, metadata.DisplayName);
		AddWithCheck(res, metadata.Description);
		foreach (EnumValueMetadata value in metadata.Values)
		{
			AddWithCheck(res, value.DisplayName);
			AddWithCheck(res, value.Description);
		}
	}

	protected virtual void GetFromMetadata(EntityMetadata metadata, List<PoLineDescriptor> res)
	{
		if (metadata == null)
		{
			return;
		}
		AddWithCheck(res, metadata.DisplayName);
		AddWithCheck(res, metadata.Description);
		foreach (IPropertyMetadata propertiesAndTablePart in metadata.GetPropertiesAndTableParts())
		{
			AddWithCheck(res, propertiesAndTablePart.DisplayName);
			AddWithCheck(res, propertiesAndTablePart.Description);
			GetFromPropertyType(propertiesAndTablePart as PropertyMetadata, res);
			if (propertiesAndTablePart is TablePartMetadata metadata2)
			{
				GetFromMetadata(metadata2, res);
			}
		}
		foreach (EntityPropertyMetadata item in (IEnumerable<EntityPropertyMetadata>)metadata.EntityProperties)
		{
			AddWithCheck(res, item.DisplayName);
			AddWithCheck(res, item.Description);
			GetFromPropertyType(item, res);
		}
		foreach (TablePartMetadata item2 in (IEnumerable<TablePartMetadata>)metadata.EntityTableParts)
		{
			AddWithCheck(res, item2.DisplayName);
			AddWithCheck(res, item2.Description);
			GetFromMetadata(item2, res);
		}
		if (metadata.Forms == null)
		{
			return;
		}
		foreach (FormViewItem form in metadata.GetForms())
		{
			string[] keys = form.GetLocalizableStrings().ToArray();
			AddWithCheck(res, keys);
		}
	}

	protected virtual void GetFromPropertyType(PropertyMetadata propertyMetadata, List<PoLineDescriptor> res)
	{
		if (propertyMetadata != null && Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeDescriptor(propertyMetadata.TypeUid, propertyMetadata.SubTypeUid) is ILocalizableType localizableType)
		{
			string[] keys = localizableType.GetLocalizableStrings(propertyMetadata).ToArray();
			AddWithCheck(res, keys);
		}
	}

	protected virtual void AddWithCheck(List<PoLineDescriptor> res, params string[] keys)
	{
		foreach (string key in keys)
		{
			PoLineDescriptor line = new PoLineDescriptor
			{
				Key = key
			};
			AddWithCheck(res, line);
		}
	}

	protected virtual void AddWithCheck(List<PoLineDescriptor> res, PoLineDescriptor line)
	{
		_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
		CS_0024_003C_003E8__locals0.line = line;
		if (!string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals0.line.Key) && res.All((PoLineDescriptor r) => !_003C_003Ec__DisplayClass9_0.wS4pbbvl68Ms4CK0L9Al(_003C_003Ec__DisplayClass9_0.rahKYNvl4sdNCQRhCWI5(r), _003C_003Ec__DisplayClass9_0.rahKYNvl4sdNCQRhCWI5(CS_0024_003C_003E8__locals0.line), StringComparison.Ordinal)))
		{
			res.Add(CS_0024_003C_003E8__locals0.line);
		}
	}

	protected BaseLocalizationFileResolver()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		hM7DRyGolQ2fRp5ANA3Y();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object jrQl5WGoyhQZe6HhCEKG()
	{
		return SR.KeyCultureInfo;
	}

	internal static object ne0Y0GGoMnii35RUWuEV()
	{
		return Logger.Log;
	}

	internal static object xp0uVmGoJOZt3GsK8Ma4(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void ECuDeBGo9Zi43hEDMTtm(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static bool UNjeE2Go0NelNd8LxV3V()
	{
		return YnktLUGox97ofNHvIyhZ == null;
	}

	internal static BaseLocalizationFileResolver KA6cyJGomHLvqvAxpqiY()
	{
		return YnktLUGox97ofNHvIyhZ;
	}

	internal static void sTdDnRGodpWd6iREdFMR(object P_0, object P_1)
	{
		SR.RunWithCulture((CultureInfo)P_0, (Action)P_1);
	}

	internal static void hM7DRyGolQ2fRp5ANA3Y()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
