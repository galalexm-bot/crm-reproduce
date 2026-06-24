using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Models;

namespace EleWise.ELMA.Api.Services.Internal;

[InternalWebService("Password", "")]
public interface IPasswordService
{
	[GlobalFunction("8aa129fa-ea6a-44ca-ae5c-1254b9e82ad2")]
	System.Threading.Tasks.Task<System.Collections.Generic.ICollection<PasswordAlgorithm>> GetAlgorithms();
}
