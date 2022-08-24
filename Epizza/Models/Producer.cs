using System.ComponentModel.DataAnnotations;
namespace Epizza.Models
{
    public class Producer
    {
        //best practise is to have a base class and then inherit these attributes as they are same in producer and actor class
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }

        public string Bio { get; set; }
    }
}
