using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Model
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime DateOfPublish { get; set; }
        public string BookCode { get; set; }
        public uint NumberOfCopies { get; set; }
    }

    public class Room
    {
        public int RoomId { get; set; }
        public string NameOfRoom { get; set; }
        public string NameOfLibrary { get; set; }
        public string Specialization { get; set; }
        public uint NumberOfSits { get; set; }

        public List<Reader> Readers { get; set; }
    }


    public class Reader
    {
        public int ReaderId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public DateTime DateOfBirht{ get; set; }
        public string Phone { get; set; }
        public string Degree { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }

        public List<Book> Books { get; set; }
    }

}
