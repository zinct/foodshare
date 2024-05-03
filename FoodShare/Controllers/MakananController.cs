using Microsoft.AspNetCore.Mvc;
using Utility;

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
            new Makanan(0, "ayam",10,2020, 8, 12),
            new Makanan(1, "sapi",14,2020, 11, 2),
            new Makanan(2, "kodok",4,2020, 8, 12),
            new Makanan(3, "kuda", 7, 2020, 8, 12),
            new Makanan(4, "kelinci", 9, 2020, 8, 12)
        };

        [HttpGet]
        public IEnumerable<Makanan> Get()
        {
            return ListUtilities.Read<Makanan>(MakananList).ToList();
        }

        [HttpGet("{id}")]
        public Makanan Get(int id)
        {
            return ListUtilities.ReadByID<Makanan>(MakananList, id);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Makanan makanan)
        {
            ListUtilities.Create<Makanan>(MakananList, makanan);
            return Ok("Makanan berhasil ditambahkan");
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id > MakananList.Count())
            {
                return NotFound("Makanan tidak ditemukan");
            }
            else
            {
                ListUtilities.Delete<Makanan>(MakananList, id);
                return Ok("Makanan berhasil dihapus");
            }
        }
    }
}

