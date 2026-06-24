using System;
using EleWise.ELMA.Files;

namespace EleWise.ELMA.Services;

public interface IStructuredFileService
{
	Guid Create(StructuredFileFolder structuredFileFolder);
}
