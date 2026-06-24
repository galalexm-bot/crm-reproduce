using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Documents.Models.Folders;

public interface IHasOwner
{
	IUser Owner { get; set; }
}
