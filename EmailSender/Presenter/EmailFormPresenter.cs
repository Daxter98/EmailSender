using EmailSender.View;
using EmailSender.Model;
using System.Windows.Forms;

namespace EmailSender.Presenter
{
    /*
     * El presentador es el encargado de conectar el Form con la Interfaz y esta con el Modelo.
     * Los elementos de la interfaz se comunican con esta clase.
     * 
     */
    internal class EmailFormPresenter
    {
        // View
        private readonly IEmail emailView;

        // La vista puede ser un
        public EmailFormPresenter(IEmail view)
        {
            emailView = view;
        }

        public void SendEmail()
        {
            Email email = new()
            {
                EmailAddress = emailView.EmailAddressText,
                EmailSubject = emailView.EmailSubjectText,
                EmailBody = emailView.EmailBodyText
            };
            // Validations can be done in the presenter.
            email.SendEmail();
        }
    }
}
