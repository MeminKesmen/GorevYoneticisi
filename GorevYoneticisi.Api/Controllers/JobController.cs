using AutoMapper;
using GorevYoneticisi.Business.Abstract;
using GorevYoneticisi.Business.Dtos;
using GorevYoneticisi.Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace GorevYoneticisi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;
        private readonly IDurationService _durationService;
        private readonly IMapper _mapper;

        public JobController(IJobService jobService,IDurationService durationService,IMapper mapper)
        {
            _jobService = jobService;
            _durationService = durationService;
            _mapper = mapper;
        }
        [HttpPost("AddJob")]
        public IActionResult AddJob([FromBody]JobCreateDto jobCreateDto)
        {
            var duration = _durationService.Get(d=>d.DurationId==jobCreateDto.DurationId);
            if (duration == null) return NotFound("Duration not found");
            var job = _mapper.Map<Job>(jobCreateDto);
            job.UserId = UserId();
            _jobService.Add(job);
            return Ok();
        }
        [HttpGet("GetMyJobs")]
        public IActionResult GetMyJobs()
        {
            var jobList = _jobService.GetAllWithDuration(j=>j.UserId==UserId());
            var jobs = _mapper.Map<List<JobDetailDto>>(jobList);
            return Ok(jobs);
        }
        [NonAction]
        int UserId()
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            return int.Parse(userId);

        }
    }
}

