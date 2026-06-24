using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.CodeGeneration.PublicApi;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Messages.DynamicAPI;

[Component(Order = 17)]
internal class PublicApiMessagesRootNodeEntityProvider : IPublicApiNodeProvider
{
	public IEnumerable<IPublicApiNode> CreatePublicApiNodes()
	{
		PublicApiPropertyClassNode messagesNode = new PublicApiPropertyClassNode("PublicAPI.Portal", "MessagesPortalApi", "Messages", TypeOf<IBaseMessage>.Raw, hideProperty: false, registerPath: false)
		{
			Description = SR.T("Сообщения"),
			Remarks = SR.T("Раздел содержащий методы для работы с сообщениями"),
			Code = SR.T("\r\n<para>\r\nОтправим сообщение для пользователя\r\n<code>\r\n<![CDATA[\r\n//автор сообщения\r\nvar messageAuthor = PublicAPI.Security.User.GetCurrentUser();\r\n//отправляем сообщение \r\nPublicAPI.Portal.Messages.SendMessage(\"Тема для сообщения\", \"Текст сообщения\", context.UserPetrov, messageAuthor);\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nнайдем инфоканал по названию\r\n<code>\r\n<![CDATA[\r\nvar infoChannel = PublicAPI.Portal.Messages.FindInformationChannel(\"Имя для инфоканала\");\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nОтправим сообщение в найденый инфоканал\r\n<code>\r\n<![CDATA[\r\nPublicAPI.Portal.Messages.AddMessageToInfoChannel(\"Найден инфоканал\", \"Инфоканал был успешно найден\", infoChannel);\r\n]]>\r\n</code>\r\n</para>\r\n")
		};
		yield return messagesNode;
		foreach (IPublicApiNode item in PublicApiNodeEntityProvider.Members<IBaseMessage, BaseMessageManager>(messagesNode.Path))
		{
			yield return item;
		}
		PublicApiCodeGenerator.Current.SaveUsesMetadata<IMessage>();
		PublicApiCodeGenerator.Current.SaveUsesMetadata<IChannelMessage>();
		yield return new PublicApiEntityFilterHelperNode((EntityMetadata)PublicApiCodeGenerator.Current.GetMetadata(InterfaceActivator.UID<IChannelMessage>(loadImplementation: false)));
		yield return new MessageBuilderMethodNode(messagesNode.Path, "MessageBuilder", "Messages.Managers", "SendMessageBuilderApi", SR.T("Помощник отправки сообщений")).Parameter<string>("messageSubject", SR.T("Тема сообщения"));
		PublicApiPropertyClassNode objectsPortalNode = new PublicApiPropertyClassNode("PublicAPI.Portal", "ObjectsPortalApi", "Objects")
		{
			Description = SR.T("Объекты внутреннего портала"),
			Remarks = SR.T("Раздел содержащий обьекты внутреннего портала и методы работы с ними")
		};
		yield return objectsPortalNode;
		MetadataTreeHelper.GroupNode rootGroupNode = MetadataTreeHelper.BuildTree(PublicApiNodeEntityProvider.GetEntityObjectsToTree(), showDisplayName: false, showEmptyGroups: false, generateForPublicApi: true);
		MetadataTreeHelper.GroupNode groupNode = new MetadataTreeHelper.GroupNode();
		groupNode.GroupNodes = new MetadataTreeHelper.GroupNode[6]
		{
			MetadataTreeHelper.GetGroupByName(rootGroupNode, "Tasks"),
			MetadataTreeHelper.GetGroupByName(rootGroupNode, "Security"),
			MetadataTreeHelper.GetGroupByName(rootGroupNode, "Content"),
			MetadataTreeHelper.GetGroupByName(rootGroupNode, "Messages"),
			MetadataTreeHelper.GetGroupByName(rootGroupNode, "Common"),
			MetadataTreeHelper.GetGroupByName(rootGroupNode, "Calendar")
		}.Where((MetadataTreeHelper.GroupNode g) => g != null).ToList();
		MetadataTreeHelper.GroupNode groupNode2 = groupNode;
		foreach (IPublicApiNode item2 in PublicApiNodeEntityProvider.BuildObjectsTree(objectsPortalNode.Path, groupNode2))
		{
			yield return item2;
		}
	}
}
