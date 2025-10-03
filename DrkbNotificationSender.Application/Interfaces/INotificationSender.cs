namespace DrkbNotificationSender.Domain.Interfaces;

public interface INotificationSender
{
    public Task Send();
}