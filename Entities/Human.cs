namespace ConsoleApp1.Entities
{
    public abstract class Human : BaseEntitiy
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
