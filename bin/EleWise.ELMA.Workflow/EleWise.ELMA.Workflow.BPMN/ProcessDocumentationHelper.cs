using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN;

public static class ProcessDocumentationHelper
{
	internal static ProcessDocumentationHelper ULjO2ZOAObl0MmhRts9b;

	public static EntityPropertyMetadata GetEntityProperty(IEnumerable<EntityPropertyMetadata> entityProperties, IEnumerable<TablePartMetadata> tableParts, Guid propertyUid, ref int padding)
	{
		_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
		CS_0024_003C_003E8__locals0.propertyUid = propertyUid;
		EntityPropertyMetadata entityPropertyMetadata = entityProperties.FirstOrDefault((EntityPropertyMetadata p) => _003C_003Ec__DisplayClass0_0.aS37m6vJSQKt1ND2hjJU(_003C_003Ec__DisplayClass0_0.gZwKIbvJxUhvbb0ILjeP(p), CS_0024_003C_003E8__locals0.propertyUid));
		if (entityPropertyMetadata != null)
		{
			return entityPropertyMetadata;
		}
		foreach (TablePartMetadata tablePart in tableParts)
		{
			padding += 10;
			entityPropertyMetadata = GetEntityProperty((IEnumerable<EntityPropertyMetadata>)tablePart.EntityProperties, (IEnumerable<TablePartMetadata>)tablePart.EntityTableParts, CS_0024_003C_003E8__locals0.propertyUid, ref padding);
			if (entityPropertyMetadata != null)
			{
				return entityPropertyMetadata;
			}
		}
		padding = 0;
		return null;
	}

