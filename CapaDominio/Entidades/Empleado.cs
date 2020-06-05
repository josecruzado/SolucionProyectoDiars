using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class Empleado
    {
        private String direccion;
        private String dni;
        private String fechaDeNacimiento;
        private String gradoAcademico;
        private String nombre;
        private String telefono;

        public void setDireccion(String direccion)
        {
            this.direccion = direccion;
        }
        public String getDireccion()
        {
            return direccion;
        }
        public void setDni(String dni)
        {
            this.dni = dni;
        }
        public String getDni()
        {
            return dni;
        }
        public void setFechaDeNacimiento(String fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        public  void setGradoAcademico(String gradoAcademico)
        {
            this.gradoAcademico = gradoAcademico;
        }
        public String getGradoAcademico()
        {
            return this.gradoAcademico;
        }
        public void setNombre (String nombre)
        {
            this.nombre = nombre;
        }
        public String getNombre()
        {
            return nombre
        }
        public void setTelefono(String telefono)
        {
            this.telefono = telefono;
        }
        public String getTelefono()
        {
            return telefono;
        }

    }
}
