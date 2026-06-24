using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.vCard.Vcard;

namespace EleWise.ELMA.Common.Mobile.API;

internal class GetVCardForUserExecutor : PublicServiceMethodExecutor
{
	public const string MethodName = "GetVCardForUser";

	public static string MethodDescription => SR.T("Получить файл vCard для пользователя");

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("UserId", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Идентификатор пользователя")).Type(typeof(long));
	}).Descriptor;

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("Result", delegate(TypeSerializationDescriptorBuilder j)
	{
		j.Description(SR.T("Результат выполнения. True, если выполнение завершено успешно.")).Type(typeof(bool));
	}).ItemWithDescriptor("VCard", delegate(TypeSerializationDescriptorBuilder j)
	{
		j.Description(SR.T("Сериализованная карточка пользователя в формате VCard")).Type(typeof(string));
	}).Descriptor;

	public GetVCardForUserExecutor(WebData parameters)
		: base(parameters)
	{
	}

	public override WebData Execute()
	{
		return ExecuteInternal();
	}

	protected virtual WebData GetResult(Vcard vcard)
	{
		EntitySerializationSettings entitySerializationSettings = new EntitySerializationSettings();
		entitySerializationSettings.Mode = EntitySerializationMode.ChangesOnly;
		return WebData.CreateFromObject(new
		{
			Result = true,
			VCard = vcard.Serialize()
		}, entitySerializationSettings);
	}

	protected virtual WebData GetError()
	{
		return WebData.CreateFromObject(new
		{
			Result = false
		});
	}

	private WebData ExecuteInternal()
	{
		if (Parameters == null || Parameters.Items == null)
		{
			return GetError();
		}
		WebDataItem webDataItem = Parameters.FindItem("UserId");
		if (webDataItem == null || string.IsNullOrEmpty(webDataItem.Value))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не задан идентификатор пользователя"));
		}
		if (!long.TryParse(webDataItem.Value, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора пользователя, должен быть Int64"), 400);
		}
		Vcard vcard = new Vcard(UserManager.Instance.LoadOrNull(result) ?? throw PublicServiceException.CreateWebFault(SR.T("Пользователь с данным идентификатором не найден"), 404));
		return GetResult(vcard);
	}
}
