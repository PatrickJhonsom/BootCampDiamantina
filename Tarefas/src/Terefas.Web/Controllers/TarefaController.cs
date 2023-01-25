using Microsoft.AspNetCore.Mvc;
using Tarefas.Web.Models;

namespace Tarefas.Web.Controllers;

public class TarefasController : Controller
{
    public IActionResult Create()
    {
        return View();
    }
        public IActionResult Index()
    {
        var listaDeTarefas = new List<TarefaViewModel>(){
           new TarefaViewModel(){id=1,Titulo = "Escovar os dentes",Descrisao="Teste"}, 
           new TarefaViewModel(){id=2,Titulo = "ArrumarCama",Descrisao="Teste"},
           new TarefaViewModel(){id=3,Titulo = "Escovar os dentes",Descrisao="Teste"}
        };
        return View(listaDeTarefas);
    }
     //  public IActionResult Detalis(int id)  {    }


}