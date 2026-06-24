using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.CodeGeneration.PublicApi;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Documents.DynamicAPI;

[Component(Order = 1)]
internal class PublicApiDocflowNodeProvider : IPublicApiNodeProvider
{
	private readonly IEntityManagerTypesStorage entityManagerTypesStorage;

	public PublicApiDocflowNodeProvider(IEntityManagerTypesStorage entityManagerTypesStorage)
	{
		this.entityManagerTypesStorage = entityManagerTypesStorage;
	}

	public IEnumerable<IPublicApiNode> CreatePublicApiNodes()
	{
		yield return new PublicApiDocflowRootNode();
		PublicApiPropertyClassNode documentNode = new PublicApiPropertyClassNode("PublicAPI.Docflow", "DocumentDocflowApi", TypeOf<IDocument>.Raw)
		{
			Description = SR.T("Документ"),
			Remarks = SR.T("Раздел содержащий методы работы с документом"),
			Code = SR.T("\r\n<para>\r\nСоздадим документ, с которым будем работать. Документ будет лежать в папке, созданной <see cref=\"P:EleWise.ELMA.API.PublicAPI.DocflowApiRoot.Folder\">тут</see>\r\n<code>\r\n<![CDATA[\r\nvar myDocument = PublicAPI.Docflow.Types.File.Create(context.File, myFolder, \"Новый документ для примера\");\r\n]]>\r\n</code>\r\ncontext.File - файл, который будет по умолчанию версией документа\r\n</para>\r\n\r\n<para>\r\nПосле <see cref=\"P:EleWise.ELMA.API.PublicAPI.DocflowApiRoot.DocumentVersion\">добавления версий документа и изменения их статусов</see>, зарегистрируем документ\r\n<code>\r\n<![CDATA[\r\n//загружаем регистрационный вариант, необходимый для регистрации документа\r\nvar regVariant = PublicAPI.Docflow.Document.LoadRegVariant(1);\r\n//регистрируем документ\r\nPublicAPI.Docflow.Document.Register(myDocument, regVariant);\r\n]]>\r\n</code>\r\nФункция регистрации будет работать только при настроенной номенклатуре и регистрацонном варианте\r\n</para>\r\n\r\n<para>\r\nДобавим пользователю привилегию на редактирование документа\r\n<code>\r\n<![CDATA[\r\nPublicAPI.Docflow.Document.AddEditPermission(myDocument, context.User);\r\n]]>\r\n</code>\r\ncontext.User - пользователь, которому добавляется привилегия. Если пользователь уже имеют данную привилегию, функция ничего не добавит\r\n</para>\r\n\r\n<para>\r\nНе забываем сохранить объект в базу для его корректной работы\r\n<code>\r\n<![CDATA[\r\nmyDocument.Save();\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nМожно заархивировать документ и восстановать из архива документ\r\n<code>\r\n<![CDATA[\r\n//архивируем документ\r\nPublicAPI.Docflow.Document.Archive(myDocument);\r\n//восстанавливаем документ из архива\r\nPublicAPI.Docflow.Document.UnArchive(myDocument);\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nДобавим комментарий к документу\r\n<code>\r\n<![CDATA[\r\nPublicAPI.Docflow.Document.AddComment(myDocument, \"Документ был успешно восстановлен из архива\");\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nИнформацию по отправке документа на согласование, ознакомление и рассмотрение смотри <see cref=\"P:EleWise.ELMA.API.PublicAPI.DocflowApiRoot.Tasks\">тут</see>\r\n</para>\r\n")
		};
		yield return documentNode;
		foreach (IPublicApiNode item in PublicApiNodeEntityProvider.Members<IDocument, DocumentManager>(documentNode.Path))
		{
			yield return item;
		}
		PublicApiPropertyClassNode folderNode = new PublicApiPropertyClassNode("PublicAPI.Docflow", "FolderDocflowApi", TypeOf<IFolder>.Raw)
		{
			Description = SR.T("Папка"),
			Remarks = SR.T("Раздел содержащий методы для работы с папками"),
			Code = SR.T("\r\n<para>\r\nСоздадим папку, с которой будем работать\r\n<code>\r\n<![CDATA[\r\n//получаем текущего пользователя\r\nvar user = PublicAPI.Security.User.GetCurrentUser();\r\n//получаем папку \"Мои документы\" текущего пользователя\r\nvar myDocumentFolder = PublicAPI.Docflow.Folder.GetMyDocumentFolder(user);\r\nvar myFolder = PublicAPI.Docflow.Folder.CreateFolder(myDocumentFolder, \"Тестовая папка для работы\");\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nСоздадим несколько папок в папке myFolder. Они уже будут сохранены в базу данных\r\n<code>\r\n<![CDATA[\r\nvar subFolder = PublicAPI.Docflow.Folder.CreateFolder(myFolder, \"Папка номер 1\");\r\nvar subFolder2 = PublicAPI.Docflow.Folder.CreateFolder(myFolder, \"Папка номер 2\");\r\nvar subFolder3 = PublicAPI.Docflow.Folder.CreateFolder(myFolder, \"Папка номер 3\");\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nПереместим папку subFolder2\r\n<code>\r\n<![CDATA[\r\nPublicAPI.Docflow.Folder.Move(myFolder, subFolder2, subFolder3);\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nНе забываем сохранить объект в базу для его корректной работы\r\n<code>\r\n<![CDATA[\r\nmyFolder.Save();\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nИнфорацию о добавлении привилегий на папку смотри <see cref=\"P:EleWise.ELMA.API.PublicAPI.DocflowApiRoot.Permissions\">тут</see>\r\n</para>\r\n")
		};
		yield return folderNode;
		foreach (IPublicApiNode item2 in PublicApiNodeEntityProvider.Members<IFolder, FolderManager>(folderNode.Path, skipTableParts: false, skipTypeUid: true))
		{
			yield return item2;
		}
		foreach (IPublicApiNode item3 in PublicApiNodeEntityProvider.TableParts(documentNode.Path, TypeOf<IFolder>.Raw))
		{
			yield return item3;
		}
		yield return new PublicApiPropertyClassNode("PublicAPI.Docflow", "TasksDocflowApi", "Tasks")
		{
			Description = SR.T("Задачи"),
			Remarks = SR.T("Раздел содержащий методы для работы с задачами по документу"),
			Code = SR.T("\r\n<para>\r\nОтправим на ознакомление документ, который был создан <see cref=\"P:EleWise.ELMA.API.PublicAPI.DocflowApiRoot.Document\">тут</see>\r\n<code>\r\n<![CDATA[\r\nvar acqTaskGroup = PublicAPI.Docflow.Tasks.SendToAcquaintance(myDocument, context.UserList);\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nОтправим документ на согласование\r\n<code>\r\n<![CDATA[\r\nvar appTaskGroup = PublicAPI.Docflow.Tasks.SendToApprovement(myDocument, context.UserList, DateTime.Now.AddDays(3));\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nСоздадим резолюцию для документа\r\n<code>\r\n<![CDATA[\r\nvar resolution = PublicAPI.Docflow.Tasks.CreateResolution(myDocument);\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nОтправим документ на рассмотрение\r\n<code>\r\n<![CDATA[\r\nPublicAPI.Docflow.Tasks.SendToResolution(myDocument, context.User, \"Резолюция для примера\", DateTime.Now.AddDays(3));\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nДобавим пользователей в группы согласования и ознакомления\r\n<code>\r\n<![CDATA[\r\n//добавим пользователя в группу ознакомления\r\nPublicAPI.Docflow.Tasks.AddExecutor(acqTaskGroup, context.UserPetrov);\r\n//добавим пользователя в группу согласования\r\nPublicAPI.Docflow.Tasks.AddExecutor(appTaskGroup, context.UserLobanov);\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nУдалим пользователй из групп согласования и ознакомления\r\n<code>\r\n<![CDATA[\r\n//удалим пользователя из группы ознакомления\r\nPublicAPI.Docflow.Tasks.DeleteExecutor(acqTaskGroup, context.UserSidorov);\r\n//удалим пользователя из группы согласования\r\nPublicAPI.Docflow.Tasks.DeleteExecutor(appTaskGroup, context.UserSidorov);\r\n]]>\r\n</code>\r\n</para>\r\n")
		};
		PublicApiPropertyClassNode documentVersionNode = new PublicApiPropertyClassNode("PublicAPI.Docflow", "DocumentVersionDocflowApi", TypeOf<IDocumentVersion>.Raw)
		{
			Description = SR.T("Версия документа"),
			Remarks = SR.T("Раздел содержащий методы для работы с версией документа"),
			Code = SR.T("\r\n<para>\r\nДобавим версию для документа, созданного <see cref=\"P:EleWise.ELMA.API.PublicAPI.DocflowApiRoot.Document\">тут</see>\r\n<code>\r\n<![CDATA[\r\n//получаем статус версии документа\r\nvar docVersionStatus = PublicAPI.Enums.Documents.DocumentVersionStatus.Current;\r\n//добавляем версию документа\r\nvar myDocumentVersion = PublicAPI.Docflow.DocumentVersion.AddDocumentVersion(myDocument, context.BinaryFile, docVersionStatus);\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nДобавим еще несколько версий документа. Все они будут со статусом \"Черновик\"\r\n<code>\r\n<![CDATA[\r\nvar docVersion = PublicAPI.Docflow.DocumentVersion.AddDocumentVersion(myDocument, context.BinaryFile1);\r\nvar docVersion2 = PublicAPI.Docflow.DocumentVersion.AddDocumentVersion(myDocument, context.BinaryFile2);\r\nvar docVersion3 = PublicAPI.Docflow.DocumentVersion.AddDocumentVersion(myDocument, context.BinaryFile3);\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nИзменим статус версии документа\r\n<code>\r\n<![CDATA[\r\n//получаем статус версии документа\r\nvar versionStatus = PublicAPI.Enums.Documents.DocumentVersionStatus.Current;\r\n//изменяем статус версии документа\r\nPublicAPI.Docflow.DocumentVersion.ChangeVersionStatus(docVersion2, versionStatus);\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nПереименуем версию документа\r\n<code>\r\n<![CDATA[\r\nPublicAPI.Docflow.DocumentVersion.RenameVersionFile(docVersion3, \"Новое имя для версии документа\", true);\r\n]]>\r\n</code>\r\n</para>\r\n")
		};
		yield return documentVersionNode;
		foreach (IPublicApiNode item4 in PublicApiNodeEntityProvider.Members<IDocumentVersion, DocumentVersionManager>(documentVersionNode.Path))
		{
			yield return item4;
		}
		PublicApiPropertyClassNode permissionNode = new PublicApiPropertyClassNode("PublicAPI.Docflow", "PermissionsDocflowApi", "Permissions")
		{
			Description = SR.T("Привилегии"),
			Remarks = SR.T("Раздел, содержащий привилегии и методы для работы с ними"),
			Code = SR.T("\r\n<para>\r\nДобавим привилегии доступа для папки, созданной <see cref=\"P:EleWise.ELMA.API.PublicAPI.DocflowApiRoot.Folder\">тут</see>\r\n<code>\r\n<![CDATA[\r\n//добавим привилегии на редактирование для пользователя\r\nPublicAPI.Docflow.Permissions.AddEditPermission(myFolder, context.UserPetrov);\r\n//добавим привилегии на редактирование для группы пользователей\r\nPublicAPI.Docflow.Permissions.AddEditPermission(myFolder, context.UserGroupDevelopers);\r\n//добавим привилегии на редактирование для элемнета оргструктуры\r\nPublicAPI.Docflow.Permissions.AddEditPermission(myFolder, context.OrgItemWorker);\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nУдалим привилегии доступа\r\n<code>\r\n<![CDATA[\r\n//удаление одной привилегии\r\nPublicAPI.Docflow.Permissions.DeletePermission(myFolder, context.UserSidorov, PermissionProvider.DocumentEditPermission);\r\n//удаление всех привилегий\r\nPublicAPI.Docflow.Permissions.DeletePermissions(myFolder, context.UserGroup);\r\n]]>\r\n</code>\r\n</para>\r\n")
		};
		yield return permissionNode;
		yield return new PublicApiPermissionsNode<CommonPermissions>(permissionNode.Path);
		yield return new PublicApiPermissionsNode<PermissionProvider>(permissionNode.Path);
		PublicApiPropertyClassNode typesNode = new PublicApiPropertyClassNode("PublicAPI.Docflow", "TypesDocflowApi", "Types")
		{
			Description = SR.T("Типы документов системы"),
			Remarks = SR.T("Раздел содержащий все типы документов системы")
		};
		yield return typesNode;
		IEnumerable<DocumentMetadata> enumerable = from m in PublicApiCodeGenerator.Current.GetAllMetadata().OfType<DocumentMetadata>()
			where m.ShowInTypeTree && (m.Type == EntityMetadataType.Entity || m.Type == EntityMetadataType.Interface) && !m.Namespace.Contains("ConfigurationModel") && PublicApiCodeGenerator.Current.IsSystem(m)
			select m;
		foreach (DocumentMetadata metadata2 in enumerable)
		{
			PublicApiCodeGenerator.Current.SaveUsesMetadata(metadata2);
			PublicApiPropertyClassNode documenttypenode2 = new PublicApiPropertyClassNode(typesNode.Path, metadata2.Name + "DocflowApi", metadata2)
			{
				Description = SR.T(metadata2.DisplayName)
			};
			yield return documenttypenode2;
			foreach (IPublicApiNode item5 in PublicApiNodeEntityProvider.TableParts(documenttypenode2.Path, metadata2))
			{
				yield return item5;
			}
			Type typeByUid = PublicApiCodeGenerator.Current.GetTypeByUid(metadata2.Uid);
			Type managerType = PublicApiNodeEntityProvider.GetManagerType(typeByUid) ?? TypeOf.DocumentManager2.Raw.MakeGenericType(typeByUid, TypeOf<long>.Raw);
			foreach (IPublicApiNode item6 in PublicApiNodeEntityProvider.InvokeMethods(documenttypenode2.Path, managerType))
			{
				yield return item6;
			}
			yield return new PublicApiCreateFilterHelperMethodNode(documenttypenode2.Path, metadata2, skipExample: true);
			yield return new PublicApiTypeUidNode(documenttypenode2.Path, metadata2);
			yield return new PublicApiEntityFilterHelperNode(metadata2);
		}
		foreach (DocumentMetadata metadata2 in from a in PublicApiCodeGenerator.Current.GetEntityMetadataList().OfType<DocumentMetadata>()
			where !PublicApiCodeGenerator.Current.IsSystem(a)
			select a)
		{
			PublicApiCodeGenerator.Current.SaveUsesMetadata(metadata2);
			PublicApiPropertyClassNode documenttypenode2 = new PublicApiPropertyClassNode(typesNode.Path, metadata2.Name.ToTranslitIdent() + "Api", "User" + metadata2.Name, metadata2)
			{
				Description = SR.T(metadata2.DisplayName)
			};
			yield return documenttypenode2;
			foreach (IPublicApiNode item7 in PublicApiNodeEntityProvider.TableParts(documenttypenode2.Path, metadata2))
			{
				yield return item7;
			}
			foreach (IPublicApiNode item8 in PublicApiNodeEntityProvider.InvokeMethods(documenttypenode2.Path, TypeOf.DocumentManager2.Raw, metadata2, TypeOf<long>.Raw))
			{
				yield return item8;
			}
			yield return new PublicApiCreateFilterHelperMethodNode(documenttypenode2.Path, metadata2, skipExample: true);
			yield return new PublicApiTypeUidNode(documenttypenode2.Path, metadata2);
			yield return new PublicApiEntityFilterHelperNode(metadata2);
		}
		PublicApiPropertyClassNode objectsDocflowNode = new PublicApiPropertyClassNode("PublicAPI.Docflow", "ObjectsApi", "Objects")
		{
			Description = SR.T("Обьекты документооборота"),
			Remarks = SR.T("Раздел содержащий обьекты документооборота и методы для работы с ними")
		};
		yield return objectsDocflowNode;
		foreach (IPublicApiNode item9 in PublicApiNodeEntityProvider.BuildObjectsTree(objectsDocflowNode.Path, "Documents"))
		{
			yield return item9;
		}
		string productionCalendarParentPath = "PublicAPI.Services.ProductionCalendar";
		ISyntaxNode productionCalendarServiceReferenceCode = typeof(ProductionCalendarServiceExtension).CreateTypeSyntax();
		foreach (PublicApiMethodInvokeNode item10 in from m in typeof(ProductionCalendarServiceExtension).GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public)
			select new PublicApiMethodInvokeNode(productionCalendarParentPath, m, productionCalendarServiceReferenceCode))
		{
			yield return item10;
		}
	}
}
