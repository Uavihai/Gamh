using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAMH.Helpers;
using GAMH.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GAMH.Pages
{
    public class OrdersModel : PageModel
    {
        public List<ClotheOrderModel> ClotheOrderList { get; set; }

        public void OnGet()
        {
            JsonBL jsonBl = new JsonBL();
            ClotheOrderList = jsonBl.GetAllClotheOrdersList();
        }
    }
}