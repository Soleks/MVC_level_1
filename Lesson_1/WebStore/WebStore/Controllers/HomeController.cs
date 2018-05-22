using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<EmployeeView> _employees = new List<EmployeeView>
        {
            new EmployeeView
            {
                Id = 1,
                FirstName = "Иван",
                SurName = "Иванов",
                Patronymic = "Иванович",
                Age = 22,
                Birthday = "01.11.1996",
                FamilyStatus ="Холост",
                Sex = "Мужской",
                Position = "Разработчик"
            },
            new EmployeeView
            {
                Id = 2,
                FirstName = "Владислав",
                SurName = "Петров",
                Patronymic = "Иванович",
                Age = 35,
                Birthday = "01.11.1983",
                FamilyStatus ="Женат",
                Sex = "Мужской",
                Position = "Ведущий разработчик"
            }
        };

        public IActionResult Index()
        {
            return View(_employees);
        }

        public IActionResult Details(int id)
        {
            return View(_employees.Select(x => x).Where(x => x.Id == id).Distinct()); 
        }
    }
}