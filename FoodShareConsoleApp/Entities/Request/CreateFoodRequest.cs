namespace FoodShareConsoleApp.Entities.Request
{
    internal class CreateFoodRequest
    {
        public required String Expire { get; set; }
        public required String Name { get; set; }
        public required String Description { get; set; }
        public required String Condition { get; set; }
        public required String Source { get; set; }
        public required String Category { get; set; }
        public int Quantity{ get; set; }
    }
}
