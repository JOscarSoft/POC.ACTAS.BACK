using System;

namespace POC.ACTAS.BACK
{
    public class Contribuyente
    {
        public string rncCedula { get; set; }
        public int tipoPersona { get; set; }
        public int nacionalidad { get; set; }
        public int fechaCierreFiscal { get; set; }
        public DateTime fechaInicioOperaciones { get; set; }
        public int idCondicionInscripto { get; set; }
        public int idPais { get; set; }
        public int idAdministracionLocal { get; set; }
        public int idRegimenPago { get; set; }
        public object ideTributariaExtranjero { get; set; }
        public int idTamanoEmpresa { get; set; }
        public bool esGranContribuyente { get; set; }
        public bool esFranquicia { get; set; }
        public object tipoFranquicia { get; set; }
        public int idProveedorServicio { get; set; }
        public object noServicio { get; set; }
        public bool enProceso { get; set; }
        public DateTime fechaIncorporacion { get; set; }
        public Administracionlocal administracionLocal { get; set; }
        public Regimenpago regimenPago { get; set; }
        public Tamanoempresa tamanoEmpresa { get; set; }
        public Situacion situacion { get; set; }
        public Proveedorservicio proveedorServicio { get; set; }
        public Pais pais { get; set; }
        public Condicioninscripto condicionInscripto { get; set; }
        public Personafisica personaFisica { get; set; }
        public object personaJuridica { get; set; }
        public Informacionescomercial informacionesComercial { get; set; }
        public object[] regimenEspecial { get; set; }
        public object[] patrimonioEirl { get; set; }
        public object[] relacionesReorganizacion { get; set; }
        public object[] franquiciantes { get; set; }
        public Localidade[] localidades { get; set; }
        public object[] responsableSolidarios { get; set; }
        public object[] defaultContribuyenteActividadesEconomicas { get; set; }
        public object[] contactos { get; set; }
        public object[] fiscalDutiesSugestions { get; set; }
        public Situacioncontribuyente situacionContribuyente { get; set; }
        public object[] cambios { get; set; }
    }

    public class Administracionlocal
    {
        public int id { get; set; }
        public string nombre { get; set; }
    }

    public class Regimenpago
    {
        public int id { get; set; }
        public string descripcion { get; set; }
    }

    public class Tamanoempresa
    {
        public int id { get; set; }
        public string descripcion { get; set; }
    }

    public class Situacion
    {
        public int idSituacion { get; set; }
        public string descripcion { get; set; }
        public bool modificable { get; set; }
        public DateTime fechaInicio { get; set; }
        public object fechaFin { get; set; }
        public Motivo motivo { get; set; }
        public object fechaDesde { get; set; }
        public object fechaHasta { get; set; }
        public string usuarioIncorporacion { get; set; }
        public DateTime fechaIncorporacion { get; set; }
        public string usuarioModificacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public int idMotivoSituacion { get; set; }
    }

    public class Motivo
    {
        public int id { get; set; }
        public string descripcion { get; set; }
    }

    public class Proveedorservicio
    {
        public int id { get; set; }
        public string nombre { get; set; }
    }

    public class Pais
    {
        public int id { get; set; }
        public string nombre { get; set; }
    }

    public class Condicioninscripto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public bool estado { get; set; }
    }

    public class Personafisica
    {
        public string rncCedula { get; set; }
        public int idTipoIdentificacion { get; set; }
        public string nombres { get; set; }
        public object apellidos { get; set; }
        public int sexo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public object noPasaporte { get; set; }
        public object fechaVencimientoPasaporte { get; set; }
        public Tipoidentificacion tipoIdentificacion { get; set; }
    }

    public class Tipoidentificacion
    {
        public int id { get; set; }
        public string descripcion { get; set; }
    }

    public class Informacionescomercial
    {
    }

    public class Situacioncontribuyente
    {
        public int idSituacion { get; set; }
        public string descripcion { get; set; }
        public bool modificable { get; set; }
        public DateTime fechaInicio { get; set; }
        public object fechaFin { get; set; }
        public Motivo1 motivo { get; set; }
        public object fechaDesde { get; set; }
        public object fechaHasta { get; set; }
        public string usuarioIncorporacion { get; set; }
        public DateTime fechaIncorporacion { get; set; }
        public string usuarioModificacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public int idMotivoSituacion { get; set; }
    }

    public class Motivo1
    {
        public int id { get; set; }
        public string descripcion { get; set; }
    }

    public class Localidade
    {
        public int id { get; set; }
        public Tipolocalidad tipoLocalidad { get; set; }
        public Tipobanca tipoBanca { get; set; }
        public Tipodomicilio tipoDomicilio { get; set; }
        public Tipodireccion tipoDireccion { get; set; }
        public DateTime fecha { get; set; }
        public bool estado { get; set; }
        public object fuente { get; set; }
        public string rncCedula { get; set; }
        public string descripcion { get; set; }
        public int idTipoLocalidad { get; set; }
        public int valoracion { get; set; }
        public bool esPrincipal { get; set; }
        public DateTime fechaInicioOperaciones { get; set; }
        public int identifEstablecimiento { get; set; }
        public Direccion direccion { get; set; }
    }

    public class Tipolocalidad
    {
        public int id { get; set; }
        public string descripcion { get; set; }
    }

    public class Tipobanca
    {
        public int id { get; set; }
        public string descripcion { get; set; }
    }

    public class Tipodomicilio
    {
        public int id { get; set; }
        public string descripcion { get; set; }
    }

    public class Tipodireccion
    {
        public int id { get; set; }
        public string descripcion { get; set; }
    }

    public class Direccion
    {
        public int idSector { get; set; }
        public int idMunicipio { get; set; }
        public int idProvicia { get; set; }
        public string calle { get; set; }
        public object referencia { get; set; }
        public object departamento { get; set; }
        public object edificio { get; set; }
        public string numero { get; set; }
        public object codigoPostal { get; set; }
        public object sectorExtranjero { get; set; }
        public object provinciaExtranjero { get; set; }
        public object municipioExtranjero { get; set; }
        public Ubicaciongeografica ubicacionGeografica { get; set; }
    }

    public class Ubicaciongeografica
    {
        public int _long { get; set; }
        public int lat { get; set; }
    }
}
