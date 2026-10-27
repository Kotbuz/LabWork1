using LabWork1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LabWork1.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            var textBlocks = new List<FirstModel>
            {
                new FirstModel { Id = 1, Title = "Уголь", Content = "Используется для выработки электроэнергии" },
                new FirstModel { Id = 2, Title = "Железо", Content = "Прочный материал, используется для большинства рецептов" },
                new FirstModel { Id = 3, Title = "Медь", Content = "Хорошо-проводящий материал, используется для электроники" },
                new FirstModel { Id = 4, Title = "Камень", Content = "Прочный и дешевый материал, используется для стен и печей" },
                new FirstModel { Id = 5, Title = "Уран", Content = "Опасный материал. Используется для создания ядерного топлива и оружия" },
                new FirstModel { Id = 6, Title = "Нефть", Content = "Используется для создания химических продуктов и топлива для огнеметов" },
                new FirstModel { Id = 7, Title = "Вольфрам", Content = "Особо-прочный материал, использующийся для продвинотого оружия" },
            };
            return View(textBlocks);
        }

    }
}
