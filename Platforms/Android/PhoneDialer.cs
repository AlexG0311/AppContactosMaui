using Android.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvocarCodigoPlataforma.Servicios.MetodosParciales;

public partial class PhoneDialer
{
    public partial void LlamarTelefono(string number)
    {

        Intent callIntent = new Intent(Intent.ActionCall);
        callIntent.SetFlags(ActivityFlags.NewTask);

        var url = Android.Net.Uri.Parse(string.Format("tel:{0}", number));
        callIntent.SetData(url);
        Android.App.Application.Context.StartActivity(callIntent);

    }
}
