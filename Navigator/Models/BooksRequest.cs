using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Navigator.Models
{
    public class BooksRequest
    {
        public List<Book> Books;

        private class BookJson
        {
            public string[] names;
            public string[] authors;
        }

        public async void GetBooks()
        {
            Books = new List<Book>();

            var client = new HttpClient();
            var uri = new Uri("http://188.134.65.35");
            Stream respStream = await client.GetStreamAsync(uri);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(BookJson));
            BookJson feed = (BookJson)ser.ReadObject(respStream);
            for(int i = 0; i < feed.names.Length; i++)
            {
                Books.Add(new Book(feed.names[i], feed.authors[i]));
            }
            //System.Diagnostics.Debug.WriteLine(feed.SONGHISTORY[0].TITLE);
        }
    }
}
