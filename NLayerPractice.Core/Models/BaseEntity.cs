namespace NLayerPractice.Core.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }


        //I used "?" for UpdateDate should be nullable in migration situation.
        public DateTime? UpdatedDate { get; set; }

        //Note : Null check closed.
    }
}
