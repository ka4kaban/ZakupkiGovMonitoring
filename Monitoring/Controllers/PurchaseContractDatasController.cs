using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Monitoring.Models;
using Newtonsoft.Json;
using ParseXmlProj;

namespace Monitoring.Controllers
{
    [Produces("application/json")]
    [Route("api/PurchaseContractDatas")]
    public class PurchaseContractDatasController : Controller
    {
        private readonly MonitoringContext _context;

        public PurchaseContractDatasController(MonitoringContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public PurchaseContractData GetPurchasebyRegNumber(string regNumber)
        {
            return _context.PurchaseContractData.Where(i => String.Equals(i.RegistrationNumber, regNumber)).FirstOrDefault();
            //return _context.PurchaseContractData.Where(i => i.RegistrationNumber == regNumber).FirstOrDefault();
        }
        //// GET: api/PurchaseContractDatas
        //[HttpGet]
        //public IEnumerable<PurchaseContractData> GetPurchaseContractData()
        //{
        //    return _context.PurchaseContractData.Where(i=> i.Id<20);
        //}
        // GET: api/PurchaseContractDatas/filter
        [HttpGet("[action]")]
        public IEnumerable<PurchaseContractData> GetPurchaseContractData(string filter)
        {
            if (string.IsNullOrEmpty(filter) || filter == "{}")
                return _context.PurchaseContractData.Where(i => i.Id < 20);

            PurchaseFilter filterObj = JsonConvert.DeserializeObject<PurchaseFilter>(filter);

            //IEnumerable<PurchaseContractData> res = _context.PurchaseContractData.Where(t => 
            //(string.IsNullOrEmpty(filterObj.PurchaseNumber) || t.RegistrationNumber.Contains(filterObj.PurchaseNumber))
            //&& (filterObj.PurchaseDate == null || t.RegistrationNumber.Contains(filterObj.PurchaseNumber))
            ////&& (filterObj.Region == null || t.)
            ////&& (filterObj.Budget == null || t.)
            //&& (filterObj.SumStart == null || float.Parse(t.Sum) > filterObj.SumStart)
            //&& (filterObj.SumEnd == null || float.Parse(t.Sum) < filterObj.SumEnd)

            //);
            IEnumerable<PurchaseContractData> res = _context.PurchaseContractData.AsNoTracking();
            if (!string.IsNullOrEmpty(filterObj.PurchaseNumber))
                res = res.Where(t => t.RegistrationNumber.Contains(filterObj.PurchaseNumber));

            if (filterObj.PurchaseDate != null)
                res = res.Where(t => DateTime.Parse(t.ContractCreateDate) > filterObj.PurchaseDate);

            //&& (filterObj.PurchaseDate == null || t.RegistrationNumber.Contains(filterObj.PurchaseNumber))
            //&& (filterObj.Region == null || t.)
            //&& (filterObj.Budget == null || t.)
            if (filterObj.SumStart != null)
                res = res.Where(t => t.Sum == null || float.Parse(t.Sum.Replace(".", ",")) > filterObj.SumStart); //TODO: performance

            if (filterObj.SumEnd != null)
                res = res.Where(t => t.Sum == null || float.Parse(t.Sum.Replace(".", ",")) < filterObj.SumEnd);

            //&& (filterObj.SumStart == null || float.Parse(t.Sum) > filterObj.SumStart)
            //&& (filterObj.SumEnd == null || float.Parse(t.Sum) < filterObj.SumEnd)

            //);
            return res;
            //if ()
            //.Where(i => i.RegistrationNumber < 20);

        }

        // this.state = {
        //    purchaseNumber: null,
        //    purchaseDate: null,
        //    budget: null,
        //    region: null,
        //    sumStart: null,
        //    sumEnd: null
        //}
        public class PurchaseFilter
        {
            [JsonProperty("purchaseNumber")]
            public string PurchaseNumber { get; set; }
            [JsonProperty("purchaseDate")]
            public Nullable<DateTime> PurchaseDate { get; set; }
            [JsonProperty("budget")]
            public Nullable<int> Budget { get; set; }
            [JsonProperty("region")]
            public Nullable<int> Region { get; set; }
            [JsonProperty("sumStart")]
            public Nullable<int> SumStart { get; set; }
            [JsonProperty("sumEnd")]
            public Nullable<int> SumEnd { get; set; }
        }

        //[HttpGet("[action]")]
        //public IEnumerable<Book> Books(string filter)
        // GET: api/PurchaseContractDatas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPurchaseContractData([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var purchaseContractData = await _context.PurchaseContractData.SingleOrDefaultAsync(m => m.Id == id);

            if (purchaseContractData == null)
            {
                return NotFound();
            }

            return Ok(purchaseContractData);
        }

        // PUT: api/PurchaseContractDatas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseContractData([FromRoute] int id, [FromBody] PurchaseContractData purchaseContractData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != purchaseContractData.Id)
            {
                return BadRequest();
            }

            _context.Entry(purchaseContractData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseContractDataExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PurchaseContractDatas
        [HttpPost]
        public async Task<IActionResult> PostPurchaseContractData([FromBody] PurchaseContractData purchaseContractData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PurchaseContractData.Add(purchaseContractData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurchaseContractData", new { id = purchaseContractData.Id }, purchaseContractData);
        }

        // DELETE: api/PurchaseContractDatas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePurchaseContractData([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var purchaseContractData = await _context.PurchaseContractData.SingleOrDefaultAsync(m => m.Id == id);
            if (purchaseContractData == null)
            {
                return NotFound();
            }

            _context.PurchaseContractData.Remove(purchaseContractData);
            await _context.SaveChangesAsync();

            return Ok(purchaseContractData);
        }

        private bool PurchaseContractDataExists(int id)
        {
            return _context.PurchaseContractData.Any(e => e.Id == id);
        }
    }
}