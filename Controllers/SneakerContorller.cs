using Microsoft.AspNetCore.Mvc;
using snk.Models;
namespace snk.Controllers;

[Route("api/sneakers")]
[ApiController]
public class SneakerContoller : ControllerBase
{
    private List<Sneaker> Sneakers { get; set; }

    public SneakerContoller()
    {
        Sneakers = new List<Sneaker>()
        {
            new Sneaker() {Id = 1, Brand = "Nike", Model = "Air Force 1", Collab = "Stussy"},
            new Sneaker() {Id = 2, Brand = "Nike x Jordan", Model ="Jordan 1", Collab = "Travis Scott"},
            new Sneaker() {Id = 3, Brand = "New Balance", Model ="990v3", Collab = "jjjjound"},
            new Sneaker() {Id = 4, Brand = "Adidas", Model ="Campus", Collab = "-"},
            new Sneaker() {Id = 5, Brand = "Reebok", Model ="Instapump fury", Collab = "Vetements"}
        };
    }
    [HttpGet]
    public ActionResult GetAllSneakers()
    {
        return Ok(Sneakers);
    }
}
