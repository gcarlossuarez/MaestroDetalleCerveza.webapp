using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using MaestroDetalleCerveza.webapp.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
//using Cerveza.api.Controllers;

namespace MaestroDetalleCerveza.webapp.Controllers
{
    public class CervezaController : Controller
    {
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            using (var DB = new Cerveza.api.Models.MaestroDetalleContext())
            {
                using (var l_Transacción = DB.Database.BeginTransaction())
                {
                    try
                    {
                        // Para no hacerlo muy pesado, no se carga el detalle; se cargará por demanda
                        //var l_ListCerveza =
                        //    await DB.Cerveza.Select(x =>
                        //       CervezaController.TransformarCervezaEnCervezaEditViewModel(x, DB, true)).ToListAsync();
                        var l_ListCerveza =
                            await DB.Cerveza.Select(x =>
                               CervezaController.TransformarCervezaEnCervezaEditViewModel(x, DB, false)).ToListAsync();

                        l_Transacción.Commit();

                        return View(l_ListCerveza);
                    }
                    catch (Exception ex)
                    {
                        l_Transacción.Rollback();

                        return View("Error", "Models");
                    }
                    
                }
                //return View(await DB.Cerveza.ToListAsync()); //.ToListAsync());
            }
            
        }
        
        private static CervezaEditViewModel TransformarCervezaEnCervezaEditViewModel(Cerveza.api.Models.Cerveza p_Cerveza,
                                                                 Cerveza.api.Models.MaestroDetalleContext p_MaestroDetalleContext,
                                                                 bool p_CargarIngredientesSiNoEstuvieranCargados)
        {
            CervezaEditViewModel l_CervezaEditViewModel = new CervezaEditViewModel()
            {
                IdCerveza = p_Cerveza.Id,
                Estilo = p_Cerveza.Estilo,
                Nombre = p_Cerveza.Nombre
            };

            List<Cerveza.api.Models.Ingrediente> l_ListIngredientes = p_Cerveza.Ingrediente.ToList();
            if( (p_Cerveza.Ingrediente.Count == 0) && (p_CargarIngredientesSiNoEstuvieranCargados))
            {
                l_ListIngredientes = new List<Cerveza.api.Models.Ingrediente>();

                // NTOA.- El '30/10/2020', se caía si no cerraba el "DataReader" original
                //l_ListIngredientes = p_MaestroDetalleContext.Ingrediente.Where(x => x.IdCerveza == p_Cerveza.Id).ToList();
                using (var DB = new Cerveza.api.Models.MaestroDetalleContext())
                {
                    l_ListIngredientes = DB.Ingrediente.Where(x => x.IdCerveza == p_Cerveza.Id).ToList();
                }
            }
            
            foreach (var l_IngerienteModelDB in l_ListIngredientes)
            {
                IngredienteEditViewModel l_IngredienteEditViewModel = new IngredienteEditViewModel
                {
                    IdIngrediente = l_IngerienteModelDB.Id,
                    NombreIngrediente = l_IngerienteModelDB.Nombre,
                    Gramos = l_IngerienteModelDB.Gramos,
                    IdCerveza = l_IngerienteModelDB.IdCerveza
                };
                l_CervezaEditViewModel.ingredientes.Add(l_IngredienteEditViewModel);
            }

            return l_CervezaEditViewModel;
        }
        

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
                        List<Cerveza.api.Models.Ingrediente> l_ListIngredientesWebApi = ObtIngredientesCervezaDesdeWebApi(model);

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

        private static List<Cerveza.api.Models.Ingrediente> ObtIngredientesCervezaDesdeWebApi(CervezaViewModel model)
        {
            List<Cerveza.api.Models.Ingrediente> l_ListIngredientesWebApi = new List<Cerveza.api.Models.Ingrediente>();
            foreach (var l_IngredienteViewModel in model.ingredientes)
            {
                Cerveza.api.Models.Ingrediente l_IngredienteWebApi = new Cerveza.api.Models.Ingrediente();
                l_IngredienteWebApi.Nombre = l_IngredienteViewModel.NombreIngrediente;
                l_IngredienteWebApi.Gramos = l_IngredienteViewModel.Gramos;

                l_ListIngredientesWebApi.Add(l_IngredienteWebApi);
            }

            return l_ListIngredientesWebApi;
        }

