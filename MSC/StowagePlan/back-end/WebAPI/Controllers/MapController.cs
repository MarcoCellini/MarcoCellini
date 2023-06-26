using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Text.Json;

namespace WebAPI.Controllers
{
    [Route("api/container")]      //     http://localhost:5000/api/container/
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("GetMap")]
        public string GetMap(int x, int y, int z, float size, [FromQuery] float[] weight, [FromQuery] int[] discharge)
        {
            Test.Program p = new Test.Program(x, y, z, size);
            int[,,] mat = p.ex1(weight, discharge);
            return JsonConvert.SerializeObject(mat);
        }

        public class cell
        {
            public int discharge { get; set; }
            public float weight { get; set; }
            public float dimension { get; set; }
        }

        [HttpPost("GetStowagePlan")]
        public string GetStowagePlan(int x, int y, int z, [FromBody] List<cell> cellList)
        {
            float[] tons = new float[x * y * z];
            int[] priority = new int[x * y * z];
            
            for (int i = 0; i < x * y * z; i++)
            {
                tons[i] = cellList[i].weight;
                priority[i] = cellList[i].discharge;
            }

            Test.Program p = new Test.Program(x, y, z, cellList[0].dimension);
            int[,,] mat = p.ex1(tons, priority);
            string json = JsonConvert.SerializeObject(mat);

            string[] layers = json.Split("]],");
            string[] row;
            string final = "Stowage plan by container IDs:\n";
            int cont = 1;
            foreach (string layer in layers)
            {
                final += $"Layer {cont++}\n";
                row =  layer.Trim(new Char[] { '[', ']' }).Split("],");
                foreach (string r in row)
                {
                    final += r.Trim(new Char[] { '[', ']' }) + "\n";
                }
                final += "\n";
            }
            final = final.Replace(',', '\t');
            return final;
        }
    }
}