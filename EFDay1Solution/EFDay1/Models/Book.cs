using Microsoft.Extensions.Configuration;
using System;

namespace EFDay1.Models
{

    //Why did the property "Id" become a Primary Key
    //without any explicit configuration?
    // because of the default beheviour of EF because if it detects any prop that is public numric ID/EntityID 
    // EF will make it as the PK 
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime? PublishedDate { get; set; }
    }
}
