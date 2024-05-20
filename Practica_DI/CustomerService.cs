

namespace Practica_DI
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public List<Customer> GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }

    }
}
