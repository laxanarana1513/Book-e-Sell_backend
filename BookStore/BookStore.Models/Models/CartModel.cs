using BookStore.Models.ViewModels;

namespace BookStore.Models.Models
{
    public class CartModel
    {
        public CartModel() { }

        public CartModel(Cart cart)
        {
            Id = cart.Id;
            UserId = cart.Userid;
            BookId = cart.Bookid;
            Quantity = cart.Quantity;
            bookname = cart.Book.Name;
            price = cart.Book.Price;
            base64image = cart.Book.Base64image;
            //quantity = (int)cart.Book.Quantity;
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        //public int quantity { get; set; }
        public string bookname { get; set; }
        public decimal price { get; set; }

        public string base64image { get; set; }
    }
}