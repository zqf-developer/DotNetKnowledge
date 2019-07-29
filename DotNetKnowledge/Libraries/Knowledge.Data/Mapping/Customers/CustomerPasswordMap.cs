using Knowledge.Core.Domain.Customers;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Knowledge.Data.Mapping.Customers
{
    public partial class CustomerPasswordMap:KnowledgeEntityTypeConfiguration<CustomerPassword>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CustomerPassword> builder)
        {
            builder.ToTable(nameof(CustomerPassword));
            builder.HasKey(password => password.Id);

            builder.HasOne(password => password.Customer)
                .WithMany()
                .HasForeignKey(password => password.CustomerId)
                .IsRequired();

            builder.Ignore(password => password.PasswordFormat);

            base.Configure(builder);
        }

        #endregion
    }
}
