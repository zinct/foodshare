using GUI.Interfaces;

namespace GUI.Models.Response
{
    public class GetUserResponse : IPrototype
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }

        public DateTime CreatedAt { get; set; }

        public IPrototype Clone()
        {
            return new GetUserResponse { Id = Id, Name = Name, Username = Username, CreatedAt = CreatedAt };
        }
    }
}
