using Microsoft.AspNetCore.Mvc;

namespace FoodShare.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MakananController : ControllerBase
    {
        //private static List<String> CourseList = new List<String> {
        //    "KPL", "PBO", "BASDAT"
        //};
        DateOnly today = DateOnly.FromDateTime(DateTime.Today);
        private static List<Makanan> MakananList = new List<Makanan> {
            new Makanan(1, "ayam",10,2020, 8, 12),
            new Makanan(2, "ayam",14,2020, 11, 2),
            new Makanan(3, "ayam",4,2020, 8, 12),
            new Makanan(4, "ayam", 7, 2020, 8, 12),
            new Makanan(5, "ayam", 9, 2020, 8, 12)
        };

        [HttpGet]
        public IEnumerable<Makanan> Get()
        {
            return MakananList;
        }


        [HttpGet("{id}")]
        public Makanan Get(int id)
        {
            return MakananList[id];
        }

        [HttpPost]
        public ActionResult Post([FromBody] Makanan makanan)
        {
            MakananList.Add(makanan);
            return CreatedAtAction(nameof(Get), new { id = MakananList.IndexOf(makanan) }, makanan);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            MakananList.RemoveAt(id);
            return NoContent();
        }
    }
}

