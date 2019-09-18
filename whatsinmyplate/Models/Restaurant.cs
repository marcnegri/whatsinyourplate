using System;
namespace whatsinmyplate.Models
{
    public class Restaurant
    {
        private string id;
        private string name;
        private string picture;
        private string description;
        private string address;
        public Restaurant()
        {
        }

        public string Name { get => name; set => name = value; }
        public string Picture { get => picture; set => picture = value; }
        public string Description { get => description; set => description = value; }
        public string Address { get => address; set => address = value; }
        public string Id { get => id; set => id = value; }
    }
}
