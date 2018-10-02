using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.model.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.model.People
{
    public class PersonManager : IManager<Person>
    {
        Manager<Person> manager;

        public PersonManager(AppDbContext context) {
            manager = new Manager<Person>(context);
        }

        public List<Person> GetAll()
        {
            List<Person> LstPerson = manager.db.Person.Include("Address").OrderBy(p => p.Name).ToList();
            
            if (LstPerson.Count > 0)
            {
                List<Contact> Contacts = new List<Contact>();

                for (int i=0; i<= LstPerson.Count-1; i++)
                {
                    var id = LstPerson[i].Id;
                    Contacts = manager.db.Contact.Where(c => c.PersonId == id).ToList();
                    if(Contacts.Count > 0)
                    {
                        LstPerson[i].Contacts = Contacts;
                    }
                }

                return LstPerson;
            }
            else
            {
                return null;
            }
        }

        public Person GetById(int id)
        {
            Person person = new Person();
            List<Contact> Contacts = new List<Contact>();

            person = manager.db.Person.Include("Address").Where(p => p.Id == id).FirstOrDefault();
            
            if ((person.Id > 0) && (!string.IsNullOrEmpty(person.Name)))
            {
                Contacts = manager.db.Contact.Where(c => c.PersonId == id).ToList();

                if (Contacts.Count > 0)
                {
                    person.Contacts = Contacts;
                }

                return person;
            }
            else
            {
                return null;
            }
        }

        public Person GetByName(string name)
        {
            Person person = new Person();
            List<Contact> Contacts = new List<Contact>();

            person = manager.db.Person.Include("Address").Where(p => p.Name == name).FirstOrDefault();
            
            if (person != null && person.Id > 0)
            {
                var id = person.Id;
                Contacts = manager.db.Contact.Where(c => c.PersonId == id).ToList();

                if (Contacts.Count > 0)
                {
                    person.Contacts = Contacts;
                }

                return person;
            }
            else
            {
                return null;
            }
        }

        public Address GetAddressByName(string name, string number)
        {
            Address address = new Address();
            address = manager.db.Address.Where(a => a.Name == name).Where(a2 => a2.Number == number).FirstOrDefault();

            if(address.Id.ToString() != null)
            {
                return address;
            }
            else
            {
                return null;
            }

        }

        public List<Person> GetByNameParameter(string paramter)
        {
            if (!string.IsNullOrEmpty(paramter))
            {
                List<Person> LstPerson = manager.db.Person.Include("Address").Where(p => p.Name.Contains(paramter)).OrderBy(p => p.Name).ToList();
                
                if (LstPerson.Count > 0)
                {
                    return LstPerson;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                throw new Exception("Invalid paramter!");
            }
        }

        public bool Insert(Person person)
        {
            Boolean validate = false;
            string msg = null;

            if (person.Type == 0)
            {
                if((!string.IsNullOrEmpty(person.Name) && person.Name != "") &&
                   (person.Gender == 0 || person.Gender == 1) && (person.Birthdate != null) &&
                   (!string.IsNullOrEmpty(person.Document1) && person.Document1 != "") &&
                   (!string.IsNullOrEmpty(person.Document2) && person.Document2 != "") &&
                   (!string.IsNullOrEmpty(person.Address.Name)&& person.Address.Name != "") &&
                   (person.AddDate != null) && (!string.IsNullOrEmpty(person.AddUser) && person.AddUser != "")
                )
                {
                    if (this.GetByName(person.Name) == null)
                    {
                        validate = true;
                    }
                    else
                    {
                        validate = false;
                        msg = "Warning: existing record!";
                    }
                }
            }
            else if (person.Type == 1)
            {
                if ((!string.IsNullOrEmpty(person.Name) && person.Name != "") &&
                   ((!string.IsNullOrEmpty(person.SocialName) && person.SocialName != "")) &&
                   (!string.IsNullOrEmpty(person.Document1) && person.Document1 != "") &&
                   (person.AddDate != null) && (!string.IsNullOrEmpty(person.AddUser) && person.AddUser != "")
                )
                {
                    if (this.GetByName(person.Name) == null)
                    {
                        validate = true;
                    }
                    else
                    {
                        validate = false;
                        msg = "Warning: existing record!";
                    }
                }
            }
            else
            {
                validate = false;
                msg = "Invalid parameter!";
            }

            if (validate == true)
            {
                manager.Create(person);
                return true;
            }
            else
            {
                throw new Exception(msg);
            }

        }

        public bool Update(Person person)
        {
            if ((person.Id > 0) &&
               (person.Type == 0 || person.Type == 1) &&
               (!string.IsNullOrEmpty(person.Name) && person.Name != "") &&
               (!string.IsNullOrEmpty(person.Document1) && person.Document1 != "") &&
               (person.EditDate != null) && (!string.IsNullOrEmpty(person.EditUser) && person.EditUser != "")
              )
            {
                manager.Change(person);
                return true;
            }
            else
            {
                throw new Exception("Warning: a field is required!");
            }
        }

        public bool Delete(Person person)
        {
            if (person.Id > 0)
            {
                manager.Remove(person);
                return true;
            }
            else
            {
                throw new Exception("Warning: An error occurred while trying to delete the record!");
            }
        }
    }
}