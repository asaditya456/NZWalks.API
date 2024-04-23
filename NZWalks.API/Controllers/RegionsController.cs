using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        public IActionResult GetAll()
        {
            var regions = new List<Region>
            {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Auckland Region",
                    Code = "AKL",
                    RegionImageUrl = "https://www.pexels.com/photo/wildlife-photography-of-elephant-during-golden-hour-1054655/"

                 },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Wellington Region",
                    Code = "Wlg",
                    RegionImageUrl = "https://www.pexels.com/photo/brown-elephant-913658/"
                }
                 };
            return Ok(regions);

            }

        }
    }
