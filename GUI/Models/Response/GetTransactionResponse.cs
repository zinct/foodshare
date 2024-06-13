

namespace GUI.Models.Response
{
    public class GetTransactionResponse
    {
        public int Id { get; set; }
        public FoodResponse Food { get; set; }
        public UserResponse User { get; set; }

        public int Amount { get; set; }

        public DateTime CreatedAt { get; set; }
    
        public class FoodResponse
        {
            public string Name { get; set; }
        }

        public class UserResponse
        {
            public string Name { get; set; }
        }
    }
}
