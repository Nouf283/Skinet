using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")] // https://localhost:5001/WeatherForecast
public class ProductsController : ControllerBase
{
    [HttpGet]
    public string GetProducts(){
        return "this will be a list of products!";
    }

    [HttpGet("{id}")]
    public string GetProduct(int id){
        return "this will be a products!";
    }
}
