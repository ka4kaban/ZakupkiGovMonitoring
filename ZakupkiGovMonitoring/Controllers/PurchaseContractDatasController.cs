using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParseXmlProj;
using ZakupkiGovMonitoring.Models;

namespace ZakupkiGovMonitoring.Controllers
{
    [Produces("application/json")]
    [Route("api/PurchaseContractDatas")]
    public class PurchaseContractDatasController : Controller
    {
        private readonly ZakupkiGovMonitoringContext _context;

        public PurchaseContractDatasController(ZakupkiGovMonitoringContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseContractDatas
        [HttpGet]
        public IEnumerable<PurchaseContractData> GetPurchaseContractData()
        {
            IEnumerable<PurchaseContractData> res = _context.PurchaseContractData.Where(t => t.Id < 20);
            PurchaseContractData tets = _context.PurchaseContractData.Where(t => t.Id == 1).FirstOrDefault();
            return res;
        }

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