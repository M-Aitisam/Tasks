namespace Project1_Lab_Simple.Models
{
    public class DataService
    {
        public Task<string> GetData()
        {
            return Task.FromResult("Here is the Aitisam Data from the service");
        }
    }
}
