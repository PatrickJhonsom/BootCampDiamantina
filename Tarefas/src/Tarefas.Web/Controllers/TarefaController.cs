using Microsoft.AspNetCore.Mvc;
using Tarefas.Web.Models;

namespace Tarefas.Web.Controllers;

public class TarefasController : Controller
{ 
      public List<TarefaViewModel> listaDeTarefas{get;set;}
     public TarefasController()
   {
           listaDeTarefas = new List<TarefaViewModel>(){
           new TarefaViewModel(){id=1,Titulo = "Escovar os dentes",Descrisao="Teste"}, 
           new TarefaViewModel(){id=2,Titulo = "ArrumarCama",Descrisao="Teste"},
           new TarefaViewModel(){id=3,Titulo = "Escovar os dentes",Descrisao="Teste"}
        };
   }
  
    public IActionResult Create()
    {
        return View();
    }
        public IActionResult Index()
    {
 
        return View(listaDeTarefas);
    }
       public IActionResult Details(int id) 
        {
          var tarefa  = listaDeTarefas.Find(tarefa=>tarefa.id==id);
          return View(tarefa);//Contruir View De detalhe
          //vert automapper c# aspnetcore
        }


}