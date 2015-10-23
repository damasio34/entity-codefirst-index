using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace EntityCodeFirstIndex
{
    public class ClienteTypeConfigurantion : EntityTypeConfiguration<Cliente>
    {
        public ClienteTypeConfigurantion()
        {
            HasKey(p => p.Id);
            
            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName, 
                    new IndexAnnotation(new IndexAttribute("NomeCliente", 1) {IsUnique = true}));
            
            Property(p => p.Sobrenome)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("NomeCliente", 2)));
        }
    }
}
