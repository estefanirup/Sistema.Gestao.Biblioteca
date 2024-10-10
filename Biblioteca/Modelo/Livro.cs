using System;

namespace Biblioteca.Modelo;

public class Livro
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }
    public bool Disponivel { get; set; }

    public override string ToString()
    {
        string status;

        if (Disponivel)
        {
            status = "Disponível";
        }
        else
        {
            status = "Indisponível";
        }
        return $"[{Id}, {Titulo}, {Autor}, {Genero}, {status}]";
    }
}
