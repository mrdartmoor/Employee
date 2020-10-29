using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Pracownicy.Controllers
{
    public class Global
    {
        protected void Application_AcquireRequestState(object sender, EventArgs e)

        {

            //Create culture info object 

            CultureInfo ci = new CultureInfo("en-US");



            //System.Threading.Thread.CurrentThread.CurrentUICulture = ci;

            //System.Threading.Thread.CurrentThread.CurrentCulture =
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            //CultureInfo.CreateSpecificCulture(ci.Name);

        }
        //protected override void Application_AcquireRequestState()
        //{
        //    base.InitializeCulture();
        //    System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-CA");
        //    System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-CA");
        //}
        //static void LanguageSet()
        //{
        //    Resourcess.Common.Culture = new CultureInfo("en-US");
        //}
        //LanguageSet();
    }
}
