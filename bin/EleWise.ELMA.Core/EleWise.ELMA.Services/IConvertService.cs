using System;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Signatures;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Views;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts.Models;

namespace EleWise.ELMA.Services;

[ServiceContract]
public interface IConvertService
{
	System.Type ToType(TypeSignature typeSignature);

	System.Threading.Tasks.Task<string> ToString(TypeSignature typeSignature, CodeType codeType);

	System.Threading.Tasks.Task<string> ToString(TypeSignature typeSignature, CodeType codeType);

	System.Threading.Tasks.Task<string> TypeValueString(InputComputedValue inputComputedValue, CodeType codeType);

	System.Threading.Tasks.Task<string> TypeValueString(TypeSignature typeSignature, CodeType codeType);

	System.Threading.Tasks.Task<string> TypeValueString(TypeSignature typeSignature, CodeType codeType);

	System.Threading.Tasks.Task<string> ToString(InputComputedValue inputComputedValue, CodeType codeType);

	string ToString(System.Type type);

	TypeSignature ToSignature(System.Type type);

	System.Threading.Tasks.Task<string> GetTypeName(INamedMetadata property);

	System.Threading.Tasks.Task<string> GetTypeName(Guid typeUid, Guid subTypeUid);
}
