namespace NLayerPractice.Core.UnitOfWorks
{
	public interface IUnitOfWork
	{
		//Call SavechangeAsync method
		Task CommitAsync();

		//Call SaveChgange method
		void Commit();
	}
}
