using System;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Documents;

public static class DocumentConstants
{
	public static readonly Guid RootDocumentFolderUid = new Guid("{377A7438-C92E-4764-8632-66637E0D2BFB}");

	public static readonly Guid RecycleDocumentFolderUid = new Guid("{DF154DA6-17BE-44ED-9F39-4CE53E1025D8}");

	public static readonly Guid RootMetadataFolderUid = new Guid("{4D2CD40A-DF36-4883-9681-CFD7CAC8FA9C}");

	public static readonly Guid RecycleMetadataFolderUid = new Guid("{D92C42A1-8EA4-4A7F-85DD-25D6717C00B0}");

	public static readonly Guid SharedFolderUid = new Guid("{4B600303-EBD6-4569-ABB5-DAFCB819BFDC}");

	public static readonly Guid ArchiveFolderUid = new Guid("{07D60255-05E0-46D7-98DC-3BD15FA4885C}");

	public static readonly Guid AccessToAllDocumentsGroupUid = new Guid("3D7DF6B9-8308-4E9B-85AB-795FAD1BBB0B");

	public static readonly Guid DefaultDocumentHistoryProfileUid = new Guid("{7CEEFA10-E46D-4AC9-97B5-F499766D6D4B}");

	public static readonly Guid DefaultDocumentActionsProfileUid = new Guid("{F8A1A6AF-8A6C-4C6B-8F2C-71E06FE25CC8}");

	public static readonly GroupDescriptor AccessToAllDocumentsGroupDescriptor = new GroupDescriptor(AccessToAllDocumentsGroupUid, SR.T("Доступ ко всем документам ELMA"), SR.T("Служебная группа, представляет пользователей системы, имеющих доступ ко всем документам"));

	public static readonly Guid DocumentStatusNewUID = new Guid("{96C227B3-9948-484E-8707-97B1E85F88BD}");

	public static readonly Guid DocumentStatusActiveUID = new Guid("{7D8BFBBD-577B-4B24-B255-F382085ADD4C}");

	public static readonly Guid DocumentStatusCancelUID = new Guid("{1B030149-81A5-48FB-8E4B-4271A7C3AA1A}");

	public static string DocumentStatusNewName => SR.T("Начало");

	public static string DocumentStatusActiveName => SR.T("Активен");

	public static string DocumentStatusCancelName => SR.T("Отменён");
}
