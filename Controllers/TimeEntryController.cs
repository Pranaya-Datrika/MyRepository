using Microsoft.AspNetCore.Mvc;
using TimeSheet.Models;

namespace TimeSheet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeEntryController : ControllerBase
    {
        private readonly ITimeEntryRepository _repository;
        public TimeEntryController(ITimeEntryRepository repository)
        {
            _repository = repository;
        }
        //POST api/values
        [HttpPost]
       public IActionResult Create([FromBody] TimeEntry timeEntry)
        {
            var createdTimeEntry = _repository.Create(timeEntry);
            return CreatedAtRoute("GetTimeEntry", new { id = createdTimeEntry.Id }, createdTimeEntry);
        }
        [HttpGet("{id}")]
        public IActionResult Read(long id)
        {
            return _repository.Contains(id) ? (IActionResult) Ok(_repository.Find(id)) : NotFound();
        }
        [HttpGet]
        public IActionResult List()
        {
            return Ok(_repository.GetTimeEntry());
        }
        //Put api/values/12
        [HttpPut("{id}")]
        public IActionResult Update(long id,[FromBody]TimeEntry timeEntry)
        {
            return _repository.Contains(id) ? (IActionResult)Ok(_repository.Update(id,timeEntry)) : NotFound();
        }
        //Delete api/values/12
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            if (_repository.Contains(id))
            {
                _repository.Delete(id);
                return NoContent();
            }
            return NotFound();
        }
    }
}
