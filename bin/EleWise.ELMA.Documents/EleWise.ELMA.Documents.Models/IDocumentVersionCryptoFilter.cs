using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Documents.Models;

[FilterFor(typeof(IDocumentVersionCrypto))]
public interface IDocumentVersionCryptoFilter : IEntityFilter
{
}
