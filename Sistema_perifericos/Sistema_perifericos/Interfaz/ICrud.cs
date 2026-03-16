using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_perifericos.Interfaz;

using System.Collections.Generic;

public interface ICrud<T>
{
    void Crear(T entidad);
    List<T> Leer();
    void Actualizar(int id, T entidad);
    void Eliminar(int id);
}