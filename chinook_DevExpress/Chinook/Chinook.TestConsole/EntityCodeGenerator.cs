using Chinook.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.TestConsole
{
    class EntityCodeGenerator
    {
        #region singleton
        private EntityCodeGenerator()
        {
        }

        private static EntityCodeGenerator _instance;

        public static EntityCodeGenerator Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EntityCodeGenerator();

                return _instance;
            }
        }
        #endregion

        public void GenerateData()
        {
            DbContext context = new ChinookEntities();

            List<string> entityNames = GetEntityNames(context);

            foreach (var entityName in entityNames)
            {
                string template = @"using MyLibrary;

namespace Chinook.Data
{{
    public class {0}Data : EntityData<{0}>
    {{
    }}
}}
";
                string code = string.Format(template, entityName);

                string filePath = $@"D:\sync\402R\sources\Chsarp\Chinook\Chinook.Data\Data\{entityName}Data.cs";

                if (File.Exists(filePath))
                    continue;

                File.WriteAllText(filePath, code);
            }
        }

        public void GenerateDataReposity()
        {
            DbContext context = new ChinookEntities();

            // public static AlbumData Album {get;} = new AlbumData();

            List<string> entityNames = GetEntityNames(context);

            StringBuilder builder = new StringBuilder();

            foreach (var entityName in entityNames)
            {
                string line = string.Format("public static {0}Data {0} {{get;}} = new {0}Data();", entityName);

                builder.AppendLine(line);
            }

            string code = builder.ToString();

        }

        private List<string> GetEntityNames(DbContext context)
        {
            Type type = context.GetType();
            PropertyInfo[] propertyInfos = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            List<string> entityNames = new List<string>();

            foreach (PropertyInfo pi in propertyInfos)
            {
                if (pi.PropertyType.Name.StartsWith("DbSet") == false)
                    continue;

                string entityName = pi.PropertyType.GenericTypeArguments[0].Name;

                if (entityName.Contains("_"))
                    continue;

                entityNames.Add(entityName);
            }

            return entityNames;
        }
    }
}
