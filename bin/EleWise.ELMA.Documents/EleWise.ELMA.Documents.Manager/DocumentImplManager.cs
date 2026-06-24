using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.Documents.Managers;

public class DocumentImplManager<T, TIntf, TId> : EntityImplManager<T, TIntf, TId> where T : TIntf where TIntf : class, IDocument, IEntity<TId>
{
}
