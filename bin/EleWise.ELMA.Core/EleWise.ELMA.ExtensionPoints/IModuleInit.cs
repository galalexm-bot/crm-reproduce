using System;
using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint]
public interface IModuleInit
{
	System.Threading.Tasks.Task Init(Guid moduleUid);
}
