using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using MaestroDetalleCerveza.webapp.Models.ViewModels;
//using Cerveza.api.Controllers;

namespace MaestroDetalleCerveza.webapp.Controllers
{
    public class CervezaController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        public async Task<IActionResult> AddAsync(CervezaViewModel model)
        {


            using (var DB = new Cerveza.api.Models.MaestroDetalleContext())
            {
                using (var l_Transacción = DB.Database.BeginTransaction())
                {
                    try
                    {

                        Cerveza.api.Controllers.CervezasController l_CervezasController =
                                                        new Cerveza.api.Controllers.CervezasController(DB);
                        Cerveza.api.Models.Cerveza l_CervezaWebApi = new Cerveza.api.Models.Cerveza
                        {
                            Nombre = model.Nombre,
                            Estilo = model.Estilo
                        };

                        List<Cerveza.api.Models.Ingrediente> l_ListIngredientesWebApi = new List<Cerveza.api.Models.Ingrediente>();
                        foreach (var l_IngredienteViewModel in model.ingredientes)
                        {
                            Cerveza.api.Models.Ingrediente l_IngredienteWebApi = new Cerveza.api.Models.Ingrediente();
                            l_IngredienteWebApi.Nombre = l_IngredienteViewModel.NombreIngrediente;
                            l_IngredienteWebApi.Gramos = l_IngredienteViewModel.Gramos;

                            l_ListIngredientesWebApi.Add(l_IngredienteWebApi);
                        }

                        l_CervezaWebApi.Ingrediente = l_ListIngredientesWebApi;

                        await l_CervezasController.PostCerveza(l_CervezaWebApi);

                        l_Transacción.Commit();
                    }
                    catch (Exception ex)
                    {
                        l_Transacción.Rollback();
                    }

                }

                return View(nameof(Create));

            }
        }
    }
}
