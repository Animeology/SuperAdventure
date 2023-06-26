namespace Engine
{
    public class Inventory
    {
        public Item Details { get; set; }
        public int Quantity { get; set; }
        public Inventory(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
