using Microsoft.AspNetCore.Mvc;

namespace FoodShare.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnggotaOrganisasiController : ControllerBase
    {
        private static List<AnggotaOrganisasi> AnggotaOrganisasiList = new List<AnggotaOrganisasi>
        {
            new AnggotaOrganisasi(01, AnggotaOrganisasi.EnumNamaDivisi.Distributor, AnggotaOrganisasi.StatusPerkerjaan.Finish),
            new AnggotaOrganisasi(02, AnggotaOrganisasi.EnumNamaDivisi.Logistik, AnggotaOrganisasi.StatusPerkerjaan.ToDo),
            new AnggotaOrganisasi(03, AnggotaOrganisasi.EnumNamaDivisi.Humas, AnggotaOrganisasi.StatusPerkerjaan.OnGoing)
        };

        [HttpGet]
        public IEnumerable<AnggotaOrganisasi> Get()
        {
            return AnggotaOrganisasiList;
        }

        [HttpGet("{id}")]
        public AnggotaOrganisasi Get(int id)
        {
            return AnggotaOrganisasiList[id];
        }

        [HttpPost]
        public ActionResult Post([FromBody] AnggotaOrganisasi Anggota)
        {
            AnggotaOrganisasiList.Add(Anggota);
            return CreatedAtAction(nameof(Get), new { id = AnggotaOrganisasiList.IndexOf(Anggota) }, Anggota);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            AnggotaOrganisasiList.RemoveAt(id);
            return NoContent();
        }

    }
}
