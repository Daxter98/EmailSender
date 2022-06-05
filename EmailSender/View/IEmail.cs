using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender.View
{
    internal interface IEmail
    {
        string? EmailAddressText { get; set; }
        string? EmailSubjectText { get; set; }
        string? EmailBodyText { get; set; }
    }
}
