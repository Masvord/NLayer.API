using NLayerPractice.Core.UnitOfWorks;




namespace NLayerPractice.Repository.UnitOfWorks
{
    //If we did, it would allow the changes to be reflected in the database.
    public class UnitOfWork : IUnitOfWork
    {

        private readonly NLayerDbContext _context;

        public UnitOfWork(NLayerDbContext context)
        {
            _context = context;
        }

        //Sencron
        public void Commit()
        {
            _context.SaveChanges();
        }

        //Async
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
