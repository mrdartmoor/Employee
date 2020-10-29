using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Pracownicy.Controllers
{
    public class Global
    {
        protected void Application_AcquireRequestState(object sender, EventArgs e)

{

   //Create culture info object 

   CultureInfo ci = new CultureInfo("pl");



   System.Threading.Thread.CurrentThread.CurrentUICulture = ci;

  System.Threading.Thread.CurrentThread.CurrentCulture = 

CultureInfo.CreateSpecificCulture(ci.Name);

 }
}
}
