public interface IMailService
{
    void Send();
}

public class MailChimpService : IMailService
{
    public void Send()
    {
        // Todo: código para enviar el correo
    }
}

public class SendGridService : IMailService
{
    public void Send()
    {
        // Todo: código para enviar el correo
    }
}

public class OrderService
{
    public readonly IMailService _mailService;

    public OrderService(IMailService mailService)
    {
        _mailService = mailService;
    }

    public void Create(Order order)
    {
        // ToDo: código para crear la orden

        // Enviar notificación de la orden creada
        _mailService.Send();
    }
}