using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIInMemoryDB.Models;

namespace WebAPIInMemoryDB.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class TestController : ControllerBase
    //{
    //    private readonly AccountDBContext _context;

    //    public TestController(AccountDBContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: api/Test
    //    [HttpGet]
    //    public IEnumerable<BankAccountModel> GetEmployees()
    //    {
    //        return _context.Accounts;
    //    }

    //    // GET: api/Test/5
    //    [HttpGet("{id}")]
    //    public async Task<IActionResult> GetEmployee([FromRoute] int id)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        var employee = await _context.Accounts.FindAsync(id);

    //        if (employee == null)
    //        {
    //            return NotFound();
    //        }

    //        return Ok(employee);
    //    }

    //    // PUT: api/Test/5
    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> PutEmployee([FromRoute] int id, [FromBody] BankAccountModel employee)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        if (id != employee.Id)
    //        {
    //            return BadRequest();
    //        }

    //        _context.Entry(employee).State = EntityState.Modified;

    //        try
    //        {
    //            await _context.SaveChangesAsync();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!EmployeeExists(id))
    //            {
    //                return NotFound();
    //            }
    //            else
    //            {
    //                throw;
    //            }
    //        }

    //        return NoContent();
    //    }

    //    // POST: api/Test
    //    [HttpPost]
    //    public async Task<IActionResult> PostEmployee([FromBody] BankAccountModel employee)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        _context.Accounts.Add(employee);
    //        await _context.SaveChangesAsync();

    //        return CreatedAtAction("GetEmployee", new { id = employee.Id }, employee);
    //    }

    //    // DELETE: api/Test/5
    //    [HttpDelete("{id}")]
    //    public async Task<IActionResult> DeleteEmployee([FromRoute] int id)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        var employee = await _context.Accounts.FindAsync(id);
    //        if (employee == null)
    //        {
    //            return NotFound();
    //        }

    //        _context.Accounts.Remove(employee);
    //        await _context.SaveChangesAsync();

    //        return Ok(employee);
    //    }

    //    private bool EmployeeExists(int id)
    //    {
    //        return _context.Accounts.Any(e => e.Id == id);
    //    }
    //}
}