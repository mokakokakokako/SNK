using Microsoft.AspNetCore.Mvc;
using snk.Models;
namespace snk.Controllers;

[Route("api/technique")]
[ApiController]
public class TechniqueController : ControllerBase
{
    private List<Technique> Tech { get; set; }

    public TechniqueController()
    {
        Tech = new List<Technique>()
        {
            new Technique() {Id = 1, Type = "Phone", Producer ="Apple", Model = "Iphone 3G", Price = "270$"},
            new Technique() {Id = 2, Type = "Car", Producer ="Land Rover", Model = "Range Rover Defender", Price = "220000$"},
            new Technique() {Id = 3, Type = "Сhainsaw", Producer ="Alpine", Model = "TTX-145", Price = "400$"},
            new Technique() {Id = 4, Type = "TV", Producer ="LG", Model = "Full DTG MAX", Price = "1500$"},
            new Technique() {Id = 5, Type = "this could be your ad", Producer ="this could be your ad", Model = "this could be your ad", Price = "this could be your ad"}
        };
    }
    [HttpGet]
    public ActionResult GetAllTechnique()
    {
        return Ok(Tech);
    }
}