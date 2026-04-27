using src.ObserverDesignPattern.Models;

namespace src.ObserverDesignPattern.Notification
{
    public class TextNotification: INotification
    {
        public void SendMessage(User user, Product product)
        {
            System.Console.WriteLine($"Text Sent to user with Number {user.Number}, for Product {product.Name}");
        }
    }
}