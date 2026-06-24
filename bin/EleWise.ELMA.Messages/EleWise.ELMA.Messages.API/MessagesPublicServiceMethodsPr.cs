using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Messages.API;

[Component]
public class MessagesPublicServiceMethodsProvider : IPublicServiceMethodsProvider
{
	internal class UnreadMessageCountExecutor : PublicServiceMethodExecutor
	{
		public const string MethodName = "UnreadMessagesCount";

		public static string MethodDescription => SR.T("Получить количество непрочитанных сообщений у текущего пользователя");

		public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptor();

		public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("Count").Descriptor(SR.T("Количество сообщений"));
		}).Descriptor;

		public UnreadMessageCountExecutor(WebData parameters)
			: base(parameters)
		{
		}

		public override WebData Execute()
		{
			return WebData.CreateFromObject(new { FeedManager.Instance.GetUnreadCount().FirstOrDefault((FeedCounter m) => m.WithPriority).Count });
		}
	}

	public IEnumerable<IPublicServiceMethod> GetMethods()
	{
		return new PublicServiceMethod[1]
		{
			new PublicServiceMethod(MessagesPublicService.UID, "UnreadMessagesCount", UnreadMessageCountExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new UnreadMessageCountExecutor(data))
			{
				ParametersDescriptor = UnreadMessageCountExecutor.ParametersDescriptor,
				ResultDescriptor = UnreadMessageCountExecutor.ResultDescriptor
			}
		};
	}
}
