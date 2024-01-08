namespace DDDOnionSample.Data.EF.Commmon
{
    public class BaseEFRepository
    {
        protected ApplicationDbContext _ctx;
        public BaseEFRepository(ApplicationDbContext ctx )
        {
            _ctx = ctx;
        }
    }
}