	public static TablePartMetadata GetTablePart(IEnumerable<TablePartMetadata> tableParts, Guid propertyUid, ref int padding)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.propertyUid = propertyUid;
		List<TablePartMetadata> list = tableParts.ToList();
		TablePartMetadata tablePartMetadata = list.Find((TablePartMetadata p) => _003C_003Ec__DisplayClass1_0.Ts13fNvJ4II1h6lJbUC8(p) == CS_0024_003C_003E8__locals0.propertyUid);
		if (tablePartMetadata != null)
		{
			return tablePartMetadata;
		}
		foreach (TablePartMetadata item in list)
		{
			padding += 10;
			tablePartMetadata = GetTablePart((IEnumerable<TablePartMetadata>)item.EntityTableParts, CS_0024_003C_003E8__locals0.propertyUid, ref padding);
			if (tablePartMetadata != null)
			{
				return tablePartMetadata;
			}
		}
		padding = 0;
		return null;
	}

	public static void GetParentsContext(IWorkflowProcess wp, List<ProcessContext> contexts, bool thisContext)
	{
		if (wp.Parent != null)
		{
			GetParentsContext(wp.Parent, contexts, thisContext: true);
		}
		if (thisContext)
		{
			contexts.Add(wp.Context);
		}
	}

	public static string GetPropertyType(IPropertyMetadata property)
	{
		//Discarded unreachable code: IL_0094, IL_00a3, IL_0145, IL_0177, IL_01c9, IL_01d8
		int num = 7;
		int num2 = num;
		string text = default(string);
		object obj = default(object);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return text;
			case 1:
				if (obj is TablePartMetadata)
				{
					num2 = 8;
					continue;
				}
				return (string)bXLpn8OA0Jxo1ZvYrTnT(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1EA50FCC ^ 0x1EA7546E));
			case 8:
				text = (string)bXLpn8OA0Jxo1ZvYrTnT(yWMxquOAll4FOTUindh5(-1214182792 ^ -1214041260));
				num2 = 9;
				continue;
			case 2:
				if (obj != null)
				{
					num2 = 4;
					continue;
				}
				goto case 5;
			case 5:
				obj = g98lwlOAJ2eu1oV7knKL(Qui7jQOAYyHabvf1J2x6(property), true, true);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
				{
					num2 = 0;
				}
				continue;
			case 9:
				return text;
			case 4:
				if (obj is IPropertyTypeInfo)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 3;
			case 7:
				text = null;
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
				{
					num2 = 6;
				}
				continue;
			case 6:
				obj = rJs1h8OAsQyuCF9Uj8KC(Locator.GetServiceNotNull<IMetadataRuntimeService>(), Qui7jQOAYyHabvf1J2x6(property), JY0QbPOA8DZdZKZPgaKF(property));
				num2 = 2;
				continue;
			}
			try
			{
				text = (string)EmmasIOAy6trpxK0JlWM((IPropertyTypeInfo)obj, (PropertyMetadata)property);
				int num3 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => text, 
					_ => text, 
				};
			}
			catch
			{
				int num4 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
				{
					num4 = 0;
				}
				while (true)
				{
					switch (num4)
					{
					case 1:
						return text;
					}
					text = (string)bXLpn8OA0Jxo1ZvYrTnT(yWMxquOAll4FOTUindh5(-1600060848 ^ -1599907342));
					num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
					{
						num4 = 1;
					}
				}
			}
		}
	}

	public static void GetParameters(object leftProperty, object rightProperty, out string typeName, out string left, out string right, out object link)
	{
		//Discarded unreachable code: IL_00db, IL_00ea, IL_0121, IL_0130, IL_01ee, IL_01fd, IL_039b, IL_03aa, IL_03b9, IL_0438, IL_0447
		int num = 18;
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		TablePartMetadata tablePartMetadata2 = default(TablePartMetadata);
		EntityPropertyMetadata entityPropertyMetadata2 = default(EntityPropertyMetadata);
		EntityInfo entityInfo = default(EntityInfo);
		CommonSettingsModule service = default(CommonSettingsModule);
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 33:
					right = (string)bXLpn8OA0Jxo1ZvYrTnT(yWMxquOAll4FOTUindh5(0xF400DF8 ^ 0xF42560C));
					num = 10;
					break;
				case 24:
					tablePartMetadata = leftProperty as TablePartMetadata;
					num2 = 5;
					continue;
				case 20:
				case 26:
					if (leftProperty is TablePartMetadata)
					{
						num2 = 24;
						continue;
					}
					goto case 15;
				case 2:
					link = nBNXCDOAby5cSD4YH34D(tablePartMetadata2);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
					{
						num2 = 23;
					}
					continue;
				case 29:
					entityPropertyMetadata2 = rightProperty as EntityPropertyMetadata;
					num2 = 22;
					continue;
				case 9:
					return;
				case 19:
					return;
				case 35:
					return;
				case 18:
					typeName = SR.T((string)yWMxquOAll4FOTUindh5(-1716458555 ^ -1716342681));
					num = 17;
					break;
				case 17:
					left = (string)bXLpn8OA0Jxo1ZvYrTnT(yWMxquOAll4FOTUindh5(0x6C7F14 ^ 0x6E24D6));
					num2 = 33;
					continue;
				case 10:
					link = null;
					num2 = 25;
					continue;
				case 27:
					right = (string)yxGGpWOA5AujiAvd8IeM(entityInfo);
					num = 28;
					break;
				case 1:
				case 14:
				case 30:
					if (rightProperty is EntityPropertyMetadata)
					{
						num2 = 29;
						continue;
					}
					if (!(rightProperty is TablePartMetadata))
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 16;
				case 7:
					if (service == null)
					{
						num2 = 35;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
						{
							num2 = 23;
						}
						continue;
					}
					goto case 12;
				case 6:
					link = nBNXCDOAby5cSD4YH34D(entityPropertyMetadata2);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
					{
						num2 = 11;
					}
					continue;
				case 22:
					right = (string)z10UxtOAtkfJccVftnXy(entityPropertyMetadata2);
					num = 6;
					break;
				default:
					left = (string)z10UxtOAtkfJccVftnXy(entityPropertyMetadata);
					num = 14;
					break;
				case 5:
					typeName = (string)bXLpn8OA0Jxo1ZvYrTnT(yWMxquOAll4FOTUindh5(0x2269BD32 ^ 0x226B841E));
					num2 = 3;
					continue;
				case 36:
					left = leftProperty.ToString();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
					{
						num2 = 1;
					}
					continue;
				case 12:
					link = N5WKBZOAchexxdcn61EH(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638225214 ^ -1638336820), wodJcQOAgbDfSg0H9OUg(service.Settings), cEvBcdOABiAp0RXvOlg0(entityInfo));
					num2 = 32;
					continue;
				case 21:
					typeName = (string)lNJFnvOAmu2SZP2BQYu6(entityPropertyMetadata);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
					{
						num2 = 0;
					}
					continue;
				case 28:
					service = Locator.GetService<CommonSettingsModule>();
					num2 = 7;
					continue;
				case 23:
					return;
				case 4:
					if (rightProperty is EntityInfo)
					{
						num = 34;
						break;
					}
					if (rightProperty == null)
					{
						num2 = 9;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 31;
				case 13:
					entityPropertyMetadata = leftProperty as EntityPropertyMetadata;
					num2 = 21;
					continue;
				case 34:
					entityInfo = rightProperty as EntityInfo;
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 != 0)
					{
						num2 = 27;
					}
					continue;
				case 8:
					right = tablePartMetadata2.DisplayName;
					num2 = 2;
					continue;
				case 15:
					if (leftProperty != null)
					{
						num2 = 36;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
						{
							num2 = 23;
						}
						continue;
					}
					goto case 1;
				case 25:
					if (!(leftProperty is EntityPropertyMetadata))
					{
						num2 = 26;
						continue;
					}
					goto case 13;
				case 11:
					return;
				case 3:
					left = (string)z10UxtOAtkfJccVftnXy(tablePartMetadata);
					num2 = 30;
					continue;
				case 32:
					return;
				case 31:
					right = rightProperty.ToString();
					num2 = 19;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					tablePartMetadata2 = rightProperty as TablePartMetadata;
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	public static void AppendPropertyRow(object leftProperty, object rightProperty, StringBuilder sb, int leftPadding, int rightPadding)
	{
		int num = 1;
		int num2 = num;
		string typeName = default(string);
		string left = default(string);
		string right = default(string);
		object link = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				GetParameters(leftProperty, rightProperty, out typeName, out left, out right, out link);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			UNyc11OADtZ7CVqmRNhn(sb, xlnoWcOAu0EArb2cfZYJ(new string[3]
			{
				left,
				typeName,
				(string)((link != null) ? ((link is Guid) ? oPwjBrOAP6sJNZ4yceAj(string.Format((string)yWMxquOAll4FOTUindh5(0x1C663DA1 ^ 0x1C6461C1), kJ3uFyOAXVeDU7o9T19K(link.ToString(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1303601216 ^ -1303466046), "")), yWMxquOAll4FOTUindh5(-980570076 ^ -980423592), right) : oPwjBrOAP6sJNZ4yceAj(link.ToString(), yWMxquOAll4FOTUindh5(0x6F6D7B44 ^ 0x6F6F2714), right)) : right)
			}, false, new string[3]
			{
				(string)((leftPadding > 0) ? hedTIrOAd1tVeJnScAZb(yWMxquOAll4FOTUindh5(-682910880 ^ -683030554), leftPadding) : ""),
				string.Empty,
				(string)((rightPadding > 0) ? hedTIrOAd1tVeJnScAZb(yWMxquOAll4FOTUindh5(0x1EA50FCC ^ 0x1EA7534A), rightPadding) : "")
			}));
			num2 = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
			{
				num2 = 1;
			}
		}
	}

	internal static Guid Qui7jQOAYyHabvf1J2x6(object P_0)
	{
		return ((IPropertyMetadata)P_0).TypeUid;
	}

	internal static Guid JY0QbPOA8DZdZKZPgaKF(object P_0)
	{
		return ((IPropertyMetadata)P_0).SubTypeUid;
	}

	internal static object rJs1h8OAsQyuCF9Uj8KC(object P_0, Guid P_1, Guid P_2)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(P_1, P_2);
	}

	internal static object g98lwlOAJ2eu1oV7knKL(Guid P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static object yWMxquOAll4FOTUindh5(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object bXLpn8OA0Jxo1ZvYrTnT(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object EmmasIOAy6trpxK0JlWM(object P_0, object P_1)
	{
		return ((IPropertyTypeInfo)P_0).GetPropertyTypeDisplayName((PropertyMetadata)P_1);
	}

	internal static bool nI3tSQOAZO4KhEaZf2RC()
	{
		return ULjO2ZOAObl0MmhRts9b == null;
	}

	internal static ProcessDocumentationHelper VT9lwKOAvT499ikTersx()
	{
		return ULjO2ZOAObl0MmhRts9b;
	}

	internal static object lNJFnvOAmu2SZP2BQYu6(object P_0)
	{
		return GetPropertyType((IPropertyMetadata)P_0);
	}

	internal static object z10UxtOAtkfJccVftnXy(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static Guid nBNXCDOAby5cSD4YH34D(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object yxGGpWOA5AujiAvd8IeM(object P_0)
	{
		return ((EntityInfo)P_0).Title;
	}

	internal static object wodJcQOAgbDfSg0H9OUg(object P_0)
	{
		return ((CommonSettings)P_0).ApplicationBaseUrl;
	}

	internal static object cEvBcdOABiAp0RXvOlg0(object P_0)
	{
		return ((EntityInfo)P_0).Id;
	}

	internal static object N5WKBZOAchexxdcn61EH(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object oPwjBrOAP6sJNZ4yceAj(object P_0, object P_1, object P_2)
	{
		return HTMLUtility.InsertHyperLink((string)P_0, (string)P_1, (string)P_2);
	}

	internal static object kJ3uFyOAXVeDU7o9T19K(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object hedTIrOAd1tVeJnScAZb(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object xlnoWcOAu0EArb2cfZYJ(object P_0, bool isBold, object P_2)
	{
		return HTMLUtility.InsertRowToTable((string[])P_0, isBold, (string[])P_2);
	}

	internal static object UNyc11OADtZ7CVqmRNhn(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}
}
