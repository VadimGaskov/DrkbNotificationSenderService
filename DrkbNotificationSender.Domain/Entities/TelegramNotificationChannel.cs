namespace DrkbNotificationSender.Domain.Entities;

public class TelegramNotificationChannel
{
    public Guid Id { get; set; }
    //TODO Изменить тип данных?
    public string TelegramId { get; set; }
}