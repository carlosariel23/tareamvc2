﻿using System;
using System.Collections.Generic;

namespace tareadatabasefirst.Models;

public partial class Servicio
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }
}
