using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Monitoring.Models;
using ParseXmlProj;

namespace Monitoring.Controllers
{
    [Produces("application/json")]
    [Route("api/PurchaseContracts")]
    public class PurchaseContractsController : Controller
    {
        private readonly MonitoringContext _context;

        public PurchaseContractsController(MonitoringContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseContracts
        [HttpGet]
        public IEnumerable<PurchaseContract> GetPurchaseContract()
        {
            return _context.PurchaseContract;
        }

        // GET: api/PurchaseContracts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPurchaseContract([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var purchaseContract = await _context.PurchaseContract.SingleOrDefaultAsync(m => m.Id == id);

            if (purchaseContract == null)
            {
                return NotFound();
            }

            return Ok(purchaseContract);
        }

        // PUT: api/PurchaseContracts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseContract([FromRoute] int id, [FromBody] PurchaseContract purchaseContract)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != purchaseContract.Id)
            {
                return BadRequest();
            }

            _context.Entry(purchaseContract).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseContractExists(id))
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

        // POST: api/PurchaseContracts
        [HttpPost]
        public async Task<IActionResult> PostPurchaseContract([FromBody] PurchaseContract purchaseContract)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PurchaseContract.Add(purchaseContract);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurchaseContract", new { id = purchaseContract.Id }, purchaseContract);
        }

        // DELETE: api/PurchaseContracts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePurchaseContract([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var purchaseContract = await _context.PurchaseContract.SingleOrDefaultAsync(m => m.Id == id);
            if (purchaseContract == null)
            {
                return NotFound();
            }

            _context.PurchaseContract.Remove(purchaseContract);
            await _context.SaveChangesAsync();

            return Ok(purchaseContract);
        }

        private bool PurchaseContractExists(int id)
        {
            return _context.PurchaseContract.Any(e => e.Id == id);
        }
    }
}