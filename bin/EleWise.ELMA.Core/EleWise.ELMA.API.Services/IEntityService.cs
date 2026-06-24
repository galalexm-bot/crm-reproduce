using System;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.Api;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Api.Services;

[CoreWebService("Entity")]
public interface IEntityService
{
	[Operation(Method = WebMethod.GET, UriTemplate = "/Count?type={typeUid}&q={eqlQuery}")]
	System.Threading.Tasks.Task<int> Count(string typeUid, string eqlQuery);

	[Operation(Method = WebMethod.GET, UriTemplate = "/QueryTree?type={typeUid}&q={eqlQuery}&limit={limit}&filterProviderUid={filterProviderUid}&filterProviderData={filterProviderData}&filter={filter}&sort={sort}&select=Uid,$toString")]
	System.Threading.Tasks.Task<Entity[]> QuerySimple(string typeUid, string eqlQuery = "", int limit = 0, string filterProviderUid = "", string filterProviderData = "", string filter = "", string sort = "");

	[Operation(Method = WebMethod.GET, UriTemplate = "/QueryTree?type={typeUid}&q={eqlQuery}&select={select}&limit={limit}&offset={offset}&sort={sort}&filterProviderUid={filterProviderUid}&filterProviderData={filterProviderData}&filter={filter}")]
	System.Threading.Tasks.Task<Entity[]> QueryTree(string typeUid, string eqlQuery, string select, string sort, int limit = 0, int offset = 0, string filterProviderUid = "", string filterProviderData = "", string filter = "");

	[Operation(Method = WebMethod.POST, UriTemplate = "/QueryTree?type={typeUid}&q={eqlQuery}&select={select}&limit={limit}&offset={offset}&sort={sort}")]
	System.Threading.Tasks.Task<Entity[]> QueryTreeWithDependencies(string typeUid, string eqlQuery, string select, EntityTypeSerializationSettingsDto[] entityTypeSerializationSettings, string sort, int limit = 0, int offset = 0);

	[Operation(Method = WebMethod.POST, UriTemplate = "/LoadTree?type={typeUid}&id={entityId}&select={select}")]
	System.Threading.Tasks.Task<Entity> LoadTree(string typeUid, string entityId, string select, EntityTypeSerializationSettingsDto[] entityTypeSerializationSettings);

	[Operation(Method = WebMethod.GET, UriTemplate = "/UserDefinedList?userdefinedlist={userDefinedListUid}&modelsubtype={modelSubtypeUid}")]
	System.Threading.Tasks.Task<Entity[]> UserDefinedListQuery(Guid userDefinedListUid, Guid modelSubtypeUid);
}
