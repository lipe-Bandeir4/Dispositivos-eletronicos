using Microsoft.AspNetCore.Components.Web;

namespace Dispositivos_eletronicos.Models
{
    public class Computador : DispositivoEletronico
    {
        public bool Ehlaptop { get; set; }

        public int MemoriaRam { get; set; }

        public string SistemOperacional { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {AnoDeFabricacao},, SO: {SistemOperacional}";
        }
    }
}
