using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebadeEntitiesFramework_11_11_22
{
    public class DatosClientes
    {
        public int IdCliente { get; set; }
        public string Categoria { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }

        public static string name;
        public static string pass;

        static public SistemaEntities conecta(EntityConnection ec)
        {
            EntityConnectionStringBuilder ecs = new EntityConnectionStringBuilder();
            ecs.Provider = "System.Data.SqlClient";
            ecs.ProviderConnectionString = "data source=KENNETH\\SQLSERVER2019;initial catalog=Cliente;persist security info=True;user id=SistemaAdminTarea;password=sistemas2022;MultipleActiveResultSets=True;App=EntityFramework";
            ecs.Metadata = "res://*/ModelDB.ssdl|res://*/ModelDB.msl";
            SistemaEntities se = new SistemaEntities(ecs.ToString());
            return se;
        }
    }
}
