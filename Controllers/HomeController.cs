using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira","857.032.950-41"," arthur@hotmail.com", "Churros");
        Cliente cliente02 = new Cliente(02, "Ana Faria", "148.152.33-22", "Ana@hotmail.com", "Cristal");
        Cliente cliente03 = new Cliente(03, "Pedro Ruiz" , "558.442.33-66","pedroRuiz@outlook.com", "Bolt" );
        Cliente cliente04 = new Cliente(04, "Souza Lopes", "005.878.66-2","Souza@gmail.com", "Cibelly");
        Cliente cliente05 = new Cliente(05, "Cibelly Ferreira", "55-640-2", "cibelly@tis.com","Suquita");
                        List<Cliente> listaClientes = new List<Cliente>();
          
          listaClientes.Add(cliente1);
          listaClientes.Add(cliente02);
          listaClientes.Add(cliente03);
          listaClientes.Add(cliente04);
          listaClientes.Add(cliente05);

            ViewBag.listaClientes = listaClientes;
           
         

          


       Fornecedor fornecedor01 = new Fornecedor(01, "CatdOg","14.55.65.33.2-55/22"," CatdOg@hotmail.com");
        Fornecedor fornecedor02 = new Fornecedor(01, "ClineDoisIrmaos"," 55.44.888.3/2"," ClineDoisIrmaos@hotmail.com"); 
        Fornecedor fornecedor03 = new Fornecedor(03, "EstelaRuiz" , "44.587.99.4/5-1","EstelaRuiz@outlook.com");
       Fornecedor fornecedor4 = new Fornecedor(04, "CLinpet", "445-55-3.5/1","CLinpet@gmail.com");
        Fornecedor fornecedor05 = new Fornecedor(05, "PetHappy", "44-562-2/5", "PetHappy@this.com");


                //Fornecedores
            List<Fornecedor> listaFornecedores = new List<Fornecedor>();
            listaFornecedores.Add(fornecedor01);
            listaFornecedores.Add(fornecedor02);
            listaFornecedores.Add(fornecedor03);
            listaFornecedores.Add(fornecedor4);
            listaFornecedores.Add(fornecedor05);
             
             ViewBag.listaFornecedores = listaFornecedores;


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
