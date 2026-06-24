using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Mobile.API.Models;

internal class ProcessHeaderInfo
{
	private static readonly string nameId = LinqUtils.NameOf((Expression<Func<ProcessHeaderInfo, object>>)((ProcessHeaderInfo i) => i.Id));

	private static readonly string nameName = LinqUtils.NameOf((Expression<Func<ProcessHeaderInfo, object>>)((ProcessHeaderInfo i) => i.Name));

	private static readonly string nameGroupId = LinqUtils.NameOf((Expression<Func<ProcessHeaderInfo, object>>)((ProcessHeaderInfo i) => i.GroupId));

	public long Id { get; set; }

	public string Name { get; set; }

	public long GroupId { get; set; }

	public ProcessHeaderInfo(IProcessHeader processHeader)
	{
		Id = processHeader.Id;
		Name = processHeader.Name;
		GroupId = ((processHeader.ParentGroup != null) ? processHeader.ParentGroup.Id : 0);
	}

	public static void GetDescriptor(TypeSerializationDescriptorBuilder builder)
	{
		builder.ItemWithDescriptor(nameId, delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Идентификатор заголовка процесса")).Type(typeof(long));
		}).ItemWithDescriptor(nameName, delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Наименование")).Type(typeof(string));
		}).ItemWithDescriptor(nameGroupId, delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Идентификатор родительской группы")).Type(typeof(long)).Optional();
		});
	}

	public WebData ToWebData()
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary[nameId] = Id;
		dictionary[nameName] = Name;
		if (GroupId != 0L)
		{
			dictionary[nameGroupId] = GroupId;
		}
		return new WebData(dictionary);
	}
}
