using System;
using System.Collections.Generic;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Services;

[ServiceContract]
public interface INotValidElementStorage
{
	void Init(Guid ownerUid);

	void Add(Guid ownerUid, Guid elementUid);

	void AddRange(Guid ownerUid, System.Collections.Generic.IEnumerable<Guid> elementUids);

	bool Contains(Guid ownerUid, Guid elementUid);

	void Clear(Guid ownerUid);
}
