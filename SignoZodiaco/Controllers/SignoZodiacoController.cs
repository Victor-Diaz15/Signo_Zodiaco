using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignoZodiaco.Models;

namespace SignoZodiaco.Controllers
{
    public class SignoZodiacoController : Controller
    {
        //objetos
        private readonly ZodiacoViewModel zodiaco = new();
        public IActionResult Index()
        {
            return View(zodiaco);
        }
        //metodo donde se hara la peticion post y el que se encargara de retonar el zodiaco a la vista
        [HttpPost]
        public IActionResult Index(ZodiacoViewModel vm)
        {
            vm.zodiacSign = GetSign(vm);
            return View(vm);
        }
        //method getSign que retorna un string con el valor del zodiaco correspondiente
        private string GetSign(ZodiacoViewModel vm)
        {
            // 23 de diciembre - 19 de enero
            if (vm.birthDay >= 23 && vm.month == 12 || vm.birthDay <= 19 && vm.month == 1) return "Capricornio";

            //20 de enero - 18 de febrero
            else if (vm.birthDay >= 20 && vm.month == 1 || vm.birthDay <= 18 && vm.month == 2) return "Acuario";

            //19 de febrero - 20 de marzo
            else if (vm.birthDay >= 19 && vm.month == 2 || vm.birthDay <= 20 && vm.month == 3)
            {
                return (vm.birthDay > 29 && vm.month == 2) ? "Not Exist" : "Piscis";
            }

            //21 de marzo - 19 de abril
            else if (vm.birthDay >= 21 && vm.month == 3 || vm.birthDay <= 19 && vm.month == 4) return "Aries";

            //20 de abril - 20 de mayo
            else if (vm.birthDay >= 20 && vm.month == 4 || vm.birthDay <= 20 && vm.month == 5) return "Tauro";

            //21 de mayo - 21 de junio
            else if (vm.birthDay >= 21 && vm.month == 5 || vm.birthDay <= 21 && vm.month == 6) return "Géminis";

            //22 de junio - 22 de julio
            else if (vm.birthDay >= 22 && vm.month == 6 || vm.birthDay <= 22 && vm.month == 7) return "Cáncer";

            //23 de julio - 22 de agosto
            else if (vm.birthDay >= 23 && vm.month == 7 || vm.birthDay <= 22 && vm.month == 8) return "Leo";

            //23 de agosto - 22 de septiembre
            else if (vm.birthDay >= 23 && vm.month == 8 || vm.birthDay <= 22 && vm.month == 9) return "Virgo";

            //23 de septiembre - 23 de octubre
            else if (vm.birthDay >= 23 && vm.month == 9 || vm.birthDay <= 23 && vm.month == 10) return "Libra";

            //24 de octubre - 21 de noviembre
            else if (vm.birthDay >= 24 && vm.month == 10 || vm.birthDay <= 21 && vm.month == 11) return "Escorpio";

            //22 de noviembre - 22 de diciembre
            else if (vm.birthDay >= 22 && vm.month == 11 || vm.birthDay <= 22 && vm.month == 12) return "Sagitario";

            return "";
        }
    }
}
