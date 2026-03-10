public class CartItem
{
    public AGood product { get; set; }
    public int quantity { get; set; }

    public CartItem(AGood product, int quantity)
    {
        this.product = product;
        this.quantity = quantity;
    }
}

public class Cart
{
    private List<CartItem> items = new List<CartItem>();

    public void AddToCart(AGood product, int quantity)
    {
        items.Add(new CartItem(product, quantity));
        Console.WriteLine($"> ĐÃ THÊM VÀO GIỎ HÀNG: {quantity}x {product.name} (ID: {product.id})");
    }

    public void Checkout()
    {
        Console.WriteLine("\n=== HÓA ĐƠN THANH TOÁN ===");
            double totalAmount = 0;

            if (items.Count == 0)
            {
                Console.WriteLine("Giỏ hàng trống!");
                return;
            }

            foreach(CartItem item in items)
            {
                double itemTotal = item.product.CalPrice(item.quantity);
                totalAmount += itemTotal;
                Console.WriteLine($"{item.product.name} (ID: {item.product.id}) x {item.quantity} = ${itemTotal}");
            }
            Console.WriteLine("------------------------");
            Console.WriteLine($"TỔNG SỐ TIỀN CẦN PHẢI THANH TOÁN: ${totalAmount}");
            Console.WriteLine("========================\n");
            
            items.Clear();
    }
}