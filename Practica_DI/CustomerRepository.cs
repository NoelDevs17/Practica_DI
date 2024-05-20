

namespace Practica_DI
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetCustomers()
        {
            return new List<Customer>();
        }
    }
}
