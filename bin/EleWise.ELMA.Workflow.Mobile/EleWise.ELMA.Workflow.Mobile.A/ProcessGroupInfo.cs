using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Workflow.DTO.Models;

namespace EleWise.ELMA.Workflow.Mobile.API.Models;

internal class ProcessGroupInfo
{
	private static readonly string nameId = LinqUtils.NameOf((Expression<Func<ProcessGroupInfo, object>>)((ProcessGroupInfo i) => i.Id));

	private static readonly string nameName = LinqUtils.NameOf((Expression<Func<ProcessGroupInfo, object>>)((ProcessGroupInfo i) => i.Name));

	private static readonly string nameParentId = LinqUtils.NameOf((Expression<Func<ProcessGroupInfo, object>>)((ProcessGroupInfo i) => i.ParentId));

	public long Id { get; set; }

	public string Name { get; set; }

	public long ParentId { get; set; }

	public ProcessGroupInfo(ProcessGroupDTO group)
	{
		Id = group.Id;
		Name = group.Name;
		ParentId = group.ParentId;
	}

	public static void GetDescriptor(TypeSerializationDescriptorBuilder builder)
	{
		builder.ItemWithDescriptor(nameId, delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Идентификатор группы")).Type(typeof(long));
		}).ItemWithDescriptor(nameName, delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Наименование группы")).Type(typeof(string));
		}).ItemWithDescriptor(nameParentId, delegate(TypeSerializationDescriptorBuilder i)
		{
			i.Description(SR.T("Идентификатор родительской группы")).Type(typeof(long)).Optional();
		});
	}

	public WebData ToWebData()
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary[nameId] = Id;
		dictionary[nameName] = Name;
		if (ParentId != 0L)
		{
			dictionary[nameParentId] = ParentId;
		}
		return new WebData(dictionary);
	}
}
