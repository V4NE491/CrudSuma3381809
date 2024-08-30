using SQLite;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudSuma3381809
{
    [SQLite.Table("Resultado")]
    public class Resultado
    {
        [PrimaryKey]
        [AutoIncrement]
        [SQLite.Column("id")]

        public int Id { get; set; }
        [SQLite.Column("numero1")]

        public string? Numero1 { get; set; }
        [SQLite.Column("numero1")]

        public string? Numero2 { get; set; }
        [SQLite.Column("suma")]

        public string? Suma { get; set; }
        
    }
}
