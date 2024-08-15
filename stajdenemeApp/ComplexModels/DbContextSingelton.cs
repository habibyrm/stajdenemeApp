using stajdenemeApp.Models;

namespace stajdenemeApp.ComplexModels
{
    public class DbContextSingelton
    {
        private StajdenemeContext? _instance;

        // Public static method to provide access to the single instance.
        public StajdenemeContext Instance
        {
            get
            {
                _instance ??= new StajdenemeContext();
                return _instance;
            }
        }
    }
}
