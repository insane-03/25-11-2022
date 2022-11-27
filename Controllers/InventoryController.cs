using Flopkart.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;


namespace Flopkart.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        public InventoryController() 
        {
           new  List<InventoryModel>(){
           new InventoryModel(){ ProductId = 001, ProductName = "Uphone", ProductDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." },
           new InventoryModel(){ ProductId = 002, ProductName = "BacBook", ProductDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." },
           new InventoryModel(){ ProductId = 003, ProductName = "Uwatch", ProductDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." },
           new InventoryModel(){ ProductId = 004, ProductName = "AacBook", ProductDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." },
           new InventoryModel(){ ProductId = 005, ProductName = "Sphone", ProductDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." },
           new InventoryModel(){ ProductId = 006, ProductName = "Swatch", ProductDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." },
        };
        }

        public static ArrayList Id = new ArrayList() {001, 002, 003, 004, 005 };
        public static ArrayList Name = new ArrayList() { "Uphone", "Uphone", "Uphone", "Uphone", "Uphone" };
        public static ArrayList Description = new ArrayList() { "Lorem Ipsum is simply", "Lorem Ipsum is simply",
        "Lorem Ipsum is simply","Lorem Ipsum is simply","Lorem Ipsum is simply",
        };


        [HttpGet("/all")]
        public void GetAllProducts()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"id:{Id[i]}\nname:{Name[i]}\ndescription:{Description[i]}");
            }
        }

        [HttpGet("/{i}")]
        public void GetProduct(int i)
        {
           
           Console.WriteLine($"id:{Id[i]}\nname:{Name[i]}\ndescription:{Description[i]}");
         
        }

        [HttpPost("/{i}/{j}/{k}")]
        public void PostProduct(int i, string j, string k)
        {
            Id.Add(i);
            Name.Add(j);
            Description.Add(k);
        }


        [HttpPut("/{id}/{i}/{j}/{k}")]
        public void PutProduct(int id,int i, string j, string k)
        {
            Id[id] = i;
            Name[id] = j;
            Description[id] = k;
        }

        [HttpDelete("/{i}")]
        public void DeleteProduct(int i)
        {

            Id.Remove(i);
            Name.Remove(i);
            Description.Remove(i);

        }
    }
}
