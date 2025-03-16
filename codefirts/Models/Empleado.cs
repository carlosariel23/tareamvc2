namespace codefirts.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Empleado
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(15)]
        public string Telefono { get; set; }

        [StringLength(10)]
        public string DUI { get; set; }

        [StringLength(200)]
        public string Direccion { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }

    public class Alumno
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(20)]
        public string Codigo { get; set; }

        [StringLength(200)]
        public string Direccion { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        public short YearEstudio { get; set; }
    }

}
