using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.Api.Services;

[CoreWebService("EntityHead")]
public interface I1CService
{
	[Operation(Method = WebMethod.GET, UriTemplate = "/Query?type={typeUid}&q={eqlQuery}&limit={limit}&filter={filter}&select=Uid,$toString")]
	System.Threading.Tasks.Task<Book1C[]> GetBooks(string typeUid, string eqlQuery = "", int limit = 0, string filter = "");
}
