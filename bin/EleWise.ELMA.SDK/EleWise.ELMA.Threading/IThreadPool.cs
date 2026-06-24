using System.Threading;

namespace EleWise.ELMA.Threading;

public interface IThreadPool
{
	void Queue(ThreadStart task);

	void Queue(ThreadStart task, string taskName);
}
