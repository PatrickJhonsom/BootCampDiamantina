
using System.ComponentModel;

namespace Tarefas.Web.Models;

public class TarefaViewModel
{
    
    [DisplayName("Código")]
    public int id {get;set;}
    [DisplayName("Título")]
    public string Titulo {get; set;}

    [DisplayName("Descrisao")]
    public string Descrisao {get; set;}
}