﻿namespace multitrabajos_security.Models
{
    public class Rol
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime Add {  get; set; }
        public virtual ICollection<User>? Usuarios { get; set; }

    }
}
