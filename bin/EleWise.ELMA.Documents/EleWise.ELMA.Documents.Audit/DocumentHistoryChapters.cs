using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Documents.Audit;

public class DocumentHistoryChapters
{
	[Component(Order = 10)]
	public class DocumentGeneralHistoryChapterInfo : IDocumentHistoryChapterInfo
	{
		[Component(Order = 10)]
		public class DocumentCreateAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => DefaultEntityActions.CreateGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 20)]
		public class DocumentEditAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => DmsObjectActions.EditGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 30)]
		public class DocumentMoveAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => DmsObjectActions.MoveGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 40)]
		public class DocumentAddCommentAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => DocumentActions.AddCommentGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 50)]
		public class DocumentChangeStatusAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => DocumentActions.ChangeStatusGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 60)]
		public class DocumentArchiveAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => DmsObjectActions.ArchiveGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 70)]
		public class DocumentUnArchiveAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => DmsObjectActions.UnArchiveGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 80)]
		public class DocumentChangeAccessAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => DmsObjectActions.ChangeAccessGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 90)]
		public class ConvertedFromOtherTypeAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => DocumentActions.ConvertedFromOtherTypeGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 100)]
		public class DocumentQuestionCreateAction : DocumentHistoryActionInfoBase
		{
			public static Guid ActionUID = new Guid("{E8FE21B5-B570-435A-8637-633C8F184245}");

			public override Guid ActionUid => ActionUID;

			public override Guid ActionChapterUid => UID;

			public override string ActionName => SR.T("Вопросы");

			public override string CustomImage => "#question.svg";
		}

		[Component(Order = 110)]
		public class DocumentSendedAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => DocumentActions.SendedGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 120)]
		public class DocumentDiscussionAction : DocumentHistoryActionInfoBase
		{
			public static Guid ActionUID = new Guid("{1BA2C2E0-F9E0-46F9-9A09-205D19EC53D0}");

			public override Guid ActionUid => ActionUID;

			public override Guid ActionChapterUid => UID;

			public override string ActionName => SR.T("Обсуждение документа");

			public override string CustomImage => "#messages.svg";
		}

		public static Guid UID = new Guid("{CC7E73BF-9B2C-4BFE-9428-B7E5C661A659}");

		public Guid Uid => UID;

		public string Name => SR.T("Общие события");
	}

	[Component(Order = 50)]
	public class DocumentVersionHistoryChapterInfo : IDocumentHistoryChapterInfo
	{
		[Component(Order = 10)]
		public class DocumentVersionCreateAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => DefaultEntityActions.CreateGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 20)]
		public class DocumentVersionLockAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => DocumentVersionActions.LockGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 30)]
		public class DocumentVersionUnLockAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => DocumentVersionActions.UnLockGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 40)]
		public class DocumentVersionChangeStatusAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => DocumentVersionActions.ChangeStatusGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 50)]
		public class DocumentVersionEditAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => DocumentVersionActions.EditGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 60)]
		public class DocumentVersionDownload : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => DocumentVersionActions.DownloadGuid;

			public override Guid ActionChapterUid => UID;
		}

		public static Guid UID = new Guid("{2FFFE221-F75F-4854-AB9D-D74D0D1FC91B}");

		public Guid Uid => UID;

		public string Name => SR.T("Версии документа");
	}

	[Component(Order = 100)]
	public class DocumentLinksHistoryChapterInfo : IDocumentHistoryChapterInfo
	{
		[Component(Order = 10)]
		public class DocumentLinkUserCreateAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => DocumentLinkActions.UserCreateGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 20)]
		public class DocumentLinkUserDeleteAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => DocumentLinkActions.UserDeleteGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 30)]
		public class DocumentLinkUserEditAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => DocumentLinkActions.UserEditGuid;

			public override Guid ActionChapterUid => UID;
		}

		public static Guid UID = new Guid("{B510CCB3-89A9-44E0-B410-34F4EBD85DE5}");

		public Guid Uid => UID;

		public string Name => SR.T("Связи с документами");
	}

	[Component(Order = 50)]
	public class DocumentTaskHistoryChapterInfo : IDocumentHistoryChapterInfo
	{
		[Component(Order = 10)]
		public class DocumentTaskAddCommentHistoryCreateAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => TaskBaseActions.AddCommentGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 20)]
		public class DocumentTaskCloseHistoryCreateAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => TaskActions.CloseGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 30)]
		public class DocumentTaskCompleteHistoryCreateAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => TaskBaseActions.CompleteGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 40)]
		public class DocumentTaskControlCompleteHistoryCreateAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => TaskActions.ControlCompleteGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 50)]
		public class DocumentTaskCreateHistoryCreateAction : DocumentHistoryActionInfoBase
		{
			public static Guid ActionUID = new Guid("{E1F23DDF-1E7E-4AAA-9B0F-C30E69DBCF30}");

			public override Guid ActionUid => ActionUID;

			public override Guid ActionChapterUid => UID;

			public override string ActionName => SR.T("Создание");

			public override string CustomImage => "#add_outline.svg";
		}

		[Component(Order = 60)]
		public class DocumentTaskIncompleteHistoryCreateAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => TaskBaseActions.IncompleteGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 70)]
		public class DocumentTaskMarkReadHistoryCreateAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => TaskBaseActions.MarkReadGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 80)]
		public class DocumentTaskRedirectHistoryCreateAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => TaskBaseActions.RedirectGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 90)]
		public class DocumentTaskStartWorkHistoryCreateAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => TaskBaseActions.StartWorkGuid;

			public override Guid ActionChapterUid => UID;
		}

		[Component(Order = 100)]
		public class DocumentTaskQuestionCreateAction : DocumentHistoryActionInfoBase
		{
			public static Guid ActionUID = new Guid("{3469BBE7-3CDC-4F13-884F-2FB039C9A9ED}");

			public override Guid ActionUid => ActionUID;

			public override Guid ActionChapterUid => UID;

			public override string ActionName => SR.T("Вопросы");

			public override string CustomImage => "#question.svg";
		}

		[Component(Order = 120)]
		public class DocumentTaskTerminateHistoryCreateAction : DocumentHistoryActionInfoBase
		{
			public override Guid ActionUid => TaskBaseActions.TerminateGuid;

			public override Guid ActionChapterUid => UID;
		}

		public static Guid UID = new Guid("{C0E8F156-CA93-4D74-B75E-553E2BCEA0D2}");

		public Guid Uid => UID;

		public string Name => SR.T("Задачи по документам");
	}
}
