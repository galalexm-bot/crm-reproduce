using System;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types;

public static class TypeConstants
{
	public static readonly Guid ActionUid = new Guid("{BF9C9728-A0F8-46F4-AB87-7C1F8DDE427C}");

	public static readonly Guid AnyTypeUid = new Guid("{C77CD813-1DFB-4777-AB7E-87B54BD09E38}");

	public static readonly Guid BinaryFileUid = new Guid("{289F266B-2805-457E-BCE0-B0BCD4D38143}");

	public static readonly Guid BlobUid = new Guid("{1911B22D-0CE2-4743-832F-6A44CB0357FE}");

	internal static readonly Guid Book1CUid = new Guid("{2CD95AAA-046F-4FAA-9F5D-6601499C985B}");

	internal static readonly Guid BookExternalDataUid = new Guid("{B461CE9D-BC64-4D82-AEA7-049393DBCC57}");

	public static readonly Guid BoolUid = new Guid("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}");

	public static readonly Guid DataClassUid = new Guid("{44AB0155-A95C-4962-9504-8C6B26DD7652}");

	public static readonly Guid DateTimeUid = new Guid("{DAC9211E-E02B-47CD-8868-89A3BFC0F749}");

	public static readonly Guid DateTimeRangeUid = new Guid("{6FBBCA7C-A693-4791-902C-30B5984671A2}");

	internal static readonly Guid Document1CUid = new Guid("{F352E3C2-5D2D-11E1-A5A0-E38E4824019B}");

	internal static readonly Guid DocumentTypeUid = new Guid("{A3A41AE4-30E2-4C46-BBA2-EE55EFDC7B90}");

	public static readonly Guid DoubleUid = new Guid("{D3DF6E6E-1FF1-46AA-AD60-D51FFA91CCC7}");

	public static readonly Guid DoubleRangeUid = new Guid("{232ECBCE-6F65-4C16-821A-CB2F79C6A720}");

	public static readonly Guid DropDownListUid = new Guid("{55888705-4BFA-431B-8A93-71B80EED484D}");

	public static readonly Guid EntityUid = new Guid("{72ED98CA-F260-4671-9BCD-FF1D80235F47}");

	public static readonly Guid EnumUid = new Guid("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}");

	public static readonly Guid ExceptionScriptUid = new Guid("{CF7F2032-8E10-4639-883A-1E247B021948}");

	public static readonly Guid FormViewItemUid = new Guid("{F2C82E42-2939-4E8B-AC63-5743C41E39E3}");

	public static readonly Guid GuidUid = new Guid("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}");

	public static readonly Guid HtmlStringUid = new Guid("{0AEF74A9-D37C-4731-813B-D5F0B5EC4392}");

	public static readonly Guid Int16Uid = new Guid("{C1D5FC22-B8ED-4CFA-8029-82EC19E17B7F}");

	public static readonly Guid Int16RangeUid = new Guid("{7C5ABF3A-1AC9-48CD-B8B0-84F70EAEAF50}");

	public static readonly Guid Int32Uid = new Guid("{D6B44BCE-B236-424D-AA74-D80DA3C8DB75}");

	public static readonly Guid Int32RangeUid = new Guid("{D3F10142-1053-4407-9E33-A5D52ED0BEF4}");

	public static readonly Guid Int64Uid = new Guid("{D90A59AF-7E47-48C5-8C4C-DAD04834E6E3}");

	public static readonly Guid Int64RangeUid = new Guid("{925CC507-9275-41A6-B050-4C121926CD98}");

	public static readonly Guid ListOfSimpleTypeUid = new Guid("{5C281E64-DDC8-4BC9-991A-84D9DC4E7649}");

	public static readonly Guid MoneyUid = new Guid("{38934BC2-601F-45DA-851F-1BBF1054D85E}");

	public static readonly Guid MoneyRangeUid = new Guid("{C245122D-57EE-4B8E-8F9F-F538D06778F4}");

	internal static readonly Guid ProjectTypeUid = new Guid("{D1397B84-F5AB-4665-984F-FDEB8F77EB0B}");

	internal static readonly Guid PasswordTypeUid = new Guid("{D31DFDF6-102D-4B74-8B3E-5EE97AA9FA7D}");

	public static readonly Guid ReferenceOnEntityUid = new Guid("{1F289B26-0607-4BC7-ADC0-9ED814C80C90}");

	public static readonly Guid ReferenceOnEntityTypeUid = new Guid("{2DF8E9CA-3AC4-4BA5-832F-18F6374397E7}");

	public static readonly Guid ReferenceOnTypeUid = new Guid("{70DC1D0B-F44B-44B9-B9E2-DFE9F8B1DBB3}");

	internal static readonly Guid RegistrationCardTypeUid = new Guid("{691ED407-4007-4530-834B-0C6A34BB9AF1}");

	public static readonly Guid RelativeDateTimeUid = new Guid("{1B104510-6460-441A-B75E-F3B7E9115E72}");

	public static readonly Guid LocalDataClassUid = new Guid("{2256D8ED-B114-4577-9C1F-241BC4CD5AF9}");

	public static readonly Guid LocalTablePartUid = new Guid("{C1021127-C9A8-42C4-BDE6-0F52A9BACA63}");

	public static readonly Guid PlatformTypeUid = new Guid("{853FA699-2756-49AD-A621-EC8158A565B0}");

	public static readonly Guid RangeTypesUid = new Guid("{66F80085-FD42-4840-9155-B20F2E947A22}");

	public static readonly Guid SimpleTypesUid = new Guid("{8507516F-C146-4317-8A32-9B164D25885D}");

	public static readonly Guid SystemTypesUid = new Guid("{8E69E7B8-EBD1-41FC-ADE0-E44084861B85}");

	public static readonly Guid StringUid = new Guid("{9B9AAC17-22BB-425C-AA93-9C02C5146965}");

	public static readonly Guid TablePartUid = MetadataConstants.TablePartMetadataTypeUid;

	public static readonly Guid TextUid = new Guid("{317E3D72-9C47-4B68-926D-BA77A2579BC2}");

	public static readonly Guid TimeSpanUid = new Guid("{C503AE0F-D260-4173-B52B-63E9158F3D7D}");

	public static readonly Guid TypeSettingsUid = new Guid("{6B39BAB6-1274-477B-A4E1-4C699EAB4C75}");

	public static readonly Guid UrlUid = new Guid("{66A64042-0490-4AD6-B804-4D08FA6C85F0}");

	public static readonly Guid WorkTimeUid = new Guid("{CDD9F627-2A60-4E36-9C10-ECB492B1ADAD}");
}
