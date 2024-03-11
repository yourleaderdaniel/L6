namespace PizzaOrderingApp.Models
{
    public class User
    {
        // Если свойства не должны быть null, инициализируем их значением по умолчанию
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
    }
}
