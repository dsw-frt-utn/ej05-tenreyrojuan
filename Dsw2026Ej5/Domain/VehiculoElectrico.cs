using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej5.Domain;

public class VehiculoElectrico : Vehiculo
{
    private double kwhBase;
    private double capacidadCarga;

    public VehiculoElectrico(string patente, string marca, string modelo, int anio, double capacidadCarga, 
        Sucursal sucursal, double kwhBase) : base(VehiculoTipo.Electrico, patente, marca, modelo, anio, capacidadCarga, sucursal)
    {
        this.kwhBase = kwhBase;
        this.capacidadCarga = capacidadCarga;
    }

    public double GetKwhBase()
    {
        return kwhBase;
    }

    public override double CalcularConsumo(double kilometros)
    {
        if(capacidadCarga >= 1200) return kwhBase * 1.15;
        return kwhBase;
    }
}
