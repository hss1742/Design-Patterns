using src.ObserverDesignPattern.Models;

namespace src.ObserverDesignPattern.Notification
{
    public class EmailNotification: INotification
    {
        public void SendMessage(User user, Product product)
        {
            System.Console.WriteLine($"Email Sent to user - {user.Email}, for product {product.Name}");
        }
    }
}