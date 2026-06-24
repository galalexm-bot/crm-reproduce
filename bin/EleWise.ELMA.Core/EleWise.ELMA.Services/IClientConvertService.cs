using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.DataClasses;

namespace EleWise.ELMA.Services;

[ServiceContract]
public interface IClientConvertService
{
	System.Threading.Tasks.Task<string> GetTypeName(DataClass dto);
}
