
using Data;


namespace pidev.Data.Infrastructure
{
    public class DataBaseFactory : IDataBaseFactory
    {
        private Model2 dataContext;

        public Model2 DataContext
        {
            get { return dataContext; }

        }
        public DataBaseFactory()
        {
            dataContext = new Model2();
        }
    }
}
