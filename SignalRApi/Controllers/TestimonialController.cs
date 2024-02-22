using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.DiscountDto;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;
        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult DiscountList()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            _testimonialService.TAdd(new Testimonial()
            {
                Comment = createTestimonialDto.Comment,
                ImageUrl = createTestimonialDto.ImageUrl,
                Name = createTestimonialDto.Name,
                Status = createTestimonialDto.Status,
                Title = createTestimonialDto.Title
            });
            return Ok("Müşteri yorum bilgisi eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            _testimonialService.TDelete(value);
            return Ok("Müşteri yorum bilgisi silindi.");
        }
        [HttpGet("GetTestimonial")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialService.TUpdate(new Testimonial()
            {
                Comment = updateTestimonialDto.Comment,
                ImageUrl = updateTestimonialDto.ImageUrl,
                Name = updateTestimonialDto.Name,
                Status = updateTestimonialDto.Status,
                Title = updateTestimonialDto.Title
            });
            return Ok("Müşteri yorum bilgisi güncellendi.");
        }
    }
}
