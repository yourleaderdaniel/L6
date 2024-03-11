namespace PizzaOrderingApp.Models
{
    public class Product
    {
        // Так же инициализируем свойство Name значением по умолчанию
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; } // Поле добавлено для отслеживания количества продукта
    }

}
