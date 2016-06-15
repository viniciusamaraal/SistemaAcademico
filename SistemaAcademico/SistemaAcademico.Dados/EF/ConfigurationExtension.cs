using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dados.EF
{
    public static class ConfigurationExtension
    {
        public static T HasIndex<T>(this T configPropriedade, string name = null, bool isUnique = false, bool isClustered = false) where T : PrimitivePropertyConfiguration
        {
            var atributo = string.IsNullOrEmpty(name) ? new IndexAttribute() : new IndexAttribute(name);
            atributo.IsUnique = isUnique;
            atributo.IsClustered = isClustered;

            return (T)configPropriedade.HasColumnAnnotation("Index", new IndexAnnotation(atributo));
        }

        public static T IsUnique<T>(this T propertyConfig, string name = null, bool isClustered = false) where T : PrimitivePropertyConfiguration
        {
            return HasIndex(propertyConfig, name, true, isClustered);
        }

        // TODO: Método desnecessário, mas interessante de ser criado para uso em outros lugares.
        //public static TEstrutura HasIndex<TEstrutura, TEntidade>(this TEstrutura asd, propriedades) where TEstrutura : StructuralTypeConfiguration<TEntidade> where TEntidade : class
        //{
        //}
    }
}
