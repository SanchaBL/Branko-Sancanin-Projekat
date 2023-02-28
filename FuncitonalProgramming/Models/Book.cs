using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FuncitonalProgramming.Models
{
    public class Book
    { 
        [JsonPropertyName("REDNI BROJ")]
        public int Id { get; set; }
        [JsonPropertyName("NASLOV")]
        public string Name { get; set; }
        [JsonPropertyName("ORIGINALNI NASLOV")]
        public string OriginalName { get; set; }
        [JsonPropertyName("PISAC")]
        public string Writer { get; set; }
        [JsonPropertyName("GODINA IZDAVANJA")]
        public int YearOfPublication { get; set; }
        [JsonPropertyName("IZDAVAČ")]
        public string PublisherName { get; set; }
        [JsonPropertyName("DATUM KUPOVINE")]
        public string ByingDate { get; set; }
        public double Price { get; set; } = 0.0;
        
        // This function reads Books.json file and deserializes list of books from file 
        public static List<Book> DeserializeBooks()
        {
            List<Book> books = new List<Book>();
            using (StreamReader r = new StreamReader("Books.json"))
            {
                string json = r.ReadToEnd();
                if (json != null)
                {
                    books = JsonSerializer.Deserialize<List<Book>>(json);
                }

            }
            return books;
        }
    }
}
