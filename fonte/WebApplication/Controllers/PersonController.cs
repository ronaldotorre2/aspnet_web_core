using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Net;
using WebApplication.model.Generic;
using WebApplication.model.People;
using WebApplication.Models;


namespace WebApplication.Controllers
{
    public class PersonController : Controller
    {
        protected PersonManager personManager;
        protected string User = "Uadmin";

        public PersonController(AppDbContext context)
        {
            personManager = new PersonManager(context);
        }

        // GET: Person
        public ActionResult Index()
        {
            //List<Person> people = new List<Person>();
            //people = personManager.GetAll();

            //if(people.Count > 0)
            //{
            //    return View(people);
            //}

            return View(personManager.GetAll());
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            var person = personManager.GetById(id);
            return View(person);
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(Person person)
        {
            try
            {
                if (person.Type == 0)
                {
                    person.Address.Type = 2;
                }

                person.AddDate = DateTime.Now;
                person.AddUser = User;

                person.Address.AddDate = person.AddDate;
                person.Address.AddUser = User;

                personManager.Insert(person);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == 0)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return StatusCode((int)HttpStatusCode.BadRequest);
            }

            var person = personManager.GetById(id);

            if (person == null)
            {
                //return HttpNotFound();
                return StatusCode((int)HttpStatusCode.NoContent);
            }

            return View(person);
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(Person person)
        {
            try
            {
                Person paux = new Person();

                if (person.AddUser == null)
                {
                    paux = personManager.GetById(person.Id);
                    person.AddDate = paux.AddDate;
                    person.AddUser = paux.AddUser;
                    person.AddressId = paux.AddressId;
                }

                if (person.Type == 0)
                {
                    person.Address.Type = 2;
                }
                else if (person.Type == 1)
                {
                    person.Address.Type = 0;
                }

                if (person.Address.Id == 0)
                {
                    person.Address = personManager.GetAddressByName(person.Address.Name, person.Address.Number);
                    person.AddressId = person.Address.Id;
                }

                person.EditDate = DateTime.Now;
                person.EditUser = User;

                person.Address.EditDate = person.EditDate;
                person.Address.EditUser = User;

                if (!ModelState.IsValid)
                {
                    return View();
                }
                else
                {
                    personManager.Update(person);
                }

                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            var person = personManager.GetById(id);
            return View(person);
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(Person person)
        {
            try
            {
                person = personManager.GetById(person.Id);
                personManager.Delete(person);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //GET: Person/Find
        public ActionResult Find()
        {
            return View();
        }

        // POST: Person/Find/5
        [HttpPost]
        public ActionResult Find(string name)
        {
            var person = personManager.GetByNameParameter(name);
            return View("List", person);
        }

        public ActionResult List()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}