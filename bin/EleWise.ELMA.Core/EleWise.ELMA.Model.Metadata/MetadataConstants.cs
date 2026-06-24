using System;

namespace EleWise.ELMA.Model.Metadata;

public static class MetadataConstants
{
	public const string DefaultComponentMetadataNamespace = "EleWise.ELMA.UI.Components";

	public const string ProcessContextDTOMetadataUid = "943d4d9d-5c7c-4de9-884f-014f014f92fb";

	public const string ProcessContextNamespace = "EleWise.ELMA.Model.Entities.ProcessContext";

	public static Guid PageFormMetadataTypeUid = new Guid("{434587C8-C950-408D-9E2D-66615B347D06}");

	public static readonly Guid ComponentMetadataTypeUid = new Guid("{66457AD6-CE6E-4CD5-AE3A-D46DC83A0E85}");

	public static Guid PageComponentMetadataTypeUid = new Guid("{CBEA0822-E430-4BCF-8D6E-DD5AC76AE84E}");

	public static Guid PortletComponentMetadataTypeUid = new Guid("{76584C56-99AD-4D3E-B0AB-7758333251BD}");

	public static readonly Guid DataClassMetadataTypeUid = new Guid("{6F1B7544-AA48-4820-823C-3579B8AF0A22}");

	public static readonly Guid EntityMetadataTypeUid = new Guid("{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}");

	public static readonly Guid EnumMetadataTypeUid = new Guid("{25A6FECE-0C54-4CAD-B9CE-9C3523BB9750}");

	public static readonly Guid FunctionMetadataTypeUid = new Guid("{44D6296F-E38E-4704-ABD6-785CC856BAB9}");

	public static readonly Guid TablePartMetadataTypeUid = new Guid("{99D587AC-0574-4ACF-B332-66B4490CAA66}");

	public const int MAX_TABLE_NAME_LENGTH = 28;

	public const string UidPropertyName = "Uid";

	public const string IdPropertyName = "Id";

	public const string TypeUidPropertyName = "TypeUid";

	public const string ParentPropertyName = "Parent";

	public const string ModelPropertyName = "Model";

	public const string WorkflowTaskPropertyName = "WorkflowTask";

	public const string RegistrationCardPropertyName = "RegistrationCard";

	public const string InputPrefix = "Input___";

	public const string OutputPrefix = "Output___";

	public const string DisableRedirectPropertyName = "DisableRedirect";

	public const string ViewModelContext = "ViewModelContext";

	public const string ConfigurationExtension = "ConfigExt";

	public static readonly Guid MetadataItemHeaderType = new Guid("0b955dd3-40b1-424a-a864-6f365427a3fd");

	public static readonly Guid DataClassMetadataItemHeaderType = new Guid("85a8928f-0ee2-48aa-8340-db98eb1011eb");

	public static readonly Guid AttachmentMetadataTypeImplementationUid = new Guid("{d4553858-96c6-4ed5-87dd-7a0429bf5cf3}");

	public static readonly Guid AttachmentMetadataTypeUid = new Guid("{3536c931-154c-4618-93b8-4e35bd8db226}");

	public static readonly Guid PhoneMetadataTypeImplementationUid = new Guid("{25e9c68b-6a07-4f04-ac70-87ed2ebfb4bc}");

	public static readonly Guid PhoneMetadataTypeUid = new Guid("{687a394e-d1d6-47e8-b930-ffe5547776e1}");

	public static readonly Guid EmailMetadataTypeImplementationUid = new Guid("{1e27dd21-d515-4a60-873a-6a39aa30ae13}");

	public static readonly Guid EmailMetadataTypeUid = new Guid("{64b8e9c4-2fa1-4c51-9596-b2df478b72c5}");

	public static readonly Guid OrganizationItemTypeUid = new Guid("e502f586-afd4-4f55-bedb-f71028ffd302");

	public static readonly Guid OrganizationItemTypeImplementationUid = new Guid("dfb7b232-140c-4aba-bff2-c5ccee293088");

	public static readonly Guid EntityUserTypeUid = new Guid("cfdeb03c-35e9-45e7-aad8-037d83888f73");

	public static readonly Guid EntityUserTypeImplementationUid = new Guid("18faf3ae-03c9-4e64-b02a-95dd63e54c4d");

	public static Guid DocumentPropertyUidInDocumentAttachmentsMetadata = new Guid("8b8a98f1-b7d6-48c3-986c-5b16200a38a4");

	public static readonly Guid DocumentAttachementTypeUid = new Guid("{3712c676-4afd-4121-aa1a-4e47ee2e09f8}");

	public static readonly Guid DocumentAttachementTypeImplementationUid = new Guid("{62d29df3-8da3-44e2-a3ab-2afd55d7d7b1}");

	public static readonly Guid DocumentMetadataTypeUid = new Guid("{2b660715-d111-4cc6-acfd-965661719fba}");

	public static readonly Guid DocumentMetadataTypeImplementationUid = new Guid("{77a266e2-e8df-41ab-82ee-8fd93db77eec}");

	public static readonly Guid RegistrationCardMetadataTypeUid = new Guid("7cfc67af-5bfa-416b-b149-3c63d85404c0");

	public static readonly Guid ProjectMetadataTypeUid = new Guid("d369d1ad-a635-4b1c-b361-ea82d1dbee52");

	public static readonly Guid ProjectTaskBaseType = new Guid("c90c5a4f-64ce-4d69-b9ea-d4d971882d88");

	public static readonly Guid SubProjectType = new Guid("7ad3e572-5d30-4d7d-84b1-68cec19df628");

	public static readonly Guid WorkflowProjectTaskType = new Guid("fd4b03f0-082a-4348-8f98-2d0804b365d2");

	public static readonly Guid Book1CMetadataTypeUid = new Guid("f3b4d888-7f10-1651-a320-08d2eb3819b9");

	public static readonly Guid Document1CMetadataTypeUid = new Guid("e2be8775-8b76-7dad-fec4-f736d34387c3");

	public static readonly Guid ProcessContextTypeUid = new Guid("{A55C0516-4442-4D0D-AB40-17143DE835DF}");

	public static readonly Guid BookExternalDataMetadataTypeUid = new Guid("0cebddba-e20d-e909-b14e-c53dee1906d2");
}