        private static List<Cerveza.api.Models.Ingrediente> ObtIngredientesCervezaDesdeWebApi(CervezaEditViewModel model)
        {
            List<Cerveza.api.Models.Ingrediente> l_ListIngredientesWebApi = new List<Cerveza.api.Models.Ingrediente>();
            foreach (var l_IngredienteViewModel in model.ingredientes)
            {
                Cerveza.api.Models.Ingrediente l_IngredienteWebApi = new Cerveza.api.Models.Ingrediente();
                l_IngredienteWebApi.Nombre = l_IngredienteViewModel.NombreIngrediente;
                l_IngredienteWebApi.Gramos = l_IngredienteViewModel.Gramos;

                l_ListIngredientesWebApi.Add(l_IngredienteWebApi);
            }

            return l_ListIngredientesWebApi;
        }

        [HttpGet]
        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}
            
            int l_IdCerveza = id ?? 0;


            using (var DB = new Cerveza.api.Models.MaestroDetalleContext())
            {
                using (var l_Transacción = DB.Database.BeginTransaction())
                {
                    try
                    {
                        Cerveza.api.Controllers.CervezasController l_CervezasController =
                                                       new Cerveza.api.Controllers.CervezasController(DB);


                        ActionResult<Cerveza.api.Models.Cerveza> actionResult = await l_CervezasController.GetCerveza(l_IdCerveza);
                        Cerveza.api.Models.Cerveza l_CervezaWebApi = actionResult.Value;
                        
                        return View( TransformarCervezaEnCervezaEditViewModel( l_CervezaWebApi, DB, true) );
                    }
                    catch (Exception ex)
                    {
                        l_Transacción.Rollback();

                        return View("Error", "Models");
                    }

                }
                //return View(await DB.Cerveza.ToListAsync()); //.ToListAsync());
            }

        }

        [HttpPost]
        // POST: Products/Edit/5
        public async Task<IActionResult> Edit(int? id, CervezaEditViewModel p_CervezaViewEditModel)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            int l_IdCerveza = id ?? 0;


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
                            Id = p_CervezaViewEditModel.IdCerveza,
                            Nombre = p_CervezaViewEditModel.Nombre,
                            Estilo = p_CervezaViewEditModel.Estilo
                        };

                        l_CervezaWebApi.Ingrediente = new List<Cerveza.api.Models.Ingrediente>();

                        foreach(var l_ÍtemViewEditModel in p_CervezaViewEditModel.ingredientes)
                        {
                            if(!string.IsNullOrEmpty(l_ÍtemViewEditModel.NombreIngrediente))
                            {
                                Cerveza.api.Models.Ingrediente l_IngredienteWebApi = new Cerveza.api.Models.Ingrediente()
                                {
                                    Id = l_ÍtemViewEditModel.IdIngrediente,
                                    Nombre = l_ÍtemViewEditModel.NombreIngrediente,
                                    Gramos = l_ÍtemViewEditModel.Gramos,
                                    IdCerveza = l_CervezaWebApi.Id, //l_ÍtemViewEditModel.IdCerveza
                                    IdCervezaNavigation = l_CervezaWebApi
                                };
                                l_CervezaWebApi.Ingrediente.Add(l_IngredienteWebApi);
                            }
                        }

                        await l_CervezasController.PutCerveza(l_IdCerveza, l_CervezaWebApi);

                        l_Transacción.Commit();

                        return await Edit(p_CervezaViewEditModel.IdCerveza);
                        //return View(p_CervezaViewEditModel);
                        //return View(new CervezaEditViewModel());
                        //return View();
                        //return View(nameof(Index));
                    }
                    catch (Exception ex)
                    {
                        l_Transacción.Rollback();

                        return View("Error", "Models");
                    }

                }
                //return View(await DB.Cerveza.ToListAsync()); //.ToListAsync());
            }

        }
    }
}
