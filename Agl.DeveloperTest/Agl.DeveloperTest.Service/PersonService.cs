﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using Agl.DeveloperTest.Service.Common;

namespace Agl.DeveloperTest.Service
{
    //PersonService class can't access directly from other layers.
    // Only way is get the object via factory.
    internal class PersonService : IPersonService
    {
        async Task<List<PersonPets>> IPersonService.GetPersonData()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://agl-developer-test.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("people.json");
                string data = string.Empty;
                List<PersonPets> query = null;
                if (response.IsSuccessStatusCode)
                {
                    data = await response.Content.ReadAsStringAsync();
                    var personList = JsonConvert.DeserializeObject<List<Person>>(data);
                    query = (from person in personList
                             group person.Pets by person.Gender into g
                             select new PersonPets
                             {
                                 Name = g.Key,
                                 Pets = g.Where(s => s != null).SelectMany(s => s).OrderBy(s => s.Name).Select(s => s.Name).ToList()
                             }).ToList();
                    
                }
                return await Task.Run<List<PersonPets>>(() => query);
            }
        }
    }
}