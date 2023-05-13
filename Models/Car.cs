using TerranovaCars.Utils;
using System.ComponentModel.DataAnnotations;

namespace TerranovaCars.Models;


public class Car {

    public int Id {get; set;}

    public string Marca {get;set;}

    public string Modelo {get;set;}

    public string Color {get;set;}

    public TipoDeCaja Caja {get;set;}

    public TipoDeCombustible Combustible {get;set;}

    public bool RuedaDeAuxilio {get;set;} = false;
    

}