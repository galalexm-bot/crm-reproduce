using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;

namespace EleWise.ELMA.Api.Services;

[InternalWebService("DataClassMetadata", "")]
public interface IDataClassMetadataService
{
	[GlobalFunction("a804e026-9dd7-4396-8f04-29b07c5e3edd")]
	System.Threading.Tasks.Task<DataClassMetadataItemHeader> Create(CreateModel createModel);

	[GlobalFunction("1a9884bc-7692-4e78-a99e-54216be6a16b")]
	System.Threading.Tasks.Task<DataClassMetadataItemHeader> EditHeader(CreateModel editModel);

	[GlobalFunction("7acbfc37-06f3-4b34-84dd-5fae24f5871a")]
	System.Threading.Tasks.Task<System.Collections.Generic.ICollection<DataClassMetadataItemHeader>> LoadAll();

	[GlobalFunction("d75591f0-70e5-4a81-b6f4-dd9813c39165")]
	System.Threading.Tasks.Task<DataClassMetadataPublishResult> Publish(Guid headerUid);

	[GlobalFunction("31e87e4b-21db-422c-bdeb-cca588d6e67d")]
	System.Threading.Tasks.Task Delete(Guid headerUid);

	[GlobalFunction("55a30cf0-c8c8-459d-9f7c-424fb4a8f62b")]
	System.Threading.Tasks.Task<DataClassMetadataItemHeader> Copy(Guid headerUid);

	[GlobalFunction("3827e598-7c10-4cce-9627-2e73197e1281")]
	System.Threading.Tasks.Task<DataClassMetadataItem> Load(Guid uid);

	[GlobalFunction("309d5a8e-1258-4a24-a866-5337e27f9aec")]
	System.Threading.Tasks.Task<DataClassSaveResult> Save(DataClassMetadataItem metadataItem);
}
