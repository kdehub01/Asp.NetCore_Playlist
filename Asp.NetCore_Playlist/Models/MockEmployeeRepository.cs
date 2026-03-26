namespace Asp.NetCore_Playlist.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _emplist;
        public MockEmployeeRepository()
        {
            _emplist = new List<Employee>()
            {
                new Employee() {Id = 1 , Name="roy" , Department ="cse" , Email="roy@gmail.com"},
                new Employee() {Id = 1 , Name="omk" , Department ="civi" , Email="omkar@gmail.com"},
                new Employee() {Id = 1 , Name="shivayee" , Department ="ca" , Email="shivaye@gmail.com"},

            };
        }
        public Employee GetEmployee(int id)
        {
            return _emplist.FirstOrDefault(s=>s.Id == id);
        }

        public List<Employee> GetAllEmployees()
        {
            return _emplist.ToList();
        }
    }
}
