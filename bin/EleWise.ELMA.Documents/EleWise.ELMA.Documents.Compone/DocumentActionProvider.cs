using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class DocumentActionProvider : IDocumentActionProvider
{
	public static Guid DocumentGeneralActionsChapterInfoUID = new Guid("{C8B56A24-112F-48E3-9C7E-2D5D1C376E08}");

	public static Guid DocumentVersionGeneralActionsChapterInfoUID = new Guid("{0026135C-3814-4FAF-97AB-74F6DBBD8D50}");

	public static Guid DocumentArchiveActionsChapterInfoUID = new Guid("{D519736D-D071-43A2-A348-2B0784632B0E}");

	public static Guid DocumentLinksActionsChapterInfoUID = new Guid("{BF52BCD7-2A1A-4281-BFA8-5D307C878BA1}");

	public static Guid DocumentEditActionUID = new Guid("{21A09699-7DCE-4127-B3D9-D9817275FD7D}");

	public static Guid DocumentConvertActionUID = new Guid("{A3C5A409-4AB8-4221-BA50-E5A52A28B200}");

	public static Guid DocumentCommentActionUID = new Guid("{45030BC8-6524-42E0-9FC3-6510938F7694}");

	public static Guid DocumentQuestionActionUID = new Guid("{D6271897-248E-4231-A6C2-97AA1F0EB582}");

	public static Guid DocumentRenameActionUID = new Guid("{811CEB38-739B-4CF8-8FF4-9005276BB293}");

	public static Guid DocumentMoveActionUID = new Guid("{FECBA1B8-E81F-405A-801D-257EE99C06BB}");

	public static Guid DocumentCopyActionUID = new Guid("{9FD2DD10-56E4-4502-9141-C96336F03076}");

	public static Guid DocumentViewAssignsActionUID = new Guid("{ECAC1908-2AF3-4E04-9A59-0F54D62C17ED}");

	public static Guid DocumentDiscussionActionUID = new Guid("{F3A8737B-27EA-4794-B6BF-8BC3B2C688CB}");

	public static Guid DocumentAttachToTaskActionUID = new Guid("{C2CE5EF5-7C8F-4241-B00F-9543E3CB164A}");

	public static Guid DocumentChangeStatusActionUID = new Guid("{6DE31442-0A4A-4F0F-9842-EE322E671141}");

	public static Guid DocumentDeleteActionUID = new Guid("{7B272C7E-5471-4764-90B8-DD1F9DBA6CB5}");

	public static Guid DocumentPrintBarcodeActionUID = new Guid("{87f41047-907d-4f8f-bfff-72eb125fa5ba}");

	public static Guid DocumentVersionCreateActionUID = new Guid("{49982FC7-F87A-4D2D-BD0D-6A5A0B2CC331}");

	public static Guid DocumentVersionSignActionUID = new Guid("{9B8F36F3-88C2-4A67-86CA-252E113C54D8}");

	public static Guid DocumentVersionDownloadActionUID = new Guid("{A004A773-54B3-4077-8233-21A896460C9D}");

	public static Guid DocumentVersionLockActionUID = new Guid("{9C90C1E3-AEFD-4D86-BF94-58EB94DECF97}");

	public static Guid DocumentVersionUnlockActionUID = new Guid("{790E3E8A-D6AB-4ACF-81DC-FFABFF659044}");

	public static Guid DocumentVersionEditActionUID = new Guid("{2CFC582F-9C19-4942-99B6-009BC07E4E10}");

	public static Guid DocumentVersionChangeStatusActionUID = new Guid("{380FB522-7AAE-41EC-9D61-A62FE67A86AE}");

	public static Guid DocumentVersionELMAAgentActionUID = new Guid("{4E2B8502-162D-4878-881A-1934EE38FF5F}");

	public static Guid DocumentDownloadWebVersionActionUID = new Guid("{B2050B0B-15EF-418D-ABD4-307F6852DAB8}");

	public static Guid DocumentSendToArchiveActionUID = new Guid("{39527903-2154-4A4A-A1A6-A0AA76B883AB}");

	public static Guid DocumentReturnFromArchiveActionUID = new Guid("{80A17748-503D-4FE1-A1A3-5A07936D6C09}");

	public static Guid DocumentAddLinkActionUID = new Guid("{B71108F5-74D1-42CE-A120-2796ED0EF7E0}");

	public static Guid DocumentDelLinkActionUID = new Guid("{E2C9CA79-1A36-4856-8C8A-3CEC4B23141A}");

	public static Guid DocumentEditLinkActionUID = new Guid("{8A77437F-0B43-4DEA-A689-D7A3FDCE4FAD}");

	public List<DocumentActionInfo> Actions => new List<DocumentActionInfo>
	{
		new DocumentActionInfo
		{
			Order = 10L,
			ActionName = SR.T("Изменить документ"),
			ActionUid = DocumentEditActionUID,
			Image = "#edit.svg",
			ActionChapterUid = DocumentGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 20L,
			ActionName = SR.T("Конвертировать документ"),
			ActionUid = DocumentConvertActionUID,
			Image = "#document_change.svg",
			ActionChapterUid = DocumentGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 30L,
			ActionName = SR.T("Добавить комментарий"),
			ActionUid = DocumentCommentActionUID,
			Image = "#comment_outline.svg",
			ActionChapterUid = DocumentGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 40L,
			ActionName = SR.T("Задать вопрос"),
			ActionUid = DocumentQuestionActionUID,
			Image = "#question.svg",
			ActionChapterUid = DocumentGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 50L,
			ActionName = SR.T("Переименовать"),
			ActionUid = DocumentRenameActionUID,
			Image = "#rename.svg",
			ActionChapterUid = DocumentGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 60L,
			ActionName = SR.T("Переместить"),
			ActionUid = DocumentMoveActionUID,
			Image = "#document_send.svg",
			ActionChapterUid = DocumentGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 70L,
			ActionName = SR.T("Копировать"),
			ActionUid = DocumentCopyActionUID,
			Image = "#copy.svg",
			ActionChapterUid = DocumentGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 80L,
			ActionName = SR.T("Просмотр подписок"),
			ActionUid = DocumentViewAssignsActionUID,
			Image = "#document_disagreements.svg",
			ActionChapterUid = DocumentGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 90L,
			ActionName = SR.T("Обсуждение документа"),
			ActionUid = DocumentDiscussionActionUID,
			Image = "#document_distribution.svg",
			ActionChapterUid = DocumentGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 100L,
			ActionName = SR.T("Вложить в задачу"),
			ActionUid = DocumentAttachToTaskActionUID,
			Image = "#add_poruch.svg",
			ActionChapterUid = DocumentGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 110L,
			ActionName = SR.T("Изменить статус"),
			ActionUid = DocumentChangeStatusActionUID,
			Image = "#lifecyrcle.svg",
			ActionChapterUid = DocumentGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 120L,
			ActionName = SR.T("Удалить документ"),
			ActionUid = DocumentDeleteActionUID,
			Image = "#delete.svg",
			ActionChapterUid = DocumentGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 130L,
			ActionName = SR.T("Напечатать штрихкод"),
			ActionUid = DocumentPrintBarcodeActionUID,
			Image = "#print_barcode.svg",
			ActionChapterUid = DocumentGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 10L,
			ActionName = SR.T("Добавить версию"),
			ActionUid = DocumentVersionCreateActionUID,
			Image = "#add.svg",
			ActionChapterUid = DocumentVersionGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 20L,
			ActionName = SR.T("Подписать версию"),
			ActionUid = DocumentVersionSignActionUID,
			Image = "#access_vertical.svg",
			ActionChapterUid = DocumentVersionGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 30L,
			ActionName = SR.T("Выгрузить"),
			ActionUid = DocumentVersionDownloadActionUID,
			Image = "#download.svg",
			ActionChapterUid = DocumentVersionGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 40L,
			ActionName = SR.T("Блокировать"),
			ActionUid = DocumentVersionLockActionUID,
			Image = "#document_lock.svg",
			ActionChapterUid = DocumentVersionGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 50L,
			ActionName = SR.T("Разблокировать"),
			ActionUid = DocumentVersionUnlockActionUID,
			Image = "#unlock.svg",
			ActionChapterUid = DocumentVersionGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 60L,
			ActionName = SR.T("Изменить"),
			ActionUid = DocumentVersionEditActionUID,
			Image = "#edit.svg",
			ActionChapterUid = DocumentVersionGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 70L,
			ActionName = SR.T("Сменить статус"),
			ActionUid = DocumentVersionChangeStatusActionUID,
			Image = "#change.svg",
			ActionChapterUid = DocumentVersionGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 80L,
			ActionName = SR.T("ELMA Агент"),
			ActionUid = DocumentVersionELMAAgentActionUID,
			Image = "#elma_agent.svg",
			ActionChapterUid = DocumentVersionGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 80L,
			ActionName = SR.T("Выгрузить содержимое"),
			ActionUid = DocumentDownloadWebVersionActionUID,
			Image = "#attachment.svg",
			ActionChapterUid = DocumentVersionGeneralActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 10L,
			ActionName = SR.T("Отправить в архив"),
			ActionUid = DocumentSendToArchiveActionUID,
			Image = "#archive.svg",
			ActionChapterUid = DocumentArchiveActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 20L,
			ActionName = SR.T("Вернуть из архива"),
			ActionUid = DocumentReturnFromArchiveActionUID,
			Image = "#unarchive.svg",
			ActionChapterUid = DocumentArchiveActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 10L,
			ActionName = SR.T("Создать связь с документом"),
			ActionUid = DocumentAddLinkActionUID,
			Image = "#add.svg",
			ActionChapterUid = DocumentLinksActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 20L,
			ActionName = SR.T("Удалить связь с документом"),
			ActionUid = DocumentDelLinkActionUID,
			Image = "#delete.svg",
			ActionChapterUid = DocumentLinksActionsChapterInfoUID
		},
		new DocumentActionInfo
		{
			Order = 30L,
			ActionName = SR.T("Редактировать связь с документом"),
			ActionUid = DocumentEditLinkActionUID,
			Image = "#edit.svg",
			ActionChapterUid = DocumentLinksActionsChapterInfoUID
		}
	};

	public List<DocumentActionChapterInfo> Groups => new List<DocumentActionChapterInfo>
	{
		new DocumentActionChapterInfo
		{
			Name = SR.T("Общие действия"),
			Uid = DocumentGeneralActionsChapterInfoUID
		},
		new DocumentActionChapterInfo
		{
			Name = SR.T("Версии документа"),
			Uid = DocumentVersionGeneralActionsChapterInfoUID
		},
		new DocumentActionChapterInfo
		{
			Name = SR.T("Архив документов"),
			Uid = DocumentArchiveActionsChapterInfoUID
		},
		new DocumentActionChapterInfo
		{
			Name = SR.T("Связи документов"),
			Uid = DocumentLinksActionsChapterInfoUID
		}
	};
}
