using Knowledge.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knowledge.Data.Mapping
{
    public partial class KnowledgeEntityTypeConfiguration<TEntity> : IMappingConfiguration, IEntityTypeConfiguration<TEntity> where TEntity:BaseEntity
    {
        #region Utilities

        /// <summary>
        /// 开发人员可以在自定义部分类中重写此方法,以便添加一些自定义配置代码
        /// Developers can override this method in custom partial classes in order to add some custom configuration code
        /// </summary>
        /// <param name="builder">用于配置实体的生成器The builder to be used to configure the entity</param>
        protected virtual void PostConfigure(EntityTypeBuilder<TEntity> builder)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// 应用此映射配置
        /// </summary>
        /// <param name="modelBuilder">构建器用于构造数据库上下文的模型</param>
        public virtual void ApplyConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(this);
        }

        /// <summary>
        /// 配置TEntity类型的实体
        /// </summary>
        /// <param name="builder">用于配置实体类型的构建器.</param>
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            this.PostConfigure(builder);
        }

        #endregion
    }
}
