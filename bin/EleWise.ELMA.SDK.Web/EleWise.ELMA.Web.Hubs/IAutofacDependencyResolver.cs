using System;
using Microsoft.AspNet.SignalR;

namespace EleWise.ELMA.Web.Hubs;

public interface IAutofacDependencyResolver : IDependencyResolver, IDisposable
{
}
