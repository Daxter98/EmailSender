using EmailSender.Presenter;
using EmailSender.View;

namespace EmailSender
{
    public partial class Form1 : Form, IEmail
    {
        private readonly EmailFormPresenter _presenter;
        public Form1()
        {
            InitializeComponent();
            _presenter = new EmailFormPresenter(this);
        }

        public string? EmailAddressText 
        {
            get => txtAddress.Text;
            set => txtAddress.Text = value;
        }
        public string? EmailSubjectText 
        { 
            get => txtSubject.Text;
            set => txtSubject.Text = value;
        }
        public string? EmailBodyText 
        { 
            get => txtEmailBody.Text;
            set => txtEmailBody.Text = value;
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            _presenter.SendEmail();
        }
    }
}