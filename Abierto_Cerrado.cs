using System;

public class NotificationEmailService : INotification
{
    private readonly string _to;
    private readonly string _subject;

    public NotificationEmailService(string to, string subject)
    {
        _to = to;
        _subject = subject;
    }

    public async Task Notifiy()
    {
        // Lógica para enviar la ntoification por e-mail
    }
}

public class NotificationSmsService : INotification
{
    private readonly string _phoneNumber;
    private readonly string _subject;

    public NotificationSmsService(string phoneNumber, string subject)
    {
        _phoneNumber = phoneNumber;
        _subject = subject;
    }

    public async Task Notifiy()
    {
        // Lógica para enviar la notificación
    }
}