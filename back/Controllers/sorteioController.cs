using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace sorteio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SorteioController : ControllerBase
    {
        public IEnumerable<Sorteio> _Sorteio = new Sorteio[] {

            new Sorteio() {Nome="Oliver Ricardo Ribeiro",cpf="925.091.645-03",DataNascimento="24/03/1980",Renda="2000.00",Cota="GERAL",CID=""},
            new Sorteio() {Nome="Lavínia Mariah Jennifer dos Santos", cpf="843.831.525-97",DataNascimento="5//0//5.00",Renda="1045",Cota="GERAL",CID=""},
            new Sorteio() {Nome="Sabrina Luna Laís Cavalcanti", cpf="945.553.979-91",DataNascimento="26/11/1971",Renda="3000.00",Cota="DEIFICENTE FÍSICO",CID="H90"},
            new Sorteio() {Nome="Hugo Manuel Novaes", cpf="239.964.398-49",DataNascimento="19/10/1971",Renda="7850.00",Cota="GERAL",CID=""},
            new Sorteio() {Nome="Ana Brenda Esther Ramos", cpf="840.216.806-56",DataNascimento="23/08/2.50",Renda="DEIFICENTE FÍSICO",Cota="H90",CID=""},
            new Sorteio() {Nome="Sérgio Vinicius Barros", cpf="479.893.965-05",DataNascimento="4///1/1956",Renda="5225.00",Cota="IDOSO",CID=""},
            new Sorteio() {Nome="Bruno Levi Dias", cpf="053.246.187-80",DataNascimento="13/09/1941",Renda="2500.00",Cota="IDOSO",CID=""},
            new Sorteio() {Nome="Tomás João Moreira", cpf="358.414.793-00",DataNascimento="26/10/1940",Renda="998.00",Cota="IDOSO",CID=""},
            new Sorteio() {Nome="Severino Igor Mário Barros", cpf="958.617.790-40",DataNascimento="21/02/1994",Renda="4000.00",Cota="DEIFICENTE FÍSICO",CID="H90"},
            new Sorteio() {Nome="Malu Emilly Pinto", cpf="071.865.388-27",DataNascimento="19/09/2002",Renda="39000.00",Cota="GERAL",CID=""},
            new Sorteio() {Nome="Giovanna Gabriela da Mota", cpf="735.196.008-97",DataNascimento="18/12/1995",Renda="1250.00",Cota="GERAL",CID=""},
            new Sorteio() {Nome="Eduardo Gael Cardoso", cpf="737.055.718-93",DataNascimento="11/3//1977",Renda="5225.99",Cota="DEIFICENTE FÍSICO",CID=""},
            new Sorteio() {Nome="Heitor Kauê Martins", cpf="005.517.108-00",DataNascimento="22/06/1986",Renda="3000.58",Cota="GERAL",CID=""},
            new Sorteio() {Nome="Rebeca Rita Moura", cpf="325.541.788-01",DataNascimento="26/08/1981",Renda="1250.98",Cota="DEIFICENTE FÍSICO",CID=""},
            new Sorteio() {Nome="Rodrigo Sebastião Araújo", cpf="785.118.978-01",DataNascimento="20/05/1958",Renda="6000.79",Cota="DEIFICENTE FÍSICO",CID="H90"},
            new Sorteio() {Nome="Leandro Gustavo Viana", cpf="411.601.448-69",DataNascimento="26/04/1945",Renda="10999.99",Cota="GERAL",CID=""},
            new Sorteio() {Nome="Letícia Rita Ferreira", cpf="025.500.928-39",DataNascimento="13/03/1956",Renda="3675.64",Cota="IDOSO",CID=""},
            new Sorteio() {Nome="Kaique Calebe Almeida", cpf="128.021.648-48",DataNascimento="27/04/1972",Renda="4488.48",Cota="GERAL",CID=""},
            new Sorteio() {Nome="Raul Emanuel Araújo", cpf="531.380.488-03",DataNascimento="16/12/1985",Renda="4567.45",Cota="IDOSO",CID=""},
            new Sorteio() {Nome="Allana Marina Mariane Alves", cpf="887.969.268-21",DataNascimento="9//1//1980",Renda="5454.55",Cota="GERAL",CID=""},
        };
        public SorteioController()
        {
        }

        [HttpGet]
        public IEnumerable<Sorteio> Get()
        {
            return _Sorteio;
        }

        [HttpGet("{cota}")]
        public IEnumerable<Sorteio> GetById(string cota)
        {
            return _Sorteio.Where(Sorteio => Sorteio.Cota == cota);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "Exemplo de Put";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return  "Exemplo de Delete";
        }
    }
}
