using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Model.Types.References;

namespace EleWise.ELMA.Api.Services;

[InternalWebService("TypeDescriptorSettings", "")]
public interface ITypeDescriptorSettingsService
{
	[GlobalFunction("046a7777-8948-4e41-8deb-0a8a7f44ccb8")]
	System.Threading.Tasks.Task<bool> UseEntityFilterOnly(ReferenceOnType type);
}
