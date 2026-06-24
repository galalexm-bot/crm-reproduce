using System;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Core.Api;

[ServiceContract]
public interface IRequestService
{
	System.Threading.Tasks.Task<Response> Post(string url, System.Type returnType, object data, RequestOptions options = null);

	System.Threading.Tasks.Task<Response> Get(string url, System.Type returnType, RequestOptions options = null);
}
